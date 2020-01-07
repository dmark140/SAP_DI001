<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_managemnt
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node1")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node0", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tvNode = New System.Windows.Forms.TreeView()
        Me.dgv_Users = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Null_txt = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUll_lbll = New IpicIndirect.uc_label()
        Me.uc_ulevel = New IpicIndirect.uc_inputbox()
        Me.uc_Departmnt = New IpicIndirect.uc_label()
        Me.uc_Type = New IpicIndirect.uc_label()
        Me.uc_Name = New IpicIndirect.uc_label()
        Me.uc_usercode = New IpicIndirect.uc_label()
        Me.Uc_header1 = New IpicIndirect.uc_header()
        CType(Me.dgv_Users, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tvNode.Location = New System.Drawing.Point(366, 45)
        Me.tvNode.Name = "tvNode"
        TreeNode1.Checked = True
        TreeNode1.Name = "Node1"
        TreeNode1.Text = "Node1"
        TreeNode2.Name = "Node0"
        TreeNode2.Text = "Node0"
        Me.tvNode.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2})
        Me.tvNode.PathSeparator = "-"
        Me.tvNode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tvNode.ShowLines = False
        Me.tvNode.ShowPlusMinus = False
        Me.tvNode.ShowRootLines = False
        Me.tvNode.Size = New System.Drawing.Size(334, 420)
        Me.tvNode.TabIndex = 2
        '
        'dgv_Users
        '
        Me.dgv_Users.AllowUserToAddRows = False
        Me.dgv_Users.AllowUserToDeleteRows = False
        Me.dgv_Users.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Users.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Users.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_Users.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgv_Users.EnableHeadersVisualStyles = False
        Me.dgv_Users.Location = New System.Drawing.Point(12, 24)
        Me.dgv_Users.Name = "dgv_Users"
        Me.dgv_Users.ReadOnly = True
        Me.dgv_Users.RowHeadersVisible = False
        Me.dgv_Users.RowTemplate.Height = 24
        Me.dgv_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Users.Size = New System.Drawing.Size(334, 441)
        Me.dgv_Users.TabIndex = 16
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
        'btn_ok
        '
        Me.btn_ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(12, 545)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(116, 21)
        Me.btn_ok.TabIndex = 62
        Me.btn_ok.Text = "Save"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(134, 545)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 21)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Cancel"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(369, 24)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(71, 17)
        Me.CheckBox1.TabIndex = 68
        Me.CheckBox1.Text = "Check All"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Null_txt
        '
        Me.Null_txt.Enabled = False
        Me.Null_txt.Location = New System.Drawing.Point(695, 525)
        Me.Null_txt.Name = "Null_txt"
        Me.Null_txt.Size = New System.Drawing.Size(20, 20)
        Me.Null_txt.TabIndex = 94
        Me.Null_txt.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Column2"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'NUll_lbll
        '
        Me.NUll_lbll.BackColor = System.Drawing.Color.Transparent
        Me.NUll_lbll.iAddition_SQL = Nothing
        Me.NUll_lbll.iAdditional = Nothing
        Me.NUll_lbll.idsc = Nothing
        Me.NUll_lbll.iIsEnabled = True
        Me.NUll_lbll.iIsForSearch = False
        Me.NUll_lbll.iLabel = "Code"
        Me.NUll_lbll.iLabel_width = 5
        Me.NUll_lbll.isLabelBoldx = False
        Me.NUll_lbll.iSQL_Parameter_ID = 0
        Me.NUll_lbll.iText = ""
        Me.NUll_lbll.Location = New System.Drawing.Point(512, 525)
        Me.NUll_lbll.Name = "NUll_lbll"
        Me.NUll_lbll.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.NUll_lbll.Size = New System.Drawing.Size(190, 20)
        Me.NUll_lbll.TabIndex = 95
        '
        'uc_ulevel
        '
        Me.uc_ulevel.BackColor = System.Drawing.Color.Transparent
        Me.uc_ulevel.iAdditional = Nothing
        Me.uc_ulevel.iArrow_Visible = True
        Me.uc_ulevel.iCanFindLabel_SQLIDx = 0
        Me.uc_ulevel.iCharacterLimit = 2
        Me.uc_ulevel.idsc = Me.uc_Departmnt
        Me.uc_ulevel.iForm = Me
        Me.uc_ulevel.iIsDropDown = True
        Me.uc_ulevel.iIsEnabled = False
        Me.uc_ulevel.iIsForSearch = True
        Me.uc_ulevel.iIsID = False
        Me.uc_ulevel.iIsInnerShow = False
        Me.uc_ulevel.iLabel = "User Level"
        Me.uc_ulevel.iLabel_width = 105
        Me.uc_ulevel.isAllowEmptyx = True
        Me.uc_ulevel.isForFind = False
        Me.uc_ulevel.iSQL_Parameter_ID = 164
        Me.uc_ulevel.iSQL_Parameter_ID_FIND = 0
        Me.uc_ulevel.iText = ""
        Me.uc_ulevel.iTextBox_ = Me.Null_txt
        Me.uc_ulevel.iTextBox_Sel_COL_ID = 0
        Me.uc_ulevel.iTitle = ""
        Me.uc_ulevel.LinkedColumn = ""
        Me.uc_ulevel.Location = New System.Drawing.Point(366, 525)
        Me.uc_ulevel.Name = "uc_ulevel"
        Me.uc_ulevel.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_ulevel.Size = New System.Drawing.Size(146, 20)
        Me.uc_ulevel.TabIndex = 93
        '
        'uc_Departmnt
        '
        Me.uc_Departmnt.BackColor = System.Drawing.Color.Transparent
        Me.uc_Departmnt.iAddition_SQL = Nothing
        Me.uc_Departmnt.iAdditional = Nothing
        Me.uc_Departmnt.idsc = Nothing
        Me.uc_Departmnt.iIsEnabled = False
        Me.uc_Departmnt.iIsForSearch = False
        Me.uc_Departmnt.iLabel = "Department"
        Me.uc_Departmnt.iLabel_width = 120
        Me.uc_Departmnt.isLabelBoldx = False
        Me.uc_Departmnt.iSQL_Parameter_ID = 0
        Me.uc_Departmnt.iText = ""
        Me.uc_Departmnt.Location = New System.Drawing.Point(366, 498)
        Me.uc_Departmnt.Name = "uc_Departmnt"
        Me.uc_Departmnt.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_Departmnt.Size = New System.Drawing.Size(334, 21)
        Me.uc_Departmnt.TabIndex = 67
        '
        'uc_Type
        '
        Me.uc_Type.BackColor = System.Drawing.Color.Transparent
        Me.uc_Type.iAddition_SQL = Nothing
        Me.uc_Type.iAdditional = Nothing
        Me.uc_Type.idsc = Nothing
        Me.uc_Type.iIsEnabled = False
        Me.uc_Type.iIsForSearch = False
        Me.uc_Type.iLabel = "User Type"
        Me.uc_Type.iLabel_width = 120
        Me.uc_Type.isLabelBoldx = False
        Me.uc_Type.iSQL_Parameter_ID = 0
        Me.uc_Type.iText = ""
        Me.uc_Type.Location = New System.Drawing.Point(366, 471)
        Me.uc_Type.Name = "uc_Type"
        Me.uc_Type.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_Type.Size = New System.Drawing.Size(334, 21)
        Me.uc_Type.TabIndex = 66
        '
        'uc_Name
        '
        Me.uc_Name.BackColor = System.Drawing.Color.Transparent
        Me.uc_Name.iAddition_SQL = Nothing
        Me.uc_Name.iAdditional = Nothing
        Me.uc_Name.idsc = Nothing
        Me.uc_Name.iIsEnabled = False
        Me.uc_Name.iIsForSearch = False
        Me.uc_Name.iLabel = "User Name"
        Me.uc_Name.iLabel_width = 120
        Me.uc_Name.isLabelBoldx = False
        Me.uc_Name.iSQL_Parameter_ID = 0
        Me.uc_Name.iText = ""
        Me.uc_Name.Location = New System.Drawing.Point(12, 514)
        Me.uc_Name.Name = "uc_Name"
        Me.uc_Name.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_Name.Size = New System.Drawing.Size(334, 21)
        Me.uc_Name.TabIndex = 65
        '
        'uc_usercode
        '
        Me.uc_usercode.BackColor = System.Drawing.Color.Transparent
        Me.uc_usercode.iAddition_SQL = Nothing
        Me.uc_usercode.iAdditional = Nothing
        Me.uc_usercode.idsc = Nothing
        Me.uc_usercode.iIsEnabled = False
        Me.uc_usercode.iIsForSearch = False
        Me.uc_usercode.iLabel = "User Code"
        Me.uc_usercode.iLabel_width = 120
        Me.uc_usercode.isLabelBoldx = False
        Me.uc_usercode.iSQL_Parameter_ID = 0
        Me.uc_usercode.iText = ""
        Me.uc_usercode.Location = New System.Drawing.Point(12, 488)
        Me.uc_usercode.Name = "uc_usercode"
        Me.uc_usercode.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_usercode.Size = New System.Drawing.Size(334, 21)
        Me.uc_usercode.TabIndex = 64
        '
        'Uc_header1
        '
        Me.Uc_header1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_header1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Uc_header1.iFrom = Me
        Me.Uc_header1.iText = "User Manager"
        Me.Uc_header1.Location = New System.Drawing.Point(0, 0)
        Me.Uc_header1.Name = "Uc_header1"
        Me.Uc_header1.Size = New System.Drawing.Size(736, 19)
        Me.Uc_header1.TabIndex = 0
        '
        'user_managemnt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 578)
        Me.Controls.Add(Me.Null_txt)
        Me.Controls.Add(Me.NUll_lbll)
        Me.Controls.Add(Me.uc_ulevel)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.uc_Departmnt)
        Me.Controls.Add(Me.uc_Type)
        Me.Controls.Add(Me.uc_Name)
        Me.Controls.Add(Me.uc_usercode)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.dgv_Users)
        Me.Controls.Add(Me.tvNode)
        Me.Controls.Add(Me.Uc_header1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "user_managemnt"
        CType(Me.dgv_Users, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Uc_header1 As uc_header
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents uc_Departmnt As uc_label
    Friend WithEvents uc_Type As uc_label
    Friend WithEvents uc_Name As uc_label
    Friend WithEvents uc_usercode As uc_label
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_ok As Button
    Friend WithEvents dgv_Users As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents tvNode As TreeView
    Friend WithEvents uc_ulevel As uc_inputbox
    Friend WithEvents Null_txt As TextBox
    Friend WithEvents NUll_lbll As uc_label
End Class
