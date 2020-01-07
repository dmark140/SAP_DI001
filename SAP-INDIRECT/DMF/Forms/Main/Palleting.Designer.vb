<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Palleting
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.docnum_container = New System.Windows.Forms.TextBox()
        Me.docnum_container_desc = New System.Windows.Forms.TextBox()
        Me.dgv_CheckSelection = New System.Windows.Forms.DataGridView()
        Me.Uc_inputbox3 = New IpicIndirect.uc_inputbox()
        Me.uc_null = New IpicIndirect.uc_label()
        Me.uc_lbl_releasedBy = New IpicIndirect.uc_label()
        Me.uc_receivedBy = New IpicIndirect.uc_label()
        Me.uc_palletizer = New IpicIndirect.uc_label()
        Me.Uc_inputbox6 = New IpicIndirect.uc_inputbox()
        Me.Uc_inputbox5 = New IpicIndirect.uc_inputbox()
        Me.Uc_inputbox2 = New IpicIndirect.uc_inputbox()
        Me.Uc_date3 = New IpicIndirect.uc_date()
        Me.uc_ToWHse_lbl = New IpicIndirect.uc_label()
        Me.uc_fromWHse_lbl = New IpicIndirect.uc_label()
        Me.uc_ToWHse = New IpicIndirect.uc_inputbox()
        Me.uc_fromWHse = New IpicIndirect.uc_inputbox()
        Me.Uc_inputbox4 = New IpicIndirect.uc_inputbox()
        Me.uc_lbl_series = New IpicIndirect.uc_label()
        Me.Uc_docnum = New IpicIndirect.uc_inputbox()
        Me.Uc_inputbox1 = New IpicIndirect.uc_inputbox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Uc_date1 = New IpicIndirect.uc_date()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_fetch = New System.Windows.Forms.Button()
        Me.Uc_dateFrom = New IpicIndirect.uc_date()
        Me.Uc_dateTo = New IpicIndirect.uc_date()
        Me.Uc_label1 = New IpicIndirect.uc_label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.dgv_CheckSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'docnum_container
        '
        Me.docnum_container.Location = New System.Drawing.Point(407, 1)
        Me.docnum_container.Name = "docnum_container"
        Me.docnum_container.Size = New System.Drawing.Size(181, 20)
        Me.docnum_container.TabIndex = 90
        Me.docnum_container.Visible = False
        '
        'docnum_container_desc
        '
        Me.docnum_container_desc.Location = New System.Drawing.Point(403, 25)
        Me.docnum_container_desc.Name = "docnum_container_desc"
        Me.docnum_container_desc.Size = New System.Drawing.Size(181, 20)
        Me.docnum_container_desc.TabIndex = 90
        Me.docnum_container_desc.Visible = False
        '
        'dgv_CheckSelection
        '
        Me.dgv_CheckSelection.AllowUserToAddRows = False
        Me.dgv_CheckSelection.AllowUserToDeleteRows = False
        Me.dgv_CheckSelection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_CheckSelection.BackgroundColor = System.Drawing.Color.White
        Me.dgv_CheckSelection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_CheckSelection.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_CheckSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_CheckSelection.EnableHeadersVisualStyles = False
        Me.dgv_CheckSelection.Location = New System.Drawing.Point(10, 160)
        Me.dgv_CheckSelection.Name = "dgv_CheckSelection"
        Me.dgv_CheckSelection.ReadOnly = True
        Me.dgv_CheckSelection.RowHeadersVisible = False
        Me.dgv_CheckSelection.RowTemplate.Height = 24
        Me.dgv_CheckSelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_CheckSelection.Size = New System.Drawing.Size(905, 402)
        Me.dgv_CheckSelection.TabIndex = 91
        '
        'Uc_inputbox3
        '
        Me.Uc_inputbox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_inputbox3.BackColor = System.Drawing.Color.Transparent
        Me.Uc_inputbox3.iAddition_SQL = Nothing
        Me.Uc_inputbox3.iAdditional = Nothing
        Me.Uc_inputbox3.iArrow_Visible = False
        Me.Uc_inputbox3.iCanFindLabel_SQLIDx = 0
        Me.Uc_inputbox3.iCharacterLimit = 0
        Me.Uc_inputbox3.idsc = Me.uc_null
        Me.Uc_inputbox3.iForm = Me
        Me.Uc_inputbox3.iIsDropDown = False
        Me.Uc_inputbox3.iIsEnabled = False
        Me.Uc_inputbox3.iIsForSearch = False
        Me.Uc_inputbox3.iIsID = False
        Me.Uc_inputbox3.iIsInnerShow = True
        Me.Uc_inputbox3.iLabel = "Odd Ref#"
        Me.Uc_inputbox3.iLabel_width = 110
        Me.Uc_inputbox3.isForFind = False
        Me.Uc_inputbox3.iSQL_Parameter_ID = 0
        Me.Uc_inputbox3.iText = ""
        Me.Uc_inputbox3.iTextBox_ = Nothing
        Me.Uc_inputbox3.iTextBox_Sel_COL_ID = 0
        Me.Uc_inputbox3.iTitle = ""
        Me.Uc_inputbox3.Location = New System.Drawing.Point(640, 57)
        Me.Uc_inputbox3.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_inputbox3.Name = "Uc_inputbox3"
        Me.Uc_inputbox3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_inputbox3.Size = New System.Drawing.Size(280, 23)
        Me.Uc_inputbox3.TabIndex = 98
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
        Me.uc_null.iSQL_Parameter_ID = 0
        Me.uc_null.iText = "Reciept From Production"
        Me.uc_null.Location = New System.Drawing.Point(403, 57)
        Me.uc_null.Name = "uc_null"
        Me.uc_null.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_null.Size = New System.Drawing.Size(230, 21)
        Me.uc_null.TabIndex = 93
        Me.uc_null.Visible = False
        '
        'uc_lbl_releasedBy
        '
        Me.uc_lbl_releasedBy.BackColor = System.Drawing.Color.Transparent
        Me.uc_lbl_releasedBy.iAddition_SQL = Nothing
        Me.uc_lbl_releasedBy.iAdditional = Nothing
        Me.uc_lbl_releasedBy.idsc = Nothing
        Me.uc_lbl_releasedBy.iIsEnabled = True
        Me.uc_lbl_releasedBy.iIsForSearch = False
        Me.uc_lbl_releasedBy.iLabel = "Edit iLbl to edit me"
        Me.uc_lbl_releasedBy.iLabel_width = 5
        Me.uc_lbl_releasedBy.iSQL_Parameter_ID = 0
        Me.uc_lbl_releasedBy.iText = ""
        Me.uc_lbl_releasedBy.Location = New System.Drawing.Point(203, 72)
        Me.uc_lbl_releasedBy.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_lbl_releasedBy.Name = "uc_lbl_releasedBy"
        Me.uc_lbl_releasedBy.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_lbl_releasedBy.Size = New System.Drawing.Size(165, 22)
        Me.uc_lbl_releasedBy.TabIndex = 97
        '
        'uc_receivedBy
        '
        Me.uc_receivedBy.BackColor = System.Drawing.Color.Transparent
        Me.uc_receivedBy.iAddition_SQL = Nothing
        Me.uc_receivedBy.iAdditional = Nothing
        Me.uc_receivedBy.idsc = Nothing
        Me.uc_receivedBy.iIsEnabled = True
        Me.uc_receivedBy.iIsForSearch = False
        Me.uc_receivedBy.iLabel = "Edit iLbl to edit me"
        Me.uc_receivedBy.iLabel_width = 5
        Me.uc_receivedBy.iSQL_Parameter_ID = 0
        Me.uc_receivedBy.iText = ""
        Me.uc_receivedBy.Location = New System.Drawing.Point(203, 97)
        Me.uc_receivedBy.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_receivedBy.Name = "uc_receivedBy"
        Me.uc_receivedBy.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_receivedBy.Size = New System.Drawing.Size(165, 22)
        Me.uc_receivedBy.TabIndex = 96
        '
        'uc_palletizer
        '
        Me.uc_palletizer.BackColor = System.Drawing.Color.Transparent
        Me.uc_palletizer.iAddition_SQL = Nothing
        Me.uc_palletizer.iAdditional = Nothing
        Me.uc_palletizer.idsc = Nothing
        Me.uc_palletizer.iIsEnabled = True
        Me.uc_palletizer.iIsForSearch = False
        Me.uc_palletizer.iLabel = "Edit iLbl to edit me"
        Me.uc_palletizer.iLabel_width = 5
        Me.uc_palletizer.iSQL_Parameter_ID = 0
        Me.uc_palletizer.iText = ""
        Me.uc_palletizer.Location = New System.Drawing.Point(203, 122)
        Me.uc_palletizer.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_palletizer.Name = "uc_palletizer"
        Me.uc_palletizer.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_palletizer.Size = New System.Drawing.Size(165, 22)
        Me.uc_palletizer.TabIndex = 95
        '
        'Uc_inputbox6
        '
        Me.Uc_inputbox6.BackColor = System.Drawing.Color.Transparent
        Me.Uc_inputbox6.iAddition_SQL = Nothing
        Me.Uc_inputbox6.iAdditional = Nothing
        Me.Uc_inputbox6.iArrow_Visible = True
        Me.Uc_inputbox6.iCanFindLabel_SQLIDx = 0
        Me.Uc_inputbox6.iCharacterLimit = 0
        Me.Uc_inputbox6.idsc = Me.uc_receivedBy
        Me.Uc_inputbox6.iForm = Me
        Me.Uc_inputbox6.iIsDropDown = False
        Me.Uc_inputbox6.iIsEnabled = True
        Me.Uc_inputbox6.iIsForSearch = True
        Me.Uc_inputbox6.iIsID = False
        Me.Uc_inputbox6.iIsInnerShow = True
        Me.Uc_inputbox6.iLabel = "Recieved by"
        Me.Uc_inputbox6.iLabel_width = 105
        Me.Uc_inputbox6.isForFind = False
        Me.Uc_inputbox6.iSQL_Parameter_ID = 4
        Me.Uc_inputbox6.iText = ""
        Me.Uc_inputbox6.iTextBox_ = Nothing
        Me.Uc_inputbox6.iTextBox_Sel_COL_ID = 0
        Me.Uc_inputbox6.iTitle = ""
        Me.Uc_inputbox6.Location = New System.Drawing.Point(8, 97)
        Me.Uc_inputbox6.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_inputbox6.Name = "Uc_inputbox6"
        Me.Uc_inputbox6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_inputbox6.Size = New System.Drawing.Size(193, 23)
        Me.Uc_inputbox6.TabIndex = 89
        '
        'Uc_inputbox5
        '
        Me.Uc_inputbox5.BackColor = System.Drawing.Color.Transparent
        Me.Uc_inputbox5.iAddition_SQL = Nothing
        Me.Uc_inputbox5.iAdditional = Nothing
        Me.Uc_inputbox5.iArrow_Visible = True
        Me.Uc_inputbox5.iCanFindLabel_SQLIDx = 0
        Me.Uc_inputbox5.iCharacterLimit = 0
        Me.Uc_inputbox5.idsc = Me.uc_lbl_releasedBy
        Me.Uc_inputbox5.iForm = Me
        Me.Uc_inputbox5.iIsDropDown = False
        Me.Uc_inputbox5.iIsEnabled = True
        Me.Uc_inputbox5.iIsForSearch = True
        Me.Uc_inputbox5.iIsID = False
        Me.Uc_inputbox5.iIsInnerShow = True
        Me.Uc_inputbox5.iLabel = "Released by"
        Me.Uc_inputbox5.iLabel_width = 105
        Me.Uc_inputbox5.isForFind = False
        Me.Uc_inputbox5.iSQL_Parameter_ID = 4
        Me.Uc_inputbox5.iText = ""
        Me.Uc_inputbox5.iTextBox_ = Nothing
        Me.Uc_inputbox5.iTextBox_Sel_COL_ID = 0
        Me.Uc_inputbox5.iTitle = ""
        Me.Uc_inputbox5.Location = New System.Drawing.Point(8, 72)
        Me.Uc_inputbox5.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_inputbox5.Name = "Uc_inputbox5"
        Me.Uc_inputbox5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_inputbox5.Size = New System.Drawing.Size(193, 23)
        Me.Uc_inputbox5.TabIndex = 89
        '
        'Uc_inputbox2
        '
        Me.Uc_inputbox2.BackColor = System.Drawing.Color.Transparent
        Me.Uc_inputbox2.iAddition_SQL = Nothing
        Me.Uc_inputbox2.iAdditional = Nothing
        Me.Uc_inputbox2.iArrow_Visible = True
        Me.Uc_inputbox2.iCanFindLabel_SQLIDx = 0
        Me.Uc_inputbox2.iCharacterLimit = 0
        Me.Uc_inputbox2.idsc = Me.uc_palletizer
        Me.Uc_inputbox2.iForm = Me
        Me.Uc_inputbox2.iIsDropDown = False
        Me.Uc_inputbox2.iIsEnabled = True
        Me.Uc_inputbox2.iIsForSearch = True
        Me.Uc_inputbox2.iIsID = False
        Me.Uc_inputbox2.iIsInnerShow = True
        Me.Uc_inputbox2.iLabel = "Palletizer"
        Me.Uc_inputbox2.iLabel_width = 105
        Me.Uc_inputbox2.isForFind = False
        Me.Uc_inputbox2.iSQL_Parameter_ID = 4
        Me.Uc_inputbox2.iText = ""
        Me.Uc_inputbox2.iTextBox_ = Nothing
        Me.Uc_inputbox2.iTextBox_Sel_COL_ID = 0
        Me.Uc_inputbox2.iTitle = ""
        Me.Uc_inputbox2.Location = New System.Drawing.Point(8, 122)
        Me.Uc_inputbox2.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_inputbox2.Name = "Uc_inputbox2"
        Me.Uc_inputbox2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_inputbox2.Size = New System.Drawing.Size(193, 23)
        Me.Uc_inputbox2.TabIndex = 89
        '
        'Uc_date3
        '
        Me.Uc_date3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_date3.BackColor = System.Drawing.Color.Transparent
        Me.Uc_date3.iDate = New Date(2020, 3, 31, 22, 3, 33, 76)
        Me.Uc_date3.idsc = Nothing
        Me.Uc_date3.iForm = Nothing
        Me.Uc_date3.iIsForSearch = False
        Me.Uc_date3.iLabel = "Palleting Date"
        Me.Uc_date3.iLabel_width = 110
        Me.Uc_date3.IsEnabled = False
        Me.Uc_date3.isForFind = False
        Me.Uc_date3.iSQL_Parameter_ID = 0
        Me.Uc_date3.Location = New System.Drawing.Point(638, 132)
        Me.Uc_date3.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_date3.Name = "Uc_date3"
        Me.Uc_date3.Size = New System.Drawing.Size(282, 24)
        Me.Uc_date3.TabIndex = 88
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
        Me.uc_ToWHse_lbl.iSQL_Parameter_ID = 0
        Me.uc_ToWHse_lbl.iText = ""
        Me.uc_ToWHse_lbl.Location = New System.Drawing.Point(203, 32)
        Me.uc_ToWHse_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_ToWHse_lbl.Name = "uc_ToWHse_lbl"
        Me.uc_ToWHse_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_ToWHse_lbl.Size = New System.Drawing.Size(166, 22)
        Me.uc_ToWHse_lbl.TabIndex = 85
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
        Me.uc_fromWHse_lbl.iSQL_Parameter_ID = 0
        Me.uc_fromWHse_lbl.iText = ""
        Me.uc_fromWHse_lbl.Location = New System.Drawing.Point(203, 8)
        Me.uc_fromWHse_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_fromWHse_lbl.Name = "uc_fromWHse_lbl"
        Me.uc_fromWHse_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_fromWHse_lbl.Size = New System.Drawing.Size(166, 22)
        Me.uc_fromWHse_lbl.TabIndex = 85
        '
        'uc_ToWHse
        '
        Me.uc_ToWHse.BackColor = System.Drawing.Color.Transparent
        Me.uc_ToWHse.iAddition_SQL = Nothing
        Me.uc_ToWHse.iAdditional = Nothing
        Me.uc_ToWHse.iArrow_Visible = True
        Me.uc_ToWHse.iCanFindLabel_SQLIDx = 0
        Me.uc_ToWHse.iCharacterLimit = 0
        Me.uc_ToWHse.idsc = Me.uc_ToWHse_lbl
        Me.uc_ToWHse.iForm = Me
        Me.uc_ToWHse.iIsDropDown = False
        Me.uc_ToWHse.iIsEnabled = True
        Me.uc_ToWHse.iIsForSearch = True
        Me.uc_ToWHse.iIsID = False
        Me.uc_ToWHse.iIsInnerShow = True
        Me.uc_ToWHse.iLabel = "To Whs"
        Me.uc_ToWHse.iLabel_width = 105
        Me.uc_ToWHse.isForFind = False
        Me.uc_ToWHse.iSQL_Parameter_ID = 2
        Me.uc_ToWHse.iText = ""
        Me.uc_ToWHse.iTextBox_ = Nothing
        Me.uc_ToWHse.iTextBox_Sel_COL_ID = 0
        Me.uc_ToWHse.iTitle = ""
        Me.uc_ToWHse.Location = New System.Drawing.Point(8, 32)
        Me.uc_ToWHse.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_ToWHse.Name = "uc_ToWHse"
        Me.uc_ToWHse.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_ToWHse.Size = New System.Drawing.Size(193, 23)
        Me.uc_ToWHse.TabIndex = 82
        '
        'uc_fromWHse
        '
        Me.uc_fromWHse.BackColor = System.Drawing.Color.Transparent
        Me.uc_fromWHse.iAddition_SQL = Nothing
        Me.uc_fromWHse.iAdditional = Nothing
        Me.uc_fromWHse.iArrow_Visible = True
        Me.uc_fromWHse.iCanFindLabel_SQLIDx = 0
        Me.uc_fromWHse.iCharacterLimit = 0
        Me.uc_fromWHse.idsc = Me.uc_fromWHse_lbl
        Me.uc_fromWHse.iForm = Me
        Me.uc_fromWHse.iIsDropDown = False
        Me.uc_fromWHse.iIsEnabled = True
        Me.uc_fromWHse.iIsForSearch = True
        Me.uc_fromWHse.iIsID = False
        Me.uc_fromWHse.iIsInnerShow = True
        Me.uc_fromWHse.iLabel = "From Whs"
        Me.uc_fromWHse.iLabel_width = 105
        Me.uc_fromWHse.isForFind = False
        Me.uc_fromWHse.iSQL_Parameter_ID = 2
        Me.uc_fromWHse.iText = ""
        Me.uc_fromWHse.iTextBox_ = Nothing
        Me.uc_fromWHse.iTextBox_Sel_COL_ID = 0
        Me.uc_fromWHse.iTitle = ""
        Me.uc_fromWHse.Location = New System.Drawing.Point(8, 7)
        Me.uc_fromWHse.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_fromWHse.Name = "uc_fromWHse"
        Me.uc_fromWHse.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_fromWHse.Size = New System.Drawing.Size(193, 23)
        Me.uc_fromWHse.TabIndex = 81
        '
        'Uc_inputbox4
        '
        Me.Uc_inputbox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_inputbox4.BackColor = System.Drawing.Color.Transparent
        Me.Uc_inputbox4.iAddition_SQL = Nothing
        Me.Uc_inputbox4.iAdditional = Nothing
        Me.Uc_inputbox4.iArrow_Visible = True
        Me.Uc_inputbox4.iCanFindLabel_SQLIDx = 0
        Me.Uc_inputbox4.iCharacterLimit = 0
        Me.Uc_inputbox4.idsc = Me.uc_lbl_series
        Me.Uc_inputbox4.iForm = Me
        Me.Uc_inputbox4.iIsDropDown = False
        Me.Uc_inputbox4.iIsEnabled = True
        Me.Uc_inputbox4.iIsForSearch = True
        Me.Uc_inputbox4.iIsID = False
        Me.Uc_inputbox4.iIsInnerShow = True
        Me.Uc_inputbox4.iLabel = "Series"
        Me.Uc_inputbox4.iLabel_width = 110
        Me.Uc_inputbox4.isForFind = False
        Me.Uc_inputbox4.iSQL_Parameter_ID = 0
        Me.Uc_inputbox4.iText = ""
        Me.Uc_inputbox4.iTextBox_ = Nothing
        Me.Uc_inputbox4.iTextBox_Sel_COL_ID = 0
        Me.Uc_inputbox4.iTitle = ""
        Me.Uc_inputbox4.Location = New System.Drawing.Point(640, 82)
        Me.Uc_inputbox4.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_inputbox4.Name = "Uc_inputbox4"
        Me.Uc_inputbox4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_inputbox4.Size = New System.Drawing.Size(191, 23)
        Me.Uc_inputbox4.TabIndex = 76
        '
        'uc_lbl_series
        '
        Me.uc_lbl_series.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_lbl_series.BackColor = System.Drawing.Color.Transparent
        Me.uc_lbl_series.iAddition_SQL = Nothing
        Me.uc_lbl_series.iAdditional = Nothing
        Me.uc_lbl_series.idsc = Nothing
        Me.uc_lbl_series.iIsEnabled = True
        Me.uc_lbl_series.iIsForSearch = False
        Me.uc_lbl_series.iLabel = "Edit iLbl to edit me"
        Me.uc_lbl_series.iLabel_width = 5
        Me.uc_lbl_series.iSQL_Parameter_ID = 0
        Me.uc_lbl_series.iText = ""
        Me.uc_lbl_series.Location = New System.Drawing.Point(833, 82)
        Me.uc_lbl_series.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_lbl_series.Name = "uc_lbl_series"
        Me.uc_lbl_series.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_lbl_series.Size = New System.Drawing.Size(87, 22)
        Me.uc_lbl_series.TabIndex = 99
        '
        'Uc_docnum
        '
        Me.Uc_docnum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_docnum.BackColor = System.Drawing.Color.Transparent
        Me.Uc_docnum.iAddition_SQL = Nothing
        Me.Uc_docnum.iAdditional = Nothing
        Me.Uc_docnum.iArrow_Visible = False
        Me.Uc_docnum.iCanFindLabel_SQLIDx = 0
        Me.Uc_docnum.iCharacterLimit = 0
        Me.Uc_docnum.idsc = Me.uc_null
        Me.Uc_docnum.iForm = Me
        Me.Uc_docnum.iIsDropDown = False
        Me.Uc_docnum.iIsEnabled = False
        Me.Uc_docnum.iIsForSearch = False
        Me.Uc_docnum.iIsID = False
        Me.Uc_docnum.iIsInnerShow = True
        Me.Uc_docnum.iLabel = "RFP #"
        Me.Uc_docnum.iLabel_width = 110
        Me.Uc_docnum.isForFind = False
        Me.Uc_docnum.iSQL_Parameter_ID = 0
        Me.Uc_docnum.iText = ""
        Me.Uc_docnum.iTextBox_ = Nothing
        Me.Uc_docnum.iTextBox_Sel_COL_ID = 0
        Me.Uc_docnum.iTitle = ""
        Me.Uc_docnum.Location = New System.Drawing.Point(640, 8)
        Me.Uc_docnum.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_docnum.Name = "Uc_docnum"
        Me.Uc_docnum.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_docnum.Size = New System.Drawing.Size(280, 23)
        Me.Uc_docnum.TabIndex = 76
        '
        'Uc_inputbox1
        '
        Me.Uc_inputbox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_inputbox1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_inputbox1.iAddition_SQL = Nothing
        Me.Uc_inputbox1.iAdditional = Nothing
        Me.Uc_inputbox1.iArrow_Visible = False
        Me.Uc_inputbox1.iCanFindLabel_SQLIDx = 0
        Me.Uc_inputbox1.iCharacterLimit = 0
        Me.Uc_inputbox1.idsc = Me.uc_null
        Me.Uc_inputbox1.iForm = Me
        Me.Uc_inputbox1.iIsDropDown = False
        Me.Uc_inputbox1.iIsEnabled = False
        Me.Uc_inputbox1.iIsForSearch = False
        Me.Uc_inputbox1.iIsID = False
        Me.Uc_inputbox1.iIsInnerShow = True
        Me.Uc_inputbox1.iLabel = "Palleting #"
        Me.Uc_inputbox1.iLabel_width = 110
        Me.Uc_inputbox1.isForFind = False
        Me.Uc_inputbox1.iSQL_Parameter_ID = 0
        Me.Uc_inputbox1.iText = ""
        Me.Uc_inputbox1.iTextBox_ = Nothing
        Me.Uc_inputbox1.iTextBox_Sel_COL_ID = 0
        Me.Uc_inputbox1.iTitle = ""
        Me.Uc_inputbox1.Location = New System.Drawing.Point(640, 32)
        Me.Uc_inputbox1.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_inputbox1.Name = "Uc_inputbox1"
        Me.Uc_inputbox1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_inputbox1.Size = New System.Drawing.Size(280, 23)
        Me.Uc_inputbox1.TabIndex = 76
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1259, 594)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 21)
        Me.Button2.TabIndex = 99
        Me.Button2.Text = "Add"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Uc_date1
        '
        Me.Uc_date1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_date1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_date1.iDate = New Date(2020, 3, 31, 22, 3, 33, 80)
        Me.Uc_date1.idsc = Nothing
        Me.Uc_date1.iForm = Nothing
        Me.Uc_date1.iIsForSearch = False
        Me.Uc_date1.iLabel = "Palleting Date"
        Me.Uc_date1.iLabel_width = 110
        Me.Uc_date1.IsEnabled = False
        Me.Uc_date1.isForFind = False
        Me.Uc_date1.iSQL_Parameter_ID = 0
        Me.Uc_date1.Location = New System.Drawing.Point(638, 106)
        Me.Uc_date1.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_date1.Name = "Uc_date1"
        Me.Uc_date1.Size = New System.Drawing.Size(282, 24)
        Me.Uc_date1.TabIndex = 88
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.btn_fetch)
        Me.Panel1.Controls.Add(Me.Uc_dateFrom)
        Me.Panel1.Controls.Add(Me.Uc_dateTo)
        Me.Panel1.Controls.Add(Me.Uc_label1)
        Me.Panel1.Location = New System.Drawing.Point(14, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 573)
        Me.Panel1.TabIndex = 100
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(7, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(417, 504)
        Me.DataGridView1.TabIndex = 93
        '
        'btn_fetch
        '
        Me.btn_fetch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_fetch.FlatAppearance.BorderSize = 0
        Me.btn_fetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fetch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fetch.ForeColor = System.Drawing.Color.White
        Me.btn_fetch.Location = New System.Drawing.Point(359, 34)
        Me.btn_fetch.Name = "btn_fetch"
        Me.btn_fetch.Size = New System.Drawing.Size(68, 21)
        Me.btn_fetch.TabIndex = 73
        Me.btn_fetch.Text = "Fetch"
        Me.btn_fetch.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_fetch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_fetch.UseVisualStyleBackColor = False
        '
        'Uc_dateFrom
        '
        Me.Uc_dateFrom.BackColor = System.Drawing.Color.Transparent
        Me.Uc_dateFrom.iDate = New Date(2020, 3, 31, 22, 3, 33, 96)
        Me.Uc_dateFrom.idsc = Nothing
        Me.Uc_dateFrom.iForm = Nothing
        Me.Uc_dateFrom.iIsForSearch = False
        Me.Uc_dateFrom.iLabel = "From"
        Me.Uc_dateFrom.iLabel_width = 65
        Me.Uc_dateFrom.IsEnabled = False
        Me.Uc_dateFrom.isForFind = False
        Me.Uc_dateFrom.iSQL_Parameter_ID = 0
        Me.Uc_dateFrom.Location = New System.Drawing.Point(7, 34)
        Me.Uc_dateFrom.Name = "Uc_dateFrom"
        Me.Uc_dateFrom.Size = New System.Drawing.Size(170, 21)
        Me.Uc_dateFrom.TabIndex = 74
        '
        'Uc_dateTo
        '
        Me.Uc_dateTo.BackColor = System.Drawing.Color.Transparent
        Me.Uc_dateTo.iDate = New Date(2020, 3, 31, 22, 3, 33, 102)
        Me.Uc_dateTo.idsc = Nothing
        Me.Uc_dateTo.iForm = Nothing
        Me.Uc_dateTo.iIsForSearch = False
        Me.Uc_dateTo.iLabel = "To"
        Me.Uc_dateTo.iLabel_width = 65
        Me.Uc_dateTo.IsEnabled = False
        Me.Uc_dateTo.isForFind = False
        Me.Uc_dateTo.iSQL_Parameter_ID = 0
        Me.Uc_dateTo.Location = New System.Drawing.Point(183, 34)
        Me.Uc_dateTo.Name = "Uc_dateTo"
        Me.Uc_dateTo.Size = New System.Drawing.Size(170, 21)
        Me.Uc_dateTo.TabIndex = 75
        '
        'Uc_label1
        '
        Me.Uc_label1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label1.iAddition_SQL = Nothing
        Me.Uc_label1.iAdditional = Nothing
        Me.Uc_label1.idsc = Nothing
        Me.Uc_label1.iIsEnabled = True
        Me.Uc_label1.iIsForSearch = False
        Me.Uc_label1.iLabel = "Source"
        Me.Uc_label1.iLabel_width = 65
        Me.Uc_label1.iSQL_Parameter_ID = 0
        Me.Uc_label1.iText = "Reciept From Production"
        Me.Uc_label1.Location = New System.Drawing.Point(7, 7)
        Me.Uc_label1.Name = "Uc_label1"
        Me.Uc_label1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label1.Size = New System.Drawing.Size(299, 21)
        Me.Uc_label1.TabIndex = 92
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.uc_lbl_series)
        Me.Panel2.Controls.Add(Me.uc_fromWHse)
        Me.Panel2.Controls.Add(Me.Uc_inputbox1)
        Me.Panel2.Controls.Add(Me.uc_null)
        Me.Panel2.Controls.Add(Me.Uc_docnum)
        Me.Panel2.Controls.Add(Me.Uc_inputbox3)
        Me.Panel2.Controls.Add(Me.Uc_inputbox4)
        Me.Panel2.Controls.Add(Me.dgv_CheckSelection)
        Me.Panel2.Controls.Add(Me.uc_ToWHse)
        Me.Panel2.Controls.Add(Me.uc_lbl_releasedBy)
        Me.Panel2.Controls.Add(Me.uc_fromWHse_lbl)
        Me.Panel2.Controls.Add(Me.uc_receivedBy)
        Me.Panel2.Controls.Add(Me.uc_ToWHse_lbl)
        Me.Panel2.Controls.Add(Me.uc_palletizer)
        Me.Panel2.Controls.Add(Me.Uc_date3)
        Me.Panel2.Controls.Add(Me.Uc_date1)
        Me.Panel2.Controls.Add(Me.Uc_inputbox2)
        Me.Panel2.Controls.Add(Me.docnum_container_desc)
        Me.Panel2.Controls.Add(Me.Uc_inputbox5)
        Me.Panel2.Controls.Add(Me.docnum_container)
        Me.Panel2.Controls.Add(Me.Uc_inputbox6)
        Me.Panel2.Location = New System.Drawing.Point(452, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(923, 573)
        Me.Panel2.TabIndex = 101
        '
        'Palleting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1387, 624)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Palleting"
        Me.Text = "Palleting"
        CType(Me.dgv_CheckSelection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Uc_inputbox1 As uc_inputbox
    Friend WithEvents uc_ToWHse As uc_inputbox
    Friend WithEvents uc_fromWHse As uc_inputbox
    Friend WithEvents uc_ToWHse_lbl As uc_label
    Friend WithEvents uc_fromWHse_lbl As uc_label
    Friend WithEvents Uc_inputbox6 As uc_inputbox
    Friend WithEvents Uc_inputbox5 As uc_inputbox
    Friend WithEvents Uc_inputbox2 As uc_inputbox
    Friend WithEvents Uc_date3 As uc_date
    Friend WithEvents Uc_inputbox4 As uc_inputbox
    Friend WithEvents Uc_docnum As uc_inputbox
    Friend WithEvents docnum_container As TextBox
    Friend WithEvents docnum_container_desc As TextBox
    Friend WithEvents dgv_CheckSelection As DataGridView
    Friend WithEvents uc_null As uc_label
    Friend WithEvents uc_receivedBy As uc_label
    Friend WithEvents uc_lbl_releasedBy As uc_label
    Friend WithEvents uc_palletizer As uc_label
    Friend WithEvents Uc_inputbox3 As uc_inputbox
    Friend WithEvents Button2 As Button
    Friend WithEvents Uc_date1 As uc_date
    Friend WithEvents Panel2 As Panel
    Friend WithEvents uc_lbl_series As uc_label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_fetch As Button
    Friend WithEvents Uc_dateFrom As uc_date
    Friend WithEvents Uc_dateTo As uc_date
    Friend WithEvents Uc_label1 As uc_label
End Class
