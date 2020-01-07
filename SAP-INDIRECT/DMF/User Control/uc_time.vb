Public Class uc_time
    Dim iTransActionTypex As Char
    Dim isForFindx As Boolean
    Dim ipreLbl As Label
    Dim iSQL_ID As Integer
    Dim iDescription As Label
    Dim iFORMx As Form

    Dim iForSearch As Boolean

    Dim iOnload_IsEnabled As Boolean
    Dim iOnload_isFind As Boolean

    Public iMyTIme As String

    Dim iLinkedColumn As String = ""
    Public Property LinkedColumn As String
        Get
            Return iLinkedColumn
        End Get
        Set(value As String)
            iLinkedColumn = value
        End Set
    End Property
    Private Sub uc_date_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iOnload_IsEnabled = IsEnabled
        iOnload_isFind = isForFind
        setWidths()
        dt_time.BringToFront()


        dt_time.CustomFormat = "HH:mm"
        dt_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        dt_time.ShowUpDown = True
        dt_time.Value = Now

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
            Return dt_time.Value
        End Get
        Set(value As Date)
            dt_time.Value = value
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
        dt_time.Left = lbl_text.Width - 10
        dt_time.Width = Me.Width - lbl_text.Width
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
            dt_time.BackColor = g_colors.Yellow_Find
            dt_time.Enabled = iOnload_isFind
        ElseIf iTrig <> "F" Then
            dt_time.BackColor = g_colors.WhiteNore
            dt_time.Enabled = iOnload_IsEnabled
        End If
    End Sub

    Private Sub uc_time_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        setWidths()
    End Sub

    Private Sub dt_time_ValueChanged(sender As Object, e As EventArgs) Handles dt_time.ValueChanged
        If IsNothing(iDescription) = False Then
            iDescription.Text = dt_time.Value
            iMyTIme = dt_time.Value
        End If
    End Sub

    Private Sub lbl_text_Move(sender As Object, e As EventArgs) Handles lbl_text.Move

    End Sub

    Private Sub lbl_text_MouseEnter(sender As Object, e As EventArgs) Handles lbl_text.MouseEnter
        MainMenu.lbl_hover.Visible = True
        MainMenu.lbl_hover.Text = "T: TIME" & " S:" & iForSearch.ToString & " SQLID: " & iSQL_Parameter_ID.ToString & " V:" & dt_time.Value
    End Sub

    Private Sub lbl_text_MouseLeave(sender As Object, e As EventArgs) Handles lbl_text.MouseLeave
        MainMenu.lbl_hover.Visible = False
    End Sub

    Private Sub dt_time_MouseEnter(sender As Object, e As EventArgs) Handles dt_time.MouseEnter
        MainMenu.lbl_hover.Visible = True
        MainMenu.lbl_hover.Text = "T: TIME" & " S:" & iForSearch.ToString & " SQLID: " & iSQL_Parameter_ID.ToString & " V:" & dt_time.Value

    End Sub

    Private Sub dt_time_MouseLeave(sender As Object, e As EventArgs) Handles dt_time.MouseLeave
        MainMenu.lbl_hover.Visible = False
    End Sub

    Private Sub uc_inputbox_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        MainMenu.lbl_hover.Visible = True
        MainMenu.lbl_hover.Text = "T: TIME" & " S:" & iForSearch.ToString & " SQLID: " & iSQL_Parameter_ID.ToString & " V:" & dt_time.Value

    End Sub
    Private Sub uc_inputbox_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        MainMenu.lbl_hover.Visible = False

    End Sub
End Class
