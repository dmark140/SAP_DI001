Public Class Palleting
    Private Sub Palleting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_CheckSelection.BringToFront()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_fetch.Click
        G_iSQL_PARAMETERS.Clear()
        G_iSQL_PARAMETERS.Add(Uc_dateFrom.iDate)
        G_iSQL_PARAMETERS.Add(Uc_dateTo.iDate)
        iSQL_selector(117, DataGridView1, False, 2)
    End Sub
    Private Sub docnum_container_TextChanged(sender As Object, e As EventArgs) Handles docnum_container.TextChanged
        Try
            dgv_CheckSelection.Rows.Clear()
            dgv_CheckSelection.Columns.Clear()
            Uc_docnum.iText = docnum_container.Text
            G_iSQL_PARAMETERS.Clear()
            G_iSQL_PARAMETERS.Add(docnum_container.Text)
            iSQL_selector(118, dgv_CheckSelection, True, 3)
            '  iSplitPallet()
        Catch ex As Exception
            MainMenu.g_notif_panel(0, "118 - " & ex.Message, 2)
        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim iIT As SAPbobsCOM.StockTransfer = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oStockTransfer)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            dgv_CheckSelection.Rows.Clear()
            dgv_CheckSelection.Columns.Clear()
            Uc_docnum.iText = docnum_container.Text
            G_iSQL_PARAMETERS.Clear()
            G_iSQL_PARAMETERS.Add(DataGridView1.SelectedRows(0).Cells(0).Value.ToString)
            iSQL_selector(118, dgv_CheckSelection, True, 3)
            '  iSplitPallet()
        Catch ex As Exception
            MainMenu.g_notif_panel(0, "118 - " & ex.Message, 2)
        End Try
    End Sub



End Class