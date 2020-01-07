Public Class iReportSettings
    Dim iNewLocation As String
    Private Sub iReportSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
        '    uc_path.Textbox.Text = FolderBrowserDialog1.SelectedPath
        '    iNewLocation = uc_path.Textbox.Text
        'End If

        Dim iOpenExplorer As New OpenFileDialog

        If iOpenExplorer.ShowDialog = DialogResult.OK Then
            If System.IO.File.Exists(iOpenExplorer.FileName) = True Then

            End If
        End If

    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try
            EDS_SQL_PARAM.Clear() ''insert
            EDS_SQL_PARAM_ADD("@SQLID", "54")
            EDS_SQL_PARAM_ADD("@val1", uc_path.iText)
            EDS_SQL_PARAM_ADD("@val2", uc_servr.iText) 'iFileLocation
            EDS_SQL_PARAM_ADD("@val3", uc_dateablea.iText) 'iFileLocation
            EDS_SQL_PARAM_ADD("@val4", uc_userid.iText) 'iFileLocation
            EDS_SQL_PARAM_ADD("@val5", uc_password.iText) 'iFileLocation
            EDS_SQL_PARAM_ADD("@val6", SYSTEM_MODE) 'iFileLocation
            EDS_SQL_PARAM_ADD("@val7", EDS_USERID) 'iFileLocation
            Dim iDtx As DataTable = EDS_G_iSQL_TABLE()
            MainMenu.g_notif_panel(iDtx.Rows(0)("ERRORCODE"), iDtx.Rows(0)("MSG"), 2)
            iLoad()
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
        ' [Path]
        ',[ServerName]
        ',[DatabaseName]
        ',[DBUserID]
        ',[Password]
        ',[CreatedBy]
        ',[CreatedDate]
        ',[Void])
    End Sub

    Private Sub uc_path_Load(sender As Object, e As EventArgs)
        iLoad()
    End Sub
    Sub iLoad()
        Try
            EDS_SQL_PARAM.Clear() ''insert
            EDS_SQL_PARAM_ADD("@SQLID", "54")
            EDS_SQL_PARAM_ADD("@val1", SYSTEM_MODE) 'iFileLocation
            Dim iDtx As DataTable = EDS_G_iSQL_TABLE()
            uc_path.iText = iDtx.Rows(0)("Path")
            uc_userid.iText = iDtx.Rows(0)("DBUserID")
            uc_password.iText = iDtx.Rows(0)("Password")
            uc_dateablea.iText = iDtx.Rows(0)("DatabaseName")
            uc_servr.iText = iDtx.Rows(0)("ServerName")
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub
    Private Sub uc_userid_Load(sender As Object, e As EventArgs) Handles uc_userid.Load, uc_servr.Load, uc_password.Load, uc_dateablea.Load

    End Sub
End Class