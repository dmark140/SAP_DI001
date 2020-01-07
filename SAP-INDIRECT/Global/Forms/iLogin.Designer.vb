<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(iLogin))
        Me.txtUser = New System.Windows.Forms.MaskedTextBox()
        Me.txtPass = New System.Windows.Forms.MaskedTextBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtServerIP = New System.Windows.Forms.MaskedTextBox()
        Me.txtDbUserName = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDatabase = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Arrows = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_moreOption = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDbPassword = New System.Windows.Forms.MaskedTextBox()
        Me.t = New System.Windows.Forms.Label()
        Me.txtCompanyDB = New System.Windows.Forms.MaskedTextBox()
        Me.btn_createConIF = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.time_autoLokgin = New System.Windows.Forms.Timer(Me.components)
        Me.cb_IS_SAPLOGIN = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txt_moDuleFind = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_moDuleFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(169, 168)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(156, 20)
        Me.txtUser.TabIndex = 0
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(169, 194)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(156, 20)
        Me.txtPass.TabIndex = 1
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(331, 168)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(90, 21)
        Me.btn_ok.TabIndex = 25
        Me.btn_ok.Text = "OK"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(331, 194)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 21)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "CANCEL"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(109, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 17)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "User ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Password"
        '
        'txtServerIP
        '
        Me.txtServerIP.Location = New System.Drawing.Point(197, 310)
        Me.txtServerIP.Name = "txtServerIP"
        Me.txtServerIP.Size = New System.Drawing.Size(156, 20)
        Me.txtServerIP.TabIndex = 2
        '
        'txtDbUserName
        '
        Me.txtDbUserName.Location = New System.Drawing.Point(197, 362)
        Me.txtDbUserName.Name = "txtDbUserName"
        Me.txtDbUserName.Size = New System.Drawing.Size(156, 20)
        Me.txtDbUserName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Server IP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 364)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "DbUserName"
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(197, 336)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(156, 20)
        Me.txtDatabase.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(89, 338)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Database"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(530, 24)
        Me.Panel1.TabIndex = 40
        Me.Panel1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Log in"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(499, -2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(31, 31)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "X"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Arrows
        '
        Me.Arrows.ImageStream = CType(resources.GetObject("Arrows.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Arrows.TransparentColor = System.Drawing.Color.Transparent
        Me.Arrows.Images.SetKeyName(0, "arrow_up")
        Me.Arrows.Images.SetKeyName(1, "arrow_down")
        '
        'btn_moreOption
        '
        Me.btn_moreOption.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_moreOption.BackColor = System.Drawing.SystemColors.Control
        Me.btn_moreOption.BackgroundImage = Global.IpicIndirect.My.Resources.Resources.icons8_sort_down_18
        Me.btn_moreOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_moreOption.FlatAppearance.BorderSize = 0
        Me.btn_moreOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_moreOption.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_moreOption.ForeColor = System.Drawing.Color.White
        Me.btn_moreOption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_moreOption.Location = New System.Drawing.Point(499, 221)
        Me.btn_moreOption.Name = "btn_moreOption"
        Me.btn_moreOption.Size = New System.Drawing.Size(16, 15)
        Me.btn_moreOption.TabIndex = 43
        Me.btn_moreOption.Tag = "0"
        Me.btn_moreOption.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_moreOption.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_moreOption.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(89, 390)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 17)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "DbPassword"
        '
        'txtDbPassword
        '
        Me.txtDbPassword.Location = New System.Drawing.Point(197, 388)
        Me.txtDbPassword.Name = "txtDbPassword"
        Me.txtDbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDbPassword.Size = New System.Drawing.Size(156, 20)
        Me.txtDbPassword.TabIndex = 5
        '
        't
        '
        Me.t.AutoSize = True
        Me.t.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t.Location = New System.Drawing.Point(89, 416)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(84, 17)
        Me.t.TabIndex = 51
        Me.t.Text = "Company DB"
        '
        'txtCompanyDB
        '
        Me.txtCompanyDB.Location = New System.Drawing.Point(197, 414)
        Me.txtCompanyDB.Name = "txtCompanyDB"
        Me.txtCompanyDB.Size = New System.Drawing.Size(156, 20)
        Me.txtCompanyDB.TabIndex = 6
        '
        'btn_createConIF
        '
        Me.btn_createConIF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_createConIF.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_createConIF.FlatAppearance.BorderSize = 0
        Me.btn_createConIF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_createConIF.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_createConIF.ForeColor = System.Drawing.Color.White
        Me.btn_createConIF.Location = New System.Drawing.Point(197, 440)
        Me.btn_createConIF.Name = "btn_createConIF"
        Me.btn_createConIF.Size = New System.Drawing.Size(156, 21)
        Me.btn_createConIF.TabIndex = 52
        Me.btn_createConIF.Text = "OK"
        Me.btn_createConIF.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_createConIF.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_createConIF.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(89, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 16)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "SAP Connection String"
        '
        'time_autoLokgin
        '
        Me.time_autoLokgin.Interval = 200
        '
        'cb_IS_SAPLOGIN
        '
        Me.cb_IS_SAPLOGIN.AutoSize = True
        Me.cb_IS_SAPLOGIN.Location = New System.Drawing.Point(97, 151)
        Me.cb_IS_SAPLOGIN.Name = "cb_IS_SAPLOGIN"
        Me.cb_IS_SAPLOGIN.Size = New System.Drawing.Size(83, 17)
        Me.cb_IS_SAPLOGIN.TabIndex = 56
        Me.cb_IS_SAPLOGIN.Text = "SAP LOGIN"
        Me.cb_IS_SAPLOGIN.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label7.Location = New System.Drawing.Point(0, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(530, 15)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Label7"
        Me.Label7.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'txt_moDuleFind
        '
        Me.txt_moDuleFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txt_moDuleFind.Image = CType(resources.GetObject("txt_moDuleFind.Image"), System.Drawing.Image)
        Me.txt_moDuleFind.Location = New System.Drawing.Point(134, -20)
        Me.txt_moDuleFind.Name = "txt_moDuleFind"
        Me.txt_moDuleFind.Size = New System.Drawing.Size(287, 211)
        Me.txt_moDuleFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.txt_moDuleFind.TabIndex = 54
        Me.txt_moDuleFind.TabStop = False
        '
        'iLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(530, 254)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cb_IS_SAPLOGIN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_createConIF)
        Me.Controls.Add(Me.t)
        Me.Controls.Add(Me.txtCompanyDB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDbPassword)
        Me.Controls.Add(Me.btn_moreOption)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.txtDbUserName)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.txtServerIP)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txt_moDuleFind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "iLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "iLogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_moDuleFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUser As MaskedTextBox
    Friend WithEvents txtPass As MaskedTextBox
    Friend WithEvents btn_ok As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtServerIP As MaskedTextBox
    Friend WithEvents txtDbUserName As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDatabase As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_moreOption As Button
    Friend WithEvents Arrows As ImageList
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDbPassword As MaskedTextBox
    Friend WithEvents t As Label
    Friend WithEvents txtCompanyDB As MaskedTextBox
    Friend WithEvents btn_createConIF As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents time_autoLokgin As Timer
    Friend WithEvents txt_moDuleFind As PictureBox
    Friend WithEvents cb_IS_SAPLOGIN As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer2 As Timer
End Class
