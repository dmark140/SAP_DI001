<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MBOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MBOS))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.btn_find_PO = New System.Windows.Forms.Button()
        Me.UC_dtp_To = New IpicIndirect.uc_date()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UC_dtp_from = New IpicIndirect.uc_date()
        Me.timer_previewCounter = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgv_CheckSelection = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgv_SelectedDocs = New System.Windows.Forms.DataGridView()
        Me.tab2 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_formatedx = New System.Windows.Forms.TextBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Uc_TextBox1 = New IpicIndirect.uc_inputbox()
        Me.Uc_null = New IpicIndirect.uc_label()
        Me.txt_null = New System.Windows.Forms.TextBox()
        Me.Uc_txt_docTotal = New IpicIndirect.uc_inputbox()
        Me.Uc_txt_DocQty = New IpicIndirect.uc_inputbox()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tab1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv_CheckSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_SelectedDocs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.btn_find_PO)
        Me.Panel1.Controls.Add(Me.UC_dtp_To)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.UC_dtp_from)
        Me.Panel1.Location = New System.Drawing.Point(12, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(374, 70)
        Me.Panel1.TabIndex = 39
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(256, 23)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(41, 17)
        Me.RadioButton2.TabIndex = 67
        Me.RadioButton2.Text = "MC"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(256, 2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton1.TabIndex = 67
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "CC"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'btn_find_PO
        '
        Me.btn_find_PO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_find_PO.FlatAppearance.BorderSize = 0
        Me.btn_find_PO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_find_PO.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_find_PO.ForeColor = System.Drawing.Color.White
        Me.btn_find_PO.Location = New System.Drawing.Point(256, 46)
        Me.btn_find_PO.Name = "btn_find_PO"
        Me.btn_find_PO.Size = New System.Drawing.Size(108, 21)
        Me.btn_find_PO.TabIndex = 113
        Me.btn_find_PO.Text = "Find"
        Me.btn_find_PO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_find_PO.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_find_PO.UseVisualStyleBackColor = False
        '
        'UC_dtp_To
        '
        Me.UC_dtp_To.BackColor = System.Drawing.Color.Transparent
        Me.UC_dtp_To.iDate = New Date(2020, 3, 31, 22, 3, 30, 651)
        Me.UC_dtp_To.idsc = Nothing
        Me.UC_dtp_To.iForm = Nothing
        Me.UC_dtp_To.iIsForSearch = False
        Me.UC_dtp_To.iLabel = "To"
        Me.UC_dtp_To.iLabel_width = 80
        Me.UC_dtp_To.IsEnabled = False
        Me.UC_dtp_To.isForFind = False
        Me.UC_dtp_To.iSQL_Parameter_ID = 0
        Me.UC_dtp_To.Location = New System.Drawing.Point(7, 47)
        Me.UC_dtp_To.Name = "UC_dtp_To"
        Me.UC_dtp_To.Size = New System.Drawing.Size(243, 22)
        Me.UC_dtp_To.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(7, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 17)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Posting Date"
        '
        'UC_dtp_from
        '
        Me.UC_dtp_from.BackColor = System.Drawing.Color.Transparent
        Me.UC_dtp_from.iDate = New Date(2020, 3, 31, 22, 3, 30, 656)
        Me.UC_dtp_from.idsc = Nothing
        Me.UC_dtp_from.iForm = Nothing
        Me.UC_dtp_from.iIsForSearch = False
        Me.UC_dtp_from.iLabel = "From"
        Me.UC_dtp_from.iLabel_width = 80
        Me.UC_dtp_from.IsEnabled = False
        Me.UC_dtp_from.isForFind = False
        Me.UC_dtp_from.iSQL_Parameter_ID = 0
        Me.UC_dtp_from.Location = New System.Drawing.Point(7, 23)
        Me.UC_dtp_from.Name = "UC_dtp_from"
        Me.UC_dtp_from.Size = New System.Drawing.Size(243, 21)
        Me.UC_dtp_from.TabIndex = 67
        '
        'timer_previewCounter
        '
        Me.timer_previewCounter.Interval = 500
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(875, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 21)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Export"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 20)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1003, 199)
        Me.RichTextBox1.TabIndex = 51
        Me.RichTextBox1.Text = ""
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tab1)
        Me.TabControl1.Controls.Add(Me.tab2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 85)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1008, 480)
        Me.TabControl1.TabIndex = 52
        '
        'tab1
        '
        Me.tab1.Controls.Add(Me.SplitContainer1)
        Me.tab1.Location = New System.Drawing.Point(4, 22)
        Me.tab1.Name = "tab1"
        Me.tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.tab1.Size = New System.Drawing.Size(1000, 454)
        Me.tab1.TabIndex = 0
        Me.tab1.Text = "Components"
        Me.tab1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgv_CheckSelection)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv_SelectedDocs)
        Me.SplitContainer1.Size = New System.Drawing.Size(994, 448)
        Me.SplitContainer1.SplitterDistance = 441
        Me.SplitContainer1.TabIndex = 51
        '
        'dgv_CheckSelection
        '
        Me.dgv_CheckSelection.AllowUserToAddRows = False
        Me.dgv_CheckSelection.AllowUserToDeleteRows = False
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
        Me.dgv_CheckSelection.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgv_CheckSelection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_CheckSelection.EnableHeadersVisualStyles = False
        Me.dgv_CheckSelection.Location = New System.Drawing.Point(0, 0)
        Me.dgv_CheckSelection.Name = "dgv_CheckSelection"
        Me.dgv_CheckSelection.ReadOnly = True
        Me.dgv_CheckSelection.RowHeadersVisible = False
        Me.dgv_CheckSelection.RowTemplate.Height = 24
        Me.dgv_CheckSelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_CheckSelection.Size = New System.Drawing.Size(439, 446)
        Me.dgv_CheckSelection.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1145, 17)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Selected Items"
        '
        'dgv_SelectedDocs
        '
        Me.dgv_SelectedDocs.AllowUserToAddRows = False
        Me.dgv_SelectedDocs.AllowUserToDeleteRows = False
        Me.dgv_SelectedDocs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_SelectedDocs.BackgroundColor = System.Drawing.Color.White
        Me.dgv_SelectedDocs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_SelectedDocs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_SelectedDocs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_SelectedDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_SelectedDocs.EnableHeadersVisualStyles = False
        Me.dgv_SelectedDocs.Location = New System.Drawing.Point(0, 19)
        Me.dgv_SelectedDocs.Margin = New System.Windows.Forms.Padding(0)
        Me.dgv_SelectedDocs.Name = "dgv_SelectedDocs"
        Me.dgv_SelectedDocs.ReadOnly = True
        Me.dgv_SelectedDocs.RowHeadersVisible = False
        Me.dgv_SelectedDocs.RowTemplate.Height = 24
        Me.dgv_SelectedDocs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_SelectedDocs.Size = New System.Drawing.Size(547, 404)
        Me.dgv_SelectedDocs.TabIndex = 48
        '
        'tab2
        '
        Me.tab2.Controls.Add(Me.Label5)
        Me.tab2.Controls.Add(Me.Button1)
        Me.tab2.Controls.Add(Me.txt_formatedx)
        Me.tab2.Location = New System.Drawing.Point(4, 22)
        Me.tab2.Name = "tab2"
        Me.tab2.Padding = New System.Windows.Forms.Padding(3)
        Me.tab2.Size = New System.Drawing.Size(1000, 454)
        Me.tab2.TabIndex = 1
        Me.tab2.Text = "Summary"
        Me.tab2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(2, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1006, 17)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Preview"
        '
        'txt_formatedx
        '
        Me.txt_formatedx.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_formatedx.Location = New System.Drawing.Point(1, 21)
        Me.txt_formatedx.Multiline = True
        Me.txt_formatedx.Name = "txt_formatedx"
        Me.txt_formatedx.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_formatedx.Size = New System.Drawing.Size(999, 398)
        Me.txt_formatedx.TabIndex = 47
        Me.txt_formatedx.WordWrap = False
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(271, -22)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(116, 21)
        Me.btn_ok.TabIndex = 60
        Me.btn_ok.Text = "Find"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(16, 588)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 21)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "Cancel"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Uc_TextBox1
        '
        Me.Uc_TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_TextBox1.iAddition_SQL = Nothing
        Me.Uc_TextBox1.iAdditional = Nothing
        Me.Uc_TextBox1.iArrow_Visible = False
        Me.Uc_TextBox1.iCanFindLabel_SQLIDx = 0
        Me.Uc_TextBox1.iCharacterLimit = 0
        Me.Uc_TextBox1.idsc = Me.Uc_null
        Me.Uc_TextBox1.iForm = Me
        Me.Uc_TextBox1.iIsDropDown = False
        Me.Uc_TextBox1.iIsEnabled = True
        Me.Uc_TextBox1.iIsForSearch = False
        Me.Uc_TextBox1.iIsID = False
        Me.Uc_TextBox1.iIsInnerShow = False
        Me.Uc_TextBox1.iLabel = "File name"
        Me.Uc_TextBox1.iLabel_width = 100
        Me.Uc_TextBox1.isForFind = False
        Me.Uc_TextBox1.iSQL_Parameter_ID = 0
        Me.Uc_TextBox1.iText = ""
        Me.Uc_TextBox1.iTextBox_ = Me.txt_null
        Me.Uc_TextBox1.iTextBox_Sel_COL_ID = 0
        Me.Uc_TextBox1.iTitle = ""
        Me.Uc_TextBox1.Location = New System.Drawing.Point(759, 61)
        Me.Uc_TextBox1.Name = "Uc_TextBox1"
        Me.Uc_TextBox1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_TextBox1.Size = New System.Drawing.Size(253, 24)
        Me.Uc_TextBox1.TabIndex = 66
        '
        'Uc_null
        '
        Me.Uc_null.BackColor = System.Drawing.Color.Transparent
        Me.Uc_null.iAddition_SQL = Nothing
        Me.Uc_null.iAdditional = Nothing
        Me.Uc_null.idsc = Nothing
        Me.Uc_null.iIsEnabled = True
        Me.Uc_null.iIsForSearch = False
        Me.Uc_null.iLabel = "Edit iLbl to edit me"
        Me.Uc_null.iLabel_width = 0
        Me.Uc_null.iSQL_Parameter_ID = 0
        Me.Uc_null.iText = ""
        Me.Uc_null.Location = New System.Drawing.Point(482, 29)
        Me.Uc_null.Name = "Uc_null"
        Me.Uc_null.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_null.Size = New System.Drawing.Size(128, 30)
        Me.Uc_null.TabIndex = 68
        Me.Uc_null.Visible = False
        '
        'txt_null
        '
        Me.txt_null.Location = New System.Drawing.Point(573, 65)
        Me.txt_null.Name = "txt_null"
        Me.txt_null.Size = New System.Drawing.Size(100, 20)
        Me.txt_null.TabIndex = 67
        Me.txt_null.Visible = False
        '
        'Uc_txt_docTotal
        '
        Me.Uc_txt_docTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_txt_docTotal.BackColor = System.Drawing.Color.Transparent
        Me.Uc_txt_docTotal.iAddition_SQL = Nothing
        Me.Uc_txt_docTotal.iAdditional = Nothing
        Me.Uc_txt_docTotal.iArrow_Visible = False
        Me.Uc_txt_docTotal.iCanFindLabel_SQLIDx = 0
        Me.Uc_txt_docTotal.iCharacterLimit = 0
        Me.Uc_txt_docTotal.idsc = Me.Uc_null
        Me.Uc_txt_docTotal.iForm = Me
        Me.Uc_txt_docTotal.iIsDropDown = False
        Me.Uc_txt_docTotal.iIsEnabled = False
        Me.Uc_txt_docTotal.iIsForSearch = False
        Me.Uc_txt_docTotal.iIsID = False
        Me.Uc_txt_docTotal.iIsInnerShow = False
        Me.Uc_txt_docTotal.iLabel = "Total Amount"
        Me.Uc_txt_docTotal.iLabel_width = 100
        Me.Uc_txt_docTotal.isForFind = False
        Me.Uc_txt_docTotal.iSQL_Parameter_ID = 0
        Me.Uc_txt_docTotal.iText = ""
        Me.Uc_txt_docTotal.iTextBox_ = Me.txt_null
        Me.Uc_txt_docTotal.iTextBox_Sel_COL_ID = 0
        Me.Uc_txt_docTotal.iTitle = ""
        Me.Uc_txt_docTotal.Location = New System.Drawing.Point(759, 31)
        Me.Uc_txt_docTotal.Name = "Uc_txt_docTotal"
        Me.Uc_txt_docTotal.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_txt_docTotal.Size = New System.Drawing.Size(253, 24)
        Me.Uc_txt_docTotal.TabIndex = 66
        '
        'Uc_txt_DocQty
        '
        Me.Uc_txt_DocQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_txt_DocQty.BackColor = System.Drawing.Color.Transparent
        Me.Uc_txt_DocQty.iAddition_SQL = Nothing
        Me.Uc_txt_DocQty.iAdditional = Nothing
        Me.Uc_txt_DocQty.iArrow_Visible = False
        Me.Uc_txt_DocQty.iCanFindLabel_SQLIDx = 0
        Me.Uc_txt_DocQty.iCharacterLimit = 0
        Me.Uc_txt_DocQty.idsc = Me.Uc_null
        Me.Uc_txt_DocQty.iForm = Me
        Me.Uc_txt_DocQty.iIsDropDown = False
        Me.Uc_txt_DocQty.iIsEnabled = False
        Me.Uc_txt_DocQty.iIsForSearch = False
        Me.Uc_txt_DocQty.iIsID = False
        Me.Uc_txt_DocQty.iIsInnerShow = False
        Me.Uc_txt_DocQty.iLabel = "Total Quantity"
        Me.Uc_txt_DocQty.iLabel_width = 100
        Me.Uc_txt_DocQty.isForFind = False
        Me.Uc_txt_DocQty.iSQL_Parameter_ID = 0
        Me.Uc_txt_DocQty.iText = ""
        Me.Uc_txt_DocQty.iTextBox_ = Me.txt_null
        Me.Uc_txt_DocQty.iTextBox_Sel_COL_ID = 0
        Me.Uc_txt_DocQty.iTitle = ""
        Me.Uc_txt_DocQty.Location = New System.Drawing.Point(759, 8)
        Me.Uc_txt_DocQty.Name = "Uc_txt_DocQty"
        Me.Uc_txt_DocQty.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_txt_DocQty.Size = New System.Drawing.Size(253, 24)
        Me.Uc_txt_DocQty.TabIndex = 66
        '
        'MBOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1032, 621)
        Me.Controls.Add(Me.Uc_null)
        Me.Controls.Add(Me.txt_null)
        Me.Controls.Add(Me.Uc_TextBox1)
        Me.Controls.Add(Me.Uc_txt_docTotal)
        Me.Controls.Add(Me.Uc_txt_DocQty)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MBOS"
        Me.Text = "MBOS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tab1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv_CheckSelection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_SelectedDocs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab2.ResumeLayout(False)
        Me.tab2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timer_previewCounter As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txt_formated As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab1 As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dgv_CheckSelection As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents dgv_SelectedDocs As DataGridView
    Friend WithEvents tab2 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_formatedx As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_ok As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Uc_header1 As uc_header
    Friend WithEvents UC_dtp_To As uc_date
    Friend WithEvents UC_dtp_from As uc_date
    Friend WithEvents Uc_txt_DocQty As uc_inputbox
    Friend WithEvents Uc_TextBox1 As uc_inputbox
    Friend WithEvents Uc_txt_docTotal As uc_inputbox
    Friend WithEvents btn_find_PO As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Uc_null As uc_label
    Friend WithEvents txt_null As TextBox
End Class
