Public Class SelectServerDir
    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        SelectDir.ShowDialog()
        ServerPath.Text = SelectDir.SelectedPath
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        If System.IO.Directory.Exists(ServerPath.Text.Trim()) Then
            Informations.ServerDir = ServerPath.Text.Trim()
            'Redirection vers la bonne fenêtre selon le type de Serveur choisi précédemment (Vanilla, Forge, Spigot, Sponge)
            Select Case Informations.ServerType
                Case ServerTypes.VANILLA
                    Me.Hide()
                    Vanilla.Show()

                Case ServerTypes.SPIGOT
                    Me.Hide()
                    Spigot.Show()

                Case ServerTypes.FORGE

                Case ServerTypes.SPONGE

            End Select
        Else
            MsgBox("Le chemin d'accès spécifié n'existe pas !", vbOKOnly + vbCritical + 4096, "Erreur")
        End If
    End Sub

    Private Sub ServerPath_KeyUp(sender As Object, e As KeyEventArgs) Handles ServerPath.KeyUp
        If e.KeyCode = Keys.Enter Then
            NextBtn.PerformClick()
        End If
    End Sub

    Private Sub SelectServerDir_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ConfirmClose(e)
    End Sub
End Class