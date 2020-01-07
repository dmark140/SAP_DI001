<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_inputbox
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
        Me.components = New System.ComponentModel.Container()
        Me.lbl_text = New System.Windows.Forms.Label()
        Me.cms_copy = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Textbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_Item_arrow = New System.Windows.Forms.Button()
        Me.cms_copy.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_text
        '
        Me.lbl_text.BackColor = System.Drawing.Color.Transparent
        Me.lbl_text.ContextMenuStrip = Me.cms_copy
        Me.lbl_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_text.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.lbl_text.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_text.Location = New System.Drawing.Point(-2, 0)
        Me.lbl_text.Name = "lbl_text"
        Me.lbl_text.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lbl_text.Size = New System.Drawing.Size(140, 20)
        Me.lbl_text.TabIndex = 72
        Me.lbl_text.Text = "Edit iLbl to edit me"
        Me.lbl_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cms_copy
        '
        Me.cms_copy.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_copy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.cms_copy.Name = "ContextMenuStrip1"
        Me.cms_copy.Size = New System.Drawing.Size(190, 92)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(189, 22)
        Me.ToolStripMenuItem1.Text = "Copy Value"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(189, 22)
        Me.ToolStripMenuItem2.Text = "Copy Linking Address"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(189, 22)
        Me.ToolStripMenuItem3.Text = "Clear"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(189, 22)
        Me.ToolStripMenuItem4.Text = "Cancel"
        '
        'Textbox
        '
        Me.Textbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Textbox.BackColor = System.Drawing.Color.White
        Me.Textbox.Location = New System.Drawing.Point(146, 0)
        Me.Textbox.Name = "Textbox"
        Me.Textbox.Size = New System.Drawing.Size(216, 20)
        Me.Textbox.TabIndex = 71
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.IpicIndirect.My.Resources.Resources.icons8_minus_48
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(343, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 16)
        Me.Button1.TabIndex = 110
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'btn_Item_arrow
        '
        Me.btn_Item_arrow.BackColor = System.Drawing.Color.Transparent
        Me.btn_Item_arrow.BackgroundImage = Global.IpicIndirect.My.Resources.Resources.GoldArrow2
        Me.btn_Item_arrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Item_arrow.FlatAppearance.BorderSize = 0
        Me.btn_Item_arrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Item_arrow.Location = New System.Drawing.Point(118, 1)
        Me.btn_Item_arrow.Name = "btn_Item_arrow"
        Me.btn_Item_arrow.Size = New System.Drawing.Size(16, 16)
        Me.btn_Item_arrow.TabIndex = 109
        Me.btn_Item_arrow.UseVisualStyleBackColor = False
        '
        'uc_inputbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Textbox)
        Me.Controls.Add(Me.btn_Item_arrow)
        Me.Controls.Add(Me.lbl_text)
        Me.Name = "uc_inputbox"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Size = New System.Drawing.Size(364, 26)
        Me.cms_copy.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_text As Label
    Friend WithEvents Textbox As TextBox
    Friend WithEvents btn_Item_arrow As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cms_copy As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
End Class
