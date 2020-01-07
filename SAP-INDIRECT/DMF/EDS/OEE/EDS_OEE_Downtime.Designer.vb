<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EDS_OEE_Downtime
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
        Me.cmd_cell_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmd_edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmd_delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmd_help = New System.Windows.Forms.ToolStripMenuItem()
        Me.textNul = New System.Windows.Forms.TextBox()
        Me.dgv_planedUn = New System.Windows.Forms.DataGridView()
        Me.btn_trig = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.dgv_warehouseman = New System.Windows.Forms.DataGridView()
        Me.NUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OPNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_exit2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btn_timeCalc = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uc_finder_user = New IpicIndirect.uc_col_finder()
        Me.btn_exit3 = New System.Windows.Forms.Button()
        Me.uc_machine_lbl = New IpicIndirect.uc_label()
        Me.uc_col_warehouse = New IpicIndirect.uc_col_finder()
        Me.uc_shift_lbl = New IpicIndirect.uc_label()
        Me.uc_shift = New IpicIndirect.uc_inputbox()
        Me.Uc_time2 = New IpicIndirect.uc_time()
        Me.Uc_time1 = New IpicIndirect.uc_time()
        Me.uc_totalMins = New IpicIndirect.uc_inputbox()
        Me.uc_postedBy_lbl = New IpicIndirect.uc_label()
        Me.uc_status_lbl = New IpicIndirect.uc_label()
        Me.uc_whse_lbl = New IpicIndirect.uc_label()
        Me.uc_station_lbl = New IpicIndirect.uc_label()
        Me.uc_lblNull = New IpicIndirect.uc_label()
        Me.uc_status = New IpicIndirect.uc_inputbox()
        Me.uc_time = New IpicIndirect.uc_time()
        Me.uc_whse = New IpicIndirect.uc_inputbox()
        Me.uc_mainDateDone = New IpicIndirect.uc_date()
        Me.uc_postedBy = New IpicIndirect.uc_inputbox()
        Me.uc_station = New IpicIndirect.uc_inputbox()
        Me.uc_machine = New IpicIndirect.uc_inputbox()
        Me.uc_DocNum = New IpicIndirect.uc_inputbox()
        Me.uc_Col_find_UnplandDwn = New IpicIndirect.uc_col_finder()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_cell_menu.SuspendLayout()
        CType(Me.dgv_planedUn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_warehouseman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_cell_menu
        '
        Me.cmd_cell_menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmd_cell_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmd_edit, Me.cmd_delete, Me.ToolStripSeparator1, Me.cmd_help})
        Me.cmd_cell_menu.Name = "ContextMenuStrip1"
        Me.cmd_cell_menu.Size = New System.Drawing.Size(108, 76)
        '
        'cmd_edit
        '
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(107, 22)
        Me.cmd_edit.Text = "Edit"
        '
        'cmd_delete
        '
        Me.cmd_delete.Name = "cmd_delete"
        Me.cmd_delete.Size = New System.Drawing.Size(107, 22)
        Me.cmd_delete.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(104, 6)
        '
        'cmd_help
        '
        Me.cmd_help.Name = "cmd_help"
        Me.cmd_help.Size = New System.Drawing.Size(107, 22)
        Me.cmd_help.Text = "Help"
        '
        'textNul
        '
        Me.textNul.Location = New System.Drawing.Point(306, 12)
        Me.textNul.Name = "textNul"
        Me.textNul.Size = New System.Drawing.Size(84, 20)
        Me.textNul.TabIndex = 161
        Me.textNul.Visible = False
        '
        'dgv_planedUn
        '
        Me.dgv_planedUn.AllowUserToAddRows = False
        Me.dgv_planedUn.AllowUserToDeleteRows = False
        Me.dgv_planedUn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_planedUn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_planedUn.BackgroundColor = System.Drawing.Color.White
        Me.dgv_planedUn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_planedUn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_planedUn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_planedUn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_planedUn.EnableHeadersVisualStyles = False
        Me.dgv_planedUn.Location = New System.Drawing.Point(12, 166)
        Me.dgv_planedUn.Name = "dgv_planedUn"
        Me.dgv_planedUn.RowHeadersVisible = False
        Me.dgv_planedUn.RowTemplate.Height = 24
        Me.dgv_planedUn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_planedUn.Size = New System.Drawing.Size(1112, 398)
        Me.dgv_planedUn.TabIndex = 144
        '
        'btn_trig
        '
        Me.btn_trig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_trig.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_trig.FlatAppearance.BorderSize = 0
        Me.btn_trig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_trig.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_trig.ForeColor = System.Drawing.Color.White
        Me.btn_trig.Location = New System.Drawing.Point(13, 570)
        Me.btn_trig.Name = "btn_trig"
        Me.btn_trig.Size = New System.Drawing.Size(84, 23)
        Me.btn_trig.TabIndex = 146
        Me.btn_trig.Text = "&Save"
        Me.btn_trig.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_trig.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_trig.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(315, 61)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 165
        Me.btn_exit.Text = "Button1"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'dgv_warehouseman
        '
        Me.dgv_warehouseman.AllowUserToAddRows = False
        Me.dgv_warehouseman.AllowUserToDeleteRows = False
        Me.dgv_warehouseman.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_warehouseman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_warehouseman.BackgroundColor = System.Drawing.Color.White
        Me.dgv_warehouseman.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_warehouseman.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_warehouseman.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_warehouseman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_warehouseman.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUM, Me.ID, Me.OPNAME})
        Me.dgv_warehouseman.EnableHeadersVisualStyles = False
        Me.dgv_warehouseman.Location = New System.Drawing.Point(842, 21)
        Me.dgv_warehouseman.Name = "dgv_warehouseman"
        Me.dgv_warehouseman.RowHeadersVisible = False
        Me.dgv_warehouseman.RowTemplate.Height = 24
        Me.dgv_warehouseman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_warehouseman.Size = New System.Drawing.Size(282, 105)
        Me.dgv_warehouseman.TabIndex = 168
        '
        'NUM
        '
        Me.NUM.FillWeight = 38.54777!
        Me.NUM.HeaderText = "#"
        Me.NUM.Name = "NUM"
        '
        'ID
        '
        Me.ID.FillWeight = 51.02538!
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'OPNAME
        '
        Me.OPNAME.FillWeight = 290.1223!
        Me.OPNAME.HeaderText = "Operator Name"
        Me.OPNAME.Name = "OPNAME"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(842, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(282, 17)
        Me.Label2.TabIndex = 169
        Me.Label2.Text = "OPERATOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 173
        Me.Label3.Text = "5/17/2020 9:47:29 PM"
        '
        'btn_exit2
        '
        Me.btn_exit2.Location = New System.Drawing.Point(306, 116)
        Me.btn_exit2.Name = "btn_exit2"
        Me.btn_exit2.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit2.TabIndex = 176
        Me.btn_exit2.Text = "Button1"
        Me.btn_exit2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1112, 17)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "OPERATOR"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btn_timeCalc
        '
        Me.btn_timeCalc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_timeCalc.Location = New System.Drawing.Point(773, 104)
        Me.btn_timeCalc.Name = "btn_timeCalc"
        Me.btn_timeCalc.Size = New System.Drawing.Size(52, 22)
        Me.btn_timeCalc.TabIndex = 181
        Me.btn_timeCalc.Text = "Calc"
        Me.btn_timeCalc.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.ContextMenuStrip = Me.cmd_cell_menu
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
        Me.DataGridViewTextBoxColumn2.FillWeight = 51.02538!
        Me.DataGridViewTextBoxColumn2.HeaderText = "CODE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 223
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 290.1223!
        Me.DataGridViewTextBoxColumn3.HeaderText = "DESCRIPTION"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 222
        '
        'uc_finder_user
        '
        Me.uc_finder_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_finder_user.BackColor = System.Drawing.Color.Transparent
        Me.uc_finder_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.uc_finder_user.iBtnExit = Me.btn_exit3
        Me.uc_finder_user.iCellx = Nothing
        Me.uc_finder_user.iColumnNameSearch = ""
        Me.uc_finder_user.iDatasetx = Nothing
        Me.uc_finder_user.iDgvCell1x = Nothing
        Me.uc_finder_user.iDgvCell2x = Nothing
        Me.uc_finder_user.iDGVX = Me.dgv_planedUn
        Me.uc_finder_user.iRectanglex = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.uc_finder_user.iText = Nothing
        Me.uc_finder_user.Location = New System.Drawing.Point(734, 339)
        Me.uc_finder_user.Name = "uc_finder_user"
        Me.uc_finder_user.Size = New System.Drawing.Size(263, 126)
        Me.uc_finder_user.TabIndex = 183
        Me.uc_finder_user.Visible = False
        '
        'btn_exit3
        '
        Me.btn_exit3.Location = New System.Drawing.Point(448, 116)
        Me.btn_exit3.Name = "btn_exit3"
        Me.btn_exit3.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit3.TabIndex = 184
        Me.btn_exit3.Text = "Button1"
        Me.btn_exit3.UseVisualStyleBackColor = True
        '
        'uc_machine_lbl
        '
        Me.uc_machine_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_machine_lbl.iAddition_SQL = Nothing
        Me.uc_machine_lbl.iAdditional = Nothing
        Me.uc_machine_lbl.idsc = Nothing
        Me.uc_machine_lbl.iIsEnabled = True
        Me.uc_machine_lbl.iIsForSearch = False
        Me.uc_machine_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_machine_lbl.iLabel_width = 5
        Me.uc_machine_lbl.iSQL_Parameter_ID = 0
        Me.uc_machine_lbl.iText = ""
        Me.uc_machine_lbl.Location = New System.Drawing.Point(147, 81)
        Me.uc_machine_lbl.Name = "uc_machine_lbl"
        Me.uc_machine_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_machine_lbl.Size = New System.Drawing.Size(141, 20)
        Me.uc_machine_lbl.TabIndex = 182
        '
        'uc_col_warehouse
        '
        Me.uc_col_warehouse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_col_warehouse.BackColor = System.Drawing.Color.Transparent
        Me.uc_col_warehouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.uc_col_warehouse.iBtnExit = Me.btn_exit2
        Me.uc_col_warehouse.iCellx = Nothing
        Me.uc_col_warehouse.iColumnNameSearch = ""
        Me.uc_col_warehouse.iDatasetx = Nothing
        Me.uc_col_warehouse.iDgvCell1x = Nothing
        Me.uc_col_warehouse.iDgvCell2x = Nothing
        Me.uc_col_warehouse.iDGVX = Me.dgv_planedUn
        Me.uc_col_warehouse.iRectanglex = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.uc_col_warehouse.iText = Nothing
        Me.uc_col_warehouse.Location = New System.Drawing.Point(861, 80)
        Me.uc_col_warehouse.Name = "uc_col_warehouse"
        Me.uc_col_warehouse.Size = New System.Drawing.Size(263, 126)
        Me.uc_col_warehouse.TabIndex = 171
        Me.uc_col_warehouse.Visible = False
        '
        'uc_shift_lbl
        '
        Me.uc_shift_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_shift_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_shift_lbl.iAddition_SQL = Nothing
        Me.uc_shift_lbl.iAdditional = Nothing
        Me.uc_shift_lbl.idsc = Nothing
        Me.uc_shift_lbl.iIsEnabled = True
        Me.uc_shift_lbl.iIsForSearch = False
        Me.uc_shift_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_shift_lbl.iLabel_width = 5
        Me.uc_shift_lbl.iSQL_Parameter_ID = 0
        Me.uc_shift_lbl.iText = ""
        Me.uc_shift_lbl.Location = New System.Drawing.Point(663, 80)
        Me.uc_shift_lbl.Name = "uc_shift_lbl"
        Me.uc_shift_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_shift_lbl.Size = New System.Drawing.Size(167, 20)
        Me.uc_shift_lbl.TabIndex = 175
        '
        'uc_shift
        '
        Me.uc_shift.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_shift.BackColor = System.Drawing.Color.Transparent
        'Me.uc_shift.iAddition_SQL = Nothing
        Me.uc_shift.iAdditional = Nothing
        Me.uc_shift.iArrow_Visible = False
        Me.uc_shift.iCanFindLabel_SQLIDx = 0
        Me.uc_shift.iCharacterLimit = 0
        Me.uc_shift.idsc = Me.uc_shift_lbl
        Me.uc_shift.iForm = Me
        Me.uc_shift.iIsDropDown = False
        Me.uc_shift.iIsEnabled = False
        Me.uc_shift.iIsForSearch = True
        Me.uc_shift.iIsID = False
        Me.uc_shift.iIsInnerShow = True
        Me.uc_shift.iLabel = "Shift"
        Me.uc_shift.iLabel_width = 90
        Me.uc_shift.isForFind = False
        Me.uc_shift.iSQL_Parameter_ID = 48
        Me.uc_shift.iText = ""
        Me.uc_shift.iTextBox_ = Me.textNul
        Me.uc_shift.iTextBox_Sel_COL_ID = 0
        Me.uc_shift.iTitle = ""
        Me.uc_shift.Location = New System.Drawing.Point(529, 80)
        Me.uc_shift.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_shift.Name = "uc_shift"
        Me.uc_shift.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_shift.Size = New System.Drawing.Size(135, 21)
        Me.uc_shift.TabIndex = 174
        '
        'Uc_time2
        '
        Me.Uc_time2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_time2.BackColor = System.Drawing.Color.Transparent
        Me.Uc_time2.iDate = New Date(2020, 5, 17, 21, 47, 29, 231)
        Me.Uc_time2.idsc = Me.Label3
        Me.Uc_time2.iForm = Me
        Me.Uc_time2.iIsForSearch = False
        Me.Uc_time2.iLabel = "Production Order Selection"
        Me.Uc_time2.iLabel_width = 10
        Me.Uc_time2.IsEnabled = True
        Me.Uc_time2.isForFind = True
        Me.Uc_time2.iSQL_Parameter_ID = 0
        Me.Uc_time2.Location = New System.Drawing.Point(704, 106)
        Me.Uc_time2.Margin = New System.Windows.Forms.Padding(4)
        Me.Uc_time2.Name = "Uc_time2"
        Me.Uc_time2.Size = New System.Drawing.Size(75, 23)
        Me.Uc_time2.TabIndex = 172
        '
        'Uc_time1
        '
        Me.Uc_time1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_time1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_time1.iDate = New Date(2020, 5, 17, 21, 47, 29, 236)
        Me.Uc_time1.idsc = Me.Label3
        Me.Uc_time1.iForm = Me
        Me.Uc_time1.iIsForSearch = False
        Me.Uc_time1.iLabel = "Start / End Time"
        Me.Uc_time1.iLabel_width = 110
        Me.Uc_time1.IsEnabled = True
        Me.Uc_time1.isForFind = True
        Me.Uc_time1.iSQL_Parameter_ID = 0
        Me.Uc_time1.Location = New System.Drawing.Point(530, 106)
        Me.Uc_time1.Margin = New System.Windows.Forms.Padding(4)
        Me.Uc_time1.Name = "Uc_time1"
        Me.Uc_time1.Size = New System.Drawing.Size(178, 23)
        Me.Uc_time1.TabIndex = 172
        '
        'uc_totalMins
        '
        Me.uc_totalMins.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_totalMins.BackColor = System.Drawing.Color.Transparent
        'Me.uc_totalMins.iAddition_SQL = Nothing
        Me.uc_totalMins.iAdditional = Nothing
        Me.uc_totalMins.iArrow_Visible = False
        Me.uc_totalMins.iCanFindLabel_SQLIDx = 0
        Me.uc_totalMins.iCharacterLimit = 0
        Me.uc_totalMins.idsc = Nothing
        Me.uc_totalMins.iForm = Me
        Me.uc_totalMins.iIsDropDown = False
        Me.uc_totalMins.iIsEnabled = False
        Me.uc_totalMins.iIsForSearch = True
        Me.uc_totalMins.iIsID = False
        Me.uc_totalMins.iIsInnerShow = True
        Me.uc_totalMins.iLabel = "Total Downtime"
        Me.uc_totalMins.iLabel_width = 105
        Me.uc_totalMins.isForFind = False
        Me.uc_totalMins.iSQL_Parameter_ID = 0
        Me.uc_totalMins.iText = ""
        Me.uc_totalMins.iTextBox_ = Me.textNul
        Me.uc_totalMins.iTextBox_Sel_COL_ID = 0
        Me.uc_totalMins.iTitle = ""
        Me.uc_totalMins.Location = New System.Drawing.Point(852, 572)
        Me.uc_totalMins.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_totalMins.Name = "uc_totalMins"
        Me.uc_totalMins.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_totalMins.Size = New System.Drawing.Size(275, 21)
        Me.uc_totalMins.TabIndex = 166
        '
        'uc_postedBy_lbl
        '
        Me.uc_postedBy_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_postedBy_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_postedBy_lbl.iAddition_SQL = Nothing
        Me.uc_postedBy_lbl.iAdditional = Nothing
        Me.uc_postedBy_lbl.idsc = Nothing
        Me.uc_postedBy_lbl.iIsEnabled = True
        Me.uc_postedBy_lbl.iIsForSearch = False
        Me.uc_postedBy_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_postedBy_lbl.iLabel_width = 5
        Me.uc_postedBy_lbl.iSQL_Parameter_ID = 0
        Me.uc_postedBy_lbl.iText = ""
        Me.uc_postedBy_lbl.Location = New System.Drawing.Point(663, 54)
        Me.uc_postedBy_lbl.Name = "uc_postedBy_lbl"
        Me.uc_postedBy_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_postedBy_lbl.Size = New System.Drawing.Size(167, 20)
        Me.uc_postedBy_lbl.TabIndex = 163
        '
        'uc_status_lbl
        '
        Me.uc_status_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_status_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_status_lbl.iAddition_SQL = Nothing
        Me.uc_status_lbl.iAdditional = Nothing
        Me.uc_status_lbl.idsc = Nothing
        Me.uc_status_lbl.iIsEnabled = True
        Me.uc_status_lbl.iIsForSearch = False
        Me.uc_status_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_status_lbl.iLabel_width = 5
        Me.uc_status_lbl.iSQL_Parameter_ID = 0
        Me.uc_status_lbl.iText = ""
        Me.uc_status_lbl.Location = New System.Drawing.Point(663, 29)
        Me.uc_status_lbl.Name = "uc_status_lbl"
        Me.uc_status_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_status_lbl.Size = New System.Drawing.Size(167, 20)
        Me.uc_status_lbl.TabIndex = 163
        '
        'uc_whse_lbl
        '
        Me.uc_whse_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_whse_lbl.iAddition_SQL = Nothing
        Me.uc_whse_lbl.iAdditional = Nothing
        Me.uc_whse_lbl.idsc = Nothing
        Me.uc_whse_lbl.iIsEnabled = True
        Me.uc_whse_lbl.iIsForSearch = False
        Me.uc_whse_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_whse_lbl.iLabel_width = 5
        Me.uc_whse_lbl.iSQL_Parameter_ID = 0
        Me.uc_whse_lbl.iText = ""
        Me.uc_whse_lbl.Location = New System.Drawing.Point(147, 54)
        Me.uc_whse_lbl.Name = "uc_whse_lbl"
        Me.uc_whse_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_whse_lbl.Size = New System.Drawing.Size(141, 20)
        Me.uc_whse_lbl.TabIndex = 163
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
        Me.uc_station_lbl.iSQL_Parameter_ID = 0
        Me.uc_station_lbl.iText = ""
        Me.uc_station_lbl.Location = New System.Drawing.Point(147, 29)
        Me.uc_station_lbl.Name = "uc_station_lbl"
        Me.uc_station_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_station_lbl.Size = New System.Drawing.Size(141, 20)
        Me.uc_station_lbl.TabIndex = 163
        '
        'uc_lblNull
        '
        Me.uc_lblNull.BackColor = System.Drawing.Color.Transparent
        Me.uc_lblNull.iAddition_SQL = Nothing
        Me.uc_lblNull.iAdditional = Nothing
        Me.uc_lblNull.idsc = Nothing
        Me.uc_lblNull.iIsEnabled = True
        Me.uc_lblNull.iIsForSearch = False
        Me.uc_lblNull.iLabel = "Edit iLbl to edit me"
        Me.uc_lblNull.iLabel_width = 0
        Me.uc_lblNull.iSQL_Parameter_ID = 0
        Me.uc_lblNull.iText = ""
        Me.uc_lblNull.Location = New System.Drawing.Point(306, 35)
        Me.uc_lblNull.Name = "uc_lblNull"
        Me.uc_lblNull.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_lblNull.Size = New System.Drawing.Size(84, 20)
        Me.uc_lblNull.TabIndex = 162
        Me.uc_lblNull.Visible = False
        '
        'uc_status
        '
        Me.uc_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_status.BackColor = System.Drawing.Color.Transparent
        'Me.uc_status.iAddition_SQL = Nothing
        Me.uc_status.iAdditional = Nothing
        Me.uc_status.iArrow_Visible = False
        Me.uc_status.iCanFindLabel_SQLIDx = 0
        Me.uc_status.iCharacterLimit = 0
        Me.uc_status.idsc = Me.uc_status_lbl
        Me.uc_status.iForm = Me
        Me.uc_status.iIsDropDown = False
        Me.uc_status.iIsEnabled = False
        Me.uc_status.iIsForSearch = True
        Me.uc_status.iIsID = False
        Me.uc_status.iIsInnerShow = True
        Me.uc_status.iLabel = "Status"
        Me.uc_status.iLabel_width = 90
        Me.uc_status.isForFind = False
        Me.uc_status.iSQL_Parameter_ID = 41
        Me.uc_status.iText = ""
        Me.uc_status.iTextBox_ = Me.textNul
        Me.uc_status.iTextBox_Sel_COL_ID = 0
        Me.uc_status.iTitle = ""
        Me.uc_status.Location = New System.Drawing.Point(529, 29)
        Me.uc_status.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_status.Name = "uc_status"
        Me.uc_status.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_status.Size = New System.Drawing.Size(135, 21)
        Me.uc_status.TabIndex = 160
        '
        'uc_time
        '
        Me.uc_time.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_time.BackColor = System.Drawing.Color.Transparent
        Me.uc_time.iDate = New Date(2020, 5, 17, 21, 47, 29, 254)
        Me.uc_time.idsc = Nothing
        Me.uc_time.iForm = Me
        Me.uc_time.iIsForSearch = False
        Me.uc_time.iLabel = "Production Order Selection"
        Me.uc_time.iLabel_width = 10
        Me.uc_time.IsEnabled = True
        Me.uc_time.isForFind = True
        Me.uc_time.iSQL_Parameter_ID = 0
        Me.uc_time.Location = New System.Drawing.Point(734, 4)
        Me.uc_time.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_time.Name = "uc_time"
        Me.uc_time.Size = New System.Drawing.Size(101, 23)
        Me.uc_time.TabIndex = 158
        '
        'uc_whse
        '
        Me.uc_whse.BackColor = System.Drawing.Color.Transparent
        ''Me.uc_whse.iAddition_SQL = Nothing
        Me.uc_whse.iAdditional = Nothing
        Me.uc_whse.iArrow_Visible = False
        Me.uc_whse.iCanFindLabel_SQLIDx = 0
        Me.uc_whse.iCharacterLimit = 0
        Me.uc_whse.idsc = Me.uc_whse_lbl
        Me.uc_whse.iForm = Me
        Me.uc_whse.iIsDropDown = False
        Me.uc_whse.iIsEnabled = False
        Me.uc_whse.iIsForSearch = True
        Me.uc_whse.iIsID = False
        Me.uc_whse.iIsInnerShow = True
        Me.uc_whse.iLabel = "Warehouse"
        Me.uc_whse.iLabel_width = 85
        Me.uc_whse.isForFind = False
        Me.uc_whse.iSQL_Parameter_ID = 26
        Me.uc_whse.iText = ""
        Me.uc_whse.iTextBox_ = Me.textNul
        Me.uc_whse.iTextBox_Sel_COL_ID = 85
        Me.uc_whse.iTitle = ""
        Me.uc_whse.Location = New System.Drawing.Point(13, 54)
        Me.uc_whse.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_whse.Name = "uc_whse"
        Me.uc_whse.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_whse.Size = New System.Drawing.Size(135, 21)
        Me.uc_whse.TabIndex = 153
        '
        'uc_mainDateDone
        '
        Me.uc_mainDateDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_mainDateDone.BackColor = System.Drawing.Color.Transparent
        Me.uc_mainDateDone.iDate = New Date(2020, 5, 17, 21, 47, 29, 260)
        Me.uc_mainDateDone.idsc = Nothing
        Me.uc_mainDateDone.iForm = Me
        Me.uc_mainDateDone.iIsForSearch = False
        Me.uc_mainDateDone.iLabel = "Posting Date"
        Me.uc_mainDateDone.iLabel_width = 109
        Me.uc_mainDateDone.IsEnabled = False
        Me.uc_mainDateDone.isForFind = False
        Me.uc_mainDateDone.iSQL_Parameter_ID = 0
        Me.uc_mainDateDone.Location = New System.Drawing.Point(530, 4)
        Me.uc_mainDateDone.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_mainDateDone.Name = "uc_mainDateDone"
        Me.uc_mainDateDone.Size = New System.Drawing.Size(202, 23)
        Me.uc_mainDateDone.TabIndex = 157
        '
        'uc_postedBy
        '
        Me.uc_postedBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_postedBy.BackColor = System.Drawing.Color.Transparent
        'Me.uc_postedBy.iAddition_SQL = Nothing
        Me.uc_postedBy.iAdditional = Nothing
        Me.uc_postedBy.iArrow_Visible = False
        Me.uc_postedBy.iCanFindLabel_SQLIDx = 0
        Me.uc_postedBy.iCharacterLimit = 0
        Me.uc_postedBy.idsc = Me.uc_postedBy_lbl
        Me.uc_postedBy.iForm = Me
        Me.uc_postedBy.iIsDropDown = False
        Me.uc_postedBy.iIsEnabled = False
        Me.uc_postedBy.iIsForSearch = True
        Me.uc_postedBy.iIsID = False
        Me.uc_postedBy.iIsInnerShow = True
        Me.uc_postedBy.iLabel = "Posted By"
        Me.uc_postedBy.iLabel_width = 90
        Me.uc_postedBy.isForFind = False
        Me.uc_postedBy.iSQL_Parameter_ID = 0
        Me.uc_postedBy.iText = ""
        Me.uc_postedBy.iTextBox_ = Me.textNul
        Me.uc_postedBy.iTextBox_Sel_COL_ID = 0
        Me.uc_postedBy.iTitle = ""
        Me.uc_postedBy.Location = New System.Drawing.Point(529, 54)
        Me.uc_postedBy.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_postedBy.Name = "uc_postedBy"
        Me.uc_postedBy.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_postedBy.Size = New System.Drawing.Size(135, 21)
        Me.uc_postedBy.TabIndex = 156
        '
        'uc_station
        '
        Me.uc_station.BackColor = System.Drawing.Color.Transparent
        ''Me.uc_station.iAddition_SQL = Nothing
        Me.uc_station.iAdditional = Nothing
        Me.uc_station.iArrow_Visible = False
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
        Me.uc_station.iLabel_width = 85
        Me.uc_station.isForFind = False
        Me.uc_station.iSQL_Parameter_ID = 32
        Me.uc_station.iText = ""
        Me.uc_station.iTextBox_ = Me.textNul
        Me.uc_station.iTextBox_Sel_COL_ID = 0
        Me.uc_station.iTitle = ""
        Me.uc_station.Location = New System.Drawing.Point(13, 29)
        Me.uc_station.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_station.Name = "uc_station"
        Me.uc_station.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_station.Size = New System.Drawing.Size(135, 21)
        Me.uc_station.TabIndex = 152
        '
        'uc_machine
        '
        Me.uc_machine.BackColor = System.Drawing.Color.Transparent
        'Me.uc_machine.iAddition_SQL = Nothing
        Me.uc_machine.iAdditional = Nothing
        Me.uc_machine.iArrow_Visible = False
        Me.uc_machine.iCanFindLabel_SQLIDx = 0
        Me.uc_machine.iCharacterLimit = 0
        Me.uc_machine.idsc = Me.uc_machine_lbl
        Me.uc_machine.iForm = Me
        Me.uc_machine.iIsDropDown = False
        Me.uc_machine.iIsEnabled = False
        Me.uc_machine.iIsForSearch = True
        Me.uc_machine.iIsID = False
        Me.uc_machine.iIsInnerShow = True
        Me.uc_machine.iLabel = "Machine"
        Me.uc_machine.iLabel_width = 85
        Me.uc_machine.isForFind = False
        Me.uc_machine.iSQL_Parameter_ID = 29
        Me.uc_machine.iText = ""
        Me.uc_machine.iTextBox_ = Me.textNul
        Me.uc_machine.iTextBox_Sel_COL_ID = 0
        Me.uc_machine.iTitle = ""
        Me.uc_machine.Location = New System.Drawing.Point(13, 80)
        Me.uc_machine.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_machine.Name = "uc_machine"
        Me.uc_machine.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_machine.Size = New System.Drawing.Size(135, 21)
        Me.uc_machine.TabIndex = 154
        '
        'uc_DocNum
        '
        Me.uc_DocNum.BackColor = System.Drawing.Color.Transparent
        'Me.uc_DocNum.iAddition_SQL = Nothing
        Me.uc_DocNum.iAdditional = Nothing
        Me.uc_DocNum.iArrow_Visible = False
        Me.uc_DocNum.iCanFindLabel_SQLIDx = 0
        Me.uc_DocNum.iCharacterLimit = 0
        Me.uc_DocNum.idsc = Me.uc_lblNull
        Me.uc_DocNum.iForm = Me
        Me.uc_DocNum.iIsDropDown = False
        Me.uc_DocNum.iIsEnabled = True
        Me.uc_DocNum.iIsForSearch = True
        Me.uc_DocNum.iIsID = False
        Me.uc_DocNum.iIsInnerShow = False
        Me.uc_DocNum.iLabel = "Doc Num"
        Me.uc_DocNum.iLabel_width = 85
        Me.uc_DocNum.isForFind = False
        Me.uc_DocNum.iSQL_Parameter_ID = 45
        Me.uc_DocNum.iText = ""
        Me.uc_DocNum.iTextBox_ = Me.textNul
        Me.uc_DocNum.iTextBox_Sel_COL_ID = 0
        Me.uc_DocNum.iTitle = ""
        Me.uc_DocNum.Location = New System.Drawing.Point(12, 4)
        Me.uc_DocNum.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_DocNum.Name = "uc_DocNum"
        Me.uc_DocNum.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_DocNum.Size = New System.Drawing.Size(276, 21)
        Me.uc_DocNum.TabIndex = 148
        '
        'uc_Col_find_UnplandDwn
        '
        Me.uc_Col_find_UnplandDwn.BackColor = System.Drawing.Color.Transparent
        Me.uc_Col_find_UnplandDwn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.uc_Col_find_UnplandDwn.iBtnExit = Me.btn_exit
        Me.uc_Col_find_UnplandDwn.iCellx = Nothing
        Me.uc_Col_find_UnplandDwn.iColumnNameSearch = ""
        Me.uc_Col_find_UnplandDwn.iDatasetx = Nothing
        Me.uc_Col_find_UnplandDwn.iDgvCell1x = Nothing
        Me.uc_Col_find_UnplandDwn.iDgvCell2x = Nothing
        Me.uc_Col_find_UnplandDwn.iDGVX = Me.dgv_planedUn
        Me.uc_Col_find_UnplandDwn.iRectanglex = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.uc_Col_find_UnplandDwn.iText = Nothing
        Me.uc_Col_find_UnplandDwn.Location = New System.Drawing.Point(39, 180)
        Me.uc_Col_find_UnplandDwn.Name = "uc_Col_find_UnplandDwn"
        Me.uc_Col_find_UnplandDwn.Size = New System.Drawing.Size(490, 147)
        Me.uc_Col_find_UnplandDwn.TabIndex = 147
        Me.uc_Col_find_UnplandDwn.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "CATEGORY"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 223
        '
        'EDS_OEE_Downtime
        '
        Me.AcceptButton = Me.btn_trig
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 600)
        Me.Controls.Add(Me.uc_finder_user)
        Me.Controls.Add(Me.btn_exit3)
        Me.Controls.Add(Me.uc_machine_lbl)
        Me.Controls.Add(Me.btn_timeCalc)
        Me.Controls.Add(Me.uc_col_warehouse)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_exit2)
        Me.Controls.Add(Me.uc_shift_lbl)
        Me.Controls.Add(Me.uc_shift)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Uc_time2)
        Me.Controls.Add(Me.Uc_time1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_warehouseman)
        Me.Controls.Add(Me.uc_totalMins)
        Me.Controls.Add(Me.uc_postedBy_lbl)
        Me.Controls.Add(Me.uc_status_lbl)
        Me.Controls.Add(Me.uc_whse_lbl)
        Me.Controls.Add(Me.uc_station_lbl)
        Me.Controls.Add(Me.uc_lblNull)
        Me.Controls.Add(Me.textNul)
        Me.Controls.Add(Me.uc_status)
        Me.Controls.Add(Me.uc_time)
        Me.Controls.Add(Me.uc_whse)
        Me.Controls.Add(Me.uc_mainDateDone)
        Me.Controls.Add(Me.uc_postedBy)
        Me.Controls.Add(Me.uc_station)
        Me.Controls.Add(Me.uc_machine)
        Me.Controls.Add(Me.uc_DocNum)
        Me.Controls.Add(Me.uc_Col_find_UnplandDwn)
        Me.Controls.Add(Me.btn_trig)
        Me.Controls.Add(Me.dgv_planedUn)
        Me.Controls.Add(Me.btn_exit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EDS_OEE_Downtime"
        Me.cmd_cell_menu.ResumeLayout(False)
        CType(Me.dgv_planedUn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_warehouseman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_cell_menu As ContextMenuStrip
    Friend WithEvents cmd_edit As ToolStripMenuItem
    Friend WithEvents cmd_delete As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmd_help As ToolStripMenuItem
    Friend WithEvents uc_status As uc_inputbox
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents uc_time As uc_time
    Friend WithEvents uc_whse As uc_inputbox
    Friend WithEvents uc_mainDateDone As uc_date
    Friend WithEvents uc_postedBy As uc_inputbox
    Friend WithEvents uc_station As uc_inputbox
    Friend WithEvents uc_machine As uc_inputbox
    Friend WithEvents uc_DocNum As uc_inputbox
    Friend WithEvents uc_Col_find_UnplandDwn As uc_col_finder
    Friend WithEvents btn_trig As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents dgv_planedUn As DataGridView
    Friend WithEvents uc_lblNull As uc_label
    Friend WithEvents textNul As TextBox
    Friend WithEvents uc_postedBy_lbl As uc_label
    Friend WithEvents uc_status_lbl As uc_label
    Friend WithEvents uc_whse_lbl As uc_label
    Friend WithEvents uc_station_lbl As uc_label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_exit As Button
    Friend WithEvents uc_totalMins As uc_inputbox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv_warehouseman As DataGridView
    Friend WithEvents uc_col_warehouse As uc_col_finder
    Friend WithEvents Uc_time2 As uc_time
    Friend WithEvents Uc_time1 As uc_time
    Friend WithEvents Label3 As Label
    Friend WithEvents uc_shift_lbl As uc_label
    Friend WithEvents uc_shift As uc_inputbox
    Friend WithEvents btn_exit2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NUM As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents OPNAME As DataGridViewTextBoxColumn
    Friend WithEvents btn_timeCalc As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents uc_machine_lbl As uc_label
    Friend WithEvents uc_finder_user As uc_col_finder
    Friend WithEvents btn_exit3 As Button
End Class
