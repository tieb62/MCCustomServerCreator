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
        Me.VanillaRadio = New System.Windows.Forms.RadioButton()
        Me.ForgeRadio = New System.Windows.Forms.RadioButton()
        Me.SpigotRadio = New System.Windows.Forms.RadioButton()
        Me.SpongeRadio = New System.Windows.Forms.RadioButton()
        Me.ServerTypeLabel = New System.Windows.Forms.Label()
        Me.Suivant = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'VanillaRadio
        '
        Me.VanillaRadio.Checked = True
        Me.VanillaRadio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VanillaRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VanillaRadio.Location = New System.Drawing.Point(18, 59)
        Me.VanillaRadio.Name = "VanillaRadio"
        Me.VanillaRadio.Size = New System.Drawing.Size(548, 41)
        Me.VanillaRadio.TabIndex = 0
        Me.VanillaRadio.TabStop = True
        Me.VanillaRadio.Text = "Serveur Vanilla"
        Me.VanillaRadio.UseMnemonic = False
        Me.VanillaRadio.UseVisualStyleBackColor = True
        '
        'ForgeRadio
        '
        Me.ForgeRadio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForgeRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForgeRadio.Location = New System.Drawing.Point(18, 148)
        Me.ForgeRadio.Name = "ForgeRadio"
        Me.ForgeRadio.Size = New System.Drawing.Size(548, 43)
        Me.ForgeRadio.TabIndex = 1
        Me.ForgeRadio.Text = "Serveur Moddé (Forge)"
        Me.ForgeRadio.UseVisualStyleBackColor = True
        '
        'SpigotRadio
        '
        Me.SpigotRadio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SpigotRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpigotRadio.Location = New System.Drawing.Point(18, 106)
        Me.SpigotRadio.Name = "SpigotRadio"
        Me.SpigotRadio.Size = New System.Drawing.Size(548, 36)
        Me.SpigotRadio.TabIndex = 2
        Me.SpigotRadio.Text = "Serveur avec des plugins (Spigot)"
        Me.SpigotRadio.UseVisualStyleBackColor = True
        '
        'SpongeRadio
        '
        Me.SpongeRadio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SpongeRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpongeRadio.Location = New System.Drawing.Point(18, 192)
        Me.SpongeRadio.Name = "SpongeRadio"
        Me.SpongeRadio.Size = New System.Drawing.Size(548, 47)
        Me.SpongeRadio.TabIndex = 1
        Me.SpongeRadio.Text = "Serveur Moddé avec plugins (Sponge)"
        Me.SpongeRadio.UseVisualStyleBackColor = True
        '
        'ServerTypeLabel
        '
        Me.ServerTypeLabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ServerTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerTypeLabel.Location = New System.Drawing.Point(12, 9)
        Me.ServerTypeLabel.Name = "ServerTypeLabel"
        Me.ServerTypeLabel.Size = New System.Drawing.Size(561, 47)
        Me.ServerTypeLabel.TabIndex = 3
        Me.ServerTypeLabel.Text = "Quel va être le type de votre serveur ?"
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
        Me.Controls.Add(Me.ServerTypeLabel)
        Me.Controls.Add(Me.SpigotRadio)
        Me.Controls.Add(Me.SpongeRadio)
        Me.Controls.Add(Me.ForgeRadio)
        Me.Controls.Add(Me.VanillaRadio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ServerType"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minecraft Custom Server Creator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VanillaRadio As RadioButton
    Friend WithEvents ForgeRadio As RadioButton
    Friend WithEvents SpigotRadio As RadioButton
    Friend WithEvents SpongeRadio As RadioButton
    Friend WithEvents ServerTypeLabel As Label
    Friend WithEvents Suivant As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Misajour As Timer
End Class
