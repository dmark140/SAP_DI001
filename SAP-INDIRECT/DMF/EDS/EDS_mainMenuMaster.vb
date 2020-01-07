Imports MetroFramework.Controls
Public Class EDS_mainMenuMaster
    Private Sub EDS_mainMenuMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim iMetroTab As New MetroTabControl
        Me.Controls.Add(iMetroTab)
        iMetroTab.Show()
        iMetroTab.Dock = DockStyle.Fill
        iMetroTab.Style = MetroFramework.MetroColorStyle.Black
        MainMenu.AddTabWthForm("IpicIndirect.EDS_FolderMaker", "Folder Maker", iMetroTab, False)
        MainMenu.AddTabWthForm("IpicIndirect.EDS_ModuleMaster", "Module Maker", iMetroTab, False)
        MainMenu.AddTabWthForm("IpicIndirect.EDS_Authorization", "Authorization", iMetroTab, False)
        MainMenu.AddTabWthForm("IpicIndirect.EDS_Ticketing_Assigner", "Ticketing Assigner", iMetroTab, False)
        MainMenu.AddTabWthForm("IpicIndirect.iReportSettings", "Report", iMetroTab, False)
        '  MainMenu.AddTabWthForm("IpicIndirect.EDS_MachineList", "Machine Master", iMetroTab, False)
        '  MainMenu.AddTabWthForm("IpicIndirect.EDS_Warehouse", "Warehouse  Master", iMetroTab, False)
        iMetroTab.SelectedIndex = 0

    End Sub
End Class