<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_time
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.dt_time = New System.Windows.Forms.DateTimePicker()
        Me.lbl_text = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dt_time
        '
        Me.dt_time.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dt_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_time.Location = New System.Drawing.Point(148, 0)
        Me.dt_time.Name = "dt_time"
        Me.dt_time.ShowUpDown = True
        Me.dt_time.Size = New System.Drawing.Size(98, 20)
        Me.dt_time.TabIndex = 6
        Me.dt_time.Value = New Date(2020, 2, 25, 15, 15, 0, 0)
        '
        'lbl_text
        '
        Me.lbl_text.BackColor = System.Drawing.Color.Transparent
        Me.lbl_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_text.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_text.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbl_text.Location = New System.Drawing.Point(-8, -3)
        Me.lbl_text.Name = "lbl_text"
        Me.lbl_text.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lbl_text.Size = New System.Drawing.Size(129, 23)
        Me.lbl_text.TabIndex = 105
        Me.lbl_text.Text = "Production Order Selection"
        Me.lbl_text.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'uc_time
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.dt_time)
        Me.Controls.Add(Me.lbl_text)
        Me.Name = "uc_time"
        Me.Size = New System.Drawing.Size(244, 27)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dt_time As DateTimePicker
    Friend WithEvents lbl_text As Label
End Class
