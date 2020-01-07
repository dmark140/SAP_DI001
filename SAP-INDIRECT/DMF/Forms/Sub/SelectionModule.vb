Public Class SelectionModule
    Private Sub SelectionModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Public Sub iFinderx(ByVal selectionID As Integer, ByVal iSearchVar As String, ByVal iFormTitle As String)
        Try

            Me.Show()
            dgv_1.Columns.Clear()
            dgv_1.Rows.Clear()
            lbl_title.Text = iFormTitle

            Call oConnect()
            Dim iUDR As SAPbobsCOM.Recordset

            iUDR = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            iUDR.DoQuery("exec spDMF_DI001  " & selectionID & " ,'" & iSearchVar & "'")

            For i = 0 To iUDR.Fields.Count - 1
                dgv_1.Columns.Add(i, iUDR.Fields(i).Name)
            Next

            Dim row(iUDR.Fields.Count - 1) As String

            Do While iUDR.EoF = False

                For i = 0 To iUDR.Fields.Count - 1
                    row(i) = iUDR.Fields.Item(iUDR.Fields(i).Name).Value
                Next

                dgv_1.Rows.Add(row)
                iUDR.MoveNext()
            Loop

            dgv_1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgv_1.Columns(0).Width = 30
            Me.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub


    Private Sub dgv_1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_1.CellContentDoubleClick
        getme()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getme()
    End Sub

    Sub getme()
        Try
            If G_Finder_text IsNot Nothing Then G_Finder_text.Text = dgv_1.SelectedRows(0).Cells(0).Value.ToString
            If G_Finder_dscr IsNot Nothing Then G_Finder_dscr.Text = dgv_1.SelectedRows(0).Cells(1).Value.ToString

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class