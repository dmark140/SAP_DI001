<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_finder
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Item_arrow = New System.Windows.Forms.Button()
        Me.txt_itemmaster = New System.Windows.Forms.TextBox()
        Me.txt_title = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_Item_arrow)
        Me.Panel2.Controls.Add(Me.txt_itemmaster)
        Me.Panel2.Controls.Add(Me.txt_title)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(141, 38)
        Me.Panel2.TabIndex = 109
        '
        'btn_Item_arrow
        '
        Me.btn_Item_arrow.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_Item_arrow.BackgroundImage = Global.IpicIndirect.My.Resources.Resources.icons8_arrow_96
        Me.btn_Item_arrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Item_arrow.FlatAppearance.BorderSize = 0
        Me.btn_Item_arrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Item_arrow.Location = New System.Drawing.Point(121, 18)
        Me.btn_Item_arrow.Name = "btn_Item_arrow"
        Me.btn_Item_arrow.Size = New System.Drawing.Size(17, 18)
        Me.btn_Item_arrow.TabIndex = 108
        Me.btn_Item_arrow.UseVisualStyleBackColor = True
        '
        'txt_itemmaster
        '
        Me.txt_itemmaster.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_itemmaster.Location = New System.Drawing.Point(0, 17)
        Me.txt_itemmaster.Name = "txt_itemmaster"
        Me.txt_itemmaster.Size = New System.Drawing.Size(141, 20)
        Me.txt_itemmaster.TabIndex = 107
        Me.txt_itemmaster.TabStop = False
        '
        'txt_title
        '
        Me.txt_title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_title.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_title.Location = New System.Drawing.Point(0, 0)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(141, 17)
        Me.txt_title.TabIndex = 106
        Me.txt_title.Text = "EDIT iTEXT To EDIT ME"
        '
        'uc_finder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Name = "uc_finder"
        Me.Size = New System.Drawing.Size(143, 40)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_Item_arrow As Button
    Friend WithEvents txt_itemmaster As TextBox
    Friend WithEvents txt_title As Label
End Class
