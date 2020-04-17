<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectServerDir
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
        Me.ServerPath = New System.Windows.Forms.TextBox()
        Me.Browse = New System.Windows.Forms.Button()
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.SelectDir = New System.Windows.Forms.FolderBrowserDialog()
        Me.ServerDirLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ServerPath
        '
        Me.ServerPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ServerPath.Location = New System.Drawing.Point(12, 49)
        Me.ServerPath.Name = "ServerPath"
        Me.ServerPath.Size = New System.Drawing.Size(626, 26)
        Me.ServerPath.TabIndex = 0
        '
        'Browse
        '
        Me.Browse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Browse.Location = New System.Drawing.Point(644, 49)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(32, 26)
        Me.Browse.TabIndex = 1
        Me.Browse.Text = "..."
        Me.Browse.UseVisualStyleBackColor = True
        '
        'NextBtn
        '
        Me.NextBtn.Font = New System.Drawing.Font("Comic Sans MS", 20.0!)
        Me.NextBtn.Location = New System.Drawing.Point(12, 81)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(664, 47)
        Me.NextBtn.TabIndex = 2
        Me.NextBtn.Text = "Suivant"
        Me.NextBtn.UseVisualStyleBackColor = True
        '
        'SelectDir
        '
        Me.SelectDir.Description = "Choisissez le dossier dans lequel va être installé le serveur"
        Me.SelectDir.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'ServerDirLabel
        '
        Me.ServerDirLabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ServerDirLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerDirLabel.Location = New System.Drawing.Point(12, 9)
        Me.ServerDirLabel.Name = "ServerDirLabel"
        Me.ServerDirLabel.Size = New System.Drawing.Size(681, 37)
        Me.ServerDirLabel.TabIndex = 5
        Me.ServerDirLabel.Text = "Dans quel dossier va être installé votre serveur ?"
        '
        'SelectServerDir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 138)
        Me.Controls.Add(Me.ServerDirLabel)
        Me.Controls.Add(Me.NextBtn)
        Me.Controls.Add(Me.Browse)
        Me.Controls.Add(Me.ServerPath)
        Me.Name = "SelectServerDir"
        Me.Text = "Choisir le dossier du Serveur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ServerPath As TextBox
    Friend WithEvents Browse As Button
    Friend WithEvents NextBtn As Button
    Friend WithEvents SelectDir As FolderBrowserDialog
    Friend WithEvents ServerDirLabel As Label
End Class
