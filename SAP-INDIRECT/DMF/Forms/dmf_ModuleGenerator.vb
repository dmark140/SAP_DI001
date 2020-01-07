Public Class dmf_ModuleGenerator

    Dim xx As String
    Dim selectedParentKey As String


    Private Sub dmf_ModuleGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Global_var.iTreeNodeViewFolder(tvNode)
        GetAllForms()
    End Sub

    Sub GetAllForms()

        '<<<<< get all form By Name(ID) if tag is not 0 inactive 
        Try
            cb_ModuleNames.Items.Clear()
            Dim myAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()

            Dim types As Type() = myAssembly.GetTypes()

            For Each F As Type In types
                If UCase(F.BaseType.ToString) = "SYSTEM.WINDOWS.FORMS.FORM" Then
                    Dim iForm As Form = Nothing
                    Dim frmNewForm_Type As Type = Type.GetType(Me.GetType().Namespace.ToString & "." & F.Name)
                    iForm = CType(Activator.CreateInstance(frmNewForm_Type), Form)
                    If iForm.Tag Is Nothing Then cb_ModuleNames.Items.Add(F.Name)
                End If

            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cb_ModuleNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_ModuleNames.SelectedIndexChanged
        Try
            Dim iForm As Form = Nothing
            Dim frmNewForm_Type As Type = Type.GetType(Me.GetType().Namespace.ToString & "." & cb_ModuleNames.Name.ToString)
            iForm = CType(Activator.CreateInstance(frmNewForm_Type), Form)
            txt_author.Text = g_txtUserID
            txt_Code.Text = Me.GetType().Namespace.ToString & "." & iForm.Text.ToString
            cb_stats.Text = "Active"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Sub childCHeck(ByVal cNode As TreeNode)
        If cNode.Parent IsNot Nothing Then
            xx = cNode.Parent.Text & " > " & xx
            cNode = cNode.Parent
            childCHeck(cNode)
        End If
    End Sub

    Private Sub tvNode_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvNode.NodeMouseClick

    End Sub

    Private Sub tvNode_MouseClick(sender As Object, e As MouseEventArgs) Handles tvNode.MouseClick

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


    Private Sub iCreate()

        Try
            Call oConnect()

            Dim iCode As Integer
            Dim iRecSet As SAPbobsCOM.Recordset
            iRecSet = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            iRecSet.DoQuery("select top 1 Code FROM [@DI_MODULEMASTER] order by Code desc")
            If iRecSet.EoF = False Then
                iCode = iRecSet.Fields.Item("Code").Value
            End If


            Dim iUDF As SAPbobsCOM.UserTable
            iUDF = oCompany.UserTables.Item("DI_MODULEMASTER")
            iUDF.Code = iCode + 1
            iUDF.Name = (iCode + 1) & "_" & txt_Code.Text
            iUDF.UserFields.Fields.Item("U_" + "Key").Value = txt_Code.Text.ToString

            iUDF.UserFields.Fields.Item("U_Name").Value = cb_ModuleNames.Text
            iUDF.UserFields.Fields.Item("U_parentKey").Value = selectedParentKey
            iUDF.UserFields.Fields.Item("U_moduleText").Value = txt_text.Text
            iUDF.UserFields.Fields.Item("U_user").Value = g_txtUserID
            iUDF.UserFields.Fields.Item("U_remarks").Value = TextBox3.Text
            iUDF.UserFields.Fields.Item("U_node_path").Value = xx '' location
            iUDF.UserFields.Fields.Item("U_DocDate").Value = Now()
            iUDF.UserFields.Fields.Item("U_void").Value = "1" '' active

            iUDF.Add()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub tvNode_AfterSelect(sender As Object, e As TreeViewEventArgs)

    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        iCreate()
    End Sub
End Class