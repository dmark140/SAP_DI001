Imports System.Data.SqlClient

Public Class EDS_Ticketing_Sender
    Dim iFileName As String
    Dim iFilePath As String
    Dim iFilePathSplit() As String
    Dim iIsReplyx As Integer = 0
    Dim isADdx As Integer = 0
    Public iType As String = ""
    Public Identity As Integer = 0

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


    Private Sub btn_zoom_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try

            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "85")
            EDS_SQL_PARAM_ADD("@IDENTITY", uc_IDENTITY.iText)
            Dim iDt2x As DataSet = EDS_G_iSQL()

            For i = 0 To dgv_x.Rows.Count - 1
                EDS_SQL_PARAM.Clear()
                EDS_SQL_PARAM_ADD("@SQLID", "84")
                EDS_SQL_PARAM_ADD("@IDENTITY", uc_IDENTITY.iText)
                EDS_SQL_PARAM_ADD("@val1", dgv_x.Rows(i).Cells(0).Value)
                Dim iDt2xx As DataSet = EDS_G_iSQL()
            Next


            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "69")
            EDS_SQL_PARAM_ADD("@val1", uc_requestedDate.iDate)
            EDS_SQL_PARAM_ADD("@val2", uc_requestedTime.iDate)
            EDS_SQL_PARAM_ADD("@val3", uc_requestedBy.iText)
            EDS_SQL_PARAM_ADD("@val4", uc_appointedTo.iText)
            EDS_SQL_PARAM_ADD("@val5", uc_notedBy.iText)
            EDS_SQL_PARAM_ADD("@val6", uc_AreaOfConcern.iText)
            EDS_SQL_PARAM_ADD("@val7", uc_TypeOfTrouble.iText)
            EDS_SQL_PARAM_ADD("@val8", uc_Station.iText)
            EDS_SQL_PARAM_ADD("@val9", uc_Machine.iText)
            EDS_SQL_PARAM_ADD("@val10", uc_Parts.iText)
            EDS_SQL_PARAM_ADD("@val11", "")
            EDS_SQL_PARAM_ADD("@val12", uc_Likelihood.iText)
            EDS_SQL_PARAM_ADD("@val13", uc_severity.iText)
            EDS_SQL_PARAM_ADD("@val14", uc_riskLevel.iText)
            EDS_SQL_PARAM_ADD("@val15", uc_controlUsed.iText)
            EDS_SQL_PARAM_ADD("@val16", uc_StartDate.iDate)
            EDS_SQL_PARAM_ADD("@val17", uc_StartTime.iDate)
            EDS_SQL_PARAM_ADD("@val18", uc_EndDate.iDate)
            EDS_SQL_PARAM_ADD("@val19", uc_EndTime.iDate)
            EDS_SQL_PARAM_ADD("@val20", uc_StatusOfRepair.iText)
            EDS_SQL_PARAM_ADD("@val28", uc_posibleHazard.iText)
            EDS_SQL_PARAM_ADD("@val29", Uc_inputbox1.iText)

            EDS_SQL_PARAM_ADD("@val21", msg.Text)
            EDS_SQL_PARAM_ADD("@val22", uc_General_remarks.iText)
            EDS_SQL_PARAM_ADD("@val23", uc_Geberal_Findings.iText)
            EDS_SQL_PARAM_ADD("@val24", uc_General_Action.iText)
            EDS_SQL_PARAM_ADD("@val25", iFileName)
            EDS_SQL_PARAM_ADD("@val26", G_IMAGEPATH)
            EDS_SQL_PARAM_ADD("@val27", txt_status.iText)

            EDS_SQL_PARAM_ADD("@IDENTITY", uc_IDENTITY.iText.ToString)
            EDS_SQL_PARAM_ADD("@CREATEDBY", EDS_USERID)

            Dim iDt As DataSet = EDS_G_iSQL()
            If iDt.Tables(0).Rows.Count > 0 Then
                If iDt.Tables(0).Rows(0)("ERRORCODE") = 1 Then
                    If IsNothing(ExtnDocs.Contains(iFileName)) = False Then
                        iFIleCopy(iFilePath, G_IMAGEPATH + iFileName)
                    End If
                    MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)
                    EDS_Ticketing.btn_find_PO.PerformClick()
                    MainMenu.g_notif_panel(iDt.Tables(0).Rows(0)("ERRORCODE"), iDt.Tables(0).Rows(0)("ERRORCODE") & " - " & iDt.Tables(0).Rows(0)("MSG"), 2)
                    Me.Close()
                Else
                    MainMenu.g_notif_panel(iDt.Tables(0).Rows(0)("ERRORCODE"), iDt.Tables(0).Rows(0)("ERRORCODE") & " - " & iDt.Tables(0).Rows(0)("MSG"), 2)
                End If
            End If


        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
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
        dgv_x.Rows.Clear()

        uc_General_Action.iIsEnabled = False
        uc_Geberal_Findings.iIsEnabled = False
        uc_General_remarks.iIsEnabled = False
        TabControl1.TabPages(1).Enabled = False
        TabControl1.SelectedTab = TabControl1.TabPages(0)
        If iIsReplyx = 0 Then
            uc_requestedBy.iText = EDS_USERID
            uc_req_by_lbl.iText = EDS_USER_FULLNAME
        End If

        If iType = "" Then
            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "67")
            Dim iDt As DataSet = EDS_G_iSQL()
            uc_IDENTITY.iText = iDt.Tables(0).Rows(0)("ID")
        ElseIf iType = "Reply" Then
            iReply()
        ElseIf iType = "Verify" Then
            iVerify()

        End If
    End Sub

    Sub iVerify()


        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "70")
        EDS_SQL_PARAM_ADD("@val1", Identity)
        Dim iDt As DataSet = EDS_G_iSQL()
        If iDt.Tables(0).Rows.Count > 0 Then
            uc_requestedBy.iText = iDt.Tables(0).Rows(0)("RequestedByid")
            uc_req_by_lbl.iText = iDt.Tables(0).Rows(0)("RequestedBy")

            uc_AreaOfConcern.iText = iDt.Tables(0).Rows(0)("AreaOfConcernID")
            uc_area_lbl.iText = iDt.Tables(0).Rows(0)("AreaOfConcern")

            uc_TypeOfTrouble.iText = iDt.Tables(0).Rows(0)("TypeOfTroubleID")
            uc_typeofTrouble_lbl.iText = iDt.Tables(0).Rows(0)("TypeOfTrouble")

            uc_Station.iText = iDt.Tables(0).Rows(0)("StationID")
            uc_station_lbl.iText = iDt.Tables(0).Rows(0)("Station")

            uc_appointedTo_lbl.iText = iDt.Tables(0).Rows(0)("appointedTo")
            uc_appointedTo.iText = iDt.Tables(0).Rows(0)("appointedToID")

            uc_Machine.iText = iDt.Tables(0).Rows(0)("MachineID")
            uc_machine_lbl.iText = iDt.Tables(0).Rows(0)("Machine")

            uc_notedBy.iText = iDt.Tables(0).Rows(0)("VerifiedByID")
            uc_notedBy_lbl.iText = iDt.Tables(0).Rows(0)("VerifiedBy")

            uc_Likelihood.iText = iDt.Tables(0).Rows(0)("LikelihoodID")
            uc_Likelihood_lbl.iText = iDt.Tables(0).Rows(0)("Likelihood")

            uc_severity.iText = iDt.Tables(0).Rows(0)("severityID")
            uc_severity_lbl.iText = iDt.Tables(0).Rows(0)("severity")

            uc_riskLevel.iText = iDt.Tables(0).Rows(0)("riskLevel")

            uc_controlUsed.iText = iDt.Tables(0).Rows(0)("controlUsed")

            uc_StartDate.iDate = iDt.Tables(0).Rows(0)("startTime")
            uc_StartTime.iDate = iDt.Tables(0).Rows(0)("startTime")
            uc_EndDate.iDate = iDt.Tables(0).Rows(0)("EndTime")
            uc_EndTime.iDate = iDt.Tables(0).Rows(0)("EndTime")

            uc_lbl.iText = iDt.Tables(0).Rows(0)("Status")
            txt_status.iText = iDt.Tables(0).Rows(0)("StatusID")
            uc_lbl.iText = iDt.Tables(0).Rows(0)("Status")
            uc_posibleHazard.iText = iDt.Tables(0).Rows(0)("posibleHazard")
            uc_StatusOfRepair.iText = iDt.Tables(0).Rows(0)("StatusOfRepairID")
            uc_statusofRep_lbl.iText = iDt.Tables(0).Rows(0)("StatusOfRepair")

            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "83")
            EDS_SQL_PARAM_ADD("@val1", uc_AreaOfConcern.iText)
            Dim iDtx2 As DataSet = EDS_G_iSQL()
            If uc_AreaOfConcern.iText = "" Then
                uc_appointedTo.iText = iDtx2.Tables(0).Rows(0)("code")
                uc_appointedTo_lbl.iText = iDtx2.Tables(0).Rows(0)("name")
            End If
        End If
    End Sub

    Sub iReply()



        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "70")
        EDS_SQL_PARAM_ADD("@val1", Identity)
        Dim iDt As DataSet = EDS_G_iSQL()
        If iDt.Tables(0).Rows.Count > 0 Then
            uc_requestedBy.iText = iDt.Tables(0).Rows(0)("RequestedByid")
            uc_req_by_lbl.iText = iDt.Tables(0).Rows(0)("RequestedBy")

            uc_AreaOfConcern.iText = iDt.Tables(0).Rows(0)("AreaOfConcernID")
            uc_area_lbl.iText = iDt.Tables(0).Rows(0)("AreaOfConcern")

            uc_TypeOfTrouble.iText = iDt.Tables(0).Rows(0)("TypeOfTroubleID")
            uc_typeofTrouble_lbl.iText = iDt.Tables(0).Rows(0)("TypeOfTrouble")

            uc_Station.iText = iDt.Tables(0).Rows(0)("StationID")
            uc_station_lbl.iText = iDt.Tables(0).Rows(0)("Station")

            uc_appointedTo_lbl.iText = iDt.Tables(0).Rows(0)("appointedTo")
            uc_appointedTo.iText = iDt.Tables(0).Rows(0)("appointedToID")

            uc_Machine.iText = iDt.Tables(0).Rows(0)("MachineID")
            uc_machine_lbl.iText = iDt.Tables(0).Rows(0)("Machine")

            uc_notedBy.iText = iDt.Tables(0).Rows(0)("VerifiedByID")
            uc_notedBy_lbl.iText = iDt.Tables(0).Rows(0)("VerifiedBy")

            uc_Likelihood.iText = iDt.Tables(0).Rows(0)("LikelihoodID")
            uc_Likelihood_lbl.iText = iDt.Tables(0).Rows(0)("Likelihood")

            uc_severity.iText = iDt.Tables(0).Rows(0)("severityID")
            uc_severity_lbl.iText = iDt.Tables(0).Rows(0)("severity")

            uc_riskLevel.iText = iDt.Tables(0).Rows(0)("riskLevel")

            uc_controlUsed.iText = iDt.Tables(0).Rows(0)("controlUsed")

            uc_StartDate.iDate = iDt.Tables(0).Rows(0)("startTime")
            uc_StartTime.iDate = iDt.Tables(0).Rows(0)("startTime")
            uc_EndDate.iDate = iDt.Tables(0).Rows(0)("EndTime")
            uc_EndTime.iDate = iDt.Tables(0).Rows(0)("EndTime")

            uc_lbl.iText = iDt.Tables(0).Rows(0)("Status")
            txt_status.iText = iDt.Tables(0).Rows(0)("StatusID")
            uc_lbl.iText = iDt.Tables(0).Rows(0)("Status")
            uc_posibleHazard.iText = iDt.Tables(0).Rows(0)("posibleHazard")
            uc_StatusOfRepair.iText = iDt.Tables(0).Rows(0)("StatusOfRepairID")
            uc_statusofRep_lbl.iText = iDt.Tables(0).Rows(0)("StatusOfRepair")
        End If







        'EDS_SQL_PARAM.Clear()
        'EDS_SQL_PARAM_ADD("@SQLID", "77") ' ALLOWED DEPARTMENT TO BE APPOINTED IN JRF
        'EDS_SQL_PARAM_ADD("@val1", EDS_USER_DEPARTMNT_ID)
        'Dim iDtx2 As DataSet = EDS_G_iSQL()
        'If iDtx2.Tables(0).Rows.Count > 0 Then
        '    If CBool(iDtx2.Tables(0).Rows(0)("CODE")) Then
        '        iSetAppointed()
        '        If uc_appointedTo.iText = "" Then
        '            If EDS_USERID <> uc_requestedBy.iText Then
        '                uc_appointedTo.iText = EDS_USERID
        '                uc_appointedTo_lbl.iText = EDS_USER_FULLNAME
        '            End If
        '        End If
        '    End If
        'End If
        uc_maint.iArrow_Visible = False
        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "74") 'ALLOWED DEPARTMENT TO SET HAZARARD
        EDS_SQL_PARAM_ADD("@val1", EDS_USER_DEPARTMNT_ID)
        Dim iDtx As DataSet = EDS_G_iSQL()
        If iDtx.Tables(0).Rows.Count > 0 Then
            If EDS_USERID <> uc_requestedBy.iText Then
                If CBool(iDtx.Tables(0).Rows(0)("CODE")) Then
                    uc_Likelihood.iArrow_Visible = True
                    uc_severity.iArrow_Visible = True
                    uc_riskLevel.iIsEnabled = True
                    uc_posibleHazard.iIsEnabled = True
                    uc_controlUsed.iIsEnabled = True
                    Uc_inputbox1.iIsEnabled = False
                    Uc_inputbox1.iArrow_Visible = True
                    uc_maint.iArrow_Visible = True
                End If
            End If
        End If

        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "83")
        EDS_SQL_PARAM_ADD("@val1", uc_AreaOfConcern.iText)
        Dim iDtx2 As DataSet = EDS_G_iSQL()
        If uc_AreaOfConcern.iText = "" Then
            uc_appointedTo.iText = iDtx2.Tables(0).Rows(0)("code")
            uc_appointedTo_lbl.iText = iDtx2.Tables(0).Rows(0)("name")
        End If
        Timer3.Enabled = True

        uc_StatusOfRepair.iArrow_Visible = True
    End Sub

    Sub iSetAppointed()
        '   uc_appointedTo.iIsEnabled = False
        '    uc_appointedTo.iArrow_Visible = True
        '    uc_appointedTo.iIsForSearch = True
        '    uc_appointedTo.iSQL_Parameter_ID = 11
        '  uc_appointedTo.iSQL_Parameter_ID_FIND = 11
    End Sub
    Private Sub msg_TextChanged(sender As Object, e As EventArgs) Handles msg.TextChanged
        Uc_lines1.lbl_text.Text = "Description of Trouble(" & (140 - msg.Text.Length) & " characters Remains)"
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Try
            If txt_status.iText = "R" Then
                '  MainMenu.g_notif_panel(2, "HEY", 3)

                uc_General_Action.iIsEnabled = True
                uc_Geberal_Findings.iIsEnabled = True
                uc_General_remarks.iIsEnabled = True
                TabControl1.TabPages(1).Enabled = True
                TabControl1.SelectedTab = TabControl1.TabPages(1)

                TabControl1.TabPages(0).Enabled = False
                msg.Enabled = False
                Uc_lines1.Enabled = False

            Else
                uc_General_Action.iIsEnabled = False
                uc_Geberal_Findings.iIsEnabled = False
                uc_General_remarks.iIsEnabled = False
                TabControl1.TabPages(1).Enabled = False
                TabControl1.SelectedTab = TabControl1.TabPages(0)

                TabControl1.TabPages(0).Enabled = True
                msg.Enabled = True
                Uc_lines1.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        uc_riskLevel.iText = ""
        If uc_Likelihood.iText <> "" And uc_severity.iText <> "" Then
            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "66")
            EDS_SQL_PARAM_ADD("@val1", uc_Likelihood.iText)
            EDS_SQL_PARAM_ADD("@val2", uc_severity.iText)
            Dim iDt As DataSet = EDS_G_iSQL()
            uc_riskLevel.iText = iDt.Tables(0).Rows(0)("CODE")

        End If



    End Sub

    Private Sub uc_AreaOfConcern_Load(sender As Object, e As EventArgs) Handles uc_AreaOfConcern.Load
        Timer1.Enabled = True
    End Sub

    Private Sub uc_area_text_TextChanged(sender As Object, e As EventArgs) Handles uc_area_text.TextChanged
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "83")
        EDS_SQL_PARAM_ADD("@val1", uc_AreaOfConcern.iText)
        Dim iDtx2 As DataSet = EDS_G_iSQL()
        If uc_AreaOfConcern.iText <> "" Then
            uc_appointedTo.iText = iDtx2.Tables(0).Rows(0)("code")
            uc_appointedTo_lbl.iText = iDtx2.Tables(0).Rows(0)("name")
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles uc_maint_Text.TextChanged
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If uc_maint.iText <> "" Then
            dgv_x.Rows.Add(uc_maint.iText, uc_maint_lbl.iText)
            uc_maint.iText = ""
            uc_maint_lbl.iText = ""
        End If
        Timer2.Enabled = False
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            dgv_x.Rows.RemoveAt(dgv_x.SelectedRows(0).Index)
        Catch
        End Try
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick


        Try
            dgv_x.Rows.Clear()
            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "86")
            EDS_SQL_PARAM_ADD("@IDENTITY", uc_IDENTITY.iText)
            Dim iDtxxx As DataSet = EDS_G_iSQL()
            For i = 0 To iDtxxx.Tables(0).Rows.Count - 1
                dgv_x.Rows.Add(iDtxxx.Tables(0).Rows(i)("code"), iDtxxx.Tables(0).Rows(i)("name"))
            Next
            Timer3.Enabled = False
        Catch ex As Exception
            Timer3.Enabled = False
        End Try
    End Sub
End Class