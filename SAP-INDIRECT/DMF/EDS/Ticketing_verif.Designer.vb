<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ticketing_verif
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.uc_req = New IpicIndirect.uc_inputbox()
        Me.uc_itemcode_txt = New System.Windows.Forms.TextBox()
        Me.uc_itemcode_lbl = New IpicIndirect.uc_label()
        Me.Uc_inputbox1 = New IpicIndirect.uc_inputbox()
        Me.Uc_label1 = New IpicIndirect.uc_label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgv_CheckSelection = New System.Windows.Forms.DataGridView()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.cms_dgv_options = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Uc_lines1 = New IpicIndirect.uc_lines()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Uc_inputbox2 = New IpicIndirect.uc_inputbox()
        Me.Uc_label2 = New IpicIndirect.uc_label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Uc_lines2 = New IpicIndirect.uc_lines()
        CType(Me.dgv_CheckSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_dgv_options.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uc_req
        '
        Me.uc_req.BackColor = System.Drawing.Color.Transparent
        Me.uc_req.iAdditional = Nothing
        Me.uc_req.iArrow_Visible = True
        Me.uc_req.iCanFindLabel_SQLIDx = 0
        Me.uc_req.iCharacterLimit = 0
        Me.uc_req.iForm = Me
        Me.uc_req.iIsDropDown = True
        Me.uc_req.iIsEnabled = False
        Me.uc_req.iIsForSearch = True
        Me.uc_req.iIsID = False
        Me.uc_req.iIsInnerShow = True
        Me.uc_req.iLabel = "Requester"
        Me.uc_req.iLabel_width = 100
        Me.uc_req.isAllowEmptyx = False
        Me.uc_req.isForFind = True
        Me.uc_req.iSQL_Parameter_ID = 56
        Me.uc_req.iSQL_Parameter_ID_FIND = 56
        Me.uc_req.iText = " "
        Me.uc_req.iTextBox_ = Me.uc_itemcode_txt
        Me.uc_req.iTextBox_Sel_COL_ID = 0
        Me.uc_req.iTitle = " "
        Me.uc_req.LinkedColumn = ""
        Me.uc_req.Location = New System.Drawing.Point(19, 406)
        Me.uc_req.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_req.Name = "uc_req"
        Me.uc_req.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_req.Size = New System.Drawing.Size(143, 20)
        Me.uc_req.TabIndex = 168
        '
        'uc_itemcode_txt
        '
        Me.uc_itemcode_txt.Location = New System.Drawing.Point(369, 406)
        Me.uc_itemcode_txt.Name = "uc_itemcode_txt"
        Me.uc_itemcode_txt.Size = New System.Drawing.Size(23, 20)
        Me.uc_itemcode_txt.TabIndex = 170
        Me.uc_itemcode_txt.Text = " "
        Me.uc_itemcode_txt.Visible = False
        '
        'uc_itemcode_lbl
        '
        Me.uc_itemcode_lbl.BackColor = System.Drawing.Color.Transparent
        Me.uc_itemcode_lbl.iAddition_SQL = Nothing
        Me.uc_itemcode_lbl.iAdditional = Nothing
        Me.uc_itemcode_lbl.idsc = Nothing
        Me.uc_itemcode_lbl.iIsEnabled = True
        Me.uc_itemcode_lbl.iIsForSearch = False
        Me.uc_itemcode_lbl.iLabel = "Edit iLbl to edit me"
        Me.uc_itemcode_lbl.iLabel_width = 5
        Me.uc_itemcode_lbl.isLabelBoldx = False
        Me.uc_itemcode_lbl.iSQL_Parameter_ID = 0
        Me.uc_itemcode_lbl.iText = ""
        Me.uc_itemcode_lbl.LinkedColumn = ""
        Me.uc_itemcode_lbl.Location = New System.Drawing.Point(165, 406)
        Me.uc_itemcode_lbl.Margin = New System.Windows.Forms.Padding(1)
        Me.uc_itemcode_lbl.Name = "uc_itemcode_lbl"
        Me.uc_itemcode_lbl.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_itemcode_lbl.Size = New System.Drawing.Size(228, 20)
        Me.uc_itemcode_lbl.TabIndex = 169
        '
        'Uc_inputbox1
        '
        Me.Uc_inputbox1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_inputbox1.iAdditional = Nothing
        Me.Uc_inputbox1.iArrow_Visible = True
        Me.Uc_inputbox1.iCanFindLabel_SQLIDx = 0
        Me.Uc_inputbox1.iCharacterLimit = 0
        Me.Uc_inputbox1.idsc = Me.Uc_label1
        Me.Uc_inputbox1.iForm = Me
        Me.Uc_inputbox1.iIsDropDown = True
        Me.Uc_inputbox1.iIsEnabled = False
        Me.Uc_inputbox1.iIsForSearch = True
        Me.Uc_inputbox1.iIsID = False
        Me.Uc_inputbox1.iIsInnerShow = True
        Me.Uc_inputbox1.iLabel = "Stages"
        Me.Uc_inputbox1.iLabel_width = 100
        Me.Uc_inputbox1.isAllowEmptyx = False
        Me.Uc_inputbox1.isForFind = True
        Me.Uc_inputbox1.iSQL_Parameter_ID = 56
        Me.Uc_inputbox1.iSQL_Parameter_ID_FIND = 56
        Me.Uc_inputbox1.iText = ""
        Me.Uc_inputbox1.iTextBox_ = Me.TextBox1
        Me.Uc_inputbox1.iTextBox_Sel_COL_ID = 0
        Me.Uc_inputbox1.iTitle = ""
        Me.Uc_inputbox1.LinkedColumn = ""
        Me.Uc_inputbox1.Location = New System.Drawing.Point(19, 432)
        Me.Uc_inputbox1.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_inputbox1.Name = "Uc_inputbox1"
        Me.Uc_inputbox1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_inputbox1.Size = New System.Drawing.Size(143, 20)
        Me.Uc_inputbox1.TabIndex = 171
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
        Me.Uc_label1.Location = New System.Drawing.Point(164, 432)
        Me.Uc_label1.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label1.Name = "Uc_label1"
        Me.Uc_label1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label1.Size = New System.Drawing.Size(228, 20)
        Me.Uc_label1.TabIndex = 172
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(369, 432)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(23, 20)
        Me.TextBox1.TabIndex = 173
        Me.TextBox1.Visible = False
        '
        'dgv_CheckSelection
        '
        Me.dgv_CheckSelection.AllowUserToAddRows = False
        Me.dgv_CheckSelection.AllowUserToDeleteRows = False
        Me.dgv_CheckSelection.BackgroundColor = System.Drawing.Color.White
        Me.dgv_CheckSelection.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_CheckSelection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_CheckSelection.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_CheckSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_CheckSelection.EnableHeadersVisualStyles = False
        Me.dgv_CheckSelection.Location = New System.Drawing.Point(21, 458)
        Me.dgv_CheckSelection.Name = "dgv_CheckSelection"
        Me.dgv_CheckSelection.ReadOnly = True
        Me.dgv_CheckSelection.RowHeadersVisible = False
        Me.dgv_CheckSelection.RowTemplate.Height = 24
        Me.dgv_CheckSelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_CheckSelection.Size = New System.Drawing.Size(366, 210)
        Me.dgv_CheckSelection.TabIndex = 174
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.Black
        Me.btn_ok.Image = Global.IpicIndirect.My.Resources.Resources.btn_bar1
        Me.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ok.Location = New System.Drawing.Point(21, 674)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(101, 23)
        Me.btn_ok.TabIndex = 202
        Me.btn_ok.Tag = "0"
        Me.btn_ok.Text = "Add"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'cms_dgv_options
        '
        Me.cms_dgv_options.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_dgv_options.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.cms_dgv_options.Name = "ContextMenuStrip1"
        Me.cms_dgv_options.Size = New System.Drawing.Size(111, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripMenuItem1.Text = "Delete"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripMenuItem2.Text = "Cancel"
        '
        'Uc_lines1
        '
        Me.Uc_lines1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_lines1.iLabel = "Tickiting Verification Setup"
        Me.Uc_lines1.Location = New System.Drawing.Point(-11, 372)
        Me.Uc_lines1.Name = "Uc_lines1"
        Me.Uc_lines1.PetSize = IpicIndirect.PetSize.Box
        Me.Uc_lines1.Size = New System.Drawing.Size(432, 361)
        Me.Uc_lines1.TabIndex = 203
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.IpicIndirect.My.Resources.Resources.btn_bar1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(21, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 211
        Me.Button1.Tag = "0"
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(26, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(366, 236)
        Me.DataGridView1.TabIndex = 210
        '
        'Uc_inputbox2
        '
        Me.Uc_inputbox2.BackColor = System.Drawing.Color.Transparent
        Me.Uc_inputbox2.iAdditional = Nothing
        Me.Uc_inputbox2.iArrow_Visible = True
        Me.Uc_inputbox2.iCanFindLabel_SQLIDx = 0
        Me.Uc_inputbox2.iCharacterLimit = 0
        Me.Uc_inputbox2.idsc = Me.Uc_label2
        Me.Uc_inputbox2.iForm = Me
        Me.Uc_inputbox2.iIsDropDown = True
        Me.Uc_inputbox2.iIsEnabled = False
        Me.Uc_inputbox2.iIsForSearch = True
        Me.Uc_inputbox2.iIsID = False
        Me.Uc_inputbox2.iIsInnerShow = True
        Me.Uc_inputbox2.iLabel = "Stages"
        Me.Uc_inputbox2.iLabel_width = 100
        Me.Uc_inputbox2.isAllowEmptyx = False
        Me.Uc_inputbox2.isForFind = True
        Me.Uc_inputbox2.iSQL_Parameter_ID = 56
        Me.Uc_inputbox2.iSQL_Parameter_ID_FIND = 56
        Me.Uc_inputbox2.iText = ""
        Me.Uc_inputbox2.iTextBox_ = Me.TextBox2
        Me.Uc_inputbox2.iTextBox_Sel_COL_ID = 0
        Me.Uc_inputbox2.iTitle = ""
        Me.Uc_inputbox2.LinkedColumn = ""
        Me.Uc_inputbox2.Location = New System.Drawing.Point(19, 41)
        Me.Uc_inputbox2.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_inputbox2.Name = "Uc_inputbox2"
        Me.Uc_inputbox2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_inputbox2.Size = New System.Drawing.Size(143, 20)
        Me.Uc_inputbox2.TabIndex = 207
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
        Me.Uc_label2.Location = New System.Drawing.Point(165, 41)
        Me.Uc_label2.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label2.Name = "Uc_label2"
        Me.Uc_label2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label2.Size = New System.Drawing.Size(232, 20)
        Me.Uc_label2.TabIndex = 208
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(369, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(23, 20)
        Me.TextBox2.TabIndex = 209
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(369, 39)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(23, 20)
        Me.TextBox3.TabIndex = 206
        Me.TextBox3.Text = " "
        Me.TextBox3.Visible = False
        '
        'Uc_lines2
        '
        Me.Uc_lines2.BackColor = System.Drawing.Color.Transparent
        Me.Uc_lines2.iLabel = "Stages Setup"
        Me.Uc_lines2.Location = New System.Drawing.Point(-11, 5)
        Me.Uc_lines2.Name = "Uc_lines2"
        Me.Uc_lines2.PetSize = IpicIndirect.PetSize.Box
        Me.Uc_lines2.Size = New System.Drawing.Size(432, 361)
        Me.Uc_lines2.TabIndex = 212
        '
        'Ticketing_verif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 722)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Uc_inputbox2)
        Me.Controls.Add(Me.Uc_label2)
        Me.Controls.Add(Me.Uc_lines2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.dgv_CheckSelection)
        Me.Controls.Add(Me.Uc_inputbox1)
        Me.Controls.Add(Me.Uc_label1)
        Me.Controls.Add(Me.uc_req)
        Me.Controls.Add(Me.uc_itemcode_lbl)
        Me.Controls.Add(Me.Uc_lines1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.uc_itemcode_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ticketing_verif"
        Me.Text = "Ticketing_verif"
        CType(Me.dgv_CheckSelection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_dgv_options.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents uc_req As uc_inputbox
    Friend WithEvents uc_itemcode_lbl As uc_label
    Friend WithEvents uc_itemcode_txt As TextBox
    Friend WithEvents Uc_inputbox1 As uc_inputbox
    Friend WithEvents Uc_label1 As uc_label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dgv_CheckSelection As DataGridView
    Friend WithEvents btn_ok As Button
    Friend WithEvents cms_dgv_options As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Uc_lines1 As uc_lines
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Uc_inputbox2 As uc_inputbox
    Friend WithEvents Uc_label2 As uc_label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Uc_lines2 As uc_lines
End Class
