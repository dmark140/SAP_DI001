Imports System.Data.SqlClient

Public Class EDS_Ticketing_Sender
    Dim iFileName As String
    Dim iFilePath As String
    Dim iFilePathSplit() As String
    Dim iIsReplyx As Integer = 0
    Dim isADdx As Integer = 0


    Public Property iIsReply() As Integer
        Get
            Return iIsReplyx
        End Get
        Set(value As Integer)
            iIsReplyx = value
        End Set
    End Property


    Public Property isAdd() As Integer
        Get
            Return isADdx
        End Get
        Set(value As Integer)
            isADdx = value
        End Set
    End Property


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim iOpenExplorer As New OpenFileDialog
            iOpenExplorer.Title = "Upload a File"
            iOpenExplorer.Filter = "Image, Docs |*.jpg;*.png;*.xls;*.xlsx;*.doc;*.docx;"
            iOpenExplorer.Multiselect = False

            If iOpenExplorer.ShowDialog = DialogResult.OK Then
                If System.IO.File.Exists(iOpenExplorer.FileName) = True Then
                    iFilePath = iOpenExplorer.FileName
                    iFilePathSplit = Split(iFilePath, "\")
                    iFileName = iFilePathSplit(iFilePathSplit.Length - 1)
                    If ExtnDocs.Contains(iFileName) Then
                        pic_attched.Image = My.Resources.ms_word
                    Else
                        pic_attched.Image = My.Resources.ms_jpg
                    End If
                    lbl_attachedFile.Text = iFileName
                    conatiner_attach.Visible = True
                End If
            End If
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub

    Sub iCopyTo(FilePath As String, DistinationPath As String)
        Try
            If System.IO.File.Exists(FilePath) = True Then
                System.IO.File.Copy(FilePath, DistinationPath)
                MainMenu.g_notif_panel(2, "1001 - File Copyed!", 2)
            End If
        Catch ex As Exception
            MainMenu.g_notif_panel(2, "1001 - File Copyed Error: " & ex.Message, 2)

        End Try
    End Sub

    Private Sub btn_zoom_Click(sender As Object, e As EventArgs) Handles btn_zoom.Click
        ''>>>> OTCK

        Dim appointedTo As String = "O"



        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "14")
        EDS_SQL_PARAM_ADD("@val1", EDS_USERID) 'requestedBy ID 
        EDS_SQL_PARAM_ADD("@val2", uc_subject.iText) 'SUBJECT ID 

        ''>>>>TCK1 
        EDS_SQL_PARAM_ADD("@val3", EDS_USERID) 'createdBy ID 
        EDS_SQL_PARAM_ADD("@val4", msg.Text) 'msg
        EDS_SQL_PARAM_ADD("@val5", iFileName) 'iFile
        EDS_SQL_PARAM_ADD("@val6", G_IMAGEPATH) 'iFileLocation
        EDS_SQL_PARAM_ADD("@val7", iIsReplyx) 'iFileLocation
        EDS_SQL_PARAM_ADD("@val8", uc_stations.iText) 'station
        EDS_SQL_PARAM_ADD("@val9", uc_warehouse.iText) 'warehouse
        EDS_SQL_PARAM_ADD("@val10", uc_machine.iText) 'machine
        EDS_SQL_PARAM_ADD("@val11", uc_status.iText) 'status
        EDS_SQL_PARAM_ADD("@val12", CInt(uc_appointedTo.iText)) 'status
        Dim iDt As DataSet = EDS_G_iSQL()
        If iDt.Tables(0).Rows.Count > 0 Then
            If iDt.Tables(0).Rows(0)("ERRORCODE") = 1 Then

                If ExtnDocs.Contains(iFileName) Then
                    iCopyTo(iFilePath, G_IMAGEPATH + iFileName)
                Else
                    iCopyTo(iFilePath, G_IMAGEPATH + iFileName)
                End If
                Me.Close()

            Else
                MainMenu.g_notif_panel(0, iDt.Tables(0).Rows(0)("ERRORCODE") & " - " & iDt.Tables(0).Rows(0)("MSG"), 0)
            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If iIsReplyx <> 0 Then
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)
        End If
        If isAdd = 1 Then
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)
        End If
        Me.Close()
    End Sub

    Private Sub EDS_Ticketing_Sender_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If iIsReplyx = 0 Then
            uc_req_by.iText = EDS_USERID
            uc_req_by_lbl.iText = EDS_USER_FULLNAME
        End If
    End Sub

    Private Sub Uc_inputbox1_Load(sender As Object, e As EventArgs) Handles uc_appointedTo.Load

    End Sub
End Class