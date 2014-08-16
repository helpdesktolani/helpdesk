<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Btn_login = New System.Windows.Forms.Button()
        Me.Txt_password = New System.Windows.Forms.TextBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.Txt_userid = New System.Windows.Forms.TextBox()
        Me.Lbl_userid = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lnpl_forgetpassword = New System.Windows.Forms.LinkLabel()
        Me.Lnpl_changepassword = New System.Windows.Forms.LinkLabel()
        Me.Btn_cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_login
        '
        Me.Btn_login.BackColor = System.Drawing.Color.LightGray
        Me.Btn_login.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_login.ForeColor = System.Drawing.Color.Navy
        Me.Btn_login.Location = New System.Drawing.Point(140, 193)
        Me.Btn_login.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_login.Name = "Btn_login"
        Me.Btn_login.Size = New System.Drawing.Size(102, 33)
        Me.Btn_login.TabIndex = 9
        Me.Btn_login.Text = "Login"
        Me.Btn_login.UseVisualStyleBackColor = False
        '
        'Txt_password
        '
        Me.Txt_password.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_password.Location = New System.Drawing.Point(177, 136)
        Me.Txt_password.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_password.Name = "Txt_password"
        Me.Txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_password.Size = New System.Drawing.Size(293, 25)
        Me.Txt_password.TabIndex = 8
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_password.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(91, 136)
        Me.lbl_password.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(69, 17)
        Me.lbl_password.TabIndex = 7
        Me.lbl_password.Text = "Password:"
        '
        'Txt_userid
        '
        Me.Txt_userid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_userid.Location = New System.Drawing.Point(177, 99)
        Me.Txt_userid.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_userid.Name = "Txt_userid"
        Me.Txt_userid.Size = New System.Drawing.Size(293, 25)
        Me.Txt_userid.TabIndex = 6
        '
        'Lbl_userid
        '
        Me.Lbl_userid.AutoSize = True
        Me.Lbl_userid.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_userid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_userid.Location = New System.Drawing.Point(104, 102)
        Me.Lbl_userid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_userid.Name = "Lbl_userid"
        Me.Lbl_userid.Size = New System.Drawing.Size(56, 17)
        Me.Lbl_userid.TabIndex = 5
        Me.Lbl_userid.Text = "User_ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Papyrus", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 33)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Welcome"
        '
        'Lnpl_forgetpassword
        '
        Me.Lnpl_forgetpassword.AutoSize = True
        Me.Lnpl_forgetpassword.Location = New System.Drawing.Point(50, 250)
        Me.Lnpl_forgetpassword.Name = "Lnpl_forgetpassword"
        Me.Lnpl_forgetpassword.Size = New System.Drawing.Size(110, 17)
        Me.Lnpl_forgetpassword.TabIndex = 11
        Me.Lnpl_forgetpassword.TabStop = True
        Me.Lnpl_forgetpassword.Text = "Forget Password"
        '
        'Lnpl_changepassword
        '
        Me.Lnpl_changepassword.AutoSize = True
        Me.Lnpl_changepassword.Location = New System.Drawing.Point(50, 285)
        Me.Lnpl_changepassword.Name = "Lnpl_changepassword"
        Me.Lnpl_changepassword.Size = New System.Drawing.Size(116, 17)
        Me.Lnpl_changepassword.TabIndex = 12
        Me.Lnpl_changepassword.TabStop = True
        Me.Lnpl_changepassword.Text = "Change Password"
        '
        'Btn_cancel
        '
        Me.Btn_cancel.BackColor = System.Drawing.Color.LightGray
        Me.Btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cancel.ForeColor = System.Drawing.Color.Navy
        Me.Btn_cancel.Location = New System.Drawing.Point(270, 193)
        Me.Btn_cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(102, 33)
        Me.Btn_cancel.TabIndex = 13
        Me.Btn_cancel.Text = "Cancel"
        Me.Btn_cancel.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AcceptButton = Me.Btn_login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Helpdesk.My.Resources.Resources.images__4_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Btn_cancel
        Me.ClientSize = New System.Drawing.Size(507, 372)
        Me.Controls.Add(Me.Btn_cancel)
        Me.Controls.Add(Me.Lnpl_changepassword)
        Me.Controls.Add(Me.Lnpl_forgetpassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_login)
        Me.Controls.Add(Me.Txt_password)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.Txt_userid)
        Me.Controls.Add(Me.Lbl_userid)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_login As System.Windows.Forms.Button
    Friend WithEvents Txt_password As System.Windows.Forms.TextBox
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents Txt_userid As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_userid As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lnpl_forgetpassword As System.Windows.Forms.LinkLabel
    Friend WithEvents Lnpl_changepassword As System.Windows.Forms.LinkLabel
    Friend WithEvents Btn_cancel As System.Windows.Forms.Button
End Class
