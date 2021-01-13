Imports System.ComponentModel
Imports System.Threading
Imports System.Text

Module GUIHelper

    Dim BackgroundWorkerRef As BackgroundWorker
    Dim count As Double
    Dim progressCount As Double
    Dim manyData As Integer
    Dim loadingScreenFinished As Boolean = False

    Dim dataGridPasienRef As DataGridView
    Dim dataGridKunjunganRef As DataGridView

    Dim arrayLinkNavPasien As New ArrayList
    Dim arrayLinkNavKunjungan As New ArrayList

    Dim manyItem As Integer = 20

    Function getItemPerPaging() As Integer
        Return manyItem
    End Function

    Sub setBackgroundWorkerRef(ByVal aRef As BackgroundWorker)
        BackgroundWorkerRef = aRef
    End Sub

    Sub setProgressIntervalCount(ByVal anum As Double)
        progressCount = anum
    End Sub

    Sub setProgressWorkerStat(ByVal anum As Boolean)
        loadingScreenFinished = anum
    End Sub

    Sub setManyData(ByVal anum As Integer)
        manyData = anum
    End Sub

    Dim monthNamesID() As String = {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"}
    Dim monthNamesEN() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}


    Function whatDataLanguage(ByVal tanggalMasuk As String) As String

        Dim benarID, benarEN As Boolean
        Dim lang As String = ""
        Dim dataSatu As String = ""

        For index = 0 To monthNamesEN.Length - 1
            dataSatu = monthNamesEN(index)
            If (tanggalMasuk.Contains(dataSatu)) Then
                benarEN = True
                Exit For
            End If
        Next

        For index = 0 To monthNamesID.Length - 1
            dataSatu = monthNamesID(index)
            If (tanggalMasuk.Contains(dataSatu)) Then
                benarID = True
                Exit For
            End If
        Next

        If (benarEN = True) Then
            lang = "English"
        ElseIf (benarID = True) Then
            lang = "Indonesia"
        End If

        Return lang
    End Function


    Function getEnglishToIndonesiaDate(ByVal textMasuk As String) As String

        Dim text As String = ""
        Dim noIndex As Integer = 0

        For Each nama As String In monthNamesEN
            If (textMasuk.Contains(nama)) Then
                text = monthNamesID(noIndex)
                textMasuk = textMasuk.Replace(nama, text)
                Return textMasuk
            End If

            noIndex += 1
        Next

        Return text
    End Function

    Function getIndonesiaToEnglishDate(ByVal textMasuk As String) As String

        Dim text As String = ""
        Dim noIndex As Integer = 0

        For Each nama As String In monthNamesID
            If (textMasuk.Contains(nama)) Then
                text = monthNamesEN(noIndex)
                textMasuk = textMasuk.Replace(nama, text)
                Return textMasuk
            End If

            noIndex += 1
        Next

        Return text
    End Function

    Function isCultureCountryEnglish() As Boolean

        Dim benarEnglish As Boolean = False

        Select Case System.Globalization.CultureInfo.CurrentCulture.ToString
            Case "id", "id-ID"
                benarEnglish = False
            Case "en-GB", "en-US"
                benarEnglish = True
        End Select

        Return benarEnglish
    End Function


    Sub updateProgressBackgroundWorker()

        If (loadingScreenFinished = False) Then
            count = progressCount + count

            BackgroundWorkerRef.ReportProgress(count)

            If (manyData > 20) Then
                Thread.Sleep(50)
            ElseIf (manyData <= 20) Then
                Thread.Sleep(300)
            End If
        End If

        If (count >= 98) Then
            loadingScreenFinished = True

        End If

    End Sub

   


    Function getCheckedRowsTablePasien(ByVal aDataGridView As DataGridView) As ArrayList
        Dim aList As ArrayList = Nothing

        Dim aStat As Boolean
        Dim data As Pasien

        For Each satuBaris As DataGridViewRow In aDataGridView.Rows
            aStat = Convert.ToBoolean(satuBaris.Cells(0).Value)

            If (aStat = True) Then

                If (aList Is Nothing) Then
                    aList = New ArrayList
                End If

                data = New Pasien()

                data.ID = satuBaris.Cells(1).Value
                aList.Add(data)

            End If
        Next

        Return aList
    End Function

    Function getCheckedRowsTableKunjungan(ByVal aDataGridView As DataGridView) As ArrayList
        Dim aList As ArrayList = Nothing

        Dim aStat As Boolean
        Dim dataKunjungan As Kunjungan

        For Each satuBaris As DataGridViewRow In aDataGridView.Rows
            aStat = Convert.ToBoolean(satuBaris.Cells(0).Value)

            If (aStat = True) Then

                If (aList Is Nothing) Then
                    aList = New ArrayList
                End If

                dataKunjungan = New Kunjungan()

                dataKunjungan.ID = satuBaris.Cells(1).Value
                aList.Add(dataKunjungan)

            End If
        Next

        Return aList
    End Function

    Function getCheckedRowsTablePoliklinik(ByVal aDataGridView As DataGridView) As ArrayList
        Dim aList As ArrayList = Nothing

        Dim aStat As Boolean
        Dim dataPoli As Poliklinik

        For Each satuBaris As DataGridViewRow In aDataGridView.Rows
            aStat = Convert.ToBoolean(satuBaris.Cells(0).Value)

            If (aStat = True) Then

                If (aList Is Nothing) Then
                    aList = New ArrayList
                End If

                dataPoli = New Poliklinik()

                dataPoli.ID = satuBaris.Cells(1).Value
                aList.Add(dataPoli)

            End If
        Next

        Return aList
    End Function

    Function getCheckedRowsTablePetugas(ByVal aDataGridView As DataGridView) As ArrayList
        Dim aList As ArrayList = Nothing

        Dim aStat As Boolean
        Dim dataPetugas As Petugas

        For Each satuBaris As DataGridViewRow In aDataGridView.Rows
            aStat = Convert.ToBoolean(satuBaris.Cells(0).Value)

            If (aStat = True) Then

                If (aList Is Nothing) Then
                    aList = New ArrayList
                End If

                dataPetugas = New Petugas()

                dataPetugas.ID = satuBaris.Cells(1).Value
                aList.Add(dataPetugas)

            End If
        Next

        Return aList
    End Function

    Function getCheckedRowsTableDokter(ByVal aDataGridView As DataGridView) As ArrayList
        Dim aList As ArrayList = Nothing

        Dim aStat As Boolean
        Dim dataDokter As Dokter

        For Each satuBaris As DataGridViewRow In aDataGridView.Rows
            aStat = Convert.ToBoolean(satuBaris.Cells(0).Value)

            If (aStat = True) Then

                If (aList Is Nothing) Then
                    aList = New ArrayList
                End If

                dataDokter = New Dokter()

                dataDokter.ID = satuBaris.Cells(1).Value
                aList.Add(dataDokter)

            End If
        Next

        Return aList
    End Function

    Function getCheckedRowTablePasien(ByVal aDataGridView As DataGridView) As Pasien
        Dim aStat As Boolean
        Dim dataSatuPasien As Pasien = Nothing
        For Each satuBaris As DataGridViewRow In aDataGridView.Rows
            aStat = Convert.ToBoolean(satuBaris.Cells(0).Value)

            If (aStat = True) Then
                dataSatuPasien = New Pasien()
                dataSatuPasien.ID = satuBaris.Cells(1).Value
                dataSatuPasien.NoMedrek = satuBaris.Cells(2).Value
                dataSatuPasien.Status = satuBaris.Cells(3).Value
                dataSatuPasien.TanggalBuat = satuBaris.Cells(4).Value
                dataSatuPasien.Nama = satuBaris.Cells(5).Value
                dataSatuPasien.TanggalLahir = satuBaris.Cells(6).Value
                dataSatuPasien.TempatLahir = satuBaris.Cells(7).Value
                dataSatuPasien.Kelamin = satuBaris.Cells(8).Value
                dataSatuPasien.Alamat = satuBaris.Cells(9).Value
                dataSatuPasien.Telp = satuBaris.Cells(10).Value
                dataSatuPasien.TotalKunjungan = satuBaris.Cells(11).Value
                dataSatuPasien.Catatan = satuBaris.Cells(12).Value

                Exit For
            End If
        Next

        Return dataSatuPasien

    End Function

    Function getCheckedRowTablePetugas(ByVal aDataGridView As DataGridView) As Petugas
        Dim aStat As Boolean
        Dim dataSatuPetugas As Petugas = Nothing
        For Each satuBaris As DataGridViewRow In aDataGridView.Rows
            aStat = Convert.ToBoolean(satuBaris.Cells(0).Value)

            If (aStat = True) Then
                dataSatuPetugas = New Petugas()
                dataSatuPetugas.ID = satuBaris.Cells(1).Value
                dataSatuPetugas.NIP = satuBaris.Cells(2).Value
                dataSatuPetugas.Nama = satuBaris.Cells(3).Value
                dataSatuPetugas.Jabatan = satuBaris.Cells(4).Value
                dataSatuPetugas.Telp = satuBaris.Cells(5).Value

                Exit For
            End If
        Next

        Return dataSatuPetugas

    End Function

    Function getCheckedRowTableKunjungan(ByVal aDataGridView As DataGridView) As Kunjungan
        Dim aStat As Boolean
        Dim dataSatuKunjungan As Kunjungan = Nothing
        For Each satuBaris As DataGridViewRow In aDataGridView.Rows
            aStat = Convert.ToBoolean(satuBaris.Cells(0).Value)

            If (aStat = True) Then
                dataSatuKunjungan = New Kunjungan()
                dataSatuKunjungan.ID = satuBaris.Cells(1).Value
                dataSatuKunjungan.TanggalKunjungan = satuBaris.Cells(2).Value
                dataSatuKunjungan.NoMedRek = satuBaris.Cells(3).Value
                dataSatuKunjungan.NamaPasien = satuBaris.Cells(4).Value
                dataSatuKunjungan.Keluhan = satuBaris.Cells(5).Value
                dataSatuKunjungan.Diagnosa = satuBaris.Cells(6).Value
                dataSatuKunjungan.TekananDarah = satuBaris.Cells(7).Value
                dataSatuKunjungan.BeratBadan = satuBaris.Cells(8).Value
                dataSatuKunjungan.Tindakan = satuBaris.Cells(9).Value
                dataSatuKunjungan.Visite = satuBaris.Cells(10).Value
                dataSatuKunjungan.KunjunganLagi = satuBaris.Cells(11).Value


                Exit For
            End If
        Next

        Return dataSatuKunjungan

    End Function

    Function getCheckedRowTablePoliklinik(ByVal aDataGridView As DataGridView) As Poliklinik
        Dim aStat As Boolean
        Dim dataSatuPoli As Poliklinik = Nothing
        For Each satuBaris As DataGridViewRow In aDataGridView.Rows
            aStat = Convert.ToBoolean(satuBaris.Cells(0).Value)

            If (aStat = True) Then
                dataSatuPoli = New Poliklinik()
                dataSatuPoli.ID = satuBaris.Cells(1).Value
                dataSatuPoli.UnitPoliklinik = satuBaris.Cells(2).Value
                dataSatuPoli.NamaDokter = satuBaris.Cells(3).Value
                dataSatuPoli.NamaPetugas = satuBaris.Cells(4).Value


                Exit For
            End If
        Next

        Return dataSatuPoli

    End Function

    Function getCheckedRowTableDokter(ByVal aDataGridView As DataGridView) As Dokter
        Dim aStat As Boolean
        Dim dataSatuDokter As Dokter = Nothing
        For Each satuBaris As DataGridViewRow In aDataGridView.Rows
            aStat = Convert.ToBoolean(satuBaris.Cells(0).Value)

            If (aStat = True) Then
                dataSatuDokter = New Dokter()
                dataSatuDokter.ID = satuBaris.Cells(1).Value
                dataSatuDokter.NIP = satuBaris.Cells(2).Value
                dataSatuDokter.Nama = satuBaris.Cells(3).Value
                dataSatuDokter.Kode = satuBaris.Cells(4).Value
                dataSatuDokter.Spesialis = satuBaris.Cells(5).Value

                Exit For
            End If
        Next

        Return dataSatuDokter

    End Function

    Function extractNamaPetugas(ByVal aDataGridView As DataGridView) As String
        Dim nama As String = Nothing
        Dim builder As New StringBuilder

        For Each satuBaris As DataGridViewRow In aDataGridView.Rows
            nama = Convert.ToString(satuBaris.Cells(0).Value)
            builder.Append(nama)
            builder.Append(",")
        Next

        If (nama IsNot Nothing) Then
            'comma last character removal
            Return builder.Remove(builder.Length - 1, 1).ToString
        End If

        Return ""
    End Function


    Sub activateAllCheckboxesSelectedRowTable(ByVal aDataGrid As DataGridView)
        'ensuring there is no editable datagridview active
        aDataGrid.EndEdit()

        For Each aRow As DataGridViewRow In aDataGrid.SelectedRows
            aRow.Cells(0).Value = True
        Next

    End Sub

    Sub activateAllCheckboxesTable(ByVal aDataGrid As DataGridView)
        'ensuring there is no editable datagridview active
        aDataGrid.EndEdit()

        Dim stat As Boolean
        For Each aRow As DataGridViewRow In aDataGrid.Rows
            stat = Not Convert.ToBoolean(aRow.Cells(0).Value)
            aRow.Cells(0).Value = stat
        Next

    End Sub

    Function getDateFromString(ByVal tanggalText) As DateTime
        Try
            Return DateTime.ParseExact(tanggalText, "dd MMMM yyyy", System.Globalization.CultureInfo.InvariantCulture)
        Catch ex As Exception
            Return DateTime.ParseExact(tanggalText, "dd MMMM yyyy", Nothing)
        End Try

    End Function


    Sub renderTablePasien(ByVal dataAsList As ArrayList, ByVal aTable As DataGridView)



        aTable.Rows.Clear()

        For Each data As Pasien In dataAsList
            Dim row As Object() = New Object() {False, data.ID, data.NoMedrek, data.Status, getDateFromString(data.TanggalBuat), data.Nama, getDateFromString(data.TanggalLahir), data.TempatLahir, data.Kelamin, data.Alamat, data.Telp, data.TotalKunjungan, data.Catatan}
            DBOperation.UpdateKunjunganPasien(data.NoMedrek)
            aTable.Rows.Add(row)
            updateProgressBackgroundWorker()
        Next

        dataGridPasienRef = aTable

    End Sub

    Sub renderTableKunjungan(ByVal dataAsList As ArrayList, ByVal aTable As DataGridView)

        aTable.Rows.Clear()

        For Each satuKunjungan As Kunjungan In dataAsList
            Dim row As Object() = New Object() {False, satuKunjungan.ID, getDateFromString(satuKunjungan.TanggalKunjungan), satuKunjungan.NoMedRek, satuKunjungan.NamaPasien, satuKunjungan.Keluhan, satuKunjungan.Diagnosa, satuKunjungan.TekananDarah, satuKunjungan.BeratBadan, satuKunjungan.Tindakan, satuKunjungan.Visite, satuKunjungan.KunjunganLagi}
            aTable.Rows.Add(row)
            updateProgressBackgroundWorker()
        Next

        dataGridKunjunganRef = aTable

    End Sub

    Sub renderTablePoliklinik(ByVal dataAsList As ArrayList, ByVal aTable As DataGridView)

        aTable.Rows.Clear()

        For Each satuPoli As Poliklinik In dataAsList
            Dim row As Object() = New Object() {False, satuPoli.ID, satuPoli.UnitPoliklinik, satuPoli.NamaDokter, satuPoli.NamaPetugas}
            aTable.Rows.Add(row)
            updateProgressBackgroundWorker()
        Next

    End Sub

    Sub renderTableDokter(ByVal dataAsList As ArrayList, ByVal aTable As DataGridView)

        aTable.Rows.Clear()

        For Each satuOrang As Dokter In dataAsList
            Dim row As Object() = New Object() {False, satuOrang.ID, satuOrang.NIP, satuOrang.Nama, satuOrang.Kode, satuOrang.Spesialis}
            aTable.Rows.Add(row)
            updateProgressBackgroundWorker()
        Next

    End Sub

    Sub renderTablePetugas(ByVal dataAsList As ArrayList, ByVal aTable As DataGridView)

        aTable.Rows.Clear()

        For Each satuOrang As Petugas In dataAsList
            Dim row As Object() = New Object() {False, satuOrang.ID, satuOrang.NIP, satuOrang.Nama, satuOrang.Jabatan, satuOrang.Telp}
            aTable.Rows.Add(row)
            updateProgressBackgroundWorker()
        Next

    End Sub

    Sub renderNamaPetugasToTable(ByVal dataCSV As String, ByVal aTable As DataGridView)

        aTable.Rows.Clear()

        Dim dataArray As String() = dataCSV.Split(",")


        For Each satuOrang As String In dataArray

            If (satuOrang.Length > 0) Then
                Dim row As Object() = New Object() {satuOrang}
                aTable.Rows.Add(row)
            End If

            'updateProgressBackgroundWorker()
        Next

    End Sub

    Sub addDataIntoTable(ByVal nama As String, ByVal aTable As DataGridView)
        Dim row As Object() = New Object() {nama}
        aTable.Rows.Add(row)
    End Sub

    Sub removeSelectedDataFromTable(ByVal table As DataGridView)

        Dim dataPopulasi As New ArrayList

        For Each Data As DataGridViewRow In table.Rows
            If (Data.Selected) Then
                dataPopulasi.Add(Data)
            End If
        Next

        If (dataPopulasi.Count > 0) Then
            For counter As Integer = dataPopulasi.Count - 1 To 0 Step -1
                table.Rows.Remove(dataPopulasi.Item(counter))
            Next
        End If


    End Sub

    Sub renderNamaCombobox(ByVal dataAsList As ArrayList, ByVal Combobox As ComboBox)

        Combobox.Items.Clear()

        For Each satuOrang As String In dataAsList

            Combobox.Items.Add(satuOrang)
        Next

    End Sub

    Sub activateAllDateTimePickers(ByVal ParamArray aComponent As DateTimePicker())
        For Each singleComp As DateTimePicker In aComponent
            singleComp.Enabled = True
        Next
    End Sub

    Sub activateAllComboboxes(ByVal ParamArray aComponent As ComboBox())
        For Each singleComp As ComboBox In aComponent
            singleComp.Enabled = True
        Next
    End Sub


    Sub activateAllTextboxes(ByVal ParamArray aComponent As TextBox())
        For Each singleComp As TextBox In aComponent
            singleComp.Enabled = True
        Next
    End Sub

    Sub disactiveAllTextboxes(ByVal ParamArray aComponent As TextBox())
        For Each singleComp As TextBox In aComponent
            singleComp.Enabled = False
        Next
    End Sub

    Sub disactiveAllDateTimePickers(ByVal ParamArray aComponent As DateTimePicker())
        For Each singleComp As DateTimePicker In aComponent
            singleComp.Enabled = False
        Next
    End Sub

    Sub disactiveAllComboboxes(ByVal ParamArray aComponent As ComboBox())
        For Each singleComp As ComboBox In aComponent
            singleComp.Enabled = False
        Next
    End Sub

    Sub activateAllButtons(ByVal ParamArray aComponent As Button())
        For Each singleComp As Button In aComponent
            singleComp.Enabled = True
        Next
    End Sub

    Sub activateAllRadioButtons(ByVal ParamArray aComponent As RadioButton())
        For Each singleComp As RadioButton In aComponent
            singleComp.Enabled = True
        Next
    End Sub

    Sub activateDataTable(ByVal dataGrid As DataGridView)
        dataGrid.Enabled = True
    End Sub

    Sub disactiveDataTable(ByVal dataGrid As DataGridView)
        dataGrid.Enabled = False
        dataGrid.Rows.Clear()
    End Sub

    Sub disactiveAllRadioButton(ByVal ParamArray aComponent As RadioButton())
        For Each singleComp As RadioButton In aComponent
            singleComp.Enabled = False
        Next
    End Sub

    Sub disactiveAllButton(ByVal ParamArray aComponent As Button())
        For Each singleComp As Button In aComponent
            singleComp.Enabled = False
        Next
    End Sub

    Sub clearAllTextboxes(ByVal ParamArray aComp As TextBox())
        For Each singleComp As TextBox In aComp
            singleComp.Text = ""
        Next
    End Sub

    Sub clearAllComboboxes(ByVal ParamArray aComp As ComboBox())
        For Each singleComp As ComboBox In aComp
            singleComp.SelectedIndex = -1
        Next
    End Sub

    Sub clearAllDateTimePickers(ByVal ParamArray aComp As DateTimePicker())
        For Each singleComp As DateTimePicker In aComp
            singleComp.Text = ""
        Next
    End Sub

    Sub filterOnTable(ByVal table As DataGridView, pencarianText As String)

        Dim ditemukanRow As New ArrayList

        For Each row As DataGridViewRow In table.Rows
            For Each cell As DataGridViewCell In row.Cells
                If (cell.Value.ToString.ToLower.Contains(pencarianText.ToLower)) Then
                    ' ketemu
                    ditemukanRow.Add(row)
                    Exit For
                End If
            Next
        Next

        ' data found extracted into table once more
        table.Rows.Clear()

        For Each ketemu As DataGridViewRow In ditemukanRow
            table.Rows.Add(ketemu)
        Next


    End Sub

    Sub navigasiLinkCreator(ByVal whichPageNow As Integer, ByVal Panel As FlowLayoutPanel, ByVal namaEntity As String)


        Dim pageNow As Integer
        Dim startFrom As Integer
        Dim manyRows As Integer

        If (namaEntity = "pasien") Then
            manyRows = DBOperation.getAllPasienCount()
        Else
            manyRows = DBOperation.getAllKunjunganCount()
        End If

        Dim manyPages As Integer = Math.Ceiling(manyRows / manyItem)

        If (whichPageNow > 0) Then
            pageNow = whichPageNow
        Else
            pageNow = 1
        End If

        If (pageNow > 1) Then
            startFrom = (pageNow * manyItem) - manyItem
        Else
            startFrom = 0
        End If

        Dim sudahada As Boolean = False

        For value As Integer = 1 To manyPages

            Dim LinkNav01 As New System.Windows.Forms.LinkLabel

            LinkNav01.AutoSize = False
            LinkNav01.Location = New System.Drawing.Point(3, 0)
            LinkNav01.Margin = New System.Windows.Forms.Padding(3, 0, 5, 0)
            LinkNav01.Name = "LinkNav" & getNumericText(value)
            LinkNav01.Size = New System.Drawing.Size(20, 20)
            LinkNav01.TabIndex = 0
            LinkNav01.TabStop = True
            LinkNav01.Text = value
            LinkNav01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

            'default activate sign
            If (value = 1) Then
                LinkNav01.LinkColor = Color.Red
            End If

            If (namaEntity = "pasien") Then
                AddHandler LinkNav01.LinkClicked, AddressOf dynamicLinkPagingPasien

                For Each link As System.Windows.Forms.LinkLabel In arrayLinkNavPasien
                    If (link.Text = value) Then
                        sudahada = True
                        Continue For
                    End If
                Next

                If (sudahada = False) Then
                    arrayLinkNavPasien.Add(LinkNav01)
                End If



            Else
                AddHandler LinkNav01.LinkClicked, AddressOf dynamicLinkPagingKunjungan

                For Each link As System.Windows.Forms.LinkLabel In arrayLinkNavKunjungan
                    If (link.Text = value) Then
                        sudahada = True
                        Continue For
                    End If
                Next

                If (sudahada = False) Then
                    arrayLinkNavKunjungan.Add(LinkNav01)
                End If


            End If

            If (sudahada = False) Then
                Panel.Controls.Add(LinkNav01)
            End If


        Next

    End Sub

    Sub recolorLinkNavigasi(ByVal nomorIndex As Integer, ByVal nlist As ArrayList)

        ' netralize first
        For Each n As LinkLabel In nlist
            n.LinkColor = Color.Blue
        Next

        Dim link As LinkLabel = nlist.Item(nomorIndex - 1)
        link.LinkColor = Color.Red
    End Sub


    Private Sub dynamicLinkPagingPasien(ByVal sender As System.Object, ByVal e As LinkLabelLinkClickedEventArgs)
        Dim linkNya As System.Windows.Forms.LinkLabel = (DirectCast(sender, LinkLabel))

        'MsgBox("saya link ke " & linkNya.Text)
        Dim nomer As Integer = linkNya.Text
        GUIHelper.renderTablePasien(DBOperation.GetAllPasienForPaging(nomer), dataGridPasienRef)

        recolorLinkNavigasi(nomer, arrayLinkNavPasien)

    End Sub

    Private Sub dynamicLinkPagingKunjungan(ByVal sender As System.Object, ByVal e As LinkLabelLinkClickedEventArgs)
        Dim linkNya As System.Windows.Forms.LinkLabel = (DirectCast(sender, LinkLabel))

        'MsgBox("saya link ke " & linkNya.Text)
        Dim nomer As Integer = linkNya.Text
        GUIHelper.renderTableKunjungan(DBOperation.GetAllKunjunganForPaging(nomer), dataGridKunjunganRef)

        recolorLinkNavigasi(nomer, arrayLinkNavKunjungan)

    End Sub

    Function getNumericText(ByVal n As Integer) As String
        If (n < 10) Then
            Return "0" & n
        End If

        Return n
    End Function



End Module
