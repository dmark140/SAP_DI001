﻿Imports System.Data.SqlClient

Module EDS_G_FUNC
    Public EDS_USERID As Integer
    Public EDS_USER_FULLNAME As String




    Dim EDS_sqlAddress As String = "Data Source = IT2\SQLEXPRESS;Initial Catalog = EDS;Persist Security Info = True;User ID=sa;Password=@Lion34907;"
    Dim EDS_sqlConn = New SqlConnection(EDS_sqlAddress)
    Dim EDS_sqlDA As New SqlDataAdapter
    Dim EDS_SQL_PARAM_LIST As List(Of String)


    Dim EDS_G_SP_Name As String




    Public EDS_SQL_PARAM As New List(Of EDS_SQL_PARAM_CONTAINER)
    Public Class EDS_SQL_PARAM_CONTAINER
        Public iPARAMETER As String
        Public iSQLTYPE As SqlDbType
        Public iVALUE
    End Class


    Public Sub EDS_SQL_PARAM_ADD(iPARAMETERx As String, iVALUEx As String)
        Dim iSqlDiv As New EDS_SQL_PARAM_CONTAINER
        iSqlDiv.iPARAMETER = iPARAMETERx
        iSqlDiv.iSQLTYPE = SqlDbType.VarChar
        iSqlDiv.iVALUE = iVALUEx
        EDS_SQL_PARAM.Add(iSqlDiv)
    End Sub





    Public Function EDS_LOGIN(Username As String, Password As String) As Boolean
        Try

            Dim EDS_sqlConn = New SqlConnection(EDS_sqlAddress)
            Dim EDS_sqlDA As New SqlDataAdapter
            Dim EDS_DS As New DataSet
            Dim EDS_DT As New DataTable

            EDS_sqlConn.Close()
            Dim EDS_sqlComm = New SqlCommand("DMF_EDS", EDS_sqlConn)
            EDS_sqlComm.Parameters.Add("@SQLID", SqlDbType.VarChar).Value = 2
            EDS_sqlComm.Parameters.Add("@val1", SqlDbType.VarChar).Value = Username
            EDS_sqlComm.Parameters.Add("@val2", SqlDbType.VarChar).Value = Password
            EDS_sqlConn.Open()
            EDS_sqlComm.CommandType = CommandType.StoredProcedure
            EDS_sqlComm.Connection = EDS_sqlConn
            EDS_sqlDA.SelectCommand = EDS_sqlComm
            EDS_sqlDA.Fill(EDS_DT)
            EDS_sqlDA.Fill(EDS_DS)
            If EDS_DS.Tables.Count > 0 Then
                If EDS_DS.Tables(0).Rows(0)("ERRORCODE") = 1 Then
                    g_EDS_iLogInSet()
                    EDS_USERID = EDS_DS.Tables(0).Rows(0)("ID")
                    EDS_USER_FULLNAME = EDS_DS.Tables(0).Rows(0)("Fullname")
                    MainMenu.g_notif_panel(1, "2 - " & EDS_DS.Tables(0).Rows(0)("MSG"), 2)
                    Return True
                Else
                    MainMenu.g_notif_panel(1, "2 - " & EDS_DS.Tables(0).Rows(0)("MSG"), 2)
                    Return False
                End If
            Else
                MainMenu.g_notif_panel(1, "2 - INCORRECT LOGIN DETAILS", 2)
                Return False
            End If
        Catch ex As Exception
            MainMenu.g_notif_panel(1, "2 - " & ex.Message, 2)
        End Try
#Disable Warning BC42353
    End Function
