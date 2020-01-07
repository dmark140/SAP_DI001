

Imports SAPbobsCOM

Public Class iLogin

    Dim conifPath As String = System.Reflection.Assembly.GetExecutingAssembly.Location()
    Dim conifPath2 As String
    Dim conifPath3 As String
    Dim iTimeCount As Integer = 0


    Private Sub iLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '     cb_IS_SAPLOGIN.Checked = True
        '    cb_IS_SAPLOGIN.Checked = False
        ilogin()

    End Sub

    Public Sub ilogin()

        Dim iPathAr = conifPath.Split("\")
        conifPath = ""
        For i As Integer = 0 To iPathAr.Count - 3
            conifPath = conifPath + iPathAr(i) + "\"
        Next
        conifPath = conifPath + "conif.txt"

        conifPath2 = ""
        For i As Integer = 0 To iPathAr.Count - 4
            conifPath2 = conifPath2 + iPathAr(i) + "\"
        Next
        conifPath2 = conifPath2 + "startupmod.txt"

        conifPath3 = ""
        For i As Integer = 0 To iPathAr.Count - 4
            conifPath3 = conifPath3 + iPathAr(i) + "\"
        Next
        conifPath3 = conifPath3 + "login.txt"

        '    iMoreOption()
        iConIfReader()

    End Sub


    Public Sub iMoreOption()
        If btn_moreOption.Tag = "1" Then
            With btn_moreOption
                .Tag = "0"
                .BackgroundImage = (Arrows.Images(0))
                Me.Height = 226
            End With
        Else
            With btn_moreOption
                .Tag = "1"
                .BackgroundImage = (Arrows.Images(1))
                Me.Height = 530
            End With
        End If
    End Sub

    Private Sub btn_moreOption_Click(sender As Object, e As EventArgs) Handles btn_moreOption.Click
        If btn_moreOption.Tag = "0" Then
            If ((iMsgs("Permission required!!", "Please enter administrative password", 0, True)) = "1nro9g") Then
                iMoreOption()
            Else
                MainMenu.g_notif_panel(0, "Invalid password", 2)
            End If
        Else
            iMoreOption()
        End If

    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try
            Dim iCurUserID As Integer
            g_txtUserID = txtUser.Text.ToString
            g_txtPassword = txtPass.Text.ToString

            g_form = Me
            iTimeCount = 0
            SYSTEM_MODE = "EDS"

            If cb_IS_SAPLOGIN.Checked = False Then
                If EDS_LOGIN(g_txtUserID, g_txtPassword) Then
                    MainMenu.g_notif_panel(1, "Pass ", 2)
                    EDS_G_SET_TV(MainMenu.tvNode)
                    '          PopUpAndNotificationHandler.Show()
                    ' Me.Close()
                    Dim iConIf As New System.IO.StreamWriter(conifPath3)
                    iConIf.WriteLine(G_USERID)
                    iConIf.WriteLine(SYSTEM_MODE)
                    iConIf.Close()
                    Me.Close()
                    iCurUserID = EDS_USERID
                Else
                    MainMenu.g_notif_panel(0, "EDS-2 - LOGIN ERROR!!", 2)
                End If

            End If

            If cb_IS_SAPLOGIN.Checked = True Then
                If oConnect() = True Then
                    SYSTEM_MODE = "SAP"
                    Dim irs As SAPbobsCOM.Recordset

                    irs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    irs.DoQuery("SELECT USERID , USER_CODE  , U_NAME FROM   OUSR  WHERE  USER_CODE = '" & g_txtUserID & "'")
                    Do While irs.EoF = False
                        G_USERID = irs.Fields.Item("USERID").Value
                        MainMenu.uc_user.iLabel = irs.Fields.Item("USER_CODE").Value
                        MainMenu.uc_jo.iLabel = irs.Fields.Item("U_NAME").Value
                        iCurUserID = G_USERID
                        irs.MoveNext()
                    Loop
                    g_iLogInSet()

                    If My.Computer.FileSystem.FileExists(conifPath2) Then
                        Dim iSplitFIlex() As String = Split(conifPath2, "\")
                        Dim iSplitTxtFile() = Split(iConIfReader2(conifPath2), "|")
                        If iSplitTxtFile(4) = "Y" Then
                            MainMenu.AddTabWthForm(iSplitTxtFile(0), iSplitTxtFile(1), g_MainTag, True)
                        End If
                        Dim iConIf As New System.IO.StreamWriter(conifPath3)
                        iConIf.WriteLine(G_USERID)
                        iConIf.WriteLine(SYSTEM_MODE)
                        iConIf.Close()
                        Me.Close()
                    End If
                End If

            End If

            '  If PREV_USER <> iCurUserID Then
            For i = 1 To MainMenu.MainTab.TabPages.Count - 1
                Dim index As Integer = i
                index = index
                MainMenu.MainTab.TabPages.RemoveAt((MainMenu.MainTab.TabPages.Count) - 1)
            Next
            ' End If
            PREV_USER = iCurUserID
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.ToString, 1)
        End Try
        MainMenu.Width = MainMenu.Width + 1
    End Sub
    Public Sub iConIfCreator()
        Dim iConIf As New System.IO.StreamWriter(conifPath)
        iConIf.WriteLine(txtServerIP.Text.ToString)
        iConIf.WriteLine(txtDatabase.Text.ToString)
        iConIf.WriteLine(txtDbUserName.Text.ToString)
        iConIf.WriteLine(txtDbPassword.Text.ToString)
        iConIf.WriteLine(txtCompanyDB.Text.ToString)
        iConIf.Close()
    End Sub

    Public Sub iConIfReader()
        Try
            Dim iAr(5) As String
            Dim ii As Integer = 0
            Dim iConIf As New System.IO.StreamReader(conifPath)
            While Not iConIf.EndOfStream
                iAr(ii) = iConIf.ReadLine()
                ii = ii + 1
            End While
            txtServerIP.Text = iAr(0)
            txtDatabase.Text = iAr(1)
            txtDbUserName.Text = iAr(2)
            txtDbPassword.Text = iAr(3)
            txtCompanyDB.Text = iAr(4)
            Global_var.g_txtServerIP = iAr(0)
            Global_var.g_txtDatabase = iAr(1)
            Global_var.g_txtDbUserName = iAr(2)
            Global_var.g_txtDbPassword = iAr(3)
            Global_var.g_txtCompanyDB = iAr(4)
            g_txtUserID = txtUser.Text
            g_txtPassword = txtPass.Text
            iConIf.Close()
        Catch ex As Exception
            If ex.Message = "Could not find file '" + conifPath + "'." Then
                MainMenu.g_notif_panel(0, "Connection String Error\Could Not find", 1)
            Else
                MainMenu.g_notif_panel(0, ex.ToString, 1)
            End If
        End Try
    End Sub


    Function iConIfReader2(iPath As String) As String
        Try
            Dim iAr(5) As String
            Dim ii As Integer = 0
            Dim iConIf As New System.IO.StreamReader(conifPath2)
            While Not iConIf.EndOfStream
                iAr(ii) = iConIf.ReadLine()
                ii = ii + 1
            End While

            iConIf.Close()
            Return iAr(0)
        Catch ex As Exception
            If ex.Message = "Could not find file '" + conifPath2 + "'." Then
                MainMenu.g_notif_panel(0, "Connection String Error\Could Not find", 1)
            Else
                MainMenu.g_notif_panel(0, ex.ToString, 1)
            End If
        End Try
    End Function

    Public Sub iModfReader()
        Try
            Dim iAr(5) As String
            Dim ii As Integer = 0
            Dim iConIf As New System.IO.StreamReader(conifPath)
            While Not iConIf.EndOfStream
                iAr(ii) = iConIf.ReadLine()
                ii = ii + 1
            End While
            txtServerIP.Text = iAr(0)
            txtDatabase.Text = iAr(1)
            txtDbUserName.Text = iAr(2)
            txtDbPassword.Text = iAr(3)
            txtCompanyDB.Text = iAr(4)
            Global_var.g_txtServerIP = iAr(0)
            Global_var.g_txtDatabase = iAr(1)
            Global_var.g_txtDbUserName = iAr(2)
            Global_var.g_txtDbPassword = iAr(3)
            Global_var.g_txtCompanyDB = iAr(4)
            g_txtUserID = txtUser.Text
            g_txtPassword = txtPass.Text
            iConIf.Close()
        Catch ex As Exception
            If ex.Message = "Could not find file '" + conifPath + "'." Then
                MainMenu.g_notif_panel(0, "Connection String Error\Could Not find", 1)
            Else
                MainMenu.g_notif_panel(0, ex.ToString, 1)
            End If
        End Try
    End Sub

    Private Sub btn_createConIF_Click(sender As Object, e As EventArgs) Handles btn_createConIF.Click
        iConIfCreator()
        MainMenu.g_notif_panel(1, "Connection string created, Please reopen application", 1)

    End Sub

    Private Sub txtUser_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtUser.MaskInputRejected

    End Sub

    Private Sub txtUser_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUser.KeyUp
        If e.KeyCode = 13 Then btn_ok.PerformClick()
    End Sub

    Private Sub txtPass_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtPass.MaskInputRejected

    End Sub

    Private Sub txtPass_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPass.KeyUp
        If e.KeyCode = 13 Then btn_ok.PerformClick()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles time_autoLokgin.Tick
        btn_ok.PerformClick()
        time_autoLokgin.Enabled = False
        Me.Width = Me.Width + 1

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        iTimeCount = iTimeCount + 1
        If iTimeCount > 9 Then
            Label7.Visible = False
            Timer2.Enabled = False
            iTimeCount = 0
        End If
    End Sub

    Private Sub cb_IS_SAPLOGIN_CheckedChanged(sender As Object, e As EventArgs) Handles cb_IS_SAPLOGIN.CheckedChanged
        'autologin()
    End Sub

    Sub autologin()
        If cb_IS_SAPLOGIN.Checked = True Then
            txtUser.Text = "IPICPADM04"
            txtPass.Text = "Thunder@69"
            ''txtUser.Text = "Manager"
            'txtPass.Text = "P@ssw0rd"
        Else
            txtUser.Text = "d34907"
            txtPass.Text = "34907"
        End If

    End Sub




End Class
