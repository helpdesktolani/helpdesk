<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Engineerallowcation
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
        Me.Lbl_solutionid = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_engineerid = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Lbl_clientid = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btn_allowcate = New System.Windows.Forms.Button()
        Me.Btn_cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_solutionid
        '
        Me.Lbl_solutionid.AutoSize = True
        Me.Lbl_solutionid.Location = New System.Drawing.Point(69, 77)
        Me.Lbl_solutionid.Name = "Lbl_solutionid"
        Me.Lbl_solutionid.Size = New System.Drawing.Size(78, 17)
        Me.Lbl_solutionid.TabIndex = 0
        Me.Lbl_solutionid.Text = "Solution_Id:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(165, 77)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(186, 25)
        Me.TextBox1.TabIndex = 1
        '
        'lbl_engineerid
        '
        Me.lbl_engineerid.AutoSize = True
        Me.lbl_engineerid.Location = New System.Drawing.Point(69, 123)
        Me.lbl_engineerid.Name = "lbl_engineerid"
        Me.lbl_engineerid.Size = New System.Drawing.Size(81, 17)
        Me.lbl_engineerid.TabIndex = 2
        Me.lbl_engineerid.Text = "Engineer_Id:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(165, 120)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(186, 25)
        Me.ComboBox1.TabIndex = 3
        '
        'Lbl_clientid
        '
        Me.Lbl_clientid.AutoSize = True
        Me.Lbl_clientid.Location = New System.Drawing.Point(86, 170)
        Me.Lbl_clientid.Name = "Lbl_clientid"
        Me.Lbl_clientid.Size = New System.Drawing.Size(62, 17)
        Me.Lbl_clientid.TabIndex = 4
        Me.Lbl_clientid.Text = "Client_Id:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(165, 170)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(186, 25)
        Me.TextBox2.TabIndex = 5
        '
        'btn_allowcate
        '
        Me.btn_allowcate.Location = New System.Drawing.Point(165, 258)
        Me.btn_allowcate.Name = "btn_allowcate"
        Me.btn_allowcate.Size = New System.Drawing.Size(75, 23)
        Me.btn_allowcate.TabIndex = 6
        Me.btn_allowcate.Text = "allowcate"
        Me.btn_allowcate.UseVisualStyleBackColor = True
        '
        'Btn_cancel
        '
        Me.Btn_cancel.Location = New System.Drawing.Point(260, 258)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.Btn_cancel.TabIndex = 7
        Me.Btn_cancel.Text = "Cancel"
        Me.Btn_cancel.UseVisualStyleBackColor = True
        '
        'Engineerallowcation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 332)
        Me.Controls.Add(Me.Btn_cancel)
        Me.Controls.Add(Me.btn_allowcate)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Lbl_clientid)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lbl_engineerid)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Lbl_solutionid)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Engineerallowcation"
        Me.Text = "Engineerallowcation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_solutionid As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_engineerid As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_clientid As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btn_allowcate As System.Windows.Forms.Button
    Friend WithEvents Btn_cancel As System.Windows.Forms.Button
End Class
