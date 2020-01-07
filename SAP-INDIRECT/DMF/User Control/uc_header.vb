Imports MetroFramework.Controls
Public Class uc_header
    Dim iFrom_DIM As Form = MainMenu

    Public Property iText As String
        Get
            Return lbl_title.Text
        End Get
        Set(value As String)
            lbl_title.Text = value
        End Set
    End Property


    Public Property iFrom As Form
        Get
            Return iFrom_DIM
        End Get
        Set(value As Form)
            iFrom_DIM = value
        End Set
    End Property

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click

        Dim tabx As TabPage
        tabx = iFrom_DIM.Parent
        Dim MetroTab As MetroTabControl
        MetroTab = tabx.Parent
        MetroTab.TabPages.Remove(tabx)
    End Sub

    Private Sub uc_header_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With Me
                .Width = iFrom_DIM.Width + 5
                .Top = 0
                .Left = 0
                .Height = 19
            End With
            Me.Anchor = AnchorStyles.Left + AnchorStyles.Top + AnchorStyles.Right
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbl_title_Click(sender As Object, e As EventArgs) Handles lbl_title.Click

    End Sub
End Class
