Public Class KeyVal

    Public Sub New(ByVal key As String, ByVal val As String)
        KeyName = key
        Value = val
    End Sub

    Private _keyName As String
    Public Property KeyName() As String
        Get
            Return _keyName
        End Get
        Set(ByVal value As String)
            _keyName = value
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


End Class
