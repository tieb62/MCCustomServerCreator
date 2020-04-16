Public Class ServerType
    Public ServerType As String
    'Définition des constantes de type de serveur
    Public ReadOnly VANILLA As String = "Vanilla"
    Public ReadOnly SPIGOT As String = "Spigot"
    Public ReadOnly FORGE As String = "Forge"
    Public ReadOnly SPONGE As String = "Sponge"

    Private Sub SpongeRadio_CheckedChanged(sender As Object, e As EventArgs) Handles SpongeRadio.CheckedChanged
        If SpongeRadio.Checked Then
            MsgBox("Attention !" + vbNewLine + "Sponge est un MOD, cela aura donc pour effet de créer un serveur Forge." + vbNewLine + "Seuls les plugins fournis par Sponge pourront être installés !", vbOKOnly + vbExclamation + 4096, "Avertissement")
        End If
    End Sub
End Class