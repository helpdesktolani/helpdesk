<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changepassword
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
        Me.lbl_Id = New System.Windows.Forms.Label()
        Me.Txt_id = New System.Windows.Forms.TextBox()
        Me.Lbl_curentpassword = New System.Windows.Forms.Label()
        Me.Txt_crentpassword = New System.Windows.Forms.TextBox()
        Me.Lbl_newpassword = New System.Windows.Forms.Label()
        Me.Txt_newpassword = New System.Windows.Forms.TextBox()
        Me.lbl_confirmpassword = New System.Windows.Forms.Label()
        Me.Txt_conformpassword = New System.Windows.Forms.TextBox()
        Me.Btn_submit = New System.Windows.Forms.Button()
        Me.Btn_cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Id
        '
        Me.lbl_Id.AutoSize = True
        Me.lbl_Id.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Id.Location = New System.Drawing.Point(185, 100)
        Me.lbl_Id.Name = "lbl_Id"
        Me.lbl_Id.Size = New System.Drawing.Size(24, 17)
        Me.lbl_Id.TabIndex = 0
        Me.lbl_Id.Text = "ID:"
        '
        'Txt_id
        '
        Me.Txt_id.Location = New System.Drawing.Point(219, 100)
        Me.Txt_id.Name = "Txt_id"
        Me.Txt_id.Size = New System.Drawing.Size(250, 25)
        Me.Txt_id.TabIndex = 1
        '
        'Lbl_curentpassword
        '
        Me.Lbl_curentpassword.AutoSize = True
        Me.Lbl_curentpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_curentpassword.Location = New System.Drawing.Point(90, 145)
        Me.Lbl_curentpassword.Name = "Lbl_curentpassword"
        Me.Lbl_curentpassword.Size = New System.Drawing.Size(119, 17)
        Me.Lbl_curentpassword.TabIndex = 2
        Me.Lbl_curentpassword.Text = "Current password:"
        '
        'Txt_crentpassword
        '
        Me.Txt_crentpassword.Location = New System.Drawing.Point(219, 142)
        Me.Txt_crentpassword.Name = "Txt_crentpassword"
        Me.Txt_crentpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_crentpassword.Size = New System.Drawing.Size(250, 25)
        Me.Txt_crentpassword.TabIndex = 3
        '
        'Lbl_newpassword
        '
        Me.Lbl_newpassword.AutoSize = True
        Me.Lbl_newpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_newpassword.Location = New System.Drawing.Point(109, 185)
        Me.Lbl_newpassword.Name = "Lbl_newpassword"
        Me.Lbl_newpassword.Size = New System.Drawing.Size(100, 17)
        Me.Lbl_newpassword.TabIndex = 4
        Me.Lbl_newpassword.Text = "New password:"
        '
        'Txt_newpassword
        '
        Me.Txt_newpassword.Location = New System.Drawing.Point(222, 185)
        Me.Txt_newpassword.Name = "Txt_newpassword"
        Me.Txt_newpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_newpassword.Size = New System.Drawing.Size(247, 25)
        Me.Txt_newpassword.TabIndex = 5
        '
        'lbl_confirmpassword
        '
        Me.lbl_confirmpassword.AutoSize = True
        Me.lbl_confirmpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_confirmpassword.Location = New System.Drawing.Point(83, 227)
        Me.lbl_confirmpassword.Name = "lbl_confirmpassword"
        Me.lbl_confirmpassword.Size = New System.Drawing.Size(126, 17)
        Me.lbl_confirmpassword.TabIndex = 6
        Me.lbl_confirmpassword.Text = "Conform password:"
        '
        'Txt_conformpassword
        '
        Me.Txt_conformpassword.Location = New System.Drawing.Point(225, 224)
        Me.Txt_conformpassword.Name = "Txt_conformpassword"
        Me.Txt_conformpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_conformpassword.Size = New System.Drawing.Size(244, 25)
        Me.Txt_conformpassword.TabIndex = 7
        '
        'Btn_submit
        '
        Me.Btn_submit.Location = New System.Drawing.Point(281, 297)
        Me.Btn_submit.Name = "Btn_submit"
        Me.Btn_submit.Size = New System.Drawing.Size(97, 31)
        Me.Btn_submit.TabIndex = 8
        Me.Btn_submit.Text = "Submit"
        Me.Btn_submit.UseVisualStyleBackColor = True
        '
        'Btn_cancel
        '
        Me.Btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_cancel.Location = New System.Drawing.Point(165, 297)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(97, 31)
        Me.Btn_cancel.TabIndex = 9
        Me.Btn_cancel.Text = "Cancel"
        Me.Btn_cancel.UseVisualStyleBackColor = True
        '
        'changepassword
        '
        Me.AcceptButton = Me.Btn_submit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Helpdesk.My.Resources.Resources.images__4_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Btn_cancel
        Me.ClientSize = New System.Drawing.Size(587, 385)
        Me.Controls.Add(Me.Btn_cancel)
        Me.Controls.Add(Me.Btn_submit)
        Me.Controls.Add(Me.Txt_conformpassword)
        Me.Controls.Add(Me.lbl_confirmpassword)
        Me.Controls.Add(Me.Txt_newpassword)
        Me.Controls.Add(Me.Lbl_newpassword)
        Me.Controls.Add(Me.Txt_crentpassword)
        Me.Controls.Add(Me.Lbl_curentpassword)
        Me.Controls.Add(Me.Txt_id)
        Me.Controls.Add(Me.lbl_Id)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "changepassword"
        Me.Text = "changepassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Id As System.Windows.Forms.Label
    Friend WithEvents Txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_curentpassword As System.Windows.Forms.Label
    Friend WithEvents Txt_crentpassword As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_newpassword As System.Windows.Forms.Label
    Friend WithEvents Txt_newpassword As System.Windows.Forms.TextBox
    Friend WithEvents lbl_confirmpassword As System.Windows.Forms.Label
    Friend WithEvents Txt_conformpassword As System.Windows.Forms.TextBox
    Friend WithEvents Btn_submit As System.Windows.Forms.Button
    Friend WithEvents Btn_cancel As System.Windows.Forms.Button
End Class
