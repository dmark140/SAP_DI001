<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SAP_CONNECTOR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SAP_CONNECTOR))
        Me.cb_IS_SAPLOGIN = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.MaskedTextBox()
        Me.txtUser = New System.Windows.Forms.MaskedTextBox()
        Me.txt_moDuleFind = New System.Windows.Forms.PictureBox()
        Me.lbl_db = New System.Windows.Forms.Label()
        Me.lbl_database = New System.Windows.Forms.Label()
        Me.lbl_constring = New System.Windows.Forms.Label()
        CType(Me.txt_moDuleFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb_IS_SAPLOGIN
        '
        Me.cb_IS_SAPLOGIN.AutoSize = True
        Me.cb_IS_SAPLOGIN.Checked = True
        Me.cb_IS_SAPLOGIN.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_IS_SAPLOGIN.Enabled = False
        Me.cb_IS_SAPLOGIN.Location = New System.Drawing.Point(129, 97)
        Me.cb_IS_SAPLOGIN.Name = "cb_IS_SAPLOGIN"
        Me.cb_IS_SAPLOGIN.Size = New System.Drawing.Size(83, 17)
        Me.cb_IS_SAPLOGIN.TabIndex = 64
        Me.cb_IS_SAPLOGIN.Text = "SAP LOGIN"
        Me.cb_IS_SAPLOGIN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(141, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 17)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "User ID"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(363, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 21)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "CANCEL"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(363, 114)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(90, 21)
        Me.btn_ok.TabIndex = 60
        Me.btn_ok.Text = "OK"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(201, 140)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(156, 20)
        Me.txtPass.TabIndex = 58
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(201, 114)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(156, 20)
        Me.txtUser.TabIndex = 57
        '
        'txt_moDuleFind
        '
        Me.txt_moDuleFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txt_moDuleFind.Image = CType(resources.GetObject("txt_moDuleFind.Image"), System.Drawing.Image)
        Me.txt_moDuleFind.Location = New System.Drawing.Point(232, 12)
        Me.txt_moDuleFind.Name = "txt_moDuleFind"
        Me.txt_moDuleFind.Size = New System.Drawing.Size(125, 96)
        Me.txt_moDuleFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.txt_moDuleFind.TabIndex = 63
        Me.txt_moDuleFind.TabStop = False
        '
        'lbl_db
        '
        Me.lbl_db.AutoSize = True
        Me.lbl_db.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_db.Location = New System.Drawing.Point(201, 163)
        Me.lbl_db.Name = "lbl_db"
        Me.lbl_db.Size = New System.Drawing.Size(172, 17)
        Me.lbl_db.TabIndex = 65
        Me.lbl_db.Text = "NOTE: Something Goes here"
        '
        'lbl_database
        '
        Me.lbl_database.AutoSize = True
        Me.lbl_database.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_database.Location = New System.Drawing.Point(201, 180)
        Me.lbl_database.Name = "lbl_database"
        Me.lbl_database.Size = New System.Drawing.Size(172, 17)
        Me.lbl_database.TabIndex = 65
        Me.lbl_database.Text = "NOTE: Something Goes here"
        '
        'lbl_constring
        '
        Me.lbl_constring.AutoSize = True
        Me.lbl_constring.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_constring.Location = New System.Drawing.Point(201, 197)
        Me.lbl_constring.Name = "lbl_constring"
        Me.lbl_constring.Size = New System.Drawing.Size(172, 17)
        Me.lbl_constring.TabIndex = 65
        Me.lbl_constring.Text = "NOTE: Something Goes here"
        '
        'SAP_CONNECTOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 237)
        Me.Controls.Add(Me.lbl_constring)
        Me.Controls.Add(Me.lbl_database)
        Me.Controls.Add(Me.lbl_db)
        Me.Controls.Add(Me.cb_IS_SAPLOGIN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txt_moDuleFind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "SAP_CONNECTOR"
        Me.Text = "SAP CONNECTOR"
        CType(Me.txt_moDuleFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_IS_SAPLOGIN As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_ok As Button
    Friend WithEvents txtPass As MaskedTextBox
    Friend WithEvents txtUser As MaskedTextBox
    Friend WithEvents txt_moDuleFind As PictureBox
    Friend WithEvents lbl_db As Label
    Friend WithEvents lbl_database As Label
    Friend WithEvents lbl_constring As Label
End Class
