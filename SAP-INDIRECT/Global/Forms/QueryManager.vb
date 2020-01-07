Public Class QueryManager
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        execute()
    End Sub
    Sub execute()
        Try
            SAP_SQL_PARAM.Clear()
            SAP_SQL_PARAM.Add(999)
            DataGridView1.DataSource = iSQL_DATATABLE(TextBox1.Text)

        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try

    End Sub

    Function ifNotInject() As Boolean
        Dim iQty() = TextBox1.Text.Split(" ")
        For i = 0 To iQty.Count - 1
            If iQty(i) = "Truncate" Or iQty(i) = "UPDATE" Or iQty(i) = "DELETE" Then

            End If
        Next
        Return False
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            oConnect()
            Dim oUserTable As SAPbobsCOM.UserTable
            oUserTable = oCompany.UserTables.Item("OQRY")
            oUserTable.Code = Uc_label5.iText
            oUserTable.Name = Uc_label2.iText
            oUserTable.UserFields.Fields.Item("U_query").Value = TextBox1.Text
            oUserTable.UserFields.Fields.Item("U_dateCreated").Value = Now.Date
            oUserTable.UserFields.Fields.Item("U_createdBy").Value = G_USERID
            oUserTable.UserFields.Fields.Item("U_void").Value = "Y"

            Dim retVal = oUserTable.Add
            Dim retStr As String = ""
            If retVal <> 0 Then
                oCompany.GetLastError(retVal, retStr)
                MainMenu.g_notif_panel(0, "Transaction Error :" & retStr, 2)
            Else
                MainMenu.g_notif_panel(0, "Transaction Success", 2)
                CodeGenereatorNclear()
            End If

        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub

    Function CodeGenereatorNclear() As String
        Try
            dgv_apv.Columns.Clear()
            Uc_label2.iText = ""
            TextBox1.Text = ""
            DataGridView1.Columns.Clear()
            SAP_SQL_PARAM.Clear()
            SAP_SQL_PARAM.Add(174)
            Dim iBt As DataTable = iSQL_DATATABLE()
            Uc_label5.iText = iBt.Rows(0)("count")
            Uc_label5.iText = "QY" & Now.Month.ToString("00") & Now.Day.ToString("00") & Now.Year.ToString("00") & Uc_label5.iText
            SAP_SQL_PARAM.Clear()
            SAP_SQL_PARAM.Add(175)
            dgv_apv.DataSource = iSQL_DATATABLE()

            Return ""
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Function

    Private Sub Uc_label5_Load(sender As Object, e As EventArgs) Handles Uc_label5.Load

    End Sub

    Private Sub QueryManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CodeGenereatorNclear()

    End Sub

    Private Sub dgv_apv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_apv.CellContentClick

    End Sub

    Private Sub dgv_apv_DoubleClick(sender As Object, e As EventArgs) Handles dgv_apv.DoubleClick

        SAP_SQL_PARAM.Clear()
        SAP_SQL_PARAM.Add(176)
        SAP_SQL_PARAM.Add(dgv_apv.Rows(dgv_apv.SelectedRows(0).Index).Cells(0).Value)
        Dim iDt As DataTable = iSQL_DATATABLE()
        TextBox1.Text = iDt.Rows(0)("U_query")

        execute()

    End Sub
End Class