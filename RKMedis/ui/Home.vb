Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class Home

    Dim dataPetugas As Petugas
    Dim dataDokter As Dokter
    Dim dataPoli As Poliklinik
    Dim dataPasien As Pasien
    Dim dataKunjungan As Kunjungan

    Dim dataRowPetugas As New ArrayList
    Dim dataRowDokter As New ArrayList
    Dim dataRowPoli As New ArrayList
    Dim dataRowPasien As New ArrayList
    Dim dataRowKunjungan As New ArrayList

    Private Sub Button_AddPetugas_Click(sender As Object, e As EventArgs) Handles Button_AddPetugas.Click
        aksiAddPetugas()

    End Sub

    Private Sub aksiAddPetugas()
        activateFormPetugas(True)
        clearFormPetugas()

        dataPetugas = New Petugas()
        Label_ModeFormPetugas.Text = "NEW"
    End Sub

    Private Sub Button_SavePetugas_Click(sender As Object, e As EventArgs) Handles Button_SavePetugas.Click

        dataPetugas.Nama = TextBox_NamaPetugas.Text
        dataPetugas.NIP = TextBox_NipPetugas.Text
        dataPetugas.Telp = TextBox_TelpPetugas.Text
        dataPetugas.Jabatan = TextBox_JabatanPetugas.Text


        If (Label_ModeFormPetugas.Text = "EDIT") Then
            'updating data
            dataPetugas.ID = Label_IDPetugas.Text
            DBOperation.UpdatePetugas(dataPetugas)
            LabelStatusBottom.Text = "Data was updated succesfully!"
        Else
            'saving new data
            DBOperation.SavePetugas(dataPetugas)
            LabelStatusBottom.Text = "Data was saved succesfully!"
        End If

        GUIHelper.renderTablePetugas(DBOperation.GetAllPetugas(), DataGridView_Petugas)
        GUIHelper.renderNamaCombobox(DBOperation.GetAllPetugas(True), ComboBox_PetugasPoliklinik)
        updateDataCount()

        activateFormPetugas(False)
    End Sub

    Private Sub DataGridView_Petugas_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView_Petugas.ColumnHeaderMouseClick


        If (e.ColumnIndex = 0) Then
            GUIHelper.activateAllCheckboxesTable(DataGridView_Petugas)
        End If
    End Sub


    Private Sub Button_EditPetugas_Click(sender As Object, e As EventArgs) Handles Button_EditPetugas.Click
        dataPetugas = GUIHelper.getCheckedRowTablePetugas(DataGridView_Petugas)

        If (dataPetugas IsNot Nothing) Then

            TextBox_JabatanPetugas.Text = dataPetugas.Jabatan
            TextBox_NamaPetugas.Text = dataPetugas.Nama
            TextBox_NipPetugas.Text = dataPetugas.NIP
            TextBox_TelpPetugas.Text = dataPetugas.Telp
            Label_IDPetugas.Text = dataPetugas.ID

            Label_ModeFormPetugas.Text = "EDIT"

            activateFormPetugas(True)

        Else
            MsgBox("Pilih dulu data petugasnya!")
        End If

    End Sub

    Private Sub DataGridView_Petugas_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView_Petugas.SelectionChanged
        GUIHelper.activateAllCheckboxesSelectedRowTable(DataGridView_Petugas)
    End Sub

    Private Sub clearFormKunjungan()
        GUIHelper.clearAllDateTimePickers(Textbox_TanggalKunjungan)
        GUIHelper.clearAllTextboxes(TextBox_NoMedRekKunjungan, TextBox_NamaPasienKunjungan, TextBox_KeluhanKunjungan, TextBox_DiagnosaKunjungan, TextBox_TekananDarahKunjungan, TextBox_BeratBadanKunjungan, TextBox_TindakanKunjungan)
    End Sub

    Private Sub clearFormDokter()
        GUIHelper.clearAllTextboxes(TextBox_NipDokter, TextBox_NamaDokter, TextBox_SpesialisDokter, TextBox_KodeDokter)
    End Sub

    Private Sub clearFormPoliklinik()
        GUIHelper.clearAllComboboxes(ComboBox_DokterPoliklinik, ComboBox_PetugasPoliklinik)
        GUIHelper.clearAllTextboxes(TextBox_UnitPoliklinik)
    End Sub

    Private Sub clearFormPasien()
        GUIHelper.clearAllComboboxes(Combobox_StatusPasien)
        GUIHelper.clearAllTextboxes(TextBox_NoMedRekPasien, TextBox_NamaPasien,
                                    TextBox_TempatLahirPasien, TextBox_AlamatPasien,
                                    TextBox_TelpPasien, TextBox_CatatanPasien)

        GUIHelper.clearAllDateTimePickers(TextBox_TanggalBuatPasien, Textbox_TanggalLahirPasien)

    End Sub

    Private Sub clearFormPetugas()
        GUIHelper.clearAllTextboxes(TextBox_JabatanPetugas, TextBox_NamaPetugas, TextBox_NipPetugas, TextBox_TelpPetugas)
    End Sub

    Private Sub activateFormKunjungan(ByVal stat As Boolean)
        If (stat = True) Then
            Textbox_TanggalKunjungan.Focus()
            GUIHelper.activateAllComboboxes(ComboBox_UnitPoliklinikKunjungan)
            GUIHelper.activateAllRadioButtons(RadioButton_VisitePoliklinikKunjungan, RadioButton_VisiteRumahKunjungan)
            GUIHelper.activateAllDateTimePickers(Textbox_TanggalKunjungan, Textbox_TanggalKunjunganLagiKunjungan)
            GUIHelper.activateAllTextboxes(TextBox_NoMedRekKunjungan, TextBox_KeluhanKunjungan, TextBox_DiagnosaKunjungan, TextBox_TekananDarahKunjungan, TextBox_BeratBadanKunjungan, TextBox_TindakanKunjungan)
            GUIHelper.activateAllButtons(Button_SaveKunjungan, Button_CancelKunjungan)
        Else
            GUIHelper.disactiveAllComboboxes(ComboBox_UnitPoliklinikKunjungan)
            GUIHelper.disactiveAllRadioButton(RadioButton_VisitePoliklinikKunjungan, RadioButton_VisiteRumahKunjungan)
            GUIHelper.disactiveAllDateTimePickers(Textbox_TanggalKunjungan, Textbox_TanggalKunjunganLagiKunjungan)
            GUIHelper.disactiveAllTextboxes(TextBox_NoMedRekKunjungan, TextBox_KeluhanKunjungan, TextBox_DiagnosaKunjungan, TextBox_TekananDarahKunjungan, TextBox_BeratBadanKunjungan, TextBox_TindakanKunjungan)
            GUIHelper.disactiveAllButton(Button_SaveKunjungan, Button_CancelKunjungan)
        End If

    End Sub

    Private Sub activateFormPetugas(ByVal stat As Boolean)
        If (stat = True) Then
            GUIHelper.activateAllTextboxes(TextBox_JabatanPetugas, TextBox_NamaPetugas, TextBox_NipPetugas, TextBox_TelpPetugas)
            TextBox_NipPetugas.Focus()
            GUIHelper.activateAllButtons(Button_SavePetugas, Button_CancelPetugas)
        Else
            GUIHelper.disactiveAllTextboxes(TextBox_JabatanPetugas, TextBox_NamaPetugas, TextBox_NipPetugas, TextBox_TelpPetugas)
            GUIHelper.disactiveAllButton(Button_SavePetugas, Button_CancelPetugas)
        End If

    End Sub

    Private Sub activateFormPasien(ByVal stat As Boolean)

        If (stat = True) Then
            GUIHelper.activateAllRadioButtons(RadioButton_KelaminPriaPasien, RadioButton_KelaminWanitaPasien)
            GUIHelper.activateAllComboboxes(Combobox_StatusPasien)
            GUIHelper.activateAllDateTimePickers(TextBox_TanggalBuatPasien, Textbox_TanggalLahirPasien)
            GUIHelper.activateAllTextboxes(TextBox_NoMedRekPasien, TextBox_NamaPasien,
                                    TextBox_TempatLahirPasien, TextBox_AlamatPasien,
                                    TextBox_TelpPasien, TextBox_CatatanPasien)
            TextBox_NoMedRekPasien.Focus()
            GUIHelper.activateAllButtons(Button_SavePasien, Button_CancelPasien)
        Else
            GUIHelper.disactiveAllRadioButton(RadioButton_KelaminPriaPasien, RadioButton_KelaminWanitaPasien)
            GUIHelper.disactiveAllComboboxes(Combobox_StatusPasien)
            GUIHelper.disactiveAllDateTimePickers(TextBox_TanggalBuatPasien, Textbox_TanggalLahirPasien)
            GUIHelper.disactiveAllTextboxes(TextBox_NoMedRekPasien, TextBox_NamaPasien,
                                    TextBox_TempatLahirPasien, TextBox_AlamatPasien,
                                    TextBox_TelpPasien, TextBox_CatatanPasien)
            GUIHelper.disactiveAllButton(Button_SavePasien, Button_CancelPasien)
        End If

    End Sub

    Private Sub activateFormDokter(ByVal stat As Boolean)
        If (stat = True) Then
            GUIHelper.activateAllTextboxes(TextBox_NipDokter, TextBox_NamaDokter, TextBox_SpesialisDokter, TextBox_KodeDokter)
            TextBox_NipDokter.Focus()
            GUIHelper.activateAllButtons(Button_SaveDokter, Button_CancelDokter)
        Else
            GUIHelper.disactiveAllTextboxes(TextBox_NipDokter, TextBox_NamaDokter, TextBox_SpesialisDokter, TextBox_KodeDokter)
            GUIHelper.disactiveAllButton(Button_SaveDokter, Button_CancelDokter)
        End If

    End Sub

    Private Sub activateFormPoliklinik(ByVal stat As Boolean)
        If (stat = True) Then
            TextBox_UnitPoliklinik.Focus()
            GUIHelper.activateAllComboboxes(ComboBox_DokterPoliklinik, ComboBox_PetugasPoliklinik)
            GUIHelper.activateAllTextboxes(TextBox_UnitPoliklinik)
            GUIHelper.activateAllButtons(Button_SavePoliklinik, Button_CancelPoliklinik, Button_AddPetugasToPoliklinik)
            GUIHelper.activateDataTable(DataGridView_NamaPetugasPoliklinik)
        Else
            GUIHelper.disactiveAllTextboxes(TextBox_UnitPoliklinik)
            GUIHelper.disactiveAllButton(Button_SavePoliklinik, Button_CancelPoliklinik, Button_AddPetugasToPoliklinik)
            GUIHelper.disactiveAllComboboxes(ComboBox_DokterPoliklinik, ComboBox_PetugasPoliklinik)
            GUIHelper.disactiveDataTable(DataGridView_NamaPetugasPoliklinik)

            Button_DeletePetugasFromPoliklinik.Visible = False

        End If

    End Sub

    Private Sub Button_CancelPetugas_Click(sender As Object, e As EventArgs) Handles Button_CancelPetugas.Click
        activateFormPetugas(False)
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.kunjunganTableAdapter.Fill(Me._db_usedDataSet.kunjungan)
        Me.pasienTableAdapter.Fill(Me._db_usedDataSet.pasien)
        Me.poliklinikTableAdapter.Fill(Me._db_usedDataSet.poliklinik)

        Me.petugasTableAdapter.Fill(Me._db_usedDataSet.petugas)
        Me.dokterTableAdapter.Fill(Me._db_usedDataSet.dokter)

        Me.ReportViewer1.Visible = False

        Me.ReportViewer1.RefreshReport()

        Me.Text = "RKMedis v" & Application.ProductVersion

        GUIHelper.navigasiLinkCreator(1, FlowPasienNavigasi, "pasien")
        GUIHelper.navigasiLinkCreator(1, FlowKunjunganNavigasi, "kunjungan")

    End Sub

    Dim loadingFrame As LoadingScreen
    Public Sub setLoadingScreenRef(ByVal aframe As LoadingScreen)
        loadingFrame = aframe
    End Sub

    ' firstly called
    Public Sub loadData()
        Control.CheckForIllegalCrossThreadCalls = False

        ' installer will give the default file Database only
        ' thus the app should detect whether this is the db-used.db or db-default.db
        If (ProgramPath.isCurrentDBExist() = False) Then

            ' if the db-used.db isnot exist
            ' we then create a duplication from db-default.db into db-used.db
            File.Copy(ProgramPath.getDefaultDBFile, ProgramPath.getCurrentDBFile)

            ' we then used the db-used.db
            ProgramPath.ApplicationDBLocation = ProgramPath.getCurrentDBFile

        End If

        'this config setting is used for the reporting connection purposes
        My.Settings.Item("db_usedConnectionString") = "Data Source=""" & ProgramPath.ApplicationDBLocation & """"
        DBOperation.refreshDBLocation()

        ' read the Database File from the config location
        readRenderDatabase()
    End Sub

    

    Private Sub readRenderDatabase()


        GUIHelper.renderTablePetugas(DBOperation.GetAllPetugas(), DataGridView_Petugas)
        GUIHelper.renderTablePoliklinik(DBOperation.GetAllPoliklinik(), DataGridView_Poliklinik)
        GUIHelper.renderTableDokter(DBOperation.GetAllDokter(), DataGridView_Dokter)
        'GUIHelper.renderTablePasien(DBOperation.GetAllPasien(), DataGridView_Pasien)
        GUIHelper.renderTablePasien(DBOperation.GetAllPasienForPaging(1), DataGridView_Pasien)
        'GUIHelper.renderTableKunjungan(DBOperation.GetAllKunjungan(), DataGridView_Kunjungan)
        GUIHelper.renderTableKunjungan(DBOperation.GetAllKunjunganForPaging(1), DataGridView_Kunjungan)

        GUIHelper.renderNamaCombobox(DBOperation.GetAllDokter(True), ComboBox_DokterPoliklinik)
        GUIHelper.renderNamaCombobox(DBOperation.GetAllPetugas(True), ComboBox_PetugasPoliklinik)
        GUIHelper.renderNamaCombobox(DBOperation.GetAllPoliklinik(True), ComboBox_UnitPoliklinikKunjungan)

        updateDataCount()
    End Sub

    Private Sub updateDataCount()
        Label_JumlahDataDokter.Text = DataGridView_Dokter.RowCount & " Data"

        Label_JumlahDataPetugas.Text = DataGridView_Petugas.RowCount & " Data"
        Label_JumlahDataPoliklinik.Text = DataGridView_Poliklinik.RowCount & " Data"

        'Label_JumlahDataPasien.Text = DataGridView_Pasien.RowCount & " Data"
        'Label_JumlahDataKunjungan.Text = DataGridView_Kunjungan.RowCount & " Data"

        Label_JumlahDataPasien.Text = DBOperation.getAllPasienCount() & " Data"
        Label_JumlahDataKunjungan.Text = DBOperation.getAllKunjunganCount() & " Data"
    End Sub

    Private Sub Button_DeletePetugas_Click(sender As Object, e As EventArgs) Handles Button_DeletePetugas.Click
        Dim datList As ArrayList = GUIHelper.getCheckedRowsTablePetugas(DataGridView_Petugas)

        If (datList IsNot Nothing) Then
            For Each satuan As Petugas In datList
                DBOperation.DeletePetugas(satuan)
            Next

            GUIHelper.renderTablePetugas(DBOperation.GetAllPetugas(), DataGridView_Petugas)
            GUIHelper.renderNamaCombobox(DBOperation.GetAllPetugas(True), ComboBox_PetugasPoliklinik)
            updateDataCount()

            showStatusDataDelete(datList.Count)
        Else
            MsgBox("Pilih dulu datanya!")
        End If



    End Sub

    Private Sub Button_ResetPetugas_Click(sender As Object, e As EventArgs) Handles Button_ResetPetugas.Click
        GUIHelper.renderTablePetugas(DBOperation.GetAllPetugas(), DataGridView_Petugas)

        showStatusDataFound(DataGridView_Petugas)
    End Sub


    Private Sub Button_AddDokter_Click(sender As Object, e As EventArgs) Handles Button_AddDokter.Click
        aksiAddDokter()
    End Sub

    Private Sub aksiAddDokter()
        activateFormDokter(True)
        clearFormDokter()

        dataDokter = New Dokter()
        Label_ModeFormDokter.Text = "NEW"
    End Sub

    Private Sub Button_ResetDokter_Click(sender As Object, e As EventArgs) Handles Button_ResetDokter.Click
        GUIHelper.renderTableDokter(DBOperation.GetAllDokter(), DataGridView_Dokter)
        showStatusDataFound(DataGridView_Dokter)
    End Sub

    Private Sub Button_DeleteDokter_Click(sender As Object, e As EventArgs) Handles Button_DeleteDokter.Click
        Dim datList As ArrayList = GUIHelper.getCheckedRowsTableDokter(DataGridView_Dokter)

        If (datList IsNot Nothing) Then
            For Each satuan As Dokter In datList
                DBOperation.DeleteDokter(satuan)
            Next

            GUIHelper.renderTableDokter(DBOperation.GetAllDokter(), DataGridView_Dokter)
            GUIHelper.renderNamaCombobox(DBOperation.GetAllDokter(True), ComboBox_DokterPoliklinik)
            updateDataCount()

            showStatusDataDelete(datList.Count)
        Else
            MsgBox("Pilih dulu datanya!")
        End If

    End Sub

    Private Sub Button_EditDokter_Click(sender As Object, e As EventArgs) Handles Button_EditDokter.Click
        dataDokter = GUIHelper.getCheckedRowTableDokter(DataGridView_Dokter)

        If (dataDokter IsNot Nothing) Then

            TextBox_KodeDokter.Text = dataDokter.Kode
            TextBox_NamaDokter.Text = dataDokter.Nama
            TextBox_NipDokter.Text = dataDokter.NIP
            TextBox_SpesialisDokter.Text = dataDokter.Spesialis
            Label_IDDokter.Text = dataDokter.ID

            Label_ModeFormDokter.Text = "EDIT"

            activateFormDokter(True)

        Else
            MsgBox("Pilih dulu data petugasnya!")
        End If

    End Sub

    Private Sub Button_CancelDokter_Click(sender As Object, e As EventArgs) Handles Button_CancelDokter.Click
        activateFormDokter(False)
    End Sub

    Private Sub Button_SaveDokter_Click(sender As Object, e As EventArgs) Handles Button_SaveDokter.Click


        dataDokter.Nama = TextBox_NamaDokter.Text
        dataDokter.NIP = TextBox_NipDokter.Text
        dataDokter.Kode = TextBox_KodeDokter.Text
        dataDokter.Spesialis = TextBox_SpesialisDokter.Text


        If (Label_ModeFormDokter.Text = "EDIT") Then
            'updating data
            dataDokter.ID = Label_IDDokter.Text
            DBOperation.UpdateDokter(dataDokter)
            LabelStatusBottom.Text = "Data was updated succesfully!"
        Else
            'saving new data
            DBOperation.SaveDokter(dataDokter)
            LabelStatusBottom.Text = "Data was saved succesfully!"
        End If

        GUIHelper.renderTableDokter(DBOperation.GetAllDokter(), DataGridView_Dokter)
        GUIHelper.renderNamaCombobox(DBOperation.GetAllDokter(True), ComboBox_DokterPoliklinik)
        updateDataCount()

        activateFormDokter(False)
    End Sub

    Private Sub DataGridView_Dokter_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView_Dokter.ColumnHeaderMouseClick

        If (e.ColumnIndex = 0) Then
            GUIHelper.activateAllCheckboxesTable(DataGridView_Dokter)
        End If
    End Sub

    Private Sub DataGridView_Dokter_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView_Dokter.SelectionChanged
        GUIHelper.activateAllCheckboxesSelectedRowTable(DataGridView_Dokter)
    End Sub

    Private Sub Button_AddPoliklinik_Click(sender As Object, e As EventArgs) Handles Button_AddPoliklinik.Click
        aksiAddPoliklinik()
    End Sub

    Private Sub aksiAddPoliklinik()
        activateFormPoliklinik(True)
        clearFormPoliklinik()

        dataPoli = New Poliklinik()
        Label_ModeFormPoliklinik.Text = "NEW"
    End Sub


    Private Sub Button_EditPoliklinik_Click(sender As Object, e As EventArgs) Handles Button_EditPoliklinik.Click
        dataPoli = GUIHelper.getCheckedRowTablePoliklinik(DataGridView_Poliklinik)

        If (dataPoli IsNot Nothing) Then

            ComboBox_DokterPoliklinik.Text = dataPoli.NamaDokter

            GUIHelper.renderNamaPetugasToTable(dataPoli.NamaPetugas, DataGridView_NamaPetugasPoliklinik)

            If (DataGridView_NamaPetugasPoliklinik.Rows.Count > 0) Then
                Button_DeletePetugasFromPoliklinik.Visible = True
            Else
                Button_DeletePetugasFromPoliklinik.Visible = False
            End If

            TextBox_UnitPoliklinik.Text = dataPoli.UnitPoliklinik
            Label_IDPoliklinik.Text = dataPoli.ID

            Label_ModeFormPoliklinik.Text = "EDIT"

            activateFormPoliklinik(True)

        Else
            MsgBox("Pilih dulu data polikliniknya!")
        End If
    End Sub

    Private Sub Button_DeletePoliklinik_Click(sender As Object, e As EventArgs) Handles Button_DeletePoliklinik.Click
        Dim datList As ArrayList = GUIHelper.getCheckedRowsTablePoliklinik(DataGridView_Poliklinik)

        If (datList IsNot Nothing) Then
            For Each satuan As Poliklinik In datList
                DBOperation.DeletePoliklinik(satuan)
            Next

            GUIHelper.renderTablePoliklinik(DBOperation.GetAllPoliklinik(), DataGridView_Poliklinik)
            GUIHelper.renderNamaCombobox(DBOperation.GetAllPoliklinik(True), ComboBox_UnitPoliklinikKunjungan)
            updateDataCount()

            showStatusDataDelete(datList.Count)
        Else
            MsgBox("Pilih dulu datanya!")
        End If
    End Sub

    Private Sub Button_ResetPoliklinik_Click(sender As Object, e As EventArgs) Handles Button_ResetPoliklinik.Click
        GUIHelper.renderTablePoliklinik(DBOperation.GetAllPoliklinik(), DataGridView_Poliklinik)
        showStatusDataFound(DataGridView_Poliklinik)
    End Sub

    Private Sub Button_SavePoliklinik_Click(sender As Object, e As EventArgs) Handles Button_SavePoliklinik.Click

        dataPoli.UnitPoliklinik = TextBox_UnitPoliklinik.Text
        dataPoli.NamaDokter = ComboBox_DokterPoliklinik.Text
        dataPoli.NamaPetugas = GUIHelper.extractNamaPetugas(DataGridView_NamaPetugasPoliklinik)

        If (Label_ModeFormPoliklinik.Text = "EDIT") Then
            'updating data
            dataPoli.ID = Label_IDPoliklinik.Text
            DBOperation.UpdatePoliklinik(dataPoli)
            LabelStatusBottom.Text = "Data was updated succesfully!"
        Else
            'saving new data
            DBOperation.SavePoliklinik(dataPoli)
            LabelStatusBottom.Text = "Data was saved succesfully!"
        End If

        GUIHelper.renderTablePoliklinik(DBOperation.GetAllPoliklinik(), DataGridView_Poliklinik)
        GUIHelper.renderNamaCombobox(DBOperation.GetAllPoliklinik(True), ComboBox_UnitPoliklinikKunjungan)
        updateDataCount()

        activateFormPoliklinik(False)
    End Sub

    Private Sub Button_CancelPoliklinik_Click(sender As Object, e As EventArgs) Handles Button_CancelPoliklinik.Click
        activateFormPoliklinik(False)
    End Sub

    Private Sub DataGridView_Poliklinik_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView_Poliklinik.ColumnHeaderMouseClick
        If (e.ColumnIndex = 0) Then
            GUIHelper.activateAllCheckboxesTable(DataGridView_Poliklinik)
        End If
    End Sub

    Private Sub DataGridView_Poliklinik_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView_Poliklinik.SelectionChanged
        GUIHelper.activateAllCheckboxesSelectedRowTable(DataGridView_Poliklinik)
    End Sub

    Private Sub Button_AddPasien_Click(sender As Object, e As EventArgs) Handles Button_AddPasien.Click
        aksiAddPasien()
    End Sub

    Private Sub aksiAddPasien()
        activateFormPasien(True)
        clearFormPasien()

        dataPasien = New Pasien()
        Label_ModeFormPasien.Text = "NEW"
    End Sub

    Private Sub Button_EditPasien_Click(sender As Object, e As EventArgs) Handles Button_EditPasien.Click
        dataPasien = GUIHelper.getCheckedRowTablePasien(DataGridView_Pasien)

        If (dataPasien IsNot Nothing) Then

            ' what data language was used?
            If (GUIHelper.whatDataLanguage(dataPasien.TanggalBuat) = "English" And GUIHelper.isCultureCountryEnglish() = False) Then
                TextBox_TanggalBuatPasien.Text = GUIHelper.getEnglishToIndonesiaDate(dataPasien.TanggalBuat)
                Textbox_TanggalLahirPasien.Text = GUIHelper.getEnglishToIndonesiaDate(dataPasien.TanggalLahir)
            ElseIf (GUIHelper.whatDataLanguage(dataPasien.TanggalBuat) = "Indonesia" And GUIHelper.isCultureCountryEnglish() = True) Then
                TextBox_TanggalBuatPasien.Text = GUIHelper.getIndonesiaToEnglishDate(dataPasien.TanggalBuat)
                Textbox_TanggalLahirPasien.Text = GUIHelper.getIndonesiaToEnglishDate(dataPasien.TanggalLahir)
            Else
                TextBox_TanggalBuatPasien.Text = dataPasien.TanggalBuat
                Textbox_TanggalLahirPasien.Text = dataPasien.TanggalLahir
            End If


            TextBox_NoMedRekPasien.Text = dataPasien.NoMedrek
            Combobox_StatusPasien.SelectedItem = dataPasien.Status.ToUpper
            TextBox_NamaPasien.Text = dataPasien.Nama
            TextBox_TempatLahirPasien.Text = dataPasien.TempatLahir
            TextBox_CatatanPasien.Text = dataPasien.Catatan

            If (dataPasien.Kelamin.ToLower = "pria") Then
                RadioButton_KelaminPriaPasien.Checked = True
                RadioButton_KelaminWanitaPasien.Checked = False
            Else
                RadioButton_KelaminPriaPasien.Checked = False
                RadioButton_KelaminWanitaPasien.Checked = True
            End If


            TextBox_AlamatPasien.Text = dataPasien.Alamat
            TextBox_TelpPasien.Text = dataPasien.Telp

            Label_IDPasien.Text = dataPasien.ID

            Label_ModeFormPasien.Text = "EDIT"

            activateFormPasien(True)

        Else
            MsgBox("Pilih dulu data petugasnya!")
        End If
    End Sub

    Private Sub Button_DeletePasien_Click(sender As Object, e As EventArgs) Handles Button_DeletePasien.Click
        Dim datList As ArrayList = GUIHelper.getCheckedRowsTablePasien(DataGridView_Pasien)

        If (datList IsNot Nothing) Then
            For Each satuan As Pasien In datList
                DBOperation.DeletePasien(satuan)
            Next

            GUIHelper.renderTablePasien(DBOperation.GetAllPasien(), DataGridView_Pasien)
            updateDataCount()

            showStatusDataDelete(datList.Count)
        Else
            MsgBox("Pilih dulu datanya!")
        End If
    End Sub

    Private Sub Button_RefreshPasien_Click(sender As Object, e As EventArgs) Handles Button_RefreshPasien.Click
        GUIHelper.navigasiLinkCreator(1, FlowPasienNavigasi, "pasien")

        GUIHelper.renderTablePasien(DBOperation.GetAllPasienForPaging(1), DataGridView_Pasien)
        showStatusDataFound(DataGridView_Pasien)
    End Sub

    Private Sub Button_CancelPasien_Click(sender As Object, e As EventArgs) Handles Button_CancelPasien.Click
        activateFormPasien(False)
    End Sub

    Private Sub Button_SavePasien_Click(sender As Object, e As EventArgs) Handles Button_SavePasien.Click

        TextBox_NoMedRekPasien.BackColor = Nothing

        dataPasien.Nama = TextBox_NamaPasien.Text

        If (RadioButton_KelaminPriaPasien.Checked) Then
            dataPasien.Kelamin = RadioButton_KelaminPriaPasien.Text
        Else
            dataPasien.Kelamin = RadioButton_KelaminWanitaPasien.Text
        End If

        dataPasien.NoMedrek = TextBox_NoMedRekPasien.Text
        dataPasien.Status = Combobox_StatusPasien.Text.ToLower

        dataPasien.TanggalBuat = TextBox_TanggalBuatPasien.Text
        dataPasien.TanggalLahir = Textbox_TanggalLahirPasien.Text
        
        dataPasien.Telp = TextBox_TelpPasien.Text
        dataPasien.TempatLahir = TextBox_TempatLahirPasien.Text
        dataPasien.Alamat = TextBox_AlamatPasien.Text
        dataPasien.TotalKunjungan = 1
        dataPasien.Catatan = TextBox_CatatanPasien.Text

        If (Label_ModeFormPasien.Text = "EDIT") Then
            'updating data
            dataPasien.ID = Label_IDPasien.Text
            DBOperation.UpdatePasien(dataPasien)
            LabelStatusBottom.Text = "Data was updated succesfully!"
        Else
            'saving new data
            DBOperation.SavePasien(dataPasien)
            LabelStatusBottom.Text = "Data was saved succesfully!"

        End If

        GUIHelper.navigasiLinkCreator(1, FlowPasienNavigasi, "pasien")

        GUIHelper.renderTablePasien(DBOperation.GetAllPasienForPaging(1), DataGridView_Pasien)

        updateDataCount()

        activateFormPasien(False)
    End Sub

    Private Sub Button_AddKunjungan_Click(sender As Object, e As EventArgs) Handles Button_AddKunjungan.Click
        aksiAddKunjungan()
    End Sub

    Private Sub aksiAddKunjungan()
        activateFormKunjungan(True)
        clearFormKunjungan()

        dataKunjungan = New Kunjungan()
        Label_ModeFormKunjungan.Text = "NEW"
    End Sub


    Private Sub Button_SaveKunjungan_Click(sender As Object, e As EventArgs) Handles Button_SaveKunjungan.Click

        If (RadioButton_VisitePoliklinikKunjungan.Checked) Then
            dataKunjungan.Visite = ComboBox_UnitPoliklinikKunjungan.Text
        Else
            dataKunjungan.Visite = RadioButton_VisiteRumahKunjungan.Text
        End If

        dataKunjungan.IDPasien = Label_IDPasienKunjungan.Text
        dataKunjungan.KunjunganLagi = Textbox_TanggalKunjunganLagiKunjungan.Text
        dataKunjungan.TanggalKunjungan = Textbox_TanggalKunjungan.Text

        dataKunjungan.NoMedRek = TextBox_NoMedRekKunjungan.Text
        dataKunjungan.NamaPasien = TextBox_NamaPasienKunjungan.Text
        dataKunjungan.Keluhan = TextBox_KeluhanKunjungan.Text
        dataKunjungan.Diagnosa = TextBox_DiagnosaKunjungan.Text
        dataKunjungan.TekananDarah = TextBox_TekananDarahKunjungan.Text
        If (TextBox_BeratBadanKunjungan.Text.Contains("kg")) Then
            Dim berat As String = TextBox_BeratBadanKunjungan.Text.Replace("kg", "").Replace(" ", "")
            If (berat.Length > 0) Then
                dataKunjungan.BeratBadan = berat
            Else
                dataKunjungan.BeratBadan = 0
            End If
        ElseIf (TextBox_BeratBadanKunjungan.Text.Length = 0) Then
            dataKunjungan.BeratBadan = 0
        End If

        dataKunjungan.Tindakan = TextBox_TindakanKunjungan.Text

        If (Label_ModeFormKunjungan.Text = "EDIT") Then
            'updating data
            dataKunjungan.ID = Label_IDKunjungan.Text
            DBOperation.UpdateKunjungan(dataKunjungan)
            LabelStatusBottom.Text = "Data was updated succesfully!"
        Else
            'saving new data
            DBOperation.SaveKunjungan(dataKunjungan)
            LabelStatusBottom.Text = "Data was saved succesfully!"

            'updating jumlah visite pada table pasien
            DBOperation.UpdateKunjunganPasien(dataKunjungan.NoMedRek)

        End If

        GUIHelper.navigasiLinkCreator(1, FlowKunjunganNavigasi, "kunjungan")
        GUIHelper.renderTableKunjungan(DBOperation.GetAllKunjunganForPaging(1), DataGridView_Kunjungan)

        updateDataCount()

        activateFormKunjungan(False)
    End Sub

    Private Sub Button_CancelKunjungan_Click(sender As Object, e As EventArgs) Handles Button_CancelKunjungan.Click
        activateFormKunjungan(False)
    End Sub

    Private Sub Button_EditKunjungan_Click(sender As Object, e As EventArgs) Handles Button_EditKunjungan.Click
        dataKunjungan = GUIHelper.getCheckedRowTableKunjungan(DataGridView_Kunjungan)

        If (dataKunjungan IsNot Nothing) Then

            ' what data language was used?
            If (GUIHelper.whatDataLanguage(dataKunjungan.TanggalKunjungan) = "English" And GUIHelper.isCultureCountryEnglish() = False) Then
                Textbox_TanggalKunjungan.Text = GUIHelper.getEnglishToIndonesiaDate(dataKunjungan.TanggalKunjungan)
                Textbox_TanggalKunjunganLagiKunjungan.Text = GUIHelper.getEnglishToIndonesiaDate(dataKunjungan.KunjunganLagi)
            ElseIf (GUIHelper.whatDataLanguage(dataKunjungan.TanggalKunjungan) = "Indonesia" And GUIHelper.isCultureCountryEnglish() = True) Then
                Textbox_TanggalKunjungan.Text = GUIHelper.getIndonesiaToEnglishDate(dataKunjungan.TanggalKunjungan)
                Textbox_TanggalKunjunganLagiKunjungan.Text = GUIHelper.getIndonesiaToEnglishDate(dataKunjungan.KunjunganLagi)
            Else
                Textbox_TanggalKunjungan.Text = dataKunjungan.TanggalKunjungan
                Textbox_TanggalKunjunganLagiKunjungan.Text = dataKunjungan.KunjunganLagi
            End If

            TextBox_NamaPasienKunjungan.Text = dataKunjungan.NamaPasien
            TextBox_NoMedRekKunjungan.Text = dataKunjungan.NoMedRek
            TextBox_KeluhanKunjungan.Text = dataKunjungan.Keluhan
            TextBox_DiagnosaKunjungan.Text = dataKunjungan.Diagnosa
            TextBox_TekananDarahKunjungan.Text = dataKunjungan.TekananDarah
            TextBox_BeratBadanKunjungan.Text = dataKunjungan.BeratBadan
            TextBox_TindakanKunjungan.Text = dataKunjungan.Tindakan


            If (dataKunjungan.Visite.ToLower = "rumah") Then
                RadioButton_VisiteRumahKunjungan.Checked = True
            Else
                RadioButton_VisitePoliklinikKunjungan.Checked = True
                ComboBox_UnitPoliklinikKunjungan.Text = dataKunjungan.Visite
            End If

            Label_ModeFormKunjungan.Text = "EDIT"
            Label_IDKunjungan.Text = dataKunjungan.ID

            activateFormKunjungan(True)

        Else
            MsgBox("Pilih dulu data kunjungannya!")
        End If

    End Sub

    Private Sub Button_DeleteKunjungan_Click(sender As Object, e As EventArgs) Handles Button_DeleteKunjungan.Click
        Dim datList As ArrayList = GUIHelper.getCheckedRowsTableKunjungan(DataGridView_Kunjungan)


        If (datList IsNot Nothing) Then
            For Each satuan As Kunjungan In datList
                DBOperation.DeleteKunjungan(satuan)

            Next

            GUIHelper.renderTableKunjungan(DBOperation.GetAllKunjungan(), DataGridView_Kunjungan)
            updateDataCount()

            showStatusDataDelete(datList.Count)
        Else
            MsgBox("Pilih dulu datanya!")
        End If
    End Sub

    Private Sub showStatusDataDelete(ByVal nJumlah As Integer)
        LabelStatusBottom.Text = nJumlah & " data was successfully deleted!"
    End Sub

    Private Sub Button_ResetKunjungan_Click(sender As Object, e As EventArgs) Handles Button_ResetKunjungan.Click

        GUIHelper.navigasiLinkCreator(1, FlowKunjunganNavigasi, "kunjungan")

        GUIHelper.renderTableKunjungan(DBOperation.GetAllKunjunganForPaging(1), DataGridView_Kunjungan)

        showStatusDataFound(DataGridView_Kunjungan)
    End Sub

    Private Sub showStatusDataFound(ByVal dataTable As DataGridView)
        Dim entryWord As String = ""
        If (dataTable.RowCount > 1) Then
            entryWord = " entries"
        ElseIf (dataTable.RowCount > 0) Then
            entryWord = " entry"
        End If

        LabelStatusBottom.Text = "Data " & dataTable.Name & " was refreshed! Found " & dataTable.RowCount & entryWord
    End Sub

    Private Sub TextBox_NoMedRekKunjungan_TextChanged(sender As Object, e As EventArgs) Handles TextBox_NoMedRekKunjungan.TextChanged
        ' getting the patient name and its id
        If (TextBox_NoMedRekKunjungan.Text.Length > 0) Then
            'obtain the patient name from database
            Dim pasien As Pasien = DBOperation.GetPasien(TextBox_NoMedRekKunjungan.Text)

            If (pasien.Nama IsNot Nothing) Then
                TextBox_NamaPasienKunjungan.Text = pasien.Nama
                Label_IDPasienKunjungan.Text = pasien.ID
            Else
                TextBox_NamaPasienKunjungan.Text = "Type a complete no.medrek"
                Label_IDPasienKunjungan.Text = Nothing
            End If
        ElseIf (TextBox_NoMedRekKunjungan.Text.Length = 0) Then
            TextBox_NamaPasienKunjungan.Text = Nothing
            Label_IDPasienKunjungan.Text = Nothing
        End If
    End Sub

    Private Sub TextBox_BeratBadanKunjungan_TextChanged(sender As Object, e As EventArgs) Handles TextBox_BeratBadanKunjungan.TextChanged
        If (TextBox_BeratBadanKunjungan.Text.ToLower.Contains("kg") = False) Then
            TextBox_BeratBadanKunjungan.Text &= " kg"
            TextBox_BeratBadanKunjungan.SelectionStart = TextBox_BeratBadanKunjungan.Text.Length - 3
        End If
    End Sub

    Private Sub ButtonHome_AddDokter_Click(sender As Object, e As EventArgs) Handles ButtonHome_AddDokter.Click
        TabControl1.SelectedIndex = 2
        aksiAddDokter()
    End Sub

    Private Sub ButtonHome_AddPetugas_Click(sender As Object, e As EventArgs) Handles ButtonHome_AddPetugas.Click
        TabControl1.SelectedIndex = 1
        aksiAddPetugas()
    End Sub

    Private Sub ButtonHome_AddKunjungan_Click(sender As Object, e As EventArgs) Handles ButtonHome_AddKunjungan.Click
        TabControl1.SelectedIndex = 5
        aksiAddKunjungan()
    End Sub

    Private Sub ButtonHome_AddPasien_Click(sender As Object, e As EventArgs) Handles ButtonHome_AddPasien.Click
        TabControl1.SelectedIndex = 3
        aksiAddPasien()
    End Sub

    Private Sub ButtonHome_AddPoliklinik_Click(sender As Object, e As EventArgs) Handles ButtonHome_AddPoliklinik.Click
        TabControl1.SelectedIndex = 4
        aksiAddPoliklinik()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        System.Environment.Exit(1)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If (TabControl1.SelectedIndex = 0) Then
            lockSearchToolbar(True)
        Else
            lockSearchToolbar(False)
        End If
    End Sub

    Private Sub lockSearchToolbar(ByVal statB As Boolean)
        ToolStripSearchText.Enabled = Not statB
        ToolStripSearchButton.Enabled = Not statB
    End Sub

    Private Sub ToolStripSearchText_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripSearchText.KeyDown
        If e.KeyCode = Keys.Enter Then

            aksiSearchText(ToolStripSearchText.Text)

        End If
    End Sub

    Private Sub aksiSearchText(ByVal tulisanDicari As String)


        If (TabControl1.SelectedIndex = 1) Then
            ' petugas tab
            GUIHelper.filterOnTable(DataGridView_Petugas, tulisanDicari)
            showStatusDataFound(DataGridView_Petugas)

        ElseIf (TabControl1.SelectedIndex = 2) Then
            ' dokter tab
            GUIHelper.filterOnTable(DataGridView_Dokter, tulisanDicari)
            showStatusDataFound(DataGridView_Dokter)
        ElseIf (TabControl1.SelectedIndex = 3) Then
            ' pasien tab
            GUIHelper.filterOnTable(DataGridView_Pasien, tulisanDicari)
            showStatusDataFound(DataGridView_Pasien)
        ElseIf (TabControl1.SelectedIndex = 4) Then
            ' poliklinik tab
            GUIHelper.filterOnTable(DataGridView_Poliklinik, tulisanDicari)
            showStatusDataFound(DataGridView_Poliklinik)
        ElseIf (TabControl1.SelectedIndex = 5) Then
            ' kunjungan tab
            GUIHelper.filterOnTable(DataGridView_Kunjungan, tulisanDicari)
            showStatusDataFound(DataGridView_Kunjungan)
        End If

    End Sub

    Private Sub ToolStripSearchText_TextChanged(sender As Object, e As EventArgs) Handles ToolStripSearchText.TextChanged
        If (ToolStripSearchText.Text.Length = 0) Then
            ' when the text is empty
            ' so we return the data back
            If (TabControl1.SelectedIndex = 1) Then
                ' petugas tab
                GUIHelper.renderTablePetugas(DBOperation.GetAllPetugas(), DataGridView_Petugas)
            ElseIf (TabControl1.SelectedIndex = 2) Then
                ' dokter tab
                GUIHelper.renderTableDokter(DBOperation.GetAllDokter(), DataGridView_Dokter)
            ElseIf (TabControl1.SelectedIndex = 3) Then
                ' pasien tab
                GUIHelper.renderTablePasien(DBOperation.GetAllPasien(), DataGridView_Pasien)
            ElseIf (TabControl1.SelectedIndex = 4) Then
                ' poliklinik tab
                GUIHelper.renderTablePoliklinik(DBOperation.GetAllPoliklinik(), DataGridView_Poliklinik)
            ElseIf (TabControl1.SelectedIndex = 5) Then
                ' kunjungan tab
                GUIHelper.renderTableKunjungan(DBOperation.GetAllKunjungan(), DataGridView_Kunjungan)
            End If

            LabelStatusBottom.Text = ""

        End If
    End Sub

    Private Sub ToolStripExportButton_Click(sender As Object, e As EventArgs) Handles ToolStripExportButton.Click
        aksiExportDatabase()

    End Sub

    Private Sub aksiExportDatabase()
        SaveFileDialog1.Filter = "Database File|*.db"
        SaveFileDialog1.Title = "Save a Database File"

        If (SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            If (SaveFileDialog1.FileName <> "") Then
                ' copy the current database into that destination
                File.Copy(ProgramPath.ApplicationDBLocation, SaveFileDialog1.FileName, True)
                MessageBox.Show("File was saved successfully!", "Export Data", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub

    Private Sub ToolStripImportButton_Click(sender As Object, e As EventArgs) Handles ToolStripImportButton.Click
        aksiImportDatabase()
    End Sub

    Private Sub aksiImportDatabase()
        OpenFileDialog1.Filter = "Database File|*.db"
        OpenFileDialog1.Title = "Open a Database File"

        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            If (OpenFileDialog1.FileName <> "") Then

                ' set the location into the config file
                ' re read the database

                ProgramPath.setDBLocationIntoConfig(OpenFileDialog1.FileName)
                readRenderDatabase()

                MessageBox.Show("File was loaded successfully!", "Import Data", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub

    Private Sub ToolStripSearchButton_Click(sender As Object, e As EventArgs) Handles ToolStripSearchButton.Click
        If (ToolStripSearchText.Text.Length > 0) Then
            aksiSearchText(ToolStripSearchText.Text)
        End If

    End Sub

    Private Sub ImportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportToolStripMenuItem.Click
        aksiImportDatabase()
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        aksiExportDatabase()
    End Sub

    Private Sub Home_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        loadingFrame.Close()
    End Sub

    Private Sub addIntoFilterMode12(ByVal name As String)
        ComboBoxFilterMode1.Items.Add(name)
        ComboBoxFilterMode2.Items.Add(name)
    End Sub

    Private Sub ComboBoxDataEntity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDataEntity.SelectedIndexChanged

        Dim namaEntity As String = ComboBoxDataEntity.Text

        ComboBoxFilterMode2.Items.Clear()
        ComboBoxFilterMode1.Items.Clear()

        ComboBoxFilterMode1.Text = ""
        ComboBoxFilterMode2.Text = ""

        TextBoxParameter1.Text = ""
        TextBoxParameter2.Text = ""

        If (namaEntity = "petugas") Then
            addIntoFilterMode12("nama")
            addIntoFilterMode12("nip")
            addIntoFilterMode12("jabatan")
            addIntoFilterMode12("telp")
        End If

        If (namaEntity = "dokter") Then
            addIntoFilterMode12("nama")
            addIntoFilterMode12("nip")
            addIntoFilterMode12("kode")
            addIntoFilterMode12("spesialis")
        End If

        If (namaEntity = "poliklinik") Then
            addIntoFilterMode12("unit")
            addIntoFilterMode12("nama")
            addIntoFilterMode12("dokter")
            addIntoFilterMode12("nama petugas")
        End If

        If (namaEntity = "pasien") Then
            addIntoFilterMode12("no.medrek")
            addIntoFilterMode12("nama")
            addIntoFilterMode12("status")
            addIntoFilterMode12("tanggal buat")
            addIntoFilterMode12("tanggal lahir")
            addIntoFilterMode12("kelamin")
            addIntoFilterMode12("alamat")
            addIntoFilterMode12("telp")
            addIntoFilterMode12("catatan")
            addIntoFilterMode12("total kunjungan")
        End If

        If (namaEntity = "kunjungan") Then
            addIntoFilterMode12("no.medrek")
            addIntoFilterMode12("nama")
            addIntoFilterMode12("keluhan")
            addIntoFilterMode12("diagosa")
            addIntoFilterMode12("tekanan darah")
            addIntoFilterMode12("berat badan")
            addIntoFilterMode12("tindakan")
            addIntoFilterMode12("visite")
            addIntoFilterMode12("tanggal")
            addIntoFilterMode12("kunjungan lagi")
        End If

    End Sub

    Private Sub ButtonRefreshReporting_Click(sender As Object, e As EventArgs) Handles ButtonRefreshReporting.Click
        Dim filterMode1 As String = ComboBoxFilterMode1.Text
        Dim nilaiFilter1 As String = TextBoxParameter1.Text

        Dim filterMode2 As String = ComboBoxFilterMode2.Text
        Dim nilaiFilter2 As String = TextBoxParameter2.Text

        Dim tanggalSekarang As String = Format(Now, "dd MMMM yyyy")

        Dim tanggalParam As New ReportParameter("Tanggal", tanggalSekarang)

        Dim kumpulanParams As New ReportParameterCollection

        kumpulanParams.Add(tanggalParam)

        Dim folderLocation = Path.GetDirectoryName(Application.ExecutablePath) & "\reporting\"
        Dim targetReporting As String = Nothing
        Dim namaFile As String = Nothing

        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        ReportDataSource1.Name = "DataSet1"

        Dim multiFilter As String = ComboBoxFilterMode1.Text & " LIKE '%" & TextBoxParameter1.Text & "%' AND " & ComboBoxFilterMode2.Text & " LIKE '%" & TextBoxParameter2.Text & "%'"
        Dim singleFilter As String = ComboBoxFilterMode1.Text & " LIKE '%" & TextBoxParameter1.Text & "%'"

        If (ComboBoxDataEntity.Text = "petugas") Then
            namaFile = "ReportPetugas.rdlc"
            Me.petugasTableAdapter.Adapter.Fill(Me._db_usedDataSet.petugas)

            If (RadioButtonFilterSingle.Checked) Then
                Me._db_usedDataSet.petugas.DefaultView.RowFilter = singleFilter
            Else

                Me._db_usedDataSet.petugas.DefaultView.RowFilter = multiFilter
            End If

            Me.petugasBindingSource.DataSource = Me._db_usedDataSet.petugas.DefaultView
            ReportDataSource1.Value = Me.petugasBindingSource

        ElseIf (ComboBoxDataEntity.Text = "dokter") Then
            namaFile = "ReportDokter.rdlc"
            Me.dokterTableAdapter.Adapter.Fill(Me._db_usedDataSet.dokter)

            If (RadioButtonFilterSingle.Checked) Then
                Me._db_usedDataSet.dokter.DefaultView.RowFilter = singleFilter
            Else
                Me._db_usedDataSet.dokter.DefaultView.RowFilter = multiFilter
            End If

            Me.dokterBindingSource.DataSource = Me._db_usedDataSet.dokter.DefaultView

            ReportDataSource1.Value = Me.dokterBindingSource
        ElseIf (ComboBoxDataEntity.Text = "poliklinik") Then
            namaFile = "ReportPoliklinik.rdlc"
            Me.poliklinikTableAdapter.Fill(Me._db_usedDataSet.poliklinik)

            If (RadioButtonFilterSingle.Checked) Then
                Me._db_usedDataSet.poliklinik.DefaultView.RowFilter = singleFilter
            Else
                Me._db_usedDataSet.poliklinik.DefaultView.RowFilter = multiFilter
            End If

            Me.poliklinikBindingSource.DataSource = Me._db_usedDataSet.poliklinik.DefaultView

            ReportDataSource1.Value = Me.poliklinikBindingSource
        ElseIf (ComboBoxDataEntity.Text = "pasien") Then
            namaFile = "ReportPasien.rdlc"
            Me.pasienTableAdapter.Adapter.Fill(Me._db_usedDataSet.pasien)

            If (RadioButtonFilterSingle.Checked) Then
                If (ComboBoxFilterMode1.Text = "total kunjungan") Then
                    singleFilter = ComboBoxFilterMode1.Text & " = " & TextBoxParameter1.Text
                    Me._db_usedDataSet.pasien.DefaultView.RowFilter = singleFilter
                Else
                    Me._db_usedDataSet.pasien.DefaultView.RowFilter = singleFilter
                End If

            Else
                Me._db_usedDataSet.pasien.DefaultView.RowFilter = Nothing
            End If

            Me.pasienBindingSource.DataSource = Me._db_usedDataSet.pasien.DefaultView

            ReportDataSource1.Value = Me.pasienBindingSource
        ElseIf (ComboBoxDataEntity.Text = "kunjungan") Then
            namaFile = "ReportKunjungan.rdlc"
            Me.kunjunganTableAdapter.Adapter.Fill(Me._db_usedDataSet.kunjungan)

            If (RadioButtonFilterSingle.Checked) Then
                If (ComboBoxFilterMode1.Text = "berat badan") Then
                    singleFilter = ComboBoxFilterMode1.Text & " = " & TextBoxParameter1.Text
                    Me._db_usedDataSet.kunjungan.DefaultView.RowFilter = singleFilter
                Else
                    Me._db_usedDataSet.kunjungan.DefaultView.RowFilter = singleFilter
                End If

            Else
                Me._db_usedDataSet.kunjungan.DefaultView.RowFilter = Nothing
            End If

            Me.kunjunganBindingSource.DataSource = Me._db_usedDataSet.kunjungan.DefaultView

            ReportDataSource1.Value = Me.kunjunganBindingSource
        End If

        targetReporting = folderLocation & namaFile
        Me.ReportViewer1.ProcessingMode = ProcessingMode.Local
        Me.ReportViewer1.LocalReport.DataSources.Clear()

        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportPath = targetReporting
        'Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "RKMedis." & namaFile


        Me.ReportViewer1.LocalReport.SetParameters(kumpulanParams)
        Me.ReportViewer1.Visible = True
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Button_AddPetugasToPoliklinik_Click(sender As Object, e As EventArgs) Handles Button_AddPetugasToPoliklinik.Click
        If (ComboBox_PetugasPoliklinik.SelectedIndex <> -1) Then
            Dim nama As String = ComboBox_PetugasPoliklinik.Text
            GUIHelper.addDataIntoTable(nama, DataGridView_NamaPetugasPoliklinik)
            Button_DeletePetugasFromPoliklinik.Visible = True
        End If
    End Sub

    Private Sub Button_DeletePetugasFromPoliklinik_Click(sender As Object, e As EventArgs) Handles Button_DeletePetugasFromPoliklinik.Click
        GUIHelper.removeSelectedDataFromTable(DataGridView_NamaPetugasPoliklinik)

        If (DataGridView_NamaPetugasPoliklinik.RowCount > 0) Then
            Button_DeletePetugasFromPoliklinik.Visible = True
        Else
            Button_DeletePetugasFromPoliklinik.Visible = False
        End If

    End Sub

    Private Sub RadioButton_VisiteRumahKunjungan_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_VisiteRumahKunjungan.CheckedChanged
        activateUnitPoliklinikVisite()
    End Sub

    Private Sub activateUnitPoliklinikVisite()
        If (RadioButton_VisiteRumahKunjungan.Checked = True) Then
            ComboBox_UnitPoliklinikKunjungan.Enabled = False
        Else
            ComboBox_UnitPoliklinikKunjungan.Enabled = True
        End If
    End Sub

    Private Sub RadioButton_VisitePoliklinikKunjungan_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_VisitePoliklinikKunjungan.CheckedChanged
        activateUnitPoliklinikVisite()
    End Sub

    Private Sub SystemToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonHome_ReportDokter_Click(sender As Object, e As EventArgs) Handles ButtonHome_ReportDokter.Click
        'last tab
        OpenReportingTabFor("dokter")

    End Sub

    Private Sub openReportingTabFor(ByVal name As String)
        TabControl1.SelectedIndex = TabControl1.TabCount - 1
        ComboBoxDataEntity.Text = name
        
    End Sub

    Private Sub ButtonHome_ReportPetugas_Click(sender As Object, e As EventArgs) Handles ButtonHome_ReportPetugas.Click
        openReportingTabFor("petugas")
    End Sub

    Private Sub ButtonHome_ReportKunjungan_Click(sender As Object, e As EventArgs) Handles ButtonHome_ReportKunjungan.Click
        openReportingTabFor("kunjungan")
    End Sub

    Private Sub ButtonHome_ReportPasien_Click(sender As Object, e As EventArgs) Handles ButtonHome_ReportPasien.Click
        openReportingTabFor("pasien")
    End Sub

    Private Sub ButtonHome_ReportPoliklinik_Click(sender As Object, e As EventArgs) Handles ButtonHome_ReportPoliklinik.Click
        openReportingTabFor("poliklinik")
    End Sub

    Private Sub toggleDualFilter()
        If (RadioButtonFilterSingle.Checked) Then
            ComboBoxFilterMode2.Enabled = False
            TextBoxParameter2.Enabled = False
        Else
            ComboBoxFilterMode2.Enabled = True
            TextBoxParameter2.Enabled = True
        End If
    End Sub

    Private Sub RadioButtonFilterDual_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonFilterDual.CheckedChanged
        toggleDualFilter()
    End Sub

    Private Sub RadioButtonFilterSingle_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonFilterSingle.CheckedChanged
        toggleDualFilter()
    End Sub

    
    Private Sub TextBox_NoMedRekPasien_TextChanged(sender As Object, e As EventArgs) Handles TextBox_NoMedRekPasien.TextChanged
        Dim ketemuPasien As Pasien = DBOperation.GetPasien(TextBox_NoMedRekPasien.Text)

        If (ketemuPasien.Nama IsNot Nothing) Then
            TextBox_NoMedRekPasien.BackColor = Color.Yellow
            GUIHelper.disactiveAllButton(Button_SavePasien)
        Else
            TextBox_NoMedRekPasien.BackColor = Nothing
            GUIHelper.activateAllButtons(Button_SavePasien)
        End If

    End Sub

    Private Sub BiggerToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SmallerToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    

End Class