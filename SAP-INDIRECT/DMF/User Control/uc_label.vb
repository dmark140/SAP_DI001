﻿Public Class uc_label
    Dim iSQL_ID As Integer
    Dim iDescription As Label
    Dim iFORMx As Form
    Dim iAdditQRT As String
    Dim iForSearch As Boolean
    Dim iIsVerticalz As Boolean = False
    Dim iSetWidth As Integer
    Dim iAddition As String
    Public ilblText As TextBox


    Dim iLinkedColumn As String = ""

    Dim iFormInfo As String = ""

    Dim isLabelBold As Boolean = False

    Public Property LinkedColumn As String
        Get
            Return iLinkedColumn
        End Get
        Set(value As String)
            iLinkedColumn = value
        End Set
    End Property
    Public Property isLabelBoldx As Boolean
        Get
            Return isLabelBold
        End Get
        Set(value As Boolean)
            Try

                isLabelBold = value
                If isLabelBold = True Then
                    lbl_text.Font = New Font(lbl_text.Font, FontStyle.Bold)
                    lbl_text.ForeColor = g_colors.Blue_Teal
                ElseIf isLabelBold = False Then
                    lbl_text.Font = New Font(lbl_text.Font, FontStyle.Regular)
                End If
            Catch ex As Exception

            End Try
        End Set
    End Property

    Public Property idsc As Label
        Get
            Return iDescription
        End Get
        Set(value As Label)
            iDescription = value
        End Set
    End Property

    'Sub iOrientation(ByVal iIsVerticalx As Boolean)
    '    If iIsVerticalx Then
    '        inputBox.Left = 0
    '        inputBox.Top = lbl_text.Height
    '        inputBox.Width = Width
    '        lbl_text.Width = Width
    '        btn_Item_arrow.Left = inputBox.Width - btn_Item_arrow.Width
    '        btn_Item_arrow.Top = inputBox.Top
    '        Me.Height = inputBox.Height + lbl_text.Height

    '    Else
    '        iLabel_width = 120
    '        lbl_text.Width = 120
    '        inputBox.Top = 0
    '        inputBox.Left = lbl_text.Width = lbl_text.Width
    '        inputBox.Width = Me.Width - lbl_text.Width
    '        btn_Item_arrow.Top = 1
    '        btn_Item_arrow.Left = inputBox.Left - btn_Item_arrow.Width
    '    End If
    'End Sub

    'Public Property iIsVertical As Boolean
    '    Get
    '        Return iIsVerticalz
    '    End Get
    '    Set(value As Boolean)
    '        iIsVerticalz = value
    '        '  iOrientation(iIsVerticalz)
    '    End Set
    'End Property

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


    Public Property iIsEnabled As Boolean
        Get
            Return inputBox.Enabled
        End Get
        Set(value As Boolean)
            inputBox.Enabled = value
        End Set
    End Property

    Public Property iLabel_width As Integer
        Get
            Return iSetWidth
        End Get
        Set(value As Integer)
            lbl_text.Width = value
            iSetWidth = value
            setWidths()
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



    Public Property iLabel As String
        Get
            Return lbl_text.Text
        End Get
        Set(value As String)
            lbl_text.Text = value
        End Set
    End Property

    Public Property iText As String
        Get
            Return inputBox.Text
        End Get
        Set(value As String)
            inputBox.Text = value
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


    Private Sub uc_inputbox_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_text.Cursor = Cursors.Default
        ilblText = inputBox
        setWidths()
        inputBox.BringToFront()
        iFormInfo = "T: LABEL" & " S:" & iIsForSearch & " ID:" & iSQL_Parameter_ID & " V:" & inputBox.Text & " L:" & LinkedColumn

    End Sub
    Sub setWidths()
        If iIsVerticalz = False Then
            inputBox.Left = lbl_text.Width - 5
            inputBox.Width = Me.Width - lbl_text.Width
        End If
    End Sub

    Private Sub inputBox_TextChanged(sender As Object, e As EventArgs) Handles inputBox.TextChanged

    End Sub

    Private Sub inputBox_EnabledChanged(sender As Object, e As EventArgs) Handles inputBox.EnabledChanged

    End Sub

    Private Sub uc_label_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        setWidths()
    End Sub

    Private Sub inputBox_MouseEnter(sender As Object, e As EventArgs) Handles inputBox.MouseEnter
        MainMenu.lbl_hover.Visible = True
        MainMenu.lbl_hover.Text = iFormInfo
    End Sub

    Private Sub inputBox_MouseLeave(sender As Object, e As EventArgs) Handles inputBox.MouseLeave
        MainMenu.lbl_hover.Visible = False
    End Sub


    Private Sub lbl_text_MouseEnter(sender As Object, e As EventArgs) Handles lbl_text.MouseEnter
        MainMenu.lbl_hover.Visible = True
        MainMenu.lbl_hover.Text = iFormInfo
    End Sub

    Private Sub lbl_text_MouseLeave(sender As Object, e As EventArgs) Handles lbl_text.MouseLeave
        MainMenu.lbl_hover.Visible = False

    End Sub

    Private Sub uc_label_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        MainMenu.lbl_hover.Visible = True
        MainMenu.lbl_hover.Text = iFormInfo
    End Sub

    Private Sub uc_label_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        MainMenu.lbl_hover.Visible = False
    End Sub

    Private Sub uc_label_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim myPen As Pen
        myPen = New Pen(Color.FromArgb(40, 0, 0, 0), 1)
        e.Graphics.DrawLine(myPen, 0, inputBox.Top + inputBox.Height - 1, inputBox.Left, inputBox.Top + inputBox.Height - 1)
    End Sub

    Private Sub lbl_text_Click(sender As Object, e As EventArgs) Handles lbl_text.Click

    End Sub
End Class
