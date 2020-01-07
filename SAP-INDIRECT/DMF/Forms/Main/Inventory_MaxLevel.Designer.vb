<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory_MaxLevel
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_null = New System.Windows.Forms.TextBox()
        Me.uc_warehouseNo = New IpicIndirect.uc_label()
        Me.btn_find_PO = New System.Windows.Forms.Button()
        Me.Uc_separatorH1 = New IpicIndirect.uc_separatorH()
        Me.Uc_itemN = New IpicIndirect.uc_inputbox()
        Me.uc_desc = New IpicIndirect.uc_label()
        Me.uc_newMax = New IpicIndirect.uc_label()
        Me.uc_curMax = New IpicIndirect.uc_label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_null)
        Me.Panel1.Controls.Add(Me.uc_warehouseNo)
        Me.Panel1.Controls.Add(Me.btn_find_PO)
        Me.Panel1.Controls.Add(Me.Uc_separatorH1)
        Me.Panel1.Controls.Add(Me.Uc_itemN)
        Me.Panel1.Controls.Add(Me.uc_newMax)
        Me.Panel1.Controls.Add(Me.uc_curMax)
        Me.Panel1.Controls.Add(Me.uc_desc)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 365)
        Me.Panel1.TabIndex = 4
        '
        'txt_null
        '
        Me.txt_null.Location = New System.Drawing.Point(0, 0)
        Me.txt_null.Name = "txt_null"
        Me.txt_null.Size = New System.Drawing.Size(100, 20)
        Me.txt_null.TabIndex = 115
        Me.txt_null.Visible = False
        '
        'uc_warehouseNo
        '
        Me.uc_warehouseNo.BackColor = System.Drawing.Color.Transparent
        Me.uc_warehouseNo.iAddition_SQL = Nothing
        Me.uc_warehouseNo.iAdditional = Nothing
        Me.uc_warehouseNo.idsc = Nothing
        Me.uc_warehouseNo.iIsEnabled = False
        Me.uc_warehouseNo.iIsForSearch = False
        Me.uc_warehouseNo.iLabel = "  Warehouse #"
        Me.uc_warehouseNo.iLabel_width = 130
        Me.uc_warehouseNo.iSQL_Parameter_ID = 0
        Me.uc_warehouseNo.iText = ""
        Me.uc_warehouseNo.Location = New System.Drawing.Point(11, 89)
        Me.uc_warehouseNo.Name = "uc_warehouseNo"
        Me.uc_warehouseNo.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_warehouseNo.Size = New System.Drawing.Size(380, 30)
        Me.uc_warehouseNo.TabIndex = 114
        '
        'btn_find_PO
        '
        Me.btn_find_PO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_find_PO.FlatAppearance.BorderSize = 0
        Me.btn_find_PO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_find_PO.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_find_PO.ForeColor = System.Drawing.Color.White
        Me.btn_find_PO.Location = New System.Drawing.Point(12, 197)
        Me.btn_find_PO.Name = "btn_find_PO"
        Me.btn_find_PO.Size = New System.Drawing.Size(108, 21)
        Me.btn_find_PO.TabIndex = 113
        Me.btn_find_PO.Text = "Update"
        Me.btn_find_PO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_find_PO.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_find_PO.UseVisualStyleBackColor = False
        '
        'Uc_separatorH1
        '
        Me.Uc_separatorH1.BackColor = System.Drawing.Color.White
        Me.Uc_separatorH1.iForm = Me
        Me.Uc_separatorH1.Location = New System.Drawing.Point(0, 75)
        Me.Uc_separatorH1.Margin = New System.Windows.Forms.Padding(1)
        Me.Uc_separatorH1.Name = "Uc_separatorH1"
        Me.Uc_separatorH1.Size = New System.Drawing.Size(441, 10)
        Me.Uc_separatorH1.TabIndex = 8
        '
        'Uc_itemN
        '
        Me.Uc_itemN.BackColor = System.Drawing.Color.Transparent
        Me.Uc_itemN.iAddition_SQL = Nothing
        Me.Uc_itemN.iAdditional = Nothing
        Me.Uc_itemN.iArrow_Visible = True
        Me.Uc_itemN.iCanFindLabel_SQLIDx = 0
        Me.Uc_itemN.iCharacterLimit = 0
        Me.Uc_itemN.idsc = Me.uc_desc
        Me.Uc_itemN.iForm = Me
        Me.Uc_itemN.iIsDropDown = False
        Me.Uc_itemN.iIsEnabled = True
        Me.Uc_itemN.iIsForSearch = True
        Me.Uc_itemN.iIsID = False
        Me.Uc_itemN.iIsInnerShow = True
        Me.Uc_itemN.iLabel = "Item No."
        Me.Uc_itemN.iLabel_width = 130
        Me.Uc_itemN.isForFind = False
        Me.Uc_itemN.iSQL_Parameter_ID = 1
        Me.Uc_itemN.iText = ""
        Me.Uc_itemN.iTextBox_ = Me.txt_null
        Me.Uc_itemN.iTextBox_Sel_COL_ID = 0
        Me.Uc_itemN.iTitle = ""
        Me.Uc_itemN.Location = New System.Drawing.Point(11, 12)
        Me.Uc_itemN.Name = "Uc_itemN"
        Me.Uc_itemN.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Uc_itemN.Size = New System.Drawing.Size(250, 23)
        Me.Uc_itemN.TabIndex = 7
        '
        'uc_desc
        '
        Me.uc_desc.BackColor = System.Drawing.Color.Transparent
        Me.uc_desc.iAddition_SQL = Nothing
        Me.uc_desc.iAdditional = Nothing
        Me.uc_desc.idsc = Nothing
        Me.uc_desc.iIsEnabled = False
        Me.uc_desc.iIsForSearch = False
        Me.uc_desc.iLabel = "  Description"
        Me.uc_desc.iLabel_width = 130
        Me.uc_desc.iSQL_Parameter_ID = 0
        Me.uc_desc.iText = ""
        Me.uc_desc.Location = New System.Drawing.Point(11, 41)
        Me.uc_desc.Name = "uc_desc"
        Me.uc_desc.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_desc.Size = New System.Drawing.Size(380, 30)
        Me.uc_desc.TabIndex = 6
        '
        'uc_newMax
        '
        Me.uc_newMax.BackColor = System.Drawing.Color.Transparent
        Me.uc_newMax.iAddition_SQL = Nothing
        Me.uc_newMax.iAdditional = Nothing
        Me.uc_newMax.idsc = Nothing
        Me.uc_newMax.iIsEnabled = True
        Me.uc_newMax.iIsForSearch = False
        Me.uc_newMax.iLabel = "  New  Maximum"
        Me.uc_newMax.iLabel_width = 130
        Me.uc_newMax.iSQL_Parameter_ID = 0
        Me.uc_newMax.iText = ""
        Me.uc_newMax.Location = New System.Drawing.Point(12, 161)
        Me.uc_newMax.Name = "uc_newMax"
        Me.uc_newMax.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_newMax.Size = New System.Drawing.Size(380, 30)
        Me.uc_newMax.TabIndex = 4
        '
        'uc_curMax
        '
        Me.uc_curMax.BackColor = System.Drawing.Color.Transparent
        Me.uc_curMax.iAddition_SQL = Nothing
        Me.uc_curMax.iAdditional = Nothing
        Me.uc_curMax.idsc = Nothing
        Me.uc_curMax.iIsEnabled = False
        Me.uc_curMax.iIsForSearch = False
        Me.uc_curMax.iLabel = "  Current Maximum"
        Me.uc_curMax.iLabel_width = 130
        Me.uc_curMax.iSQL_Parameter_ID = 0
        Me.uc_curMax.iText = ""
        Me.uc_curMax.Location = New System.Drawing.Point(12, 125)
        Me.uc_curMax.Name = "uc_curMax"
        Me.uc_curMax.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_curMax.Size = New System.Drawing.Size(380, 30)
        Me.uc_curMax.TabIndex = 5
        '
        'Inventory_MaxLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(425, 385)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inventory_MaxLevel"
        Me.Text = "Inventory_MaxLevel"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Uc_separatorH1 As uc_separatorH
    Friend WithEvents Uc_itemN As uc_inputbox
    Friend WithEvents uc_newMax As uc_label
    Friend WithEvents uc_curMax As uc_label
    Friend WithEvents uc_desc As uc_label
    Friend WithEvents btn_find_PO As Button
    Friend WithEvents uc_warehouseNo As uc_label
    Friend WithEvents txt_null As TextBox
End Class
