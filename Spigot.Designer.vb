<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Spigot
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SpigotVersionsListBox = New System.Windows.Forms.ListBox()
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MissingVersion = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'SpigotVersionsListBox
        '
        Me.SpigotVersionsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SpigotVersionsListBox.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.SpigotVersionsListBox.FormattingEnabled = True
        Me.SpigotVersionsListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SpigotVersionsListBox.ItemHeight = 18
        Me.SpigotVersionsListBox.Items.AddRange(New Object() {"Dernière Version"})
        Me.SpigotVersionsListBox.Location = New System.Drawing.Point(13, 46)
        Me.SpigotVersionsListBox.Name = "SpigotVersionsListBox"
        Me.SpigotVersionsListBox.Size = New System.Drawing.Size(215, 326)
        Me.SpigotVersionsListBox.TabIndex = 1
        '
        'NextBtn
        '
        Me.NextBtn.Enabled = False
        Me.NextBtn.Font = New System.Drawing.Font("Comic Sans MS", 20.0!)
        Me.NextBtn.Location = New System.Drawing.Point(13, 397)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(215, 52)
        Me.NextBtn.TabIndex = 2
        Me.NextBtn.Text = "Suivant"
        Me.NextBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Choisissez la version de Spigot :"
        '
        'MissingVersion
        '
        Me.MissingVersion.AutoSize = True
        Me.MissingVersion.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.MissingVersion.Location = New System.Drawing.Point(87, 375)
        Me.MissingVersion.Name = "MissingVersion"
        Me.MissingVersion.Size = New System.Drawing.Size(141, 19)
        Me.MissingVersion.TabIndex = 4
        Me.MissingVersion.TabStop = True
        Me.MissingVersion.Text = "Version manquante ?"
        '
        'Spigot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 462)
        Me.Controls.Add(Me.MissingVersion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NextBtn)
        Me.Controls.Add(Me.SpigotVersionsListBox)
        Me.Name = "Spigot"
        Me.Text = "Spigot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SpigotVersionsListBox As ListBox
    Friend WithEvents NextBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MissingVersion As LinkLabel
End Class
