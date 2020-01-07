Imports MetroFramework.Controls

Public Class EDS_OEE_GENERALSETTINGS
    Private Sub EDS_OEE_GENERALSETTINGS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim iMetroTab As New MetroTabControl
        Me.Controls.Add(iMetroTab)
        iMetroTab.Show()
        iMetroTab.Dock = DockStyle.Fill
        iMetroTab.Style = MetroFramework.MetroColorStyle.Black

        MainMenu.AddTabWthForm("IpicIndirect.EDS_OEE_DowntimeList", "Downtime List", iMetroTab, False)

        iMetroTab.SelectedIndex = 0
    End Sub
End Class