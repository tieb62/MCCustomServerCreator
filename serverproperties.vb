Public Class ServerProperties
    Public generatorsettings As String
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles defaultfile.CheckedChanged
        If defaultfile.Checked = True Then
            options.Enabled = False

        Else

            options.Enabled = True

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles hardcore.CheckedChanged
        If hardcore.Checked Then

            defaultgamemode.Enabled = False
            survival.Checked = True
            peaceful.Enabled = False
            easy.Enabled = False
            normal.Enabled = False
            hard.Enabled = False
            hard.Checked = True

        Else
            defaultgamemode.Enabled = True
            peaceful.Enabled = True
            easy.Enabled = True
            normal.Enabled = True
            hard.Enabled = True

        End If
    End Sub

    Private Sub Serverproperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        leveltype.SelectedItem = leveltype.Items(0)

    End Sub

    Private Sub Serverproperties_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        MsgBox("Attention !" & vbNewLine & "Certaines option ne peuvent pas être effectives dans le jeu car certaines versions n'ont pas les mêmes propriétés (des propriétés en moins ou en plus)" & vbNewLine & vbNewLine & "Ne vous inquiétez donc pas si certaines propriétés que vous avez modifié sur cette page ne sont pas effectives dans le jeu !", MsgBoxStyle.Exclamation + vbOKOnly + 4096, "Avertissement !")

    End Sub

    Private Sub CheckBox2_CheckedChanged_1(sender As Object, e As EventArgs) Handles whitelist.CheckedChanged

        If whitelist.Checked = True Then

            forcewhitelist.Enabled = True

        Else

            forcewhitelist.Enabled = False
            forcewhitelist.Checked = False

        End If

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles levelname.Click

        MsgBox("Les caractères telles que les ' (apostrophe) doivent avoir un caractère d’échappement devant (par exemple, l'adorable devient l\'adorable).", vbOKOnly + MsgBoxStyle.Exclamation + 4096, "Avertissement")

    End Sub

    Private Sub Enablequery_CheckedChanged(sender As Object, e As EventArgs) Handles enablequery.CheckedChanged, CheckBox4.CheckedChanged, CheckBox3.CheckedChanged, CheckBox2.CheckedChanged, CheckBox1.CheckedChanged

        If enablequery.Checked = True Then

            queryport.Enabled = True

        Else

            queryport.Enabled = False

        End If

    End Sub

    Private Sub Leveltype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles leveltype.SelectedIndexChanged


        Select Case leveltype.SelectedItem

            Case "Monde SuperFlat"

                levelpersonnalise.Enabled = True

            Case "Personnalisé"

                levelpersonnalise.Enabled = True

            Case Else

                levelpersonnalise.Enabled = False

        End Select

    End Sub

    Private Sub Levelpersonnalise_Click(sender As Object, e As EventArgs) Handles levelpersonnalise.Click

        Select Case leveltype.SelectedItem

            Case "Monde SuperFlat"

            Case "Personnalisé"

        End Select

    End Sub
End Class