<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class batch_selectionForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_selectorBatch = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgv_selected = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_auto = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_null = New System.Windows.Forms.TextBox()
        Me.uc_null = New IpicIndirect.uc_label()
        Me.Uc_inputbox1 = New IpicIndirect.uc_inputbox()
        Me.uc_Ttl_need = New IpicIndirect.uc_inputbox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.cms_copy = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dgv_selectorBatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_selected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.cms_copy.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_selectorBatch
        '
        Me.dgv_selectorBatch.AllowUserToAddRows = False
        Me.dgv_selectorBatch.AllowUserToDeleteRows = False
        Me.dgv_selectorBatch.BackgroundColor = System.Drawing.Color.White
        Me.dgv_selectorBatch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_selectorBatch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_selectorBatch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_selectorBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_selectorBatch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgv_selectorBatch.EnableHeadersVisualStyles = False
        Me.dgv_selectorBatch.Location = New System.Drawing.Point(12, 5)
        Me.dgv_selectorBatch.Name = "dgv_selectorBatch"
        Me.dgv_selectorBatch.RowHeadersVisible = False
        Me.dgv_selectorBatch.RowTemplate.Height = 24
        Me.dgv_selectorBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_selectorBatch.Size = New System.Drawing.Size(445, 179)
        Me.dgv_selectorBatch.TabIndex = 121
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(463, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 21)
        Me.Button1.TabIndex = 123
        Me.Button1.Text = ">"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgv_selected
        '
        Me.dgv_selected.AllowUserToAddRows = False
        Me.dgv_selected.AllowUserToDeleteRows = False
        Me.dgv_selected.BackgroundColor = System.Drawing.Color.White
        Me.dgv_selected.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_selected.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_selected.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_selected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_selected.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgv_selected.EnableHeadersVisualStyles = False
        Me.dgv_selected.Location = New System.Drawing.Point(516, 5)
        Me.dgv_selected.Name = "dgv_selected"
        Me.dgv_selected.ReadOnly = True
        Me.dgv_selected.RowHeadersVisible = False
        Me.dgv_selected.RowTemplate.Height = 24
        Me.dgv_selected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_selected.Size = New System.Drawing.Size(445, 179)
        Me.dgv_selected.TabIndex = 124
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
        'btn_auto
        '
        Me.btn_auto.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_auto.FlatAppearance.BorderSize = 0
        Me.btn_auto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_auto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_auto.ForeColor = System.Drawing.Color.White
        Me.btn_auto.Location = New System.Drawing.Point(832, 219)
        Me.btn_auto.Name = "btn_auto"
        Me.btn_auto.Size = New System.Drawing.Size(131, 24)
        Me.btn_auto.TabIndex = 125
        Me.btn_auto.Text = "&Auto Select"
        Me.btn_auto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_auto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_auto.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(131, 216)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(110, 24)
        Me.btn_cancel.TabIndex = 126
        Me.btn_cancel.Text = "&Cancel"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_null)
        Me.Panel1.Controls.Add(Me.uc_null)
        Me.Panel1.Controls.Add(Me.Uc_inputbox1)
        Me.Panel1.Controls.Add(Me.uc_Ttl_need)
        Me.Panel1.Controls.Add(Me.dgv_selectorBatch)
        Me.Panel1.Controls.Add(Me.btn_update)
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.dgv_selected)
        Me.Panel1.Controls.Add(Me.btn_auto)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(956, 245)
        Me.Panel1.TabIndex = 127
        '
        'txt_null
        '
        Me.txt_null.Location = New System.Drawing.Point(287, 220)
        Me.txt_null.Name = "txt_null"
        Me.txt_null.Size = New System.Drawing.Size(100, 20)
        Me.txt_null.TabIndex = 129
        Me.txt_null.Visible = False
        Me.txt_null.WordWrap = False
        '
        'uc_null
        '
        Me.uc_null.BackColor = System.Drawing.Color.Transparent
        Me.uc_null.iAddition_SQL = Nothing
        Me.uc_null.iAdditional = Nothing
        Me.uc_null.idsc = Nothing
        Me.uc_null.iIsEnabled = True
        Me.uc_null.iIsForSearch = False
        Me.uc_null.iLabel = "Edit iLbl to edit me"
        Me.uc_null.iLabel_width = 0
        Me.uc_null.iSQL_Parameter_ID = 0
        Me.uc_null.iText = ""
        Me.uc_null.Location = New System.Drawing.Point(276, 201)
        Me.uc_null.Name = "uc_null"
        Me.uc_null.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_null.Size = New System.Drawing.Size(135, 18)
        Me.uc_null.TabIndex = 128
        Me.uc_null.Visible = False
        '
        'Uc_inputbox1
        '
        Me.Uc_inputbox1.BackColor = System.Drawing.Color.Transparent
        'Me.Uc_inputbox1.iAddition_SQL = Nothing
        Me.Uc_inputbox1.iAdditional = Nothing
        Me.Uc_inputbox1.iArrow_Visible = False
        Me.Uc_inputbox1.iCanFindLabel_SQLIDx = 0
        Me.Uc_inputbox1.iCharacterLimit = 0
        Me.Uc_inputbox1.idsc = Me.uc_null
        Me.Uc_inputbox1.iForm = Me
        Me.Uc_inputbox1.iIsDropDown = True
        Me.Uc_inputbox1.iIsEnabled = False
        Me.Uc_inputbox1.iIsForSearch = False
        Me.Uc_inputbox1.iIsID = False
        Me.Uc_inputbox1.iIsInnerShow = True
        Me.Uc_inputbox1.iLabel = "Total Selected"
        Me.Uc_inputbox1.iLabel_width = 90
        Me.Uc_inputbox1.isForFind = False
        Me.Uc_inputbox1.iSQL_Parameter_ID = 0
        Me.Uc_inputbox1.iText = ""
        Me.Uc_inputbox1.iTextBox_ = Me.txt_null
        Me.Uc_inputbox1.iTextBox_Sel_COL_ID = 0
        Me.Uc_inputbox1.iTitle = ""
        Me.Uc_inputbox1.Location = New System.Drawing.Point(516, 190)
        Me.Uc_inputbox1.Name = "Uc_inputbox1"
        Me.Uc_inputbox1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_inputbox1.Size = New System.Drawing.Size(229, 20)
        Me.Uc_inputbox1.TabIndex = 127
        '
        'uc_Ttl_need
        '
        Me.uc_Ttl_need.BackColor = System.Drawing.Color.Transparent
        'Me.uc_Ttl_need.iAddition_SQL = Nothing
        Me.uc_Ttl_need.iAdditional = Nothing
        Me.uc_Ttl_need.iArrow_Visible = False
        Me.uc_Ttl_need.iCanFindLabel_SQLIDx = 0
        Me.uc_Ttl_need.iCharacterLimit = 0
        Me.uc_Ttl_need.idsc = Me.uc_null
        Me.uc_Ttl_need.iForm = Me
        Me.uc_Ttl_need.iIsDropDown = True
        Me.uc_Ttl_need.iIsEnabled = False
        Me.uc_Ttl_need.iIsForSearch = False
        Me.uc_Ttl_need.iIsID = False
        Me.uc_Ttl_need.iIsInnerShow = True
        Me.uc_Ttl_need.iLabel = "Total Nedded"
        Me.uc_Ttl_need.iLabel_width = 90
        Me.uc_Ttl_need.isForFind = False
        Me.uc_Ttl_need.iSQL_Parameter_ID = 0
        Me.uc_Ttl_need.iText = ""
        Me.uc_Ttl_need.iTextBox_ = Me.txt_null
        Me.uc_Ttl_need.iTextBox_Sel_COL_ID = 0
        Me.uc_Ttl_need.iTitle = ""
        Me.uc_Ttl_need.Location = New System.Drawing.Point(12, 190)
        Me.uc_Ttl_need.Name = "uc_Ttl_need"
        Me.uc_Ttl_need.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_Ttl_need.Size = New System.Drawing.Size(229, 20)
        Me.uc_Ttl_need.TabIndex = 127
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(15, 216)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(110, 24)
        Me.btn_update.TabIndex = 126
        Me.btn_update.Text = "&Update"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'cms_copy
        '
        Me.cms_copy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator2})
        Me.cms_copy.Name = "ContextMenuStrip1"
        Me.cms_copy.Size = New System.Drawing.Size(168, 32)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.ToolStripMenuItem1.Text = "Copy with header"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(164, 6)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Location = New System.Drawing.Point(5, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(956, 245)
        Me.Panel2.TabIndex = 128
        Me.Panel2.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(12, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(935, 202)
        Me.DataGridView1.TabIndex = 121
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Column2"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(12, 216)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 24)
        Me.Button3.TabIndex = 126
        Me.Button3.Text = "&OK"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'batch_selectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 257)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(984, 296)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(984, 296)
        Me.Name = "batch_selectionForm"
        Me.Text = "Batch Number Selection"
        CType(Me.dgv_selectorBatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_selected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.cms_copy.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_selectorBatch As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents dgv_selected As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents btn_auto As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_null As TextBox
    Friend WithEvents uc_null As uc_label
    Public WithEvents Uc_inputbox1 As uc_inputbox
    Public WithEvents uc_Ttl_need As uc_inputbox
    Friend WithEvents btn_update As Button
    Friend WithEvents cms_copy As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
End Class
