Public Class EDS_Authorization
    Private Sub Uc_inputbox1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub EDS_Authorization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EDS_G_SET_TV(Me.tvNode)

    End Sub

    Private Sub txt_user_TextChanged(sender As Object, e As EventArgs) Handles txt_user.TextChanged
        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "13")
        EDS_SQL_PARAM_ADD("@val1", uc_userID.iText.ToString)
        Dim iDt As DataSet = EDS_G_iSQL()
        If iDt.Tables(0).Rows.Count Then
            uc_fullname.iText = iDt.Tables(0).Rows(0)("Fullname")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "35")
            EDS_SQL_PARAM_ADD("@val1", CInt(uc_userID.iText))
            EDS_SQL_PARAM_ADD("@val2", CheckBox1.Checked)
            Dim iDt As DataSet = EDS_G_iSQL()
            iSaveNodes(Me.tvNode.Nodes)
            '    iUnselectTv(Me.tvNode.Nodes)
            MainMenu.g_notif_panel(1, "12 - Transaction Success ", 2)
        Catch ex As Exception

        End Try
    End Sub


    Sub iSaveNodes(ByVal cols As TreeNodeCollection)
        Try
            For Each RootnodE As TreeNode In cols
                Dim iNodeSplit() As String = Split(RootnodE.Tag, "|")
                EDS_SQL_PARAM.Clear()
                If (iNodeSplit(1) = "M" Or iNodeSplit(1) = "R") And RootnodE.Checked Then
                    EDS_SQL_PARAM_ADD("@SQLID", "12")
                    EDS_SQL_PARAM_ADD("@val1", CInt(uc_userID.iText)) ' userId
                    EDS_SQL_PARAM_ADD("@val2", iNodeSplit(2)) ' moduleID
                    EDS_SQL_PARAM_ADD("@val3", EDS_USERID) ' createdBy
                    Dim iDt As DataSet = EDS_G_iSQL()
                End If
                If RootnodE.Nodes.Count > 0 Then
                    iSaveNodes(RootnodE.Nodes)
                End If
            Next RootnodE
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub

    Sub iUnselectTv(ByVal cols As TreeNodeCollection)
        Try
            For Each RootnodE As TreeNode In cols
                RootnodE.Checked = False
            Next RootnodE
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub

    Private Sub tvNode_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvNode.AfterSelect

    End Sub

    Private Sub tvNode_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tvNode.MouseDoubleClick
        MainMenu.g_notif_panel(2, tvNode.SelectedNode.Tag, 2)
    End Sub
End Class