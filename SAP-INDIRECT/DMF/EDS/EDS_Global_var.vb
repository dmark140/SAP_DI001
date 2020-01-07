Imports System.Data.SqlClient

Public Class EDS_Global_var
    Public iUsername As String
    Public iFirstName As String
    Public iLastName As String
    Public iPosition As String
    Public sqlAddress = "Data Source = winserver2016; Initial Catalog = eds; Persist Security Info = True; User ID=sa; Password=1p1cdbs3rv3r@2016;"
    Public Sub iConnect()

        Dim sqlConn = New SqlConnection(sqlAddress)
        Dim sqlDA = New SqlDataAdapter()
        Dim DS = New DataSet()
        Dim sqlComm = New SqlCommand("sp_HRPS_Timelogs", sqlConn)
        '  sqlComm.Parameters.Add("@user_id", SqlDbType.VarChar).Value = UserID.ToString()
        sqlConn.Open()
        sqlComm.CommandType = CommandType.StoredProcedure
        sqlComm.Connection = sqlConn
        sqlDA.SelectCommand = sqlComm
        sqlDA.Fill(DS, "load")
        ' dataGridView1.DataSource = DS
        ' dataGridView1.DataMember = "load"
        sqlConn.Close()
    End Sub
End Class
