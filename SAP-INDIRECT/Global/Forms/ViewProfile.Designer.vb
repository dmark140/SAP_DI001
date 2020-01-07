<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewProfile
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewProfile))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.uc_lbl_null = New IpicIndirect.uc_label()
        Me.txtnull = New System.Windows.Forms.TextBox()
        Me.uc_machine_lbl = New IpicIndirect.uc_label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Uc_label1 = New IpicIndirect.uc_label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Uc_inputbox2 = New IpicIndirect.uc_inputbox()
        Me.Uc_inputbox1 = New IpicIndirect.uc_inputbox()
        Me.uc_Departmet = New IpicIndirect.uc_inputbox()
        Me.uc_pass2 = New IpicIndirect.uc_inputbox()
        Me.uc_username = New IpicIndirect.uc_inputbox()
        Me.uc_pass1 = New IpicIndirect.uc_inputbox()
        Me.uc_lname = New IpicIndirect.uc_inputbox()
        Me.uc_mname = New IpicIndirect.uc_inputbox()
        Me.uc_fname = New IpicIndirect.uc_inputbox()
        Me.Uc_lines1 = New IpicIndirect.uc_lines()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(153, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 21)
        Me.Button1.TabIndex = 187
        Me.Button1.Tag = "0"
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "icons8-spam-96.png")
        Me.ImageList2.Images.SetKeyName(1, "icons8-error-96.png")
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 4)
        Me.Label1.TabIndex = 188
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(309, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(20, 18)
        Me.Button2.TabIndex = 189
        Me.Button2.Tag = "0"
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'btn_ok
        '
        Me.btn_ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btn_ok.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.Black
        Me.btn_ok.Image = Global.IpicIndirect.My.Resources.Resources.btn_bar1
        Me.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ok.Location = New System.Drawing.Point(28, 321)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(101, 21)
        Me.btn_ok.TabIndex = 186
        Me.btn_ok.Tag = "0"
        Me.btn_ok.Text = "Confirm"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'uc_lbl_null
        '
        Me.uc_lbl_null.BackColor = System.Drawing.Color.Transparent
        Me.uc_lbl_null.iAddition_SQL = Nothing
        Me.uc_lbl_null.iAdditional = Nothing
        Me.uc_lbl_null.idsc = Nothing
        Me.uc_lbl_null.iIsEnabled = True
        Me.uc_lbl_null.iIsForSearch = False
        Me.uc_lbl_null.iLabel = "Edit iLbl to edit me"
        Me.uc_lbl_null.iLabel_width = 0
        Me.uc_lbl_null.isLabelBoldx = False
        Me.uc_lbl_null.iSQL_Parameter_ID = 0
        Me.uc_lbl_null.iText = ""
        Me.uc_lbl_null.LinkedColumn = ""
        Me.uc_lbl_null.Location = New System.Drawing.Point(241, 286)
        Me.uc_lbl_null.Name = "uc_lbl_null"
        Me.uc_lbl_null.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_lbl_null.Size = New System.Drawing.Size(19, 30)
        Me.uc_lbl_null.TabIndex = 192
        Me.uc_lbl_null.Visible = False
        '
        'txtnull
        '
        Me.txtnull.Location = New System.Drawing.Point(266, 286)
        Me.txtnull.Name = "txtnull"
        Me.txtnull.Size = New System.Drawing.Size(19, 20)
        Me.txtnull.TabIndex = 195
        Me.txtnull.Visible = False
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
        Me.uc_machine_lbl.Location = New System.Drawing.Point(153, 254)
        Me.uc_machine_lbl.Margin = New System.Windows.Forms.Padding(4)
        Me.uc_machine_lbl.Name = "uc_machine_lbl"
        Me.uc_machine_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_machine_lbl.Size = New System.Drawing.Size(147, 21)
        Me.uc_machine_lbl.TabIndex = 202
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(200, 286)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(26, 20)
        Me.TextBox1.TabIndex = 201
        Me.TextBox1.Text = "O"
        Me.TextBox1.Visible = False
        '
        'Uc_label1
        '
        Me.Uc_label1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label1.iAddition_SQL = Nothing
        Me.Uc_label1.iAdditional = Nothing
        Me.Uc_label1.idsc = Nothing
        Me.Uc_label1.iIsEnabled = False
        Me.Uc_label1.iIsForSearch = False
        Me.Uc_label1.iLabel = "Edit iLbl to edit me"
        Me.Uc_label1.iLabel_width = 5
        Me.Uc_label1.isLabelBoldx = False
        Me.Uc_label1.iSQL_Parameter_ID = 0
        Me.Uc_label1.iText = ""
        Me.Uc_label1.LinkedColumn = ""
        Me.Uc_label1.Location = New System.Drawing.Point(153, 25)
        Me.Uc_label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Uc_label1.Name = "Uc_label1"
        Me.Uc_label1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label1.Size = New System.Drawing.Size(147, 21)
        Me.Uc_label1.TabIndex = 206
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(175, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 207
        Me.TextBox2.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Uc_inputbox2
        '
        Me.Uc_inputbox2.BackColor = System.Drawing.Color.Transparent
        Me.Uc_inputbox2.iAdditional = Nothing
        Me.Uc_inputbox2.iArrow_Visible = True
        Me.Uc_inputbox2.iCanFindLabel_SQLIDx = 0
        Me.Uc_inputbox2.iCharacterLimit = 0
        Me.Uc_inputbox2.idsc = Me.Uc_label1
        Me.Uc_inputbox2.iForm = Me
        Me.Uc_inputbox2.iIsDropDown = False
        Me.Uc_inputbox2.iIsEnabled = False
        Me.Uc_inputbox2.iIsForSearch = True
        Me.Uc_inputbox2.iIsID = True
        Me.Uc_inputbox2.iIsInnerShow = False
        Me.Uc_inputbox2.iLabel = "ID"
        Me.Uc_inputbox2.iLabel_width = 40
        Me.Uc_inputbox2.isAllowEmptyx = False
        Me.Uc_inputbox2.isForFind = False
        Me.Uc_inputbox2.iSQL_Parameter_ID = 82
        Me.Uc_inputbox2.iSQL_Parameter_ID_FIND = 82
        Me.Uc_inputbox2.isStayVisible = False
        Me.Uc_inputbox2.iText = ""
        Me.Uc_inputbox2.iTextBox_ = Me.TextBox2
        Me.Uc_inputbox2.iTextBox_Sel_COL_ID = 0
        Me.Uc_inputbox2.iTitle = ""
        Me.Uc_inputbox2.LinkedColumn = ""
        Me.Uc_inputbox2.Location = New System.Drawing.Point(27, 25)
        Me.Uc_inputbox2.Margin = New System.Windows.Forms.Padding(0)
        Me.Uc_inputbox2.Name = "Uc_inputbox2"
        Me.Uc_inputbox2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_inputbox2.Size = New System.Drawing.Size(125, 21)
        Me.Uc_inputbox2.TabIndex = 205
        '
        'Uc_inputbox1
        '
        Me.Uc_inputbox1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_inputbox1.iAdditional = Nothing
        Me.Uc_inputbox1.iArrow_Visible = False
        Me.Uc_inputbox1.iCanFindLabel_SQLIDx = 0
        Me.Uc_inputbox1.iCharacterLimit = 0
        Me.Uc_inputbox1.idsc = Nothing
        Me.Uc_inputbox1.iForm = Nothing
        Me.Uc_inputbox1.iIsDropDown = False
        Me.Uc_inputbox1.iIsEnabled = True
        Me.Uc_inputbox1.iIsForSearch = False
        Me.Uc_inputbox1.iIsID = False
        Me.Uc_inputbox1.iIsInnerShow = False
        Me.Uc_inputbox1.iLabel = "Mobile Number"
        Me.Uc_inputbox1.iLabel_width = 85
        Me.Uc_inputbox1.isAllowEmptyx = False
        Me.Uc_inputbox1.isForFind = False
        Me.Uc_inputbox1.iSQL_Parameter_ID = 0
        Me.Uc_inputbox1.iSQL_Parameter_ID_FIND = 0
        Me.Uc_inputbox1.isStayVisible = False
        Me.Uc_inputbox1.iText = ""
        Me.Uc_inputbox1.iTextBox_ = Me.txtnull
        Me.Uc_inputbox1.iTextBox_Sel_COL_ID = 0
        Me.Uc_inputbox1.iTitle = ""
        Me.Uc_inputbox1.LinkedColumn = ""
        Me.Uc_inputbox1.Location = New System.Drawing.Point(26, 278)
        Me.Uc_inputbox1.Name = "Uc_inputbox1"
        Me.Uc_inputbox1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_inputbox1.Size = New System.Drawing.Size(273, 23)
        Me.Uc_inputbox1.TabIndex = 203
        '
        'uc_Departmet
        '
        Me.uc_Departmet.BackColor = System.Drawing.Color.Transparent
        Me.uc_Departmet.iAdditional = Nothing
        Me.uc_Departmet.iArrow_Visible = True
        Me.uc_Departmet.iCanFindLabel_SQLIDx = 0
        Me.uc_Departmet.iCharacterLimit = 0
        Me.uc_Departmet.idsc = Me.uc_machine_lbl
        Me.uc_Departmet.iForm = Me
        Me.uc_Departmet.iIsDropDown = False
        Me.uc_Departmet.iIsEnabled = False
        Me.uc_Departmet.iIsForSearch = True
        Me.uc_Departmet.iIsID = True
        Me.uc_Departmet.iIsInnerShow = False
        Me.uc_Departmet.iLabel = "Department"
        Me.uc_Departmet.iLabel_width = 85
        Me.uc_Departmet.isAllowEmptyx = False
        Me.uc_Departmet.isForFind = False
        Me.uc_Departmet.iSQL_Parameter_ID = 52
        Me.uc_Departmet.iSQL_Parameter_ID_FIND = 0
        Me.uc_Departmet.isStayVisible = False
        Me.uc_Departmet.iText = ""
        Me.uc_Departmet.iTextBox_ = Me.TextBox1
        Me.uc_Departmet.iTextBox_Sel_COL_ID = 0
        Me.uc_Departmet.iTitle = ""
        Me.uc_Departmet.LinkedColumn = ""
        Me.uc_Departmet.Location = New System.Drawing.Point(27, 254)
        Me.uc_Departmet.Margin = New System.Windows.Forms.Padding(0)
        Me.uc_Departmet.Name = "uc_Departmet"
        Me.uc_Departmet.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_Departmet.Size = New System.Drawing.Size(125, 21)
        Me.uc_Departmet.TabIndex = 200
        '
        'uc_pass2
        '
        Me.uc_pass2.BackColor = System.Drawing.Color.Transparent
        Me.uc_pass2.iAdditional = Nothing
        Me.uc_pass2.iArrow_Visible = False
        Me.uc_pass2.iCanFindLabel_SQLIDx = 0
        Me.uc_pass2.iCharacterLimit = 0
        Me.uc_pass2.idsc = Nothing
        Me.uc_pass2.iForm = Nothing
        Me.uc_pass2.iIsDropDown = False
        Me.uc_pass2.iIsEnabled = True
        Me.uc_pass2.iIsForSearch = False
        Me.uc_pass2.iIsID = False
        Me.uc_pass2.iIsInnerShow = False
        Me.uc_pass2.iLabel = "Re-Password"
        Me.uc_pass2.iLabel_width = 85
        Me.uc_pass2.isAllowEmptyx = False
        Me.uc_pass2.isForFind = False
        Me.uc_pass2.iSQL_Parameter_ID = 0
        Me.uc_pass2.iSQL_Parameter_ID_FIND = 0
        Me.uc_pass2.isStayVisible = False
        Me.uc_pass2.iText = ""
        Me.uc_pass2.iTextBox_ = Me.txtnull
        Me.uc_pass2.iTextBox_Sel_COL_ID = 0
        Me.uc_pass2.iTitle = ""
        Me.uc_pass2.LinkedColumn = ""
        Me.uc_pass2.Location = New System.Drawing.Point(30, 224)
        Me.uc_pass2.Name = "uc_pass2"
        Me.uc_pass2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_pass2.Size = New System.Drawing.Size(270, 23)
        Me.uc_pass2.TabIndex = 198
        '
        'uc_username
        '
        Me.uc_username.BackColor = System.Drawing.Color.Transparent
        Me.uc_username.iAdditional = Nothing
        Me.uc_username.iArrow_Visible = False
        Me.uc_username.iCanFindLabel_SQLIDx = 0
        Me.uc_username.iCharacterLimit = 0
        Me.uc_username.idsc = Nothing
        Me.uc_username.iForm = Nothing
        Me.uc_username.iIsDropDown = False
        Me.uc_username.iIsEnabled = False
        Me.uc_username.iIsForSearch = False
        Me.uc_username.iIsID = False
        Me.uc_username.iIsInnerShow = False
        Me.uc_username.iLabel = "Username"
        Me.uc_username.iLabel_width = 85
        Me.uc_username.isAllowEmptyx = True
        Me.uc_username.isForFind = False
        Me.uc_username.iSQL_Parameter_ID = 0
        Me.uc_username.iSQL_Parameter_ID_FIND = 0
        Me.uc_username.isStayVisible = False
        Me.uc_username.iText = ""
        Me.uc_username.iTextBox_ = Me.txtnull
        Me.uc_username.iTextBox_Sel_COL_ID = 0
        Me.uc_username.iTitle = ""
        Me.uc_username.LinkedColumn = ""
        Me.uc_username.Location = New System.Drawing.Point(30, 166)
        Me.uc_username.Name = "uc_username"
        Me.uc_username.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_username.Size = New System.Drawing.Size(270, 23)
        Me.uc_username.TabIndex = 196
        '
        'uc_pass1
        '
        Me.uc_pass1.BackColor = System.Drawing.Color.Transparent
        Me.uc_pass1.iAdditional = Nothing
        Me.uc_pass1.iArrow_Visible = False
        Me.uc_pass1.iCanFindLabel_SQLIDx = 0
        Me.uc_pass1.iCharacterLimit = 0
        Me.uc_pass1.idsc = Nothing
        Me.uc_pass1.iForm = Nothing
        Me.uc_pass1.iIsDropDown = False
        Me.uc_pass1.iIsEnabled = True
        Me.uc_pass1.iIsForSearch = False
        Me.uc_pass1.iIsID = False
        Me.uc_pass1.iIsInnerShow = False
        Me.uc_pass1.iLabel = "Password"
        Me.uc_pass1.iLabel_width = 85
        Me.uc_pass1.isAllowEmptyx = False
        Me.uc_pass1.isForFind = False
        Me.uc_pass1.iSQL_Parameter_ID = 0
        Me.uc_pass1.iSQL_Parameter_ID_FIND = 0
        Me.uc_pass1.isStayVisible = False
        Me.uc_pass1.iText = ""
        Me.uc_pass1.iTextBox_ = Me.txtnull
        Me.uc_pass1.iTextBox_Sel_COL_ID = 0
        Me.uc_pass1.iTitle = ""
        Me.uc_pass1.LinkedColumn = ""
        Me.uc_pass1.Location = New System.Drawing.Point(30, 195)
        Me.uc_pass1.Name = "uc_pass1"
        Me.uc_pass1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_pass1.Size = New System.Drawing.Size(270, 23)
        Me.uc_pass1.TabIndex = 197
        '
        'uc_lname
        '
        Me.uc_lname.BackColor = System.Drawing.Color.Transparent
        Me.uc_lname.iAdditional = Nothing
        Me.uc_lname.iArrow_Visible = False
        Me.uc_lname.iCanFindLabel_SQLIDx = 0
        Me.uc_lname.iCharacterLimit = 0
        Me.uc_lname.idsc = Nothing
        Me.uc_lname.iForm = Nothing
        Me.uc_lname.iIsDropDown = False
        Me.uc_lname.iIsEnabled = False
        Me.uc_lname.iIsForSearch = False
        Me.uc_lname.iIsID = False
        Me.uc_lname.iIsInnerShow = False
        Me.uc_lname.iLabel = "Last name"
        Me.uc_lname.iLabel_width = 85
        Me.uc_lname.isAllowEmptyx = False
        Me.uc_lname.isForFind = False
        Me.uc_lname.iSQL_Parameter_ID = 0
        Me.uc_lname.iSQL_Parameter_ID_FIND = 0
        Me.uc_lname.isStayVisible = False
        Me.uc_lname.iText = ""
        Me.uc_lname.iTextBox_ = Me.txtnull
        Me.uc_lname.iTextBox_Sel_COL_ID = 0
        Me.uc_lname.iTitle = ""
        Me.uc_lname.LinkedColumn = ""
        Me.uc_lname.Location = New System.Drawing.Point(29, 122)
        Me.uc_lname.Name = "uc_lname"
        Me.uc_lname.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_lname.Size = New System.Drawing.Size(270, 23)
        Me.uc_lname.TabIndex = 194
        '
        'uc_mname
        '
        Me.uc_mname.BackColor = System.Drawing.Color.Transparent
        Me.uc_mname.iAdditional = Nothing
        Me.uc_mname.iArrow_Visible = False
        Me.uc_mname.iCanFindLabel_SQLIDx = 0
        Me.uc_mname.iCharacterLimit = 0
        Me.uc_mname.idsc = Nothing
        Me.uc_mname.iForm = Nothing
        Me.uc_mname.iIsDropDown = False
        Me.uc_mname.iIsEnabled = False
        Me.uc_mname.iIsForSearch = False
        Me.uc_mname.iIsID = False
        Me.uc_mname.iIsInnerShow = False
        Me.uc_mname.iLabel = "Midle name"
        Me.uc_mname.iLabel_width = 85
        Me.uc_mname.isAllowEmptyx = True
        Me.uc_mname.isForFind = False
        Me.uc_mname.iSQL_Parameter_ID = 0
        Me.uc_mname.iSQL_Parameter_ID_FIND = 0
        Me.uc_mname.isStayVisible = False
        Me.uc_mname.iText = ""
        Me.uc_mname.iTextBox_ = Me.txtnull
        Me.uc_mname.iTextBox_Sel_COL_ID = 0
        Me.uc_mname.iTitle = ""
        Me.uc_mname.LinkedColumn = ""
        Me.uc_mname.Location = New System.Drawing.Point(29, 93)
        Me.uc_mname.Name = "uc_mname"
        Me.uc_mname.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_mname.Size = New System.Drawing.Size(270, 23)
        Me.uc_mname.TabIndex = 193
        '
        'uc_fname
        '
        Me.uc_fname.BackColor = System.Drawing.Color.Transparent
        Me.uc_fname.iAdditional = Nothing
        Me.uc_fname.iArrow_Visible = False
        Me.uc_fname.iCanFindLabel_SQLIDx = 0
        Me.uc_fname.iCharacterLimit = 0
        Me.uc_fname.idsc = Nothing
        Me.uc_fname.iForm = Nothing
        Me.uc_fname.iIsDropDown = False
        Me.uc_fname.iIsEnabled = False
        Me.uc_fname.iIsForSearch = False
        Me.uc_fname.iIsID = False
        Me.uc_fname.iIsInnerShow = False
        Me.uc_fname.iLabel = "First name"
        Me.uc_fname.iLabel_width = 85
        Me.uc_fname.isAllowEmptyx = False
        Me.uc_fname.isForFind = False
        Me.uc_fname.iSQL_Parameter_ID = 0
        Me.uc_fname.iSQL_Parameter_ID_FIND = 0
        Me.uc_fname.isStayVisible = False
        Me.uc_fname.iText = ""
        Me.uc_fname.iTextBox_ = Me.txtnull
        Me.uc_fname.iTextBox_Sel_COL_ID = 0
        Me.uc_fname.iTitle = ""
        Me.uc_fname.LinkedColumn = ""
        Me.uc_fname.Location = New System.Drawing.Point(29, 64)
        Me.uc_fname.Name = "uc_fname"
        Me.uc_fname.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_fname.Size = New System.Drawing.Size(270, 23)
        Me.uc_fname.TabIndex = 191
        '
        'Uc_lines1
        '
        Me.Uc_lines1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_lines1.iLabel = "User Profile"
        Me.Uc_lines1.isHighLight = True
        Me.Uc_lines1.iSize = 1
        Me.Uc_lines1.Location = New System.Drawing.Point(0, 6)
        Me.Uc_lines1.Name = "Uc_lines1"
        Me.Uc_lines1.PetSize = IpicIndirect.PetSize.Box
        Me.Uc_lines1.Size = New System.Drawing.Size(327, 320)
        Me.Uc_lines1.TabIndex = 204
        '
        'ViewProfile
        '
        Me.AcceptButton = Me.btn_ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(328, 354)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Uc_label1)
        Me.Controls.Add(Me.Uc_inputbox2)
        Me.Controls.Add(Me.Uc_inputbox1)
        Me.Controls.Add(Me.uc_machine_lbl)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.uc_Departmet)
        Me.Controls.Add(Me.uc_pass2)
        Me.Controls.Add(Me.uc_username)
        Me.Controls.Add(Me.uc_pass1)
        Me.Controls.Add(Me.uc_lname)
        Me.Controls.Add(Me.uc_mname)
        Me.Controls.Add(Me.uc_fname)
        Me.Controls.Add(Me.txtnull)
        Me.Controls.Add(Me.uc_lbl_null)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Uc_lines1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ViewProfile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_ok As Button
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Uc_inputbox1 As uc_inputbox
    Friend WithEvents uc_lbl_null As uc_label
    Friend WithEvents txtnull As TextBox
    Friend WithEvents uc_machine_lbl As uc_label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents uc_Departmet As uc_inputbox
    Friend WithEvents uc_pass2 As uc_inputbox
    Friend WithEvents uc_username As uc_inputbox
    Friend WithEvents uc_pass1 As uc_inputbox
    Friend WithEvents uc_lname As uc_inputbox
    Friend WithEvents uc_mname As uc_inputbox
    Friend WithEvents uc_fname As uc_inputbox
    Friend WithEvents Uc_lines1 As uc_lines
    Friend WithEvents Uc_label1 As uc_label
    Friend WithEvents Uc_inputbox2 As uc_inputbox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Timer1 As Timer
End Class
