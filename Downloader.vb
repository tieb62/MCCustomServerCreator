Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class Downloader
    Public Async Sub DownloadVanillaServer(ByVal VersionName As String, ByVal Invoker As Form, ByVal NextForm As Form)
        'On masque le Formulaire qui a appelé la Fonction et on affiche ce Formulaire
        Invoker.Hide()
        Me.Show()
        InfoLabel.Text = "Searching " + VersionName + " ..."

        'On récupère le lien de téléchargement du server.jar
        Dim VersionURL As String = Vanilla.Versions(VersionName)
        Dim DownloadPath As String = Informations.TempPath + "\" + VersionName + ".json"
        If File.Exists(DownloadPath) Then
            File.Delete(DownloadPath)
        End If
        My.Computer.Network.DownloadFile(VersionURL, DownloadPath)

        Dim VersionJSON As String = File.ReadAllText(DownloadPath)

        Dim Obj As JObject = JObject.Parse(VersionJSON)
        Dim Downloads = Obj("downloads").ToList()
        Dim DownloadLink As String
        For Each Download As JProperty In Downloads
            Download.CreateReader()
            If Download.Name = "server" Then
                Dim DownloadObj As JObject = JObject.Parse(Download.Value.ToString())
                DownloadLink = DownloadObj("url").ToString()
            End If
        Next

        'On télécharge le server.jar
        InfoLabel.Text = "Downloading server.jar..."
        DownloadBar.Style = ProgressBarStyle.Continuous
        Dim Client As New WebClient
        AddHandler Client.DownloadProgressChanged, AddressOf Client_ProgressChanged

        If File.Exists(Informations.ServerDir + "\server.jar") Then
            File.Delete(Informations.ServerDir + "\server.jar")
        End If

#Disable Warning BC42104 ' La variable est utilisée avant de se voir attribuer une valeur
        Await Client.DownloadFileTaskAsync(New Uri(DownloadLink), Informations.ServerDir + "\server.jar")
#Enable Warning BC42104 ' La variable est utilisée avant de se voir attribuer une valeur

        InfoLabel.Text = "Téléchargement terminé !"

        'On à fini le Téléchargement, on affiche le Formulaire suivant et on cache ce Formulaire
        NextForm.Show()
        Me.Hide()
    End Sub

    Private Sub Client_ProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        DownloadBar.Value = e.ProgressPercentage
    End Sub

    Private Sub Downloader_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ConfirmClose(e)
    End Sub
End Class