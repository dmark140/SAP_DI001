﻿'Public Class uc_finder

'    Dim iSQL_ID As Integer
'    Dim iSQL_Value As String
'    Dim iFORMx As Form
'    Dim iArrowVisible As Boolean
'    Dim iDesc As TextBox
'    Dim iAddition As String
'    '' sql ID is the spDMF_M001[id][value]
'    Public Property iSQL_Parameter_ID As Integer
'        Get
'            Return iSQL_ID
'        End Get
'        Set(value As Integer)
'            iSQL_ID = value
'        End Set
'    End Property

'    Public Property iTitle As String
'        Get
'            Return txt_title.Text
'        End Get
'        Set(value As String)
'            txt_title.Text = value
'        End Set
'    End Property

'    Public Property iAddition_SQL As String
'        Get
'            Return iAddition
'        End Get
'        Set(value As String)
'            iAddition = value
'        End Set
'    End Property
'    Public Property iText As String
'        Get
'            Return txt_itemmaster.Text
'        End Get
'        Set(value As String)
'            txt_itemmaster.Text = value
'        End Set
'    End Property


'    Public Property iDescription As TextBox
'        Get
'            Return iDesc
'        End Get
'        Set(value As TextBox)
'            iDesc = value
'            G_Finder_dscr = iDesc
'        End Set
'    End Property

'    Public Property iHasArrow As Boolean
'        Get
'            Return btn_Item_arrow.Visible
'        End Get
'        Set(value As Boolean)
'            btn_Item_arrow.Visible = value
'        End Set
'    End Property

'    Public Property iForm As Form
'        Get
'            Return iFORMx
'        End Get
'        Set(value As Form)
'            iFORMx = value
'        End Set
'    End Property

'    Private Sub btn_Item_arrow_Click(sender As Object, e As EventArgs) Handles btn_Item_arrow.Click
'        iFinder(iSQL_Parameter_ID, iTitle, txt_itemmaster, iDescription, iFORMx, Me, iAddition_SQL, True)
'    End Sub

'    Private Sub txt_itemmaster_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txt_itemmaster.PreviewKeyDown
'        If txt_itemmaster.Text IsNot "" And e.KeyCode = Keys.Tab Then
'            iFinder(iSQL_Parameter_ID, iTitle, txt_itemmaster, iDescription, iFORMx, btn_Item_arrow, iAddition_SQL, True)
'        End If
'    End Sub

'    Private Sub uc_finder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        Me.Width = txt_title.Width + 1
'        Me.Height = txt_itemmaster.Height + txt_itemmaster.Top + 1
'    End Sub

'    Private Sub txt_itemmaster_TextChanged(sender As Object, e As EventArgs) Handles txt_itemmaster.TextChanged
'        iDescription.Text = ""
'    End Sub
'End Class
