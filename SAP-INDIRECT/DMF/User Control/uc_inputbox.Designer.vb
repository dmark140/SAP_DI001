<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_inputbox
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
        Me.Textbox = New System.Windows.Forms.TextBox()
        Me.btn_Item_arrow = New System.Windows.Forms.Button()
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
        Me.lbl_text.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_text.Name = "lbl_text"
        Me.lbl_text.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.lbl_text.Size = New System.Drawing.Size(186, 25)
        Me.lbl_text.TabIndex = 72
        Me.lbl_text.Text = "Edit iLbl to edit me"
        Me.lbl_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Textbox
        '
        Me.Textbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Textbox.BackColor = System.Drawing.Color.White
        Me.Textbox.Location = New System.Drawing.Point(182, 0)
        Me.Textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox.Name = "Textbox"
        Me.Textbox.Size = New System.Drawing.Size(287, 22)
        Me.Textbox.TabIndex = 71
        '
        'btn_Item_arrow
        '
        Me.btn_Item_arrow.BackColor = System.Drawing.Color.Transparent
        Me.btn_Item_arrow.BackgroundImage = Global.IpicIndirect.My.Resources.Resources.GoldArrow2
        Me.btn_Item_arrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Item_arrow.FlatAppearance.BorderSize = 0
        Me.btn_Item_arrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Item_arrow.Location = New System.Drawing.Point(157, 1)
        Me.btn_Item_arrow.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Item_arrow.Name = "btn_Item_arrow"
        Me.btn_Item_arrow.Size = New System.Drawing.Size(21, 20)
        Me.btn_Item_arrow.TabIndex = 109
        Me.btn_Item_arrow.UseVisualStyleBackColor = False
        '
        'uc_inputbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Textbox)
        Me.Controls.Add(Me.btn_Item_arrow)
        Me.Controls.Add(Me.lbl_text)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "uc_inputbox"
        Me.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.Size = New System.Drawing.Size(472, 25)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_text As Label
    Friend WithEvents Textbox As TextBox
    Friend WithEvents btn_Item_arrow As Button
End Class
