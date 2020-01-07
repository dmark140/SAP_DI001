<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Palleting
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.docnum_container = New System.Windows.Forms.TextBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms_copy = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txt_frmWhs = New System.Windows.Forms.TextBox()
        Me.txt_docNum = New System.Windows.Forms.TextBox()
        Me.docnum_container_desc = New System.Windows.Forms.TextBox()
        Me.txt_uc_palletingNum = New System.Windows.Forms.TextBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.txt_null = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_palleted = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_forPallet = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.uc_LP_date = New IpicIndirect.uc_date()
        Me.uc_palletingNum_lbl = New IpicIndirect.uc_label()
        Me.uc_station_lbl = New IpicIndirect.uc_label()
        Me.uc_station = New IpicIndirect.uc_inputbox()
        Me.uc_packer_lbl = New IpicIndirect.uc_label()
        Me.uc_packer = New IpicIndirect.uc_inputbox()
        Me.Uc_inputbox3 = New IpicIndirect.uc_inputbox()
        Me.uc_LP_qty = New IpicIndirect.uc_label()
        Me.uc_docnum_lbl = New IpicIndirect.uc_label()
        Me.uc_LP_pallet_num = New IpicIndirect.uc_label()
        Me.uc_docnum = New IpicIndirect.uc_inputbox()
        Me.uc_LP_Docnum = New IpicIndirect.uc_label()
        Me.uc_fromWHse = New IpicIndirect.uc_inputbox()
        Me.uc_fromWHse_lbl = New IpicIndirect.uc_label()
        Me.uc_palletingNum = New IpicIndirect.uc_inputbox()
        Me.Uc_label1 = New IpicIndirect.uc_label()
        Me.uc_null = New IpicIndirect.uc_label()
        Me.uc_recieved = New IpicIndirect.uc_inputbox()
        Me.uc_recieved_lbl = New IpicIndirect.uc_label()
        Me.uc_ToWHse = New IpicIndirect.uc_inputbox()
        Me.uc_ToWHse_lbl = New IpicIndirect.uc_label()
        Me.uc_release_lbl = New IpicIndirect.uc_label()
        Me.uc_release = New IpicIndirect.uc_inputbox()
        Me.uc_paletsizer_LBl = New IpicIndirect.uc_label()
        Me.uc_paletsizer = New IpicIndirect.uc_inputbox()
        Me.uc_TaxDate = New IpicIndirect.uc_date()
        Me.uc_DocDate = New IpicIndirect.uc_date()
        Me.cms_copy.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_palleted, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_forPallet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'docnum_container
        '
        Me.docnum_container.Location = New System.Drawing.Point(884, 43)
        Me.docnum_container.Name = "docnum_container"
        Me.docnum_container.Size = New System.Drawing.Size(13, 20)
        Me.docnum_container.TabIndex = 90
        Me.docnum_container.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem1.Text = "Copy with header"
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
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem2.Text = "Cancel"
        '
        'cms_copy
        '
        Me.cms_copy.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_copy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem3, Me.ToolStripSeparator2, Me.ToolStripMenuItem2})
        Me.cms_copy.Name = "ContextMenuStrip1"
        Me.cms_copy.Size = New System.Drawing.Size(169, 76)
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'txt_frmWhs
        '
        Me.txt_frmWhs.Location = New System.Drawing.Point(424, 13)
        Me.txt_frmWhs.Name = "txt_frmWhs"
        Me.txt_frmWhs.Size = New System.Drawing.Size(23, 20)
        Me.txt_frmWhs.TabIndex = 90
        Me.txt_frmWhs.Visible = False
        '
        'txt_docNum
        '
        Me.txt_docNum.Location = New System.Drawing.Point(424, 63)
        Me.txt_docNum.Name = "txt_docNum"
        Me.txt_docNum.Size = New System.Drawing.Size(23, 20)
        Me.txt_docNum.TabIndex = 90
        Me.txt_docNum.Visible = False
        '
        'docnum_container_desc
        '
        Me.docnum_container_desc.Location = New System.Drawing.Point(903, 41)
        Me.docnum_container_desc.Name = "docnum_container_desc"
        Me.docnum_container_desc.Size = New System.Drawing.Size(13, 20)
        Me.docnum_container_desc.TabIndex = 90
        Me.docnum_container_desc.Visible = False
        '
        'txt_uc_palletingNum
        '
        Me.txt_uc_palletingNum.Location = New System.Drawing.Point(1037, 17)
        Me.txt_uc_palletingNum.Name = "txt_uc_palletingNum"
        Me.txt_uc_palletingNum.Size = New System.Drawing.Size(23, 20)
        Me.txt_uc_palletingNum.TabIndex = 108
        Me.txt_uc_palletingNum.Visible = False
        '
        'btn_ok
        '
        Me.btn_ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(830, 530)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(116, 22)
        Me.btn_ok.TabIndex = 99
        Me.btn_ok.Tag = "0"
        Me.btn_ok.Text = "Add"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'txt_null
        '
        Me.txt_null.Location = New System.Drawing.Point(451, 93)
        Me.txt_null.Name = "txt_null"
        Me.txt_null.Size = New System.Drawing.Size(23, 20)
        Me.txt_null.TabIndex = 100
        Me.txt_null.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_palleted)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(920, 275)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Palleted"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_palleted
        '
        Me.dgv_palleted.AllowUserToAddRows = False
        Me.dgv_palleted.AllowUserToDeleteRows = False
        Me.dgv_palleted.BackgroundColor = System.Drawing.Color.White
        Me.dgv_palleted.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_palleted.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_palleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_palleted.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_palleted.EnableHeadersVisualStyles = False
        Me.dgv_palleted.Location = New System.Drawing.Point(3, 3)
        Me.dgv_palleted.Name = "dgv_palleted"
        Me.dgv_palleted.ReadOnly = True
        Me.dgv_palleted.RowHeadersVisible = False
        Me.dgv_palleted.RowTemplate.Height = 24
        Me.dgv_palleted.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_palleted.Size = New System.Drawing.Size(914, 269)
        Me.dgv_palleted.TabIndex = 91
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_forPallet)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(920, 275)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "For Palleting"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv_forPallet
        '
        Me.dgv_forPallet.AllowUserToAddRows = False
        Me.dgv_forPallet.AllowUserToDeleteRows = False
        Me.dgv_forPallet.BackgroundColor = System.Drawing.Color.White
        Me.dgv_forPallet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_forPallet.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_forPallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_forPallet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_forPallet.EnableHeadersVisualStyles = False
        Me.dgv_forPallet.Location = New System.Drawing.Point(3, 3)
        Me.dgv_forPallet.Name = "dgv_forPallet"
        Me.dgv_forPallet.ReadOnly = True
        Me.dgv_forPallet.RowHeadersVisible = False
        Me.dgv_forPallet.RowTemplate.Height = 24
        Me.dgv_forPallet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_forPallet.Size = New System.Drawing.Size(914, 269)
        Me.dgv_forPallet.TabIndex = 91
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(18, 177)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(928, 301)
        Me.TabControl1.TabIndex = 101
        '
        'txt_remarks
        '
        Me.txt_remarks.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_remarks.Location = New System.Drawing.Point(707, 93)
        Me.txt_remarks.Multiline = True
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(232, 74)
        Me.txt_remarks.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(571, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(0, 0)
        Me.Panel2.TabIndex = 101
        Me.Panel2.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(480, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 110
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(570, 95)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(129, 20)
        Me.TextBox1.TabIndex = 111
        Me.TextBox1.Visible = False
        '
        'uc_LP_date
        '
        Me.uc_LP_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.uc_LP_date.BackColor = System.Drawing.Color.Transparent
        Me.uc_LP_date.iDate = New Date(2020, 8, 8, 9, 39, 7, 643)
        Me.uc_LP_date.idsc = Nothing
        Me.uc_LP_date.iForm = Me
        Me.uc_LP_date.iIsForSearch = False
        Me.uc_LP_date.iLabel = "MNF Date"
        Me.uc_LP_date.iLabel_width = 80
        Me.uc_LP_date.IsEnabled = True
        Me.uc_LP_date.isForFind = True
        Me.uc_LP_date.iSQL_Parameter_ID = 0
        Me.uc_LP_date.LinkedColumn = ""
        Me.uc_LP_date.Location = New System.Drawing.Point(15, 506)
        Me.uc_LP_date.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_LP_date.Name = "uc_LP_date"
        Me.uc_LP_date.Size = New System.Drawing.Size(208, 24)
        Me.uc_LP_date.TabIndex = 112
        '
        'uc_palletingNum_lbl
        '
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
        Me.uc_palletingNum_lbl.Location = New System.Drawing.Point(1006, 17)
        Me.uc_palletingNum_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_palletingNum_lbl.Name = "uc_palletingNum_lbl"
        Me.uc_palletingNum_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_palletingNum_lbl.Size = New System.Drawing.Size(27, 22)
        Me.uc_palletingNum_lbl.TabIndex = 109
        Me.uc_palletingNum_lbl.Visible = False
        '
        'uc_station_lbl
        '
        Me.uc_station_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_station_lbl.iAddition_SQL = Nothing
        Me.uc_station_lbl.iAdditional = Nothing
        Me.uc_station_lbl.idsc = Nothing
        Me.uc_station_lbl.iIsEnabled = True
        Me.uc_station_lbl.iIsForSearch = False
        Me.uc_station_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_station_lbl.iLabel_width = 5
        Me.uc_station_lbl.isLabelBoldx = False
        Me.uc_station_lbl.iSQL_Parameter_ID = 0
        Me.uc_station_lbl.iText = ""
        Me.uc_station_lbl.LinkedColumn = ""
        Me.uc_station_lbl.Location = New System.Drawing.Point(422, 93)
        Me.uc_station_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_station_lbl.Name = "uc_station_lbl"
        Me.uc_station_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_station_lbl.Size = New System.Drawing.Size(25, 22)
        Me.uc_station_lbl.TabIndex = 107
        Me.uc_station_lbl.Visible = False
        '
        'uc_station
        '
        Me.uc_station.BackColor = System.Drawing.Color.Transparent
        Me.uc_station.iAdditional = Nothing
        Me.uc_station.iArrow_Visible = True
        Me.uc_station.iCanFindLabel_SQLIDx = 0
        Me.uc_station.iCharacterLimit = 0
        Me.uc_station.idsc = Me.uc_station_lbl
        Me.uc_station.iForm = Me
        Me.uc_station.iIsDropDown = False
        Me.uc_station.iIsEnabled = False
        Me.uc_station.iIsForSearch = True
        Me.uc_station.iIsID = False
        Me.uc_station.iIsInnerShow = True
        Me.uc_station.iLabel = "Station"
        Me.uc_station.iLabel_width = 105
        Me.uc_station.isAllowEmptyx = True
        Me.uc_station.isForFind = False
        Me.uc_station.iSQL_Parameter_ID = 153
        Me.uc_station.iSQL_Parameter_ID_FIND = 0
        Me.uc_station.iText = ""
        Me.uc_station.iTextBox_ = Me.docnum_container
        Me.uc_station.iTextBox_Sel_COL_ID = 0
        Me.uc_station.iTitle = ""
        Me.uc_station.LinkedColumn = ""
        Me.uc_station.Location = New System.Drawing.Point(19, 93)
        Me.uc_station.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_station.Name = "uc_station"
        Me.uc_station.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_station.Size = New System.Drawing.Size(401, 23)
        Me.uc_station.TabIndex = 106
        Me.uc_station.Visible = False
        '
        'uc_packer_lbl
        '
        Me.uc_packer_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_packer_lbl.iAddition_SQL = Nothing
        Me.uc_packer_lbl.iAdditional = Nothing
        Me.uc_packer_lbl.idsc = Nothing
        Me.uc_packer_lbl.iIsEnabled = True
        Me.uc_packer_lbl.iIsForSearch = False
        Me.uc_packer_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_packer_lbl.iLabel_width = 5
        Me.uc_packer_lbl.isLabelBoldx = False
        Me.uc_packer_lbl.iSQL_Parameter_ID = 0
        Me.uc_packer_lbl.iText = ""
        Me.uc_packer_lbl.LinkedColumn = ""
        Me.uc_packer_lbl.Location = New System.Drawing.Point(569, 151)
        Me.uc_packer_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_packer_lbl.Name = "uc_packer_lbl"
        Me.uc_packer_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_packer_lbl.Size = New System.Drawing.Size(25, 25)
        Me.uc_packer_lbl.TabIndex = 107
        Me.uc_packer_lbl.Visible = False
        '
        'uc_packer
        '
        Me.uc_packer.BackColor = System.Drawing.Color.Transparent
        Me.uc_packer.iAdditional = Nothing
        Me.uc_packer.iArrow_Visible = False
        Me.uc_packer.iCanFindLabel_SQLIDx = 0
        Me.uc_packer.iCharacterLimit = 10
        Me.uc_packer.idsc = Me.uc_packer_lbl
        Me.uc_packer.iForm = Me
        Me.uc_packer.iIsDropDown = False
        Me.uc_packer.iIsEnabled = True
        Me.uc_packer.iIsForSearch = True
        Me.uc_packer.iIsID = False
        Me.uc_packer.iIsInnerShow = True
        Me.uc_packer.iLabel = "Packer"
        Me.uc_packer.iLabel_width = 105
        Me.uc_packer.isAllowEmptyx = False
        Me.uc_packer.isForFind = False
        Me.uc_packer.iSQL_Parameter_ID = 4
        Me.uc_packer.iSQL_Parameter_ID_FIND = 0
        Me.uc_packer.iText = ""
        Me.uc_packer.iTextBox_ = Me.txt_null
        Me.uc_packer.iTextBox_Sel_COL_ID = 0
        Me.uc_packer.iTitle = ""
        Me.uc_packer.LinkedColumn = ""
        Me.uc_packer.Location = New System.Drawing.Point(276, 150)
        Me.uc_packer.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_packer.Name = "uc_packer"
        Me.uc_packer.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_packer.Size = New System.Drawing.Size(266, 23)
        Me.uc_packer.TabIndex = 5
        '
        'Uc_inputbox3
        '
        Me.Uc_inputbox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_inputbox3.BackColor = System.Drawing.Color.Transparent
        Me.Uc_inputbox3.iAdditional = Nothing
        Me.Uc_inputbox3.iArrow_Visible = False
        Me.Uc_inputbox3.iCanFindLabel_SQLIDx = 0
        Me.Uc_inputbox3.iCharacterLimit = 0
        Me.Uc_inputbox3.idsc = Nothing
        Me.Uc_inputbox3.iForm = Me
        Me.Uc_inputbox3.iIsDropDown = False
        Me.Uc_inputbox3.iIsEnabled = False
        Me.Uc_inputbox3.iIsForSearch = True
        Me.Uc_inputbox3.iIsID = False
        Me.Uc_inputbox3.iIsInnerShow = True
        Me.Uc_inputbox3.iLabel = "Remarks"
        Me.Uc_inputbox3.iLabel_width = 105
        Me.Uc_inputbox3.isAllowEmptyx = True
        Me.Uc_inputbox3.isForFind = False
        Me.Uc_inputbox3.iSQL_Parameter_ID = 4
        Me.Uc_inputbox3.iSQL_Parameter_ID_FIND = 0
        Me.Uc_inputbox3.iText = ""
        Me.Uc_inputbox3.iTextBox_ = Me.txt_remarks
        Me.Uc_inputbox3.iTextBox_Sel_COL_ID = 0
        Me.Uc_inputbox3.iTitle = ""
        Me.Uc_inputbox3.LinkedColumn = ""
        Me.Uc_inputbox3.Location = New System.Drawing.Point(643, 147)
        Me.Uc_inputbox3.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_inputbox3.Name = "Uc_inputbox3"
        Me.Uc_inputbox3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_inputbox3.Size = New System.Drawing.Size(161, 23)
        Me.Uc_inputbox3.TabIndex = 102
        '
        'uc_LP_qty
        '
        Me.uc_LP_qty.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.uc_LP_qty.BackColor = System.Drawing.Color.Transparent
        Me.uc_LP_qty.iAddition_SQL = Nothing
        Me.uc_LP_qty.iAdditional = Nothing
        Me.uc_LP_qty.idsc = Nothing
        Me.uc_LP_qty.iIsEnabled = True
        Me.uc_LP_qty.iIsForSearch = False
        Me.uc_LP_qty.iLabel = "Quantity"
        Me.uc_LP_qty.iLabel_width = 80
        Me.uc_LP_qty.isLabelBoldx = False
        Me.uc_LP_qty.iSQL_Parameter_ID = 0
        Me.uc_LP_qty.iText = "0"
        Me.uc_LP_qty.LinkedColumn = ""
        Me.uc_LP_qty.Location = New System.Drawing.Point(15, 532)
        Me.uc_LP_qty.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_LP_qty.Name = "uc_LP_qty"
        Me.uc_LP_qty.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_LP_qty.Size = New System.Drawing.Size(208, 22)
        Me.uc_LP_qty.TabIndex = 105
        '
        'uc_docnum_lbl
        '
        Me.uc_docnum_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_docnum_lbl.iAddition_SQL = Nothing
        Me.uc_docnum_lbl.iAdditional = Nothing
        Me.uc_docnum_lbl.idsc = Nothing
        Me.uc_docnum_lbl.iIsEnabled = True
        Me.uc_docnum_lbl.iIsForSearch = False
        Me.uc_docnum_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_docnum_lbl.iLabel_width = 5
        Me.uc_docnum_lbl.isLabelBoldx = False
        Me.uc_docnum_lbl.iSQL_Parameter_ID = 0
        Me.uc_docnum_lbl.iText = ""
        Me.uc_docnum_lbl.LinkedColumn = ""
        Me.uc_docnum_lbl.Location = New System.Drawing.Point(214, 63)
        Me.uc_docnum_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_docnum_lbl.Name = "uc_docnum_lbl"
        Me.uc_docnum_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_docnum_lbl.Size = New System.Drawing.Size(206, 22)
        Me.uc_docnum_lbl.TabIndex = 99
        Me.uc_docnum_lbl.Visible = False
        '
        'uc_LP_pallet_num
        '
        Me.uc_LP_pallet_num.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.uc_LP_pallet_num.BackColor = System.Drawing.Color.Transparent
        Me.uc_LP_pallet_num.iAddition_SQL = Nothing
        Me.uc_LP_pallet_num.iAdditional = Nothing
        Me.uc_LP_pallet_num.idsc = Nothing
        Me.uc_LP_pallet_num.iIsEnabled = True
        Me.uc_LP_pallet_num.iIsForSearch = False
        Me.uc_LP_pallet_num.iLabel = "Pallet #"
        Me.uc_LP_pallet_num.iLabel_width = 80
        Me.uc_LP_pallet_num.isLabelBoldx = False
        Me.uc_LP_pallet_num.iSQL_Parameter_ID = 0
        Me.uc_LP_pallet_num.iText = "0"
        Me.uc_LP_pallet_num.LinkedColumn = ""
        Me.uc_LP_pallet_num.Location = New System.Drawing.Point(225, 530)
        Me.uc_LP_pallet_num.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_LP_pallet_num.Name = "uc_LP_pallet_num"
        Me.uc_LP_pallet_num.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_LP_pallet_num.Size = New System.Drawing.Size(189, 22)
        Me.uc_LP_pallet_num.TabIndex = 105
        '
        'uc_docnum
        '
        Me.uc_docnum.BackColor = System.Drawing.Color.Transparent
        Me.uc_docnum.iAdditional = Nothing
        Me.uc_docnum.iArrow_Visible = True
        Me.uc_docnum.iCanFindLabel_SQLIDx = 0
        Me.uc_docnum.iCharacterLimit = 0
        Me.uc_docnum.idsc = Me.uc_docnum_lbl
        Me.uc_docnum.iForm = Me
        Me.uc_docnum.iIsDropDown = False
        Me.uc_docnum.iIsEnabled = True
        Me.uc_docnum.iIsForSearch = True
        Me.uc_docnum.iIsID = False
        Me.uc_docnum.iIsInnerShow = True
        Me.uc_docnum.iLabel = "Document #"
        Me.uc_docnum.iLabel_width = 105
        Me.uc_docnum.isAllowEmptyx = False
        Me.uc_docnum.isForFind = False
        Me.uc_docnum.iSQL_Parameter_ID = 141
        Me.uc_docnum.iSQL_Parameter_ID_FIND = 0
        Me.uc_docnum.iText = ""
        Me.uc_docnum.iTextBox_ = Me.txt_docNum
        Me.uc_docnum.iTextBox_Sel_COL_ID = 0
        Me.uc_docnum.iTitle = ""
        Me.uc_docnum.LinkedColumn = ""
        Me.uc_docnum.Location = New System.Drawing.Point(18, 63)
        Me.uc_docnum.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_docnum.Name = "uc_docnum"
        Me.uc_docnum.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_docnum.Size = New System.Drawing.Size(193, 23)
        Me.uc_docnum.TabIndex = 1
        '
        'uc_LP_Docnum
        '
        Me.uc_LP_Docnum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.uc_LP_Docnum.BackColor = System.Drawing.Color.Transparent
        Me.uc_LP_Docnum.iAddition_SQL = Nothing
        Me.uc_LP_Docnum.iAdditional = Nothing
        Me.uc_LP_Docnum.idsc = Nothing
        Me.uc_LP_Docnum.iIsEnabled = True
        Me.uc_LP_Docnum.iIsForSearch = False
        Me.uc_LP_Docnum.iLabel = "Document #"
        Me.uc_LP_Docnum.iLabel_width = 100
        Me.uc_LP_Docnum.isLabelBoldx = False
        Me.uc_LP_Docnum.iSQL_Parameter_ID = 0
        Me.uc_LP_Docnum.iText = ""
        Me.uc_LP_Docnum.LinkedColumn = ""
        Me.uc_LP_Docnum.Location = New System.Drawing.Point(432, 530)
        Me.uc_LP_Docnum.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_LP_Docnum.Name = "uc_LP_Docnum"
        Me.uc_LP_Docnum.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_LP_Docnum.Size = New System.Drawing.Size(280, 22)
        Me.uc_LP_Docnum.TabIndex = 105
        Me.uc_LP_Docnum.Visible = False
        '
        'uc_fromWHse
        '
        Me.uc_fromWHse.BackColor = System.Drawing.Color.Transparent
        Me.uc_fromWHse.iAdditional = Nothing
        Me.uc_fromWHse.iArrow_Visible = True
        Me.uc_fromWHse.iCanFindLabel_SQLIDx = 0
        Me.uc_fromWHse.iCharacterLimit = 0
        Me.uc_fromWHse.idsc = Me.uc_fromWHse_lbl
        Me.uc_fromWHse.iForm = Me
        Me.uc_fromWHse.iIsDropDown = False
        Me.uc_fromWHse.iIsEnabled = False
        Me.uc_fromWHse.iIsForSearch = True
        Me.uc_fromWHse.iIsID = False
        Me.uc_fromWHse.iIsInnerShow = True
        Me.uc_fromWHse.iLabel = "From Whs"
        Me.uc_fromWHse.iLabel_width = 105
        Me.uc_fromWHse.isAllowEmptyx = False
        Me.uc_fromWHse.isForFind = False
        Me.uc_fromWHse.iSQL_Parameter_ID = 143
        Me.uc_fromWHse.iSQL_Parameter_ID_FIND = 0
        Me.uc_fromWHse.iText = ""
        Me.uc_fromWHse.iTextBox_ = Me.txt_frmWhs
        Me.uc_fromWHse.iTextBox_Sel_COL_ID = 0
        Me.uc_fromWHse.iTitle = ""
        Me.uc_fromWHse.LinkedColumn = ""
        Me.uc_fromWHse.Location = New System.Drawing.Point(18, 13)
        Me.uc_fromWHse.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_fromWHse.Name = "uc_fromWHse"
        Me.uc_fromWHse.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_fromWHse.Size = New System.Drawing.Size(193, 23)
        Me.uc_fromWHse.TabIndex = 0
        '
        'uc_fromWHse_lbl
        '
        Me.uc_fromWHse_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_fromWHse_lbl.iAddition_SQL = Nothing
        Me.uc_fromWHse_lbl.iAdditional = Nothing
        Me.uc_fromWHse_lbl.idsc = Nothing
        Me.uc_fromWHse_lbl.iIsEnabled = True
        Me.uc_fromWHse_lbl.iIsForSearch = False
        Me.uc_fromWHse_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_fromWHse_lbl.iLabel_width = 5
        Me.uc_fromWHse_lbl.isLabelBoldx = False
        Me.uc_fromWHse_lbl.iSQL_Parameter_ID = 0
        Me.uc_fromWHse_lbl.iText = ""
        Me.uc_fromWHse_lbl.LinkedColumn = ""
        Me.uc_fromWHse_lbl.Location = New System.Drawing.Point(214, 13)
        Me.uc_fromWHse_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_fromWHse_lbl.Name = "uc_fromWHse_lbl"
        Me.uc_fromWHse_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_fromWHse_lbl.Size = New System.Drawing.Size(207, 22)
        Me.uc_fromWHse_lbl.TabIndex = 85
        '
        'uc_palletingNum
        '
        Me.uc_palletingNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_palletingNum.BackColor = System.Drawing.Color.Transparent
        Me.uc_palletingNum.iAdditional = Nothing
        Me.uc_palletingNum.iArrow_Visible = False
        Me.uc_palletingNum.iCanFindLabel_SQLIDx = 0
        Me.uc_palletingNum.iCharacterLimit = 0
        Me.uc_palletingNum.idsc = Me.uc_palletingNum_lbl
        Me.uc_palletingNum.iForm = Me
        Me.uc_palletingNum.iIsDropDown = True
        Me.uc_palletingNum.iIsEnabled = False
        Me.uc_palletingNum.iIsForSearch = True
        Me.uc_palletingNum.iIsID = False
        Me.uc_palletingNum.iIsInnerShow = True
        Me.uc_palletingNum.iLabel = "Palleting #"
        Me.uc_palletingNum.iLabel_width = 90
        Me.uc_palletingNum.isAllowEmptyx = True
        Me.uc_palletingNum.isForFind = False
        Me.uc_palletingNum.iSQL_Parameter_ID = 157
        Me.uc_palletingNum.iSQL_Parameter_ID_FIND = 0
        Me.uc_palletingNum.iText = ""
        Me.uc_palletingNum.iTextBox_ = Me.txt_uc_palletingNum
        Me.uc_palletingNum.iTextBox_Sel_COL_ID = 0
        Me.uc_palletingNum.iTitle = ""
        Me.uc_palletingNum.LinkedColumn = ""
        Me.uc_palletingNum.Location = New System.Drawing.Point(640, 14)
        Me.uc_palletingNum.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_palletingNum.Name = "uc_palletingNum"
        Me.uc_palletingNum.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_palletingNum.Size = New System.Drawing.Size(305, 23)
        Me.uc_palletingNum.TabIndex = 76
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
        Me.Uc_label1.iLabel = "Last Pallet"
        Me.Uc_label1.iLabel_width = 500
        Me.Uc_label1.isLabelBoldx = True
        Me.Uc_label1.iSQL_Parameter_ID = 0
        Me.Uc_label1.iText = ""
        Me.Uc_label1.LinkedColumn = ""
        Me.Uc_label1.Location = New System.Drawing.Point(15, 482)
        Me.Uc_label1.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label1.Name = "Uc_label1"
        Me.Uc_label1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label1.Size = New System.Drawing.Size(98, 22)
        Me.Uc_label1.TabIndex = 104
        '
        'uc_null
        '
        Me.uc_null.BackColor = System.Drawing.Color.Transparent
        Me.uc_null.iAddition_SQL = Nothing
        Me.uc_null.iAdditional = Nothing
        Me.uc_null.idsc = Nothing
        Me.uc_null.iIsEnabled = True
        Me.uc_null.iIsForSearch = False
        Me.uc_null.iLabel = "Source"
        Me.uc_null.iLabel_width = 65
        Me.uc_null.isLabelBoldx = False
        Me.uc_null.iSQL_Parameter_ID = 0
        Me.uc_null.iText = "Reciept From Production"
        Me.uc_null.LinkedColumn = ""
        Me.uc_null.Location = New System.Drawing.Point(972, 66)
        Me.uc_null.Name = "uc_null"
        Me.uc_null.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_null.Size = New System.Drawing.Size(62, 21)
        Me.uc_null.TabIndex = 93
        Me.uc_null.Visible = False
        '
        'uc_recieved
        '
        Me.uc_recieved.BackColor = System.Drawing.Color.Transparent
        Me.uc_recieved.iAdditional = Nothing
        Me.uc_recieved.iArrow_Visible = False
        Me.uc_recieved.iCanFindLabel_SQLIDx = 0
        Me.uc_recieved.iCharacterLimit = 10
        Me.uc_recieved.idsc = Me.uc_recieved_lbl
        Me.uc_recieved.iForm = Me
        Me.uc_recieved.iIsDropDown = False
        Me.uc_recieved.iIsEnabled = True
        Me.uc_recieved.iIsForSearch = True
        Me.uc_recieved.iIsID = False
        Me.uc_recieved.iIsInnerShow = True
        Me.uc_recieved.iLabel = "Recieved by"
        Me.uc_recieved.iLabel_width = 105
        Me.uc_recieved.isAllowEmptyx = False
        Me.uc_recieved.isForFind = False
        Me.uc_recieved.iSQL_Parameter_ID = 4
        Me.uc_recieved.iSQL_Parameter_ID_FIND = 0
        Me.uc_recieved.iText = ""
        Me.uc_recieved.iTextBox_ = Me.docnum_container
        Me.uc_recieved.iTextBox_Sel_COL_ID = 0
        Me.uc_recieved.iTitle = ""
        Me.uc_recieved.LinkedColumn = ""
        Me.uc_recieved.Location = New System.Drawing.Point(20, 151)
        Me.uc_recieved.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_recieved.Name = "uc_recieved"
        Me.uc_recieved.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_recieved.Size = New System.Drawing.Size(254, 23)
        Me.uc_recieved.TabIndex = 3
        '
        'uc_recieved_lbl
        '
        Me.uc_recieved_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_recieved_lbl.iAddition_SQL = Nothing
        Me.uc_recieved_lbl.iAdditional = Nothing
        Me.uc_recieved_lbl.idsc = Nothing
        Me.uc_recieved_lbl.iIsEnabled = True
        Me.uc_recieved_lbl.iIsForSearch = False
        Me.uc_recieved_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_recieved_lbl.iLabel_width = 5
        Me.uc_recieved_lbl.isLabelBoldx = False
        Me.uc_recieved_lbl.iSQL_Parameter_ID = 0
        Me.uc_recieved_lbl.iText = ""
        Me.uc_recieved_lbl.LinkedColumn = ""
        Me.uc_recieved_lbl.Location = New System.Drawing.Point(544, 151)
        Me.uc_recieved_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_recieved_lbl.Name = "uc_recieved_lbl"
        Me.uc_recieved_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_recieved_lbl.Size = New System.Drawing.Size(25, 25)
        Me.uc_recieved_lbl.TabIndex = 96
        Me.uc_recieved_lbl.Visible = False
        '
        'uc_ToWHse
        '
        Me.uc_ToWHse.BackColor = System.Drawing.Color.Transparent
        Me.uc_ToWHse.iAdditional = Nothing
        Me.uc_ToWHse.iArrow_Visible = False
        Me.uc_ToWHse.iCanFindLabel_SQLIDx = 0
        Me.uc_ToWHse.iCharacterLimit = 0
        Me.uc_ToWHse.idsc = Me.uc_ToWHse_lbl
        Me.uc_ToWHse.iForm = Me
        Me.uc_ToWHse.iIsDropDown = False
        Me.uc_ToWHse.iIsEnabled = False
        Me.uc_ToWHse.iIsForSearch = True
        Me.uc_ToWHse.iIsID = False
        Me.uc_ToWHse.iIsInnerShow = True
        Me.uc_ToWHse.iLabel = "To Whs"
        Me.uc_ToWHse.iLabel_width = 105
        Me.uc_ToWHse.isAllowEmptyx = True
        Me.uc_ToWHse.isForFind = False
        Me.uc_ToWHse.iSQL_Parameter_ID = 2
        Me.uc_ToWHse.iSQL_Parameter_ID_FIND = 0
        Me.uc_ToWHse.iText = ""
        Me.uc_ToWHse.iTextBox_ = Me.docnum_container
        Me.uc_ToWHse.iTextBox_Sel_COL_ID = 0
        Me.uc_ToWHse.iTitle = ""
        Me.uc_ToWHse.LinkedColumn = ""
        Me.uc_ToWHse.Location = New System.Drawing.Point(18, 38)
        Me.uc_ToWHse.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_ToWHse.Name = "uc_ToWHse"
        Me.uc_ToWHse.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_ToWHse.Size = New System.Drawing.Size(193, 23)
        Me.uc_ToWHse.TabIndex = 82
        '
        'uc_ToWHse_lbl
        '
        Me.uc_ToWHse_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_ToWHse_lbl.iAddition_SQL = Nothing
        Me.uc_ToWHse_lbl.iAdditional = Nothing
        Me.uc_ToWHse_lbl.idsc = Nothing
        Me.uc_ToWHse_lbl.iIsEnabled = True
        Me.uc_ToWHse_lbl.iIsForSearch = False
        Me.uc_ToWHse_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_ToWHse_lbl.iLabel_width = 5
        Me.uc_ToWHse_lbl.isLabelBoldx = False
        Me.uc_ToWHse_lbl.iSQL_Parameter_ID = 0
        Me.uc_ToWHse_lbl.iText = ""
        Me.uc_ToWHse_lbl.LinkedColumn = ""
        Me.uc_ToWHse_lbl.Location = New System.Drawing.Point(214, 38)
        Me.uc_ToWHse_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_ToWHse_lbl.Name = "uc_ToWHse_lbl"
        Me.uc_ToWHse_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_ToWHse_lbl.Size = New System.Drawing.Size(207, 22)
        Me.uc_ToWHse_lbl.TabIndex = 85
        '
        'uc_release_lbl
        '
        Me.uc_release_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_release_lbl.iAddition_SQL = Nothing
        Me.uc_release_lbl.iAdditional = Nothing
        Me.uc_release_lbl.idsc = Nothing
        Me.uc_release_lbl.iIsEnabled = True
        Me.uc_release_lbl.iIsForSearch = False
        Me.uc_release_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_release_lbl.iLabel_width = 5
        Me.uc_release_lbl.isLabelBoldx = False
        Me.uc_release_lbl.iSQL_Parameter_ID = 0
        Me.uc_release_lbl.iText = ""
        Me.uc_release_lbl.LinkedColumn = ""
        Me.uc_release_lbl.Location = New System.Drawing.Point(544, 126)
        Me.uc_release_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_release_lbl.Name = "uc_release_lbl"
        Me.uc_release_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_release_lbl.Size = New System.Drawing.Size(25, 25)
        Me.uc_release_lbl.TabIndex = 97
        Me.uc_release_lbl.Visible = False
        '
        'uc_release
        '
        Me.uc_release.BackColor = System.Drawing.Color.Transparent
        Me.uc_release.iAdditional = Nothing
        Me.uc_release.iArrow_Visible = False
        Me.uc_release.iCanFindLabel_SQLIDx = 0
        Me.uc_release.iCharacterLimit = 10
        Me.uc_release.idsc = Me.uc_release_lbl
        Me.uc_release.iForm = Me
        Me.uc_release.iIsDropDown = False
        Me.uc_release.iIsEnabled = True
        Me.uc_release.iIsForSearch = True
        Me.uc_release.iIsID = False
        Me.uc_release.iIsInnerShow = True
        Me.uc_release.iLabel = "Released by"
        Me.uc_release.iLabel_width = 105
        Me.uc_release.isAllowEmptyx = False
        Me.uc_release.isForFind = False
        Me.uc_release.iSQL_Parameter_ID = 4
        Me.uc_release.iSQL_Parameter_ID_FIND = 0
        Me.uc_release.iText = ""
        Me.uc_release.iTextBox_ = Me.docnum_container
        Me.uc_release.iTextBox_Sel_COL_ID = 0
        Me.uc_release.iTitle = ""
        Me.uc_release.LinkedColumn = ""
        Me.uc_release.Location = New System.Drawing.Point(20, 126)
        Me.uc_release.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_release.Name = "uc_release"
        Me.uc_release.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_release.Size = New System.Drawing.Size(254, 23)
        Me.uc_release.TabIndex = 2
        '
        'uc_paletsizer_LBl
        '
        Me.uc_paletsizer_LBl.BackColor = System.Drawing.Color.Transparent
        Me.uc_paletsizer_LBl.iAddition_SQL = Nothing
        Me.uc_paletsizer_LBl.iAdditional = Nothing
        Me.uc_paletsizer_LBl.idsc = Nothing
        Me.uc_paletsizer_LBl.iIsEnabled = True
        Me.uc_paletsizer_LBl.iIsForSearch = False
        Me.uc_paletsizer_LBl.iLabel = "Edit iLbl to edit me"
        Me.uc_paletsizer_LBl.iLabel_width = 5
        Me.uc_paletsizer_LBl.isLabelBoldx = False
        Me.uc_paletsizer_LBl.iSQL_Parameter_ID = 0
        Me.uc_paletsizer_LBl.iText = ""
        Me.uc_paletsizer_LBl.LinkedColumn = ""
        Me.uc_paletsizer_LBl.Location = New System.Drawing.Point(569, 126)
        Me.uc_paletsizer_LBl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_paletsizer_LBl.Name = "uc_paletsizer_LBl"
        Me.uc_paletsizer_LBl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_paletsizer_LBl.Size = New System.Drawing.Size(25, 25)
        Me.uc_paletsizer_LBl.TabIndex = 95
        Me.uc_paletsizer_LBl.Visible = False
        '
        'uc_paletsizer
        '
        Me.uc_paletsizer.BackColor = System.Drawing.Color.Transparent
        Me.uc_paletsizer.iAdditional = Nothing
        Me.uc_paletsizer.iArrow_Visible = False
        Me.uc_paletsizer.iCanFindLabel_SQLIDx = 0
        Me.uc_paletsizer.iCharacterLimit = 10
        Me.uc_paletsizer.idsc = Me.uc_paletsizer_LBl
        Me.uc_paletsizer.iForm = Me
        Me.uc_paletsizer.iIsDropDown = False
        Me.uc_paletsizer.iIsEnabled = True
        Me.uc_paletsizer.iIsForSearch = True
        Me.uc_paletsizer.iIsID = False
        Me.uc_paletsizer.iIsInnerShow = True
        Me.uc_paletsizer.iLabel = "Palletizer"
        Me.uc_paletsizer.iLabel_width = 105
        Me.uc_paletsizer.isAllowEmptyx = False
        Me.uc_paletsizer.isForFind = False
        Me.uc_paletsizer.iSQL_Parameter_ID = 4
        Me.uc_paletsizer.iSQL_Parameter_ID_FIND = 0
        Me.uc_paletsizer.iText = ""
        Me.uc_paletsizer.iTextBox_ = Me.docnum_container
        Me.uc_paletsizer.iTextBox_Sel_COL_ID = 0
        Me.uc_paletsizer.iTitle = ""
        Me.uc_paletsizer.LinkedColumn = ""
        Me.uc_paletsizer.Location = New System.Drawing.Point(276, 125)
        Me.uc_paletsizer.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_paletsizer.Name = "uc_paletsizer"
        Me.uc_paletsizer.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_paletsizer.Size = New System.Drawing.Size(266, 23)
        Me.uc_paletsizer.TabIndex = 4
        '
        'uc_TaxDate
        '
        Me.uc_TaxDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_TaxDate.BackColor = System.Drawing.Color.Transparent
        Me.uc_TaxDate.iDate = New Date(2020, 8, 8, 9, 39, 7, 694)
        Me.uc_TaxDate.idsc = Nothing
        Me.uc_TaxDate.iForm = Me
        Me.uc_TaxDate.iIsForSearch = False
        Me.uc_TaxDate.iLabel = "Document Date"
        Me.uc_TaxDate.iLabel_width = 120
        Me.uc_TaxDate.IsEnabled = False
        Me.uc_TaxDate.isForFind = False
        Me.uc_TaxDate.iSQL_Parameter_ID = 0
        Me.uc_TaxDate.LinkedColumn = ""
        Me.uc_TaxDate.Location = New System.Drawing.Point(638, 65)
        Me.uc_TaxDate.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_TaxDate.Name = "uc_TaxDate"
        Me.uc_TaxDate.Size = New System.Drawing.Size(307, 24)
        Me.uc_TaxDate.TabIndex = 9
        '
        'uc_DocDate
        '
        Me.uc_DocDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_DocDate.BackColor = System.Drawing.Color.Transparent
        Me.uc_DocDate.iDate = New Date(2020, 8, 8, 9, 39, 7, 698)
        Me.uc_DocDate.idsc = Nothing
        Me.uc_DocDate.iForm = Me
        Me.uc_DocDate.iIsForSearch = False
        Me.uc_DocDate.iLabel = "Posting Date"
        Me.uc_DocDate.iLabel_width = 120
        Me.uc_DocDate.IsEnabled = False
        Me.uc_DocDate.isForFind = False
        Me.uc_DocDate.iSQL_Parameter_ID = 0
        Me.uc_DocDate.LinkedColumn = ""
        Me.uc_DocDate.Location = New System.Drawing.Point(638, 39)
        Me.uc_DocDate.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_DocDate.Name = "uc_DocDate"
        Me.uc_DocDate.Size = New System.Drawing.Size(307, 24)
        Me.uc_DocDate.TabIndex = 6
        '
        'Palleting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(958, 562)
        Me.ContextMenuStrip = Me.cms_copy
        Me.Controls.Add(Me.uc_LP_date)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.uc_palletingNum_lbl)
        Me.Controls.Add(Me.txt_uc_palletingNum)
        Me.Controls.Add(Me.uc_station_lbl)
        Me.Controls.Add(Me.uc_station)
        Me.Controls.Add(Me.uc_packer_lbl)
        Me.Controls.Add(Me.uc_packer)
        Me.Controls.Add(Me.txt_remarks)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Uc_inputbox3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.uc_LP_qty)
        Me.Controls.Add(Me.txt_null)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.uc_docnum_lbl)
        Me.Controls.Add(Me.uc_LP_pallet_num)
        Me.Controls.Add(Me.uc_docnum)
        Me.Controls.Add(Me.uc_LP_Docnum)
        Me.Controls.Add(Me.uc_fromWHse)
        Me.Controls.Add(Me.uc_palletingNum)
        Me.Controls.Add(Me.Uc_label1)
        Me.Controls.Add(Me.uc_null)
        Me.Controls.Add(Me.uc_recieved)
        Me.Controls.Add(Me.uc_ToWHse)
        Me.Controls.Add(Me.docnum_container)
        Me.Controls.Add(Me.uc_release_lbl)
        Me.Controls.Add(Me.uc_release)
        Me.Controls.Add(Me.uc_fromWHse_lbl)
        Me.Controls.Add(Me.docnum_container_desc)
        Me.Controls.Add(Me.uc_recieved_lbl)
        Me.Controls.Add(Me.txt_docNum)
        Me.Controls.Add(Me.uc_ToWHse_lbl)
        Me.Controls.Add(Me.txt_frmWhs)
        Me.Controls.Add(Me.uc_paletsizer_LBl)
        Me.Controls.Add(Me.uc_paletsizer)
        Me.Controls.Add(Me.uc_TaxDate)
        Me.Controls.Add(Me.uc_DocDate)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Palleting"
        Me.Text = "Palleting"
        Me.cms_copy.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_palleted, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_forPallet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents uc_paletsizer As uc_inputbox
    Friend WithEvents cms_copy As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents txt_remarks As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Uc_inputbox3 As uc_inputbox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgv_forPallet As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_palleted As DataGridView
    Friend WithEvents uc_LP_qty As uc_label
    Friend WithEvents txt_null As TextBox
    Friend WithEvents btn_ok As Button
    Friend WithEvents uc_docnum_lbl As uc_label
    Friend WithEvents uc_LP_pallet_num As uc_label
    Friend WithEvents uc_docnum As uc_inputbox
    Friend WithEvents txt_docNum As TextBox
    Friend WithEvents uc_LP_Docnum As uc_label
    Friend WithEvents uc_fromWHse As uc_inputbox
    Friend WithEvents txt_frmWhs As TextBox
    Friend WithEvents uc_palletingNum As uc_inputbox
    Friend WithEvents docnum_container As TextBox
    Friend WithEvents Uc_label1 As uc_label
    Friend WithEvents uc_null As uc_label
    Friend WithEvents uc_recieved As uc_inputbox
    Friend WithEvents uc_ToWHse As uc_inputbox
    Friend WithEvents uc_release_lbl As uc_label
    Friend WithEvents uc_release As uc_inputbox
    Friend WithEvents uc_fromWHse_lbl As uc_label
    Friend WithEvents docnum_container_desc As TextBox
    Friend WithEvents uc_recieved_lbl As uc_label
    Friend WithEvents uc_ToWHse_lbl As uc_label
    Friend WithEvents uc_paletsizer_LBl As uc_label
    Friend WithEvents uc_TaxDate As uc_date
    Friend WithEvents uc_DocDate As uc_date
    Friend WithEvents Timer1 As Timer
    Friend WithEvents uc_packer_lbl As uc_label
    Friend WithEvents uc_packer As uc_inputbox
    Friend WithEvents uc_station_lbl As uc_label
    Friend WithEvents uc_station As uc_inputbox
    Friend WithEvents uc_palletingNum_lbl As uc_label
    Friend WithEvents txt_uc_palletingNum As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents uc_LP_date As uc_date
End Class
