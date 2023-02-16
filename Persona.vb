Public Class Persona
    Protected nombre As String
    Protected fechaNacimiento As DateTime?
    Public Property NombreP As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property
    Public Property FechaNacimientoP As DateTime?
        Get
            Return fechaNacimiento
        End Get
        Set(ByVal value As DateTime?)
            fechaNacimiento = value
        End Set
    End Property
    Public ReadOnly Property EdadP As Integer
        Get
            Dim edad As Integer
            edad = (DateTime.Now.Year - fechaNacimiento.Value.Year)
            Return edad
        End Get
    End Property
    Public Sub New()
        nombre = String.Empty
        fechaNacimiento = Nothing
    End Sub
    Public Sub New(ByVal nombre As String, ByVal fechaNacimiento As DateTime?)
        Me.nombre = nombre
        Me.fechaNacimiento = fechaNacimiento
    End Sub
    Public Overrides Function ToString() As String
        Return nombre.ToUpper() & " " & EdadP
    End Function
End Class
