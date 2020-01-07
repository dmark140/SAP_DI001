Public Class Form1
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Call oConnect()
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Call oDisconnect()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call CreateBP()
    End Sub
    Private Sub CreateBP()
        Call oConnect()
        Dim oBP As SAPbobsCOM.BusinessPartners
        Dim lRetCode, lErrCode As Integer
        Dim sErrMsg As String = ""
        'Prepare empty oBP Object:
        oBP = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)
        'oBP = oCompany.GetBusinessObject(2)
        oBP.CardCode = "C08154712"
        oBP.CardName = "James Tiberius Kirk"
        oBP.CardType = SAPbobsCOM.BoCardTypes.cCustomer
        'Add the new BP to the database
        lRetCode = oBP.Add()
        If lRetCode <> 0 Then
            oCompany.GetLastError(lErrCode, sErrMsg)
            MessageBox.Show("Error: " + sErrMsg + "; Code: " + lErrCode.ToString)
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call oUpdateBP()
    End Sub
    Private Sub oUpdateBP()
        Try
            Call oConnect()
            Dim oBP As SAPbobsCOM.BusinessPartners = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)

            Dim iUrs As SAPbobsCOM.Users = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUsers)




            Dim lRetCode, lErrCode As Integer
            Dim sErrMsg As String = ""
            If oBP.GetByKey("C08154711") = True Then 'here we use an existing record…
                'First line is always prepared (in any business object that has lines…)
                oBP.CardName = "Leo"

                oBP.ContactEmployees.SetCurrentLine(0)
                oBP.ContactEmployees.LastName = "DeBorja"
                oBP.ContactEmployees.FirstName = "Jerome"

                oBP.ContactEmployees.SetCurrentLine(1)
                oBP.ContactEmployees.LastName = "Cabillos"
                oBP.ContactEmployees.FirstName = "Leo"


                lRetCode = oBP.Update()
                If lRetCode <> 0 Then
                    oCompany.GetLastError(lErrCode, sErrMsg)
                    MessageBox.Show("Error: " + sErrMsg + "; Code: " + lErrCode.ToString)
                End If
            Else
                MessageBox.Show("Business Partner C08154711 not found!")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Invoice_Payement()
    End Sub
    Private Sub Invoice_Payement()
        ''INVOICE WITH PAYMENT
        Call oConnect()
        Try
            'If oCompany.InTransaction = False Then
            '    oCompany.StartTransaction()
            'End If

            Try
                Dim oInvoice As SAPbobsCOM.Documents
                oInvoice = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInvoices)
                oInvoice.CardCode = "C20000"
                oInvoice.DocDate = "02-07-2013"
                oInvoice.DocType = SAPbobsCOM.BoDocumentTypes.dDocument_Items ''For Service Type Document

                ''FIRST LINE IN Sales Order                
                oInvoice.Lines.BaseEntry = 361 ''361 'DocEntry of Sales Order
                oInvoice.Lines.BaseLine = 0 'Copy first line
                oInvoice.Lines.BaseType = SAPbobsCOM.BoObjectTypes.oOrders '17 'Sales Order base document
                oInvoice.Lines.PriceAfterVAT = 10
                oInvoice.Lines.Quantity = 1
                'oInvoice.Lines.AccountCode = "400000"

                ''SECOND LINE IN Sales Order     
                oInvoice.Lines.Add()
                oInvoice.Lines.BaseEntry = 361 ''361 'DocEntry of Sales Order
                oInvoice.Lines.BaseLine = 1 'Copy first line
                oInvoice.Lines.BaseType = SAPbobsCOM.BoObjectTypes.oOrders '17 'Sales Order base document
                oInvoice.Lines.PriceAfterVAT = 20
                oInvoice.Lines.Quantity = 1
                ''THIRD LINE IN Sales Order     
                oInvoice.Lines.Add()
                oInvoice.Lines.BaseEntry = 361 ''361 'DocEntry of Sales Order
                oInvoice.Lines.BaseLine = 2 'Copy first line
                oInvoice.Lines.BaseType = SAPbobsCOM.BoObjectTypes.oOrders '17 'Sales Order base document
                oInvoice.Lines.PriceAfterVAT = 30
                oInvoice.Lines.Quantity = 1

                retVal = oInvoice.Add
                If retVal <> 0 Then
                    oCompany.GetLastError(retVal, retStr)
                    MsgBox("Error " & retVal & " " & retStr)
                    'oCompany.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                Else
                    MsgBox("Invoice number " & oCompany.GetNewObjectKey & " created")
                    InvNum = oCompany.GetNewObjectKey
                    'InvNum = 822
                End If
                oInvoice = Nothing
                retVal = -1
                retStr = ""
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                If InvNum <> "" Then
                    Dim oIncomingPymt As SAPbobsCOM.Payments
                    oIncomingPymt = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oIncomingPayments)
                    oIncomingPymt.CardCode = "C20000"
                    oIncomingPymt.DocDate = "02-07-2013"
                    oIncomingPymt.Invoices.DocEntry = CInt(InvNum)
                    oIncomingPymt.Invoices.SumApplied = 60
                    oIncomingPymt.CashAccount = "161000"
                    oIncomingPymt.CashSum = 60

                    retVal = oIncomingPymt.Add
                    If retVal <> 0 Then
                        oCompany.GetLastError(retVal, retStr)
                        MsgBox("Error " & retVal & " " & retStr)
                        Try
                            'oCompany.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                        Catch ex As Exception
                        End Try

                    Else
                        MsgBox("Incoming Payment number " & oCompany.GetNewObjectKey & " added")
                        'oCompany.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                    End If

                    oIncomingPymt = Nothing
                    retVal = -1
                    retStr = ""
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                'Try
                '    oCompany.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                'Catch exc As Exception
                'End Try
            End Try
        Catch ex As Exception
            'Try
            '    oCompany.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
            'Catch exc As Exception
            'End Try
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ''WORKING WITH XML
        Try
            Call oConnect()

            oCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode
            Dim oInvoice As SAPbobsCOM.Documents
            oInvoice = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInvoices)
            If oInvoice.GetByKey(366) = False Then
                oCompany.GetLastError(retVal, retStr)
                MsgBox("Failed to Retrieve Invoice" & retVal & " " & retStr)
                Exit Sub
            End If
            'Save the object as an xml file
            'oInvoice.Comments = oInvoice.Comments & "SAMPLE COMMENTS" 'ipapatung  yung last comment
            oInvoice.Comments = "SAMPLE COMMENTS"
            oInvoice.SaveXML("C:\Program Files (x86)\SAP\SAP Business One SDK\Invoice.xml")

            Dim schema As String
            schema = oCompany.GetBusinessObjectXmlSchema(SAPbobsCOM.BoObjectTypes.oInvoices)
            'MsgBox(schema)


            oInvoice = oCompany.GetBusinessObjectFromXML("C:\Program Files (x86)\SAP\SAP Business One SDK\Invoice.xml", 0)
            retVal = oInvoice.Add
            If retVal <> 0 Then
                oCompany.GetLastError(retVal, retStr)
                MsgBox("Error " & retVal & " " & retStr)
            Else
                MsgBox("Invoice number " & oCompany.GetNewObjectKey & " created")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim frm = New BrowserFRM
        frm.ShowDialog()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        ''ADD UDF
        Dim oUDF As SAPbobsCOM.UserFieldsMD
        Try
            Call oConnect()

            'Dim oUDF As SAPbobsCOM.UserFieldsMD
            'oUDF = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)
            'oUDF.TableName = "OITM"
            'oUDF.Name = "TB1_Course"
            'oUDF.Description = "Course UDF"
            'oUDF.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
            'oUDF.EditSize = 20
            'retVal = oUDF.Add
            'If retVal <> 0 Then
            '    oCompany.GetLastError(retVal, retStr)
            '    MsgBox("Error " & retVal & " " & retStr)
            'Else
            '    MsgBox("UDF Added")
            'End If  

            oUDF = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)
            Dim isAdd As Boolean = True
            Dim oRecordSet As SAPbobsCOM.Recordset
            oRecordSet = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oRecordSet.DoQuery("SELECT FieldID FROM CUFD where TableID = 'OITM' and AliasID = 'TB1_Course' ")
            If oRecordSet.RecordCount > 0 Then
                isAdd = False ''FOR UPDATE
                oUDF.GetByKey("OITM", oRecordSet.Fields.Item("FieldID").Value)
            Else
                isAdd = True ''FOR ADDING
            End If
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oRecordSet)
            oUDF.TableName = "OITM"
            oUDF.Name = "TB1_Course"
            oUDF.Description = "Course UDF Sample"
            oUDF.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
            oUDF.EditSize = 20
            'oUDF.LinkedTable = "TB1_DVD"
            If isAdd Then
                retVal = oUDF.Add
            Else
                retVal = oUDF.Update
            End If

            If retVal <> 0 Then
                oCompany.GetLastError(retVal, retStr)
                MsgBox("Error " & retVal & " " & retStr)
            Else
                MsgBox("UDF Added")
            End If
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oUDF)
            GC.Collect()

        Catch ex As Exception
            MsgBox(ex.ToString)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oUDF)
            GC.Collect()
        End Try

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ''ADD UDT
        Call oConnect()
        Dim oUsrTble As SAPbobsCOM.UserTablesMD
        oUsrTble = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserTables)

        If oUsrTble.GetByKey("TB1_DVD") Then
            MsgBox("TB1_DVD Table already exists.")
            Return
        End If

        oUsrTble.TableName = "TB1_DVD"
        oUsrTble.TableDescription = "DVD Management"
        retVal = oUsrTble.Add
        If retVal <> 0 Then
            oCompany.GetLastError(retVal, retStr)
            MsgBox("Error " & retVal & " " & retStr)
        Else
            MsgBox("UDT TB1_DVD Added")
        End If
        'oUsrTble = Nothing
        System.Runtime.InteropServices.Marshal.ReleaseComObject(oUsrTble)
        GC.Collect()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ''ADD UDF TO UDT
        Call oConnect()
        Dim oUDF As SAPbobsCOM.UserFieldsMD
        oUDF = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)
        oUDF.TableName = "@TB1_DVD"
        oUDF.Name = "AISLE"
        oUDF.Description = "Aisle Number"
        oUDF.Type = SAPbobsCOM.BoFieldTypes.db_Numeric
        oUDF.EditSize = 2
        retVal = oUDF.Add
        If retVal <> 0 Then
            oCompany.GetLastError(retVal, retStr)
            MsgBox("Error " & retVal & " " & retStr)
        Else
            MsgBox("UDF AISLE Added")
        End If

        oUDF = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)
        oUDF.TableName = "@TB1_DVD"
        oUDF.Name = "SECTION"
        oUDF.Description = "Section Number"
        oUDF.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUDF.EditSize = 20
        retVal = oUDF.Add
        If retVal <> 0 Then
            oCompany.GetLastError(retVal, retStr)
            MsgBox("Error " & retVal & " " & retStr)
        Else
            MsgBox("UDF SECTION Added")
        End If

        oUDF = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)
        oUDF.TableName = "@TB1_DVD"
        oUDF.Name = "RENTED"
        oUDF.Description = "Rented/Available"

        oUDF.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUDF.EditSize = 1

        oUDF.ValidValues.Value = "Y"
        oUDF.ValidValues.Description = "Y"
        oUDF.ValidValues.Add()

        oUDF.ValidValues.Value = "N"
        oUDF.ValidValues.Description = "N"
        oUDF.ValidValues.Add()

        retVal = oUDF.Add
        If retVal <> 0 Then
            oCompany.GetLastError(retVal, retStr)
            MsgBox("Error " & retVal & " " & retStr)
        Else
            MsgBox("UDF RENTED Added")
        End If

        oUDF = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)
        oUDF.TableName = "@TB1_DVD"
        oUDF.Name = "CARDCODE"
        oUDF.Description = "Card Code"
        oUDF.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUDF.EditSize = 20
        retVal = oUDF.Add
        If retVal <> 0 Then
            oCompany.GetLastError(retVal, retStr)
            MsgBox("Error " & retVal & " " & retStr)
        Else
            MsgBox("UDF CARDCODE Added")
        End If

        System.Runtime.InteropServices.Marshal.ReleaseComObject(oUDF)
        GC.Collect()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ''REMOVE UDT
        Call oConnect()
        Dim oUsrTble As SAPbobsCOM.UserTablesMD
        oUsrTble = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserTables)
        If oUsrTble.GetByKey("TB1_DVD") = True Then
            retVal = oUsrTble.Remove
        End If
        If retVal <> 0 Then
            oCompany.GetLastError(retVal, retStr)
            MsgBox("Error " & retVal & " " & retStr)
        Else
            MsgBox("UDT TB1_DVD Removed")
        End If

        System.Runtime.InteropServices.Marshal.ReleaseComObject(oUsrTble)
        GC.Collect()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ''ADD DATA TO UDT
        Call oConnect()
        Dim oUserTable As SAPbobsCOM.UserTable
        oUserTable = oCompany.UserTables.Item("TB1_DVD")
        oUserTable.Code = "1"
        oUserTable.Name = "Avatar"
        oUserTable.UserFields.Fields.Item("U_AISLE").Value = "2"
        oUserTable.UserFields.Fields.Item("U_SECTION").Value = "Science Fiction"
        oUserTable.UserFields.Fields.Item("U_RENTED").Value = "N"

        retVal = oUserTable.Add
        If retVal <> 0 Then
            oCompany.GetLastError(retVal, retStr)
            MsgBox("Error " & retVal & " " & retStr)
        Else
            MsgBox("Record Avatar Added")
        End If

        oUserTable = oCompany.UserTables.Item("TB1_DVD")
        oUserTable.Code = "2"
        oUserTable.Name = "The Shining"
        oUserTable.UserFields.Fields.Item("U_AISLE").Value = "6"
        oUserTable.UserFields.Fields.Item("U_SECTION").Value = "Horrow"
        oUserTable.UserFields.Fields.Item("U_RENTED").Value = "Y"

        retVal = oUserTable.Add
        If retVal <> 0 Then
            oCompany.GetLastError(retVal, retStr)
            MsgBox("Error " & retVal & " " & retStr)
        Else
            MsgBox("Record The Shining Added")
        End If

        oUserTable = oCompany.UserTables.Item("TB1_DVD")
        oUserTable.Code = "3"
        oUserTable.Name = "Coraline"
        oUserTable.UserFields.Fields.Item("U_AISLE").Value = "5"
        oUserTable.UserFields.Fields.Item("U_SECTION").Value = "Animation"
        oUserTable.UserFields.Fields.Item("U_RENTED").Value = "N"

        retVal = oUserTable.Add
        If retVal <> 0 Then
            oCompany.GetLastError(retVal, retStr)
            MsgBox("Error " & retVal & " " & retStr)
        Else
            MsgBox("Record Coraline Added")
        End If

        System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserTable)
        GC.Collect()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
