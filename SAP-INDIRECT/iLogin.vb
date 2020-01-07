Public Class iLogin

    Dim conifPath As String = System.Reflection.Assembly.GetExecutingAssembly.Location()


    Private Sub iLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ilogin()
    End Sub

    Public Sub ilogin()

        Dim iPathAr = conifPath.Split("\")
        conifPath = ""
        For i As Integer = 0 To iPathAr.Count - 3
            conifPath = conifPath + iPathAr(i) + "\"
        Next
        conifPath = conifPath + "conif.txt"
        iMoreOption()
        iConIfReader()


    End Sub


    Public Sub iMoreOption()
        If btn_moreOption.Tag = "1" Then
            With btn_moreOption
                .Tag = "0"
                .BackgroundImage = (Arrows.Images(0))
                Me.Height = 305
            End With
        Else
            With btn_moreOption
                .Tag = "1"
                .BackgroundImage = (Arrows.Images(1))
                Me.Height = 121
            End With
        End If
    End Sub

    Private Sub btn_moreOption_Click(sender As Object, e As EventArgs) Handles btn_moreOption.Click
        iMoreOption()
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        g_txtUserID = txtUser.Text.ToString
        g_txtPassword = txtPass.Text.ToString
        If oConnect() = True Then
            g_iLogInSet()
            'MBOS.Show()
            'MBOS.Top = 0
            'MBOS.Left = 0

        End If
    End Sub

    Public Sub iConIfCreator()
        Dim iConIf As New System.IO.StreamWriter(conifPath)
        iConIf.WriteLine(txtServerIP.Text.ToString)
        iConIf.WriteLine(txtDatabase.Text.ToString)
        iConIf.WriteLine(txtDbUserName.Text.ToString)
        iConIf.WriteLine(txtDbPassword.Text.ToString)
        iConIf.WriteLine(txtCompanyDB.Text.ToString)
        iConIf.Close()
    End Sub

    Public Sub iConIfReader()
        Try

            Dim iAr(5) As String
            Dim ii As Integer = 0
            Dim iConIf As New System.IO.StreamReader(conifPath)


            While Not iConIf.EndOfStream
                iAr(ii) = iConIf.ReadLine()
                ii = ii + 1
            End While

            txtServerIP.Text = iAr(0)
            txtDatabase.Text = iAr(1)
            txtDbUserName.Text = iAr(2)
            txtDbPassword.Text = iAr(3)
            txtCompanyDB.Text = iAr(4)
            Global_var.g_txtServerIP = iAr(0)
            Global_var.g_txtDatabase = iAr(1)
            Global_var.g_txtDbUserName = iAr(2)
            Global_var.g_txtDbPassword = iAr(3)
            Global_var.g_txtCompanyDB = iAr(4)

            g_txtUserID = txtUser.Text
            g_txtPassword = txtPass.Text
            iConIf.Close()

        Catch ex As Exception
            If ex.Message = "Could not find file '" + conifPath + "'." Then
                MsgBox("Connection String Error\Could not find")
            End If

            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btn_createConIF_Click(sender As Object, e As EventArgs) Handles btn_createConIF.Click
        iConIfCreator()
        MsgBox("Connection String Created!")
    End Sub

    Private Sub txtUser_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtUser.MaskInputRejected

    End Sub

    Private Sub txtUser_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUser.KeyUp
        If e.KeyCode = 13 Then btn_ok.PerformClick()
    End Sub

    Private Sub txtPass_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtPass.MaskInputRejected

    End Sub

    Private Sub txtPass_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPass.KeyUp
        If e.KeyCode = 13 Then btn_ok.PerformClick()
    End Sub
End Class

