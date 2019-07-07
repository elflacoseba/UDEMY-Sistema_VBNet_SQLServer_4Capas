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

    ''' <summary>
    ''' Inserta una nueva Categoría en la base de datos.
    ''' </summary>
    ''' <param name="obj">Un objeto del tipo Categoria</param>
    Public Sub Insertar(obj As Entidades.Categoria)

        Try

            Using cmd As New SqlCommand("Categorias_Insertar", MyBase.Cnn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre)
                cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion)

                MyBase.Cnn.Open()

                cmd.ExecuteNonQuery()

            End Using

        Catch ex As Exception
            Throw ex
        Finally
            MyBase.Cnn.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Modifica los datos de una nueva Categoría en la base de datos.
    ''' </summary>
    ''' <param name="obj">Un objeto del tipo Categoria</param>
    Public Sub Actualizar(obj As Entidades.Categoria)

        Try

            Using cmd As New SqlCommand("Categorias_Actualizar", MyBase.Cnn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Id", obj.CategoriaID)
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre)
                cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion)

                MyBase.Cnn.Open()

                cmd.ExecuteNonQuery()

            End Using

        Catch ex As Exception
            Throw ex
        Finally
            MyBase.Cnn.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Elimina una Categoría de la base de datos.
    ''' </summary>
    ''' <param name="ID">El ID de la Categoria</param>
    Public Sub Eliminar(ID As Integer)

        Try

            Using cmd As New SqlCommand("Categorias_Eliminar", MyBase.Cnn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Id", ID)

                MyBase.Cnn.Open()

                cmd.ExecuteNonQuery()

            End Using

        Catch ex As Exception
            Throw ex
        Finally
            MyBase.Cnn.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Desactiva una Categoría de la base de datos.
    ''' </summary>
    ''' <param name="ID">El ID de la Categoria</param>
    Public Sub Desactivar(ID As Integer)

        Try

            Using cmd As New SqlCommand("Categorias_Desactivar", MyBase.Cnn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Id", ID)

                MyBase.Cnn.Open()

                cmd.ExecuteNonQuery()

            End Using

        Catch ex As Exception
            Throw ex
        Finally
            MyBase.Cnn.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Activa una Categoría de la base de datos.
    ''' </summary>
    ''' <param name="ID">El ID de la Categoria</param>
    Public Sub Activar(ID As Integer)

        Try

            Using cmd As New SqlCommand("Categorias_Activar", MyBase.Cnn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Id", ID)

                MyBase.Cnn.Open()

                cmd.ExecuteNonQuery()

            End Using

        Catch ex As Exception
            Throw ex
        Finally
            MyBase.Cnn.Close()
        End Try
    End Sub
End Class
