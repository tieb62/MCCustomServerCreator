Public Class ServerType


    Private Sub SpongeRadio_CheckedChanged(sender As Object, e As EventArgs) Handles SpongeRadio.CheckedChanged
        If SpongeRadio.Checked Then
            MsgBox("Attention !" + vbNewLine + "Sponge est un MOD, cela aura donc pour effet de créer un serveur Forge." + vbNewLine + "Seuls les plugins fournis par Sponge pourront être installés !", vbOKOnly + vbExclamation + 4096, "Avertissement")
        End If
    End Sub

    Private Sub Suivant_Click(sender As Object, e As EventArgs) Handles Suivant.Click
        If VanillaRadio.Checked Then
            Informations.ServerType = ServerTypes.VANILLA
        ElseIf SpigotRadio.Checked Then
            Informations.ServerType = ServerTypes.SPIGOT
        ElseIf ForgeRadio.Checked Then
            Informations.ServerType = ServerTypes.FORGE
        ElseIf SpongeRadio.Checked Then
            Informations.ServerType = ServerTypes.SPONGE
        End If
        Me.Close()
        SelectServerDir.Show()
    End Sub
End Class