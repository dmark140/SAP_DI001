Public Class CrystalReportPreview
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles Report.Load

    End Sub

    Private Sub CrystalReportPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrystalReportPreview_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        MainMenu.g_notif_panel(1, e.KeyCode, 2)
    End Sub

    Private Sub Report_KeyDown(sender As Object, e As KeyEventArgs) Handles Report.KeyDown
        MainMenu.g_notif_panel(1, e.KeyCode, 2)

    End Sub
End Class