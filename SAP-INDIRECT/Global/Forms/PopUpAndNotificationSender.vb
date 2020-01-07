
Public Class PopUpAndNotificationSender


    '   Dim MgmtSearch As System.Management.Instrumentation


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SYSTEM_MODE = "EDS" Then
            'If txt_msg.Text = "" Then
            '    MainMenu.g_notif_panel(0, "Field [" & Uc_label1.iLabel & "] Must be filled up", 2)
            'ElseIf txt_subject.Text = "" Then
            '    MainMenu.g_notif_panel(0, "Field [" & Uc_label3.iLabel & "] Must be filled up", 2)
            'ElseIf iSelectedCount(dgv_users) > 0 Then
            '''''For i = 0 To dgv_users.Rows.Count - 1
            '''''    If CBool(dgv_users.Rows(i).Cells(0).Value) = True Then
            '''''        EDS_SQL_PARAM.Clear()
            '''''        EDS_SQL_PARAM_ADD("@SQLID", "57")
            '''''        EDS_SQL_PARAM_ADD("@val3", txt_subject.Text)                    'subject
            '''''        EDS_SQL_PARAM_ADD("@val4", txt_msg.Text)                        'msg
            '''''        EDS_SQL_PARAM_ADD("@val5", EDS_USERID)                          'sender
            '''''        EDS_SQL_PARAM_ADD("@val6", dgv_users.Rows(i).Cells(1).Value)    'receiver
            '''''        EDS_G_iSQL_TABLE()
            '''''    End If
            '''''Next
            '''

            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "61")
            EDS_SQL_PARAM_ADD("@val1", EDS_USERID)                    'subject
            EDS_SQL_PARAM_ADD("@val2", txt_msg.Text)                        'msg
            EDS_G_iSQL_TABLE()



            '>> TEXT
            '    iText(txt_subject.Text, txt_msg.Text, uc_number.Text)
            'End If
        End If
    End Sub




    Private Sub PopUpAndNotificationSender_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' >> GET USERS
        ' >> Embed it to Dgv_users
        SYSTEM_MODE = "EDS"
        If SYSTEM_MODE = "EDS" Then
            EDS_SQL_PARAM.Clear()
            EDS_SQL_PARAM_ADD("@SQLID", "11")
            dgv_users.DataSource = EDS_G_iSQL_TABLE()
            ADD_Column("", 3, 0, 30, dgv_users, False, False)
        End If
    End Sub

    Function iSelectedCount(iDgv As DataGridView) As Integer
        Dim iCOunt As Integer = 0
        For i = 0 To iDgv.Rows.Count - 1
            If CBool(iDgv.Rows(i).Cells(0).Value) Then
                iCOunt = iCOunt + 1
            End If
        Next
        Return iCOunt
    End Function



    Private Sub dgv_users_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_users.CellClick
        dgv_users.Rows(e.RowIndex).Cells(0).Value = BooleanReverse(dgv_users.Rows(e.RowIndex).Cells(0).Value)
        TextBox1.Text = iSelectSelected(dgv_users)
    End Sub

    Function iSelectSelected(iDgv As DataGridView) As String
        Dim iIds As String = ""
        For i = 0 To iDgv.Rows.Count - 1
            If CBool(iDgv.Rows(i).Cells(0).Value) Then
                iIds = iIds & dgv_users.Rows(i).Cells(2).Value & ", "
            End If

        Next
        Return iIds
    End Function
End Class