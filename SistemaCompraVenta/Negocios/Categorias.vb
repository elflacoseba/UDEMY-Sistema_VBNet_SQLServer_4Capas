Public Class Categorias

    ''' <summary>
    ''' Devuelve un listado con todas las Categorías de la base de datos.
    ''' </summary>
    ''' <returns></returns>
    Public Function Listar() As DataTable

        Dim oDatos As Datos.Categorias
        Dim Tabla As DataTable

        Try
            oDatos = New Datos.Categorias()

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
    ''' Busca Categorías por nombre y descripción.
    ''' </summary>
    ''' <param name="Valor">Valor a buscar</param>
    ''' <returns></returns>
    Public Function Buscar(Valor As String) As DataTable

        Dim oDatos As Datos.Categorias
        Dim Tabla As DataTable

        Try
            oDatos = New Datos.Categorias()

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
    ''' Inserta una nueva Categoría en la base de datos.
    ''' </summary>
    ''' <param name="obj">Un objeto del tipo Categoría</param>
    ''' <returns></returns>
    Public Function Insertar(obj As Entidades.Categoria) As Boolean

        Dim oDatos As Datos.Categorias

        Try
            oDatos = New Datos.Categorias
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
    ''' Actualiza la información de una Categoría en la base de datos.
    ''' </summary>
    ''' <param name="obj">Un objeto del tipo Categoría</param>
    ''' <returns></returns>
    Public Function Actualizar(obj As Entidades.Categoria) As Boolean

        Dim oDatos As Datos.Categorias

        Try
            oDatos = New Datos.Categorias
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
    ''' Elimina una Categoría de la base de datos.
    ''' </summary>
    ''' <param name="ID">El ID de la Categoría</param>
    ''' <returns></returns>
    Public Function Eliminar(ID As Integer) As Boolean

        Dim oDatos As Datos.Categorias

        Try
            oDatos = New Datos.Categorias
            oDatos.Eliminar(ID)

            Return True
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            oDatos = Nothing
        End Try
    End Function
End Class
