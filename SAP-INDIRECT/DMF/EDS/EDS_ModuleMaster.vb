Public Class EDS_ModuleMaster

    Dim xx As String
    Dim selectedParentKey As String


    Private Sub EDS_ModuleMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetAllForms()
        Call EDS_FOLDER_TREEVIEW(tvNode)
    End Sub
    Sub GetAllForms()
        Try
            cb_ModuleNames.Items.Clear()
            Dim myAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Dim types As Type() = myAssembly.GetTypes()
            For Each F As Type In types
                If UCase(F.BaseType.ToString) = "SYSTEM.WINDOWS.FORMS.FORM" Then
                    Dim iForm As Form = Nothing
                    Dim frmNewForm_Type As Type = Type.GetType(Me.GetType().Namespace.ToString & "." & F.Name)
                    iForm = CType(Activator.CreateInstance(frmNewForm_Type), Form)
                    Dim iTagSplit() As String = Split(F.Name, "_")
                    If iTagSplit(0) = "EDS" Then If iForm.Tag Is Nothing Then cb_ModuleNames.Items.Add(F.Name)
                End If
            Next
        Catch ex As Exception
            '  MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub



    Private Sub tvNode_MouseClick(sender As Object, e As MouseEventArgs) Handles tvNode.MouseClick

    End Sub


    Sub childCHeck(ByVal cNode As TreeNode)
        If cNode.Parent IsNot Nothing Then
            xx = cNode.Parent.Text & " > " & xx
            cNode = cNode.Parent
            childCHeck(cNode)
        End If
    End Sub

    Private Sub cb_ModuleNames_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cb_ModuleNames.SelectedIndexChanged
        Try
            Dim iForm As Form = Nothing
            Dim frmNewForm_Type As Type
            frmNewForm_Type = Type.GetType(Me.GetType().Namespace.ToString & "." & cb_ModuleNames.Text.ToString)
            iForm = CType(Activator.CreateInstance(frmNewForm_Type), Form)
            txt_Code.Text = Me.GetType().Namespace.ToString & "." & iForm.Name.ToString
            cb_stats.Text = "Active"
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.ToString, 1)
        End Try
    End Sub

    Private Sub tvNode_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvNode.AfterSelect

    End Sub

    Private Sub tvNode_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tvNode.MouseDoubleClick
        Dim iLocation As String
        Dim iCorNode As TreeNode
        iCorNode = tvNode.SelectedNode
        '    Dim bol As Boolean = iCorNode.Parent.Checked

        xx = iCorNode.Text & ">"
        childCHeck(iCorNode)
        TextBox4.Text = xx
        selectedParentKey = iCorNode.Tag
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Dim ikEy As Integer = 1
        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "6")
        EDS_SQL_PARAM_ADD("@val1", txt_Code.Text) ' moduleKey
        EDS_SQL_PARAM_ADD("@val2", selectedParentKey) ' moduleFolderKey
        EDS_SQL_PARAM_ADD("@val3", txt_text.Text) ' moduleName
        EDS_SQL_PARAM_ADD("@val4", "0") ' craetedBy ID
        Dim iDt As DataSet = EDS_G_iSQL()
        EDS_PARAM_VALIDATION(iDt)



    End Sub
End Class