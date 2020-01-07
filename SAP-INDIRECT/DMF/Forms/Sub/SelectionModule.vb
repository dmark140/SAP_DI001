Public Class SelectionModule
    Public isbtn_return_selected As Boolean
    Dim isForID As Boolean
    Dim iFormx As Form
    Dim itext_COL_ID As Integer
    Dim itext_ As TextBox
    Private Sub SelectionModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.Select()
    End Sub


    Public Sub iFinderx(ByVal selectionID As Integer,
                        ByVal iSearchVar As String,
                        ByVal iFormTitle As String,
                        ByVal iAdditionalCmd As String,
                        ByVal iIsbtn_return_selected As Boolean, iIsForIDx As Boolean,
                        iForm As Form, itext_COL_IDx As Integer, itext_x As TextBox, iUC_input As uc_inputbox)
        Try
            iFormx = iForm
            itext_COL_ID = itext_COL_IDx
            itext_ = itext_x
            isbtn_return_selected = iIsbtn_return_selected

            dgv.Columns.Clear()
            dgv.Rows.Clear()
            Me.Text = iFormTitle

            If SYSTEM_MODE = "SAP" Then
                FIND_SAP(selectionID, iSearchVar, iFormTitle, iAdditionalCmd, iIsbtn_return_selected, isForID, iForm, itext_COL_ID, itext_x)
            End If

            If SYSTEM_MODE = "EDS" Then
                FIND_EDS(selectionID, iSearchVar, iFormTitle, iAdditionalCmd, iIsbtn_return_selected, isForID, iForm, itext_COL_ID, itext_x)
            End If


            Dim iWithx As Integer = 0

            For i = 0 To dgv.Columns.Count - 1
                iWithx = iWithx + dgv.Columns(i).Width

            Next
            '   Me.dgv.Width = iWithx + 10
            Me.Width = iWithx + 50
            '  Me.dgv.Left = 10
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
            Me.Close()
        End Try
        Try
            Me.TopLevel = False
            Me.TopMost = True
            ' iForm.Controls.SetChildIndex(Me, 999)
            iUC_input.Parent.Controls.Add(Me)
            '  iForm.Controls.SetChildIndex(Me, 999)
            Me.BringToFront()
            Me.Location = iUC_input.Location
            Me.Show()
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub dgv_1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentDoubleClick
        getme()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getme()
        If isbtn_return_selected = False Then Me.Close()

    End Sub

    Sub getme()
        If isbtn_return_selected Then

            Try
                Me.Top = Me.Height * -2
                If G_Finder_text IsNot Nothing Then G_Finder_text.Text = dgv.SelectedRows(0).Cells(0).Value.ToString
                If G_Finder_dscr IsNot Nothing Then G_Finder_dscr.Text = dgv.SelectedRows(0).Cells(1).Value.ToString
                If iFormx IsNot Nothing Then iFormx.Text = dgv.SelectedRows(0).Cells(0).Value.ToString
                If G_SELECTEDFORM IsNot Nothing Then G_SELECTEDFORM.Text = dgv.SelectedRows(0).Cells(0).Value.ToString
                If itext_COL_ID <> 0 Then itext_.Text = dgv.SelectedRows(0).Cells(itext_COL_ID).Value.ToString
                Me.Close()
            Catch ex As Exception
              '  MsgBox(ex.ToString)
            End Try
        End If

    End Sub

    Private Sub SelectionModule_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        MsgBox(e.ToString)
    End Sub

    Private Sub uc_find_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub uc_find_KeyUp(sender As Object, e As KeyEventArgs)
        MsgBox(e.ToString)
    End Sub




    Private Sub SelectionModule_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Text = Me.Left & " : "
    End Sub


    Sub FIND_SAP(ByVal selectionID As Integer,
                        ByVal iSearchVar As String,
                        ByVal iFormTitle As String,
                        ByVal iAdditionalCmd As String,
                        ByVal iIsbtn_return_selected As Boolean, iIsForIDx As Boolean, iForm As Form, itext_COL_IDx As Integer, itext_x As TextBox)
        Call oConnect()
        Dim iUDR As SAPbobsCOM.Recordset
        iSearchVar = iSearchVar.Replace("*", "%")
        iUDR = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        iUDR.DoQuery("exec spDMF_DI001  " & selectionID & " ,'" & iSearchVar & "'")
        For i = 0 To iUDR.Fields.Count - 1
            dgv.Columns.Add(i, iUDR.Fields(i).Name)
        Next
        Dim row(iUDR.Fields.Count - 1) As String
        Do While iUDR.EoF = False
            For i = 0 To iUDR.Fields.Count - 1
                row(i) = iUDR.Fields.Item(iUDR.Fields(i).Name).Value
            Next
            dgv.Rows.Add(row)
            iUDR.MoveNext()
        Loop
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv.Columns(0).Width = 30
    End Sub
    Sub FIND_EDS(ByVal selectionID As Integer,
                        ByVal iSearchVar As String,
                        ByVal iFormTitle As String,
                        ByVal iAdditionalCmd As String,
                        ByVal iIsbtn_return_selected As Boolean, iIsForIDx As Boolean,
                        iForm As Form, itext_COL_IDx As Integer, itext_x As TextBox)

        iSearchVar = iSearchVar.Replace("*", "%")


        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", selectionID)
        Dim iDt As DataTable = EDS_G_iSQL_TABLE()
        dgv.DataSource = iDt


        Me.Enabled = True
        Button1.Enabled = True
        If iDt.Rows.Count <= 0 Then
            Me.Close()
        End If

        'For i = 0 To iDt.Tables(0).Rows.Count - 1
        '    iDt. Tables(0).Rows(0)()
        'Next




    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
