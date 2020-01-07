Public Class EDS_Warehouse

    Dim onCEllEdit As Boolean
    Dim ModuleMode As String = "F"

    Dim iDeletedIDs(0) As String

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        For i = 0 To iDeletedIDs.Count - 1
            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "24")
            EDS_SQL_PARAM_ADD("@val1", iDeletedIDs(i))
            Dim iDtxc As DataTable = EDS_G_iSQL_TABLE()
        Next

        For i = 0 To dgv_1.Rows.Count - 1
            If CStr(dgv_1.Rows(i).Cells(0).Value) = "-" Then
                EDS_SQL_PARAM.Clear() ''insert
                EDS_SQL_PARAM_ADD("@SQLID", "25")
                EDS_SQL_PARAM_ADD("@val1", dgv_1.Rows(i).Cells(1).Value) 'iFileLocation
                EDS_SQL_PARAM_ADD("@val2", dgv_1.Rows(i).Cells(2).Value) 'iFileLocation
                EDS_SQL_PARAM_ADD("@val3", EDS_USERID) 'iFileLocation
                Dim iDtx As DataTable = EDS_G_iSQL_TABLE()
                MainMenu.g_notif_panel(iDtx.Rows(0)("ERRORCODE"), iDtx.Rows(0)("MSG"), 2)
            End If

        Next

        dgv_1.Rows.Clear()
        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "26") ''select
        Dim iDt As DataTable = EDS_G_iSQL_TABLE()
        For i = 0 To iDt.Rows.Count - 1
            dgv_1.Rows.Add(dgv_1.Rows.Count + 1, iDt.Rows(i)("code"), iDt.Rows(i)("Warehouse"))
        Next

        MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)
        onCEllEdit = False
        cmd_cell_menu.Enabled = True
        ModuleMode = "F"
        WrightAllCell()

    End Sub

    Private Sub dgv_1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_1.CellContentClick

    End Sub
    Sub AddMode()
        dgv_1.Rows.Add("-", "", "")
        WrightPrevCell()

        Dim iFinalRow As Integer = dgv_1.Rows.Count - 1
        WrightFinalCell(iFinalRow)
        MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, False)
        cmd_cell_menu.Enabled = False
        ModuleMode = "A"

    End Sub

    Private Sub EDS_Warehouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)

        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "26")
        Dim iDt As DataTable = EDS_G_iSQL_TABLE()
        For i = 0 To iDt.Rows.Count - 1
            dgv_1.Rows.Add(dgv_1.Rows.Count + 1, iDt.Rows(i)("code"), iDt.Rows(i)("Warehouse"))
        Next
        WrightAllCell()

        onCEllEdit = False

    End Sub

    Sub WrightFinalCell(iFinalRow As Integer)

        dgv_1.Rows(iFinalRow).Cells(0).ReadOnly = True
        dgv_1.Rows(iFinalRow).Cells(1).ReadOnly = False
        dgv_1.Rows(iFinalRow).Cells(2).ReadOnly = False


        dgv_1.Rows(iFinalRow).Cells(0).Style.BackColor = g_colors.whiteSmoke3
        dgv_1.Rows(iFinalRow).Cells(1).Style.BackColor = g_colors.WhiteNore
        dgv_1.Rows(iFinalRow).Cells(2).Style.BackColor = g_colors.WhiteNore
    End Sub
    Sub WrightPrevCell()
        For i = 0 To dgv_1.Rows.Count - 2
            dgv_1.Rows(i).Cells(0).ReadOnly = True
            dgv_1.Rows(i).Cells(1).ReadOnly = True
            dgv_1.Rows(i).Cells(2).ReadOnly = True

            dgv_1.Rows(i).Cells(0).Style.BackColor = g_colors.whiteSmoke3
            dgv_1.Rows(i).Cells(1).Style.BackColor = g_colors.whiteSmoke3
            dgv_1.Rows(i).Cells(2).Style.BackColor = g_colors.whiteSmoke3

        Next
    End Sub
    Sub WrightAllCell()
        For i = 0 To dgv_1.Rows.Count - 1
            dgv_1.Rows(i).Cells(0).ReadOnly = True
            dgv_1.Rows(i).Cells(1).ReadOnly = True
            dgv_1.Rows(i).Cells(2).ReadOnly = True


            dgv_1.Rows(i).Cells(0).Style.BackColor = g_colors.whiteSmoke3
            dgv_1.Rows(i).Cells(1).Style.BackColor = g_colors.whiteSmoke3
            dgv_1.Rows(i).Cells(2).Style.BackColor = g_colors.whiteSmoke3
        Next
    End Sub

    Private Sub cmd_help_Click(sender As Object, e As EventArgs) Handles cmd_help.Click
        MainMenu.g_notif_panel(2, "HELP: EDIT- Clicking  'Edit' will trigger edit mode in the selected row,  DELETE - will delete the selected row ", 2)
    End Sub

    Private Sub cmd_edit_Click(sender As Object, e As EventArgs) Handles cmd_edit.Click
        If onCEllEdit = False Then
            WrightFinalCell(dgv_1.SelectedCells(0).RowIndex)
            onCEllEdit = True
        End If
    End Sub

    Private Sub dgv_1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_1.CellMouseDown

    End Sub

    Private Sub cmd_cell_menu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmd_cell_menu.Opening

    End Sub

    Private Sub cmd_delete_Click(sender As Object, e As EventArgs) Handles cmd_delete.Click

        ReDim iDeletedIDs(iDeletedIDs.Count)
        iDeletedIDs(iDeletedIDs.Count - 1) = dgv_1.Rows(dgv_1.SelectedCells(0).RowIndex).Cells(1).Value

        dgv_1.Rows.RemoveAt(dgv_1.SelectedCells(0).RowIndex)
    End Sub

    Sub TrigerMode()
        If ModuleMode = "A" Then
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, True)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, False)
        ElseIf ModuleMode = "F" Then
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, False)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)
        End If
    End Sub
End Class