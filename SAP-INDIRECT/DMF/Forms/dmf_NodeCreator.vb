Public Class dmf_NodeCreator
    Dim saveCounter As Integer = 0
    Dim iNodeID_Inc As Integer = 0
    Dim iNodeConcatID As Integer = 0
    Dim iCodeCon As Integer = 0
    Dim arrString() As String

    Private Sub btn_addRoot_Click(sender As Object, e As EventArgs) Handles btn_addRoot.Click
        Dim iNode As TreeNode

        iNode = tvNode.Nodes.Add(txtText.Text)
        NodeTabSet(iNode)
        tvNode.ExpandAll()
        saveCounter = saveCounter + 1
    End Sub

    Private Sub btn_NewFolder_Click(sender As Object, e As EventArgs) Handles btn_NewFolder.Click
        Try
            Dim iNode As TreeNode
            iNode = tvNode.SelectedNode.Nodes.Add(txtText.Text)
            NodeTabSet(iNode)
            tvNode.ExpandAll()
            saveCounter = saveCounter + 1
        Catch ex As Exception
            MainMenu.g_notif_panel(0, "Please Select A Parent Folder", 1)
        End Try

    End Sub

    Private Sub tvNode_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvNode.AfterSelect
        tvNode.FullRowSelect = True

        NodeTabSplit()
        Try
            txtName.Text = arrString(0)
            txtText.Text = arrString(1)
            txtAccLevel.Text = arrString(2)
        Catch
        End Try

    End Sub

    Private Sub btn_set_Click(sender As Object, e As EventArgs) Handles btn_set.Click
        Try
            NodeTabSet(tvNode.SelectedNode)
        Catch ex As Exception
            MainMenu.g_notif_panel(0, "Please Select A Node", 1)
        End Try
    End Sub

    Private Sub NodeTabSet(ByRef iNode As TreeNode)
        Dim selectedNodeTab As String
        selectedNodeTab = txtName.Text & "|" & txtText.Text & "|" & txtAccLevel.Text
        iNode.Tag = selectedNodeTab
        MainMenu.g_notif_panel(2, selectedNodeTab, 1)

        iNode.Text = txtText.Text
        ''
    End Sub


    Private Sub NodeTabSplit()
        Try
            arrString = Split(tvNode.SelectedNode.Tag, "|")
        Catch ex As Exception
            MainMenu.g_notif_panel(0, "Please Select A Parent Folder", 1)
        End Try
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        save()


        '        btn_ok.Enabled = False
    End Sub


    Sub updatex()
        iBtn_Ok("2", "Update", Button3)
        If btn_ok.Tag = "1" Then
            iNodeConcatID = 0
            nodeUpdate()
            iSaveNodes(tvNode.Nodes)
        Else

            Try
                tvNode.SelectedNode.Text = txtText.Text
                NodeTabSet(tvNode.SelectedNode)
            Catch ex As Exception
                MainMenu.g_notif_panel(0, "Please Select A node", 1)
            End Try
        End If
        iBtn_Ok("2", "Update", Button3)
    End Sub

    Sub save()
        iBtn_Ok("1", "Save", btn_ok)
        If btn_ok.Tag = "1" Then
            iNodeConcatID = 0
            nodeUpdate()
            iSaveNodes(tvNode.Nodes)
        Else

            Try
                tvNode.SelectedNode.Text = txtText.Text
                NodeTabSet(tvNode.SelectedNode)
            Catch ex As Exception
                MainMenu.g_notif_panel(0, "Please Select A node", 1)
            End Try
        End If
        iBtn_Ok("1", "Save", btn_ok)
    End Sub

    Sub iSaveNodes(ByVal cols As TreeNodeCollection)
        ''AD D DATA TO UDT
        '   Call oConnect()




        Dim irecSetx As SAPbobsCOM.Recordset
        irecSetx = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        irecSetx.DoQuery(" SELECT top 1  Code  FROM [@ONOD]  A order by CONVERT(int,code) desc")
        Do While irecSetx.EoF = False
            iCodeCon = irecSetx.Fields.Item("Code").Value
            irecSetx.MoveNext()
        Loop
        For Each RootnodE As TreeNode In cols
            iNodeConcatID = iNodeConcatID + 1
            RootnodE.Tag = RootnodE.Tag & "|" & iNodeConcatID
            iInserNodes(RootnodE)
            If RootnodE.Nodes.Count > 0 Then
                iSaveNodes(RootnodE.Nodes)
            End If
        Next RootnodE
    End Sub
    Sub nodeUpdate()
        Try
            Dim irecSetx As SAPbobsCOM.Recordset
            irecSetx = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            irecSetx.DoQuery(" SELECT  U_void ,U_id   , code,Name    FROM [@ONOD]  A WHERE A.U_void = '1'  order by CONVERT(int,code)  ")
            Do While irecSetx.EoF = False

                Dim oUDT As SAPbobsCOM.UserTable
                oUDT = oCompany.UserTables.Item("ONOD") '' UDT NAME
                iNodeID_Inc = irecSetx.Fields.Item("Code").Value
                oUDT.Code = irecSetx.Fields.Item("Code").Value
                oUDT.Name = irecSetx.Fields.Item("Name").Value
                oUDT.GetByKey(irecSetx.Fields.Item("Code").Value)

                oUDT.UserFields.Fields.Item("U_" + "id").Value = irecSetx.Fields.Item("U_id").Value
                oUDT.UserFields.Fields.Item("U_" + "void").Value = "0"
                retVal = oUDT.Update()

                If retVal <> 0 Then
                    oCompany.GetLastError(retVal, retStr)
                    MainMenu.g_notif_panel(0, "Error " & retVal & " " & retStr, 1)

                Else

                    MainMenu.g_notif_panel(0, irecSetx.Fields.Item("Name").Value & " Updated", 1)
                End If


                irecSetx.MoveNext()
            Loop
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.ToString, 1)
        End Try

    End Sub


    Sub iInserNodes(ByVal iNodee As TreeNode)
        Try

            Dim iNodeSplit() As String
            Dim iNodeSplitParent() As String
            Dim iNodeParentID As String = "0"
            iNodeSplit = Split(iNodee.Tag.ToString, "|")
            If (iNodee.Parent Is Nothing) = False Then
                iNodeSplitParent = Split(iNodee.Parent.Tag.ToString, "|")
                iNodeParentID = iNodeSplitParent(3)
            End If

            'For i As Integer = 0 To iNodeSplit.Count - 1
            '    MsgBox(iNodeSplit(i).ToString)
            'Next 

            Dim oUDT As SAPbobsCOM.UserTable
            oUDT = oCompany.UserTables.Item("ONOD") '' UDT NAME
            iNodeID_Inc = iNodeID_Inc + 1
            oUDT.Code = iNodeID_Inc + iCodeCon
            oUDT.Name = iNodeSplit(1) & iNodeID_Inc + iCodeCon
            oUDT.UserFields.Fields.Item("U_" + "id").Value = iNodeID_Inc
            oUDT.UserFields.Fields.Item("U_" + "NodeId").Value = iNodeSplit(3)
            oUDT.UserFields.Fields.Item("U_" + "parent_ID").Value = iNodeParentID
            oUDT.UserFields.Fields.Item("U_" + "NodeName").Value = iNodeSplit(1)
            oUDT.UserFields.Fields.Item("U_" + "lvl").Value = iNodeSplit(2)
            oUDT.UserFields.Fields.Item("U_" + "DocDate").Value = Now()
            oUDT.UserFields.Fields.Item("U_" + "void").Value = "1"
            retVal = oUDT.Add()

            If retVal <> 0 Then
                oCompany.GetLastError(retVal, retStr)
                MainMenu.g_notif_panel(0, "Error " & retVal & " " & retStr & " " & iNodeID_Inc, 1)
            Else
                MainMenu.g_notif_panel(0, "Record " & iNodeSplit(1) & " Added", 1)
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub dmf_NodeCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' iTreeNodeViewFolder(tvNode)
        iTreeNodeViewFolder_creator(tvNode)
        btn_ok.Tag = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub



    Private Sub txtText_LostFocus(sender As Object, e As EventArgs) Handles txtText.LostFocus
    End Sub

    Private Sub tvNode_Click(sender As Object, e As EventArgs) Handles tvNode.Click
        '   iBtn_Ok("0", "Update", btn_ok)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub tvNode_MouseClick(sender As Object, e As MouseEventArgs) Handles tvNode.MouseClick
        Try

            If e.Button.ToString = "Right" And tvNode.SelectedNode.Nodes.Count = 0 Then
                tsm_main.Show(Me, tvNode.Left, tvNode.Top)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub MS_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MS_1.ItemClicked

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub t_remove_DragDrop(sender As Object, e As DragEventArgs) Handles t_remove.DragDrop

    End Sub

    Private Sub t_remove_Click(sender As Object, e As EventArgs) Handles t_remove.Click
        If tvNode.SelectedNode.Nodes.Count = 0 Then
            tvNode.SelectedNode.Remove()
        End If
    End Sub

    Private Sub tsm_remove_Click(sender As Object, e As EventArgs) Handles tsm_remove.Click
        If tvNode.SelectedNode.Nodes.Count = 0 Then
            tvNode.SelectedNode.Remove()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        updatex()
    End Sub
End Class