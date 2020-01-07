Public Class uc_sub_Header


    Public Property iLabel As String
        Get
            Return lbl_text.Text
        End Get
        Set(value As String)
            lbl_text.Text = value
        End Set
    End Property
End Class
