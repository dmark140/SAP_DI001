<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_label
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_text = New System.Windows.Forms.Label()
        Me.inputBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_text
        '
        Me.lbl_text.BackColor = System.Drawing.Color.Transparent
        Me.lbl_text.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.lbl_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_text.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_text.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_text.Location = New System.Drawing.Point(-2, 0)
        Me.lbl_text.Name = "lbl_text"
        Me.lbl_text.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lbl_text.Size = New System.Drawing.Size(124, 20)
        Me.lbl_text.TabIndex = 74
        Me.lbl_text.Text = "Edit iLbl to edit me"
        Me.lbl_text.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lbl_text.UseWaitCursor = True
        '
        'inputBox
        '
        Me.inputBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputBox.Location = New System.Drawing.Point(119, 0)
        Me.inputBox.Name = "inputBox"
        Me.inputBox.Size = New System.Drawing.Size(228, 20)
        Me.inputBox.TabIndex = 73
        '
        'uc_label
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.inputBox)
        Me.Controls.Add(Me.lbl_text)
        Me.Name = "uc_label"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Size = New System.Drawing.Size(509, 20)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_text As Label
    Friend WithEvents inputBox As TextBox
End Class
