<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vanilla
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
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.VersionsList = New System.Windows.Forms.ListView()
        Me.VersionName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VersionType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'NextBtn
        '
        Me.NextBtn.Enabled = False
        Me.NextBtn.Font = New System.Drawing.Font("Comic Sans MS", 25.0!)
        Me.NextBtn.Location = New System.Drawing.Point(12, 374)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(275, 64)
        Me.NextBtn.TabIndex = 0
        Me.NextBtn.Text = "Suivant"
        Me.NextBtn.UseVisualStyleBackColor = True
        '
        'VersionsList
        '
        Me.VersionsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.VersionName, Me.VersionType})
        Me.VersionsList.HideSelection = False
        Me.VersionsList.Location = New System.Drawing.Point(12, 12)
        Me.VersionsList.MultiSelect = False
        Me.VersionsList.Name = "VersionsList"
        Me.VersionsList.Size = New System.Drawing.Size(275, 356)
        Me.VersionsList.TabIndex = 2
        Me.VersionsList.UseCompatibleStateImageBehavior = False
        Me.VersionsList.View = System.Windows.Forms.View.Details
        '
        'VersionName
        '
        Me.VersionName.Text = "Nom"
        Me.VersionName.Width = 144
        '
        'VersionType
        '
        Me.VersionType.Text = "Type"
        Me.VersionType.Width = 121
        '
        'Vanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 450)
        Me.Controls.Add(Me.VersionsList)
        Me.Controls.Add(Me.NextBtn)
        Me.Name = "Vanilla"
        Me.Text = "Vanilla"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NextBtn As Button
    Friend WithEvents VersionsList As ListView
    Friend WithEvents VersionType As ColumnHeader
    Friend WithEvents VersionName As ColumnHeader
End Class
