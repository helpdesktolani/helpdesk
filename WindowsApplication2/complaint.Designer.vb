<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class complaint
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_cancel = New System.Windows.Forms.Button()
        Me.Btn_submit = New System.Windows.Forms.Button()
        Me.Txt_refcomno = New System.Windows.Forms.TextBox()
        Me.Txt_noofpc = New System.Windows.Forms.TextBox()
        Me.Txt_description = New System.Windows.Forms.TextBox()
        Me.Txt_schoolid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_noofpc = New System.Windows.Forms.Label()
        Me.lbl_description = New System.Windows.Forms.Label()
        Me.lbl_schoolid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_preferredsolution = New System.Windows.Forms.Label()
        Me.Txt_presolution = New System.Windows.Forms.TextBox()
        Me.Lbl_status = New System.Windows.Forms.Label()
        Me.Cmp_status = New System.Windows.Forms.ComboBox()
        Me.Lbl_approved = New System.Windows.Forms.Label()
        Me.Cmp_approved = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(441, 50)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Complain Register"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_cancel
        '
        Me.Btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_cancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cancel.Location = New System.Drawing.Point(149, 490)
        Me.Btn_cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(101, 29)
        Me.Btn_cancel.TabIndex = 22
        Me.Btn_cancel.Text = "Cancel"
        Me.Btn_cancel.UseVisualStyleBackColor = True
        '
        'Btn_submit
        '
        Me.Btn_submit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_submit.Location = New System.Drawing.Point(256, 490)
        Me.Btn_submit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_submit.Name = "Btn_submit"
        Me.Btn_submit.Size = New System.Drawing.Size(100, 29)
        Me.Btn_submit.TabIndex = 21
        Me.Btn_submit.Text = "Submit"
        Me.Btn_submit.UseVisualStyleBackColor = True
        '
        'Txt_refcomno
        '
        Me.Txt_refcomno.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_refcomno.Location = New System.Drawing.Point(149, 276)
        Me.Txt_refcomno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_refcomno.Name = "Txt_refcomno"
        Me.Txt_refcomno.Size = New System.Drawing.Size(265, 25)
        Me.Txt_refcomno.TabIndex = 20
        '
        'Txt_noofpc
        '
        Me.Txt_noofpc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_noofpc.Location = New System.Drawing.Point(149, 243)
        Me.Txt_noofpc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_noofpc.Name = "Txt_noofpc"
        Me.Txt_noofpc.Size = New System.Drawing.Size(265, 25)
        Me.Txt_noofpc.TabIndex = 19
        '
        'Txt_description
        '
        Me.Txt_description.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_description.Location = New System.Drawing.Point(149, 168)
        Me.Txt_description.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_description.Multiline = True
        Me.Txt_description.Name = "Txt_description"
        Me.Txt_description.Size = New System.Drawing.Size(265, 67)
        Me.Txt_description.TabIndex = 18
        '
        'Txt_schoolid
        '
        Me.Txt_schoolid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_schoolid.Location = New System.Drawing.Point(149, 135)
        Me.Txt_schoolid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_schoolid.Name = "Txt_schoolid"
        Me.Txt_schoolid.Size = New System.Drawing.Size(265, 25)
        Me.Txt_schoolid.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(33, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Refrence com no:"
        '
        'Lbl_noofpc
        '
        Me.Lbl_noofpc.AutoSize = True
        Me.Lbl_noofpc.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_noofpc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_noofpc.ForeColor = System.Drawing.Color.Black
        Me.Lbl_noofpc.Location = New System.Drawing.Point(78, 246)
        Me.Lbl_noofpc.Name = "Lbl_noofpc"
        Me.Lbl_noofpc.Size = New System.Drawing.Size(65, 17)
        Me.Lbl_noofpc.TabIndex = 15
        Me.Lbl_noofpc.Text = "NO of pc:"
        '
        'lbl_description
        '
        Me.lbl_description.AutoSize = True
        Me.lbl_description.BackColor = System.Drawing.Color.Transparent
        Me.lbl_description.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_description.ForeColor = System.Drawing.Color.Black
        Me.lbl_description.Location = New System.Drawing.Point(72, 168)
        Me.lbl_description.Name = "lbl_description"
        Me.lbl_description.Size = New System.Drawing.Size(71, 17)
        Me.lbl_description.TabIndex = 14
        Me.lbl_description.Text = "Desription:"
        '
        'lbl_schoolid
        '
        Me.lbl_schoolid.AutoSize = True
        Me.lbl_schoolid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_schoolid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_schoolid.ForeColor = System.Drawing.Color.Black
        Me.lbl_schoolid.Location = New System.Drawing.Point(76, 138)
        Me.lbl_schoolid.Name = "lbl_schoolid"
        Me.lbl_schoolid.Size = New System.Drawing.Size(67, 17)
        Me.lbl_schoolid.TabIndex = 13
        Me.lbl_schoolid.Text = "School_ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(341, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(382, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Date:"
        '
        'Lbl_preferredsolution
        '
        Me.Lbl_preferredsolution.AutoSize = True
        Me.Lbl_preferredsolution.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_preferredsolution.Location = New System.Drawing.Point(27, 318)
        Me.Lbl_preferredsolution.Name = "Lbl_preferredsolution"
        Me.Lbl_preferredsolution.Size = New System.Drawing.Size(116, 17)
        Me.Lbl_preferredsolution.TabIndex = 26
        Me.Lbl_preferredsolution.Text = "Preferred solution:"
        '
        'Txt_presolution
        '
        Me.Txt_presolution.Location = New System.Drawing.Point(149, 318)
        Me.Txt_presolution.Multiline = True
        Me.Txt_presolution.Name = "Txt_presolution"
        Me.Txt_presolution.Size = New System.Drawing.Size(265, 59)
        Me.Txt_presolution.TabIndex = 27
        '
        'Lbl_status
        '
        Me.Lbl_status.AutoSize = True
        Me.Lbl_status.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_status.Location = New System.Drawing.Point(97, 395)
        Me.Lbl_status.Name = "Lbl_status"
        Me.Lbl_status.Size = New System.Drawing.Size(46, 17)
        Me.Lbl_status.TabIndex = 28
        Me.Lbl_status.Text = "Status:"
        '
        'Cmp_status
        '
        Me.Cmp_status.FormattingEnabled = True
        Me.Cmp_status.Location = New System.Drawing.Point(149, 392)
        Me.Cmp_status.Name = "Cmp_status"
        Me.Cmp_status.Size = New System.Drawing.Size(265, 25)
        Me.Cmp_status.TabIndex = 29
        '
        'Lbl_approved
        '
        Me.Lbl_approved.AutoSize = True
        Me.Lbl_approved.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_approved.Location = New System.Drawing.Point(74, 437)
        Me.Lbl_approved.Name = "Lbl_approved"
        Me.Lbl_approved.Size = New System.Drawing.Size(69, 17)
        Me.Lbl_approved.TabIndex = 30
        Me.Lbl_approved.Text = "Approved:"
        '
        'Cmp_approved
        '
        Me.Cmp_approved.FormattingEnabled = True
        Me.Cmp_approved.Location = New System.Drawing.Point(149, 434)
        Me.Cmp_approved.Name = "Cmp_approved"
        Me.Cmp_approved.Size = New System.Drawing.Size(265, 25)
        Me.Cmp_approved.TabIndex = 31
        '
        'complaint
        '
        Me.AcceptButton = Me.Btn_submit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Helpdesk.My.Resources.Resources.images__4_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Btn_cancel
        Me.ClientSize = New System.Drawing.Size(467, 534)
        Me.Controls.Add(Me.Cmp_approved)
        Me.Controls.Add(Me.Lbl_approved)
        Me.Controls.Add(Me.Cmp_status)
        Me.Controls.Add(Me.Lbl_status)
        Me.Controls.Add(Me.Txt_presolution)
        Me.Controls.Add(Me.Lbl_preferredsolution)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_cancel)
        Me.Controls.Add(Me.Btn_submit)
        Me.Controls.Add(Me.Txt_refcomno)
        Me.Controls.Add(Me.Txt_noofpc)
        Me.Controls.Add(Me.Txt_description)
        Me.Controls.Add(Me.Txt_schoolid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_noofpc)
        Me.Controls.Add(Me.lbl_description)
        Me.Controls.Add(Me.lbl_schoolid)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "complaint"
        Me.Text = "complaint"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_cancel As System.Windows.Forms.Button
    Friend WithEvents Btn_submit As System.Windows.Forms.Button
    Friend WithEvents Txt_refcomno As System.Windows.Forms.TextBox
    Friend WithEvents Txt_noofpc As System.Windows.Forms.TextBox
    Friend WithEvents Txt_description As System.Windows.Forms.TextBox
    Friend WithEvents Txt_schoolid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_noofpc As System.Windows.Forms.Label
    Friend WithEvents lbl_description As System.Windows.Forms.Label
    Friend WithEvents lbl_schoolid As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Lbl_preferredsolution As System.Windows.Forms.Label
    Friend WithEvents Txt_presolution As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_status As System.Windows.Forms.Label
    Friend WithEvents Cmp_status As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_approved As System.Windows.Forms.Label
    Friend WithEvents Cmp_approved As System.Windows.Forms.ComboBox
End Class
