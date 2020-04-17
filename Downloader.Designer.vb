<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Downloader
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
        Me.DownloadBar = New System.Windows.Forms.ProgressBar()
        Me.InfoLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DownloadBar
        '
        Me.DownloadBar.Location = New System.Drawing.Point(12, 12)
        Me.DownloadBar.MarqueeAnimationSpeed = 1
        Me.DownloadBar.Name = "DownloadBar"
        Me.DownloadBar.Size = New System.Drawing.Size(1004, 48)
        Me.DownloadBar.Step = 1
        Me.DownloadBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.DownloadBar.TabIndex = 0
        Me.DownloadBar.UseWaitCursor = True
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.InfoLabel.Location = New System.Drawing.Point(12, 67)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(142, 25)
        Me.InfoLabel.TabIndex = 1
        Me.InfoLabel.Text = "Initialisation . . ."
        Me.InfoLabel.UseWaitCursor = True
        '
        'Downloader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 101)
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.DownloadBar)
        Me.Name = "Downloader"
        Me.Text = "Downloading . . ."
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DownloadBar As ProgressBar
    Friend WithEvents InfoLabel As Label
End Class
