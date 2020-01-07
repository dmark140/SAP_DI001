Public Class uc_date
    Dim iTransActionTypex As Char
    Dim isForFindx As Boolean

    Dim iSQL_ID As Integer
    Dim iDescription As Label
    Dim iFORMx As Form

    Dim iForSearch As Boolean

    Dim iOnload_IsEnabled As Boolean
    Dim iOnload_isFind As Boolean

    Private Sub uc_date_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iOnload_IsEnabled = IsEnabled
        iOnload_isFind = isForFind
        setWidths()
        dtp_date.BringToFront()
        Me.dtp_date.Value = Now
    End Sub

    Public Property isForFind As Boolean
        Get
            Return isForFindx
        End Get
        Set(value As Boolean)
            isForFindx = value
        End Set
    End Property

    Public Property IsEnabled As Boolean
        Get
            Return isForFindx
        End Get
        Set(value As Boolean)
            isForFindx = value
        End Set
    End Property


    Public Property idsc As Label
        Get
            Return iDescription
        End Get
        Set(value As Label)
            iDescription = value
        End Set
    End Property



    Public Property iIsForSearch As Boolean
        Get
            Return iForSearch
        End Get
        Set(value As Boolean)
            iForSearch = value
        End Set
    End Property


    Public Property iSQL_Parameter_ID As Integer
        Get
            Return iSQL_ID
        End Get
        Set(value As Integer)
            iSQL_ID = value
        End Set
    End Property



    Public Property iLabel_width As Integer
        Get
            Return lbl_text.Width
        End Get
        Set(value As Integer)
            lbl_text.Width = value
            setWidths()
        End Set
    End Property




    Public Property iLabel As String
        Get
            Return lbl_text.Text
        End Get
        Set(value As String)
            lbl_text.Text = value
            setWidths()
        End Set
    End Property

    Public Property iDate As Date
        Get
            Return dtp_date.Value
        End Get
        Set(value As Date)
            dtp_date.Value = value
        End Set
    End Property



    Public Property iForm As Form
        Get
            Return iFORMx
        End Get
        Set(value As Form)
            iFORMx = value
        End Set
    End Property









    Sub setWidths()
        dtp_date.Left = lbl_text.Width - 5
        dtp_date.Width = Me.Width - lbl_text.Width
    End Sub



    Private Sub dtp_date_ValueChanged(sender As Object, e As EventArgs) Handles dtp_date.ValueChanged

    End Sub

    Private Sub lbl_text_Click(sender As Object, e As EventArgs) Handles lbl_text.Click

    End Sub

    ''' <summary>
    ''' Retruns or Set the transaction type 
    ''' </summary>
    ''' <value>
    ''' A = Add &#xD
    ''' U = Update&#xD
    ''' F = Find&#xD
    ''' D = Delete&#xD
    ''' </value>
    ''' <remarks></remarks> 
    Sub TransactionTrig(iTrig As Char)
        If iTrig = "F" Then
            dtp_date.BackColor = g_colors.Yellow_Find
            dtp_date.Enabled = iOnload_isFind
        ElseIf iTrig <> "F" Then
            dtp_date.BackColor = g_colors.WhiteNore
            dtp_date.Enabled = iOnload_IsEnabled
        End If
    End Sub

    Private Sub uc_date_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        setWidths()
    End Sub
End Class
