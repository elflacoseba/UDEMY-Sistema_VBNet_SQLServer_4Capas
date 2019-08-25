Public Class Articulos

    ''' <summary>
    ''' Devuelve un listado con todos los Artículos de la base de datos.
    ''' </summary>
    ''' <returns></returns>
    Public Function Listar() As DataTable

        Dim oDatos As Datos.Articulos
        Dim Tabla As DataTable

        Try
            oDatos = New Datos.Articulos()

            Tabla = New DataTable

            Tabla = oDatos.Listar()

            Return Tabla

        Catch ex As Exception
            Throw ex
            Return Nothing
        Finally
            oDatos = Nothing
            Tabla = Nothing
        End Try
    End Function

    ''' <summary>
    ''' Busca Artículos por Código, nombre y descripción.
    ''' </summary>
    ''' <param name="Valor">Valor a buscar</param>
    ''' <returns></returns>
    Public Function Buscar(Valor As String) As DataTable

        Dim oDatos As Datos.Articulos
        Dim Tabla As DataTable

        Try
            oDatos = New Datos.Articulos()

            Tabla = New DataTable

            Tabla = oDatos.Buscar(Valor)

            Return Tabla

        Catch ex As Exception
            Throw ex
            Return Nothing
        Finally
            oDatos = Nothing
            Tabla = Nothing
        End Try
    End Function

    ''' <summary>
    ''' Inserta un nuevo Artículo en la base de datos.
    ''' </summary>
    ''' <param name="obj">Un objeto del tipo Artículo</param>
    ''' <returns></returns>
    Public Function Insertar(obj As Entidades.Articulo) As Boolean

        Dim oDatos As Datos.Articulos

        Try
            oDatos = New Datos.Articulos
            oDatos.Insertar(obj)

            Return True
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            oDatos = Nothing
        End Try
    End Function

    ''' <summary>
    ''' Actualiza la información de un Artículo en la base de datos.
    ''' </summary>
    ''' <param name="obj">Un objeto del tipo Artículo</param>
    ''' <returns></returns>
    Public Function Actualizar(obj As Entidades.Articulo) As Boolean

        Dim oDatos As Datos.Articulos

        Try
            oDatos = New Datos.Articulos
            oDatos.Actualizar(obj)

            Return True
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            oDatos = Nothing
        End Try
    End Function

    ''' <summary>
    ''' Elimina un Artículo de la base de datos.
    ''' </summary>
    ''' <param name="ID">El ID del Artículo</param>
    ''' <returns></returns>
    Public Function Eliminar(ID As Integer) As Boolean

        Dim oDatos As Datos.Articulos

        Try
            oDatos = New Datos.Articulos
            oDatos.Eliminar(ID)

            Return True
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            oDatos = Nothing
        End Try
    End Function

    ''' <summary>
    ''' Desactiva un Artículo de la base de datos.
    ''' </summary>
    ''' <param name="ID">El ID del Artículo</param>
    ''' <returns></returns>
    Public Function Desactivar(ID As Integer) As Boolean

        Dim oDatos As Datos.Articulos

        Try
            oDatos = New Datos.Articulos
            oDatos.Desactivar(ID)

            Return True
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            oDatos = Nothing
        End Try
    End Function

    ''' <summary>
    ''' Activa un Artículo de la base de datos.
    ''' </summary>
    ''' <param name="ID">El ID del Artículo</param>
    ''' <returns></returns>
    Public Function Activar(ID As Integer) As Boolean

        Dim oDatos As Datos.Articulos

        Try
            oDatos = New Datos.Articulos
            oDatos.Activar(ID)

            Return True
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            oDatos = Nothing
        End Try
    End Function
End Class
