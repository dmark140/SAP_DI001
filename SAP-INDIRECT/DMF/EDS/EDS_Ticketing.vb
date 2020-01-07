Public Class EDS_Ticketing

    Dim ModuleMode As String = "F"
    Dim prefNode As uc_msgnode

    Private Sub Ticketing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainMenu.MenuIcons_IsActive(MainMenu.btn_menu_add, True)

        dgv_CheckSelection.Columns.Clear()

        uc_status.iText = "ALL"
        uc_label_status.iText = "A"
        txt_status.Text = "ALL"

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
        iNewTIcket.isAdd = 1
        iNewTIcket.Dock = DockStyle.Fill
        'ModuleMode = "A"
    End Sub
    Private Sub btn_find_PO_Click(sender As Object, e As EventArgs) Handles btn_find_PO.Click
        EDS_SQL_PARAM.Clear()
        dgv_CheckSelection.Columns.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "16")
        EDS_SQL_PARAM_ADD("@val1", uc_label_status.iText) 'iFileLocation
        EDS_SQL_PARAM_ADD("@val2", (uc_From.iDate)) '
        EDS_SQL_PARAM_ADD("@val3", (uc_to.iDate)) ' 
        Dim iDt As DataTable = EDS_G_iSQL_TABLE()
        dgv_CheckSelection.DataSource = iDt
        dgv_CheckSelection.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        '   DataGridViewAutoSizeColumnsMode.ColumnHeader
        '   If id_Column_AutoSize = 2 Then iDATA_GRIDVIEW.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        '   If id_Column_AutoSize = 3 Then iDATA_GRIDVIEW.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells)
    End Sub

    Private Sub dgv_CheckSelection_DoubleClick(sender As Object, e As EventArgs) Handles dgv_CheckSelection.DoubleClick

        Try
            clearmsg(Panel3)
            EDS_SQL_PARAM.Clear()
            '    dgv_CheckSelection.Columns.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "17")
            EDS_SQL_PARAM_ADD("@val1", CInt(dgv_CheckSelection.SelectedRows(0).Cells(0).Value))
            Dim iDt As DataSet = EDS_G_iSQL()
            ' 			id	docentry	createdBy	createdDate	createdTime	msg	iFile	iFileLocation	Status	void
            If iDt.Tables(0).Rows.Count > 0 Then
                ''>>> EHAEDER SETUP
                uc_mainTagNum.iText = iDt.Tables(0).Rows(0)("Tag #")
                uc_mainReqBy.iText = iDt.Tables(0).Rows(0)("Requested By")
                uc_mainReqBy.Tag = iDt.Tables(0).Rows(0)("RequestedById")
                uc_mainDateReq.iDate = iDt.Tables(0).Rows(0)("RequestedTime")
                uc_mainTimeReq.iDate = iDt.Tables(0).Rows(0)("RequestedTime")
                uc_main_subject.iText = iDt.Tables(0).Rows(0)("subject")

                uc_warehouse_lbl.iText = iDt.Tables(0).Rows(0)("warehouse")
                uc_station_lbl.iText = iDt.Tables(0).Rows(0)("station")
                uc_machine_lbl.iText = iDt.Tables(0).Rows(0)("MACHINE")
                uc_warehouse.iText = iDt.Tables(0).Rows(0)("warehousecode")
                uc_station.iText = iDt.Tables(0).Rows(0)("stationcode")
                uc_machine.iText = iDt.Tables(0).Rows(0)("MACHINEcode")


            End If
            For i = 0 To iDt.Tables(0).Rows.Count - 1
                Dim iMsgNode As New uc_msgnode

                iMsgNode.iIsLeft = CBool(iDt.Tables(0).Rows(i)("isLeft"))
                iMsgNode.isHasAttached = CBool(iDt.Tables(0).Rows(i)("isHasFile"))
                iMsgNode.iForm = Me
                iMsgNode.iAttachedx = iDt.Tables(0).Rows(i)("iFile")
                iMsgNode.RichTextBox2.Text = iDt.Tables(0).Rows(i)("msg")
                iMsgNode.uc_Sender.iText = iDt.Tables(0).Rows(i)("SentBy")
                iMsgNode.Tag = iDt.Tables(0).Rows(i)("SentTime")
                iMsgNode.AutoSize = True
                iMsgNode.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
                iMsgNode.Left = 0
                iMsgNode.Width = Panel3.Width - 20
                Panel3.Controls.Add(iMsgNode)
                iMsgNode.Show()

                iMsgNode.uc_time.iDate = iDt.Tables(0).Rows(i)("SentTime")
                iMsgNode.uc_date.iDate = iDt.Tables(0).Rows(i)("SentTime")
                If CBool(iDt.Tables(0).Rows(i)("isLeft")) Then iMsgNode.BackColor = g_colors.whiteSmoke1
                '  If CBool(iDt.Tables(0).Rows(i)("isLeft")) = False Then iMsgNode.BackColor = g_colors.whiteSmoke2
                uc_iStats.iText = iDt.Tables(0).Rows(i)("StatusLbl")

                uc_appoint2.Tag = iDt.Tables(0).Rows(i)("AppointedToId")
                uc_appoint2.iText = iDt.Tables(0).Rows(i)("AppointedTo")

                If i <> 0 Then
                    iMsgNode.Top = prefNode.Top + prefNode.Height + 5
                Else
                    iMsgNode.Top = 0
                End If
                prefNode = iMsgNode
                Panel3.Height = prefNode.Top + prefNode.Height
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
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_reply.Click
        If uc_mainTagNum.iText <> "" Then
            Dim iNewTIcket As New EDS_Ticketing_Sender
            iNewTIcket.Visible = True
            iNewTIcket.TopLevel = False
            iNewTIcket.TopMost = True
            Me.Controls.Add(iNewTIcket)
            Me.Controls.SetChildIndex(iNewTIcket, 999)
            iNewTIcket.BringToFront()
            iNewTIcket.uc_subject.iText = "RE: " & uc_main_subject.iText
            iNewTIcket.iIsReply = CInt(uc_mainTagNum.iText)
            iNewTIcket.uc_status.iArrow_Visible = True
            iNewTIcket.uc_status.iIsForSearch = True

            iNewTIcket.uc_stations.iText = uc_station.iText
            iNewTIcket.uc_station_lbl.iText = uc_station_lbl.iText

            iNewTIcket.uc_machine.iText = uc_machine.iText
            iNewTIcket.uc_machine_lbl.iText = uc_machine_lbl.iText

            iNewTIcket.uc_warehouse.iText = uc_warehouse.iText
            iNewTIcket.uc_warehouse_lbl.iText = uc_warehouse_lbl.iText

            If uc_appoint2.iText = "" And uc_mainReqBy.Tag <> EDS_USERID Then
                iNewTIcket.uc_appointedTo.iText = EDS_USERID
                iNewTIcket.uc_appointedTo_lbl.iText = EDS_USER_FULLNAME
            ElseIf uc_appoint2.iText <> "" Then
                iNewTIcket.uc_appointedTo.iText = uc_appoint2.Tag
                iNewTIcket.uc_appointedTo_lbl.iText = uc_appoint2.iText
            End If

            iNewTIcket.uc_req_by.iText = uc_mainReqBy.Tag
            iNewTIcket.uc_req_by_lbl.iText = uc_mainReqBy.iText

            iNewTIcket.Show()
            iNewTIcket.Dock = DockStyle.Fill
        End If
    End Sub
    Private Sub EDS_Ticketing_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ReSizeMsgNode(Panel3)
    End Sub


End Class