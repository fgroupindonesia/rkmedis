Imports System.Data.SQLite

Public Class Dokter

    Dim columns As String
    Dim allColumns As New ArrayList

    Public Sub New()
        allColumns.Add(New ColumnType("@nip", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@nama", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@kode", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@spesialis", SqlDbType.VarChar))
    End Sub

    Function getIDColumnWithValue() As String
        columns = "id=" & Me.ID
        Return columns
    End Function

    Sub addValuesIntoColumn(ByVal data As KeyVal)
        For Each col As ColumnType In allColumns
            If (col.Name = data.KeyName) Then
                col.Value = data.Value
            End If
        Next
    End Sub

    Sub setParameters(ByVal asqlCommand As SQLiteCommand)

        For Each column As ColumnType In allColumns
            asqlCommand.Parameters.Add(column.Name, column.Type).Value = column.Value
        Next
    End Sub

    Function getAllColumnTypes() As ArrayList
        Return allColumns
    End Function

    Function getAllValuesInsert() As String
        ' the ordering is fixed based on SQLite structures
        Return "null, @nip, @nama, @kode, @spesialis"
    End Function

    Function getAllColumnsSet() As String
        columns = "nip=@nip" & _
           ",nama=@nama" & _
           ",kode=@kode" & _
           ",spesialis=@spesialis"
        Return columns
    End Function


    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _spesialis As String
    Public Property Spesialis() As String
        Get
            Return _spesialis
        End Get
        Set(ByVal value As String)
            _spesialis = value
            addValuesIntoColumn(New KeyVal("@spesialis", value))
        End Set
    End Property


    Private _nip As String
    Public Property NIP() As String
        Get
            Return _nip
        End Get
        Set(ByVal value As String)
            _nip = value
            addValuesIntoColumn(New KeyVal("@nip", value))
        End Set
    End Property


    Private _kode As String
    Public Property Kode() As String
        Get
            Return _kode
        End Get
        Set(ByVal value As String)
            _kode = value
            addValuesIntoColumn(New KeyVal("@kode", value))
        End Set
    End Property


    Private _nama As String
    Public Property Nama() As String
        Get
            Return _nama
        End Get
        Set(ByVal value As String)
            _nama = value
            addValuesIntoColumn(New KeyVal("@nama", value))
        End Set
    End Property


End Class
