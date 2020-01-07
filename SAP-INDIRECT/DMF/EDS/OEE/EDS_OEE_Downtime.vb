Public Class EDS_OEE_Downtime
    Dim ModuleMode As String = "F"
    Dim onCEllEdit As Boolean
    Private WithEvents eidtText As TextBox
    Private WithEvents eidtText2 As TextBox
    Private WithEvents eidtText3 As TextBox
    Private WithEvents iTImeMask As MaskedTextBox
    Dim iSelectedId As Integer = 0
    Private Sub EDS_OEE_Downtime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        uc_DocNum.iIsEnabled = False
        btn_exit.Top = -50
        btn_exit2.Top = -50
        Label3.Top = -50

        dgv_planedUn.Rows.Clear()
        dgv_warehouseman.Rows.Clear()

        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "39") ''select
        Dim iDt As DataTable = EDS_G_iSQL_TABLE()
        uc_Col_find_UnplandDwn.iDGVX = dgv_planedUn
        uc_Col_find_UnplandDwn.iDatasetx = iDt
        uc_Col_find_UnplandDwn.iColumnNameSearch = "DESCRIPTION"

        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "11") ''select
        Dim iDt2 As DataTable = EDS_G_iSQL_TABLE()
        uc_col_warehouse.iDGVX = dgv_warehouseman
        uc_col_warehouse.iDatasetx = iDt2
        uc_col_warehouse.iColumnNameSearch = "NAME"

        uc_finder_user.iDGVX = dgv_planedUn
        uc_finder_user.iDatasetx = iDt2
        uc_finder_user.iColumnNameSearch = "NAME"



        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "42") ''select
        Dim iDtx As DataTable = EDS_G_iSQL_TABLE()
        For i = 0 To iDtx.Columns.Count - 1
            ADD_Column(iDtx.Columns(i).ColumnName, iDtx.Rows(0)(iDtx.Columns(i).ColumnName), i, 10, dgv_planedUn, False, False)
        Next

        Dim iColumn As DataGridViewComboBoxColumn
        iColumn = dgv_planedUn.Columns(6)
        iColumn.Items.Add("0 - Planned")
        iColumn.Items.Add("1 - Unplanned")


        dgv_planedUn.Columns(0).ContextMenuStrip = cmd_cell_menu
        dgv_warehouseman.Columns(0).ContextMenuStrip = cmd_cell_menu

        MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)
        DisableAllCell()
        uc_Col_find_UnplandDwn.BringToFront()
        uc_Col_find_UnplandDwn.iBtnExit = btn_exit
        AddMode()


    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_trig.Click
        uc_DocNum.iIsEnabled = False
        uc_totalMins.iText = ""
        iArrowsSet(False)
        Dim iProc As Boolean = True
        If ModuleMode = "A" Then
            iProc = iAdd()
            If iProc Then iExtendQry()
        ElseIf ModuleMode = "F" Then
            If iSelectDownTime(CInt(uc_DocNum.iText)) Then
                btn_trig.Text = "&Save"
                iExtendQry()
            End If
        End If

    End Sub


    Sub iExtendQry()
        If uc_status.iText = "O" Then
            iAddCell()
            btn_trig.Text = "&Save"
            ModuleMode = "A"
            iArrowsSet(True)

            uc_DocNum.iArrow_Visible = False
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, True)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, False)

        Else
            uc_status.iArrow_Visible = False
            btn_trig.Text = "F&ind"
            ModuleMode = "F"
            DisableAllCell()
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, True)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)
        End If
    End Sub

    Function iAdd() As Boolean
        Try
            textNul.Text = ""
            EDS_SQL_PARAM.Clear() ''insert
            EDS_SQL_PARAM_ADD("@SQLID", "40")

            EDS_SQL_PARAM_ADD("@val1", uc_station.iText) '
            EDS_SQL_PARAM_ADD("@val2", uc_whse.iText) '
            EDS_SQL_PARAM_ADD("@val3", uc_machine.iText) '
            EDS_SQL_PARAM_ADD("@val4", uc_status.iText) '
            EDS_SQL_PARAM_ADD("@val5", EDS_USERID) '

            Dim iRowFinal As Integer = 0 'dgv_1.Rows.Count - 1
            Dim iVal9 As String = ""
            Dim iVal11 As String = ""
            Dim iVal12 As String = ""
            Dim iVal16 As String = ""
            Dim iVal17 As String = ""

            If IsNothing(dgv_planedUn.Rows(iRowFinal).Cells(5).Value) Then
                iVal9 = ""
            Else
                iVal9 = dgv_planedUn.Rows(iRowFinal).Cells(5).Value
            End If
            If IsNothing(dgv_planedUn.Rows(iRowFinal).Cells(6).Value) Then
                iVal11 = ""
            Else
                iVal11 = dgv_planedUn.Rows(iRowFinal).Cells(6).Value
            End If


            If IsNothing(dgv_warehouseman.Rows(0).Cells(1).Value) Then
                iVal12 = ""
            Else
                iVal12 = dgv_warehouseman.Rows(0).Cells(1).Value
            End If


            If IsNothing(dgv_planedUn.Rows(0).Cells(6).Value) Then
                iVal16 = ""
            Else
                iVal16 = dgv_planedUn.Rows(0).Cells(6).Value
            End If


            If IsNothing(dgv_planedUn.Rows(0).Cells(7).Value) Then
                iVal17 = ""
            Else
                iVal17 = dgv_planedUn.Rows(0).Cells(7).Value
            End If



            EDS_SQL_PARAM_ADD("@linenum", dgv_planedUn.Rows(iRowFinal).Cells(0).Value) ' 
            EDS_SQL_PARAM_ADD("@val6", dgv_planedUn.Rows(iRowFinal).Cells(1).Value) ' 
            EDS_SQL_PARAM_ADD("@val7", dgv_planedUn.Rows(iRowFinal).Cells(3).Value) ' 
            EDS_SQL_PARAM_ADD("@val8", dgv_planedUn.Rows(iRowFinal).Cells(4).Value) ' 
            EDS_SQL_PARAM_ADD("@val9", iVal9) ' 
            EDS_SQL_PARAM_ADD("@val10", EDS_USERID) ' 
            EDS_SQL_PARAM_ADD("@val11", iVal11) ' 
            EDS_SQL_PARAM_ADD("@val12", iVal12) ' 


            EDS_SQL_PARAM_ADD("@val13", uc_shift.iText) ' shift
            EDS_SQL_PARAM_ADD("@val14", Uc_time1.iDate.TimeOfDay.ToString.Substring(0, 8)) ' timestart
            EDS_SQL_PARAM_ADD("@val15", Uc_time2.iDate.TimeOfDay.ToString.Substring(0, 8)) ' timeEnd
            If iVal16.Length > 0 Then
                iVal16 = iVal16.Substring(0, 1)
            Else
                iVal16 = ""
            End If
            EDS_SQL_PARAM_ADD("@val16", iVal16) ' type
            EDS_SQL_PARAM_ADD("@val17", iVal17) ' UID

            EDS_SQL_PARAM_ADD("@IDENTITY", CInt(uc_DocNum.iText)) ' 

            Dim iDtx As DataTable = EDS_G_iSQL_TABLE()

            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)
            onCEllEdit = False
            cmd_cell_menu.Enabled = True
            If CInt(iDtx.Rows(0)("ERRORCODE")) = 1 Then
                If iSelectedId = 0 Then iSelectDownTime(iDtx.Rows(0)("IDENTITY"))
                If iSelectedId <> 0 Then iSelectDownTime(iSelectedId)
                DisableAllCell()
                MainMenu.g_notif_panel(iDtx.Rows(0)("ERRORCODE"), iDtx.Rows(0)("MSG"), 2)
                Return True
            Else

                MainMenu.g_notif_panel(iDtx.Rows(0)("ERRORCODE"), iDtx.Rows(0)("MSG"), 2)
                iArrowsSet(True)
                Return False
            End If
            ModuleMode = "A"
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
            Return False
        End Try
    End Function
    Sub iArrowsSet(isVisible As Boolean)
        uc_station.iArrow_Visible = isVisible
        uc_whse.iArrow_Visible = isVisible
        uc_machine.iArrow_Visible = isVisible
        uc_status.iArrow_Visible = isVisible
        uc_shift.iArrow_Visible = isVisible
    End Sub
    Sub iClear()
        dgv_planedUn.Rows.Clear()
        dgv_warehouseman.Rows.Clear()
        dgv_planedUn.Columns(0).Width = 50
        dgv_planedUn.Columns(1).Width = 100
        dgv_planedUn.Columns(2).Width = 250
        dgv_planedUn.Columns(3).Width = 70
        dgv_planedUn.Columns(4).Width = 70
        dgv_planedUn.Columns(5).Width = 70

        uc_station.iText = ""
        uc_station_lbl.iText = ""
        uc_whse.iText = ""
        uc_whse_lbl.iText = ""
        uc_machine.iText = ""
        uc_machine_lbl.iText = ""
        uc_DocNum.iText = ""
        uc_status.iText = ""
        uc_status_lbl.iText = ""
        uc_shift.iText = ""
        uc_shift_lbl.iText = ""



        uc_postedBy.iText = ""
        uc_postedBy_lbl.iText = ""

    End Sub

    Sub FindMode()
        iClear()
        uc_DocNum.iArrow_Visible = True
        iArrowsSet(False)
        btn_trig.Text = "F&ind"
        ModuleMode = "F"
        uc_DocNum.iIsEnabled = True
        uc_DocNum.Textbox.Select()


        MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, False)
        MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)
    End Sub

    Sub AddMode()
        uc_DocNum.iArrow_Visible = False
        iClear()
        iArrowsSet(True)
        btn_trig.Text = "&Save"
        dgv_planedUn.Rows.Insert(0, dgv_planedUn.Rows.Count + 1, "", "", "0000", "0000")
        dgv_warehouseman.Rows.Insert(0, dgv_warehouseman.Rows.Count + 1, "")
        Try
            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "43") ''select
            Dim iDtx As DataTable = EDS_G_iSQL_TABLE()
            If IsNumeric(iDtx.Rows(0)("ID")) Then
                uc_DocNum.iText = iDtx.Rows(0)("ID")
            Else
                uc_DocNum.iText = 1
            End If
        Catch ex As Exception

        End Try

        uc_mainDateDone.iDate = Now
        uc_time.iDate = Now

        uc_status.iText = "O"
        uc_status_lbl.iText = "OPEN"



        If Now.TimeOfDay.TotalMinutes > 420 And Now.TimeOfDay.TotalMinutes < 1140 Then
            uc_shift.iText = "1"
            uc_shift_lbl.iText = "1ST SHIFT"
        Else
            uc_shift.iText = "2"
            uc_shift_lbl.iText = "2ND SHIFT"
        End If

        uc_postedBy.iText = EDS_USERID
        uc_postedBy_lbl.iText = EDS_USER_FULLNAME





        dgv_planedUn.CurrentCell = dgv_planedUn.Rows(0).Cells(2)
        dgv_planedUn.Select()
        cmd_cell_menu.Enabled = False

        ModuleMode = "A"


        DisableAllCell()
        Dim iFinalRow As Integer = dgv_planedUn.Rows.Count - 1
        WrightFinalCell(0, dgv_planedUn)

        DisableSeelctedCell(iFinalRow, 5, dgv_planedUn)
        AbleSeelctedCell(0, 2, dgv_warehouseman)
        MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, True)
        MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, False)
    End Sub

    Sub DisableAllCell()
        For i = 0 To dgv_planedUn.Rows.Count - 1
            For ii = 0 To dgv_planedUn.Columns.Count - 1
                dgv_planedUn.Rows(i).Cells(ii).ReadOnly = True
                dgv_planedUn.Rows(i).Cells(ii).Style.BackColor = g_colors.whiteSmoke3

            Next
        Next
        For i = 0 To dgv_warehouseman.Rows.Count - 1
            For ii = 0 To dgv_warehouseman.Columns.Count - 1
                dgv_warehouseman.Rows(i).Cells(ii).ReadOnly = True
                dgv_warehouseman.Rows(i).Cells(ii).Style.BackColor = g_colors.whiteSmoke3

            Next
        Next
    End Sub

    Sub WrightFinalCell(iFinalRow As Integer, dgv As DataGridView)

        If dgv.Rows.Count > 0 Then
            dgv.Rows(iFinalRow).Cells(0).ReadOnly = True
            dgv.Rows(iFinalRow).Cells(0).Style.BackColor = g_colors.whiteSmoke3
            For ii = 2 To dgv.Columns.Count - 1
                dgv.Rows(iFinalRow).Cells(ii).ReadOnly = False
                dgv.Rows(iFinalRow).Cells(ii).Style.BackColor = g_colors.WhiteNore
            Next
        End If


    End Sub

    Sub DisableSeelctedCell(ROW As Integer, CELL As Integer, dgv As DataGridView)

        If dgv.Rows.Count > 0 Then
            dgv.Rows(ROW).Cells(CELL).ReadOnly = True
            dgv.Rows(ROW).Cells(CELL).Style.BackColor = g_colors.whiteSmoke3
        End If
    End Sub


    Sub AbleSeelctedCell(ROW As Integer, CELL As Integer, dgv As DataGridView)
        If dgv.Rows.Count > 0 Then
            dgv.Rows(ROW).Cells(CELL).ReadOnly = False
            dgv.Rows(ROW).Cells(CELL).Style.BackColor = g_colors.WhiteNore
        End If
    End Sub

    Private Sub dgv_1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgv_planedUn.EditingControlShowing
        If dgv_planedUn.CurrentCell.ColumnIndex = 2 Then
            uc_Col_find_UnplandDwn.iRectanglex = dgv_planedUn.GetCellDisplayRectangle(dgv_planedUn.CurrentCell.ColumnIndex, dgv_planedUn.CurrentCell.RowIndex, True) ' dgv_1.Rows(dgv_1.SelectedRows(0).Index).Cells(dgv_1.SelectedColumns(0).Index).ContentBounds
            Me.eidtText = DirectCast(e.Control, TextBox)
        End If
        If dgv_planedUn.CurrentCell.ColumnIndex = 8 Then
            uc_finder_user.iRectanglex = dgv_planedUn.GetCellDisplayRectangle(dgv_planedUn.CurrentCell.ColumnIndex, dgv_planedUn.CurrentCell.RowIndex, True) ' dgv_1.Rows(dgv_1.SelectedRows(0).Index).Cells(dgv_1.SelectedColumns(0).Index).ContentBounds
            Me.eidtText3 = DirectCast(e.Control, TextBox)
        End If
    End Sub

    Private Sub eidtText_KeyUp(sender As Object, e As KeyEventArgs) Handles eidtText.KeyUp

        Dim iCurCol As Integer = dgv_planedUn.CurrentCell.ColumnIndex
        Dim iCurRow As Integer = dgv_planedUn.CurrentCell.RowIndex
        If iCurCol = 2 Then
            If eidtText.Text <> "" Then
                uc_Col_find_UnplandDwn.Visible = True
                uc_Col_find_UnplandDwn.iText = eidtText.Text
                uc_Col_find_UnplandDwn.iDgvCell1x = dgv_planedUn.Rows(0).Cells(1)
                uc_Col_find_UnplandDwn.iDgvCell2x = dgv_planedUn.Rows(0).Cells(2)
                If uc_Col_find_UnplandDwn.iRowCoint <= 0 Then
                    uc_Col_find_UnplandDwn.Visible = False
                End If
            Else
                uc_Col_find_UnplandDwn.Visible = False
            End If
        End If

    End Sub



    Private Sub eidtText2_KeyUp(sender As Object, e As KeyEventArgs) Handles eidtText2.KeyUp

        Dim iCurCol As Integer = dgv_warehouseman.CurrentCell.ColumnIndex
        Dim iCurRow As Integer = dgv_warehouseman.CurrentCell.RowIndex
        If iCurCol = 2 Then
            If eidtText2.Text <> "" Then
                uc_col_warehouse.Visible = True

                uc_col_warehouse.iText = eidtText2.Text
                uc_col_warehouse.iDgvCell1x = dgv_warehouseman.Rows(0).Cells(1)
                uc_col_warehouse.iDgvCell2x = dgv_warehouseman.Rows(0).Cells(2)
                If uc_col_warehouse.iRowCoint <= 0 Then
                    uc_col_warehouse.Visible = False
                End If
            Else
                uc_col_warehouse.Visible = False
            End If
        End If

    End Sub

    Private Sub eidtText3_KeyUp(sender As Object, e As KeyEventArgs) Handles eidtText3.KeyUp

        Dim iCurCol As Integer = dgv_planedUn.CurrentCell.ColumnIndex
        Dim iCurRow As Integer = dgv_planedUn.CurrentCell.RowIndex
        If iCurCol = 8 Then
            If eidtText3.Text <> "" Then
                uc_finder_user.Visible = True

                uc_finder_user.iText = eidtText3.Text
                uc_finder_user.iDgvCell1x = dgv_planedUn.Rows(0).Cells(7)
                uc_finder_user.iDgvCell2x = dgv_planedUn.Rows(0).Cells(8)
                If uc_finder_user.iRowCoint <= 0 Then
                    uc_finder_user.Visible = False
                End If
            Else
                uc_finder_user.Visible = False
            End If
        End If

    End Sub


    Private Sub eidtText_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles eidtText.PreviewKeyDown
        Try
            If (e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab) And uc_Col_find_UnplandDwn.Visible Then
                dgv_planedUn.Rows(dgv_planedUn.CurrentCell.RowIndex).Cells(1).Value = CStr(uc_Col_find_UnplandDwn.dgv_1.SelectedRows(0).Cells(0).Value)
                eidtText.Text = CStr(uc_Col_find_UnplandDwn.dgv_1.SelectedRows(0).Cells(1).Value)
                uc_Col_find_UnplandDwn.Visible = False
            End If
        Catch ex As Exception
        End Try
    End Sub



    Private Sub eidtText3_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles eidtText3.PreviewKeyDown
        Try
            If (e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab) And uc_finder_user.Visible Then
                dgv_planedUn.Rows(dgv_planedUn.CurrentCell.RowIndex).Cells(7).Value = CStr(uc_finder_user.dgv_1.SelectedRows(0).Cells(0).Value)
                eidtText3.Text = CStr(uc_finder_user.dgv_1.SelectedRows(0).Cells(1).Value)
                uc_finder_user.Visible = False
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub eidtText2_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles eidtText2.PreviewKeyDown
        Try
            If (e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab) And uc_Col_find_UnplandDwn.Visible Then
                dgv_planedUn.Rows(dgv_planedUn.CurrentCell.RowIndex).Cells(1).Value = CStr(uc_Col_find_UnplandDwn.dgv_1.SelectedRows(0).Cells(0).Value)
                eidtText.Text = CStr(uc_Col_find_UnplandDwn.dgv_1.SelectedRows(0).Cells(1).Value)
                uc_Col_find_UnplandDwn.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgv_1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_planedUn.CellValueChanged

        Dim iCurCol As Integer = dgv_planedUn.CurrentCell.ColumnIndex
        Dim iCurRow As Integer = dgv_planedUn.CurrentCell.RowIndex

        If iCurCol = 3 Or iCurCol = 4 Then
            Try
                Dim iTime1 As String = dgv_planedUn.Rows(iCurRow).Cells(3).Value
                Dim iTime2 As String = dgv_planedUn.Rows(iCurRow).Cells(4).Value
                iTime1 = iTime1.Insert(2, ":")
                iTime2 = iTime2.Insert(2, ":")

                Dim date1 As DateTime = ("01/01/2020 " & iTime1 & ":00")


                Dim date2 As DateTime = ("01/01/2020 " & iTime2 & ":00")
                If date1 > date2 Then date2 = ("01/02/2020 " & iTime2 & ":00")


                dgv_planedUn.Rows(iCurRow).Cells(5).Value = (date2 - date1).TotalMinutes
            Catch ex As Exception
                dgv_planedUn.Rows(iCurRow).Cells(5).Value = "Time Error"
            End Try
        End If

    End Sub
    Sub iAddCell()
        ModuleMode = "A"

        dgv_planedUn.Rows.Insert(0, dgv_planedUn.Rows.Count + 1, "", "", "0000", "0000")
        dgv_warehouseman.Rows.Insert(0, dgv_warehouseman.Rows.Count + 1, "")
        DisableAllCell()

        dgv_planedUn.CurrentCell = dgv_planedUn.Rows(0).Cells(2)
        dgv_planedUn.Select()
        cmd_cell_menu.Enabled = False

        uc_Col_find_UnplandDwn.iDgvCell1x = dgv_planedUn.Rows(0).Cells(1)
        uc_Col_find_UnplandDwn.iDgvCell2x = dgv_planedUn.Rows(0).Cells(2)
        WrightFinalCell(0, dgv_planedUn)

        Dim iFinalRow As Integer = dgv_planedUn.Rows.Count - 1
        Dim iFinalRow2 As Integer = dgv_planedUn.Rows.Count - 1
        WrightFinalCell(0, dgv_planedUn)
        AbleSeelctedCell(0, 2, dgv_warehouseman)
        DisableSeelctedCell(iFinalRow, 5, dgv_planedUn)
    End Sub

    Function iSelectDownTime(DocEntry As Integer) As Boolean
        Try
            dgv_planedUn.Rows.Clear()
            dgv_warehouseman.Rows.Clear()
            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "44") ''select
            EDS_SQL_PARAM_ADD("@val1", DocEntry) ''select
            Dim iDtx As DataTable = EDS_G_iSQL_TABLE()
            If iDtx.Rows.Count > 0 Then
                uc_station.iText = iDtx.Rows(0)("sCODE")
                uc_station_lbl.iText = iDtx.Rows(0)("sName")

                uc_whse.iText = iDtx.Rows(0)("wCODE")
                uc_whse_lbl.iText = iDtx.Rows(0)("wName")

                uc_machine.iText = iDtx.Rows(0)("mCODE")
                uc_machine_lbl.iText = iDtx.Rows(0)("mName")

                uc_status.iText = iDtx.Rows(0)("status")
                uc_status_lbl.iText = iDtx.Rows(0)("statusLBL")

                uc_postedBy.iText = iDtx.Rows(0)("createdBy")
                uc_postedBy_lbl.iText = iDtx.Rows(0)("createdByName")

                uc_mainDateDone.iDate = iDtx.Rows(0)("createdDate")
                uc_time.iDate = iDtx.Rows(0)("createdTime")

                Dim iDate1 As DateTime = ("01/01/2020 " & iDtx.Rows(0)("timeStart"))
                Dim iDate2 As DateTime = ("01/01/2020 " & iDtx.Rows(0)("timeEnd"))
                Uc_time1.iDate = iDate1
                Uc_time2.iDate = iDate2
                uc_shift.iText = iDtx.Rows(0)("shift")
                uc_shift_lbl.iText = iDtx.Rows(0)("shiftName")

                Dim totalDwntime As Integer = 0
                For i = 0 To iDtx.Rows.Count - 1
                    If IsDBNull(iDtx.Rows(i)(dgv_planedUn.Columns(0).Name)) = False Then
                        dgv_planedUn.Rows.Add()
                        For ii = 0 To dgv_planedUn.Columns.Count - 1
                            'If ii = 5 Then
                            '    Dim iCol As DataGridViewComboBoxCell = dgv_planedUn.Rows(i).Cells(ii)
                            '    iCol.Items(0)
                            'Else
                            dgv_planedUn.Rows(i).Cells(ii).Value = iDtx.Rows(i)(dgv_planedUn.Columns(ii).Name)
                            ' End If
                        Next
                        If IsNumeric(dgv_planedUn.Rows(i).Cells(5).Value) Then totalDwntime = totalDwntime + CInt(dgv_planedUn.Rows(i).Cells(5).Value)
                    End If
                Next
                EDS_SQL_PARAM.Clear()
                EDS_SQL_PARAM_ADD("@SQLID", "47") ''select
                EDS_SQL_PARAM_ADD("@val1", DocEntry) ''select
                Dim iDtxx As DataTable = EDS_G_iSQL_TABLE()
                For i = 0 To iDtxx.Rows.Count - 1
                    If IsDBNull(iDtxx.Rows(i)(dgv_warehouseman.Columns(0).Name)) = False Then
                        dgv_warehouseman.Rows.Add()
                        For ii = 0 To dgv_warehouseman.Columns.Count - 1
                            dgv_warehouseman.Rows(i).Cells(ii).Value = iDtxx.Rows(i)(dgv_warehouseman.Columns(ii).Name)
                        Next
                    End If
                Next

                uc_totalMins.iText = totalDwntime & " Mins"
                Dim iFinalRow As Integer = dgv_planedUn.Rows.Count - 1
                WrightFinalCell(0, dgv_planedUn)
                DisableSeelctedCell(iFinalRow, 5, dgv_planedUn)
                Return True
            Else
                MainMenu.g_notif_panel(0, "101 - No record found!", 2)
                Return False
            End If

        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
            Return False
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        uc_Col_find_UnplandDwn.Visible = False
    End Sub

    Private Sub dgv_warehouseman_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgv_warehouseman.EditingControlShowing
        If dgv_warehouseman.CurrentCell.ColumnIndex = 2 Then
            uc_col_warehouse.iRectanglex = dgv_warehouseman.GetCellDisplayRectangle(dgv_warehouseman.CurrentCell.ColumnIndex, dgv_warehouseman.CurrentCell.RowIndex, True) ' dgv_1.Rows(dgv_1.SelectedRows(0).Index).Cells(dgv_1.SelectedColumns(0).Index).ContentBounds
            Me.eidtText2 = DirectCast(e.Control, TextBox)
        End If
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_exit2.Click
        uc_col_warehouse.Visible = False
    End Sub


    Private Sub dgv_warehouseman_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btn_timeCalc_Click(sender As Object, e As EventArgs) Handles btn_timeCalc.Click

        If uc_shift.iText = "1" Or uc_shift.iText = "2" Then
            Dim iMins1 As Double
            iMins1 = Uc_time1.iDate.TimeOfDay.TotalMinutes

            iMins1 = iMins1 + 720
            Dim inewTime As TimeSpan = TimeSpan.FromMinutes(iMins1)
            Dim iExNewTime() As String = Split(inewTime.ToString, ".")
            Dim iNewDate As DateTime
            If iExNewTime(0) = "1" Then
                iNewDate = ("01/01/2020 " & iExNewTime(1))
            Else
                iNewDate = ("01/01/2020 " & iExNewTime(0))
            End If
            Uc_time2.iDate = iNewDate
        Else
            Uc_time2.iDate = Uc_time1.iDate
        End If

    End Sub

    Private Sub btn_exit3_Click(sender As Object, e As EventArgs) Handles btn_exit3.Click
        uc_finder_user.Visible = False
    End Sub

    Private Sub dgv_planedUn_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_planedUn.CellContentClick

    End Sub
End Class
