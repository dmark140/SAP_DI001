Public Class Proration
    Private Sub Proration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Proration_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If (TextBox9.Left + TextBox9.Width + 20) < (Panel1.Left) Then Panel1.Left = 843
    End Sub

End Class