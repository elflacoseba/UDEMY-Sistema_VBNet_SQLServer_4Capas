Imports System.Data.SqlClient

Public Class Categorias
    Inherits Conexion

    ''' <summary>
    ''' Obtiene todas las Categorías de la base de datos.
    ''' </summary>
    ''' <returns></returns>
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

    ''' <summary>
    ''' Buscar Categorías por nombre y descripción.
    ''' </summary>
    ''' <param name="Valor">Valor a buscar.</param>
    ''' <returns></returns>
    Public Function Buscar(Valor As String) As DataTable

        Dim Resultados As SqlDataReader

        Try

            Using cmd As New SqlCommand("Categorias_Buscar", MyBase.Cnn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Valor", Valor)

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
