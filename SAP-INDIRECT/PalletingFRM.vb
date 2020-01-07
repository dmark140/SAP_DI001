Public Class PalletingFRM
    Public oRecordSet As SAPbobsCOM.Recordset
    Dim oBusinessPartner As SAPbobsCOM.BusinessPartners
    Public oRecordSet1 As SAPbobsCOM.Recordset
    Dim oBusinessPartner1 As SAPbobsCOM.BusinessPartners
    Private Sub PalletingFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call oConnect()
    End Sub
    Private Sub PalletingFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Call oDisconnect()
        End
    End Sub

    Public Function oConnect1() As Boolean
        Try
            If oCompany.Connected = True Then
                Return True
            End If
        Catch ex As Exception
        End Try
        Try
            oCompany = New SAPbobsCOM.Company
            oCompany.Server = "10.10.0.7" ' SQL server 
            oCompany.CompanyDB = "TEST_0107" ' Sql Database name
            oCompany.UserName = "IPICPADM04" 'SAP username credentials 
            oCompany.Password = "Thunder@69" 'SAP password credentials 
            oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2014 'db server type
            oCompany.DbUserName = "sa"
            oCompany.DbPassword = "P@ssw0rd810~"
            oCompany.LicenseServer = "10.10.0.7"
            retVal = oCompany.Connect
            If retVal <> 0 Then
                oCompany.GetLastError(retVal, retStr)
                MsgBox("Error Code:" & retVal & " " & retStr)
                End
            Else
                'MsgBox("You Are connected to:" & oCompany.CompanyDB.ToString, vbInformation)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
        Return True
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Try
            DataGridView1.Rows.Clear()
            oRecordSet = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oBusinessPartner = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)
            oRecordSet.DoQuery("Select T4.U_APP_MachineCode 'Machine',T0.ItemCode ,T0.Dscription ,T3.U_APP_PalletSize ,sum(T0.Quantity ) 'Tqty' 
                                FROM IGN1 T0   LEFT JOIN OIGN T1 ON T0.DocEntry = T1.DocEntry AND T0.BaseType = 202  
                                LEFT JOIN OWOR T2 ON T0.BaseRef = T2.DocNum --Production Order
                                LEFT JOIN OITM T3 ON T0.ItemCode = T3.ItemCode --Item Master Data
                                LEFT JOIN vwApp_IBT1 T4 ON T1.ObjType = T4.BaseType AND T1.DocNum = T4.BaseNum   AND T1.DocEntry = T4.BaseEntry 
                                WHERE T3.U_APP_ItemSGroup = 'ULP' and t3.itmsgrpcod='105' and T1.DocDate>= '" & txtfrom.Value.ToString("yyyy-MM-dd 00:00:00") & "'
                                and T1.DocDate<='" & txtto.Value.ToString("yyyy-MM-dd 00:00:00") & "' Group by  T4.U_APP_MachineCode  ,T0.ItemCode  ,T0.Dscription ,T3.U_APP_PalletSize 
                                order by U_APP_MachineCode,ItemCode asc") ' ,T1.DocDate 
            If oRecordSet.RecordCount > 0 Then
                Do Until oRecordSet.EoF = True
                    DataGridView1.Rows.Add(i + 1,
                                            oRecordSet.Fields.Item("Machine").Value,
                                            oRecordSet.Fields.Item("ItemCode").Value,
                                            oRecordSet.Fields.Item("Dscription").Value,
                                            oRecordSet.Fields.Item("U_APP_PalletSize").Value,
                                            oRecordSet.Fields.Item("Tqty").Value) ' oRecordSet.Fields.Item("DocDate").Value,
                    i += 1
                    oRecordSet.MoveNext()
                Loop
            End If

            oRecordSet = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    '    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '        Dim i As Integer
    '        Try
    '            DataGridView1.Rows.Clear()
    '            oRecordSet = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
    '            oBusinessPartner = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)

    '            oRecordSet.DoQuery("SELECT T0.ItemCode ,T1.DocDate ,T0.Dscription ,T0.Quantity ,T0.UomCode 'UoM' ,T4.MnfDate ,T4.ExpDate
    '	   ,T4.BatchNum ,T4.U_APP_MachineCode 'Machine'  ,T0.BaseRef 'PO#' ,T1.Comments 'Remarks' ,T1.BPLName 'Branch'  ,T3.U_APP_PalletSize
    '	   ,convert(int,T0.Quantity /  T3.U_APP_PalletSize )  'Tbox'  ,T0.Quantity - (T3.U_APP_PalletSize * (convert(int,T0.Quantity /  T3.U_APP_PalletSize )))  'Tbutal'
    '	   ,T1.DocNum  FROM IGN1 T0  LEFT JOIN OIGN T1 ON T0.DocEntry = T1.DocEntry AND T0.BaseType = 202 --Receipt From Produciton Details
    '        LEFT JOIN OWOR T2 ON T0.BaseRef = T2.DocNum  LEFT JOIN OITM T3 ON T0.ItemCode = T3.ItemCode  
    '        LEFT JOIN vwApp_IBT1 T4 ON T1.ObjType = T4.BaseType AND T1.DocNum = T4.BaseNum  AND T1.DocEntry = T4.BaseEntry 
    '        WHERE T3.U_APP_ItemSGroup = 'ULP' and t3.itmsgrpcod='105'  and  T1.DocDate>= '" & txtfrom.Value.ToString("yyyy-MM-dd 00:00:00") & "'
    '         and T1.DocDate<='" & txtto.Value.ToString("yyyy-MM-dd 00:00:00") & "'")
    '            If oRecordSet.RecordCount > 0 Thenk
    '                Do Until oRecordSet.EoF = True
    '                    DataGridView1.Rows.Add(i + 1,
    '                                           "",
    '                                            oRecordSet.Fields.Item("Machine").Value,
    '                                            oRecordSet.Fields.Item("ItemCode").Value,
    '                                            oRecordSet.Fields.Item("Dscription").Value,
    '                                            oRecordSet.Fields.Item("Quantity").Value,
    '                                            oRecordSet.Fields.Item("U_APP_PalletSize").Value,
    '                                            oRecordSet.Fields.Item("Tbox").Value,
    '                                            oRecordSet.Fields.Item("Tbutal").Value)
    '                    i += 1
    '                    oRecordSet.MoveNext()
    '                Loop
    '            End If

    '            oRecordSet = Nothing
    '            ' Call List_of_Acct()
    '        Catch ex As Exception
    '            MsgBox(ex.Message, vbCritical)
    '        End Try
    '    End Sub


    Private Sub List_of_Acct()
        Try
            oRecordSet1 = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oBusinessPartner1 = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)
            oRecordSet1.DoQuery("Select AcctCode,AcctName from OACT order by AcctCode asc")
            Do Until oRecordSet1.EoF = True
                'txtcashAcc.Items.Add(oRecordSet1.Fields.Item("AcctCode").Value)
                oRecordSet1.MoveNext()
            Loop
            oRecordSet1 = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            txtmachine.Text = DataGridView1.Item(1, i).Value
            'txtdocdate.Text = DataGridView1.Item(2, i).Value
            txtitemcode.Text = DataGridView1.Item(2, i).Value
            txtdesc.Text = DataGridView1.Item(3, i).Value
            txtqty.Text = DataGridView1.Item(4, i).Value
            txtpalletQty.Text = DataGridView1.Item(5, i).Value
            Display_BreakDown()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Display_BreakDown()
        Dim i As Integer = 0
        Dim ii As Integer = 0
        Dim iii As Integer = 0
        Dim Ttlbox, TtlButal As Integer
        Dim Tco As Boolean = False
        Dim Tcon_Butal As Integer = 0
        Dim PalletID As Integer = 0
        DataGridView2.Rows.Clear()
        oRecordSet1 = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oBusinessPartner = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)
        oRecordSet1.DoQuery(" Select T1.DocNum , T1.DocDate, T4.BatchNum, T0.Quantity 
		                        ,T0.BaseRef 'PO#' ,T1.Comments 'Remarks' ,T3.U_APP_PalletSize  'PalletQty' 
                                From IGN1 T0  Left Join OIGN T1 ON T0.DocEntry = T1.DocEntry And T0.BaseType = 202  
                                Left Join OWOR T2 ON T0.BaseRef = T2.DocNum  Left Join OITM T3 ON T0.ItemCode = T3.ItemCode  
                                Left Join vwApp_IBT1 T4 ON T1.ObjType = T4.BaseType And T1.DocNum = T4.BaseNum  
                                And T1.DocEntry = T4.BaseEntry  WHERE T3.U_APP_ItemSGroup = 'ULP' and t3.itmsgrpcod='105'
                                and T1.DocDate>= '" & txtfrom.Value.ToString("yyyy-MM-dd 00:00:00") & "'
                                and T1.DocDate<='" & txtto.Value.ToString("yyyy-MM-dd 00:00:00") & "' 
                                And T4.U_APP_MachineCode='" & txtmachine.Text & "'
                                And T0.Dscription='" & txtdesc.Text & "'")
        If oRecordSet1.RecordCount > 0 Then
            Do Until oRecordSet1.EoF = True
                If Tco = True And Tcon_Butal <> 0 Then
                    Ttlbox = Fix((Val(oRecordSet1.Fields.Item("Quantity").Value) - (Val(oRecordSet1.Fields.Item("PalletQty").Value) - Tcon_Butal)) / Val(oRecordSet1.Fields.Item("PalletQty").Value))
                    TtlButal = Val(oRecordSet1.Fields.Item("PalletQty").Value) * Ttlbox
                    TtlButal = (Val(oRecordSet1.Fields.Item("Quantity").Value) - (Val(oRecordSet1.Fields.Item("PalletQty").Value) - Tcon_Butal)) - TtlButal
                    If TtlButal <> 0 Then
                        Ttlbox = Ttlbox + 2
                    End If
                Else
                    Ttlbox = Fix(Val(oRecordSet1.Fields.Item("Quantity").Value) / Val(oRecordSet1.Fields.Item("PalletQty").Value))
                    TtlButal = Val(oRecordSet1.Fields.Item("PalletQty").Value) * Ttlbox
                    TtlButal = Val(oRecordSet1.Fields.Item("Quantity").Value) - TtlButal
                    If TtlButal <> 0 Then
                        Ttlbox = Ttlbox + 1
                    End If
                End If


                For ii = 1 To Ttlbox
                    If Tco = True And Tcon_Butal <> 0 Then
                        iii = (Val(oRecordSet1.Fields.Item("PalletQty").Value) - Tcon_Butal)
                        Tco = False
                        Tcon_Butal = 0
                    ElseIf Ttlbox = ii And TtlButal <> 0 Then
                        iii = TtlButal
                        Tco = True
                        Tcon_Butal = TtlButal
                        PalletID = PalletID + 1
                    Else
                        iii = Val(oRecordSet1.Fields.Item("PalletQty").Value)
                        Tco = False
                        Tcon_Butal = 0
                        PalletID = PalletID + 1
                    End If
                    DataGridView2.Rows.Add(i + 1,
                                        oRecordSet1.Fields.Item("DocNum").Value,
                                        oRecordSet1.Fields.Item("DocDate").Value,
                                             PalletID,
                                             iii,
                                        oRecordSet1.Fields.Item("BatchNum").Value,
                                        oRecordSet1.Fields.Item("Quantity").Value,
                                        oRecordSet1.Fields.Item("PO#").Value,
                                        oRecordSet1.Fields.Item("Remarks").Value)
                    i += 1
                Next
                oRecordSet1.MoveNext()
                '(If Ttlbox = ii And TtlButal<> 0 then TtlButal  else oRecordSet1.Fields.Item("PalletQty").Value  End If),
            Loop
        End If

        oRecordSet1 = Nothing
    End Sub


    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Call oDisconnect()
        End
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

    End Sub
End Class