Public Class CreateAR
    Public oRecordSet As SAPbobsCOM.Recordset
    Public oRecordSet1 As SAPbobsCOM.Recordset
    Dim oBusinessPartner As SAPbobsCOM.BusinessPartners
    Dim oBusinessPartner1 As SAPbobsCOM.BusinessPartners
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.Dispose()
    End Sub

    Private Sub CreateAR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0

        Call oConnect()
        Try
            DataGridView1.Rows.Clear()
            oRecordSet = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oBusinessPartner = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)
            'oRecordSet.DoQuery("select A.DocEntry,A.CardName,A.CardCode ,B.LineNum,B.ObjType,A.DocDueDate,B.Quantity,B.Price,B.LineTotal,B.ItemCode     " &
            '                   " from ORDR  as a left join RDR1  as b on a.DocEntry=b.DocEntry  and B.TrgetEntry  = null where a.DocStatus='O'")
            oRecordSet.DoQuery(" Select A.DocEntry, A.CardName, A.CardCode, B.LineNum, B.ObjType, A.DocDueDate, B.Quantity, B.Price, B.LineTotal, B.ItemCode   
      From ORDR As a left Join RDR1 As b On a.DocEntry=b.DocEntry   left Join
   OINV As c On C.DocNum=A.DocNum  left Join INV1 As D On D.itemcode=D.itemcode And D.BaseDocNum=C.DocNum 
	  Where a.DocStatus ='O' and D.itemcode is null ")

            If oRecordSet.RecordCount > 0 Then
                Do Until oRecordSet.EoF = True
                    DataGridView1.Rows.Add(i + 1,
                                            oRecordSet.Fields.Item("CardCode").Value,
                                            oRecordSet.Fields.Item("CardName").Value,
                                            oRecordSet.Fields.Item("DocEntry").Value,
                                            oRecordSet.Fields.Item("LineNum").Value,
                                            oRecordSet.Fields.Item("ObjType").Value,
                                            oRecordSet.Fields.Item("DocDueDate").Value,
                                            oRecordSet.Fields.Item("Price").Value,
                                            oRecordSet.Fields.Item("Quantity").Value,
                                            oRecordSet.Fields.Item("ItemCode").Value)
                    i += 1
                    oRecordSet.MoveNext()
                Loop
            End If

            oRecordSet = Nothing
            Call List_of_Acct()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub
    Private Sub List_of_Acct()
        Try
            oRecordSet1 = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oBusinessPartner1 = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)
            oRecordSet1.DoQuery("Select AcctCode,AcctName from OACT order by AcctCode asc")
            Do Until oRecordSet1.EoF = True
                txtcashAcc.Items.Add(oRecordSet1.Fields.Item("AcctCode").Value)
                oRecordSet1.MoveNext()
            Loop

            'Dim dt As New DataTable("OACT")
            'Dim ds As New DataSet
            '' da.Fill(dt)
            'If oRecordSet1.RecordCount > 0 Then
            '    txtcashAcc.DisplayMember = "AcctName" 'What is displayed
            '    txtcashAcc.ValueMember = "AcctCode"
            '    txtcashAcc.DataSource = dt
            'Else
            '    txtcashAcc.DataSource = Nothing
            'End If
            oRecordSet1 = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            txtcardcode.Text = DataGridView1.Item(1, i).Value
            txtcardname.Text = DataGridView1.Item(2, i).Value
            txtdocentry.Text = DataGridView1.Item(3, i).Value
            txtlinenum.Text = DataGridView1.Item(4, i).Value
            txtobjtype.Text = DataGridView1.Item(5, i).Value
            txtDateDue.Text = DataGridView1.Item(6, i).Value
            txtprices.Text = DataGridView1.Item(7, i).Value
            txtAvailQty.Text = DataGridView1.Item(8, i).Value
            txtitemcode.Text = DataGridView1.Item(9, i).Value
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''INVOICE WITH PAYMENT
        ' Call oConnect()
        Try
            Try
                Dim oInvoice As SAPbobsCOM.Documents
                oInvoice = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInvoices)
                oInvoice.CardCode = txtcardcode.Text
                oInvoice.DocDate = txtDateDue.Value.ToString("MM-dd-yyyy") '"02-07-2013"
                oInvoice.DocType = SAPbobsCOM.BoDocumentTypes.dDocument_Items ''For Service Type Document 

                ' oInvoice.Lines.Add()
                oInvoice.Lines.ItemCode = txtItemCode.Text
                oInvoice.Lines.BaseEntry = txtdocentry.Text ''361 'DocEntry of Sales Order
                oInvoice.Lines.BaseLine = txtlinenum.Text 'Copy first line
                oInvoice.Lines.BaseType = SAPbobsCOM.BoObjectTypes.oOrders '17 'Sales Order base document
                oInvoice.Lines.PriceAfterVAT = txtprices.Text
                oInvoice.Lines.Quantity = txtqty.Text

                retVal = oInvoice.Add
                If retVal <> 0 Then
                    oCompany.GetLastError(retVal, retStr)
                    MsgBox("Error " & retVal & " " & retStr)
                Else
                    MsgBox("Invoice number " & oCompany.GetNewObjectKey & " created")
                    InvNum = oCompany.GetNewObjectKey
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
                    oIncomingPymt.CardCode = txtcardcode.Text
                    oIncomingPymt.DocDate = txtDateDue.Value.ToString("MM-dd-yyyy")
                    oIncomingPymt.Invoices.DocEntry = CInt(InvNum)
                    oIncomingPymt.Invoices.DiscountPercent = 0
                    oIncomingPymt.Invoices.SumApplied = Val(txtprices.Text) * Val(txtqty.Text)
                    oIncomingPymt.CashAccount = txtcashAcc.Text
                    oIncomingPymt.CashSum = Val(txtprices.Text) * Val(txtqty.Text)

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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcashAcc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtcashAcc.SelectedIndexChanged

    End Sub
End Class