<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ApprovalTemp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.uc_itemcode = New IpicIndirect.uc_inputbox()
        Me.uc_itemcode_lbl = New IpicIndirect.uc_label()
        Me.cms_Dgv2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgv_req = New System.Windows.Forms.DataGridView()
        Me.cms_Dgv1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.dgv_apv = New System.Windows.Forms.DataGridView()
        Me.Uc_inputbox1 = New IpicIndirect.uc_inputbox()
        Me.Uc_label1 = New IpicIndirect.uc_label()
        Me.uc_itemcode_txt = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Uc_label2 = New IpicIndirect.uc_label()
        Me.Uc_inputbox2 = New IpicIndirect.uc_inputbox()
        Me.Uc_label3 = New IpicIndirect.uc_label()
        Me.Uc_label4 = New IpicIndirect.uc_label()
        Me.cms_Dgv2.SuspendLayout()
        CType(Me.dgv_req, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_Dgv1.SuspendLayout()
        CType(Me.dgv_apv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uc_itemcode
        '
        Me.uc_itemcode.BackColor = System.Drawing.Color.Transparent
        Me.uc_itemcode.iAdditional = Nothing
        Me.uc_itemcode.iArrow_Visible = False
        Me.uc_itemcode.iCanFindLabel_SQLIDx = 0
        Me.uc_itemcode.iCharacterLimit = 0
        Me.uc_itemcode.idsc = Me.uc_itemcode_lbl
        Me.uc_itemcode.iForm = Nothing
        Me.uc_itemcode.iIsDropDown = True
        Me.uc_itemcode.iIsEnabled = False
        Me.uc_itemcode.iIsForSearch = True
        Me.uc_itemcode.iIsID = False
        Me.uc_itemcode.iIsInnerShow = True
        Me.uc_itemcode.iLabel = "Name"
        Me.uc_itemcode.iLabel_width = 100
        Me.uc_itemcode.isAllowEmptyx = False
        Me.uc_itemcode.isForFind = True
        Me.uc_itemcode.iSQL_Parameter_ID = 161
        Me.uc_itemcode.iSQL_Parameter_ID_FIND = 168
        Me.uc_itemcode.iText = ""
        Me.uc_itemcode.iTextBox_ = Nothing
        Me.uc_itemcode.iTextBox_Sel_COL_ID = 0
        Me.uc_itemcode.iTitle = ""
        Me.uc_itemcode.LinkedColumn = "u_code"
        Me.uc_itemcode.Location = New System.Drawing.Point(10, 18)
        Me.uc_itemcode.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_itemcode.Name = "uc_itemcode"
        Me.uc_itemcode.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_itemcode.Size = New System.Drawing.Size(312, 20)
        Me.uc_itemcode.TabIndex = 168
        '
        'uc_itemcode_lbl
        '
        Me.uc_itemcode_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_itemcode_lbl.iAddition_SQL = Nothing
        Me.uc_itemcode_lbl.iAdditional = Nothing
        Me.uc_itemcode_lbl.idsc = Nothing
        Me.uc_itemcode_lbl.iIsEnabled = True
        Me.uc_itemcode_lbl.iIsForSearch = False
        Me.uc_itemcode_lbl.iLabel = "Description"
        Me.uc_itemcode_lbl.iLabel_width = 115
        Me.uc_itemcode_lbl.isLabelBoldx = False
        Me.uc_itemcode_lbl.iSQL_Parameter_ID = 0
        Me.uc_itemcode_lbl.iText = ""
        Me.uc_itemcode_lbl.LinkedColumn = ""
        Me.uc_itemcode_lbl.Location = New System.Drawing.Point(10, 41)
        Me.uc_itemcode_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_itemcode_lbl.Name = "uc_itemcode_lbl"
        Me.uc_itemcode_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_itemcode_lbl.Size = New System.Drawing.Size(312, 20)
        Me.uc_itemcode_lbl.TabIndex = 169
        '
        'cms_Dgv2
        '
        Me.cms_Dgv2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_Dgv2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripSeparator1, Me.ToolStripMenuItem6})
        Me.cms_Dgv2.Name = "ContextMenuStrip1"
        Me.cms_Dgv2.Size = New System.Drawing.Size(167, 76)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(166, 22)
        Me.ToolStripMenuItem4.Text = "Change Selection"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(166, 22)
        Me.ToolStripMenuItem5.Text = "Remove"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(166, 22)
        Me.ToolStripMenuItem6.Text = "Cancel"
        '
        'dgv_req
        '
        Me.dgv_req.AllowUserToAddRows = False
        Me.dgv_req.AllowUserToDeleteRows = False
        Me.dgv_req.BackgroundColor = System.Drawing.Color.White
        Me.dgv_req.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_req.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_req.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_req.ContextMenuStrip = Me.cms_Dgv1
        Me.dgv_req.EnableHeadersVisualStyles = False
        Me.dgv_req.Location = New System.Drawing.Point(361, 234)
        Me.dgv_req.Name = "dgv_req"
        Me.dgv_req.ReadOnly = True
        Me.dgv_req.RowHeadersVisible = False
        Me.dgv_req.RowTemplate.Height = 24
        Me.dgv_req.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_req.Size = New System.Drawing.Size(293, 315)
        Me.dgv_req.TabIndex = 92
        '
        'cms_Dgv1
        '
        Me.cms_Dgv1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_Dgv1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem3, Me.ToolStripSeparator2, Me.ToolStripMenuItem2})
        Me.cms_Dgv1.Name = "ContextMenuStrip1"
        Me.cms_Dgv1.Size = New System.Drawing.Size(167, 76)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.ToolStripMenuItem1.Text = "Change Selection"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(166, 22)
        Me.ToolStripMenuItem3.Text = "Remove"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(163, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(166, 22)
        Me.ToolStripMenuItem2.Text = "Cancel"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(381, 10)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox1.TabIndex = 171
        Me.CheckBox1.Text = "&Active"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(381, 33)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(137, 17)
        Me.CheckBox2.TabIndex = 172
        Me.CheckBox2.Text = "&Active When Updating "
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'dgv_apv
        '
        Me.dgv_apv.AllowUserToAddRows = False
        Me.dgv_apv.AllowUserToDeleteRows = False
        Me.dgv_apv.BackgroundColor = System.Drawing.Color.White
        Me.dgv_apv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_apv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_apv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_apv.EnableHeadersVisualStyles = False
        Me.dgv_apv.Location = New System.Drawing.Point(14, 234)
        Me.dgv_apv.Name = "dgv_apv"
        Me.dgv_apv.ReadOnly = True
        Me.dgv_apv.RowHeadersVisible = False
        Me.dgv_apv.RowTemplate.Height = 24
        Me.dgv_apv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_apv.Size = New System.Drawing.Size(293, 315)
        Me.dgv_apv.TabIndex = 92
        '
        'Uc_inputbox1
        '
        Me.Uc_inputbox1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_inputbox1.iAdditional = Nothing
        Me.Uc_inputbox1.iArrow_Visible = True
        Me.Uc_inputbox1.iCanFindLabel_SQLIDx = 0
        Me.Uc_inputbox1.iCharacterLimit = 0
        Me.Uc_inputbox1.idsc = Me.Uc_label1
        Me.Uc_inputbox1.iForm = Nothing
        Me.Uc_inputbox1.iIsDropDown = True
        Me.Uc_inputbox1.iIsEnabled = False
        Me.Uc_inputbox1.iIsForSearch = True
        Me.Uc_inputbox1.iIsID = False
        Me.Uc_inputbox1.iIsInnerShow = True
        Me.Uc_inputbox1.iLabel = "Item Code"
        Me.Uc_inputbox1.iLabel_width = 100
        Me.Uc_inputbox1.isAllowEmptyx = False
        Me.Uc_inputbox1.isForFind = True
        Me.Uc_inputbox1.iSQL_Parameter_ID = 161
        Me.Uc_inputbox1.iSQL_Parameter_ID_FIND = 168
        Me.Uc_inputbox1.iText = ""
        Me.Uc_inputbox1.iTextBox_ = Me.uc_itemcode_txt
        Me.Uc_inputbox1.iTextBox_Sel_COL_ID = 0
        Me.Uc_inputbox1.iTitle = ""
        Me.Uc_inputbox1.LinkedColumn = "A.U_itemcode"
        Me.Uc_inputbox1.Location = New System.Drawing.Point(10, 64)
        Me.Uc_inputbox1.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_inputbox1.Name = "Uc_inputbox1"
        Me.Uc_inputbox1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_inputbox1.Size = New System.Drawing.Size(170, 20)
        Me.Uc_inputbox1.TabIndex = 173
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
        Me.Uc_label1.iLabel_width = 5
        Me.Uc_label1.isLabelBoldx = False
        Me.Uc_label1.iSQL_Parameter_ID = 0
        Me.Uc_label1.iText = ""
        Me.Uc_label1.LinkedColumn = ""
        Me.Uc_label1.Location = New System.Drawing.Point(181, 64)
        Me.Uc_label1.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label1.Name = "Uc_label1"
        Me.Uc_label1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label1.Size = New System.Drawing.Size(204, 20)
        Me.Uc_label1.TabIndex = 174
        '
        'uc_itemcode_txt
        '
        Me.uc_itemcode_txt.Location = New System.Drawing.Point(390, 65)
        Me.uc_itemcode_txt.Name = "uc_itemcode_txt"
        Me.uc_itemcode_txt.Size = New System.Drawing.Size(23, 20)
        Me.uc_itemcode_txt.TabIndex = 175
        Me.uc_itemcode_txt.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(390, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(23, 20)
        Me.TextBox1.TabIndex = 175
        Me.TextBox1.Visible = False
        '
        'Uc_label2
        '
        Me.Uc_label2.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label2.iAddition_SQL = Nothing
        Me.Uc_label2.iAdditional = Nothing
        Me.Uc_label2.idsc = Nothing
        Me.Uc_label2.iIsEnabled = True
        Me.Uc_label2.iIsForSearch = False
        Me.Uc_label2.iLabel = "Edit iLbl to edit me"
        Me.Uc_label2.iLabel_width = 5
        Me.Uc_label2.isLabelBoldx = False
        Me.Uc_label2.iSQL_Parameter_ID = 0
        Me.Uc_label2.iText = ""
        Me.Uc_label2.LinkedColumn = ""
        Me.Uc_label2.Location = New System.Drawing.Point(181, 87)
        Me.Uc_label2.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label2.Name = "Uc_label2"
        Me.Uc_label2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label2.Size = New System.Drawing.Size(204, 20)
        Me.Uc_label2.TabIndex = 174
        '
        'Uc_inputbox2
        '
        Me.Uc_inputbox2.BackColor = System.Drawing.Color.Transparent
        Me.Uc_inputbox2.iAdditional = Nothing
        Me.Uc_inputbox2.iArrow_Visible = True
        Me.Uc_inputbox2.iCanFindLabel_SQLIDx = 0
        Me.Uc_inputbox2.iCharacterLimit = 0
        Me.Uc_inputbox2.idsc = Me.Uc_label2
        Me.Uc_inputbox2.iForm = Nothing
        Me.Uc_inputbox2.iIsDropDown = True
        Me.Uc_inputbox2.iIsEnabled = False
        Me.Uc_inputbox2.iIsForSearch = True
        Me.Uc_inputbox2.iIsID = False
        Me.Uc_inputbox2.iIsInnerShow = True
        Me.Uc_inputbox2.iLabel = "Item Code"
        Me.Uc_inputbox2.iLabel_width = 100
        Me.Uc_inputbox2.isAllowEmptyx = False
        Me.Uc_inputbox2.isForFind = True
        Me.Uc_inputbox2.iSQL_Parameter_ID = 161
        Me.Uc_inputbox2.iSQL_Parameter_ID_FIND = 168
        Me.Uc_inputbox2.iText = ""
        Me.Uc_inputbox2.iTextBox_ = Me.TextBox1
        Me.Uc_inputbox2.iTextBox_Sel_COL_ID = 0
        Me.Uc_inputbox2.iTitle = ""
        Me.Uc_inputbox2.LinkedColumn = "A.U_itemcode"
        Me.Uc_inputbox2.Location = New System.Drawing.Point(10, 87)
        Me.Uc_inputbox2.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_inputbox2.Name = "Uc_inputbox2"
        Me.Uc_inputbox2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_inputbox2.Size = New System.Drawing.Size(170, 20)
        Me.Uc_inputbox2.TabIndex = 173
        '
        'Uc_label3
        '
        Me.Uc_label3.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label3.iAddition_SQL = Nothing
        Me.Uc_label3.iAdditional = Nothing
        Me.Uc_label3.idsc = Nothing
        Me.Uc_label3.iIsEnabled = True
        Me.Uc_label3.iIsForSearch = False
        Me.Uc_label3.iLabel = "Description"
        Me.Uc_label3.iLabel_width = 115
        Me.Uc_label3.isLabelBoldx = False
        Me.Uc_label3.iSQL_Parameter_ID = 0
        Me.Uc_label3.iText = ""
        Me.Uc_label3.LinkedColumn = ""
        Me.Uc_label3.Location = New System.Drawing.Point(14, 210)
        Me.Uc_label3.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label3.Name = "Uc_label3"
        Me.Uc_label3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label3.Size = New System.Drawing.Size(113, 20)
        Me.Uc_label3.TabIndex = 176
        '
        'Uc_label4
        '
        Me.Uc_label4.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label4.iAddition_SQL = Nothing
        Me.Uc_label4.iAdditional = Nothing
        Me.Uc_label4.idsc = Nothing
        Me.Uc_label4.iIsEnabled = True
        Me.Uc_label4.iIsForSearch = False
        Me.Uc_label4.iLabel = "Description"
        Me.Uc_label4.iLabel_width = 115
        Me.Uc_label4.isLabelBoldx = False
        Me.Uc_label4.iSQL_Parameter_ID = 0
        Me.Uc_label4.iText = ""
        Me.Uc_label4.LinkedColumn = ""
        Me.Uc_label4.Location = New System.Drawing.Point(361, 210)
        Me.Uc_label4.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label4.Name = "Uc_label4"
        Me.Uc_label4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label4.Size = New System.Drawing.Size(113, 20)
        Me.Uc_label4.TabIndex = 176
        '
        'ApprovalTemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 652)
        Me.Controls.Add(Me.Uc_label4)
        Me.Controls.Add(Me.Uc_label3)
        Me.Controls.Add(Me.Uc_inputbox2)
        Me.Controls.Add(Me.Uc_inputbox1)
        Me.Controls.Add(Me.Uc_label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Uc_label1)
        Me.Controls.Add(Me.uc_itemcode_txt)
        Me.Controls.Add(Me.dgv_apv)
        Me.Controls.Add(Me.dgv_req)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.uc_itemcode)
        Me.Controls.Add(Me.uc_itemcode_lbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ApprovalTemp"
        Me.Text = "1"
        Me.cms_Dgv2.ResumeLayout(False)
        CType(Me.dgv_req, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_Dgv1.ResumeLayout(False)
        CType(Me.dgv_apv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents uc_itemcode As uc_inputbox
    Friend WithEvents uc_itemcode_lbl As uc_label
    Friend WithEvents dgv_req As DataGridView
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents cms_Dgv2 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents cms_Dgv1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents dgv_apv As DataGridView
    Friend WithEvents Uc_inputbox1 As uc_inputbox
    Friend WithEvents Uc_label1 As uc_label
    Friend WithEvents uc_itemcode_txt As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Uc_label2 As uc_label
    Friend WithEvents Uc_inputbox2 As uc_inputbox
    Friend WithEvents Uc_label3 As uc_label
    Friend WithEvents Uc_label4 As uc_label
End Class
