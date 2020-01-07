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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.msg = New System.Windows.Forms.RichTextBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.conatiner_attach = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbl_attachedFile = New System.Windows.Forms.Label()
        Me.pic_attched = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.uc_stations_text = New System.Windows.Forms.TextBox()
        Me.uc_subParts_txt = New System.Windows.Forms.TextBox()
        Me.uc_machine_text = New System.Windows.Forms.TextBox()
        Me.uc_area_text = New System.Windows.Forms.TextBox()
        Me.uc_typeofTrouble_text = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txt_null = New System.Windows.Forms.TextBox()
        Me.uc_statusofRep_txt = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Uc_lines1 = New IpicIndirect.uc_lines()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.uc_General_remarks = New IpicIndirect.uc_label()
        Me.uc_Geberal_Findings = New IpicIndirect.uc_label()
        Me.uc_General_Action = New IpicIndirect.uc_label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.uc_maint_Text = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.dgv_x = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cms_action = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.uc_notedBy_lbl = New IpicIndirect.uc_label()
        Me.uc_req_by_lbl = New IpicIndirect.uc_label()
        Me.uc_appointedTo_lbl = New IpicIndirect.uc_label()
        Me.uc_maint_lbl = New IpicIndirect.uc_label()
        Me.uc_maint = New IpicIndirect.uc_inputbox()
        Me.Uc_label2 = New IpicIndirect.uc_label()
        Me.Uc_inputbox1 = New IpicIndirect.uc_inputbox()
        Me.uc_Parts = New IpicIndirect.uc_inputbox()
        Me.uc_statusofRep_lbl = New IpicIndirect.uc_label()
        Me.uc_StatusOfRepair = New IpicIndirect.uc_inputbox()
        Me.uc_lbl = New IpicIndirect.uc_label()
        Me.txt_status = New IpicIndirect.uc_inputbox()
        Me.uc_controlUsed = New IpicIndirect.uc_label()
        Me.uc_posibleHazard = New IpicIndirect.uc_label()
        Me.uc_riskLevel = New IpicIndirect.uc_label()
        Me.uc_severity_lbl = New IpicIndirect.uc_label()
        Me.uc_Likelihood = New IpicIndirect.uc_inputbox()
        Me.uc_Likelihood_lbl = New IpicIndirect.uc_label()
        Me.uc_severity = New IpicIndirect.uc_inputbox()
        Me.Uc_lines2 = New IpicIndirect.uc_lines()
        Me.uc_null = New IpicIndirect.uc_label()
        Me.uc_notedBy = New IpicIndirect.uc_inputbox()
        Me.uc_IDENTITY = New IpicIndirect.uc_label()
        Me.uc_EndTime = New IpicIndirect.uc_time()
        Me.uc_StartTime = New IpicIndirect.uc_time()
        Me.uc_EndDate = New IpicIndirect.uc_date()
        Me.uc_StartDate = New IpicIndirect.uc_date()
        Me.uc_appointedTo = New IpicIndirect.uc_inputbox()
        Me.uc_machine_lbl = New IpicIndirect.uc_label()
        Me.uc_requestedTime = New IpicIndirect.uc_time()
        Me.uc_requestedDate = New IpicIndirect.uc_date()
        Me.uc_typeofTrouble_lbl = New IpicIndirect.uc_label()
        Me.uc_area_lbl = New IpicIndirect.uc_label()
        Me.uc_station_lbl = New IpicIndirect.uc_label()
        Me.uc_verifiedBy_lbl = New IpicIndirect.uc_label()
        Me.uc_subParts_lbl = New IpicIndirect.uc_label()
        Me.uc_appointedTo2lbl = New IpicIndirect.uc_label()
        Me.uc_TypeOfTrouble = New IpicIndirect.uc_inputbox()
        Me.uc_AreaOfConcern = New IpicIndirect.uc_inputbox()
        Me.uc_Station = New IpicIndirect.uc_inputbox()
        Me.uc_Machine = New IpicIndirect.uc_inputbox()
        Me.uc_requestedBy = New IpicIndirect.uc_inputbox()
        Me.Uc_label1 = New IpicIndirect.uc_label()
        Me.Uc_lines3 = New IpicIndirect.uc_lines()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.conatiner_attach.SuspendLayout()
        CType(Me.pic_attched, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_x, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_action.SuspendLayout()
        Me.SuspendLayout()
        '
        'msg
        '
        Me.msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.msg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.msg.Location = New System.Drawing.Point(6, 28)
        Me.msg.Name = "msg"
        Me.msg.Size = New System.Drawing.Size(570, 86)
        Me.msg.TabIndex = 2
        Me.msg.Text = ""
        '
        'btn_ok
        '
        Me.btn_ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(896, 463)
        Me.btn_ok.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(63, 27)
        Me.btn_ok.TabIndex = 127
        Me.btn_ok.Tag = "1"
        Me.btn_ok.Text = "&Send"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(568, 463)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 27)
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
        Me.conatiner_attach.Location = New System.Drawing.Point(15, 463)
        Me.conatiner_attach.Name = "conatiner_attach"
        Me.conatiner_attach.Size = New System.Drawing.Size(556, 27)
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
        Me.Button2.Location = New System.Drawing.Point(531, -4)
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
        Me.lbl_attachedFile.Location = New System.Drawing.Point(41, 11)
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
        Me.Button3.Location = New System.Drawing.Point(797, 463)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 27)
        Me.Button3.TabIndex = 128
        Me.Button3.Tag = "1"
        Me.Button3.Text = "&Cancel"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(403, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(26, 20)
        Me.TextBox1.TabIndex = 133
        Me.TextBox1.Text = " "
        Me.TextBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(356, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'uc_stations_text
        '
        Me.uc_stations_text.Location = New System.Drawing.Point(369, 220)
        Me.uc_stations_text.Name = "uc_stations_text"
        Me.uc_stations_text.Size = New System.Drawing.Size(26, 20)
        Me.uc_stations_text.TabIndex = 133
        Me.uc_stations_text.Text = " "
        Me.uc_stations_text.Visible = False
        '
        'uc_subParts_txt
        '
        Me.uc_subParts_txt.Location = New System.Drawing.Point(369, 269)
        Me.uc_subParts_txt.Name = "uc_subParts_txt"
        Me.uc_subParts_txt.Size = New System.Drawing.Size(26, 20)
        Me.uc_subParts_txt.TabIndex = 133
        Me.uc_subParts_txt.Text = " "
        Me.uc_subParts_txt.Visible = False
        '
        'uc_machine_text
        '
        Me.uc_machine_text.Location = New System.Drawing.Point(369, 245)
        Me.uc_machine_text.Name = "uc_machine_text"
        Me.uc_machine_text.Size = New System.Drawing.Size(26, 20)
        Me.uc_machine_text.TabIndex = 133
        Me.uc_machine_text.Text = " "
        Me.uc_machine_text.Visible = False
        '
        'uc_area_text
        '
        Me.uc_area_text.Location = New System.Drawing.Point(369, 160)
        Me.uc_area_text.Name = "uc_area_text"
        Me.uc_area_text.Size = New System.Drawing.Size(26, 20)
        Me.uc_area_text.TabIndex = 133
        Me.uc_area_text.Text = " "
        Me.uc_area_text.Visible = False
        '
        'uc_typeofTrouble_text
        '
        Me.uc_typeofTrouble_text.Location = New System.Drawing.Point(369, 184)
        Me.uc_typeofTrouble_text.Name = "uc_typeofTrouble_text"
        Me.uc_typeofTrouble_text.Size = New System.Drawing.Size(26, 20)
        Me.uc_typeofTrouble_text.TabIndex = 133
        Me.uc_typeofTrouble_text.Text = " "
        Me.uc_typeofTrouble_text.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(595, 12)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(26, 20)
        Me.TextBox2.TabIndex = 155
        Me.TextBox2.Text = " "
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(403, 5)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(26, 20)
        Me.TextBox3.TabIndex = 160
        Me.TextBox3.Text = " "
        Me.TextBox3.Visible = False
        '
        'txt_null
        '
        Me.txt_null.Location = New System.Drawing.Point(491, 27)
        Me.txt_null.Name = "txt_null"
        Me.txt_null.Size = New System.Drawing.Size(26, 20)
        Me.txt_null.TabIndex = 162
        Me.txt_null.Text = " "
        Me.txt_null.Visible = False
        '
        'uc_statusofRep_txt
        '
        Me.uc_statusofRep_txt.Location = New System.Drawing.Point(535, 165)
        Me.uc_statusofRep_txt.Name = "uc_statusofRep_txt"
        Me.uc_statusofRep_txt.Size = New System.Drawing.Size(26, 20)
        Me.uc_statusofRep_txt.TabIndex = 160
        Me.uc_statusofRep_txt.Text = " "
        Me.uc_statusofRep_txt.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(15, 308)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(590, 146)
        Me.TabControl1.TabIndex = 165
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.msg)
        Me.TabPage1.Controls.Add(Me.Uc_lines1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(582, 120)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Remarks"
        '
        'Uc_lines1
        '
        Me.Uc_lines1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_lines1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_lines1.iLabel = "Description of Trouble(140 characters Remains)"
        Me.Uc_lines1.isHighLight = False
        Me.Uc_lines1.iSize = 1
        Me.Uc_lines1.Location = New System.Drawing.Point(-12, 2)
        Me.Uc_lines1.Name = "Uc_lines1"
        Me.Uc_lines1.PetSize = IpicIndirect.PetSize.Vertical
        Me.Uc_lines1.Size = New System.Drawing.Size(343, 83)
        Me.Uc_lines1.TabIndex = 152
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.uc_General_remarks)
        Me.TabPage2.Controls.Add(Me.uc_Geberal_Findings)
        Me.TabPage2.Controls.Add(Me.uc_General_Action)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(582, 120)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "General"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'uc_General_remarks
        '
        Me.uc_General_remarks.BackColor = System.Drawing.Color.Transparent
        Me.uc_General_remarks.iAddition_SQL = Nothing
        Me.uc_General_remarks.iAdditional = Nothing
        Me.uc_General_remarks.idsc = Nothing
        Me.uc_General_remarks.iIsEnabled = True
        Me.uc_General_remarks.iIsForSearch = False
        Me.uc_General_remarks.iLabel = "Remarks"
        Me.uc_General_remarks.iLabel_width = 80
        Me.uc_General_remarks.isLabelBoldx = False
        Me.uc_General_remarks.iSQL_Parameter_ID = 0
        Me.uc_General_remarks.iText = ""
        Me.uc_General_remarks.LinkedColumn = "General_remarks"
        Me.uc_General_remarks.Location = New System.Drawing.Point(11, 11)
        Me.uc_General_remarks.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_General_remarks.Name = "uc_General_remarks"
        Me.uc_General_remarks.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_General_remarks.Size = New System.Drawing.Size(571, 21)
        Me.uc_General_remarks.TabIndex = 165
        '
        'uc_Geberal_Findings
        '
        Me.uc_Geberal_Findings.BackColor = System.Drawing.Color.Transparent
        Me.uc_Geberal_Findings.iAddition_SQL = Nothing
        Me.uc_Geberal_Findings.iAdditional = Nothing
        Me.uc_Geberal_Findings.idsc = Nothing
        Me.uc_Geberal_Findings.iIsEnabled = True
        Me.uc_Geberal_Findings.iIsForSearch = False
        Me.uc_Geberal_Findings.iLabel = "Findings"
        Me.uc_Geberal_Findings.iLabel_width = 80
        Me.uc_Geberal_Findings.isLabelBoldx = False
        Me.uc_Geberal_Findings.iSQL_Parameter_ID = 0
        Me.uc_Geberal_Findings.iText = ""
        Me.uc_Geberal_Findings.LinkedColumn = "Geberal_Findings"
        Me.uc_Geberal_Findings.Location = New System.Drawing.Point(11, 51)
        Me.uc_Geberal_Findings.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_Geberal_Findings.Name = "uc_Geberal_Findings"
        Me.uc_Geberal_Findings.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_Geberal_Findings.Size = New System.Drawing.Size(571, 21)
        Me.uc_Geberal_Findings.TabIndex = 166
        '
        'uc_General_Action
        '
        Me.uc_General_Action.BackColor = System.Drawing.Color.Transparent
        Me.uc_General_Action.iAddition_SQL = Nothing
        Me.uc_General_Action.iAdditional = Nothing
        Me.uc_General_Action.idsc = Nothing
        Me.uc_General_Action.iIsEnabled = True
        Me.uc_General_Action.iIsForSearch = False
        Me.uc_General_Action.iLabel = "Action"
        Me.uc_General_Action.iLabel_width = 80
        Me.uc_General_Action.isLabelBoldx = False
        Me.uc_General_Action.iSQL_Parameter_ID = 0
        Me.uc_General_Action.iText = ""
        Me.uc_General_Action.LinkedColumn = "General_Action"
        Me.uc_General_Action.Location = New System.Drawing.Point(11, 92)
        Me.uc_General_Action.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_General_Action.Name = "uc_General_Action"
        Me.uc_General_Action.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_General_Action.Size = New System.Drawing.Size(571, 21)
        Me.uc_General_Action.TabIndex = 167
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(579, 170)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(26, 20)
        Me.TextBox4.TabIndex = 166
        Me.TextBox4.Text = " "
        Me.TextBox4.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(595, 39)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(26, 20)
        Me.TextBox5.TabIndex = 169
        Me.TextBox5.Text = " "
        Me.TextBox5.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'uc_maint_Text
        '
        Me.uc_maint_Text.Location = New System.Drawing.Point(948, 314)
        Me.uc_maint_Text.Name = "uc_maint_Text"
        Me.uc_maint_Text.Size = New System.Drawing.Size(26, 20)
        Me.uc_maint_Text.TabIndex = 174
        Me.uc_maint_Text.Text = " "
        Me.uc_maint_Text.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 300
        '
        'dgv_x
        '
        Me.dgv_x.AllowUserToAddRows = False
        Me.dgv_x.AllowUserToDeleteRows = False
        Me.dgv_x.AllowUserToResizeColumns = False
        Me.dgv_x.AllowUserToResizeRows = False
        Me.dgv_x.BackgroundColor = System.Drawing.Color.White
        Me.dgv_x.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_x.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_x.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_x.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_x.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgv_x.ContextMenuStrip = Me.cms_action
        Me.dgv_x.EnableHeadersVisualStyles = False
        Me.dgv_x.Location = New System.Drawing.Point(630, 343)
        Me.dgv_x.Name = "dgv_x"
        Me.dgv_x.ReadOnly = True
        Me.dgv_x.RowHeadersVisible = False
        Me.dgv_x.RowTemplate.Height = 24
        Me.dgv_x.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_x.Size = New System.Drawing.Size(317, 107)
        Me.dgv_x.TabIndex = 176
        '
        'Column1
        '
        Me.Column1.HeaderText = "Code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 250
        '
        'cms_action
        '
        Me.cms_action.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem3})
        Me.cms_action.Name = "ContextMenuStrip1"
        Me.cms_action.Size = New System.Drawing.Size(118, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.IpicIndirect.My.Resources.Resources.icons8_close_window_16
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripMenuItem1.Text = "&Remove"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.IpicIndirect.My.Resources.Resources.icons8_file_delete_16
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripMenuItem3.Text = "&Cancel"
        '
        'uc_notedBy_lbl
        '
        Me.uc_notedBy_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_notedBy_lbl.Enabled = False
        Me.uc_notedBy_lbl.iAddition_SQL = Nothing
        Me.uc_notedBy_lbl.iAdditional = Nothing
        Me.uc_notedBy_lbl.idsc = Nothing
        Me.uc_notedBy_lbl.iIsEnabled = False
        Me.uc_notedBy_lbl.iIsForSearch = False
        Me.uc_notedBy_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_notedBy_lbl.iLabel_width = 5
        Me.uc_notedBy_lbl.isLabelBoldx = False
        Me.uc_notedBy_lbl.iSQL_Parameter_ID = 0
        Me.uc_notedBy_lbl.iText = ""
        Me.uc_notedBy_lbl.LinkedColumn = ""
        Me.uc_notedBy_lbl.Location = New System.Drawing.Point(145, 116)
        Me.uc_notedBy_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_notedBy_lbl.Name = "uc_notedBy_lbl"
        Me.uc_notedBy_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_notedBy_lbl.Size = New System.Drawing.Size(205, 28)
        Me.uc_notedBy_lbl.TabIndex = 148
        Me.uc_notedBy_lbl.Tag = "`"
        '
        'uc_req_by_lbl
        '
        Me.uc_req_by_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_req_by_lbl.iAddition_SQL = Nothing
        Me.uc_req_by_lbl.iAdditional = Nothing
        Me.uc_req_by_lbl.idsc = Nothing
        Me.uc_req_by_lbl.iIsEnabled = False
        Me.uc_req_by_lbl.iIsForSearch = False
        Me.uc_req_by_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_req_by_lbl.iLabel_width = 5
        Me.uc_req_by_lbl.isLabelBoldx = False
        Me.uc_req_by_lbl.iSQL_Parameter_ID = 0
        Me.uc_req_by_lbl.iText = ""
        Me.uc_req_by_lbl.LinkedColumn = ""
        Me.uc_req_by_lbl.Location = New System.Drawing.Point(145, 61)
        Me.uc_req_by_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_req_by_lbl.Name = "uc_req_by_lbl"
        Me.uc_req_by_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_req_by_lbl.Size = New System.Drawing.Size(205, 21)
        Me.uc_req_by_lbl.TabIndex = 144
        '
        'uc_appointedTo_lbl
        '
        Me.uc_appointedTo_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_appointedTo_lbl.iAddition_SQL = Nothing
        Me.uc_appointedTo_lbl.iAdditional = Nothing
        Me.uc_appointedTo_lbl.idsc = Me.Label1
        Me.uc_appointedTo_lbl.iIsEnabled = False
        Me.uc_appointedTo_lbl.iIsForSearch = False
        Me.uc_appointedTo_lbl.iLabel = ""
        Me.uc_appointedTo_lbl.iLabel_width = 5
        Me.uc_appointedTo_lbl.isLabelBoldx = False
        Me.uc_appointedTo_lbl.iSQL_Parameter_ID = 0
        Me.uc_appointedTo_lbl.iText = ""
        Me.uc_appointedTo_lbl.LinkedColumn = ""
        Me.uc_appointedTo_lbl.Location = New System.Drawing.Point(145, 90)
        Me.uc_appointedTo_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_appointedTo_lbl.Name = "uc_appointedTo_lbl"
        Me.uc_appointedTo_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_appointedTo_lbl.Size = New System.Drawing.Size(205, 21)
        Me.uc_appointedTo_lbl.TabIndex = 143
        '
        'uc_maint_lbl
        '
        Me.uc_maint_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_maint_lbl.iAddition_SQL = Nothing
        Me.uc_maint_lbl.iAdditional = Nothing
        Me.uc_maint_lbl.idsc = Nothing
        Me.uc_maint_lbl.iIsEnabled = False
        Me.uc_maint_lbl.iIsForSearch = False
        Me.uc_maint_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_maint_lbl.iLabel_width = 5
        Me.uc_maint_lbl.isLabelBoldx = False
        Me.uc_maint_lbl.iSQL_Parameter_ID = 0
        Me.uc_maint_lbl.iText = ""
        Me.uc_maint_lbl.LinkedColumn = ""
        Me.uc_maint_lbl.Location = New System.Drawing.Point(914, 314)
        Me.uc_maint_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_maint_lbl.Name = "uc_maint_lbl"
        Me.uc_maint_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_maint_lbl.Size = New System.Drawing.Size(33, 21)
        Me.uc_maint_lbl.TabIndex = 175
        '
        'uc_maint
        '
        Me.uc_maint.BackColor = System.Drawing.Color.Transparent
        Me.uc_maint.iAdditional = Nothing
        Me.uc_maint.iArrow_Visible = False
        Me.uc_maint.iCanFindLabel_SQLIDx = 0
        Me.uc_maint.iCharacterLimit = 0
        Me.uc_maint.idsc = Me.uc_maint_lbl
        Me.uc_maint.iForm = Me
        Me.uc_maint.iIsDropDown = False
        Me.uc_maint.iIsEnabled = False
        Me.uc_maint.iIsForSearch = True
        Me.uc_maint.iIsID = True
        Me.uc_maint.iIsInnerShow = True
        Me.uc_maint.iLabel = "Maintenance(s)"
        Me.uc_maint.iLabel_width = 120
        Me.uc_maint.isAllowEmptyx = True
        Me.uc_maint.isForFind = False
        Me.uc_maint.iSQL_Parameter_ID = 84
        Me.uc_maint.iSQL_Parameter_ID_FIND = 0
        Me.uc_maint.isStayVisible = False
        Me.uc_maint.iText = ""
        Me.uc_maint.iTextBox_ = Me.uc_maint_Text
        Me.uc_maint.iTextBox_Sel_COL_ID = 0
        Me.uc_maint.iTitle = ""
        Me.uc_maint.LinkedColumn = ""
        Me.uc_maint.Location = New System.Drawing.Point(631, 321)
        Me.uc_maint.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_maint.Name = "uc_maint"
        Me.uc_maint.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_maint.Size = New System.Drawing.Size(135, 19)
        Me.uc_maint.TabIndex = 173
        '
        'Uc_label2
        '
        Me.Uc_label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_label2.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label2.iAddition_SQL = Nothing
        Me.Uc_label2.iAdditional = Nothing
        Me.Uc_label2.idsc = Me.Label1
        Me.Uc_label2.iIsEnabled = False
        Me.Uc_label2.iIsForSearch = False
        Me.Uc_label2.iLabel = " "
        Me.Uc_label2.iLabel_width = 5
        Me.Uc_label2.isLabelBoldx = False
        Me.Uc_label2.iSQL_Parameter_ID = 0
        Me.Uc_label2.iText = ""
        Me.Uc_label2.LinkedColumn = ""
        Me.Uc_label2.Location = New System.Drawing.Point(763, 40)
        Me.Uc_label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Uc_label2.Name = "Uc_label2"
        Me.Uc_label2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label2.Size = New System.Drawing.Size(195, 21)
        Me.Uc_label2.TabIndex = 168
        '
        'Uc_inputbox1
        '
        Me.Uc_inputbox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_inputbox1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_inputbox1.iAdditional = Nothing
        Me.Uc_inputbox1.iArrow_Visible = False
        Me.Uc_inputbox1.iCanFindLabel_SQLIDx = 0
        Me.Uc_inputbox1.iCharacterLimit = 0
        Me.Uc_inputbox1.idsc = Me.Uc_label2
        Me.Uc_inputbox1.iForm = Me
        Me.Uc_inputbox1.iIsDropDown = True
        Me.Uc_inputbox1.iIsEnabled = False
        Me.Uc_inputbox1.iIsForSearch = True
        Me.Uc_inputbox1.iIsID = False
        Me.Uc_inputbox1.iIsInnerShow = True
        Me.Uc_inputbox1.iLabel = "Criticality"
        Me.Uc_inputbox1.iLabel_width = 90
        Me.Uc_inputbox1.isAllowEmptyx = True
        Me.Uc_inputbox1.isForFind = False
        Me.Uc_inputbox1.iSQL_Parameter_ID = 73
        Me.Uc_inputbox1.iSQL_Parameter_ID_FIND = 73
        Me.Uc_inputbox1.isStayVisible = False
        Me.Uc_inputbox1.iText = " "
        Me.Uc_inputbox1.iTextBox_ = Me.TextBox5
        Me.Uc_inputbox1.iTextBox_Sel_COL_ID = 0
        Me.Uc_inputbox1.iTitle = " "
        Me.Uc_inputbox1.LinkedColumn = "status"
        Me.Uc_inputbox1.Location = New System.Drawing.Point(630, 40)
        Me.Uc_inputbox1.Margin = New System.Windows.Forms.Padding(0)
        Me.Uc_inputbox1.Name = "Uc_inputbox1"
        Me.Uc_inputbox1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_inputbox1.Size = New System.Drawing.Size(129, 21)
        Me.Uc_inputbox1.TabIndex = 167
        '
        'uc_Parts
        '
        Me.uc_Parts.BackColor = System.Drawing.Color.Transparent
        Me.uc_Parts.iAdditional = Nothing
        Me.uc_Parts.iArrow_Visible = True
        Me.uc_Parts.iCanFindLabel_SQLIDx = 0
        Me.uc_Parts.iCharacterLimit = 0
        Me.uc_Parts.idsc = Me.uc_appointedTo_lbl
        Me.uc_Parts.iForm = Me
        Me.uc_Parts.iIsDropDown = False
        Me.uc_Parts.iIsEnabled = False
        Me.uc_Parts.iIsForSearch = True
        Me.uc_Parts.iIsID = True
        Me.uc_Parts.iIsInnerShow = True
        Me.uc_Parts.iLabel = "Part/Sub-Parts"
        Me.uc_Parts.iLabel_width = 120
        Me.uc_Parts.isAllowEmptyx = True
        Me.uc_Parts.isForFind = False
        Me.uc_Parts.iSQL_Parameter_ID = 29
        Me.uc_Parts.iSQL_Parameter_ID_FIND = 0
        Me.uc_Parts.isStayVisible = False
        Me.uc_Parts.iText = ""
        Me.uc_Parts.iTextBox_ = Me.uc_subParts_txt
        Me.uc_Parts.iTextBox_Sel_COL_ID = 0
        Me.uc_Parts.iTitle = ""
        Me.uc_Parts.LinkedColumn = "Parts"
        Me.uc_Parts.Location = New System.Drawing.Point(14, 268)
        Me.uc_Parts.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_Parts.Name = "uc_Parts"
        Me.uc_Parts.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_Parts.Size = New System.Drawing.Size(166, 36)
        Me.uc_Parts.TabIndex = 131
        Me.uc_Parts.Tag = "`"
        Me.uc_Parts.Visible = False
        '
        'uc_statusofRep_lbl
        '
        Me.uc_statusofRep_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_statusofRep_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_statusofRep_lbl.Enabled = False
        Me.uc_statusofRep_lbl.iAddition_SQL = Nothing
        Me.uc_statusofRep_lbl.iAdditional = Nothing
        Me.uc_statusofRep_lbl.idsc = Nothing
        Me.uc_statusofRep_lbl.iIsEnabled = False
        Me.uc_statusofRep_lbl.iIsForSearch = False
        Me.uc_statusofRep_lbl.iLabel = ""
        Me.uc_statusofRep_lbl.iLabel_width = 5
        Me.uc_statusofRep_lbl.isLabelBoldx = False
        Me.uc_statusofRep_lbl.iSQL_Parameter_ID = 0
        Me.uc_statusofRep_lbl.iText = ""
        Me.uc_statusofRep_lbl.LinkedColumn = ""
        Me.uc_statusofRep_lbl.Location = New System.Drawing.Point(801, 289)
        Me.uc_statusofRep_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_statusofRep_lbl.Name = "uc_statusofRep_lbl"
        Me.uc_statusofRep_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_statusofRep_lbl.Size = New System.Drawing.Size(134, 21)
        Me.uc_statusofRep_lbl.TabIndex = 148
        Me.uc_statusofRep_lbl.Tag = "`"
        '
        'uc_StatusOfRepair
        '
        Me.uc_StatusOfRepair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_StatusOfRepair.BackColor = System.Drawing.Color.Transparent
        Me.uc_StatusOfRepair.iAdditional = Nothing
        Me.uc_StatusOfRepair.iArrow_Visible = False
        Me.uc_StatusOfRepair.iCanFindLabel_SQLIDx = 0
        Me.uc_StatusOfRepair.iCharacterLimit = 0
        Me.uc_StatusOfRepair.idsc = Me.uc_statusofRep_lbl
        Me.uc_StatusOfRepair.iForm = Me
        Me.uc_StatusOfRepair.iIsDropDown = True
        Me.uc_StatusOfRepair.iIsEnabled = False
        Me.uc_StatusOfRepair.iIsForSearch = True
        Me.uc_StatusOfRepair.iIsID = True
        Me.uc_StatusOfRepair.iIsInnerShow = True
        Me.uc_StatusOfRepair.iLabel = "Status of Repair"
        Me.uc_StatusOfRepair.iLabel_width = 120
        Me.uc_StatusOfRepair.isAllowEmptyx = True
        Me.uc_StatusOfRepair.isForFind = False
        Me.uc_StatusOfRepair.iSQL_Parameter_ID = 76
        Me.uc_StatusOfRepair.iSQL_Parameter_ID_FIND = 76
        Me.uc_StatusOfRepair.isStayVisible = False
        Me.uc_StatusOfRepair.iText = ""
        Me.uc_StatusOfRepair.iTextBox_ = Me.txt_null
        Me.uc_StatusOfRepair.iTextBox_Sel_COL_ID = 0
        Me.uc_StatusOfRepair.iTitle = ""
        Me.uc_StatusOfRepair.LinkedColumn = "StatusOfRepair"
        Me.uc_StatusOfRepair.Location = New System.Drawing.Point(631, 289)
        Me.uc_StatusOfRepair.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_StatusOfRepair.Name = "uc_StatusOfRepair"
        Me.uc_StatusOfRepair.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_StatusOfRepair.Size = New System.Drawing.Size(166, 21)
        Me.uc_StatusOfRepair.TabIndex = 146
        Me.uc_StatusOfRepair.Tag = ""
        '
        'uc_lbl
        '
        Me.uc_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_lbl.iAddition_SQL = Nothing
        Me.uc_lbl.iAdditional = Nothing
        Me.uc_lbl.idsc = Me.Label1
        Me.uc_lbl.iIsEnabled = False
        Me.uc_lbl.iIsForSearch = False
        Me.uc_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_lbl.iLabel_width = 5
        Me.uc_lbl.isLabelBoldx = False
        Me.uc_lbl.iSQL_Parameter_ID = 0
        Me.uc_lbl.iText = "OPEN"
        Me.uc_lbl.LinkedColumn = ""
        Me.uc_lbl.Location = New System.Drawing.Point(763, 13)
        Me.uc_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_lbl.Name = "uc_lbl"
        Me.uc_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_lbl.Size = New System.Drawing.Size(195, 21)
        Me.uc_lbl.TabIndex = 142
        '
        'txt_status
        '
        Me.txt_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_status.BackColor = System.Drawing.Color.Transparent
        Me.txt_status.iAdditional = Nothing
        Me.txt_status.iArrow_Visible = False
        Me.txt_status.iCanFindLabel_SQLIDx = 0
        Me.txt_status.iCharacterLimit = 0
        Me.txt_status.idsc = Me.uc_lbl
        Me.txt_status.iForm = Me
        Me.txt_status.iIsDropDown = True
        Me.txt_status.iIsEnabled = False
        Me.txt_status.iIsForSearch = True
        Me.txt_status.iIsID = False
        Me.txt_status.iIsInnerShow = True
        Me.txt_status.iLabel = "Status"
        Me.txt_status.iLabel_width = 90
        Me.txt_status.isAllowEmptyx = True
        Me.txt_status.isForFind = False
        Me.txt_status.iSQL_Parameter_ID = 33
        Me.txt_status.iSQL_Parameter_ID_FIND = 0
        Me.txt_status.isStayVisible = False
        Me.txt_status.iText = "O"
        Me.txt_status.iTextBox_ = Me.TextBox2
        Me.txt_status.iTextBox_Sel_COL_ID = 0
        Me.txt_status.iTitle = "O"
        Me.txt_status.LinkedColumn = "status"
        Me.txt_status.Location = New System.Drawing.Point(630, 13)
        Me.txt_status.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_status.Size = New System.Drawing.Size(129, 21)
        Me.txt_status.TabIndex = 141
        '
        'uc_controlUsed
        '
        Me.uc_controlUsed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_controlUsed.BackColor = System.Drawing.Color.Transparent
        Me.uc_controlUsed.iAddition_SQL = Nothing
        Me.uc_controlUsed.iAdditional = Nothing
        Me.uc_controlUsed.idsc = Nothing
        Me.uc_controlUsed.iIsEnabled = False
        Me.uc_controlUsed.iIsForSearch = False
        Me.uc_controlUsed.iLabel = "Controls Used"
        Me.uc_controlUsed.iLabel_width = 135
        Me.uc_controlUsed.isLabelBoldx = False
        Me.uc_controlUsed.iSQL_Parameter_ID = 0
        Me.uc_controlUsed.iText = ""
        Me.uc_controlUsed.LinkedColumn = "controlUsed"
        Me.uc_controlUsed.Location = New System.Drawing.Point(631, 257)
        Me.uc_controlUsed.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_controlUsed.Name = "uc_controlUsed"
        Me.uc_controlUsed.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_controlUsed.Size = New System.Drawing.Size(305, 29)
        Me.uc_controlUsed.TabIndex = 164
        '
        'uc_posibleHazard
        '
        Me.uc_posibleHazard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_posibleHazard.BackColor = System.Drawing.Color.Transparent
        Me.uc_posibleHazard.iAddition_SQL = Nothing
        Me.uc_posibleHazard.iAdditional = Nothing
        Me.uc_posibleHazard.idsc = Nothing
        Me.uc_posibleHazard.iIsEnabled = False
        Me.uc_posibleHazard.iIsForSearch = False
        Me.uc_posibleHazard.iLabel = "Possible Hazards"
        Me.uc_posibleHazard.iLabel_width = 135
        Me.uc_posibleHazard.isLabelBoldx = False
        Me.uc_posibleHazard.iSQL_Parameter_ID = 0
        Me.uc_posibleHazard.iText = ""
        Me.uc_posibleHazard.LinkedColumn = "posibleHazard"
        Me.uc_posibleHazard.Location = New System.Drawing.Point(631, 235)
        Me.uc_posibleHazard.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_posibleHazard.Name = "uc_posibleHazard"
        Me.uc_posibleHazard.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_posibleHazard.Size = New System.Drawing.Size(305, 21)
        Me.uc_posibleHazard.TabIndex = 164
        '
        'uc_riskLevel
        '
        Me.uc_riskLevel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_riskLevel.BackColor = System.Drawing.Color.Transparent
        Me.uc_riskLevel.iAddition_SQL = Nothing
        Me.uc_riskLevel.iAdditional = Nothing
        Me.uc_riskLevel.idsc = Nothing
        Me.uc_riskLevel.iIsEnabled = False
        Me.uc_riskLevel.iIsForSearch = False
        Me.uc_riskLevel.iLabel = "Risk Level"
        Me.uc_riskLevel.iLabel_width = 135
        Me.uc_riskLevel.isLabelBoldx = False
        Me.uc_riskLevel.iSQL_Parameter_ID = 0
        Me.uc_riskLevel.iText = ""
        Me.uc_riskLevel.LinkedColumn = "riskLevel"
        Me.uc_riskLevel.Location = New System.Drawing.Point(631, 213)
        Me.uc_riskLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_riskLevel.Name = "uc_riskLevel"
        Me.uc_riskLevel.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_riskLevel.Size = New System.Drawing.Size(305, 21)
        Me.uc_riskLevel.TabIndex = 164
        '
        'uc_severity_lbl
        '
        Me.uc_severity_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_severity_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_severity_lbl.iAddition_SQL = Nothing
        Me.uc_severity_lbl.iAdditional = Nothing
        Me.uc_severity_lbl.idsc = Nothing
        Me.uc_severity_lbl.iIsEnabled = False
        Me.uc_severity_lbl.iIsForSearch = False
        Me.uc_severity_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_severity_lbl.iLabel_width = 5
        Me.uc_severity_lbl.isLabelBoldx = False
        Me.uc_severity_lbl.iSQL_Parameter_ID = 0
        Me.uc_severity_lbl.iText = ""
        Me.uc_severity_lbl.LinkedColumn = ""
        Me.uc_severity_lbl.Location = New System.Drawing.Point(801, 190)
        Me.uc_severity_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_severity_lbl.Name = "uc_severity_lbl"
        Me.uc_severity_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_severity_lbl.Size = New System.Drawing.Size(134, 21)
        Me.uc_severity_lbl.TabIndex = 163
        '
        'uc_Likelihood
        '
        Me.uc_Likelihood.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_Likelihood.BackColor = System.Drawing.Color.Transparent
        Me.uc_Likelihood.iAdditional = Nothing
        Me.uc_Likelihood.iArrow_Visible = False
        Me.uc_Likelihood.iCanFindLabel_SQLIDx = 0
        Me.uc_Likelihood.iCharacterLimit = 0
        Me.uc_Likelihood.idsc = Me.uc_Likelihood_lbl
        Me.uc_Likelihood.iForm = Me
        Me.uc_Likelihood.iIsDropDown = True
        Me.uc_Likelihood.iIsEnabled = False
        Me.uc_Likelihood.iIsForSearch = True
        Me.uc_Likelihood.iIsID = True
        Me.uc_Likelihood.iIsInnerShow = True
        Me.uc_Likelihood.iLabel = "Likelihood"
        Me.uc_Likelihood.iLabel_width = 120
        Me.uc_Likelihood.isAllowEmptyx = True
        Me.uc_Likelihood.isForFind = False
        Me.uc_Likelihood.iSQL_Parameter_ID = 72
        Me.uc_Likelihood.iSQL_Parameter_ID_FIND = 0
        Me.uc_Likelihood.isStayVisible = False
        Me.uc_Likelihood.iText = ""
        Me.uc_Likelihood.iTextBox_ = Me.TextBox4
        Me.uc_Likelihood.iTextBox_Sel_COL_ID = 0
        Me.uc_Likelihood.iTitle = ""
        Me.uc_Likelihood.LinkedColumn = "Likelihood"
        Me.uc_Likelihood.Location = New System.Drawing.Point(631, 169)
        Me.uc_Likelihood.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_Likelihood.Name = "uc_Likelihood"
        Me.uc_Likelihood.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_Likelihood.Size = New System.Drawing.Size(166, 21)
        Me.uc_Likelihood.TabIndex = 159
        '
        'uc_Likelihood_lbl
        '
        Me.uc_Likelihood_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_Likelihood_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_Likelihood_lbl.iAddition_SQL = Nothing
        Me.uc_Likelihood_lbl.iAdditional = Nothing
        Me.uc_Likelihood_lbl.idsc = Nothing
        Me.uc_Likelihood_lbl.iIsEnabled = False
        Me.uc_Likelihood_lbl.iIsForSearch = False
        Me.uc_Likelihood_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_Likelihood_lbl.iLabel_width = 5
        Me.uc_Likelihood_lbl.isLabelBoldx = False
        Me.uc_Likelihood_lbl.iSQL_Parameter_ID = 0
        Me.uc_Likelihood_lbl.iText = ""
        Me.uc_Likelihood_lbl.LinkedColumn = ""
        Me.uc_Likelihood_lbl.Location = New System.Drawing.Point(801, 169)
        Me.uc_Likelihood_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_Likelihood_lbl.Name = "uc_Likelihood_lbl"
        Me.uc_Likelihood_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_Likelihood_lbl.Size = New System.Drawing.Size(134, 21)
        Me.uc_Likelihood_lbl.TabIndex = 161
        '
        'uc_severity
        '
        Me.uc_severity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_severity.BackColor = System.Drawing.Color.Transparent
        Me.uc_severity.iAdditional = Nothing
        Me.uc_severity.iArrow_Visible = False
        Me.uc_severity.iCanFindLabel_SQLIDx = 0
        Me.uc_severity.iCharacterLimit = 0
        Me.uc_severity.idsc = Me.uc_severity_lbl
        Me.uc_severity.iForm = Me
        Me.uc_severity.iIsDropDown = True
        Me.uc_severity.iIsEnabled = False
        Me.uc_severity.iIsForSearch = True
        Me.uc_severity.iIsID = True
        Me.uc_severity.iIsInnerShow = True
        Me.uc_severity.iLabel = "Severity"
        Me.uc_severity.iLabel_width = 120
        Me.uc_severity.isAllowEmptyx = True
        Me.uc_severity.isForFind = False
        Me.uc_severity.iSQL_Parameter_ID = 73
        Me.uc_severity.iSQL_Parameter_ID_FIND = 0
        Me.uc_severity.isStayVisible = False
        Me.uc_severity.iText = ""
        Me.uc_severity.iTextBox_ = Me.TextBox4
        Me.uc_severity.iTextBox_Sel_COL_ID = 0
        Me.uc_severity.iTitle = ""
        Me.uc_severity.LinkedColumn = "severity"
        Me.uc_severity.Location = New System.Drawing.Point(631, 190)
        Me.uc_severity.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_severity.Name = "uc_severity"
        Me.uc_severity.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_severity.Size = New System.Drawing.Size(166, 21)
        Me.uc_severity.TabIndex = 162
        '
        'Uc_lines2
        '
        Me.Uc_lines2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_lines2.BackColor = System.Drawing.Color.Transparent
        Me.Uc_lines2.iLabel = "Job Safety Risk Assessment "
        Me.Uc_lines2.isHighLight = False
        Me.Uc_lines2.iSize = 1
        Me.Uc_lines2.Location = New System.Drawing.Point(600, 150)
        Me.Uc_lines2.Name = "Uc_lines2"
        Me.Uc_lines2.PetSize = IpicIndirect.PetSize.Box
        Me.Uc_lines2.Size = New System.Drawing.Size(359, 154)
        Me.Uc_lines2.TabIndex = 158
        '
        'uc_null
        '
        Me.uc_null.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_null.BackColor = System.Drawing.Color.Transparent
        Me.uc_null.Enabled = False
        Me.uc_null.iAddition_SQL = Nothing
        Me.uc_null.iAdditional = Nothing
        Me.uc_null.idsc = Nothing
        Me.uc_null.iIsEnabled = True
        Me.uc_null.iIsForSearch = False
        Me.uc_null.iLabel = "Edit iLbl to edit me"
        Me.uc_null.iLabel_width = 5
        Me.uc_null.isLabelBoldx = False
        Me.uc_null.iSQL_Parameter_ID = 0
        Me.uc_null.iText = ""
        Me.uc_null.LinkedColumn = ""
        Me.uc_null.Location = New System.Drawing.Point(460, 26)
        Me.uc_null.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_null.Name = "uc_null"
        Me.uc_null.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_null.Size = New System.Drawing.Size(27, 21)
        Me.uc_null.TabIndex = 161
        Me.uc_null.Tag = "`"
        Me.uc_null.Visible = False
        '
        'uc_notedBy
        '
        Me.uc_notedBy.BackColor = System.Drawing.Color.Transparent
        Me.uc_notedBy.iAdditional = Nothing
        Me.uc_notedBy.iArrow_Visible = False
        Me.uc_notedBy.iCanFindLabel_SQLIDx = 0
        Me.uc_notedBy.iCharacterLimit = 0
        Me.uc_notedBy.idsc = Me.uc_appointedTo_lbl
        Me.uc_notedBy.iForm = Me
        Me.uc_notedBy.iIsDropDown = True
        Me.uc_notedBy.iIsEnabled = False
        Me.uc_notedBy.iIsForSearch = False
        Me.uc_notedBy.iIsID = True
        Me.uc_notedBy.iIsInnerShow = True
        Me.uc_notedBy.iLabel = "Verified By"
        Me.uc_notedBy.iLabel_width = 90
        Me.uc_notedBy.isAllowEmptyx = True
        Me.uc_notedBy.isForFind = False
        Me.uc_notedBy.iSQL_Parameter_ID = 29
        Me.uc_notedBy.iSQL_Parameter_ID_FIND = 0
        Me.uc_notedBy.isStayVisible = False
        Me.uc_notedBy.iText = ""
        Me.uc_notedBy.iTextBox_ = Me.TextBox1
        Me.uc_notedBy.iTextBox_Sel_COL_ID = 0
        Me.uc_notedBy.iTitle = ""
        Me.uc_notedBy.LinkedColumn = "VerifiedBy"
        Me.uc_notedBy.Location = New System.Drawing.Point(14, 116)
        Me.uc_notedBy.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_notedBy.Name = "uc_notedBy"
        Me.uc_notedBy.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_notedBy.Size = New System.Drawing.Size(131, 21)
        Me.uc_notedBy.TabIndex = 146
        Me.uc_notedBy.Tag = ""
        '
        'uc_IDENTITY
        '
        Me.uc_IDENTITY.BackColor = System.Drawing.Color.Transparent
        Me.uc_IDENTITY.iAddition_SQL = Nothing
        Me.uc_IDENTITY.iAdditional = Nothing
        Me.uc_IDENTITY.idsc = Nothing
        Me.uc_IDENTITY.iIsEnabled = True
        Me.uc_IDENTITY.iIsForSearch = False
        Me.uc_IDENTITY.iLabel = "No."
        Me.uc_IDENTITY.iLabel_width = 100
        Me.uc_IDENTITY.isLabelBoldx = False
        Me.uc_IDENTITY.iSQL_Parameter_ID = 0
        Me.uc_IDENTITY.iText = ""
        Me.uc_IDENTITY.LinkedColumn = ""
        Me.uc_IDENTITY.Location = New System.Drawing.Point(15, 7)
        Me.uc_IDENTITY.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_IDENTITY.Name = "uc_IDENTITY"
        Me.uc_IDENTITY.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_IDENTITY.Size = New System.Drawing.Size(281, 21)
        Me.uc_IDENTITY.TabIndex = 154
        '
        'uc_EndTime
        '
        Me.uc_EndTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_EndTime.BackColor = System.Drawing.Color.Transparent
        Me.uc_EndTime.iDate = New Date(2020, 9, 2, 9, 43, 15, 313)
        Me.uc_EndTime.idsc = Nothing
        Me.uc_EndTime.iForm = Nothing
        Me.uc_EndTime.iIsForSearch = False
        Me.uc_EndTime.iLabel = "Production Order Selection"
        Me.uc_EndTime.iLabel_width = 10
        Me.uc_EndTime.IsEnabled = False
        Me.uc_EndTime.isForFind = False
        Me.uc_EndTime.iSQL_Parameter_ID = 0
        Me.uc_EndTime.LinkedColumn = "EndTime"
        Me.uc_EndTime.Location = New System.Drawing.Point(874, 99)
        Me.uc_EndTime.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_EndTime.Name = "uc_EndTime"
        Me.uc_EndTime.Size = New System.Drawing.Size(89, 23)
        Me.uc_EndTime.TabIndex = 150
        Me.uc_EndTime.Tag = "`"
        '
        'uc_StartTime
        '
        Me.uc_StartTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_StartTime.BackColor = System.Drawing.Color.Transparent
        Me.uc_StartTime.iDate = New Date(2020, 9, 2, 9, 43, 15, 318)
        Me.uc_StartTime.idsc = Nothing
        Me.uc_StartTime.iForm = Me
        Me.uc_StartTime.iIsForSearch = False
        Me.uc_StartTime.iLabel = "Production Order Selection"
        Me.uc_StartTime.iLabel_width = 10
        Me.uc_StartTime.IsEnabled = False
        Me.uc_StartTime.isForFind = False
        Me.uc_StartTime.iSQL_Parameter_ID = 0
        Me.uc_StartTime.LinkedColumn = "StartTime"
        Me.uc_StartTime.Location = New System.Drawing.Point(874, 77)
        Me.uc_StartTime.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_StartTime.Name = "uc_StartTime"
        Me.uc_StartTime.Size = New System.Drawing.Size(89, 23)
        Me.uc_StartTime.TabIndex = 150
        Me.uc_StartTime.Tag = "`"
        '
        'uc_EndDate
        '
        Me.uc_EndDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_EndDate.BackColor = System.Drawing.Color.Transparent
        Me.uc_EndDate.iDate = New Date(2020, 9, 2, 9, 43, 15, 322)
        Me.uc_EndDate.idsc = Nothing
        Me.uc_EndDate.iForm = Nothing
        Me.uc_EndDate.iIsForSearch = False
        Me.uc_EndDate.iLabel = "End Date/Time"
        Me.uc_EndDate.iLabel_width = 127
        Me.uc_EndDate.IsEnabled = False
        Me.uc_EndDate.isForFind = False
        Me.uc_EndDate.iSQL_Parameter_ID = 0
        Me.uc_EndDate.LinkedColumn = "EndDate"
        Me.uc_EndDate.Location = New System.Drawing.Point(630, 99)
        Me.uc_EndDate.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_EndDate.Name = "uc_EndDate"
        Me.uc_EndDate.Size = New System.Drawing.Size(236, 23)
        Me.uc_EndDate.TabIndex = 149
        Me.uc_EndDate.Tag = "`"
        '
        'uc_StartDate
        '
        Me.uc_StartDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_StartDate.BackColor = System.Drawing.Color.Transparent
        Me.uc_StartDate.iDate = New Date(2020, 9, 2, 9, 43, 15, 328)
        Me.uc_StartDate.idsc = Me.Label1
        Me.uc_StartDate.iForm = Me
        Me.uc_StartDate.iIsForSearch = False
        Me.uc_StartDate.iLabel = "Start Date/Time"
        Me.uc_StartDate.iLabel_width = 127
        Me.uc_StartDate.IsEnabled = False
        Me.uc_StartDate.isForFind = False
        Me.uc_StartDate.iSQL_Parameter_ID = 0
        Me.uc_StartDate.LinkedColumn = "StartDate"
        Me.uc_StartDate.Location = New System.Drawing.Point(630, 76)
        Me.uc_StartDate.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_StartDate.Name = "uc_StartDate"
        Me.uc_StartDate.Size = New System.Drawing.Size(236, 23)
        Me.uc_StartDate.TabIndex = 149
        Me.uc_StartDate.Tag = "`"
        '
        'uc_appointedTo
        '
        Me.uc_appointedTo.BackColor = System.Drawing.Color.Transparent
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
        Me.uc_appointedTo.iLabel_width = 90
        Me.uc_appointedTo.isAllowEmptyx = True
        Me.uc_appointedTo.isForFind = False
        Me.uc_appointedTo.iSQL_Parameter_ID = 0
        Me.uc_appointedTo.iSQL_Parameter_ID_FIND = 0
        Me.uc_appointedTo.isStayVisible = False
        Me.uc_appointedTo.iText = ""
        Me.uc_appointedTo.iTextBox_ = Me.TextBox1
        Me.uc_appointedTo.iTextBox_Sel_COL_ID = 0
        Me.uc_appointedTo.iTitle = ""
        Me.uc_appointedTo.LinkedColumn = "appointedTo"
        Me.uc_appointedTo.Location = New System.Drawing.Point(14, 90)
        Me.uc_appointedTo.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_appointedTo.Name = "uc_appointedTo"
        Me.uc_appointedTo.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_appointedTo.Size = New System.Drawing.Size(131, 21)
        Me.uc_appointedTo.TabIndex = 140
        '
        'uc_machine_lbl
        '
        Me.uc_machine_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_machine_lbl.iAddition_SQL = Nothing
        Me.uc_machine_lbl.iAdditional = Nothing
        Me.uc_machine_lbl.idsc = Nothing
        Me.uc_machine_lbl.iIsEnabled = False
        Me.uc_machine_lbl.iIsForSearch = False
        Me.uc_machine_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_machine_lbl.iLabel_width = 5
        Me.uc_machine_lbl.isLabelBoldx = False
        Me.uc_machine_lbl.iSQL_Parameter_ID = 0
        Me.uc_machine_lbl.iText = ""
        Me.uc_machine_lbl.LinkedColumn = ""
        Me.uc_machine_lbl.Location = New System.Drawing.Point(183, 244)
        Me.uc_machine_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_machine_lbl.Name = "uc_machine_lbl"
        Me.uc_machine_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_machine_lbl.Size = New System.Drawing.Size(167, 21)
        Me.uc_machine_lbl.TabIndex = 135
        '
        'uc_requestedTime
        '
        Me.uc_requestedTime.BackColor = System.Drawing.Color.Transparent
        Me.uc_requestedTime.iDate = New Date(2020, 9, 2, 9, 43, 15, 336)
        Me.uc_requestedTime.idsc = Nothing
        Me.uc_requestedTime.iForm = Me
        Me.uc_requestedTime.iIsForSearch = False
        Me.uc_requestedTime.iLabel = "Production Order Selection"
        Me.uc_requestedTime.iLabel_width = 10
        Me.uc_requestedTime.IsEnabled = False
        Me.uc_requestedTime.isForFind = False
        Me.uc_requestedTime.iSQL_Parameter_ID = 0
        Me.uc_requestedTime.LinkedColumn = "requestedTime"
        Me.uc_requestedTime.Location = New System.Drawing.Point(231, 34)
        Me.uc_requestedTime.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_requestedTime.Name = "uc_requestedTime"
        Me.uc_requestedTime.Size = New System.Drawing.Size(65, 23)
        Me.uc_requestedTime.TabIndex = 138
        '
        'uc_requestedDate
        '
        Me.uc_requestedDate.BackColor = System.Drawing.Color.Transparent
        Me.uc_requestedDate.iDate = New Date(2020, 9, 2, 9, 43, 15, 342)
        Me.uc_requestedDate.idsc = Me.Label1
        Me.uc_requestedDate.iForm = Me
        Me.uc_requestedDate.iIsForSearch = False
        Me.uc_requestedDate.iLabel = "Posted Date"
        Me.uc_requestedDate.iLabel_width = 100
        Me.uc_requestedDate.IsEnabled = False
        Me.uc_requestedDate.isForFind = False
        Me.uc_requestedDate.iSQL_Parameter_ID = 0
        Me.uc_requestedDate.LinkedColumn = "requestedDate"
        Me.uc_requestedDate.Location = New System.Drawing.Point(14, 34)
        Me.uc_requestedDate.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_requestedDate.Name = "uc_requestedDate"
        Me.uc_requestedDate.Size = New System.Drawing.Size(209, 23)
        Me.uc_requestedDate.TabIndex = 137
        '
        'uc_typeofTrouble_lbl
        '
        Me.uc_typeofTrouble_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_typeofTrouble_lbl.iAddition_SQL = Nothing
        Me.uc_typeofTrouble_lbl.iAdditional = Nothing
        Me.uc_typeofTrouble_lbl.idsc = Nothing
        Me.uc_typeofTrouble_lbl.iIsEnabled = False
        Me.uc_typeofTrouble_lbl.iIsForSearch = False
        Me.uc_typeofTrouble_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_typeofTrouble_lbl.iLabel_width = 5
        Me.uc_typeofTrouble_lbl.isLabelBoldx = False
        Me.uc_typeofTrouble_lbl.iSQL_Parameter_ID = 0
        Me.uc_typeofTrouble_lbl.iText = ""
        Me.uc_typeofTrouble_lbl.LinkedColumn = ""
        Me.uc_typeofTrouble_lbl.Location = New System.Drawing.Point(183, 184)
        Me.uc_typeofTrouble_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_typeofTrouble_lbl.Name = "uc_typeofTrouble_lbl"
        Me.uc_typeofTrouble_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_typeofTrouble_lbl.Size = New System.Drawing.Size(167, 21)
        Me.uc_typeofTrouble_lbl.TabIndex = 136
        '
        'uc_area_lbl
        '
        Me.uc_area_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_area_lbl.iAddition_SQL = Nothing
        Me.uc_area_lbl.iAdditional = Nothing
        Me.uc_area_lbl.idsc = Nothing
        Me.uc_area_lbl.iIsEnabled = False
        Me.uc_area_lbl.iIsForSearch = False
        Me.uc_area_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_area_lbl.iLabel_width = 5
        Me.uc_area_lbl.isLabelBoldx = False
        Me.uc_area_lbl.iSQL_Parameter_ID = 0
        Me.uc_area_lbl.iText = ""
        Me.uc_area_lbl.LinkedColumn = ""
        Me.uc_area_lbl.Location = New System.Drawing.Point(183, 160)
        Me.uc_area_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_area_lbl.Name = "uc_area_lbl"
        Me.uc_area_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_area_lbl.Size = New System.Drawing.Size(167, 21)
        Me.uc_area_lbl.TabIndex = 136
        '
        'uc_station_lbl
        '
        Me.uc_station_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_station_lbl.iAddition_SQL = Nothing
        Me.uc_station_lbl.iAdditional = Nothing
        Me.uc_station_lbl.idsc = Nothing
        Me.uc_station_lbl.iIsEnabled = False
        Me.uc_station_lbl.iIsForSearch = False
        Me.uc_station_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_station_lbl.iLabel_width = 5
        Me.uc_station_lbl.isLabelBoldx = False
        Me.uc_station_lbl.iSQL_Parameter_ID = 0
        Me.uc_station_lbl.iText = ""
        Me.uc_station_lbl.LinkedColumn = ""
        Me.uc_station_lbl.Location = New System.Drawing.Point(183, 220)
        Me.uc_station_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_station_lbl.Name = "uc_station_lbl"
        Me.uc_station_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_station_lbl.Size = New System.Drawing.Size(167, 21)
        Me.uc_station_lbl.TabIndex = 136
        '
        'uc_verifiedBy_lbl
        '
        Me.uc_verifiedBy_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_verifiedBy_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_verifiedBy_lbl.Enabled = False
        Me.uc_verifiedBy_lbl.iAddition_SQL = Nothing
        Me.uc_verifiedBy_lbl.iAdditional = Nothing
        Me.uc_verifiedBy_lbl.idsc = Nothing
        Me.uc_verifiedBy_lbl.iIsEnabled = True
        Me.uc_verifiedBy_lbl.iIsForSearch = False
        Me.uc_verifiedBy_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_verifiedBy_lbl.iLabel_width = 5
        Me.uc_verifiedBy_lbl.isLabelBoldx = False
        Me.uc_verifiedBy_lbl.iSQL_Parameter_ID = 0
        Me.uc_verifiedBy_lbl.iText = ""
        Me.uc_verifiedBy_lbl.LinkedColumn = ""
        Me.uc_verifiedBy_lbl.Location = New System.Drawing.Point(464, 68)
        Me.uc_verifiedBy_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_verifiedBy_lbl.Name = "uc_verifiedBy_lbl"
        Me.uc_verifiedBy_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_verifiedBy_lbl.Size = New System.Drawing.Size(157, 21)
        Me.uc_verifiedBy_lbl.TabIndex = 135
        Me.uc_verifiedBy_lbl.Tag = "`"
        Me.uc_verifiedBy_lbl.Visible = False
        '
        'uc_subParts_lbl
        '
        Me.uc_subParts_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_subParts_lbl.iAddition_SQL = Nothing
        Me.uc_subParts_lbl.iAdditional = Nothing
        Me.uc_subParts_lbl.idsc = Nothing
        Me.uc_subParts_lbl.iIsEnabled = False
        Me.uc_subParts_lbl.iIsForSearch = False
        Me.uc_subParts_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_subParts_lbl.iLabel_width = 5
        Me.uc_subParts_lbl.isLabelBoldx = False
        Me.uc_subParts_lbl.iSQL_Parameter_ID = 0
        Me.uc_subParts_lbl.iText = ""
        Me.uc_subParts_lbl.LinkedColumn = ""
        Me.uc_subParts_lbl.Location = New System.Drawing.Point(183, 268)
        Me.uc_subParts_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_subParts_lbl.Name = "uc_subParts_lbl"
        Me.uc_subParts_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_subParts_lbl.Size = New System.Drawing.Size(167, 21)
        Me.uc_subParts_lbl.TabIndex = 135
        Me.uc_subParts_lbl.Tag = "`"
        Me.uc_subParts_lbl.Visible = False
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
        Me.uc_appointedTo2lbl.isLabelBoldx = False
        Me.uc_appointedTo2lbl.iSQL_Parameter_ID = 0
        Me.uc_appointedTo2lbl.iText = ""
        Me.uc_appointedTo2lbl.LinkedColumn = ""
        Me.uc_appointedTo2lbl.Location = New System.Drawing.Point(347, 34)
        Me.uc_appointedTo2lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_appointedTo2lbl.Name = "uc_appointedTo2lbl"
        Me.uc_appointedTo2lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_appointedTo2lbl.Size = New System.Drawing.Size(26, 20)
        Me.uc_appointedTo2lbl.TabIndex = 134
        Me.uc_appointedTo2lbl.Visible = False
        '
        'uc_TypeOfTrouble
        '
        Me.uc_TypeOfTrouble.BackColor = System.Drawing.Color.Transparent
        Me.uc_TypeOfTrouble.iAdditional = Nothing
        Me.uc_TypeOfTrouble.iArrow_Visible = True
        Me.uc_TypeOfTrouble.iCanFindLabel_SQLIDx = 0
        Me.uc_TypeOfTrouble.iCharacterLimit = 0
        Me.uc_TypeOfTrouble.idsc = Me.uc_typeofTrouble_lbl
        Me.uc_TypeOfTrouble.iForm = Me
        Me.uc_TypeOfTrouble.iIsDropDown = True
        Me.uc_TypeOfTrouble.iIsEnabled = False
        Me.uc_TypeOfTrouble.iIsForSearch = True
        Me.uc_TypeOfTrouble.iIsID = True
        Me.uc_TypeOfTrouble.iIsInnerShow = True
        Me.uc_TypeOfTrouble.iLabel = "Type of Trouble"
        Me.uc_TypeOfTrouble.iLabel_width = 120
        Me.uc_TypeOfTrouble.isAllowEmptyx = True
        Me.uc_TypeOfTrouble.isForFind = False
        Me.uc_TypeOfTrouble.iSQL_Parameter_ID = 64
        Me.uc_TypeOfTrouble.iSQL_Parameter_ID_FIND = 0
        Me.uc_TypeOfTrouble.isStayVisible = False
        Me.uc_TypeOfTrouble.iText = ""
        Me.uc_TypeOfTrouble.iTextBox_ = Me.uc_typeofTrouble_text
        Me.uc_TypeOfTrouble.iTextBox_Sel_COL_ID = 0
        Me.uc_TypeOfTrouble.iTitle = ""
        Me.uc_TypeOfTrouble.LinkedColumn = "TypeOfTrouble"
        Me.uc_TypeOfTrouble.Location = New System.Drawing.Point(14, 184)
        Me.uc_TypeOfTrouble.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_TypeOfTrouble.Name = "uc_TypeOfTrouble"
        Me.uc_TypeOfTrouble.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_TypeOfTrouble.Size = New System.Drawing.Size(166, 21)
        Me.uc_TypeOfTrouble.TabIndex = 132
        '
        'uc_AreaOfConcern
        '
        Me.uc_AreaOfConcern.BackColor = System.Drawing.Color.Transparent
        Me.uc_AreaOfConcern.iAdditional = Nothing
        Me.uc_AreaOfConcern.iArrow_Visible = True
        Me.uc_AreaOfConcern.iCanFindLabel_SQLIDx = 0
        Me.uc_AreaOfConcern.iCharacterLimit = 0
        Me.uc_AreaOfConcern.idsc = Me.uc_area_lbl
        Me.uc_AreaOfConcern.iForm = Me
        Me.uc_AreaOfConcern.iIsDropDown = True
        Me.uc_AreaOfConcern.iIsEnabled = False
        Me.uc_AreaOfConcern.iIsForSearch = True
        Me.uc_AreaOfConcern.iIsID = True
        Me.uc_AreaOfConcern.iIsInnerShow = True
        Me.uc_AreaOfConcern.iLabel = "Area Of Concern"
        Me.uc_AreaOfConcern.iLabel_width = 120
        Me.uc_AreaOfConcern.isAllowEmptyx = True
        Me.uc_AreaOfConcern.isForFind = False
        Me.uc_AreaOfConcern.iSQL_Parameter_ID = 65
        Me.uc_AreaOfConcern.iSQL_Parameter_ID_FIND = 0
        Me.uc_AreaOfConcern.isStayVisible = False
        Me.uc_AreaOfConcern.iText = ""
        Me.uc_AreaOfConcern.iTextBox_ = Me.uc_area_text
        Me.uc_AreaOfConcern.iTextBox_Sel_COL_ID = 0
        Me.uc_AreaOfConcern.iTitle = ""
        Me.uc_AreaOfConcern.LinkedColumn = "AreaOfConcern"
        Me.uc_AreaOfConcern.Location = New System.Drawing.Point(14, 160)
        Me.uc_AreaOfConcern.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_AreaOfConcern.Name = "uc_AreaOfConcern"
        Me.uc_AreaOfConcern.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_AreaOfConcern.Size = New System.Drawing.Size(166, 21)
        Me.uc_AreaOfConcern.TabIndex = 132
        '
        'uc_Station
        '
        Me.uc_Station.BackColor = System.Drawing.Color.Transparent
        Me.uc_Station.iAdditional = Nothing
        Me.uc_Station.iArrow_Visible = True
        Me.uc_Station.iCanFindLabel_SQLIDx = 0
        Me.uc_Station.iCharacterLimit = 0
        Me.uc_Station.idsc = Me.uc_station_lbl
        Me.uc_Station.iForm = Me
        Me.uc_Station.iIsDropDown = False
        Me.uc_Station.iIsEnabled = False
        Me.uc_Station.iIsForSearch = True
        Me.uc_Station.iIsID = True
        Me.uc_Station.iIsInnerShow = True
        Me.uc_Station.iLabel = "Station"
        Me.uc_Station.iLabel_width = 120
        Me.uc_Station.isAllowEmptyx = True
        Me.uc_Station.isForFind = False
        Me.uc_Station.iSQL_Parameter_ID = 32
        Me.uc_Station.iSQL_Parameter_ID_FIND = 0
        Me.uc_Station.isStayVisible = False
        Me.uc_Station.iText = ""
        Me.uc_Station.iTextBox_ = Me.uc_stations_text
        Me.uc_Station.iTextBox_Sel_COL_ID = 0
        Me.uc_Station.iTitle = ""
        Me.uc_Station.LinkedColumn = "Station"
        Me.uc_Station.Location = New System.Drawing.Point(14, 220)
        Me.uc_Station.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_Station.Name = "uc_Station"
        Me.uc_Station.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_Station.Size = New System.Drawing.Size(166, 21)
        Me.uc_Station.TabIndex = 132
        '
        'uc_Machine
        '
        Me.uc_Machine.BackColor = System.Drawing.Color.Transparent
        Me.uc_Machine.iAdditional = Nothing
        Me.uc_Machine.iArrow_Visible = True
        Me.uc_Machine.iCanFindLabel_SQLIDx = 0
        Me.uc_Machine.iCharacterLimit = 0
        Me.uc_Machine.idsc = Me.uc_machine_lbl
        Me.uc_Machine.iForm = Me
        Me.uc_Machine.iIsDropDown = False
        Me.uc_Machine.iIsEnabled = False
        Me.uc_Machine.iIsForSearch = True
        Me.uc_Machine.iIsID = True
        Me.uc_Machine.iIsInnerShow = True
        Me.uc_Machine.iLabel = "Machine/EQ"
        Me.uc_Machine.iLabel_width = 120
        Me.uc_Machine.isAllowEmptyx = True
        Me.uc_Machine.isForFind = False
        Me.uc_Machine.iSQL_Parameter_ID = 29
        Me.uc_Machine.iSQL_Parameter_ID_FIND = 0
        Me.uc_Machine.isStayVisible = False
        Me.uc_Machine.iText = ""
        Me.uc_Machine.iTextBox_ = Me.uc_machine_text
        Me.uc_Machine.iTextBox_Sel_COL_ID = 0
        Me.uc_Machine.iTitle = ""
        Me.uc_Machine.LinkedColumn = "Machine"
        Me.uc_Machine.Location = New System.Drawing.Point(14, 244)
        Me.uc_Machine.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_Machine.Name = "uc_Machine"
        Me.uc_Machine.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_Machine.Size = New System.Drawing.Size(166, 21)
        Me.uc_Machine.TabIndex = 131
        '
        'uc_requestedBy
        '
        Me.uc_requestedBy.BackColor = System.Drawing.Color.Transparent
        Me.uc_requestedBy.iAdditional = Nothing
        Me.uc_requestedBy.iArrow_Visible = False
        Me.uc_requestedBy.iCanFindLabel_SQLIDx = 0
        Me.uc_requestedBy.iCharacterLimit = 0
        Me.uc_requestedBy.idsc = Me.uc_req_by_lbl
        Me.uc_requestedBy.iForm = Me
        Me.uc_requestedBy.iIsDropDown = False
        Me.uc_requestedBy.iIsEnabled = False
        Me.uc_requestedBy.iIsForSearch = False
        Me.uc_requestedBy.iIsID = False
        Me.uc_requestedBy.iIsInnerShow = False
        Me.uc_requestedBy.iLabel = "Requested By"
        Me.uc_requestedBy.iLabel_width = 90
        Me.uc_requestedBy.isAllowEmptyx = True
        Me.uc_requestedBy.isForFind = False
        Me.uc_requestedBy.iSQL_Parameter_ID = 0
        Me.uc_requestedBy.iSQL_Parameter_ID_FIND = 0
        Me.uc_requestedBy.isStayVisible = False
        Me.uc_requestedBy.iText = ""
        Me.uc_requestedBy.iTextBox_ = Me.TextBox1
        Me.uc_requestedBy.iTextBox_Sel_COL_ID = 0
        Me.uc_requestedBy.iTitle = ""
        Me.uc_requestedBy.LinkedColumn = "requestedBy"
        Me.uc_requestedBy.Location = New System.Drawing.Point(14, 61)
        Me.uc_requestedBy.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_requestedBy.Name = "uc_requestedBy"
        Me.uc_requestedBy.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_requestedBy.Size = New System.Drawing.Size(131, 21)
        Me.uc_requestedBy.TabIndex = 130
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
        Me.Uc_label1.isLabelBoldx = False
        Me.Uc_label1.iSQL_Parameter_ID = 0
        Me.Uc_label1.iText = ""
        Me.Uc_label1.LinkedColumn = ""
        Me.Uc_label1.Location = New System.Drawing.Point(436, 27)
        Me.Uc_label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Uc_label1.Name = "Uc_label1"
        Me.Uc_label1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label1.Size = New System.Drawing.Size(23, 30)
        Me.Uc_label1.TabIndex = 1
        Me.Uc_label1.Visible = False
        '
        'Uc_lines3
        '
        Me.Uc_lines3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_lines3.BackColor = System.Drawing.Color.Transparent
        Me.Uc_lines3.iLabel = ""
        Me.Uc_lines3.isHighLight = False
        Me.Uc_lines3.iSize = 1
        Me.Uc_lines3.Location = New System.Drawing.Point(603, 324)
        Me.Uc_lines3.Name = "Uc_lines3"
        Me.Uc_lines3.PetSize = IpicIndirect.PetSize.Box
        Me.Uc_lines3.Size = New System.Drawing.Size(371, 144)
        Me.Uc_lines3.TabIndex = 172
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'Timer3
        '
        Me.Timer3.Interval = 500
        '
        'EDS_Ticketing_Sender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 499)
        Me.Controls.Add(Me.uc_notedBy_lbl)
        Me.Controls.Add(Me.uc_req_by_lbl)
        Me.Controls.Add(Me.uc_appointedTo_lbl)
        Me.Controls.Add(Me.dgv_x)
        Me.Controls.Add(Me.uc_maint_lbl)
        Me.Controls.Add(Me.uc_maint)
        Me.Controls.Add(Me.uc_maint_Text)
        Me.Controls.Add(Me.Uc_label2)
        Me.Controls.Add(Me.Uc_inputbox1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.uc_Parts)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.uc_statusofRep_lbl)
        Me.Controls.Add(Me.uc_StatusOfRepair)
        Me.Controls.Add(Me.uc_lbl)
        Me.Controls.Add(Me.txt_status)
        Me.Controls.Add(Me.uc_controlUsed)
        Me.Controls.Add(Me.uc_posibleHazard)
        Me.Controls.Add(Me.uc_riskLevel)
        Me.Controls.Add(Me.uc_severity_lbl)
        Me.Controls.Add(Me.uc_Likelihood)
        Me.Controls.Add(Me.uc_severity)
        Me.Controls.Add(Me.uc_Likelihood_lbl)
        Me.Controls.Add(Me.Uc_lines2)
        Me.Controls.Add(Me.txt_null)
        Me.Controls.Add(Me.uc_null)
        Me.Controls.Add(Me.uc_statusofRep_txt)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.uc_notedBy)
        Me.Controls.Add(Me.uc_IDENTITY)
        Me.Controls.Add(Me.conatiner_attach)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.uc_EndTime)
        Me.Controls.Add(Me.uc_StartTime)
        Me.Controls.Add(Me.uc_EndDate)
        Me.Controls.Add(Me.uc_StartDate)
        Me.Controls.Add(Me.uc_appointedTo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.uc_requestedTime)
        Me.Controls.Add(Me.uc_requestedDate)
        Me.Controls.Add(Me.uc_typeofTrouble_lbl)
        Me.Controls.Add(Me.uc_area_lbl)
        Me.Controls.Add(Me.uc_station_lbl)
        Me.Controls.Add(Me.uc_verifiedBy_lbl)
        Me.Controls.Add(Me.uc_subParts_lbl)
        Me.Controls.Add(Me.uc_machine_lbl)
        Me.Controls.Add(Me.uc_appointedTo2lbl)
        Me.Controls.Add(Me.uc_TypeOfTrouble)
        Me.Controls.Add(Me.uc_AreaOfConcern)
        Me.Controls.Add(Me.uc_Station)
        Me.Controls.Add(Me.uc_subParts_txt)
        Me.Controls.Add(Me.uc_machine_text)
        Me.Controls.Add(Me.uc_typeofTrouble_text)
        Me.Controls.Add(Me.uc_area_text)
        Me.Controls.Add(Me.uc_stations_text)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.uc_Machine)
        Me.Controls.Add(Me.uc_requestedBy)
        Me.Controls.Add(Me.Uc_label1)
        Me.Controls.Add(Me.Uc_lines3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(992, 538)
        Me.MinimumSize = New System.Drawing.Size(992, 538)
        Me.Name = "EDS_Ticketing_Sender"
        Me.Tag = ""
        Me.Text = " "
        Me.conatiner_attach.ResumeLayout(False)
        Me.conatiner_attach.PerformLayout()
        CType(Me.pic_attched, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_x, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_action.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Uc_label1 As uc_label
    Friend WithEvents msg As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_ok As Button
    Friend WithEvents conatiner_attach As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents lbl_attachedFile As Label
    Friend WithEvents pic_attched As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents uc_Machine As uc_inputbox
    Friend WithEvents uc_requestedBy As uc_inputbox
    Friend WithEvents uc_machine_lbl As uc_label
    Friend WithEvents uc_appointedTo2lbl As uc_label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents uc_requestedTime As uc_time
    Friend WithEvents uc_requestedDate As uc_date
    Friend WithEvents uc_station_lbl As uc_label
    Friend WithEvents uc_Station As uc_inputbox
    Friend WithEvents uc_appointedTo As uc_inputbox
    Friend WithEvents uc_lbl As uc_label
    Friend WithEvents txt_status As uc_inputbox
    Friend WithEvents uc_appointedTo_lbl As uc_label
    Friend WithEvents uc_req_by_lbl As uc_label
    Friend WithEvents uc_verifiedBy_lbl As uc_label
    Friend WithEvents uc_subParts_lbl As uc_label
    Friend WithEvents uc_Parts As uc_inputbox
    Friend WithEvents uc_notedBy_lbl As uc_label
    Friend WithEvents uc_notedBy As uc_inputbox
    Friend WithEvents uc_EndTime As uc_time
    Friend WithEvents uc_StartTime As uc_time
    Friend WithEvents uc_EndDate As uc_date
    Friend WithEvents uc_StartDate As uc_date
    Friend WithEvents uc_IDENTITY As uc_label
    Friend WithEvents uc_typeofTrouble_lbl As uc_label
    Friend WithEvents uc_area_lbl As uc_label
    Friend WithEvents uc_TypeOfTrouble As uc_inputbox
    Friend WithEvents uc_typeofTrouble_text As TextBox
    Friend WithEvents uc_AreaOfConcern As uc_inputbox
    Friend WithEvents uc_area_text As TextBox
    Friend WithEvents uc_stations_text As TextBox
    Friend WithEvents uc_subParts_txt As TextBox
    Friend WithEvents uc_machine_text As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents uc_riskLevel As uc_label
    Friend WithEvents uc_severity_lbl As uc_label
    Friend WithEvents uc_severity As uc_inputbox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents uc_Likelihood_lbl As uc_label
    Friend WithEvents uc_Likelihood As uc_inputbox
    Friend WithEvents Uc_lines2 As uc_lines
    Friend WithEvents txt_null As TextBox
    Friend WithEvents uc_null As uc_label
    Friend WithEvents uc_statusofRep_txt As TextBox
    Friend WithEvents uc_StatusOfRepair As uc_inputbox
    Friend WithEvents uc_statusofRep_lbl As uc_label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Uc_lines1 As uc_lines
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents uc_General_remarks As uc_label
    Friend WithEvents uc_Geberal_Findings As uc_label
    Friend WithEvents uc_General_Action As uc_label
    Friend WithEvents uc_controlUsed As uc_label
    Friend WithEvents uc_posibleHazard As uc_label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Uc_label2 As uc_label
    Friend WithEvents Uc_inputbox1 As uc_inputbox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Uc_lines3 As uc_lines
    Friend WithEvents uc_maint_lbl As uc_label
    Friend WithEvents uc_maint As uc_inputbox
    Friend WithEvents uc_maint_Text As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents dgv_x As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents cms_action As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents Timer3 As Timer
End Class
