<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EDS_FolderMaker
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
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_upload = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.uc_lbl_folderName = New IpicIndirect.uc_label()
        Me.SuspendLayout()
        '
        'tvNode
        '
        Me.tvNode.BorderStyle = System.Windows.Forms.BorderStyle.None
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
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(321, 288)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(173, 21)
        Me.btn_ok.TabIndex = 109
        Me.btn_ok.Text = "Create Root"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'btn_upload
        '
        Me.btn_upload.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_upload.FlatAppearance.BorderSize = 0
        Me.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_upload.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_upload.ForeColor = System.Drawing.Color.White
        Me.btn_upload.Location = New System.Drawing.Point(321, 375)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(173, 21)
        Me.btn_upload.TabIndex = 109
        Me.btn_upload.Text = "Save"
        Me.btn_upload.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_upload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_upload.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(321, 316)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 21)
        Me.Button2.TabIndex = 109
        Me.Button2.Text = "Create Child"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'uc_lbl_folderName
        '
        Me.uc_lbl_folderName.BackColor = System.Drawing.Color.Transparent
        Me.uc_lbl_folderName.iAddition_SQL = Nothing
        Me.uc_lbl_folderName.iAdditional = Nothing
        Me.uc_lbl_folderName.idsc = Nothing
        Me.uc_lbl_folderName.iIsEnabled = True
        Me.uc_lbl_folderName.iIsForSearch = False
        Me.uc_lbl_folderName.iLabel = "Folder Name"
        Me.uc_lbl_folderName.iLabel_width = 100
        Me.uc_lbl_folderName.iSQL_Parameter_ID = 0
        Me.uc_lbl_folderName.iText = ""
        Me.uc_lbl_folderName.Location = New System.Drawing.Point(268, 30)
        Me.uc_lbl_folderName.Name = "uc_lbl_folderName"
        Me.uc_lbl_folderName.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.uc_lbl_folderName.Size = New System.Drawing.Size(265, 23)
        Me.uc_lbl_folderName.TabIndex = 93
        '
        'EDS_FolderMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 413)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_upload)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.uc_lbl_folderName)
        Me.Controls.Add(Me.tvNode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EDS_FolderMaker"
        Me.Text = "EDS_FolderMaker"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tvNode As TreeView
    Friend WithEvents uc_lbl_folderName As uc_label
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_upload As Button
    Friend WithEvents Button2 As Button
End Class
