<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eula
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
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.CheckEULA = New System.Windows.Forms.CheckBox()
        Me.LinkEULA = New System.Windows.Forms.LinkLabel()
        Me.LabelEULA = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NextBtn
        '
        Me.NextBtn.Enabled = False
        Me.NextBtn.Font = New System.Drawing.Font("Comic Sans MS", 20.0!)
        Me.NextBtn.Location = New System.Drawing.Point(12, 91)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(590, 46)
        Me.NextBtn.TabIndex = 0
        Me.NextBtn.Text = "Suivant"
        Me.NextBtn.UseVisualStyleBackColor = True
        '
        'CheckEULA
        '
        Me.CheckEULA.AutoSize = True
        Me.CheckEULA.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.CheckEULA.Location = New System.Drawing.Point(16, 58)
        Me.CheckEULA.Name = "CheckEULA"
        Me.CheckEULA.Size = New System.Drawing.Size(241, 27)
        Me.CheckEULA.TabIndex = 1
        Me.CheckEULA.Text = "J'accepte l'EULA de Mojang"
        Me.CheckEULA.UseVisualStyleBackColor = True
        '
        'LinkEULA
        '
        Me.LinkEULA.AutoSize = True
        Me.LinkEULA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkEULA.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkEULA.Location = New System.Drawing.Point(12, 32)
        Me.LinkEULA.Name = "LinkEULA"
        Me.LinkEULA.Size = New System.Drawing.Size(412, 23)
        Me.LinkEULA.TabIndex = 2
        Me.LinkEULA.TabStop = True
        Me.LinkEULA.Text = "https://account.mojang.com/documents/minecraft_eula"
        '
        'LabelEULA
        '
        Me.LabelEULA.AutoSize = True
        Me.LabelEULA.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.LabelEULA.Location = New System.Drawing.Point(12, 9)
        Me.LabelEULA.Name = "LabelEULA"
        Me.LabelEULA.Size = New System.Drawing.Size(583, 23)
        Me.LabelEULA.TabIndex = 3
        Me.LabelEULA.Text = "En cochant la case ci-dessous, vous acceptez explicitement l'EULA de Mojang :"
        '
        'Eula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 149)
        Me.Controls.Add(Me.LabelEULA)
        Me.Controls.Add(Me.LinkEULA)
        Me.Controls.Add(Me.CheckEULA)
        Me.Controls.Add(Me.NextBtn)
        Me.Name = "Eula"
        Me.Text = "Eula"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NextBtn As Button
    Friend WithEvents CheckEULA As CheckBox
    Friend WithEvents LinkEULA As LinkLabel
    Friend WithEvents LabelEULA As Label
End Class
