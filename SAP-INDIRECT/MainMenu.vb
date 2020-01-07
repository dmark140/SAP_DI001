Imports System.ComponentModel
Imports MetroFramework.Controls

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class MainMenu
    Private Declare Function GetAsyncKeyState _
 Lib "user32" (ByVal vKey As Long) As Integer
    Public metroSpin As New MetroProgressSpinner

    Dim iloGtimer = 0
    Dim logCounter As Integer = 0
    Dim notifTimex As Integer
    Dim notifTimex_Count As Integer
    Public opend_FormList_Counter As Integer
    Public opend_FormList As List(Of Form)



    Dim conifPath As String = System.Reflection.Assembly.GetExecutingAssembly.Location()


    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)
    End Sub
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  uc_user.lbl_text.TextAlign = ContentAlignment.BottomCenter
        ' uc_jo.lbl_text.TextAlign = ContentAlignment.BottomCenter

        rtb_logs.Height = 500

        metroSpin.Height = 18
        metroSpin.Width = 18
        metroSpin.Left = btn_maxMin.Left - metroSpin.Width
        metroSpin.Top = btn_maxMin.Top
        metroSpin.Value = 20


        Me.btn_maxMin.Parent.Controls.Add(metroSpin)
        metroSpin.Show()
        metroSpin.Anchor = AnchorStyles.Right Or AnchorStyles.Bottom
        metroSpin.Visible = False
        metroSpin.BringToFront()



        rtb_logs.Padding.Left.Equals(10)
        rtb_logs.Padding.Right.Equals(10)

        G_lbl_profile1 = lbl_profile1
        G_lbl_profile2 = lbl_profile2
        mainPanel.BringToFront()
        MS_menu.Top = -50
        g_iBtn_Menu_disable()
        g_MainTag = MainTab
        g_MainPanel = mainPanel
        g_splitPanel = SplitCon
        g_tv = tvNode
        LogInMenu()
        WebBrowser1.Visible = True
        timer_logs.BringToFront()
        ' WebBrowser1.Navigate("file://10.10.0.7/ipic_di/Dashboard/gentelella-master/production/indexOLD.html?v=1|1|2|3|4|&s=11|231|xxas|3231")
        ' CMS_Triger.Visible = True


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



        iStartUpModulePathSetup()
        '   iConIfReader()

        Label1.BringToFront()
        Label1.Text = "Copyright© 2019 - " & Now.Year & vbNewLine & "Innovative Packaging Industry Corp" & vbNewLine & ".271 T.Santiago Str,Veinte Reales, 1444 Valenzuela City, Metro Manila " & vbNewLine & "[294 1275 to 77]  & vbNewLine  &   Support@innovativepkg.com"
        Label1.Top = Label1.Parent.Height - Label1.Height
        Label1.BackColor = Color.FromArgb(255, 243, 243, 243)
        Label1.Visible = False
    End Sub
    Private Sub mainPanel_Paint(sender As Object, e As PaintEventArgs)
    End Sub
    Sub LogInMenu()
        tvNode.Nodes.Clear()
        oDisconnect()
        SplitCon.Enabled = False
        mainPanel.Visible = True
        mainPanel.Dock = DockStyle.Fill
        Dim xiLogin As New iLogin
        xiLogin.TopLevel = False
        xiLogin.TopMost = True
        mainPanel.Controls.Add(xiLogin)
        xiLogin.Top = ((mainPanel.Height / 2) - (xiLogin.Height / 2)) - 150
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
    Public Sub AddTabWthForm(ByVal iNameSpace As String, ByVal ModuleName As String, iMetroTab As MetroTabControl, WithCloseButton As Boolean, Optional iReportnameLocation As String = "")
        Try
            Dim iMainNewTab As New TabPage

            ''"IpicIndirect.EDS_Ticketing"
            Dim iForm
            Dim iFormx As New CrystalReportPreview

            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table
            If iReportnameLocation = "" Then
                Dim frmNewForm_Type As Type = Type.GetType(iNameSpace)
                iForm = CType(Activator.CreateInstance(frmNewForm_Type), Form)
            Else
                iForm = New CrystalReportPreview
                Dim iFormxx = New CrystalReportPreview
                cryRpt.Load(iReportnameLocation)
                With crConnectionInfo
                    .ServerName = "DATA-SERVER1\WINSERVER2019"
                    .DatabaseName = "EDS"
                    .UserID = "SA"
                    .Password = "1p1cdbs3rv3r@2016"
                End With

                CrTables = cryRpt.Database.Tables
                For Each CrTable In CrTables
                    crtableLogoninfo = CrTable.LogOnInfo
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo
                    CrTable.ApplyLogOnInfo(crtableLogoninfo)
                Next
                iForm.Report.ReportSource = cryRpt
                iForm.Report.Refresh()

                ''For Each iFormxx As ParameterField In iFormxx.*/

            End If

            iForm.TopLevel = False
            iForm.TopMost = True
            iForm.Tag = opend_FormList_Counter
            With iMainNewTab

                If WithCloseButton Then .Text = "    " & ModuleName & "    X"
                If WithCloseButton = False Then .Text = "" & ModuleName & ""
                .Controls.Add(iForm)
                .Tag = opend_FormList_Counter

            End With
            iMainNewTab = iMainNewTab
            iMetroTab.TabPages.Add(iMainNewTab)
            iForm.Show()
            iForm.Dock = DockStyle.Fill
            iMetroTab.SelectedTab = iMainNewTab
            opend_FormList_Counter = opend_FormList_Counter + 1
        Catch ex As Exception

        End Try
    End Sub
    Private Sub tvNode_DoubleClick(sender As Object, e As EventArgs) Handles tvNode.DoubleClick
        Try

            If SYSTEM_MODE = "EDS" Then
                Dim iTagSplit() As String
                If tvNode.SelectedNode.Tag IsNot Nothing Then
                    Dim iSPlitTag = Split(tvNode.SelectedNode.Tag, "|")
                    If iSPlitTag(3) = "Y" Then
                        If iSPlitTag(1) = "M" Then
                            iTagSplit = tvNode.SelectedNode.Tag.ToString.Split("|")
                            Dim iTagSplit2() = Split(iTagSplit(0), ".")
                            AddTabWthForm(iSPlitTag(0), tvNode.SelectedNode.Text, MainTab, True)
                            TrigerMode()
                        ElseIf iSPlitTag(1) = "R" Then
                            AddTabWthForm("IpicIndirect.CrystalReportPreview", tvNode.SelectedNode.Text, MainTab, True, iSPlitTag(0))
                        End If
                    Else
                        g_notif_panel(0, "404 - Access Denied", 2)
                    End If
                End If
                ElseIf SYSTEM_MODE = "SAP" Then
                Try
                    Dim iTagSplit() As String
                    If IsNumeric(tvNode.SelectedNode.Tag) = False Then
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
        Catch ex As Exception

        End Try
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
    ''' 

    Public Sub g_notif_panel(ByVal Notification_type As Integer, ByRef Notification_msg As String, ByVal Notification_time As Integer)
        Try
            'isAllowEmpty()
            metroSpin.Visible = True

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

            notifTimex = 5 * Notification_time
            Clipboard.SetText(Notification_msg)
            rtb_logs.Text = rtb_logs.Text & vbNewLine & " ----- LOG" & logCounter & " -----" & vbNewLine & " " & " [" & TimeOfDay.ToString("HH:mm:ss") & "]" & Notification_msg & vbNewLine
            logCounter = logCounter + 1
            rtb_logs.SelectionStart = Len(rtb_logs.Text)
            rtb_logs.ScrollToCaret()
            rtb_logs.Select()

            '    metroSpin.Visible = False
            metroSpin.Visible = False

        Catch ex As Exception
            metroSpin.Visible = False
        End Try

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
        '   MenuIcons_IsActive(btn_menu_Profile, False)
        MenuIcons_IsActive(btn_menu_Refresh, False)
        MenuIcons_IsActive(btn_menu_Right, False)
        MenuIcons_IsActive(btn_menu_RightMax, False)
        MenuIcons_IsActive(btn_menu_Print, False)

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
            SAP_SQL_PARAM.Clear()
            SAP_SQL_PARAM.Add(G_USERID)
            SAP_SQL_PARAM.Add(txt_search.Text)
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

    Private Sub btn_menuLogOut_Click(sender As Object, e As EventArgs) Handles btn_menuLogOut.Click
        LogInMenu()
    End Sub


    Private Sub btn_logs_Click(sender As Object, e As EventArgs) Handles btn_logs.Click

        iloGtimer = 0
        If rtb_logs.Visible Then
            rtb_logs.Visible = False
            timer_log.Enabled = False
        Else
            rtb_logs.Visible = True
        End If
        rtb_logs.Select()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles timer_log.Tick
        If iloGtimer >= 10 Then
            rtb_logs.Visible = False
            timer_log.Enabled = False
        Else
            iloGtimer = iloGtimer + 1
        End If
    End Sub

    Private Sub LOGSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGSToolStripMenuItem.Click
        btn_logs.PerformClick()
    End Sub

    Private Sub MainMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        oDisconnect()
    End Sub


    Private Sub rtb_logs_LostFocus(sender As Object, e As EventArgs) Handles rtb_logs.LostFocus
        rtb_logs.Visible = False
        timer_log.Enabled = False
    End Sub

    Private Sub TSM_STARTUP_Click(sender As Object, e As EventArgs) Handles TSM_STARTUP.Click
        iStartUpModulePathSetup()
        Dim iConIfx As New System.IO.StreamWriter(conifPath)
        iConIfx.WriteLine(tvNode.SelectedNode.Tag.ToString)
        iConIfx.Close()
    End Sub

    Sub iStartUpModulePathSetup()
        Dim iPathAr = conifPath.Split("\")
        conifPath = ""
        For i As Integer = 0 To iPathAr.Count - 3
            conifPath = conifPath + iPathAr(i) + "\"
        Next
        conifPath = conifPath + "startupmod.txt"
    End Sub

    Public Sub iConIfReader()

        Dim iAr(5) As String
        Dim ii As Integer = 0
        Dim iConIf As New System.IO.StreamReader(conifPath)
        Try

            While Not iConIf.EndOfStream
                iAr(ii) = iConIf.ReadLine()
                ii = ii + 1
            End While
            '  txtServerIP.Text = iAr(0)
            iConIf.Close()
        Catch ex As Exception
            If ex.Message = "Could not find file '" + conifPath + "'." Then
                g_notif_panel(0, "Connection String Error\Could Not find", 1)
            Else
                g_notif_panel(0, ex.ToString, 1)
            End If
            iConIf.Close()
        End Try
    End Sub

    Private Sub timer_startUp_Tick(sender As Object, e As EventArgs) Handles timer_startUp.Tick

        timer_startUp.Enabled = False

    End Sub

    Private Sub btn_menu_add_MouseHover(sender As Object, e As EventArgs) Handles btn_menu_add.MouseHover, btn_menu_find.MouseHover
        Dim ibtn As Button = sender
        Dim iMsg As String = ""
        If ibtn.Name = "btn_menu_add" Then
            iMsg = "Add Mode (ALT + A)"
        ElseIf ibtn.Name = "btn_menu_find" Then
            iMsg = "Find Mode (ALT + F)"
        End If
        '       mtt_Mianoption.Show(iMsg, ibtn)
    End Sub

    Private Sub CMS_Layout_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles CMS_Layout.ItemClicked
        If SYSTEM_MODE = "SAP" Then
            Dim iCode() = Split(e.ClickedItem.Text, "|")
            ReportSetUp(iCode(1), G_DocEntry)
        End If
    End Sub

    Private Sub btn_menu_Print_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_menu_Print.MouseUp
        Try
            Dim iChild As Form = Nothing
            Dim myForms As FormCollection = Application.OpenForms
            For Each iFOrms As Form In myForms
                If MainTab.SelectedTab.Tag = iFOrms.Tag Then iChild = iFOrms
            Next
            Dim t As Type = iChild.GetType()
            ' iChild.GetType().GetMethod("AddMode")
            g_notif_panel(2, "Layout Mode", 2)
            CallByName(iChild, "LayoutMode", vbMethod)
            CMS_Layout.Show(Me, e.Location)
        Catch ex As Exception
            g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub



    Private Sub btn_menu_Refresh_Click(sender As Object, e As EventArgs) Handles btn_menu_Refresh.Click
        Try


            Dim iChild As Form = Nothing
            Dim myForms As FormCollection = Application.OpenForms
            For Each iFOrms As Form In myForms
                If MainTab.SelectedTab.Tag = iFOrms.Tag Then iChild = iFOrms
            Next
            Dim t As Type = iChild.GetType()
            ' iChild.GetType().GetMethod("AddMode")
            g_notif_panel(2, "Refreash", 2)

            CallByName(iChild, "Refreash", vbMethod)
            'MenuIcons_IsActive(btn_menu_find, True)

        Catch
        End Try
    End Sub

    Private Sub btn_menu_Profile_Click(sender As Object, e As EventArgs) Handles btn_menu_Profile.Click

        Try

            Dim iNewTIcket As New ViewProfile

            Dim iPoint As Point
            iNewTIcket.ShowDialog()
        Catch ex As Exception
            g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub

    Private Sub tvNode_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvNode.AfterSelect

    End Sub
End Class