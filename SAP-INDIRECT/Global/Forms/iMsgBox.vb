Public Class iButtonBox
    Public value As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        value = False
    End Sub
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        value = True
    End Sub

    Private Sub iMsgBox_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.btn_ok.Select()
    End Sub

    Private Sub iMsgBox_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.btn_ok.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class