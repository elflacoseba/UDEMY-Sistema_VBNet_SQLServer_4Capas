
Imports System.Data.SqlClient

Public Class Articulos
    Inherits Conexion

    ''' <summary>
    ''' Obtiene todas los Artículos de la base de datos.
    ''' </summary>
    ''' <returns></returns>
    Public Function Listar() As DataTable

        Dim Resultados As SqlDataReader

        Try

            Using cmd As New SqlCommand("Articulos_Listar", MyBase.Cnn)

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
    ''' Busca Artículos por Código, Nombre y Descripción.
    ''' </summary>
    ''' <param name="Valor">Valor a buscar.</param>
    ''' <returns></returns>
    Public Function Buscar(Valor As String) As DataTable

        Dim Resultados As SqlDataReader

        Try

            Using cmd As New SqlCommand("Articulos_Buscar", MyBase.Cnn)

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
    ''' Inserta un nuev Artículo en la base de datos.
    ''' </summary>
    ''' <param name="obj">Un objeto del tipo Categoria</param>
    Public Sub Insertar(obj As Entidades.Articulo)

        Try

            Using cmd As New SqlCommand("Articulos_Insertar", MyBase.Cnn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CategoriaId", obj.CategoriaID)
                cmd.Parameters.AddWithValue("@Codigo", obj.Codigo)
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre)
                cmd.Parameters.AddWithValue("@Precio_Venta", obj.PrecioVenta)
                cmd.Parameters.AddWithValue("@Stock", obj.Stock)
                cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion)
                cmd.Parameters.AddWithValue("@Imagen", obj.Imagen)
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
    ''' Modifica los datos de una Artículo en la base de datos.
    ''' </summary>
    ''' <param name="obj">Un objeto del tipo Articulo</param>
    Public Sub Actualizar(obj As Entidades.Articulo)

        Try

            Using cmd As New SqlCommand("Articulos_Actualizar", MyBase.Cnn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ArticuloID", obj.ArticuloID)
                cmd.Parameters.AddWithValue("@CategoriaId", obj.CategoriaID)
                cmd.Parameters.AddWithValue("@Codigo", obj.Codigo)
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre)
                cmd.Parameters.AddWithValue("@Precio_Venta", obj.PrecioVenta)
                cmd.Parameters.AddWithValue("@Stock", obj.Stock)
                cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion)
                cmd.Parameters.AddWithValue("@Imagen", obj.Imagen)

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
    ''' Elimina un Artículo de la base de datos.
    ''' </summary>
    ''' <param name="ID">El ID del Artículo</param>
    Public Sub Eliminar(ID As Integer)

        Try

            Using cmd As New SqlCommand("Articulos_Eliminar", MyBase.Cnn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ArticuloID", ID)

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
    ''' Desactiva un Artículo de la base de datos.
    ''' </summary>
    ''' <param name="ID">El ID de la Categoria</param>
    Public Sub Desactivar(ID As Integer)

        Try

            Using cmd As New SqlCommand("Articulos_Desactivar", MyBase.Cnn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ArticuloID", ID)

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
    ''' Activa un Artículo de la base de datos.
    ''' </summary>
    ''' <param name="ID">El ID de la Categoria</param>
    Public Sub Activar(ID As Integer)

        Try

            Using cmd As New SqlCommand("Articulos_Activar", MyBase.Cnn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ArticuloID", ID)

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
