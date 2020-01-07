Public Class EDS_OEE_DowntimeList

    Dim ModuleMode As String = "F"
        Dim onCEllEdit As Boolean
        Private WithEvents eidtText As TextBox


        Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "38")
            Dim iDtxc As DataTable = EDS_G_iSQL_TABLE()
        For i = 0 To dgv_1.Rows.Count - 1
            EDS_SQL_PARAM.Clear() ''insert
            EDS_SQL_PARAM_ADD("@SQLID", "37")
            EDS_SQL_PARAM_ADD("@val1", dgv_1.Rows(i).Cells(1).Value) 'iFileLocation
            EDS_SQL_PARAM_ADD("@val2", dgv_1.Rows(i).Cells(2).Value) 'iFileLocation
            EDS_SQL_PARAM_ADD("@val3", dgv_1.Rows(i).Cells(3).Value) 'iFileLocation
            EDS_SQL_PARAM_ADD("@val4", EDS_USERID) 'iFileLocation
            Dim iDtx As DataTable = EDS_G_iSQL_TABLE()
            MainMenu.g_notif_panel(iDtx.Rows(0)("ERRORCODE"), iDtx.Rows(0)("MSG"), 2)
        Next
        dgv_1.Rows.Clear()
        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "39") ''select
            Dim iDt As DataTable = EDS_G_iSQL_TABLE()
            For i = 0 To iDt.Rows.Count - 1
                dgv_1.Rows.Add(dgv_1.Rows.Count + 1, iDt.Rows(i)("code"), iDt.Rows(i)("DESCRIPTION"), iDt.Rows(i)("CATEGORY"))
            Next
            DisableAllCell()
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)
            onCEllEdit = False
            cmd_cell_menu.Enabled = True
            ModuleMode = "F"

        End Sub

        Private Sub EDS_OEE_DowntimeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_1.Rows.Clear()

        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "39") ''select
        Dim iDt As DataTable = EDS_G_iSQL_TABLE()
        '  Uc_col_finder1.iDGVX = dgv_1
        '   Uc_col_finder1.iDatasetx = iDt
        For i = 0 To iDt.Rows.Count - 1
            dgv_1.Rows.Add(dgv_1.Rows.Count + 1, iDt.Rows(i)("code"), iDt.Rows(i)("DESCRIPTION"), iDt.Rows(i)("CATEGORY"))
        Next
        MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)
        DisableAllCell()
        'Uc_col_finder1.BringToFront()

    End Sub

        Sub AddMode()
            dgv_1.Rows.Insert(0, dgv_1.Rows.Count + 1, "", "")
            DisableAllCell()
            Dim iFinalRow As Integer = dgv_1.Rows.Count - 1
            WrightFinalCell(0)


            dgv_1.CurrentCell = dgv_1.Rows(0).Cells(1)
            dgv_1.Select()
            cmd_cell_menu.Enabled = False

            ModuleMode = "A"
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, False)
        End Sub

        Sub DisableAllCell()
            For i = 0 To dgv_1.Rows.Count - 1
                For ii = 0 To dgv_1.Columns.Count - 1
                    dgv_1.Rows(i).Cells(ii).ReadOnly = True
                    dgv_1.Rows(i).Cells(ii).ReadOnly = True
                    dgv_1.Rows(i).Cells(ii).ReadOnly = True
                    dgv_1.Rows(i).Cells(ii).Style.BackColor = g_colors.whiteSmoke3
                    dgv_1.Rows(i).Cells(ii).Style.BackColor = g_colors.whiteSmoke3
                    dgv_1.Rows(i).Cells(ii).Style.BackColor = g_colors.whiteSmoke3
                Next
            Next
        End Sub

        Sub WrightFinalCell(iFinalRow As Integer)
            dgv_1.Rows(iFinalRow).Cells(0).ReadOnly = True
            dgv_1.Rows(iFinalRow).Cells(0).Style.BackColor = g_colors.whiteSmoke3
            For ii = 1 To dgv_1.Columns.Count - 1
                dgv_1.Rows(iFinalRow).Cells(ii).ReadOnly = False
                dgv_1.Rows(iFinalRow).Cells(ii).Style.BackColor = g_colors.WhiteNore
            Next
        End Sub

    Private Sub dgv_1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgv_1.EditingControlShowing
        '   Uc_col_finder1.iRectanglex = dgv_1.GetCellDisplayRectangle(dgv_1.CurrentCell.ColumnIndex, dgv_1.CurrentCell.RowIndex, True) ' dgv_1.Rows(dgv_1.SelectedRows(0).Index).Cells(dgv_1.SelectedColumns(0).Index).ContentBounds
        '    Me.eidtText = DirectCast(e.Control, TextBox)

    End Sub

    'Private Sub eidtText_TextChanged(sender As Object, e As EventArgs) Handles eidtText.TextChanged

    '    If eidtText.Text <> "" Then
    '        Uc_col_finder1.Visible = True

    '        Uc_col_finder1.iText = eidtText.Text

    '        If Uc_col_finder1.iRowCoint <= 0 Then
    '            Uc_col_finder1.Visible = False
    '        End If
    '    Else
    '        Uc_col_finder1.Visible = False
    '    End If
    'End Sub
End Class