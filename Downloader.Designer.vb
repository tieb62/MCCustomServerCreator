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
        Me.DetailsBtn = New System.Windows.Forms.Button()
        Me.Details = New System.Windows.Forms.TextBox()
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
        'DetailsBtn
        '
        Me.DetailsBtn.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.DetailsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DetailsBtn.Location = New System.Drawing.Point(912, 66)
        Me.DetailsBtn.Name = "DetailsBtn"
        Me.DetailsBtn.Size = New System.Drawing.Size(104, 26)
        Me.DetailsBtn.TabIndex = 2
        Me.DetailsBtn.Text = "Détails >>"
        Me.DetailsBtn.UseVisualStyleBackColor = True
        Me.DetailsBtn.UseWaitCursor = True
        '
        'Details
        '
        Me.Details.AcceptsReturn = True
        Me.Details.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Details.Location = New System.Drawing.Point(12, 98)
        Me.Details.Multiline = True
        Me.Details.Name = "Details"
        Me.Details.ReadOnly = True
        Me.Details.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Details.Size = New System.Drawing.Size(1004, 419)
        Me.Details.TabIndex = 3
        Me.Details.UseWaitCursor = True
        Me.Details.Visible = False
        '
        'Downloader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 534)
        Me.Controls.Add(Me.Details)
        Me.Controls.Add(Me.DetailsBtn)
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.DownloadBar)
        Me.Name = "Downloader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Downloading . . ."
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DownloadBar As ProgressBar
    Friend WithEvents InfoLabel As Label
    Friend WithEvents DetailsBtn As Button
    Friend WithEvents Details As TextBox
End Class
