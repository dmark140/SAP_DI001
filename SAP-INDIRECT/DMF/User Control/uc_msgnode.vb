Public Class uc_msgnode
    Dim iIsLeftx As Boolean
    Dim iIshasAttachedx As Boolean
    Dim iAttached As String
    Dim iIformx As Form

    Public Property iIsLeft() As Boolean
        Get
            Return iIsLeftx
        End Get
        Set(value As Boolean)
            iIsLeftx = value
            If value Then
                Panel1.Left = Me.Width - (Panel1.Width + 5)
                Panel1.Anchor = AnchorStyles.Right Or AnchorStyles.Top
            Else
                Panel1.Left = 5
                Panel1.Anchor = AnchorStyles.Left Or AnchorStyles.Top
            End If
        End Set
    End Property

    Public Property isHasAttached() As Boolean
        Get
            Return iIshasAttachedx
        End Get
        Set(value As Boolean)
            Button2.Visible = value
            Button2.Enabled = value
            iIshasAttachedx = value

            'If value Then
            '    RichTextBox2.Height = RichTextBox2.Height + Button2.Height + 10
            'Else
            '    RichTextBox2.Height = RichTextBox2.Height - (Button2.Height + 10)
            'End If

        End Set
    End Property

    Public Property iAttachedx() As String
        Get
            Return iAttached
        End Get
        Set(value As String)
            iAttached = value
        End Set
    End Property

    Public Property iForm() As Form
        Get
            Return iIformx
        End Get
        Set(value As Form)
            iIformx = value
        End Set
    End Property

    Private Sub uc_msgnode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If iIsLeftx Then
            Panel1.Left = Me.Width - (Panel1.Width + 5)
        Else
            Panel1.Left = 5
        End If
        iResize()
        iResize()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ''open attached file
        Dim FILE_NAME As String = iAttached

        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)
        Else
            MainMenu.g_notif_panel(0, ("File Does Not Exist"), 2)

        End If

    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged
        ' RichTextBox2.Height = RichTextBox2.Lines.Count * RichTextBox2.Lines(0).
        '  RichTextBox2.ClientSize = New Size(RichTextBox2.ClientSize.Width, GetHeightOfFirstLines(RichTextBox2, RichTextBox2.Lines.Count) - 10)
        '  MainMenu.g_notif_panel(2,GetHeightOfFirstLines(RichTextBox2, RichTextBox2.Lines.Count).ToString,2)
        iResize()
        iResize()
    End Sub

    'Private Shared Function GetHeightOfFirstLines(ByVal Rtb As RichTextBox, ByVal NumLines As Integer) As Integer
    '    Dim p1 = Rtb.GetPositionFromCharIndex(Rtb.GetFirstCharIndexFromLine(0))
    '    Dim p2 = Rtb.GetPositionFromCharIndex(Rtb.GetFirstCharIndexFromLine(NumLines))

    '    Return p2.Y - p1.Y
    'End Function


    Sub iResize()
        Dim rtbSize As New Size(TextRenderer.MeasureText(RichTextBox2.Text, RichTextBox2.Font, RichTextBox2.Size, TextFormatFlags.WordBreak))
        If rtbSize.Height > 300 Then
            rtbSize.Height = 300
        End If
        Me.Height = rtbSize.Height + 10 + Button2.Height + 10 + RichTextBox2.Top
        RichTextBox2.Height = rtbSize.Height + 5
        Button2.Top = rtbSize.Height + 10 + RichTextBox2.Top
        Me.Tag = Me.Height
    End Sub

End Class
