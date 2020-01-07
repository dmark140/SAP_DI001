<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dmf_NodeCreator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dmf_NodeCreator))
        Me.tvNode = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_NewFolder = New System.Windows.Forms.Button()
        Me.btn_addRoot = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAccLevel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_set = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MS_1 = New System.Windows.Forms.MenuStrip()
        Me.t_remove = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_main = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsm_remove = New System.Windows.Forms.ToolStripMenuItem()
        Me.Uc_header1 = New IpicIndirect.uc_header()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MS_1.SuspendLayout()
        Me.tsm_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'tvNode
        '
        Me.tvNode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvNode.ForeColor = System.Drawing.Color.Black
        Me.tvNode.FullRowSelect = True
        Me.tvNode.HideSelection = False
        Me.tvNode.ItemHeight = 20
        Me.tvNode.Location = New System.Drawing.Point(19, 88)
        Me.tvNode.Name = "tvNode"
        Me.tvNode.PathSeparator = "-"
        Me.tvNode.ShowLines = False
        Me.tvNode.Size = New System.Drawing.Size(250, 346)
        Me.tvNode.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-triangle-arrow-24 - Copy.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8-triangle-arrow-24.png")
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(180, 467)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(89, 21)
        Me.btn_ok.TabIndex = 61
        Me.btn_ok.Text = "Save"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'btn_NewFolder
        '
        Me.btn_NewFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_NewFolder.FlatAppearance.BorderSize = 0
        Me.btn_NewFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_NewFolder.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NewFolder.ForeColor = System.Drawing.Color.White
        Me.btn_NewFolder.Location = New System.Drawing.Point(19, 440)
        Me.btn_NewFolder.Name = "btn_NewFolder"
        Me.btn_NewFolder.Size = New System.Drawing.Size(89, 21)
        Me.btn_NewFolder.TabIndex = 61
        Me.btn_NewFolder.Text = "New Folder"
        Me.btn_NewFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_NewFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_NewFolder.UseVisualStyleBackColor = False
        '
        'btn_addRoot
        '
        Me.btn_addRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_addRoot.FlatAppearance.BorderSize = 0
        Me.btn_addRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addRoot.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addRoot.ForeColor = System.Drawing.Color.White
        Me.btn_addRoot.Location = New System.Drawing.Point(180, 440)
        Me.btn_addRoot.Name = "btn_addRoot"
        Me.btn_addRoot.Size = New System.Drawing.Size(89, 21)
        Me.btn_addRoot.TabIndex = 62
        Me.btn_addRoot.Text = "New Root"
        Me.btn_addRoot.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_addRoot.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_addRoot.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(314, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Name(ID)"
        Me.Label3.Visible = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(314, 332)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(89, 20)
        Me.txtName.TabIndex = 65
        Me.txtName.Visible = False
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(19, 62)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(122, 20)
        Me.txtText.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(19, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Folder Name"
        '
        'txtAccLevel
        '
        Me.txtAccLevel.Location = New System.Drawing.Point(147, 62)
        Me.txtAccLevel.Name = "txtAccLevel"
        Me.txtAccLevel.Size = New System.Drawing.Size(122, 20)
        Me.txtAccLevel.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(147, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 17)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Root Level"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(5, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 17)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Node Properties"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(314, 348)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Administrator"
        Me.Label5.Visible = False
        '
        'btn_set
        '
        Me.btn_set.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_set.FlatAppearance.BorderSize = 0
        Me.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_set.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_set.ForeColor = System.Drawing.Color.White
        Me.btn_set.Location = New System.Drawing.Point(314, 273)
        Me.btn_set.Name = "btn_set"
        Me.btn_set.Size = New System.Drawing.Size(89, 21)
        Me.btn_set.TabIndex = 73
        Me.btn_set.Text = "Update"
        Me.btn_set.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_set.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_set.UseVisualStyleBackColor = False
        Me.btn_set.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(314, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 21)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Save"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(19, 467)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 21)
        Me.Button2.TabIndex = 75
        Me.Button2.Text = "Cancel"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MS_1
        '
        Me.MS_1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.t_remove})
        Me.MS_1.Location = New System.Drawing.Point(0, 0)
        Me.MS_1.Name = "MS_1"
        Me.MS_1.Size = New System.Drawing.Size(787, 24)
        Me.MS_1.TabIndex = 76
        Me.MS_1.Text = "MenuStrip1"
        '
        't_remove
        '
        Me.t_remove.Name = "t_remove"
        Me.t_remove.Size = New System.Drawing.Size(62, 20)
        Me.t_remove.Text = "&Remove"
        '
        'tsm_main
        '
        Me.tsm_main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_remove})
        Me.tsm_main.Name = "tsm_main"
        Me.tsm_main.Size = New System.Drawing.Size(118, 26)
        '
        'tsm_remove
        '
        Me.tsm_remove.Name = "tsm_remove"
        Me.tsm_remove.Size = New System.Drawing.Size(117, 22)
        Me.tsm_remove.Text = "&Remove"
        '
        'Uc_header1
        '
        Me.Uc_header1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Uc_header1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Uc_header1.iFrom = Me
        Me.Uc_header1.iText = " Node Creator"
        Me.Uc_header1.Location = New System.Drawing.Point(0, 0)
        Me.Uc_header1.Name = "Uc_header1"
        Me.Uc_header1.Size = New System.Drawing.Size(808, 19)
        Me.Uc_header1.TabIndex = 77
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(180, 494)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 21)
        Me.Button3.TabIndex = 78
        Me.Button3.Text = "Update"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'dmf_NodeCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 562)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Uc_header1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_set)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAccLevel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_addRoot)
        Me.Controls.Add(Me.btn_NewFolder)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.tvNode)
        Me.Controls.Add(Me.MS_1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MS_1
        Me.Name = "dmf_NodeCreator"
        Me.Text = "dmf_NodeCreator"
        Me.MS_1.ResumeLayout(False)
        Me.MS_1.PerformLayout()
        Me.tsm_main.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tvNode As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_NewFolder As Button
    Friend WithEvents btn_addRoot As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAccLevel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_set As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MS_1 As MenuStrip
    Friend WithEvents t_remove As ToolStripMenuItem
    Friend WithEvents tsm_main As ContextMenuStrip
    Friend WithEvents tsm_remove As ToolStripMenuItem
    Friend WithEvents Uc_header1 As uc_header
    Friend WithEvents Button3 As Button
End Class
