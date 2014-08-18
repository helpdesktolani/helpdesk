<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Status
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
        Me.Btn_cancel = New System.Windows.Forms.Button()
        Me.Btn_search = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Enddate = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_startdate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_cancel
        '
        Me.Btn_cancel.Location = New System.Drawing.Point(300, 296)
        Me.Btn_cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(87, 31)
        Me.Btn_cancel.TabIndex = 11
        Me.Btn_cancel.Text = "Cancel"
        Me.Btn_cancel.UseVisualStyleBackColor = True
        '
        'Btn_search
        '
        Me.Btn_search.Location = New System.Drawing.Point(176, 293)
        Me.Btn_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_search.Name = "Btn_search"
        Me.Btn_search.Size = New System.Drawing.Size(87, 34)
        Me.Btn_search.TabIndex = 10
        Me.Btn_search.Text = "Search"
        Me.Btn_search.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(248, 216)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(233, 25)
        Me.DateTimePicker2.TabIndex = 9
        '
        'Lbl_Enddate
        '
        Me.Lbl_Enddate.AutoSize = True
        Me.Lbl_Enddate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Enddate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Enddate.Location = New System.Drawing.Point(173, 216)
        Me.Lbl_Enddate.Name = "Lbl_Enddate"
        Me.Lbl_Enddate.Size = New System.Drawing.Size(58, 17)
        Me.Lbl_Enddate.TabIndex = 8
        Me.Lbl_Enddate.Text = "To Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(248, 165)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(233, 25)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Lbl_startdate
        '
        Me.Lbl_startdate.AutoSize = True
        Me.Lbl_startdate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_startdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_startdate.Location = New System.Drawing.Point(156, 165)
        Me.Lbl_startdate.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lbl_startdate.Name = "Lbl_startdate"
        Me.Lbl_startdate.Size = New System.Drawing.Size(75, 17)
        Me.Lbl_startdate.TabIndex = 6
        Me.Lbl_startdate.Text = "From Date:"
        '
        'Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 536)
        Me.Controls.Add(Me.Btn_cancel)
        Me.Controls.Add(Me.Btn_search)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Lbl_Enddate)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Lbl_startdate)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Status"
        Me.Text = "Status"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_cancel As System.Windows.Forms.Button
    Friend WithEvents Btn_search As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Enddate As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_startdate As System.Windows.Forms.Label
End Class
