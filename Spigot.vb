Imports System.IO

Public Class Spigot
    Private Sub Spigot_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ConfirmClose(e)
    End Sub

    Private Sub Spigot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CheckInternet() Then
            DownloadFile(SpigotVersionsURL, SpigotVersionsDownloadPath)
            Dim ListSpigotVersionsReader = File.ReadAllLines(SpigotVersionsDownloadPath)
            For Each SpigotVersion As String In ListSpigotVersionsReader
                SpigotVersionsListBox.Items.Add(SpigotVersion)
            Next
        Else
                MsgBox("Aucune connection internet détectée !", vbCritical + vbOKOnly + 4096, "Erreur")
            Application.Exit()
        End If
    End Sub
End Class