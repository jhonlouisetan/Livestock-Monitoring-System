Imports MySql.Data.MySqlClient


Module Livestock
    Private dbConn As MySqlConnection
    Private da As MySqlDataAdapter
    Private dt As DataTable
    Private sqlCommand As MySqlCommand

    Private strConn = "server=localhost; username=root; database=db_livestock; Convert Zero Datetime=True"

    Public Sub dbConnection()
        dbConn = New MySqlConnection(strConn)
        'dbConn.ConnectionString=strConn

        dbConn.Open()
        dbConn.Close()
    End Sub

    Public Sub displayRecords(ByVal SQL As String, ByVal DG As DataGridView)
        dbConn.Open()

        da = New MySqlDataAdapter(SQL, dbConn)
        dt = New DataTable
        da.Fill(dt) ' fill or populate records to dt thru da

        DG.DataSource = dt ' keep and send the records to DataGridView in the GUI

        dbConn.Close()
    End Sub

    Public Sub SQLManager(ByVal SQL As String)
        dbConn.Open()
        sqlCommand = New MySqlCommand

        With sqlCommand
            .CommandType = CommandType.Text
            .CommandText = SQL
            .Connection = dbConn
            .ExecuteNonQuery()
        End With
        dbConn.Close()
    End Sub

    Public Class DTConnection
        Dim connect As New MySqlConnection("server=localhost; uid=root; database=db_livestock")

        Public Function open() As MySqlConnection
            Try
                connect.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return connect

        End Function

        Public Function close() As MySqlConnection
            Try
                connect.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return connect

        End Function
    End Class
End Module
