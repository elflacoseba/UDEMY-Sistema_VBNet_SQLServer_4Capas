Imports System.Data.SqlClient

Public Class Conexion
    Private _BaseDeDatos As String
    Private _Servidor As String
    Private _Usuario As String
    Private _Clave As String
    Private _Seguridad As Boolean
    Public Cnn As SqlConnection

    Public Sub New()
        'Trabajeré con la autenticación de Windows.
        Me.Seguridad = True

        Me.BaseDeDatos = "CompraVentaDB"
        Me.Servidor = "PCFLACO\SQLEXPRESS"
        Me.Usuario = "sa"
        Me.Clave = "flaco1022"
        Me.Cnn = New SqlConnection(CrearCadena())

    End Sub

    Public Property BaseDeDatos As String
        Get
            Return _BaseDeDatos
        End Get
        Set(value As String)
            _BaseDeDatos = value
        End Set
    End Property

    Public Property Servidor As String
        Get
            Return _Servidor
        End Get
        Set(value As String)
            _Servidor = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _Usuario
        End Get
        Set(value As String)
            _Usuario = value
        End Set
    End Property

    Public Property Clave As String
        Get
            Return _Clave
        End Get
        Set(value As String)
            _Clave = value
        End Set
    End Property

    Public Property Seguridad As Boolean
        Get
            Return _Seguridad
        End Get
        Set(value As Boolean)
            _Seguridad = value
        End Set
    End Property

    ''' <summary>
    ''' Crea y devuelve la cadena de conexión.
    ''' </summary>
    ''' <returns></returns>
    Public Function CrearCadena() As String
        Dim cadena As String

        cadena = "Server=" & Me.Servidor & "; Database=" & Me.BaseDeDatos & ";"

        If Me.Seguridad Then
            cadena &= "Integrated Segurity=SSPI"
        Else
            cadena &= cadena & "User Id=" & Me.Usuario & "; Password=" & Me.Clave
        End If

        Return cadena
    End Function

End Class
