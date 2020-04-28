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

    Private Sub MissingVersion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MissingVersion.LinkClicked
        'TODO: Ouvrir l'aide "Une Version Manque ?"
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        'Si c'est le premier élément qui est sélectionné (Dernière Version) on build "latest" sinon on build la version sélectionnée
        If SpigotVersionsListBox.SelectedIndex = 0 Then
            Downloader.BuildSpigot("latest", Me, ServerProperties)
        Else
            Downloader.BuildSpigot(SpigotVersionsListBox.SelectedItem.ToString(), Me, ServerProperties)
        End If
    End Sub

    Private Sub SpigotVersionsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SpigotVersionsListBox.SelectedIndexChanged
        If SpigotVersionsListBox.SelectedItems.Count > 0 Then
            NextBtn.Enabled = True
        Else
            NextBtn.Enabled = False
        End If
    End Sub
End Class