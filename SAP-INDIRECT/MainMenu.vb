Imports System.ComponentModel
Imports MetroFramework.Controls
Imports IpicIndirect
Imports IpicIndirect.hotkey

Public Class MainMenu
    Dim notifTimex As Integer
    Dim notifTimex_Count As Integer
    Public opend_FormList_Counter As Integer
    Public opend_FormList As List(Of Form)
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)
    End Sub
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        G_lbl_profile1 = lbl_profile1
        G_lbl_profile2 = lbl_profile2
        mainPanel.BringToFront()
        MS_menu.Top = -50
        g_iBtn_Menu_disable()

        g_MainPanel = mainPanel
        g_splitPanel = SplitCon
        g_tv = tvNode
        LogInMenu()
        WebBrowser1.Visible = True
        txt_moDuleFind.BringToFront()
        ' WebBrowser1.Navigate("file://10.10.0.7/ipic_di/Dashboard/gentelella-master/production/indexOLD.html?v=1|1|2|3|4|&s=11|231|xxas|3231")
        '  CMS_Triger.Visible = True


        dgv_moduleFInd.ColumnHeadersVisible = False
        dgv_moduleFInd.Visible = False
        iSearchSetUp()
        ' btn_maxMin.Left = (Me.Width) - (btn_maxMin.Width + 15)
        SplitCon.Height = Panel_notif.Top - SplitCon.Top

        ''picture extn
        ExtnImage.Add("PNG")
        ExtnImage.Add("JPG")
        ''MS extn
        ExtnDocs.Add("XLSX")
        ExtnDocs.Add("XLS")
        ExtnDocs.Add("DOC")
        ExtnDocs.Add("DOCX")

    End Sub
    Private Sub mainPanel_Paint(sender As Object, e As PaintEventArgs)
    End Sub
    Sub LogInMenu()
        SplitCon.Enabled = False
        mainPanel.Visible = True
        mainPanel.Dock = DockStyle.Fill
        Dim xiLogin As New iLogin
        xiLogin.TopLevel = False
        xiLogin.TopMost = True
        mainPanel.Controls.Add(xiLogin)
        xiLogin.Top = (mainPanel.Height / 2) - (xiLogin.Height / 2)
        xiLogin.Left = (mainPanel.Width / 2) - (xiLogin.Width / 2)
        g_form = xiLogin
        xiLogin.Show()
        If btn_maxMin.Tag = 0 Then SplitCon.SplitterDistance = G_split_panel_left_size
        iSearchSetUp()
    End Sub
    Private Sub MainMenu_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If btn_maxMin.Tag = 0 Then
            SplitCon.SplitterDistance = G_split_panel_left_size
            '   btn_maxMin.Left = Me.Width - (btn_maxMin.Width + 1)
        End If
        iSearchSetUp()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub AddTabWthForm(ByVal iNameSpace As String, ByVal ModuleName As String, iMetroTab As MetroTabControl, WithCloseButton As Boolean)
        Dim iMainNewTab As New TabPage


        Dim iForm As Form = Nothing
        Dim frmNewForm_Type As Type = Type.GetType(iNameSpace)
        iForm = CType(Activator.CreateInstance(frmNewForm_Type), Form)



        iForm.TopLevel = False
        iForm.TopMost = True
        iForm.Tag = opend_FormList_Counter
        With iMainNewTab

            If WithCloseButton Then .Text = "    " & ModuleName & "    X"
            If WithCloseButton = False Then .Text = "" & ModuleName & ""
            .Controls.Add(iForm)
            .Tag = opend_FormList_Counter

        End With
        ''  opend_FormList.Add(iForm)

        iMetroTab.TabPages.Add(iMainNewTab)
        iForm.Show()
        iForm.Dock = DockStyle.Fill
        iMetroTab.SelectedTab = iMainNewTab
        opend_FormList_Counter = opend_FormList_Counter + 1
    End Sub
    Private Sub tvNode_DoubleClick(sender As Object, e As EventArgs) Handles tvNode.DoubleClick
        If SYSTEM_MODE = "EDS" Then
            Dim iTagSplit() As String
            If tvNode.SelectedNode.Tag IsNot Nothing Then
                Dim iSPlitTag = Split(tvNode.SelectedNode.Tag, "|")
                If iSPlitTag(1) = "M" Then
                    If iSPlitTag(3) = "Y" Then
                        iTagSplit = tvNode.SelectedNode.Tag.ToString.Split("|")
                        Dim iTagSplit2() = Split(iTagSplit(0), ".")
                        AddTabWthForm(iSPlitTag(0), tvNode.SelectedNode.Text, MainTab, True)
                        TrigerMode()
                    Else
                        g_notif_panel(0, "404 - Access Denied", 2)
                End If
            End If
            End If
        ElseIf SYSTEM_MODE = "SAP" Then
            Try
                Dim iTagSplit() As String
                If tvNode.SelectedNode.Tag IsNot Nothing Then
                    Dim iSPlitTag = Split(tvNode.SelectedNode.Tag, "|")
                    If iSPlitTag(4) = "Y" Then
                        iTagSplit = tvNode.SelectedNode.Tag.ToString.Split("|")
                        AddTabWthForm(iTagSplit(0), iTagSplit(1), MainTab, True)
                    Else
                        g_notif_panel(0, "404 - Access Denied", 2)
                    End If
                End If
            Catch ex As Exception
                g_notif_panel(0, ex.ToString, 1)
            End Try
        End If
    End Sub
    Private Sub MainMenu_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If btn_maxMin.Tag = 0 Then SplitCon.SplitterDistance = G_split_panel_left_size
        iSearchSetUp()
    End Sub
    Private Sub MainMenu_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        btn_maxMin.Left = (Me.Width) - (btn_maxMin.Width + 15)
    End Sub
    ''' <summary>
    ''' Notification_type
    ''' 0 =  Error 
    ''' 1 =  Success
    ''' 2 =  Warning
    ''' Notification_time
    ''' 1 = short
    ''' 2 = long
    ''' </summary>
    Public Sub g_notif_panel(ByVal Notification_type As Integer, ByRef Notification_msg As String, ByVal Notification_time As Integer)
        notifTimex_Count = 0
        G_iHAVE_ERROR_IN_TRANSACTION = True
        Dim iColor As Color
        If Notification_type = 0 Then iColor = g_colors.Red_Alizarin
        If Notification_type = 1 Then iColor = g_colors.Green_nephritis
        If Notification_type = 2 Then iColor = g_colors.Orange_AgentOrange
        Notification_msg.Replace("vbCrLf ", " ")
        With lbl_notif
            .Text = Notification_msg
            .BackColor = iColor
            .Visible = True
        End With
        notif_time.Enabled = True
        If Notification_time = 1 Then notifTimex = 5
        If Notification_time = 2 Then notifTimex = 10

       ' My.Computer.Clipboard.SetText(Notification_msg)
    End Sub
    Private Sub notif_time_Tick(sender As Object, e As EventArgs) Handles notif_time.Tick
        If (notifTimex_Count < notifTimex) = True Then
            notifTimex_Count = notifTimex_Count + 1
        Else
            lbl_notif.Visible = False
            lbl_notif.Text = ""
            notif_time.Enabled = False
            notifTimex_Count = 0
        End If
    End Sub

    Private Sub btn_refreash_Click(sender As Object, e As EventArgs)
        dmf_ModuleGenerator.Show()
    End Sub
    Private Sub btn_frwd_Click(sender As Object, e As EventArgs)
        dmf_NodeCreator.Show()
    End Sub
    Private Sub btn_menu_find_Click(sender As Object, e As EventArgs) Handles btn_menu_find.Click

        Try



            Dim iChild As Form = Nothing
            Dim myForms As FormCollection = Application.OpenForms
            For Each iFOrms As Form In myForms
                If MainTab.SelectedTab.Tag = iFOrms.Tag Then iChild = iFOrms
            Next
            Dim t As Type = iChild.GetType()
            ' iChild.GetType().GetMethod("AddMode")
            g_notif_panel(2, "FIND MODE", 2)
            CallByName(iChild, "FindMode", vbMethod)



            MenuIcons_IsActive(btn_menu_find, False)
            '  MenuIcons_IsActive(btn_menu_add, True)

        Catch
        End Try
    End Sub
    Private Sub btn_bback_Click(sender As Object, e As EventArgs) Handles btn_menu_add.Click
        Try
            Dim iChild As Form = Nothing
            Dim myForms As FormCollection = Application.OpenForms
            For Each iFOrms As Form In myForms
                If MainTab.SelectedTab.Tag = iFOrms.Tag Then iChild = iFOrms
            Next
            Dim t As Type = iChild.GetType()
            ' iChild.GetType().GetMethod("AddMode")
            g_notif_panel(2, "ADD MODE", 2)

            CallByName(iChild, "AddMode", vbMethod)
            MenuIcons_IsActive(btn_menu_add, False)
            ' MenuIcons_IsActive(btn_menu_find, True)

        Catch
        End Try
    End Sub
    Public Shared Function FindControlRecursive(ByVal list As List(Of Control), ByVal parent As Control, ByVal ctrlType As System.Type) As List(Of Control)
        If parent Is Nothing Then Return list
        If parent.GetType Is ctrlType Then
            list.Add(parent)
        End If
        For Each child As Control In parent.Controls
            FindControlRecursive(list, child, ctrlType)
        Next
        Return list
    End Function
    Public Shared Function FindControlRecursive2(ByVal list As List(Of Control), ByVal parent As Control) As List(Of Control)

        For Each child As Control In parent.Controls
            list.Add(parent)
        Next
        Return list
    End Function
    Public Sub MenuIcons_IsActive(ByRef btn As Button, ByVal isActive As Boolean)
        If isActive Then
            btn.BackgroundImage = menuIcons.Images((CInt(btn.Tag)))
        Else
            btn.BackgroundImage = menuIconsMono.Images((CInt(btn.Tag)))
        End If
        btn.Enabled = isActive

    End Sub
    Private Sub MS_ADD_Click(sender As Object, e As EventArgs) Handles MS_ADD.Click
        If btn_menu_add.Enabled Then btn_menu_add.PerformClick()
    End Sub
    Private Sub MS_FIND_Click(sender As Object, e As EventArgs) Handles MS_FIND.Click
        If btn_menu_find.Enabled Then btn_menu_find.PerformClick()
    End Sub
    Private Sub MS_REFRESH_Click(sender As Object, e As EventArgs) Handles MS_REFRESH.Click
        If btn_menu_Refresh.Enabled Then btn_menu_Refresh.PerformClick()
    End Sub

    Private Sub MS_EXPAND_Click(sender As Object, e As EventArgs) Handles MS_EXPAND.Click
        tvNode.ExpandAll()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        oDisconnect()
    End Sub
    Public Sub g_iBtn_Menu_disable()
        MenuIcons_IsActive(btn_menu_add, False)
        MenuIcons_IsActive(btn_menu_find, False)
        MenuIcons_IsActive(btn_menu_Left, False)
        MenuIcons_IsActive(btn_menu_LeftMax, False)
        MenuIcons_IsActive(btn_menu_Profile, False)
        MenuIcons_IsActive(btn_menu_Refresh, False)
        MenuIcons_IsActive(btn_menu_Right, False)
        MenuIcons_IsActive(btn_menu_RightMax, False)
    End Sub

    Private Sub MainTab_MouseUp(sender As Object, e As MouseEventArgs) Handles MainTab.MouseUp
        Dim rect As Rectangle
        rect = MainTab.GetTabRect(MainTab.SelectedIndex)
        If rect.Contains(e.Location) Then
            Dim x1 As Integer = (rect.Width + rect.Location.X) - 3
            Dim x2 As Integer = (rect.Width + rect.Location.X) - 22
            If e.Location.X > x2 And e.Location.X < x1 Then
                If MainTab.SelectedIndex <> 0 Then
                    MainTab.TabPages.RemoveAt(MainTab.SelectedIndex)
                    g_iBtn_Menu_disable()
                End If
            End If
        End If
        TrigerMode()

    End Sub

    Sub TrigerMode()
        Try
            Dim iChild As Form = Nothing
            Dim myForms As FormCollection = Application.OpenForms
            For Each iFOrms As Form In myForms
                If MainTab.SelectedTab.Tag = iFOrms.Tag Then iChild = iFOrms
            Next
            Dim t As Type = iChild.GetType()
            ' iChild.GetType().GetMethod("AddMode")

            CallByName(iChild, "TrigerMode", vbMethod)

        Catch ex As Exception

        End Try
    End Sub



    Private Sub btn_Item_arrow_Click(sender As Object, e As EventArgs) Handles btn_Item_arrow.Click
        If txt_search.Text <> "" Then
            dgv_moduleFInd.Visible = True
            dgv_moduleFInd.Rows.Clear()
            dgv_moduleFInd.Columns.Clear()
            G_iSQL_PARAMETERS.Clear()
            G_iSQL_PARAMETERS.Add(g_userID)
            G_iSQL_PARAMETERS.Add(txt_search.Text)
            iSQL_selector(120, dgv_moduleFInd, True, 2)
            If dgv_moduleFInd.Rows.Count < 1 Then
                dgv_moduleFInd.Visible = False
            Else
                If btn_maxMin.Tag = 0 Then dgv_moduleFInd.Columns(0).Width = G_split_panel_left_size
                dgv_moduleFInd.Columns(1).Width = 0
                dgv_moduleFInd.Columns(2).Width = 0
                dgv_moduleFInd.Columns(3).Width = 0
            End If


        End If
    End Sub


    Private Sub dgv_moduleFInd_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_moduleFInd.CellClick
        Try
            '      If tvNode.SelectedNode.Tag IsNot Nothing Then
            '        Dim iSPlitTag = Split(tvNode.SelectedNode.Tag, "|")
            If dgv_moduleFInd.SelectedRows(0).Cells(3).Value = "1" Then

                AddTabWthForm(dgv_moduleFInd.SelectedRows(0).Cells(2).Value, dgv_moduleFInd.SelectedRows(0).Cells(0).Value, MainTab, True)
            Else
                g_notif_panel(0, "404 - Access Denied", 2)
            End If

            '     End If

            dgv_moduleFInd.Rows.Clear()
            dgv_moduleFInd.Columns.Clear()
            dgv_moduleFInd.Visible = False
            txt_search.Text = ""

        Catch ex As Exception
            g_notif_panel(0, ex.ToString, 1)

        End Try

    End Sub

    Public Sub iSearchSetUp()
        txt_search.Left = 3
        txt_search.Width = G_split_panel_left_size - 6
        btn_Item_arrow.Left = G_split_panel_left_size - (btn_Item_arrow.Width + 6)
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        btn_Item_arrow.PerformClick()
    End Sub

    Private Sub txt_search_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_search.KeyUp
        If e.KeyCode = 13 Then
            Try
                '      If tvNode.SelectedNode.Tag IsNot Nothing Then
                '        Dim iSPlitTag = Split(tvNode.SelectedNode.Tag, "|")
                If dgv_moduleFInd.Rows(0).Cells(3).Value = "1" Then

                    AddTabWthForm(dgv_moduleFInd.Rows(0).Cells(2).Value, dgv_moduleFInd.Rows(0).Cells(0).Value, MainTab, True)
                Else
                    g_notif_panel(0, "404 - Access Denied", 2)
                End If

                '     End If
            Catch ex As Exception
                g_notif_panel(0, ex.ToString, 1)

            End Try
            dgv_moduleFInd.Rows.Clear()
            dgv_moduleFInd.Columns.Clear()
            dgv_moduleFInd.Visible = False
        End If
    End Sub

    Private Sub dgv_moduleFInd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_moduleFInd.CellContentClick

    End Sub

    Public Sub iSetProfile()
        lbl_profile1.Left = btn_menu_Profile.Left - lbl_profile1.Width - 10
        lbl_profile2.Left = btn_menu_Profile.Left - lbl_profile2.Width - 10
    End Sub

    Private Sub btn_maxMin_Click(sender As Object, e As EventArgs) Handles btn_maxMin.Click
        If btn_maxMin.Tag = 1 Then
            SetMin()
        Else
            SetMax()
        End If

    End Sub

    Sub SetMax()
        btn_maxMin.BackgroundImage = My.Resources.restore
        btn_maxMin.Tag = 1
        SplitCon.SplitterDistance = 0
        '  SplitCon.Top = 0
        btn_maxMin.Top = SplitCon.Top + 1

        SplitCon.BringToFront()
        btn_maxMin.BringToFront()
        SplitCon.Height = Panel_notif.Top - SplitCon.Top
    End Sub
    Sub SetMin()
        btn_maxMin.BackgroundImage = My.Resources.maximize
        btn_maxMin.Tag = 0
        SplitCon.SplitterDistance = G_split_panel_left_size
        '   SplitCon.Top = 46
        btn_maxMin.Top = SplitCon.Top + 1
        btn_maxMin.SendToBack()
        SplitCon.SendToBack()
        SplitCon.Height = Panel_notif.Top - SplitCon.Top
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        'If IsNumeric(TextBox1.Text) Then
        '    iLoad_bar(CInt(TextBox1.Text))
        'End If
    End Sub

    Private Sub tvNode_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvNode.AfterSelect

    End Sub

    Private Sub SplitCon_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitCon.Panel2.Paint

    End Sub

    Private Sub txt_moDuleFind_Click(sender As Object, e As EventArgs) Handles txt_moDuleFind.Click

    End Sub

    Private Sub tvNode_DockChanged(sender As Object, e As EventArgs) Handles tvNode.DockChanged

    End Sub
End Class