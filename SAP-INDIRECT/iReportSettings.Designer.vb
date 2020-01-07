<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iReportSettings
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
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Uc_label3 = New IpicIndirect.uc_label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Uc_label1 = New IpicIndirect.uc_label()
        Me.txt_null = New System.Windows.Forms.TextBox()
        Me.uc_path = New IpicIndirect.uc_inputbox()
        Me.uc_userid = New IpicIndirect.uc_inputbox()
        Me.uc_password = New IpicIndirect.uc_inputbox()
        Me.uc_servr = New IpicIndirect.uc_inputbox()
        Me.uc_dateablea = New IpicIndirect.uc_inputbox()
        Me.SuspendLayout()
        '
        'btn_ok
        '
        Me.btn_ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(12, 156)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(92, 23)
        Me.btn_ok.TabIndex = 84
        Me.btn_ok.Text = "Add"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(405, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 23)
        Me.Button1.TabIndex = 84
        Me.Button1.Text = "&Locate"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Uc_label3
        '
        Me.Uc_label3.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label3.iAddition_SQL = Nothing
        Me.Uc_label3.iAdditional = Nothing
        Me.Uc_label3.idsc = Nothing
        Me.Uc_label3.iIsEnabled = True
        Me.Uc_label3.iIsForSearch = False
        Me.Uc_label3.iLabel = "Connection Info"
        Me.Uc_label3.iLabel_width = 500
        Me.Uc_label3.isLabelBoldx = False
        Me.Uc_label3.iSQL_Parameter_ID = 0
        Me.Uc_label3.iText = ""
        Me.Uc_label3.Location = New System.Drawing.Point(12, 60)
        Me.Uc_label3.Name = "Uc_label3"
        Me.Uc_label3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label3.Size = New System.Drawing.Size(176, 20)
        Me.Uc_label3.TabIndex = 85
        '
        'Uc_label1
        '
        Me.Uc_label1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label1.iAddition_SQL = Nothing
        Me.Uc_label1.iAdditional = Nothing
        Me.Uc_label1.idsc = Nothing
        Me.Uc_label1.iIsEnabled = True
        Me.Uc_label1.iIsForSearch = False
        Me.Uc_label1.iLabel = "     Database Name"
        Me.Uc_label1.iLabel_width = 150
        Me.Uc_label1.isLabelBoldx = False
        Me.Uc_label1.iSQL_Parameter_ID = 0
        Me.Uc_label1.iText = ""
        Me.Uc_label1.Location = New System.Drawing.Point(528, 13)
        Me.Uc_label1.Name = "Uc_label1"
        Me.Uc_label1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label1.Size = New System.Drawing.Size(20, 20)
        Me.Uc_label1.TabIndex = 85
        Me.Uc_label1.Visible = False
        '
        'txt_null
        '
        Me.txt_null.Location = New System.Drawing.Point(502, 13)
        Me.txt_null.Name = "txt_null"
        Me.txt_null.Size = New System.Drawing.Size(20, 20)
        Me.txt_null.TabIndex = 87
        Me.txt_null.Visible = False
        '
        'uc_path
        '
        Me.uc_path.BackColor = System.Drawing.Color.Transparent
        Me.uc_path.iAdditional = Nothing
        Me.uc_path.iArrow_Visible = False
        Me.uc_path.iCanFindLabel_SQLIDx = 0
        Me.uc_path.iCharacterLimit = 0
        Me.uc_path.idsc = Me.Uc_label1
        Me.uc_path.iForm = Me
        Me.uc_path.iIsDropDown = False
        Me.uc_path.iIsEnabled = True
        Me.uc_path.iIsForSearch = False
        Me.uc_path.iIsID = False
        Me.uc_path.iIsInnerShow = False
        Me.uc_path.iLabel = "Path"
        Me.uc_path.iLabel_width = 120
        Me.uc_path.isAllowEmptyx = False
        Me.uc_path.isForFind = False
        Me.uc_path.iSQL_Parameter_ID = 0
        Me.uc_path.iText = ""
        Me.uc_path.iTextBox_ = Me.txt_null
        Me.uc_path.iTextBox_Sel_COL_ID = 0
        Me.uc_path.iTitle = ""
        Me.uc_path.Location = New System.Drawing.Point(12, 12)
        Me.uc_path.Name = "uc_path"
        Me.uc_path.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_path.Size = New System.Drawing.Size(387, 23)
        Me.uc_path.TabIndex = 86
        '
        'uc_userid
        '
        Me.uc_userid.BackColor = System.Drawing.Color.Transparent
        Me.uc_userid.iAdditional = Nothing
        Me.uc_userid.iArrow_Visible = False
        Me.uc_userid.iCanFindLabel_SQLIDx = 0
        Me.uc_userid.iCharacterLimit = 0
        Me.uc_userid.idsc = Me.Uc_label1
        Me.uc_userid.iForm = Me
        Me.uc_userid.iIsDropDown = False
        Me.uc_userid.iIsEnabled = True
        Me.uc_userid.iIsForSearch = False
        Me.uc_userid.iIsID = False
        Me.uc_userid.iIsInnerShow = False
        Me.uc_userid.iLabel = "User Id"
        Me.uc_userid.iLabel_width = 120
        Me.uc_userid.isAllowEmptyx = False
        Me.uc_userid.isForFind = False
        Me.uc_userid.iSQL_Parameter_ID = 0
        Me.uc_userid.iText = ""
        Me.uc_userid.iTextBox_ = Me.txt_null
        Me.uc_userid.iTextBox_Sel_COL_ID = 0
        Me.uc_userid.iTitle = ""
        Me.uc_userid.Location = New System.Drawing.Point(12, 86)
        Me.uc_userid.Name = "uc_userid"
        Me.uc_userid.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_userid.Size = New System.Drawing.Size(317, 20)
        Me.uc_userid.TabIndex = 86
        '
        'uc_password
        '
        Me.uc_password.BackColor = System.Drawing.Color.Transparent
        Me.uc_password.iAdditional = Nothing
        Me.uc_password.iArrow_Visible = False
        Me.uc_password.iCanFindLabel_SQLIDx = 0
        Me.uc_password.iCharacterLimit = 0
        Me.uc_password.idsc = Me.Uc_label1
        Me.uc_password.iForm = Me
        Me.uc_password.iIsDropDown = False
        Me.uc_password.iIsEnabled = True
        Me.uc_password.iIsForSearch = False
        Me.uc_password.iIsID = False
        Me.uc_password.iIsInnerShow = False
        Me.uc_password.iLabel = "Password"
        Me.uc_password.iLabel_width = 120
        Me.uc_password.isAllowEmptyx = False
        Me.uc_password.isForFind = False
        Me.uc_password.iSQL_Parameter_ID = 0
        Me.uc_password.iText = ""
        Me.uc_password.iTextBox_ = Me.txt_null
        Me.uc_password.iTextBox_Sel_COL_ID = 0
        Me.uc_password.iTitle = ""
        Me.uc_password.Location = New System.Drawing.Point(12, 112)
        Me.uc_password.Name = "uc_password"
        Me.uc_password.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_password.Size = New System.Drawing.Size(317, 20)
        Me.uc_password.TabIndex = 86
        '
        'uc_servr
        '
        Me.uc_servr.BackColor = System.Drawing.Color.Transparent
        Me.uc_servr.iAdditional = Nothing
        Me.uc_servr.iArrow_Visible = False
        Me.uc_servr.iCanFindLabel_SQLIDx = 0
        Me.uc_servr.iCharacterLimit = 0
        Me.uc_servr.idsc = Me.Uc_label1
        Me.uc_servr.iForm = Me
        Me.uc_servr.iIsDropDown = False
        Me.uc_servr.iIsEnabled = True
        Me.uc_servr.iIsForSearch = False
        Me.uc_servr.iIsID = False
        Me.uc_servr.iIsInnerShow = False
        Me.uc_servr.iLabel = "Server"
        Me.uc_servr.iLabel_width = 120
        Me.uc_servr.isAllowEmptyx = False
        Me.uc_servr.isForFind = False
        Me.uc_servr.iSQL_Parameter_ID = 0
        Me.uc_servr.iText = ""
        Me.uc_servr.iTextBox_ = Me.txt_null
        Me.uc_servr.iTextBox_Sel_COL_ID = 0
        Me.uc_servr.iTitle = ""
        Me.uc_servr.Location = New System.Drawing.Point(347, 86)
        Me.uc_servr.Name = "uc_servr"
        Me.uc_servr.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_servr.Size = New System.Drawing.Size(317, 20)
        Me.uc_servr.TabIndex = 86
        '
        'uc_dateablea
        '
        Me.uc_dateablea.BackColor = System.Drawing.Color.Transparent
        Me.uc_dateablea.iAdditional = Nothing
        Me.uc_dateablea.iArrow_Visible = False
        Me.uc_dateablea.iCanFindLabel_SQLIDx = 0
        Me.uc_dateablea.iCharacterLimit = 0
        Me.uc_dateablea.idsc = Me.Uc_label1
        Me.uc_dateablea.iForm = Me
        Me.uc_dateablea.iIsDropDown = False
        Me.uc_dateablea.iIsEnabled = True
        Me.uc_dateablea.iIsForSearch = False
        Me.uc_dateablea.iIsID = False
        Me.uc_dateablea.iIsInnerShow = False
        Me.uc_dateablea.iLabel = "Database"
        Me.uc_dateablea.iLabel_width = 120
        Me.uc_dateablea.isAllowEmptyx = False
        Me.uc_dateablea.isForFind = False
        Me.uc_dateablea.iSQL_Parameter_ID = 0
        Me.uc_dateablea.iText = ""
        Me.uc_dateablea.iTextBox_ = Me.txt_null
        Me.uc_dateablea.iTextBox_Sel_COL_ID = 0
        Me.uc_dateablea.iTitle = ""
        Me.uc_dateablea.Location = New System.Drawing.Point(347, 112)
        Me.uc_dateablea.Name = "uc_dateablea"
        Me.uc_dateablea.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_dateablea.Size = New System.Drawing.Size(317, 20)
        Me.uc_dateablea.TabIndex = 86
        '
        'iReportSettings
        '
        Me.AcceptButton = Me.btn_ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 191)
        Me.Controls.Add(Me.txt_null)
        Me.Controls.Add(Me.uc_dateablea)
        Me.Controls.Add(Me.uc_servr)
        Me.Controls.Add(Me.uc_password)
        Me.Controls.Add(Me.uc_userid)
        Me.Controls.Add(Me.uc_path)
        Me.Controls.Add(Me.Uc_label3)
        Me.Controls.Add(Me.Uc_label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_ok)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "iReportSettings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_ok As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Uc_label3 As uc_label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Uc_label1 As uc_label
    Friend WithEvents txt_null As TextBox
    Friend WithEvents uc_path As uc_inputbox
    Friend WithEvents uc_userid As uc_inputbox
    Friend WithEvents uc_dateablea As uc_inputbox
    Friend WithEvents uc_servr As uc_inputbox
    Friend WithEvents uc_password As uc_inputbox
End Class
