Public Class NotificationHandler
    Dim DocEntry As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub NotificationHandler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(btn_close, "Exit")
        ToolTip1.SetToolTip(btn_copy, "Copy to clip board")
    End Sub

    Sub iPop(Title As String, Msg As String, id As Integer)
        Dim iHeightAdd As Integer
        'For Each form In My.Application.OpenForms
        '    If (form.name = Me.Name) Then
        '        'form is loaded so can do work 
        '        'if you need to check whether it is actually visible
        '        If form.Visible Then
        '            iHeightAdd = iHeightAdd + Me.Height + 10
        '        End If
        '    End If
        'Next
        'If iHeightAdd > 0 Then
        '    iHeightAdd = iHeightAdd - (Me.Height + 10)
        'End If

        Me.Visible = True
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        y = y - iHeightAdd
        'Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        '    x = x - 2
        'Loop
        x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        Me.Location = New Point(x - 5, y - 5)
        Me.Label1.Text = Title
        Me.Label2.Text = Msg
        Me.TopMost = True

        Me.Show()
        Me.BringToFront()
        Button1.Select()
        iDeliverNotif()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_copy_Click(sender As Object, e As EventArgs) Handles btn_copy.Click
        Clipboard.SetText(Label1.Text + " " + Label2.Text)
    End Sub

    Sub iDeliverNotif()
        Try
            If SYSTEM_MODE = "SAP" Then

            ElseIf SYSTEM_MODE = "EDS" Then

            End If

        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub
End Class