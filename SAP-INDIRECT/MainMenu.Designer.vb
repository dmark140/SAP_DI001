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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.SplitCon = New System.Windows.Forms.SplitContainer()
        Me.btn_Item_arrow = New System.Windows.Forms.Button()
        Me.dgv_moduleFInd = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tvNode = New System.Windows.Forms.TreeView()
        Me.imglist_tv_indicator = New System.Windows.Forms.ImageList(Me.components)
        Me.MainTab = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.txt_moDuleFind = New System.Windows.Forms.PictureBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.Panel_notif = New System.Windows.Forms.Panel()
        Me.lbl_notif = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.imgList_ = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.notif_time = New System.Windows.Forms.Timer(Me.components)
        Me.menuIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.menuIconsMono = New System.Windows.Forms.ImageList(Me.components)
        Me.CMS_Triger = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMS_ADD = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMD_FIND = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMS_RIGHT_MAX = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMS_RIGHT = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMS_LEFT = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMS_LEFT_RIGHT = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMS_REFRESH = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMD_PROFILE = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS_menu = New System.Windows.Forms.MenuStrip()
        Me.MS_ADD = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS_FIND = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS_LEFT_MAX = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS_LEFT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS_RIGHT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS__RIGHTMAX = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS_REFRESH = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS_PROFILE = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS_EXPAND = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_profile1 = New System.Windows.Forms.Label()
        Me.lbl_profile2 = New System.Windows.Forms.Label()
        Me.lbl_load_bar = New System.Windows.Forms.Label()
        Me.btn_maxMin = New System.Windows.Forms.Button()
        Me.btn_menu_add = New System.Windows.Forms.Button()
        Me.btn_menu_find = New System.Windows.Forms.Button()
        Me.btn_menu_RightMax = New System.Windows.Forms.Button()
        Me.btn_menu_Right = New System.Windows.Forms.Button()
        Me.btn_menu_Left = New System.Windows.Forms.Button()
        Me.btn_menu_LeftMax = New System.Windows.Forms.Button()
        Me.btn_menu_Refresh = New System.Windows.Forms.Button()
        Me.btn_menu_Profile = New System.Windows.Forms.Button()
        CType(Me.SplitCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitCon.Panel1.SuspendLayout()
        Me.SplitCon.Panel2.SuspendLayout()
        Me.SplitCon.SuspendLayout()
        CType(Me.dgv_moduleFInd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainTab.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.txt_moDuleFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_notif.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMS_Triger.SuspendLayout()
        Me.MS_menu.SuspendLayout()
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
        Me.SplitCon.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.SplitCon.Panel1.Controls.Add(Me.btn_Item_arrow)
        Me.SplitCon.Panel1.Controls.Add(Me.dgv_moduleFInd)
        Me.SplitCon.Panel1.Controls.Add(Me.txt_search)
        Me.SplitCon.Panel1.Controls.Add(Me.Label9)
        Me.SplitCon.Panel1.Controls.Add(Me.tvNode)
        Me.SplitCon.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SplitCon.Panel1MinSize = 0
        '
        'SplitCon.Panel2
        '
        Me.SplitCon.Panel2.Controls.Add(Me.MainTab)
        Me.SplitCon.Panel2MinSize = 0
        Me.SplitCon.Size = New System.Drawing.Size(1411, 696)
        Me.SplitCon.SplitterDistance = 351
        Me.SplitCon.TabIndex = 0
        '
        'btn_Item_arrow
        '
        Me.btn_Item_arrow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Item_arrow.BackColor = System.Drawing.Color.White
        Me.btn_Item_arrow.BackgroundImage = Global.IpicIndirect.My.Resources.Resources.icons8_arrow_96
        Me.btn_Item_arrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Item_arrow.FlatAppearance.BorderSize = 0
        Me.btn_Item_arrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Item_arrow.Location = New System.Drawing.Point(327, 24)
        Me.btn_Item_arrow.Name = "btn_Item_arrow"
        Me.btn_Item_arrow.Size = New System.Drawing.Size(17, 18)
        Me.btn_Item_arrow.TabIndex = 116
        Me.btn_Item_arrow.UseVisualStyleBackColor = False
        '
        'dgv_moduleFInd
        '
        Me.dgv_moduleFInd.AllowUserToAddRows = False
        Me.dgv_moduleFInd.AllowUserToDeleteRows = False
        Me.dgv_moduleFInd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_moduleFInd.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgv_moduleFInd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_moduleFInd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_moduleFInd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_moduleFInd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_moduleFInd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgv_moduleFInd.EnableHeadersVisualStyles = False
        Me.dgv_moduleFInd.Location = New System.Drawing.Point(-1, 45)
        Me.dgv_moduleFInd.Name = "dgv_moduleFInd"
        Me.dgv_moduleFInd.ReadOnly = True
        Me.dgv_moduleFInd.RowHeadersVisible = False
        Me.dgv_moduleFInd.RowTemplate.Height = 24
        Me.dgv_moduleFInd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_moduleFInd.Size = New System.Drawing.Size(364, 302)
        Me.dgv_moduleFInd.TabIndex = 115
        Me.dgv_moduleFInd.Visible = False
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
        'txt_search
        '
        Me.txt_search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search.Location = New System.Drawing.Point(4, 23)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(342, 20)
        Me.txt_search.TabIndex = 89
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(353, 20)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Main Menu"
        '
        'tvNode
        '
        Me.tvNode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tvNode.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.tvNode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvNode.ForeColor = System.Drawing.Color.Black
        Me.tvNode.FullRowSelect = True
        Me.tvNode.HideSelection = False
        Me.tvNode.ImageIndex = 0
        Me.tvNode.ImageList = Me.imglist_tv_indicator
        Me.tvNode.ItemHeight = 20
        Me.tvNode.Location = New System.Drawing.Point(0, 49)
        Me.tvNode.Name = "tvNode"
        Me.tvNode.PathSeparator = "-"
        Me.tvNode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tvNode.SelectedImageIndex = 0
        Me.tvNode.ShowLines = False
        Me.tvNode.ShowPlusMinus = False
        Me.tvNode.ShowRootLines = False
        Me.tvNode.Size = New System.Drawing.Size(346, 646)
        Me.tvNode.TabIndex = 1
        '
        'imglist_tv_indicator
        '
        Me.imglist_tv_indicator.ImageStream = CType(resources.GetObject("imglist_tv_indicator.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglist_tv_indicator.TransparentColor = System.Drawing.Color.Transparent
        Me.imglist_tv_indicator.Images.SetKeyName(0, "icons8-folder-96.png")
        Me.imglist_tv_indicator.Images.SetKeyName(1, "doc.png")
        '
        'MainTab
        '
        Me.MainTab.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.MainTab.Controls.Add(Me.MetroTabPage1)
        Me.MainTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTab.ItemSize = New System.Drawing.Size(54, 20)
        Me.MainTab.Location = New System.Drawing.Point(0, 0)
        Me.MainTab.Name = "MainTab"
        Me.MainTab.Padding = New System.Drawing.Point(6, 8)
        Me.MainTab.SelectedIndex = 0
        Me.MainTab.Size = New System.Drawing.Size(1054, 694)
        Me.MainTab.Style = MetroFramework.MetroColorStyle.Silver
        Me.MainTab.TabIndex = 4
        Me.MainTab.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.txt_moDuleFind)
        Me.MetroTabPage1.Controls.Add(Me.WebBrowser1)
        Me.MetroTabPage1.Enabled = True
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 24)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(1046, 666)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "  HOME"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        Me.MetroTabPage1.Visible = True
        '
        'txt_moDuleFind
        '
        Me.txt_moDuleFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txt_moDuleFind.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_moDuleFind.Image = CType(resources.GetObject("txt_moDuleFind.Image"), System.Drawing.Image)
        Me.txt_moDuleFind.Location = New System.Drawing.Point(0, 0)
        Me.txt_moDuleFind.Name = "txt_moDuleFind"
        Me.txt_moDuleFind.Size = New System.Drawing.Size(1046, 666)
        Me.txt_moDuleFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.txt_moDuleFind.TabIndex = 2
        Me.txt_moDuleFind.TabStop = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(589, 540)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(355, 126)
        Me.WebBrowser1.TabIndex = 89
        '
        'mainPanel
        '
        Me.mainPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.mainPanel.Location = New System.Drawing.Point(247, -19)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(222, 16)
        Me.mainPanel.TabIndex = 2
        '
        'Panel_notif
        '
        Me.Panel_notif.AccessibleDescription = "Panel_notif"
        Me.Panel_notif.Controls.Add(Me.lbl_notif)
        Me.Panel_notif.Controls.Add(Me.PictureBox1)
        Me.Panel_notif.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_notif.Location = New System.Drawing.Point(0, 745)
        Me.Panel_notif.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_notif.Name = "Panel_notif"
        Me.Panel_notif.Size = New System.Drawing.Size(1412, 21)
        Me.Panel_notif.TabIndex = 3
        '
        'lbl_notif
        '
        Me.lbl_notif.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_notif.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_notif.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_notif.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_notif.Location = New System.Drawing.Point(1, 1)
        Me.lbl_notif.Name = "lbl_notif"
        Me.lbl_notif.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.lbl_notif.Size = New System.Drawing.Size(1410, 20)
        Me.lbl_notif.TabIndex = 89
        Me.lbl_notif.Text = "Main Menu"
        Me.lbl_notif.Visible = False
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
        'imgList_
        '
        Me.imgList_.ImageStream = CType(resources.GetObject("imgList_.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList_.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList_.Images.SetKeyName(0, "I.png")
        Me.imgList_.Images.SetKeyName(1, "X.png")
        Me.imgList_.Images.SetKeyName(2, "Y.png")
        '
        'notif_time
        '
        Me.notif_time.Interval = 500
        '
        'menuIcons
        '
        Me.menuIcons.ImageStream = CType(resources.GetObject("menuIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.menuIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.menuIcons.Images.SetKeyName(0, "A.png")
        Me.menuIcons.Images.SetKeyName(1, "B.png")
        Me.menuIcons.Images.SetKeyName(2, "C.png")
        Me.menuIcons.Images.SetKeyName(3, "D.png")
        Me.menuIcons.Images.SetKeyName(4, "E.png")
        Me.menuIcons.Images.SetKeyName(5, "F.png")
        Me.menuIcons.Images.SetKeyName(6, "G.png")
        Me.menuIcons.Images.SetKeyName(7, "H.png")
        Me.menuIcons.Images.SetKeyName(8, "I.png")
        Me.menuIcons.Images.SetKeyName(9, "J.png")
        Me.menuIcons.Images.SetKeyName(10, "K.png")
        Me.menuIcons.Images.SetKeyName(11, "L.png")
        Me.menuIcons.Images.SetKeyName(12, "M.png")
        Me.menuIcons.Images.SetKeyName(13, "N.png")
        Me.menuIcons.Images.SetKeyName(14, "0.png")
        '
        'menuIconsMono
        '
        Me.menuIconsMono.ImageStream = CType(resources.GetObject("menuIconsMono.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.menuIconsMono.TransparentColor = System.Drawing.Color.Transparent
        Me.menuIconsMono.Images.SetKeyName(0, "A1.png")
        Me.menuIconsMono.Images.SetKeyName(1, "B1.png")
        Me.menuIconsMono.Images.SetKeyName(2, "C1.png")
        Me.menuIconsMono.Images.SetKeyName(3, "D1.png")
        Me.menuIconsMono.Images.SetKeyName(4, "E1.png")
        Me.menuIconsMono.Images.SetKeyName(5, "F1.png")
        Me.menuIconsMono.Images.SetKeyName(6, "G1.png")
        Me.menuIconsMono.Images.SetKeyName(7, "H1.png")
        Me.menuIconsMono.Images.SetKeyName(8, "I1.png")
        Me.menuIconsMono.Images.SetKeyName(9, "J1.png")
        Me.menuIconsMono.Images.SetKeyName(10, "K1.png")
        Me.menuIconsMono.Images.SetKeyName(11, "L1.png")
        Me.menuIconsMono.Images.SetKeyName(12, "M1.png")
        Me.menuIconsMono.Images.SetKeyName(13, "N1.png")
        Me.menuIconsMono.Images.SetKeyName(14, "O1.png")
        '
        'CMS_Triger
        '
        Me.CMS_Triger.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CMS_Triger.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMS_ADD, Me.CMD_FIND, Me.CMS_RIGHT_MAX, Me.CMS_RIGHT, Me.CMS_LEFT, Me.CMS_LEFT_RIGHT, Me.CMS_REFRESH, Me.CMD_PROFILE})
        Me.CMS_Triger.Name = "CMS_Triger"
        Me.CMS_Triger.Size = New System.Drawing.Size(134, 180)
        '
        'CMS_ADD
        '
        Me.CMS_ADD.Name = "CMS_ADD"
        Me.CMS_ADD.Size = New System.Drawing.Size(133, 22)
        Me.CMS_ADD.Text = "&ADD"
        '
        'CMD_FIND
        '
        Me.CMD_FIND.Name = "CMD_FIND"
        Me.CMD_FIND.Size = New System.Drawing.Size(133, 22)
        Me.CMD_FIND.Text = "&FIND"
        '
        'CMS_RIGHT_MAX
        '
        Me.CMS_RIGHT_MAX.Name = "CMS_RIGHT_MAX"
        Me.CMS_RIGHT_MAX.Size = New System.Drawing.Size(133, 22)
        Me.CMS_RIGHT_MAX.Text = "RIGHTMAX"
        '
        'CMS_RIGHT
        '
        Me.CMS_RIGHT.Name = "CMS_RIGHT"
        Me.CMS_RIGHT.Size = New System.Drawing.Size(133, 22)
        Me.CMS_RIGHT.Text = "RIGHT"
        '
        'CMS_LEFT
        '
        Me.CMS_LEFT.Name = "CMS_LEFT"
        Me.CMS_LEFT.Size = New System.Drawing.Size(133, 22)
        Me.CMS_LEFT.Text = "LEFT"
        '
        'CMS_LEFT_RIGHT
        '
        Me.CMS_LEFT_RIGHT.Name = "CMS_LEFT_RIGHT"
        Me.CMS_LEFT_RIGHT.Size = New System.Drawing.Size(133, 22)
        Me.CMS_LEFT_RIGHT.Text = "LEFTMAX"
        '
        'CMS_REFRESH
        '
        Me.CMS_REFRESH.Name = "CMS_REFRESH"
        Me.CMS_REFRESH.Size = New System.Drawing.Size(133, 22)
        Me.CMS_REFRESH.Text = "REFRESH"
        '
        'CMD_PROFILE
        '
        Me.CMD_PROFILE.Name = "CMD_PROFILE"
        Me.CMD_PROFILE.Size = New System.Drawing.Size(133, 22)
        Me.CMD_PROFILE.Text = "PROFILE"
        '
        'MS_menu
        '
        Me.MS_menu.Dock = System.Windows.Forms.DockStyle.None
        Me.MS_menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MS_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MS_ADD, Me.MS_FIND, Me.MS_LEFT_MAX, Me.MS_LEFT, Me.MS_RIGHT, Me.MS__RIGHTMAX, Me.MS_REFRESH, Me.MS_PROFILE, Me.MS_EXPAND})
        Me.MS_menu.Location = New System.Drawing.Point(625, 9)
        Me.MS_menu.Name = "MS_menu"
        Me.MS_menu.Size = New System.Drawing.Size(533, 24)
        Me.MS_menu.TabIndex = 103
        Me.MS_menu.Text = "Menu"
        '
        'MS_ADD
        '
        Me.MS_ADD.Name = "MS_ADD"
        Me.MS_ADD.Size = New System.Drawing.Size(43, 20)
        Me.MS_ADD.Text = "&ADD"
        '
        'MS_FIND
        '
        Me.MS_FIND.Name = "MS_FIND"
        Me.MS_FIND.Size = New System.Drawing.Size(45, 20)
        Me.MS_FIND.Text = "&FIND"
        '
        'MS_LEFT_MAX
        '
        Me.MS_LEFT_MAX.Name = "MS_LEFT_MAX"
        Me.MS_LEFT_MAX.Size = New System.Drawing.Size(72, 20)
        Me.MS_LEFT_MAX.Text = "LEFT MAX"
        '
        'MS_LEFT
        '
        Me.MS_LEFT.Name = "MS_LEFT"
        Me.MS_LEFT.Size = New System.Drawing.Size(43, 20)
        Me.MS_LEFT.Text = "LEFT"
        '
        'MS_RIGHT
        '
        Me.MS_RIGHT.Name = "MS_RIGHT"
        Me.MS_RIGHT.Size = New System.Drawing.Size(52, 20)
        Me.MS_RIGHT.Text = "RIGHT"
        '
        'MS__RIGHTMAX
        '
        Me.MS__RIGHTMAX.Name = "MS__RIGHTMAX"
        Me.MS__RIGHTMAX.Size = New System.Drawing.Size(78, 20)
        Me.MS__RIGHTMAX.Text = "RIGHTMAX"
        '
        'MS_REFRESH
        '
        Me.MS_REFRESH.Name = "MS_REFRESH"
        Me.MS_REFRESH.Size = New System.Drawing.Size(66, 20)
        Me.MS_REFRESH.Text = "&REFRESH"
        '
        'MS_PROFILE
        '
        Me.MS_PROFILE.Name = "MS_PROFILE"
        Me.MS_PROFILE.Size = New System.Drawing.Size(63, 20)
        Me.MS_PROFILE.Text = "PROFILE"
        '
        'MS_EXPAND
        '
        Me.MS_EXPAND.Name = "MS_EXPAND"
        Me.MS_EXPAND.Size = New System.Drawing.Size(63, 20)
        Me.MS_EXPAND.Text = "&EXPAND"
        '
        'lbl_profile1
        '
        Me.lbl_profile1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_profile1.AutoSize = True
        Me.lbl_profile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lbl_profile1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_profile1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_profile1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_profile1.Location = New System.Drawing.Point(1058, 4)
        Me.lbl_profile1.Name = "lbl_profile1"
        Me.lbl_profile1.Size = New System.Drawing.Size(0, 17)
        Me.lbl_profile1.TabIndex = 104
        Me.lbl_profile1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_profile2
        '
        Me.lbl_profile2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_profile2.AutoSize = True
        Me.lbl_profile2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lbl_profile2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_profile2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_profile2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_profile2.Location = New System.Drawing.Point(1238, 18)
        Me.lbl_profile2.Name = "lbl_profile2"
        Me.lbl_profile2.Size = New System.Drawing.Size(0, 17)
        Me.lbl_profile2.TabIndex = 104
        Me.lbl_profile2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_load_bar
        '
        Me.lbl_load_bar.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_load_bar.Location = New System.Drawing.Point(0, -7)
        Me.lbl_load_bar.Name = "lbl_load_bar"
        Me.lbl_load_bar.Size = New System.Drawing.Size(57, 10)
        Me.lbl_load_bar.TabIndex = 106
        Me.lbl_load_bar.Visible = False
        '
        'btn_maxMin
        '
        Me.btn_maxMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_maxMin.BackColor = System.Drawing.Color.Transparent
        Me.btn_maxMin.BackgroundImage = Global.IpicIndirect.My.Resources.Resources.maximize
        Me.btn_maxMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_maxMin.FlatAppearance.BorderSize = 0
        Me.btn_maxMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_maxMin.Location = New System.Drawing.Point(1385, 48)
        Me.btn_maxMin.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btn_maxMin.Name = "btn_maxMin"
        Me.btn_maxMin.Size = New System.Drawing.Size(23, 18)
        Me.btn_maxMin.TabIndex = 105
        Me.btn_maxMin.Tag = "0"
        Me.btn_maxMin.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_maxMin.UseVisualStyleBackColor = False
        '
        'btn_menu_add
        '
        Me.btn_menu_add.BackColor = System.Drawing.Color.Transparent
        Me.btn_menu_add.BackgroundImage = Global.IpicIndirect.My.Resources.Resources.Add
        Me.btn_menu_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_add.FlatAppearance.BorderSize = 0
        Me.btn_menu_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_add.Location = New System.Drawing.Point(9, 0)
        Me.btn_menu_add.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btn_menu_add.Name = "btn_menu_add"
        Me.btn_menu_add.Size = New System.Drawing.Size(30, 43)
        Me.btn_menu_add.TabIndex = 94
        Me.btn_menu_add.Tag = "7"
        Me.btn_menu_add.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_menu_add.UseVisualStyleBackColor = False
        '
        'btn_menu_find
        '
        Me.btn_menu_find.BackColor = System.Drawing.Color.Transparent
        Me.btn_menu_find.BackgroundImage = Global.IpicIndirect.My.Resources.Resources.find
        Me.btn_menu_find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_find.FlatAppearance.BorderSize = 0
        Me.btn_menu_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_find.Location = New System.Drawing.Point(40, 0)
        Me.btn_menu_find.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btn_menu_find.Name = "btn_menu_find"
        Me.btn_menu_find.Size = New System.Drawing.Size(30, 43)
        Me.btn_menu_find.TabIndex = 95
        Me.btn_menu_find.Tag = "6"
        Me.btn_menu_find.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_menu_find.UseVisualStyleBackColor = False
        '
        'btn_menu_RightMax
        '
        Me.btn_menu_RightMax.BackColor = System.Drawing.Color.Transparent
        Me.btn_menu_RightMax.BackgroundImage = Global.IpicIndirect.My.Resources.Resources.left_max
        Me.btn_menu_RightMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_RightMax.FlatAppearance.BorderSize = 0
        Me.btn_menu_RightMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_RightMax.Location = New System.Drawing.Point(71, 0)
        Me.btn_menu_RightMax.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btn_menu_RightMax.Name = "btn_menu_RightMax"
        Me.btn_menu_RightMax.Size = New System.Drawing.Size(30, 43)
        Me.btn_menu_RightMax.TabIndex = 96
        Me.btn_menu_RightMax.Tag = "8"
        Me.btn_menu_RightMax.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_menu_RightMax.UseVisualStyleBackColor = False
        '
        'btn_menu_Right
        '
        Me.btn_menu_Right.BackColor = System.Drawing.Color.Transparent
        Me.btn_menu_Right.BackgroundImage = Global.IpicIndirect.My.Resources.Resources.left
        Me.btn_menu_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_Right.FlatAppearance.BorderSize = 0
        Me.btn_menu_Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_Right.Location = New System.Drawing.Point(102, 0)
        Me.btn_menu_Right.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btn_menu_Right.Name = "btn_menu_Right"
        Me.btn_menu_Right.Size = New System.Drawing.Size(30, 43)
        Me.btn_menu_Right.TabIndex = 97
        Me.btn_menu_Right.Tag = "9"
        Me.btn_menu_Right.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_menu_Right.UseVisualStyleBackColor = False
        '
        'btn_menu_Left
        '
        Me.btn_menu_Left.BackColor = System.Drawing.Color.Transparent
        Me.btn_menu_Left.BackgroundImage = Global.IpicIndirect.My.Resources.Resources.right
        Me.btn_menu_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_Left.FlatAppearance.BorderSize = 0
        Me.btn_menu_Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_Left.Location = New System.Drawing.Point(133, 0)
        Me.btn_menu_Left.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btn_menu_Left.Name = "btn_menu_Left"
        Me.btn_menu_Left.Size = New System.Drawing.Size(30, 43)
        Me.btn_menu_Left.TabIndex = 98
        Me.btn_menu_Left.Tag = "10"
        Me.btn_menu_Left.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_menu_Left.UseVisualStyleBackColor = False
        '
        'btn_menu_LeftMax
        '
        Me.btn_menu_LeftMax.BackColor = System.Drawing.Color.Transparent
        Me.btn_menu_LeftMax.BackgroundImage = Global.IpicIndirect.My.Resources.Resources.RightMax
        Me.btn_menu_LeftMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_LeftMax.FlatAppearance.BorderSize = 0
        Me.btn_menu_LeftMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_LeftMax.Location = New System.Drawing.Point(164, 0)
        Me.btn_menu_LeftMax.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btn_menu_LeftMax.Name = "btn_menu_LeftMax"
        Me.btn_menu_LeftMax.Size = New System.Drawing.Size(30, 43)
        Me.btn_menu_LeftMax.TabIndex = 99
        Me.btn_menu_LeftMax.Tag = "11"
        Me.btn_menu_LeftMax.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_menu_LeftMax.UseVisualStyleBackColor = False
        '
        'btn_menu_Refresh
        '
        Me.btn_menu_Refresh.BackColor = System.Drawing.Color.Transparent
        Me.btn_menu_Refresh.BackgroundImage = Global.IpicIndirect.My.Resources.Resources.ReFresh
        Me.btn_menu_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_Refresh.FlatAppearance.BorderSize = 0
        Me.btn_menu_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_Refresh.Location = New System.Drawing.Point(195, 0)
        Me.btn_menu_Refresh.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btn_menu_Refresh.Name = "btn_menu_Refresh"
        Me.btn_menu_Refresh.Size = New System.Drawing.Size(30, 43)
        Me.btn_menu_Refresh.TabIndex = 100
        Me.btn_menu_Refresh.Tag = "12"
        Me.btn_menu_Refresh.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_menu_Refresh.UseVisualStyleBackColor = False
        '
        'btn_menu_Profile
        '
        Me.btn_menu_Profile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_menu_Profile.BackColor = System.Drawing.Color.Transparent
        Me.btn_menu_Profile.BackgroundImage = Global.IpicIndirect.My.Resources.Resources.Profile
        Me.btn_menu_Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_menu_Profile.FlatAppearance.BorderSize = 0
        Me.btn_menu_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu_Profile.Location = New System.Drawing.Point(1373, 1)
        Me.btn_menu_Profile.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btn_menu_Profile.Name = "btn_menu_Profile"
        Me.btn_menu_Profile.Size = New System.Drawing.Size(30, 43)
        Me.btn_menu_Profile.TabIndex = 101
        Me.btn_menu_Profile.Tag = "13"
        Me.btn_menu_Profile.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_menu_Profile.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1412, 766)
        Me.Controls.Add(Me.lbl_load_bar)
        Me.Controls.Add(Me.btn_maxMin)
        Me.Controls.Add(Me.btn_menu_add)
        Me.Controls.Add(Me.btn_menu_find)
        Me.Controls.Add(Me.btn_menu_RightMax)
        Me.Controls.Add(Me.lbl_profile2)
        Me.Controls.Add(Me.btn_menu_Right)
        Me.Controls.Add(Me.lbl_profile1)
        Me.Controls.Add(Me.btn_menu_Left)
        Me.Controls.Add(Me.btn_menu_LeftMax)
        Me.Controls.Add(Me.MS_menu)
        Me.Controls.Add(Me.btn_menu_Refresh)
        Me.Controls.Add(Me.btn_menu_Profile)
        Me.Controls.Add(Me.Panel_notif)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.SplitCon)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1428, 397)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu :"
        Me.SplitCon.Panel1.ResumeLayout(False)
        Me.SplitCon.Panel1.PerformLayout()
        Me.SplitCon.Panel2.ResumeLayout(False)
        CType(Me.SplitCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitCon.ResumeLayout(False)
        CType(Me.dgv_moduleFInd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainTab.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        CType(Me.txt_moDuleFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_notif.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMS_Triger.ResumeLayout(False)
        Me.MS_menu.ResumeLayout(False)
        Me.MS_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplitCon As SplitContainer
    Friend WithEvents tvNode As TreeView
    Friend WithEvents Panel_notif As Panel
    Public WithEvents mainPanel As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents imgList_ As ImageList
    Friend WithEvents btn_menu_add As Button
    Friend WithEvents lbl_notif As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_moDuleFind As PictureBox
    Friend WithEvents NotifTime As Timer
    Friend WithEvents notif_time As Timer
    Friend WithEvents btn_menu_find As Button
    Friend WithEvents btn_menu_Right As Button
    Friend WithEvents btn_menu_RightMax As Button
    Friend WithEvents btn_menu_LeftMax As Button
    Friend WithEvents btn_menu_Left As Button
    Friend WithEvents btn_menu_Refresh As Button
    Friend WithEvents btn_menu_Profile As Button
    Friend WithEvents menuIcons As ImageList
    Friend WithEvents menuIconsMono As ImageList
    Friend WithEvents CMS_Triger As ContextMenuStrip
    Friend WithEvents CMS_ADD As ToolStripMenuItem
    Friend WithEvents CMD_FIND As ToolStripMenuItem
    Friend WithEvents CMS_RIGHT_MAX As ToolStripMenuItem
    Friend WithEvents CMS_RIGHT As ToolStripMenuItem
    Friend WithEvents CMS_LEFT As ToolStripMenuItem
    Friend WithEvents CMS_LEFT_RIGHT As ToolStripMenuItem
    Friend WithEvents CMS_REFRESH As ToolStripMenuItem
    Friend WithEvents CMD_PROFILE As ToolStripMenuItem
    Friend WithEvents MS_menu As MenuStrip
    Friend WithEvents MS_ADD As ToolStripMenuItem
    Friend WithEvents MS_FIND As ToolStripMenuItem
    Friend WithEvents MS_LEFT_MAX As ToolStripMenuItem
    Friend WithEvents MS_LEFT As ToolStripMenuItem
    Friend WithEvents MS_RIGHT As ToolStripMenuItem
    Friend WithEvents MS__RIGHTMAX As ToolStripMenuItem
    Friend WithEvents MS_REFRESH As ToolStripMenuItem
    Friend WithEvents MS_PROFILE As ToolStripMenuItem
    Public WithEvents imglist_tv_indicator As ImageList
    Friend WithEvents MS_EXPAND As ToolStripMenuItem
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents txt_search As TextBox
    Friend WithEvents dgv_moduleFInd As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents btn_Item_arrow As Button
    Friend WithEvents lbl_profile1 As Label
    Friend WithEvents lbl_profile2 As Label
    Friend WithEvents btn_maxMin As Button
    Public WithEvents lbl_load_bar As Label
    Private WithEvents MainTab As MetroFramework.Controls.MetroTabControl
    Private WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
End Class
