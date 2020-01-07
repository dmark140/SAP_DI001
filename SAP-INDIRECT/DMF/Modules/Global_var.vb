Module Global_var
    Public g_txtServerIP As String
    Public g_txtDatabase As String
    Public g_txtDbUserName As String
    Public g_txtDbPassword As String
    Public g_txtCompanyDB As String

    Public g_txtUserID As String
    Public g_txtPassword As String

    Public g_MainPanel As Panel
    Public g_splitPanel As SplitContainer
    Public g_tv As TreeView
    Public g_form As Form


    Public G_Finder_text As TextBox
    Public G_Finder_dscr As Label





    Public Sub ADD_Column(ByVal ColName As String, ByVal ColTypeID As Integer, ByVal PositionIndex As Integer,
                           ByVal HeadrTxt As String, ByVal iName As String, ByVal widthx As Integer, ByVal dgb As DataGridView)

        Dim AddColumn
        If ColTypeID = 1 Then
            AddColumn = New DataGridViewTextBoxColumn
        ElseIf ColTypeID = 2 Then
            AddColumn = New DataGridViewButtonColumn
        ElseIf ColTypeID = 3 Then
            AddColumn = New DataGridViewCheckBoxColumn
        End If


        With AddColumn
            .HeaderText = HeadrTxt
            .Name = iName
            .Width = widthx
            '    .Index = PositionIndex

        End With
        dgb.Columns.Insert(PositionIndex, AddColumn)
    End Sub


    Public Sub Fit_Column_Wtih(ByRef dgb As DataGridView)

        '  For i As Integer = 0 To dgb.Columns

        ' Next

    End Sub



    Public Sub iBtn_Ok(ByVal iTag As String, ByVal iText As String, ByVal btn_ok As Button)
        btn_ok.Tag = iTag
        btn_ok.Text = iText
    End Sub



    Public Sub iTreeNodeViewFolder(ByRef iTree As TreeView)
        Dim iCount = 0
        Dim irecSetx As SAPbobsCOM.Recordset
        irecSetx = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        irecSetx.DoQuery(" SELECT   * FROM vwDMF_DI001  A WHERE  iType = 0  Order By A.U_parent_ID , A.U_NodeId   ")
        Do While irecSetx.EoF = False
            Dim iTreeNode As New TreeNode
            Dim nodeKey As String = irecSetx.Fields(3).Value.ToString
            Dim nodeParent As String = irecSetx.Fields(4).Value.ToString
            Dim nodeValue As String = irecSetx.Fields(5).Value.ToString
            Dim nodeLevel As String = irecSetx.Fields(6).Value.ToString
            Dim nodeType As String = irecSetx.Fields(8).Value.ToString
            If nodeParent <> 0 Then
                Dim iChild = iTree.Nodes.Find(nodeParent, True).FirstOrDefault()
                iTreeNode = iChild.Nodes.Add(nodeKey, nodeValue)
                '   iChild.Nodes(nodeParent).Nodes.Add(nodeKey, nodeValue). 
            Else
                iTreeNode = iTree.Nodes.Add(nodeKey, nodeValue)

                'txtName.Text & "|" & txtText.Text & "|" & txtAccLevel.Text
            End If
            '  iTreeNode.Tag = nodeKey & "|" & nodeValue & "|" & nodeLevel
            iTreeNode.Tag = nodeKey

            iCount = iCount + 1
            irecSetx.MoveNext()
        Loop
    End Sub




    Public Sub iTreeNodeViewFolder_creator(ByRef iTree As TreeView)
        Dim iCount = 0
        Dim irecSetx As SAPbobsCOM.Recordset
        irecSetx = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        irecSetx.DoQuery(" SELECT   * FROM [@DFM_TEST2]  A     WHERE U_void = 1    Order By A.U_parent_ID , A.U_NodeId")
        Do While irecSetx.EoF = False
            Dim iTreeNode As New TreeNode
            Dim nodeKey As String = irecSetx.Fields(3).Value.ToString
            Dim nodeParent As String = irecSetx.Fields(4).Value.ToString
            Dim nodeValue As String = irecSetx.Fields(5).Value.ToString
            Dim nodeLevel As String = irecSetx.Fields(6).Value.ToString
            If nodeParent <> 0 Then
                Dim iChild = iTree.Nodes.Find(nodeParent, True).FirstOrDefault()
                iTreeNode = iChild.Nodes.Add(nodeKey, nodeValue)
                '   iChild.Nodes(nodeParent).Nodes.Add(nodeKey, nodeValue). 
            Else
                iTreeNode = iTree.Nodes.Add(nodeKey, nodeValue)

                'txtName.Text & "|" & txtText.Text & "|" & txtAccLevel.Text
            End If
            iTreeNode.Tag = nodeKey & "|" & nodeValue & "|" & nodeLevel
            ' iTreeNode.Tag = nodeKey
            iCount = iCount + 1
            irecSetx.MoveNext()
        Loop
    End Sub


    Public Sub iMain_iTreeNodeViewFolder(ByRef iTree As TreeView)
        Try

            iTree.Nodes.Clear()
            Dim iCount = 0
            Dim irecSetx As SAPbobsCOM.Recordset
            irecSetx = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            irecSetx.DoQuery(" SELECT   * FROM vwDMF_DI001  A Order By A.U_parent_ID , A.U_NodeId ")
            Do While irecSetx.EoF = False
                Dim iTreeNode As New TreeNode
                Dim nodeKey As String = irecSetx.Fields(3).Value.ToString
                Dim nodeParent As String = irecSetx.Fields(4).Value.ToString
                Dim nodeValue As String = irecSetx.Fields(5).Value.ToString
                Dim nodeLevel As String = irecSetx.Fields(6).Value.ToString
                Dim nodeStyle As String = irecSetx.Fields(8).Value.ToString
                If nodeParent <> 0 Then
                    Dim iChild = iTree.Nodes.Find(nodeParent, True).FirstOrDefault()
                    iTreeNode = iChild.Nodes.Add(nodeKey, nodeValue)
                    '   iChild.Nodes(nodeParent).Nodes.Add(nodeKey, nodeValue).

                Else
                    iTreeNode = iTree.Nodes.Add(nodeKey, nodeValue)

                    'txtName.Text & "|" & txtText.Text & "|" & txtAccLevel.Text
                End If
                If nodeStyle = "1" Then
                    iTreeNode.Tag = nodeKey & "|" & nodeValue & "|" & nodeLevel
                    iTreeNode.ImageIndex = 1
                    iTreeNode.SelectedImageIndex = 1
                Else
                    iTreeNode.ImageIndex = 0
                    iTreeNode.SelectedImageIndex = 0
                End If

                iCount = iCount + 1
                irecSetx.MoveNext()
            Loop
        Catch
        End Try
    End Sub

    Public Sub g_iLogInSet()
        g_MainPanel.Visible = False
        g_splitPanel.Enabled = True

        iMain_iTreeNodeViewFolder(g_tv)

        g_form.Dispose()
        g_form = Nothing
    End Sub



    Public Sub g_Notif(ByVal iType As Integer, ByVal iMsg As String)

    End Sub



    Public Sub iFinder(ByVal selectionID As Integer, ByVal iFormTitle As String, ByRef returni As TextBox, ByRef returnDsc As Label, ByRef iForm As Form, ByRef iArrwBtn As UserControl)
        SelectionModule.TopLevel = False
        iForm.Controls.Add(SelectionModule)

        SelectionModule.Left = iArrwBtn.Left + iArrwBtn.Width + 1
        SelectionModule.Top = iArrwBtn.Top + g_MainPanel.Top

        SelectionModule.Show()
        SelectionModule.Enabled = False
        iForm.Controls.SetChildIndex(SelectionModule, 999)
        SelectionModule.BringToFront()
        G_Finder_text = returni
        SelectionModule.iFinderx(selectionID, returni.Text, iFormTitle)
    End Sub


End Module
