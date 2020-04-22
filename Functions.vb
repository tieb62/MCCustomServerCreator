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

End Module
