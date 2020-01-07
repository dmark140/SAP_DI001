Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Management
Imports System.Threading

Module Global_var



    Dim iCOmport As String = ""
    Dim iNumOfTry As Integer = 0
    Dim iSend As Boolean = False

    Dim iSerial As Ports.SerialPort
    Public G_DocEntry As Integer

    Public SYSTEM_MODE As String

    Public g_txtServerIP As String
    Public G_iHAVE_ERROR_IN_TRANSACTION As Boolean
    Public g_txtDatabase As String
    Public g_txtDbUserName As String
    Public g_txtDbPassword As String
    Public g_txtCompanyDB As String

    Public g_txtUserID As String
    Public G_USERID As String
    Public g_txtPassword As String

    Public g_MainTag As MetroFramework.Controls.MetroTabControl
    Public g_MainPanel As Panel
    Public g_splitPanel As SplitContainer
    Public g_tv As TreeView
    Public g_form As Form
    Public g_Id As Form
    Public g_Id_S As String
    Public G_Finder_text As TextBox
    Public G_Finder_dscr As TextBox
    Public G_lbl_profile1 As Label



    Public G_lbl_profile2 As Label

    Public SAP_SQL_PARAM As New List(Of String)

    Public G_iSQL_COLUMNNAMES As New List(Of String)

    Public G_SUB_ADD

    Public G_split_panel_left_size As Integer = 220
    Public G_report_path As String = System.Reflection.Assembly.GetExecutingAssembly.Location()

    '  Public iPathSplit() As String = Split("C:\Users\IO\Source\Repos\SAP_DI0012\SAP-INDIRECT\bin\Debug", "\")
    Public G_iAPP_PATH_REPORTS As String = "\\10.10.0.7\ipic_di\Report"
    Public G_IMAGEPATH As String = "\\10.10.0.10\eds\REDTAG DOCS\"

    Public G_report_info As List(Of KeyValuePair(Of String, String))
    Public g_SelectionFOrm As Form
    Public G_SELECTEDFORM As Form


    Public ExtnImage As New List(Of String)
    Public ExtnDocs As New List(Of String)


    Dim WithEvents Notification_timer As Timer


    Public Batches As New List(Of BATCH_CONTAINER)
    Public Class BATCH_CONTAINER
        Public ROW As Integer
        Public BATCH As String
        Public DOCNUM As String
        Public QTY As Double
        Public WHSECODE As String
        Public SYSTEMNUM As String
        Public MACHINE As String
        Public BATCHDRNO As String
        Public ITEMCODE As String
        Public TYPE As String
    End Class


    Public Sub ADD_Column(ByVal ColName As String, ByVal ColTypeID As Integer, ByVal PositionIndex As Integer,
                          ByVal widthx As Integer,
                          ByVal dgb As DataGridView,
                          ByVal iReadOnly As Boolean,
                          ByVal isFrozen As Boolean
        )

        Dim AddColumn
        If ColTypeID = 1 Then
            AddColumn = New DataGridViewTextBoxColumn
        ElseIf ColTypeID = 2 Then
            AddColumn = New DataGridViewButtonColumn
        ElseIf ColTypeID = 3 Then
            AddColumn = New DataGridViewCheckBoxColumn
        ElseIf ColTypeID = 4 Then
            AddColumn = New DataGridViewTextBoxEditingControl
        ElseIf ColTypeID = 5 Then
            AddColumn = New DataGridViewComboBoxColumn
        End If
        Dim ix As DataGridViewButtonColumn
        With AddColumn
            If iReadOnly Then .DefaultCellStyle.backcolor = g_colors.Black_Gray_light
            .HeaderText = ColName
            .Name = ColName
            .ReadOnly = iReadOnly
            .Width = widthx
            .Frozen = isFrozen
            '  .value = "0"
            If ColTypeID = 2 Then
                .text = ColName
                .UseColumnTextForButtonValue = True

            End If
            '       .Index = PositionIndex

        End With
        dgb.Columns.Insert(PositionIndex, AddColumn)

    End Sub
    Public Sub isSortDGV(dgv As DataGridView, isForSort As Boolean)
        For i = 0 To dgv.Columns.Count - 1
            If isForSort Then dgv.Columns(i).SortMode = DataGridViewColumnSortMode.Automatic
            If isForSort = False Then dgv.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub



    Public Sub ADD_Column_ARROW(ByVal ColName As String, ByVal ColTypeID As Integer, ByVal ROWPOSITION As Integer,
                            ByVal HeadrTxt As String, ByVal iName As String,
                            ByVal widthx As Integer,
                            ByVal dgb As DataGridView,
                            ByVal iReadOnly As Boolean,
                            ByVal tag As String,
                            ByVal baseObj As Integer,
                            ByVal iITEMX_CELL_ID As Integer,
                            ByVal iIWSEX_CELL_ID As Integer,
                            ByVal iiQTYNEED_CELL_ID As Integer,
                            ByVal iIDOCNUM_CELL_ID As Integer,
                            ByVal iISQL_STATUS As Integer,
                            ByVal iType As String)

        Dim idvv As String
        ADD_Column(ColName, ColTypeID, ROWPOSITION, widthx, dgb, iReadOnly, False)
        Dim i As Integer
        For Each row As DataGridViewRow In dgb.Rows
            'Create an instance of control
            Dim uc_c As New uc_dgv_col_withArrow
            uc_c.Visible = False
            If baseObj = 1 Then
                idvv = tag & "|" & i
            End If
            uc_c.Tag = idvv
            uc_c.iDataGridView = dgb
            uc_c.iText = ""
            uc_c.iITEMXx = dgb.Rows(i).Cells(iITEMX_CELL_ID).Value
            uc_c.iIWSEXx = dgb.Rows(i).Cells(iIWSEX_CELL_ID).Value
            uc_c.iiQTYNEEDx = dgb.Rows(i).Cells(iiQTYNEED_CELL_ID).Value
            uc_c.iIDOCNUMx = dgb.Rows(i).Cells(iIDOCNUM_CELL_ID).Value
            uc_c.iTypex = iType
            uc_c.iSTATUSx = dgb.Rows(i).Cells(iISQL_STATUS).Value



            row.Cells(ROWPOSITION).Tag = uc_c

            dgb.Controls.Add(uc_c)
            uc_c.Location = dgb.GetCellDisplayRectangle(ROWPOSITION, row.Index, False).Location
            ' uc_c.Width = uc_c..Width

            uc_c.Visible = True
            '  row.Cells(ROWPOSITION)

            i = i + 1
        Next
        ' ADD_Column_ARROW_PAINT(dgb, ROWPOSITION)
    End Sub

    Public Sub AutoBatchx(dgv As DataGridView)
        Try
            For i = 0 To dgv.Controls.Count - 1
                Dim cControl As Control = dgv.Controls(i)
                If (TypeOf cControl Is uc_dgv_col_withArrow) Then
                    Dim iArrow As New uc_dgv_col_withArrow
                    iArrow = cControl
                    iArrow.btn_Item_arrow.PerformClick()
                    iArrow.iBatchSelectionFOrm.btn_auto.PerformClick()
                    iArrow.iBatchSelectionFOrm.btn_update.PerformClick()
                End If
            Next
        Catch
        End Try

    End Sub


    Public Sub ADD_Column_ARROW_REMOVE(form As DataGridView)
        Dim count As Integer = form.Controls.Count

        For i As Integer = count - 1 To 0 Step -1
            Dim cControl As Control = form.Controls(i)
            If (TypeOf cControl Is uc_dgv_col_withArrow) Then
                form.Controls.Remove(cControl)
            End If
        Next
    End Sub
    Public Sub ADD_Column_ARROW_ALIGN(form As DataGridView, COL_ID As Integer)
        Try
            If form.Columns.Count > 0 Then
                Dim iWidths As Integer = 0
                For ix = 0 To COL_ID
                    iWidths = iWidths + form.Columns(COL_ID).Width
                Next

                Dim count As Integer = form.Controls.Count
                For i As Integer = count - 1 To 0 Step -1
                    Dim cControl As Control = form.Controls(i)


                    If (TypeOf cControl Is uc_dgv_col_withArrow) Then
                        cControl.Left = form.Left + iWidths
                    End If
                Next
            End If
        Catch
        End Try
    End Sub


    Public Sub ADD_Column_ARROW_PAINT(ByVal dgb As DataGridView, ROWPOSITION As Integer)
        For i As Integer = 0 To dgb.RowCount - 1
            'Extract control from tag of your wanted cell
            Dim uc_c As uc_dgv_col_withArrow = dgb.Rows(i).Cells(ROWPOSITION).Tag

            Dim cellRectangle As Rectangle = dgb.GetCellDisplayRectangle(ROWPOSITION, i, True)
            uc_c.Location = New Point(cellRectangle.X, cellRectangle.Y)
            uc_c.Size = New Size(cellRectangle.Width - 1, cellRectangle.Height - 1)
            uc_c.Visible = True
        Next
    End Sub

    Public Sub iBtn_Ok(ByVal iTag As String, ByVal iText As String, ByVal btn_ok As Button)
        btn_ok.Tag = iTag
        btn_ok.Text = iText
    End Sub



    Public Sub iTreeNodeViewFolder(ByRef iTree As TreeView)
        Dim iCount = 0
        Dim irecSetx As SAPbobsCOM.Recordset
        irecSetx = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        irecSetx.DoQuery(" exec spDMF_DI001 3  ")
        Do While irecSetx.EoF = False
            Dim iTreeNode As New TreeNode
            Dim nodeKey As String = irecSetx.Fields(3).Value.ToString
            Dim nodeParent As String = irecSetx.Fields(4).Value.ToString
            Dim nodeValue As String = irecSetx.Fields(5).Value.ToString
            Dim nodeLevel As String = irecSetx.Fields(6).Value.ToString
            Dim nodeType As String = irecSetx.Fields(8).Value.ToString
            If nodeParent <> 0 Then
                Dim iChild = iTree.Nodes.Find(nodeParent, True).FirstOrDefault()
                iTreeNode = iChild.Nodes.Add(nodeKey, nodeValue)
                '   iChild.Nodes(nodeParent).Nodes.Add(nodeKey, nodeValue). 
            Else
                iTreeNode = iTree.Nodes.Add(nodeKey, nodeValue)

                'txtName.Text & "|" & txtText.Text & "|" & txtAccLevel.Text
            End If
            '  iTreeNode.Tag = nodeKey & "|" & nodeValue & "|" & nodeLevel
            iTreeNode.Tag = nodeKey

            iCount = iCount + 1
            irecSetx.MoveNext()
        Loop
    End Sub
    Public Sub iTreeNodeViewFolder_creator(ByRef iTree As TreeView)
        Dim iCount = 0
        Dim irecSetx As SAPbobsCOM.Recordset
        irecSetx = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        irecSetx.DoQuery(" SELECT   * FROM [@ONOD]  A     WHERE U_void = 'Y'    Order By A.U_parent_ID , A.U_NodeId")
        Do While irecSetx.EoF = False
            Dim iTreeNode As New TreeNode
            Dim nodeKey As String = irecSetx.Fields(3).Value.ToString
            Dim nodeParent As String = irecSetx.Fields(4).Value.ToString
            Dim nodeValue As String = irecSetx.Fields(5).Value.ToString
            Dim nodeLevel As String = irecSetx.Fields(6).Value.ToString
            If nodeParent <> 0 Then
                Dim iChild = iTree.Nodes.Find(nodeParent, True).FirstOrDefault()
                iTreeNode = iChild.Nodes.Add(nodeKey, nodeValue)
                '   iChild.Nodes(nodeParent).Nodes.Add(nodeKey, nodeValue). 
            Else
                iTreeNode = iTree.Nodes.Add(nodeKey, nodeValue)

                'txtName.Text & "|" & txtText.Text & "|" & txtAccLevel.Text
            End If
            iTreeNode.Tag = nodeKey & "|" & nodeValue & "|" & nodeLevel
            ' iTreeNode.Tag = nodeKey
            iCount = iCount + 1
            irecSetx.MoveNext()
        Loop
    End Sub


    Public Sub iMain_iTreeNodeViewFolder(ByRef iTree As TreeView, ByVal uID As String)
        Try

            iTree.Nodes.Clear()
            Dim iCount = 0
            Dim irecSetx As SAPbobsCOM.Recordset
            irecSetx = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            irecSetx.DoQuery("  EXEC spDMF_DI001 110  , '" & uID & "'")
            Do While irecSetx.EoF = False
                Dim iTreeNode As New TreeNode
                Dim nodeCOde As String = irecSetx.Fields(0).Value.ToString
                Dim nodeKey As String = irecSetx.Fields(3).Value.ToString
                Dim nodeParent As String = irecSetx.Fields(4).Value.ToString
                Dim nodeValue As String = irecSetx.Fields(5).Value.ToString
                Dim nodeLevel As String = irecSetx.Fields(6).Value.ToString
                Dim nodeStyle As String = irecSetx.Fields(8).Value.ToString
                Dim nodeIsEnabled As String = irecSetx.Fields(9).Value.ToString
                Dim nodeAccessType As String = irecSetx.Fields(10).Value.ToString
                If nodeParent <> 0 Then
                    Dim iChild = iTree.Nodes.Find(nodeParent, True).FirstOrDefault()
                    iTreeNode = iChild.Nodes.Add(nodeKey, nodeValue)
                Else
                    iTreeNode = iTree.Nodes.Add(nodeKey, nodeValue)
                    iTreeNode.NodeFont = New Font(MainMenu.Font, FontStyle.Bold)
                    iTreeNode.Text = iTreeNode.Text & ""
                End If
                If nodeStyle = "1" Then
                    iTreeNode.Tag = nodeKey & "|" & nodeValue & "|" & nodeLevel & "|" & nodeCOde & "|" & nodeIsEnabled & "|" & nodeAccessType
                    iTreeNode.ImageIndex = 1
                    iTreeNode.SelectedImageIndex = 1
                Else
                    iTreeNode.Tag = nodeKey
                    iTreeNode.ImageIndex = 0
                    iTreeNode.SelectedImageIndex = 0
                End If
                iCount = iCount + 1
                irecSetx.MoveNext()
            Loop
            MainMenu.g_notif_panel(2, iCount.ToString, 2)
        Catch ex As Exception
            MainMenu.g_notif_panel(2, ex.Message, 2)

        End Try
    End Sub

    Public Sub g_iLogInSet()
        Try
            g_MainPanel.Visible = False
            g_splitPanel.Enabled = True

            iMain_iTreeNodeViewFolder(g_tv, G_USERID)
            g_form.Close()

            MainMenu.g_notif_panel(1, "login successful USER:" & g_txtUserID, 2)
            MainMenu.lbl_profile1.Text = oCompany.CompanyName
            MainMenu.lbl_profile2.Text = oCompany.UserName
            MainMenu.iSetProfile()

        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub

    Public Sub g_EDS_iLogInSet()
        Try
            g_MainPanel.Visible = False
            g_splitPanel.Enabled = True

        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub



    Public Sub g_Notif(ByVal iType As Integer, ByVal iMsg As String)

    End Sub


    Public Sub iFetch(iReturn_ID As TextBox, iReturn_Desc As TextBox, iSQL_ID_ID As Integer, iForm As Form, btn_Fetch As Button)
        Try

            If IsNothing(g_SelectionFOrm) = False Then
                g_SelectionFOrm.Close()
            End If
            Dim SelectionModule As New SelectionModule
            g_SelectionFOrm = SelectionModule

            G_Finder_text = iReturn_ID
            G_Finder_dscr = iReturn_Desc
            G_SELECTEDFORM = iForm


            SelectionModule.isbtn_return_selected = True
            SelectionModule.TopMost = True
            SelectionModule.TopLevel = False
            SelectionModule.Left = btn_Fetch.Left
            iForm.Controls.Add(SelectionModule)
            iForm.Controls.SetChildIndex(SelectionModule, 999)
            SelectionModule.BringToFront()
            SelectionModule.Show()
            iSQL_selector(iSQL_ID_ID, SelectionModule.dgv, True, 2)
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub

    Public Sub iFinder(ByVal selectionID As Integer, ByVal iFormTitle As String, ByRef returni As TextBox,
                       ByRef returnDsc As TextBox, ByRef iForm As Form,
                       ByRef iArrwBtn As Button, ByVal iAdditionlQry As String, ByVal isReturnValue As Boolean, ByVal iIsInnerShow As Boolean, isForID As Boolean,
                        iText_RETURN As TextBox, iText_RETURN_ID As Integer, iinputbox As uc_inputbox, isMultiSelected As Boolean, isStayVisible As Boolean)
        '     Dim iParnt As uc_inputbox = iArrwBtn.Parent
        If IsNothing(g_SelectionFOrm) = False Then
            g_SelectionFOrm.Close()
        End If
        Dim SelectionModule As New SelectionModule
        g_SelectionFOrm = SelectionModule
        If iIsInnerShow = False Then
            '        iArrwBtn.Parent.Controls.Add(SelectionModule)
            '      SelectionModule.ShowDialog()
        End If

        If iIsInnerShow Then
            SelectionModule.TopLevel = False
            iForm.Controls.Add(SelectionModule)

            SelectionModule.Left = iArrwBtn.Left + iArrwBtn.Width + 1
            SelectionModule.Top = iArrwBtn.Top + g_MainPanel.Top
            '     SelectionModule.Show()
            SelectionModule.Activate()

            SelectionModule.Enabled = False
            If iIsInnerShow = False Then iArrwBtn.Parent.Controls.SetChildIndex(SelectionModule, 999)
            If iIsInnerShow Then iForm.Controls.SetChildIndex(SelectionModule, 999)

            SelectionModule.BringToFront()

        End If
        G_Finder_text = returni
        G_Finder_dscr = returnDsc
        SelectionModule.iFinderx(selectionID, returni.Text, iFormTitle, iAdditionlQry, isReturnValue, isForID, iForm, iText_RETURN_ID, iText_RETURN, iinputbox, isMultiSelected, iIsInnerShow, isStayVisible)
    End Sub
    Public Sub iViewr(
        ByVal selectionID As Integer,
        ByVal iSearchVar As String,
        ByVal iFormTitle As String,
        ByVal iForm As Form,
        ByVal iAdditionalCmd As String,
        ByVal isReturnValue As Boolean)

        Dim iTExtbo As TextBox
        Dim iInpuxBOx As uc_inputbox

        SelectionModule.TopLevel = False
        iForm.Controls.Add(SelectionModule)
        SelectionModule.Show()
        SelectionModule.Enabled = False
        iForm.Controls.SetChildIndex(SelectionModule, 999)
        SelectionModule.BringToFront()

        SelectionModule.iFinderx(selectionID, iSearchVar, iFormTitle, iAdditionalCmd, isReturnValue, False, iForm, 0, iTExtbo, iInpuxBOx, False, True, False)
    End Sub


    '''<summary>
    '''iSQL_ID =  @Select_id in spDMF_DI001
    '''
    '''</summary>
    '''
    Public Sub iSQL_selector(ByVal iSQL_ID As String, ByVal iDATA_GRIDVIEW As DataGridView, ByRef clear_datagrid As Boolean, ByVal id_Column_AutoSize As Integer)
        Try
            MainMenu.metroSpin.Visible = True
            Dim iFINAL_PARAM As String
            iFINAL_PARAM = "'" & iSQL_ID & "'"

            For i = 0 To SAP_SQL_PARAM.Count - 1
                iFINAL_PARAM = iFINAL_PARAM & ", '" & SAP_SQL_PARAM(i) & "'"
            Next
            iFINAL_PARAM.Remove(iFINAL_PARAM.Length - 1)
            ' MsgBox("EXEC spDMF_DI001 " & iFINAL_PARAM)


            Dim iRS As SAPbobsCOM.Recordset
            iRS = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            iRS.DoQuery("EXEC spDMF_DI001 " & iFINAL_PARAM)

            ' column formating adn adding
            If iDATA_GRIDVIEW.Columns.Count > 0 Then
                If clear_datagrid = True Then
                    iDATA_GRIDVIEW.Columns.Clear()
                    For i = 0 To iRS.Fields.Count - 1
                        ADD_Column(iRS.Fields(i).Name, 1, i, 30, iDATA_GRIDVIEW, True, False)
                    Next
                End If
            Else
                For i = 0 To iRS.Fields.Count - 1
                    ADD_Column(iRS.Fields(i).Name, 1, i, 30, iDATA_GRIDVIEW, True, False)
                Next
            End If

            '' data adding 
            Dim row()

            ReDim row(iRS.Fields.Count + 1)

            For i As Integer = 0 To iRS.RecordCount - 1

                For ii As Integer = 0 To iRS.Fields.Count - 1
                    row(ii) = iRS.Fields.Item(iRS.Fields(ii).Name).Value.ToString
                    System.Console.WriteLine(iRS.Fields(ii).Name & ":" & iRS.Fields.Item(iRS.Fields(ii).Name).Value)

                Next
                iDATA_GRIDVIEW.Rows.Add(row)
                iRS.MoveNext()
            Next
            If id_Column_AutoSize = 1 Then iDATA_GRIDVIEW.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
            If id_Column_AutoSize = 2 Then iDATA_GRIDVIEW.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            If id_Column_AutoSize = 3 Then iDATA_GRIDVIEW.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            MainMenu.metroSpin.Visible = False
        Catch ex As Exception
            MainMenu.metroSpin.Visible = False
            MainMenu.g_notif_panel(0, iSQL_ID + ex.Message, 1)
        End Try

        SAP_SQL_PARAM.Clear()
    End Sub

    Public Function iSQL_SELECT_COLUNNS(ByVal Select_ID As Integer, ByVal TableName As String) As List(Of String)
        Dim iRs As SAPbobsCOM.Recordset
        iRs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        iRs.DoQuery("")
        G_iSQL_COLUMNNAMES.Clear()

        For i = 0 To iRs.Columns.Count = False
            G_iSQL_COLUMNNAMES.Add(iRs.Columns(i).name)
        Next
        Return G_iSQL_COLUMNNAMES
    End Function

    ''' <summary>
    ''' This Function Trigers Notification panel if empty
    ''' </summary>
    Public Function iIfIsEmpty(ByVal iObject As String, ByVal iObjectName As String) As Boolean

        If iObject = "" Then
            MainMenu.g_notif_panel(0, iObjectName & " Needs be to fill up", 1)
            Return False
        Else
            Return True
        End If
    End Function
    Public Function iIfIsEmptyDGV(ByVal dataGrid As DataGridView, ByVal iObjectName As String) As Boolean

        If dataGrid.Rows.Count <= 0 Then
            MainMenu.g_notif_panel(0, iObjectName & " Needs be to fill up", 1)
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub EnableEditDGV(ByRef datagirdView As DataGridView, ByVal column As Integer)
        Dim cell As DataGridViewCell
        For i = 0 To datagirdView.Rows.Count - 1
            cell = datagirdView.Rows(i).Cells(column)
            datagirdView.CurrentCell = cell
            datagirdView.Columns(column).ReadOnly = False
            datagirdView.BeginEdit(True)
            datagirdView.Columns(column).DefaultCellStyle.BackColor = g_colors.WhiteNore
        Next
    End Sub

    Sub g_cryReportSetDB(crystalReport As ReportDocument)
        crystalReport.DataSourceConnections.Clear()
        crystalReport.DataSourceConnections.Item(0).SetConnection(g_txtServerIP, g_txtDatabase, g_txtDbUserName, g_txtDbPassword)
    End Sub
    Sub g_cryReportSetDB_EDS(crystalReport As ReportDocument)
        crystalReport.DataSourceConnections.Clear()
        crystalReport.DataSourceConnections.Item(0).SetConnection(g_txtServerIP, g_txtDatabase, g_txtDbUserName, g_txtDbPassword)
    End Sub

    Public Sub CopyToClipboardWithHeaders(dgv As DataGridView)
        'DGV = DataGridView
        dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Dim dataObj As DataObject = dgv.GetClipboardContent()
        If dataObj Is Nothing = False Then Clipboard.SetDataObject(dataObj)

    End Sub


    Public Sub iLoad_bar(iPercent As Integer, isVisible As Boolean)
        Dim iLoadBar As Label = MainMenu.lbl_load_bar
        Dim iMainMWidth As Integer = MainMenu.Width
        iLoadBar.Width = (iMainMWidth * iPercent) / 100
        iLoadBar.Visible = isVisible
        ' add timer 
    End Sub


    Function iSQL_DATATABLE(Optional ByVal iQry As String = "") As DataTable
        Try
            Dim iDataTbl As New DataTable
            Dim adapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter()

            Dim iFINAL_PARAM As String = ""
            If iQry <> "" Then
                iFINAL_PARAM = iQry
            Else
                For i = 0 To SAP_SQL_PARAM.Count - 1

                    If iFINAL_PARAM <> "" Then iFINAL_PARAM = iFINAL_PARAM & ", '" & SAP_SQL_PARAM(i) & "'"
                    If iFINAL_PARAM = "" Then iFINAL_PARAM = "'" & SAP_SQL_PARAM(i) & "'"
                Next
                iFINAL_PARAM.Remove(iFINAL_PARAM.Length - 1)
            End If
            ' MsgBox("EXEC spDMF_DI001 " & iFINAL_PARAM)
            Dim iRS As SAPbobsCOM.Recordset
            iRS = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            iRS.DoQuery("EXEC spDMF_DI001 " & iFINAL_PARAM)
            iDataTbl = AdapterFill(iRS)
            Return iDataTbl
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 1)
        End Try
        SAP_SQL_PARAM.Clear()
    End Function



    Public Function AdapterFill(ByVal SAPRecordset As SAPbobsCOM.Recordset) As DataTable

        '\ This function will take an SAP recordset from the SAPbobsCOM library and convert it to a more
        '\ easily used ADO.NET datatable which can be used for data binding much easier.
        Dim dtTable As New DataTable
        Dim NewCol As DataColumn
        Dim NewRow As DataRow
        Dim ColCount As Integer
        Try
            For ColCount = 0 To SAPRecordset.Fields.Count - 1
                NewCol = New DataColumn(SAPRecordset.Fields.Item(ColCount).Name)
                dtTable.Columns.Add(NewCol)
            Next

            Do Until SAPRecordset.EoF

                NewRow = dtTable.NewRow
                'populate each column in the row we're creating
                For ColCount = 0 To SAPRecordset.Fields.Count - 1

                    NewRow.Item(SAPRecordset.Fields.Item(ColCount).Name) = SAPRecordset.Fields.Item(ColCount).Value
                Next
                'Add the row to the datatable
                dtTable.Rows.Add(NewRow)
                SAPRecordset.MoveNext()
            Loop
            Return dtTable

        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.ToString & Chr(10) & "Error converting SAP Recordset to DataTable", 2)
            Exit Function
        End Try


    End Function



    Public Sub fitCols(dgv As DataGridView)
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub



    Public Sub iSapGoldenRetriever(iEDS_SQL_ID As Integer, iSAP_SQL_ID As Integer)
        Dim iSAPCON As New SAP_CONNECTOR
        iSAPCON.EDS_SQL_ID = iEDS_SQL_ID
        iSAPCON.SAP_SQL_ID = iSAP_SQL_ID

        iSAPCON.TopLevel = False
        iSAPCON.TopMost = True
        MainMenu.Controls.Add(iSAPCON)
        iSAPCON.BringToFront()
        iSAPCON.Location = MainMenu.Location
        iSAPCON.Show()


    End Sub

    Public Function iFileRename(FilePath As String, FileNewName As String) As Boolean
        Try
            If My.Computer.FileSystem.FileExists(FilePath) Then
                My.Computer.FileSystem.RenameFile(FilePath, FileNewName)
                Return True
            Else
                MainMenu.g_notif_panel(0, "1001  - File NOT Exists", 2)
                Return False
            End If
        Catch ex As Exception
            MainMenu.g_notif_panel(0, "1001  -[iFileRename]  " & ex.Message, 2)
            Return False
        End Try
    End Function

    Public Function iFIleCopy(FilePath As String, DistinationPath As String) As Boolean
        Try
            If System.IO.File.Exists(DistinationPath) = False Then
                System.IO.File.Copy(FilePath, DistinationPath)
                MainMenu.g_notif_panel(2, "1001 - File Copyed!", 2)
                Return True
            Else
                MainMenu.g_notif_panel(2, "1001 - File Copy Error Please Contact Administrator", 2)
                Return False
            End If
        Catch ex As Exception
            MainMenu.g_notif_panel(2, "1001 - File Copy Error: " & ex.Message, 2)
            Return False
        End Try
    End Function

    Public Function iFileExtention(FilePath As String) As String
        Try
            If System.IO.File.Exists(FilePath) = True Then
                Path.GetExtension(FilePath)
                MainMenu.g_notif_panel(2, "1001 - File Copyed!", 2)
                Return True
            Else
                MainMenu.g_notif_panel(2, "1001 - File Copy Error Please Contact Administrator", 2)
                Return False
            End If
        Catch ex As Exception
            MainMenu.g_notif_panel(2, "1001 - File Copy Error: " & ex.Message, 2)
            Return False
        End Try
    End Function
    Public Function getFormType(iForm As Form) As String

        Return iForm.GetType().Namespace.ToString & "." & iForm.Name.ToString
    End Function


    Public Sub iLayoutSetUp(LinkedTo As String, DocEntry As Integer)
        MainMenu.CMS_Layout.Items.Clear()
        G_DocEntry = DocEntry
        SAP_SQL_PARAM.Clear()
        SAP_SQL_PARAM.Add(158)
        SAP_SQL_PARAM.Add(LinkedTo)
        Dim idts As DataTable = iSQL_DATATABLE()
        For i = 0 To idts.Rows.Count - 1

            MainMenu.CMS_Layout.Items.Add(idts.Rows(i)("CODE"))
        Next
        MainMenu.CMS_Layout.Show()
    End Sub

    Sub PopUp(Title As String, Msg As String, ID As Integer, Type As Integer)
        '>>>> 1 = if main is online  
        '>>>> 2 = if main is online but is not focus 
        '>>>> 3 = if main is offline
        Dim iPopUp As New NotificationHandler

        If Type = 1 Then
            iPopUp.iPop(Title, Msg, ID)
        ElseIf Type = 2 Then
            ' this needs to be updated 
            iPopUp.iPop(Title, Msg, ID)
        ElseIf Type = 3 Then
            Dim p() As Process
            p = Process.GetProcessesByName("IPIC-SAP-DI")
            If p.Count < 1 Then
                iPopUp.iPop(Title, Msg, ID)
            End If
        End If
    End Sub

    Function BooleanReverse(i As Boolean) As Boolean
        If i = True Then Return False
        If i = False Then Return True
    End Function

    Public Sub iGet_UC_INPUT_FOR_FIND(form As Form)
        Try
            For i = 0 To form.Controls.Count - 1
                Dim cControl As Control = form.Controls(i)
                If (TypeOf cControl Is uc_inputbox) Then
                    Dim iUC_INPUTBOX As New uc_inputbox
                    iUC_INPUTBOX = cControl
                    If iUC_INPUTBOX.LinkedColumn <> "" And iUC_INPUTBOX.iIsForSearch = True Then
                        SAP_SQL_PARAM.Add(iUC_INPUTBOX.LinkedColumn & "|" & iUC_INPUTBOX.iText)
                    End If
                End If
            Next
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub


    Public Sub iFind_Css_undo(form As Form)
        Try
            For i = 0 To form.Controls.Count - 1
                Dim cControl As Control = form.Controls(i)
                If (TypeOf cControl Is uc_inputbox) Then
                    Dim iUC_INPUTBOX As New uc_inputbox
                    iUC_INPUTBOX = cControl
                    '     If iUC_INPUTBOX.LinkedColumn <> "" And iUC_INPUTBOX.iIsForSearch = True Then
                    iUC_INPUTBOX.Find_CSS(False)
                    '   End If

                End If
            Next
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub

    Public Sub iFind_Css(transType As Boolean, form As Form)
        Try
            For i = 0 To form.Controls.Count - 1
                Dim cControl As Control = form.Controls(i)
                If (TypeOf cControl Is uc_inputbox) Then
                    Dim iUC_INPUTBOX As New uc_inputbox
                    iUC_INPUTBOX = cControl
                    If iUC_INPUTBOX.LinkedColumn <> "" And iUC_INPUTBOX.iIsForSearch = True Then
                        iUC_INPUTBOX.Find_CSS(transType)
                    End If

                End If
            Next
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub

    Public Sub iSet_btn_img(iForm As Form, Image_list As ImageList)
        For i = 0 To iForm.Controls.Count - 1
            Dim iControl As Control = iForm.Controls(i)

            If TypeOf iControl Is Button Then
                Dim ibtn As New Button
                ibtn = iControl
                If IsNumeric(ibtn.Tag) Then
                    ' 0 = SAVE
                    ' 1 = CANCEL
                    ' 2 = FIND
                    ibtn.ImageAlign = ContentAlignment.MiddleRight
                    ibtn.TextImageRelation = TextImageRelation.ImageBeforeText
                    If ibtn.Tag = "0" Then
                        ibtn.Image = Image_list.Images(0)
                    ElseIf ibtn.Tag = "1" Then
                        ibtn.Image = Image_list.Images(1)
                    ElseIf ibtn.Tag = "2" Then
                        ibtn.Image = Image_list.Images(2)
                    End If
                End If
            End If
        Next
    End Sub


    Function isAllowEmpty(iForm) As Boolean
        Try
            Dim iIsTrue As Boolean = False
            For i = 0 To iForm.Controls.Count - 1
                Dim cControl As Control = iForm.Controls(i)
                If (TypeOf cControl Is uc_inputbox) Then
                    Dim iUC_INPUTBOX As New uc_inputbox
                    iUC_INPUTBOX = cControl
                    If iUC_INPUTBOX.isAllowEmptyx = False Then
                        If iUC_INPUTBOX.iText = "" Then
                            iUC_INPUTBOX.Button1.Visible = True
                            iIsTrue = True
                            MainMenu.g_notif_panel(0, "Field [" & iUC_INPUTBOX.lbl_text.Text & "] needs to be filled up", 2)
                        End If
                    End If

                End If
            Next
            Return iIsTrue
        Catch ex As Exception
            Return True
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Function





    Private Sub iTreeViewCheckAll_NodeCHeck(ByVal treeNode As TreeNode, Checked As Boolean)
        Try
            treeNode.Checked = Checked
            For Each tn As TreeNode In treeNode.Nodes
                iTreeViewCheckAll_NodeCHeck(tn, Checked)
            Next
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Sub
    Public Sub iTreeViewCheckAll(ByVal treeView As TreeView, checked As Boolean)
        Dim Nodes = treeView.Nodes
        For Each n As TreeNode In Nodes
            iTreeViewCheckAll_NodeCHeck(n, checked)
        Next
    End Sub


    Public Sub ReportSetUp(fILEnAME As String, DocEntryx As Integer)
        Dim iReportForm As New CrystalReportPreview
        Dim iReportDoc As New ReportDocument



        Dim RptDocument As New ReportDocument

        RptDocument.Load("\\10.10.0.10\eds\REPORTS\SAP\Layout\" & fILEnAME & ".rpt")

        RptDocument.SetParameterValue("DocEntry", DocEntryx)
        Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo

        Dim myTable As Table
        For Each myTable In RptDocument.Database.Tables
            myLogin = myTable.LogOnInfo
            myLogin.ConnectionInfo.ServerName = g_txtServerIP
            myLogin.ConnectionInfo.DatabaseName = g_txtDatabase
            myLogin.ConnectionInfo.UserID = g_txtDbUserName
            myLogin.ConnectionInfo.Password = g_txtDbPassword
            myTable.ApplyLogOnInfo(myLogin)
            '    myTable.Location = myTable.Location
        Next

        iReportForm.Report.ReportSource = RptDocument
        iReportForm.Show
    End Sub

    Function ModemPortUpdate() As String
        Dim MgmtSearch = New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_POTSModem")
        ' Dim MgmtSearch = New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_SerialPort")
        For Each queryObj As ManagementObject In MgmtSearch.Get()
            If queryObj("Status") = "OK" Then
                iCOmport = queryObj("AttachedTo").ToString
                EDS_SQL_PARAM.Clear()
                EDS_SQL_PARAM_ADD("@SQLID", "60")
                EDS_SQL_PARAM_ADD("@val1", iCOmport) ' 
                EDS_SQL_PARAM_ADD("@val2", Environment.MachineName) ' .
                EDS_G_iSQL()
                Return iCOmport
            Else
                EDS_SQL_PARAM.Clear()
                EDS_SQL_PARAM_ADD("@SQLID", "60")
                EDS_SQL_PARAM_ADD("@val1", queryObj("AttachedTo") & "  -  " & queryObj("Status")) ' 
                EDS_SQL_PARAM_ADD("@val2", Environment.MachineName) ' .
                EDS_G_iSQL()
                Return ""
            End If
        Next
        EDS_SQL_PARAM.Clear()
        EDS_SQL_PARAM_ADD("@SQLID", "60")
        EDS_SQL_PARAM_ADD("@val1", "DI POMASOK SA FOR") ' 
        EDS_SQL_PARAM_ADD("@val2", Environment.MachineName) ' .
        EDS_G_iSQL()
        Return ""
    End Function


    Public Sub iText(Subject As String, Msg As String, num As String)
        MainMenu.g_notif_panel(0, Msg.Length, 2)
        Dim iIsOkForSend As Boolean
        Do
            iSend = True
            Try
                Dim MgmtSearch = New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_POTSModem ")
                For Each queryObj As ManagementObject In MgmtSearch.Get()
                    If queryObj("Status") = "OK" Then
                        iCOmport = queryObj("AttachedTo").ToString
                        iIsOkForSend = True
                    End If
                Next
                If iIsOkForSend Then

                    Dim GLOBAL_SMS_Message As String = ""
                    iSerial = New Ports.SerialPort()
                    iSerial.PortName = iCOmport
                    iSerial.BaudRate = 9600
                    iSerial.Parity = Ports.Parity.None
                    iSerial.StopBits = Ports.StopBits.One
                    iSerial.DataBits = 8
                    iSerial.Handshake = Ports.Handshake.RequestToSend
                    iSerial.DtrEnable = True
                    iSerial.RtsEnable = True
                    iSerial.NewLine = vbCrLf
                    iSerial.Open()

                    If iSerial.IsOpen() = True Then
                        iSerial.Write("AT" & vbCrLf)
                        Thread.Sleep(500)
                        iSerial.Write("AT+CMGF=1" & vbCrLf)
                        iSerial.Write("AT+CMGS=" & Chr(34) & (num) & Chr(34) & vbCrLf)
                        iSerial.Write(Msg & Chr(26))
                        Thread.Sleep(500)
                        iSerial.Close()
                        iSend = True
                    Else
                        iCOmport = "COM" & iNumOfTry
                        iNumOfTry = iNumOfTry + 1
                        iSend = False
                    End If
                End If
            Catch ex As Exception
                iCOmport = "COM" & iNumOfTry
                iSend = True
            End Try
        Loop Until iSend = True
    End Sub

    Function iTextWithHandler(Msg As String, num As String, port As String, notificationicon As NotifyIcon) As Boolean
        Try

            Dim GLOBAL_SMS_Message As String = ""
            iSerial = New Ports.SerialPort()
            iSerial.PortName = port
            iSerial.BaudRate = 9600
            iSerial.Parity = Ports.Parity.None
            iSerial.StopBits = Ports.StopBits.One
            iSerial.DataBits = 8
            iSerial.Handshake = Ports.Handshake.RequestToSend
            iSerial.DtrEnable = True
            iSerial.RtsEnable = True
            iSerial.NewLine = vbCrLf
            iSerial.Open()
            iSend = False
            If iSerial.IsOpen() = True Then
                iSerial.Write("AT" & vbCrLf)
                iSerial.Write("AT+CMGF=1" & vbCrLf)
                iSerial.Write("AT+CMGS=" & Chr(34) & (num) & Chr(34) & vbCrLf)
                iSerial.Write(Msg & Chr(26))
                iSerial.Close()
                iSend = True
                Thread.Sleep(2000)
            Else
                notificationicon.Text = "IsOpen : " & iSerial.IsOpen().ToString
            End If
            Return iSend
        Catch ex As Exception
            notificationicon.Text = "Error Message: " & ex.Message
            Return False
        End Try
    End Function



    Function iGetUserType(form As Form) As String
        Try
            SAP_SQL_PARAM.Clear()
            SAP_SQL_PARAM.Add(166)
            SAP_SQL_PARAM.Add(G_USERID)
            SAP_SQL_PARAM.Add("IpicIndirect." & form.Name)
            Dim iBt As DataTable = iSQL_DATATABLE()
            Return iBt.Rows(0)("UserType")
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 2)
            Return ""
        End Try
    End Function


    Function iGetSQL_Params_FIND() As String

        Dim iFINAL_PARAM As String = ""
        For i = 1 To SAP_SQL_PARAM.Count - 1
            Dim iSplit_SAP_SQL_PARAM = SAP_SQL_PARAM(i).Split("|")
            If iFINAL_PARAM <> "" Then iFINAL_PARAM = iFINAL_PARAM & " AND " & iSplit_SAP_SQL_PARAM(0) & "  LIKE  ''%" & iSplit_SAP_SQL_PARAM(1) & "%'' "
            If iFINAL_PARAM = "" Then iFINAL_PARAM = iSplit_SAP_SQL_PARAM(0) & "  LIKE  ''%" & iSplit_SAP_SQL_PARAM(1) & "%'' "
        Next
        '      iFINAL_PARAM.Remove(iFINAL_PARAM.Length - 1)
        Return iFINAL_PARAM
    End Function


    Function iSQL_DATATABLE_FIND(Optional ByVal iQry As String = "") As DataTable
        Try
            Dim iDataTbl As New DataTable
            '    Dim adapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter()

            Dim iFINAL_PARAM As String = ""
            iFINAL_PARAM = SAP_SQL_PARAM(0) & ","
            iFINAL_PARAM = iFINAL_PARAM & "'" & iQry & "'"
            iFINAL_PARAM = iFINAL_PARAM

            Dim iRS As SAPbobsCOM.Recordset
            iRS = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            iRS.DoQuery("EXEC spDMF_DI001 " & iFINAL_PARAM)
            iDataTbl = AdapterFill(iRS)
            Return iDataTbl
        Catch ex As Exception
            MainMenu.g_notif_panel(0, ex.Message, 1)
        End Try
        SAP_SQL_PARAM.Clear()
