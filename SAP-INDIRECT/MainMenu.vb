Public Class MainMenu
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        g_MainPanel = mainPanel
        g_splitPanel = SplitCon
        g_tv = tvNode
        LogInMenu()

    End Sub

    Private Sub mainPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Sub LogInMenu()
        SplitCon.Enabled = False
        mainPanel.Visible = True
        mainPanel.Dock = DockStyle.Fill
        Dim xiLogin As New iLogin
        xiLogin.TopLevel = False
        xiLogin.TopMost = True
        mainPanel.Controls.Add(xiLogin)
        xiLogin.Top = (mainPanel.Height / 2) - (xiLogin.Height / 2)
        xiLogin.Left = (mainPanel.Width / 2) - (xiLogin.Width / 2)
        g_form = xiLogin
        xiLogin.Show()

        SplitCon.SplitterDistance = 282
    End Sub

    Private Sub MainMenu_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        SplitCon.SplitterDistance = 282
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Sub AddTabWthForm(ByVal iNameSpace As String, ByVal ModuleName As String)
        Dim iMainNewTab As New TabPage


        Dim iForm As Form = Nothing
        Dim frmNewForm_Type As Type = Type.GetType(iNameSpace)
        iForm = CType(Activator.CreateInstance(frmNewForm_Type), Form)



        iForm.TopLevel = False
        iForm.TopMost = True
        With iMainNewTab
            .Text = "    " & ModuleName & "    "

            .Controls.Add(iForm)
        End With
        MainTab.TabPages.Add(iMainNewTab)
        iForm.Show()
        iForm.Dock = DockStyle.Fill
        MainTab.SelectedTab = iMainNewTab
    End Sub



    Private Sub tvNode_DoubleClick(sender As Object, e As EventArgs) Handles tvNode.DoubleClick
        Try

            Dim iTagSplit() As String
            If tvNode.SelectedNode.Tag IsNot Nothing Then

                iTagSplit = tvNode.SelectedNode.Tag.ToString.Split("|")
                AddTabWthForm(iTagSplit(0), iTagSplit(1))
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub MainMenu_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        SplitCon.SplitterDistance = 282
    End Sub

    Private Sub tvNode_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvNode.AfterSelect

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Uc_treenode1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_bback_Click(sender As Object, e As EventArgs) Handles btn_bback.Click
        Me.Select()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Select()

    End Sub

    Private Sub btn_refreash_Click(sender As Object, e As EventArgs) Handles btn_refreash.Click
        Me.Select()

    End Sub

    Private Sub btn_frwd_Click(sender As Object, e As EventArgs) Handles btn_frwd.Click
        Me.Select()

    End Sub

    Private Sub btn_ffrwd_Click(sender As Object, e As EventArgs) Handles btn_ffrwd.Click
        Me.Select()
        'ads
    End Sub

    Private Sub MainMenu_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Text = "W: " & Me.Width & " H: " & Height
    End Sub
End Class