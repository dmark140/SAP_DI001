Public Class Inventory_MaxLevel
    Private Sub btn_find_PO_Click(sender As Object, e As EventArgs) Handles btn_find_PO.Click
        Try

            If CInt(uc_curMax.iText) > CInt(uc_newMax.iText) Then
                MainMenu.g_notif_panel(0, "-119   Please input an appropriate data, You cant set max inventory Level lower than the current one", 2)
            Else

                Call oConnect()
                Dim iStng As String
                Dim iRs As SAPbobsCOM.Items = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems)
                If iRs.GetByKey(Uc_itemN.iText) Then
                    iRs.WhsInfo.SetCurrentLine(CInt(uc_warehouseNo.Tag - 1))
                    iRs.WhsInfo.MaximalStock = CInt(uc_newMax.iText)
                    iStng = iRs.Update()
                    MainMenu.g_notif_panel(1, "-119   Transaction Complete", 2)
                End If
            End If
            iClear()
        Catch ex As Exception
            MainMenu.g_notif_panel(1, "-119  " & ex.Message.ToString, 2)
        End Try
    End Sub

    Private Sub Inventory_MaxLevel_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        Try
            btn_find_PO.Enabled = True
            Dim iRs As SAPbobsCOM.Recordset = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            iRs.DoQuery("Exec spDMF_DI001 119 , '" & Me.Text.ToString & "'")
            Do While iRs.EoF = False
                uc_warehouseNo.iText = iRs.Fields.Item("WhsCode").Value().ToString
                uc_warehouseNo.Tag = iRs.Fields.Item("ROW#").Value().ToString
                uc_curMax.iText = iRs.Fields.Item("MaxStock").Value().ToString
                iRs.MoveNext()
            Loop
        Catch ex As Exception

        End Try
    End Sub
    Sub iClear()
        Uc_itemN.iText = ""
        uc_warehouseNo.iText = ""
        uc_curMax.iText = ""
        uc_newMax.iText = ""
        Me.Text = ""
        btn_find_PO.Enabled = False

    End Sub
End Class