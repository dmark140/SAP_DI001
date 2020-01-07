Imports SAPbobsCOM




Module Draft
    Dim DGV As New DataGridView

    Function Draft_Set(ByRef iForm As Form, ByRef Temp_key As String, ByRef Remarks As String, Module_Key As String,
                        Optional ByVal DataGid1 As DataGridView = Nothing,
                        Optional ByVal DataGid2 As DataGridView = Nothing,
                        Optional ByVal DataGid3 As DataGridView = Nothing) As Integer
        Try
            oConnect()

            Dim iHeader As GeneralService
            Dim iHeaderData As GeneralData
            Dim iChild As GeneralDataCollection
            Dim iChildData As GeneralData

            Dim oCompService As CompanyService = oCompany.GetCompanyService()
            iHeader = oCompany.GetCompanyService.GetGeneralService("ODFT")
            iHeaderData = iHeader.GetDataInterface(GeneralServiceDataInterfaces.gsGeneralData)
            iHeaderData.SetProperty("U_TemplateKey", Temp_key)
            iHeaderData.SetProperty("U_ModuleKey", Module_Key)
            iHeaderData.SetProperty("U_Status", "D")
            iHeaderData.SetProperty("Remarks", Remarks)

            iChild = iHeaderData.Child("DFT1")
            DraftTable_UC_INPUTBOX(iForm, iChild, iChildData)
            DraftTable_UC_DATE(iForm, iChild, iChildData)
            DraftTable_UC_TIME(iForm, iChild, iChildData)

            iChild = iHeaderData.Child("DFT2")
            If IsNothing(DataGid1) = False Then DraftTable_DATAGRID(DataGid1, iChild, iChildData, "1")
            If IsNothing(DataGid2) = False Then DraftTable_DATAGRID(DataGid2, iChild, iChildData, "2")
            If IsNothing(DataGid3) = False Then DraftTable_DATAGRID(DataGid3, iChild, iChildData, "3")

            iHeader.Add(iHeaderData)
            Return 0
        Catch ex As Exception
            Return 101
        End Try
    End Function

    Sub DraftTable_DATAGRID(DataGid As DataGridView, iChild As GeneralDataCollection, iChildData As GeneralData, panel As String)
        For R = 0 To DataGid.Rows.Count - 1
            For C = 0 To DataGid.Columns.Count - 1
                iChildData = iChild.Add()
                iChildData.SetProperty("U_panel", panel)
                iChildData.SetProperty("U_FieldName", DataGid.Columns(C).Name)
                iChildData.SetProperty("U_colnum", C & "")
                iChildData.SetProperty("U_rownum", R & "")
                iChildData.SetProperty("U_value", DataGid.Rows(R).Cells(C).Value)
            Next
        Next
    End Sub


    Sub DraftTable_UC_INPUTBOX(iForm As Form, iChild As GeneralDataCollection, iChildData As GeneralData)
        For i = 0 To iForm.Controls.Count - 1 '' INPUT USER CONTROL
            Dim cControl As Control = iForm.Controls(i)
            If (TypeOf cControl Is uc_inputbox) Then
                Dim UC As New uc_inputbox
                UC = cControl
                If UC.LinkedColumn <> "" Then
                    Dim iIsEn As String
                    If UC.iIsEnabled Then iIsEn = "Y"
                    If UC.iIsEnabled = False Then iIsEn = "N"

                    iChildData = iChild.Add()
                    iChildData.SetProperty("U_controlName", UC.Name)
                    iChildData.SetProperty("U_controlType", "X")
                    iChildData.SetProperty("U_isControlEnabled", iIsEn)
                    iChildData.SetProperty("U_ControlValue", UC.iText)
                End If
            End If
        Next
    End Sub



    Sub DraftTable_UC_DATE(iForm As Form, iChild As SAPbobsCOM.GeneralDataCollection, iChildData As SAPbobsCOM.GeneralData)
        For i = 0 To iForm.Controls.Count - 1 '' INPUT USER CONTROL
            Dim cControl As Control = iForm.Controls(i)
            If (TypeOf cControl Is uc_date) Then
                Dim UC As New uc_date
                UC = cControl
                If UC.LinkedColumn <> "" Then
                    iChildData = iChild.Add()
                    iChildData.SetProperty("U_controlName", UC.Name)
                    iChildData.SetProperty("U_controlType", "D")
                    iChildData.SetProperty("U_isControlEnabled", UC.IsEnabled)
                    iChildData.SetProperty("U_ControlValue", UC.iDate)
                End If
            End If
        Next
    End Sub
    Sub DraftTable_UC_TIME(iForm As Form, iChild As SAPbobsCOM.GeneralDataCollection, iChildData As SAPbobsCOM.GeneralData)
        For i = 0 To iForm.Controls.Count - 1 '' INPUT USER CONTROL
            Dim cControl As Control = iForm.Controls(i)
            If (TypeOf cControl Is uc_time) Then
                Dim UC As New uc_time
                UC = cControl
                If UC.LinkedColumn <> "" Then
                    iChildData = iChild.Add()
                    iChildData.SetProperty("U_controlName", UC.Name)
                    iChildData.SetProperty("U_controlType", "D")
                    iChildData.SetProperty("U_isControlEnabled", UC.IsEnabled)
                    iChildData.SetProperty("U_ControlValue", UC.iDate)
                End If
            End If
        Next
    End Sub
End Module
