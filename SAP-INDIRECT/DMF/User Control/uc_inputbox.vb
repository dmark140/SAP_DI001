Public Class uc_inputbox
    Dim iSQL_ID As Integer
    Dim iDescription As TextBox
    Dim iFORMx As Object
    Dim iAdditQRT As String
    Dim iForSearch As Boolean
    Dim iShowInsideOutSide As Boolean
    Dim isForFindx As Boolean
    Dim iIsVerticalz As Boolean = False
    Dim iSetWidth As Integer
    Dim iAddition As String
    Dim idscx As uc_label
    Dim iTransActionTypex As Char
    Dim iOnload_iBtnArrowShow_IsActive As Boolean
    Dim iOnload_iText_IsActive As Boolean
    Dim iOnload_IsForSearch As Boolean
    Dim iDropDown As Boolean
    Dim iIsFOrID As Boolean
    Dim iTexbo_ As TextBox
    Dim iTexbo_COL_ID As Integer
    Dim iCharacterLimitx As Integer

    Dim iCanFindLabel_SQLID As Integer

    Public Property idsc As uc_label
        Get
            Return idscx
        End Get
        Set(value As uc_label)
            idscx = value
        End Set
    End Property

    Public Property iTextBox_ As TextBox
        Get
            Return iTexbo_
        End Get
        Set(value As TextBox)
            iTexbo_ = value
        End Set
    End Property

    Public Property iTextBox_Sel_COL_ID As Integer
        Get
            Return iTexbo_COL_ID
        End Get
        Set(value As Integer)
            iTexbo_COL_ID = value
        End Set
    End Property

    Public Property iIsInnerShow As Boolean
        Get
            Return iShowInsideOutSide
        End Get
        Set(value As Boolean)
            iShowInsideOutSide = value
        End Set
    End Property

    Public Property iIsForSearch As Boolean
        Get
            Return iForSearch
        End Get
        Set(value As Boolean)
            iForSearch = value
        End Set
    End Property


    Public Property iSQL_Parameter_ID As Integer
        Get
            Return iSQL_ID
        End Get
        Set(value As Integer)
            iSQL_ID = value
        End Set
    End Property


    Public Property iTitle As String
        Get
            Return Textbox.Text
        End Get
        Set(value As String)
            Textbox.Text = value
        End Set
    End Property

    Public Property iForm As Form
        Get
            Return iFORMx
        End Get
        Set(value As Form)
            iFORMx = value
        End Set
    End Property
    ''' <summary>
    ''' Retruns or Set the transaction type 
    ''' </summary>
    ''' <value>
    ''' A = Add &#xD
    ''' U = Update&#xD
    ''' F = Find&#xD
    ''' D = Delete&#xD
    ''' </value>
    ''' <remarks></remarks>
    'Public Property iTransactionType As Char
    '    Get
    '        Return iTransActionTypex
    '    End Get
    '    Set(value As Char)
    '        iTransActionTypex = value

    '    End Set
    'End Property

    Public Property iIsEnabled As Boolean
        Get
            Return Textbox.Enabled
        End Get
        Set(value As Boolean)
            Textbox.Enabled = value
            If value = False Then Textbox.Font = New Font(Textbox.Font, FontStyle.Bold)
            If value = True Then Textbox.Font = New Font(Textbox.Font, FontStyle.Regular)
        End Set

    End Property

    Public Property iIsDropDown As Boolean
        Get
            Return iDropDown
        End Get
        Set(value As Boolean)
            iDropDown = value

        End Set
    End Property



    Public Property iLabel_width As Integer
        Get
            Return iSetWidth
        End Get
        Set(value As Integer)
            '  value = value + btn_Item_arrow.Width
            lbl_text.Width = value + btn_Item_arrow.Width
            iSetWidth = value
            setWidths()
        End Set
    End Property

    Public Property iIsID As Boolean
        Get
            Return iIsFOrID
        End Get
        Set(value As Boolean)
            iIsFOrID = value
        End Set
    End Property


    Public Property iAddition_SQL As String
        Get
            Return iAddition
        End Get
        Set(value As String)
            iAddition = value
        End Set
    End Property


    Public Property iArrow_Visible As Boolean
        Get
            Return btn_Item_arrow.Visible
        End Get
        Set(value As Boolean)
            btn_Item_arrow.Visible = value
        End Set
    End Property


    Public Property iLabel As String
        Get
            Return lbl_text.Text
        End Get
        Set(value As String)

            lbl_text.Text = Trim(value)
            setWidths()
        End Set
    End Property

    Public Property iText As String
        Get
            Return Textbox.Text
        End Get
        Set(value As String)
            Textbox.Text = value
        End Set
    End Property

    Public Property iAdditional As String
        Get
            Return iAdditQRT
        End Get
        Set(value As String)
            iAdditQRT = value
        End Set
    End Property

    Public Property iCharacterLimit As Integer
        Get
            Return iCharacterLimitx
        End Get
        Set(value As Integer)
            iCharacterLimitx = value
        End Set
    End Property


    Public Property iCanFindLabel_SQLIDx As Integer
        Get
            Return iCanFindLabel_SQLID
        End Get
        Set(value As Integer)
            iCanFindLabel_SQLID = value
        End Set
    End Property


    Public Property isForFind As Boolean
        Get
            Return isForFindx
        End Get
        Set(value As Boolean)
            isForFindx = value
        End Set
    End Property
    Private Sub uc_inputbox_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        'MainMenu.lbl_footer.Text = "hover test"
    End Sub
    Private Sub uc_inputbox_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        '  MainMenu.lbl_footer.Text = ""
    End Sub

    Private Sub uc_inputbox_Load(sender As Object, e As EventArgs) Handles Me.Load
        iOnload_iBtnArrowShow_IsActive = iArrow_Visible
        iOnload_iText_IsActive = iIsEnabled
        iOnload_IsForSearch = iIsForSearch
        setWidths()
        Textbox.BringToFront()
        btn_Item_arrow.BringToFront()
    End Sub

    Sub setWidths()
        If iIsVerticalz = False Then
            Textbox.Left = (lbl_text.Width) - 5
            Textbox.Width = Me.Width - lbl_text.Width
            btn_Item_arrow.Left = Textbox.Left - (btn_Item_arrow.Width) - 5
        End If
    End Sub

    Private Sub inputBox_TextChanged(sender As Object, e As EventArgs) Handles Textbox.TextChanged


        If iCharacterLimitx < Textbox.TextLength And iCharacterLimitx <> 0 Then
            MainMenu.g_notif_panel(0, "Maximum character length reached, this filed only accepts " & iCharacterLimitx & " characters", 2)
        Else

            Try
                g_Id_S = Textbox.Text

                iTexbo_.Text = Textbox.Text
                If iCanFindLabel_SQLID <> 0 Then

                    If SYSTEM_MODE = "SAP" Then
                        Dim iRs As SAPbobsCOM.Recordset = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                        iRs.DoQuery("exec spDMF_DI001  " & iCanFindLabel_SQLID & " , " & Textbox.Text)
                        If iRs.RecordCount > 0 Then
                            idscx.iText = iRs.Fields.Item(0).Value
                        Else
                            idscx.iText = ""
                        End If
                    ElseIf SYSTEM_MODE = "EDS" Then
                        MsgBox("")
                    End If



                Else
                    idscx.iText = ""
                End If
            Catch ex As Exception
                '    MainMenu.g_notif_panel(0, ex.Message, 2)
            End Try
        End If


    End Sub

    Private Sub btn_Item_arrow_Click(sender As Object, e As EventArgs) Handles btn_Item_arrow.Click
        Try

            If iDropDown Then
                Textbox.Text = ""
                idscx.iText = ""
            End If

            If iIsForSearch And iSQL_Parameter_ID <> 0 Then iFinder(iSQL_Parameter_ID, iTitle, Textbox, idsc.inputBox, iFORMx, Me.btn_Item_arrow, iAdditional, True, iShowInsideOutSide, iIsFOrID, iTextBox_, iTextBox_Sel_COL_ID, Me)

        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try

    End Sub

    Private Sub inputBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Textbox.KeyDown
        If Textbox.Text IsNot "" And e.KeyCode = Keys.Tab Then
            iFinder(iSQL_Parameter_ID, iTitle, Textbox, idsc.inputBox, iFORMx, Me.btn_Item_arrow, iAdditional, True, iShowInsideOutSide, iIsFOrID, iTextBox_, iTextBox_Sel_COL_ID,me)
        End If
    End Sub

    Sub TransactionTrig(iTrig As Char)
        Try
            If iTrig = "F" Then
                If isForFind Then
                    Textbox.BackColor = g_colors.Yellow_Find
                    Textbox.Enabled = True
                    iIsForSearch = True
                    btn_Item_arrow.Visible = True
                    btn_Item_arrow.Visible = True
                Else
                    Textbox.BackColor = g_colors.WhiteNore
                    Textbox.Enabled = False
                    btn_Item_arrow.Visible = False
                End If
            ElseIf iTrig = "A" Then
                iIsForSearch = iOnload_IsForSearch
                Textbox.BackColor = g_colors.WhiteNore
                Textbox.Enabled = iOnload_iText_IsActive

                iArrow_Visible = iOnload_iBtnArrowShow_IsActive
            End If
            Textbox.Text = ""
            idsc.inputBox.Text = ""
        Catch
        End Try
    End Sub

    Private Sub uc_inputbox_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        setWidths()
    End Sub

    Private Sub lbl_text_Click(sender As Object, e As EventArgs) Handles lbl_text.Click

    End Sub
End Class
