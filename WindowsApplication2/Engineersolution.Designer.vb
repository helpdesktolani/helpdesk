<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Engineersolution
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl_description = New System.Windows.Forms.Label()
        Me.Txt_description = New System.Windows.Forms.TextBox()
        Me.Lbl_status = New System.Windows.Forms.Label()
        Me.Cmp_status = New System.Windows.Forms.ComboBox()
        Me.lbl_solutiondetail = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_description
        '
        Me.Lbl_description.AutoSize = True
        Me.Lbl_description.Location = New System.Drawing.Point(115, 77)
        Me.Lbl_description.Name = "Lbl_description"
        Me.Lbl_description.Size = New System.Drawing.Size(77, 17)
        Me.Lbl_description.TabIndex = 0
        Me.Lbl_description.Text = "Description:"
        '
        'Txt_description
        '
        Me.Txt_description.Location = New System.Drawing.Point(198, 77)
        Me.Txt_description.Name = "Txt_description"
        Me.Txt_description.Size = New System.Drawing.Size(227, 25)
        Me.Txt_description.TabIndex = 1
        '
        'Lbl_status
        '
        Me.Lbl_status.AutoSize = True
        Me.Lbl_status.Location = New System.Drawing.Point(137, 117)
        Me.Lbl_status.Name = "Lbl_status"
        Me.Lbl_status.Size = New System.Drawing.Size(46, 17)
        Me.Lbl_status.TabIndex = 2
        Me.Lbl_status.Text = "Status:"
        '
        'Cmp_status
        '
        Me.Cmp_status.FormattingEnabled = True
        Me.Cmp_status.Location = New System.Drawing.Point(198, 117)
        Me.Cmp_status.Name = "Cmp_status"
        Me.Cmp_status.Size = New System.Drawing.Size(227, 25)
        Me.Cmp_status.TabIndex = 3
        '
        'lbl_solutiondetail
        '
        Me.lbl_solutiondetail.AutoSize = True
        Me.lbl_solutiondetail.Location = New System.Drawing.Point(60, 159)
        Me.lbl_solutiondetail.Name = "lbl_solutiondetail"
        Me.lbl_solutiondetail.Size = New System.Drawing.Size(126, 17)
        Me.lbl_solutiondetail.TabIndex = 4
        Me.lbl_solutiondetail.Text = "Solution desctiption:"
        '
        'Engineersolution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 450)
        Me.Controls.Add(Me.lbl_solutiondetail)
        Me.Controls.Add(Me.Cmp_status)
        Me.Controls.Add(Me.Lbl_status)
        Me.Controls.Add(Me.Txt_description)
        Me.Controls.Add(Me.Lbl_description)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Engineersolution"
        Me.Text = "Engineersolution"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_description As System.Windows.Forms.Label
    Friend WithEvents Txt_description As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_status As System.Windows.Forms.Label
    Friend WithEvents Cmp_status As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_solutiondetail As System.Windows.Forms.Label
End Class
