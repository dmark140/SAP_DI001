Imports System.ComponentModel
Imports System.Management
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Threading
Public Class SMSHandler
    Dim iPortx As String
    Dim ErrCount As Integer
    Dim SntCount As Integer
    Dim iLastSend As Date


    Private Sub SMSHandler_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SMSHandler_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Me.Location = New Point(x, y)
        Me.Hide()
    End Sub

    Sub iText()
        'If SYSTEM_MODE = "EDS" Then
        Timer1.Enabled = False
        Dim iPort = ModemPortUpdate()
        NotifyIcon1.Text = iPort
        uc_port.iText = iPort
        If uc_port.iText <> "" Then
            Try

                '     iPortx = iPort
                '  uc_port.iText = iPortx
                If uc_port.iText <> "" Then
                    EDS_SQL_PARAM.Clear()
                    EDS_SQL_PARAM_ADD("@SQLID", "62")
                    EDS_SQL_PARAM_ADD("@val1", "P") ' 
                    Dim iDt As DataSet = EDS_G_iSQL()
                    Dim iIfInFor = False
                    Dim smsiD As String = ""
                    Dim iSent As Boolean = False
                    For i = 0 To iDt.Tables(0).Rows.Count - 1
                        iIfInFor = True
                        ''>> SEND
                        ''>> UPDATE DONE SENDING

                        iSent = iTextWithHandler(
                                        iDt.Tables(0).Rows(i)("msg"),
                                        iDt.Tables(0).Rows(i)("Mobilenumber"),
                                        iPort,
                                        Me.NotifyIcon1
                                        )

                        If iSent Then
                            SntCount = SntCount + 1
                            iLastSend = Now.ToShortDateString & " " & Now.ToShortTimeString
                        Else
                            ErrCount = ErrCount + 1
                        End If
                        smsiD = iDt.Tables(0).Rows(0)("id")
                        Thread.Sleep(2000)
                    Next


                    EDS_SQL_PARAM.Clear()
                    EDS_SQL_PARAM_ADD("@SQLID", "63")
                    EDS_SQL_PARAM_ADD("@val1", smsiD) ' 
                    If iSent Then EDS_SQL_PARAM_ADD("@val2", "S")
                    If iSent = False Then EDS_SQL_PARAM_ADD("@val2", "E") ' 
                    EDS_G_iSQL()
                    '  uc_port.iText = iPortx
                    uc_errcounter.iText = ErrCount
                    uc_msgSend.iText = SntCount
                    uc_lstDate.iText = iLastSend
                    '>>TEXT  TO Developer
                    '' iTextWithHandler(Now.ToShortDateString & " " & Now.ToShortTimeString & "Modem is not connected and not sending any port")
                    '' BOBO MOVE
                End If
            Catch ex As Exception
                uc_errcounter.iText = ex.Message
                Timer1.Enabled = True
            End Try
        End If
        '     ElseIf SYSTEM_MODE = "SAP" Then
        '  End If
        Timer1.Enabled = True
    End Sub

    Private Sub SMSHandler_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        e.Cancel = True
        Me.Hide()

    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        iText()
    End Sub

    Private Sub uc_port_Load(sender As Object, e As EventArgs) Handles uc_port.Load

    End Sub
End Class