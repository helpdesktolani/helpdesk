<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Engineer
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Engineer))
        Me.Lbl_engineername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_contactno = New System.Windows.Forms.Label()
        Me.Lbl_emailid = New System.Windows.Forms.Label()
        Me.Txt_engineername = New System.Windows.Forms.TextBox()
        Me.Txt_engineerid = New System.Windows.Forms.TextBox()
        Me.Txt_contactno = New System.Windows.Forms.TextBox()
        Me.Txt_emailid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_address = New System.Windows.Forms.TextBox()
        Me.Lbl_workonpc = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_Typefiled = New System.Windows.Forms.Label()
        Me.Txt_typeoffiled = New System.Windows.Forms.TextBox()
        Me.Btn_Submit = New System.Windows.Forms.Button()
        Me.Btn_cancel = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Lbl_engineername
        '
        Me.Lbl_engineername.AutoSize = True
        Me.Lbl_engineername.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_engineername.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_engineername.Location = New System.Drawing.Point(61, 44)
        Me.Lbl_engineername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_engineername.Name = "Lbl_engineername"
        Me.Lbl_engineername.Size = New System.Drawing.Size(104, 17)
        Me.Lbl_engineername.TabIndex = 0
        Me.Lbl_engineername.Text = "Engineer Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Engineer_ID:"
        '
        'Lbl_contactno
        '
        Me.Lbl_contactno.AutoSize = True
        Me.Lbl_contactno.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_contactno.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_contactno.Location = New System.Drawing.Point(86, 131)
        Me.Lbl_contactno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_contactno.Name = "Lbl_contactno"
        Me.Lbl_contactno.Size = New System.Drawing.Size(79, 17)
        Me.Lbl_contactno.TabIndex = 2
        Me.Lbl_contactno.Text = "Contact_no:"
        '
        'Lbl_emailid
        '
        Me.Lbl_emailid.AutoSize = True
        Me.Lbl_emailid.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_emailid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_emailid.Location = New System.Drawing.Point(104, 173)
        Me.Lbl_emailid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_emailid.Name = "Lbl_emailid"
        Me.Lbl_emailid.Size = New System.Drawing.Size(61, 17)
        Me.Lbl_emailid.TabIndex = 3
        Me.Lbl_emailid.Text = "Email_ID:"
        '
        'Txt_engineername
        '
        Me.Txt_engineername.BackColor = System.Drawing.Color.White
        Me.Txt_engineername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_engineername.ForeColor = System.Drawing.Color.Black
        Me.Txt_engineername.Location = New System.Drawing.Point(189, 44)
        Me.Txt_engineername.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_engineername.Name = "Txt_engineername"
        Me.Txt_engineername.Size = New System.Drawing.Size(280, 25)
        Me.Txt_engineername.TabIndex = 4
        '
        'Txt_engineerid
        '
        Me.Txt_engineerid.BackColor = System.Drawing.Color.White
        Me.Txt_engineerid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_engineerid.ForeColor = System.Drawing.Color.LightGray
        Me.Txt_engineerid.Location = New System.Drawing.Point(189, 92)
        Me.Txt_engineerid.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_engineerid.Name = "Txt_engineerid"
        Me.Txt_engineerid.Size = New System.Drawing.Size(280, 25)
        Me.Txt_engineerid.TabIndex = 5
        '
        'Txt_contactno
        '
        Me.Txt_contactno.BackColor = System.Drawing.Color.White
        Me.Txt_contactno.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_contactno.ForeColor = System.Drawing.Color.LightGray
        Me.Txt_contactno.Location = New System.Drawing.Point(189, 131)
        Me.Txt_contactno.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_contactno.Name = "Txt_contactno"
        Me.Txt_contactno.Size = New System.Drawing.Size(280, 25)
        Me.Txt_contactno.TabIndex = 6
        '
        'Txt_emailid
        '
        Me.Txt_emailid.BackColor = System.Drawing.Color.White
        Me.Txt_emailid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_emailid.ForeColor = System.Drawing.Color.LightGray
        Me.Txt_emailid.Location = New System.Drawing.Point(192, 173)
        Me.Txt_emailid.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_emailid.Name = "Txt_emailid"
        Me.Txt_emailid.Size = New System.Drawing.Size(280, 25)
        Me.Txt_emailid.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 209)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Address:"
        '
        'Txt_address
        '
        Me.Txt_address.BackColor = System.Drawing.Color.White
        Me.Txt_address.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_address.ForeColor = System.Drawing.Color.LightGray
        Me.Txt_address.Location = New System.Drawing.Point(189, 206)
        Me.Txt_address.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_address.Multiline = True
        Me.Txt_address.Name = "Txt_address"
        Me.Txt_address.Size = New System.Drawing.Size(280, 58)
        Me.Txt_address.TabIndex = 9
        '
        'Lbl_workonpc
        '
        Me.Lbl_workonpc.AutoSize = True
        Me.Lbl_workonpc.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_workonpc.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_workonpc.Location = New System.Drawing.Point(81, 281)
        Me.Lbl_workonpc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_workonpc.Name = "Lbl_workonpc"
        Me.Lbl_workonpc.Size = New System.Drawing.Size(84, 17)
        Me.Lbl_workonpc.TabIndex = 10
        Me.Lbl_workonpc.Text = "Work_on_pc:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.LightGray
        Me.TextBox1.Location = New System.Drawing.Point(192, 281)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(280, 25)
        Me.TextBox1.TabIndex = 11
        '
        'lbl_Typefiled
        '
        Me.lbl_Typefiled.AutoSize = True
        Me.lbl_Typefiled.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Typefiled.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Typefiled.Location = New System.Drawing.Point(77, 319)
        Me.lbl_Typefiled.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Typefiled.Name = "lbl_Typefiled"
        Me.lbl_Typefiled.Size = New System.Drawing.Size(88, 17)
        Me.lbl_Typefiled.TabIndex = 13
        Me.lbl_Typefiled.Text = "Type of Filed:"
        '
        'Txt_typeoffiled
        '
        Me.Txt_typeoffiled.BackColor = System.Drawing.Color.White
        Me.Txt_typeoffiled.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_typeoffiled.ForeColor = System.Drawing.Color.LightGray
        Me.Txt_typeoffiled.Location = New System.Drawing.Point(192, 319)
        Me.Txt_typeoffiled.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_typeoffiled.Name = "Txt_typeoffiled"
        Me.Txt_typeoffiled.Size = New System.Drawing.Size(280, 25)
        Me.Txt_typeoffiled.TabIndex = 14
        '
        'Btn_Submit
        '
        Me.Btn_Submit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Submit.Location = New System.Drawing.Point(140, 378)
        Me.Btn_Submit.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Size = New System.Drawing.Size(100, 30)
        Me.Btn_Submit.TabIndex = 15
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'Btn_cancel
        '
        Me.Btn_cancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cancel.Location = New System.Drawing.Point(274, 378)
        Me.Btn_cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(100, 30)
        Me.Btn_cancel.TabIndex = 16
        Me.Btn_cancel.Text = "Cancel"
        Me.Btn_cancel.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Help Desk"
        '
        'Engineer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Helpdesk.My.Resources.Resources.images__4_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(544, 431)
        Me.Controls.Add(Me.Btn_cancel)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.Txt_typeoffiled)
        Me.Controls.Add(Me.lbl_Typefiled)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Lbl_workonpc)
        Me.Controls.Add(Me.Txt_address)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_emailid)
        Me.Controls.Add(Me.Txt_contactno)
        Me.Controls.Add(Me.Txt_engineerid)
        Me.Controls.Add(Me.Txt_engineername)
        Me.Controls.Add(Me.Lbl_emailid)
        Me.Controls.Add(Me.Lbl_contactno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_engineername)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Engineer"
        Me.Text = resources.GetString("$this.Text")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_engineername As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_contactno As System.Windows.Forms.Label
    Friend WithEvents Lbl_emailid As System.Windows.Forms.Label
    Friend WithEvents Txt_engineername As System.Windows.Forms.TextBox
    Friend WithEvents Txt_engineerid As System.Windows.Forms.TextBox
    Friend WithEvents Txt_contactno As System.Windows.Forms.TextBox
    Friend WithEvents Txt_emailid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_address As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_workonpc As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Typefiled As System.Windows.Forms.Label
    Friend WithEvents Txt_typeoffiled As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Submit As System.Windows.Forms.Button
    Friend WithEvents Btn_cancel As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
