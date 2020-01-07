Public Class MBOS
    Public prevCounter As Integer
    Public iRecSet As SAPbobsCOM.Recordset
    Public iListOfCCRows As New List(Of String)
    Public Firstx As Boolean = False

    Private Sub MBOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oConnect()

        btn_ok.PerformClick()
    End Sub



    Sub iSelectCheckList(ByVal dateF As String, ByVal dateT As String)
        Try

            Dim row() As String


            '   dgv_CheckSelection.DataSource.Equals(vbNull)
            '   dgv_CheckSelection.Rows.Clear()
            dgv_CheckSelection.AutoGenerateColumns = False
            dgv_CheckSelection.Columns.Clear()
            dgv_CheckSelection.Rows.Clear()


            'dgv_SelectedDocs.AutoGenerateColumns = False
            'dgv_SelectedDocs.Columns.Clear()
            'dgv_SelectedDocs.Rows.Clear()

            iRecSet = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            iRecSet.DoQuery("exec spDMF_S001 '" + dateF.ToString + "' , '" + dateT.ToString + "'")

            For i As Integer = 0 To iRecSet.Fields.Count - 1
                ADD_Column(iRecSet.Fields(i).Name, 1, i, 30, dgv_CheckSelection, True, False)
                If Firstx = False Then ADD_Column(iRecSet.Fields(i).Name, 1, i, 30, dgv_SelectedDocs, True, False)
            Next

            ADD_Column("C", 3, 0, 30, dgv_CheckSelection, True, False)
            If Firstx = False Then ADD_Column("C", 3, 0, 30, dgv_SelectedDocs, True, False)
            '  ADD_Column("ID", 1, iRecSet.Fields.Count, "ID", iRecSet.Fields.Count, 30, dgv_SelectedDocs)
            ReDim row(iRecSet.Fields.Count)

            For i As Integer = 0 To iRecSet.RecordCount - 1
                row(0) = False
                For ii As Integer = 0 To iRecSet.Fields.Count - 1
                    row(ii + 1) = iRecSet.Fields.Item(iRecSet.Fields(ii).Name).Value
                Next
                dgv_CheckSelection.Rows.Add(row)
                iRecSet.MoveNext()
            Next
            dgv_CheckSelection.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgv_SelectedDocs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgv_CheckSelection.Columns(0).Width = 30
            dgv_SelectedDocs.Columns(0).Width = 30
            dgv_CheckSelection.Columns(1).Width = 1
            dgv_SelectedDocs.Columns(1).Width = 1
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.ToString, 1)

            'End
        End Try
        dgv_CheckSelection.Columns(0).Frozen = True

        Firstx = True
    End Sub
    Private Sub dgv_CheckSelection_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_CheckSelection.CellContentClick

        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewCheckBoxColumn AndAlso
           e.RowIndex >= 0 Then
            If dgv_CheckSelection.Rows(e.RowIndex).Cells(0).Value = True Then
                dgv_CheckSelection.Rows(e.RowIndex).Cells(0).Value = False
                iRemoveSelected(Integer.Parse(senderGrid.Rows(e.RowIndex).Cells(1).Value))
            Else
                dgv_CheckSelection.Rows(e.RowIndex).Cells(0).Value = True
                iGetSelectEDDocsLeft(e.RowIndex)
            End If
        End If
        prevCounter = 0
        timer_previewCounter.Enabled = True
        Timer1.Enabled = True
    End Sub

    Private Sub btn_ok_Click_1(sender As Object, e As EventArgs) Handles btn_ok.Click
        iSelectCheckList(UC_dtp_from.iDate.ToString("MM.dd.yyyy"), UC_dtp_To.iDate.ToString("MM.dd.yyyy"))
    End Sub

    Private Sub dgv_SelectedDocs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_SelectedDocs.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewCheckBoxColumn AndAlso
           e.RowIndex >= 0 Then
            If dgv_SelectedDocs.Rows(e.RowIndex).Cells(0).Value = True Then

                iRemoveSelectedRight(Integer.Parse(senderGrid.Rows(e.RowIndex).Cells(1).Value))
                dgv_SelectedDocs.Rows.RemoveAt(e.RowIndex)
            End If
        End If
        prevCounter = 0
        timer_previewCounter.Enabled = True
    End Sub



    Private Sub iGetSelectEDDocsLeft(ByVal SelectedIndex As Integer)
        Dim row() As String
        Dim iColCount = dgv_CheckSelection.Columns.GetColumnCount(DataGridViewElementStates.Displayed)
        'For i As Integer = 0 To dgv_CheckSelection.Columns.GetColumnCount(DataGridViewElementStates.Displayed)
        '    dgv_SelectedDocs.Rows(SelectedIndex).Cells(i).Value = dgv_CheckSelection.Rows(SelectedIndex).Cells(i).Value
        'Next
        ReDim row(iColCount + 1)

        row(0) = True
        For i As Integer = 1 To iColCount - 1
            row(i) = dgv_CheckSelection.Rows(SelectedIndex).Cells(i).Value
        Next
        row(iColCount + 1) = SelectedIndex
        dgv_SelectedDocs.Rows.Add(row)
    End Sub

    Private Sub iRemoveSelected(ByVal iRowID As Integer)
        Dim iRowCount = dgv_SelectedDocs.Rows.Count

        Dim iRowIndex As Integer

        For i As Integer = 0 To iRowCount - 1
            If Integer.Parse(dgv_SelectedDocs.Rows(i).Cells(1).Value) = iRowID Then
                iRowIndex = dgv_SelectedDocs.Rows(i).Cells(2).RowIndex
            End If
        Next
        dgv_SelectedDocs.Rows.RemoveAt(iRowIndex)
    End Sub

    Private Sub iRemoveSelectedRight(ByVal iRowID As Integer)
        Dim iRowCount = dgv_CheckSelection.Rows.Count

        Dim iRowIndex As Integer

        For i As Integer = 0 To iRowCount - 1
            If Integer.Parse(dgv_CheckSelection.Rows(i).Cells(1).Value) = iRowID Then
                iRowIndex = dgv_CheckSelection.Rows(i).Cells(2).RowIndex
            End If
        Next
        dgv_CheckSelection.Rows(iRowIndex).Cells(0).Value = False
    End Sub




    Private Sub iPrev_CC()
        Try
            Dim iSelectedTransIDs As String = ""
            For i As Integer = 0 To dgv_SelectedDocs.Rows.Count - 1
                iSelectedTransIDs = iSelectedTransIDs + dgv_SelectedDocs.Rows(i).Cells(1).Value + ", "
            Next
            iSelectedTransIDs = iSelectedTransIDs.Trim().Remove(iSelectedTransIDs.Length - 2)

            iListOfCCRows.Clear()

            iRecSet = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)


            iRecSet.DoQuery("exec spDMF_M005  '" + iSelectedTransIDs + "'")
            For i As Integer = 0 To iRecSet.Fields.Count - 1
                txt_formatedx.Text = iRecSet.Fields(i).Value
                iListOfCCRows.Add(Trim(iRecSet.Fields(i).Value.ToString).Replace(vbCr, ""))
            Next
            iRecSet = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            iRecSet.DoQuery("exec spDMF_M004 '" + iSelectedTransIDs + "'")
            Dim ix As String
            For i As Integer = 0 To iRecSet.RecordCount - 1
                iListOfCCRows.Add(Trim(iRecSet.Fields(0).Value.ToString.Replace(vbCr, "")))
                ix = Trim(iRecSet.Fields(0).Value.ToString).Replace(vbCr, "")
                ix = ix
                txt_formatedx.Text = txt_formatedx.Text + vbNewLine + iRecSet.Fields(0).Value
                iRecSet.MoveNext()
            Next


        Catch ex As Exception
            '      MainMenu.g_notif_panel(0, ex.ToString, 1)

        End Try
    End Sub

    Private Sub iPrev_MC()
        Try
            Dim iSelectedTransIDs As String = ""
            For i As Integer = 0 To dgv_SelectedDocs.Rows.Count - 1
                iSelectedTransIDs = iSelectedTransIDs + dgv_SelectedDocs.Rows(i).Cells(1).Value + ", "
            Next
            iSelectedTransIDs = iSelectedTransIDs.Trim().Remove(iSelectedTransIDs.Length - 2)

            iListOfCCRows.Clear()
            iRecSet = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            iRecSet.DoQuery("exec spDMF_DI001 130 ,   '" + iSelectedTransIDs + "'")
            Dim ix As String
            For i As Integer = 0 To iRecSet.RecordCount - 1
                iListOfCCRows.Add(Trim(iRecSet.Fields(2).Value.ToString.Replace(vbCr, "")))
                ix = Trim(iRecSet.Fields(2).Value.ToString).Replace(vbCr, "")
                ix = ix
                If i = 0 Then txt_formatedx.Text = ix
                If i <> 0 Then txt_formatedx.Text = txt_formatedx.Text + vbNewLine + ix
                iRecSet.MoveNext()
            Next
        Catch ex As Exception
            '   MainMenu.g_notif_panel(0, ex.ToString, 1)
        End Try
    End Sub

    Private Sub timer_previewCounter_Tick(sender As Object, e As EventArgs) Handles timer_previewCounter.Tick
        prevCounter = prevCounter + 1
        If prevCounter > 3 Then
            prevCounter = 0

            timer_previewCounter.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            FolderBrowserDialog1.ShowDialog()
            If FolderBrowserDialog1.SelectedPath <> "" Then
                iTextTabCreation(FolderBrowserDialog1.SelectedPath.ToString)
                Process.Start("explorer.exe", ("/root," + FolderBrowserDialog1.SelectedPath.ToString))
            End If
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.ToString, 1)

        End Try
    End Sub

    Public Sub iTextTabCreation(ByVal conifPath As String)
        Try

            Dim iTextname As String
            iTextname = Uc_TextBox1.iText.ToString

            conifPath = conifPath + "\" + iTextname + ".txt"

            Dim iConIf As New System.IO.StreamWriter(conifPath)
            For i As Integer = 0 To iListOfCCRows.Count - 1
                iConIf.WriteLine(iListOfCCRows(i).ToString)
            Next
            iConIf.Close()
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.ToString, 1)

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Try
            Dim iCount As Double = 0
            Dim iStringx As String = ""
            For i As Integer = 0 To dgv_SelectedDocs.Rows.Count - 1
                '     Integer.Parse(dgv_SelectedDocs.Rows(i).Cells(5).Value)
                iStringx = dgv_SelectedDocs.Rows(i).Cells(5).Value
                iStringx.Trim()
                iCount = iCount + Double.Parse(iStringx)
            Next
            Uc_txt_docTotal.Tag = iCount
            If iCount <= 999 Then
                Uc_txt_docTotal.iText = "₱ " + iCount.ToString("000.00")
            Else
                Uc_txt_docTotal.iText = "₱ " + iCount.ToString("0,000.00")
            End If
            Uc_txt_DocQty.iText = dgv_SelectedDocs.Rows.Count

        Catch ex As Exception

            MainMenu.g_notif_panel(0, ex.ToString, 1)
        End Try

    End Sub


    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim iSend As TabControl = sender
        If iSend.SelectedTab.TabIndex = 1 Then
            txt_formatedx.Text = ""
            If RadioButton1.Checked = True Then iPrev_CC()
            If RadioButton2.Checked = True Then iPrev_MC()
        End If
    End Sub

    Private Sub UC_dtp_from_ValueChanged(sender As Object, e As EventArgs)
        btn_ok.PerformClick()
    End Sub

    Private Sub dtp_To_ValueChanged(sender As Object, e As EventArgs)
        btn_ok.PerformClick()
    End Sub

    Private Sub timer_notif_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_find_PO_Click(sender As Object, e As EventArgs) Handles btn_find_PO.Click
        iSelectCheckList(UC_dtp_from.iDate.ToString("MM.dd.yyyy"), UC_dtp_To.iDate.ToString("MM.dd.yyyy"))

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dgv_CheckSelection.Rows.Clear()
        dgv_SelectedDocs.Rows.Clear()
        Uc_txt_DocQty.iText = 0
        Uc_txt_docTotal.iText = 0
        Uc_TextBox1.iText = 0

    End Sub
End Class