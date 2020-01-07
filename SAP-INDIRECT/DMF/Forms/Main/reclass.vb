Imports SAPbobsCOM

Public Class reclass
    Dim ModuleKey As String = "ORCL"
    Dim ModuleKey1 As String = "RCL1"
    Dim ModuleKey2 As String = "RCL2"



    Dim iUser_Type As Integer = 0
    Dim transaction_type As Char = "A"
    Dim iUserType As String

    Dim ModuleMode As String = "F" 'bring to top
    Sub TrigerMode()


        If ModuleMode = "A" Then
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, True)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_Print, False)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, False)
        ElseIf ModuleMode = "F" Then
        ElseIf ModuleMode = "F" Then
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, False)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_Print, False)
        End If
    End Sub
    Private Sub PickFromPalletingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PickFromPalletingToolStripMenuItem.Click
        SelectionModule.iFindMulti(Me, 159, "Controlling Documents", Me.dgv, 160, uc_itemcode.iText)
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        Try
            dgv.Rows.Remove(dgv.SelectedRows(0))
        Catch
        End Try
    End Sub
    Private Sub uc_controlp_txt_TextChanged(sender As Object, e As EventArgs) Handles uc_controlp_txt.TextChanged
        If transaction_type = "A" Then
            dgv.Columns.Clear()

            If uc_controlp_txt.Text <> "" And uc_itemcode.iText <> "" Then
                SelectionModule.iFindMulti(Me, 159, "Controlling Documents", Me.dgv, 160, uc_itemcode.iText)
                getHeaderDetails()
            End If
        End If
    End Sub

    Sub getHeaderDetails()
        SAP_SQL_PARAM.Clear()
        SAP_SQL_PARAM.Add(163)
        SAP_SQL_PARAM.Add(uc_itemcode.iText)
        SAP_SQL_PARAM.Add(uc_controlp.iText)
        Dim iBt As DataTable = iSQL_DATATABLE()
        uc_warehouseF.iText = iBt.Rows(0)("FROM WHSE CODE")
        uc_warehouseF_lbl.iText = iBt.Rows(0)("FROM WHSE NAME")
        uc_warehouseto.iText = iBt.Rows(0)("TO WHSE CODE")
        uc_warehouseto_lb.iText = iBt.Rows(0)("TO WHSE NAME")
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If transaction_type = "A" Then
            If isAllowEmpty(Me) = False Then
                If iUserType <> "11" Then
                    Dim iDocEntry = InsertIntoIIT2()
                    If iDocEntry > 0 Then
                        InsertIntoDI(CStr(iDocEntry))
                        setModeAfterBtnClick()
                        uc_itemcode.iArrow_Visible = False
                        uc_controlp.iArrow_Visible = False
                        uc_status.iArrow_Visible = False
                    End If
                Else
                    InsertIntoDI("")
                    setModeAfterBtnClick()
                    uc_itemcode.iArrow_Visible = False
                    uc_controlp.iArrow_Visible = False
                    uc_status.iArrow_Visible = False
                End If
            End If
        ElseIf transaction_type = "F" Then

            SAP_SQL_PARAM.Clear()
            SAP_SQL_PARAM.Add(169)
            iGet_UC_INPUT_FOR_FIND(Me)
            SelectionModule.iFindThis(iSQL_DATATABLE_FIND(iGetSQL_Params_FIND), Me, "Find Result", 150, TextBox2)

            setModeAfterBtnClick()
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)

            uc_itemcode.iArrow_Visible = False
            uc_controlp.iArrow_Visible = False
            uc_status.iArrow_Visible = False
        End If

    End Sub



    Sub forApproval()
        'Prerequisites: You have set ApprovalTemplates and ApprovalStage by DI or SAP Business One 
        Dim i As Integer
        Dim retcode As Long = 0
        Dim msg As String = ""

        'Enable the approval procedure in the company level 
        Dim oAdmin As AdminInfo = oCompanyService.GetAdminInfo()

        oAdmin.EnableApprovalProcedureInDI = BoYesNoEnum.tYES
        oAdmin.DocConfirmation = BoYesNoEnum.tYES

        oCompanyService.UpdateAdminInfo(oAdmin)

        'Create StockTransfer which will trigger the approval procedure 
        Dim retKey As String = 0
        Dim retType As String = 0
        Dim oStockTransfer As StockTransfer = oCompany.GetBusinessObject(BoObjectTypes.oStockTransfer)

        oStockTransfer.CardCode = "C001"
        oStockTransfer.Lines.ItemCode = "I001"
        oStockTransfer.Lines.Quantity = 10
        oStockTransfer.Lines.WarehouseCode = "10"
        oStockTransfer.DocDate = Today

        retcode = oStockTransfer.GetApprovalTemplates()

        If retcode = 0 Then
            If (oStockTransfer.StockTransfer_ApprovalRequests.ApprovalTemplatesID > 0) Then
                For i = 1 To oStockTransfer.StockTransfer_ApprovalRequests.Count

                    oStockTransfer.StockTransfer_ApprovalRequests.SetCurrentLine(i - 1)
                    'Add some remarks  
                    oStockTransfer.StockTransfer_ApprovalRequests.Remarks = "Remark of Inv" & i & " AddedfromDI"
                Next i
            End If
        End If

        Try
            'Add StockTransfer 
            retcode = oStockTransfer.Add()
        Catch ex As Exception
            'Error processing 
            MsgBox(ex.Message)
        End Try

        If retcode <> 0 Then
            oCompany.GetLastError(retcode, msg)
            MsgBox("Failed to add. Error: " & msg & " (" & Str(retcode) & ")")
            Exit Sub
        Else
            'Get the last added object key and type 
            retKey = oCompany.GetNewObjectKey
            retType = oCompany.GetNewObjectType
        End If


    End Sub
    Sub setModeAfterBtnClick()
        uc_status.iArrow_Visible = False
        uc_status.isForFind = False
        uc_status.iIsForSearch = False

        iFind_Css(False, Me)

        transaction_type = "N"
        btn_ok.Text = "Okay"
        btn_ok.BackgroundImage = MainMenu.btn_img.Images(0)
        MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, False)
        MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, True)
        MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_Print, False)

    End Sub


    Function InsertIntoDI(DocEntry As String)
        Try
            Dim iRemarks As String = Now.ToString & "Posted from Reclass Add-on " & vbNewLine & " " & uc_remarks.iText & vbNewLine

            oConnect()

            Dim iHeader As SAPbobsCOM.GeneralService
            Dim iHeaderData As SAPbobsCOM.GeneralData
            Dim iChild As SAPbobsCOM.GeneralDataCollection
            Dim iChildData As SAPbobsCOM.GeneralData

            Dim oCompService As SAPbobsCOM.CompanyService = oCompany.GetCompanyService()

            iHeader = oCompany.GetCompanyService.GetGeneralService("ORCL")
            iHeaderData = iHeader.GetDataInterface(SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralData)
            iHeaderData.SetProperty("Remark", iRemarks)
            iHeaderData.SetProperty("U_it_FQI_Entry", DocEntry)
            iHeaderData.SetProperty("U_itemcode", uc_itemcode.iText)
            iHeaderData.SetProperty("U_reclassType", uc_controlp.iText)
            iHeaderData.SetProperty("U_preparedBy", uc_prepared.iText)
            iHeaderData.SetProperty("U_approvedBy", uc_approved.iText)
            iHeaderData.SetProperty("U_docdate", uc_TaxDate.iDate)

            iChild = iHeaderData.Child("RCL1")

            For i = 0 To dgv.Rows.Count - 1
                iChildData = iChild.Add()
                iChildData.SetProperty("U_palletid", dgv.Rows(i).Cells(2).Value)
                iChildData.SetProperty("U_qty", dgv.Rows(i).Cells(6).Value)
                iChildData.SetProperty("U_machine", dgv.Rows(i).Cells(8).Value)
                iChildData.SetProperty("U_rfp", dgv.Rows(i).Cells(9).Value)
                iChildData.SetProperty("U_ITT", dgv.Rows(i).Cells(10).Value)
                iChildData.SetProperty("U_batch", dgv.Rows(i).Cells(4).Value)
            Next

            iHeader.Add(iHeaderData)
            MainMenu.g_notif_panel(1, " RECLASS DETAILS - Transaction success", 2)
            Dim iDOcEntry = oCompany.GetNewObjectKey
            Return iDOcEntry
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
            Return 0
        End Try
    End Function


    Function InsertIntoIIT2() As Integer
        Try

            Dim i As Integer
            Dim retcode As Long = 0
            Dim msg As String = ""

            'Dim oAdminInfo As AdminInfo = oCompany.GetCompanyService().GetAdminInfo()
            'oAdminInfo.EnableApprovalProcedureInDI = BoYesNoEnum.tYES
            'oAdminInfo.DocConfirmation = BoYesNoEnum.tYES
            'oAdminInfo.QueryAccuracy = 100
            'oCompany.GetCompanyService().UpdateAdminInfo(oAdminInfo)


            Dim retKey As String = 0
            Dim retType As String = 0


            Dim iRemarks As String = Now.ToString & "Posted from Reclass Add-on " & vbNewLine & " " & uc_remarks.iText & vbNewLine
            Dim iIT As StockTransfer = oCompany.GetBusinessObject(BoObjectTypes.oStockTransfer)
            iIT.UserFields.Fields.Item("U_isFromDi").Value = "Y"
            iIT.DocDate = uc_DocDate.iDate
            iIT.TaxDate = uc_TaxDate.iDate
            iIT.FromWarehouse = uc_warehouseF.iText
            iIT.ToWarehouse = uc_warehouseto.iText
            iIT.Comments = iRemarks
            iIT.UserFields.Fields.Item("U_APP_TransferType").Value = "FQI"
            iIT.UserFields.Fields.Item("U_fqi_type").Value = uc_controlp.iText
            Dim iBchCount = 0

            For i = 0 To dgv.Rows.Count - 1

                If i > 0 Then
                    iIT.Lines.Add()
                End If
                iIT.Lines.SetCurrentLine(i)
                iIT.Lines.ItemCode = dgv.Rows(i).Cells(0).Value

                iIT.Lines.Quantity = CDbl(dgv.Rows(i).Cells(6).Value)
                iIT.Lines.FromWarehouseCode = uc_warehouseF.iText
                iIT.Lines.WarehouseCode = uc_warehouseto.iText
                iIT.Lines.UserFields.Fields.Item("U_RFPRef").Value = dgv.Rows(i).Cells(9).Value
                iIT.Lines.UserFields.Fields.Item("U_PalletRef").Value = dgv.Rows(i).Cells(10).Value
                iIT.Lines.UserFields.Fields.Item("U_APP_PalletId").Value = dgv.Rows(i).Cells(2).Value
                iIT.Lines.UserFields.Fields.Item("U_Machine").Value = dgv.Rows(i).Cells(8).Value
                iIT.Lines.UserFields.Fields.Item("U_Machine").Value = dgv.Rows(i).Cells(8).Value

                If iBchCount <> 0 Then
                    iIT.Lines.BatchNumbers.Add()
                    iIT.Lines.BatchNumbers.SetCurrentLine(iBchCount)
                End If

                iBchCount += 1
                iIT.Lines.BatchNumbers.BatchNumber = dgv.Rows(i).Cells(4).Value
                iIT.Lines.BatchNumbers.Quantity = CDbl(dgv.Rows(i).Cells(6).Value)

            Next



            Try
                retcode = iIT.Add()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If retcode <> 0 Then
                oCompany.GetLastError(retcode, msg)
                MainMenu.g_notif_panel(0, "Failed to add. Error: " & msg & " (" & Str(retcode) & ")", 2)
            Else
                retType = oCompany.GetNewObjectType
                retKey = oCompany.GetNewObjectKey
                Return retKey
            End If
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
            Return 0
        End Try
    End Function

    Sub AddMode()
        iFind_Css_undo(Me)
        uc_doc.iText = ""
        Uc_inputbox1.iArrow_Visible = False
        Try
            '>> GET DOC ENTRY . ALWAYS  + 1 
            SAP_SQL_PARAM.Clear()
            SAP_SQL_PARAM.Add(172)
            Dim iBt As DataTable = iSQL_DATATABLE()
            uc_doc.iText = iBt.Rows(0)("Code")


            btn_ok.Tag = 0
            btn_ok.Text = "Add"
            iSet_btn_img(Me, MainMenu.btn_img)

            iRemoveIsEmptyWarinIcon(Me)
            uc_status.iArrow_Visible = False
            uc_status.isForFind = False
            uc_status.iIsForSearch = False


            iFind_Css(False, Me)

            transaction_type = "A"

            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, False)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, True)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_Print, False)
            dgv.Columns.Clear()

            uc_warehouseF.iIsEnabled = True
            uc_warehouseto.iIsEnabled = True
            uc_DocDate.Enabled = True
            uc_TaxDate.Enabled = True
            uc_status.Enabled = True
            uc_remarks.iIsEnabled = True
            CMS_main.Enabled = True

            If iUserType = "9" Then
                uc_approved.isAllowEmptyx = True
                uc_approved.iIsEnabled = False
            Else
                uc_approved.isAllowEmptyx = False
                uc_approved.iIsEnabled = True

            End If

        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try

    End Sub

    Sub FindMode()
        Try
            uc_itemcode.iArrow_Visible = True
            uc_controlp.iArrow_Visible = True
            Uc_inputbox1.iArrow_Visible = True
            uc_status.iArrow_Visible = True
            uc_doc.iText = ""

            btn_ok.Tag = 2
            btn_ok.Text = "Find"
            iSet_btn_img(Me, MainMenu.btn_img)

            iRemoveIsEmptyWarinIcon(Me)

            uc_status.iArrow_Visible = True
            uc_status.isForFind = True
            uc_status.iIsForSearch = True
            transaction_type = "F"


            iFind_Css(True, Me)

            uc_warehouseF.iIsEnabled = False
            uc_warehouseto.iIsEnabled = False
            uc_DocDate.Enabled = False
            uc_TaxDate.Enabled = False
            'uc_status.Enabled = False
            uc_remarks.iIsEnabled = False
            CMS_main.Enabled = False

            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, False)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_Print, False)

        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub




    Private Sub dgv_DataSourceChanged(sender As Object, e As EventArgs) Handles dgv.DataSourceChanged
        '  MainMenu.g_notif_panel(0, "DATA CHANGED!", 2)
        Try
            Dim iX As Double = 0
            For i = 0 To dgv.Rows.Count - 1
                iX = iX + CDbl(dgv.Rows(i).Cells(6).Value)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub reclass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iUserType = iGetUserType(Me)
        FindMode()
    End Sub

    Private Sub uc_controlp_Load(sender As Object, e As EventArgs) Handles uc_controlp.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        SAP_SQL_PARAM.Clear()
        SAP_SQL_PARAM.Add(170)
        SAP_SQL_PARAM.Add(TextBox2.Text)
        Dim iBt As DataTable = iSQL_DATATABLE()
        uc_doc.iText = iBt.Rows(0)("DocEntry")
        uc_itemcode.iText = iBt.Rows(0)("itemcode")
        uc_itemcode_lbl.iText = iBt.Rows(0)("ItemName")

        uc_status.iText = iBt.Rows(0)("Type")
        uc_status_lbl.iText = iBt.Rows(0)("TypeCode")

        uc_prepared.iText = iBt.Rows(0)("PreparedBy")
        uc_approved.iText = iBt.Rows(0)("approvedBy")

        uc_warehouseF.iText = iBt.Rows(0)("ToWarehouseF")
        uc_warehouseF_lbl.iText = iBt.Rows(0)("ToWhseNameF")

        uc_warehouseto_lb.iText = iBt.Rows(0)("FromWarehouseT")
        uc_doc.iText = iBt.Rows(0)("ToWhseNameT")

        Timer1.Enabled = False
        SAP_SQL_PARAM.Clear()
        SAP_SQL_PARAM.Add(171)
        SAP_SQL_PARAM.Add(TextBox2.Text)
        dgv.DataSource = iSQL_DATATABLE()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Draft_Set(Me, 1, uc_remarks.iText, 1, dgv)
    End Sub

    Private Sub Uc_label2_Load(sender As Object, e As EventArgs) Handles Uc_label2.Load

    End Sub

    Private Sub btn_ok_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class
