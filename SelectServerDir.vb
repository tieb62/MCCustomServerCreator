Public Class SelectServerDir
    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        ServerPath.Text = SelectDir.ShowDialog()
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        If System.IO.Directory.Exists(ServerPath.Text.Trim()) Then
            Informations.ServerDir = ServerPath.Text.Trim()
        Else
            MsgBox("Le chemin d'accès spécifié n'existe pas !", vbOKOnly + vbCritical + 4096, "Erreur")
        End If
    End Sub
End Class