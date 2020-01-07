<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EDS_Authorization
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
        Me.tvNode = New System.Windows.Forms.TreeView()
        Me.txt_null = New System.Windows.Forms.TextBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.uc_lbl_null = New IpicIndirect.uc_label()
        Me.uc_fullname = New IpicIndirect.uc_inputbox()
        Me.uc_userID = New IpicIndirect.uc_inputbox()
        Me.SuspendLayout()
        '
        'tvNode
        '
        Me.tvNode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvNode.CheckBoxes = True
        Me.tvNode.ForeColor = System.Drawing.Color.Black
        Me.tvNode.FullRowSelect = True
        Me.tvNode.HideSelection = False
        Me.tvNode.ItemHeight = 20
        Me.tvNode.Location = New System.Drawing.Point(12, 12)
        Me.tvNode.Name = "tvNode"
        Me.tvNode.PathSeparator = "-"
        Me.tvNode.ShowLines = False
        Me.tvNode.Size = New System.Drawing.Size(250, 384)
        Me.tvNode.TabIndex = 92
        '
        'txt_null
        '
        Me.txt_null.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_null.Location = New System.Drawing.Point(714, 370)
        Me.txt_null.Name = "txt_null"
        Me.txt_null.Size = New System.Drawing.Size(64, 20)
        Me.txt_null.TabIndex = 95
        Me.txt_null.Visible = False
        '
        'txt_user
        '
        Me.txt_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_user.Location = New System.Drawing.Point(440, 12)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(101, 20)
        Me.txt_user.TabIndex = 95
        Me.txt_user.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 405)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 21)
        Me.Button1.TabIndex = 123
        Me.Button1.Text = "OK"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'uc_lbl_null
        '
        Me.uc_lbl_null.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.uc_lbl_null.Location = New System.Drawing.Point(714, 396)
        Me.uc_lbl_null.Name = "uc_lbl_null"
        Me.uc_lbl_null.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_lbl_null.Size = New System.Drawing.Size(64, 30)
        Me.uc_lbl_null.TabIndex = 94
        Me.uc_lbl_null.Visible = False
        '
        'uc_fullname
        '
        Me.uc_fullname.BackColor = System.Drawing.Color.Transparent
        Me.uc_fullname.iAddition_SQL = Nothing
        Me.uc_fullname.iAdditional = Nothing
        Me.uc_fullname.iArrow_Visible = False
        Me.uc_fullname.iCanFindLabel_SQLIDx = 0
        Me.uc_fullname.iCharacterLimit = 0
        Me.uc_fullname.idsc = Me.uc_lbl_null
        Me.uc_fullname.iForm = Me
        Me.uc_fullname.iIsDropDown = False
        Me.uc_fullname.iIsEnabled = True
        Me.uc_fullname.iIsForSearch = False
        Me.uc_fullname.iIsID = True
        Me.uc_fullname.iIsInnerShow = True
        Me.uc_fullname.iLabel = "Name"
        Me.uc_fullname.iLabel_width = 60
        Me.uc_fullname.isForFind = False
        Me.uc_fullname.iSQL_Parameter_ID = 0
        Me.uc_fullname.iText = ""
        Me.uc_fullname.iTextBox_ = Me.txt_null
        Me.uc_fullname.iTextBox_Sel_COL_ID = 0
        Me.uc_fullname.iTitle = ""
        Me.uc_fullname.Location = New System.Drawing.Point(268, 38)
        Me.uc_fullname.Name = "uc_fullname"
        Me.uc_fullname.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_fullname.Size = New System.Drawing.Size(278, 20)
        Me.uc_fullname.TabIndex = 93
        '
        'uc_userID
        '
        Me.uc_userID.BackColor = System.Drawing.Color.Transparent
        Me.uc_userID.iAddition_SQL = Nothing
        Me.uc_userID.iAdditional = Nothing
        Me.uc_userID.iArrow_Visible = True
        Me.uc_userID.iCanFindLabel_SQLIDx = 0
        Me.uc_userID.iCharacterLimit = 0
        Me.uc_userID.idsc = Me.uc_lbl_null
        Me.uc_userID.iForm = Me
        Me.uc_userID.iIsDropDown = False
        Me.uc_userID.iIsEnabled = False
        Me.uc_userID.iIsForSearch = True
        Me.uc_userID.iIsID = True
        Me.uc_userID.iIsInnerShow = True
        Me.uc_userID.iLabel = "User"
        Me.uc_userID.iLabel_width = 60
        Me.uc_userID.isForFind = False
        Me.uc_userID.iSQL_Parameter_ID = 11
        Me.uc_userID.iText = ""
        Me.uc_userID.iTextBox_ = Me.txt_user
        Me.uc_userID.iTextBox_Sel_COL_ID = 0
        Me.uc_userID.iTitle = ""
        Me.uc_userID.Location = New System.Drawing.Point(268, 12)
        Me.uc_userID.Name = "uc_userID"
        Me.uc_userID.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_userID.Size = New System.Drawing.Size(166, 20)
        Me.uc_userID.TabIndex = 93
        '
        'EDS_Authorization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 438)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.txt_null)
        Me.Controls.Add(Me.uc_lbl_null)
        Me.Controls.Add(Me.uc_fullname)
        Me.Controls.Add(Me.uc_userID)
        Me.Controls.Add(Me.tvNode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EDS_Authorization"
        Me.Text = "EDS_Authorization"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tvNode As TreeView
    Friend WithEvents uc_userID As uc_inputbox
    Friend WithEvents uc_lbl_null As uc_label
    Friend WithEvents txt_null As TextBox
    Friend WithEvents txt_user As TextBox
    Friend WithEvents uc_fullname As uc_inputbox
    Friend WithEvents Button1 As Button
End Class
