Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iti As Integer
        iti = TextBox1.Text
        MsgBox(iti, vbInformation)


        MsgBox(Fix(TextBox1.Text))
        'Dim intgr As Integer = Integer.Parse(TextBox1.ToString.Split("."c)(0))
        'MsgBox(intgr.ToString)

        'Dim sTemp As String = Val(TextBox1.Text)
        'Dim sTemp2 As String
        'sTemp2 = sTemp.Substring(0, (sTemp.IndexOf(".") - 1))
        'MsgBox(sTemp2)
    End Sub
End Class