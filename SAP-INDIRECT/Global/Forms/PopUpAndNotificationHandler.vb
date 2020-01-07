
Imports Microsoft.Win32
Imports System.IO

Public Class PopUpAndNotificationHandler
    Dim IcOUNT As Integer
    Dim SYSTEM_MODEx As String
    Dim USER As String

    Dim iRefract As String = System.Reflection.Assembly.GetExecutingAssembly.Location()
    Declare Sub Sleep Lib "kernel32.dll" (ByVal Milliseconds As Integer)
    Private Sub PopUpAndNotificationHandler_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ''   SYSTEM_MODEx = "EDS"
        If SYSTEM_MODE = "EDS" Then
            Try
                Dim iReadObj As Object = IReadFile()
                USER = iReadObj(0)
                SYSTEM_MODEx = iReadObj(1)

                EDS_SQL_PARAM.Clear()
                EDS_SQL_PARAM_ADD("@SQLID", "56")
                EDS_SQL_PARAM_ADD("@val1", "S") ' 
                EDS_SQL_PARAM_ADD("@val2", USER) ' .
                Dim iDt As DataSet = EDS_G_iSQL()
                For i = 0 To iDt.Tables(0).Rows.Count - 1
                    PopUp(iDt.Tables(0).Rows(0)("Subject"), iDt.Tables(0).Rows(i)("iMsg"), iDt.Tables(0).Rows(i)("id"), 3)
                    EDS_SQL_PARAM.Clear()
                    EDS_SQL_PARAM_ADD("@SQLID", "58")
                    EDS_SQL_PARAM_ADD("@val1", iDt.Tables(0).Rows(i)("id")) ' 
                    EDS_SQL_PARAM_ADD("@val2", "R") ' 
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
                    Threading.Thread.CurrentThread.Sleep(2000)
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
                    EDS_G_iSQL()
                Next

            Catch ex As Exception
                '          MsgBox(ex.Message)
            End Try
        ElseIf SYSTEM_MODE = "SAP" Then

        End If


    End Sub




    Function IReadFile() As Object
        Dim iPathAr = iRefract.Split("\")
        Dim conifPath = ""
        For i As Integer = 0 To iPathAr.Count - 4
            conifPath = conifPath + iPathAr(i) + "\"
        Next
        conifPath = conifPath + "login.txt"

        Dim iAr(3) As String
        Dim ii As Integer = 0
        Dim iConIf As New System.IO.StreamReader(conifPath)
        While Not iConIf.EndOfStream
            iAr(ii) = iConIf.ReadLine()
            ii = ii + 1
        End While
        Dim iUSER = iAr(0)       ''user id 
        Dim iSYSTEM_MODEx = iAr(1) ''System mode 

        iConIf.Close()
        Return {iUSER, iSYSTEM_MODEx}
    End Function




    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = MouseButtons.Right Then
            NotifyIcon1.ContextMenuStrip.Show()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PopUpAndNotificationHandler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Dim info As New FileInfo(Application.StartupPath)
        '  info.CopyTo(My.Computer.FileSystem.SpecialDirectories.Programs + "\startup\IPIC-SAP-DI-NOTIF.exe", True)
        ''   My.Computer.Registry.LocalMachine.OpenSubKey("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
        'My.Computer.Registry.LocalMachine.OpenSubKey("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", False).SetValue(Application.ProductName, Application.ExecutablePath)

        'Dim regKey As RegistryKey
        'regKey = Registry.LocalMachine.OpenSubKey("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        'regKey.SetValue(Application.ProductName, Application.ExecutablePath)
        'regKey.Close()

    End Sub

    Private Sub NotifyIcon2_MouseDoubleClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        '    iText()
    End Sub
End Class


