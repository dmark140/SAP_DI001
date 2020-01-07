

Public Class iLogin

    Dim conifPath As String = System.Reflection.Assembly.GetExecutingAssembly.Location()
    Dim iTimeCount As Integer = 0


    Private Sub iLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim iPathSplit() = Split(System.Reflection.Assembly.GetExecutingAssembly.Location(), "\")
        'For i = 0 To iPathSplit.Count - 1
        '    If i = 0 Then G_iAPP_PATH_REPORTS = iPathSplit(i)
        '    If i > 0 Then G_iAPP_PATH_REPORTS = G_iAPP_PATH_REPORTS & "\" & iPathSplit(i)
        '    If iPathSplit(i) = "SAP-INDIRECT" Then i = iPathSplit.Count
        'Next
        'G_iAPP_PATH_REPORTS = G_iAPP_PATH_REPORTS & "\Reports"
        'G_iAPP_PATH_REPORTS = G_iAPP_PATH_REPORTS


        ilogin()

    End Sub

    Public Sub ilogin()

        Dim iPathAr = conifPath.Split("\")
        conifPath = ""
        For i As Integer = 0 To iPathAr.Count - 3
            conifPath = conifPath + iPathAr(i) + "\"
        Next
        conifPath = conifPath + "conif.txt"
        iMoreOption()
        iConIfReader()

    End Sub


    Public Sub iMoreOption()
        If btn_moreOption.Tag = "1" Then
            With btn_moreOption
                .Tag = "0"
                .BackgroundImage = (Arrows.Images(0))
                Me.Height = 339
            End With
        Else
            With btn_moreOption
                .Tag = "1"
                .BackgroundImage = (Arrows.Images(1))
                Me.Height = 119
            End With
        End If
    End Sub

    Private Sub btn_moreOption_Click(sender As Object, e As EventArgs) Handles btn_moreOption.Click
        iMoreOption()
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try
            g_txtUserID = txtUser.Text.ToString
            g_txtPassword = txtPass.Text.ToString
            g_form = Me
            iTimeCount = 0
            SYSTEM_MODE = "EDS"
            If cb_IS_SAPLOGIN.Checked = False Then
                If EDS_LOGIN(g_txtUserID, g_txtPassword) Then
                    MainMenu.g_notif_panel(1, "Pass ", 2)
                    EDS_G_SET_TV(MainMenu.tvNode)
                Else
                    MainMenu.g_notif_panel(0, "EDS-2 - LOGIN ERROR!!", 2)
                End If
            End If
            If cb_IS_SAPLOGIN.Checked = True Then
                If oConnect() = True Then
                    SYSTEM_MODE = "SAP"
                    Dim irs As SAPbobsCOM.Recordset
                    irs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    irs.DoQuery("SELECT USERID FROM OUSR  WHERE  USER_CODE = '" & g_txtUserID & "'")
                    Do While irs.EoF = False
                        g_userID = irs.Fields.Item("USERID").Value
                        irs.MoveNext()
                    Loop
                    g_iLogInSet()
                End If
            End If
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
        'btn_ok.PerformClick()
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
End Class
