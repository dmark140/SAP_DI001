Imports System.ComponentModel

Public Class SelectionModule
    Public isbtn_return_selected As Boolean
    Dim isForID As Boolean
    Dim iFormx As Form
    Dim itext_COL_ID As Integer
    Dim itext_ As TextBox
    Dim iDtx As DataTable
    Dim isMultiSelect As Boolean
    Dim iMultiDgvReturn As DataGridView
    Dim iSQlReturnx As Integer
    Dim isForFind As Boolean = False
    Dim iSQL_ID As Integer = 0
    Dim iIsDropDown As Boolean


    Private isAllowStayVisibleValue As Boolean = False
    Public Property isAllowStayVisible() As Boolean
        Get
            Return isAllowStayVisibleValue
        End Get
        Set(ByVal value As Boolean)
            isAllowStayVisibleValue = value
            CheckBox1.Visible = value
        End Set
    End Property


    Private Sub SelectionModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        dgv.Select()
        Textbox.Select()

    End Sub



    Public Sub iFindMulti(iParent As Form, SQLID As Integer, HeaderText As String, iReturnDataGrid As DataGridView, iSQLReturn As Integer,
                          AdditionalParam As String)

        iSQlReturnx = iSQLReturn
        iMultiDgvReturn = iReturnDataGrid
        isMultiSelect = True
        Uc_label1.iLabel = "Search By :" & dgv.Columns(1).HeaderText

        Uc_label2.iLabel = HeaderText
        Uc_label2.Width = Uc_label2.iLabel.Length * 8
        dgv.Columns.Clear()
        If SYSTEM_MODE = "SAP" Then
            FIND_SAP(SQLID, "", AdditionalParam)
        End If

        If SYSTEM_MODE = "EDS" Then
            FIND_EDS(SQLID, "")
        End If

        ADD_Column("", 3, 0, 30, Me.dgv, False, True)

        Me.Width = 700
        Me.Height = 511

        Me.Left = (iParent.Width / 2) - (Me.Width / 2)
        Me.Top = (iParent.Height / 2) - (Me.Height / 2)
        '   Me.Top = 1 ''(iParent.Width / 2) - (Me.Width / 2)
        Me.TopLevel = False
        Me.TopMost = True
        iParent.Controls.Add(Me)
        Me.Show()
        Me.BringToFront()

        '       dgv.Sort(dgv.Columns(1), System.ComponentModel.ListSortDirection.Ascending)


    End Sub



    Public Sub iFinderx(ByVal selectionID As Integer,
                        ByVal iSearchVar As String,
                        ByVal iFormTitle As String,
                        ByVal iAdditionalCmd As String,
                        ByVal iIsbtn_return_selected As Boolean, iIsForIDx As Boolean,
                        iForm As Form, itext_COL_IDx As Integer,
                        itext_x As TextBox, iUC_input As uc_inputbox, isMultiSelected As Boolean,
                        isInnerShow As Boolean,
                        isStayVisible As Boolean)
        Try
            isAllowStayVisible = isStayVisible
            isMultiSelect = isMultiSelected
            iFormx = iForm
            itext_COL_ID = itext_COL_IDx
            itext_ = itext_x
            isbtn_return_selected = iIsbtn_return_selected

            Uc_label2.Width = iUC_input.iLabel_width - 10
            dgv.Columns.Clear()
            dgv.Rows.Clear()
            ''   Me.Text = iFormTitle
            Uc_label2.iLabel = iFormTitle
            If SYSTEM_MODE = "SAP" Then
                FIND_SAP(selectionID, iSearchVar, iAdditionalCmd)
            End If

            If SYSTEM_MODE = "EDS" Then
                FIND_EDS(selectionID, iSearchVar)
            End If


            Dim iWithx As Integer = 0

            For i = 0 To dgv.Columns.Count - 1
                iWithx = iWithx + dgv.Columns(i).Width

            Next
            '   Me.dgv.Width = iWithx + 10
            Me.Width = iWithx + 50



            If isMultiSelected Then
                ADD_Column("", 3, 0, 30, Me.dgv, False, False)
            End If

        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
            ''    'me.close()
        End Try

        If isInnerShow Then

            Try
                Me.TopLevel = False
                Me.TopMost = True
                ' iForm.Controls.SetChildIndex(Me, 999)
                iUC_input.Parent.Controls.Add(Me)
                '  iForm.Controls.SetChildIndex(Me, 999)
                Me.BringToFront()
                Me.Location = iUC_input.Location
                Me.Show()
                dgv.Sort(dgv.Columns(1), System.ComponentModel.ListSortDirection.Ascending)


                For i = 0 To dgv.Columns.Count - 1
                    Dim iColNewName As String
                    Dim iSplitName() As String = Split(" ", dgv.Columns(0).Name)
                    For ii = 0 To iSplitName.Count - 1
                        iColNewName = iColNewName & "_" & iSplitName(ii)
                    Next
                    dgv.Columns(0).Name = iColNewName
                Next


                Dim iWithx As Integer = 0

                For i = 0 To dgv.Columns.Count - 1
                    iWithx = iWithx + dgv.Columns(i).Width

                Next
                '   Me.dgv.Width = iWithx + 10
                If iWithx > 700 Then
                    iWithx = 700
                End If
                Me.Width = iWithx + 50

                If Me.Parent.Width < (Me.Width + Me.Left) Then
                    Me.Left = Me.Parent.Width - Me.Width
                End If

                Uc_label1.iLabel = "Search By :" & dgv.Columns(1).HeaderText


                If iUC_input.iIsDropDown = True Then
                    '    Me.Visible = False
                    Dim column = dgv.Columns
                    Dim iSize As Integer
                    For i = 0 To column.Count - 1
                        iSize = iSize + column(i).Width
                    Next
                    Me.MinimumSize = New Size(0, 0)
                    Me.Width = iSize + 20

                    Dim iIsV As Boolean = False
                    Dim iIsH As Boolean = False

                    For Each Scroll As VScrollBar In dgv.Controls.OfType(Of VScrollBar)
                        If Scroll.Visible = True Then iIsV = True
                    Next
                    Dim iRosH As Integer
                    For i = 0 To dgv.Rows.Count - 1
                        If i = 0 Then
                            iRosH = dgv.Rows(i).Height * 2
                        Else
                            iRosH = iRosH + dgv.Rows(i).Height
                        End If

                    Next

                    Me.Height = iRosH






                    If iIsV Then
                        Me.Width = iSize + 20
                    Else
                        Me.Width = iSize + 5
                    End If
                    Me.dgv.Dock = DockStyle.None
                    Me.dgv.Top = 5
                    Me.dgv.Left = 0
                    Me.dgv.Height = Me.Height + 10
                    Me.dgv.BringToFront()
                    Me.dgv.BringToFront()
                    Me.Visible = True

                Else
                    dgv.Dock = DockStyle.Fill
                    Me.dgv.BringToFront()
                End If
                Timer2.Enabled = True
            Catch ex As Exception
                'MainMenu.g_notif_panel(0, ex.Message, 2)
            End Try
        Else
            Me.Show()
        End If

    End Sub



    Private Sub dgv_1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentDoubleClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try


            If isForFind Then
                itext_.Text = dgv.SelectedRows(0).Cells(0).Value.ToString
                Me.Close()
            Else
                If isMultiSelect = False Then
                    getme()
                Else
                    Dim iParam As String = ""
                    For i = 0 To dgv.Rows.Count - 1
                        If CBool(dgv.Rows(i).Cells(0).Value) = True Then
                            If iParam = "" Then iParam = "''" & dgv.Rows(i).Cells(1).Value & "''"
                            If iParam <> "" Then iParam = iParam & ",''" & dgv.Rows(i).Cells(1).Value & "''"
                        End If
                    Next
                    '     iParam.Remove(iParam.Length - 1)
                    '    iParam = iParam.Substring(0, iParam.Length - 1)
                    '      iParam = "'" & iParam
                    If SYSTEM_MODE = "SAP" Then
                        SAP_SQL_PARAM.Clear()
                        SAP_SQL_PARAM.Add(iSQlReturnx)
                        SAP_SQL_PARAM.Add(iParam)
                        iMultiDgvReturn.DataSource = iSQL_DATATABLE()
                    End If
                End If
            End If
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
        If isbtn_return_selected = False Then Me.Close()

    End Sub

    Sub getme()
        If isMultiSelect = False Then
            Try
                If isbtn_return_selected Then

                    Me.Top = Me.Height * -2
                    G_Finder_text.Text = dgv.SelectedRows(0).Cells(0).Value.ToString
                    G_Finder_dscr.Text = dgv.SelectedRows(0).Cells(1).Value.ToString
                    G_Finder_text.Tag = dgv.SelectedRows(0).Cells(1).Value.ToString
                    If iFormx IsNot Nothing Then iFormx.Text = dgv.SelectedRows(0).Cells(0).Value.ToString
                    If G_SELECTEDFORM IsNot Nothing Then G_SELECTEDFORM.Text = dgv.SelectedRows(0).Cells(0).Value.ToString
                    If itext_COL_ID <> 0 Then itext_.Text = dgv.SelectedRows(0).Cells(itext_COL_ID).Value.ToString
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub SelectionModule_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        MsgBox(e.ToString)
    End Sub


    Private Sub uc_find_KeyUp(sender As Object, e As KeyEventArgs)
        MsgBox(e.ToString)
    End Sub
    Sub FIND_SAP(ByVal selectionID As Integer, ByVal iSearchVar As String, ByVal iAdditionalCmd As String)
        Call oConnect()
        Dim iDatatble As DataTable = iSQL_DATATABLE("exec spDMF_DI001  " & selectionID & " ,'" & iSearchVar & "'" & " ,'" & iAdditionalCmd & "'")
        dgv.DataSource = iDatatble
        iDtx = iDatatble
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        '   dgv.AutoSizeColumnsMode = DataGridViewAutoSizeRowsMode.AllCells
        Me.Enabled = True
        btn_ok.Enabled = True
    End Sub
    Sub Find_eds(ByVal selectionID As Integer, ByVal iSearchVar As String)

        iSearchVar = iSearchVar.Replace("*", "%")


        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", selectionID)
        Dim iDt As DataTable = EDS_G_iSQL_TABLE()
        dgv.DataSource = iDt
        iDtx = iDt

        Me.Enabled = True
        btn_ok.Enabled = True
        If iDt.Rows.Count <= 0 Then
            Me.Close()
        End If

    End Sub


    Private Sub dgv_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_ok.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cnl.Click
        isAllowStayVisibleValue = False
        Me.Close()

    End Sub

    Private Sub Uc_inputbox1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Textbox_TextChanged(sender As Object, e As EventArgs) Handles Textbox.TextChanged
        Timer1.Enabled = False
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Textbox.Text = "" Then
            dgv.DataSource = iDtx
        Else

            Try
                Dim dv As DataView
                Dim dt As DataTable
                Dim iSl As Integer = dgv.SortedColumn.Index

                dt = iDtx
                dv = New DataView(iDtx, "[" & dgv.SortedColumn.HeaderText & "]" & "  like '%" & Textbox.Text & "%' ", "", DataViewRowState.CurrentRows)

                If dv.Table.Rows.Count < 1 Then
                    dgv.Columns.Clear()
                Else
                    dgv.DataSource = dv
                    dgv.Sort(dgv.Columns(iSl), System.ComponentModel.ListSortDirection.Ascending)
                End If

            Catch ex As Exception
                Timer1.Enabled = False
                Textbox.Select()
                MainMenu.g_notif_panel(0, ex.Message, 2)
            End Try
        End If
        Timer1.Enabled = False
    End Sub

    Private Sub Textbox_KeyUp(sender As Object, e As KeyEventArgs) Handles Textbox.KeyUp
        Try
            Dim iSelected As Integer = dgv.SelectedRows(0).Index

            If e.KeyCode = Keys.Enter Then
                getme()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.Down Then
                dgv.ClearSelection()

                dgv.Rows(iSelected + 1).Selected = True
            ElseIf e.KeyCode = Keys.Up Then
                dgv.ClearSelection()

                dgv.Rows(iSelected - 1).Selected = True

            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            'MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub



    Private Sub dgv_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.ColumnHeaderMouseClick
        Uc_label1.iLabel = "Search By :" & dgv.Columns(e.ColumnIndex).HeaderText
    End Sub


    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If isMultiSelect Then
            Try
                Dim iGetLowIndex As Integer = 999
                Dim iGetTopIndex As Integer = 0

                For i = 0 To dgv.SelectedRows.Count - 1
                    If dgv.SelectedRows(i).Index < iGetLowIndex Then iGetLowIndex = dgv.SelectedRows(i).Index
                    If dgv.SelectedRows(i).Index > iGetTopIndex Then iGetTopIndex = dgv.SelectedRows(i).Index
                Next
                iGetLowIndex = iGetLowIndex
                iGetTopIndex = iGetTopIndex
                For i = iGetLowIndex To iGetTopIndex
                    dgv.Rows(i).Cells(0).Value = BooleanReverse(CBool(dgv.Rows(i).Cells(0).Value))
                Next
            Catch ex As Exception
                MainMenu.g_notif_panel(0, ex.Message, 2)
            End Try
        End If
    End Sub

    Public Sub iFindThis(datatable As DataTable, parent As Form, Title As String, TitleWidth As Integer, TextBox_Return As TextBox)
        isForFind = True
        isMultiSelect = False
        itext_ = TextBox_Return
        dgv.Columns.Clear()
        dgv.DataSource = Nothing
        dgv.DataSource = datatable

        Me.Width = 700
        Me.Height = 511
        Me.Left = (parent.Width / 2) - (Me.Width / 2)
        Me.Top = (parent.Height / 2) - (Me.Height / 2)
        Me.TopLevel = False
        Me.TopMost = True
        parent.Controls.Add(Me)
        Me.Show()
        Me.BringToFront()
        Uc_label2.Width = TitleWidth
        Uc_label2.iText = Title
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            If Textbox.Text = "" Then
                Me.Top = Me.Top + 20
                If (Me.Top + Me.Height + 50) >= Me.Parent.Height Then
                    Me.Height = (Me.Parent.Height - Me.Top) - 40
                    If Me.Height < 100 Then
                        Me.Top = 0
                        Me.Height = Me.Parent.Height
                    End If
                End If

                If (Me.Width + Me.Left) >= Me.Parent.Width Then
                    Me.Left = (Me.Parent.Width - (Me.Width + 25))
                End If
            End If


            Timer2.Enabled = False
        Catch ex As Exception
            Timer2.Enabled = False
        End Try

    End Sub

    Private Sub dgv_DataSourceChanged(sender As Object, e As EventArgs) Handles dgv.DataSourceChanged
        Timer2.Enabled = True
    End Sub


    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        If isMultiSelect = False Then
            getme()
        Else
            If isMultiSelect Then
                dgv.Rows(e.RowIndex).Cells(0).Value = BooleanReverse(CBool(dgv.Rows(e.RowIndex).Cells(0).Value))
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        isAllowStayVisibleValue = CheckBox1.Visible
    End Sub
End Class
