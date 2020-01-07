Public Class ViewProfile
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ViewProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If EDS_USERID <> 3103 Then
            Uc_inputbox2.iArrow_Visible = True
            uc_Departmet.iArrow_Visible = True
        ElseIf EDS_USERID <> 3171 Then
            Uc_inputbox2.iArrow_Visible = True
            uc_Departmet.iArrow_Visible = True
        End If
        uc_pass1.Textbox.PasswordChar = "*"
        uc_pass2.Textbox.PasswordChar = "*"
        Try
            ' If isAllowEmpty(Me) = False Then
            Uc_inputbox2.iText = EDS_USERID
            Uc_label1.iText = EDS_USER_FULLNAME
            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", 80)
            EDS_SQL_PARAM_ADD("@IDENTITY", CInt(Uc_inputbox2.iText))
            Dim iDt As DataSet = EDS_G_iSQL()
            '      If EDS_PARAM_VALIDATION(iDt) > 0 Then
            uc_fname.iText = iDt.Tables(0).Rows(0)("firstname")
            uc_mname.iText = iDt.Tables(0).Rows(0)("midname")
            uc_lname.iText = iDt.Tables(0).Rows(0)("lastname")
            uc_username.iText = iDt.Tables(0).Rows(0)("username")
            uc_pass1.iText = iDt.Tables(0).Rows(0)("password")
            uc_pass2.iText = iDt.Tables(0).Rows(0)("password")
            uc_Departmet.iText = iDt.Tables(0).Rows(0)("Departmnt")
            uc_machine_lbl.iText = iDt.Tables(0).Rows(0)("DepartmenName")
            Uc_inputbox1.iText = iDt.Tables(0).Rows(0)("Mobilenumber")
            ' End If
            '  End If
            'Dim iPoint = New Point(MainMenu.btn_menu_Profile.Left, MainMenu.btn_menu_Profile.Top )
            'Me.Location = iPoint
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try
            If iMsgs("System Info", "are you sure you want to update this user?", 1, False) = "True" Then
                EDS_SQL_PARAM.Clear()
                EDS_SQL_PARAM_ADD("@SQLID", 81)
                EDS_SQL_PARAM_ADD("@val1", (uc_fname.iText))
                EDS_SQL_PARAM_ADD("@val2", (uc_mname.iText))
                EDS_SQL_PARAM_ADD("@val3", (uc_lname.iText))
                EDS_SQL_PARAM_ADD("@val4", (uc_pass1.iText))
                EDS_SQL_PARAM_ADD("@val5", (uc_pass2.iText))
                EDS_SQL_PARAM_ADD("@val6", (uc_Departmet.iText))
                EDS_SQL_PARAM_ADD("@val7", (Uc_inputbox1.iText))
                EDS_SQL_PARAM_ADD("@IDENTITY", (Uc_inputbox2.iText))
                Dim iDt As DataSet = EDS_G_iSQL()
                MainMenu.g_notif_panel(iDt.Tables(0).Rows(0)("ErrorCode"), iDt.Tables(0).Rows(0)("MSG"), 2)
            End If
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Try

            uc_fname.iText = ""
            uc_mname.iText = ""
            uc_lname.iText = ""
            uc_username.iText = ""
            uc_pass1.iText = ""
            uc_pass2.iText = ""
            uc_Departmet.iText = ""
            uc_machine_lbl.iText = ""
            Uc_inputbox1.iText = ""

            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", 80)
            EDS_SQL_PARAM_ADD("@IDENTITY", CInt(Uc_inputbox2.iText))
            Dim iDt As DataSet = EDS_G_iSQL()
            uc_fname.iText = iDt.Tables(0).Rows(0)("firstname")
            uc_mname.iText = iDt.Tables(0).Rows(0)("midname")
            uc_lname.iText = iDt.Tables(0).Rows(0)("lastname")
            uc_username.iText = iDt.Tables(0).Rows(0)("username")
            uc_pass1.iText = iDt.Tables(0).Rows(0)("password")
            uc_pass2.iText = iDt.Tables(0).Rows(0)("password")
            uc_Departmet.iText = iDt.Tables(0).Rows(0)("Departmnt")
            uc_machine_lbl.iText = iDt.Tables(0).Rows(0)("DepartmenName")
            Uc_inputbox1.iText = iDt.Tables(0).Rows(0)("Mobilenumber")
              Timer1.Enabled = False
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
            Timer1.Enabled = False
        End Try

    End Sub
End Class