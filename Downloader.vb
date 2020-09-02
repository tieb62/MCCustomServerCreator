Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class Downloader

    Public Async Sub DownloadVanillaServer(ByVal VersionName As String, ByVal Invoker As Form, ByVal NextForm As Form)
        'On masque le Formulaire qui a appelé la Fonction et on affiche ce Formulaire
        Invoker.Hide()
        Me.Show()
        InfoLabel.Text = "Recherche de la " + VersionName + " ..."
        Me.Text = "Recherche de la " + VersionName + " ..."

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
        InfoLabel.Text = "Téléchargement du server.jar..."
        Me.Text = "Téléchargement du server.jar..."
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
        Me.Text = "Téléchargement terminé !"

        'On à fini le Téléchargement, on affiche le Formulaire suivant et on cache ce Formulaire
        NextForm.Show()
        Me.Hide()
    End Sub

    Private Sub Client_ProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        Dim incrementValue As Integer = e.ProgressPercentage - DownloadBar.Value
        DownloadBar.Increment(incrementValue)
    End Sub

    Private Sub Downloader_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ConfirmClose(e)
    End Sub

    Public Async Sub BuildSpigot(ByVal VersionName As String, ByVal Invoker As Form, ByVal NextForm As Form)
        'On cache le formulaire appelant et on affiche ce formulaire
        Invoker.Hide()
        Me.Show()

        'On vide le dossier de compilation si il contient des fichiers

        InfoLabel.Text = "Vidage du dossier de compilation..."
        Me.Text = "Vidage du dossier de compilation..."
        DownloadBar.Style = ProgressBarStyle.Marquee
        DownloadBar.Value = 0

        If Directory.GetFileSystemEntries(Informations.SpigotBuildPath).Count() > 0 Then
            For Each DirectoryString As String In Directory.GetDirectories(Informations.SpigotBuildPath)
                Directory.Delete(DirectoryString, True)
            Next
            For Each FileString As String In Directory.GetFiles(Informations.SpigotBuildPath)
                File.Delete(FileString)
            Next
        End If

        'On Télécharge BuildTools.jar
        InfoLabel.Text = "Extraction de BuildTools.jar"
        Me.Text = "Extraction de BuildTools.jar"
        DownloadBar.Style = ProgressBarStyle.Marquee
        DownloadBar.Value = 0

        ExtractRessource(My.Resources.BuildTools, Informations.SpigotBuildToolsPath)

        'On Vérifie l'installation de Java
        InfoLabel.Text = "Vérification de l'installation de Java..."
        Me.Text = "Vérification de l'installation de Java..."
        DownloadBar.Style = ProgressBarStyle.Marquee
        DownloadBar.Value = 0

        Dim checker As JavaChecker = New JavaChecker
        Await checker.AsyncCheck()
        Select Case checker.CurrentStatus
            Case JavaChecker.JavaStatus.NOT_INSTALLED
                MsgBox("Aucune installation de Java n'a été trouvée sur votre système !" + vbNewLine + "Installez Java et réessayez !", vbCritical + vbOKOnly, "Erreur")
                Application.Exit()
            Case JavaChecker.JavaStatus.VERIFY_ERROR
                MsgBox("Une Erreur est survenue durant la vérification de votre installation de Java," + vbNewLine + "Veuillez réessayer, si le problème persiste, ouvrez une Issue sur le GitHub", vbOKOnly + vbCritical, "Erreur")
                Application.Exit()
        End Select

        'On Build la Version de Spigot demandé dans le VersionName
        InfoLabel.Text = "Compilation de Spigot " + VersionName
        Me.Text = "Compilation de Spigot " + VersionName
        DownloadBar.Style = ProgressBarStyle.Marquee
        DownloadBar.Value = 0

        Dim BuildProcess As Process = New Process
        BuildProcess.StartInfo.WorkingDirectory = Informations.SpigotBuildPath
        BuildProcess.StartInfo.FileName = "java"
        BuildProcess.StartInfo.Arguments = "-jar BuildTools.jar --rev " + VersionName
        BuildProcess.Start()
        BuildProcess.WaitForExit()
        If (Not BuildProcess.ExitCode = 0) Then
            MsgBox("Erreur durant la compilation, veuillez rééssayer, si le problème persiste, contactez les développeurs", vbOKOnly + vbCritical + 4096, "Erreur")
            Application.Exit()
        End If
        MsgBox("Compilation réussie !", vbOKOnly + vbInformation + 4096, "Succès")
        'À la fin on cache ce formulaire et on affiche le formulaire suivant
        Me.Hide()
        NextForm.Show()
    End Sub
End Class