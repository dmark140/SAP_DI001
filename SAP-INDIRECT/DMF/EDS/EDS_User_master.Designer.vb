<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EDS_User_master
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtnull = New System.Windows.Forms.TextBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.uc_pass2 = New IpicIndirect.uc_inputbox()
        Me.uc_lbl_null = New IpicIndirect.uc_label()
        Me.uc_username = New IpicIndirect.uc_inputbox()
        Me.uc_pass1 = New IpicIndirect.uc_inputbox()
        Me.uc_lname = New IpicIndirect.uc_inputbox()
        Me.uc_mname = New IpicIndirect.uc_inputbox()
        Me.uc_fname = New IpicIndirect.uc_inputbox()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtnull
        '
        Me.txtnull.Location = New System.Drawing.Point(12, 255)
        Me.txtnull.Name = "txtnull"
        Me.txtnull.Size = New System.Drawing.Size(82, 20)
        Me.txtnull.TabIndex = 3
        Me.txtnull.Visible = False
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(190, 248)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(92, 24)
        Me.btn_ok.TabIndex = 7
        Me.btn_ok.Text = "&OK"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'uc_pass2
        '
        Me.uc_pass2.BackColor = System.Drawing.Color.Transparent
        Me.uc_pass2.iAddition_SQL = Nothing
        Me.uc_pass2.iAdditional = Nothing
        Me.uc_pass2.iArrow_Visible = False
        Me.uc_pass2.iCanFindLabel_SQLIDx = 0
        Me.uc_pass2.iCharacterLimit = 0
        Me.uc_pass2.idsc = Me.uc_lbl_null
        Me.uc_pass2.iForm = Me
        Me.uc_pass2.iIsDropDown = False
        Me.uc_pass2.iIsEnabled = True
        Me.uc_pass2.iIsForSearch = False
        Me.uc_pass2.iIsID = False
        Me.uc_pass2.iIsInnerShow = False
        Me.uc_pass2.iLabel = "Re-Password"
        Me.uc_pass2.iLabel_width = 100
        Me.uc_pass2.isForFind = False
        Me.uc_pass2.iSQL_Parameter_ID = 0
        Me.uc_pass2.iText = ""
        Me.uc_pass2.iTextBox_ = Me.txtnull
        Me.uc_pass2.iTextBox_Sel_COL_ID = 0
        Me.uc_pass2.iTitle = ""
        Me.uc_pass2.Location = New System.Drawing.Point(12, 204)
        Me.uc_pass2.Name = "uc_pass2"
        Me.uc_pass2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_pass2.Size = New System.Drawing.Size(270, 23)
        Me.uc_pass2.TabIndex = 6
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
        Me.uc_lbl_null.iSQL_Parameter_ID = 0
        Me.uc_lbl_null.iText = ""
        Me.uc_lbl_null.Location = New System.Drawing.Point(12, 233)
        Me.uc_lbl_null.Name = "uc_lbl_null"
        Me.uc_lbl_null.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_lbl_null.Size = New System.Drawing.Size(82, 30)
        Me.uc_lbl_null.TabIndex = 0
        Me.uc_lbl_null.Visible = False
        '
        'uc_username
        '
        Me.uc_username.BackColor = System.Drawing.Color.Transparent
        Me.uc_username.iAddition_SQL = Nothing
        Me.uc_username.iAdditional = Nothing
        Me.uc_username.iArrow_Visible = False
        Me.uc_username.iCanFindLabel_SQLIDx = 0
        Me.uc_username.iCharacterLimit = 0
        Me.uc_username.idsc = Me.uc_lbl_null
        Me.uc_username.iForm = Me
        Me.uc_username.iIsDropDown = False
        Me.uc_username.iIsEnabled = False
        Me.uc_username.iIsForSearch = False
        Me.uc_username.iIsID = False
        Me.uc_username.iIsInnerShow = False
        Me.uc_username.iLabel = "Username"
        Me.uc_username.iLabel_width = 100
        Me.uc_username.isForFind = False
        Me.uc_username.iSQL_Parameter_ID = 0
        Me.uc_username.iText = ""
        Me.uc_username.iTextBox_ = Me.txtnull
        Me.uc_username.iTextBox_Sel_COL_ID = 0
        Me.uc_username.iTitle = ""
        Me.uc_username.Location = New System.Drawing.Point(12, 146)
        Me.uc_username.Name = "uc_username"
        Me.uc_username.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_username.Size = New System.Drawing.Size(270, 23)
        Me.uc_username.TabIndex = 4
        '
        'uc_pass1
        '
        Me.uc_pass1.BackColor = System.Drawing.Color.Transparent
        Me.uc_pass1.iAddition_SQL = Nothing
        Me.uc_pass1.iAdditional = Nothing
        Me.uc_pass1.iArrow_Visible = False
        Me.uc_pass1.iCanFindLabel_SQLIDx = 0
        Me.uc_pass1.iCharacterLimit = 0
        Me.uc_pass1.idsc = Me.uc_lbl_null
        Me.uc_pass1.iForm = Me
        Me.uc_pass1.iIsDropDown = False
        Me.uc_pass1.iIsEnabled = True
        Me.uc_pass1.iIsForSearch = False
        Me.uc_pass1.iIsID = False
        Me.uc_pass1.iIsInnerShow = False
        Me.uc_pass1.iLabel = "Password"
        Me.uc_pass1.iLabel_width = 100
        Me.uc_pass1.isForFind = False
        Me.uc_pass1.iSQL_Parameter_ID = 0
        Me.uc_pass1.iText = ""
        Me.uc_pass1.iTextBox_ = Me.txtnull
        Me.uc_pass1.iTextBox_Sel_COL_ID = 0
        Me.uc_pass1.iTitle = ""
        Me.uc_pass1.Location = New System.Drawing.Point(12, 175)
        Me.uc_pass1.Name = "uc_pass1"
        Me.uc_pass1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_pass1.Size = New System.Drawing.Size(270, 23)
        Me.uc_pass1.TabIndex = 5
        '
        'uc_lname
        '
        Me.uc_lname.BackColor = System.Drawing.Color.Transparent
        Me.uc_lname.iAddition_SQL = Nothing
        Me.uc_lname.iAdditional = Nothing
        Me.uc_lname.iArrow_Visible = False
        Me.uc_lname.iCanFindLabel_SQLIDx = 0
        Me.uc_lname.iCharacterLimit = 0
        Me.uc_lname.idsc = Me.uc_lbl_null
        Me.uc_lname.iForm = Me
        Me.uc_lname.iIsDropDown = False
        Me.uc_lname.iIsEnabled = True
        Me.uc_lname.iIsForSearch = False
        Me.uc_lname.iIsID = False
        Me.uc_lname.iIsInnerShow = False
        Me.uc_lname.iLabel = "Last name"
        Me.uc_lname.iLabel_width = 100
        Me.uc_lname.isForFind = False
        Me.uc_lname.iSQL_Parameter_ID = 0
        Me.uc_lname.iText = ""
        Me.uc_lname.iTextBox_ = Me.txtnull
        Me.uc_lname.iTextBox_Sel_COL_ID = 0
        Me.uc_lname.iTitle = ""
        Me.uc_lname.Location = New System.Drawing.Point(12, 90)
        Me.uc_lname.Name = "uc_lname"
        Me.uc_lname.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_lname.Size = New System.Drawing.Size(270, 23)
        Me.uc_lname.TabIndex = 3
        '
        'uc_mname
        '
        Me.uc_mname.BackColor = System.Drawing.Color.Transparent
        Me.uc_mname.iAddition_SQL = Nothing
        Me.uc_mname.iAdditional = Nothing
        Me.uc_mname.iArrow_Visible = False
        Me.uc_mname.iCanFindLabel_SQLIDx = 0
        Me.uc_mname.iCharacterLimit = 0
        Me.uc_mname.idsc = Me.uc_lbl_null
        Me.uc_mname.iForm = Me
        Me.uc_mname.iIsDropDown = False
        Me.uc_mname.iIsEnabled = True
        Me.uc_mname.iIsForSearch = False
        Me.uc_mname.iIsID = False
        Me.uc_mname.iIsInnerShow = False
        Me.uc_mname.iLabel = "Midle name"
        Me.uc_mname.iLabel_width = 100
        Me.uc_mname.isForFind = False
        Me.uc_mname.iSQL_Parameter_ID = 0
        Me.uc_mname.iText = ""
        Me.uc_mname.iTextBox_ = Me.txtnull
        Me.uc_mname.iTextBox_Sel_COL_ID = 0
        Me.uc_mname.iTitle = ""
        Me.uc_mname.Location = New System.Drawing.Point(12, 61)
        Me.uc_mname.Name = "uc_mname"
        Me.uc_mname.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_mname.Size = New System.Drawing.Size(270, 23)
        Me.uc_mname.TabIndex = 2
        '
        'uc_fname
        '
        Me.uc_fname.BackColor = System.Drawing.Color.Transparent
        Me.uc_fname.iAddition_SQL = Nothing
        Me.uc_fname.iAdditional = Nothing
        Me.uc_fname.iArrow_Visible = False
        Me.uc_fname.iCanFindLabel_SQLIDx = 0
        Me.uc_fname.iCharacterLimit = 0
        Me.uc_fname.idsc = Me.uc_lbl_null
        Me.uc_fname.iForm = Me
        Me.uc_fname.iIsDropDown = False
        Me.uc_fname.iIsEnabled = True
        Me.uc_fname.iIsForSearch = False
        Me.uc_fname.iIsID = False
        Me.uc_fname.iIsInnerShow = False
        Me.uc_fname.iLabel = "First name"
        Me.uc_fname.iLabel_width = 100
        Me.uc_fname.isForFind = False
        Me.uc_fname.iSQL_Parameter_ID = 0
        Me.uc_fname.iText = ""
        Me.uc_fname.iTextBox_ = Me.txtnull
        Me.uc_fname.iTextBox_Sel_COL_ID = 0
        Me.uc_fname.iTitle = ""
        Me.uc_fname.Location = New System.Drawing.Point(12, 32)
        Me.uc_fname.Name = "uc_fname"
        Me.uc_fname.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_fname.Size = New System.Drawing.Size(270, 23)
        Me.uc_fname.TabIndex = 0
        '
        'EDS_User_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 287)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.uc_pass2)
        Me.Controls.Add(Me.uc_username)
        Me.Controls.Add(Me.uc_pass1)
        Me.Controls.Add(Me.uc_lname)
        Me.Controls.Add(Me.uc_mname)
        Me.Controls.Add(Me.uc_fname)
        Me.Controls.Add(Me.txtnull)
        Me.Controls.Add(Me.uc_lbl_null)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EDS_User_master"
        Me.Text = "EDS_User_master"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents uc_lbl_null As uc_label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtnull As TextBox
    Friend WithEvents uc_fname As uc_inputbox
    Friend WithEvents uc_pass2 As uc_inputbox
    Friend WithEvents uc_pass1 As uc_inputbox
    Friend WithEvents uc_lname As uc_inputbox
    Friend WithEvents uc_mname As uc_inputbox
    Friend WithEvents uc_username As uc_inputbox
    Friend WithEvents btn_ok As Button
End Class
