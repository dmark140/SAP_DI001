<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueryManager
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_apv = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Uc_label5 = New IpicIndirect.uc_label()
        Me.Uc_label2 = New IpicIndirect.uc_label()
        Me.Uc_label4 = New IpicIndirect.uc_label()
        Me.Uc_label1 = New IpicIndirect.uc_label()
        Me.Uc_label3 = New IpicIndirect.uc_label()
        CType(Me.dgv_apv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_apv
        '
        Me.dgv_apv.AllowUserToAddRows = False
        Me.dgv_apv.AllowUserToDeleteRows = False
        Me.dgv_apv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.dgv_apv.Location = New System.Drawing.Point(12, 89)
        Me.dgv_apv.Name = "dgv_apv"
        Me.dgv_apv.ReadOnly = True
        Me.dgv_apv.RowHeadersVisible = False
        Me.dgv_apv.RowTemplate.Height = 24
        Me.dgv_apv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_apv.Size = New System.Drawing.Size(285, 536)
        Me.dgv_apv.TabIndex = 93
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(303, 89)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(595, 315)
        Me.TextBox1.TabIndex = 178
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(303, 432)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(595, 193)
        Me.DataGridView1.TabIndex = 182
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(809, 639)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 21)
        Me.Button2.TabIndex = 183
        Me.Button2.Text = "Execute"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 639)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 21)
        Me.Button1.TabIndex = 183
        Me.Button1.Text = "Add"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Uc_label5
        '
        Me.Uc_label5.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label5.iAddition_SQL = Nothing
        Me.Uc_label5.iAdditional = Nothing
        Me.Uc_label5.idsc = Nothing
        Me.Uc_label5.iIsEnabled = False
        Me.Uc_label5.iIsForSearch = False
        Me.Uc_label5.iLabel = "Query Code"
        Me.Uc_label5.iLabel_width = 124
        Me.Uc_label5.isLabelBoldx = False
        Me.Uc_label5.iSQL_Parameter_ID = 0
        Me.Uc_label5.iText = ""
        Me.Uc_label5.Location = New System.Drawing.Point(12, 10)
        Me.Uc_label5.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label5.Name = "Uc_label5"
        Me.Uc_label5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label5.Size = New System.Drawing.Size(301, 20)
        Me.Uc_label5.TabIndex = 184
        '
        'Uc_label2
        '
        Me.Uc_label2.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label2.iAddition_SQL = Nothing
        Me.Uc_label2.iAdditional = Nothing
        Me.Uc_label2.idsc = Nothing
        Me.Uc_label2.iIsEnabled = True
        Me.Uc_label2.iIsForSearch = False
        Me.Uc_label2.iLabel = "Query Name"
        Me.Uc_label2.iLabel_width = 124
        Me.Uc_label2.isLabelBoldx = False
        Me.Uc_label2.iSQL_Parameter_ID = 0
        Me.Uc_label2.iText = ""
        Me.Uc_label2.Location = New System.Drawing.Point(12, 35)
        Me.Uc_label2.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label2.Name = "Uc_label2"
        Me.Uc_label2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label2.Size = New System.Drawing.Size(301, 20)
        Me.Uc_label2.TabIndex = 180
        '
        'Uc_label4
        '
        Me.Uc_label4.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label4.iAddition_SQL = Nothing
        Me.Uc_label4.iAdditional = Nothing
        Me.Uc_label4.idsc = Nothing
        Me.Uc_label4.iIsEnabled = True
        Me.Uc_label4.iIsForSearch = False
        Me.Uc_label4.iLabel = "Query Results"
        Me.Uc_label4.iLabel_width = 115
        Me.Uc_label4.isLabelBoldx = False
        Me.Uc_label4.iSQL_Parameter_ID = 0
        Me.Uc_label4.iText = ""
        Me.Uc_label4.Location = New System.Drawing.Point(303, 408)
        Me.Uc_label4.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label4.Name = "Uc_label4"
        Me.Uc_label4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label4.Size = New System.Drawing.Size(113, 20)
        Me.Uc_label4.TabIndex = 177
        '
        'Uc_label1
        '
        Me.Uc_label1.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label1.iAddition_SQL = Nothing
        Me.Uc_label1.iAdditional = Nothing
        Me.Uc_label1.idsc = Nothing
        Me.Uc_label1.iIsEnabled = True
        Me.Uc_label1.iIsForSearch = False
        Me.Uc_label1.iLabel = "Query Structure"
        Me.Uc_label1.iLabel_width = 115
        Me.Uc_label1.isLabelBoldx = False
        Me.Uc_label1.iSQL_Parameter_ID = 0
        Me.Uc_label1.iText = ""
        Me.Uc_label1.Location = New System.Drawing.Point(303, 66)
        Me.Uc_label1.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label1.Name = "Uc_label1"
        Me.Uc_label1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label1.Size = New System.Drawing.Size(113, 20)
        Me.Uc_label1.TabIndex = 177
        '
        'Uc_label3
        '
        Me.Uc_label3.BackColor = System.Drawing.Color.Transparent
        Me.Uc_label3.iAddition_SQL = Nothing
        Me.Uc_label3.iAdditional = Nothing
        Me.Uc_label3.idsc = Nothing
        Me.Uc_label3.iIsEnabled = True
        Me.Uc_label3.iIsForSearch = False
        Me.Uc_label3.iLabel = "Query List"
        Me.Uc_label3.iLabel_width = 115
        Me.Uc_label3.isLabelBoldx = False
        Me.Uc_label3.iSQL_Parameter_ID = 0
        Me.Uc_label3.iText = ""
        Me.Uc_label3.Location = New System.Drawing.Point(12, 65)
        Me.Uc_label3.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_label3.Name = "Uc_label3"
        Me.Uc_label3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_label3.Size = New System.Drawing.Size(113, 20)
        Me.Uc_label3.TabIndex = 177
        '
        'QueryManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 672)
        Me.Controls.Add(Me.Uc_label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Uc_label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Uc_label4)
        Me.Controls.Add(Me.Uc_label1)
        Me.Controls.Add(Me.Uc_label3)
        Me.Controls.Add(Me.dgv_apv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QueryManager"
        CType(Me.dgv_apv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_apv As DataGridView
    Friend WithEvents Uc_label3 As uc_label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Uc_label1 As uc_label
    Friend WithEvents Uc_label2 As uc_label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Uc_label4 As uc_label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Uc_label5 As uc_label
End Class
