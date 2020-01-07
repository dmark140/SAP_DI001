Public Class uc_dropdown
    Private Sub uc_dropdown_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setWidths()
        cb_list.BringToFront()
    End Sub

    Dim iSQL_ID As Integer
    Dim iDescription As Label
    Dim iFORMx As Form
    Dim iAdditQRT As String
    Dim iForSearch As Boolean
    Dim iIsVerticalz As Boolean = False
    Dim iSetWidth As Integer
    Dim iAddition As String
    Public ilblText As TextBox

    Public Property idsc As Label
        Get
            Return iDescription
        End Get
        Set(value As Label)
            iDescription = value
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

    Public Property iIsEnabled As Boolean
        Get
            Return cb_list.Enabled
        End Get
        Set(value As Boolean)
            cb_list.Enabled = value
        End Set
    End Property

    Public Property iLabel_width As Integer
        Get
            Return iSetWidth
        End Get
        Set(value As Integer)
            lbl_text.Width = value
            iSetWidth = value
            setWidths()
        End Set
    End Property

    Sub setWidths()
        If iIsVerticalz = False Then
            cb_list.Left = lbl_text.Width - 5
            cb_list.Width = Me.Width - lbl_text.Width
        End If
    End Sub

    Private Sub uc_label_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        setWidths()
    End Sub

End Class
