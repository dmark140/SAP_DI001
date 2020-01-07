
Public Class batch_selectionForm
    Dim iTypeX As String
    Dim iItemc As String
    Dim iStatusx As String
    Dim iWhsec As String
    Dim QTYNEED As Double
    Dim DOCNUM As Integer
    Dim iROW As Integer
    Dim iAUTOMODE As Boolean = False
    Dim iUC_ARROW As uc_dgv_col_withArrow
    Dim DGVx As DataGridView

    Public Property iType As String
        Get
            Return iTypeX
        End Get
        Set(value As String)
            iTypeX = value
        End Set
    End Property

    Public Property iDGV As DataGridView
        Get
            Return DGVx
        End Get
        Set(value As DataGridView)
            DGVx = value
        End Set
    End Property

    Public Property UC_ARROW As uc_dgv_col_withArrow
        Get
            Return iUC_ARROW
        End Get
        Set(value As uc_dgv_col_withArrow)
            iUC_ARROW = value
        End Set
    End Property

    Public Property ITEMX As String
        Get
            Return iItemc
        End Get
        Set(value As String)
            iItemc = value
        End Set
    End Property

    Public Property iStatus As String
        Get
            Return iStatusx
        End Get
        Set(value As String)
            iStatusx = value
        End Set
    End Property

    Public Property iQTYNEED As Double
        Get
            Return QTYNEED
        End Get
        Set(value As Double)
            QTYNEED = value
        End Set
    End Property


    Public Property IWSEX As String
        Get
            Return iWhsec
        End Get
        Set(value As String)
            iWhsec = value
        End Set
    End Property


    Public Property ROW As Integer
        Get
            Return iROW
        End Get
        Set(value As Integer)
            iROW = value
        End Set
    End Property
    Public Property IDOCNUM As Integer
        Get
            Return DOCNUM
        End Get
        Set(value As Integer)
            DOCNUM = value
        End Set
    End Property


    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub batch_selectionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Me.iStatus = "Close" Then
            Try
                Panel2.Visible = True
                Dim iDr As SAPbobsCOM.Recordset = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                SAP_SQL_PARAM.Clear()
                SAP_SQL_PARAM.Add(IDOCNUM)
                SAP_SQL_PARAM.Add(ITEMX)
                iSQL_selector(138, DataGridView1, True, 3)
            Catch ex As Exception
                MainMenu.g_notif_panel(0, ex.Message, 2)
            End Try
        End If
        Try
            Uc_inputbox1.iText = "0"
            dgv_selectorBatch.Columns.Clear()
            dgv_selectorBatch.Rows.Clear()
            uc_Ttl_need.iText = iQTYNEED
            SAP_SQL_PARAM.Clear()
            SAP_SQL_PARAM.Add(iItemc)
            SAP_SQL_PARAM.Add(iWhsec)
            iSQL_selector(122, dgv_selectorBatch, True, 3)

            If dgv_selectorBatch.Rows.Count = 0 Then
                MainMenu.g_notif_panel(0, "122 -  : " & iWhsec & " Wtih the item: " & iItemc, 2)
            Else
                ADD_Column(" Selected Qty ", 1, 2, 15, dgv_selectorBatch, False, False)
                Col_MERROR()
                SelectedProration_MINUS_SQL()
                SelectedBatcH_Re_use()
                iTotalCalc()
                iZeroOutSeleciton()
                dgv_selected.Columns(1).Visible = False
            End If
        Catch ex As Exception
            MainMenu.g_notif_panel(1, "122 - " + ex.Message, 2)
        End Try
    End Sub


    Sub Col_MERROR()
        dgv_selected.Columns.Clear()
        dgv_selected.Rows.Clear()
        For i = 0 To dgv_selectorBatch.Columns.Count - 1
            ADD_Column(dgv_selectorBatch.Columns(i).HeaderText, 1, i, dgv_selectorBatch.Columns(i).Width, dgv_selected, True, False)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        iAUTOMODE = True
        Dim iQtyOnHan As Double
        For i = 0 To dgv_selectorBatch.Rows.Count - 1
            iQtyOnHan = iQtyOnHan + CDbl(dgv_selectorBatch.Rows(i).Cells(2).Value)
        Next
        iQtyOnHan = iQtyOnHan + CDbl(Uc_inputbox1.iText)
        If CDbl(Uc_inputbox1.iText) < iQtyOnHan Then

            Try
                Dim row()
                ReDim row(dgv_selectorBatch.Columns.Count)
                For i = 0 To dgv_selectorBatch.Rows.Count - 1
                    If CDbl(dgv_selectorBatch.Rows(i).Cells(2).Value) > 0 Then

                        dgv_selectorBatch.Rows(i).Cells(1).Value = CDbl(dgv_selectorBatch.Rows(i).Cells(1).Value) - CDbl(dgv_selectorBatch.Rows(i).Cells(2).Value)

                        For ii As Integer = 0 To dgv_selected.Columns.Count - 1
                            row(ii) = dgv_selectorBatch.Rows(i).Cells(ii).Value.ToString
                        Next
                        dgv_selected.Rows.Add(row)
                        '  dgv_selectorBatch.Rows(i).Cells(2).Value = 0
                    End If
                Next
                For i = 0 To dgv_selectorBatch.Rows.Count - 1
                    dgv_selectorBatch.Rows(i).Cells(2).Value = 0
                Next
            Catch
            End Try
        Else
            MainMenu.g_notif_panel(0, "0002 - Exceed needed Quantity!", 2)
        End If


        iAUTOMODE = False

        ' End If
        iTotalCalc()
    End Sub
    Private Sub dgv_selectorBatch_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_selectorBatch.CellValueChanged
        If iAUTOMODE = False Then
            Try
                For i = 0 To dgv_selectorBatch.Rows.Count - 1
                    If IsNumeric(dgv_selectorBatch.Rows(i).Cells(2).Value) = False Then
                        dgv_selectorBatch.Rows(i).Cells(2).Value = 0
                        '   MainMenu.g_notif_panel(2, "0002 - Selected qty Is Not Numeric!", 2)
                    ElseIf (CDbl(dgv_selectorBatch.Rows(i).Cells(2).Value) > CDbl(dgv_selectorBatch.Rows(i).Cells(1).Value)) Then
                        If (CDbl(dgv_selectorBatch.Rows(i).Cells(2).Value) > CDbl(dgv_selectorBatch.Rows(i).Cells(1).Value)) Then dgv_selectorBatch.Rows(i).Cells(2).Value = (dgv_selectorBatch.Rows(i).Cells(1).Value)
                        If (CDbl(dgv_selectorBatch.Rows(i).Cells(2).Value) > QTYNEED) Then dgv_selectorBatch.Rows(i).Cells(2).Value = QTYNEED
                    End If
                Next
            Catch ex As Exception
                MainMenu.g_notif_panel(2, ex.Message, 2)
            End Try
        End If

    End Sub

    Private Sub btn_auto_Click(sender As Object, e As EventArgs) Handles btn_auto.Click

        iAUTOMODE = True
        If CDbl(Uc_inputbox1.iText) < CDbl(uc_Ttl_need.iText) Then
            dgv_selected.Rows.Clear()
            Dim iNeed As Double = CDbl(uc_Ttl_need.iText)
            Dim iGet As Double = 0
            Dim iGetx As Double = 0
            For i = 0 To dgv_selectorBatch.Rows.Count - 1
                Dim iQTY As Double = dgv_selectorBatch.Rows(i).Cells(1).Value
                If dgv_selectorBatch.Rows(i).Cells(1).Value > 1 Then
                    If iGet < CDbl(uc_Ttl_need.iText) Then
                        If iQTY < iNeed Then
                            iGet = iGet + iQTY
                            iGetx = iQTY
                            iNeed = iNeed - iQTY
                        Else
                            iGet = iGet + iNeed
                            iGetx = iNeed
                            iNeed = 0
                        End If
                        dgv_selectorBatch.Rows(i).Cells(2).Value = iGetx
                        'dgv_selectorBatch.Rows(i).Cells(1).Value = CDbl(dgv_selectorBatch.Rows(i).Cells(1).Value) - iGetx
                    End If
                End If
            Next
            iAUTOMODE = False
            Button1.PerformClick()
            For i = 0 To dgv_selectorBatch.Rows.Count - 1
                dgv_selectorBatch.Rows(i).Cells(2).Value = 0
            Next
        End If
        iTotalCalc()
    End Sub
    Sub iTotalCalc()
        Dim iCOUNT As Double = 0
        For i = 0 To dgv_selected.Rows.Count - 1
            iCOUNT = iCOUNT + CDbl(dgv_selected.Rows(i).Cells(2).Value)
        Next
        Uc_inputbox1.iText = iCOUNT
    End Sub


    Sub iZeroOutSeleciton()
        For i = 0 To dgv_selectorBatch.Rows.Count - 1
            dgv_selectorBatch.Rows(i).Cells(2).Value = "0"
        Next
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        Dim iGOodToGo As Boolean = False


        If CDbl(uc_Ttl_need.iText) = CDbl(Uc_inputbox1.iText) Then
            iUC_ARROW.iText = CDbl(Uc_inputbox1.iText)
            MainMenu.g_notif_panel(3, "0002 - Batch updated", 2)
            For i = 0 To iDGV.Columns.Count - 1
                iDGV.Rows(0).Cells(i).Style.ForeColor = Color.Black
            Next
            iDGV.Rows(Me.ROW).Cells(iDGV.Columns.Count - 1).Value = "Open"
            iGOodToGo = True

        ElseIf CDbl(uc_Ttl_need.iText) < CDbl(Uc_inputbox1.iText) Then
            MainMenu.g_notif_panel(2, "0002 - Selected Batch quantity is not equal to needed quantity", 2)
            For i = 0 To iDGV.Columns.Count - 1
                iDGV.Rows(Me.ROW).Cells(i).Style.ForeColor = Color.Red
            Next
            iDGV.Rows(Me.ROW).Cells(iDGV.Columns.Count - 1).Value = "Not equal  batch qty"
            '  iUC_ARROW.iText = CDbl(Uc_inputbox1.iText)
            iGOodToGo = False
        Else
            MainMenu.g_notif_panel(2, "0002 - Selected Batch quantity is not equal to needed quantity", 2)
            For i = 0 To iDGV.Columns.Count - 1
                iDGV.Rows(Me.ROW).Cells(i).Style.ForeColor = Color.Red
            Next
            iDGV.Rows(Me.ROW).Cells(iDGV.Columns.Count - 1).Value = "Insufficient batch qty"
            iUC_ARROW.iText = CDbl(Uc_inputbox1.iText)
            iGOodToGo = False
        End If
        If iGOodToGo Then

            Dim iBatch As String
            Dim iQty As Double
            Dim iSysNum As String
            Dim iMachine As String
            Dim iBatchDRno As String
            Dim iItemcode As String

            For Each Rowx As DataGridViewRow In dgv_selected.Rows
                iBatch = Rowx.Cells(0).Value
                iQty = Rowx.Cells(2).Value
                iSysNum = Rowx.Cells(4).Value
                iMachine = ""
                iBatchDRno = Rowx.Cells(5).Value
                iItemcode = Rowx.Cells(6).Value
                Dim iBatchCon As New BATCH_CONTAINER()
                iBatchCon.ROW = Me.ROW
                iBatchCon.BATCH = iBatch
                iBatchCon.DOCNUM = DOCNUM
                iBatchCon.QTY = iQty
                iBatchCon.WHSECODE = iWhsec
                iBatchCon.SYSTEMNUM = iSysNum
                iBatchCon.MACHINE = iMachine
                iBatchCon.BATCHDRNO = iBatchDRno
                iBatchCon.ITEMCODE = iItemcode
                iBatchCon.TYPE = iTypeX

                Batches.Add(iBatchCon)
            Next
        End If
        Me.Close()
        If dgv_selectorBatch.Rows.Count = 0 Then
            '  MainMenu.g_notif_panel(0, "122 - No Batch found in Warehouse: " & iWhsec & " Wtih the item: " & iItemc, 2)
            '    iUC_ARROW.iText = "0"
            Me.Close()
        End If
    End Sub

    ''<<< LEFT SIDE --
    Sub SelectedProration_MINUS_SQL()
        Try
            For Y = 0 To dgv_selectorBatch.Rows.Count - 1
                Dim iBATCH As String = dgv_selectorBatch.Rows(Y).Cells(0).Value.ToString
                Dim iITEMCODE As String = dgv_selectorBatch.Rows(Y).Cells(6).Value.ToString
                Dim iSYSNUM As String = dgv_selectorBatch.Rows(Y).Cells(4).Value.ToString
                For Each iBATCHX As BATCH_CONTAINER In Batches
                    If iBATCH = iBATCHX.BATCH And
                        iITEMCODE = iBATCHX.ITEMCODE And
                        iSYSNUM = iBATCHX.SYSTEMNUM Then
                        dgv_selectorBatch.Rows(Y).Cells(1).Value = CDbl(dgv_selectorBatch.Rows(Y).Cells(1).Value) - iBATCHX.QTY
                        If dgv_selectorBatch.Rows(Y).Cells(1).Value < 0 Then
                            dgv_selectorBatch.Rows(Y).Cells(1).Value = 0
                        End If
                    End If
                    System.Console.WriteLine("BATCH: " & "" & " - " & iBATCHX.BATCH)
                    System.Console.WriteLine("ITEMCODE: " & "" & " - " & iBATCHX.ITEMCODE)
                    System.Console.WriteLine("SYSNUM: " & "" & " - " & iBATCHX.SYSTEMNUM)
                    System.Console.WriteLine("---------------------------------------------")
                Next
            Next
        Catch ex As Exception
            MainMenu.g_notif_panel(0, "0002 - " & ex.Message, 2)
        End Try
    End Sub

    Sub SelectedBatcH_Re_use()
        Try
            Dim row()
            ReDim row(dgv_selected.Columns.Count)
            For Each iBATCHX As BATCH_CONTAINER In Batches
                If iBATCHX.ROW = Me.ROW Then
                    If iBATCHX.TYPE = iTypeX Then
                        row(0) = iBATCHX.BATCH
                        row(1) = 0
                        row(2) = iBATCHX.QTY
                        row(3) = iBATCHX.WHSECODE
                        row(4) = iBATCHX.SYSTEMNUM
                        row(5) = iBATCHX.BATCHDRNO
                        row(6) = iBATCHX.ITEMCODE
                        dgv_selected.Rows.Add(row)
                    End If
                End If
            Next
        Catch ex As Exception
            MainMenu.g_notif_panel(0, "0002 - " & ex.Message, 2)
        End Try
    End Sub
    Private Sub _MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_selected.MouseClick
        If e.Button = MouseButtons.Right Then
            dgv_selected = dgv_selected
            cms_copy.Show(MousePosition)
        End If
    End Sub

    Private Sub cms_copy_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cms_copy.Opening

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        CopyToClipboardWithHeaders(dgv_selected)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class