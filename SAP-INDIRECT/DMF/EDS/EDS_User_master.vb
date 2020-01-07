Public Class EDS_User_master

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Dim ikEy As Integer = 1
        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "1")
        EDS_SQL_PARAM_ADD("@val1", uc_fname.iText) ' firstname 
        EDS_SQL_PARAM_ADD("@val2", uc_mname.iText) ' midname 
        EDS_SQL_PARAM_ADD("@val3", uc_lname.iText) ' lastname 
        EDS_SQL_PARAM_ADD("@val4", "0") ' createdBy 
        EDS_SQL_PARAM_ADD("@val5", "0") ' updatedBy 
        EDS_SQL_PARAM_ADD("@val6", uc_username.iText) ' username 
        EDS_SQL_PARAM_ADD("@val7", uc_pass1.iText) ' password Please Fill up 
        EDS_SQL_PARAM_ADD("@val8", uc_pass2.iText) ' password Please Fill up 
        EDS_SQL_PARAM_ADD("@val9", "0") ' position 
        Dim iDt As DataSet = EDS_G_iSQL()
        EDS_PARAM_VALIDATION(iDt)
    End Sub

    Private Sub EDS_User_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        uc_pass1.Textbox.PasswordChar = "*"
        uc_pass2.Textbox.PasswordChar = "*"
    End Sub

    Sub UsernameGenerator()
        Try


            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "9") ' GET LAST ID OF USERS
            Dim iDt As DataSet = EDS_G_iSQL()

            uc_username.iText = uc_fname.iText.Substring(0, 1) & uc_lname.iText.Substring(0, 1) & iDt.Tables(0).Rows(0)("ID").ToString()
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
End Class