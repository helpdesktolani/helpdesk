<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class visit
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_solutionid = New System.Windows.Forms.Label()
        Me.Txt_solutionid = New System.Windows.Forms.TextBox()
        Me.Lbl_query = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_solutiondetail = New System.Windows.Forms.Label()
        Me.Txt_solutiondetail = New System.Windows.Forms.TextBox()
        Me.Btn_submit = New System.Windows.Forms.Button()
        Me.Btn_cancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(191, 317)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(233, 25)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Lbl_solutionid
        '
        Me.Lbl_solutionid.AutoSize = True
        Me.Lbl_solutionid.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_solutionid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_solutionid.Location = New System.Drawing.Point(110, 154)
        Me.Lbl_solutionid.Name = "Lbl_solutionid"
        Me.Lbl_solutionid.Size = New System.Drawing.Size(75, 17)
        Me.Lbl_solutionid.TabIndex = 1
        Me.Lbl_solutionid.Text = "Solution_ID:"
        '
        'Txt_solutionid
        '
        Me.Txt_solutionid.Location = New System.Drawing.Point(191, 154)
        Me.Txt_solutionid.Name = "Txt_solutionid"
        Me.Txt_solutionid.Size = New System.Drawing.Size(217, 25)
        Me.Txt_solutionid.TabIndex = 2
        '
        'Lbl_query
        '
        Me.Lbl_query.AutoSize = True
        Me.Lbl_query.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_query.Location = New System.Drawing.Point(129, 199)
        Me.Lbl_query.Name = "Lbl_query"
        Me.Lbl_query.Size = New System.Drawing.Size(46, 17)
        Me.Lbl_query.TabIndex = 3
        Me.Lbl_query.Text = "Query:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(191, 196)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(217, 57)
        Me.TextBox1.TabIndex = 4
        '
        'lbl_solutiondetail
        '
        Me.lbl_solutiondetail.AutoSize = True
        Me.lbl_solutiondetail.BackColor = System.Drawing.Color.Transparent
        Me.lbl_solutiondetail.Location = New System.Drawing.Point(91, 272)
        Me.lbl_solutiondetail.Name = "lbl_solutiondetail"
        Me.lbl_solutiondetail.Size = New System.Drawing.Size(94, 17)
        Me.lbl_solutiondetail.TabIndex = 5
        Me.lbl_solutiondetail.Text = "Solution detail:"
        '
        'Txt_solutiondetail
        '
        Me.Txt_solutiondetail.Location = New System.Drawing.Point(191, 272)
        Me.Txt_solutiondetail.Name = "Txt_solutiondetail"
        Me.Txt_solutiondetail.Size = New System.Drawing.Size(217, 25)
        Me.Txt_solutiondetail.TabIndex = 6
        '
        'Btn_submit
        '
        Me.Btn_submit.Location = New System.Drawing.Point(160, 368)
        Me.Btn_submit.Name = "Btn_submit"
        Me.Btn_submit.Size = New System.Drawing.Size(88, 36)
        Me.Btn_submit.TabIndex = 7
        Me.Btn_submit.Text = "Submit"
        Me.Btn_submit.UseVisualStyleBackColor = True
        '
        'Btn_cancel
        '
        Me.Btn_cancel.Location = New System.Drawing.Point(272, 368)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(88, 36)
        Me.Btn_cancel.TabIndex = 8
        Me.Btn_cancel.Text = "Cancel"
        Me.Btn_cancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(110, 317)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Visit Time:"
        '
        'visit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = Global.Helpdesk.My.Resources.Resources.images__4_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 492)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_cancel)
        Me.Controls.Add(Me.Btn_submit)
        Me.Controls.Add(Me.Txt_solutiondetail)
        Me.Controls.Add(Me.lbl_solutiondetail)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Lbl_query)
        Me.Controls.Add(Me.Txt_solutionid)
        Me.Controls.Add(Me.Lbl_solutionid)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "visit"
        Me.Text = "Visit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_solutionid As System.Windows.Forms.Label
    Friend WithEvents Txt_solutionid As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_query As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_solutiondetail As System.Windows.Forms.Label
    Friend WithEvents Txt_solutiondetail As System.Windows.Forms.TextBox
    Friend WithEvents Btn_submit As System.Windows.Forms.Button
    Friend WithEvents Btn_cancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
