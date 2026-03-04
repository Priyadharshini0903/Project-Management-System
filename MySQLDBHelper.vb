Imports MySql.Data.MySqlClient
Imports System.Data

Public Class MySQLDBHelper
    Public ReadOnly _connectionString As String
    Private _connection As MySqlConnection

    Public Sub New(server As String, port As String, database As String, uid As String, password As String)
        _connectionString = $"server={server};database={database};username={uid};password={password};port={port};"
    End Sub

    Public Function OpenConnection() As Boolean
        Try
            _connection = New MySqlConnection(_connectionString)
            _connection.Open()
            Console.WriteLine("Database connection opened successfully.")
            Return True
        Catch ex As MySqlException
            Console.WriteLine($"Error opening connection: {ex.Message}")
            Return False
        End Try
    End Function

    Public Function CloseConnection() As Boolean
        Try
            If _connection IsNot Nothing AndAlso _connection.State = ConnectionState.Open Then
                _connection.Close()
                Console.WriteLine("Database connection closed successfully.")
            End If
            Return True
        Catch ex As MySqlException
            Console.WriteLine($"Error closing connection: {ex.Message}")
            Return False
        End Try
    End Function

    ' Modified to accept MySqlParameter array
    Public Function ExecuteNonQuery(sql As String, Optional parameters As MySqlParameter() = Nothing) As Integer
        Dim rowsAffected As Integer = -1
        If OpenConnection() Then
            Using cmd As New MySqlCommand(sql, _connection)
                ' Add parameters if provided
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)
                End If
                Try
                    rowsAffected = cmd.ExecuteNonQuery()
                    Console.WriteLine($"Query executed successfully. Rows affected: {rowsAffected}")
                Catch ex As MySqlException
                    Console.WriteLine($"Error executing non-query: {ex.Message}")
                Finally
                    CloseConnection()
                End Try
            End Using
        End If
        Return rowsAffected
    End Function

    ' Modified to accept MySqlParameter array
    Public Function ExecuteScalar(sql As String, Optional parameters As MySqlParameter() = Nothing) As Object
        Dim result As Object = Nothing
        If OpenConnection() Then
            Using cmd As New MySqlCommand(sql, _connection)
                ' Add parameters if provided
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)
                End If
                Try
                    result = cmd.ExecuteScalar()
                    Console.WriteLine("Scalar query executed successfully.")
                Catch ex As MySqlException
                    Console.WriteLine($"Error executing scalar query: {ex.Message}")
                Finally
                    CloseConnection()
                End Try
            End Using
        End If
        Return result
    End Function

    ' Modified to accept MySqlParameter array
    Public Function ExecuteReader(sql As String, Optional parameters As MySqlParameter() = Nothing) As DataTable
        Dim dt As New DataTable()
        If OpenConnection() Then
            Using cmd As New MySqlCommand(sql, _connection)
                ' Add parameters if provided
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)
                End If
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    Try
                        dt.Load(reader)
                        Console.WriteLine("Reader query executed successfully.")
                    Catch ex As MySqlException
                        Console.WriteLine($"Error executing reader query: {ex.Message}")
                        dt = Nothing ' Set to Nothing on error
                    Finally
                        CloseConnection()
                    End Try
                End Using
            End Using
        End If
        Return dt
    End Function
End Class

