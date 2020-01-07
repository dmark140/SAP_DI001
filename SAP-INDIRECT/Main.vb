
Module Main

    Public oCompany As SAPbobsCOM.Company
    Public oCompanyService As SAPbobsCOM.CompanyService

    Public retVal As Long
    Public retStr As String
    Public InvNum As String

    Public strServer As String
    Public strDataName As String
    Public strSAPuserName As String
    Public strSAPpassw As String
    Public strServerType As String
    Public strDBusername As String
    Public strDBpassw As String
    Public strServerLicense As String

    Public Sub oDC()
        Try
            If oCompany.Connected = True Then
                oCompany.Disconnect()
            End If
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub
    Public Function oConnect() As Boolean
        Try
            If oCompany.Connected = True Then
                Return True
            End If
        Catch ex As Exception
        End Try
        Try
            oCompany = New SAPbobsCOM.Company
            oCompany.Server = Global_var.g_txtServerIP ' SQL server 
            oCompany.CompanyDB = Global_var.g_txtDatabase  ' Sql Database name
            oCompany.UserName = Global_var.g_txtUserID 'SAP username credentials 
            oCompany.Password = Global_var.g_txtPassword 'SAP password credentials 
            oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2014 'db server type
            oCompany.DbUserName = Global_var.g_txtDbUserName
            oCompany.DbPassword = Global_var.g_txtDbPassword
            oCompany.LicenseServer = Global_var.g_txtServerIP

            retVal = oCompany.Connect


            If retVal <> 0 Then
                oCompany.GetLastError(retVal, retStr)
                '      MainMenu.g_notif_panel(1, "Error Code:" & retVal & " " & retStr, 1)
            Else
                ' p'       MainMenu.g_notif_panel(1, "Error Code:" & retVal & " " & retStr, 1)
                Return True
            End If

            oCompanyService = oCompany.GetCompanyService





        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.ToString, 1)
            Return False
        End Try

    End Function

    Function oDisconnect() As Boolean
        Try
            Try
                If oCompany.Connected = True Then

                    oCompany.Disconnect()

                    MainMenu.g_notif_panel(1, "Successfully disconnected to company database.", 1)

                End If
            Catch ex As Exception
                MainMenu.g_notif_panel(2, "You are not connected to company database", 1)

            End Try
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Module