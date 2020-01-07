Public Enum PetSize
    Horizontal
    Vertical
    Box
End Enum
Public Class uc_lines
    Private myPetSize As PetSize
    Public Property PetSize() As PetSize
        Get
            Return myPetSize
        End Get
        Set(ByVal value As PetSize)
            myPetSize = value
        End Set
    End Property

    Dim iSizex As Integer = 1
    Dim isHighLightx As Boolean

    Public Property iLabel As String
        Get
            Return lbl_text.Text
        End Get
        Set(value As String)
            lbl_text.Text = value
        End Set

    End Property

    Public Property iSize As Integer
        Get
            Return iSizex
        End Get
        Set(value As Integer)
            iSizex = value
        End Set
    End Property
    Public Property isHighLight As Boolean
        Get
            Return isHighLightx
        End Get
        Set(value As Boolean)
            isHighLightx = value
            If isHighLightx Then
                lbl_text.ForeColor = g_colors.Blue_Teal
            Else
                lbl_text.ForeColor = g_colors.iFontColor_Default
            End If
        End Set
    End Property
    Private Sub uc_lines_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim myPen As Pen
        myPen = New Pen(Color.FromArgb(40, 0, 0, 0), iSizex)

        Dim W As Integer = Me.Width
        Dim H As Integer = Me.Height
        Dim P As Integer = 20
        Dim PW As Integer = W - P
        Dim PH As Integer = H - P


        If PetSize = 0 Then
            e.Graphics.DrawLine(myPen, P, P, P, PH)
        ElseIf PetSize = 1 Then
            e.Graphics.DrawLine(myPen, P, P, PW, P)
        ElseIf PetSize = 2 Then
            e.Graphics.DrawLine(myPen, P, P, P, PH)
            e.Graphics.DrawLine(myPen, P, P, PW, P)

            e.Graphics.DrawLine(myPen, PW, P, PW, PH)
            e.Graphics.DrawLine(myPen, P, PH, PW, PH)
        End If
        lbl_text.BringToFront()
        lbl_text.Left = P - 5
        lbl_text.Top = 0
    End Sub

    Private Sub uc_lines_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
