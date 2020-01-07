<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Proration
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.txt_null = New System.Windows.Forms.TextBox()
        Me.dgv_CheckSelection = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MainTab = New MetroFramework.Controls.MetroTabControl()
        Me.tab1 = New MetroFramework.Controls.MetroTabPage()
        Me.dgv_Variant = New System.Windows.Forms.DataGridView()
        Me.returnTextbox = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.panel_sgf = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgv_sfg = New System.Windows.Forms.DataGridView()
        Me.tab2 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgv_FG = New System.Windows.Forms.DataGridView()
        Me.tab3 = New System.Windows.Forms.TabPage()
        Me.crvwr = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.dgv_Proration = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_find_PO = New System.Windows.Forms.Button()
        Me.txt_prorationType = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.uc_baseRef = New IpicIndirect.uc_inputbox()
        Me.uc_dsc_null = New IpicIndirect.uc_label()
        Me.Uc_PostingDate = New IpicIndirect.uc_date()
        Me.uc_CreatedDate = New IpicIndirect.uc_date()
        Me.uc_SFG_lbl = New IpicIndirect.uc_label()
        Me.uc_createdBy = New IpicIndirect.uc_inputbox()
        Me.uc_SFG = New IpicIndirect.uc_inputbox()
        Me.Uc_label1 = New IpicIndirect.uc_label()
        Me.uc_prorationLbl = New IpicIndirect.uc_label()
        Me.uc_warehouse = New IpicIndirect.uc_inputbox()
        Me.UC_warehouselabel = New IpicIndirect.uc_label()
        Me.Uc_label2 = New IpicIndirect.uc_label()
        Me.returnLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.uc_prorationType = New IpicIndirect.uc_inputbox()
        Me.uc_prorationNum = New IpicIndirect.uc_inputbox()
        Me.cmd_Variant = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cms_Variant_ViewBatch = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cms_copy = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgv_CheckSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainTab.SuspendLayout()
        Me.tab1.SuspendLayout()
        CType(Me.dgv_Variant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.panel_sgf.SuspendLayout()
        CType(Me.dgv_sfg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab2.SuspendLayout()
        CType(Me.dgv_FG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab3.SuspendLayout()
        CType(Me.dgv_Proration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.cmd_Variant.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.cms_copy.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_ok
        '
        Me.btn_ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(1192, 760)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(92, 21)
        Me.btn_ok.TabIndex = 83
        Me.btn_ok.Text = "OK"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'txt_remarks
        '
        Me.txt_remarks.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_remarks.Location = New System.Drawing.Point(786, 84)
        Me.txt_remarks.Multiline = True
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(321, 46)
        Me.txt_remarks.TabIndex = 92
        '
        'txt_null
        '
        Me.txt_null.Location = New System.Drawing.Point(513, 36)
        Me.txt_null.Name = "txt_null"
        Me.txt_null.Size = New System.Drawing.Size(211, 20)
        Me.txt_null.TabIndex = 118
        Me.txt_null.Visible = False
        '
        'dgv_CheckSelection
        '
        Me.dgv_CheckSelection.AllowUserToAddRows = False
        Me.dgv_CheckSelection.AllowUserToDeleteRows = False
        Me.dgv_CheckSelection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_CheckSelection.BackgroundColor = System.Drawing.Color.White
        Me.dgv_CheckSelection.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_CheckSelection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_CheckSelection.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_CheckSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_CheckSelection.EnableHeadersVisualStyles = False
        Me.dgv_CheckSelection.Location = New System.Drawing.Point(5, 53)
        Me.dgv_CheckSelection.Name = "dgv_CheckSelection"
        Me.dgv_CheckSelection.ReadOnly = True
        Me.dgv_CheckSelection.RowHeadersVisible = False
        Me.dgv_CheckSelection.RowTemplate.Height = 24
        Me.dgv_CheckSelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_CheckSelection.Size = New System.Drawing.Size(166, 675)
        Me.dgv_CheckSelection.TabIndex = 95
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(-101, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 17)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "To"
        Me.Label11.Visible = False
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(171, 20)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "Production Order Selection"
        '
        'MainTab
        '
        Me.MainTab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainTab.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.MainTab.Controls.Add(Me.tab1)
        Me.MainTab.Controls.Add(Me.TabPage1)
        Me.MainTab.Controls.Add(Me.tab2)
        Me.MainTab.Controls.Add(Me.tab3)
        Me.MainTab.ItemSize = New System.Drawing.Size(54, 20)
        Me.MainTab.Location = New System.Drawing.Point(0, 158)
        Me.MainTab.Name = "MainTab"
        Me.MainTab.SelectedIndex = 3
        Me.MainTab.Size = New System.Drawing.Size(1117, 565)
        Me.MainTab.Style = MetroFramework.MetroColorStyle.Silver
        Me.MainTab.TabIndex = 101
        Me.MainTab.UseSelectable = True
        '
        'tab1
        '
        Me.tab1.Controls.Add(Me.dgv_Variant)
        Me.tab1.Controls.Add(Me.returnTextbox)
        Me.tab1.HorizontalScrollbarBarColor = True
        Me.tab1.HorizontalScrollbarHighlightOnWheel = False
        Me.tab1.HorizontalScrollbarSize = 10
        Me.tab1.Location = New System.Drawing.Point(4, 24)
        Me.tab1.Name = "tab1"
        Me.tab1.Size = New System.Drawing.Size(1109, 537)
        Me.tab1.TabIndex = 0
        Me.tab1.Text = "Variant"
        Me.tab1.VerticalScrollbarBarColor = True
        Me.tab1.VerticalScrollbarHighlightOnWheel = False
        Me.tab1.VerticalScrollbarSize = 10
        Me.tab1.Visible = False
        '
        'dgv_Variant
        '
        Me.dgv_Variant.AllowUserToAddRows = False
        Me.dgv_Variant.AllowUserToDeleteRows = False
        Me.dgv_Variant.AllowUserToResizeColumns = False
        Me.dgv_Variant.AllowUserToResizeRows = False
        Me.dgv_Variant.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Variant.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Variant.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Variant.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Variant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_Variant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Variant.EnableHeadersVisualStyles = False
        Me.dgv_Variant.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Variant.Name = "dgv_Variant"
        Me.dgv_Variant.RowHeadersVisible = False
        Me.dgv_Variant.RowTemplate.Height = 24
        Me.dgv_Variant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_Variant.Size = New System.Drawing.Size(1109, 537)
        Me.dgv_Variant.TabIndex = 100
        '
        'returnTextbox
        '
        Me.returnTextbox.Location = New System.Drawing.Point(-50, -50)
        Me.returnTextbox.Name = "returnTextbox"
        Me.returnTextbox.Size = New System.Drawing.Size(100, 20)
        Me.returnTextbox.TabIndex = 98
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.panel_sgf)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1109, 537)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Material Usage(SFG)"
        '
        'panel_sgf
        '
        Me.panel_sgf.Controls.Add(Me.Panel5)
        Me.panel_sgf.Controls.Add(Me.dgv_sfg)
        Me.panel_sgf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_sgf.Location = New System.Drawing.Point(0, 0)
        Me.panel_sgf.Name = "panel_sgf"
        Me.panel_sgf.Size = New System.Drawing.Size(1109, 537)
        Me.panel_sgf.TabIndex = 100
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(0, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1109, 516)
        Me.Panel5.TabIndex = 122
        '
        'dgv_sfg
        '
        Me.dgv_sfg.AllowUserToAddRows = False
        Me.dgv_sfg.AllowUserToDeleteRows = False
        Me.dgv_sfg.AllowUserToResizeColumns = False
        Me.dgv_sfg.AllowUserToResizeRows = False
        Me.dgv_sfg.BackgroundColor = System.Drawing.Color.White
        Me.dgv_sfg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_sfg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_sfg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_sfg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_sfg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_sfg.EnableHeadersVisualStyles = False
        Me.dgv_sfg.Location = New System.Drawing.Point(0, 0)
        Me.dgv_sfg.Name = "dgv_sfg"
        Me.dgv_sfg.RowHeadersVisible = False
        Me.dgv_sfg.RowTemplate.Height = 24
        Me.dgv_sfg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_sfg.Size = New System.Drawing.Size(1109, 537)
        Me.dgv_sfg.TabIndex = 99
        '
        'tab2
        '
        Me.tab2.Controls.Add(Me.Panel4)
        Me.tab2.Controls.Add(Me.dgv_FG)
        Me.tab2.Location = New System.Drawing.Point(4, 24)
        Me.tab2.Name = "tab2"
        Me.tab2.Size = New System.Drawing.Size(1109, 537)
        Me.tab2.TabIndex = 1
        Me.tab2.Text = "Material Usage(FG)"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1109, 537)
        Me.Panel4.TabIndex = 121
        '
        'dgv_FG
        '
        Me.dgv_FG.AllowUserToAddRows = False
        Me.dgv_FG.AllowUserToDeleteRows = False
        Me.dgv_FG.AllowUserToOrderColumns = True
        Me.dgv_FG.BackgroundColor = System.Drawing.Color.White
        Me.dgv_FG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_FG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_FG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_FG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_FG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_FG.EnableHeadersVisualStyles = False
        Me.dgv_FG.Location = New System.Drawing.Point(0, 0)
        Me.dgv_FG.Name = "dgv_FG"
        Me.dgv_FG.RowHeadersVisible = False
        Me.dgv_FG.RowTemplate.Height = 24
        Me.dgv_FG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_FG.Size = New System.Drawing.Size(1109, 537)
        Me.dgv_FG.TabIndex = 98
        '
        'tab3
        '
        Me.tab3.Controls.Add(Me.crvwr)
        Me.tab3.Controls.Add(Me.dgv_Proration)
        Me.tab3.Location = New System.Drawing.Point(4, 24)
        Me.tab3.Name = "tab3"
        Me.tab3.Size = New System.Drawing.Size(1109, 537)
        Me.tab3.TabIndex = 2
        Me.tab3.Text = "Proration"
        '
        'crvwr
        '
        Me.crvwr.ActiveViewIndex = -1
        Me.crvwr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvwr.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvwr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvwr.Location = New System.Drawing.Point(0, 0)
        Me.crvwr.Name = "crvwr"
        Me.crvwr.ShowCloseButton = False
        Me.crvwr.ShowCopyButton = False
        Me.crvwr.ShowGotoPageButton = False
        Me.crvwr.ShowGroupTreeButton = False
        Me.crvwr.ShowLogo = False
        Me.crvwr.ShowPageNavigateButtons = False
        Me.crvwr.ShowParameterPanelButton = False
        Me.crvwr.ShowRefreshButton = False
        Me.crvwr.ShowTextSearchButton = False
        Me.crvwr.Size = New System.Drawing.Size(1109, 537)
        Me.crvwr.TabIndex = 115
        Me.crvwr.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'dgv_Proration
        '
        Me.dgv_Proration.AllowUserToAddRows = False
        Me.dgv_Proration.AllowUserToDeleteRows = False
        Me.dgv_Proration.AllowUserToOrderColumns = True
        Me.dgv_Proration.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Proration.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Proration.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Proration.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Proration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_Proration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Proration.EnableHeadersVisualStyles = False
        Me.dgv_Proration.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Proration.Name = "dgv_Proration"
        Me.dgv_Proration.RowHeadersVisible = False
        Me.dgv_Proration.RowTemplate.Height = 24
        Me.dgv_Proration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_Proration.Size = New System.Drawing.Size(1109, 537)
        Me.dgv_Proration.TabIndex = 100
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.btn_find_PO)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.dgv_CheckSelection)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(162, 733)
        Me.Panel2.TabIndex = 113
        '
        'btn_find_PO
        '
        Me.btn_find_PO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_find_PO.FlatAppearance.BorderSize = 0
        Me.btn_find_PO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_find_PO.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_find_PO.ForeColor = System.Drawing.Color.White
        Me.btn_find_PO.Location = New System.Drawing.Point(297, 706)
        Me.btn_find_PO.Name = "btn_find_PO"
        Me.btn_find_PO.Size = New System.Drawing.Size(108, 20)
        Me.btn_find_PO.TabIndex = 112
        Me.btn_find_PO.Text = "Find"
        Me.btn_find_PO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_find_PO.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_find_PO.UseVisualStyleBackColor = False
        Me.btn_find_PO.Visible = False
        '
        'txt_prorationType
        '
        Me.txt_prorationType.Location = New System.Drawing.Point(453, 84)
        Me.txt_prorationType.Name = "txt_prorationType"
        Me.txt_prorationType.Size = New System.Drawing.Size(211, 20)
        Me.txt_prorationType.TabIndex = 119
        Me.txt_prorationType.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.uc_baseRef)
        Me.Panel3.Controls.Add(Me.Uc_PostingDate)
        Me.Panel3.Controls.Add(Me.uc_CreatedDate)
        Me.Panel3.Controls.Add(Me.uc_SFG_lbl)
        Me.Panel3.Controls.Add(Me.uc_createdBy)
        Me.Panel3.Controls.Add(Me.txt_prorationType)
        Me.Panel3.Controls.Add(Me.txt_null)
        Me.Panel3.Controls.Add(Me.uc_dsc_null)
        Me.Panel3.Controls.Add(Me.uc_SFG)
        Me.Panel3.Controls.Add(Me.txt_remarks)
        Me.Panel3.Controls.Add(Me.Uc_label1)
        Me.Panel3.Controls.Add(Me.uc_prorationLbl)
        Me.Panel3.Controls.Add(Me.uc_warehouse)
        Me.Panel3.Controls.Add(Me.Uc_label2)
        Me.Panel3.Controls.Add(Me.UC_warehouselabel)
        Me.Panel3.Controls.Add(Me.returnLabel)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.uc_prorationType)
        Me.Panel3.Controls.Add(Me.uc_prorationNum)
        Me.Panel3.Controls.Add(Me.MainTab)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1121, 733)
        Me.Panel3.TabIndex = 114
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(509, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 22)
        Me.Button1.TabIndex = 122
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'uc_baseRef
        '
        Me.uc_baseRef.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.uc_baseRef.BackColor = System.Drawing.Color.Transparent
        Me.uc_baseRef.iAdditional = Nothing
        Me.uc_baseRef.iArrow_Visible = False
        Me.uc_baseRef.iCanFindLabel_SQLIDx = 0
        Me.uc_baseRef.iCharacterLimit = 0
        Me.uc_baseRef.idsc = Me.uc_dsc_null
        Me.uc_baseRef.iForm = Me
        Me.uc_baseRef.iIsDropDown = False
        Me.uc_baseRef.iIsEnabled = False
        Me.uc_baseRef.iIsForSearch = False
        Me.uc_baseRef.iIsID = False
        Me.uc_baseRef.iIsInnerShow = True
        Me.uc_baseRef.iLabel = "Document #"
        Me.uc_baseRef.iLabel_width = 110
        Me.uc_baseRef.isAllowEmptyx = True
        Me.uc_baseRef.isForFind = True
        Me.uc_baseRef.iSQL_Parameter_ID = 112
        Me.uc_baseRef.iText = ""
        Me.uc_baseRef.iTextBox_ = Me.txt_null
        Me.uc_baseRef.iTextBox_Sel_COL_ID = 0
        Me.uc_baseRef.iTitle = ""
        Me.uc_baseRef.Location = New System.Drawing.Point(5, 32)
        Me.uc_baseRef.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_baseRef.Name = "uc_baseRef"
        Me.uc_baseRef.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_baseRef.Size = New System.Drawing.Size(231, 20)
        Me.uc_baseRef.TabIndex = 121
        '
        'uc_dsc_null
        '
        Me.uc_dsc_null.BackColor = System.Drawing.Color.Transparent
        Me.uc_dsc_null.iAddition_SQL = Nothing
        Me.uc_dsc_null.iAdditional = Nothing
        Me.uc_dsc_null.idsc = Nothing
        Me.uc_dsc_null.iIsEnabled = False
        Me.uc_dsc_null.iIsForSearch = False
        Me.uc_dsc_null.iLabel = "    Proration Name"
        Me.uc_dsc_null.iLabel_width = 5
        Me.uc_dsc_null.isLabelBoldx = False
        Me.uc_dsc_null.iSQL_Parameter_ID = 0
        Me.uc_dsc_null.iText = ""
        Me.uc_dsc_null.Location = New System.Drawing.Point(364, 10)
        Me.uc_dsc_null.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_dsc_null.Name = "uc_dsc_null"
        Me.uc_dsc_null.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.uc_dsc_null.Size = New System.Drawing.Size(211, 20)
        Me.uc_dsc_null.TabIndex = 117
        Me.uc_dsc_null.Visible = False
        '
        'Uc_PostingDate
        '
        Me.Uc_PostingDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_PostingDate.BackColor = System.Drawing.Color.Transparent
        Me.Uc_PostingDate.iDate = New Date(2020, 6, 21, 4, 22, 39, 387)
        Me.Uc_PostingDate.idsc = Nothing
        Me.Uc_PostingDate.iForm = Nothing
        Me.Uc_PostingDate.iIsForSearch = False
        Me.Uc_PostingDate.iLabel = "Posting Date"
        Me.Uc_PostingDate.iLabel_width = 110
        Me.Uc_PostingDate.IsEnabled = True
        Me.Uc_PostingDate.isForFind = True
        Me.Uc_PostingDate.iSQL_Parameter_ID = 0
        Me.Uc_PostingDate.Location = New System.Drawing.Point(867, 6)
        Me.Uc_PostingDate.Margin = New System.Windows.Forms.Padding(4)
        Me.Uc_PostingDate.Name = "Uc_PostingDate"
        Me.Uc_PostingDate.Size = New System.Drawing.Size(240, 24)
        Me.Uc_PostingDate.TabIndex = 106
        '
        'uc_CreatedDate
        '
        Me.uc_CreatedDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_CreatedDate.BackColor = System.Drawing.Color.Transparent
        Me.uc_CreatedDate.iDate = New Date(2020, 6, 21, 4, 22, 39, 390)
        Me.uc_CreatedDate.idsc = Nothing
        Me.uc_CreatedDate.iForm = Nothing
        Me.uc_CreatedDate.iIsForSearch = False
        Me.uc_CreatedDate.iLabel = "Created Date"
        Me.uc_CreatedDate.iLabel_width = 110
        Me.uc_CreatedDate.IsEnabled = False
        Me.uc_CreatedDate.isForFind = False
        Me.uc_CreatedDate.iSQL_Parameter_ID = 0
        Me.uc_CreatedDate.Location = New System.Drawing.Point(867, 32)
        Me.uc_CreatedDate.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_CreatedDate.Name = "uc_CreatedDate"
        Me.uc_CreatedDate.Size = New System.Drawing.Size(240, 24)
        Me.uc_CreatedDate.TabIndex = 106
        '
        'uc_SFG_lbl
        '
        Me.uc_SFG_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_SFG_lbl.iAddition_SQL = Nothing
        Me.uc_SFG_lbl.iAdditional = Nothing
        Me.uc_SFG_lbl.idsc = Nothing
        Me.uc_SFG_lbl.iIsEnabled = False
        Me.uc_SFG_lbl.iIsForSearch = False
        Me.uc_SFG_lbl.iLabel = "    Proration Name"
        Me.uc_SFG_lbl.iLabel_width = 5
        Me.uc_SFG_lbl.isLabelBoldx = False
        Me.uc_SFG_lbl.iSQL_Parameter_ID = 0
        Me.uc_SFG_lbl.iText = ""
        Me.uc_SFG_lbl.Location = New System.Drawing.Point(237, 84)
        Me.uc_SFG_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_SFG_lbl.Name = "uc_SFG_lbl"
        Me.uc_SFG_lbl.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.uc_SFG_lbl.Size = New System.Drawing.Size(211, 20)
        Me.uc_SFG_lbl.TabIndex = 120
        '
        'uc_createdBy
        '
        Me.uc_createdBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_createdBy.BackColor = System.Drawing.Color.Transparent
        Me.uc_createdBy.iAdditional = Nothing
        Me.uc_createdBy.iArrow_Visible = False
        Me.uc_createdBy.iCanFindLabel_SQLIDx = 0
        Me.uc_createdBy.iCharacterLimit = 0
        Me.uc_createdBy.idsc = Me.uc_dsc_null
        Me.uc_createdBy.iForm = Me
        Me.uc_createdBy.iIsDropDown = False
        Me.uc_createdBy.iIsEnabled = False
        Me.uc_createdBy.iIsForSearch = False
        Me.uc_createdBy.iIsID = False
        Me.uc_createdBy.iIsInnerShow = False
        Me.uc_createdBy.iLabel = "Created By"
        Me.uc_createdBy.iLabel_width = 94
        Me.uc_createdBy.isAllowEmptyx = True
        Me.uc_createdBy.isForFind = False
        Me.uc_createdBy.iSQL_Parameter_ID = 0
        Me.uc_createdBy.iText = ""
        Me.uc_createdBy.iTextBox_ = Me.txt_null
        Me.uc_createdBy.iTextBox_Sel_COL_ID = 0
        Me.uc_createdBy.iTitle = ""
        Me.uc_createdBy.Location = New System.Drawing.Point(865, 54)
        Me.uc_createdBy.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_createdBy.Name = "uc_createdBy"
        Me.uc_createdBy.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_createdBy.Size = New System.Drawing.Size(242, 20)
        Me.uc_createdBy.TabIndex = 105
        '
        'uc_SFG
        '
        Me.uc_SFG.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.uc_SFG.BackColor = System.Drawing.Color.Transparent
        Me.uc_SFG.iAdditional = Nothing
        Me.uc_SFG.iArrow_Visible = False
        Me.uc_SFG.iCanFindLabel_SQLIDx = 132
        Me.uc_SFG.iCharacterLimit = 0
        Me.uc_SFG.idsc = Me.uc_SFG_lbl
        Me.uc_SFG.iForm = Me
        Me.uc_SFG.iIsDropDown = False
        Me.uc_SFG.iIsEnabled = False
        Me.uc_SFG.iIsForSearch = False
        Me.uc_SFG.iIsID = False
        Me.uc_SFG.iIsInnerShow = True
        Me.uc_SFG.iLabel = "SFG"
        Me.uc_SFG.iLabel_width = 110
        Me.uc_SFG.isAllowEmptyx = True
        Me.uc_SFG.isForFind = True
        Me.uc_SFG.iSQL_Parameter_ID = 101
        Me.uc_SFG.iText = ""
        Me.uc_SFG.iTextBox_ = Me.txt_null
        Me.uc_SFG.iTextBox_Sel_COL_ID = 0
        Me.uc_SFG.iTitle = ""
        Me.uc_SFG.Location = New System.Drawing.Point(4, 84)
        Me.uc_SFG.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_SFG.Name = "uc_SFG"
        Me.uc_SFG.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_SFG.Size = New System.Drawing.Size(231, 20)
        Me.uc_SFG.TabIndex = 116
        '
        'Uc_label1
        '
        Me.Uc_label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_label1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label1.iAddition_SQL = Nothing
        Me.Uc_label1.iAdditional = Nothing
        Me.Uc_label1.idsc = Nothing
        Me.Uc_label1.iIsEnabled = False
        Me.Uc_label1.iIsForSearch = False
        Me.Uc_label1.iLabel = "Remarks"
        Me.Uc_label1.iLabel_width = 130
        Me.Uc_label1.isLabelBoldx = False
        Me.Uc_label1.iSQL_Parameter_ID = 0
        Me.Uc_label1.iText = ""
        Me.Uc_label1.Location = New System.Drawing.Point(711, 110)
        Me.Uc_label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Uc_label1.Name = "Uc_label1"
        Me.Uc_label1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Uc_label1.Size = New System.Drawing.Size(159, 20)
        Me.Uc_label1.TabIndex = 113
        '
        'uc_prorationLbl
        '
        Me.uc_prorationLbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_prorationLbl.iAddition_SQL = Nothing
        Me.uc_prorationLbl.iAdditional = Nothing
        Me.uc_prorationLbl.idsc = Nothing
        Me.uc_prorationLbl.iIsEnabled = False
        Me.uc_prorationLbl.iIsForSearch = False
        Me.uc_prorationLbl.iLabel = "    Proration Name"
        Me.uc_prorationLbl.iLabel_width = 5
        Me.uc_prorationLbl.isLabelBoldx = False
        Me.uc_prorationLbl.iSQL_Parameter_ID = 0
        Me.uc_prorationLbl.iText = ""
        Me.uc_prorationLbl.Location = New System.Drawing.Point(237, 58)
        Me.uc_prorationLbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_prorationLbl.Name = "uc_prorationLbl"
        Me.uc_prorationLbl.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.uc_prorationLbl.Size = New System.Drawing.Size(211, 20)
        Me.uc_prorationLbl.TabIndex = 115
        '
        'uc_warehouse
        '
        Me.uc_warehouse.BackColor = System.Drawing.Color.Transparent
        Me.uc_warehouse.iAdditional = Nothing
        Me.uc_warehouse.iArrow_Visible = False
        Me.uc_warehouse.iCanFindLabel_SQLIDx = 131
        Me.uc_warehouse.iCharacterLimit = 0
        Me.uc_warehouse.idsc = Me.UC_warehouselabel
        Me.uc_warehouse.iForm = Me
        Me.uc_warehouse.iIsDropDown = False
        Me.uc_warehouse.iIsEnabled = False
        Me.uc_warehouse.iIsForSearch = True
        Me.uc_warehouse.iIsID = False
        Me.uc_warehouse.iIsInnerShow = True
        Me.uc_warehouse.iLabel = "Warehouse"
        Me.uc_warehouse.iLabel_width = 110
        Me.uc_warehouse.isAllowEmptyx = True
        Me.uc_warehouse.isForFind = False
        Me.uc_warehouse.iSQL_Parameter_ID = 2
        Me.uc_warehouse.iText = ""
        Me.uc_warehouse.iTextBox_ = Me.txt_null
        Me.uc_warehouse.iTextBox_Sel_COL_ID = 0
        Me.uc_warehouse.iTitle = ""
        Me.uc_warehouse.Location = New System.Drawing.Point(4, 110)
        Me.uc_warehouse.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_warehouse.Name = "uc_warehouse"
        Me.uc_warehouse.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_warehouse.Size = New System.Drawing.Size(231, 20)
        Me.uc_warehouse.TabIndex = 111
        '
        'UC_warehouselabel
        '
        Me.UC_warehouselabel.BackColor = System.Drawing.Color.Transparent
        Me.UC_warehouselabel.iAddition_SQL = Nothing
        Me.UC_warehouselabel.iAdditional = Nothing
        Me.UC_warehouselabel.idsc = Nothing
        Me.UC_warehouselabel.iIsEnabled = False
        Me.UC_warehouselabel.iIsForSearch = False
        Me.UC_warehouselabel.iLabel = "    Warehouse Name"
        Me.UC_warehouselabel.iLabel_width = 5
        Me.UC_warehouselabel.isLabelBoldx = False
        Me.UC_warehouselabel.iSQL_Parameter_ID = 0
        Me.UC_warehouselabel.iText = ""
        Me.UC_warehouselabel.Location = New System.Drawing.Point(237, 110)
        Me.UC_warehouselabel.Margin = New System.Windows.Forms.Padding(4)
        Me.UC_warehouselabel.Name = "UC_warehouselabel"
        Me.UC_warehouselabel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.UC_warehouselabel.Size = New System.Drawing.Size(211, 20)
        Me.UC_warehouselabel.TabIndex = 109
        '
        'Uc_label2
        '
        Me.Uc_label2.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label2.iAddition_SQL = Nothing
        Me.Uc_label2.iAdditional = Nothing
        Me.Uc_label2.idsc = Nothing
        Me.Uc_label2.iIsEnabled = True
        Me.Uc_label2.iIsForSearch = False
        Me.Uc_label2.iLabel = "    Warehouse Name"
        Me.Uc_label2.iLabel_width = 120
        Me.Uc_label2.isLabelBoldx = False
        Me.Uc_label2.iSQL_Parameter_ID = 0
        Me.Uc_label2.iText = ""
        Me.Uc_label2.Location = New System.Drawing.Point(-50, -50)
        Me.Uc_label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Uc_label2.Name = "Uc_label2"
        Me.Uc_label2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Uc_label2.Size = New System.Drawing.Size(419, 31)
        Me.Uc_label2.TabIndex = 110
        '
        'returnLabel
        '
        Me.returnLabel.AutoSize = True
        Me.returnLabel.Location = New System.Drawing.Point(-50, -50)
        Me.returnLabel.Name = "returnLabel"
        Me.returnLabel.Size = New System.Drawing.Size(39, 13)
        Me.returnLabel.TabIndex = 108
        Me.returnLabel.Text = "Label1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(-50, -50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 107
        '
        'uc_prorationType
        '
        Me.uc_prorationType.BackColor = System.Drawing.Color.Transparent
        Me.uc_prorationType.iAdditional = Nothing
        Me.uc_prorationType.iArrow_Visible = True
        Me.uc_prorationType.iCanFindLabel_SQLIDx = 0
        Me.uc_prorationType.iCharacterLimit = 0
        Me.uc_prorationType.idsc = Me.uc_prorationLbl
        Me.uc_prorationType.iForm = Me
        Me.uc_prorationType.iIsDropDown = True
        Me.uc_prorationType.iIsEnabled = False
        Me.uc_prorationType.iIsForSearch = True
        Me.uc_prorationType.iIsID = False
        Me.uc_prorationType.iIsInnerShow = True
        Me.uc_prorationType.iLabel = "Proration Type"
        Me.uc_prorationType.iLabel_width = 110
        Me.uc_prorationType.isAllowEmptyx = True
        Me.uc_prorationType.isForFind = False
        Me.uc_prorationType.iSQL_Parameter_ID = 101
        Me.uc_prorationType.iText = ""
        Me.uc_prorationType.iTextBox_ = Me.txt_prorationType
        Me.uc_prorationType.iTextBox_Sel_COL_ID = 2
        Me.uc_prorationType.iTitle = ""
        Me.uc_prorationType.Location = New System.Drawing.Point(4, 58)
        Me.uc_prorationType.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_prorationType.Name = "uc_prorationType"
        Me.uc_prorationType.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_prorationType.Size = New System.Drawing.Size(231, 20)
        Me.uc_prorationType.TabIndex = 106
        '
        'uc_prorationNum
        '
        Me.uc_prorationNum.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.uc_prorationNum.BackColor = System.Drawing.Color.Transparent
        Me.uc_prorationNum.iAdditional = Nothing
        Me.uc_prorationNum.iArrow_Visible = False
        Me.uc_prorationNum.iCanFindLabel_SQLIDx = 0
        Me.uc_prorationNum.iCharacterLimit = 0
        Me.uc_prorationNum.idsc = Me.uc_dsc_null
        Me.uc_prorationNum.iForm = Me
        Me.uc_prorationNum.iIsDropDown = False
        Me.uc_prorationNum.iIsEnabled = False
        Me.uc_prorationNum.iIsForSearch = False
        Me.uc_prorationNum.iIsID = False
        Me.uc_prorationNum.iIsInnerShow = True
        Me.uc_prorationNum.iLabel = "Proration #"
        Me.uc_prorationNum.iLabel_width = 110
        Me.uc_prorationNum.isAllowEmptyx = True
        Me.uc_prorationNum.isForFind = True
        Me.uc_prorationNum.iSQL_Parameter_ID = 112
        Me.uc_prorationNum.iText = ""
        Me.uc_prorationNum.iTextBox_ = Me.txt_null
        Me.uc_prorationNum.iTextBox_Sel_COL_ID = 0
        Me.uc_prorationNum.iTitle = ""
        Me.uc_prorationNum.Location = New System.Drawing.Point(4, 6)
        Me.uc_prorationNum.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_prorationNum.Name = "uc_prorationNum"
        Me.uc_prorationNum.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_prorationNum.Size = New System.Drawing.Size(231, 20)
        Me.uc_prorationNum.TabIndex = 102
        '
        'cmd_Variant
        '
        Me.cmd_Variant.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmd_Variant.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cms_Variant_ViewBatch, Me.ToolStripSeparator1, Me.ToolStripMenuItem2})
        Me.cmd_Variant.Name = "ContextMenuStrip1"
        Me.cmd_Variant.Size = New System.Drawing.Size(171, 54)
        '
        'cms_Variant_ViewBatch
        '
        Me.cms_Variant_ViewBatch.Name = "cms_Variant_ViewBatch"
        Me.cms_Variant_ViewBatch.Size = New System.Drawing.Size(170, 22)
        Me.cms_Variant_ViewBatch.Text = "View Batch Details"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(167, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.CheckOnClick = True
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem2.Text = "Cancel"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 21)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1MinSize = 0
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel2MinSize = 0
        Me.SplitContainer1.Size = New System.Drawing.Size(1284, 733)
        Me.SplitContainer1.SplitterDistance = 162
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 115
        '
        'cms_copy
        '
        Me.cms_copy.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_copy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator2})
        Me.cms_copy.Name = "ContextMenuStrip1"
        Me.cms_copy.Size = New System.Drawing.Size(168, 32)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.ToolStripMenuItem1.Text = "Copy with header"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(164, 6)
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Proration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1296, 793)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.btn_ok)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Proration"
        CType(Me.dgv_CheckSelection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainTab.ResumeLayout(False)
        Me.tab1.ResumeLayout(False)
        Me.tab1.PerformLayout()
        CType(Me.dgv_Variant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.panel_sgf.ResumeLayout(False)
        CType(Me.dgv_sfg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab2.ResumeLayout(False)
        CType(Me.dgv_FG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab3.ResumeLayout(False)
        CType(Me.dgv_Proration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.cmd_Variant.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.cms_copy.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_ok As Button
    Friend WithEvents txt_remarks As TextBox
    Friend WithEvents dgv_CheckSelection As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tab2 As TabPage
    Friend WithEvents tab3 As TabPage
    '  Friend WithEvents Uc_finder_ItemCode As uc_finder
    Friend WithEvents Uc_header1 As uc_header
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Uc_header2 As uc_header
    Friend WithEvents dgv_FG As DataGridView
    Friend WithEvents Uc_PostingDate As uc_date
    Friend WithEvents uc_CreatedDate As uc_date
    Public WithEvents uc_prorationType As uc_inputbox
    Public WithEvents uc_createdBy As uc_inputbox
    Friend WithEvents cmd_Variant As ContextMenuStrip
    Friend WithEvents cms_Variant_ViewBatch As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents returnLabel As Label
    Friend WithEvents returnTextbox As TextBox
    Friend WithEvents UC_warehouselabel As uc_label
    Friend WithEvents Uc_label2 As uc_label
    Public WithEvents uc_warehouse As uc_inputbox
    Friend WithEvents btn_find_PO As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Uc_header3 As uc_header
    Friend WithEvents dgv_Proration As DataGridView
    Friend WithEvents crvwr As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Uc_label1 As uc_label
    Friend WithEvents uc_prorationLbl As uc_label
    Friend WithEvents uc_dsc_null As uc_label
    Public WithEvents uc_SFG As uc_inputbox
    Public WithEvents uc_prorationNum As uc_inputbox
    Friend WithEvents txt_prorationType As TextBox
    Friend WithEvents txt_null As TextBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgv_sfg As DataGridView
    Friend WithEvents panel_sgf As Panel
    Friend WithEvents cms_copy As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents uc_SFG_lbl As uc_label
    Friend WithEvents dgv_Variant As DataGridView
    Public WithEvents uc_baseRef As uc_inputbox
    Private WithEvents MainTab As MetroFramework.Controls.MetroTabControl
    Private WithEvents tab1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
