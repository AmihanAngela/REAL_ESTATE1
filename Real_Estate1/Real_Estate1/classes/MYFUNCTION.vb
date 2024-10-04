Imports MySqlConnector

Public Class MYFUNCTION
    Dim db As New Database()

    ' Create function to return table data
    Function getData(ByVal query As String) As DataTable
        Dim table As New DataTable()
        Using connection As MySqlConnection = db.getConnection()
            Using command As New MySqlCommand(query, connection)
                Using adapter As New MySqlDataAdapter(command)
                    db.openConnection(connection)
                    adapter.Fill(table)
                End Using
            End Using
            db.closesConnection(connection)
        End Using
        Return table
    End Function

    ' Create function to execute queries
    Function exeQuery(ByVal command As MySqlCommand) As Boolean
        Using connection As MySqlConnection = db.getConnection()
            command.Connection = connection
            db.openConnection(connection)
            Try
                Return command.ExecuteNonQuery() = 1
            Finally
                db.closesConnection(connection)
            End Try
        End Using
    End Function

    ' Add other functions as needed...
End Class
