<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EDS_Ticketing
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
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.uc_appointedLbl = New IpicIndirect.uc_label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.uc_label_status = New IpicIndirect.uc_label()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.btn_find_PO = New System.Windows.Forms.Button()
        Me.Uc_inputbox5 = New IpicIndirect.uc_inputbox()
        Me.uc_lbl_null = New IpicIndirect.uc_label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.uc_status = New IpicIndirect.uc_inputbox()
        Me.uc_to = New IpicIndirect.uc_date()
        Me.uc_From = New IpicIndirect.uc_date()
        Me.dgv_CheckSelection = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_reply = New System.Windows.Forms.Button()
        Me.uc_station = New IpicIndirect.uc_inputbox()
        Me.uc_warehouse = New IpicIndirect.uc_inputbox()
        Me.uc_machine = New IpicIndirect.uc_inputbox()
        Me.uc_station_lbl = New IpicIndirect.uc_inputbox()
        Me.uc_warehouse_lbl = New IpicIndirect.uc_inputbox()
        Me.uc_machine_lbl = New IpicIndirect.uc_inputbox()
        Me.uc_appointedTo2lbl = New IpicIndirect.uc_label()
        Me.uc_iStats = New IpicIndirect.uc_inputbox()
        Me.uc_appoint2 = New IpicIndirect.uc_inputbox()
        Me.uc_main_subject = New IpicIndirect.uc_inputbox()
        Me.uc_mainReqBy = New IpicIndirect.uc_inputbox()
        Me.uc_mainTagNum = New IpicIndirect.uc_inputbox()
        Me.Uc_time3 = New IpicIndirect.uc_time()
        Me.uc_mainDateDone = New IpicIndirect.uc_date()
        Me.uc_mainTimeReq = New IpicIndirect.uc_time()
        Me.uc_mainDateReq = New IpicIndirect.uc_date()
        Me.panel1.SuspendLayout()
        CType(Me.dgv_CheckSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.uc_appointedLbl)
        Me.panel1.Controls.Add(Me.uc_label_status)
        Me.panel1.Controls.Add(Me.txt_status)
        Me.panel1.Controls.Add(Me.btn_find_PO)
        Me.panel1.Controls.Add(Me.Label7)
        Me.panel1.Controls.Add(Me.Uc_inputbox5)
        Me.panel1.Controls.Add(Me.uc_status)
        Me.panel1.Controls.Add(Me.uc_to)
        Me.panel1.Controls.Add(Me.uc_From)
        Me.panel1.Controls.Add(Me.dgv_CheckSelection)
        Me.panel1.Location = New System.Drawing.Point(10, 59)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(446, 781)
        Me.panel1.TabIndex = 0
        '
        'uc_appointedLbl
        '
        Me.uc_appointedLbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_appointedLbl.iAddition_SQL = Nothing
        Me.uc_appointedLbl.iAdditional = Nothing
        Me.uc_appointedLbl.idsc = Me.Label7
        Me.uc_appointedLbl.iIsEnabled = True
        Me.uc_appointedLbl.iIsForSearch = False
        Me.uc_appointedLbl.iLabel = "Edit iLbl to edit me"
        Me.uc_appointedLbl.iLabel_width = 5
        Me.uc_appointedLbl.iSQL_Parameter_ID = 0
        Me.uc_appointedLbl.iText = ""
        Me.uc_appointedLbl.Location = New System.Drawing.Point(156, 4)
        Me.uc_appointedLbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_appointedLbl.Name = "uc_appointedLbl"
        Me.uc_appointedLbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_appointedLbl.Size = New System.Drawing.Size(288, 21)
        Me.uc_appointedLbl.TabIndex = 116
        Me.uc_appointedLbl.Visible = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(4, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(445, 17)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Request list"
        '
        'uc_label_status
        '
        Me.uc_label_status.BackColor = System.Drawing.Color.Transparent
        Me.uc_label_status.iAddition_SQL = Nothing
        Me.uc_label_status.iAdditional = Nothing
        Me.uc_label_status.idsc = Nothing
        Me.uc_label_status.iIsEnabled = True
        Me.uc_label_status.iIsForSearch = False
        Me.uc_label_status.iLabel = "Edit iLbl to edit me"
        Me.uc_label_status.iLabel_width = 0
        Me.uc_label_status.iSQL_Parameter_ID = 0
        Me.uc_label_status.iText = ""
        Me.uc_label_status.Location = New System.Drawing.Point(253, 4)
        Me.uc_label_status.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_label_status.Name = "uc_label_status"
        Me.uc_label_status.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_label_status.Size = New System.Drawing.Size(191, 18)
        Me.uc_label_status.TabIndex = 116
        Me.uc_label_status.Visible = False
        '
        'txt_status
        '
        Me.txt_status.Location = New System.Drawing.Point(268, 3)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(64, 20)
        Me.txt_status.TabIndex = 115
        Me.txt_status.Visible = False
        '
        'btn_find_PO
        '
        Me.btn_find_PO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_find_PO.FlatAppearance.BorderSize = 0
        Me.btn_find_PO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_find_PO.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_find_PO.ForeColor = System.Drawing.Color.White
        Me.btn_find_PO.Location = New System.Drawing.Point(344, 25)
        Me.btn_find_PO.Name = "btn_find_PO"
        Me.btn_find_PO.Size = New System.Drawing.Size(98, 22)
        Me.btn_find_PO.TabIndex = 114
        Me.btn_find_PO.Text = "Search"
        Me.btn_find_PO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_find_PO.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_find_PO.UseVisualStyleBackColor = False
        '
        'Uc_inputbox5
        '
        Me.Uc_inputbox5.BackColor = System.Drawing.Color.Transparent
        Me.Uc_inputbox5.iAddition_SQL = Nothing
        Me.Uc_inputbox5.iAdditional = Nothing
        Me.Uc_inputbox5.iArrow_Visible = True
        Me.Uc_inputbox5.iCanFindLabel_SQLIDx = 0
        Me.Uc_inputbox5.iCharacterLimit = 0
        Me.Uc_inputbox5.idsc = Me.uc_lbl_null
        Me.Uc_inputbox5.iForm = Me
        Me.Uc_inputbox5.iIsDropDown = True
        Me.Uc_inputbox5.iIsEnabled = False
        Me.Uc_inputbox5.iIsForSearch = True
        Me.Uc_inputbox5.iIsID = False
        Me.Uc_inputbox5.iIsInnerShow = True
        Me.Uc_inputbox5.iLabel = "Appointed To"
        Me.Uc_inputbox5.iLabel_width = 105
        Me.Uc_inputbox5.isForFind = False
        Me.Uc_inputbox5.iSQL_Parameter_ID = 11
        Me.Uc_inputbox5.iText = ""
        Me.Uc_inputbox5.iTextBox_ = Me.TextBox1
        Me.Uc_inputbox5.iTextBox_Sel_COL_ID = 0
        Me.Uc_inputbox5.iTitle = ""
        Me.Uc_inputbox5.Location = New System.Drawing.Point(7, 4)
        Me.Uc_inputbox5.Margin = New System.Windows.Forms.Padding(0)
        Me.Uc_inputbox5.Name = "Uc_inputbox5"
        Me.Uc_inputbox5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_inputbox5.Size = New System.Drawing.Size(149, 24)
        Me.Uc_inputbox5.TabIndex = 19
        Me.Uc_inputbox5.Visible = False
        '
        'uc_lbl_null
        '
        Me.uc_lbl_null.BackColor = System.Drawing.Color.Transparent
        Me.uc_lbl_null.iAddition_SQL = Nothing
        Me.uc_lbl_null.iAdditional = Nothing
        Me.uc_lbl_null.idsc = Me.Label7
        Me.uc_lbl_null.iIsEnabled = True
        Me.uc_lbl_null.iIsForSearch = False
        Me.uc_lbl_null.iLabel = "Edit iLbl to edit me"
        Me.uc_lbl_null.iLabel_width = 0
        Me.uc_lbl_null.iSQL_Parameter_ID = 0
        Me.uc_lbl_null.iText = ""
        Me.uc_lbl_null.Location = New System.Drawing.Point(410, 21)
        Me.uc_lbl_null.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_lbl_null.Name = "uc_lbl_null"
        Me.uc_lbl_null.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_lbl_null.Size = New System.Drawing.Size(17, 24)
        Me.uc_lbl_null.TabIndex = 3
        Me.uc_lbl_null.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(410, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(17, 20)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Visible = False
        '
        'uc_status
        '
        Me.uc_status.AutoScroll = True
        Me.uc_status.BackColor = System.Drawing.Color.Transparent
        Me.uc_status.iAddition_SQL = Nothing
        Me.uc_status.iAdditional = Nothing
        Me.uc_status.iArrow_Visible = True
        Me.uc_status.iCanFindLabel_SQLIDx = 0
        Me.uc_status.iCharacterLimit = 0
        Me.uc_status.idsc = Me.uc_label_status
        Me.uc_status.iForm = Me
        Me.uc_status.iIsDropDown = False
        Me.uc_status.iIsEnabled = True
        Me.uc_status.iIsForSearch = True
        Me.uc_status.iIsID = False
        Me.uc_status.iIsInnerShow = True
        Me.uc_status.iLabel = "Status"
        Me.uc_status.iLabel_width = 105
        Me.uc_status.isForFind = False
        Me.uc_status.iSQL_Parameter_ID = 15
        Me.uc_status.iText = ""
        Me.uc_status.iTextBox_ = Me.txt_status
        Me.uc_status.iTextBox_Sel_COL_ID = 15
        Me.uc_status.iTitle = ""
        Me.uc_status.Location = New System.Drawing.Point(7, 4)
        Me.uc_status.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_status.Name = "uc_status"
        Me.uc_status.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_status.Size = New System.Drawing.Size(225, 24)
        Me.uc_status.TabIndex = 18
        '
        'uc_to
        '
        Me.uc_to.BackColor = System.Drawing.Color.Transparent
        Me.uc_to.iDate = New Date(2020, 4, 30, 23, 13, 46, 727)
        Me.uc_to.idsc = Me.Label7
        Me.uc_to.iForm = Me
        Me.uc_to.iIsForSearch = False
        Me.uc_to.iLabel = "To"
        Me.uc_to.iLabel_width = 50
        Me.uc_to.IsEnabled = False
        Me.uc_to.isForFind = False
        Me.uc_to.iSQL_Parameter_ID = 0
        Me.uc_to.Location = New System.Drawing.Point(167, 25)
        Me.uc_to.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_to.Name = "uc_to"
        Me.uc_to.Size = New System.Drawing.Size(176, 23)
        Me.uc_to.TabIndex = 17
        '
        'uc_From
        '
        Me.uc_From.BackColor = System.Drawing.Color.Transparent
        Me.uc_From.iDate = New Date(2020, 4, 30, 23, 13, 46, 731)
        Me.uc_From.idsc = Me.Label7
        Me.uc_From.iForm = Me
        Me.uc_From.iIsForSearch = True
        Me.uc_From.iLabel = "From"
        Me.uc_From.iLabel_width = 50
        Me.uc_From.IsEnabled = True
        Me.uc_From.isForFind = True
        Me.uc_From.iSQL_Parameter_ID = 0
        Me.uc_From.Location = New System.Drawing.Point(7, 25)
        Me.uc_From.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_From.Name = "uc_From"
        Me.uc_From.Size = New System.Drawing.Size(159, 23)
        Me.uc_From.TabIndex = 17
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
        Me.dgv_CheckSelection.Location = New System.Drawing.Point(4, 72)
        Me.dgv_CheckSelection.Name = "dgv_CheckSelection"
        Me.dgv_CheckSelection.ReadOnly = True
        Me.dgv_CheckSelection.RowHeadersVisible = False
        Me.dgv_CheckSelection.RowTemplate.Height = 24
        Me.dgv_CheckSelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_CheckSelection.Size = New System.Drawing.Size(441, 704)
        Me.dgv_CheckSelection.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(261, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 21)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "KPI"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(132, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 21)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Pending"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(261, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 21)
        Me.Label6.TabIndex = 120
        Me.Label6.Text = "0"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(132, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 21)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "0"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 21)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "0"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(10, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 21)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Total Request"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Location = New System.Drawing.Point(474, 186)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(733, 654)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(710, 693)
        Me.Panel3.TabIndex = 117
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(604, 1533)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 21)
        Me.Button2.TabIndex = 116
        Me.Button2.Text = "Find"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_reply
        '
        Me.btn_reply.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reply.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_reply.FlatAppearance.BorderSize = 0
        Me.btn_reply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reply.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reply.ForeColor = System.Drawing.Color.White
        Me.btn_reply.Location = New System.Drawing.Point(1106, 156)
        Me.btn_reply.Name = "btn_reply"
        Me.btn_reply.Size = New System.Drawing.Size(101, 21)
        Me.btn_reply.TabIndex = 119
        Me.btn_reply.Text = "Replay"
        Me.btn_reply.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_reply.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_reply.UseVisualStyleBackColor = False
        '
        'uc_station
        '
        Me.uc_station.BackColor = System.Drawing.Color.Transparent
        Me.uc_station.iAddition_SQL = Nothing
        Me.uc_station.iAdditional = Nothing
        Me.uc_station.iArrow_Visible = False
        Me.uc_station.iCanFindLabel_SQLIDx = 0
        Me.uc_station.iCharacterLimit = 0
        Me.uc_station.idsc = Me.uc_lbl_null
        Me.uc_station.iForm = Me
        Me.uc_station.iIsDropDown = False
        Me.uc_station.iIsEnabled = False
        Me.uc_station.iIsForSearch = False
        Me.uc_station.iIsID = False
        Me.uc_station.iIsInnerShow = True
        Me.uc_station.iLabel = "Station"
        Me.uc_station.iLabel_width = 85
        Me.uc_station.isForFind = False
        Me.uc_station.iSQL_Parameter_ID = 0
        Me.uc_station.iText = ""
        Me.uc_station.iTextBox_ = Me.TextBox1
        Me.uc_station.iTextBox_Sel_COL_ID = 0
        Me.uc_station.iTitle = ""
        Me.uc_station.Location = New System.Drawing.Point(474, 58)
        Me.uc_station.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_station.Name = "uc_station"
        Me.uc_station.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_station.Size = New System.Drawing.Size(143, 21)
        Me.uc_station.TabIndex = 125
        '
        'uc_warehouse
        '
        Me.uc_warehouse.BackColor = System.Drawing.Color.Transparent
        Me.uc_warehouse.iAddition_SQL = Nothing
        Me.uc_warehouse.iAdditional = Nothing
        Me.uc_warehouse.iArrow_Visible = False
        Me.uc_warehouse.iCanFindLabel_SQLIDx = 0
        Me.uc_warehouse.iCharacterLimit = 0
        Me.uc_warehouse.idsc = Me.uc_lbl_null
        Me.uc_warehouse.iForm = Me
        Me.uc_warehouse.iIsDropDown = False
        Me.uc_warehouse.iIsEnabled = False
        Me.uc_warehouse.iIsForSearch = False
        Me.uc_warehouse.iIsID = False
        Me.uc_warehouse.iIsInnerShow = True
        Me.uc_warehouse.iLabel = "Warehouse"
        Me.uc_warehouse.iLabel_width = 85
        Me.uc_warehouse.isForFind = False
        Me.uc_warehouse.iSQL_Parameter_ID = 0
        Me.uc_warehouse.iText = ""
        Me.uc_warehouse.iTextBox_ = Me.TextBox1
        Me.uc_warehouse.iTextBox_Sel_COL_ID = 0
        Me.uc_warehouse.iTitle = ""
        Me.uc_warehouse.Location = New System.Drawing.Point(474, 35)
        Me.uc_warehouse.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_warehouse.Name = "uc_warehouse"
        Me.uc_warehouse.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_warehouse.Size = New System.Drawing.Size(143, 21)
        Me.uc_warehouse.TabIndex = 126
        '
        'uc_machine
        '
        Me.uc_machine.BackColor = System.Drawing.Color.Transparent
        Me.uc_machine.iAddition_SQL = Nothing
        Me.uc_machine.iAdditional = Nothing
        Me.uc_machine.iArrow_Visible = False
        Me.uc_machine.iCanFindLabel_SQLIDx = 0
        Me.uc_machine.iCharacterLimit = 0
        Me.uc_machine.idsc = Me.uc_lbl_null
        Me.uc_machine.iForm = Me
        Me.uc_machine.iIsDropDown = False
        Me.uc_machine.iIsEnabled = False
        Me.uc_machine.iIsForSearch = False
        Me.uc_machine.iIsID = False
        Me.uc_machine.iIsInnerShow = True
        Me.uc_machine.iLabel = "Machine"
        Me.uc_machine.iLabel_width = 85
        Me.uc_machine.isForFind = False
        Me.uc_machine.iSQL_Parameter_ID = 0
        Me.uc_machine.iText = ""
        Me.uc_machine.iTextBox_ = Me.TextBox1
        Me.uc_machine.iTextBox_Sel_COL_ID = 0
        Me.uc_machine.iTitle = ""
        Me.uc_machine.Location = New System.Drawing.Point(474, 84)
        Me.uc_machine.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_machine.Name = "uc_machine"
        Me.uc_machine.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_machine.Size = New System.Drawing.Size(143, 21)
        Me.uc_machine.TabIndex = 127
        '
        'uc_station_lbl
        '
        Me.uc_station_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_station_lbl.iAddition_SQL = Nothing
        Me.uc_station_lbl.iAdditional = Nothing
        Me.uc_station_lbl.iArrow_Visible = False
        Me.uc_station_lbl.iCanFindLabel_SQLIDx = 0
        Me.uc_station_lbl.iCharacterLimit = 0
        Me.uc_station_lbl.idsc = Me.uc_lbl_null
        Me.uc_station_lbl.iForm = Me
        Me.uc_station_lbl.iIsDropDown = False
        Me.uc_station_lbl.iIsEnabled = False
        Me.uc_station_lbl.iIsForSearch = False
        Me.uc_station_lbl.iIsID = False
        Me.uc_station_lbl.iIsInnerShow = True
        Me.uc_station_lbl.iLabel = "Station"
        Me.uc_station_lbl.iLabel_width = -11
        Me.uc_station_lbl.isForFind = False
        Me.uc_station_lbl.iSQL_Parameter_ID = 0
        Me.uc_station_lbl.iText = ""
        Me.uc_station_lbl.iTextBox_ = Me.TextBox1
        Me.uc_station_lbl.iTextBox_Sel_COL_ID = 0
        Me.uc_station_lbl.iTitle = ""
        Me.uc_station_lbl.Location = New System.Drawing.Point(617, 58)
        Me.uc_station_lbl.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_station_lbl.Name = "uc_station_lbl"
        Me.uc_station_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_station_lbl.Size = New System.Drawing.Size(131, 21)
        Me.uc_station_lbl.TabIndex = 120
        '
        'uc_warehouse_lbl
        '
        Me.uc_warehouse_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_warehouse_lbl.iAddition_SQL = Nothing
        Me.uc_warehouse_lbl.iAdditional = Nothing
        Me.uc_warehouse_lbl.iArrow_Visible = False
        Me.uc_warehouse_lbl.iCanFindLabel_SQLIDx = 0
        Me.uc_warehouse_lbl.iCharacterLimit = 0
        Me.uc_warehouse_lbl.idsc = Me.uc_lbl_null
        Me.uc_warehouse_lbl.iForm = Me
        Me.uc_warehouse_lbl.iIsDropDown = False
        Me.uc_warehouse_lbl.iIsEnabled = False
        Me.uc_warehouse_lbl.iIsForSearch = False
        Me.uc_warehouse_lbl.iIsID = False
        Me.uc_warehouse_lbl.iIsInnerShow = True
        Me.uc_warehouse_lbl.iLabel = "Warehouse"
        Me.uc_warehouse_lbl.iLabel_width = -11
        Me.uc_warehouse_lbl.isForFind = False
        Me.uc_warehouse_lbl.iSQL_Parameter_ID = 0
        Me.uc_warehouse_lbl.iText = ""
        Me.uc_warehouse_lbl.iTextBox_ = Me.TextBox1
        Me.uc_warehouse_lbl.iTextBox_Sel_COL_ID = 0
        Me.uc_warehouse_lbl.iTitle = ""
        Me.uc_warehouse_lbl.Location = New System.Drawing.Point(617, 35)
        Me.uc_warehouse_lbl.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_warehouse_lbl.Name = "uc_warehouse_lbl"
        Me.uc_warehouse_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_warehouse_lbl.Size = New System.Drawing.Size(131, 21)
        Me.uc_warehouse_lbl.TabIndex = 120
        '
        'uc_machine_lbl
        '
        Me.uc_machine_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_machine_lbl.iAddition_SQL = Nothing
        Me.uc_machine_lbl.iAdditional = Nothing
        Me.uc_machine_lbl.iArrow_Visible = False
        Me.uc_machine_lbl.iCanFindLabel_SQLIDx = 0
        Me.uc_machine_lbl.iCharacterLimit = 0
        Me.uc_machine_lbl.idsc = Me.uc_lbl_null
        Me.uc_machine_lbl.iForm = Me
        Me.uc_machine_lbl.iIsDropDown = False
        Me.uc_machine_lbl.iIsEnabled = False
        Me.uc_machine_lbl.iIsForSearch = False
        Me.uc_machine_lbl.iIsID = False
        Me.uc_machine_lbl.iIsInnerShow = True
        Me.uc_machine_lbl.iLabel = "Machine"
        Me.uc_machine_lbl.iLabel_width = -11
        Me.uc_machine_lbl.isForFind = False
        Me.uc_machine_lbl.iSQL_Parameter_ID = 0
        Me.uc_machine_lbl.iText = ""
        Me.uc_machine_lbl.iTextBox_ = Me.TextBox1
        Me.uc_machine_lbl.iTextBox_Sel_COL_ID = 0
        Me.uc_machine_lbl.iTitle = ""
        Me.uc_machine_lbl.Location = New System.Drawing.Point(617, 84)
        Me.uc_machine_lbl.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_machine_lbl.Name = "uc_machine_lbl"
        Me.uc_machine_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_machine_lbl.Size = New System.Drawing.Size(131, 21)
        Me.uc_machine_lbl.TabIndex = 120
        '
        'uc_appointedTo2lbl
        '
        Me.uc_appointedTo2lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_appointedTo2lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_appointedTo2lbl.iAddition_SQL = Nothing
        Me.uc_appointedTo2lbl.iAdditional = Nothing
        Me.uc_appointedTo2lbl.idsc = Me.Label7
        Me.uc_appointedTo2lbl.iIsEnabled = True
        Me.uc_appointedTo2lbl.iIsForSearch = False
        Me.uc_appointedTo2lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_appointedTo2lbl.iLabel_width = 5
        Me.uc_appointedTo2lbl.iSQL_Parameter_ID = 0
        Me.uc_appointedTo2lbl.iText = ""
        Me.uc_appointedTo2lbl.Location = New System.Drawing.Point(410, 21)
        Me.uc_appointedTo2lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_appointedTo2lbl.Name = "uc_appointedTo2lbl"
        Me.uc_appointedTo2lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_appointedTo2lbl.Size = New System.Drawing.Size(17, 21)
        Me.uc_appointedTo2lbl.TabIndex = 117
        Me.uc_appointedTo2lbl.Visible = False
        '
        'uc_iStats
        '
        Me.uc_iStats.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_iStats.BackColor = System.Drawing.Color.Transparent
        Me.uc_iStats.iAddition_SQL = Nothing
        Me.uc_iStats.iAdditional = Nothing
        Me.uc_iStats.iArrow_Visible = False
        Me.uc_iStats.iCanFindLabel_SQLIDx = 0
        Me.uc_iStats.iCharacterLimit = 0
        Me.uc_iStats.idsc = Me.uc_lbl_null
        Me.uc_iStats.iForm = Me
        Me.uc_iStats.iIsDropDown = False
        Me.uc_iStats.iIsEnabled = False
        Me.uc_iStats.iIsForSearch = False
        Me.uc_iStats.iIsID = False
        Me.uc_iStats.iIsInnerShow = False
        Me.uc_iStats.iLabel = "Status"
        Me.uc_iStats.iLabel_width = 103
        Me.uc_iStats.isForFind = False
        Me.uc_iStats.iSQL_Parameter_ID = 11
        Me.uc_iStats.iText = ""
        Me.uc_iStats.iTextBox_ = Me.TextBox1
        Me.uc_iStats.iTextBox_Sel_COL_ID = 0
        Me.uc_iStats.iTitle = ""
        Me.uc_iStats.Location = New System.Drawing.Point(956, 60)
        Me.uc_iStats.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_iStats.Name = "uc_iStats"
        Me.uc_iStats.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_iStats.Size = New System.Drawing.Size(250, 22)
        Me.uc_iStats.TabIndex = 4
        '
        'uc_appoint2
        '
        Me.uc_appoint2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_appoint2.BackColor = System.Drawing.Color.Transparent
        Me.uc_appoint2.iAddition_SQL = Nothing
        Me.uc_appoint2.iAdditional = Nothing
        Me.uc_appoint2.iArrow_Visible = False
        Me.uc_appoint2.iCanFindLabel_SQLIDx = 0
        Me.uc_appoint2.iCharacterLimit = 0
        Me.uc_appoint2.idsc = Me.uc_lbl_null
        Me.uc_appoint2.iForm = Me
        Me.uc_appoint2.iIsDropDown = False
        Me.uc_appoint2.iIsEnabled = False
        Me.uc_appoint2.iIsForSearch = False
        Me.uc_appoint2.iIsID = False
        Me.uc_appoint2.iIsInnerShow = False
        Me.uc_appoint2.iLabel = "Appointed To"
        Me.uc_appoint2.iLabel_width = 103
        Me.uc_appoint2.isForFind = False
        Me.uc_appoint2.iSQL_Parameter_ID = 11
        Me.uc_appoint2.iText = ""
        Me.uc_appoint2.iTextBox_ = Me.TextBox1
        Me.uc_appoint2.iTextBox_Sel_COL_ID = 0
        Me.uc_appoint2.iTitle = ""
        Me.uc_appoint2.Location = New System.Drawing.Point(956, 8)
        Me.uc_appoint2.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_appoint2.Name = "uc_appoint2"
        Me.uc_appoint2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_appoint2.Size = New System.Drawing.Size(250, 22)
        Me.uc_appoint2.TabIndex = 4
        '
        'uc_main_subject
        '
        Me.uc_main_subject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_main_subject.BackColor = System.Drawing.Color.Transparent
        Me.uc_main_subject.iAddition_SQL = Nothing
        Me.uc_main_subject.iAdditional = Nothing
        Me.uc_main_subject.iArrow_Visible = False
        Me.uc_main_subject.iCanFindLabel_SQLIDx = 0
        Me.uc_main_subject.iCharacterLimit = 0
        Me.uc_main_subject.idsc = Nothing
        Me.uc_main_subject.iForm = Me
        Me.uc_main_subject.iIsDropDown = False
        Me.uc_main_subject.iIsEnabled = False
        Me.uc_main_subject.iIsForSearch = False
        Me.uc_main_subject.iIsID = False
        Me.uc_main_subject.iIsInnerShow = False
        Me.uc_main_subject.iLabel = "Subject"
        Me.uc_main_subject.iLabel_width = 90
        Me.uc_main_subject.isForFind = False
        Me.uc_main_subject.iSQL_Parameter_ID = 0
        Me.uc_main_subject.iText = ""
        Me.uc_main_subject.iTextBox_ = Me.TextBox1
        Me.uc_main_subject.iTextBox_Sel_COL_ID = 0
        Me.uc_main_subject.iTitle = ""
        Me.uc_main_subject.Location = New System.Drawing.Point(473, 156)
        Me.uc_main_subject.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_main_subject.Name = "uc_main_subject"
        Me.uc_main_subject.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_main_subject.Size = New System.Drawing.Size(633, 25)
        Me.uc_main_subject.TabIndex = 4
        '
        'uc_mainReqBy
        '
        Me.uc_mainReqBy.BackColor = System.Drawing.Color.Transparent
        Me.uc_mainReqBy.iAddition_SQL = Nothing
        Me.uc_mainReqBy.iAdditional = Nothing
        Me.uc_mainReqBy.iArrow_Visible = False
        Me.uc_mainReqBy.iCanFindLabel_SQLIDx = 0
        Me.uc_mainReqBy.iCharacterLimit = 0
        Me.uc_mainReqBy.idsc = Me.uc_lbl_null
        Me.uc_mainReqBy.iForm = Me
        Me.uc_mainReqBy.iIsDropDown = False
        Me.uc_mainReqBy.iIsEnabled = False
        Me.uc_mainReqBy.iIsForSearch = False
        Me.uc_mainReqBy.iIsID = False
        Me.uc_mainReqBy.iIsInnerShow = False
        Me.uc_mainReqBy.iLabel = "Requested By"
        Me.uc_mainReqBy.iLabel_width = 85
        Me.uc_mainReqBy.isForFind = False
        Me.uc_mainReqBy.iSQL_Parameter_ID = 0
        Me.uc_mainReqBy.iText = ""
        Me.uc_mainReqBy.iTextBox_ = Me.TextBox1
        Me.uc_mainReqBy.iTextBox_Sel_COL_ID = 0
        Me.uc_mainReqBy.iTitle = ""
        Me.uc_mainReqBy.Location = New System.Drawing.Point(473, 109)
        Me.uc_mainReqBy.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_mainReqBy.Name = "uc_mainReqBy"
        Me.uc_mainReqBy.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_mainReqBy.Size = New System.Drawing.Size(276, 21)
        Me.uc_mainReqBy.TabIndex = 4
        '
        'uc_mainTagNum
        '
        Me.uc_mainTagNum.BackColor = System.Drawing.Color.Transparent
        Me.uc_mainTagNum.iAddition_SQL = Nothing
        Me.uc_mainTagNum.iAdditional = Nothing
        Me.uc_mainTagNum.iArrow_Visible = False
        Me.uc_mainTagNum.iCanFindLabel_SQLIDx = 0
        Me.uc_mainTagNum.iCharacterLimit = 0
        Me.uc_mainTagNum.idsc = Me.uc_lbl_null
        Me.uc_mainTagNum.iForm = Me
        Me.uc_mainTagNum.iIsDropDown = False
        Me.uc_mainTagNum.iIsEnabled = False
        Me.uc_mainTagNum.iIsForSearch = False
        Me.uc_mainTagNum.iIsID = False
        Me.uc_mainTagNum.iIsInnerShow = False
        Me.uc_mainTagNum.iLabel = "Tag #"
        Me.uc_mainTagNum.iLabel_width = 85
        Me.uc_mainTagNum.isForFind = False
        Me.uc_mainTagNum.iSQL_Parameter_ID = 0
        Me.uc_mainTagNum.iText = ""
        Me.uc_mainTagNum.iTextBox_ = Me.TextBox1
        Me.uc_mainTagNum.iTextBox_Sel_COL_ID = 0
        Me.uc_mainTagNum.iTitle = ""
        Me.uc_mainTagNum.Location = New System.Drawing.Point(473, 8)
        Me.uc_mainTagNum.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_mainTagNum.Name = "uc_mainTagNum"
        Me.uc_mainTagNum.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_mainTagNum.Size = New System.Drawing.Size(276, 21)
        Me.uc_mainTagNum.TabIndex = 4
        '
        'Uc_time3
        '
        Me.Uc_time3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_time3.BackColor = System.Drawing.Color.Transparent
        Me.Uc_time3.iDate = New Date(2020, 4, 30, 23, 13, 46, 698)
        Me.Uc_time3.idsc = Me.Label7
        Me.Uc_time3.iForm = Me
        Me.Uc_time3.iIsForSearch = False
        Me.Uc_time3.iLabel = "Production Order Selection"
        Me.Uc_time3.iLabel_width = 5
        Me.Uc_time3.IsEnabled = True
        Me.Uc_time3.isForFind = True
        Me.Uc_time3.iSQL_Parameter_ID = 0
        Me.Uc_time3.Location = New System.Drawing.Point(1146, 33)
        Me.Uc_time3.Margin = New System.Windows.Forms.Padding(4)
        Me.Uc_time3.Name = "Uc_time3"
        Me.Uc_time3.Size = New System.Drawing.Size(61, 23)
        Me.Uc_time3.TabIndex = 2
        '
        'uc_mainDateDone
        '
        Me.uc_mainDateDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_mainDateDone.BackColor = System.Drawing.Color.Transparent
        Me.uc_mainDateDone.iDate = New Date(2020, 4, 30, 23, 13, 46, 703)
        Me.uc_mainDateDone.idsc = Me.Label7
        Me.uc_mainDateDone.iForm = Me
        Me.uc_mainDateDone.iIsForSearch = False
        Me.uc_mainDateDone.iLabel = "Done Time"
        Me.uc_mainDateDone.iLabel_width = 120
        Me.uc_mainDateDone.IsEnabled = False
        Me.uc_mainDateDone.isForFind = False
        Me.uc_mainDateDone.iSQL_Parameter_ID = 0
        Me.uc_mainDateDone.Location = New System.Drawing.Point(957, 33)
        Me.uc_mainDateDone.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_mainDateDone.Name = "uc_mainDateDone"
        Me.uc_mainDateDone.Size = New System.Drawing.Size(188, 23)
        Me.uc_mainDateDone.TabIndex = 1
        '
        'uc_mainTimeReq
        '
        Me.uc_mainTimeReq.BackColor = System.Drawing.Color.Transparent
        Me.uc_mainTimeReq.iDate = New Date(2020, 4, 30, 23, 13, 46, 708)
        Me.uc_mainTimeReq.idsc = Me.Label7
        Me.uc_mainTimeReq.iForm = Me
        Me.uc_mainTimeReq.iIsForSearch = False
        Me.uc_mainTimeReq.iLabel = "Production Order Selection"
        Me.uc_mainTimeReq.iLabel_width = 5
        Me.uc_mainTimeReq.IsEnabled = False
        Me.uc_mainTimeReq.isForFind = False
        Me.uc_mainTimeReq.iSQL_Parameter_ID = 0
        Me.uc_mainTimeReq.Location = New System.Drawing.Point(683, 132)
        Me.uc_mainTimeReq.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_mainTimeReq.Name = "uc_mainTimeReq"
        Me.uc_mainTimeReq.Size = New System.Drawing.Size(63, 20)
        Me.uc_mainTimeReq.TabIndex = 2
        '
        'uc_mainDateReq
        '
        Me.uc_mainDateReq.BackColor = System.Drawing.Color.Transparent
        Me.uc_mainDateReq.iDate = New Date(2020, 4, 30, 23, 13, 46, 712)
        Me.uc_mainDateReq.idsc = Me.Label7
        Me.uc_mainDateReq.iForm = Me
        Me.uc_mainDateReq.iIsForSearch = False
        Me.uc_mainDateReq.iLabel = "Reqested Time"
        Me.uc_mainDateReq.iLabel_width = 126
        Me.uc_mainDateReq.IsEnabled = False
        Me.uc_mainDateReq.isForFind = False
        Me.uc_mainDateReq.iSQL_Parameter_ID = 0
        Me.uc_mainDateReq.Location = New System.Drawing.Point(473, 132)
        Me.uc_mainDateReq.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_mainDateReq.Name = "uc_mainDateReq"
        Me.uc_mainDateReq.Size = New System.Drawing.Size(209, 21)
        Me.uc_mainDateReq.TabIndex = 1
        '
        'EDS_Ticketing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 852)
        Me.Controls.Add(Me.uc_station)
        Me.Controls.Add(Me.uc_warehouse)
        Me.Controls.Add(Me.uc_machine)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.uc_station_lbl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.uc_warehouse_lbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.uc_machine_lbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_reply)
        Me.Controls.Add(Me.uc_appointedTo2lbl)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.uc_iStats)
        Me.Controls.Add(Me.uc_appoint2)
        Me.Controls.Add(Me.uc_main_subject)
        Me.Controls.Add(Me.uc_mainReqBy)
        Me.Controls.Add(Me.uc_mainTagNum)
        Me.Controls.Add(Me.uc_lbl_null)
        Me.Controls.Add(Me.Uc_time3)
        Me.Controls.Add(Me.uc_mainDateDone)
        Me.Controls.Add(Me.uc_mainTimeReq)
        Me.Controls.Add(Me.uc_mainDateReq)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Name = "EDS_Ticketing"
        Me.Text = "Ticketing"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.dgv_CheckSelection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel1 As Panel
    Friend WithEvents txt_status As TextBox
    Friend WithEvents btn_find_PO As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Uc_inputbox5 As uc_inputbox
    Friend WithEvents uc_label_status As uc_label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents uc_appoint2 As uc_inputbox
    Friend WithEvents uc_main_subject As uc_inputbox
    Friend WithEvents uc_mainReqBy As uc_inputbox
    Friend WithEvents uc_mainTagNum As uc_inputbox
    Friend WithEvents uc_lbl_null As uc_label
    Friend WithEvents Uc_time3 As uc_time
    Friend WithEvents uc_mainDateDone As uc_date
    Friend WithEvents uc_mainTimeReq As uc_time
    Friend WithEvents uc_mainDateReq As uc_date
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents uc_status As uc_inputbox
    Friend WithEvents uc_to As uc_date
    Friend WithEvents uc_From As uc_date
    Friend WithEvents dgv_CheckSelection As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents uc_appointedLbl As uc_label
    Friend WithEvents uc_appointedTo2lbl As uc_label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_reply As Button
    Friend WithEvents uc_warehouse_lbl As uc_inputbox
    Friend WithEvents uc_machine_lbl As uc_inputbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents uc_station_lbl As uc_inputbox
    Friend WithEvents uc_iStats As uc_inputbox
    Friend WithEvents uc_station As uc_inputbox
    Friend WithEvents uc_warehouse As uc_inputbox
    Friend WithEvents uc_machine As uc_inputbox
End Class
