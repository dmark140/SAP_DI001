<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocumentDraft
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.uc_itemcode = New IpicIndirect.uc_inputbox()
        Me.uc_itemcode_lbl = New IpicIndirect.uc_label()
        Me.uc_itemcode_txt = New System.Windows.Forms.TextBox()
        Me.Uc_label1 = New IpicIndirect.uc_label()
        Me.Uc_label2 = New IpicIndirect.uc_label()
        Me.Uc_label3 = New IpicIndirect.uc_label()
        Me.Uc_label4 = New IpicIndirect.uc_label()
        Me.Uc_label5 = New IpicIndirect.uc_label()
        Me.Uc_label7 = New IpicIndirect.uc_label()
        Me.Uc_label9 = New IpicIndirect.uc_label()
        Me.Uc_label10 = New IpicIndirect.uc_label()
        Me.Uc_label11 = New IpicIndirect.uc_label()
        Me.Uc_label12 = New IpicIndirect.uc_label()
        Me.Uc_label14 = New IpicIndirect.uc_label()
        Me.Uc_label15 = New IpicIndirect.uc_label()
        Me.Uc_label16 = New IpicIndirect.uc_label()
        Me.Uc_label8 = New IpicIndirect.uc_label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Uc_label6 = New IpicIndirect.uc_label()
        Me.Uc_inputbox1 = New IpicIndirect.uc_inputbox()
        Me.Uc_label13 = New IpicIndirect.uc_label()
        Me.lbl_text = New System.Windows.Forms.Label()
        Me.Uc_label17 = New IpicIndirect.uc_label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_Item_arrow = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.Location = New System.Drawing.Point(10, 36)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(400, 531)
        Me.dgv.TabIndex = 92
        '
        'uc_itemcode
        '
        Me.uc_itemcode.BackColor = System.Drawing.Color.Transparent
        Me.uc_itemcode.iAdditional = Nothing
        Me.uc_itemcode.iArrow_Visible = True
        Me.uc_itemcode.iCanFindLabel_SQLIDx = 0
        Me.uc_itemcode.iCharacterLimit = 0
        Me.uc_itemcode.idsc = Me.uc_itemcode_lbl
        Me.uc_itemcode.iForm = Me
        Me.uc_itemcode.iIsDropDown = True
        Me.uc_itemcode.iIsEnabled = False
        Me.uc_itemcode.iIsForSearch = True
        Me.uc_itemcode.iIsID = False
        Me.uc_itemcode.iIsInnerShow = True
        Me.uc_itemcode.iLabel = "Draft Type"
        Me.uc_itemcode.iLabel_width = 100
        Me.uc_itemcode.isAllowEmptyx = False
        Me.uc_itemcode.isForFind = True
        Me.uc_itemcode.iSQL_Parameter_ID = 161
        Me.uc_itemcode.iSQL_Parameter_ID_FIND = 168
        Me.uc_itemcode.iText = ""
        Me.uc_itemcode.iTextBox_ = Me.uc_itemcode_txt
        Me.uc_itemcode.iTextBox_Sel_COL_ID = 0
        Me.uc_itemcode.iTitle = ""
        Me.uc_itemcode.LinkedColumn = "code"
        Me.uc_itemcode.Location = New System.Drawing.Point(10, 10)
        Me.uc_itemcode.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_itemcode.Name = "uc_itemcode"
        Me.uc_itemcode.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_itemcode.Size = New System.Drawing.Size(146, 20)
        Me.uc_itemcode.TabIndex = 168
        '
        'uc_itemcode_lbl
        '
        Me.uc_itemcode_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_itemcode_lbl.iAddition_SQL = Nothing
        Me.uc_itemcode_lbl.iAdditional = Nothing
        Me.uc_itemcode_lbl.idsc = Nothing
        Me.uc_itemcode_lbl.iIsEnabled = True
        Me.uc_itemcode_lbl.iIsForSearch = False
        Me.uc_itemcode_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_itemcode_lbl.iLabel_width = 5
        Me.uc_itemcode_lbl.isLabelBoldx = False
        Me.uc_itemcode_lbl.iSQL_Parameter_ID = 0
        Me.uc_itemcode_lbl.iText = ""
        Me.uc_itemcode_lbl.LinkedColumn = ""
        Me.uc_itemcode_lbl.Location = New System.Drawing.Point(158, 10)
        Me.uc_itemcode_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_itemcode_lbl.Name = "uc_itemcode_lbl"
        Me.uc_itemcode_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_itemcode_lbl.Size = New System.Drawing.Size(199, 20)
        Me.uc_itemcode_lbl.TabIndex = 169
        '
        'uc_itemcode_txt
        '
        Me.uc_itemcode_txt.Location = New System.Drawing.Point(361, 10)
        Me.uc_itemcode_txt.Name = "uc_itemcode_txt"
        Me.uc_itemcode_txt.Size = New System.Drawing.Size(23, 20)
        Me.uc_itemcode_txt.TabIndex = 170
        Me.uc_itemcode_txt.Visible = False
        '
        'Uc_label1
        '
        Me.Uc_label1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label1.iAddition_SQL = Nothing
        Me.Uc_label1.iAdditional = Nothing
        Me.Uc_label1.idsc = Nothing
        Me.Uc_label1.iIsEnabled = False
        Me.Uc_label1.iIsForSearch = False
        Me.Uc_label1.iLabel = "Requested By"
        Me.Uc_label1.iLabel_width = 155
        Me.Uc_label1.isLabelBoldx = False
        Me.Uc_label1.iSQL_Parameter_ID = 0
        Me.Uc_label1.iText = ""
        Me.Uc_label1.LinkedColumn = ""
        Me.Uc_label1.Location = New System.Drawing.Point(425, 94)
        Me.Uc_label1.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label1.Name = "Uc_label1"
        Me.Uc_label1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label1.Size = New System.Drawing.Size(324, 26)
        Me.Uc_label1.TabIndex = 172
        '
        'Uc_label2
        '
        Me.Uc_label2.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label2.iAddition_SQL = Nothing
        Me.Uc_label2.iAdditional = Nothing
        Me.Uc_label2.idsc = Nothing
        Me.Uc_label2.iIsEnabled = False
        Me.Uc_label2.iIsForSearch = False
        Me.Uc_label2.iLabel = "Status"
        Me.Uc_label2.iLabel_width = 155
        Me.Uc_label2.isLabelBoldx = False
        Me.Uc_label2.iSQL_Parameter_ID = 0
        Me.Uc_label2.iText = ""
        Me.Uc_label2.LinkedColumn = ""
        Me.Uc_label2.Location = New System.Drawing.Point(425, 122)
        Me.Uc_label2.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label2.Name = "Uc_label2"
        Me.Uc_label2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label2.Size = New System.Drawing.Size(324, 26)
        Me.Uc_label2.TabIndex = 172
        '
        'Uc_label3
        '
        Me.Uc_label3.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label3.iAddition_SQL = Nothing
        Me.Uc_label3.iAdditional = Nothing
        Me.Uc_label3.idsc = Nothing
        Me.Uc_label3.iIsEnabled = False
        Me.Uc_label3.iIsForSearch = False
        Me.Uc_label3.iLabel = "Document Draft No."
        Me.Uc_label3.iLabel_width = 155
        Me.Uc_label3.isLabelBoldx = False
        Me.Uc_label3.iSQL_Parameter_ID = 0
        Me.Uc_label3.iText = ""
        Me.Uc_label3.LinkedColumn = ""
        Me.Uc_label3.Location = New System.Drawing.Point(425, 150)
        Me.Uc_label3.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label3.Name = "Uc_label3"
        Me.Uc_label3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label3.Size = New System.Drawing.Size(324, 26)
        Me.Uc_label3.TabIndex = 172
        '
        'Uc_label4
        '
        Me.Uc_label4.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label4.iAddition_SQL = Nothing
        Me.Uc_label4.iAdditional = Nothing
        Me.Uc_label4.idsc = Nothing
        Me.Uc_label4.iIsEnabled = False
        Me.Uc_label4.iIsForSearch = False
        Me.Uc_label4.iLabel = "Document No."
        Me.Uc_label4.iLabel_width = 155
        Me.Uc_label4.isLabelBoldx = False
        Me.Uc_label4.iSQL_Parameter_ID = 0
        Me.Uc_label4.iText = ""
        Me.Uc_label4.LinkedColumn = ""
        Me.Uc_label4.Location = New System.Drawing.Point(805, 150)
        Me.Uc_label4.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label4.Name = "Uc_label4"
        Me.Uc_label4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label4.Size = New System.Drawing.Size(324, 26)
        Me.Uc_label4.TabIndex = 172
        '
        'Uc_label5
        '
        Me.Uc_label5.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label5.iAddition_SQL = Nothing
        Me.Uc_label5.iAdditional = Nothing
        Me.Uc_label5.idsc = Nothing
        Me.Uc_label5.iIsEnabled = False
        Me.Uc_label5.iIsForSearch = False
        Me.Uc_label5.iLabel = "Document"
        Me.Uc_label5.iLabel_width = 155
        Me.Uc_label5.isLabelBoldx = False
        Me.Uc_label5.iSQL_Parameter_ID = 0
        Me.Uc_label5.iText = ""
        Me.Uc_label5.LinkedColumn = ""
        Me.Uc_label5.Location = New System.Drawing.Point(805, 94)
        Me.Uc_label5.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label5.Name = "Uc_label5"
        Me.Uc_label5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label5.Size = New System.Drawing.Size(324, 26)
        Me.Uc_label5.TabIndex = 172
        '
        'Uc_label7
        '
        Me.Uc_label7.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label7.iAddition_SQL = Nothing
        Me.Uc_label7.iAdditional = Nothing
        Me.Uc_label7.idsc = Nothing
        Me.Uc_label7.iIsEnabled = False
        Me.Uc_label7.iIsForSearch = False
        Me.Uc_label7.iLabel = "Document Draft Internal ID"
        Me.Uc_label7.iLabel_width = 155
        Me.Uc_label7.isLabelBoldx = False
        Me.Uc_label7.iSQL_Parameter_ID = 0
        Me.Uc_label7.iText = ""
        Me.Uc_label7.LinkedColumn = ""
        Me.Uc_label7.Location = New System.Drawing.Point(805, 122)
        Me.Uc_label7.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label7.Name = "Uc_label7"
        Me.Uc_label7.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label7.Size = New System.Drawing.Size(324, 26)
        Me.Uc_label7.TabIndex = 172
        '
        'Uc_label9
        '
        Me.Uc_label9.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label9.iAddition_SQL = Nothing
        Me.Uc_label9.iAdditional = Nothing
        Me.Uc_label9.idsc = Nothing
        Me.Uc_label9.iIsEnabled = True
        Me.Uc_label9.iIsForSearch = False
        Me.Uc_label9.iLabel = "Document Details"
        Me.Uc_label9.iLabel_width = 11111
        Me.Uc_label9.isLabelBoldx = True
        Me.Uc_label9.iSQL_Parameter_ID = 0
        Me.Uc_label9.iText = ""
        Me.Uc_label9.LinkedColumn = ""
        Me.Uc_label9.Location = New System.Drawing.Point(425, 66)
        Me.Uc_label9.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label9.Name = "Uc_label9"
        Me.Uc_label9.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label9.Size = New System.Drawing.Size(146, 26)
        Me.Uc_label9.TabIndex = 172
        '
        'Uc_label10
        '
        Me.Uc_label10.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label10.iAddition_SQL = Nothing
        Me.Uc_label10.iAdditional = Nothing
        Me.Uc_label10.idsc = Nothing
        Me.Uc_label10.iIsEnabled = True
        Me.Uc_label10.iIsForSearch = False
        Me.Uc_label10.iLabel = "Authorization Details"
        Me.Uc_label10.iLabel_width = 11111
        Me.Uc_label10.isLabelBoldx = True
        Me.Uc_label10.iSQL_Parameter_ID = 0
        Me.Uc_label10.iText = ""
        Me.Uc_label10.LinkedColumn = ""
        Me.Uc_label10.Location = New System.Drawing.Point(425, 204)
        Me.Uc_label10.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label10.Name = "Uc_label10"
        Me.Uc_label10.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label10.Size = New System.Drawing.Size(166, 26)
        Me.Uc_label10.TabIndex = 172
        '
        'Uc_label11
        '
        Me.Uc_label11.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label11.iAddition_SQL = Nothing
        Me.Uc_label11.iAdditional = Nothing
        Me.Uc_label11.idsc = Nothing
        Me.Uc_label11.iIsEnabled = False
        Me.Uc_label11.iIsForSearch = False
        Me.Uc_label11.iLabel = "Document"
        Me.Uc_label11.iLabel_width = 155
        Me.Uc_label11.isLabelBoldx = False
        Me.Uc_label11.iSQL_Parameter_ID = 0
        Me.Uc_label11.iText = ""
        Me.Uc_label11.LinkedColumn = ""
        Me.Uc_label11.Location = New System.Drawing.Point(805, 232)
        Me.Uc_label11.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label11.Name = "Uc_label11"
        Me.Uc_label11.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label11.Size = New System.Drawing.Size(324, 26)
        Me.Uc_label11.TabIndex = 172
        '
        'Uc_label12
        '
        Me.Uc_label12.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label12.iAddition_SQL = Nothing
        Me.Uc_label12.iAdditional = Nothing
        Me.Uc_label12.idsc = Nothing
        Me.Uc_label12.iIsEnabled = False
        Me.Uc_label12.iIsForSearch = False
        Me.Uc_label12.iLabel = "Status"
        Me.Uc_label12.iLabel_width = 155
        Me.Uc_label12.isLabelBoldx = False
        Me.Uc_label12.iSQL_Parameter_ID = 0
        Me.Uc_label12.iText = ""
        Me.Uc_label12.LinkedColumn = ""
        Me.Uc_label12.Location = New System.Drawing.Point(425, 232)
        Me.Uc_label12.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label12.Name = "Uc_label12"
        Me.Uc_label12.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label12.Size = New System.Drawing.Size(324, 26)
        Me.Uc_label12.TabIndex = 172
        '
        'Uc_label14
        '
        Me.Uc_label14.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label14.iAddition_SQL = Nothing
        Me.Uc_label14.iAdditional = Nothing
        Me.Uc_label14.idsc = Nothing
        Me.Uc_label14.iIsEnabled = False
        Me.Uc_label14.iIsForSearch = False
        Me.Uc_label14.iLabel = "Document Draft No."
        Me.Uc_label14.iLabel_width = 155
        Me.Uc_label14.isLabelBoldx = False
        Me.Uc_label14.iSQL_Parameter_ID = 0
        Me.Uc_label14.iText = ""
        Me.Uc_label14.LinkedColumn = ""
        Me.Uc_label14.Location = New System.Drawing.Point(425, 260)
        Me.Uc_label14.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label14.Name = "Uc_label14"
        Me.Uc_label14.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label14.Size = New System.Drawing.Size(324, 26)
        Me.Uc_label14.TabIndex = 172
        '
        'Uc_label15
        '
        Me.Uc_label15.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label15.iAddition_SQL = Nothing
        Me.Uc_label15.iAdditional = Nothing
        Me.Uc_label15.idsc = Nothing
        Me.Uc_label15.iIsEnabled = False
        Me.Uc_label15.iIsForSearch = False
        Me.Uc_label15.iLabel = "Document Draft Internal ID"
        Me.Uc_label15.iLabel_width = 155
        Me.Uc_label15.isLabelBoldx = False
        Me.Uc_label15.iSQL_Parameter_ID = 0
        Me.Uc_label15.iText = ""
        Me.Uc_label15.LinkedColumn = ""
        Me.Uc_label15.Location = New System.Drawing.Point(805, 260)
        Me.Uc_label15.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label15.Name = "Uc_label15"
        Me.Uc_label15.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label15.Size = New System.Drawing.Size(324, 26)
        Me.Uc_label15.TabIndex = 172
        '
        'Uc_label16
        '
        Me.Uc_label16.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label16.iAddition_SQL = Nothing
        Me.Uc_label16.iAdditional = Nothing
        Me.Uc_label16.idsc = Nothing
        Me.Uc_label16.iIsEnabled = False
        Me.Uc_label16.iIsForSearch = False
        Me.Uc_label16.iLabel = "Document No."
        Me.Uc_label16.iLabel_width = 155
        Me.Uc_label16.isLabelBoldx = False
        Me.Uc_label16.iSQL_Parameter_ID = 0
        Me.Uc_label16.iText = ""
        Me.Uc_label16.LinkedColumn = ""
        Me.Uc_label16.Location = New System.Drawing.Point(425, 288)
        Me.Uc_label16.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label16.Name = "Uc_label16"
        Me.Uc_label16.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label16.Size = New System.Drawing.Size(324, 26)
        Me.Uc_label16.TabIndex = 172
        '
        'Uc_label8
        '
        Me.Uc_label8.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label8.iAddition_SQL = Nothing
        Me.Uc_label8.iAdditional = Nothing
        Me.Uc_label8.idsc = Nothing
        Me.Uc_label8.iIsEnabled = True
        Me.Uc_label8.iIsForSearch = False
        Me.Uc_label8.iLabel = "Answer"
        Me.Uc_label8.iLabel_width = 11111
        Me.Uc_label8.isLabelBoldx = True
        Me.Uc_label8.iSQL_Parameter_ID = 0
        Me.Uc_label8.iText = ""
        Me.Uc_label8.LinkedColumn = ""
        Me.Uc_label8.Location = New System.Drawing.Point(425, 363)
        Me.Uc_label8.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label8.Name = "Uc_label8"
        Me.Uc_label8.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label8.Size = New System.Drawing.Size(73, 26)
        Me.Uc_label8.TabIndex = 174
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(935, 391)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(23, 20)
        Me.TextBox1.TabIndex = 170
        Me.TextBox1.Visible = False
        '
        'Uc_label6
        '
        Me.Uc_label6.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label6.iAddition_SQL = Nothing
        Me.Uc_label6.iAdditional = Nothing
        Me.Uc_label6.idsc = Nothing
        Me.Uc_label6.iIsEnabled = True
        Me.Uc_label6.iIsForSearch = False
        Me.Uc_label6.iLabel = "Edit iLbl to edit me"
        Me.Uc_label6.iLabel_width = 5
        Me.Uc_label6.isLabelBoldx = False
        Me.Uc_label6.iSQL_Parameter_ID = 0
        Me.Uc_label6.iText = ""
        Me.Uc_label6.LinkedColumn = ""
        Me.Uc_label6.Location = New System.Drawing.Point(756, 391)
        Me.Uc_label6.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label6.Name = "Uc_label6"
        Me.Uc_label6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label6.Size = New System.Drawing.Size(175, 20)
        Me.Uc_label6.TabIndex = 169
        Me.Uc_label6.Visible = False
        '
        'Uc_inputbox1
        '
        Me.Uc_inputbox1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_inputbox1.iAdditional = Nothing
        Me.Uc_inputbox1.iArrow_Visible = True
        Me.Uc_inputbox1.iCanFindLabel_SQLIDx = 0
        Me.Uc_inputbox1.iCharacterLimit = 0
        Me.Uc_inputbox1.idsc = Me.Uc_label6
        Me.Uc_inputbox1.iForm = Me
        Me.Uc_inputbox1.iIsDropDown = True
        Me.Uc_inputbox1.iIsEnabled = False
        Me.Uc_inputbox1.iIsForSearch = True
        Me.Uc_inputbox1.iIsID = False
        Me.Uc_inputbox1.iIsInnerShow = True
        Me.Uc_inputbox1.iLabel = "Decision"
        Me.Uc_inputbox1.iLabel_width = 140
        Me.Uc_inputbox1.isAllowEmptyx = False
        Me.Uc_inputbox1.isForFind = True
        Me.Uc_inputbox1.iSQL_Parameter_ID = 161
        Me.Uc_inputbox1.iSQL_Parameter_ID_FIND = 168
        Me.Uc_inputbox1.iText = ""
        Me.Uc_inputbox1.iTextBox_ = Me.TextBox1
        Me.Uc_inputbox1.iTextBox_Sel_COL_ID = 0
        Me.Uc_inputbox1.iTitle = ""
        Me.Uc_inputbox1.LinkedColumn = "code"
        Me.Uc_inputbox1.Location = New System.Drawing.Point(425, 391)
        Me.Uc_inputbox1.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_inputbox1.Name = "Uc_inputbox1"
        Me.Uc_inputbox1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_inputbox1.Size = New System.Drawing.Size(324, 20)
        Me.Uc_inputbox1.TabIndex = 168
        '
        'Uc_label13
        '
        Me.Uc_label13.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label13.iAddition_SQL = Nothing
        Me.Uc_label13.iAdditional = Nothing
        Me.Uc_label13.idsc = Nothing
        Me.Uc_label13.iIsEnabled = True
        Me.Uc_label13.iIsForSearch = False
        Me.Uc_label13.iLabel = "Remarks"
        Me.Uc_label13.iLabel_width = 155
        Me.Uc_label13.isLabelBoldx = False
        Me.Uc_label13.iSQL_Parameter_ID = 0
        Me.Uc_label13.iText = ""
        Me.Uc_label13.LinkedColumn = ""
        Me.Uc_label13.Location = New System.Drawing.Point(425, 420)
        Me.Uc_label13.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label13.Name = "Uc_label13"
        Me.Uc_label13.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label13.Size = New System.Drawing.Size(507, 20)
        Me.Uc_label13.TabIndex = 176
        Me.Uc_label13.Visible = False
        '
        'lbl_text
        '
        Me.lbl_text.BackColor = System.Drawing.Color.Transparent
        Me.lbl_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_text.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_text.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_text.Location = New System.Drawing.Point(425, 36)
        Me.lbl_text.Name = "lbl_text"
        Me.lbl_text.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lbl_text.Size = New System.Drawing.Size(345, 20)
        Me.lbl_text.TabIndex = 177
        Me.lbl_text.Text = "NOTE: Once updated, document can be reverse"
        Me.lbl_text.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lbl_text.UseWaitCursor = True
        '
        'Uc_label17
        '
        Me.Uc_label17.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label17.iAddition_SQL = Nothing
        Me.Uc_label17.iAdditional = Nothing
        Me.Uc_label17.idsc = Nothing
        Me.Uc_label17.iIsEnabled = True
        Me.Uc_label17.iIsForSearch = False
        Me.Uc_label17.iLabel = ""
        Me.Uc_label17.iLabel_width = 5000
        Me.Uc_label17.isLabelBoldx = False
        Me.Uc_label17.iSQL_Parameter_ID = 0
        Me.Uc_label17.iText = ""
        Me.Uc_label17.LinkedColumn = ""
        Me.Uc_label17.Location = New System.Drawing.Point(425, 326)
        Me.Uc_label17.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label17.Name = "Uc_label17"
        Me.Uc_label17.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label17.Size = New System.Drawing.Size(704, 23)
        Me.Uc_label17.TabIndex = 178
        Me.Uc_label17.Visible = False
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.Black
        Me.btn_ok.Image = Global.IpicIndirect.My.Resources.Resources.btn_bar1
        Me.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ok.Location = New System.Drawing.Point(425, 455)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(101, 21)
        Me.btn_ok.TabIndex = 179
        Me.btn_ok.Tag = "0"
        Me.btn_ok.Text = "Add"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'btn_Item_arrow
        '
        Me.btn_Item_arrow.BackColor = System.Drawing.Color.Transparent
        Me.btn_Item_arrow.BackgroundImage = Global.IpicIndirect.My.Resources.Resources.GoldArrow2
        Me.btn_Item_arrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Item_arrow.FlatAppearance.BorderSize = 0
        Me.btn_Item_arrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Item_arrow.Location = New System.Drawing.Point(555, 152)
        Me.btn_Item_arrow.Name = "btn_Item_arrow"
        Me.btn_Item_arrow.Size = New System.Drawing.Size(16, 16)
        Me.btn_Item_arrow.TabIndex = 175
        Me.btn_Item_arrow.UseVisualStyleBackColor = False
        '
        'DocumentDraft
        '
        Me.AcceptButton = Me.btn_ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 579)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.Uc_label17)
        Me.Controls.Add(Me.lbl_text)
        Me.Controls.Add(Me.Uc_label13)
        Me.Controls.Add(Me.btn_Item_arrow)
        Me.Controls.Add(Me.Uc_label8)
        Me.Controls.Add(Me.Uc_label16)
        Me.Controls.Add(Me.Uc_label4)
        Me.Controls.Add(Me.Uc_label15)
        Me.Controls.Add(Me.Uc_label7)
        Me.Controls.Add(Me.Uc_label14)
        Me.Controls.Add(Me.Uc_label3)
        Me.Controls.Add(Me.Uc_label12)
        Me.Controls.Add(Me.Uc_label2)
        Me.Controls.Add(Me.Uc_label11)
        Me.Controls.Add(Me.Uc_label10)
        Me.Controls.Add(Me.Uc_label5)
        Me.Controls.Add(Me.Uc_label9)
        Me.Controls.Add(Me.Uc_label1)
        Me.Controls.Add(Me.Uc_inputbox1)
        Me.Controls.Add(Me.Uc_label6)
        Me.Controls.Add(Me.uc_itemcode)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.uc_itemcode_lbl)
        Me.Controls.Add(Me.uc_itemcode_txt)
        Me.Controls.Add(Me.dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DocumentDraft"
        Me.Text = "DocumentDraft"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents uc_itemcode As uc_inputbox
    Friend WithEvents uc_itemcode_lbl As uc_label
    Friend WithEvents uc_itemcode_txt As TextBox
    Friend WithEvents Uc_label4 As uc_label
    Friend WithEvents Uc_label7 As uc_label
    Friend WithEvents Uc_label3 As uc_label
    Friend WithEvents Uc_label2 As uc_label
    Friend WithEvents Uc_label5 As uc_label
    Friend WithEvents Uc_label9 As uc_label
    Friend WithEvents Uc_label1 As uc_label
    Friend WithEvents Uc_label8 As uc_label
    Friend WithEvents Uc_label16 As uc_label
    Friend WithEvents Uc_label15 As uc_label
    Friend WithEvents Uc_label14 As uc_label
    Friend WithEvents Uc_label12 As uc_label
    Friend WithEvents Uc_label11 As uc_label
    Friend WithEvents Uc_label10 As uc_label
    Friend WithEvents Uc_inputbox1 As uc_inputbox
    Friend WithEvents Uc_label6 As uc_label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Uc_label13 As uc_label
    Friend WithEvents btn_Item_arrow As Button
    Friend WithEvents Uc_label17 As uc_label
    Friend WithEvents lbl_text As Label
    Friend WithEvents btn_ok As Button
End Class
