Public Class EDS_User_master

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        btn_ok.Enabled = False
        Try
            If isAllowEmpty(Me) = False Then
                Dim ikEy As Integer = 1
                EDS_SQL_PARAM.Clear()
                EDS_SQL_PARAM_ADD("@SQLID", "1")
                EDS_SQL_PARAM_ADD("@val1", uc_fname.iText) 'firstname 
                EDS_SQL_PARAM_ADD("@val2", uc_mname.iText) 'midname 
                EDS_SQL_PARAM_ADD("@val3", uc_lname.iText) 'lastname 
                EDS_SQL_PARAM_ADD("@val4", "0") 'createdBy 
                EDS_SQL_PARAM_ADD("@val5", "0") 'updatedBy 
                EDS_SQL_PARAM_ADD("@val6", uc_username.iText) 'username 
                EDS_SQL_PARAM_ADD("@val7", uc_pass1.iText) 'password Please Fill up 
                EDS_SQL_PARAM_ADD("@val8", uc_pass2.iText) 'password Please Fill up 
                EDS_SQL_PARAM_ADD("@val9", "0") 'position 
                EDS_SQL_PARAM_ADD("@val10", "0") 'position 
                EDS_SQL_PARAM_ADD("@val11", uc_machine.iText) 'position 
                EDS_SQL_PARAM_ADD("@val12", Uc_inputbox1.iText) 'position 
                Dim iDt As DataSet = EDS_G_iSQL()
                EDS_PARAM_VALIDATION(iDt)
                MainMenu.g_notif_panel(0, "User Added", 2)
                iClear()
            End If
            btn_ok.Enabled = True
        Catch ex As Exception
            btn_ok.Enabled = True
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub
    Sub iClear()
        uc_fname.iText = ""
        uc_mname.iText = ""
        uc_lname.iText = ""
        uc_username.iText = ""
        uc_pass1.iText = ""
        uc_pass2.iText = ""
        uc_machine.iText = ""
        uc_machine_lbl.iText = ""
        Uc_inputbox1.iText = ""
    End Sub

    Private Sub EDS_User_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        uc_pass1.Textbox.PasswordChar = "*"
        uc_pass2.Textbox.PasswordChar = "*"
    End Sub

    Sub UsernameGenerator()
        Try
            uc_username.iText = uc_fname.iText + "." + uc_lname.iText
            '    EDS_SQL_PARAM.Clear()
            '    EDS_SQL_PARAM_ADD("@SQLID", "9") ' GET LAST ID OF USERS1
            '    Dim iDt As DataSet = EDS_G_iSQL()
            '    uc_username.iText = uc_fname.iText.Substring(0, 1) & uc_lname.iText.Substring(0, 1) & iDt.Tables(0).Rows(0)("ID").ToString()
        Catch
        End Try
    End Sub

    Private Sub uc_fname_Load(sender As Object, e As EventArgs) Handles uc_fname.Load

    End Sub

    Private Sub uc_fname_Leave(sender As Object, e As EventArgs) Handles uc_fname.Leave
        UsernameGenerator()
    End Sub
    Private Sub uc_lname_Leave(sender As Object, e As EventArgs) Handles uc_lname.Leave
        UsernameGenerator()
    End Sub
    Private Sub uc_mname_Leave(sender As Object, e As EventArgs) Handles uc_mname.Leave
        UsernameGenerator()
    End Sub

    Private Sub uc_lname_Load(sender As Object, e As EventArgs) Handles uc_lname.Load

    End Sub
End Class