#Disable Warning BC42105
    End Function
#Enable Warning BC42105

    Function iRemoveIsEmptyWarinIcon(iForm) As Boolean
        Try
            Dim iIsTrue As Boolean = False
            For i = 0 To iForm.Controls.Count - 1
                Dim cControl As Control = iForm.Controls(i)
                If (TypeOf cControl Is uc_inputbox) Then
                    Dim iUC_INPUTBOX As New uc_inputbox
                    iUC_INPUTBOX = cControl
                    iUC_INPUTBOX.iBtnSetVisible(False)
                End If
            Next
            Return iIsTrue
        Catch ex As Exception
            Return True
            MainMenu.g_notif_panel(0, ex.Message, 2)
        End Try
    End Function


    Function iMsgs(ByVal title As String, ByVal Msg As String, ByVal icon As Integer, isInputBox As Boolean) As String
        Dim imsg As New iButtonBox

        With imsg
            .uc_title.iLabel = "     " + title
            .uc_Body.Text = Msg
            .PictureBox1.Image = .ImageList2.Images(icon)
            .TextBox1.Visible = isInputBox
            imsg.ShowDialog()
            If isInputBox Then
                If .TextBox1.Text <> "" Then
                    Return .TextBox1.Text
                Else
                    Return "False"
                End If
            Else
                Return imsg.value
            End If

        End With
    End Function

End Module
