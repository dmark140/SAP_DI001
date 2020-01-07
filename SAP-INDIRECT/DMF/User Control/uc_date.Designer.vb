<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_date
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
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_text = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtp_date
        '
        Me.dtp_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_date.CustomFormat = "MM.dd.yyyy"
        Me.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_date.Location = New System.Drawing.Point(179, 0)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(172, 20)
        Me.dtp_date.TabIndex = 103
        '
        'lbl_text
        '
        Me.lbl_text.BackColor = System.Drawing.Color.Transparent
        Me.lbl_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_text.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_text.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbl_text.Location = New System.Drawing.Point(-2, -2)
        Me.lbl_text.Name = "lbl_text"
        Me.lbl_text.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lbl_text.Size = New System.Drawing.Size(182, 22)
        Me.lbl_text.TabIndex = 104
        Me.lbl_text.Text = "Production Order Selection"
        '
        'uc_date
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.lbl_text)
        Me.Controls.Add(Me.dtp_date)
        Me.Name = "uc_date"
        Me.Size = New System.Drawing.Size(351, 25)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtp_date As DateTimePicker
    Friend WithEvents lbl_text As Label
End Class
