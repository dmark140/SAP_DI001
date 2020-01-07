<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_sub_Header
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
        Me.SuspendLayout()
        '
        'lbl_text
        '
        Me.lbl_text.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_text.BackColor = System.Drawing.Color.Transparent
        Me.lbl_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_text.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_text.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_text.Location = New System.Drawing.Point(14, 2)
        Me.lbl_text.Name = "lbl_text"
        Me.lbl_text.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_text.Size = New System.Drawing.Size(122, 23)
        Me.lbl_text.TabIndex = 75
        Me.lbl_text.Text = "Edit iLbl to edit me"
        '
        'uc_sub_Header
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.lbl_text)
        Me.Name = "uc_sub_Header"
        Me.Size = New System.Drawing.Size(150, 27)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_text As Label
End Class
