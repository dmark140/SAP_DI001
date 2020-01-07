Imports System.Data.SqlClient

Public Class EDS_FolderMaker
    Dim saveCounter As Integer = 0
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Dim iNode As TreeNode
        iNode = tvNode.Nodes.Add(uc_lbl_folderName.iText & "*")
        tvNode.ExpandAll()
        saveCounter = saveCounter + 1
        uc_lbl_folderName.iText = ""
        uc_lbl_folderName.inputBox.Select()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim iNode As TreeNode
            iNode = tvNode.SelectedNode.Nodes.Add(uc_lbl_folderName.iText & "*")
            tvNode.ExpandAll()
            saveCounter = saveCounter + 1

            uc_lbl_folderName.iText = ""
            uc_lbl_folderName.inputBox.Select()
        Catch ex As Exception
            MainMenu.g_notif_panel(0, "Please Select A Parent Folder", 1)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_upload.Click
        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "5")
        Dim iDt As DataSet = EDS_G_iSQL()
        EDS_PARAM_VALIDATION(iDt)
        iSaveNodes(tvNode.Nodes)
    End Sub
    Sub iSaveNodes(ByVal cols As TreeNodeCollection)
        For Each RootnodE As TreeNode In cols
            EDS_SQL_PARAM.Clear()
            saveCounter = saveCounter + 1
            RootnodE.Tag = saveCounter
            Dim iSPlitStar() As String = Split(RootnodE.Text, "*")
            If iSPlitStar.Count = 2 Then

                If IsNothing(RootnodE.Parent) = False Then
                    EDS_SQL_PARAM_ADD("@SQLID", "3")
                    EDS_SQL_PARAM_ADD("@val1", iSPlitStar(0)) '' folderName
                    EDS_SQL_PARAM_ADD("@val2", RootnodE.Tag) '' folderKey
                    EDS_SQL_PARAM_ADD("@val3", RootnodE.Parent.Tag) '' folderFatherKey
                    EDS_SQL_PARAM_ADD("@val4", "3") '' createdby
                Else
                    EDS_SQL_PARAM_ADD("@SQLID", "3")
                    EDS_SQL_PARAM_ADD("@val1", iSPlitStar(0)) '' folderName
                    EDS_SQL_PARAM_ADD("@val2", RootnodE.Tag) '' folderKey
                    EDS_SQL_PARAM_ADD("@val3", "0") '' folderFatherKey
                    EDS_SQL_PARAM_ADD("@val4", "3") '' createdby
                End If
                Dim iDt As DataSet = EDS_G_iSQL()
                EDS_PARAM_VALIDATION(iDt)
                RootnodE.Text = iSPlitStar(0)
            End If
            If RootnodE.Nodes.Count > 0 Then
                iSaveNodes(RootnodE.Nodes)
            End If
        Next RootnodE
    End Sub

    Private Sub EDS_FolderMaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        saveCounter = EDS_FOLDER_TREEVIEW(tvNode)
    End Sub
End Class

'If CInt(EDS_DS.Tables(0).Rows(i)("folderFatherKey")) <> 0 Then
'Dim iFather = tvNode.Nodes.Find(nodeParent, True).FirstOrDefault()
'iFather.Nodes.Add(nodeKey, nodeValue)
'iNode.Text =
' iNode.Tag = EDS_DS.Tables(0).Rows(i)("folderKey")
'tvNode.Nodes.Add(iNode)
'Else
'iNode.Text = EDS_DS.Tables(0).Rows(i)("folderName")
'iNode.Tag = EDS_DS.Tables(0).Rows(i)("folderKey")
'tvNode.Nodes.Add(iNode)
'End If
