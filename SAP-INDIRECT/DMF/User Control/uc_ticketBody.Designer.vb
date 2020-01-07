<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_ticketBody
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uc_ticketBody))
        Me.imgAttched = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_owner = New System.Windows.Forms.Label()
        Me.lvl_ownerInformation = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.pic_attched = New System.Windows.Forms.PictureBox()
        Me.lbl_attachedFile = New System.Windows.Forms.Label()
        Me.btn_zoom = New System.Windows.Forms.Button()
        Me.conatiner_attach = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_attched, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.conatiner_attach.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgAttched
        '
        Me.imgAttched.ImageStream = CType(resources.GetObject("imgAttched.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgAttched.TransparentColor = System.Drawing.Color.Transparent
        Me.imgAttched.Images.SetKeyName(0, "ms jpg.png")
        Me.imgAttched.Images.SetKeyName(1, "ms png.png")
        Me.imgAttched.Images.SetKeyName(2, "ms excel.png")
        Me.imgAttched.Images.SetKeyName(3, "ms word.png")
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(697, 10)
        Me.Panel1.TabIndex = 126
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(-1, -21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(690, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'lbl_owner
        '
        Me.lbl_owner.AutoSize = True
        Me.lbl_owner.BackColor = System.Drawing.Color.Transparent
        Me.lbl_owner.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_owner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_owner.Location = New System.Drawing.Point(5, 3)
        Me.lbl_owner.Name = "lbl_owner"
        Me.lbl_owner.Size = New System.Drawing.Size(40, 17)
        Me.lbl_owner.TabIndex = 128
        Me.lbl_owner.Text = "Dean"
        '
        'lvl_ownerInformation
        '
        Me.lvl_ownerInformation.AutoSize = True
        Me.lvl_ownerInformation.BackColor = System.Drawing.Color.Transparent
        Me.lvl_ownerInformation.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvl_ownerInformation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lvl_ownerInformation.Location = New System.Drawing.Point(6, 20)
        Me.lvl_ownerInformation.Name = "lvl_ownerInformation"
        Me.lvl_ownerInformation.Size = New System.Drawing.Size(133, 17)
        Me.lvl_ownerInformation.TabIndex = 129
        Me.lvl_ownerInformation.Text = "Deanmark Famoleras"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(8, 56)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(671, 293)
        Me.RichTextBox1.TabIndex = 131
        Me.RichTextBox1.Text = ""
        '
        'pic_attched
        '
        Me.pic_attched.ErrorImage = Global.IpicIndirect.My.Resources.Resources.icons8_image_100
        Me.pic_attched.InitialImage = Global.IpicIndirect.My.Resources.Resources.icons8_image_100
        Me.pic_attched.Location = New System.Drawing.Point(5, 4)
        Me.pic_attched.Name = "pic_attched"
        Me.pic_attched.Size = New System.Drawing.Size(30, 28)
        Me.pic_attched.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_attched.TabIndex = 123
        Me.pic_attched.TabStop = False
        '
        'lbl_attachedFile
        '
        Me.lbl_attachedFile.AutoSize = True
        Me.lbl_attachedFile.Location = New System.Drawing.Point(41, 14)
        Me.lbl_attachedFile.Name = "lbl_attachedFile"
        Me.lbl_attachedFile.Size = New System.Drawing.Size(39, 13)
        Me.lbl_attachedFile.TabIndex = 123
        Me.lbl_attachedFile.Text = "Label4"
        '
        'btn_zoom
        '
        Me.btn_zoom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_zoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_zoom.FlatAppearance.BorderSize = 0
        Me.btn_zoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_zoom.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_zoom.ForeColor = System.Drawing.Color.White
        Me.btn_zoom.Location = New System.Drawing.Point(651, -3)
        Me.btn_zoom.Name = "btn_zoom"
        Me.btn_zoom.Size = New System.Drawing.Size(20, 21)
        Me.btn_zoom.TabIndex = 126
        Me.btn_zoom.Tag = "1"
        Me.btn_zoom.Text = "+"
        Me.btn_zoom.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_zoom.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_zoom.UseVisualStyleBackColor = False
        Me.btn_zoom.Visible = False
        '
        'conatiner_attach
        '
        Me.conatiner_attach.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.conatiner_attach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.conatiner_attach.Controls.Add(Me.btn_zoom)
        Me.conatiner_attach.Controls.Add(Me.lbl_attachedFile)
        Me.conatiner_attach.Controls.Add(Me.pic_attched)
        Me.conatiner_attach.Location = New System.Drawing.Point(9, 355)
        Me.conatiner_attach.Name = "conatiner_attach"
        Me.conatiner_attach.Size = New System.Drawing.Size(670, 39)
        Me.conatiner_attach.TabIndex = 124
        Me.conatiner_attach.Visible = False
        '
        'uc_ticketBody
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.lvl_ownerInformation)
        Me.Controls.Add(Me.lbl_owner)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.conatiner_attach)
        Me.Name = "uc_ticketBody"
        Me.Size = New System.Drawing.Size(688, 404)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pic_attched, System.ComponentModel.ISupportInitialize).EndInit()
        Me.conatiner_attach.ResumeLayout(False)
        Me.conatiner_attach.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgAttched As ImageList
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Public WithEvents lbl_owner As Label
    Public WithEvents lvl_ownerInformation As Label
    Friend WithEvents pic_attched As PictureBox
    Friend WithEvents lbl_attachedFile As Label
    Friend WithEvents btn_zoom As Button
    Friend WithEvents conatiner_attach As Panel
End Class
