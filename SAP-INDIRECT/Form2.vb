
Public Class Form2
    Dim FILE_NAME As String = "C:\Program Files (x86)\SAP\SAP Business One SDK\text.txt"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 62
        Call Note_load()
    End Sub
    Private Sub FormSet()
        If Me.Height = 524 Then
            Me.Height = 62
            Me.StartPosition = FormStartPosition.CenterScreen
            Panel2.Visible = True
        Else
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Height = 524
            Panel2.Visible = False
        End If
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim formnewleft As Integer = (screenWidth / 2) - (Me.Width / 2)
        Dim formnewTop As Integer = (screenHeight / 2) - (Me.Height / 2)
        Me.Left = formnewleft
        Me.Top = formnewTop
        'Timer1.Enabled = False
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
        Dim i As Integer
        objWriter.WriteLine(txtServer.Text)
        objWriter.WriteLine(txtdn.Text)
        objWriter.WriteLine(txtsapu.Text)
        objWriter.WriteLine(txtsapp.Text)
        objWriter.WriteLine(txtServerType.SelectedIndex.ToString)
        objWriter.WriteLine(txtdbu.Text)
        objWriter.WriteLine(txtdbp.Text)
        objWriter.WriteLine(txtsl.Text)
        objWriter.Close()
        Note_load()
        FormSet()
    End Sub
    Private Sub Note_load()
        Dim _swFile As System.IO.StreamReader
        Dim n(7) As String
        Dim i As Integer
        ' Prepare the file to be read
        _swFile = System.IO.File.OpenText(FILE_NAME)
        ' Loop the file until end
        While Not _swFile.EndOfStream
            ' Read a single line
            n(i) = _swFile.ReadLine
            i += 1
        End While
        txtServerType.Items.Clear()
        txtServerType.Items.Add("") '0
        txtServerType.Items.Add("MSSQL") '1
        txtServerType.Items.Add("DB_2") '2
        txtServerType.Items.Add("SYBASE") '3
        txtServerType.Items.Add("MSSQL2005") '4
        txtServerType.Items.Add("MAXDB") '5 
        txtServerType.Items.Add("MSSQL2008") '6 
        txtServerType.Items.Add("MSSQL2012") '7 
        txtServerType.Items.Add("MSSQL2014") '8 
        txtServerType.Items.Add("HANADB") '9
        txtServerType.Items.Add("MSSQL2016") '10 
        txtServerType.Items.Add("MSSQL2017") '11 
        strServer = n(0)
        strDataName = n(1)
        strSAPuserName = n(2)
        strSAPpassw = n(3)
        strServerType = n(4)
        strDBusername = n(5)
        strDBpassw = n(6)
        strServerLicense = n(7)
        txtServer.Text = strServer
        txtdn.Text = strDataName
        txtsapu.Text = strSAPuserName
        txtsapp.Text = strSAPpassw
        txtServerType.SelectedIndex = strServerType
        txtdbu.Text = strDBusername
        txtdbp.Text = strDBpassw
        txtsl.Text = strServerLicense
        _swFile.Close()
        'Call First_Load()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call First_Load()
    End Sub

    Public Function First_Load() As Boolean
        Try
            If oCompany.Connected = True Then
                Timer1.Enabled = False
                Return True
                Me.Hide()
                MainMenu.Show()

            End If
        Catch ex As Exception
        End Try
        Try
            oCompany = New SAPbobsCOM.Company
            oCompany.Server = strServer ' SQL server 
            oCompany.CompanyDB = strDataName ' Sql Database name
            oCompany.UserName = strSAPuserName 'SAP username credentials 
            oCompany.Password = strSAPpassw 'SAP password credentials 
            oCompany.DbServerType = strServerType 'db server type
            oCompany.DbUserName = strDBusername
            oCompany.DbPassword = strDBpassw
            oCompany.LicenseServer = strServerLicense
            retVal = oCompany.Connect
            If retVal <> 0 Then
                Timer1.Enabled = False
                oCompany.GetLastError(retVal, retStr)
                MsgBox("Error Code:" & retVal & " " & retStr)
                Call FormSet()
            Else
                Me.Hide()
                MainMenu.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        End
    End Sub

    Private Sub txtdbp_Click(sender As Object, e As EventArgs) Handles txtdbp.Click

    End Sub
End Class