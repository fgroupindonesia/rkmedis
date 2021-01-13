Public Class ColumnType

    Public Sub New(ByVal aName As String, ByVal aType As SqlDbType)
        Name = aName
        Type = aType
    End Sub

    Private _type As SqlDbType
    Public Property Type() As SqlDbType
        Get
            Return _type
        End Get
        Set(ByVal value As SqlDbType)
            _type = value
        End Set
    End Property


    Private _value As String
    Public Property Value() As String
        Get
            Return _value
        End Get
        Set(ByVal value As String)
            _value = value
        End Set
    End Property


    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

End Class
