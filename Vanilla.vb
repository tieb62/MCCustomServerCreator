Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class Vanilla
    'Création du Dictionnaire contenant la liste des versions et leurs liens
    Public Versions As New Dictionary(Of String, String)

    Private Sub Vanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateVersionList()
    End Sub

    Private Sub UpdateVersionList()
        If CheckInternet() Then
            If File.Exists(Informations.ManifestDownloadPath) Then
                File.Delete(Informations.ManifestDownloadPath)
            End If
            Try
                My.Computer.Network.DownloadFile(Informations.ManifestURL, Informations.ManifestDownloadPath)
#Disable Warning CA1031 ' Do not catch general exception types
            Catch ex As Exception
                MsgBox("Une erreur est survenue lors de l'obtention de la liste des versions :" + vbNewLine + ex.Message, vbOKOnly + vbCritical + 4096, "Erreur")
#Enable Warning CA1031 ' Do not catch general exception types
            End Try
            Dim VersionManifestJSON As String = File.ReadAllText(Informations.ManifestDownloadPath)


            Dim obj As JObject = JObject.Parse(VersionManifestJSON)

            VersionsList.BeginUpdate()

            Dim VersionsJSON = obj("versions").ToList()
            For Each VersionJSON As JToken In VersionsJSON
                Dim VersionObj As JObject = JObject.Parse(VersionJSON.ToString())
                Dim versionInfo As New ListViewItem
                Dim VersionName As String
                Dim VersionLink As String
                For Each version As JProperty In VersionObj.Children()
                    version.CreateReader()
                    Select Case version.Name
                        Case "id"
                            versionInfo.Text = version.Value
                            VersionName = version.Value
                        Case "type"
                            versionInfo.SubItems.Add(version.Value)
                        Case "url"
                            VersionLink = version.Value
                    End Select
                Next
                VersionsList.Items.Add(versionInfo)
#Disable Warning BC42104 ' La variable est utilisée avant de se voir attribuer une valeur
                Versions.Add(VersionName, VersionLink)
#Enable Warning BC42104 ' La variable est utilisée avant de se voir attribuer une valeur
            Next
            VersionsList.EndUpdate()
            VersionsList.Update()
        Else
            MsgBox("Pas d'accès internet !", vbOKOnly + vbCritical + 4096, "Erreur")
        End If
    End Sub

    Private Sub VersionsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VersionsList.SelectedIndexChanged
        If VersionsList.SelectedItems.Count = 1 Then
            NextBtn.Enabled = True
        Else
            NextBtn.Enabled = False
        End If
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        Downloader.DownloadVanillaServer(VersionsList.SelectedItems.Item(0).Text, Me, Eula)
    End Sub
End Class