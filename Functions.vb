Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation

Module Functions

    Public Function CheckInternet() As Boolean

        Try
            Return My.Computer.Network.Ping("www.google.com")
            My.Application.Log.WriteEntry("Check connection : Connecté à Internet")
        Catch ex As PingException
            Return False
            My.Application.Log.WriteEntry("Check connection : échoué : non connecté à internet")
        End Try

    End Function

    Public Sub ConfirmClose(ByRef e As FormClosingEventArgs)
        If Not e.CloseReason = CloseReason.ApplicationExitCall Then
            Dim ConfirmResult As MsgBoxResult = MsgBox("Voulez-vous vraiment arrêter toute opération en cours et fermer MC Custom Server Creator ?" + vbNewLine + "Cela pourrait entraîner une perte de données !", vbYesNo + vbExclamation + 4096, "Attention !")
            If ConfirmResult.Equals(MsgBoxResult.Yes) Then
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Public Sub DownloadFile(ByVal url As String, ByVal downloadPath As String)
        Try
            If File.Exists(downloadPath) Then
                File.Delete(downloadPath)
            End If
            My.Computer.Network.DownloadFile(url, downloadPath)
#Disable Warning CA1031 ' Do not catch general exception types
        Catch ex As Exception
            MsgBox("Une erreur est survenue : " + ex.Message, vbCritical + vbOKOnly + 4096, "Erreur")
#Enable Warning CA1031 ' Do not catch general exception types
        End Try
    End Sub

    Public Function ExtractRessource(ByVal ressource As Object, ByVal path As String) As Boolean
        Try
            My.Computer.FileSystem.WriteAllBytes(path, ressource, False)
            Return True
        Catch ex As Exception
            Throw New Exception("Impossible d'extraire la Ressource " + ressource.ToString + " !", ex)
            Return False
        End Try
    End Function
End Module
