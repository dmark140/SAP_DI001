Public Class uc_dgv_col_withArrow
    Public DatagridView As DataGridView
    Public BATCHSELECTIONFORM As batch_selectionForm

    Public iTypex As String

    Public iITEMX As String
    Public iSTATUS As String
    Public iIWSEX As String
    Public iiQTYNEED As String
    Public iIDOCNUM As String
    Public iIROW As Integer


    Public Property iType As String
        Get
            Return iTypex
        End Get
        Set(value As String)
            iTypex = value
        End Set
    End Property


    Public Property IROW As Integer
        Get
            Return iIROW
        End Get
        Set(value As Integer)
            iIROW = value
        End Set
    End Property

    Public Property iITEMXx As String
        Get
            Return iITEMX
        End Get
        Set(value As String)
            iITEMX = value
        End Set
    End Property
    Public Property iIWSEXx As String
        Get
            Return iIWSEX
        End Get
        Set(value As String)
            iIWSEX = value
        End Set
    End Property
    Public Property iiQTYNEEDx As String
        Get
            Return iiQTYNEED
        End Get
        Set(value As String)
            iiQTYNEED = value
        End Set
    End Property

    Public Property iIDOCNUMx As String
        Get
            Return iIDOCNUM
        End Get
        Set(value As String)
            iIDOCNUM = value
        End Set
    End Property

    Public Property iSTATUSx As String
        Get
            Return iSTATUS
        End Get
        Set(value As String)
            iSTATUS = value
        End Set
    End Property


    Public Property iDataGridView As DataGridView
        Get
            Return DatagridView
        End Get
        Set(value As DataGridView)
            DatagridView = value
        End Set
    End Property



    Public Property iBatchSelectionFOrm As batch_selectionForm
        Get
            Return BATCHSELECTIONFORM
        End Get
        Set(value As batch_selectionForm)
            BATCHSELECTIONFORM = value
        End Set
    End Property
    

    Public Property iText As String
        Get
            Return lbl.Text
        End Get
        Set(value As String)
            lbl.Text = value
        End Set
    End Property


    Private Sub lbl_Click(sender As Object, e As EventArgs) Handles lbl.Click
        Me.Width = lbl.Width + lbl.Left + 10
    End Sub




    Private Sub btn_Item_arrow_Click(sender As Object, e As EventArgs) Handles btn_Item_arrow.Click

        Try
            Dim iTAG_CONTAINER() As String
            iTAG_CONTAINER = Split(Me.Tag, "|")
            If iTAG_CONTAINER(0) = "1" Then
                Dim iSelBatchModule As New batch_selectionForm

                iSelBatchModule.iStatus = iSTATUS
                iSelBatchModule.iType = iTypex
                iSelBatchModule.ITEMX = iITEMX
                iSelBatchModule.IWSEX = iIWSEX
                iSelBatchModule.iQTYNEED = iiQTYNEED
                iSelBatchModule.ROW = iTAG_CONTAINER(1)
                iSelBatchModule.IDOCNUM = iIDOCNUM
                iSelBatchModule.iDGV = DatagridView

                iSelBatchModule.UC_ARROW = Me
                iSelBatchModule.TopLevel = False

                iBatchSelectionFOrm = iSelBatchModule
                DatagridView.Parent.Controls.Add(iSelBatchModule)
                iIROW = iTAG_CONTAINER(1)

                iSelBatchModule.Left = 0
                iSelBatchModule.Top = Me.Top + DatagridView.Top + DatagridView.ColumnHeadersHeight
                iSelBatchModule.Left = 0

                iSelBatchModule.Show()
                DatagridView.Parent.Controls.SetChildIndex(iSelBatchModule, 999)
                DatagridView.SendToBack
            End If

        Catch ex As Exception
            '     MainMenu.g_notif_panel(0, "0001 - " & ex.Message, 2)
        End Try

    End Sub

End Class
