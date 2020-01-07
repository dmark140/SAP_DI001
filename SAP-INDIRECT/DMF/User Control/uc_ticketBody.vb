Public Class uc_ticketBody

    Dim iPanel As Panel
    Dim iSender As Integer
    Dim iFileName As String
    Dim iFilePath As String
    Dim iReturnPicturebOx As PictureBox
    Dim iAttachmentType As String

    Public Property iSetAttachmentType() As String
        Get
            Return iAttachmentType
        End Get
        Set(ByVal value As String)
            iAttachmentType = value
        End Set
    End Property


    Public Property iSetReturnPicturebOx() As PictureBox
        Get
            Return iReturnPicturebOx
        End Get
        Set(ByVal value As PictureBox)
            iReturnPicturebOx = value
        End Set
    End Property


    Public Property iSetFileName() As String
        Get
            Return iFileName
        End Get
        Set(ByVal value As String)
            iFileName = value
        End Set
    End Property

    Public Property iSetFilePath() As String
        Get
            Return iFilePath
        End Get
        Set(ByVal value As String)
            iFilePath = value
        End Set
    End Property

    Public Property iSetPanel() As Panel
        Get
            Return iPanel
        End Get
        Set(ByVal value As Panel)
            iPanel = value
        End Set
    End Property


    Public Property iSetIdSender() As Integer
        Get
            Return iSender
        End Get
        Set(ByVal value As Integer)
            iSender = value
        End Set
    End Property


    Private Sub uc_ticketBody_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsNothing(iPanel) = False Then
            Me.Width = iPanel.Width - 120
            Me.Anchor = AnchorStyles.Top
            Me.Anchor = AnchorStyles.Left
            Me.Anchor = AnchorStyles.Right

            If iSender = 1 Then Me.Left = 10
            If iSender = 0 Then Me.Left = 110
            If True Then

            End If
        End If


    End Sub


    Private Sub btn_zoom_Click_1(sender As Object, e As EventArgs) Handles btn_zoom.Click
        If System.IO.File.Exists(iFilePath) = True Then
            If ExtnImage.Contains(iAttachmentType) Then
                iReturnPicturebOx.ImageLocation = iFilePath
                iReturnPicturebOx.Visible = True
            Else
                Process.Start(iFilePath)
            End If
        Else
            MainMenu.g_notif_panel(0, "File Does Not Exist", 2)
        End If
    End Sub
End Class
