Public Class Ticketing_verif
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If isAllowEmpty(Me) Then
            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "57")
            EDS_SQL_PARAM_ADD("@val1", uc_req.iText) 'status
            EDS_SQL_PARAM_ADD("@val2", Uc_inputbox1.iText) 'status
            EDS_G_iSQL()
        End If
    End Sub
    Sub dgv_CheckSelection_load()
        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "58")
        dgv_CheckSelection.DataSource = EDS_G_iSQL_TABLE()
    End Sub

    Private Sub Ticketing_verif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_CheckSelection_load()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim iMsgbox = InputBox("Warning!, This action cant  be undone, Do you wish to proceed?", "Remove selected item", 1)
        MainMenu.g_notif_panel(0, iMsgbox, 2)
    End Sub

    Private Sub Uc_lines2_Load(sender As Object, e As EventArgs) Handles Uc_lines2.Load

    End Sub
End Class'