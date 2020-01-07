<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dmf_ModuleGenerator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dmf_ModuleGenerator))
        Me.tvNode = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.txt_Code = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_author = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txt_text = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cb_ModuleNames = New System.Windows.Forms.ComboBox()
        Me.cb_stats = New System.Windows.Forms.ComboBox()
        Me.Uc_header1 = New IpicIndirect.uc_header()
        Me.Uc_label1 = New IpicIndirect.uc_label()
        Me.Uc_label2 = New IpicIndirect.uc_label()
        Me.Uc_label3 = New IpicIndirect.uc_label()
        Me.Uc_label4 = New IpicIndirect.uc_label()
        Me.Uc_label5 = New IpicIndirect.uc_label()
        Me.NUll_lbll = New IpicIndirect.uc_label()
        Me.Null_txt = New System.Windows.Forms.TextBox()
        Me.Uc_label6 = New IpicIndirect.uc_label()
        Me.SuspendLayout()
        '
        'tvNode
        '
        Me.tvNode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvNode.ForeColor = System.Drawing.Color.Black
        Me.tvNode.FullRowSelect = True
        Me.tvNode.HideSelection = False
        Me.tvNode.ItemHeight = 20
        Me.tvNode.Location = New System.Drawing.Point(16, 51)
        Me.tvNode.Name = "tvNode"
        Me.tvNode.PathSeparator = "-"
        Me.tvNode.ShowLines = False
        Me.tvNode.Size = New System.Drawing.Size(250, 384)
        Me.tvNode.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-triangle-arrow-24 - Copy.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8-triangle-arrow-24.png")
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(16, 441)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(89, 21)
        Me.btn_ok.TabIndex = 61
        Me.btn_ok.Text = "Save"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'txt_Code
        '
        Me.txt_Code.Enabled = False
        Me.txt_Code.Location = New System.Drawing.Point(415, 59)
        Me.txt_Code.Name = "txt_Code"
        Me.txt_Code.Size = New System.Drawing.Size(158, 20)
        Me.txt_Code.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(16, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(250, 17)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Menu Selector"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(180, 441)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 21)
        Me.Button2.TabIndex = 75
        Me.Button2.Text = "Cancel"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txt_author
        '
        Me.txt_author.Enabled = False
        Me.txt_author.Location = New System.Drawing.Point(415, 137)
        Me.txt_author.Name = "txt_author"
        Me.txt_author.Size = New System.Drawing.Size(158, 20)
        Me.txt_author.TabIndex = 79
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(579, 79)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(307, 104)
        Me.TextBox3.TabIndex = 85
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(579, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(307, 20)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Remarks"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(415, 235)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(471, 20)
        Me.TextBox4.TabIndex = 83
        '
        'txt_text
        '
        Me.txt_text.Location = New System.Drawing.Point(415, 111)
        Me.txt_text.Name = "txt_text"
        Me.txt_text.Size = New System.Drawing.Size(158, 20)
        Me.txt_text.TabIndex = 87
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(275, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(611, 17)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "Module Properties"
        '
        'cb_ModuleNames
        '
        Me.cb_ModuleNames.FormattingEnabled = True
        Me.cb_ModuleNames.Location = New System.Drawing.Point(415, 84)
        Me.cb_ModuleNames.Name = "cb_ModuleNames"
        Me.cb_ModuleNames.Size = New System.Drawing.Size(158, 21)
        Me.cb_ModuleNames.TabIndex = 89
        '
        'cb_stats
        '
        Me.cb_stats.FormattingEnabled = True
        Me.cb_stats.Items.AddRange(New Object() {"Inactive", "Active"})
        Me.cb_stats.Location = New System.Drawing.Point(415, 163)
        Me.cb_stats.Name = "cb_stats"
        Me.cb_stats.Size = New System.Drawing.Size(158, 21)
        Me.cb_stats.TabIndex = 90
        '
        'Uc_header1
        '
        Me.Uc_header1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_header1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Uc_header1.iFrom = Me
        Me.Uc_header1.iText = " Module Generator"
        Me.Uc_header1.Location = New System.Drawing.Point(0, 0)
        Me.Uc_header1.Name = "Uc_header1"
        Me.Uc_header1.Size = New System.Drawing.Size(923, 19)
        Me.Uc_header1.TabIndex = 91
        '
        'Uc_label1
        '
        Me.Uc_label1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label1.iAddition_SQL = Nothing
        Me.Uc_label1.iAdditional = Nothing
        Me.Uc_label1.idsc = Nothing
        Me.Uc_label1.iIsEnabled = True
        Me.Uc_label1.iIsForSearch = False
        Me.Uc_label1.iLabel = "Code"
        Me.Uc_label1.iLabel_width = 500
        Me.Uc_label1.isLabelBoldx = False
        Me.Uc_label1.iSQL_Parameter_ID = 0
        Me.Uc_label1.iText = ""
        Me.Uc_label1.Location = New System.Drawing.Point(278, 59)
        Me.Uc_label1.Name = "Uc_label1"
        Me.Uc_label1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label1.Size = New System.Drawing.Size(138, 20)
        Me.Uc_label1.TabIndex = 93
        '
        'Uc_label2
        '
        Me.Uc_label2.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label2.iAddition_SQL = Nothing
        Me.Uc_label2.iAdditional = Nothing
        Me.Uc_label2.idsc = Nothing
        Me.Uc_label2.iIsEnabled = True
        Me.Uc_label2.iIsForSearch = False
        Me.Uc_label2.iLabel = "Name"
        Me.Uc_label2.iLabel_width = 500
        Me.Uc_label2.isLabelBoldx = False
        Me.Uc_label2.iSQL_Parameter_ID = 0
        Me.Uc_label2.iText = ""
        Me.Uc_label2.Location = New System.Drawing.Point(278, 85)
        Me.Uc_label2.Name = "Uc_label2"
        Me.Uc_label2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label2.Size = New System.Drawing.Size(138, 20)
        Me.Uc_label2.TabIndex = 93
        '
        'Uc_label3
        '
        Me.Uc_label3.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label3.iAddition_SQL = Nothing
        Me.Uc_label3.iAdditional = Nothing
        Me.Uc_label3.idsc = Nothing
        Me.Uc_label3.iIsEnabled = True
        Me.Uc_label3.iIsForSearch = False
        Me.Uc_label3.iLabel = "Text"
        Me.Uc_label3.iLabel_width = 500
        Me.Uc_label3.isLabelBoldx = False
        Me.Uc_label3.iSQL_Parameter_ID = 0
        Me.Uc_label3.iText = ""
        Me.Uc_label3.Location = New System.Drawing.Point(278, 111)
        Me.Uc_label3.Name = "Uc_label3"
        Me.Uc_label3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label3.Size = New System.Drawing.Size(138, 20)
        Me.Uc_label3.TabIndex = 93
        '
        'Uc_label4
        '
        Me.Uc_label4.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label4.iAddition_SQL = Nothing
        Me.Uc_label4.iAdditional = Nothing
        Me.Uc_label4.idsc = Nothing
        Me.Uc_label4.iIsEnabled = True
        Me.Uc_label4.iIsForSearch = False
        Me.Uc_label4.iLabel = "Author"
        Me.Uc_label4.iLabel_width = 500
        Me.Uc_label4.isLabelBoldx = False
        Me.Uc_label4.iSQL_Parameter_ID = 0
        Me.Uc_label4.iText = ""
        Me.Uc_label4.Location = New System.Drawing.Point(278, 137)
        Me.Uc_label4.Name = "Uc_label4"
        Me.Uc_label4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label4.Size = New System.Drawing.Size(138, 20)
        Me.Uc_label4.TabIndex = 93
        '
        'Uc_label5
        '
        Me.Uc_label5.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label5.iAddition_SQL = Nothing
        Me.Uc_label5.iAdditional = Nothing
        Me.Uc_label5.idsc = Nothing
        Me.Uc_label5.iIsEnabled = True
        Me.Uc_label5.iIsForSearch = False
        Me.Uc_label5.iLabel = "Status"
        Me.Uc_label5.iLabel_width = 500
        Me.Uc_label5.isLabelBoldx = False
        Me.Uc_label5.iSQL_Parameter_ID = 0
        Me.Uc_label5.iText = ""
        Me.Uc_label5.Location = New System.Drawing.Point(278, 164)
        Me.Uc_label5.Name = "Uc_label5"
        Me.Uc_label5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label5.Size = New System.Drawing.Size(138, 20)
        Me.Uc_label5.TabIndex = 93
        '
        'NUll_lbll
        '
        Me.NUll_lbll.BackColor = System.Drawing.Color.Transparent
        Me.NUll_lbll.iAddition_SQL = Nothing
        Me.NUll_lbll.iAdditional = Nothing
        Me.NUll_lbll.idsc = Nothing
        Me.NUll_lbll.iIsEnabled = True
        Me.NUll_lbll.iIsForSearch = False
        Me.NUll_lbll.iLabel = "Code"
        Me.NUll_lbll.iLabel_width = 500
        Me.NUll_lbll.isLabelBoldx = False
        Me.NUll_lbll.iSQL_Parameter_ID = 0
        Me.NUll_lbll.iText = ""
        Me.NUll_lbll.Location = New System.Drawing.Point(569, 386)
        Me.NUll_lbll.Name = "NUll_lbll"
        Me.NUll_lbll.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.NUll_lbll.Size = New System.Drawing.Size(20, 20)
        Me.NUll_lbll.TabIndex = 93
        Me.NUll_lbll.Visible = False
        '
        'Null_txt
        '
        Me.Null_txt.Enabled = False
        Me.Null_txt.Location = New System.Drawing.Point(569, 360)
        Me.Null_txt.Name = "Null_txt"
        Me.Null_txt.Size = New System.Drawing.Size(20, 20)
        Me.Null_txt.TabIndex = 83
        Me.Null_txt.Visible = False
        '
        'Uc_label6
        '
        Me.Uc_label6.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label6.iAddition_SQL = Nothing
        Me.Uc_label6.iAdditional = Nothing
        Me.Uc_label6.idsc = Nothing
        Me.Uc_label6.iIsEnabled = True
        Me.Uc_label6.iIsForSearch = False
        Me.Uc_label6.iLabel = "Location"
        Me.Uc_label6.iLabel_width = 500
        Me.Uc_label6.isLabelBoldx = False
        Me.Uc_label6.iSQL_Parameter_ID = 0
        Me.Uc_label6.iText = ""
        Me.Uc_label6.Location = New System.Drawing.Point(278, 235)
        Me.Uc_label6.Name = "Uc_label6"
        Me.Uc_label6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label6.Size = New System.Drawing.Size(138, 20)
        Me.Uc_label6.TabIndex = 93
        '
        'dmf_ModuleGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 474)
        Me.Controls.Add(Me.Uc_header1)
        Me.Controls.Add(Me.cb_stats)
        Me.Controls.Add(Me.cb_ModuleNames)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_text)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Null_txt)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.txt_author)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Code)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.tvNode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Uc_label6)
        Me.Controls.Add(Me.Uc_label5)
        Me.Controls.Add(Me.Uc_label4)
        Me.Controls.Add(Me.Uc_label3)
        Me.Controls.Add(Me.Uc_label2)
        Me.Controls.Add(Me.NUll_lbll)
        Me.Controls.Add(Me.Uc_label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dmf_ModuleGenerator"
        Me.Text = "dmf_ModuleGenerator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tvNode As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btn_ok As Button
    Friend WithEvents txt_Code As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txt_author As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_text As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cb_ModuleNames As ComboBox
    Friend WithEvents cb_stats As ComboBox
    Friend WithEvents Uc_header1 As uc_header
    Friend WithEvents NUll_lbll As uc_label
    Friend WithEvents Null_txt As TextBox
    Friend WithEvents Uc_label5 As uc_label
    Friend WithEvents Uc_label4 As uc_label
    Friend WithEvents Uc_label3 As uc_label
    Friend WithEvents Uc_label2 As uc_label
    Friend WithEvents Uc_label1 As uc_label
    Friend WithEvents Uc_label6 As uc_label
End Class
