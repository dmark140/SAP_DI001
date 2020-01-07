Public Class uc_col_finder

    Dim iDataset As DataTable
    Dim iColumnNameForSearch As String = ""
    Dim iCell As DataGridViewTextBoxCell
    Dim iRectangle As Rectangle
    Dim iDGV As DataGridView
    Dim iTextx As String
    Public iRowCoint As Integer
    Dim iDgvCell1 As DataGridViewCell
    Dim iDgvCell2 As DataGridViewCell
    Dim iBtnExitx As Button

    Public Property iDgvCell1x As DataGridViewCell
        Get
            Return iDgvCell1
        End Get
        Set(value As DataGridViewCell)
            iDgvCell1 = value
        End Set
    End Property

    Public Property iDgvCell2x As DataGridViewCell
        Get
            Return iDgvCell2
        End Get
        Set(value As DataGridViewCell)
            iDgvCell2 = value
        End Set
    End Property




    Public Property iText As String
        Get
            Return iTextx
        End Get
        Set(value As String)
            If value <> Nothing Then
                iTextx = value
                Try
                    iRowCoint = 0
                    dgv_1.Columns.Clear()
                    dgv_1.DataSource = Nothing
                    Dim iQry As String = iColumnNameForSearch & " Like '%" & value & "%'"
                    iDataset.Select(iQry)
                    Dim inewDataRow() As DataRow = iDataset.Select(iQry)
                    For i = 0 To iDataset.Columns.Count - 1
                        ADD_Column(iDataset.Columns(i).Caption, 1, i, 50, dgv_1, True, False)

                    Next
                    Dim row()
                    ReDim row(dgv_1.Columns.Count)
                    For i As Integer = 0 To inewDataRow.Count - 1
                        For ii As Integer = 0 To iDataset.Columns.Count - 1
                            row(ii) = inewDataRow(i)(ii)

                        Next
                        dgv_1.Rows.Add(row)
                    Next
                    iRowCoint = inewDataRow.Count
                    MainMenu.Text = iRowCoint
                Catch ex As Exception
                    MainMenu.g_notif_panel(0, ex.Message, 2)
                End Try
            End If
        End Set
    End Property



    Public Property iBtnExit As Button
        Get
            Return iBtnExitx
        End Get
        Set(value As Button)
            iBtnExitx = value
            '   Me.Location = value.Location
            '    Me.Textbox.Size = value.Size
            ' Me.Top = value.Location.Y + iRectangle.Height + iDGVX.ColumnHeadersHeight
            '       MainMenu.Text = value.Location.ToString
        End Set
    End Property

    Public Property iDGVX As DataGridView
        Get
            Return iDGV
        End Get
        Set(value As DataGridView)
            iDGV = value
            '   Me.Location = value.Location
            '    Me.Textbox.Size = value.Size
            ' Me.Top = value.Location.Y + iRectangle.Height + iDGVX.ColumnHeadersHeight
            '       MainMenu.Text = value.Location.ToString
        End Set
    End Property


    Public Property iRectanglex As Rectangle
        Get
            Return iRectangle
        End Get
        Set(value As Rectangle)
            iRectangle = value
            Try
                Me.Location = value.Location
                '    Me.Textbox.Size = value.Size
                Me.Top = Me.Top + iDGV.ColumnHeadersHeight + iDGV.Top
                Me.Left = Me.Left + iDGV.Left

                MainMenu.Text = value.Location.ToString
            Catch ex As Exception
                MainMenu.g_notif_panel(0, ex.Message, 2)
            End Try
        End Set
    End Property

    Public Property iCellx As DataGridViewTextBoxCell
        Get
            Return iCell
        End Get
        Set(value As DataGridViewTextBoxCell)
            iCell = value
        End Set
    End Property

    Public Property iColumnNameSearch As String
        Get
            Return iColumnNameForSearch
        End Get
        Set(value As String)
            iColumnNameForSearch = value
        End Set
    End Property


    Public Property iDatasetx As DataTable
        Get
            Return iDataset
        End Get
        Set(value As DataTable)
            iDataset = value
        End Set
    End Property




    'Public Property iDGV As DataGridView
    '    Get
    '        Return iDGVx
    '    End Get
    '    Set(value As DataGridView)
    '        iDGVx = value

    '    End Set
    'End Property


    'Private Sub Textbox_TextChanged(sender As Object, e As EventArgs)
    '    Try
    '        dgv_1.Columns.Clear()
    '        dgv_1.DataSource = Nothing
    '        Dim iQry As String = iColumnNameForSearch & " Like '%" & TextBox.Text & "%'"
    '        iDataset.Select(iQry)
    '        Dim inewDataRow() As DataRow = iDataset.Select(iQry)
    '        For i = 0 To iDataset.Columns.Count - 1
    '            ADD_Column(iDataset.Columns(i).Caption, 1, i, 50, dgv_1, True)
    '        Next
    '        Dim row()
    '        ReDim row(dgv_1.Columns.Count)
    '        For i As Integer = 0 To inewDataRow.Count - 1
    '            For ii As Integer = 0 To iDataset.Columns.Count - 1
    '                row(ii) = inewDataRow(i)(ii)
    '            Next
    '            dgv_1.Rows.Add(row)
    '        Next
    '    Catch ex As Exception
    '        MainMenu.g_notif_panel(0, ex.Message, 2)
    '    End Try
    'End Sub

    Private Sub Textbox_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            iCell.Tag = dgv_1.SelectedRows(0).Cells(0).Value
            iCell.Value = dgv_1.SelectedRows(0).Cells(0).Value
        End If
    End Sub

    Private Sub uc_col_finder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgv_1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_1.CellContentClick

    End Sub

    Private Sub dgv_1_DoubleClick(sender As Object, e As EventArgs) Handles dgv_1.DoubleClick
        iDgvCell1.Value = dgv_1.SelectedRows(0).Cells(0).Value
        iDgvCell2.Value = dgv_1.SelectedRows(0).Cells(1).Value
        iBtnExitx.PerformClick()
    End Sub

    Private Sub dgv_1_KeyUp(sender As Object, e As KeyEventArgs) Handles dgv_1.KeyUp
        If e.KeyCode = Keys.Enter Then
            iDgvCell1.Value = dgv_1.SelectedRows(0).Cells(0).Value
            iDgvCell2.Value = dgv_1.SelectedRows(0).Cells(1).Value
            iBtnExitx.PerformClick()
        End If
    End Sub
End Class
