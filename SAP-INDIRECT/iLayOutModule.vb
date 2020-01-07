Public Class iLayOutModule


    Dim xx As String
    Dim selectedParentKey As String
    Dim iFormContainer As List(Of String)
    Dim frmNewForm_Type As String
    Sub GetAllForms()
        Try
            iFormContainer.Clear()
            Dim myAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Dim types As Type() = myAssembly.GetTypes()
            For Each F As Type In types
                If UCase(F.BaseType.ToString) = "SYSTEM.WINDOWS.FORMS.FORM" Then
                    Dim iForm As Form = Nothing
                    Dim frmNewForm_Type As Type = Type.GetType(Me.GetType().Namespace.ToString & "." & F.Name)
                    iForm = CType(Activator.CreateInstance(frmNewForm_Type), Form)
                    If iForm.Tag Is Nothing Then iFormContainer.Add(F.Name)
                End If
            Next


            For i = 0 To iFormContainer.Count - 1
                MainMenu.g_notif_panel(0, iFormContainer(i), 2)
            Next
        Catch ex As Exception
            '        MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub


    Private Sub iLayOutModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmNewForm_Type = Me.GetType().Namespace.ToString & "." & Me.Name.ToString
        GetAllForms()
        If SYSTEM_MODE = "EDS" Then Call EDS_G_SET_TV(tvNode)
        If SYSTEM_MODE = "SAP" Then Call iMain_iTreeNodeViewFolder(tvNode, G_USERID)
        uc_status.isAllowEmptyx = True
    End Sub

    Private Sub iLayOutModule_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        SplitContainer1.SplitterDistance = Math.Abs(SplitContainer1.Height / 2)
    End Sub

    Private Sub tvNode_DoubleClick(sender As Object, e As EventArgs) Handles tvNode.DoubleClick
        Try
            iMarikit() ''Clear
            Dim iLocation As String
            Dim iCorNode As TreeNode
            iCorNode = tvNode.SelectedNode
            '  Dim bol As Boolean = iCorNode.Parent.Checked

            xx = iCorNode.Text & ">"
            childCHeck(iCorNode)
            uc_location.iText = xx
            selectedParentKey = iCorNode.Tag


            If SYSTEM_MODE = "EDS" Then
                Dim iSplit() As String = Split(selectedParentKey, "|")
                If IsNumeric(iSplit(0)) Then
                    uc_moduleKey.iText = iSplit(0)
                    uc_type.iText = "3"
                    uc_type_lbl.iText = "Report"
                Else

                    uc_moduleKey.iText = iSplit(2)
                    uc_type.iText = "4"
                    uc_type_lbl.iText = "Layout"
                End If
                EDS_SQL_PARAM.Clear()
                EDS_SQL_PARAM_ADD("@SQLID", "88")
                Dim iDt2x As DataSet = EDS_G_iSQL()
                uc_id.iText = iDt2x.Tables(0).Rows(0)("id")


            End If


            If SYSTEM_MODE = "SAP" Then
                Dim iID As Integer = 1
                SAP_SQL_PARAM.Clear()
                SAP_SQL_PARAM.Add(152)
                Dim iBt1 As DataTable = iSQL_DATATABLE()
                If iBt1.Rows.Count > 0 Then
                    iID = CInt(iBt1.Rows(0)("ID"))
                    iID = iID + 1
                End If
                uc_id.iText = iID

                If IsNumeric(iCorNode.Tag) = False And iCorNode.Tag <> "" Then
                    uc_type.iText = "4"
                    uc_type_lbl.iText = "Layout"
                Else
                    uc_type.iText = "3"
                    uc_type_lbl.iText = "Report"
                End If
                Dim iModkeySplt = Split(iCorNode.Tag, "|")
                uc_moduleKey.iText = iModkeySplt(0)
                uc_createdBy.iText = G_USERID
                uc_createdBy.Tag = G_USERID

                uc_status.iText = "1"
                uc_status_lbl.iText = "Open"

            End If
            uc_createdDate.iText = Now.ToString
            MainMenu.g_notif_panel(2, iCorNode.Tag, 2)
        Catch ex As Exception

        End Try

    End Sub

    Sub childCHeck(ByVal cNode As TreeNode)
        If cNode.Parent IsNot Nothing Then
            xx = cNode.Parent.Text & " > " & xx
            cNode = cNode.Parent
            childCHeck(cNode)
        End If
    End Sub

    Sub iDiInput(report_name As String)

        Call oConnect()
        Dim iReportNameCode As String
        Dim iType As String
        If uc_type.iText = 3 Then
            iType = "R"

        ElseIf uc_type.iText = 4 Then
            iType = "L"

        End If
        If uc_type.iText = 3 Then
            iReportNameCode = "W" & Format(uc_id.iText, "0000")
        End If

        Dim oUserTable As SAPbobsCOM.UserTable
        oUserTable = oCompany.UserTables.Item("OCRP")
        oUserTable.Code = uc_id.iText
        oUserTable.Name = report_name
        oUserTable.UserFields.Fields.Item("U_DocDate").Value = Now
        oUserTable.UserFields.Fields.Item("U_Reportname").Value = uc_name.iText
        oUserTable.UserFields.Fields.Item("U_Void").Value = "Y"
        oUserTable.UserFields.Fields.Item("U_CreatedBy").Value = G_USERID
        oUserTable.UserFields.Fields.Item("U_Type").Value = iType
        oUserTable.UserFields.Fields.Item("U_LinkedTo").Value = uc_moduleKey.iText
        retVal = oUserTable.Add
        If retVal <> 0 Then
            oCompany.GetLastError(retVal, retStr)
            MsgBox("Error " & retVal & " " & retStr)
            MainMenu.g_notif_panel(0, "Error " & retVal & " " & retStr, 2)
        Else
            MainMenu.g_notif_panel(1, " Transaction Success", 2)
        End If
        System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserTable)
        GC.Collect()
    End Sub
    Sub iEDS_input(report_name As String)
        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "54")
        EDS_SQL_PARAM_ADD("@val1", report_name)
        EDS_SQL_PARAM_ADD("@val2", uc_name.iText)
        EDS_SQL_PARAM_ADD("@val3", "\\10.10.0.10\eds\REPORTS\" & SYSTEM_MODE & "\" & uc_type_lbl.iText & "\")
        EDS_SQL_PARAM_ADD("@val4", uc_moduleKey.iText)

        EDS_SQL_PARAM_ADD("@val5", uc_name.iText)
        EDS_SQL_PARAM_ADD("@val6", uc_cr.iText)
        EDS_SQL_PARAM_ADD("@val7", uc_location.iText)


        EDS_SQL_PARAM_ADD("@IDENTITY", EDS_USERID)
        Dim iDt2x As DataSet = EDS_G_iSQL()
    End Sub


    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim iReportNameCode As String
        If uc_type.iText = 3 Then
            iReportNameCode = "R" & CInt(uc_id.iText).ToString("0000")
        Else
            iReportNameCode = "L" & CInt(uc_id.iText).ToString("0000")
        End If


        If isAllowEmpty(Panel1) = False Then
            If iFIleCopy(uc_cr.iText, "\\10.10.0.10\eds\REPORTS\" & SYSTEM_MODE & "\" & uc_type_lbl.iText & "\" & iReportNameCode & ".rpt") Then
                If SYSTEM_MODE = "SAP" Then iDiInput(iReportNameCode)
                If SYSTEM_MODE = "EDS" Then iEDS_input(iReportNameCode)
            End If
        End If
    End Sub


    Sub iMarikit()
        uc_id.iText = ""
        uc_name.iText = ""
        uc_name.iText = ""
        uc_type_lbl.iText = ""
        uc_status.iText = ""
        uc_status_lbl.iText = ""
        uc_location.iText = ""
        uc_moduleKey.iText = ""
        uc_createdBy.iText = ""
        uc_createdDate.iText = ""
        uc_remarks.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles w.Click
        Try
            Dim iOpenExplorer As New OpenFileDialog
            iOpenExplorer.Title = "Upload a Crystal Report"
            iOpenExplorer.Filter = "Crystal Report|*.rpt;"
            iOpenExplorer.Multiselect = False
            Dim iFilePath, iFilePathSplit, iFileName

            If iOpenExplorer.ShowDialog = DialogResult.OK Then
                If System.IO.File.Exists(iOpenExplorer.FileName) = True Then
                    iFilePath = iOpenExplorer.FileName
                    iFilePathSplit = Split(iFilePath, "\")
                    iFileName = iFilePathSplit(iFilePathSplit.Length - 1)
                    uc_cr.iText = iFilePath
                End If
            End If
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub

    Private Sub tvNode_Click(sender As Object, e As EventArgs) Handles tvNode.Click

    End Sub
End Class