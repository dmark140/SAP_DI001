Public Class uc_separatorH

    Dim iFOrmContainer As Form



    Public Property iForm As Form
        Get
            Return iFOrmContainer
        End Get
        Set(value As Form)
            iFOrmContainer = value
            Me.Width = value.Width
            Me.Left = 0
        End Set
    End Property

    Private Sub uc_separator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsNothing(iFOrmContainer) = False Then
            Me.Width = iFOrmContainer.Width
            Me.Left = 0
        End If
    End Sub





End Class
