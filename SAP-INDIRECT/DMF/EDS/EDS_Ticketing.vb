Public Class EDS_Ticketing

    Dim ModuleMode As String = "F"
    Dim prefNode As uc_msgnode

    Private Sub Ticketing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)

        dgv_CheckSelection.Columns.Clear()

        uc_status.iText = "O"
        uc_label_status.iText = "OPEN"
        txt_status.Text = "O"

        uc_From.iDate = "01/01/2020"
        btn_find_PO.PerformClick()

    End Sub
    Sub TrigerMode()
        If ModuleMode = "A" Then
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, True)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, False)
        ElseIf ModuleMode = "F" Then
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, False)
            MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)
        End If
    End Sub
    Sub AddMode()
        MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, False)
        MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_find, False)
        Dim iNewTIcket As New EDS_Ticketing_Sender
        iNewTIcket.Visible = True

        iNewTIcket.TopLevel = False
        iNewTIcket.TopMost = True
        Me.Controls.Add(iNewTIcket)
        Me.Controls.SetChildIndex(iNewTIcket, 999)
        iNewTIcket.BringToFront()
        iNewTIcket.Show()
        iNewTIcket.iIsReply = 0
        ''''iNewTIcket.isAdd = 1


        iNewTIcket.Left = (Me.Width / 2) - (iNewTIcket.Width / 2)
        ModuleMode = "A"
    End Sub
    Private Sub btn_find_PO_Clcick(sender As Object, e As EventArgs) Handles btn_find_PO.Click

        Try
            EDS_SQL_PARAM.Clear()
            dgv_CheckSelection.Columns.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "16")
            EDS_SQL_PARAM_ADD("@val1", uc_status.iText) 'iFileLocation
            EDS_SQL_PARAM_ADD("@val2", (uc_From.iDate)) '
            EDS_SQL_PARAM_ADD("@val3", (uc_to.iDate)) ' 
            EDS_SQL_PARAM_ADD("@val4", EDS_USER_DEPARTMNT_ID.ToString) ' 
            EDS_SQL_PARAM_ADD("@val6", EDS_USERID.ToString) '
            EDS_SQL_PARAM_ADD("@val7", Uc_inputbox4.iText.ToString) '
            Dim iDt As DataTable = EDS_G_iSQL_TABLE()
            dgv_CheckSelection.DataSource = iDt
            dgv_CheckSelection.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub

    Private Sub dgv_CheckSelection_DoubleClick(sender As Object, e As EventArgs) Handles dgv_CheckSelection.DoubleClick

        Try
            clearmsg(Panel3)
            EDS_SQL_PARAM.Clear()

            uc_IDENTITY.iText = (dgv_CheckSelection.SelectedRows(0).Cells(0).Value)

            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "70")
            EDS_SQL_PARAM_ADD("@val1", CInt(dgv_CheckSelection.SelectedRows(0).Cells(0).Value))
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
                uc_lbl.iText = iDt.Tables(0).Rows(0)("Status")
                uc_posibleHazard.iText = iDt.Tables(0).Rows(0)("posibleHazard")
                uc_StatusOfRepair.iText = iDt.Tables(0).Rows(0)("StatusOfRepairID")
                uc_statusofRep_lbl.iText = iDt.Tables(0).Rows(0)("StatusOfRepair")
            End If

            EDS_SQL_PARAM.Clear()
            '   dgv_CheckSelection.Columns.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "71")
            EDS_SQL_PARAM_ADD("@val1", uc_IDENTITY.iText)
            Dim iDtx As DataSet = EDS_G_iSQL()
            For i = 0 To iDtx.Tables(0).Rows.Count - 1
                Dim iMsgNode As New uc_msgnode

                '   iMsgNode.iIsLeft = CBool(iDtx.Tables(0).Rows(i)("isLeft"))
                iMsgNode.isHasAttached = CBool(iDtx.Tables(0).Rows(i)("isHasFile"))
                iMsgNode.iForm = Me
                iMsgNode.iAttachedx = iDtx.Tables(0).Rows(i)("iFile")
                Dim iMsg() As String = Split(iDtx.Tables(0).Rows(i)("msg"), "|")
                For xi = 0 To iMsg.Count - 1
                    iMsgNode.RichTextBox2.Text = iMsgNode.RichTextBox2.Text & vbNewLine & iMsg(xi)
                Next
                '= iDtx.Tables(0).Rows(i)("msg")
                iMsgNode.uc_Sender.iText = iDtx.Tables(0).Rows(i)("createdBy")
                iMsgNode.Tag = iDtx.Tables(0).Rows(i)("createdTime")
                iMsgNode.AutoSize = True
                iMsgNode.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
                iMsgNode.Left = 0
                iMsgNode.Width = Panel3.Width - 20
                Panel3.Controls.Add(iMsgNode)
                iMsgNode.Show()

                iMsgNode.uc_time.iDate = iDtx.Tables(0).Rows(i)("createdTime")
                iMsgNode.uc_date.iDate = iDtx.Tables(0).Rows(i)("createdDate")

                If iDtx.Tables(0).Rows(i)("iFile") <> "" Then
                    iMsgNode.Height = iMsgNode.Height + 20
                End If
                If i <> 0 Then
                    iMsgNode.Top = prefNode.Top + prefNode.Height + 5
                Else
                    iMsgNode.Top = 0
                End If
                prefNode = iMsgNode
                Panel3.Height = prefNode.Top + prefNode.Height
            Next

            dgv_x.Rows.Clear()
            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "86")
            EDS_SQL_PARAM_ADD("@IDENTITY", uc_IDENTITY.iText)
            Dim iDtxxx As DataSet = EDS_G_iSQL()
            For i = 0 To iDtxxx.Tables(0).Rows.Count - 1
                dgv_x.Rows.Add(iDtxxx.Tables(0).Rows(i)("name"))
            Next


        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub
    Sub clearmsg(iPanel As Panel)
        Dim count As Integer = iPanel.Controls.Count
        For i As Integer = count - 1 To 0 Step -1
            Dim cControl As Control = iPanel.Controls(i)
            If (TypeOf cControl Is uc_msgnode) Then
                iPanel.Controls.Remove(cControl)
            End If
        Next
    End Sub
    Sub ReSizeMsgNode(iPanel As Panel)
        Dim count As Integer = iPanel.Controls.Count
        For i As Integer = count - 1 To 0 Step -1
            Dim cControl As Control = iPanel.Controls(i)
            If (TypeOf cControl Is uc_msgnode) Then
                cControl.Width = iPanel.Width
            End If
        Next
    End Sub

    Sub reply()
        If uc_IDENTITY.iText <> "" Then
            Dim iNewTIcket As New EDS_Ticketing_Sender
            iNewTIcket.btn_ok.Text = "Reply"
            iNewTIcket.iType = "Reply"
            iNewTIcket.Identity = CInt(uc_IDENTITY.iText)
            iNewTIcket.Visible = True
            iNewTIcket.TopLevel = False
            iNewTIcket.TopMost = True
            Me.Controls.Add(iNewTIcket)
            Me.Controls.SetChildIndex(iNewTIcket, 999)
            iNewTIcket.uc_IDENTITY.iText = uc_IDENTITY.iText
            iNewTIcket.uc_IDENTITY.iIsEnabled = False
            iNewTIcket.txt_status.iArrow_Visible = True
            iNewTIcket.BringToFront()

            iNewTIcket.Show()
            iNewTIcket.Left = (Me.Width / 2) - (iNewTIcket.Width / 2)
        Else
            MainMenu.g_notif_panel(0, "Please select a ticket!", 2)
        End If
    End Sub

    Sub Verify()

        If uc_IDENTITY.iText <> "" Then
            If CBool(iMsgs("Confirm Verification", "WARNING: this action cannot be undone ", 1, False)) Then
                EDS_SQL_PARAM.Clear()
                EDS_SQL_PARAM_ADD("@SQLID", "79")
                EDS_SQL_PARAM_ADD("@val1", EDS_USERID)
                EDS_SQL_PARAM_ADD("@IDENTITY", CInt(uc_IDENTITY.iText))
                EDS_SQL_PARAM_ADD("@CREATEDBY", EDS_USERID)
                Dim iDt As DataSet = EDS_G_iSQL()
                If iDt.Tables(0).Rows.Count > 0 Then
                    MainMenu.g_notif_panel(iDt.Tables(0).Rows(0)("ERRORCODE"), iDt.Tables(0).Rows(0)("MSG"), 2)
                End If
            End If
        Else
            MainMenu.g_notif_panel(0, "Please select a ticket!", 2)
        End If
    End Sub



    Private Sub EDS_Ticketing_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ReSizeMsgNode(Panel3)
    End Sub
    Private Sub txt_status_TextChanged(sender As Object, e As EventArgs) Handles txt_status.TextChanged
        btn_find_PO.PerformClick()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        btn_find_PO.PerformClick()
    End Sub


    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        Try

            ToolStripMenuItem1.Enabled = False
            ToolStripMenuItem2.Enabled = False
            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "74")
            EDS_SQL_PARAM_ADD("@CREATEDBY", EDS_USERID)
            EDS_SQL_PARAM_ADD("@IDENTITY", uc_IDENTITY.iText)
            Dim iDtx As DataSet = EDS_G_iSQL()
            If iDtx.Tables(0).Rows.Count > 0 Then
                If CBool(iDtx.Tables(0).Rows(0)("CODE")) Then
                    ToolStripMenuItem1.Enabled = True
                End If
            End If

            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "75")
            EDS_SQL_PARAM_ADD("@CREATEDBY", EDS_USERID)
            EDS_SQL_PARAM_ADD("@IDENTITY", uc_IDENTITY.iText)
            Dim iDt As DataSet = EDS_G_iSQL()
            If iDt.Tables(0).Rows.Count > 0 Then
                ToolStripMenuItem2.Enabled = CBool(iDt.Tables(0).Rows(0)("CODE"))
            End If

            Dim iPoint As Point
            iPoint = New Point(0, btn_ok.Height)
            cms_action.Show(btn_ok, iPoint)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        reply()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Verify()
    End Sub


    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        btn_find_PO.PerformClick()

    End Sub

End Class