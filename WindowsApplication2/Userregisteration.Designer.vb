<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Userregisteration
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
        Me.Lbl_schoolid = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_searchschool = New System.Windows.Forms.TextBox()
        Me.Lst_schoolid = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_conatctno = New System.Windows.Forms.Label()
        Me.Txt_address = New System.Windows.Forms.TextBox()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.Txt_name = New System.Windows.Forms.TextBox()
        Me.Lbl_regname = New System.Windows.Forms.Label()
        Me.lbl_Id = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Lbl_password = New System.Windows.Forms.Label()
        Me.Txt_password = New System.Windows.Forms.TextBox()
        Me.Btn_sub = New System.Windows.Forms.Button()
        Me.Btn_cancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_schoolid
        '
        Me.Lbl_schoolid.AutoSize = True
        Me.Lbl_schoolid.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_schoolid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_schoolid.Location = New System.Drawing.Point(141, 89)
        Me.Lbl_schoolid.Name = "Lbl_schoolid"
        Me.Lbl_schoolid.Size = New System.Drawing.Size(69, 17)
        Me.Lbl_schoolid.TabIndex = 0
        Me.Lbl_schoolid.Text = "School_ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Search School:"
        '
        'Txt_searchschool
        '
        Me.Txt_searchschool.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_searchschool.Location = New System.Drawing.Point(231, 41)
        Me.Txt_searchschool.Name = "Txt_searchschool"
        Me.Txt_searchschool.Size = New System.Drawing.Size(214, 25)
        Me.Txt_searchschool.TabIndex = 2
        '
        'Lst_schoolid
        '
        Me.Lst_schoolid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_schoolid.FormattingEnabled = True
        Me.Lst_schoolid.ItemHeight = 17
        Me.Lst_schoolid.Location = New System.Drawing.Point(231, 89)
        Me.Lst_schoolid.Name = "Lst_schoolid"
        Me.Lst_schoolid.Size = New System.Drawing.Size(214, 72)
        Me.Lst_schoolid.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.lbl_conatctno)
        Me.GroupBox1.Controls.Add(Me.Txt_address)
        Me.GroupBox1.Controls.Add(Me.lbl_address)
        Me.GroupBox1.Controls.Add(Me.Txt_name)
        Me.GroupBox1.Controls.Add(Me.Lbl_regname)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(513, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 219)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(96, 110)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 25)
        Me.TextBox1.TabIndex = 5
        '
        'lbl_conatctno
        '
        Me.lbl_conatctno.AutoSize = True
        Me.lbl_conatctno.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_conatctno.Location = New System.Drawing.Point(7, 110)
        Me.lbl_conatctno.Name = "lbl_conatctno"
        Me.lbl_conatctno.Size = New System.Drawing.Size(78, 17)
        Me.lbl_conatctno.TabIndex = 4
        Me.lbl_conatctno.Text = "Contact no:"
        '
        'Txt_address
        '
        Me.Txt_address.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_address.Location = New System.Drawing.Point(96, 66)
        Me.Txt_address.Name = "Txt_address"
        Me.Txt_address.Size = New System.Drawing.Size(181, 25)
        Me.Txt_address.TabIndex = 3
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.Location = New System.Drawing.Point(21, 66)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(60, 17)
        Me.lbl_address.TabIndex = 2
        Me.lbl_address.Text = "Address:"
        '
        'Txt_name
        '
        Me.Txt_name.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_name.Location = New System.Drawing.Point(96, 25)
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.Size = New System.Drawing.Size(181, 25)
        Me.Txt_name.TabIndex = 1
        '
        'Lbl_regname
        '
        Me.Lbl_regname.AutoSize = True
        Me.Lbl_regname.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_regname.Location = New System.Drawing.Point(35, 25)
        Me.Lbl_regname.Name = "Lbl_regname"
        Me.Lbl_regname.Size = New System.Drawing.Size(47, 17)
        Me.Lbl_regname.TabIndex = 0
        Me.Lbl_regname.Text = "Name:"
        '
        'lbl_Id
        '
        Me.lbl_Id.AutoSize = True
        Me.lbl_Id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Id.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Id.Location = New System.Drawing.Point(117, 289)
        Me.lbl_Id.Name = "lbl_Id"
        Me.lbl_Id.Size = New System.Drawing.Size(24, 17)
        Me.lbl_Id.TabIndex = 5
        Me.lbl_Id.Text = "ID:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(165, 286)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(261, 25)
        Me.TextBox2.TabIndex = 6
        '
        'Lbl_password
        '
        Me.Lbl_password.AutoSize = True
        Me.Lbl_password.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_password.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_password.Location = New System.Drawing.Point(72, 330)
        Me.Lbl_password.Name = "Lbl_password"
        Me.Lbl_password.Size = New System.Drawing.Size(69, 17)
        Me.Lbl_password.TabIndex = 7
        Me.Lbl_password.Text = "Password:"
        '
        'Txt_password
        '
        Me.Txt_password.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_password.Location = New System.Drawing.Point(165, 327)
        Me.Txt_password.Name = "Txt_password"
        Me.Txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_password.Size = New System.Drawing.Size(261, 25)
        Me.Txt_password.TabIndex = 8
        '
        'Btn_sub
        '
        Me.Btn_sub.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_sub.Location = New System.Drawing.Point(109, 398)
        Me.Btn_sub.Name = "Btn_sub"
        Me.Btn_sub.Size = New System.Drawing.Size(101, 35)
        Me.Btn_sub.TabIndex = 9
        Me.Btn_sub.Text = "Submit"
        Me.Btn_sub.UseVisualStyleBackColor = True
        '
        'Btn_cancel
        '
        Me.Btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cancel.Location = New System.Drawing.Point(231, 398)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(101, 35)
        Me.Btn_cancel.TabIndex = 10
        Me.Btn_cancel.Text = "Cancel"
        Me.Btn_cancel.UseVisualStyleBackColor = True
        '
        'Userregisteration
        '
        Me.AcceptButton = Me.Btn_sub
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Helpdesk.My.Resources.Resources.images__4_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Btn_cancel
        Me.ClientSize = New System.Drawing.Size(851, 482)
        Me.Controls.Add(Me.Btn_cancel)
        Me.Controls.Add(Me.Btn_sub)
        Me.Controls.Add(Me.Txt_password)
        Me.Controls.Add(Me.Lbl_password)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lbl_Id)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Lst_schoolid)
        Me.Controls.Add(Me.Txt_searchschool)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbl_schoolid)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Userregisteration"
        Me.Text = "Userregisteration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_schoolid As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_searchschool As System.Windows.Forms.TextBox
    Friend WithEvents Lst_schoolid As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_conatctno As System.Windows.Forms.Label
    Friend WithEvents Txt_address As System.Windows.Forms.TextBox
    Friend WithEvents lbl_address As System.Windows.Forms.Label
    Friend WithEvents Txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_regname As System.Windows.Forms.Label
    Friend WithEvents lbl_Id As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_password As System.Windows.Forms.Label
    Friend WithEvents Txt_password As System.Windows.Forms.TextBox
    Friend WithEvents Btn_sub As System.Windows.Forms.Button
    Friend WithEvents Btn_cancel As System.Windows.Forms.Button
End Class
