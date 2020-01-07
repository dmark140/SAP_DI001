<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reclass
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reclass))
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.CMS_main = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PickFromPalletingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.uc_itemcode_txt = New System.Windows.Forms.TextBox()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cms_copy = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_uc_palletingNum = New System.Windows.Forms.TextBox()
        Me.uc_controlp_txt = New System.Windows.Forms.TextBox()
        Me.uc_prepared_txt = New System.Windows.Forms.TextBox()
        Me.uc_approved_txt = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.uc_status = New IpicIndirect.uc_inputbox()
        Me.uc_status_lbl = New IpicIndirect.uc_label()
        Me.uc_approved = New IpicIndirect.uc_inputbox()
        Me.uc_approved_lbl = New IpicIndirect.uc_label()
        Me.uc_prepared = New IpicIndirect.uc_inputbox()
        Me.uc_prepared_lbl = New IpicIndirect.uc_label()
        Me.Uc_label1 = New IpicIndirect.uc_label()
        Me.uc_palletingNum_lbl = New IpicIndirect.uc_label()
        Me.uc_controlp = New IpicIndirect.uc_inputbox()
        Me.uc_controlp_lbl = New IpicIndirect.uc_label()
        Me.uc_itemcode = New IpicIndirect.uc_inputbox()
        Me.uc_itemcode_lbl = New IpicIndirect.uc_label()
        Me.uc_doc = New IpicIndirect.uc_inputbox()
        Me.uc_DocDate = New IpicIndirect.uc_date()
        Me.uc_warehouseto_lb = New IpicIndirect.uc_label()
        Me.uc_warehouseto = New IpicIndirect.uc_label()
        Me.uc_warehouseF_lbl = New IpicIndirect.uc_label()
        Me.uc_warehouseF = New IpicIndirect.uc_label()
        Me.uc_machine = New IpicIndirect.uc_label()
        Me.uc_TaxDate = New IpicIndirect.uc_date()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.uc_remarks = New IpicIndirect.uc_label()
        Me.Uc_inputbox1 = New IpicIndirect.uc_inputbox()
        Me.Uc_label2 = New IpicIndirect.uc_label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMS_main.SuspendLayout()
        Me.cms_copy.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem3.Text = "Fit Column Width"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(165, 6)
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv.ContextMenuStrip = Me.CMS_main
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.Location = New System.Drawing.Point(10, 191)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(910, 387)
        Me.dgv.TabIndex = 91
        '
        'CMS_main
        '
        Me.CMS_main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PickFromPalletingToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.CMS_main.Name = "CMS_main"
        Me.CMS_main.Size = New System.Drawing.Size(148, 48)
        '
        'PickFromPalletingToolStripMenuItem
        '
        Me.PickFromPalletingToolStripMenuItem.Name = "PickFromPalletingToolStripMenuItem"
        Me.PickFromPalletingToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.PickFromPalletingToolStripMenuItem.Text = "Change Items"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove Item"
        '
        'uc_itemcode_txt
        '
        Me.uc_itemcode_txt.Location = New System.Drawing.Point(390, 10)
        Me.uc_itemcode_txt.Name = "uc_itemcode_txt"
        Me.uc_itemcode_txt.Size = New System.Drawing.Size(23, 20)
        Me.uc_itemcode_txt.TabIndex = 167
        Me.uc_itemcode_txt.Visible = False
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem2.Text = "Cancel"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'cms_copy
        '
        Me.cms_copy.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_copy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem3, Me.ToolStripSeparator2, Me.ToolStripMenuItem2})
        Me.cms_copy.Name = "ContextMenuStrip1"
        Me.cms_copy.Size = New System.Drawing.Size(169, 76)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem1.Text = "Copy with header"
        '
        'txt_uc_palletingNum
        '
        Me.txt_uc_palletingNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_uc_palletingNum.Location = New System.Drawing.Point(581, 8)
        Me.txt_uc_palletingNum.Name = "txt_uc_palletingNum"
        Me.txt_uc_palletingNum.Size = New System.Drawing.Size(23, 20)
        Me.txt_uc_palletingNum.TabIndex = 186
        Me.txt_uc_palletingNum.Visible = False
        '
        'uc_controlp_txt
        '
        Me.uc_controlp_txt.Location = New System.Drawing.Point(390, 34)
        Me.uc_controlp_txt.Name = "uc_controlp_txt"
        Me.uc_controlp_txt.Size = New System.Drawing.Size(23, 20)
        Me.uc_controlp_txt.TabIndex = 167
        Me.uc_controlp_txt.Visible = False
        '
        'uc_prepared_txt
        '
        Me.uc_prepared_txt.Location = New System.Drawing.Point(288, 65)
        Me.uc_prepared_txt.Name = "uc_prepared_txt"
        Me.uc_prepared_txt.Size = New System.Drawing.Size(23, 20)
        Me.uc_prepared_txt.TabIndex = 191
        Me.uc_prepared_txt.Visible = False
        '
        'uc_approved_txt
        '
        Me.uc_approved_txt.Location = New System.Drawing.Point(288, 90)
        Me.uc_approved_txt.Name = "uc_approved_txt"
        Me.uc_approved_txt.Size = New System.Drawing.Size(23, 20)
        Me.uc_approved_txt.TabIndex = 191
        Me.uc_approved_txt.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(288, 119)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(23, 20)
        Me.TextBox1.TabIndex = 194
        Me.TextBox1.Visible = False
        '
        'uc_status
        '
        Me.uc_status.BackColor = System.Drawing.Color.Transparent
        Me.uc_status.iAdditional = Nothing
        Me.uc_status.iArrow_Visible = False
        Me.uc_status.iCanFindLabel_SQLIDx = 0
        Me.uc_status.iCharacterLimit = 49
        Me.uc_status.idsc = Me.uc_status_lbl
        Me.uc_status.iForm = Me
        Me.uc_status.iIsDropDown = True
        Me.uc_status.iIsEnabled = False
        Me.uc_status.iIsForSearch = True
        Me.uc_status.iIsID = False
        Me.uc_status.iIsInnerShow = False
        Me.uc_status.iLabel = "Status"
        Me.uc_status.iLabel_width = 105
        Me.uc_status.isAllowEmptyx = True
        Me.uc_status.isForFind = True
        Me.uc_status.iSQL_Parameter_ID = 167
        Me.uc_status.iSQL_Parameter_ID_FIND = 167
        Me.uc_status.iText = ""
        Me.uc_status.iTextBox_ = Me.TextBox1
        Me.uc_status.iTextBox_Sel_COL_ID = 0
        Me.uc_status.iTitle = ""
        Me.uc_status.LinkedColumn = "[ORCL].Status"
        Me.uc_status.Location = New System.Drawing.Point(10, 119)
        Me.uc_status.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_status.Name = "uc_status"
        Me.uc_status.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_status.Size = New System.Drawing.Size(153, 20)
        Me.uc_status.TabIndex = 192
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
        Me.uc_status_lbl.Location = New System.Drawing.Point(163, 119)
        Me.uc_status_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_status_lbl.Name = "uc_status_lbl"
        Me.uc_status_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_status_lbl.Size = New System.Drawing.Size(126, 20)
        Me.uc_status_lbl.TabIndex = 193
        '
        'uc_approved
        '
        Me.uc_approved.BackColor = System.Drawing.Color.Transparent
        Me.uc_approved.iAdditional = Nothing
        Me.uc_approved.iArrow_Visible = False
        Me.uc_approved.iCanFindLabel_SQLIDx = 0
        Me.uc_approved.iCharacterLimit = 49
        Me.uc_approved.idsc = Me.uc_approved_lbl
        Me.uc_approved.iForm = Me
        Me.uc_approved.iIsDropDown = True
        Me.uc_approved.iIsEnabled = False
        Me.uc_approved.iIsForSearch = True
        Me.uc_approved.iIsID = False
        Me.uc_approved.iIsInnerShow = False
        Me.uc_approved.iLabel = "Approved By"
        Me.uc_approved.iLabel_width = 105
        Me.uc_approved.isAllowEmptyx = True
        Me.uc_approved.isForFind = True
        Me.uc_approved.iSQL_Parameter_ID = 162
        Me.uc_approved.iSQL_Parameter_ID_FIND = 0
        Me.uc_approved.iText = ""
        Me.uc_approved.iTextBox_ = Me.uc_approved_txt
        Me.uc_approved.iTextBox_Sel_COL_ID = 0
        Me.uc_approved.iTitle = ""
        Me.uc_approved.LinkedColumn = "[ORCL].U_approvedBy"
        Me.uc_approved.Location = New System.Drawing.Point(10, 90)
        Me.uc_approved.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_approved.Name = "uc_approved"
        Me.uc_approved.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_approved.Size = New System.Drawing.Size(279, 20)
        Me.uc_approved.TabIndex = 189
        '
        'uc_approved_lbl
        '
        Me.uc_approved_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_approved_lbl.iAddition_SQL = Nothing
        Me.uc_approved_lbl.iAdditional = Nothing
        Me.uc_approved_lbl.idsc = Nothing
        Me.uc_approved_lbl.iIsEnabled = True
        Me.uc_approved_lbl.iIsForSearch = False
        Me.uc_approved_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_approved_lbl.iLabel_width = 5
        Me.uc_approved_lbl.isLabelBoldx = False
        Me.uc_approved_lbl.iSQL_Parameter_ID = 0
        Me.uc_approved_lbl.iText = ""
        Me.uc_approved_lbl.LinkedColumn = ""
        Me.uc_approved_lbl.Location = New System.Drawing.Point(315, 90)
        Me.uc_approved_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_approved_lbl.Name = "uc_approved_lbl"
        Me.uc_approved_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_approved_lbl.Size = New System.Drawing.Size(27, 20)
        Me.uc_approved_lbl.TabIndex = 190
        Me.uc_approved_lbl.Visible = False
        '
        'uc_prepared
        '
        Me.uc_prepared.BackColor = System.Drawing.Color.Transparent
        Me.uc_prepared.iAdditional = Nothing
        Me.uc_prepared.iArrow_Visible = False
        Me.uc_prepared.iCanFindLabel_SQLIDx = 0
        Me.uc_prepared.iCharacterLimit = 49
        Me.uc_prepared.idsc = Me.uc_prepared_lbl
        Me.uc_prepared.iForm = Me
        Me.uc_prepared.iIsDropDown = True
        Me.uc_prepared.iIsEnabled = True
        Me.uc_prepared.iIsForSearch = True
        Me.uc_prepared.iIsID = False
        Me.uc_prepared.iIsInnerShow = False
        Me.uc_prepared.iLabel = "Prepared By"
        Me.uc_prepared.iLabel_width = 105
        Me.uc_prepared.isAllowEmptyx = False
        Me.uc_prepared.isForFind = True
        Me.uc_prepared.iSQL_Parameter_ID = 162
        Me.uc_prepared.iSQL_Parameter_ID_FIND = 0
        Me.uc_prepared.iText = ""
        Me.uc_prepared.iTextBox_ = Me.uc_prepared_txt
        Me.uc_prepared.iTextBox_Sel_COL_ID = 0
        Me.uc_prepared.iTitle = ""
        Me.uc_prepared.LinkedColumn = "[ORCL].U_preparedBy"
        Me.uc_prepared.Location = New System.Drawing.Point(10, 65)
        Me.uc_prepared.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_prepared.Name = "uc_prepared"
        Me.uc_prepared.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_prepared.Size = New System.Drawing.Size(279, 20)
        Me.uc_prepared.TabIndex = 189
        '
        'uc_prepared_lbl
        '
        Me.uc_prepared_lbl.AccessibleDescription = ""
        Me.uc_prepared_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_prepared_lbl.iAddition_SQL = Nothing
        Me.uc_prepared_lbl.iAdditional = Nothing
        Me.uc_prepared_lbl.idsc = Nothing
        Me.uc_prepared_lbl.iIsEnabled = True
        Me.uc_prepared_lbl.iIsForSearch = False
        Me.uc_prepared_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_prepared_lbl.iLabel_width = 5
        Me.uc_prepared_lbl.isLabelBoldx = False
        Me.uc_prepared_lbl.iSQL_Parameter_ID = 0
        Me.uc_prepared_lbl.iText = ""
        Me.uc_prepared_lbl.LinkedColumn = ""
        Me.uc_prepared_lbl.Location = New System.Drawing.Point(315, 65)
        Me.uc_prepared_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_prepared_lbl.Name = "uc_prepared_lbl"
        Me.uc_prepared_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_prepared_lbl.Size = New System.Drawing.Size(27, 20)
        Me.uc_prepared_lbl.TabIndex = 190
        Me.uc_prepared_lbl.Visible = False
        '
        'Uc_label1
        '
        Me.Uc_label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Uc_label1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label1.iAddition_SQL = Nothing
        Me.Uc_label1.iAdditional = Nothing
        Me.Uc_label1.idsc = Nothing
        Me.Uc_label1.iIsEnabled = False
        Me.Uc_label1.iIsForSearch = False
        Me.Uc_label1.iLabel = "Total  Qty"
        Me.Uc_label1.iLabel_width = 80
        Me.Uc_label1.isLabelBoldx = True
        Me.Uc_label1.iSQL_Parameter_ID = 0
        Me.Uc_label1.iText = ""
        Me.Uc_label1.LinkedColumn = ""
        Me.Uc_label1.Location = New System.Drawing.Point(10, 584)
        Me.Uc_label1.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label1.Name = "Uc_label1"
        Me.Uc_label1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label1.Size = New System.Drawing.Size(178, 23)
        Me.Uc_label1.TabIndex = 188
        Me.Uc_label1.Visible = False
        '
        'uc_palletingNum_lbl
        '
        Me.uc_palletingNum_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_palletingNum_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_palletingNum_lbl.iAddition_SQL = Nothing
        Me.uc_palletingNum_lbl.iAdditional = Nothing
        Me.uc_palletingNum_lbl.idsc = Nothing
        Me.uc_palletingNum_lbl.iIsEnabled = True
        Me.uc_palletingNum_lbl.iIsForSearch = False
        Me.uc_palletingNum_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_palletingNum_lbl.iLabel_width = 5
        Me.uc_palletingNum_lbl.isLabelBoldx = False
        Me.uc_palletingNum_lbl.iSQL_Parameter_ID = 0
        Me.uc_palletingNum_lbl.iText = ""
        Me.uc_palletingNum_lbl.LinkedColumn = ""
        Me.uc_palletingNum_lbl.Location = New System.Drawing.Point(550, 8)
        Me.uc_palletingNum_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_palletingNum_lbl.Name = "uc_palletingNum_lbl"
        Me.uc_palletingNum_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_palletingNum_lbl.Size = New System.Drawing.Size(27, 22)
        Me.uc_palletingNum_lbl.TabIndex = 187
        Me.uc_palletingNum_lbl.Visible = False
        '
        'uc_controlp
        '
        Me.uc_controlp.BackColor = System.Drawing.Color.Transparent
        Me.uc_controlp.iAdditional = Nothing
        Me.uc_controlp.iArrow_Visible = True
        Me.uc_controlp.iCanFindLabel_SQLIDx = 0
        Me.uc_controlp.iCharacterLimit = 0
        Me.uc_controlp.idsc = Me.uc_controlp_lbl
        Me.uc_controlp.iForm = Me
        Me.uc_controlp.iIsDropDown = True
        Me.uc_controlp.iIsEnabled = False
        Me.uc_controlp.iIsForSearch = True
        Me.uc_controlp.iIsID = False
        Me.uc_controlp.iIsInnerShow = True
        Me.uc_controlp.iLabel = "Controlling Process"
        Me.uc_controlp.iLabel_width = 150
        Me.uc_controlp.isAllowEmptyx = False
        Me.uc_controlp.isForFind = True
        Me.uc_controlp.iSQL_Parameter_ID = 162
        Me.uc_controlp.iSQL_Parameter_ID_FIND = 162
        Me.uc_controlp.iText = ""
        Me.uc_controlp.iTextBox_ = Me.uc_controlp_txt
        Me.uc_controlp.iTextBox_Sel_COL_ID = 0
        Me.uc_controlp.iTitle = ""
        Me.uc_controlp.LinkedColumn = "[ORCL].U_reclassType"
        Me.uc_controlp.Location = New System.Drawing.Point(10, 34)
        Me.uc_controlp.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_controlp.Name = "uc_controlp"
        Me.uc_controlp.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_controlp.Size = New System.Drawing.Size(207, 20)
        Me.uc_controlp.TabIndex = 152
        '
        'uc_controlp_lbl
        '
        Me.uc_controlp_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_controlp_lbl.iAddition_SQL = Nothing
        Me.uc_controlp_lbl.iAdditional = Nothing
        Me.uc_controlp_lbl.idsc = Nothing
        Me.uc_controlp_lbl.iIsEnabled = True
        Me.uc_controlp_lbl.iIsForSearch = False
        Me.uc_controlp_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_controlp_lbl.iLabel_width = 5
        Me.uc_controlp_lbl.isLabelBoldx = False
        Me.uc_controlp_lbl.iSQL_Parameter_ID = 0
        Me.uc_controlp_lbl.iText = ""
        Me.uc_controlp_lbl.LinkedColumn = ""
        Me.uc_controlp_lbl.Location = New System.Drawing.Point(217, 34)
        Me.uc_controlp_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_controlp_lbl.Name = "uc_controlp_lbl"
        Me.uc_controlp_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_controlp_lbl.Size = New System.Drawing.Size(169, 20)
        Me.uc_controlp_lbl.TabIndex = 163
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
        Me.uc_itemcode.iLabel = "Item Code"
        Me.uc_itemcode.iLabel_width = 100
        Me.uc_itemcode.isAllowEmptyx = False
        Me.uc_itemcode.isForFind = True
        Me.uc_itemcode.iSQL_Parameter_ID = 161
        Me.uc_itemcode.iSQL_Parameter_ID_FIND = 168
        Me.uc_itemcode.iText = ""
        Me.uc_itemcode.iTextBox_ = Me.uc_itemcode_txt
        Me.uc_itemcode.iTextBox_Sel_COL_ID = 0
        Me.uc_itemcode.iTitle = ""
        Me.uc_itemcode.LinkedColumn = "[ORCL].U_itemcode"
        Me.uc_itemcode.Location = New System.Drawing.Point(10, 10)
        Me.uc_itemcode.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_itemcode.Name = "uc_itemcode"
        Me.uc_itemcode.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_itemcode.Size = New System.Drawing.Size(207, 20)
        Me.uc_itemcode.TabIndex = 152
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
        Me.uc_itemcode_lbl.Location = New System.Drawing.Point(217, 10)
        Me.uc_itemcode_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_itemcode_lbl.Name = "uc_itemcode_lbl"
        Me.uc_itemcode_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_itemcode_lbl.Size = New System.Drawing.Size(169, 20)
        Me.uc_itemcode_lbl.TabIndex = 163
        '
        'uc_doc
        '
        Me.uc_doc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_doc.BackColor = System.Drawing.Color.Transparent
        Me.uc_doc.iAdditional = Nothing
        Me.uc_doc.iArrow_Visible = False
        Me.uc_doc.iCanFindLabel_SQLIDx = 0
        Me.uc_doc.iCharacterLimit = 0
        Me.uc_doc.idsc = Me.uc_palletingNum_lbl
        Me.uc_doc.iForm = Me
        Me.uc_doc.iIsDropDown = True
        Me.uc_doc.iIsEnabled = False
        Me.uc_doc.iIsForSearch = False
        Me.uc_doc.iIsID = False
        Me.uc_doc.iIsInnerShow = True
        Me.uc_doc.iLabel = "Number"
        Me.uc_doc.iLabel_width = 105
        Me.uc_doc.isAllowEmptyx = True
        Me.uc_doc.isForFind = False
        Me.uc_doc.iSQL_Parameter_ID = 157
        Me.uc_doc.iSQL_Parameter_ID_FIND = 0
        Me.uc_doc.iText = ""
        Me.uc_doc.iTextBox_ = Me.txt_uc_palletingNum
        Me.uc_doc.iTextBox_Sel_COL_ID = 0
        Me.uc_doc.iTitle = ""
        Me.uc_doc.LinkedColumn = "[ORCL].DocEntry"
        Me.uc_doc.Location = New System.Drawing.Point(618, 5)
        Me.uc_doc.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_doc.Name = "uc_doc"
        Me.uc_doc.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_doc.Size = New System.Drawing.Size(305, 23)
        Me.uc_doc.TabIndex = 161
        '
        'uc_DocDate
        '
        Me.uc_DocDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_DocDate.BackColor = System.Drawing.Color.Transparent
        Me.uc_DocDate.Enabled = False
        Me.uc_DocDate.iDate = New Date(2020, 7, 23, 9, 1, 59, 833)
        Me.uc_DocDate.idsc = Nothing
        Me.uc_DocDate.iForm = Me
        Me.uc_DocDate.iIsForSearch = False
        Me.uc_DocDate.iLabel = "Posting Date"
        Me.uc_DocDate.iLabel_width = 120
        Me.uc_DocDate.IsEnabled = False
        Me.uc_DocDate.isForFind = False
        Me.uc_DocDate.iSQL_Parameter_ID = 0
        Me.uc_DocDate.LinkedColumn = "[ORCL].createdDate"
        Me.uc_DocDate.Location = New System.Drawing.Point(618, 30)
        Me.uc_DocDate.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_DocDate.Name = "uc_DocDate"
        Me.uc_DocDate.Size = New System.Drawing.Size(305, 24)
        Me.uc_DocDate.TabIndex = 158
        '
        'uc_warehouseto_lb
        '
        Me.uc_warehouseto_lb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_warehouseto_lb.BackColor = System.Drawing.Color.Transparent
        Me.uc_warehouseto_lb.iAddition_SQL = Nothing
        Me.uc_warehouseto_lb.iAdditional = Nothing
        Me.uc_warehouseto_lb.idsc = Nothing
        Me.uc_warehouseto_lb.iIsEnabled = True
        Me.uc_warehouseto_lb.iIsForSearch = False
        Me.uc_warehouseto_lb.iLabel = "Edit iLbl to edit me"
        Me.uc_warehouseto_lb.iLabel_width = 5
        Me.uc_warehouseto_lb.isLabelBoldx = False
        Me.uc_warehouseto_lb.iSQL_Parameter_ID = 0
        Me.uc_warehouseto_lb.iText = ""
        Me.uc_warehouseto_lb.LinkedColumn = ""
        Me.uc_warehouseto_lb.Location = New System.Drawing.Point(707, 167)
        Me.uc_warehouseto_lb.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_warehouseto_lb.Name = "uc_warehouseto_lb"
        Me.uc_warehouseto_lb.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_warehouseto_lb.Size = New System.Drawing.Size(219, 23)
        Me.uc_warehouseto_lb.TabIndex = 163
        '
        'uc_warehouseto
        '
        Me.uc_warehouseto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_warehouseto.BackColor = System.Drawing.Color.Transparent
        Me.uc_warehouseto.iAddition_SQL = Nothing
        Me.uc_warehouseto.iAdditional = Nothing
        Me.uc_warehouseto.idsc = Nothing
        Me.uc_warehouseto.iIsEnabled = True
        Me.uc_warehouseto.iIsForSearch = False
        Me.uc_warehouseto.iLabel = "To Warehouse"
        Me.uc_warehouseto.iLabel_width = 120
        Me.uc_warehouseto.isLabelBoldx = False
        Me.uc_warehouseto.iSQL_Parameter_ID = 0
        Me.uc_warehouseto.iText = ""
        Me.uc_warehouseto.LinkedColumn = "[ORCL].whseCodeTo"
        Me.uc_warehouseto.Location = New System.Drawing.Point(515, 167)
        Me.uc_warehouseto.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_warehouseto.Name = "uc_warehouseto"
        Me.uc_warehouseto.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_warehouseto.Size = New System.Drawing.Size(190, 23)
        Me.uc_warehouseto.TabIndex = 163
        '
        'uc_warehouseF_lbl
        '
        Me.uc_warehouseF_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_warehouseF_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_warehouseF_lbl.iAddition_SQL = Nothing
        Me.uc_warehouseF_lbl.iAdditional = Nothing
        Me.uc_warehouseF_lbl.idsc = Nothing
        Me.uc_warehouseF_lbl.iIsEnabled = True
        Me.uc_warehouseF_lbl.iIsForSearch = False
        Me.uc_warehouseF_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_warehouseF_lbl.iLabel_width = 5
        Me.uc_warehouseF_lbl.isLabelBoldx = False
        Me.uc_warehouseF_lbl.iSQL_Parameter_ID = 0
        Me.uc_warehouseF_lbl.iText = ""
        Me.uc_warehouseF_lbl.LinkedColumn = ""
        Me.uc_warehouseF_lbl.Location = New System.Drawing.Point(707, 143)
        Me.uc_warehouseF_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_warehouseF_lbl.Name = "uc_warehouseF_lbl"
        Me.uc_warehouseF_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_warehouseF_lbl.Size = New System.Drawing.Size(219, 23)
        Me.uc_warehouseF_lbl.TabIndex = 163
        '
        'uc_warehouseF
        '
        Me.uc_warehouseF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_warehouseF.BackColor = System.Drawing.Color.Transparent
        Me.uc_warehouseF.iAddition_SQL = Nothing
        Me.uc_warehouseF.iAdditional = Nothing
        Me.uc_warehouseF.idsc = Nothing
        Me.uc_warehouseF.iIsEnabled = True
        Me.uc_warehouseF.iIsForSearch = False
        Me.uc_warehouseF.iLabel = "From Warehouse"
        Me.uc_warehouseF.iLabel_width = 120
        Me.uc_warehouseF.isLabelBoldx = False
        Me.uc_warehouseF.iSQL_Parameter_ID = 0
        Me.uc_warehouseF.iText = ""
        Me.uc_warehouseF.LinkedColumn = "[ORCL].whseCodeFrom"
        Me.uc_warehouseF.Location = New System.Drawing.Point(515, 143)
        Me.uc_warehouseF.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_warehouseF.Name = "uc_warehouseF"
        Me.uc_warehouseF.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_warehouseF.Size = New System.Drawing.Size(190, 23)
        Me.uc_warehouseF.TabIndex = 163
        '
        'uc_machine
        '
        Me.uc_machine.BackColor = System.Drawing.Color.Transparent
        Me.uc_machine.iAddition_SQL = Nothing
        Me.uc_machine.iAdditional = Nothing
        Me.uc_machine.idsc = Nothing
        Me.uc_machine.iIsEnabled = True
        Me.uc_machine.iIsForSearch = False
        Me.uc_machine.iLabel = "Machine"
        Me.uc_machine.iLabel_width = 120
        Me.uc_machine.isLabelBoldx = False
        Me.uc_machine.iSQL_Parameter_ID = 0
        Me.uc_machine.iText = ""
        Me.uc_machine.LinkedColumn = ""
        Me.uc_machine.Location = New System.Drawing.Point(417, 34)
        Me.uc_machine.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_machine.Name = "uc_machine"
        Me.uc_machine.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_machine.Size = New System.Drawing.Size(23, 20)
        Me.uc_machine.TabIndex = 163
        Me.uc_machine.Visible = False
        '
        'uc_TaxDate
        '
        Me.uc_TaxDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_TaxDate.BackColor = System.Drawing.Color.Transparent
        Me.uc_TaxDate.iDate = New Date(2020, 7, 23, 9, 1, 59, 853)
        Me.uc_TaxDate.idsc = Nothing
        Me.uc_TaxDate.iForm = Me
        Me.uc_TaxDate.iIsForSearch = False
        Me.uc_TaxDate.iLabel = "Document Date"
        Me.uc_TaxDate.iLabel_width = 120
        Me.uc_TaxDate.IsEnabled = False
        Me.uc_TaxDate.isForFind = False
        Me.uc_TaxDate.iSQL_Parameter_ID = 0
        Me.uc_TaxDate.LinkedColumn = "[ORCL].docdate"
        Me.uc_TaxDate.Location = New System.Drawing.Point(618, 56)
        Me.uc_TaxDate.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_TaxDate.Name = "uc_TaxDate"
        Me.uc_TaxDate.Size = New System.Drawing.Size(305, 24)
        Me.uc_TaxDate.TabIndex = 159
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(363, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(114, 20)
        Me.TextBox2.TabIndex = 195
        Me.TextBox2.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(667, 587)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 21)
        Me.Button1.TabIndex = 196
        Me.Button1.Tag = "0"
        Me.Button1.Text = "Send Draft"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'uc_remarks
        '
        Me.uc_remarks.BackColor = System.Drawing.Color.Transparent
        Me.uc_remarks.iAddition_SQL = Nothing
        Me.uc_remarks.iAdditional = Nothing
        Me.uc_remarks.idsc = Nothing
        Me.uc_remarks.iIsEnabled = True
        Me.uc_remarks.iIsForSearch = False
        Me.uc_remarks.iLabel = "Remarks"
        Me.uc_remarks.iLabel_width = 123
        Me.uc_remarks.isLabelBoldx = False
        Me.uc_remarks.iSQL_Parameter_ID = 0
        Me.uc_remarks.iText = ""
        Me.uc_remarks.LinkedColumn = "[ORCL].Remarks"
        Me.uc_remarks.Location = New System.Drawing.Point(10, 167)
        Me.uc_remarks.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_remarks.Name = "uc_remarks"
        Me.uc_remarks.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_remarks.Size = New System.Drawing.Size(467, 20)
        Me.uc_remarks.TabIndex = 197
        '
        'Uc_inputbox1
        '
        Me.Uc_inputbox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_inputbox1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_inputbox1.iAdditional = Nothing
        Me.Uc_inputbox1.iArrow_Visible = False
        Me.Uc_inputbox1.iCanFindLabel_SQLIDx = 0
        Me.Uc_inputbox1.iCharacterLimit = 49
        Me.Uc_inputbox1.idsc = Me.Uc_label2
        Me.Uc_inputbox1.iForm = Me
        Me.Uc_inputbox1.iIsDropDown = True
        Me.Uc_inputbox1.iIsEnabled = False
        Me.Uc_inputbox1.iIsForSearch = True
        Me.Uc_inputbox1.iIsID = False
        Me.Uc_inputbox1.iIsInnerShow = False
        Me.Uc_inputbox1.iLabel = "User"
        Me.Uc_inputbox1.iLabel_width = 105
        Me.Uc_inputbox1.isAllowEmptyx = True
        Me.Uc_inputbox1.isForFind = True
        Me.Uc_inputbox1.iSQL_Parameter_ID = 0
        Me.Uc_inputbox1.iSQL_Parameter_ID_FIND = 108
        Me.Uc_inputbox1.iText = ""
        Me.Uc_inputbox1.iTextBox_ = Me.TextBox3
        Me.Uc_inputbox1.iTextBox_Sel_COL_ID = 0
        Me.Uc_inputbox1.iTitle = ""
        Me.Uc_inputbox1.LinkedColumn = "[ORCL].UserSign"
        Me.Uc_inputbox1.Location = New System.Drawing.Point(618, 82)
        Me.Uc_inputbox1.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_inputbox1.Name = "Uc_inputbox1"
        Me.Uc_inputbox1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_inputbox1.Size = New System.Drawing.Size(153, 20)
        Me.Uc_inputbox1.TabIndex = 198
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
        Me.Uc_label2.iLabel = "Edit iLbl to edit me"
        Me.Uc_label2.iLabel_width = 5
        Me.Uc_label2.isLabelBoldx = False
        Me.Uc_label2.iSQL_Parameter_ID = 0
        Me.Uc_label2.iText = ""
        Me.Uc_label2.LinkedColumn = ""
        Me.Uc_label2.Location = New System.Drawing.Point(771, 82)
        Me.Uc_label2.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label2.Name = "Uc_label2"
        Me.Uc_label2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label2.Size = New System.Drawing.Size(151, 20)
        Me.Uc_label2.TabIndex = 199
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(897, 106)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(23, 20)
        Me.TextBox3.TabIndex = 200
        Me.TextBox3.Visible = False
        '
        'btn_ok
        '
        Me.btn_ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.Black
        Me.btn_ok.Image = Global.IpicIndirect.My.Resources.Resources.btn_bar1
        Me.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ok.Location = New System.Drawing.Point(819, 586)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(101, 23)
        Me.btn_ok.TabIndex = 201
        Me.btn_ok.Tag = "0"
        Me.btn_ok.Text = "&Add"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'reclass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 617)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.Uc_inputbox1)
        Me.Controls.Add(Me.Uc_label2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.uc_remarks)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.uc_status)
        Me.Controls.Add(Me.uc_status_lbl)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.uc_approved)
        Me.Controls.Add(Me.uc_prepared)
        Me.Controls.Add(Me.uc_approved_lbl)
        Me.Controls.Add(Me.uc_approved_txt)
        Me.Controls.Add(Me.uc_prepared_lbl)
        Me.Controls.Add(Me.uc_prepared_txt)
        Me.Controls.Add(Me.Uc_label1)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.uc_palletingNum_lbl)
        Me.Controls.Add(Me.txt_uc_palletingNum)
        Me.Controls.Add(Me.uc_controlp)
        Me.Controls.Add(Me.uc_itemcode)
        Me.Controls.Add(Me.uc_doc)
        Me.Controls.Add(Me.uc_DocDate)
        Me.Controls.Add(Me.uc_warehouseto_lb)
        Me.Controls.Add(Me.uc_warehouseto)
        Me.Controls.Add(Me.uc_warehouseF_lbl)
        Me.Controls.Add(Me.uc_warehouseF)
        Me.Controls.Add(Me.uc_machine)
        Me.Controls.Add(Me.uc_controlp_lbl)
        Me.Controls.Add(Me.uc_controlp_txt)
        Me.Controls.Add(Me.uc_itemcode_lbl)
        Me.Controls.Add(Me.uc_itemcode_txt)
        Me.Controls.Add(Me.uc_TaxDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "reclass"
        Me.Text = "s"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMS_main.ResumeLayout(False)
        Me.cms_copy.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents dgv As DataGridView
    Friend WithEvents uc_itemcode As uc_inputbox
    Friend WithEvents uc_itemcode_lbl As uc_label
    Friend WithEvents uc_itemcode_txt As TextBox
    Friend WithEvents uc_doc As uc_inputbox
    Friend WithEvents uc_palletingNum_lbl As uc_label
    Friend WithEvents txt_uc_palletingNum As TextBox
    Friend WithEvents uc_DocDate As uc_date
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cms_copy As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents uc_TaxDate As uc_date
    Friend WithEvents uc_controlp As uc_inputbox
    Friend WithEvents uc_controlp_lbl As uc_label
    Friend WithEvents uc_controlp_txt As TextBox
    Friend WithEvents uc_warehouseF_lbl As uc_label
    Friend WithEvents uc_warehouseF As uc_label
    Friend WithEvents uc_machine As uc_label
    Friend WithEvents uc_warehouseto_lb As uc_label
    Friend WithEvents uc_warehouseto As uc_label
    Friend WithEvents CMS_main As ContextMenuStrip
    Friend WithEvents PickFromPalletingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Uc_label1 As uc_label
    Friend WithEvents uc_approved As uc_inputbox
    Friend WithEvents uc_approved_lbl As uc_label
    Friend WithEvents uc_approved_txt As TextBox
    Friend WithEvents uc_prepared As uc_inputbox
    Friend WithEvents uc_prepared_lbl As uc_label
    Friend WithEvents uc_prepared_txt As TextBox
    Friend WithEvents uc_status As uc_inputbox
    Friend WithEvents uc_status_lbl As uc_label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents uc_remarks As uc_label
    Friend WithEvents Uc_inputbox1 As uc_inputbox
    Friend WithEvents Uc_label2 As uc_label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btn_ok As Button
End Class
