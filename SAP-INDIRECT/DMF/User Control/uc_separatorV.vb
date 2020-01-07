Public Class uc_separatorV



    Dim iFOrmContainer As Form



    Public Property iForm As Form
        Get
            Return iFOrmContainer
        End Get
        Set(value As Form)
            iFOrmContainer = value
            Me.Height = value.Height
            Me.Top = 0
        End Set
    End Property



    Private Sub uc_separatorV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
