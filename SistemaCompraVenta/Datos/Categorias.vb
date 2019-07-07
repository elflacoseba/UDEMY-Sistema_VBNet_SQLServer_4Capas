Imports System.Data.SqlClient

Public Class Categorias
    Inherits Conexion

    Public Function Listar() As DataTable

        Dim Resultados As SqlDataReader

        Try

            Using cmd As New SqlCommand("Categorias_Listar", MyBase.Cnn)

                cmd.CommandType = CommandType.StoredProcedure
                MyBase.Cnn.Open()

                Resultados = cmd.ExecuteReader()

                Using Tabla As New DataTable
                    Tabla.BeginLoadData()
                    Tabla.Load(Resultados)
                    Tabla.EndLoadData()

                    Return Tabla

                End Using

            End Using

        Catch ex As Exception
            Throw ex
        Finally
            MyBase.Cnn.Close()
            Resultados = Nothing
        End Try
    End Function
End Class