#Enable Warning BC42353

    Public Function EDS_G_iSQL() As DataSet
        Dim SP_name As String = "DMF_EDS"
        Dim EDS_sqlConn = New SqlConnection(EDS_sqlAddress)
        Dim EDS_sqlDA As New SqlDataAdapter
        Dim EDS_DS As New DataSet
        Dim EDS_DT As New DataTable
        Dim EDS_sqlComm = New SqlCommand(SP_name, EDS_sqlConn)
        For i = 0 To EDS_SQL_PARAM.Count - 1
            EDS_sqlComm.Parameters.Add(EDS_SQL_PARAM(i).iPARAMETER, EDS_SQL_PARAM(i).iSQLTYPE).Value = EDS_SQL_PARAM(i).iVALUE
        Next
        EDS_sqlConn.Open()
        EDS_sqlComm.CommandType = CommandType.StoredProcedure
        EDS_sqlComm.Connection = EDS_sqlConn
        EDS_sqlDA.SelectCommand = EDS_sqlComm
        'EDS_sqlDA.Fill(EDS_DT)
        EDS_sqlDA.Fill(EDS_DS)
        EDS_sqlConn.Close()
        Return EDS_DS
    End Function

    Public Function EDS_G_iSQL_TABLE() As DataTable
        Try
            Dim SP_name As String = "DMF_EDS"
            Dim EDS_sqlConn = New SqlConnection(EDS_sqlAddress)
            Dim EDS_sqlDA As New SqlDataAdapter
            Dim EDS_DS As New DataSet
            Dim EDS_DT As New DataTable
            Dim EDS_sqlComm = New SqlCommand(SP_name, EDS_sqlConn)
            For i = 0 To EDS_SQL_PARAM.Count - 1
                EDS_sqlComm.Parameters.Add(EDS_SQL_PARAM(i).iPARAMETER, EDS_SQL_PARAM(i).iSQLTYPE).Value = EDS_SQL_PARAM(i).iVALUE
            Next
            EDS_sqlConn.Open()
            EDS_sqlComm.CommandType = CommandType.StoredProcedure
            EDS_sqlComm.Connection = EDS_sqlConn
            EDS_sqlDA.SelectCommand = EDS_sqlComm
            EDS_sqlDA.Fill(EDS_DT)
            '   EDS_sqlDA.Fill(EDS_DS)
            EDS_sqlConn.Close()
            Return EDS_DT
        Catch ex As Exception
            MainMenu.g_notif_panel(1, ex.Message, 2)

        End Try
    End Function


    Public Sub EDS_PARAM_VALIDATION(iDATASET As DataSet)
        Try
            If iDATASET.Tables.Count > 0 Then
                MainMenu.g_notif_panel(CInt(iDATASET.Tables(0).Rows(0)("ERRORCODE")), iDATASET.Tables(0).Rows(0)("MSG"), 2)
            End If
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub



    Function EDS_FOLDER_TREEVIEW(tvNode As TreeView) As Integer

        Try
            Dim ikEy As Integer = 1
            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "4")
            Dim iDt As DataSet = EDS_G_iSQL()

            For i = 0 To iDt.Tables(0).Rows.Count - 1
                Dim iNode As New TreeNode
                Dim nodeParent As Integer = CInt(iDt.Tables(0).Rows(i)("folderFatherKey"))
                Dim nodeKey As String = iDt.Tables(0).Rows(i)("folderKey")
                Dim nodeValue As String = iDt.Tables(0).Rows(i)("folderName")
                Dim iTreeNode As New TreeNode
                If nodeParent <> 0 Then
                    Dim iChild = tvNode.Nodes.Find(nodeParent, True).FirstOrDefault()
                    iTreeNode = iChild.Nodes.Add(nodeKey, nodeValue)
                Else
                    iTreeNode = tvNode.Nodes.Add(nodeKey, nodeValue)
                End If
                iTreeNode.Tag = nodeKey
                ikEy = i
            Next

            Return ikEy
        Catch ex As Exception

        End Try
    End Function


    Public Sub EDS_G_SET_TV(iTree As TreeView)
        ' Try
        ' g_MainPanel.Visible = False
        '   g_splitPanel.Enabled = True

        '  g_form.Close()
        EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "8")
            EDS_SQL_PARAM_ADD("@val1", EDS_USERID)
            Dim iDt As DataSet = EDS_G_iSQL()
            For i = 0 To iDt.Tables(0).Rows.Count - 1
                Dim iTreeNode As New TreeNode
                Dim nodeKey As String = iDt.Tables(0).Rows(i)("folderKey")
                Dim nodeParent As String = iDt.Tables(0).Rows(i)("folderFatherKey")
                Dim nodeValue As String = iDt.Tables(0).Rows(i)("folderName")
                Dim nodeType As String = iDt.Tables(0).Rows(i)("iType")
                Dim NodeID As String = iDt.Tables(0).Rows(i)("id")
                Dim NodeAuthorize As String = iDt.Tables(0).Rows(i)("grant")
                If nodeParent <> 0 Then
                    Dim iChild = iTree.Nodes.Find(nodeParent, True).FirstOrDefault()
                    iTreeNode = iChild.Nodes.Add(nodeKey, nodeValue)

                Else
                    iTreeNode = iTree.Nodes.Add(nodeKey, nodeValue)
                End If
                If nodeType = "F" Then
                    iTreeNode.ImageIndex = 0
                    iTreeNode.SelectedImageIndex = 0
                    iTreeNode.NodeFont = New Font(MainMenu.Font, FontStyle.Bold)
                    iTreeNode.Text = iTreeNode.Text
                Else
                    iTreeNode.ImageIndex = 1
                    iTreeNode.SelectedImageIndex = 1
                End If



                iTreeNode.Tag = nodeKey & "|" & nodeType & "|" & NodeID & "|" & NodeAuthorize
            Next

        ' Catch ex As Exception

        '  End Try
    End Sub



End Module
