Public Class EDS_Department
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        iSapGoldenRetriever(50, 150)
    End Sub
    Private Sub EDS_Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgv_1.Columns.Clear()
            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", 51)
            Dim iEDS_DT As DataTable = EDS_G_iSQL_TABLE() '
            dgv_1.DataSource = iEDS_DT
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub
End Class