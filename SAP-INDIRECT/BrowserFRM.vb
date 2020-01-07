Public Class BrowserFRM
    Public oRecordSet As SAPbobsCOM.Recordset
    Dim oBusinessPartner As SAPbobsCOM.BusinessPartners
    Private Sub BrowserFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call oConnect()
        oRecordSet = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oBusinessPartner = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)
        oRecordSet.DoQuery("Select A.CardCode from OCRD A /*LEFT JOIN OCPR B ON A.CardCode = B.CardCode*/ where A.CardType = 'C'")
        oBusinessPartner.Browser.Recordset = oRecordSet
        If oRecordSet.RecordCount > 0 Then
            oBusinessPartner.Browser.MoveFirst()
            'TextBox1.Text = oBusinessPartner.CardCode
            FillField()
        End If
    End Sub

    ''MOVE LAST
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If oBusinessPartner.Browser.EoF = False Then
            oBusinessPartner.Browser.MoveLast()
            'TextBox1.Text = oBusinessPartner.CardCode
            'TextBox2.Text = oBusinessPartner.CardName
            FillField()
        End If
    End Sub

    ''MOVE Previous
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If oBusinessPartner.Browser.BoF = False Then
            oBusinessPartner.Browser.MovePrevious()
            'TextBox1.Text = oBusinessPartner.CardCode
            FillField()
        End If

    End Sub
    ''MOVE FIRST
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If oBusinessPartner.Browser.BoF = False Then
            oBusinessPartner.Browser.MoveFirst()
            'TextBox1.Text = oBusinessPartner.CardCode
            FillField()
        End If
    End Sub
    'MOVE Next
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If oBusinessPartner.Browser.EoF = False Then
            oBusinessPartner.Browser.MoveNext()
            'TextBox1.Text = oBusinessPartner.CardCode
            FillField()
        End If
    End Sub

    Private Sub FillField()
        TextBox1.Text = oBusinessPartner.CardCode
        TextBox2.Text = oBusinessPartner.CardName
        TextBox3.Text = oBusinessPartner.CardType
        'TextBox3.Text = oBusinessPartner.ContactEmployees.Address
    End Sub
End Class