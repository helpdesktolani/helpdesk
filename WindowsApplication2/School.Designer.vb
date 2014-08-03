<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Lbl_schoolname = New System.Windows.Forms.Label()
        Me.Lbl_schoolid = New System.Windows.Forms.Label()
        Me.Lbl_address = New System.Windows.Forms.Label()
        Me.Lbl_noofpc = New System.Windows.Forms.Label()
        Me.Lbl_validationdate = New System.Windows.Forms.Label()
        Me.Txt_schoolname = New System.Windows.Forms.TextBox()
        Me.Txt_schoolid = New System.Windows.Forms.TextBox()
        Me.Txt_address = New System.Windows.Forms.TextBox()
        Me.Txt_noofpc = New System.Windows.Forms.TextBox()
        Me.Txt_validationdate = New System.Windows.Forms.TextBox()
        Me.Btn_submit = New System.Windows.Forms.Button()
        Me.Btn_cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_schoolname
        '
        Me.Lbl_schoolname.AutoSize = True
        Me.Lbl_schoolname.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_schoolname.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_schoolname.Location = New System.Drawing.Point(75, 79)
        Me.Lbl_schoolname.Name = "Lbl_schoolname"
        Me.Lbl_schoolname.Size = New System.Drawing.Size(91, 17)
        Me.Lbl_schoolname.TabIndex = 0
        Me.Lbl_schoolname.Text = "School Name:"
        '
        'Lbl_schoolid
        '
        Me.Lbl_schoolid.AutoSize = True
        Me.Lbl_schoolid.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_schoolid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_schoolid.Location = New System.Drawing.Point(97, 115)
        Me.Lbl_schoolid.Name = "Lbl_schoolid"
        Me.Lbl_schoolid.Size = New System.Drawing.Size(69, 17)
        Me.Lbl_schoolid.TabIndex = 1
        Me.Lbl_schoolid.Text = "School_ID:"
        '
        'Lbl_address
        '
        Me.Lbl_address.AutoSize = True
        Me.Lbl_address.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_address.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_address.Location = New System.Drawing.Point(105, 151)
        Me.Lbl_address.Name = "Lbl_address"
        Me.Lbl_address.Size = New System.Drawing.Size(60, 17)
        Me.Lbl_address.TabIndex = 2
        Me.Lbl_address.Text = "Address:"
        '
        'Lbl_noofpc
        '
        Me.Lbl_noofpc.AutoSize = True
        Me.Lbl_noofpc.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_noofpc.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_noofpc.Location = New System.Drawing.Point(97, 211)
        Me.Lbl_noofpc.Name = "Lbl_noofpc"
        Me.Lbl_noofpc.Size = New System.Drawing.Size(63, 17)
        Me.Lbl_noofpc.TabIndex = 3
        Me.Lbl_noofpc.Text = "No of pc:"
        '
        'Lbl_validationdate
        '
        Me.Lbl_validationdate.AutoSize = True
        Me.Lbl_validationdate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_validationdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_validationdate.Location = New System.Drawing.Point(64, 242)
        Me.Lbl_validationdate.Name = "Lbl_validationdate"
        Me.Lbl_validationdate.Size = New System.Drawing.Size(103, 17)
        Me.Lbl_validationdate.TabIndex = 4
        Me.Lbl_validationdate.Text = "Validation Date:"
        '
        'Txt_schoolname
        '
        Me.Txt_schoolname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_schoolname.Location = New System.Drawing.Point(171, 79)
        Me.Txt_schoolname.Name = "Txt_schoolname"
        Me.Txt_schoolname.Size = New System.Drawing.Size(216, 25)
        Me.Txt_schoolname.TabIndex = 5
        '
        'Txt_schoolid
        '
        Me.Txt_schoolid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_schoolid.Location = New System.Drawing.Point(171, 115)
        Me.Txt_schoolid.Name = "Txt_schoolid"
        Me.Txt_schoolid.Size = New System.Drawing.Size(216, 25)
        Me.Txt_schoolid.TabIndex = 6
        '
        'Txt_address
        '
        Me.Txt_address.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_address.Location = New System.Drawing.Point(171, 151)
        Me.Txt_address.Multiline = True
        Me.Txt_address.Name = "Txt_address"
        Me.Txt_address.Size = New System.Drawing.Size(216, 36)
        Me.Txt_address.TabIndex = 7
        '
        'Txt_noofpc
        '
        Me.Txt_noofpc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_noofpc.Location = New System.Drawing.Point(171, 203)
        Me.Txt_noofpc.Name = "Txt_noofpc"
        Me.Txt_noofpc.Size = New System.Drawing.Size(216, 25)
        Me.Txt_noofpc.TabIndex = 8
        '
        'Txt_validationdate
        '
        Me.Txt_validationdate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_validationdate.Location = New System.Drawing.Point(171, 242)
        Me.Txt_validationdate.Name = "Txt_validationdate"
        Me.Txt_validationdate.Size = New System.Drawing.Size(216, 25)
        Me.Txt_validationdate.TabIndex = 9
        '
        'Btn_submit
        '
        Me.Btn_submit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_submit.Location = New System.Drawing.Point(131, 309)
        Me.Btn_submit.Name = "Btn_submit"
        Me.Btn_submit.Size = New System.Drawing.Size(90, 37)
        Me.Btn_submit.TabIndex = 10
        Me.Btn_submit.Text = "Submit"
        Me.Btn_submit.UseVisualStyleBackColor = True
        '
        'Btn_cancel
        '
        Me.Btn_cancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cancel.Location = New System.Drawing.Point(237, 309)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(90, 37)
        Me.Btn_cancel.TabIndex = 11
        Me.Btn_cancel.Text = "Cancel"
        Me.Btn_cancel.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Helpdesk.My.Resources.Resources.images__4_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(655, 450)
        Me.Controls.Add(Me.Btn_cancel)
        Me.Controls.Add(Me.Btn_submit)
        Me.Controls.Add(Me.Txt_validationdate)
        Me.Controls.Add(Me.Txt_noofpc)
        Me.Controls.Add(Me.Txt_address)
        Me.Controls.Add(Me.Txt_schoolid)
        Me.Controls.Add(Me.Txt_schoolname)
        Me.Controls.Add(Me.Lbl_validationdate)
        Me.Controls.Add(Me.Lbl_noofpc)
        Me.Controls.Add(Me.Lbl_address)
        Me.Controls.Add(Me.Lbl_schoolid)
        Me.Controls.Add(Me.Lbl_schoolname)
        Me.Name = "Form2"
        Me.Text = "School"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_schoolname As System.Windows.Forms.Label
    Friend WithEvents Lbl_schoolid As System.Windows.Forms.Label
    Friend WithEvents Lbl_address As System.Windows.Forms.Label
    Friend WithEvents Lbl_noofpc As System.Windows.Forms.Label
    Friend WithEvents Lbl_validationdate As System.Windows.Forms.Label
    Friend WithEvents Txt_schoolname As System.Windows.Forms.TextBox
    Friend WithEvents Txt_schoolid As System.Windows.Forms.TextBox
    Friend WithEvents Txt_address As System.Windows.Forms.TextBox
    Friend WithEvents Txt_noofpc As System.Windows.Forms.TextBox
    Friend WithEvents Txt_validationdate As System.Windows.Forms.TextBox
    Friend WithEvents Btn_submit As System.Windows.Forms.Button
    Friend WithEvents Btn_cancel As System.Windows.Forms.Button
End Class
