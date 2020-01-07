<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class iLayOutModule
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.dgv_1 = New System.Windows.Forms.DataGridView()
        Me.c_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_CODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_STATIOn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_lbl = New System.Windows.Forms.TextBox()
        Me.tvNode = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.uc_remarks = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.w = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Uc_label2 = New IpicIndirect.uc_label()
        Me.uc_location = New IpicIndirect.uc_label()
        Me.uc_createdDate = New IpicIndirect.uc_label()
        Me.uc_moduleKey = New IpicIndirect.uc_label()
        Me.uc_createdBy = New IpicIndirect.uc_label()
        Me.uc_status_lbl = New IpicIndirect.uc_label()
        Me.uc_type_lbl = New IpicIndirect.uc_label()
        Me.uc_lbl = New IpicIndirect.uc_label()
        Me.uc_type = New IpicIndirect.uc_inputbox()
        Me.uc_status = New IpicIndirect.uc_inputbox()
        Me.uc_cr = New IpicIndirect.uc_inputbox()
        Me.uc_name = New IpicIndirect.uc_inputbox()
        Me.uc_id = New IpicIndirect.uc_inputbox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(1024, 655)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(84, 23)
        Me.btn_update.TabIndex = 130
        Me.btn_update.Text = "SAVE"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'dgv_1
        '
        Me.dgv_1.AllowUserToAddRows = False
        Me.dgv_1.AllowUserToDeleteRows = False
        Me.dgv_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_1.BackgroundColor = System.Drawing.Color.White
        Me.dgv_1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_id, Me.C_CODE, Me.C_STATIOn})
        Me.dgv_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_1.EnableHeadersVisualStyles = False
        Me.dgv_1.Location = New System.Drawing.Point(0, 0)
        Me.dgv_1.Name = "dgv_1"
        Me.dgv_1.RowHeadersVisible = False
        Me.dgv_1.RowTemplate.Height = 24
        Me.dgv_1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_1.Size = New System.Drawing.Size(768, 324)
        Me.dgv_1.TabIndex = 129
        '
        'c_id
        '
        Me.c_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.c_id.FillWeight = 20.0!
        Me.c_id.Frozen = True
        Me.c_id.HeaderText = "ID"
        Me.c_id.Name = "c_id"
        Me.c_id.ReadOnly = True
        Me.c_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.c_id.Width = 39
        '
        'C_CODE
        '
        Me.C_CODE.HeaderText = "CODE"
        Me.C_CODE.Name = "C_CODE"
        '
        'C_STATIOn
        '
        Me.C_STATIOn.HeaderText = "STATIONS"
        Me.C_STATIOn.Name = "C_STATIOn"
        '
        'txt_lbl
        '
        Me.txt_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_lbl.Location = New System.Drawing.Point(303, 7)
        Me.txt_lbl.Multiline = True
        Me.txt_lbl.Name = "txt_lbl"
        Me.txt_lbl.Size = New System.Drawing.Size(18, 22)
        Me.txt_lbl.TabIndex = 133
        Me.txt_lbl.Visible = False
        '
        'tvNode
        '
        Me.tvNode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tvNode.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.tvNode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvNode.ForeColor = System.Drawing.Color.Black
        Me.tvNode.FullRowSelect = True
        Me.tvNode.HideSelection = False
        Me.tvNode.ItemHeight = 20
        Me.tvNode.Location = New System.Drawing.Point(12, 12)
        Me.tvNode.Name = "tvNode"
        Me.tvNode.PathSeparator = "-"
        Me.tvNode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tvNode.Size = New System.Drawing.Size(322, 637)
        Me.tvNode.TabIndex = 132
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.uc_remarks)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.w)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.txt_lbl)
        Me.Panel1.Controls.Add(Me.Uc_label2)
        Me.Panel1.Controls.Add(Me.uc_location)
        Me.Panel1.Controls.Add(Me.uc_createdDate)
        Me.Panel1.Controls.Add(Me.uc_moduleKey)
        Me.Panel1.Controls.Add(Me.uc_createdBy)
        Me.Panel1.Controls.Add(Me.uc_status_lbl)
        Me.Panel1.Controls.Add(Me.uc_type_lbl)
        Me.Panel1.Controls.Add(Me.uc_lbl)
        Me.Panel1.Controls.Add(Me.uc_type)
        Me.Panel1.Controls.Add(Me.uc_status)
        Me.Panel1.Controls.Add(Me.uc_cr)
        Me.Panel1.Controls.Add(Me.uc_name)
        Me.Panel1.Controls.Add(Me.uc_id)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(768, 309)
        Me.Panel1.TabIndex = 133
        '
        'uc_remarks
        '
        Me.uc_remarks.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_remarks.Location = New System.Drawing.Point(531, 158)
        Me.uc_remarks.Multiline = True
        Me.uc_remarks.Name = "uc_remarks"
        Me.uc_remarks.Size = New System.Drawing.Size(213, 62)
        Me.uc_remarks.TabIndex = 133
        Me.uc_remarks.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(277, 87)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(18, 22)
        Me.TextBox2.TabIndex = 133
        Me.TextBox2.Visible = False
        '
        'w
        '
        Me.w.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.w.FlatAppearance.BorderSize = 0
        Me.w.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.w.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.w.ForeColor = System.Drawing.Color.White
        Me.w.Location = New System.Drawing.Point(360, 142)
        Me.w.Name = "w"
        Me.w.Size = New System.Drawing.Size(84, 23)
        Me.w.TabIndex = 130
        Me.w.Text = "UPLOAD"
        Me.w.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.w.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.w.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(277, 63)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(18, 22)
        Me.TextBox1.TabIndex = 133
        Me.TextBox1.Visible = False
        '
        'Uc_label2
        '
        Me.Uc_label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_label2.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label2.iAddition_SQL = Nothing
        Me.Uc_label2.iAdditional = Nothing
        Me.Uc_label2.idsc = Nothing
        Me.Uc_label2.iIsEnabled = True
        Me.Uc_label2.iIsForSearch = False
        Me.Uc_label2.iLabel = "Description"
        Me.Uc_label2.iLabel_width = 500
        Me.Uc_label2.isLabelBoldx = False
        Me.Uc_label2.iSQL_Parameter_ID = 0
        Me.Uc_label2.iText = ""
        Me.Uc_label2.LinkedColumn = ""
        Me.Uc_label2.Location = New System.Drawing.Point(422, 200)
        Me.Uc_label2.Name = "Uc_label2"
        Me.Uc_label2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label2.Size = New System.Drawing.Size(194, 20)
        Me.Uc_label2.TabIndex = 132
        Me.Uc_label2.Visible = False
        '
        'uc_location
        '
        Me.uc_location.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_location.BackColor = System.Drawing.Color.Transparent
        Me.uc_location.iAddition_SQL = Nothing
        Me.uc_location.iAdditional = Nothing
        Me.uc_location.idsc = Nothing
        Me.uc_location.iIsEnabled = False
        Me.uc_location.iIsForSearch = False
        Me.uc_location.iLabel = "Loaction"
        Me.uc_location.iLabel_width = 120
        Me.uc_location.isLabelBoldx = False
        Me.uc_location.iSQL_Parameter_ID = 0
        Me.uc_location.iText = ""
        Me.uc_location.LinkedColumn = ""
        Me.uc_location.Location = New System.Drawing.Point(8, 115)
        Me.uc_location.Name = "uc_location"
        Me.uc_location.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_location.Size = New System.Drawing.Size(443, 20)
        Me.uc_location.TabIndex = 132
        '
        'uc_createdDate
        '
        Me.uc_createdDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_createdDate.BackColor = System.Drawing.Color.Transparent
        Me.uc_createdDate.iAddition_SQL = Nothing
        Me.uc_createdDate.iAdditional = Nothing
        Me.uc_createdDate.idsc = Nothing
        Me.uc_createdDate.iIsEnabled = False
        Me.uc_createdDate.iIsForSearch = False
        Me.uc_createdDate.iLabel = "Created Date"
        Me.uc_createdDate.iLabel_width = 105
        Me.uc_createdDate.isLabelBoldx = False
        Me.uc_createdDate.iSQL_Parameter_ID = 0
        Me.uc_createdDate.iText = ""
        Me.uc_createdDate.LinkedColumn = ""
        Me.uc_createdDate.Location = New System.Drawing.Point(531, 61)
        Me.uc_createdDate.Name = "uc_createdDate"
        Me.uc_createdDate.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_createdDate.Size = New System.Drawing.Size(213, 20)
        Me.uc_createdDate.TabIndex = 132
        '
        'uc_moduleKey
        '
        Me.uc_moduleKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_moduleKey.BackColor = System.Drawing.Color.Transparent
        Me.uc_moduleKey.iAddition_SQL = Nothing
        Me.uc_moduleKey.iAdditional = Nothing
        Me.uc_moduleKey.idsc = Nothing
        Me.uc_moduleKey.iIsEnabled = False
        Me.uc_moduleKey.iIsForSearch = False
        Me.uc_moduleKey.iLabel = "Module"
        Me.uc_moduleKey.iLabel_width = 105
        Me.uc_moduleKey.isLabelBoldx = False
        Me.uc_moduleKey.iSQL_Parameter_ID = 0
        Me.uc_moduleKey.iText = ""
        Me.uc_moduleKey.LinkedColumn = ""
        Me.uc_moduleKey.Location = New System.Drawing.Point(531, 6)
        Me.uc_moduleKey.Name = "uc_moduleKey"
        Me.uc_moduleKey.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_moduleKey.Size = New System.Drawing.Size(213, 20)
        Me.uc_moduleKey.TabIndex = 132
        '
        'uc_createdBy
        '
        Me.uc_createdBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_createdBy.BackColor = System.Drawing.Color.Transparent
        Me.uc_createdBy.iAddition_SQL = Nothing
        Me.uc_createdBy.iAdditional = Nothing
        Me.uc_createdBy.idsc = Nothing
        Me.uc_createdBy.iIsEnabled = False
        Me.uc_createdBy.iIsForSearch = False
        Me.uc_createdBy.iLabel = "Author"
        Me.uc_createdBy.iLabel_width = 105
        Me.uc_createdBy.isLabelBoldx = False
        Me.uc_createdBy.iSQL_Parameter_ID = 0
        Me.uc_createdBy.iText = ""
        Me.uc_createdBy.LinkedColumn = ""
        Me.uc_createdBy.Location = New System.Drawing.Point(531, 31)
        Me.uc_createdBy.Name = "uc_createdBy"
        Me.uc_createdBy.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_createdBy.Size = New System.Drawing.Size(213, 20)
        Me.uc_createdBy.TabIndex = 132
        '
        'uc_status_lbl
        '
        Me.uc_status_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_status_lbl.iAddition_SQL = Nothing
        Me.uc_status_lbl.iAdditional = Nothing
        Me.uc_status_lbl.idsc = Nothing
        Me.uc_status_lbl.iIsEnabled = True
        Me.uc_status_lbl.iIsForSearch = False
        Me.uc_status_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_status_lbl.iLabel_width = 5
        Me.uc_status_lbl.isLabelBoldx = False
        Me.uc_status_lbl.iSQL_Parameter_ID = 0
        Me.uc_status_lbl.iText = ""
        Me.uc_status_lbl.LinkedColumn = ""
        Me.uc_status_lbl.Location = New System.Drawing.Point(155, 88)
        Me.uc_status_lbl.Name = "uc_status_lbl"
        Me.uc_status_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_status_lbl.Size = New System.Drawing.Size(116, 20)
        Me.uc_status_lbl.TabIndex = 132
        '
        'uc_type_lbl
        '
        Me.uc_type_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_type_lbl.iAddition_SQL = Nothing
        Me.uc_type_lbl.iAdditional = Nothing
        Me.uc_type_lbl.idsc = Nothing
        Me.uc_type_lbl.iIsEnabled = True
        Me.uc_type_lbl.iIsForSearch = False
        Me.uc_type_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_type_lbl.iLabel_width = 5
        Me.uc_type_lbl.isLabelBoldx = False
        Me.uc_type_lbl.iSQL_Parameter_ID = 0
        Me.uc_type_lbl.iText = ""
        Me.uc_type_lbl.LinkedColumn = ""
        Me.uc_type_lbl.Location = New System.Drawing.Point(155, 61)
        Me.uc_type_lbl.Name = "uc_type_lbl"
        Me.uc_type_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_type_lbl.Size = New System.Drawing.Size(116, 20)
        Me.uc_type_lbl.TabIndex = 132
        '
        'uc_lbl
        '
        Me.uc_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_lbl.iAddition_SQL = Nothing
        Me.uc_lbl.iAdditional = Nothing
        Me.uc_lbl.idsc = Nothing
        Me.uc_lbl.iIsEnabled = True
        Me.uc_lbl.iIsForSearch = False
        Me.uc_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_lbl.iLabel_width = 0
        Me.uc_lbl.isLabelBoldx = False
        Me.uc_lbl.iSQL_Parameter_ID = 0
        Me.uc_lbl.iText = ""
        Me.uc_lbl.LinkedColumn = ""
        Me.uc_lbl.Location = New System.Drawing.Point(277, 8)
        Me.uc_lbl.Name = "uc_lbl"
        Me.uc_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_lbl.Size = New System.Drawing.Size(20, 20)
        Me.uc_lbl.TabIndex = 132
        Me.uc_lbl.Visible = False
        '
        'uc_type
        '
        Me.uc_type.BackColor = System.Drawing.Color.Transparent
        Me.uc_type.iAdditional = "1"
        Me.uc_type.iArrow_Visible = False
        Me.uc_type.iCanFindLabel_SQLIDx = 0
        Me.uc_type.iCharacterLimit = 0
        Me.uc_type.idsc = Me.uc_type_lbl
        Me.uc_type.iForm = Me
        Me.uc_type.iIsDropDown = True
        Me.uc_type.iIsEnabled = False
        Me.uc_type.iIsForSearch = True
        Me.uc_type.iIsID = False
        Me.uc_type.iIsInnerShow = True
        Me.uc_type.iLabel = "Type"
        Me.uc_type.iLabel_width = 105
        Me.uc_type.isAllowEmptyx = False
        Me.uc_type.isForFind = False
        Me.uc_type.iSQL_Parameter_ID = 151
        Me.uc_type.iSQL_Parameter_ID_FIND = 0
        Me.uc_type.isStayVisible = False
        Me.uc_type.iText = ""
        Me.uc_type.iTextBox_ = Me.TextBox1
        Me.uc_type.iTextBox_Sel_COL_ID = 0
        Me.uc_type.iTitle = ""
        Me.uc_type.LinkedColumn = ""
        Me.uc_type.Location = New System.Drawing.Point(8, 61)
        Me.uc_type.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_type.Name = "uc_type"
        Me.uc_type.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_type.Size = New System.Drawing.Size(147, 23)
        Me.uc_type.TabIndex = 131
        '
        'uc_status
        '
        Me.uc_status.BackColor = System.Drawing.Color.Transparent
        Me.uc_status.iAdditional = "2"
        Me.uc_status.iArrow_Visible = False
        Me.uc_status.iCanFindLabel_SQLIDx = 0
        Me.uc_status.iCharacterLimit = 0
        Me.uc_status.idsc = Me.uc_status_lbl
        Me.uc_status.iForm = Me
        Me.uc_status.iIsDropDown = True
        Me.uc_status.iIsEnabled = False
        Me.uc_status.iIsForSearch = True
        Me.uc_status.iIsID = False
        Me.uc_status.iIsInnerShow = True
        Me.uc_status.iLabel = "Status"
        Me.uc_status.iLabel_width = 105
        Me.uc_status.isAllowEmptyx = False
        Me.uc_status.isForFind = False
        Me.uc_status.iSQL_Parameter_ID = 151
        Me.uc_status.iSQL_Parameter_ID_FIND = 0
        Me.uc_status.isStayVisible = False
        Me.uc_status.iText = ""
        Me.uc_status.iTextBox_ = Me.txt_lbl
        Me.uc_status.iTextBox_Sel_COL_ID = 0
        Me.uc_status.iTitle = ""
        Me.uc_status.LinkedColumn = ""
        Me.uc_status.Location = New System.Drawing.Point(8, 88)
        Me.uc_status.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_status.Name = "uc_status"
        Me.uc_status.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_status.Size = New System.Drawing.Size(147, 23)
        Me.uc_status.TabIndex = 131
        '
        'uc_cr
        '
        Me.uc_cr.BackColor = System.Drawing.Color.Transparent
        Me.uc_cr.iAdditional = Nothing
        Me.uc_cr.iArrow_Visible = False
        Me.uc_cr.iCanFindLabel_SQLIDx = 0
        Me.uc_cr.iCharacterLimit = 0
        Me.uc_cr.idsc = Nothing
        Me.uc_cr.iForm = Nothing
        Me.uc_cr.iIsDropDown = True
        Me.uc_cr.iIsEnabled = True
        Me.uc_cr.iIsForSearch = True
        Me.uc_cr.iIsID = False
        Me.uc_cr.iIsInnerShow = True
        Me.uc_cr.iLabel = "Name"
        Me.uc_cr.iLabel_width = 105
        Me.uc_cr.isAllowEmptyx = False
        Me.uc_cr.isForFind = False
        Me.uc_cr.iSQL_Parameter_ID = 143
        Me.uc_cr.iSQL_Parameter_ID_FIND = 0
        Me.uc_cr.isStayVisible = False
        Me.uc_cr.iText = ""
        Me.uc_cr.iTextBox_ = Nothing
        Me.uc_cr.iTextBox_Sel_COL_ID = 0
        Me.uc_cr.iTitle = ""
        Me.uc_cr.LinkedColumn = ""
        Me.uc_cr.Location = New System.Drawing.Point(8, 143)
        Me.uc_cr.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_cr.Name = "uc_cr"
        Me.uc_cr.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_cr.Size = New System.Drawing.Size(349, 23)
        Me.uc_cr.TabIndex = 131
        '
        'uc_name
        '
        Me.uc_name.BackColor = System.Drawing.Color.Transparent
        Me.uc_name.iAdditional = Nothing
        Me.uc_name.iArrow_Visible = False
        Me.uc_name.iCanFindLabel_SQLIDx = 0
        Me.uc_name.iCharacterLimit = 0
        Me.uc_name.idsc = Me.uc_lbl
        Me.uc_name.iForm = Me
        Me.uc_name.iIsDropDown = True
        Me.uc_name.iIsEnabled = True
        Me.uc_name.iIsForSearch = True
        Me.uc_name.iIsID = False
        Me.uc_name.iIsInnerShow = True
        Me.uc_name.iLabel = "Name"
        Me.uc_name.iLabel_width = 105
        Me.uc_name.isAllowEmptyx = False
        Me.uc_name.isForFind = False
        Me.uc_name.iSQL_Parameter_ID = 143
        Me.uc_name.iSQL_Parameter_ID_FIND = 0
        Me.uc_name.isStayVisible = False
        Me.uc_name.iText = ""
        Me.uc_name.iTextBox_ = Me.txt_lbl
        Me.uc_name.iTextBox_Sel_COL_ID = 0
        Me.uc_name.iTitle = ""
        Me.uc_name.LinkedColumn = ""
        Me.uc_name.Location = New System.Drawing.Point(8, 31)
        Me.uc_name.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_name.Name = "uc_name"
        Me.uc_name.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_name.Size = New System.Drawing.Size(265, 23)
        Me.uc_name.TabIndex = 131
        '
        'uc_id
        '
        Me.uc_id.BackColor = System.Drawing.Color.Transparent
        Me.uc_id.iAdditional = Nothing
        Me.uc_id.iArrow_Visible = False
        Me.uc_id.iCanFindLabel_SQLIDx = 0
        Me.uc_id.iCharacterLimit = 0
        Me.uc_id.idsc = Me.uc_lbl
        Me.uc_id.iForm = Me
        Me.uc_id.iIsDropDown = True
        Me.uc_id.iIsEnabled = False
        Me.uc_id.iIsForSearch = True
        Me.uc_id.iIsID = False
        Me.uc_id.iIsInnerShow = True
        Me.uc_id.iLabel = "ID"
        Me.uc_id.iLabel_width = 105
        Me.uc_id.isAllowEmptyx = False
        Me.uc_id.isForFind = False
        Me.uc_id.iSQL_Parameter_ID = 143
        Me.uc_id.iSQL_Parameter_ID_FIND = 0
        Me.uc_id.isStayVisible = False
        Me.uc_id.iText = ""
        Me.uc_id.iTextBox_ = Me.txt_lbl
        Me.uc_id.iTextBox_Sel_COL_ID = 0
        Me.uc_id.iTitle = ""
        Me.uc_id.LinkedColumn = ""
        Me.uc_id.Location = New System.Drawing.Point(8, 6)
        Me.uc_id.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_id.Name = "uc_id"
        Me.uc_id.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_id.Size = New System.Drawing.Size(265, 23)
        Me.uc_id.TabIndex = 131
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(340, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgv_1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(768, 637)
        Me.SplitContainer1.SplitterDistance = 324
        Me.SplitContainer1.TabIndex = 134
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Width = 39
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "CODE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 363
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "STATIONS"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 363
        '
        'iLayOutModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 686)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.tvNode)
        Me.Controls.Add(Me.btn_update)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1120, 686)
        Me.Name = "iLayOutModule"
        Me.Text = "SAVE"
        CType(Me.dgv_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_update As Button
    Friend WithEvents dgv_1 As DataGridView
    Friend WithEvents c_id As DataGridViewTextBoxColumn
    Friend WithEvents C_CODE As DataGridViewTextBoxColumn
    Friend WithEvents C_STATIOn As DataGridViewTextBoxColumn
    Friend WithEvents uc_id As uc_inputbox
    Friend WithEvents tvNode As TreeView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txt_lbl As TextBox
    Friend WithEvents uc_lbl As uc_label
    Friend WithEvents uc_type As uc_inputbox
    Friend WithEvents uc_status As uc_inputbox
    Friend WithEvents uc_name As uc_inputbox
    Friend WithEvents Uc_label2 As uc_label
    Friend WithEvents uc_createdDate As uc_label
    Friend WithEvents uc_createdBy As uc_label
    Friend WithEvents uc_location As uc_label
    Friend WithEvents uc_moduleKey As uc_label
    Friend WithEvents uc_remarks As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents uc_status_lbl As uc_label
    Friend WithEvents uc_type_lbl As uc_label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents w As Button
    Friend WithEvents uc_cr As uc_inputbox
End Class
