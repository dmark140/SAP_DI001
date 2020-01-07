Public Class Palleting
    Dim iButalholder As Double
    Dim transaction_type As Char = "A"


    Dim ModuleMode As String = "F" 'bring to top
    Sub TrigerMode()
        If ModuleMode = "A" Then
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, True)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, False)
        ElseIf ModuleMode = "F" Then
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, False)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_Print, True)
        End If
    End Sub
    Private Sub Palleting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_forPallet.BringToFront()
        AddMode()

    End Sub
    Sub LayoutMode()

        If IsNumeric(uc_palletingNum.iText) And uc_palletingNum.iText <> "" Then
            Dim DocEntry As Integer = CInt(uc_palletingNum.iText)
            iLayoutSetUp(getFormType(Me), DocEntry)
        Else

            MainMenu.g_notif_panel(2, "Find Error : Search a record first", 2)
        End If
    End Sub

    Private Sub docnum_container_TextChanged(sender As Object, e As EventArgs)
        Try

            dgv_forPallet.Columns.Clear()
            uc_docnum.iText = docnum_container.Text
            SAP_SQL_PARAM.Clear()
            SAP_SQL_PARAM.Add(docnum_container.Text)
            iSQL_selector(118, dgv_forPallet, True, 3)
            '  iSplitPallet()
        Catch ex As Exception
            MainMenu.g_notif_panel(0, "118 - " & ex.Message, 2)
        End Try
    End Sub


    Sub AddMode()


        Try
            transaction_type = "A"
            btn_ok.Text = "Add"
            dgv_forPallet.Columns.Clear()
            dgv_palleted.Columns.Clear()
            uc_palletingNum.TransactionTrig(transaction_type)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, False)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, True)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_Print, False)

            uc_fromWHse.iText = ""
            uc_ToWHse.iText = ""
            uc_docnum.iText = ""
            uc_station.iText = ""
            uc_release.iText = ""
            uc_recieved.iText = ""
            uc_paletsizer.iText = ""
            uc_packer.iText = ""
            uc_palletingNum.iText = ""
            txt_remarks.Text = ""

            uc_LP_Docnum.iText = ""
            uc_LP_qty.iText = "0"
            uc_LP_pallet_num.iText = "0"

            iArrowSet(True)

            uc_palletingNum.iArrow_Visible = False


            dgv_forPallet.Rows.Clear()
            dgv_palleted.Rows.Clear()
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try

    End Sub

    Sub iArrowSet(Visible As Boolean)
        uc_fromWHse.iArrow_Visible = Visible
        uc_docnum.iArrow_Visible = Visible
        uc_station.iArrow_Visible = Visible
        'uc_release.iArrow_Visible = Visible
        'uc_recieved.iArrow_Visible = Visible
        'uc_paletsizer.iArrow_Visible = Visible
        'uc_packer.iArrow_Visible = Visible
    End Sub

    Sub FindMode()
        Try
            transaction_type = "F"
            btn_ok.Text = "Find"
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, False)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_Print, True)

            dgv_forPallet.Columns.Clear()
            dgv_palleted.Columns.Clear()

            uc_palletingNum.iArrow_Visible = True
            iArrowSet(False)
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub




    Private Sub txt_FromWhse_TextChanged(sender As Object, e As EventArgs) Handles txt_frmWhs.TextChanged
        SAP_SQL_PARAM.Clear()
        SAP_SQL_PARAM.Add(144)
        SAP_SQL_PARAM.Add(uc_fromWHse.iText)
        Dim iBt As DataTable = iSQL_DATATABLE()

        uc_ToWHse.iText = iBt.Rows(0)("Warehouse Code")
        uc_ToWHse_lbl.iText = iBt.Rows(0)("Warehouse Name")
        uc_docnum.iAdditional = uc_fromWHse.iText
    End Sub

    Private Sub txt_docNum_TextChanged(sender As Object, e As EventArgs) Handles txt_docNum.TextChanged
        If txt_docNum.Text <> "" Then
            Timer1.Enabled = True
        End If
    End Sub
    Sub iPopulate(datatbl As DataTable)
        dgv_palleted.Columns.Clear()
        '      dgv_palleted.Rows.Clear()
        For i = 0 To datatbl.Columns.Count - 1
            ADD_Column(datatbl.Columns(i).Caption, 1, i, 150, dgv_palleted, True, False)
        Next
        ADD_Column("PALLETED QTY", 1, 5, 150, dgv_palleted, True, False)
        ADD_Column("PALLET ID", 1, 5, 150, dgv_palleted, True, False)

        Dim iQtyHolder As Double = 0
        Dim iQtyPost As Double = 0
        Dim iPalletSize As Double = 0
        Dim iButalholder As Double = 0

        Dim date1 As DateTime = datatbl.Rows(0)("MNF Date")
        Dim date2 As DateTime = uc_LP_date.iDate



        If Fix((Val(datatbl.Rows(0)("PALLET SIZE")))) > CDbl(uc_LP_qty.iText) Then
            If date1.Day = date2.Day Then
                iButalholder = CDbl(uc_LP_qty.iText)
            End If
        End If



        iPalletSize = Fix((Val(datatbl.Rows(0)("PALLET SIZE"))))

        If iPalletSize = 0 Then
            MainMenu.g_notif_panel(0, " Pallet size not set, please contact your administrator", 2)
            Return
        End If
        Dim iPalletId As Integer = CInt(uc_LP_pallet_num.iText)
        Dim iPost As Boolean = False
        For i = 0 To dgv_forPallet.Rows.Count - 1

            iQtyHolder = Fix((Val(datatbl.Rows(i)("QUANTITY"))))


            Dim iTrue As Boolean = True
            Do While iTrue = True
                'If (iButalholder + iQtyHolder) <= iPalletSize Then
                '    iQtyPost = iQtyHolder
                '    iTrue = False
                '    iPost = True
                '    If iPalletId <= 0 Then
                '        iPalletId = iPalletId + 1
                '    End If
                'Else
                If iButalholder > 0 Then


                    If (iPalletSize - iButalholder) > iQtyHolder Then
                        iQtyPost = iQtyHolder
                        iTrue = False
                        iPost = True
                        iButalholder = iButalholder + iQtyHolder
                    Else
                        iQtyPost = iPalletSize - iButalholder
                        iQtyHolder = iQtyHolder - iQtyPost
                        If iQtyHolder < 1 Then iQtyHolder = 0
                        iButalholder = 0
                        iTrue = True
                        iPost = True
                    End If

                ElseIf iQtyHolder >= iPalletSize Then
                    iQtyPost = iPalletSize
                    iQtyHolder = iQtyHolder - iPalletSize
                    iPalletId = iPalletId + 1
                    iTrue = True
                    iPost = True
                ElseIf iQtyHolder = 0 Then
                    iPost = False
                    iTrue = False

                Else
                    iQtyPost = iQtyHolder
                    iPalletId = iPalletId + 1
                    iButalholder = iQtyHolder
                    iPost = True
                    iTrue = False
                End If

                If iPost Then

                    dgv_palleted.Rows.Add(
                                datatbl.Rows(i)("NUM"),
                                datatbl.Rows(i)("ITEM CODE"),
                                datatbl.Rows(i)("ITEM NAME"),
                                datatbl.Rows(i)("QUANTITY"),
                                datatbl.Rows(i)("UOM"),
                                iPalletId,
                                iQtyPost,
                                datatbl.Rows(i)("BATCH #"),
                                datatbl.Rows(i)("PALLET SIZE"),
                                datatbl.Rows(i)("MACHINE"),
                                datatbl.Rows(i)("MNF Date"),
                                datatbl.Rows(i)("EXP Date"),
                                datatbl.Rows(i)("SHIFT"))
                End If

            Loop
        Next
    End Sub

    Sub iPopulate2(datatbl As DataTable)
        dgv_palleted.Columns.Clear()
        '      dgv_palleted.Rows.Clear()
        For i = 0 To datatbl.Columns.Count - 1
            ADD_Column(datatbl.Columns(i).Caption, 1, i, 150, dgv_palleted, True, False)
        Next
        ADD_Column("PALLETED QTY", 1, 5, 150, dgv_palleted, True, False)
        ADD_Column("PALLET ID", 1, 5, 150, dgv_palleted, True, False)

        Dim iQtyHolder As Double = 0
        Dim iQtyPost As Double = 0
        Dim iPalletSize As Double = 0
        Dim iButalholder As Double
        If Fix((Val(datatbl.Rows(0)("PALLET SIZE")))) > CDbl(uc_LP_qty.iText) Then
            iButalholder = CDbl(uc_LP_qty.iText)
        End If

        iPalletSize = Fix((Val(datatbl.Rows(0)("PALLET SIZE"))))

        If iPalletSize = 0 Then
            MainMenu.g_notif_panel(0, " Pallet size not set, please contact your administrator", 2)
            Return
        End If
        Dim iPalletId As Integer = CInt(uc_LP_pallet_num.iText)
        Dim iPost As Boolean = False
        For i = 0 To dgv_forPallet.Rows.Count - 1

            iQtyHolder = Fix((Val(datatbl.Rows(i)("QUANTITY"))))


            Dim iTrue As Boolean = True
            Do While iTrue = True
                If iButalholder + iQtyHolder <= iPalletSize Then
                    iQtyPost = iQtyHolder
                    iTrue = False
                    iPost = True
                    If iPalletId <= 0 Then
                        iPalletId = iPalletId + 1
                    End If
                ElseIf iButalholder > 0 Then
                    iQtyPost = iPalletSize - iButalholder
                    iQtyHolder = iQtyHolder - iQtyPost
                    If iQtyHolder < 1 Then iQtyHolder = 0
                    iButalholder = 0
                    iTrue = True
                    iPost = True
                ElseIf iQtyHolder >= iPalletSize Then
                    iQtyPost = iPalletSize
                    iQtyHolder = iQtyHolder - iPalletSize
                    iPalletId = iPalletId + 1
                    iTrue = True
                    iPost = True
                ElseIf iQtyHolder = 0 Then
                    iPost = False
                    iTrue = False
                Else
                    iQtyPost = iQtyHolder
                    iPalletId = iPalletId + 1
                    iButalholder = iQtyHolder
                    iPost = True
                    iTrue = False
                End If

                If iPost Then

                    dgv_palleted.Rows.Add(
                                datatbl.Rows(i)("NUM"),
                                datatbl.Rows(i)("ITEM CODE"),
                                datatbl.Rows(i)("ITEM NAME"),
                                datatbl.Rows(i)("QUANTITY"),
                                datatbl.Rows(i)("UOM"),
                                iPalletId,
                                iQtyPost,
                                datatbl.Rows(i)("BATCH #"),
                                datatbl.Rows(i)("PALLET SIZE"),
                                datatbl.Rows(i)("MACHINE"),
                                datatbl.Rows(i)("MNF Date"),
                                datatbl.Rows(i)("EXP Date"),
                                datatbl.Rows(i)("SHIFT"))
                End If

            Loop
        Next
    End Sub

    Sub iPopulat1(datatbl As DataTable)
        Try
            Dim i As Integer = 0
            Dim ii As Integer = 0
            Dim iii As Integer = 0
            Dim Ttlbox, TtlButal As Double
            Dim Tco As Boolean = False
            Dim iButalholder As Double = CDbl(uc_LP_qty.iText)

            Dim Tcon_Butal As Double = iButalholder
            Dim PalletID As Integer = CInt(uc_LP_pallet_num.iText)
            dgv_palleted.Columns.Clear()

            Ttlbox = CInt(uc_LP_pallet_num.iText)
            If uc_LP_qty.iText <> 0 Then
                Tco = True
            End If
            For i = 0 To datatbl.Columns.Count - 1
                ADD_Column(datatbl.Columns(i).Caption, 1, i, 150, dgv_palleted, True, False)
            Next
            ADD_Column("PALLETED QTY", 1, 5, 150, dgv_palleted, True, False)
            ADD_Column("PALLET ID", 1, 5, 150, dgv_palleted, True, False)

            For i = 0 To datatbl.Rows.Count - 1
                If (Tco = True And Tcon_Butal <> 0) Then
                    Ttlbox = (Fix((Val(datatbl.Rows(i)("QUANTITY"))) - (Val(datatbl.Rows(i)("PALLET SIZE")) - (Tcon_Butal))) / Val(datatbl.Rows(i)("PALLET SIZE")))
                    TtlButal = (Val(datatbl.Rows(i)("PALLET SIZE")) * Ttlbox)
                    TtlButal = (Val(datatbl.Rows(i)("QUANTITY")) - (Val(datatbl.Rows(i)("PALLET SIZE")) - Tcon_Butal)) - TtlButal
                    If TtlButal <> 0 Then
                        Ttlbox = Ttlbox + 2
                    End If
                    iButalholder = 0
                Else


                    Ttlbox = Fix(Val(datatbl.Rows(i)("QUANTITY")) / Val(datatbl.Rows(i)("PALLET SIZE")))

                    TtlButal = Val(datatbl.Rows(i)("PALLET SIZE")) * Ttlbox

                    TtlButal = Val(datatbl.Rows(i)("QUANTITY")) - (TtlButal)


                    If TtlButal <> 0 Then
                        Ttlbox = Ttlbox + 1
                    End If


                End If


                TtlButal = Math.Abs(TtlButal)

                For ii = 1 To Ttlbox
                    If iButalholder <> 0 Then
                        iii = (Val(datatbl.Rows(i)("PALLET SIZE")) - iButalholder)
                        Tco = True
                        Ttlbox = Ttlbox + 1
                        iButalholder = 0
                    ElseIf Tco = True And Tcon_Butal <> 0 Then
                        iii = (Val(datatbl.Rows(i)("PALLET SIZE")) - Tcon_Butal)
                        Tco = False
                        Tcon_Butal = 0
                    ElseIf Ttlbox = ii And TtlButal <> 0 Then
                        iii = TtlButal
                        Tco = True
                        Tcon_Butal = TtlButal
                        PalletID = PalletID + 1

                    Else
                        iii = Val(datatbl.Rows(i)("PALLET SIZE"))
                        Tco = False
                        Tcon_Butal = 0
                        PalletID = PalletID + 1
                    End If

                    dgv_palleted.Rows.Add(
                                datatbl.Rows(i)("NUM"),
                                datatbl.Rows(i)("ITEM CODE"),
                                datatbl.Rows(i)("ITEM NAME"),
                              datatbl.Rows(i)("QUANTITY"),
                                datatbl.Rows(i)("UOM"),
                                PalletID,
                                iii,
                                datatbl.Rows(i)("BATCH #"),
                                datatbl.Rows(i)("PALLET SIZE"),
                                datatbl.Rows(i)("MACHINE"),
                                datatbl.Rows(i)("MNF Date"),
                                datatbl.Rows(i)("EXP Date"),
                                datatbl.Rows(i)("SHIFT"))
                    '          i += 1
                Next
            Next

        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub

    Private Sub Option1_Click(sender As Object, e As EventArgs)
        fitCols(dgv_forPallet)
        fitCols(dgv_palleted)
    End Sub
    Function iAdd() As Integer
        If isAllowEmpty(Me) = False Then
            Dim i As Integer = InsertIntoIIT()
            If i > 0 Then
                Dim DocEntry As Integer = InsertIntoDI(i)
                Return DocEntry
            End If
        End If
    End Function
    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles btn_ok.Click
        Dim DocEntry As Integer = 0
        If transaction_type = "A" Then
            iAdd()
            If DocEntry > 0 Then
                iFind(DocEntry)
            End If
        ElseIf transaction_type = "F" Then
            iFind(DocEntry)
        End If
    End Sub

    Function iFind(Optional iDocEnddtry As Integer = 0) As Integer
        SAP_SQL_PARAM.Clear()
        SAP_SQL_PARAM.Add(154)
        SAP_SQL_PARAM.Add(uc_palletingNum.iText)
        Dim iBt As DataTable = iSQL_DATATABLE()
        uc_fromWHse_lbl.iText = iBt.Rows(0)("fwhseName")

        uc_fromWHse.iText = iBt.Rows(0)("U_fwhse")
        uc_fromWHse_lbl.iText = iBt.Rows(0)("TwhseName")

        uc_DocDate.iDate = iBt.Rows(0)("CreateDate")
        uc_TaxDate.iDate = iBt.Rows(0)("PostingDate")

        txt_remarks.Text = iBt.Rows(0)("Remark")

        uc_docnum.iText = iBt.Rows(0)("U_prodDocNum")
        uc_docnum_lbl.iText = iBt.Rows(0)("U_rfpDocNum")

        uc_release.iText = iBt.Rows(0)("ReleasedByName")
        '  uc_release_lbl.iText = iBt.Rows(0)("ReleasedByName")

        uc_recieved.iText = iBt.Rows(0)("RecievedByName")
        '   uc_recieved_lbl.iText = iBt.Rows(0)("RecievedByName")

        uc_paletsizer.iText = iBt.Rows(0)("PalletizerName")
        '   uc_paletsizer_LBl.iText = iBt.Rows(0)("PalletizerName")

        txt_remarks.Text = iBt.Rows(0)("Remark")

        uc_packer.Text = iBt.Rows(0)("PackerName")
        '  uc_packer_lbl.Text = iBt.Rows(0)("PackerName")

        SAP_SQL_PARAM.Clear()
        SAP_SQL_PARAM.Add(155)
        SAP_SQL_PARAM.Add(uc_palletingNum.iText)
        dgv_forPallet.DataSource = iSQL_DATATABLE()

        SAP_SQL_PARAM.Clear()
        SAP_SQL_PARAM.Add(156)
        SAP_SQL_PARAM.Add(uc_palletingNum.iText)
        dgv_palleted.DataSource = iSQL_DATATABLE()

    End Function
    Function InsertIntoDI(JustAddedID As Integer) As Integer
        Try
            Dim iRemarks As String = Now.ToString & "Posted from Palleting Add-on from Reciept From Prod with Document # " & uc_docnum_lbl.iText & vbNewLine & " " & txt_remarks.Text

            oConnect()

            Dim iHeader As SAPbobsCOM.GeneralService
            Dim iHeaderData As SAPbobsCOM.GeneralData
            Dim iChild As SAPbobsCOM.GeneralDataCollection
            Dim iChildData As SAPbobsCOM.GeneralData

            Dim oCompService As SAPbobsCOM.CompanyService = oCompany.GetCompanyService()

            iHeader = oCompany.GetCompanyService.GetGeneralService("OPLT")
            iHeaderData = iHeader.GetDataInterface(SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralData)
            iHeaderData.SetProperty("Remark", iRemarks)
            iHeaderData.SetProperty("U_fwhse", uc_fromWHse.iText)
            iHeaderData.SetProperty("U_twhse", uc_ToWHse.iText)
            iHeaderData.SetProperty("U_prodDocNum", uc_docnum.iText)
            iHeaderData.SetProperty("U_rfpDocNum", uc_docnum_lbl.iText)
            iHeaderData.SetProperty("U_ReleasedBy", uc_release.iText)
            iHeaderData.SetProperty("U_RecievedBy", uc_recieved.iText)
            iHeaderData.SetProperty("U_Palletizer", uc_paletsizer.iText)
            iHeaderData.SetProperty("U_packer", uc_packer.iText)
            iHeaderData.SetProperty("U_DatePalleted", Now.ToShortDateString.ToString)
            iHeaderData.SetProperty("U_IT_DocEntry", JustAddedID)
            iChild = iHeaderData.Child("PLT1")
            For i = 0 To dgv_forPallet.Rows.Count - 1
                iChildData = iChild.Add()
                iChildData.SetProperty("U_linenum", dgv_forPallet.Rows(i).Cells(0).Value.ToString)
                iChildData.SetProperty("U_Itemcode", dgv_forPallet.Rows(i).Cells(1).Value.ToString)
                iChildData.SetProperty("U_Quantity", CInt(dgv_forPallet.Rows(i).Cells(3).Value.ToString))
                iChildData.SetProperty("U_uom", dgv_forPallet.Rows(i).Cells(4).Value.ToString)
                iChildData.SetProperty("U_batchnum", dgv_forPallet.Rows(i).Cells(5).Value.ToString)
                iChildData.SetProperty("U_palletsize", dgv_forPallet.Rows(i).Cells(6).Value.ToString)
                iChildData.SetProperty("U_mnfd", dgv_forPallet.Rows(i).Cells(8).Value.ToString)
                iChildData.SetProperty("U_expd", dgv_forPallet.Rows(i).Cells(9).Value.ToString)
                iChildData.SetProperty("U_admd", "x")
                iChildData.SetProperty("U_sft", dgv_forPallet.Rows(i).Cells(10).Value.ToString)
                iChildData.SetProperty("U_machine", dgv_forPallet.Rows(i).Cells(7).Value.ToString)
            Next
            iChild = iHeaderData.Child("PLT2")
            For i = 0 To dgv_palleted.Rows.Count - 1
                iChildData = iChild.Add()
                iChildData.SetProperty("U_linenum", dgv_palleted.Rows(i).Cells(0).Value.ToString)
                iChildData.SetProperty("U_palletedQty", dgv_palleted.Rows(i).Cells(6).Value.ToString)
                iChildData.SetProperty("U_palletid", dgv_palleted.Rows(i).Cells(5).Value.ToString)
            Next
            iHeader.Add(iHeaderData)

            MainMenu.g_notif_panel(1, " PALLETING DETAILS - Transaction success", 2)
            Dim iDOcEntry As Integer = oCompany.GetNewObjectKey
            Return iDOcEntry
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
            Return 0
        End Try
    End Function


    Function InsertIntoIIT() As Integer
        Try
            Dim iRemarks As String = Now.ToString & " Posted from Palleting Add-on from Reciept From Prod with Document # " & uc_docnum_lbl.iText & vbNewLine & " " & txt_remarks.Text
            Dim iIT As SAPbobsCOM.StockTransfer = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oStockTransfer)

            ''     iIT.DocDate = DateTime.Now
            iIT.DocDate = uc_DocDate.iDate
            iIT.TaxDate = uc_TaxDate.iDate
            iIT.FromWarehouse = uc_fromWHse.iText
            iIT.ToWarehouse = uc_ToWHse.iText
            iIT.Comments = iRemarks
            iIT.UserFields.Fields.Item("U_APP_TransferType").Value = "PLT"


            Dim iBchCount = 0
            For i = 0 To dgv_palleted.Rows.Count - 1
                If i <> 0 Then
                    iIT.Lines.Add()
                    iIT.Lines.SetCurrentLine(i)
                End If

                iIT.Lines.ItemCode = dgv_palleted.Rows(i).Cells(1).Value
                iIT.Lines.Quantity = CDbl(dgv_palleted.Rows(i).Cells(6).Value)
                iIT.Lines.FromWarehouseCode = uc_fromWHse.iText
                iIT.Lines.WarehouseCode = uc_ToWHse.iText
                iIT.Lines.UserFields.Fields.Item("U_RFPRef").Value = uc_docnum_lbl.iText
                iIT.Lines.UserFields.Fields.Item("U_APP_PalletId").Value = dgv_palleted.Rows(i).Cells(5).Value & ""
                iIT.Lines.UserFields.Fields.Item("U_Machine").Value = dgv_palleted.Rows(i).Cells(9).Value & ""



                If iBchCount <> 0 Then
                    iBchCount += 1
                    iIT.Lines.BatchNumbers.Add()
                    iIT.Lines.BatchNumbers.SetCurrentLine(iBchCount)
                End If

                iIT.Lines.BatchNumbers.BatchNumber = dgv_palleted.Rows(i).Cells(7).Value
                iIT.Lines.BatchNumbers.Quantity = CDbl(dgv_palleted.Rows(i).Cells(6).Value)
                '-'  iIT.Lines.BatchNumbers.UserFields.Fields.Item("U_MachineNo").Value = dgv_palleted.Rows(i).Cells(9).Value & ""
                'iIT.Lines.BatchNumbers.

                'iIT.Lines.BatchNumbers.Add()
                'iIT.Lines.BinAllocations.BinActionType = SAPbobsCOM.BinActionTypeEnum.batToWarehouse
                'iIT.Lines.BatchNumbers.SetCurrentLine(iBchCount)
                'iIT.Lines.BatchNumbers.BatchNumber = dgv_palleted.Rows(i).Cells(7).Value
                'iIT.Lines.BatchNumbers.Quantity = CDbl(dgv_palleted.Rows(i).Cells(6).Value)
                'iBchCount += 1
            Next
            Dim ix As Integer
            Dim iMsg As String
            ix = iIT.Add()
            oCompany.GetLastError(ix, iMsg)
            MainMenu.g_notif_panel(0, ix, 2)
            MainMenu.g_notif_panel(0, ix & " -  " & iMsg, 2)
            Dim DocNum As Integer = oCompany.GetNewObjectKey()


            If ix = 0 Then
                Return DocNum
            Else
                Return 0
            End If
        Catch ex As Exception

            MainMenu.g_notif_panel(0, ex.Message, 2)
            Return 0
        End Try

    End Function


    Sub turd()
        If SYSTEM_MODE = "SAP" Then
            If transaction_type = "A" Then
                Try
                    SAP_SQL_PARAM.Clear()
                    SAP_SQL_PARAM.Add(142)
                    SAP_SQL_PARAM.Add(uc_docnum.iText)
                    SAP_SQL_PARAM.Add(uc_docnum_lbl.iText)
                    Dim iBt As DataTable = iSQL_DATATABLE()

                    dgv_forPallet.DataSource = iBt
                    dgv_forPallet.Columns(8).DefaultCellStyle.Format = "dd/MM/yyyy"

                    uc_LP_Docnum.iText = ""
                    uc_LP_pallet_num.iText = 0
                    uc_LP_qty.iText = 0

                    SAP_SQL_PARAM.Clear()
                    SAP_SQL_PARAM.Add(145)
                    SAP_SQL_PARAM.Add(iBt.Rows(0)("ITEM CODE"))
                    SAP_SQL_PARAM.Add(iBt.Rows(0)("MNF DATE"))
                    SAP_SQL_PARAM.Add(iBt.Rows(0)("MACHINE"))

                    Dim iBt1 As DataTable = iSQL_DATATABLE()
                    If iBt1.Rows.Count > 0 Then
                        uc_LP_Docnum.iText = iBt1.Rows(0)("MNF DATE")
                        uc_LP_date.iDate = iBt1.Rows(0)("MNF DATE")
                        uc_LP_pallet_num.iText = iBt1.Rows(0)("U_palletid")
                        uc_LP_qty.iText = iBt1.Rows(0)("QTYSUM")
                    End If
                    Timer1.Enabled = False
                    iPopulate(iBt)

                Catch ex As Exception
                    Timer1.Enabled = False
                    MainMenu.g_notif_panel(0, "118 - " & ex.Message, 2)
                End Try
            End If
        End If
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        turd()
        Timer1.Enabled = False
    End Sub


    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        fitCols(dgv_forPallet)
        fitCols(dgv_palleted)
    End Sub


    Private Sub txt_uc_palletingNum_TextChanged(sender As Object, e As EventArgs) Handles txt_uc_palletingNum.TextChanged
        If transaction_type = "F" Then
            btn_ok.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        turd()
    End Sub

    Private Sub uc_LP_Docnum_Load(sender As Object, e As EventArgs) Handles uc_LP_Docnum.Load

    End Sub
End Class