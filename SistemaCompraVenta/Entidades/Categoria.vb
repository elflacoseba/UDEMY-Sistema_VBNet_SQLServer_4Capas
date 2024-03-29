﻿Public Class Categoria

    ''' <summary>
    ''' Enumerable que indica los tipos de Estado de las Categorías.
    ''' </summary>
    Public Enum EstadoListarCategorias
        Todas
        Activas
        Inactivas
    End Enum

#Region "Campos"

    Private _CategoriaID As Integer
    Private _Nombre As String
    Private _Descripcion As String
    Private _Estado As Boolean

#End Region

#Region "Propiedades"

    Public Property CategoriaID As Integer
        Get
            Return _CategoriaID
        End Get
        Set(value As Integer)
            _CategoriaID = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _Estado
        End Get
        Set(value As Boolean)
            _Estado = value
        End Set
    End Property

#End Region

End Class
