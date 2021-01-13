Imports System.Data.SQLite

Public Class Poliklinik

    Dim columns As String
    Dim allColumns As New ArrayList

    Public Sub New()
        allColumns.Add(New ColumnType("@dokter", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@unit", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@nama_petugas", SqlDbType.VarChar))

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


    Function getAllColumnsSet() As String
        columns = "dokter=@dokter" & _
           ",unit=@unit" & _
           ",nama_petugas=@nama_petugas"
        Return columns
    End Function

    Function getAllValuesInsert() As String
        ' the ordering is fixed based on SQLite structures
        Return "null, @unit, @dokter, @nama_petugas"
    End Function

    Private _namaDokter As String
    Public Property NamaDokter() As String
        Get
            Return _namaDokter
        End Get
        Set(ByVal value As String)
            _namaDokter = value
            addValuesIntoColumn(New KeyVal("@dokter", value))
        End Set
    End Property

    Private _unit As String
    Public Property UnitPoliklinik() As String
        Get
            Return _unit
        End Get
        Set(ByVal value As String)
            _unit = value
            addValuesIntoColumn(New KeyVal("@unit", value))
        End Set
    End Property


    Private _namaPetugas As String
    Public Property NamaPetugas() As String
        Get
            Return _namaPetugas
        End Get
        Set(ByVal value As String)
            _namaPetugas = value
            addValuesIntoColumn(New KeyVal("@nama_petugas", value))
        End Set
    End Property


    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property


End Class
