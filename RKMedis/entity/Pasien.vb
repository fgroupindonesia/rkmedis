Imports System.Data.SQLite

Public Class Pasien

    Dim columns As String
    Dim allColumns As New ArrayList

    Public Sub New()
        allColumns.Add(New ColumnType("@no_medrek", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@status", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@tgl_buat", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@nama", SqlDbType.VarChar))

        allColumns.Add(New ColumnType("@tgl_lahir", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@tempat_lahir", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@kelamin", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@alamat", SqlDbType.VarChar))

        allColumns.Add(New ColumnType("@telp", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@total_kunjungan", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@catatan", SqlDbType.VarChar))


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

    Sub setParameter(ByVal asqlCommand As SQLiteCommand)

        asqlCommand.Parameters.Add("@no_medrek", SqlDbType.VarChar).Value = NoMedrek

    End Sub

    Function getAllColumnTypes() As ArrayList
        Return allColumns
    End Function

    Function getNoMedRekColumnSet() As String
        columns = "no_medrek=@no_medrek"
        Return columns
    End Function

    Function getAllValuesInsert() As String
        ' the ordering is fixed based on SQLite structures
        Return "null, @no_medrek, @status, @tgl_buat, @nama, @tgl_lahir, @tempat_lahir, @kelamin, @alamat, @telp, @total_kunjungan, @catatan"
     
    End Function

    Function getAllColumnsSet() As String
        columns = "no_medrek=@no_medrek" & _
           ",status=@status" & _
           ",tgl_buat=@tgl_buat" & _
           ",nama=@nama" & _
        ",tgl_lahir=@tgl_lahir" & _
        ",tempat_lahir=@tempat_lahir" & _
        ",kelamin=@kelamin" & _
        ",alamat=@alamat" & _
        ",telp=@telp" & _
        ",total_kunjungan=@total_kunjungan" & _
        ",catatan=@catatan"

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

    Private _medrek As String
    Public Property NoMedrek() As String
        Get
            Return _medrek
        End Get
        Set(ByVal value As String)
            _medrek = value
            addValuesIntoColumn(New KeyVal("@no_medrek", value))
        End Set
    End Property

    Private _catatan As String
    Public Property Catatan() As String
        Get
            Return _catatan
        End Get
        Set(ByVal value As String)
            _catatan = value
            addValuesIntoColumn(New KeyVal("@catatan", value))
        End Set
    End Property

    Private _status As String
    Public Property Status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
            addValuesIntoColumn(New KeyVal("@status", value))
        End Set
    End Property


    Private _tglBuat As String
    Public Property TanggalBuat() As String
        Get
            Return _tglBuat
        End Get
        Set(ByVal value As String)
            _tglBuat = value
            addValuesIntoColumn(New KeyVal("@tgl_buat", value))
        End Set
    End Property

    Private _tglLahir As String
    Public Property TanggalLahir() As String
        Get
            Return _tglLahir
        End Get
        Set(ByVal value As String)
            _tglLahir = value
            addValuesIntoColumn(New KeyVal("@tgl_lahir", value))
        End Set
    End Property

    Private _totalKunjungan As Integer
    Public Property TotalKunjungan() As Integer
        Get
            Return _totalKunjungan
        End Get
        Set(ByVal value As Integer)
            _totalKunjungan = value
            addValuesIntoColumn(New KeyVal("@total_kunjungan", value))
        End Set
    End Property


    Private _telp As String
    Public Property Telp() As String
        Get
            Return _telp
        End Get
        Set(ByVal value As String)
            _telp = value
            addValuesIntoColumn(New KeyVal("@telp", value))
        End Set
    End Property


    Private _alamat As String
    Public Property Alamat() As String
        Get
            Return _alamat
        End Get
        Set(ByVal value As String)
            _alamat = value
            addValuesIntoColumn(New KeyVal("@alamat", value))
        End Set
    End Property


    Private _kelamin As String
    Public Property Kelamin() As String
        Get
            Return _kelamin
        End Get
        Set(ByVal value As String)
            _kelamin = value
            addValuesIntoColumn(New KeyVal("@kelamin", value))
        End Set
    End Property


    Private _tempatLahir As String
    Public Property TempatLahir() As String
        Get
            Return _tempatLahir
        End Get
        Set(ByVal value As String)
            _tempatLahir = value
            addValuesIntoColumn(New KeyVal("@tempat_lahir", value))
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
