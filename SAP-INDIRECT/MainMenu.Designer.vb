<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.SplitCon = New System.Windows.Forms.SplitContainer()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tvNode = New System.Windows.Forms.TreeView()
        Me.imglist_tv_indicator = New System.Windows.Forms.ImageList(Me.components)
        Me.MainTab = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imgList_ = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_bback = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_frwd = New System.Windows.Forms.Button()
        Me.btn_refreash = New System.Windows.Forms.Button()
        Me.btn_ffrwd = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SplitCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitCon.Panel1.SuspendLayout()
        Me.SplitCon.Panel2.SuspendLayout()
        Me.SplitCon.SuspendLayout()
        Me.MainTab.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitCon
        '
        Me.SplitCon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitCon.Location = New System.Drawing.Point(1, 46)
        Me.SplitCon.Name = "SplitCon"
        '
        'SplitCon.Panel1
        '
        Me.SplitCon.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SplitCon.Panel1.Controls.Add(Me.Label9)
        Me.SplitCon.Panel1.Controls.Add(Me.tvNode)
        Me.SplitCon.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        '
        'SplitCon.Panel2
        '
        Me.SplitCon.Panel2.Controls.Add(Me.MainTab)
        Me.SplitCon.Size = New System.Drawing.Size(1411, 696)
        Me.SplitCon.SplitterDistance = 453
        Me.SplitCon.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(278, 20)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Main Menu"
        '
        'tvNode
        '
        Me.tvNode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tvNode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvNode.ForeColor = System.Drawing.Color.Black
        Me.tvNode.FullRowSelect = True
        Me.tvNode.HideSelection = False
        Me.tvNode.ImageIndex = 0
        Me.tvNode.ImageList = Me.imglist_tv_indicator
        Me.tvNode.ItemHeight = 20
        Me.tvNode.Location = New System.Drawing.Point(0, 21)
        Me.tvNode.Name = "tvNode"
        Me.tvNode.PathSeparator = "-"
        Me.tvNode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tvNode.SelectedImageIndex = 0
        Me.tvNode.ShowLines = False
        Me.tvNode.ShowPlusMinus = False
        Me.tvNode.ShowRootLines = False
        Me.tvNode.Size = New System.Drawing.Size(451, 677)
        Me.tvNode.TabIndex = 1
        '
        'imglist_tv_indicator
        '
        Me.imglist_tv_indicator.ImageStream = CType(resources.GetObject("imglist_tv_indicator.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglist_tv_indicator.TransparentColor = System.Drawing.Color.Transparent
        Me.imglist_tv_indicator.Images.SetKeyName(0, "icons8-folder-96.png")
        Me.imglist_tv_indicator.Images.SetKeyName(1, "Empty.png")
        '
        'MainTab
        '
        Me.MainTab.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.MainTab.Controls.Add(Me.MetroTabPage1)
        Me.MainTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTab.ItemSize = New System.Drawing.Size(54, 20)
        Me.MainTab.Location = New System.Drawing.Point(0, 0)
        Me.MainTab.Name = "MainTab"
        Me.MainTab.SelectedIndex = 0
        Me.MainTab.Size = New System.Drawing.Size(952, 694)
        Me.MainTab.Style = MetroFramework.MetroColorStyle.Silver
        Me.MainTab.TabIndex = 4
        Me.MainTab.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.PictureBox2)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 24)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(944, 666)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "   HOME   "
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(944, 666)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'mainPanel
        '
        Me.mainPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.mainPanel.Location = New System.Drawing.Point(247, -19)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(222, 16)
        Me.mainPanel.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 745)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1412, 21)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 21)
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(67, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 20)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Main Menu"
        '
        'imgList_
        '
        Me.imgList_.ImageStream = CType(resources.GetObject("imgList_.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList_.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList_.Images.SetKeyName(0, "I.png")
        Me.imgList_.Images.SetKeyName(1, "X.png")
        Me.imgList_.Images.SetKeyName(2, "Y.png")
        '
        'btn_bback
        '
        Me.btn_bback.BackgroundImage = CType(resources.GetObject("btn_bback.BackgroundImage"), System.Drawing.Image)
        Me.btn_bback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_bback.FlatAppearance.BorderSize = 0
        Me.btn_bback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bback.Location = New System.Drawing.Point(20, 1)
        Me.btn_bback.Name = "btn_bback"
        Me.btn_bback.Size = New System.Drawing.Size(19, 43)
        Me.btn_bback.TabIndex = 94
        Me.btn_bback.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.BackgroundImage = CType(resources.GetObject("btn_back.BackgroundImage"), System.Drawing.Image)
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_back.FlatAppearance.BorderSize = 0
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Location = New System.Drawing.Point(45, 1)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(19, 43)
        Me.btn_back.TabIndex = 95
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_frwd
        '
        Me.btn_frwd.BackgroundImage = CType(resources.GetObject("btn_frwd.BackgroundImage"), System.Drawing.Image)
        Me.btn_frwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_frwd.FlatAppearance.BorderSize = 0
        Me.btn_frwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_frwd.Location = New System.Drawing.Point(95, 1)
        Me.btn_frwd.Name = "btn_frwd"
        Me.btn_frwd.Size = New System.Drawing.Size(19, 43)
        Me.btn_frwd.TabIndex = 97
        Me.btn_frwd.UseVisualStyleBackColor = True
        '
        'btn_refreash
        '
        Me.btn_refreash.BackgroundImage = CType(resources.GetObject("btn_refreash.BackgroundImage"), System.Drawing.Image)
        Me.btn_refreash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_refreash.FlatAppearance.BorderSize = 0
        Me.btn_refreash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refreash.Location = New System.Drawing.Point(70, 1)
        Me.btn_refreash.Name = "btn_refreash"
        Me.btn_refreash.Size = New System.Drawing.Size(19, 43)
        Me.btn_refreash.TabIndex = 96
        Me.btn_refreash.UseVisualStyleBackColor = True
        '
        'btn_ffrwd
        '
        Me.btn_ffrwd.BackgroundImage = CType(resources.GetObject("btn_ffrwd.BackgroundImage"), System.Drawing.Image)
        Me.btn_ffrwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_ffrwd.FlatAppearance.BorderSize = 0
        Me.btn_ffrwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ffrwd.Location = New System.Drawing.Point(120, 1)
        Me.btn_ffrwd.Name = "btn_ffrwd"
        Me.btn_ffrwd.Size = New System.Drawing.Size(19, 43)
        Me.btn_ffrwd.TabIndex = 98
        Me.btn_ffrwd.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1412, 766)
        Me.Controls.Add(Me.btn_ffrwd)
        Me.Controls.Add(Me.btn_frwd)
        Me.Controls.Add(Me.btn_refreash)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_bback)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.SplitCon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1428, 398)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitCon.Panel1.ResumeLayout(False)
        Me.SplitCon.Panel2.ResumeLayout(False)
        CType(Me.SplitCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitCon.ResumeLayout(False)
        Me.MainTab.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitCon As SplitContainer
    Friend WithEvents tvNode As TreeView
    Friend WithEvents Panel1 As Panel
    Public WithEvents mainPanel As Panel
    Friend WithEvents imglist_tv_indicator As ImageList
    Friend WithEvents Label9 As Label
    Friend WithEvents imgList_ As ImageList
    Friend WithEvents MainTab As MetroFramework.Controls.MetroTabControl
    Friend WithEvents btn_bback As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_frwd As Button
    Friend WithEvents btn_refreash As Button
    Friend WithEvents btn_ffrwd As Button
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
