Public Class SAP_CONNECTOR
    Public EDS_SQL_ID As Integer '>>>> for insertion
    Public SAP_SQL_ID As Integer


    Private Sub SAP_CONNECTOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_database.Text = g_txtDatabase
        lbl_constring.Text = g_txtServerIP
        lbl_db.Text = g_txtCompanyDB
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try
            Global_var.g_txtUserID = txtUser.Text
            Global_var.g_txtPassword = txtPass.Text
            If oConnect() Then

                '>>>> GET  FROM  SAP
                SAP_SQL_PARAM.Clear()
                SAP_SQL_PARAM.Add(SAP_SQL_ID)
                Dim iSAP_DT As DataTable = iSQL_DATATABLE()
                For i1 = 0 To iSAP_DT.Rows.Count - 1

                    '>>>> INSERT  TO EDS 
                    EDS_SQL_PARAM.Clear()
                    EDS_SQL_PARAM_ADD("@SQLID", EDS_SQL_ID)
                    Dim iFinalRow As Integer = 0
                    For i2 = 0 To iSAP_DT.Columns.Count - 1
                        Dim iVALID As String = "@val" & (i2 + 1)
                        EDS_SQL_PARAM_ADD(iVALID, iSAP_DT.Rows(i1)(i2))
                        iFinalRow = i2
                    Next
                    EDS_SQL_PARAM_ADD("@val" & iFinalRow + 2, EDS_USERID)
                    Dim iEDS_DT As DataTable = EDS_G_iSQL_TABLE() '' EXECUTE INSERT
                Next
                MainMenu.g_notif_panel(0, EDS_SQL_ID & " Operation completed successfully ", 2)

                oDisconnect()
                Me.Close()
            End If
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub




End Class