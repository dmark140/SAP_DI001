<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_dropdown
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
        Me.lbl_text = New System.Windows.Forms.Label()
        Me.cb_list = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbl_text
        '
        Me.lbl_text.BackColor = System.Drawing.Color.Transparent
        Me.lbl_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_text.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_text.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_text.Location = New System.Drawing.Point(-2, -3)
        Me.lbl_text.Name = "lbl_text"
        Me.lbl_text.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lbl_text.Size = New System.Drawing.Size(123, 24)
        Me.lbl_text.TabIndex = 76
        Me.lbl_text.Text = "Edit iLbl to edit me"
        Me.lbl_text.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cb_list
        '
        Me.cb_list.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.cb_list.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_list.FormattingEnabled = True
        Me.cb_list.Location = New System.Drawing.Point(120, 0)
        Me.cb_list.Name = "cb_list"
        Me.cb_list.Size = New System.Drawing.Size(205, 21)
        Me.cb_list.TabIndex = 77
        '
        'uc_dropdown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.cb_list)
        Me.Controls.Add(Me.lbl_text)
        Me.Name = "uc_dropdown"
        Me.Size = New System.Drawing.Size(325, 23)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_text As Label
    Friend WithEvents cb_list As ComboBox
End Class
