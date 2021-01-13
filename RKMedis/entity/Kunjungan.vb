Imports System.Data.SQLite

Public Class Kunjungan

    Dim columns As String
    Dim allColumns As New ArrayList

    Public Sub New()
        allColumns.Add(New ColumnType("@tgl_kunjungan", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@no_medrek", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@nama", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@id_pasien", SqlDbType.Int))
        allColumns.Add(New ColumnType("@keluhan", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@diagnosa", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@tekanan_darah", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@berat_badan", SqlDbType.Int))
        allColumns.Add(New ColumnType("@tindakan", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@visite", SqlDbType.VarChar))
        allColumns.Add(New ColumnType("@kunjungan_lagi", SqlDbType.VarChar))


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
        Return "null, @tgl_kunjungan, @no_medrek, @nama, @id_pasien, @keluhan, @diagnosa, @tekanan_darah, @berat_badan, @tindakan, @visite, @kunjungan_lagi"
    End Function

    Function getAllColumnsSet() As String
        columns = "tgl_kunjungan=@tgl_kunjungan" & _
           ",no_medrek=@no_medrek" & _
           ",nama=@nama" & _
           ",id_pasien=@id_pasien" & _
        ",keluhan=@keluhan" & _
        ",diagnosa=@diagnosa" & _
        ",tekanan_darah=@tekanan_darah" & _
        ",berat_badan=@berat_badan" & _
        ",tindakan=@tindakan" & _
        ",visite=@visite" & _
        ",kunjungan_lagi=@kunjungan_lagi"

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


    Private _kunjunganLagi As String
    Public Property KunjunganLagi() As String
        Get
            Return _kunjunganLagi
        End Get
        Set(ByVal value As String)
            _kunjunganLagi = value
            addValuesIntoColumn(New KeyVal("@kunjungan_lagi", value))
        End Set
    End Property

    Private _visite As String
    Public Property Visite() As String
        Get
            Return _visite
        End Get
        Set(ByVal value As String)
            _visite = value
            addValuesIntoColumn(New KeyVal("@visite", value))
        End Set
    End Property

    Private _tglKunjungan As String
    Public Property TanggalKunjungan() As String
        Get
            Return _tglKunjungan
        End Get
        Set(ByVal value As String)
            _tglKunjungan = value
            addValuesIntoColumn(New KeyVal("@tgl_kunjungan", value))
        End Set
    End Property


    Private _medRek As String
    Public Property NoMedRek() As String
        Get
            Return _medRek
        End Get
        Set(ByVal value As String)
            _medRek = value
            addValuesIntoColumn(New KeyVal("@no_medrek", value))
        End Set
    End Property


    Private _namaPasien As String
    Public Property NamaPasien() As String
        Get
            Return _namaPasien
        End Get
        Set(ByVal value As String)
            _namaPasien = value
            addValuesIntoColumn(New KeyVal("@nama", value))
        End Set
    End Property

    Private _idPasien As Integer
    Public Property IDPasien() As Integer
        Get
            Return _idPasien
        End Get
        Set(ByVal value As Integer)
            _idPasien = value
            addValuesIntoColumn(New KeyVal("@id_pasien", value))
        End Set
    End Property

    Private _keluhan As String
    Public Property Keluhan() As String
        Get
            Return _keluhan
        End Get
        Set(ByVal value As String)
            _keluhan = value
            addValuesIntoColumn(New KeyVal("@keluhan", value))
        End Set
    End Property

    Private _beratBadan As Integer
    Public Property BeratBadan() As Integer
        Get
            Return _beratBadan
        End Get
        Set(ByVal value As Integer)
            _beratBadan = value
            addValuesIntoColumn(New KeyVal("@berat_badan", value))
        End Set
    End Property

    Private _tindakan As String
    Public Property Tindakan() As String
        Get
            Return _tindakan
        End Get
        Set(ByVal value As String)
            _tindakan = value
            addValuesIntoColumn(New KeyVal("@tindakan", value))
        End Set
    End Property

    Private _tekananDarah As String
    Public Property TekananDarah() As String
        Get
            Return _tekananDarah
        End Get
        Set(ByVal value As String)
            _tekananDarah = value
            addValuesIntoColumn(New KeyVal("@tekanan_darah", value))
        End Set
    End Property

    Private _diagnosa As String
    Public Property Diagnosa() As String
        Get
            Return _diagnosa
        End Get
        Set(ByVal value As String)
            _diagnosa = value
            addValuesIntoColumn(New KeyVal("@diagnosa", value))
        End Set
    End Property

End Class
