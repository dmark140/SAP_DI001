Public Class user_managemnt
    Dim Primary_code As Integer = 0


    Private Sub user_managemnt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tvNode.ImageList = MainMenu.imglist_tv_indicator
        G_iSQL_PARAMETERS.Clear()
        iSQL_selector(108, dgv_Users, True, 3)
        iMain_iTreeNodeViewFolder(tvNode, "")
        getPrimaryCode()

    End Sub






    Private Sub PrintRecursiveForUpdate(ByVal treeNode As TreeNode)

        If treeNode.Checked Then
            Dim iCode() As String
            Dim iFinalCode As String
            iCode = Split(treeNode.Tag, "|")
            iFinalCode = iCode(iCode.Count - 2)

            If IsNumeric(iFinalCode) Then setAdd(iFinalCode)
        End If

        For Each tn As TreeNode In treeNode.Nodes
            PrintRecursiveForUpdate(tn)
        Next
    End Sub

    Private Sub CallRecursivForUpdatee(ByVal treeView As TreeView)
        Dim Nodes = treeView.Nodes
        For Each n As TreeNode In Nodes
            PrintRecursiveForUpdate(n)
        Next
    End Sub





    Private Sub PrintRecursiveForCheck(ByVal treeNode As TreeNode, ByVal iVAl As String)

        If treeNode.Text = iVAl Then
            treeNode.Checked = True
        End If

        For Each tn As TreeNode In treeNode.Nodes
            PrintRecursiveForCheck(tn, iVAl)
        Next
    End Sub

    Private Sub CallRecursivForCheck(ByVal treeView As TreeView, ByRef iVal As String)
        Dim Nodes = treeView.Nodes
        For Each n As TreeNode In Nodes
            PrintRecursiveForCheck(n, iVal)
        Next
    End Sub





    Private Sub PrintRecursiveForUNCheck(ByVal treeNode As TreeNode)


        treeNode.Checked = False


        For Each tn As TreeNode In treeNode.Nodes
            PrintRecursiveForUNCheck(tn)
        Next
    End Sub

    Private Sub CallRecursivForUNCheck(ByVal treeView As TreeView)
        Dim Nodes = treeView.Nodes
        For Each n As TreeNode In Nodes
            PrintRecursiveForUNCheck(n)
        Next
    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_ok.Click, Button1.Click
        Dim UserID As Integer
        setUpdate()
        CallRecursivForUpdatee(tvNode)
    End Sub





    Private Sub dgv_Users_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Users.CellContentDoubleClick

    End Sub

    Private Sub dgv_Users_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Users.CellContentClick
        tvNode.ExpandAll()
        CallRecursivForUNCheck(tvNode)
        getClicked(e)
    End Sub

    Sub getClicked(e)
        uc_Departmnt.iText = dgv_Users.Rows(e.RowIndex).Cells(4).Value
        uc_Name.iText = dgv_Users.Rows(e.RowIndex).Cells(2).Value
        uc_usercode.iText = dgv_Users.Rows(e.RowIndex).Cells(1).Value
        uc_usercode.Tag = dgv_Users.Rows(e.RowIndex).Cells(0).Value 'USER ID
        uc_Type.iText = dgv_Users.Rows(e.RowIndex).Cells(3).Value


        Dim iRs As SAPbobsCOM.Recordset
        iRs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        iRs.DoQuery(" exec spDMF_DI001 109 , '" & uc_usercode.Tag & "'")
        While iRs.EoF = False

            CallRecursivForCheck(tvNode, iRs.Fields.Item("U_moduleText").Value.ToString)

            iRs.MoveNext()
        End While

    End Sub
    Sub setUpdate()
        Try
            Dim iRs As SAPbobsCOM.Recordset
            iRs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            iRs.DoQuery("SELECT  Code FROM [@OUAC] WHERE U_void = '1' and  U_UserID = '" & uc_usercode.Tag & "'")
            While iRs.EoF = False
                Dim oUDT As SAPbobsCOM.UserTable
                oUDT = oCompany.UserTables.Item("OUAC") '' UDT NAME
                oUDT.GetByKey(iRs.Fields.Item(0).Value)
                oUDT.UserFields.Fields.Item("U_void").Value = "0"
                retVal = oUDT.Update()
                iRs.MoveNext()
            End While
            MainMenu.g_notif_panel(1, "Updated", 2)
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub

    Sub setAdd(ByRef ModuleID As String)
        Try
            Primary_code = Primary_code + 1
            Dim oUDT As SAPbobsCOM.UserTable
            oUDT = oCompany.UserTables.Item("OUAC") '' UDT NAME
            oUDT.Code = Primary_code
            oUDT.Name = Primary_code & "_" & uc_usercode.iText
            oUDT.UserFields.Fields.Item("U_UserID").Value = uc_usercode.Tag
            oUDT.UserFields.Fields.Item("U_ModuleID").Value = ModuleID
            oUDT.UserFields.Fields.Item("U_PostedBy").Value = g_txtUserID
            oUDT.UserFields.Fields.Item("U_CreatedDate").Value = Now()
            oUDT.UserFields.Fields.Item("U_void").Value = "1"

            retVal = oUDT.Add()
            MainMenu.g_notif_panel(1, "Added", 2)

        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub


    Sub getPrimaryCode()
        Dim iRs As SAPbobsCOM.Recordset
        iRs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        iRs.DoQuery("exec spDMF_DI001 111")

        While iRs.EoF = False
            Primary_code = iRs.Fields.Item(0).Value
            iRs.MoveNext()
        End While
    End Sub
End Class