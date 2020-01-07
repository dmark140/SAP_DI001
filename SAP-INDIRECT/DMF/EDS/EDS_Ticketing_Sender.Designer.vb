<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EDS_Ticketing_Sender
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
        Me.msg = New System.Windows.Forms.RichTextBox()
        Me.btn_zoom = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.conatiner_attach = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbl_attachedFile = New System.Windows.Forms.Label()
        Me.pic_attched = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.uc_appointedTo_lbl = New IpicIndirect.uc_label()
        Me.uc_lbl = New IpicIndirect.uc_label()
        Me.uc_status = New IpicIndirect.uc_inputbox()
        Me.uc_appointedTo = New IpicIndirect.uc_inputbox()
        Me.uc_machine_lbl = New IpicIndirect.uc_label()
        Me.uc_mainTimeReq = New IpicIndirect.uc_time()
        Me.uc_mainDateReq = New IpicIndirect.uc_date()
        Me.uc_station_lbl = New IpicIndirect.uc_label()
        Me.uc_warehouse_lbl = New IpicIndirect.uc_label()
        Me.uc_appointedTo2lbl = New IpicIndirect.uc_label()
        Me.uc_stations = New IpicIndirect.uc_inputbox()
        Me.uc_warehouse = New IpicIndirect.uc_inputbox()
        Me.uc_machine = New IpicIndirect.uc_inputbox()
        Me.uc_req_by = New IpicIndirect.uc_inputbox()
        Me.Uc_label1 = New IpicIndirect.uc_label()
        Me.uc_subject = New IpicIndirect.uc_inputbox()
        Me.uc_req_by_lbl = New IpicIndirect.uc_label()
        Me.conatiner_attach.SuspendLayout()
        CType(Me.pic_attched, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msg
        '
        Me.msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.msg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.msg.Location = New System.Drawing.Point(7, 136)
        Me.msg.Name = "msg"
        Me.msg.Size = New System.Drawing.Size(673, 536)
        Me.msg.TabIndex = 2
        Me.msg.Text = ""
        '
        'btn_zoom
        '
        Me.btn_zoom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_zoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_zoom.FlatAppearance.BorderSize = 0
        Me.btn_zoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_zoom.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_zoom.ForeColor = System.Drawing.Color.White
        Me.btn_zoom.Location = New System.Drawing.Point(616, 108)
        Me.btn_zoom.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_zoom.Name = "btn_zoom"
        Me.btn_zoom.Size = New System.Drawing.Size(63, 20)
        Me.btn_zoom.TabIndex = 127
        Me.btn_zoom.Tag = "1"
        Me.btn_zoom.Text = "&SEND"
        Me.btn_zoom.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_zoom.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_zoom.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(466, 681)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 30)
        Me.Button1.TabIndex = 128
        Me.Button1.Tag = "1"
        Me.Button1.Text = "Attach File"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'conatiner_attach
        '
        Me.conatiner_attach.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.conatiner_attach.BackColor = System.Drawing.SystemColors.Control
        Me.conatiner_attach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.conatiner_attach.Controls.Add(Me.Button2)
        Me.conatiner_attach.Controls.Add(Me.lbl_attachedFile)
        Me.conatiner_attach.Controls.Add(Me.pic_attched)
        Me.conatiner_attach.Location = New System.Drawing.Point(7, 681)
        Me.conatiner_attach.Name = "conatiner_attach"
        Me.conatiner_attach.Size = New System.Drawing.Size(454, 30)
        Me.conatiner_attach.TabIndex = 129
        Me.conatiner_attach.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(435, -3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(20, 21)
        Me.Button2.TabIndex = 126
        Me.Button2.Tag = "1"
        Me.Button2.Text = "+"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'lbl_attachedFile
        '
        Me.lbl_attachedFile.AutoSize = True
        Me.lbl_attachedFile.Location = New System.Drawing.Point(41, 14)
        Me.lbl_attachedFile.Name = "lbl_attachedFile"
        Me.lbl_attachedFile.Size = New System.Drawing.Size(39, 13)
        Me.lbl_attachedFile.TabIndex = 123
        Me.lbl_attachedFile.Text = "Label4"
        '
        'pic_attched
        '
        Me.pic_attched.ErrorImage = Global.IpicIndirect.My.Resources.Resources.ms_excel
        Me.pic_attched.Image = Global.IpicIndirect.My.Resources.Resources.ms_word
        Me.pic_attched.InitialImage = Global.IpicIndirect.My.Resources.Resources.icons8_image_100
        Me.pic_attched.Location = New System.Drawing.Point(5, 4)
        Me.pic_attched.Name = "pic_attched"
        Me.pic_attched.Size = New System.Drawing.Size(30, 28)
        Me.pic_attched.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_attched.TabIndex = 123
        Me.pic_attched.TabStop = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(584, 681)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 30)
        Me.Button3.TabIndex = 128
        Me.Button3.Tag = "1"
        Me.Button3.Text = "&Cancel"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(346, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(26, 20)
        Me.TextBox1.TabIndex = 133
        Me.TextBox1.Text = "O"
        Me.TextBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(344, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'uc_appointedTo_lbl
        '
        Me.uc_appointedTo_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_appointedTo_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_appointedTo_lbl.iAddition_SQL = Nothing
        Me.uc_appointedTo_lbl.iAdditional = Nothing
        Me.uc_appointedTo_lbl.idsc = Me.Label1
        Me.uc_appointedTo_lbl.iIsEnabled = True
        Me.uc_appointedTo_lbl.iIsForSearch = False
        Me.uc_appointedTo_lbl.iLabel = ""
        Me.uc_appointedTo_lbl.iLabel_width = 5
        Me.uc_appointedTo_lbl.iSQL_Parameter_ID = 0
        Me.uc_appointedTo_lbl.iText = ""
        Me.uc_appointedTo_lbl.Location = New System.Drawing.Point(532, 9)
        Me.uc_appointedTo_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_appointedTo_lbl.Name = "uc_appointedTo_lbl"
        Me.uc_appointedTo_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_appointedTo_lbl.Size = New System.Drawing.Size(147, 21)
        Me.uc_appointedTo_lbl.TabIndex = 143
        '
        'uc_lbl
        '
        Me.uc_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_lbl.iAddition_SQL = Nothing
        Me.uc_lbl.iAdditional = Nothing
        Me.uc_lbl.idsc = Me.Label1
        Me.uc_lbl.iIsEnabled = True
        Me.uc_lbl.iIsForSearch = False
        Me.uc_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_lbl.iLabel_width = 5
        Me.uc_lbl.iSQL_Parameter_ID = 0
        Me.uc_lbl.iText = "OPEN"
        Me.uc_lbl.Location = New System.Drawing.Point(532, 68)
        Me.uc_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_lbl.Name = "uc_lbl"
        Me.uc_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_lbl.Size = New System.Drawing.Size(147, 21)
        Me.uc_lbl.TabIndex = 142
        '
        'uc_status
        '
        Me.uc_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_status.BackColor = System.Drawing.Color.Transparent
        Me.uc_status.iAddition_SQL = Nothing
        Me.uc_status.iAdditional = Nothing
        Me.uc_status.iArrow_Visible = False
        Me.uc_status.iCanFindLabel_SQLIDx = 0
        Me.uc_status.iCharacterLimit = 0
        Me.uc_status.idsc = Me.uc_lbl
        Me.uc_status.iForm = Me
        Me.uc_status.iIsDropDown = False
        Me.uc_status.iIsEnabled = False
        Me.uc_status.iIsForSearch = False
        Me.uc_status.iIsID = False
        Me.uc_status.iIsInnerShow = True
        Me.uc_status.iLabel = "Station"
        Me.uc_status.iLabel_width = 83
        Me.uc_status.isForFind = False
        Me.uc_status.iSQL_Parameter_ID = 33
        Me.uc_status.iText = "O"
        Me.uc_status.iTextBox_ = Me.TextBox1
        Me.uc_status.iTextBox_Sel_COL_ID = 0
        Me.uc_status.iTitle = "O"
        Me.uc_status.Location = New System.Drawing.Point(409, 68)
        Me.uc_status.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_status.Name = "uc_status"
        Me.uc_status.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_status.Size = New System.Drawing.Size(125, 24)
        Me.uc_status.TabIndex = 141
        '
        'uc_appointedTo
        '
        Me.uc_appointedTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_appointedTo.BackColor = System.Drawing.Color.Transparent
        Me.uc_appointedTo.iAddition_SQL = Nothing
        Me.uc_appointedTo.iAdditional = Nothing
        Me.uc_appointedTo.iArrow_Visible = False
        Me.uc_appointedTo.iCanFindLabel_SQLIDx = 0
        Me.uc_appointedTo.iCharacterLimit = 0
        Me.uc_appointedTo.idsc = Me.uc_machine_lbl
        Me.uc_appointedTo.iForm = Me
        Me.uc_appointedTo.iIsDropDown = False
        Me.uc_appointedTo.iIsEnabled = False
        Me.uc_appointedTo.iIsForSearch = False
        Me.uc_appointedTo.iIsID = False
        Me.uc_appointedTo.iIsInnerShow = False
        Me.uc_appointedTo.iLabel = "Appointed To"
        Me.uc_appointedTo.iLabel_width = 83
        Me.uc_appointedTo.isForFind = False
        Me.uc_appointedTo.iSQL_Parameter_ID = 0
        Me.uc_appointedTo.iText = ""
        Me.uc_appointedTo.iTextBox_ = Me.TextBox1
        Me.uc_appointedTo.iTextBox_Sel_COL_ID = 0
        Me.uc_appointedTo.iTitle = ""
        Me.uc_appointedTo.Location = New System.Drawing.Point(409, 9)
        Me.uc_appointedTo.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_appointedTo.Name = "uc_appointedTo"
        Me.uc_appointedTo.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_appointedTo.Size = New System.Drawing.Size(125, 24)
        Me.uc_appointedTo.TabIndex = 140
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
        Me.uc_machine_lbl.Location = New System.Drawing.Point(162, 79)
        Me.uc_machine_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_machine_lbl.Name = "uc_machine_lbl"
        Me.uc_machine_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_machine_lbl.Size = New System.Drawing.Size(176, 21)
        Me.uc_machine_lbl.TabIndex = 135
        '
        'uc_mainTimeReq
        '
        Me.uc_mainTimeReq.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_mainTimeReq.BackColor = System.Drawing.Color.Transparent
        Me.uc_mainTimeReq.iDate = New Date(2020, 4, 30, 14, 19, 59, 846)
        Me.uc_mainTimeReq.idsc = Me.Label1
        Me.uc_mainTimeReq.iForm = Me
        Me.uc_mainTimeReq.iIsForSearch = False
        Me.uc_mainTimeReq.iLabel = "Production Order Selection"
        Me.uc_mainTimeReq.iLabel_width = 5
        Me.uc_mainTimeReq.IsEnabled = False
        Me.uc_mainTimeReq.isForFind = False
        Me.uc_mainTimeReq.iSQL_Parameter_ID = 0
        Me.uc_mainTimeReq.Location = New System.Drawing.Point(619, 37)
        Me.uc_mainTimeReq.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_mainTimeReq.Name = "uc_mainTimeReq"
        Me.uc_mainTimeReq.Size = New System.Drawing.Size(61, 23)
        Me.uc_mainTimeReq.TabIndex = 138
        '
        'uc_mainDateReq
        '
        Me.uc_mainDateReq.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_mainDateReq.BackColor = System.Drawing.Color.Transparent
        Me.uc_mainDateReq.iDate = New Date(2020, 4, 30, 14, 19, 59, 852)
        Me.uc_mainDateReq.idsc = Me.Label1
        Me.uc_mainDateReq.iForm = Me
        Me.uc_mainDateReq.iIsForSearch = False
        Me.uc_mainDateReq.iLabel = "Posted Date"
        Me.uc_mainDateReq.iLabel_width = 100
        Me.uc_mainDateReq.IsEnabled = False
        Me.uc_mainDateReq.isForFind = False
        Me.uc_mainDateReq.iSQL_Parameter_ID = 0
        Me.uc_mainDateReq.Location = New System.Drawing.Point(409, 37)
        Me.uc_mainDateReq.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_mainDateReq.Name = "uc_mainDateReq"
        Me.uc_mainDateReq.Size = New System.Drawing.Size(209, 23)
        Me.uc_mainDateReq.TabIndex = 137
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
        Me.uc_station_lbl.Location = New System.Drawing.Point(162, 32)
        Me.uc_station_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_station_lbl.Name = "uc_station_lbl"
        Me.uc_station_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_station_lbl.Size = New System.Drawing.Size(176, 21)
        Me.uc_station_lbl.TabIndex = 136
        '
        'uc_warehouse_lbl
        '
        Me.uc_warehouse_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_warehouse_lbl.iAddition_SQL = Nothing
        Me.uc_warehouse_lbl.iAdditional = Nothing
        Me.uc_warehouse_lbl.idsc = Nothing
        Me.uc_warehouse_lbl.iIsEnabled = True
        Me.uc_warehouse_lbl.iIsForSearch = False
        Me.uc_warehouse_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_warehouse_lbl.iLabel_width = 5
        Me.uc_warehouse_lbl.iSQL_Parameter_ID = 0
        Me.uc_warehouse_lbl.iText = ""
        Me.uc_warehouse_lbl.Location = New System.Drawing.Point(162, 55)
        Me.uc_warehouse_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_warehouse_lbl.Name = "uc_warehouse_lbl"
        Me.uc_warehouse_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_warehouse_lbl.Size = New System.Drawing.Size(176, 21)
        Me.uc_warehouse_lbl.TabIndex = 136
        '
        'uc_appointedTo2lbl
        '
        Me.uc_appointedTo2lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_appointedTo2lbl.iAddition_SQL = Nothing
        Me.uc_appointedTo2lbl.iAdditional = Nothing
        Me.uc_appointedTo2lbl.idsc = Nothing
        Me.uc_appointedTo2lbl.iIsEnabled = True
        Me.uc_appointedTo2lbl.iIsForSearch = False
        Me.uc_appointedTo2lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_appointedTo2lbl.iLabel_width = 5
        Me.uc_appointedTo2lbl.iSQL_Parameter_ID = 0
        Me.uc_appointedTo2lbl.iText = ""
        Me.uc_appointedTo2lbl.Location = New System.Drawing.Point(349, 27)
        Me.uc_appointedTo2lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_appointedTo2lbl.Name = "uc_appointedTo2lbl"
        Me.uc_appointedTo2lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_appointedTo2lbl.Size = New System.Drawing.Size(26, 21)
        Me.uc_appointedTo2lbl.TabIndex = 134
        Me.uc_appointedTo2lbl.Visible = False
        '
        'uc_stations
        '
        Me.uc_stations.BackColor = System.Drawing.Color.Transparent
        Me.uc_stations.iAddition_SQL = Nothing
        Me.uc_stations.iAdditional = Nothing
        Me.uc_stations.iArrow_Visible = True
        Me.uc_stations.iCanFindLabel_SQLIDx = 0
        Me.uc_stations.iCharacterLimit = 0
        Me.uc_stations.idsc = Me.uc_station_lbl
        Me.uc_stations.iForm = Me
        Me.uc_stations.iIsDropDown = False
        Me.uc_stations.iIsEnabled = False
        Me.uc_stations.iIsForSearch = True
        Me.uc_stations.iIsID = True
        Me.uc_stations.iIsInnerShow = True
        Me.uc_stations.iLabel = "Station"
        Me.uc_stations.iLabel_width = 100
        Me.uc_stations.isForFind = False
        Me.uc_stations.iSQL_Parameter_ID = 32
        Me.uc_stations.iText = ""
        Me.uc_stations.iTextBox_ = Me.TextBox1
        Me.uc_stations.iTextBox_Sel_COL_ID = 0
        Me.uc_stations.iTitle = ""
        Me.uc_stations.Location = New System.Drawing.Point(13, 32)
        Me.uc_stations.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_stations.Name = "uc_stations"
        Me.uc_stations.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_stations.Size = New System.Drawing.Size(149, 24)
        Me.uc_stations.TabIndex = 132
        '
        'uc_warehouse
        '
        Me.uc_warehouse.BackColor = System.Drawing.Color.Transparent
        Me.uc_warehouse.iAddition_SQL = Nothing
        Me.uc_warehouse.iAdditional = Nothing
        Me.uc_warehouse.iArrow_Visible = True
        Me.uc_warehouse.iCanFindLabel_SQLIDx = 0
        Me.uc_warehouse.iCharacterLimit = 0
        Me.uc_warehouse.idsc = Me.uc_warehouse_lbl
        Me.uc_warehouse.iForm = Me
        Me.uc_warehouse.iIsDropDown = False
        Me.uc_warehouse.iIsEnabled = False
        Me.uc_warehouse.iIsForSearch = True
        Me.uc_warehouse.iIsID = True
        Me.uc_warehouse.iIsInnerShow = True
        Me.uc_warehouse.iLabel = "Warehouse"
        Me.uc_warehouse.iLabel_width = 100
        Me.uc_warehouse.isForFind = False
        Me.uc_warehouse.iSQL_Parameter_ID = 26
        Me.uc_warehouse.iText = ""
        Me.uc_warehouse.iTextBox_ = Me.TextBox1
        Me.uc_warehouse.iTextBox_Sel_COL_ID = 0
        Me.uc_warehouse.iTitle = ""
        Me.uc_warehouse.Location = New System.Drawing.Point(13, 55)
        Me.uc_warehouse.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_warehouse.Name = "uc_warehouse"
        Me.uc_warehouse.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_warehouse.Size = New System.Drawing.Size(149, 24)
        Me.uc_warehouse.TabIndex = 132
        '
        'uc_machine
        '
        Me.uc_machine.BackColor = System.Drawing.Color.Transparent
        Me.uc_machine.iAddition_SQL = Nothing
        Me.uc_machine.iAdditional = Nothing
        Me.uc_machine.iArrow_Visible = True
        Me.uc_machine.iCanFindLabel_SQLIDx = 0
        Me.uc_machine.iCharacterLimit = 0
        Me.uc_machine.idsc = Me.uc_machine_lbl
        Me.uc_machine.iForm = Me
        Me.uc_machine.iIsDropDown = False
        Me.uc_machine.iIsEnabled = False
        Me.uc_machine.iIsForSearch = True
        Me.uc_machine.iIsID = True
        Me.uc_machine.iIsInnerShow = True
        Me.uc_machine.iLabel = "Machine"
        Me.uc_machine.iLabel_width = 100
        Me.uc_machine.isForFind = False
        Me.uc_machine.iSQL_Parameter_ID = 29
        Me.uc_machine.iText = ""
        Me.uc_machine.iTextBox_ = Me.TextBox1
        Me.uc_machine.iTextBox_Sel_COL_ID = 0
        Me.uc_machine.iTitle = ""
        Me.uc_machine.Location = New System.Drawing.Point(13, 79)
        Me.uc_machine.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_machine.Name = "uc_machine"
        Me.uc_machine.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_machine.Size = New System.Drawing.Size(149, 24)
        Me.uc_machine.TabIndex = 131
        '
        'uc_req_by
        '
        Me.uc_req_by.BackColor = System.Drawing.Color.Transparent
        Me.uc_req_by.iAddition_SQL = Nothing
        Me.uc_req_by.iAdditional = Nothing
        Me.uc_req_by.iArrow_Visible = False
        Me.uc_req_by.iCanFindLabel_SQLIDx = 0
        Me.uc_req_by.iCharacterLimit = 0
        Me.uc_req_by.idsc = Me.uc_req_by_lbl
        Me.uc_req_by.iForm = Me
        Me.uc_req_by.iIsDropDown = False
        Me.uc_req_by.iIsEnabled = False
        Me.uc_req_by.iIsForSearch = False
        Me.uc_req_by.iIsID = False
        Me.uc_req_by.iIsInnerShow = False
        Me.uc_req_by.iLabel = "Requested By"
        Me.uc_req_by.iLabel_width = 100
        Me.uc_req_by.isForFind = False
        Me.uc_req_by.iSQL_Parameter_ID = 0
        Me.uc_req_by.iText = ""
        Me.uc_req_by.iTextBox_ = Me.TextBox1
        Me.uc_req_by.iTextBox_Sel_COL_ID = 0
        Me.uc_req_by.iTitle = ""
        Me.uc_req_by.Location = New System.Drawing.Point(12, 7)
        Me.uc_req_by.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_req_by.Name = "uc_req_by"
        Me.uc_req_by.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_req_by.Size = New System.Drawing.Size(150, 24)
        Me.uc_req_by.TabIndex = 130
        '
        'Uc_label1
        '
        Me.Uc_label1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label1.iAddition_SQL = Nothing
        Me.Uc_label1.iAdditional = Nothing
        Me.Uc_label1.idsc = Nothing
        Me.Uc_label1.iIsEnabled = True
        Me.Uc_label1.iIsForSearch = False
        Me.Uc_label1.iLabel = "Edit iLbl to edit me"
        Me.Uc_label1.iLabel_width = 0
        Me.Uc_label1.iSQL_Parameter_ID = 0
        Me.Uc_label1.iText = ""
        Me.Uc_label1.Location = New System.Drawing.Point(12, 420)
        Me.Uc_label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Uc_label1.Name = "Uc_label1"
        Me.Uc_label1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label1.Size = New System.Drawing.Size(23, 30)
        Me.Uc_label1.TabIndex = 1
        Me.Uc_label1.Visible = False
        '
        'uc_subject
        '
        Me.uc_subject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_subject.BackColor = System.Drawing.Color.Transparent
        Me.uc_subject.iAddition_SQL = Nothing
        Me.uc_subject.iAdditional = Nothing
        Me.uc_subject.iArrow_Visible = False
        Me.uc_subject.iCanFindLabel_SQLIDx = 0
        Me.uc_subject.iCharacterLimit = 149
        Me.uc_subject.idsc = Nothing
        Me.uc_subject.iForm = Me
        Me.uc_subject.iIsDropDown = False
        Me.uc_subject.iIsEnabled = True
        Me.uc_subject.iIsForSearch = False
        Me.uc_subject.iIsID = False
        Me.uc_subject.iIsInnerShow = False
        Me.uc_subject.iLabel = "Subject"
        Me.uc_subject.iLabel_width = 108
        Me.uc_subject.isForFind = False
        Me.uc_subject.iSQL_Parameter_ID = 0
        Me.uc_subject.iText = ""
        Me.uc_subject.iTextBox_ = Nothing
        Me.uc_subject.iTextBox_Sel_COL_ID = 0
        Me.uc_subject.iTitle = ""
        Me.uc_subject.Location = New System.Drawing.Point(7, 108)
        Me.uc_subject.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_subject.Name = "uc_subject"
        Me.uc_subject.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_subject.Size = New System.Drawing.Size(604, 21)
        Me.uc_subject.TabIndex = 0
        '
        'uc_req_by_lbl
        '
        Me.uc_req_by_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_req_by_lbl.iAddition_SQL = Nothing
        Me.uc_req_by_lbl.iAdditional = Nothing
        Me.uc_req_by_lbl.idsc = Nothing
        Me.uc_req_by_lbl.iIsEnabled = True
        Me.uc_req_by_lbl.iIsForSearch = False
        Me.uc_req_by_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_req_by_lbl.iLabel_width = 5
        Me.uc_req_by_lbl.iSQL_Parameter_ID = 0
        Me.uc_req_by_lbl.iText = ""
        Me.uc_req_by_lbl.Location = New System.Drawing.Point(162, 7)
        Me.uc_req_by_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_req_by_lbl.Name = "uc_req_by_lbl"
        Me.uc_req_by_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_req_by_lbl.Size = New System.Drawing.Size(176, 21)
        Me.uc_req_by_lbl.TabIndex = 144
        '
        'EDS_Ticketing_Sender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 723)
        Me.Controls.Add(Me.uc_req_by_lbl)
        Me.Controls.Add(Me.uc_appointedTo_lbl)
        Me.Controls.Add(Me.uc_lbl)
        Me.Controls.Add(Me.uc_status)
        Me.Controls.Add(Me.uc_appointedTo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.uc_mainTimeReq)
        Me.Controls.Add(Me.uc_mainDateReq)
        Me.Controls.Add(Me.uc_station_lbl)
        Me.Controls.Add(Me.uc_warehouse_lbl)
        Me.Controls.Add(Me.uc_machine_lbl)
        Me.Controls.Add(Me.uc_appointedTo2lbl)
        Me.Controls.Add(Me.uc_stations)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.uc_warehouse)
        Me.Controls.Add(Me.uc_machine)
        Me.Controls.Add(Me.uc_req_by)
        Me.Controls.Add(Me.conatiner_attach)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_zoom)
        Me.Controls.Add(Me.msg)
        Me.Controls.Add(Me.Uc_label1)
        Me.Controls.Add(Me.uc_subject)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EDS_Ticketing_Sender"
        Me.Text = "Ticketing_Sender"
        Me.conatiner_attach.ResumeLayout(False)
        Me.conatiner_attach.PerformLayout()
        CType(Me.pic_attched, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Uc_label1 As uc_label
    Friend WithEvents msg As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_zoom As Button
    Friend WithEvents conatiner_attach As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents lbl_attachedFile As Label
    Friend WithEvents pic_attched As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents uc_warehouse As uc_inputbox
    Friend WithEvents uc_machine As uc_inputbox
    Friend WithEvents uc_req_by As uc_inputbox
    Friend WithEvents uc_warehouse_lbl As uc_label
    Friend WithEvents uc_machine_lbl As uc_label
    Friend WithEvents uc_appointedTo2lbl As uc_label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents uc_mainTimeReq As uc_time
    Friend WithEvents uc_mainDateReq As uc_date
    Friend WithEvents uc_station_lbl As uc_label
    Friend WithEvents uc_stations As uc_inputbox
    Friend WithEvents uc_appointedTo As uc_inputbox
    Friend WithEvents uc_lbl As uc_label
    Friend WithEvents uc_status As uc_inputbox
    Friend WithEvents uc_subject As uc_inputbox
    Friend WithEvents uc_appointedTo_lbl As uc_label
    Friend WithEvents uc_req_by_lbl As uc_label
End Class
