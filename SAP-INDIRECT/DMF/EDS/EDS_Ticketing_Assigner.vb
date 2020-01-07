Public Class EDS_Ticketing_Assigner
    Private Sub EDS_Ticketing_Assigner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EDS_SQL_PARAM.Clear()
        dgv_1.Columns.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "19")
        Dim iDt As DataTable = EDS_G_iSQL_TABLE()
        dgv_1.DataSource = iDt
        dgv_1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.ColumnHeader



        ADD_Column("+", 2, 0, 40, dgv_1, True, False)


        ADD_Column("User", 1, 0, 100, dgv_2, True, False)
        ADD_Column("ID", 1, 0, 50, dgv_2, True, False)
        ADD_Column("-", 2, 0, 40, dgv_2, True, False)

        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "22")
        Dim iDt2 As DataTable = EDS_G_iSQL_TABLE()
        '  dgv_2.DataSource = iDt2

        For i = 0 To iDt2.Rows.Count - 1
            dgv_2.Rows.Add(i, iDt2.Rows(i)("id").ToString, iDt2.Rows(i)("User").ToString)

        Next
        dgv_2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.ColumnHeader



    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "20")
        Dim iDt As DataTable = EDS_G_iSQL_TABLE()


        For i = 0 To dgv_2.Rows.Count - 1
            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "21")
            EDS_SQL_PARAM_ADD("@val1", dgv_2.Rows(i).Cells(1).Value)
            EDS_SQL_PARAM_ADD("@val2", EDS_USERID)
            Dim iDtx As DataTable = EDS_G_iSQL_TABLE()
        Next
    End Sub

    Private Sub dgv_1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            Dim i1 As Integer = dgv_1.SelectedRows(0).Index  ' ownumber
            dgv_2.Rows.Add(i1, dgv_1.Rows(i1).Cells(1).Value, dgv_1.Rows(i1).Cells(2).Value)
            dgv_1.Rows.RemoveAt(i1)
        End If
    End Sub

    Private Sub dgv_2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_2.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            Dim i1 As Integer = dgv_2.SelectedRows(0).Index  ' ownumber
            dgv_2.Rows.RemoveAt(i1)
        End If
    End Sub
End Class