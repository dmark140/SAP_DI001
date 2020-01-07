Public Class uc_Notification


    Private Sub uc_Notification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(btn_close, "Exit")
        ToolTip1.SetToolTip(btn_copy, "Copy to clip board")
    End Sub
    Sub iPop()


    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub
End Class
