Imports System.IO
Imports System.Reflection
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared



Public Class Proration

    Dim iIsCreated1 As Boolean = False
    Dim dgv_selected As DataGridView
    Dim s_row As Integer
    Dim s_col As Integer
    Private WithEvents eidtText As TextBox
    Dim transaction_type As Char = "A"
    Dim iSelectMode As Boolean = False
    Dim maxItq As List(Of Integer)
    Private Sub Proration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel4.Dock = DockStyle.Fill
        Panel5.Dock = DockStyle.Fill

        MainTab.SelectedIndex = 0
        dgv_Variant.BringToFront()
        SplitContainer1.SplitterDistance = 0
        MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)
        MainMenu.btn_menu_add.PerformClick()
        '   txt_prorationType.Text = "SFG0000006"
    End Sub

    Private Sub Proration_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        '   If (txt_remarks.Left + txt_remarks.Width + 20) < (Panel1.Left) Then Panel1.Left = 843
    End Sub



    Private Sub lbl_itemcode_dsc_TextChanged(sender As Object, e As EventArgs)
        '   iSQL_SELECT_PROD_SELECTION()

    End Sub

    Sub iSQL_SELECT_PROD_SELECTION()
        Try
            'Dim iAdditionAlSQL As String = ""
            'For i = 0 To dgv_Variant.Rows.Count - 1
            '    iAdditionAlSQL = dgv_Variant.Rows(i).Cells(1).Value + "," + iAdditionAlSQL
            'Next
            'If iAdditionAlSQL.Length > 0 Then iAdditionAlSQL = iAdditionAlSQL.Substring(0, iAdditionAlSQL.Length - 1)
            'G_iSQL_PARAMETERS.Add(UC_itemcode.iText.ToString)
            'G_iSQL_PARAMETERS.Add(dtp_from.Value)
            'G_iSQL_PARAMETERS.Add(dtp_To.Value)
            ' G_iSQL_PARAMETERS.Add(iAdditionAlSQL)1
            iSQL_selector(101, dgv_CheckSelection, True, 1)
            ''            For i = 1 To dgv_CheckSelection.Rows.Count
            'ADD_Column(" + ", 2, 0, " ~ ", 1, 15, dgv_CheckSelection, True)
            ''        Next 
            'dgv_CheckSelection.Columns(0).Width = 25

        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 1)
            G_iSQL_PARAMETERS.Clear()
        End Try
    End Sub

    Private Sub dtp_from_ValueChanged(sender As Object, e As EventArgs)
        iSQL_SELECT_PROD_SELECTION()
    End Sub

    Private Sub dtp_To_ValueChanged(sender As Object, e As EventArgs)
        iSQL_SELECT_PROD_SELECTION()
    End Sub

    Private Sub dgv_CheckSelection_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_CheckSelection.CellContentClick
        If dgv_Variant.Rows.Count < 5 Then

            Try
                Dim senderGrid = DirectCast(sender, DataGridView)
                iSQL_SELECT_VARIANT(dgv_CheckSelection.Rows(e.RowIndex).Cells(1).Value.ToString, dgv_Variant)
                iRemove_SElected_DGV_Variant()
                '  iSQL_GET_MATERIAL_SUMMARY()
                ' iSQL_GET_PRE_PRORATION()

            Catch ex As Exception
                MainMenu.g_notif_panel(0, "" + ex.ToString, 2)
            End Try
        End If

    End Sub

    Sub iRemove_SElected_DGV_Variant()
        Batches.Clear()
        ADD_Column_ARROW_REMOVE(dgv_FG)
        ADD_Column_ARROW_REMOVE(dgv_sfg)
        dgv_sfg.Columns.Clear()
        dgv_FG.Columns.Clear()

        Dim iloadCount As Integer = 0
        Dim incr As Integer = 5
        iloadCount = iloadCount + incr
        iLoad_bar(iloadCount, True)

        MainTab.SelectedIndex = 1
        iSQL_GET_MATERIAL_SUMMARYSFG() '>>>>>>>>>>>>>> GET SFG


        iloadCount = iloadCount + incr
        iLoad_bar(iloadCount, True)

        If dgv_sfg.Rows.Count > 0 Then
            ADD_Column_ARROW(" - ", 1, 7, "BATCH DETAILS", 1, 15, dgv_sfg, True, "1", 1, 5, 4, 8, 1, 12, "SFG")

            iloadCount = iloadCount + incr
            iLoad_bar(iloadCount, True)

            ADD_Column("Status", 1, dgv_sfg.Columns.Count, "Status", "Status", 80, dgv_sfg, True)
            AutoBatchx(dgv_sfg)

            iloadCount = iloadCount + incr
            iLoad_bar(iloadCount, True)

            'dgv_Variant

            iloadCount = iloadCount + incr
            iLoad_bar(iloadCount, True)
        End If


        MainTab.SelectedIndex = 2
        iSQL_GET_MATERIAL_SUMMARY()
        iloadCount = iloadCount + incr
        iLoad_bar(iloadCount, True)
        If dgv_FG.Rows.Count > 0 Then
            ADD_Column_ARROW(" - ", 1, 7, "BATCH DETAILS", 1, 15, dgv_FG, True, "1", 1, 5, 4, 8, 1, 12, "FG")

            iloadCount = iloadCount + incr
            iLoad_bar(iloadCount, True)


            ADD_Column("Status", 1, dgv_FG.Columns.Count, "Status", "Status", 80, dgv_FG, True)
            AutoBatchx(dgv_FG)

            iloadCount = iloadCount + incr
            iLoad_bar(iloadCount, True)
        End If

        MainTab.SelectedIndex = 3

        iLoad_bar(0, False)

        MainTab.SelectedIndex = 0

        '     MainMenu.g_notif_panel(0, iloadCount.ToString, 2)
        Panel4.Visible = False
        Panel5.Visible = False
    End Sub

    Sub iSQL_SELECT_VARIANT(ByRef productionNumber As String, ByRef DataGridView As DataGridView)
        Try

            DataGridView.Rows.Clear()
            DataGridView.Columns.Clear()
            If DataGridView.Columns.Count > 0 Then
                If (TypeOf DataGridView.Columns(0) Is DataGridViewButtonColumn) = True Then
                    DataGridView.Columns.RemoveAt(0)
                End If
            End If
            G_iSQL_PARAMETERS.Clear()
            G_iSQL_PARAMETERS.Add(productionNumber)
            iSQL_selector(102, DataGridView, False, 2)
            If DataGridView.Columns.Count > 0 Then
                If (TypeOf DataGridView.Columns(0) Is DataGridViewButtonColumn) = False Then
                    ADD_Column(" - ", 2, 0, " ~ ", 2, 15, DataGridView, True)
                    DataGridView.Columns(0).Width = 25
                End If

            End If

        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.ToString, 1)
            G_iSQL_PARAMETERS.Clear()
        End Try
    End Sub




    Private Sub dgv_Variant_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Variant.CellContentClick
        Try
            Dim senderGrid = DirectCast(sender, DataGridView)
            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
                dgv_Variant.Rows.RemoveAt(e.RowIndex)
                iRemove_SElected_DGV_Variant()
                iRemoveSFG_IN_Batch()
                'iSQL_GET_MATERIAL_SUMMARYSFG()
                ' iSQL_GET_MATERIAL_SUMMARYSFG()
            End If
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.ToString, 2)
        End Try

    End Sub


    Sub iSQL_GET_MATERIAL_SUMMARY()
        If dgv_Variant.Rows.Count > 0 Then
            Try
                Dim iSQLPARAM As String = ""
                For i = 0 To dgv_Variant.Rows.Count - 1
                    iSQLPARAM = dgv_Variant.Rows(i).Cells(1).Value.ToString & "," & iSQLPARAM
                Next
                iSQLPARAM.Trim()

                iSQLPARAM = iSQLPARAM.TrimEnd(CChar(","))
                G_iSQL_PARAMETERS.Clear()
                G_iSQL_PARAMETERS.Add(iSQLPARAM)
                iSQL_selector(125, dgv_FG, True, 3)
                '  /* ADD 3 TYPES OF REJECTS */ 
                ''   ADD_Column(" - ", 1, 4, "Formula Adj", 1, 15, dgv_FG, True)
                '   ADD_Column(" - ", 1, 4, "Reject", 1, 15, dgv_FG, True)
                '   ADD_Column(" - ", 1, 4, "NTSSQty", 1, 15, dgv_FG, True)

                'For i = 0 To dgv_FG.Rows.Count - 1
                '    dgv_FG.Rows(i).Cells(4).Value = 0
                '    dgv_FG.Rows(i).Cells(5).Value = 0
                '    dgv_FG.Rows(i).Cells(6).Value = 0
                '    '    dgv_material_usage.Rows(i).Cells(11).Value = ""
                'Next
                ADD_Column(" - ", 1, dgv_FG.Columns.Count, "Remarks", 1, 15, dgv_FG, False)

            Catch ex As Exception
                MainMenu.g_notif_panel(0, "121 - " & ex.Message, 2)
            End Try
        Else
            dgv_FG.Rows.Clear()
        End If

    End Sub


    Sub iSQL_GET_MATERIAL_SUMMARYSFG()
        If dgv_Variant.Rows.Count > 0 Then


            Try
                Dim iSQLPARAM As String = ""
                For i = 0 To dgv_Variant.Rows.Count - 1
                    iSQLPARAM = dgv_Variant.Rows(i).Cells(1).Value.ToString & "," & iSQLPARAM
                Next
                iSQLPARAM.Trim()

                iSQLPARAM = iSQLPARAM.TrimEnd(CChar(","))
                G_iSQL_PARAMETERS.Clear()
                G_iSQL_PARAMETERS.Add(iSQLPARAM)
                iSQL_selector(124, dgv_sfg, True, 3)
                '  /* ADD 3 TYPES OF REJECTS */ 
                '  ADD_Column(" - ", 1, 4, "Formula Adj", 1, 15, dgv_sfg, True)
                '  ADD_Column(" - ", 1, 4, "Reject", 1, 15, dgv_sfg, True)
                '  ADD_Column(" - ", 1, 4, "NTSSQty", 1, 15, dgv_sfg, True)

                'For i = 0 To dgv_sfg.Rows.Count - 1
                '    dgv_sfg.Rows(i).Cells(4).Value = 0
                '    dgv_sfg.Rows(i).Cells(5).Value = 0
                '    dgv_sfg.Rows(i).Cells(6).Value = 0
                '    '    dgv_material_usage.Rows(i).Cells(11).Value = ""
                'Next
                ADD_Column(" - ", 1, dgv_sfg.Columns.Count, "Remarks", 1, 15, dgv_sfg, False)


            Catch ex As Exception
                MainMenu.g_notif_panel(0, "121 - " & ex.Message, 2)
            End Try
        Else
            dgv_sfg.Rows.Clear()
        End If
    End Sub

    Sub iSQL_GET_PRE_PRORATION()
        If dgv_Variant.Rows.Count > 0 Then
            Try
                Dim iSQLPARAM As String = ""
                For i = 0 To dgv_Variant.Rows.Count - 1
                    iSQLPARAM = dgv_Variant.Rows(i).Cells(1).Value.ToString & "," & iSQLPARAM
                Next
                iSQLPARAM.Trim()
                iSQLPARAM = iSQLPARAM.TrimEnd(CChar(","))
                G_iSQL_PARAMETERS.Clear()
                G_iSQL_PARAMETERS.Add(iSQLPARAM)
                iSQL_selector(116, dgv_Proration, True, 3)

                For i = dgv_Proration.Columns.Count + 1 To 9
                    ADD_Column(" ", 1, dgv_Proration.Columns.Count - 3, " ", 1, 15, dgv_Proration, True)
                Next
            Catch ex As Exception
                MainMenu.g_notif_panel(0, ex.Message, 2)
            End Try
        Else
            dgv_FG.Rows.Clear()
        End If

    End Sub

    Sub EditableColumn(ByRef DataG_C As DataGridViewColumn)
        DataG_C.ReadOnly = False
    End Sub
    Private Sub dgv_material_usage_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgv_FG.EditingControlShowing
        Me.eidtText = DirectCast(e.Control, TextBox)
        ' 
        s_row = dgv_FG.CurrentCell.RowIndex
        s_col = dgv_FG.CurrentCell.ColumnIndex
    End Sub
    Private Sub dgv_material_usage_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_FG.CellEndEdit
        Me.eidtText = Nothing
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Panel4.Visible = True
        Panel5.Visible = True
        If transaction_type = "A" Then
            G_iHAVE_ERROR_IN_TRANSACTION = False
            ' oCompany.StartTransaction()
            If iErrorCheck() = False Then
                iCreate2()
                iSQL_GET_PRE_PRORATION()
                iCreate()
                AddMode()
            Else
                MainMenu.g_notif_panel(0, "Please check your inputs", 2)
            End If

        End If
        If transaction_type = "F" Then iFind()
        Panel4.Visible = False
        Panel5.Visible = False
    End Sub

    Sub iFind()
        Batches.Clear()
        ADD_Column_ARROW_REMOVE(dgv_FG)
        ADD_Column_ARROW_REMOVE(dgv_sfg)

        iClear()


        Dim iProRateType As String = ""
        crvwr.Visible = True
        Dim iRs As SAPbobsCOM.Recordset
        iRs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        iRs.DoQuery("EXEC spDMF_DI001 113 , '" & uc_prorationNum.iText & "'")
        Do While iRs.EoF = False
            uc_prorationType.iText = iRs.Fields.Item("U_ProrationType").Value
            uc_prorationLbl.iText = iRs.Fields.Item("U_ProrationTypeName").Value
            iProRateType = iRs.Fields.Item("U_ProrationType").Value
            uc_warehouse.iText = iRs.Fields.Item("U_WhseCode").Value
            UC_warehouselabel.iText = iRs.Fields.Item("WhsName").Value

            txt_remarks.Text = iRs.Fields.Item("U_remarks").Value

            uc_createdBy.iText = iRs.Fields.Item("Creator").Value

            uc_CreatedDate.iDate = iRs.Fields.Item("U_DocDate").Value
            Uc_PostingDate.iDate = iRs.Fields.Item("CreateDate").Value
            iRs.MoveNext()
        Loop


        G_iSQL_PARAMETERS.Add(uc_prorationNum.iText.ToString)
        iSQL_selector(114, dgv_Variant, True, 2)

        Dim iSQLPARAM As String = ""
        For i = 0 To dgv_Variant.Rows.Count - 1
            iSQLPARAM = dgv_Variant.Rows(i).Cells(0).Value.ToString & "," & iSQLPARAM
        Next
        iSQLPARAM.Trim()

        iSQLPARAM = iSQLPARAM.TrimEnd(CChar(","))
        G_iSQL_PARAMETERS.Clear()
        G_iSQL_PARAMETERS.Add(iSQLPARAM)

        G_iSQL_PARAMETERS.Clear()
        G_iSQL_PARAMETERS.Add(iSQLPARAM)
        iSQL_selector(136, dgv_sfg, True, 2)

        G_iSQL_PARAMETERS.Clear()
        G_iSQL_PARAMETERS.Add(iSQLPARAM)
        iSQL_selector(139, dgv_FG, True, 2)



        Dim crystalReport As New ReportDocument()
        If iProRateType = "TS" Then
            crystalReport.Load(G_iAPP_PATH_REPORTS & "\Proration\Proration - TP.rpt")
        Else
            crystalReport.Load(G_iAPP_PATH_REPORTS & "\Proration\Proration - SR.rpt")
        End If
        g_cryReportSetDB(crystalReport)
        crystalReport.SetParameterValue(0, uc_prorationNum.iText)
        crvwr.ReportSource = crystalReport

    End Sub

    Sub iCreate2()
        Try



            For ii = 0 To dgv_sfg.Rows.Count - 1


                If dgv_sfg.Rows(ii).Cells(15).Value = "Open" Then


                    Dim iIssueToProd As SAPbobsCOM.Documents
                    iIssueToProd = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenExit)

                    iIssueToProd.Series = 20
                    iIssueToProd.DocDate = Now  '>> POSTRING DATE
                    iIssueToProd.BPL_IDAssignedToInvoice = 1 '>> BRANCH

                    Dim iLineCount = 0
                    Dim iRowBatchCouter As Integer = 0

                    Dim iDocCounter As Integer = 0

                    Dim iSQLDoc = dgv_sfg.Rows(ii).Cells(1).Value
                    If iDocCounter > 0 Then
                        iIssueToProd.Lines.Add()
                        iIssueToProd.Lines.SetCurrentLine(iDocCounter)
                        iDocCounter = iDocCounter + 1
                    Else
                        iDocCounter = iDocCounter + 1
                    End If

                    iIssueToProd.Lines.BaseType = 202
                    iIssueToProd.Lines.BaseEntry = CInt(dgv_sfg.Rows(ii).Cells(2).Value)
                    iIssueToProd.Lines.BaseLine = CInt(dgv_sfg.Rows(ii).Cells(3).Value) - 1

                    iIssueToProd.Lines.WarehouseCode = dgv_sfg.Rows(ii).Cells(8).Value
                    iIssueToProd.Lines.Quantity = dgv_sfg.Rows(ii).Cells(11).Value
                    iIssueToProd.Lines.AccountCode = "113110600" ' <<WIP    | dgv_Variant.Rows(i).Cells(15).Value
                    iRowBatchCouter = 0
                    ''>>SFG BATCH 
                    For iii = 0 To Batches.Count - 1
                        If Batches(iii).ROW = dgv_sfg.Rows(ii).Cells(0).Value And
                            Batches(iii).ITEMCODE = dgv_sfg.Rows(ii).Cells(9).Value And
                            Batches(iii).TYPE = "SFG" Then
                            If iRowBatchCouter > 0 Then
                                iIssueToProd.Lines.BatchNumbers.Add()
                                iIssueToProd.Lines.BatchNumbers.SetCurrentLine(iRowBatchCouter)
                                iRowBatchCouter = iRowBatchCouter + 1
                            Else
                                iRowBatchCouter = iRowBatchCouter + 1
                            End If
                            iIssueToProd.Lines.BatchNumbers.BatchNumber = Batches(iii).BATCH
                            iIssueToProd.Lines.BatchNumbers.Quantity = Batches(iii).QTY
                            iIssueToProd.Lines.BatchNumbers.UserFields.Fields.Item("U_APP_BatchDRNo").Value = Batches(iii).BATCHDRNO

                        End If
                    Next


                    '>>>>FG 
                    For ii2 = 0 To dgv_FG.Rows.Count - 1
                        If dgv_FG.Rows(ii2).Cells(1).Value = dgv_sfg.Rows(ii).Cells(1).Value Then
                            If iDocCounter > 0 Then
                                iIssueToProd.Lines.Add()
                                iIssueToProd.Lines.SetCurrentLine(iDocCounter)
                                iDocCounter = iDocCounter + 1
                            Else
                                iDocCounter = iDocCounter + 1
                            End If
                            iIssueToProd.Lines.BaseType = 202
                            iIssueToProd.Lines.BaseEntry = CInt(dgv_FG.Rows(ii2).Cells(2).Value)
                            iIssueToProd.Lines.BaseLine = CInt(dgv_FG.Rows(ii2).Cells(3).Value) - 1
                            iIssueToProd.Lines.WarehouseCode = dgv_FG.Rows(ii2).Cells(8).Value
                            iIssueToProd.Lines.Quantity = dgv_FG.Rows(ii2).Cells(11).Value
                            iIssueToProd.Lines.AccountCode = "113110600" ' <<WIP    | dgv_Variant.Rows(i).Cells(15).Value
                            iRowBatchCouter = 0

                            For iii2 = 0 To Batches.Count - 1
                                If Batches(iii2).ROW = dgv_FG.Rows(ii2).Cells(0).Value And
                                Batches(iii2).ITEMCODE = dgv_FG.Rows(ii2).Cells(9).Value And
                                Batches(iii2).TYPE = "FG" Then
                                    If iRowBatchCouter > 0 Then
                                        iIssueToProd.Lines.BatchNumbers.Add()
                                        iIssueToProd.Lines.BatchNumbers.SetCurrentLine(iRowBatchCouter)
                                        iRowBatchCouter = iRowBatchCouter + 1
                                    Else
                                        iRowBatchCouter = iRowBatchCouter + 1
                                    End If
                                    iIssueToProd.Lines.BatchNumbers.BatchNumber = Batches(iii2).BATCH
                                    iIssueToProd.Lines.BatchNumbers.Quantity = Batches(iii2).QTY
                                    iIssueToProd.Lines.BatchNumbers.UserFields.Fields.Item("U_APP_BatchDRNo").Value = Batches(iii2).BATCHDRNO

                                End If
                            Next
                        End If
                    Next

                    'If oCompany.InTransaction = True Then
                    Dim inum = iIssueToProd.Add()
                    Dim iStr As String = ""
                    oCompany.GetLastError(inum, iStr)
                    MainMenu.g_notif_panel(0, "Error " & inum & " " & iStr, 2)
                    'Else
                    '    oCompany.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                    'End If
                End If
            Next
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
            '   oCompany.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
        End Try
    End Sub

    Sub iCreate()
        Try
            If oCompany.InTransaction Then
                oCompany.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
            End If

            Dim iHeader As SAPbobsCOM.GeneralService
            Dim iHeaderData As SAPbobsCOM.GeneralData

            Dim iChild As SAPbobsCOM.GeneralDataCollection
            Dim iChildData As SAPbobsCOM.GeneralData

            Dim oCompService As SAPbobsCOM.CompanyService = oCompany.GetCompanyService()

            iHeader = oCompany.GetCompanyService.GetGeneralService("OPRT")
            iHeaderData = iHeader.GetDataInterface(SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralData)

            iHeaderData.SetProperty("U_WhseCode", uc_warehouse.iText)
            iHeaderData.SetProperty("U_DocDate", Now())
            iHeaderData.SetProperty("U_ProrationType", uc_prorationType.iText)
            iHeaderData.SetProperty("U_Remarks", "" + txt_remarks.Text.ToString)
            iHeaderData.SetProperty("U_Void", "Y")
            iHeaderData.SetProperty("U_DocDate", uc_CreatedDate.iDate)
            iHeaderData.SetProperty("U_BaseRef", uc_baseRef.iText)


            iChild = iHeaderData.Child("PRT1")
            For i = 0 To dgv_Variant.Rows.Count - 1
                iChildData = iChild.Add()
                iChildData.SetProperty("U_Batch", dgv_Variant.Rows(i).Cells(5).Value)
                iChildData.SetProperty("U_DMPISample", dgv_Variant.Rows(i).Cells(6).Value)
                iChildData.SetProperty("U_ItemCode", dgv_Variant.Rows(i).Cells(2).Value.ToString)
                ' iChildData.SetProperty("U_ItemName", dgv_Variant.Rows(i).Cells(3).Value.ToString)
                iChildData.SetProperty("U_LabSample", dgv_Variant.Rows(i).Cells(7).Value)
                iChildData.SetProperty("U_Retain", dgv_Variant.Rows(i).Cells(8).Value)
                iChildData.SetProperty("U_CompletedQty", CDbl(dgv_Variant.Rows(i).Cells(4).Value))
                iChildData.SetProperty("U_BaseRef", dgv_Variant.Rows(i).Cells(1).Value.ToString)
                iChildData.SetProperty("U_Void", "Y")
            Next

            'iChild = iHeaderData.Child("PRT2")

            'Dim iUsage As Double
            'For i = 0 To dgv_FG.Rows.Count - 1
            '    Double.TryParse(dgv_FG.Rows(i).Cells(8).Value.ToString, iUsage)
            '    iChildData = iChild.Add()
            '    iChildData.SetProperty("U_ExpDate", dgv_FG.Rows(i).Cells(12 + 1).Value)
            '    iChildData.SetProperty("U_FormulaAdj", CDbl(dgv_FG.Rows(i).Cells(6).Value))
            '    iChildData.SetProperty("U_ItemCode", dgv_FG.Rows(i).Cells(0 + 1).Value.ToString)
            '    iChildData.SetProperty("U_ItemName", dgv_FG.Rows(i).Cells(1 + 1).Value.ToString)
            '    iChildData.SetProperty("U_MnfDate", dgv_FG.Rows(i).Cells(11 + 1).Value)
            '    iChildData.SetProperty("U_NTSSQty", CDbl(dgv_FG.Rows(i).Cells(4).Value))
            '    iChildData.SetProperty("U_Reject", CDbl(dgv_FG.Rows(i).Cells(5).Value.ToString))
            '    iChildData.SetProperty("U_UsageQty", CDbl(dgv_FG.Rows(i).Cells(2 + 1).Value))
            '    iChildData.SetProperty("U_BaseRef", dgv_FG.Rows(i).Cells(0).Value)
            '    Dim i14 As String = ""
            '    If IsNothing(dgv_FG.Rows(i).Cells(14).Value) = False Then i14 = dgv_FG.Rows(i).Cells(14).Value.ToString
            '    iChildData.SetProperty("U_Remarks", i14)
            '    iChildData.SetProperty("U_UoMCode", dgv_FG.Rows(i).Cells(8 + 1).Value.ToString)
            '    ' iChildData.SetProperty("U_Void", "Y")
            'Next
            iChild = iHeaderData.Child("PRT3")

            For i = 0 To dgv_Proration.Rows.Count - 1
                iChildData = iChild.Add()
                Dim I1, I2, I3, I4, I5 As Double
                I1 = CDbl(dgv_Proration.Rows(i).Cells(1).Value)
                I2 = CDbl(dgv_Proration.Rows(i).Cells(2).Value)
                I3 = CDbl(dgv_Proration.Rows(i).Cells(3).Value)
                I4 = CDbl(dgv_Proration.Rows(i).Cells(4).Value)
                I5 = CDbl(dgv_Proration.Rows(i).Cells(5).Value)

                iChildData.SetProperty("U_ItemCode", dgv_Proration.Rows(i).Cells(0).Value)
                iChildData.SetProperty("U_ItemCode1", I1)
                iChildData.SetProperty("U_ItemCode2", I2)
                iChildData.SetProperty("U_ItemCode3", I3)
                iChildData.SetProperty("U_ItemCode4", I4)
                iChildData.SetProperty("U_ItemCode5", I5)
                iChildData.SetProperty("U_UsageQty", dgv_Proration.Rows(i).Cells(6).Value)
                iChildData.SetProperty("U_Prorated", dgv_Proration.Rows(i).Cells(7).Value)
                iChildData.SetProperty("U_BaseRef", dgv_Proration.Rows(i).Cells(8).Value)
            Next
            Dim imsgNum As Integer



            iHeader.Add(iHeaderData)
            iIsCreated1 = True
            MainMenu.g_notif_panel(1, "Transaction success", 2)

            '  AddMode()
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
        'Try
        '    'For i = 0 To dgv_Variant.Rows.Count - 1
        '    '    Dim iRs As SAPbobsCOM.ProductionOrders
        '    '    iRs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders)
        '    '    If iRs.GetByKey(dgv_Variant.Rows(i).Cells(9).Value) = True Then
        '    '        iRs.UserFields.Fields.Item("U_reject_dmpi_sample").Value = dgv_Variant.Rows(i).Cells(6).Value
        '    '        iRs.UserFields.Fields.Item("U_reject_lab_sample").Value = dgv_Variant.Rows(i).Cells(7).Value
        '    '        iRs.UserFields.Fields.Item("U_reject_retiamn").Value = dgv_Variant.Rows(i).Cells(8).Value
        '    '        iRs.Update()
        '    '    End If
        '    'Next
        '    '  MainMenu.g_notif_panel(1, "Transaction success", 2)

        'Catch ex As Exception
        '    MainMenu.g_notif_panel(0, ex.Message, 2)
        'End Try

    End Sub
    Function iTryParse(ByVal iObh As String) As Double
        Dim iDouble

        If Double.TryParse(iObh, iDouble) = True Then
            iDouble = Double.Parse(iObh)
        ElseIf Integer.TryParse(iObh, iDouble) Then
            iDouble = Integer.Parse(iDouble)
        End If
        Return iDouble
    End Function


    Private Sub eidtText_KeyDown(sender As Object, e As KeyEventArgs) Handles eidtText.KeyDown
        If Not (IsNumeric(eidtText.Text)) Then
            If dgv_FG.CurrentCell.ColumnIndex < 10 Then

                MainMenu.g_notif_panel(0, "Only Numeric Value is Accepted on this Cell", 1)
                dgv_FG.ClearSelection()
                dgv_FG.CurrentCell = dgv_FG.Rows(s_row).Cells(s_col)
                dgv_FG.CurrentCell.Value = 0
            End If
        End If
    End Sub




    Private Sub dgv_Variant_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_Variant.MouseClick
        'If e.Button = MouseButtons.Right And dgv_Variant.Rows.Count > 0 And transaction_type = "A" Then
        '    cmd_Variant.Show(MousePosition)
        'End If
        If e.Button = MouseButtons.Right Then
            dgv_selected = dgv_sfg
            cms_copy.Show(MousePosition)
        End If
    End Sub

    Private Sub cms_Variant_remove_Click(sender As Object, e As EventArgs) Handles cms_Variant_remove.Click
        Try
            dgv_Variant.Rows.RemoveAt(dgv_Variant.SelectedCells(0).RowIndex)
        Catch
        End Try
    End Sub

    Private Sub cms_Variant_ViewBatch_Click(sender As Object, e As EventArgs) Handles cms_Variant_ViewBatch.Click
        Try

            Dim batchNUm As String = dgv_Variant.Rows(dgv_Variant.SelectedCells(0).RowIndex).Cells(1).Value
            iViewr(106, batchNUm, "Production # " & batchNUm & " batch details", Me, "", False)
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_find_PO.Click
        iSQL_SELECT_PROD_SELECTION()
    End Sub



    Sub AddMode()
        Try
            crvwr.Visible = False

            Me.dgv_FG.Rows.Clear()
            Me.dgv_CheckSelection.Rows.Clear()
            Me.dgv_Variant.Rows.Clear()
            Me.dgv_Variant.Columns.Clear()
            Me.dgv_FG.Columns.Clear()
            Me.dgv_CheckSelection.Columns.Clear()

            transaction_type = "A"

            uc_prorationNum.TransactionTrig(transaction_type)
            uc_prorationType.TransactionTrig(transaction_type)
            uc_warehouse.TransactionTrig(transaction_type)
            uc_createdBy.TransactionTrig(transaction_type)
            uc_createdBy.iText = g_txtUserID.ToString

            SplitContainer1.SplitterDistance = 0
            btn_ok.Text = "Ok"
            btn_find_PO.Enabled = True
            Dim iRead As SAPbobsCOM.Recordset
            iRead = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            iRead.DoQuery("EXEC spDMF_DI001 105")
            Do While iRead.EoF = False
                uc_prorationNum.iText = iRead.Fields(0).value
                iRead.MoveNext()
            Loop
            'dtp_from.Enabled = True
            '   dtp_To.Enabled = True
            btn_find_PO.Enabled = True
            'iSQL_SELECT_PROD_SELECTION()
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub
    Sub FindMode()
        Try
            crvwr.Visible = False
            Me.dgv_FG.Rows.Clear()
            Me.dgv_CheckSelection.Rows.Clear()
            Me.dgv_Variant.Rows.Clear()
            Me.dgv_Variant.Columns.Clear()
            Me.dgv_FG.Columns.Clear()
            Me.dgv_CheckSelection.Columns.Clear()

            dgv_Variant.Rows.Clear()
            dgv_CheckSelection.Rows.Clear()
            dgv_FG.Rows.Clear()
            transaction_type = "F"

            btn_find_PO.Enabled = False
            btn_ok.Text = "Find"
            uc_prorationNum.TransactionTrig(transaction_type)
            uc_prorationType.TransactionTrig(transaction_type)
            uc_warehouse.TransactionTrig(transaction_type)
            uc_createdBy.TransactionTrig(transaction_type)
            SplitContainer1.SplitterDistance = 0
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Proration_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        '  ADD_Column_ARROW_ALIGN(dgv_sfg, 7)
        IFG_REFRESH()
        iSFG_REFRESH()
    End Sub

    Private Sub SplitContainer1_Resize(sender As Object, e As EventArgs) Handles SplitContainer1.Resize
        '      If transaction_type <> "F" Then SplitContainer1.SplitterDistance = 0
    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved
        '    If transaction_type <> "F" Then SplitContainer1.SplitterDistance = 0
    End Sub



    Private Sub Proration_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        '' i TRIG
        Try
        Catch ex As Exception
            MainMenu.g_notif_panel(0, "" + ex.ToString, 2)
        End Try
    End Sub


    Private Sub txt_prorationType_TextChanged(sender As Object, e As EventArgs) Handles txt_prorationType.TextChanged
        If iSelectMode = False And IsNumeric(txt_prorationType.Text) = True Then

            If transaction_type = "A" Then
                iGetDataSql()
                iRemoveSFG_IN_Batch()
            End If
        ElseIf txt_prorationType.Text = "" Then
            uc_SFG.iText = ""
            uc_warehouse.iText = ""
            txt_prorationType.Text = ""
            uc_baseRef.iText = ""
            uc_createdBy.iText = ""
            txt_remarks.Text = ""
            uc_prorationType.iText = ""
            uc_prorationLbl.iText = ""
            uc_label_sfg.iText = ""
            UC_warehouselabel.iText = ""
            dgv_Variant.Columns.Clear()
            dgv_FG.Columns.Clear()
            dgv_sfg.Columns.Clear()
            dgv_FG.Columns.Clear()
            dgv_FG.Columns.Clear()
            ADD_Column_ARROW_REMOVE(dgv_FG)
            ADD_Column_ARROW_REMOVE(dgv_sfg)
        End If
    End Sub

    Sub AutoFillBatch()
        Dim count As Integer = dgv_sfg.Controls.Count
        For i As Integer = count - 1 To 0 Step -1
            Dim cControl As Control = dgv_sfg.Controls(i)
            If (TypeOf cControl Is uc_dgv_col_withArrow) Then

                Dim iArrow As New uc_dgv_col_withArrow
                iArrow = cControl
                iArrow.iText = ""
                iArrow.Left = dgv_sfg.Left
            End If
        Next
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)
        CopyToClipboardWithHeaders(dgv_FG)
    End Sub
    Private Sub dgv_material_usage_MouseUp(sender As Object, e As MouseEventArgs) Handles dgv_FG.MouseUp
        If e.Button = MouseButtons.Right Then
            dgv_selected = dgv_FG
            cms_copy.Show(MousePosition)
        End If
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        CopyToClipboardWithHeaders(dgv_selected)
    End Sub
    Private Sub dgv_sfg_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_sfg.MouseClick
        If e.Button = MouseButtons.Right Then
            dgv_selected = dgv_sfg
            cms_copy.Show(MousePosition)
        End If
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            dgv_selected = dgv_FG
            cms_copy.Show(MousePosition)
        End If
    End Sub


    Private Sub dgv_sfg_Scroll(sender As Object, e As ScrollEventArgs) Handles dgv_sfg.Scroll
        Timer2.Enabled = True
    End Sub

    Private Sub dgv_material_usage_Scroll(sender As Object, e As ScrollEventArgs) Handles dgv_FG.Scroll

        Timer1.Enabled = True
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        IFG_REFRESH()
        Timer1.Enabled = False
    End Sub

    Sub IFG_REFRESH()
        If transaction_type = "A" Then
            For i = 0 To dgv_FG.Controls.Count - 1
                Dim cControl As Control = dgv_FG.Controls(i)
                If (TypeOf cControl Is uc_dgv_col_withArrow) Then
                    Dim iuc_dgv_col_withArrow As uc_dgv_col_withArrow
                    iuc_dgv_col_withArrow = cControl
                    iuc_dgv_col_withArrow.Location = dgv_FG.GetCellDisplayRectangle(7, iuc_dgv_col_withArrow.IROW, True).Location
                    If iuc_dgv_col_withArrow.Location.X < 10 Then
                        iuc_dgv_col_withArrow.Location = New Point(-200, -200)
                    End If
                End If
            Next
        End If
    End Sub
    Sub iSFG_REFRESH()
        If transaction_type = "A" Then
            For i = 0 To dgv_sfg.Controls.Count - 1
                Dim cControl As Control = dgv_sfg.Controls(i)
                If (TypeOf cControl Is uc_dgv_col_withArrow) Then
                    Dim iuc_dgv_col_withArrow As uc_dgv_col_withArrow
                    iuc_dgv_col_withArrow = cControl
                    iuc_dgv_col_withArrow.Location = dgv_sfg.GetCellDisplayRectangle(7, iuc_dgv_col_withArrow.IROW, True).Location
                    If iuc_dgv_col_withArrow.Location.X < 10 Then
                        iuc_dgv_col_withArrow.Location = New Point(-200, -200)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        iSFG_REFRESH()
        Timer2.Enabled = False
    End Sub


    Private Sub MainTab_TabIndexChanged(sender As Object, e As EventArgs) Handles MainTab.TabIndexChanged
        iSFG_REFRESH()
        IFG_REFRESH()
    End Sub

    Private Sub MainTab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MainTab.SelectedIndexChanged
        iSFG_REFRESH()
        IFG_REFRESH()
    End Sub



    Sub ConvertCellToNum(dgv As DataGridView, CellId As Integer)
        For i = 0 To dgv.Rows.Count - 1
            dgv.Rows(i).Cells(CellId).Value = CInt(dgv.Rows(i).Cells(CellId).Value)
        Next
    End Sub
    Sub iGetDataSql()


        Try


            Dim iRs As SAPbobsCOM.Recordset = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            iRs.DoQuery("exec spDMF_DI001 137, '" & txt_prorationType.Text & "'")
            If iRs.RecordCount > 0 Then
                iSelectMode = True
                uc_SFG.iText = iRs.Fields.Item("itemcode").Value
                uc_warehouse.iText = iRs.Fields.Item("Warehouse").Value
                uc_prorationType.iText = iRs.Fields.Item("Proration Type").Value
                uc_baseRef.iText = iRs.Fields.Item("BaseRef").Value

                Panel4.Visible = True
                Panel5.Visible = True
                Dim iloadCount As Integer = 0
                Dim incr As Integer = 5
                iloadCount = iloadCount + incr
                iLoad_bar(iloadCount, True)

                ADD_Column_ARROW_REMOVE(dgv_sfg)

                iloadCount = iloadCount + incr
                iLoad_bar(iloadCount, True)

                ADD_Column_ARROW_REMOVE(dgv_FG)

                iloadCount = iloadCount + incr
                iLoad_bar(iloadCount, True)

                Batches.Clear()

                iloadCount = iloadCount + incr
                iLoad_bar(iloadCount, True)
                Dim iSFG_SELCTED As String = uc_SFG.iText
                iloadCount = iloadCount + incr
                iLoad_bar(iloadCount, True)



                MainTab.SelectedIndex = 0
                iloadCount = iloadCount + incr
                iLoad_bar(iloadCount, True)
                iSQL_SELECT_VARIANT(iSFG_SELCTED, dgv_Variant)

                MainTab.SelectedIndex = 1
                iSQL_GET_MATERIAL_SUMMARYSFG() '>>>>>>>>>>>>>> GET SFG

                uc_SFG.iText = iSFG_SELCTED
                '       If dgv_sfg.Rows.Count > 0 Then uc_warehouse.iText = dgv_sfg.Rows(0).Cells(7).Value

                iloadCount = iloadCount + incr
                iLoad_bar(iloadCount, True)

                If dgv_sfg.Rows.Count > 0 Then
                    ADD_Column_ARROW(" - ", 1, 7, "BATCH DETAILS", 1, 15, dgv_sfg, True, "1", 1, 5, 4, 8, 1, 12, "SFG")

                    iloadCount = iloadCount + incr
                    iLoad_bar(iloadCount, True)

                    ADD_Column("Status", 1, dgv_sfg.Columns.Count, "Status", "Status", 80, dgv_sfg, True)

                    iloadCount = iloadCount + incr
                    iLoad_bar(iloadCount, True)
                    AutoBatchx(dgv_sfg)
                    'dgv_Variant

                    iloadCount = iloadCount + incr
                        iLoad_bar(iloadCount, True)
                    End If


                    MainTab.SelectedIndex = 2
                    iSQL_GET_MATERIAL_SUMMARY()
                    iloadCount = iloadCount + incr
                    iLoad_bar(iloadCount, True)
                    If dgv_FG.Rows.Count > 0 Then
                    ADD_Column_ARROW(" - ", 1, 7, "BATCH DETAILS", 1, 15, dgv_FG, True, "1", 1, 5, 4, 8, 1, 12, "FG")

                    iloadCount = iloadCount + incr
                    iLoad_bar(iloadCount, True)


                        ADD_Column("Status", 1, dgv_FG.Columns.Count, "Status", "Status", 80, dgv_FG, True)
                        AutoBatchx(dgv_FG)

                        iloadCount = iloadCount + incr
                        iLoad_bar(iloadCount, True)
                    End If

                    MainTab.SelectedIndex = 3

                iLoad_bar(0, False)

                    MainTab.SelectedIndex = 0

                    '     MainMenu.g_notif_panel(0, iloadCount.ToString, 2)
                    Panel4.Visible = False
                    Panel5.Visible = False
                End If
                iSelectMode = False

        Catch ex As Exception
            iSelectMode = False
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub

    Sub iRemoveSFG_IN_Batch()
        'For i = 0 To Batches.Count - 1
        '    If Batches(i).TYPE = "SFG" Then
        '        Batches(i).TYPE = "CANCEL"
        '    End If
        'Next

        'Dim count As Integer = dgv_sfg.Controls.Count

        'For i As Integer = count - 1 To 0 Step -1
        '    Dim cControl As Control = dgv_sfg.Controls(i)
        '    If (TypeOf cControl Is uc_dgv_col_withArrow) Then
        '        Dim iArrow As uc_dgv_col_withArrow
        '        iArrow = cControl
        '        iArrow.iText = ""
        '        dgv_sfg.Rows(CInt(iArrow.IROW)).Cells(14).Value = "Insufficient batch qty"
        '    End If
        'Next
    End Sub
    Function iErrorCheck() As Boolean
        Try
            G_iHAVE_ERROR_IN_TRANSACTION = False
            For i = 0 To dgv_sfg.Rows.Count - 1
                If dgv_sfg.Rows(i).Cells(14).Value <> "Open" Then
                    G_iHAVE_ERROR_IN_TRANSACTION = True
                End If
            Next
            For i = 0 To dgv_FG.Rows.Count - 1
                If dgv_FG.Rows(i).Cells(14).Value <> "Open" Then
                    G_iHAVE_ERROR_IN_TRANSACTION = True
                End If
            Next
            Return G_iHAVE_ERROR_IN_TRANSACTION
        Catch ex As Exception
            G_iHAVE_ERROR_IN_TRANSACTION = True
            MainMenu.g_notif_panel(0, ex.Message, 2)
            Return G_iHAVE_ERROR_IN_TRANSACTION
        End Try
    End Function


    Sub iClear()
        uc_SFG.iText = ""
        uc_warehouse.iText = ""
        txt_prorationType.Text = ""
        uc_baseRef.iText = ""
        uc_createdBy.iText = ""
        txt_remarks.Text = ""
        uc_prorationType.iText = ""
        uc_prorationLbl.iText = ""
        uc_label_sfg.iText = ""
        UC_warehouselabel.iText = ""
        dgv_Variant.Columns.Clear()
        dgv_FG.Columns.Clear()
        dgv_sfg.Columns.Clear()
        dgv_FG.Columns.Clear()
        dgv_FG.Columns.Clear()
        ADD_Column_ARROW_REMOVE(dgv_FG)
        ADD_Column_ARROW_REMOVE(dgv_sfg)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class

