<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ServerType
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.rien = New System.Windows.Forms.RadioButton()
        Me.modsbutton = New System.Windows.Forms.RadioButton()
        Me.pluginsbutton = New System.Windows.Forms.RadioButton()
        Me.les2button = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Suivant = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rien
        '
        Me.rien.Checked = True
        Me.rien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rien.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rien.Location = New System.Drawing.Point(18, 59)
        Me.rien.Name = "rien"
        Me.rien.Size = New System.Drawing.Size(548, 41)
        Me.rien.TabIndex = 0
        Me.rien.TabStop = True
        Me.rien.Text = "Serveur Vanilla"
        Me.rien.UseMnemonic = False
        Me.rien.UseVisualStyleBackColor = True
        '
        'modsbutton
        '
        Me.modsbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modsbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modsbutton.Location = New System.Drawing.Point(18, 148)
        Me.modsbutton.Name = "modsbutton"
        Me.modsbutton.Size = New System.Drawing.Size(548, 43)
        Me.modsbutton.TabIndex = 1
        Me.modsbutton.Text = "Serveur Moddé (Forge)"
        Me.modsbutton.UseVisualStyleBackColor = True
        '
        'pluginsbutton
        '
        Me.pluginsbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pluginsbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pluginsbutton.Location = New System.Drawing.Point(18, 106)
        Me.pluginsbutton.Name = "pluginsbutton"
        Me.pluginsbutton.Size = New System.Drawing.Size(548, 36)
        Me.pluginsbutton.TabIndex = 2
        Me.pluginsbutton.Text = "Serveur avec des plugins (Spigot)"
        Me.pluginsbutton.UseVisualStyleBackColor = True
        '
        'les2button
        '
        Me.les2button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.les2button.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.les2button.Location = New System.Drawing.Point(18, 192)
        Me.les2button.Name = "les2button"
        Me.les2button.Size = New System.Drawing.Size(548, 47)
        Me.les2button.TabIndex = 1
        Me.les2button.Text = "Serveur Moddé avec plugins (Sponge)"
        Me.les2button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(561, 47)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Quel va être le type de votre serveur ?"
        '
        'Suivant
        '
        Me.Suivant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Suivant.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Suivant.Location = New System.Drawing.Point(12, 250)
        Me.Suivant.Name = "Suivant"
        Me.Suivant.Size = New System.Drawing.Size(554, 44)
        Me.Suivant.TabIndex = 4
        Me.Suivant.Text = "Suivant"
        Me.Suivant.UseVisualStyleBackColor = True
        '
        'ServerType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(578, 306)
        Me.Controls.Add(Me.Suivant)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pluginsbutton)
        Me.Controls.Add(Me.les2button)
        Me.Controls.Add(Me.modsbutton)
        Me.Controls.Add(Me.rien)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ServerType"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minecraft Custom Server Creator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rien As RadioButton
    Friend WithEvents modsbutton As RadioButton
    Friend WithEvents pluginsbutton As RadioButton
    Friend WithEvents les2button As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Suivant As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Misajour As Timer
End Class
