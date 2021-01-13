Imports System.Data.SQLite

Module DBOperation

    Dim connectionString As String = "URI=file:" & ProgramPath.ApplicationDBLocation
    Dim con As SQLiteConnection

    Function Varchar(ByVal anParameter As String) As String
        Return "'" & anParameter & "'"
    End Function

    Private Function connection() As SQLiteConnection
        Return con
    End Function

    Public Sub refreshDBLocation()
        connectionString = "URI=file:" & ProgramPath.ApplicationDBLocation
    End Sub

    Sub test()
        Dim con As SQLiteConnection
        Dim cmd As SQLiteCommand

        Try
            Dim cs As String = "Data Source=:memory:"
            con = New SQLiteConnection(cs)
            con.Open()

            Dim stm As String = "SELECT SQLITE_VERSION()"
            cmd = New SQLiteCommand(stm, con)

            Dim version As String = Convert.ToString(cmd.ExecuteScalar())

            MsgBox("SQLite version : " & version)

        Catch ex As SQLiteException
            MsgBox("Something " & ex.Message)
        End Try

    End Sub

    Sub connect()

        If (con IsNot Nothing) Then
            disconnect()
        End If

        con = New SQLiteConnection(connectionString)
        con.Open()

    End Sub

    Sub disconnect()

        If (con IsNot Nothing) Then
            con.Close()
        End If

    End Sub

    Function getAllDataCount() As Integer
       

        Dim aSQLString As String = "SELECT COUNT(*) FROM "
        Dim namaTables As String() = {"dokter", "history_pinjam", "kunjungan", "pasien", "penyimpanan", "petugas", "poliklinik", "users"}

        Dim nilai As Integer = 0

        For Each namaTable As String In namaTables
            connect()

            Using aSQLCommand As New SQLiteCommand()
                aSQLCommand.Connection = connection()
                aSQLCommand.CommandText = aSQLString & namaTable

                Dim aReader As SQLiteDataReader = aSQLCommand.ExecuteReader()

                Using aReader
                    While aReader.Read()
                        nilai += aReader(0)
                    End While
                End Using

            End Using

            disconnect()
        Next

        Return nilai
    End Function

    Function UpdateUser(ByVal obVal As Users)
        Dim stat As Boolean = False

        Dim kolomSet As String = obVal.getAllColumnsSet()
        Dim kolomKondisi As String = obVal.getUsernameColumnWithValue()

        Dim aSQLString As String = "UPDATE users SET " & kolomSet & " WHERE " & kolomKondisi

        connect()

        Using aSQLCommand As New SQLiteCommand()
            aSQLCommand.Connection = connection()
            aSQLCommand.CommandText = aSQLString
            aSQLCommand.Prepare()

            ' this is depend upon the parameter (preparedParameter) inside User Class Column
            aSQLCommand.Parameters.Add("@logo", DbType.Binary, obVal.Logo.Length)
            aSQLCommand.Parameters("@logo").Value = obVal.Logo

            aSQLCommand.ExecuteNonQuery()
            stat = True
        End Using

        disconnect()

        Return stat
    End Function

    Function SavePetugas(ByVal obVal As Petugas) As Boolean
        Dim stat As Boolean = False

        Dim kolomSet = obVal.getAllValuesInsert()

        Dim aSQLString As String = "INSERT INTO petugas VALUES(" & kolomSet & ")"

        connect()

        Using aSQLCommand As New SQLiteCommand(aSQLString)
            aSQLCommand.Connection = connection()

            obVal.setParameters(aSQLCommand)

            aSQLCommand.Prepare()

            aSQLCommand.ExecuteNonQuery()
            stat = True
        End Using

        disconnect()

        Return stat
    End Function

    Function UpdatePetugas(ByVal obVal As Petugas) As Boolean
        Dim stat As Boolean = False

        Dim kolomSet As String = obVal.getAllColumnsSet()
        Dim kolomKondisi As String = obVal.getIDColumnWithValue()

        Dim aSQLString As String = "UPDATE petugas SET " & kolomSet & " WHERE " & kolomKondisi

        connect()

        Using aSQLCommand As New SQLiteCommand(aSQLString)
            aSQLCommand.Connection = connection()

            obVal.setParameters(aSQLCommand)

            aSQLCommand.ExecuteNonQuery()
            stat = True
        End Using

        disconnect()

        Return stat
    End Function

    Function DeletePetugas(ByVal obVal As Petugas) As Boolean
        Dim stat As Boolean = False

        Dim kolomKondisi As String = obVal.getIDColumnWithValue()

        Dim aSQLString As String = "DELETE FROM petugas WHERE " & kolomKondisi

        connect()

        Using aSQLCommand As New SQLiteCommand()
            aSQLCommand.Connection = connection()
            aSQLCommand.CommandText = aSQLString

            aSQLCommand.ExecuteNonQuery()
            stat = True
        End Using

        disconnect()

        Return stat
    End Function

   

    Function GetAllPetugas(Optional nameOnly As Boolean = False) As ArrayList
        Dim aList As New ArrayList

        Dim satuOrang As New Petugas()


        Dim aSQLString As String = "SELECT * FROM petugas"

        connect()

        Using aSQLCommand As New SQLiteCommand()
            aSQLCommand.Connection = connection()
            aSQLCommand.CommandText = aSQLString

            Dim aReader As SQLiteDataReader = aSQLCommand.ExecuteReader()

            Using aReader
                While aReader.Read()
                    satuOrang.ID = aReader("id")
                    satuOrang.Jabatan = aReader("jabatan")
                    satuOrang.Nama = aReader("nama")
                    satuOrang.NIP = aReader("nip")
                    satuOrang.Telp = aReader("telp")

                    If (nameOnly = True) Then
                        aList.Add(satuOrang.Nama)
                    Else
                        aList.Add(satuOrang)
                    End If

                    satuOrang = New Petugas()
                End While
            End Using

        End Using

        disconnect()

        Return aList
    End Function

    Function GetAllDokter(Optional nameOnly As Boolean = False) As ArrayList
        Dim aList As New ArrayList

        Dim satuOrang As New Dokter()


        Dim aSQLString As String = "SELECT * FROM dokter"

        connect()

        Using aSQLCommand As New SQLiteCommand()
            aSQLCommand.Connection = connection()
            aSQLCommand.CommandText = aSQLString

            Dim aReader As SQLiteDataReader = aSQLCommand.ExecuteReader()

            Using aReader
                While aReader.Read()
                    satuOrang.ID = aReader("id")
                    satuOrang.Kode = aReader("kode")
                    satuOrang.Nama = aReader("nama")
                    satuOrang.NIP = aReader("nip")
                    satuOrang.Spesialis = aReader("spesialis")

                    If (nameOnly = True) Then
                        aList.Add(satuOrang.Nama)
                    Else
                        aList.Add(satuOrang)
                    End If

                    satuOrang = New Dokter()
                End While
            End Using

        End Using

        disconnect()

        Return aList
    End Function

    Function DeleteDokter(ByVal obVal As Dokter) As Boolean
        Dim stat As Boolean = False

        Dim kolomKondisi As String = obVal.getIDColumnWithValue()

        Dim aSQLString As String = "DELETE FROM dokter WHERE " & kolomKondisi

        connect()

        Using aSQLCommand As New SQLiteCommand()
            aSQLCommand.Connection = connection()
            aSQLCommand.CommandText = aSQLString

            aSQLCommand.ExecuteNonQuery()
            stat = True
        End Using

        disconnect()

        Return stat
    End Function

    Function UpdateDokter(ByVal obVal As Dokter) As Boolean
        Dim stat As Boolean = False

        Dim kolomSet As String = obVal.getAllColumnsSet()
        Dim kolomKondisi As String = obVal.getIDColumnWithValue()

        Dim aSQLString As String = "UPDATE dokter SET " & kolomSet & " WHERE " & kolomKondisi

        connect()

        Using aSQLCommand As New SQLiteCommand(aSQLString)
            aSQLCommand.Connection = connection()

            obVal.setParameters(aSQLCommand)

            aSQLCommand.ExecuteNonQuery()
            stat = True
        End Using

        disconnect()

        Return stat
    End Function

    Function SaveDokter(ByVal obVal As Dokter) As Boolean
        Dim stat As Boolean = False

        Dim kolomSet = obVal.getAllValuesInsert()

        Dim aSQLString As String = "INSERT INTO dokter VALUES(" & kolomSet & ")"

        connect()

        Using aSQLCommand As New SQLiteCommand(aSQLString)
            aSQLCommand.Connection = connection()

            obVal.setParameters(aSQLCommand)

            aSQLCommand.Prepare()

            aSQLCommand.ExecuteNonQuery()
            stat = True
        End Using

        disconnect()

        Return stat
    End Function


    Function DeletePoliklinik(ByVal obVal As Poliklinik) As Boolean
        Dim stat As Boolean = False

        Dim kolomKondisi As String = obVal.getIDColumnWithValue()

        Dim aSQLString As String = "DELETE FROM poliklinik WHERE " & kolomKondisi

        connect()

        Using aSQLCommand As New SQLiteCommand()
            aSQLCommand.Connection = connection()
            aSQLCommand.CommandText = aSQLString

            aSQLCommand.ExecuteNonQuery()
            stat = True
        End Using

        disconnect()

        Return stat
    End Function

    Function GetAllPoliklinik(Optional namaUnitonly As Boolean = False) As ArrayList
        Dim aList As New ArrayList

        Dim satuPoli As New Poliklinik()

        Dim aSQLString As String = "SELECT * FROM poliklinik"

        connect()

        Using aSQLCommand As New SQLiteCommand()
            aSQLCommand.Connection = connection()
            aSQLCommand.CommandText = aSQLString

            Dim aReader As SQLiteDataReader = aSQLCommand.ExecuteReader()

            Using aReader
                While aReader.Read()
                    satuPoli.ID = aReader("id")
                    satuPoli.UnitPoliklinik = aReader("unit")
                    satuPoli.NamaDokter = aReader("dokter")
                    satuPoli.NamaPetugas = aReader("nama_petugas")

                    If (namaUnitonly = True) Then
                        aList.Add(satuPoli.UnitPoliklinik)
                    Else
                        aList.Add(satuPoli)
                    End If

                    satuPoli = New Poliklinik()
                End While
            End Using

        End Using

        disconnect()

        Return aList
    End Function

    Function SavePoliklinik(ByVal obVal As Poliklinik) As Boolean
        Dim stat As Boolean = False

        Dim kolomSet = obVal.getAllValuesInsert()

        Dim aSQLString As String = "INSERT INTO poliklinik VALUES(" & kolomSet & ")"

        connect()

        Using aSQLCommand As New SQLiteCommand(aSQLString)
            aSQLCommand.Connection = connection()

            obVal.setParameters(aSQLCommand)

            aSQLCommand.Prepare()

            aSQLCommand.ExecuteNonQuery()
            stat = True
        End Using

        disconnect()

        Return stat
    End Function

    Function UpdatePoliklinik(ByVal obVal As Poliklinik) As Boolean
        Dim stat As Boolean = False

        Dim kolomSet As String = obVal.getAllColumnsSet()
        Dim kolomKondisi As String = obVal.getIDColumnWithValue()

        Dim aSQLString As String = "UPDATE poliklinik SET " & kolomSet & " WHERE " & kolomKondisi

        connect()

        Using aSQLCommand As New SQLiteCommand(aSQLString)
            aSQLCommand.Connection = connection()

            obVal.setParameters(aSQLCommand)

            aSQLCommand.ExecuteNonQuery()
            stat = True
        End Using

        disconnect()

        Return stat
    End Function


    ' pasien here
    Function DeletePasien(ByVal obVal As Pasien) As Boolean
        Dim stat As Boolean = False

        Dim kolomKondisi As String = obVal.getIDColumnWithValue()

        Dim aSQLString As String = "DELETE FROM pasien WHERE " & kolomKondisi

        connect()

        Using aSQLCommand As New SQLiteCommand()
            aSQLCommand.Connection = connection()
            aSQLCommand.CommandText = aSQLString

            aSQLCommand.ExecuteNonQuery()
            stat = True
        End Using

        disconnect()

        Return stat
    End Function

    Function UpdatePasien(ByVal obVal As Pasien) As Boolean
        Dim stat As Boolean = False

        Dim kolomSet As String = obVal.getAllColumnsSet()
        Dim kolomKondisi As String = obVal.getIDColumnWithValue()

        Dim aSQLString As String = "UPDATE pasien SET " & kolomSet & " WHERE " & kolomKondisi

        connect()

        Using aSQLCommand As New SQLiteCommand(aSQLString)
            aSQLCommand.Connection = connection()

            obVal.setParameters(aSQLCommand)

            aSQLCommand.ExecuteNonQuery()
            stat = True
        End Using

        disconnect()

        Return stat
    End Function

    Function SavePasien(ByVal obVal As Pasien) As Boolean
        Dim stat As Boolean = False

        Dim kolomSet = obVal.getAllValuesInsert()

        Dim aSQLString As String = "INSERT INTO pasien VALUES(" & kolomSet & ")"

        connect()

        Using aSQLCommand As New SQLiteCommand(aSQLString)
            aSQLCommand.Connection = connection()

            obVal.setParameters(aSQLCommand)

            aSQLCommand.Prepare()

            aSQLCommand.ExecuteNonQuery()
            stat = True
        End Using

        disconnect()

        Return stat
    End Function

    Function getAllPasienCount() As Integer

        Dim aSQLString As String = "SELECT COUNT(*) FROM pasien"

        Dim nilai As Integer = 0

        connect()

        Using aSQLCommand As New SQLiteCommand()
            aSQLCommand.Connection = connection()
            aSQLCommand.CommandText = aSQLString

            Dim aReader As SQLiteDataReader = aSQLCommand.ExecuteReader()

            Using aReader
                While aReader.Read()
                    nilai += aReader(0)
                End While
            End Using

        End Using

        disconnect()


        Return nilai
    End Function

    Function GetAllPasienForPaging(ByVal whichPageNow As Integer) As ArrayList
        Dim aList As New ArrayList
        Dim manyItem As Integer = GUIHelper.getItemPerPaging()
        Dim pageNow As Integer
        Dim indexMulai As Integer

        If (whichPageNow > 0) Then
            pageNow = whichPageNow
        Else
            pageNow = 1
        End If

        If (pageNow > 1) Then
            indexMulai = (pageNow * manyItem) - manyItem
        Else
            indexMulai = 0
        End If

        Dim satuData As New Pasien()

        Dim aSQLString As String = "SELECT * FROM pasien LIMIT @indexMulai, @showMany"

        aSQLString = aSQLString.Replace("@indexMulai", indexMulai).Replace("@showMany", manyItem)

        connect()

        Using aSQLCommand As New SQLiteCommand()
            aSQLCommand.Connection = connection()
            aSQLCommand.CommandText = aSQLString

            Dim aReader As SQLiteDataReader = aSQLCommand.ExecuteReader()

            Using aReader
                While aReader.Read()
                    satuData.ID = aReader("id")
                    satuData.NoMedrek = aReader("no_medrek")
                    satuData.Status = aReader("status")
                    satuData.TanggalBuat = aReader("tgl_buat")
                    satuData.Nama = aReader("nama")
                    satuData.TanggalLahir = aReader("tgl_lahir")
                    satuData.TempatLahir = aReader("tempat_lahir")
                    satuData.Kelamin = aReader("kelamin")
                    satuData.Alamat = aReader("alamat")
                    satuData.Telp = aReader("telp")
                    satuData.TotalKunjungan = aReader("total_kunjungan")
                    satuData.Catatan = aReader("catatan")

                    aList.Add(satuData)
                    satuData = New Pasien()
                End While
            End Using

        End Using

        disconnect()

        Return aList
    End Function

    Function GetAllPasien() As ArrayList
        Dim aList As New ArrayList

        Dim satuData As New Pasien()

        Dim aSQLString As String = "SELECT * FROM pasien"

        connect()

        Using aSQLCommand As New SQLiteCommand()
            aSQLCommand.Connection = connection()
            aSQLCommand.CommandText = aSQLString

            Dim aReader As SQLiteDataReader = aSQLCommand.ExecuteReader()

            Using aReader
                While aReader.Read()
                    satuData.ID = aReader("id")
                    satuData.NoMedrek = aReader("no_medrek")
                    satuData.Status = aReader("status")
                    satuData.TanggalBuat = aReader("tgl_buat")
                    satuData.Nama = aReader("nama")
                    satuData.TanggalLahir = aReader("tgl_lahir")
                    satuData.TempatLahir = aReader("tempat_lahir")
                    satuData.Kelamin = aReader("kelamin")
                    satuData.Alamat = aReader("alamat")
                    satuData.Telp = aReader("telp")
                    satuData.TotalKunjungan = aReader("total_kunjungan")
                    satuData.Catatan = aReader("catatan")

                    aList.Add(satuData)
                    satuData = New Pasien()
                End While
            End Using

        End Using

        disconnect()

        Return aList
    End Function

    Function GetPasien(ByVal noMedRek As String) As Pasien

        Dim satuData As New Pasien
        satuData.NoMedrek = noMedRek

        Dim aSQLString As String = "SELECT * FROM pasien WHERE " & satuData.getNoMedRekColumnSet()
        connect()

        Using aSQLCommand As New SQLiteCommand(aSQLString)
            aSQLCommand.Connection = connection()

            satuData.setParameter(aSQLCommand)

            Dim aReader As SQLiteDataReader = aSQLCommand.ExecuteReader()

            Using aReader
                While aReader.Read()
                    satuData.ID = aReader("id")
                    satuData.NoMedrek = aReader("no_medrek")
                    satuData.Status = aReader("status")
                    satuData.TanggalBuat = aReader("tgl_buat")
                    satuData.Nama = aReader("nama")
                    satuData.TanggalLahir = aReader("tgl_lahir")
                    satuData.TempatLahir = aReader("tempat_lahir")
                    satuData.Kelamin = aReader("kelamin")
                    satuData.Alamat = aReader("alamat")
                    satuData.Telp = aReader("telp")
                    satuData.TotalKunjungan = aReader("total_kunjungan")

                End While
            End Using

        End Using

        disconnect()

        Return satuData
    End Function


    Function DeleteKunjungan(ByVal obVal As Kunjungan) As Boolean
        Dim stat As Boolean = False

        Dim kolomKondisi As String = obVal.getIDColumnWithValue()

        Dim aSQLString As String = "DELETE FROM kunjungan WHERE " & kolomKondisi

        connect()

        Using aSQLCommand As New SQLiteCommand()
            aSQLCommand.Connection = connection()
            aSQLCommand.CommandText = aSQLString

            aSQLCommand.ExecuteNonQuery()
            stat = True
        End Using

        disconnect()

        Return stat
    End Function

    Function GetAllKunjunganForPaging(ByVal whichPageNow As Integer) As ArrayList
        Dim aList As New ArrayList
        Dim manyItem As Integer = GUIHelper.getItemPerPaging()
        Dim pageNow As Integer
        Dim indexMulai As Integer

        If (whichPageNow > 0) Then
            pageNow = whichPageNow
        Else
            pageNow = 1
        End If

        If (pageNow > 1) Then
            indexMulai = (pageNow * manyItem) - manyItem
        Else
            indexMulai = 0
        End If

        Dim satuData As New Kunjungan()

        Dim aSQLString As String = "SELECT * FROM kunjungan LIMIT @indexMulai, @showMany"

        aSQLString = aSQLString.Replace("@indexMulai", indexMulai).Replace("@showMany", manyItem)

        connect()

        Using aSQLCommand As New SQLiteCommand()
            aSQLCommand.Connection = connection()
            aSQLCommand.CommandText = aSQLString

            Dim aReader As SQLiteDataReader = aSQLCommand.ExecuteReader()

            Using aReader
                While aReader.Read()
                    satuData.ID = aReader("id")
                    satuData.NoMedrek = aReader("no_medrek")
                    satuData.TanggalKunjungan = aReader("tgl_kunjungan")
                    satuData.NamaPasien = aReader("nama")
                    satuData.IDPasien = aReader("id_pasien")
                    satuData.Keluhan = aReader("keluhan")
                    satuData.Diagnosa = aReader("diagnosa")
                    satuData.TekananDarah = aReader("tekanan_darah")
                    satuData.BeratBadan = aReader("berat_badan")
                    satuData.Tindakan = aReader("tindakan")
                    satuData.KunjunganLagi = aReader("kunjungan_lagi")
                    satuData.Visite = aReader("visite")

                    aList.Add(satuData)
                    satuData = New Kunjungan()
                End While
            End Using

        End Using

        disconnect()

        Return aList
    End Function

    Function getAllKunjunganCount() As Integer

        Dim aSQLString As String = "SELECT COUNT(*) FROM kunjungan"

        Dim nilai As Integer = 0

        connect()

        Using aSQLCommand As New SQLiteCommand()
            aSQLCommand.Connection = connection()
            aSQLCommand.CommandText = aSQLString

            Dim aReader As SQLiteDataReader = aSQLCommand.ExecuteReader()

            Using aReader
                While aReader.Read()
                    nilai += aReader(0)
                End While
            End Using

        End Using

        disconnect()


        Return nilai
    End Function

    Function getAllKunjunganCount(ByVal anomedrek As String) As Integer

        Dim aSQLString As String = "SELECT COUNT(*) FROM kunjungan WHERE no_medrek=@no_medrek"

        Dim nilai As Integer = 0

        connect()

        Using aSQLCommand As New SQLiteCommand()
            aSQLCommand.Connection = connection()
            aSQLCommand.CommandText = aSQLString

            aSQLCommand.Prepare()
            aSQLCommand.Parameters.AddWithValue("@no_medrek", anomedrek)

            Dim aReader As SQLiteDataReader = aSQLCommand.ExecuteReader()

            Using aReader
                While aReader.Read()
                    nilai += aReader(0)
                End While
            End Using

        End Using

        disconnect()


        Return nilai
    End Function

    Function GetAllKunjungan() As ArrayList
        Dim aList As New ArrayList

        Dim satuData As New Kunjungan()

        Dim aSQLString As String = "SELECT * FROM kunjungan"

        connect()

        Using aSQLCommand As New SQLiteCommand()
            aSQLCommand.Connection = connection()
            aSQLCommand.CommandText = aSQLString

            Dim aReader As SQLiteDataReader = aSQLCommand.ExecuteReader()

            Using aReader
                While aReader.Read()
                    satuData.ID = aReader("id")
                    satuData.NoMedRek = aReader("no_medrek")
                    satuData.TanggalKunjungan = aReader("tgl_kunjungan")
                    satuData.NamaPasien = aReader("nama")
                    satuData.IDPasien = aReader("id_pasien")
                    satuData.Keluhan = aReader("keluhan")
                    satuData.Diagnosa = aReader("diagnosa")
                    satuData.TekananDarah = aReader("tekanan_darah")
                    satuData.BeratBadan = aReader("berat_badan")
                    satuData.Tindakan = aReader("tindakan")
                    satuData.KunjunganLagi = aReader("kunjungan_lagi")
                    satuData.Visite = aReader("visite")

                    aList.Add(satuData)
                    satuData = New Kunjungan()
                End While
            End Using

        End Using

        disconnect()

        Return aList
    End Function

    Function SaveKunjungan(ByVal obVal As Kunjungan) As Boolean
        Dim stat As Boolean = False

        Dim kolomSet = obVal.getAllValuesInsert()

        Dim aSQLString As String = "INSERT INTO kunjungan VALUES(" & kolomSet & ")"

        connect()

        Using aSQLCommand As New SQLiteCommand(aSQLString)
            aSQLCommand.Connection = connection()

            obVal.setParameters(aSQLCommand)

            aSQLCommand.Prepare()

            aSQLCommand.ExecuteNonQuery()
            stat = True
        End Using

        disconnect()

        Return stat
    End Function

    Function UpdateKunjungan(ByVal obVal As Kunjungan) As Boolean
        Dim stat As Boolean = False

        Dim kolomSet As String = obVal.getAllColumnsSet()
        Dim kolomKondisi As String = obVal.getIDColumnWithValue()

        Dim aSQLString As String = "UPDATE kunjungan SET " & kolomSet & " WHERE " & kolomKondisi

        connect()

        Using aSQLCommand As New SQLiteCommand(aSQLString)
            aSQLCommand.Connection = connection()

            obVal.setParameters(aSQLCommand)

            aSQLCommand.ExecuteNonQuery()
            stat = True
        End Using

        disconnect()

        Return stat
    End Function

    Function UpdateKunjunganPasien(ByVal nomedrek As String) As Boolean
        Dim stat As Boolean = False

        Dim totalKunjunganTerakhir As Integer = DBOperation.getAllKunjunganCount(nomedrek)

        Dim aSQLString As String = "UPDATE pasien SET total_kunjungan=@total WHERE no_medrek=@no_medrek"

        connect()

        '  Dim tr As SQLiteTransaction

        Using aSQLCommand As New SQLiteCommand(aSQLString)
            aSQLCommand.Connection = connection()

            '  tr = aSQLCommand.Connection.BeginTransaction
            'aSQLCommand.Transaction = tr

            aSQLCommand.Prepare()
            aSQLCommand.Parameters.AddWithValue("@total", totalKunjunganTerakhir)
            aSQLCommand.Parameters.AddWithValue("@no_medrek", nomedrek)

            aSQLCommand.ExecuteNonQuery()

            ' tr.Commit()
            stat = True
        End Using

        disconnect()

        Return stat
    End Function

End Module
