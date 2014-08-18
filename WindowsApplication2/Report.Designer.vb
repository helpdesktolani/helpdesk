<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.Lbl_startdate = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Enddate = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Btn_search = New System.Windows.Forms.Button()
        Me.Btn_cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_startdate
        '
        Me.Lbl_startdate.AutoSize = True
        Me.Lbl_startdate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_startdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_startdate.Location = New System.Drawing.Point(44, 115)
        Me.Lbl_startdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_startdate.Name = "Lbl_startdate"
        Me.Lbl_startdate.Size = New System.Drawing.Size(75, 17)
        Me.Lbl_startdate.TabIndex = 0
        Me.Lbl_startdate.Text = "From Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(123, 115)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 25)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Lbl_Enddate
        '
        Me.Lbl_Enddate.AutoSize = True
        Me.Lbl_Enddate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Enddate.Location = New System.Drawing.Point(47, 170)
        Me.Lbl_Enddate.Name = "Lbl_Enddate"
        Me.Lbl_Enddate.Size = New System.Drawing.Size(58, 17)
        Me.Lbl_Enddate.TabIndex = 2
        Me.Lbl_Enddate.Text = "To Date:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(123, 170)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 25)
        Me.DateTimePicker2.TabIndex = 3
        '
        'Btn_search
        '
        Me.Btn_search.Location = New System.Drawing.Point(64, 248)
        Me.Btn_search.Name = "Btn_search"
        Me.Btn_search.Size = New System.Drawing.Size(75, 26)
        Me.Btn_search.TabIndex = 4
        Me.Btn_search.Text = "Search"
        Me.Btn_search.UseVisualStyleBackColor = True
        '
        'Btn_cancel
        '
        Me.Btn_cancel.Location = New System.Drawing.Point(172, 250)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(75, 24)
        Me.Btn_cancel.TabIndex = 5
        Me.Btn_cancel.Text = "Cancel"
        Me.Btn_cancel.UseVisualStyleBackColor = True
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Helpdesk.My.Resources.Resources.images__4_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(455, 373)
        Me.Controls.Add(Me.Btn_cancel)
        Me.Controls.Add(Me.Btn_search)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Lbl_Enddate)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Lbl_startdate)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Report"
        Me.Text = "Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_startdate As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Enddate As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Btn_search As System.Windows.Forms.Button
    Friend WithEvents Btn_cancel As System.Windows.Forms.Button
End Class
