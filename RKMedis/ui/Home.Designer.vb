<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource10 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.petugasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._db_usedDataSet = New RKMedis._db_usedDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripImportButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripExportButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSearchText = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSearchButton = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.LabelStatusBottom = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabDokter = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox_SpesialisDokter = New System.Windows.Forms.TextBox()
        Me.TextBox_NipDokter = New System.Windows.Forms.TextBox()
        Me.TextBox_NamaDokter = New System.Windows.Forms.TextBox()
        Me.TextBox_KodeDokter = New System.Windows.Forms.TextBox()
        Me.Button_SaveDokter = New System.Windows.Forms.Button()
        Me.Button_CancelDokter = New System.Windows.Forms.Button()
        Me.Label_IDDokter = New System.Windows.Forms.Label()
        Me.Label_ModeFormDokter = New System.Windows.Forms.Label()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel9 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button_AddDokter = New System.Windows.Forms.Button()
        Me.Button_EditDokter = New System.Windows.Forms.Button()
        Me.Button_DeleteDokter = New System.Windows.Forms.Button()
        Me.Button_ResetDokter = New System.Windows.Forms.Button()
        Me.DataGridView_Dokter = New System.Windows.Forms.DataGridView()
        Me.ColumnDokter_Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnDokter_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDokter_NIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDokter_Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDokter_Kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDokter_Spesialis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPetugas = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox_TelpPetugas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox_NipPetugas = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox_NamaPetugas = New System.Windows.Forms.TextBox()
        Me.TextBox_JabatanPetugas = New System.Windows.Forms.TextBox()
        Me.Button_SavePetugas = New System.Windows.Forms.Button()
        Me.Button_CancelPetugas = New System.Windows.Forms.Button()
        Me.Label_IDPetugas = New System.Windows.Forms.Label()
        Me.Label_ModeFormPetugas = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel10 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button_AddPetugas = New System.Windows.Forms.Button()
        Me.Button_EditPetugas = New System.Windows.Forms.Button()
        Me.Button_DeletePetugas = New System.Windows.Forms.Button()
        Me.Button_ResetPetugas = New System.Windows.Forms.Button()
        Me.DataGridView_Petugas = New System.Windows.Forms.DataGridView()
        Me.ColumnPetugas_Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnPetugas_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPetugas_NIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPetugas_Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPetugas_Jabatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPetugas_Telp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabHome = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel16 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel17 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_JumlahDataDokter = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonHome_AddDokter = New System.Windows.Forms.Button()
        Me.ButtonHome_ReportDokter = New System.Windows.Forms.Button()
        Me.PictureHome_Dokter = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel18 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_JumlahDataPetugas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonHome_AddPetugas = New System.Windows.Forms.Button()
        Me.ButtonHome_ReportPetugas = New System.Windows.Forms.Button()
        Me.PictureHome_Petugas = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel19 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_JumlahDataKunjungan = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonHome_AddKunjungan = New System.Windows.Forms.Button()
        Me.ButtonHome_ReportKunjungan = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel20 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_JumlahDataPoliklinik = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonHome_AddPoliklinik = New System.Windows.Forms.Button()
        Me.ButtonHome_ReportPoliklinik = New System.Windows.Forms.Button()
        Me.PictureHome_Poliklinik = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel21 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_JumlahDataPasien = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonHome_AddPasien = New System.Windows.Forms.Button()
        Me.ButtonHome_ReportPasien = New System.Windows.Forms.Button()
        Me.PictureHome_Pasien = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPasien = New System.Windows.Forms.TabPage()
        Me.SplitContainer7 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox_NamaPasien = New System.Windows.Forms.TextBox()
        Me.TextBox_NoMedRekPasien = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Textbox_TanggalLahirPasien = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox_TempatLahirPasien = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RadioButton_KelaminWanitaPasien = New System.Windows.Forms.RadioButton()
        Me.RadioButton_KelaminPriaPasien = New System.Windows.Forms.RadioButton()
        Me.Button_SavePasien = New System.Windows.Forms.Button()
        Me.Button_CancelPasien = New System.Windows.Forms.Button()
        Me.Label_IDPasien = New System.Windows.Forms.Label()
        Me.Label_ModeFormPasien = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBox_AlamatPasien = New System.Windows.Forms.TextBox()
        Me.TextBox_TelpPasien = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TextBox_TanggalBuatPasien = New System.Windows.Forms.DateTimePicker()
        Me.Combobox_StatusPasien = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_CatatanPasien = New System.Windows.Forms.TextBox()
        Me.SplitContainer8 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel8 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.FlowPasienNavigasi = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button_AddPasien = New System.Windows.Forms.Button()
        Me.Button_EditPasien = New System.Windows.Forms.Button()
        Me.Button_DeletePasien = New System.Windows.Forms.Button()
        Me.Button_RefreshPasien = New System.Windows.Forms.Button()
        Me.DataGridView_Pasien = New System.Windows.Forms.DataGridView()
        Me.ColumnPasien_Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnPasien_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPasien_NoMedRek = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPasien_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPasien_TanggalBuat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPasien_Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPasien_TanggalLahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPasien_TempatLahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPasien_Kelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPasien_Alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPasien_Telp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPasien_TotalKunjungan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPasien_Catatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPoliklinik = New System.Windows.Forms.TabPage()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox_UnitPoliklinik = New System.Windows.Forms.TextBox()
        Me.Button_SavePoliklinik = New System.Windows.Forms.Button()
        Me.Button_CancelPoliklinik = New System.Windows.Forms.Button()
        Me.Label_IDPoliklinik = New System.Windows.Forms.Label()
        Me.Label_ModeFormPoliklinik = New System.Windows.Forms.Label()
        Me.ComboBox_DokterPoliklinik = New System.Windows.Forms.ComboBox()
        Me.FlowLayoutPanel11 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ComboBox_PetugasPoliklinik = New System.Windows.Forms.ComboBox()
        Me.Button_AddPetugasToPoliklinik = New System.Windows.Forms.Button()
        Me.DataGridView_NamaPetugasPoliklinik = New System.Windows.Forms.DataGridView()
        Me.Table_PetugasPoliklinik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button_DeletePetugasFromPoliklinik = New System.Windows.Forms.Button()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button_AddPoliklinik = New System.Windows.Forms.Button()
        Me.Button_EditPoliklinik = New System.Windows.Forms.Button()
        Me.Button_DeletePoliklinik = New System.Windows.Forms.Button()
        Me.Button_ResetPoliklinik = New System.Windows.Forms.Button()
        Me.DataGridView_Poliklinik = New System.Windows.Forms.DataGridView()
        Me.ColumnPoliklinik_Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnPoliklinik_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPoliklinik_Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPoliklinik_NamaDokter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPoliklinik_NamaPetugas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabKunjungan = New System.Windows.Forms.TabPage()
        Me.SplitContainer9 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.Textbox_TanggalKunjungan = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TextBox_NamaPasienKunjungan = New System.Windows.Forms.TextBox()
        Me.TextBox_NoMedRekKunjungan = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TextBox_KeluhanKunjungan = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TextBox_DiagnosaKunjungan = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TextBox_TekananDarahKunjungan = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TextBox_BeratBadanKunjungan = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TextBox_TindakanKunjungan = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.RadioButton_VisitePoliklinikKunjungan = New System.Windows.Forms.RadioButton()
        Me.RadioButton_VisiteRumahKunjungan = New System.Windows.Forms.RadioButton()
        Me.Label_ModeFormKunjungan = New System.Windows.Forms.Label()
        Me.Label_IDKunjungan = New System.Windows.Forms.Label()
        Me.Label_IDPasienKunjungan = New System.Windows.Forms.Label()
        Me.Button_SaveKunjungan = New System.Windows.Forms.Button()
        Me.Button_CancelKunjungan = New System.Windows.Forms.Button()
        Me.Textbox_TanggalKunjunganLagiKunjungan = New System.Windows.Forms.DateTimePicker()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.ComboBox_UnitPoliklinikKunjungan = New System.Windows.Forms.ComboBox()
        Me.SplitContainer10 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button_AddKunjungan = New System.Windows.Forms.Button()
        Me.Button_EditKunjungan = New System.Windows.Forms.Button()
        Me.Button_DeleteKunjungan = New System.Windows.Forms.Button()
        Me.Button_ResetKunjungan = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView_Kunjungan = New System.Windows.Forms.DataGridView()
        Me.ColumnKunjungan_Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnKunjungan_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnKunjungan_Tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnKunjungan_NoMedRek = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnKunjungan_Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnKunjungan_Keluhan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnKunjungan_Diagnosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnKunjungan_TekananDarah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnKunjungan_BeratBadan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnKunjungan_Tindakan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnKunjungan_Visite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnKunjungan_KunjunganLagi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabReporting = New System.Windows.Forms.TabPage()
        Me.SplitContainer11 = New System.Windows.Forms.SplitContainer()
        Me.RadioButtonFilterDual = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFilterSingle = New System.Windows.Forms.RadioButton()
        Me.TextBoxParameter2 = New System.Windows.Forms.TextBox()
        Me.ComboBoxFilterMode2 = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.TextBoxParameter1 = New System.Windows.Forms.TextBox()
        Me.ButtonRefreshReporting = New System.Windows.Forms.Button()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.ComboBoxFilterMode1 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDataEntity = New System.Windows.Forms.ComboBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.kunjunganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dokterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dokterTableAdapter = New RKMedis._db_usedDataSetTableAdapters.dokterTableAdapter()
        Me.petugasTableAdapter = New RKMedis._db_usedDataSetTableAdapters.petugasTableAdapter()
        Me.poliklinikBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.poliklinikTableAdapter = New RKMedis._db_usedDataSetTableAdapters.poliklinikTableAdapter()
        Me.pasienBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pasienTableAdapter = New RKMedis._db_usedDataSetTableAdapters.pasienTableAdapter()
        Me.kunjunganTableAdapter = New RKMedis._db_usedDataSetTableAdapters.kunjunganTableAdapter()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.FlowKunjunganNavigasi = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.petugasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._db_usedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabDokter.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.TableLayoutPanel14.SuspendLayout()
        Me.FlowLayoutPanel9.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.DataGridView_Dokter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPetugas.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TableLayoutPanel15.SuspendLayout()
        Me.FlowLayoutPanel10.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView_Petugas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabHome.SuspendLayout()
        Me.TableLayoutPanel16.SuspendLayout()
        Me.TableLayoutPanel17.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureHome_Dokter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel18.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureHome_Petugas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel19.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel20.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PictureHome_Poliklinik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel21.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.PictureHome_Pasien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPasien.SuspendLayout()
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer7.Panel1.SuspendLayout()
        Me.SplitContainer7.Panel2.SuspendLayout()
        Me.SplitContainer7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.SplitContainer8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer8.Panel1.SuspendLayout()
        Me.SplitContainer8.Panel2.SuspendLayout()
        Me.SplitContainer8.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.FlowLayoutPanel8.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.DataGridView_Pasien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPoliklinik.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.FlowLayoutPanel11.SuspendLayout()
        CType(Me.DataGridView_NamaPetugasPoliklinik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.FlowLayoutPanel7.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        CType(Me.DataGridView_Poliklinik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabKunjungan.SuspendLayout()
        CType(Me.SplitContainer9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer9.Panel1.SuspendLayout()
        Me.SplitContainer9.Panel2.SuspendLayout()
        Me.SplitContainer9.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.SplitContainer10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer10.Panel1.SuspendLayout()
        Me.SplitContainer10.Panel2.SuspendLayout()
        Me.SplitContainer10.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        CType(Me.DataGridView_Kunjungan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabReporting.SuspendLayout()
        CType(Me.SplitContainer11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer11.Panel1.SuspendLayout()
        Me.SplitContainer11.Panel2.SuspendLayout()
        Me.SplitContainer11.SuspendLayout()
        CType(Me.kunjunganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dokterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.poliklinikBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pasienBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox12.SuspendLayout()
        Me.SuspendLayout()
        '
        'petugasBindingSource
        '
        Me.petugasBindingSource.DataMember = "petugas"
        Me.petugasBindingSource.DataSource = Me._db_usedDataSet
        '
        '_db_usedDataSet
        '
        Me._db_usedDataSet.DataSetName = "_db_usedDataSet"
        Me._db_usedDataSet.EnforceConstraints = False
        Me._db_usedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1020, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToolStripMenuItem, Me.ImportToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ImportToolStripMenuItem.Text = "Import"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(119, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripImportButton, Me.ToolStripExportButton, Me.ToolStripSeparator3, Me.ToolStripLabel1, Me.ToolStripSearchText, Me.ToolStripSearchButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1020, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(85, 22)
        Me.ToolStripLabel2.Text = "Database File : "
        '
        'ToolStripImportButton
        '
        Me.ToolStripImportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripImportButton.Image = Global.RKMedis.My.Resources.Resources.import
        Me.ToolStripImportButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripImportButton.Name = "ToolStripImportButton"
        Me.ToolStripImportButton.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripImportButton.Text = "Import data"
        '
        'ToolStripExportButton
        '
        Me.ToolStripExportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripExportButton.Image = CType(resources.GetObject("ToolStripExportButton.Image"), System.Drawing.Image)
        Me.ToolStripExportButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripExportButton.Name = "ToolStripExportButton"
        Me.ToolStripExportButton.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripExportButton.Text = "Export data"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(78, 22)
        Me.ToolStripLabel1.Text = "Search Data : "
        '
        'ToolStripSearchText
        '
        Me.ToolStripSearchText.Enabled = False
        Me.ToolStripSearchText.Name = "ToolStripSearchText"
        Me.ToolStripSearchText.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSearchButton
        '
        Me.ToolStripSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStripSearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSearchButton.Enabled = False
        Me.ToolStripSearchButton.Image = Global.RKMedis.My.Resources.Resources.search
        Me.ToolStripSearchButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSearchButton.Name = "ToolStripSearchButton"
        Me.ToolStripSearchButton.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripSearchButton.Text = "Clear"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.LabelStatusBottom})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 672)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1020, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'LabelStatusBottom
        '
        Me.LabelStatusBottom.Name = "LabelStatusBottom"
        Me.LabelStatusBottom.Size = New System.Drawing.Size(48, 17)
        Me.LabelStatusBottom.Text = "Status..."
        '
        'TabDokter
        '
        Me.TabDokter.Controls.Add(Me.SplitContainer3)
        Me.TabDokter.Location = New System.Drawing.Point(4, 22)
        Me.TabDokter.Name = "TabDokter"
        Me.TabDokter.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDokter.Size = New System.Drawing.Size(1012, 597)
        Me.TabDokter.TabIndex = 1
        Me.TabDokter.Text = "Dokter"
        Me.TabDokter.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox6)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer3.Size = New System.Drawing.Size(1006, 591)
        Me.SplitContainer3.SplitterDistance = 287
        Me.SplitContainer3.TabIndex = 1
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TableLayoutPanel6)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(287, 591)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Data"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.33083!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.66917!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label15, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label16, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Label17, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBox_SpesialisDokter, 1, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBox_NipDokter, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBox_NamaDokter, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBox_KodeDokter, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Button_SaveDokter, 0, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.Button_CancelDokter, 1, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.Label_IDDokter, 0, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.Label_ModeFormDokter, 1, 5)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(35, 44)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 6
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(266, 178)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Nama : "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "NIP :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 54)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Kode :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 81)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Spesialis :"
        '
        'TextBox_SpesialisDokter
        '
        Me.TextBox_SpesialisDokter.Enabled = False
        Me.TextBox_SpesialisDokter.Location = New System.Drawing.Point(89, 84)
        Me.TextBox_SpesialisDokter.Name = "TextBox_SpesialisDokter"
        Me.TextBox_SpesialisDokter.Size = New System.Drawing.Size(129, 20)
        Me.TextBox_SpesialisDokter.TabIndex = 14
        '
        'TextBox_NipDokter
        '
        Me.TextBox_NipDokter.Enabled = False
        Me.TextBox_NipDokter.Location = New System.Drawing.Point(89, 3)
        Me.TextBox_NipDokter.Name = "TextBox_NipDokter"
        Me.TextBox_NipDokter.Size = New System.Drawing.Size(129, 20)
        Me.TextBox_NipDokter.TabIndex = 11
        '
        'TextBox_NamaDokter
        '
        Me.TextBox_NamaDokter.Enabled = False
        Me.TextBox_NamaDokter.Location = New System.Drawing.Point(89, 30)
        Me.TextBox_NamaDokter.Name = "TextBox_NamaDokter"
        Me.TextBox_NamaDokter.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_NamaDokter.TabIndex = 12
        '
        'TextBox_KodeDokter
        '
        Me.TextBox_KodeDokter.Enabled = False
        Me.TextBox_KodeDokter.Location = New System.Drawing.Point(89, 57)
        Me.TextBox_KodeDokter.Name = "TextBox_KodeDokter"
        Me.TextBox_KodeDokter.Size = New System.Drawing.Size(129, 20)
        Me.TextBox_KodeDokter.TabIndex = 13
        '
        'Button_SaveDokter
        '
        Me.Button_SaveDokter.Enabled = False
        Me.Button_SaveDokter.Image = Global.RKMedis.My.Resources.Resources.save16
        Me.Button_SaveDokter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_SaveDokter.Location = New System.Drawing.Point(3, 111)
        Me.Button_SaveDokter.Name = "Button_SaveDokter"
        Me.Button_SaveDokter.Size = New System.Drawing.Size(75, 23)
        Me.Button_SaveDokter.TabIndex = 15
        Me.Button_SaveDokter.Text = "Save"
        Me.Button_SaveDokter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_SaveDokter.UseVisualStyleBackColor = True
        '
        'Button_CancelDokter
        '
        Me.Button_CancelDokter.Enabled = False
        Me.Button_CancelDokter.Location = New System.Drawing.Point(89, 111)
        Me.Button_CancelDokter.Name = "Button_CancelDokter"
        Me.Button_CancelDokter.Size = New System.Drawing.Size(75, 23)
        Me.Button_CancelDokter.TabIndex = 16
        Me.Button_CancelDokter.Text = "Cancel"
        Me.Button_CancelDokter.UseVisualStyleBackColor = True
        '
        'Label_IDDokter
        '
        Me.Label_IDDokter.AutoSize = True
        Me.Label_IDDokter.Location = New System.Drawing.Point(3, 155)
        Me.Label_IDDokter.Name = "Label_IDDokter"
        Me.Label_IDDokter.Size = New System.Drawing.Size(50, 13)
        Me.Label_IDDokter.TabIndex = 11
        Me.Label_IDDokter.Text = "IDDokter"
        Me.Label_IDDokter.Visible = False
        '
        'Label_ModeFormDokter
        '
        Me.Label_ModeFormDokter.AutoSize = True
        Me.Label_ModeFormDokter.Location = New System.Drawing.Point(89, 155)
        Me.Label_ModeFormDokter.Name = "Label_ModeFormDokter"
        Me.Label_ModeFormDokter.Size = New System.Drawing.Size(34, 13)
        Me.Label_ModeFormDokter.TabIndex = 12
        Me.Label_ModeFormDokter.Text = "Mode"
        Me.Label_ModeFormDokter.Visible = False
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.IsSplitterFixed = True
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.TableLayoutPanel14)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.DataGridView_Dokter)
        Me.SplitContainer4.Size = New System.Drawing.Size(715, 591)
        Me.SplitContainer4.SplitterDistance = 93
        Me.SplitContainer4.TabIndex = 0
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.ColumnCount = 1
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.FlowLayoutPanel9, 0, 1)
        Me.TableLayoutPanel14.Controls.Add(Me.FlowLayoutPanel2, 0, 0)
        Me.TableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 2
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(715, 93)
        Me.TableLayoutPanel14.TabIndex = 4
        '
        'FlowLayoutPanel9
        '
        Me.FlowLayoutPanel9.Controls.Add(Me.Label34)
        Me.FlowLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel9.Location = New System.Drawing.Point(3, 49)
        Me.FlowLayoutPanel9.Name = "FlowLayoutPanel9"
        Me.FlowLayoutPanel9.Size = New System.Drawing.Size(709, 41)
        Me.FlowLayoutPanel9.TabIndex = 6
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Image = Global.RKMedis.My.Resources.Resources.doctor32
        Me.Label34.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label34.Location = New System.Drawing.Point(3, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(156, 41)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "Data Dokter"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Button_AddDokter)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button_EditDokter)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button_DeleteDokter)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button_ResetDokter)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(709, 40)
        Me.FlowLayoutPanel2.TabIndex = 4
        '
        'Button_AddDokter
        '
        Me.Button_AddDokter.Image = Global.RKMedis.My.Resources.Resources.add24
        Me.Button_AddDokter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_AddDokter.Location = New System.Drawing.Point(3, 3)
        Me.Button_AddDokter.Name = "Button_AddDokter"
        Me.Button_AddDokter.Size = New System.Drawing.Size(75, 37)
        Me.Button_AddDokter.TabIndex = 17
        Me.Button_AddDokter.Text = "Add"
        Me.Button_AddDokter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_AddDokter.UseVisualStyleBackColor = True
        '
        'Button_EditDokter
        '
        Me.Button_EditDokter.Image = Global.RKMedis.My.Resources.Resources.edit24
        Me.Button_EditDokter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_EditDokter.Location = New System.Drawing.Point(84, 3)
        Me.Button_EditDokter.Name = "Button_EditDokter"
        Me.Button_EditDokter.Size = New System.Drawing.Size(75, 37)
        Me.Button_EditDokter.TabIndex = 18
        Me.Button_EditDokter.Text = "Edit"
        Me.Button_EditDokter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_EditDokter.UseVisualStyleBackColor = True
        '
        'Button_DeleteDokter
        '
        Me.Button_DeleteDokter.Image = Global.RKMedis.My.Resources.Resources.delete24
        Me.Button_DeleteDokter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_DeleteDokter.Location = New System.Drawing.Point(165, 3)
        Me.Button_DeleteDokter.Name = "Button_DeleteDokter"
        Me.Button_DeleteDokter.Size = New System.Drawing.Size(75, 37)
        Me.Button_DeleteDokter.TabIndex = 19
        Me.Button_DeleteDokter.Text = "Delete"
        Me.Button_DeleteDokter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_DeleteDokter.UseVisualStyleBackColor = True
        '
        'Button_ResetDokter
        '
        Me.Button_ResetDokter.Image = Global.RKMedis.My.Resources.Resources.refresh24
        Me.Button_ResetDokter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_ResetDokter.Location = New System.Drawing.Point(246, 3)
        Me.Button_ResetDokter.Name = "Button_ResetDokter"
        Me.Button_ResetDokter.Size = New System.Drawing.Size(79, 37)
        Me.Button_ResetDokter.TabIndex = 20
        Me.Button_ResetDokter.Text = "Refresh"
        Me.Button_ResetDokter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_ResetDokter.UseVisualStyleBackColor = True
        '
        'DataGridView_Dokter
        '
        Me.DataGridView_Dokter.AllowUserToAddRows = False
        Me.DataGridView_Dokter.ColumnHeadersHeight = 35
        Me.DataGridView_Dokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView_Dokter.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnDokter_Check, Me.ColumnDokter_ID, Me.ColumnDokter_NIP, Me.ColumnDokter_Nama, Me.ColumnDokter_Kode, Me.ColumnDokter_Spesialis})
        Me.DataGridView_Dokter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Dokter.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Dokter.Name = "DataGridView_Dokter"
        Me.DataGridView_Dokter.Size = New System.Drawing.Size(715, 494)
        Me.DataGridView_Dokter.TabIndex = 0
        '
        'ColumnDokter_Check
        '
        Me.ColumnDokter_Check.HeaderText = "#"
        Me.ColumnDokter_Check.Name = "ColumnDokter_Check"
        Me.ColumnDokter_Check.Width = 25
        '
        'ColumnDokter_ID
        '
        Me.ColumnDokter_ID.HeaderText = "#"
        Me.ColumnDokter_ID.Name = "ColumnDokter_ID"
        Me.ColumnDokter_ID.Visible = False
        '
        'ColumnDokter_NIP
        '
        Me.ColumnDokter_NIP.HeaderText = "NIP"
        Me.ColumnDokter_NIP.Name = "ColumnDokter_NIP"
        Me.ColumnDokter_NIP.Width = 45
        '
        'ColumnDokter_Nama
        '
        Me.ColumnDokter_Nama.HeaderText = "Nama"
        Me.ColumnDokter_Nama.Name = "ColumnDokter_Nama"
        '
        'ColumnDokter_Kode
        '
        Me.ColumnDokter_Kode.HeaderText = "Kode"
        Me.ColumnDokter_Kode.Name = "ColumnDokter_Kode"
        '
        'ColumnDokter_Spesialis
        '
        Me.ColumnDokter_Spesialis.HeaderText = "Spesialis"
        Me.ColumnDokter_Spesialis.Name = "ColumnDokter_Spesialis"
        '
        'TabPetugas
        '
        Me.TabPetugas.Controls.Add(Me.SplitContainer1)
        Me.TabPetugas.Location = New System.Drawing.Point(4, 22)
        Me.TabPetugas.Name = "TabPetugas"
        Me.TabPetugas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPetugas.Size = New System.Drawing.Size(1012, 597)
        Me.TabPetugas.TabIndex = 0
        Me.TabPetugas.Text = "Petugas"
        Me.TabPetugas.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox5)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1006, 591)
        Me.SplitContainer1.SplitterDistance = 287
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TableLayoutPanel5)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(287, 591)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Data"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.33083!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.66917!))
        Me.TableLayoutPanel5.Controls.Add(Me.TextBox_TelpPetugas, 1, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TextBox_NipPetugas, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label11, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label12, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Label13, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.TextBox_NamaPetugas, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TextBox_JabatanPetugas, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Button_SavePetugas, 0, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.Button_CancelPetugas, 1, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.Label_IDPetugas, 0, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.Label_ModeFormPetugas, 1, 5)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(35, 44)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 6
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(266, 178)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'TextBox_TelpPetugas
        '
        Me.TextBox_TelpPetugas.Enabled = False
        Me.TextBox_TelpPetugas.Location = New System.Drawing.Point(89, 84)
        Me.TextBox_TelpPetugas.Name = "TextBox_TelpPetugas"
        Me.TextBox_TelpPetugas.Size = New System.Drawing.Size(129, 20)
        Me.TextBox_TelpPetugas.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "NIP :"
        '
        'TextBox_NipPetugas
        '
        Me.TextBox_NipPetugas.Enabled = False
        Me.TextBox_NipPetugas.Location = New System.Drawing.Point(89, 3)
        Me.TextBox_NipPetugas.Name = "TextBox_NipPetugas"
        Me.TextBox_NipPetugas.Size = New System.Drawing.Size(129, 20)
        Me.TextBox_NipPetugas.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Nama : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Jabatan : "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Telp : "
        '
        'TextBox_NamaPetugas
        '
        Me.TextBox_NamaPetugas.Enabled = False
        Me.TextBox_NamaPetugas.Location = New System.Drawing.Point(89, 30)
        Me.TextBox_NamaPetugas.Name = "TextBox_NamaPetugas"
        Me.TextBox_NamaPetugas.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_NamaPetugas.TabIndex = 2
        '
        'TextBox_JabatanPetugas
        '
        Me.TextBox_JabatanPetugas.Enabled = False
        Me.TextBox_JabatanPetugas.Location = New System.Drawing.Point(89, 57)
        Me.TextBox_JabatanPetugas.Name = "TextBox_JabatanPetugas"
        Me.TextBox_JabatanPetugas.Size = New System.Drawing.Size(129, 20)
        Me.TextBox_JabatanPetugas.TabIndex = 3
        '
        'Button_SavePetugas
        '
        Me.Button_SavePetugas.Enabled = False
        Me.Button_SavePetugas.Image = Global.RKMedis.My.Resources.Resources.save16
        Me.Button_SavePetugas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_SavePetugas.Location = New System.Drawing.Point(3, 111)
        Me.Button_SavePetugas.Name = "Button_SavePetugas"
        Me.Button_SavePetugas.Size = New System.Drawing.Size(75, 23)
        Me.Button_SavePetugas.TabIndex = 5
        Me.Button_SavePetugas.Text = "Save"
        Me.Button_SavePetugas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_SavePetugas.UseVisualStyleBackColor = True
        '
        'Button_CancelPetugas
        '
        Me.Button_CancelPetugas.Enabled = False
        Me.Button_CancelPetugas.Location = New System.Drawing.Point(89, 111)
        Me.Button_CancelPetugas.Name = "Button_CancelPetugas"
        Me.Button_CancelPetugas.Size = New System.Drawing.Size(75, 23)
        Me.Button_CancelPetugas.TabIndex = 6
        Me.Button_CancelPetugas.Text = "Cancel"
        Me.Button_CancelPetugas.UseVisualStyleBackColor = True
        '
        'Label_IDPetugas
        '
        Me.Label_IDPetugas.AutoSize = True
        Me.Label_IDPetugas.Location = New System.Drawing.Point(3, 155)
        Me.Label_IDPetugas.Name = "Label_IDPetugas"
        Me.Label_IDPetugas.Size = New System.Drawing.Size(57, 13)
        Me.Label_IDPetugas.TabIndex = 11
        Me.Label_IDPetugas.Text = "IDPetugas"
        Me.Label_IDPetugas.Visible = False
        '
        'Label_ModeFormPetugas
        '
        Me.Label_ModeFormPetugas.AutoSize = True
        Me.Label_ModeFormPetugas.Location = New System.Drawing.Point(89, 155)
        Me.Label_ModeFormPetugas.Name = "Label_ModeFormPetugas"
        Me.Label_ModeFormPetugas.Size = New System.Drawing.Size(34, 13)
        Me.Label_ModeFormPetugas.TabIndex = 12
        Me.Label_ModeFormPetugas.Text = "Mode"
        Me.Label_ModeFormPetugas.Visible = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TableLayoutPanel15)
        Me.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridView_Petugas)
        Me.SplitContainer2.Size = New System.Drawing.Size(715, 591)
        Me.SplitContainer2.SplitterDistance = 93
        Me.SplitContainer2.TabIndex = 0
        '
        'TableLayoutPanel15
        '
        Me.TableLayoutPanel15.ColumnCount = 1
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.Controls.Add(Me.FlowLayoutPanel10, 0, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel15.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
        Me.TableLayoutPanel15.RowCount = 2
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.Size = New System.Drawing.Size(715, 93)
        Me.TableLayoutPanel15.TabIndex = 4
        '
        'FlowLayoutPanel10
        '
        Me.FlowLayoutPanel10.Controls.Add(Me.Label40)
        Me.FlowLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel10.Location = New System.Drawing.Point(3, 49)
        Me.FlowLayoutPanel10.Name = "FlowLayoutPanel10"
        Me.FlowLayoutPanel10.Size = New System.Drawing.Size(709, 41)
        Me.FlowLayoutPanel10.TabIndex = 6
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Image = Global.RKMedis.My.Resources.Resources.staff32
        Me.Label40.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label40.Location = New System.Drawing.Point(3, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(172, 35)
        Me.Label40.TabIndex = 0
        Me.Label40.Text = "Data Petugas"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Button_AddPetugas)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button_EditPetugas)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button_DeletePetugas)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button_ResetPetugas)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(709, 40)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'Button_AddPetugas
        '
        Me.Button_AddPetugas.Image = Global.RKMedis.My.Resources.Resources.add24
        Me.Button_AddPetugas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_AddPetugas.Location = New System.Drawing.Point(3, 3)
        Me.Button_AddPetugas.Name = "Button_AddPetugas"
        Me.Button_AddPetugas.Size = New System.Drawing.Size(75, 37)
        Me.Button_AddPetugas.TabIndex = 7
        Me.Button_AddPetugas.Text = "Add"
        Me.Button_AddPetugas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_AddPetugas.UseVisualStyleBackColor = True
        '
        'Button_EditPetugas
        '
        Me.Button_EditPetugas.Image = Global.RKMedis.My.Resources.Resources.edit24
        Me.Button_EditPetugas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_EditPetugas.Location = New System.Drawing.Point(84, 3)
        Me.Button_EditPetugas.Name = "Button_EditPetugas"
        Me.Button_EditPetugas.Size = New System.Drawing.Size(75, 37)
        Me.Button_EditPetugas.TabIndex = 8
        Me.Button_EditPetugas.Text = "Edit"
        Me.Button_EditPetugas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_EditPetugas.UseVisualStyleBackColor = True
        '
        'Button_DeletePetugas
        '
        Me.Button_DeletePetugas.Image = Global.RKMedis.My.Resources.Resources.delete24
        Me.Button_DeletePetugas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_DeletePetugas.Location = New System.Drawing.Point(165, 3)
        Me.Button_DeletePetugas.Name = "Button_DeletePetugas"
        Me.Button_DeletePetugas.Size = New System.Drawing.Size(75, 37)
        Me.Button_DeletePetugas.TabIndex = 9
        Me.Button_DeletePetugas.Text = "Delete"
        Me.Button_DeletePetugas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_DeletePetugas.UseVisualStyleBackColor = True
        '
        'Button_ResetPetugas
        '
        Me.Button_ResetPetugas.Image = Global.RKMedis.My.Resources.Resources.refresh24
        Me.Button_ResetPetugas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_ResetPetugas.Location = New System.Drawing.Point(246, 3)
        Me.Button_ResetPetugas.Name = "Button_ResetPetugas"
        Me.Button_ResetPetugas.Size = New System.Drawing.Size(78, 37)
        Me.Button_ResetPetugas.TabIndex = 10
        Me.Button_ResetPetugas.Text = "Refresh"
        Me.Button_ResetPetugas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_ResetPetugas.UseVisualStyleBackColor = True
        '
        'DataGridView_Petugas
        '
        Me.DataGridView_Petugas.AllowUserToAddRows = False
        Me.DataGridView_Petugas.ColumnHeadersHeight = 35
        Me.DataGridView_Petugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView_Petugas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnPetugas_Check, Me.ColumnPetugas_ID, Me.ColumnPetugas_NIP, Me.ColumnPetugas_Nama, Me.ColumnPetugas_Jabatan, Me.ColumnPetugas_Telp})
        Me.DataGridView_Petugas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Petugas.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Petugas.Name = "DataGridView_Petugas"
        Me.DataGridView_Petugas.Size = New System.Drawing.Size(715, 494)
        Me.DataGridView_Petugas.TabIndex = 0
        '
        'ColumnPetugas_Check
        '
        Me.ColumnPetugas_Check.HeaderText = "#"
        Me.ColumnPetugas_Check.Name = "ColumnPetugas_Check"
        Me.ColumnPetugas_Check.Width = 25
        '
        'ColumnPetugas_ID
        '
        Me.ColumnPetugas_ID.HeaderText = "#"
        Me.ColumnPetugas_ID.Name = "ColumnPetugas_ID"
        Me.ColumnPetugas_ID.Visible = False
        '
        'ColumnPetugas_NIP
        '
        Me.ColumnPetugas_NIP.HeaderText = "NIP"
        Me.ColumnPetugas_NIP.Name = "ColumnPetugas_NIP"
        Me.ColumnPetugas_NIP.Width = 45
        '
        'ColumnPetugas_Nama
        '
        Me.ColumnPetugas_Nama.HeaderText = "Nama"
        Me.ColumnPetugas_Nama.Name = "ColumnPetugas_Nama"
        '
        'ColumnPetugas_Jabatan
        '
        Me.ColumnPetugas_Jabatan.HeaderText = "Jabatan"
        Me.ColumnPetugas_Jabatan.Name = "ColumnPetugas_Jabatan"
        '
        'ColumnPetugas_Telp
        '
        Me.ColumnPetugas_Telp.HeaderText = "Telp"
        Me.ColumnPetugas_Telp.Name = "ColumnPetugas_Telp"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabHome)
        Me.TabControl1.Controls.Add(Me.TabPetugas)
        Me.TabControl1.Controls.Add(Me.TabDokter)
        Me.TabControl1.Controls.Add(Me.TabPasien)
        Me.TabControl1.Controls.Add(Me.TabPoliklinik)
        Me.TabControl1.Controls.Add(Me.TabKunjungan)
        Me.TabControl1.Controls.Add(Me.TabReporting)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 49)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1020, 623)
        Me.TabControl1.TabIndex = 4
        '
        'TabHome
        '
        Me.TabHome.Controls.Add(Me.TableLayoutPanel16)
        Me.TabHome.Controls.Add(Me.Label3)
        Me.TabHome.Location = New System.Drawing.Point(4, 22)
        Me.TabHome.Name = "TabHome"
        Me.TabHome.Size = New System.Drawing.Size(1012, 597)
        Me.TabHome.TabIndex = 5
        Me.TabHome.Text = "Home"
        Me.TabHome.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel16
        '
        Me.TableLayoutPanel16.ColumnCount = 3
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.52488!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.47512!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 344.0!))
        Me.TableLayoutPanel16.Controls.Add(Me.TableLayoutPanel17, 0, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.TableLayoutPanel18, 1, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.TableLayoutPanel19, 2, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.TableLayoutPanel20, 0, 1)
        Me.TableLayoutPanel16.Controls.Add(Me.TableLayoutPanel21, 1, 1)
        Me.TableLayoutPanel16.Location = New System.Drawing.Point(54, 90)
        Me.TableLayoutPanel16.Name = "TableLayoutPanel16"
        Me.TableLayoutPanel16.RowCount = 2
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel16.Size = New System.Drawing.Size(1000, 403)
        Me.TableLayoutPanel16.TabIndex = 8
        '
        'TableLayoutPanel17
        '
        Me.TableLayoutPanel17.ColumnCount = 2
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252.0!))
        Me.TableLayoutPanel17.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel17.Controls.Add(Me.PictureHome_Dokter, 0, 0)
        Me.TableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel17.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel17.Name = "TableLayoutPanel17"
        Me.TableLayoutPanel17.RowCount = 1
        Me.TableLayoutPanel17.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel17.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel17.Size = New System.Drawing.Size(332, 195)
        Me.TableLayoutPanel17.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(83, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(246, 189)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dokter"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label_JumlahDataDokter, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonHome_AddDokter, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonHome_ReportDokter, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 22)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.55102!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.44898!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(240, 164)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'Label_JumlahDataDokter
        '
        Me.Label_JumlahDataDokter.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_JumlahDataDokter.AutoSize = True
        Me.Label_JumlahDataDokter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label_JumlahDataDokter.Location = New System.Drawing.Point(123, 6)
        Me.Label_JumlahDataDokter.Name = "Label_JumlahDataDokter"
        Me.Label_JumlahDataDokter.Size = New System.Drawing.Size(114, 13)
        Me.Label_JumlahDataDokter.TabIndex = 1
        Me.Label_JumlahDataDokter.Text = "0 Data"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(3, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total :"
        '
        'ButtonHome_AddDokter
        '
        Me.ButtonHome_AddDokter.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHome_AddDokter.BackgroundImage = Global.RKMedis.My.Resources.Resources.add
        Me.ButtonHome_AddDokter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonHome_AddDokter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ButtonHome_AddDokter.Location = New System.Drawing.Point(3, 41)
        Me.ButtonHome_AddDokter.Name = "ButtonHome_AddDokter"
        Me.ButtonHome_AddDokter.Size = New System.Drawing.Size(114, 38)
        Me.ButtonHome_AddDokter.TabIndex = 2
        Me.ButtonHome_AddDokter.Text = "Add Data"
        Me.ButtonHome_AddDokter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonHome_AddDokter.UseVisualStyleBackColor = True
        '
        'ButtonHome_ReportDokter
        '
        Me.ButtonHome_ReportDokter.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHome_ReportDokter.BackgroundImage = CType(resources.GetObject("ButtonHome_ReportDokter.BackgroundImage"), System.Drawing.Image)
        Me.ButtonHome_ReportDokter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonHome_ReportDokter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ButtonHome_ReportDokter.Location = New System.Drawing.Point(3, 110)
        Me.ButtonHome_ReportDokter.Name = "ButtonHome_ReportDokter"
        Me.ButtonHome_ReportDokter.Size = New System.Drawing.Size(114, 38)
        Me.ButtonHome_ReportDokter.TabIndex = 3
        Me.ButtonHome_ReportDokter.Text = "Report"
        Me.ButtonHome_ReportDokter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonHome_ReportDokter.UseVisualStyleBackColor = True
        '
        'PictureHome_Dokter
        '
        Me.PictureHome_Dokter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureHome_Dokter.BackgroundImage = Global.RKMedis.My.Resources.Resources.doctor
        Me.PictureHome_Dokter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureHome_Dokter.Location = New System.Drawing.Point(3, 3)
        Me.PictureHome_Dokter.Name = "PictureHome_Dokter"
        Me.PictureHome_Dokter.Size = New System.Drawing.Size(74, 189)
        Me.PictureHome_Dokter.TabIndex = 2
        Me.PictureHome_Dokter.TabStop = False
        '
        'TableLayoutPanel18
        '
        Me.TableLayoutPanel18.ColumnCount = 2
        Me.TableLayoutPanel18.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel18.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.TableLayoutPanel18.Controls.Add(Me.GroupBox1, 1, 0)
        Me.TableLayoutPanel18.Controls.Add(Me.PictureHome_Petugas, 0, 0)
        Me.TableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel18.Location = New System.Drawing.Point(341, 3)
        Me.TableLayoutPanel18.Name = "TableLayoutPanel18"
        Me.TableLayoutPanel18.RowCount = 1
        Me.TableLayoutPanel18.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel18.Size = New System.Drawing.Size(311, 195)
        Me.TableLayoutPanel18.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(106, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 189)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Petugas"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label_JumlahDataPetugas, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonHome_AddPetugas, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonHome_ReportPetugas, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 22)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.34328!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.65672!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(196, 164)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Label_JumlahDataPetugas
        '
        Me.Label_JumlahDataPetugas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_JumlahDataPetugas.AutoSize = True
        Me.Label_JumlahDataPetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label_JumlahDataPetugas.Location = New System.Drawing.Point(101, 8)
        Me.Label_JumlahDataPetugas.Name = "Label_JumlahDataPetugas"
        Me.Label_JumlahDataPetugas.Size = New System.Drawing.Size(92, 13)
        Me.Label_JumlahDataPetugas.TabIndex = 1
        Me.Label_JumlahDataPetugas.Text = "0 Data"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total :"
        '
        'ButtonHome_AddPetugas
        '
        Me.ButtonHome_AddPetugas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHome_AddPetugas.BackgroundImage = Global.RKMedis.My.Resources.Resources.add
        Me.ButtonHome_AddPetugas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonHome_AddPetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ButtonHome_AddPetugas.Location = New System.Drawing.Point(3, 42)
        Me.ButtonHome_AddPetugas.Name = "ButtonHome_AddPetugas"
        Me.ButtonHome_AddPetugas.Size = New System.Drawing.Size(92, 38)
        Me.ButtonHome_AddPetugas.TabIndex = 2
        Me.ButtonHome_AddPetugas.Text = "Add Data"
        Me.ButtonHome_AddPetugas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonHome_AddPetugas.UseVisualStyleBackColor = True
        '
        'ButtonHome_ReportPetugas
        '
        Me.ButtonHome_ReportPetugas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHome_ReportPetugas.BackgroundImage = CType(resources.GetObject("ButtonHome_ReportPetugas.BackgroundImage"), System.Drawing.Image)
        Me.ButtonHome_ReportPetugas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonHome_ReportPetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ButtonHome_ReportPetugas.Location = New System.Drawing.Point(3, 110)
        Me.ButtonHome_ReportPetugas.Name = "ButtonHome_ReportPetugas"
        Me.ButtonHome_ReportPetugas.Size = New System.Drawing.Size(92, 38)
        Me.ButtonHome_ReportPetugas.TabIndex = 3
        Me.ButtonHome_ReportPetugas.Text = "Report"
        Me.ButtonHome_ReportPetugas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonHome_ReportPetugas.UseVisualStyleBackColor = True
        '
        'PictureHome_Petugas
        '
        Me.PictureHome_Petugas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureHome_Petugas.BackgroundImage = Global.RKMedis.My.Resources.Resources.staff
        Me.PictureHome_Petugas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureHome_Petugas.Location = New System.Drawing.Point(3, 3)
        Me.PictureHome_Petugas.Name = "PictureHome_Petugas"
        Me.PictureHome_Petugas.Size = New System.Drawing.Size(97, 189)
        Me.PictureHome_Petugas.TabIndex = 2
        Me.PictureHome_Petugas.TabStop = False
        '
        'TableLayoutPanel19
        '
        Me.TableLayoutPanel19.ColumnCount = 2
        Me.TableLayoutPanel19.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25!))
        Me.TableLayoutPanel19.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.75!))
        Me.TableLayoutPanel19.Controls.Add(Me.GroupBox10, 1, 0)
        Me.TableLayoutPanel19.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel19.Location = New System.Drawing.Point(658, 3)
        Me.TableLayoutPanel19.Name = "TableLayoutPanel19"
        Me.TableLayoutPanel19.RowCount = 1
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel19.Size = New System.Drawing.Size(339, 195)
        Me.TableLayoutPanel19.TabIndex = 2
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.TableLayoutPanel10)
        Me.GroupBox10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(108, 3)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(228, 189)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Kunjungan"
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.Label_JumlahDataKunjungan, 1, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.ButtonHome_AddKunjungan, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.ButtonHome_ReportKunjungan, 0, 2)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 22)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 3
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.34328!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.65672!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(222, 164)
        Me.TableLayoutPanel10.TabIndex = 2
        '
        'Label_JumlahDataKunjungan
        '
        Me.Label_JumlahDataKunjungan.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_JumlahDataKunjungan.AutoSize = True
        Me.Label_JumlahDataKunjungan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label_JumlahDataKunjungan.Location = New System.Drawing.Point(114, 8)
        Me.Label_JumlahDataKunjungan.Name = "Label_JumlahDataKunjungan"
        Me.Label_JumlahDataKunjungan.Size = New System.Drawing.Size(105, 13)
        Me.Label_JumlahDataKunjungan.TabIndex = 1
        Me.Label_JumlahDataKunjungan.Text = "0 Data"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(3, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total :"
        '
        'ButtonHome_AddKunjungan
        '
        Me.ButtonHome_AddKunjungan.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHome_AddKunjungan.BackgroundImage = Global.RKMedis.My.Resources.Resources.add
        Me.ButtonHome_AddKunjungan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonHome_AddKunjungan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ButtonHome_AddKunjungan.Location = New System.Drawing.Point(3, 42)
        Me.ButtonHome_AddKunjungan.Name = "ButtonHome_AddKunjungan"
        Me.ButtonHome_AddKunjungan.Size = New System.Drawing.Size(105, 38)
        Me.ButtonHome_AddKunjungan.TabIndex = 2
        Me.ButtonHome_AddKunjungan.Text = "Add Data"
        Me.ButtonHome_AddKunjungan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonHome_AddKunjungan.UseVisualStyleBackColor = True
        '
        'ButtonHome_ReportKunjungan
        '
        Me.ButtonHome_ReportKunjungan.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHome_ReportKunjungan.BackgroundImage = CType(resources.GetObject("ButtonHome_ReportKunjungan.BackgroundImage"), System.Drawing.Image)
        Me.ButtonHome_ReportKunjungan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonHome_ReportKunjungan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ButtonHome_ReportKunjungan.Location = New System.Drawing.Point(3, 110)
        Me.ButtonHome_ReportKunjungan.Name = "ButtonHome_ReportKunjungan"
        Me.ButtonHome_ReportKunjungan.Size = New System.Drawing.Size(105, 38)
        Me.ButtonHome_ReportKunjungan.TabIndex = 3
        Me.ButtonHome_ReportKunjungan.Text = "Report"
        Me.ButtonHome_ReportKunjungan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonHome_ReportKunjungan.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.RKMedis.My.Resources.Resources.schedule
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 189)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel20
        '
        Me.TableLayoutPanel20.ColumnCount = 2
        Me.TableLayoutPanel20.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.TableLayoutPanel20.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857!))
        Me.TableLayoutPanel20.Controls.Add(Me.GroupBox3, 1, 0)
        Me.TableLayoutPanel20.Controls.Add(Me.PictureHome_Poliklinik, 0, 0)
        Me.TableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel20.Location = New System.Drawing.Point(3, 204)
        Me.TableLayoutPanel20.Name = "TableLayoutPanel20"
        Me.TableLayoutPanel20.RowCount = 1
        Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel20.Size = New System.Drawing.Size(332, 196)
        Me.TableLayoutPanel20.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(97, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 190)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Poliklinik"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label_JumlahDataPoliklinik, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonHome_AddPoliklinik, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonHome_ReportPoliklinik, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 22)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.50685!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.49315!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(226, 165)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'Label_JumlahDataPoliklinik
        '
        Me.Label_JumlahDataPoliklinik.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_JumlahDataPoliklinik.AutoSize = True
        Me.Label_JumlahDataPoliklinik.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label_JumlahDataPoliklinik.Location = New System.Drawing.Point(116, 8)
        Me.Label_JumlahDataPoliklinik.Name = "Label_JumlahDataPoliklinik"
        Me.Label_JumlahDataPoliklinik.Size = New System.Drawing.Size(107, 13)
        Me.Label_JumlahDataPoliklinik.TabIndex = 1
        Me.Label_JumlahDataPoliklinik.Text = "0 Data"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(3, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total :"
        '
        'ButtonHome_AddPoliklinik
        '
        Me.ButtonHome_AddPoliklinik.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHome_AddPoliklinik.BackgroundImage = Global.RKMedis.My.Resources.Resources.add
        Me.ButtonHome_AddPoliklinik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonHome_AddPoliklinik.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ButtonHome_AddPoliklinik.Location = New System.Drawing.Point(3, 44)
        Me.ButtonHome_AddPoliklinik.Name = "ButtonHome_AddPoliklinik"
        Me.ButtonHome_AddPoliklinik.Size = New System.Drawing.Size(107, 38)
        Me.ButtonHome_AddPoliklinik.TabIndex = 2
        Me.ButtonHome_AddPoliklinik.Text = "Add Data"
        Me.ButtonHome_AddPoliklinik.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonHome_AddPoliklinik.UseVisualStyleBackColor = True
        '
        'ButtonHome_ReportPoliklinik
        '
        Me.ButtonHome_ReportPoliklinik.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHome_ReportPoliklinik.BackgroundImage = CType(resources.GetObject("ButtonHome_ReportPoliklinik.BackgroundImage"), System.Drawing.Image)
        Me.ButtonHome_ReportPoliklinik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonHome_ReportPoliklinik.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ButtonHome_ReportPoliklinik.Location = New System.Drawing.Point(3, 111)
        Me.ButtonHome_ReportPoliklinik.Name = "ButtonHome_ReportPoliklinik"
        Me.ButtonHome_ReportPoliklinik.Size = New System.Drawing.Size(107, 38)
        Me.ButtonHome_ReportPoliklinik.TabIndex = 3
        Me.ButtonHome_ReportPoliklinik.Text = "Report"
        Me.ButtonHome_ReportPoliklinik.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonHome_ReportPoliklinik.UseVisualStyleBackColor = True
        '
        'PictureHome_Poliklinik
        '
        Me.PictureHome_Poliklinik.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureHome_Poliklinik.BackgroundImage = Global.RKMedis.My.Resources.Resources.door
        Me.PictureHome_Poliklinik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureHome_Poliklinik.Location = New System.Drawing.Point(3, 3)
        Me.PictureHome_Poliklinik.Name = "PictureHome_Poliklinik"
        Me.PictureHome_Poliklinik.Size = New System.Drawing.Size(88, 190)
        Me.PictureHome_Poliklinik.TabIndex = 2
        Me.PictureHome_Poliklinik.TabStop = False
        '
        'TableLayoutPanel21
        '
        Me.TableLayoutPanel21.ColumnCount = 2
        Me.TableLayoutPanel21.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.53659!))
        Me.TableLayoutPanel21.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.46342!))
        Me.TableLayoutPanel21.Controls.Add(Me.GroupBox4, 1, 0)
        Me.TableLayoutPanel21.Controls.Add(Me.PictureHome_Pasien, 0, 0)
        Me.TableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel21.Location = New System.Drawing.Point(341, 204)
        Me.TableLayoutPanel21.Name = "TableLayoutPanel21"
        Me.TableLayoutPanel21.RowCount = 1
        Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel21.Size = New System.Drawing.Size(311, 196)
        Me.TableLayoutPanel21.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(107, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(201, 190)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pasien"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label_JumlahDataPasien, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.ButtonHome_AddPasien, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.ButtonHome_ReportPasien, 0, 2)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 22)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.71429!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.28571!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(195, 165)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'Label_JumlahDataPasien
        '
        Me.Label_JumlahDataPasien.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_JumlahDataPasien.AutoSize = True
        Me.Label_JumlahDataPasien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label_JumlahDataPasien.Location = New System.Drawing.Point(100, 12)
        Me.Label_JumlahDataPasien.Name = "Label_JumlahDataPasien"
        Me.Label_JumlahDataPasien.Size = New System.Drawing.Size(92, 13)
        Me.Label_JumlahDataPasien.TabIndex = 1
        Me.Label_JumlahDataPasien.Text = "0 Data"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(3, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Total :"
        '
        'ButtonHome_AddPasien
        '
        Me.ButtonHome_AddPasien.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHome_AddPasien.BackgroundImage = Global.RKMedis.My.Resources.Resources.add
        Me.ButtonHome_AddPasien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonHome_AddPasien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ButtonHome_AddPasien.Location = New System.Drawing.Point(3, 51)
        Me.ButtonHome_AddPasien.Name = "ButtonHome_AddPasien"
        Me.ButtonHome_AddPasien.Size = New System.Drawing.Size(91, 38)
        Me.ButtonHome_AddPasien.TabIndex = 2
        Me.ButtonHome_AddPasien.Text = "Add Data"
        Me.ButtonHome_AddPasien.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonHome_AddPasien.UseVisualStyleBackColor = True
        '
        'ButtonHome_ReportPasien
        '
        Me.ButtonHome_ReportPasien.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHome_ReportPasien.BackgroundImage = CType(resources.GetObject("ButtonHome_ReportPasien.BackgroundImage"), System.Drawing.Image)
        Me.ButtonHome_ReportPasien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonHome_ReportPasien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ButtonHome_ReportPasien.Location = New System.Drawing.Point(3, 115)
        Me.ButtonHome_ReportPasien.Name = "ButtonHome_ReportPasien"
        Me.ButtonHome_ReportPasien.Size = New System.Drawing.Size(91, 38)
        Me.ButtonHome_ReportPasien.TabIndex = 3
        Me.ButtonHome_ReportPasien.Text = "Report"
        Me.ButtonHome_ReportPasien.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonHome_ReportPasien.UseVisualStyleBackColor = True
        '
        'PictureHome_Pasien
        '
        Me.PictureHome_Pasien.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureHome_Pasien.BackgroundImage = Global.RKMedis.My.Resources.Resources.patient
        Me.PictureHome_Pasien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureHome_Pasien.Location = New System.Drawing.Point(3, 3)
        Me.PictureHome_Pasien.Name = "PictureHome_Pasien"
        Me.PictureHome_Pasien.Size = New System.Drawing.Size(98, 190)
        Me.PictureHome_Pasien.TabIndex = 2
        Me.PictureHome_Pasien.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(366, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 43)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Home"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPasien
        '
        Me.TabPasien.Controls.Add(Me.SplitContainer7)
        Me.TabPasien.Location = New System.Drawing.Point(4, 22)
        Me.TabPasien.Name = "TabPasien"
        Me.TabPasien.Size = New System.Drawing.Size(1012, 597)
        Me.TabPasien.TabIndex = 2
        Me.TabPasien.Text = "Pasien"
        Me.TabPasien.UseVisualStyleBackColor = True
        '
        'SplitContainer7
        '
        Me.SplitContainer7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer7.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer7.Name = "SplitContainer7"
        '
        'SplitContainer7.Panel1
        '
        Me.SplitContainer7.Panel1.Controls.Add(Me.GroupBox8)
        '
        'SplitContainer7.Panel2
        '
        Me.SplitContainer7.Panel2.Controls.Add(Me.SplitContainer8)
        Me.SplitContainer7.Size = New System.Drawing.Size(1012, 597)
        Me.SplitContainer7.SplitterDistance = 288
        Me.SplitContainer7.TabIndex = 2
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TableLayoutPanel8)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox8.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(288, 597)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Data"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.33083!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.66917!))
        Me.TableLayoutPanel8.Controls.Add(Me.Label21, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.Label22, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Label23, 0, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.Label24, 0, 3)
        Me.TableLayoutPanel8.Controls.Add(Me.TextBox_NamaPasien, 1, 3)
        Me.TableLayoutPanel8.Controls.Add(Me.TextBox_NoMedRekPasien, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Label27, 0, 4)
        Me.TableLayoutPanel8.Controls.Add(Me.Textbox_TanggalLahirPasien, 1, 4)
        Me.TableLayoutPanel8.Controls.Add(Me.Label28, 0, 5)
        Me.TableLayoutPanel8.Controls.Add(Me.TextBox_TempatLahirPasien, 1, 5)
        Me.TableLayoutPanel8.Controls.Add(Me.Label29, 0, 6)
        Me.TableLayoutPanel8.Controls.Add(Me.Panel3, 1, 6)
        Me.TableLayoutPanel8.Controls.Add(Me.Button_SavePasien, 0, 11)
        Me.TableLayoutPanel8.Controls.Add(Me.Button_CancelPasien, 1, 11)
        Me.TableLayoutPanel8.Controls.Add(Me.Label_IDPasien, 0, 10)
        Me.TableLayoutPanel8.Controls.Add(Me.Label_ModeFormPasien, 1, 10)
        Me.TableLayoutPanel8.Controls.Add(Me.Label30, 0, 7)
        Me.TableLayoutPanel8.Controls.Add(Me.TextBox_AlamatPasien, 1, 7)
        Me.TableLayoutPanel8.Controls.Add(Me.TextBox_TelpPasien, 1, 8)
        Me.TableLayoutPanel8.Controls.Add(Me.Label31, 0, 8)
        Me.TableLayoutPanel8.Controls.Add(Me.TextBox_TanggalBuatPasien, 1, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.Combobox_StatusPasien, 1, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.Label2, 0, 9)
        Me.TableLayoutPanel8.Controls.Add(Me.TextBox_CatatanPasien, 1, 9)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(35, 44)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 12
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.43363!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.77876!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.43363!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.80925!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(266, 472)
        Me.TableLayoutPanel8.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 13)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Status : "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 13)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "No.Medrek :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(3, 61)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 26)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "Tanggal Pembuatan : "
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(3, 93)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(44, 13)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "Nama : "
        '
        'TextBox_NamaPasien
        '
        Me.TextBox_NamaPasien.Enabled = False
        Me.TextBox_NamaPasien.Location = New System.Drawing.Point(89, 96)
        Me.TextBox_NamaPasien.Name = "TextBox_NamaPasien"
        Me.TextBox_NamaPasien.Size = New System.Drawing.Size(129, 20)
        Me.TextBox_NamaPasien.TabIndex = 24
        '
        'TextBox_NoMedRekPasien
        '
        Me.TextBox_NoMedRekPasien.Enabled = False
        Me.TextBox_NoMedRekPasien.Location = New System.Drawing.Point(89, 3)
        Me.TextBox_NoMedRekPasien.Name = "TextBox_NoMedRekPasien"
        Me.TextBox_NoMedRekPasien.Size = New System.Drawing.Size(129, 20)
        Me.TextBox_NoMedRekPasien.TabIndex = 21
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(3, 117)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(78, 13)
        Me.Label27.TabIndex = 13
        Me.Label27.Text = "Tanggal Lahir : "
        '
        'Textbox_TanggalLahirPasien
        '
        Me.Textbox_TanggalLahirPasien.CustomFormat = "dd MMMM yyyy"
        Me.Textbox_TanggalLahirPasien.Enabled = False
        Me.Textbox_TanggalLahirPasien.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Textbox_TanggalLahirPasien.Location = New System.Drawing.Point(89, 120)
        Me.Textbox_TanggalLahirPasien.Name = "Textbox_TanggalLahirPasien"
        Me.Textbox_TanggalLahirPasien.Size = New System.Drawing.Size(129, 20)
        Me.Textbox_TanggalLahirPasien.TabIndex = 25
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(3, 147)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(75, 13)
        Me.Label28.TabIndex = 15
        Me.Label28.Text = "Tempat Lahir :"
        '
        'TextBox_TempatLahirPasien
        '
        Me.TextBox_TempatLahirPasien.Enabled = False
        Me.TextBox_TempatLahirPasien.Location = New System.Drawing.Point(89, 150)
        Me.TextBox_TempatLahirPasien.Name = "TextBox_TempatLahirPasien"
        Me.TextBox_TempatLahirPasien.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_TempatLahirPasien.TabIndex = 26
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(3, 179)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(53, 13)
        Me.Label29.TabIndex = 17
        Me.Label29.Text = "Kelamin : "
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RadioButton_KelaminWanitaPasien)
        Me.Panel3.Controls.Add(Me.RadioButton_KelaminPriaPasien)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(89, 182)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(174, 21)
        Me.Panel3.TabIndex = 18
        '
        'RadioButton_KelaminWanitaPasien
        '
        Me.RadioButton_KelaminWanitaPasien.AutoSize = True
        Me.RadioButton_KelaminWanitaPasien.Dock = System.Windows.Forms.DockStyle.Left
        Me.RadioButton_KelaminWanitaPasien.Enabled = False
        Me.RadioButton_KelaminWanitaPasien.Location = New System.Drawing.Point(43, 0)
        Me.RadioButton_KelaminWanitaPasien.Name = "RadioButton_KelaminWanitaPasien"
        Me.RadioButton_KelaminWanitaPasien.Size = New System.Drawing.Size(59, 21)
        Me.RadioButton_KelaminWanitaPasien.TabIndex = 28
        Me.RadioButton_KelaminWanitaPasien.Text = "Wanita"
        Me.RadioButton_KelaminWanitaPasien.UseVisualStyleBackColor = True
        '
        'RadioButton_KelaminPriaPasien
        '
        Me.RadioButton_KelaminPriaPasien.AutoSize = True
        Me.RadioButton_KelaminPriaPasien.Checked = True
        Me.RadioButton_KelaminPriaPasien.Dock = System.Windows.Forms.DockStyle.Left
        Me.RadioButton_KelaminPriaPasien.Enabled = False
        Me.RadioButton_KelaminPriaPasien.Location = New System.Drawing.Point(0, 0)
        Me.RadioButton_KelaminPriaPasien.Name = "RadioButton_KelaminPriaPasien"
        Me.RadioButton_KelaminPriaPasien.Size = New System.Drawing.Size(43, 21)
        Me.RadioButton_KelaminPriaPasien.TabIndex = 27
        Me.RadioButton_KelaminPriaPasien.TabStop = True
        Me.RadioButton_KelaminPriaPasien.Text = "Pria"
        Me.RadioButton_KelaminPriaPasien.UseVisualStyleBackColor = True
        '
        'Button_SavePasien
        '
        Me.Button_SavePasien.Enabled = False
        Me.Button_SavePasien.Image = Global.RKMedis.My.Resources.Resources.save16
        Me.Button_SavePasien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_SavePasien.Location = New System.Drawing.Point(3, 378)
        Me.Button_SavePasien.Name = "Button_SavePasien"
        Me.Button_SavePasien.Size = New System.Drawing.Size(75, 23)
        Me.Button_SavePasien.TabIndex = 32
        Me.Button_SavePasien.Text = "Save"
        Me.Button_SavePasien.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_SavePasien.UseVisualStyleBackColor = True
        '
        'Button_CancelPasien
        '
        Me.Button_CancelPasien.Enabled = False
        Me.Button_CancelPasien.Location = New System.Drawing.Point(89, 378)
        Me.Button_CancelPasien.Name = "Button_CancelPasien"
        Me.Button_CancelPasien.Size = New System.Drawing.Size(75, 23)
        Me.Button_CancelPasien.TabIndex = 33
        Me.Button_CancelPasien.Text = "Cancel"
        Me.Button_CancelPasien.UseVisualStyleBackColor = True
        '
        'Label_IDPasien
        '
        Me.Label_IDPasien.AutoSize = True
        Me.Label_IDPasien.Location = New System.Drawing.Point(3, 355)
        Me.Label_IDPasien.Name = "Label_IDPasien"
        Me.Label_IDPasien.Size = New System.Drawing.Size(50, 13)
        Me.Label_IDPasien.TabIndex = 11
        Me.Label_IDPasien.Text = "IDPasien"
        Me.Label_IDPasien.Visible = False
        '
        'Label_ModeFormPasien
        '
        Me.Label_ModeFormPasien.AutoSize = True
        Me.Label_ModeFormPasien.Location = New System.Drawing.Point(89, 355)
        Me.Label_ModeFormPasien.Name = "Label_ModeFormPasien"
        Me.Label_ModeFormPasien.Size = New System.Drawing.Size(34, 13)
        Me.Label_ModeFormPasien.TabIndex = 12
        Me.Label_ModeFormPasien.Text = "Mode"
        Me.Label_ModeFormPasien.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(3, 206)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(48, 13)
        Me.Label30.TabIndex = 19
        Me.Label30.Text = "Alamat : "
        '
        'TextBox_AlamatPasien
        '
        Me.TextBox_AlamatPasien.Enabled = False
        Me.TextBox_AlamatPasien.Location = New System.Drawing.Point(89, 209)
        Me.TextBox_AlamatPasien.Multiline = True
        Me.TextBox_AlamatPasien.Name = "TextBox_AlamatPasien"
        Me.TextBox_AlamatPasien.Size = New System.Drawing.Size(100, 49)
        Me.TextBox_AlamatPasien.TabIndex = 29
        '
        'TextBox_TelpPasien
        '
        Me.TextBox_TelpPasien.Enabled = False
        Me.TextBox_TelpPasien.Location = New System.Drawing.Point(89, 264)
        Me.TextBox_TelpPasien.Name = "TextBox_TelpPasien"
        Me.TextBox_TelpPasien.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_TelpPasien.TabIndex = 30
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(3, 261)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(34, 13)
        Me.Label31.TabIndex = 22
        Me.Label31.Text = "Telp :"
        '
        'TextBox_TanggalBuatPasien
        '
        Me.TextBox_TanggalBuatPasien.CustomFormat = "dd MMMM yyyy"
        Me.TextBox_TanggalBuatPasien.Enabled = False
        Me.TextBox_TanggalBuatPasien.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TextBox_TanggalBuatPasien.Location = New System.Drawing.Point(89, 64)
        Me.TextBox_TanggalBuatPasien.Name = "TextBox_TanggalBuatPasien"
        Me.TextBox_TanggalBuatPasien.Size = New System.Drawing.Size(129, 20)
        Me.TextBox_TanggalBuatPasien.TabIndex = 23
        '
        'Combobox_StatusPasien
        '
        Me.Combobox_StatusPasien.AutoCompleteCustomSource.AddRange(New String() {"ACTIVE", "NONACTIVE"})
        Me.Combobox_StatusPasien.Enabled = False
        Me.Combobox_StatusPasien.FormattingEnabled = True
        Me.Combobox_StatusPasien.Items.AddRange(New Object() {"ACTIVE", "NONACTIVE"})
        Me.Combobox_StatusPasien.Location = New System.Drawing.Point(89, 35)
        Me.Combobox_StatusPasien.Name = "Combobox_StatusPasien"
        Me.Combobox_StatusPasien.Size = New System.Drawing.Size(121, 21)
        Me.Combobox_StatusPasien.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Catatan : "
        '
        'TextBox_CatatanPasien
        '
        Me.TextBox_CatatanPasien.Location = New System.Drawing.Point(89, 300)
        Me.TextBox_CatatanPasien.Multiline = True
        Me.TextBox_CatatanPasien.Name = "TextBox_CatatanPasien"
        Me.TextBox_CatatanPasien.Size = New System.Drawing.Size(155, 44)
        Me.TextBox_CatatanPasien.TabIndex = 31
        '
        'SplitContainer8
        '
        Me.SplitContainer8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer8.IsSplitterFixed = True
        Me.SplitContainer8.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer8.Name = "SplitContainer8"
        Me.SplitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer8.Panel1
        '
        Me.SplitContainer8.Panel1.Controls.Add(Me.TableLayoutPanel13)
        '
        'SplitContainer8.Panel2
        '
        Me.SplitContainer8.Panel2.Controls.Add(Me.DataGridView_Pasien)
        Me.SplitContainer8.Size = New System.Drawing.Size(720, 597)
        Me.SplitContainer8.SplitterDistance = 93
        Me.SplitContainer8.TabIndex = 0
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 1
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.FlowLayoutPanel8, 0, 1)
        Me.TableLayoutPanel13.Controls.Add(Me.FlowLayoutPanel3, 0, 0)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 2
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(720, 93)
        Me.TableLayoutPanel13.TabIndex = 4
        '
        'FlowLayoutPanel8
        '
        Me.FlowLayoutPanel8.Controls.Add(Me.Label33)
        Me.FlowLayoutPanel8.Controls.Add(Me.GroupBox11)
        Me.FlowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel8.Location = New System.Drawing.Point(3, 49)
        Me.FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        Me.FlowLayoutPanel8.Size = New System.Drawing.Size(714, 41)
        Me.FlowLayoutPanel8.TabIndex = 6
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Image = Global.RKMedis.My.Resources.Resources.patient32
        Me.Label33.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label33.Location = New System.Drawing.Point(3, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(165, 41)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Data Pasien"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.FlowPasienNavigasi)
        Me.GroupBox11.Location = New System.Drawing.Point(174, 3)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(485, 37)
        Me.GroupBox11.TabIndex = 1
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Halaman"
        '
        'FlowPasienNavigasi
        '
        Me.FlowPasienNavigasi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowPasienNavigasi.Location = New System.Drawing.Point(3, 16)
        Me.FlowPasienNavigasi.Name = "FlowPasienNavigasi"
        Me.FlowPasienNavigasi.Size = New System.Drawing.Size(479, 18)
        Me.FlowPasienNavigasi.TabIndex = 0
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.Button_AddPasien)
        Me.FlowLayoutPanel3.Controls.Add(Me.Button_EditPasien)
        Me.FlowLayoutPanel3.Controls.Add(Me.Button_DeletePasien)
        Me.FlowLayoutPanel3.Controls.Add(Me.Button_RefreshPasien)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(714, 40)
        Me.FlowLayoutPanel3.TabIndex = 4
        '
        'Button_AddPasien
        '
        Me.Button_AddPasien.Image = Global.RKMedis.My.Resources.Resources.add24
        Me.Button_AddPasien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_AddPasien.Location = New System.Drawing.Point(3, 3)
        Me.Button_AddPasien.Name = "Button_AddPasien"
        Me.Button_AddPasien.Size = New System.Drawing.Size(75, 37)
        Me.Button_AddPasien.TabIndex = 34
        Me.Button_AddPasien.Text = "Add"
        Me.Button_AddPasien.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_AddPasien.UseVisualStyleBackColor = True
        '
        'Button_EditPasien
        '
        Me.Button_EditPasien.Image = Global.RKMedis.My.Resources.Resources.edit24
        Me.Button_EditPasien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_EditPasien.Location = New System.Drawing.Point(84, 3)
        Me.Button_EditPasien.Name = "Button_EditPasien"
        Me.Button_EditPasien.Size = New System.Drawing.Size(75, 37)
        Me.Button_EditPasien.TabIndex = 35
        Me.Button_EditPasien.Text = "Edit"
        Me.Button_EditPasien.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_EditPasien.UseVisualStyleBackColor = True
        '
        'Button_DeletePasien
        '
        Me.Button_DeletePasien.Image = Global.RKMedis.My.Resources.Resources.delete24
        Me.Button_DeletePasien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_DeletePasien.Location = New System.Drawing.Point(165, 3)
        Me.Button_DeletePasien.Name = "Button_DeletePasien"
        Me.Button_DeletePasien.Size = New System.Drawing.Size(75, 37)
        Me.Button_DeletePasien.TabIndex = 36
        Me.Button_DeletePasien.Text = "Delete"
        Me.Button_DeletePasien.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_DeletePasien.UseVisualStyleBackColor = True
        '
        'Button_RefreshPasien
        '
        Me.Button_RefreshPasien.Image = Global.RKMedis.My.Resources.Resources.refresh24
        Me.Button_RefreshPasien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_RefreshPasien.Location = New System.Drawing.Point(246, 3)
        Me.Button_RefreshPasien.Name = "Button_RefreshPasien"
        Me.Button_RefreshPasien.Size = New System.Drawing.Size(81, 37)
        Me.Button_RefreshPasien.TabIndex = 37
        Me.Button_RefreshPasien.Text = "Refresh"
        Me.Button_RefreshPasien.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_RefreshPasien.UseVisualStyleBackColor = True
        '
        'DataGridView_Pasien
        '
        Me.DataGridView_Pasien.AllowUserToAddRows = False
        Me.DataGridView_Pasien.ColumnHeadersHeight = 35
        Me.DataGridView_Pasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView_Pasien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnPasien_Check, Me.ColumnPasien_ID, Me.ColumnPasien_NoMedRek, Me.ColumnPasien_Status, Me.ColumnPasien_TanggalBuat, Me.ColumnPasien_Nama, Me.ColumnPasien_TanggalLahir, Me.ColumnPasien_TempatLahir, Me.ColumnPasien_Kelamin, Me.ColumnPasien_Alamat, Me.ColumnPasien_Telp, Me.ColumnPasien_TotalKunjungan, Me.ColumnPasien_Catatan})
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle19.Format = "D"
        DataGridViewCellStyle19.NullValue = Nothing
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_Pasien.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridView_Pasien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Pasien.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Pasien.Name = "DataGridView_Pasien"
        Me.DataGridView_Pasien.Size = New System.Drawing.Size(720, 500)
        Me.DataGridView_Pasien.TabIndex = 0
        '
        'ColumnPasien_Check
        '
        Me.ColumnPasien_Check.HeaderText = "#"
        Me.ColumnPasien_Check.Name = "ColumnPasien_Check"
        Me.ColumnPasien_Check.Width = 25
        '
        'ColumnPasien_ID
        '
        Me.ColumnPasien_ID.HeaderText = "#"
        Me.ColumnPasien_ID.Name = "ColumnPasien_ID"
        Me.ColumnPasien_ID.Visible = False
        '
        'ColumnPasien_NoMedRek
        '
        Me.ColumnPasien_NoMedRek.HeaderText = "No.MedRek"
        Me.ColumnPasien_NoMedRek.Name = "ColumnPasien_NoMedRek"
        '
        'ColumnPasien_Status
        '
        Me.ColumnPasien_Status.HeaderText = "Status"
        Me.ColumnPasien_Status.Name = "ColumnPasien_Status"
        '
        'ColumnPasien_TanggalBuat
        '
        Me.ColumnPasien_TanggalBuat.HeaderText = "Tanggal Buat"
        Me.ColumnPasien_TanggalBuat.Name = "ColumnPasien_TanggalBuat"
        '
        'ColumnPasien_Nama
        '
        Me.ColumnPasien_Nama.HeaderText = "Nama"
        Me.ColumnPasien_Nama.Name = "ColumnPasien_Nama"
        '
        'ColumnPasien_TanggalLahir
        '
        Me.ColumnPasien_TanggalLahir.HeaderText = "Tanggal Lahir"
        Me.ColumnPasien_TanggalLahir.Name = "ColumnPasien_TanggalLahir"
        '
        'ColumnPasien_TempatLahir
        '
        Me.ColumnPasien_TempatLahir.HeaderText = "Tempat Lahir"
        Me.ColumnPasien_TempatLahir.Name = "ColumnPasien_TempatLahir"
        '
        'ColumnPasien_Kelamin
        '
        Me.ColumnPasien_Kelamin.HeaderText = "Kelamin"
        Me.ColumnPasien_Kelamin.Name = "ColumnPasien_Kelamin"
        '
        'ColumnPasien_Alamat
        '
        Me.ColumnPasien_Alamat.HeaderText = "Alamat"
        Me.ColumnPasien_Alamat.Name = "ColumnPasien_Alamat"
        '
        'ColumnPasien_Telp
        '
        Me.ColumnPasien_Telp.HeaderText = "Telp"
        Me.ColumnPasien_Telp.Name = "ColumnPasien_Telp"
        '
        'ColumnPasien_TotalKunjungan
        '
        Me.ColumnPasien_TotalKunjungan.HeaderText = "Total Kunjungan"
        Me.ColumnPasien_TotalKunjungan.Name = "ColumnPasien_TotalKunjungan"
        Me.ColumnPasien_TotalKunjungan.Width = 45
        '
        'ColumnPasien_Catatan
        '
        Me.ColumnPasien_Catatan.HeaderText = "Catatan"
        Me.ColumnPasien_Catatan.Name = "ColumnPasien_Catatan"
        '
        'TabPoliklinik
        '
        Me.TabPoliklinik.Controls.Add(Me.SplitContainer5)
        Me.TabPoliklinik.Location = New System.Drawing.Point(4, 22)
        Me.TabPoliklinik.Name = "TabPoliklinik"
        Me.TabPoliklinik.Size = New System.Drawing.Size(1012, 597)
        Me.TabPoliklinik.TabIndex = 3
        Me.TabPoliklinik.Text = "Poliklinik"
        Me.TabPoliklinik.UseVisualStyleBackColor = True
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.GroupBox7)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.SplitContainer6)
        Me.SplitContainer5.Size = New System.Drawing.Size(1012, 597)
        Me.SplitContainer5.SplitterDistance = 288
        Me.SplitContainer5.TabIndex = 2
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TableLayoutPanel7)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox7.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(288, 597)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Data"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.96241!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0376!))
        Me.TableLayoutPanel7.Controls.Add(Me.Label18, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Label19, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label20, 0, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.TextBox_UnitPoliklinik, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Button_SavePoliklinik, 0, 4)
        Me.TableLayoutPanel7.Controls.Add(Me.Button_CancelPoliklinik, 1, 4)
        Me.TableLayoutPanel7.Controls.Add(Me.Label_IDPoliklinik, 0, 5)
        Me.TableLayoutPanel7.Controls.Add(Me.Label_ModeFormPoliklinik, 1, 5)
        Me.TableLayoutPanel7.Controls.Add(Me.ComboBox_DokterPoliklinik, 1, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.FlowLayoutPanel11, 1, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.DataGridView_NamaPetugasPoliklinik, 1, 3)
        Me.TableLayoutPanel7.Controls.Add(Me.Button_DeletePetugasFromPoliklinik, 0, 3)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(35, 49)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 6
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.963586!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.683474!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.11173!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.2905!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(266, 426)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Dokter :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Unit : "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 63)
        Me.Label20.Name = "Label20"
        Me.Label20.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label20.Size = New System.Drawing.Size(52, 18)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Petugas :"
        '
        'TextBox_UnitPoliklinik
        '
        Me.TextBox_UnitPoliklinik.Enabled = False
        Me.TextBox_UnitPoliklinik.Location = New System.Drawing.Point(96, 3)
        Me.TextBox_UnitPoliklinik.Name = "TextBox_UnitPoliklinik"
        Me.TextBox_UnitPoliklinik.Size = New System.Drawing.Size(129, 20)
        Me.TextBox_UnitPoliklinik.TabIndex = 38
        '
        'Button_SavePoliklinik
        '
        Me.Button_SavePoliklinik.Enabled = False
        Me.Button_SavePoliklinik.Image = Global.RKMedis.My.Resources.Resources.save16
        Me.Button_SavePoliklinik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_SavePoliklinik.Location = New System.Drawing.Point(3, 361)
        Me.Button_SavePoliklinik.Name = "Button_SavePoliklinik"
        Me.Button_SavePoliklinik.Size = New System.Drawing.Size(75, 23)
        Me.Button_SavePoliklinik.TabIndex = 41
        Me.Button_SavePoliklinik.Text = "Save"
        Me.Button_SavePoliklinik.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_SavePoliklinik.UseVisualStyleBackColor = True
        '
        'Button_CancelPoliklinik
        '
        Me.Button_CancelPoliklinik.Enabled = False
        Me.Button_CancelPoliklinik.Location = New System.Drawing.Point(96, 361)
        Me.Button_CancelPoliklinik.Name = "Button_CancelPoliklinik"
        Me.Button_CancelPoliklinik.Size = New System.Drawing.Size(75, 23)
        Me.Button_CancelPoliklinik.TabIndex = 42
        Me.Button_CancelPoliklinik.Text = "Cancel"
        Me.Button_CancelPoliklinik.UseVisualStyleBackColor = True
        '
        'Label_IDPoliklinik
        '
        Me.Label_IDPoliklinik.AutoSize = True
        Me.Label_IDPoliklinik.Location = New System.Drawing.Point(3, 405)
        Me.Label_IDPoliklinik.Name = "Label_IDPoliklinik"
        Me.Label_IDPoliklinik.Size = New System.Drawing.Size(59, 13)
        Me.Label_IDPoliklinik.TabIndex = 11
        Me.Label_IDPoliklinik.Text = "IDPoliklinik"
        Me.Label_IDPoliklinik.Visible = False
        '
        'Label_ModeFormPoliklinik
        '
        Me.Label_ModeFormPoliklinik.AutoSize = True
        Me.Label_ModeFormPoliklinik.Location = New System.Drawing.Point(96, 405)
        Me.Label_ModeFormPoliklinik.Name = "Label_ModeFormPoliklinik"
        Me.Label_ModeFormPoliklinik.Size = New System.Drawing.Size(34, 13)
        Me.Label_ModeFormPoliklinik.TabIndex = 12
        Me.Label_ModeFormPoliklinik.Text = "Mode"
        Me.Label_ModeFormPoliklinik.Visible = False
        '
        'ComboBox_DokterPoliklinik
        '
        Me.ComboBox_DokterPoliklinik.Enabled = False
        Me.ComboBox_DokterPoliklinik.FormattingEnabled = True
        Me.ComboBox_DokterPoliklinik.Location = New System.Drawing.Point(96, 35)
        Me.ComboBox_DokterPoliklinik.Name = "ComboBox_DokterPoliklinik"
        Me.ComboBox_DokterPoliklinik.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_DokterPoliklinik.TabIndex = 43
        '
        'FlowLayoutPanel11
        '
        Me.FlowLayoutPanel11.Controls.Add(Me.ComboBox_PetugasPoliklinik)
        Me.FlowLayoutPanel11.Controls.Add(Me.Button_AddPetugasToPoliklinik)
        Me.FlowLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel11.Location = New System.Drawing.Point(96, 66)
        Me.FlowLayoutPanel11.Name = "FlowLayoutPanel11"
        Me.FlowLayoutPanel11.Size = New System.Drawing.Size(167, 66)
        Me.FlowLayoutPanel11.TabIndex = 44
        '
        'ComboBox_PetugasPoliklinik
        '
        Me.ComboBox_PetugasPoliklinik.Enabled = False
        Me.ComboBox_PetugasPoliklinik.FormattingEnabled = True
        Me.ComboBox_PetugasPoliklinik.Location = New System.Drawing.Point(3, 3)
        Me.ComboBox_PetugasPoliklinik.Name = "ComboBox_PetugasPoliklinik"
        Me.ComboBox_PetugasPoliklinik.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_PetugasPoliklinik.TabIndex = 45
        '
        'Button_AddPetugasToPoliklinik
        '
        Me.Button_AddPetugasToPoliklinik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button_AddPetugasToPoliklinik.Enabled = False
        Me.Button_AddPetugasToPoliklinik.Image = Global.RKMedis.My.Resources.Resources.down24
        Me.Button_AddPetugasToPoliklinik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_AddPetugasToPoliklinik.Location = New System.Drawing.Point(3, 30)
        Me.Button_AddPetugasToPoliklinik.Name = "Button_AddPetugasToPoliklinik"
        Me.Button_AddPetugasToPoliklinik.Size = New System.Drawing.Size(75, 28)
        Me.Button_AddPetugasToPoliklinik.TabIndex = 0
        Me.Button_AddPetugasToPoliklinik.Text = "Add"
        Me.Button_AddPetugasToPoliklinik.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_AddPetugasToPoliklinik.UseVisualStyleBackColor = True
        '
        'DataGridView_NamaPetugasPoliklinik
        '
        Me.DataGridView_NamaPetugasPoliklinik.AllowUserToAddRows = False
        Me.DataGridView_NamaPetugasPoliklinik.AllowUserToDeleteRows = False
        Me.DataGridView_NamaPetugasPoliklinik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_NamaPetugasPoliklinik.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Table_PetugasPoliklinik})
        Me.DataGridView_NamaPetugasPoliklinik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_NamaPetugasPoliklinik.Enabled = False
        Me.DataGridView_NamaPetugasPoliklinik.Location = New System.Drawing.Point(96, 138)
        Me.DataGridView_NamaPetugasPoliklinik.Name = "DataGridView_NamaPetugasPoliklinik"
        Me.DataGridView_NamaPetugasPoliklinik.ReadOnly = True
        Me.DataGridView_NamaPetugasPoliklinik.Size = New System.Drawing.Size(167, 217)
        Me.DataGridView_NamaPetugasPoliklinik.TabIndex = 45
        '
        'Table_PetugasPoliklinik
        '
        Me.Table_PetugasPoliklinik.HeaderText = "Nama"
        Me.Table_PetugasPoliklinik.Name = "Table_PetugasPoliklinik"
        Me.Table_PetugasPoliklinik.ReadOnly = True
        '
        'Button_DeletePetugasFromPoliklinik
        '
        Me.Button_DeletePetugasFromPoliklinik.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_DeletePetugasFromPoliklinik.Image = Global.RKMedis.My.Resources.Resources.delete242
        Me.Button_DeletePetugasFromPoliklinik.Location = New System.Drawing.Point(3, 138)
        Me.Button_DeletePetugasFromPoliklinik.Name = "Button_DeletePetugasFromPoliklinik"
        Me.Button_DeletePetugasFromPoliklinik.Size = New System.Drawing.Size(87, 31)
        Me.Button_DeletePetugasFromPoliklinik.TabIndex = 46
        Me.Button_DeletePetugasFromPoliklinik.Text = "Delete"
        Me.Button_DeletePetugasFromPoliklinik.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_DeletePetugasFromPoliklinik.UseVisualStyleBackColor = True
        Me.Button_DeletePetugasFromPoliklinik.Visible = False
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.IsSplitterFixed = True
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        Me.SplitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.TableLayoutPanel12)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.DataGridView_Poliklinik)
        Me.SplitContainer6.Size = New System.Drawing.Size(720, 597)
        Me.SplitContainer6.SplitterDistance = 93
        Me.SplitContainer6.TabIndex = 0
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.ColumnCount = 1
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.FlowLayoutPanel7, 0, 1)
        Me.TableLayoutPanel12.Controls.Add(Me.FlowLayoutPanel4, 0, 0)
        Me.TableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 2
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(720, 93)
        Me.TableLayoutPanel12.TabIndex = 4
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(3, 49)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(714, 41)
        Me.FlowLayoutPanel7.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Image = Global.RKMedis.My.Resources.Resources.door32
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(180, 44)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Data Poliklinik"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.Button_AddPoliklinik)
        Me.FlowLayoutPanel4.Controls.Add(Me.Button_EditPoliklinik)
        Me.FlowLayoutPanel4.Controls.Add(Me.Button_DeletePoliklinik)
        Me.FlowLayoutPanel4.Controls.Add(Me.Button_ResetPoliklinik)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(714, 40)
        Me.FlowLayoutPanel4.TabIndex = 4
        '
        'Button_AddPoliklinik
        '
        Me.Button_AddPoliklinik.Image = Global.RKMedis.My.Resources.Resources.add24
        Me.Button_AddPoliklinik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_AddPoliklinik.Location = New System.Drawing.Point(3, 3)
        Me.Button_AddPoliklinik.Name = "Button_AddPoliklinik"
        Me.Button_AddPoliklinik.Size = New System.Drawing.Size(75, 37)
        Me.Button_AddPoliklinik.TabIndex = 43
        Me.Button_AddPoliklinik.Text = "Add"
        Me.Button_AddPoliklinik.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_AddPoliklinik.UseVisualStyleBackColor = True
        '
        'Button_EditPoliklinik
        '
        Me.Button_EditPoliklinik.Image = Global.RKMedis.My.Resources.Resources.edit24
        Me.Button_EditPoliklinik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_EditPoliklinik.Location = New System.Drawing.Point(84, 3)
        Me.Button_EditPoliklinik.Name = "Button_EditPoliklinik"
        Me.Button_EditPoliklinik.Size = New System.Drawing.Size(75, 37)
        Me.Button_EditPoliklinik.TabIndex = 44
        Me.Button_EditPoliklinik.Text = "Edit"
        Me.Button_EditPoliklinik.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_EditPoliklinik.UseVisualStyleBackColor = True
        '
        'Button_DeletePoliklinik
        '
        Me.Button_DeletePoliklinik.Image = Global.RKMedis.My.Resources.Resources.delete24
        Me.Button_DeletePoliklinik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_DeletePoliklinik.Location = New System.Drawing.Point(165, 3)
        Me.Button_DeletePoliklinik.Name = "Button_DeletePoliklinik"
        Me.Button_DeletePoliklinik.Size = New System.Drawing.Size(75, 37)
        Me.Button_DeletePoliklinik.TabIndex = 45
        Me.Button_DeletePoliklinik.Text = "Delete"
        Me.Button_DeletePoliklinik.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_DeletePoliklinik.UseVisualStyleBackColor = True
        '
        'Button_ResetPoliklinik
        '
        Me.Button_ResetPoliklinik.Image = Global.RKMedis.My.Resources.Resources.refresh24
        Me.Button_ResetPoliklinik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_ResetPoliklinik.Location = New System.Drawing.Point(246, 3)
        Me.Button_ResetPoliklinik.Name = "Button_ResetPoliklinik"
        Me.Button_ResetPoliklinik.Size = New System.Drawing.Size(82, 37)
        Me.Button_ResetPoliklinik.TabIndex = 46
        Me.Button_ResetPoliklinik.Text = "Refresh"
        Me.Button_ResetPoliklinik.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_ResetPoliklinik.UseVisualStyleBackColor = True
        '
        'DataGridView_Poliklinik
        '
        Me.DataGridView_Poliklinik.AllowUserToAddRows = False
        Me.DataGridView_Poliklinik.ColumnHeadersHeight = 35
        Me.DataGridView_Poliklinik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView_Poliklinik.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnPoliklinik_Check, Me.ColumnPoliklinik_ID, Me.ColumnPoliklinik_Unit, Me.ColumnPoliklinik_NamaDokter, Me.ColumnPoliklinik_NamaPetugas})
        Me.DataGridView_Poliklinik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Poliklinik.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Poliklinik.Name = "DataGridView_Poliklinik"
        Me.DataGridView_Poliklinik.Size = New System.Drawing.Size(720, 500)
        Me.DataGridView_Poliklinik.TabIndex = 0
        '
        'ColumnPoliklinik_Check
        '
        Me.ColumnPoliklinik_Check.HeaderText = "#"
        Me.ColumnPoliklinik_Check.Name = "ColumnPoliklinik_Check"
        Me.ColumnPoliklinik_Check.Width = 25
        '
        'ColumnPoliklinik_ID
        '
        Me.ColumnPoliklinik_ID.HeaderText = "#"
        Me.ColumnPoliklinik_ID.Name = "ColumnPoliklinik_ID"
        Me.ColumnPoliklinik_ID.Visible = False
        '
        'ColumnPoliklinik_Unit
        '
        Me.ColumnPoliklinik_Unit.HeaderText = "Unit"
        Me.ColumnPoliklinik_Unit.Name = "ColumnPoliklinik_Unit"
        '
        'ColumnPoliklinik_NamaDokter
        '
        Me.ColumnPoliklinik_NamaDokter.HeaderText = "Dokter"
        Me.ColumnPoliklinik_NamaDokter.Name = "ColumnPoliklinik_NamaDokter"
        '
        'ColumnPoliklinik_NamaPetugas
        '
        Me.ColumnPoliklinik_NamaPetugas.HeaderText = "Petugas"
        Me.ColumnPoliklinik_NamaPetugas.Name = "ColumnPoliklinik_NamaPetugas"
        '
        'TabKunjungan
        '
        Me.TabKunjungan.Controls.Add(Me.SplitContainer9)
        Me.TabKunjungan.Location = New System.Drawing.Point(4, 22)
        Me.TabKunjungan.Name = "TabKunjungan"
        Me.TabKunjungan.Size = New System.Drawing.Size(1012, 597)
        Me.TabKunjungan.TabIndex = 4
        Me.TabKunjungan.Text = "Kunjungan"
        Me.TabKunjungan.UseVisualStyleBackColor = True
        '
        'SplitContainer9
        '
        Me.SplitContainer9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer9.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer9.Name = "SplitContainer9"
        '
        'SplitContainer9.Panel1
        '
        Me.SplitContainer9.Panel1.Controls.Add(Me.GroupBox9)
        '
        'SplitContainer9.Panel2
        '
        Me.SplitContainer9.Panel2.Controls.Add(Me.SplitContainer10)
        Me.SplitContainer9.Size = New System.Drawing.Size(1012, 597)
        Me.SplitContainer9.SplitterDistance = 288
        Me.SplitContainer9.TabIndex = 3
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.TableLayoutPanel9)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox9.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(288, 597)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Data"
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.33083!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.66917!))
        Me.TableLayoutPanel9.Controls.Add(Me.Textbox_TanggalKunjungan, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Label25, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.Label26, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Label32, 0, 2)
        Me.TableLayoutPanel9.Controls.Add(Me.TextBox_NamaPasienKunjungan, 1, 2)
        Me.TableLayoutPanel9.Controls.Add(Me.TextBox_NoMedRekKunjungan, 1, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.Label35, 0, 3)
        Me.TableLayoutPanel9.Controls.Add(Me.TextBox_KeluhanKunjungan, 1, 3)
        Me.TableLayoutPanel9.Controls.Add(Me.Label36, 0, 4)
        Me.TableLayoutPanel9.Controls.Add(Me.TextBox_DiagnosaKunjungan, 1, 4)
        Me.TableLayoutPanel9.Controls.Add(Me.Label37, 0, 5)
        Me.TableLayoutPanel9.Controls.Add(Me.TextBox_TekananDarahKunjungan, 1, 5)
        Me.TableLayoutPanel9.Controls.Add(Me.Label38, 0, 6)
        Me.TableLayoutPanel9.Controls.Add(Me.TextBox_BeratBadanKunjungan, 1, 6)
        Me.TableLayoutPanel9.Controls.Add(Me.Label39, 0, 7)
        Me.TableLayoutPanel9.Controls.Add(Me.TextBox_TindakanKunjungan, 1, 7)
        Me.TableLayoutPanel9.Controls.Add(Me.Label41, 0, 8)
        Me.TableLayoutPanel9.Controls.Add(Me.Panel5, 1, 8)
        Me.TableLayoutPanel9.Controls.Add(Me.Label_ModeFormKunjungan, 1, 13)
        Me.TableLayoutPanel9.Controls.Add(Me.Label_IDKunjungan, 0, 13)
        Me.TableLayoutPanel9.Controls.Add(Me.Label_IDPasienKunjungan, 0, 12)
        Me.TableLayoutPanel9.Controls.Add(Me.Button_SaveKunjungan, 0, 11)
        Me.TableLayoutPanel9.Controls.Add(Me.Button_CancelKunjungan, 1, 11)
        Me.TableLayoutPanel9.Controls.Add(Me.Textbox_TanggalKunjunganLagiKunjungan, 1, 10)
        Me.TableLayoutPanel9.Controls.Add(Me.Label42, 0, 10)
        Me.TableLayoutPanel9.Controls.Add(Me.Label46, 0, 9)
        Me.TableLayoutPanel9.Controls.Add(Me.ComboBox_UnitPoliklinikKunjungan, 1, 9)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(35, 44)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 14
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.5298!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.2053!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.76423!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.21138!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(291, 547)
        Me.TableLayoutPanel9.TabIndex = 0
        '
        'Textbox_TanggalKunjungan
        '
        Me.Textbox_TanggalKunjungan.CustomFormat = "dd MMMM yyyy"
        Me.Textbox_TanggalKunjungan.Enabled = False
        Me.Textbox_TanggalKunjungan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Textbox_TanggalKunjungan.Location = New System.Drawing.Point(97, 3)
        Me.Textbox_TanggalKunjungan.Name = "Textbox_TanggalKunjungan"
        Me.Textbox_TanggalKunjungan.Size = New System.Drawing.Size(129, 20)
        Me.Textbox_TanggalKunjungan.TabIndex = 47
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(3, 26)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(74, 13)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "No.MedRek : "
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(3, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 13)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Tanggal : "
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(3, 50)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(44, 13)
        Me.Label32.TabIndex = 3
        Me.Label32.Text = "Nama : "
        '
        'TextBox_NamaPasienKunjungan
        '
        Me.TextBox_NamaPasienKunjungan.Enabled = False
        Me.TextBox_NamaPasienKunjungan.Location = New System.Drawing.Point(97, 53)
        Me.TextBox_NamaPasienKunjungan.Name = "TextBox_NamaPasienKunjungan"
        Me.TextBox_NamaPasienKunjungan.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_NamaPasienKunjungan.TabIndex = 49
        '
        'TextBox_NoMedRekKunjungan
        '
        Me.TextBox_NoMedRekKunjungan.Enabled = False
        Me.TextBox_NoMedRekKunjungan.Location = New System.Drawing.Point(97, 29)
        Me.TextBox_NoMedRekKunjungan.Name = "TextBox_NoMedRekKunjungan"
        Me.TextBox_NoMedRekKunjungan.Size = New System.Drawing.Size(129, 20)
        Me.TextBox_NoMedRekKunjungan.TabIndex = 48
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(3, 79)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(55, 13)
        Me.Label35.TabIndex = 13
        Me.Label35.Text = "Keluhan : "
        '
        'TextBox_KeluhanKunjungan
        '
        Me.TextBox_KeluhanKunjungan.Enabled = False
        Me.TextBox_KeluhanKunjungan.Location = New System.Drawing.Point(97, 82)
        Me.TextBox_KeluhanKunjungan.Multiline = True
        Me.TextBox_KeluhanKunjungan.Name = "TextBox_KeluhanKunjungan"
        Me.TextBox_KeluhanKunjungan.Size = New System.Drawing.Size(158, 43)
        Me.TextBox_KeluhanKunjungan.TabIndex = 50
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(3, 128)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(61, 13)
        Me.Label36.TabIndex = 15
        Me.Label36.Text = "Diagnosa : "
        '
        'TextBox_DiagnosaKunjungan
        '
        Me.TextBox_DiagnosaKunjungan.Enabled = False
        Me.TextBox_DiagnosaKunjungan.Location = New System.Drawing.Point(97, 131)
        Me.TextBox_DiagnosaKunjungan.Multiline = True
        Me.TextBox_DiagnosaKunjungan.Name = "TextBox_DiagnosaKunjungan"
        Me.TextBox_DiagnosaKunjungan.Size = New System.Drawing.Size(158, 89)
        Me.TextBox_DiagnosaKunjungan.TabIndex = 51
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(3, 223)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(88, 13)
        Me.Label37.TabIndex = 17
        Me.Label37.Text = "Tekanan Darah : "
        '
        'TextBox_TekananDarahKunjungan
        '
        Me.TextBox_TekananDarahKunjungan.Enabled = False
        Me.TextBox_TekananDarahKunjungan.Location = New System.Drawing.Point(97, 226)
        Me.TextBox_TekananDarahKunjungan.Name = "TextBox_TekananDarahKunjungan"
        Me.TextBox_TekananDarahKunjungan.Size = New System.Drawing.Size(139, 20)
        Me.TextBox_TekananDarahKunjungan.TabIndex = 52
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(3, 253)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(75, 13)
        Me.Label38.TabIndex = 19
        Me.Label38.Text = "Berat Badan : "
        '
        'TextBox_BeratBadanKunjungan
        '
        Me.TextBox_BeratBadanKunjungan.Enabled = False
        Me.TextBox_BeratBadanKunjungan.Location = New System.Drawing.Point(97, 256)
        Me.TextBox_BeratBadanKunjungan.Name = "TextBox_BeratBadanKunjungan"
        Me.TextBox_BeratBadanKunjungan.Size = New System.Drawing.Size(66, 20)
        Me.TextBox_BeratBadanKunjungan.TabIndex = 53
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(3, 283)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(61, 13)
        Me.Label39.TabIndex = 21
        Me.Label39.Text = "Tindakan : "
        '
        'TextBox_TindakanKunjungan
        '
        Me.TextBox_TindakanKunjungan.Enabled = False
        Me.TextBox_TindakanKunjungan.Location = New System.Drawing.Point(97, 286)
        Me.TextBox_TindakanKunjungan.Multiline = True
        Me.TextBox_TindakanKunjungan.Name = "TextBox_TindakanKunjungan"
        Me.TextBox_TindakanKunjungan.Size = New System.Drawing.Size(158, 54)
        Me.TextBox_TindakanKunjungan.TabIndex = 54
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(3, 346)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(41, 13)
        Me.Label41.TabIndex = 28
        Me.Label41.Text = "Visite : "
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.RadioButton_VisitePoliklinikKunjungan)
        Me.Panel5.Controls.Add(Me.RadioButton_VisiteRumahKunjungan)
        Me.Panel5.Location = New System.Drawing.Point(97, 349)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(191, 26)
        Me.Panel5.TabIndex = 29
        '
        'RadioButton_VisitePoliklinikKunjungan
        '
        Me.RadioButton_VisitePoliklinikKunjungan.AutoSize = True
        Me.RadioButton_VisitePoliklinikKunjungan.Enabled = False
        Me.RadioButton_VisitePoliklinikKunjungan.Location = New System.Drawing.Point(68, 3)
        Me.RadioButton_VisitePoliklinikKunjungan.Name = "RadioButton_VisitePoliklinikKunjungan"
        Me.RadioButton_VisitePoliklinikKunjungan.Size = New System.Drawing.Size(66, 17)
        Me.RadioButton_VisitePoliklinikKunjungan.TabIndex = 56
        Me.RadioButton_VisitePoliklinikKunjungan.TabStop = True
        Me.RadioButton_VisitePoliklinikKunjungan.Text = "Poliklinik"
        Me.RadioButton_VisitePoliklinikKunjungan.UseVisualStyleBackColor = True
        '
        'RadioButton_VisiteRumahKunjungan
        '
        Me.RadioButton_VisiteRumahKunjungan.AutoSize = True
        Me.RadioButton_VisiteRumahKunjungan.Enabled = False
        Me.RadioButton_VisiteRumahKunjungan.Location = New System.Drawing.Point(3, 5)
        Me.RadioButton_VisiteRumahKunjungan.Name = "RadioButton_VisiteRumahKunjungan"
        Me.RadioButton_VisiteRumahKunjungan.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton_VisiteRumahKunjungan.TabIndex = 55
        Me.RadioButton_VisiteRumahKunjungan.TabStop = True
        Me.RadioButton_VisiteRumahKunjungan.Text = "Rumah"
        Me.RadioButton_VisiteRumahKunjungan.UseVisualStyleBackColor = True
        '
        'Label_ModeFormKunjungan
        '
        Me.Label_ModeFormKunjungan.AutoSize = True
        Me.Label_ModeFormKunjungan.Location = New System.Drawing.Point(97, 516)
        Me.Label_ModeFormKunjungan.Name = "Label_ModeFormKunjungan"
        Me.Label_ModeFormKunjungan.Size = New System.Drawing.Size(34, 13)
        Me.Label_ModeFormKunjungan.TabIndex = 26
        Me.Label_ModeFormKunjungan.Text = "Mode"
        Me.Label_ModeFormKunjungan.Visible = False
        '
        'Label_IDKunjungan
        '
        Me.Label_IDKunjungan.AutoSize = True
        Me.Label_IDKunjungan.Location = New System.Drawing.Point(3, 516)
        Me.Label_IDKunjungan.Name = "Label_IDKunjungan"
        Me.Label_IDKunjungan.Size = New System.Drawing.Size(69, 13)
        Me.Label_IDKunjungan.TabIndex = 25
        Me.Label_IDKunjungan.Text = "IDKunjungan"
        Me.Label_IDKunjungan.Visible = False
        '
        'Label_IDPasienKunjungan
        '
        Me.Label_IDPasienKunjungan.AutoSize = True
        Me.Label_IDPasienKunjungan.Location = New System.Drawing.Point(3, 487)
        Me.Label_IDPasienKunjungan.Name = "Label_IDPasienKunjungan"
        Me.Label_IDPasienKunjungan.Size = New System.Drawing.Size(50, 13)
        Me.Label_IDPasienKunjungan.TabIndex = 23
        Me.Label_IDPasienKunjungan.Text = "IDPasien"
        Me.Label_IDPasienKunjungan.Visible = False
        '
        'Button_SaveKunjungan
        '
        Me.Button_SaveKunjungan.Enabled = False
        Me.Button_SaveKunjungan.Image = Global.RKMedis.My.Resources.Resources.save16
        Me.Button_SaveKunjungan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_SaveKunjungan.Location = New System.Drawing.Point(3, 451)
        Me.Button_SaveKunjungan.Name = "Button_SaveKunjungan"
        Me.Button_SaveKunjungan.Size = New System.Drawing.Size(75, 23)
        Me.Button_SaveKunjungan.TabIndex = 58
        Me.Button_SaveKunjungan.Text = "Save"
        Me.Button_SaveKunjungan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_SaveKunjungan.UseVisualStyleBackColor = True
        '
        'Button_CancelKunjungan
        '
        Me.Button_CancelKunjungan.Enabled = False
        Me.Button_CancelKunjungan.Location = New System.Drawing.Point(97, 451)
        Me.Button_CancelKunjungan.Name = "Button_CancelKunjungan"
        Me.Button_CancelKunjungan.Size = New System.Drawing.Size(75, 23)
        Me.Button_CancelKunjungan.TabIndex = 59
        Me.Button_CancelKunjungan.Text = "Cancel"
        Me.Button_CancelKunjungan.UseVisualStyleBackColor = True
        '
        'Textbox_TanggalKunjunganLagiKunjungan
        '
        Me.Textbox_TanggalKunjunganLagiKunjungan.CustomFormat = "dd MMMM yyyy"
        Me.Textbox_TanggalKunjunganLagiKunjungan.Enabled = False
        Me.Textbox_TanggalKunjunganLagiKunjungan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Textbox_TanggalKunjunganLagiKunjungan.Location = New System.Drawing.Point(97, 415)
        Me.Textbox_TanggalKunjunganLagiKunjungan.Name = "Textbox_TanggalKunjunganLagiKunjungan"
        Me.Textbox_TanggalKunjunganLagiKunjungan.Size = New System.Drawing.Size(139, 20)
        Me.Textbox_TanggalKunjunganLagiKunjungan.TabIndex = 57
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(3, 412)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(87, 13)
        Me.Label42.TabIndex = 30
        Me.Label42.Text = "Kunjungan Lagi :"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(3, 382)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(73, 13)
        Me.Label46.TabIndex = 60
        Me.Label46.Text = "Unit Poliklinik:"
        '
        'ComboBox_UnitPoliklinikKunjungan
        '
        Me.ComboBox_UnitPoliklinikKunjungan.Enabled = False
        Me.ComboBox_UnitPoliklinikKunjungan.FormattingEnabled = True
        Me.ComboBox_UnitPoliklinikKunjungan.Location = New System.Drawing.Point(97, 385)
        Me.ComboBox_UnitPoliklinikKunjungan.Name = "ComboBox_UnitPoliklinikKunjungan"
        Me.ComboBox_UnitPoliklinikKunjungan.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_UnitPoliklinikKunjungan.TabIndex = 61
        '
        'SplitContainer10
        '
        Me.SplitContainer10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer10.IsSplitterFixed = True
        Me.SplitContainer10.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer10.Name = "SplitContainer10"
        Me.SplitContainer10.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer10.Panel1
        '
        Me.SplitContainer10.Panel1.Controls.Add(Me.TableLayoutPanel11)
        '
        'SplitContainer10.Panel2
        '
        Me.SplitContainer10.Panel2.Controls.Add(Me.DataGridView_Kunjungan)
        Me.SplitContainer10.Size = New System.Drawing.Size(720, 597)
        Me.SplitContainer10.SplitterDistance = 93
        Me.SplitContainer10.TabIndex = 0
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 1
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.FlowLayoutPanel5, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.FlowLayoutPanel6, 0, 1)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 2
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(720, 93)
        Me.TableLayoutPanel11.TabIndex = 4
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.Button_AddKunjungan)
        Me.FlowLayoutPanel5.Controls.Add(Me.Button_EditKunjungan)
        Me.FlowLayoutPanel5.Controls.Add(Me.Button_DeleteKunjungan)
        Me.FlowLayoutPanel5.Controls.Add(Me.Button_ResetKunjungan)
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(714, 40)
        Me.FlowLayoutPanel5.TabIndex = 4
        '
        'Button_AddKunjungan
        '
        Me.Button_AddKunjungan.Image = Global.RKMedis.My.Resources.Resources.add24
        Me.Button_AddKunjungan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_AddKunjungan.Location = New System.Drawing.Point(3, 3)
        Me.Button_AddKunjungan.Name = "Button_AddKunjungan"
        Me.Button_AddKunjungan.Size = New System.Drawing.Size(75, 37)
        Me.Button_AddKunjungan.TabIndex = 60
        Me.Button_AddKunjungan.Text = "Add"
        Me.Button_AddKunjungan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_AddKunjungan.UseVisualStyleBackColor = True
        '
        'Button_EditKunjungan
        '
        Me.Button_EditKunjungan.Image = Global.RKMedis.My.Resources.Resources.edit24
        Me.Button_EditKunjungan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_EditKunjungan.Location = New System.Drawing.Point(84, 3)
        Me.Button_EditKunjungan.Name = "Button_EditKunjungan"
        Me.Button_EditKunjungan.Size = New System.Drawing.Size(75, 37)
        Me.Button_EditKunjungan.TabIndex = 61
        Me.Button_EditKunjungan.Text = "Edit"
        Me.Button_EditKunjungan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_EditKunjungan.UseVisualStyleBackColor = True
        '
        'Button_DeleteKunjungan
        '
        Me.Button_DeleteKunjungan.Image = Global.RKMedis.My.Resources.Resources.delete24
        Me.Button_DeleteKunjungan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_DeleteKunjungan.Location = New System.Drawing.Point(165, 3)
        Me.Button_DeleteKunjungan.Name = "Button_DeleteKunjungan"
        Me.Button_DeleteKunjungan.Size = New System.Drawing.Size(75, 37)
        Me.Button_DeleteKunjungan.TabIndex = 62
        Me.Button_DeleteKunjungan.Text = "Delete"
        Me.Button_DeleteKunjungan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_DeleteKunjungan.UseVisualStyleBackColor = True
        '
        'Button_ResetKunjungan
        '
        Me.Button_ResetKunjungan.Image = Global.RKMedis.My.Resources.Resources.refresh24
        Me.Button_ResetKunjungan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_ResetKunjungan.Location = New System.Drawing.Point(246, 3)
        Me.Button_ResetKunjungan.Name = "Button_ResetKunjungan"
        Me.Button_ResetKunjungan.Size = New System.Drawing.Size(80, 37)
        Me.Button_ResetKunjungan.TabIndex = 63
        Me.Button_ResetKunjungan.Text = "Refresh"
        Me.Button_ResetKunjungan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_ResetKunjungan.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel6.Controls.Add(Me.GroupBox12)
        Me.FlowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(3, 49)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(714, 41)
        Me.FlowLayoutPanel6.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Image = Global.RKMedis.My.Resources.Resources.schedule32
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 41)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Data Kunjungan"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridView_Kunjungan
        '
        Me.DataGridView_Kunjungan.AllowUserToAddRows = False
        Me.DataGridView_Kunjungan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Kunjungan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnKunjungan_Check, Me.ColumnKunjungan_ID, Me.ColumnKunjungan_Tanggal, Me.ColumnKunjungan_NoMedRek, Me.ColumnKunjungan_Nama, Me.ColumnKunjungan_Keluhan, Me.ColumnKunjungan_Diagnosa, Me.ColumnKunjungan_TekananDarah, Me.ColumnKunjungan_BeratBadan, Me.ColumnKunjungan_Tindakan, Me.ColumnKunjungan_Visite, Me.ColumnKunjungan_KunjunganLagi})
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle20.Format = "D"
        DataGridViewCellStyle20.NullValue = Nothing
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_Kunjungan.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridView_Kunjungan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Kunjungan.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_Kunjungan.Name = "DataGridView_Kunjungan"
        Me.DataGridView_Kunjungan.Size = New System.Drawing.Size(720, 500)
        Me.DataGridView_Kunjungan.TabIndex = 0
        '
        'ColumnKunjungan_Check
        '
        Me.ColumnKunjungan_Check.HeaderText = "#"
        Me.ColumnKunjungan_Check.Name = "ColumnKunjungan_Check"
        Me.ColumnKunjungan_Check.Width = 25
        '
        'ColumnKunjungan_ID
        '
        Me.ColumnKunjungan_ID.HeaderText = "#"
        Me.ColumnKunjungan_ID.Name = "ColumnKunjungan_ID"
        Me.ColumnKunjungan_ID.Visible = False
        '
        'ColumnKunjungan_Tanggal
        '
        Me.ColumnKunjungan_Tanggal.HeaderText = "Tanggal"
        Me.ColumnKunjungan_Tanggal.Name = "ColumnKunjungan_Tanggal"
        '
        'ColumnKunjungan_NoMedRek
        '
        Me.ColumnKunjungan_NoMedRek.HeaderText = "No.MedRek"
        Me.ColumnKunjungan_NoMedRek.Name = "ColumnKunjungan_NoMedRek"
        '
        'ColumnKunjungan_Nama
        '
        Me.ColumnKunjungan_Nama.HeaderText = "Nama"
        Me.ColumnKunjungan_Nama.Name = "ColumnKunjungan_Nama"
        '
        'ColumnKunjungan_Keluhan
        '
        Me.ColumnKunjungan_Keluhan.HeaderText = "Keluhan"
        Me.ColumnKunjungan_Keluhan.Name = "ColumnKunjungan_Keluhan"
        '
        'ColumnKunjungan_Diagnosa
        '
        Me.ColumnKunjungan_Diagnosa.HeaderText = "Diagnosa"
        Me.ColumnKunjungan_Diagnosa.Name = "ColumnKunjungan_Diagnosa"
        '
        'ColumnKunjungan_TekananDarah
        '
        Me.ColumnKunjungan_TekananDarah.HeaderText = "Tekanan Darah"
        Me.ColumnKunjungan_TekananDarah.Name = "ColumnKunjungan_TekananDarah"
        '
        'ColumnKunjungan_BeratBadan
        '
        Me.ColumnKunjungan_BeratBadan.HeaderText = "Berat Badan"
        Me.ColumnKunjungan_BeratBadan.Name = "ColumnKunjungan_BeratBadan"
        '
        'ColumnKunjungan_Tindakan
        '
        Me.ColumnKunjungan_Tindakan.HeaderText = "Tindakan"
        Me.ColumnKunjungan_Tindakan.Name = "ColumnKunjungan_Tindakan"
        '
        'ColumnKunjungan_Visite
        '
        Me.ColumnKunjungan_Visite.HeaderText = "Visite"
        Me.ColumnKunjungan_Visite.Name = "ColumnKunjungan_Visite"
        '
        'ColumnKunjungan_KunjunganLagi
        '
        Me.ColumnKunjungan_KunjunganLagi.HeaderText = "Kunjungan Lagi"
        Me.ColumnKunjungan_KunjunganLagi.Name = "ColumnKunjungan_KunjunganLagi"
        '
        'TabReporting
        '
        Me.TabReporting.Controls.Add(Me.SplitContainer11)
        Me.TabReporting.Location = New System.Drawing.Point(4, 22)
        Me.TabReporting.Name = "TabReporting"
        Me.TabReporting.Padding = New System.Windows.Forms.Padding(3)
        Me.TabReporting.Size = New System.Drawing.Size(1012, 597)
        Me.TabReporting.TabIndex = 6
        Me.TabReporting.Text = "Reporting"
        Me.TabReporting.UseVisualStyleBackColor = True
        '
        'SplitContainer11
        '
        Me.SplitContainer11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer11.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer11.Name = "SplitContainer11"
        Me.SplitContainer11.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer11.Panel1
        '
        Me.SplitContainer11.Panel1.Controls.Add(Me.RadioButtonFilterDual)
        Me.SplitContainer11.Panel1.Controls.Add(Me.RadioButtonFilterSingle)
        Me.SplitContainer11.Panel1.Controls.Add(Me.TextBoxParameter2)
        Me.SplitContainer11.Panel1.Controls.Add(Me.ComboBoxFilterMode2)
        Me.SplitContainer11.Panel1.Controls.Add(Me.Label45)
        Me.SplitContainer11.Panel1.Controls.Add(Me.TextBoxParameter1)
        Me.SplitContainer11.Panel1.Controls.Add(Me.ButtonRefreshReporting)
        Me.SplitContainer11.Panel1.Controls.Add(Me.Label44)
        Me.SplitContainer11.Panel1.Controls.Add(Me.Label43)
        Me.SplitContainer11.Panel1.Controls.Add(Me.ComboBoxFilterMode1)
        Me.SplitContainer11.Panel1.Controls.Add(Me.ComboBoxDataEntity)
        '
        'SplitContainer11.Panel2
        '
        Me.SplitContainer11.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer11.Size = New System.Drawing.Size(1006, 591)
        Me.SplitContainer11.SplitterDistance = 108
        Me.SplitContainer11.TabIndex = 0
        '
        'RadioButtonFilterDual
        '
        Me.RadioButtonFilterDual.AutoSize = True
        Me.RadioButtonFilterDual.Location = New System.Drawing.Point(366, 16)
        Me.RadioButtonFilterDual.Name = "RadioButtonFilterDual"
        Me.RadioButtonFilterDual.Size = New System.Drawing.Size(47, 17)
        Me.RadioButtonFilterDual.TabIndex = 10
        Me.RadioButtonFilterDual.Text = "Dual"
        Me.RadioButtonFilterDual.UseVisualStyleBackColor = True
        '
        'RadioButtonFilterSingle
        '
        Me.RadioButtonFilterSingle.AutoSize = True
        Me.RadioButtonFilterSingle.Checked = True
        Me.RadioButtonFilterSingle.Location = New System.Drawing.Point(313, 16)
        Me.RadioButtonFilterSingle.Name = "RadioButtonFilterSingle"
        Me.RadioButtonFilterSingle.Size = New System.Drawing.Size(54, 17)
        Me.RadioButtonFilterSingle.TabIndex = 9
        Me.RadioButtonFilterSingle.TabStop = True
        Me.RadioButtonFilterSingle.Text = "Single"
        Me.RadioButtonFilterSingle.UseVisualStyleBackColor = True
        '
        'TextBoxParameter2
        '
        Me.TextBoxParameter2.Enabled = False
        Me.TextBoxParameter2.Location = New System.Drawing.Point(432, 69)
        Me.TextBoxParameter2.Name = "TextBoxParameter2"
        Me.TextBoxParameter2.Size = New System.Drawing.Size(138, 20)
        Me.TextBoxParameter2.TabIndex = 8
        '
        'ComboBoxFilterMode2
        '
        Me.ComboBoxFilterMode2.Enabled = False
        Me.ComboBoxFilterMode2.FormattingEnabled = True
        Me.ComboBoxFilterMode2.Location = New System.Drawing.Point(242, 68)
        Me.ComboBoxFilterMode2.Name = "ComboBoxFilterMode2"
        Me.ComboBoxFilterMode2.Size = New System.Drawing.Size(171, 21)
        Me.ComboBoxFilterMode2.TabIndex = 7
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(433, 18)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(64, 13)
        Me.Label45.TabIndex = 6
        Me.Label45.Text = "Parameter"
        '
        'TextBoxParameter1
        '
        Me.TextBoxParameter1.Location = New System.Drawing.Point(432, 42)
        Me.TextBoxParameter1.Name = "TextBoxParameter1"
        Me.TextBoxParameter1.Size = New System.Drawing.Size(138, 20)
        Me.TextBoxParameter1.TabIndex = 5
        '
        'ButtonRefreshReporting
        '
        Me.ButtonRefreshReporting.Image = Global.RKMedis.My.Resources.Resources.refresh24
        Me.ButtonRefreshReporting.Location = New System.Drawing.Point(600, 16)
        Me.ButtonRefreshReporting.Name = "ButtonRefreshReporting"
        Me.ButtonRefreshReporting.Size = New System.Drawing.Size(98, 46)
        Me.ButtonRefreshReporting.TabIndex = 4
        Me.ButtonRefreshReporting.Text = "Refresh"
        Me.ButtonRefreshReporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonRefreshReporting.UseVisualStyleBackColor = True
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(239, 16)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(74, 13)
        Me.Label44.TabIndex = 3
        Me.Label44.Text = "Filter Mode "
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(29, 16)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(70, 13)
        Me.Label43.TabIndex = 2
        Me.Label43.Text = "Data Entity"
        '
        'ComboBoxFilterMode1
        '
        Me.ComboBoxFilterMode1.FormattingEnabled = True
        Me.ComboBoxFilterMode1.Location = New System.Drawing.Point(242, 41)
        Me.ComboBoxFilterMode1.Name = "ComboBoxFilterMode1"
        Me.ComboBoxFilterMode1.Size = New System.Drawing.Size(171, 21)
        Me.ComboBoxFilterMode1.TabIndex = 1
        '
        'ComboBoxDataEntity
        '
        Me.ComboBoxDataEntity.AutoCompleteCustomSource.AddRange(New String() {"petugas", "dokter", "pasien", "poliklinik", "kunjungan"})
        Me.ComboBoxDataEntity.FormattingEnabled = True
        Me.ComboBoxDataEntity.Items.AddRange(New Object() {"petugas", "dokter", "poliklinik", "pasien", "kunjungan"})
        Me.ComboBoxDataEntity.Location = New System.Drawing.Point(32, 41)
        Me.ComboBoxDataEntity.Name = "ComboBoxDataEntity"
        Me.ComboBoxDataEntity.Size = New System.Drawing.Size(175, 21)
        Me.ComboBoxDataEntity.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource10.Name = "DataSet1"
        ReportDataSource10.Value = Me.petugasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource10)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "RKMedis.ReportPetugas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1006, 479)
        Me.ReportViewer1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'kunjunganBindingSource
        '
        Me.kunjunganBindingSource.DataMember = "kunjungan"
        Me.kunjunganBindingSource.DataSource = Me._db_usedDataSet
        '
        'dokterBindingSource
        '
        Me.dokterBindingSource.DataMember = "dokter"
        Me.dokterBindingSource.DataSource = Me._db_usedDataSet
        '
        'dokterTableAdapter
        '
        Me.dokterTableAdapter.ClearBeforeFill = True
        '
        'petugasTableAdapter
        '
        Me.petugasTableAdapter.ClearBeforeFill = True
        '
        'poliklinikBindingSource
        '
        Me.poliklinikBindingSource.DataMember = "poliklinik"
        Me.poliklinikBindingSource.DataSource = Me._db_usedDataSet
        '
        'poliklinikTableAdapter
        '
        Me.poliklinikTableAdapter.ClearBeforeFill = True
        '
        'pasienBindingSource
        '
        Me.pasienBindingSource.DataMember = "pasien"
        Me.pasienBindingSource.DataSource = Me._db_usedDataSet
        '
        'pasienTableAdapter
        '
        Me.pasienTableAdapter.ClearBeforeFill = True
        '
        'kunjunganTableAdapter
        '
        Me.kunjunganTableAdapter.ClearBeforeFill = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.FlowKunjunganNavigasi)
        Me.GroupBox12.Location = New System.Drawing.Point(204, 3)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(485, 37)
        Me.GroupBox12.TabIndex = 2
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Halaman"
        '
        'FlowKunjunganNavigasi
        '
        Me.FlowKunjunganNavigasi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowKunjunganNavigasi.Location = New System.Drawing.Point(3, 16)
        Me.FlowKunjunganNavigasi.Name = "FlowKunjunganNavigasi"
        Me.FlowKunjunganNavigasi.Size = New System.Drawing.Size(479, 18)
        Me.FlowKunjunganNavigasi.TabIndex = 0
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 694)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Home"
        Me.Text = "RKMedis"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.petugasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._db_usedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabDokter.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.TableLayoutPanel14.ResumeLayout(False)
        Me.FlowLayoutPanel9.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        CType(Me.DataGridView_Dokter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPetugas.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TableLayoutPanel15.ResumeLayout(False)
        Me.FlowLayoutPanel10.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.DataGridView_Petugas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabHome.ResumeLayout(False)
        Me.TableLayoutPanel16.ResumeLayout(False)
        Me.TableLayoutPanel17.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PictureHome_Dokter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel18.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureHome_Petugas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel19.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel20.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.PictureHome_Poliklinik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel21.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.PictureHome_Pasien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPasien.ResumeLayout(False)
        Me.SplitContainer7.Panel1.ResumeLayout(False)
        Me.SplitContainer7.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.SplitContainer8.Panel1.ResumeLayout(False)
        Me.SplitContainer8.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer8.ResumeLayout(False)
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.FlowLayoutPanel8.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        CType(Me.DataGridView_Pasien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPoliklinik.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.FlowLayoutPanel11.ResumeLayout(False)
        CType(Me.DataGridView_NamaPetugasPoliklinik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer6.ResumeLayout(False)
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.FlowLayoutPanel7.ResumeLayout(False)
        Me.FlowLayoutPanel4.ResumeLayout(False)
        CType(Me.DataGridView_Poliklinik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabKunjungan.ResumeLayout(False)
        Me.SplitContainer9.Panel1.ResumeLayout(False)
        Me.SplitContainer9.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer9.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.SplitContainer10.Panel1.ResumeLayout(False)
        Me.SplitContainer10.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer10.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel6.ResumeLayout(False)
        CType(Me.DataGridView_Kunjungan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabReporting.ResumeLayout(False)
        Me.SplitContainer11.Panel1.ResumeLayout(False)
        Me.SplitContainer11.Panel1.PerformLayout()
        Me.SplitContainer11.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer11.ResumeLayout(False)
        CType(Me.kunjunganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dokterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.poliklinikBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pasienBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox12.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripExportButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents LabelStatusBottom As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSearchText As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSearchButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabDokter As System.Windows.Forms.TabPage
    Friend WithEvents TabPetugas As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabHome As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPasien As System.Windows.Forms.TabPage
    Friend WithEvents TabPoliklinik As System.Windows.Forms.TabPage
    Friend WithEvents TabKunjungan As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label_JumlahDataPetugas As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonHome_AddPetugas As System.Windows.Forms.Button
    Friend WithEvents ButtonHome_ReportPetugas As System.Windows.Forms.Button
    Friend WithEvents PictureHome_Petugas As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label_JumlahDataDokter As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ButtonHome_AddDokter As System.Windows.Forms.Button
    Friend WithEvents ButtonHome_ReportDokter As System.Windows.Forms.Button
    Friend WithEvents PictureHome_Dokter As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label_JumlahDataPasien As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ButtonHome_AddPasien As System.Windows.Forms.Button
    Friend WithEvents ButtonHome_ReportPasien As System.Windows.Forms.Button
    Friend WithEvents PictureHome_Pasien As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label_JumlahDataPoliklinik As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ButtonHome_AddPoliklinik As System.Windows.Forms.Button
    Friend WithEvents ButtonHome_ReportPoliklinik As System.Windows.Forms.Button
    Friend WithEvents PictureHome_Poliklinik As System.Windows.Forms.PictureBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button_AddPetugas As System.Windows.Forms.Button
    Friend WithEvents Button_DeletePetugas As System.Windows.Forms.Button
    Friend WithEvents Button_EditPetugas As System.Windows.Forms.Button
    Friend WithEvents DataGridView_Petugas As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox_NipPetugas As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox_NamaPetugas As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_JabatanPetugas As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_TelpPetugas As System.Windows.Forms.TextBox
    Friend WithEvents Button_SavePetugas As System.Windows.Forms.Button
    Friend WithEvents Button_CancelPetugas As System.Windows.Forms.Button
    Friend WithEvents Button_ResetPetugas As System.Windows.Forms.Button
    Friend WithEvents Label_IDPetugas As System.Windows.Forms.Label
    Friend WithEvents ColumnPetugas_Check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ColumnPetugas_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPetugas_NIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPetugas_Nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPetugas_Jabatan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPetugas_Telp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label_ModeFormPetugas As System.Windows.Forms.Label
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TextBox_SpesialisDokter As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox_NipDokter As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox_NamaDokter As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_KodeDokter As System.Windows.Forms.TextBox
    Friend WithEvents Button_SaveDokter As System.Windows.Forms.Button
    Friend WithEvents Button_CancelDokter As System.Windows.Forms.Button
    Friend WithEvents Label_IDDokter As System.Windows.Forms.Label
    Friend WithEvents Label_ModeFormDokter As System.Windows.Forms.Label
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button_ResetDokter As System.Windows.Forms.Button
    Friend WithEvents Button_AddDokter As System.Windows.Forms.Button
    Friend WithEvents Button_DeleteDokter As System.Windows.Forms.Button
    Friend WithEvents Button_EditDokter As System.Windows.Forms.Button
    Friend WithEvents DataGridView_Dokter As System.Windows.Forms.DataGridView
    Friend WithEvents ColumnDokter_Check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ColumnDokter_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnDokter_NIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnDokter_Nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnDokter_Kode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnDokter_Spesialis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TextBox_UnitPoliklinik As System.Windows.Forms.TextBox
    Friend WithEvents Button_SavePoliklinik As System.Windows.Forms.Button
    Friend WithEvents Button_CancelPoliklinik As System.Windows.Forms.Button
    Friend WithEvents Label_IDPoliklinik As System.Windows.Forms.Label
    Friend WithEvents Label_ModeFormPoliklinik As System.Windows.Forms.Label
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button_ResetPoliklinik As System.Windows.Forms.Button
    Friend WithEvents Button_AddPoliklinik As System.Windows.Forms.Button
    Friend WithEvents Button_DeletePoliklinik As System.Windows.Forms.Button
    Friend WithEvents Button_EditPoliklinik As System.Windows.Forms.Button
    Friend WithEvents DataGridView_Poliklinik As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer7 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TextBox_NamaPasien As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_NoMedRekPasien As System.Windows.Forms.TextBox
    Friend WithEvents Button_SavePasien As System.Windows.Forms.Button
    Friend WithEvents Button_CancelPasien As System.Windows.Forms.Button
    Friend WithEvents Label_ModeFormPasien As System.Windows.Forms.Label
    Friend WithEvents SplitContainer8 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button_RefreshPasien As System.Windows.Forms.Button
    Friend WithEvents Button_AddPasien As System.Windows.Forms.Button
    Friend WithEvents Button_DeletePasien As System.Windows.Forms.Button
    Friend WithEvents Button_EditPasien As System.Windows.Forms.Button
    Friend WithEvents DataGridView_Pasien As System.Windows.Forms.DataGridView
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Textbox_TanggalLahirPasien As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label_IDPasien As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TextBox_TempatLahirPasien As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton_KelaminWanitaPasien As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_KelaminPriaPasien As System.Windows.Forms.RadioButton
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TextBox_AlamatPasien As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_TelpPasien As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TextBox_TanggalBuatPasien As System.Windows.Forms.DateTimePicker
    Friend WithEvents Combobox_StatusPasien As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer9 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel9 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TextBox_NamaPasienKunjungan As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_NoMedRekKunjungan As System.Windows.Forms.TextBox
    Friend WithEvents Button_SaveKunjungan As System.Windows.Forms.Button
    Friend WithEvents Button_CancelKunjungan As System.Windows.Forms.Button
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents TextBox_KeluhanKunjungan As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer10 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button_ResetKunjungan As System.Windows.Forms.Button
    Friend WithEvents Button_AddKunjungan As System.Windows.Forms.Button
    Friend WithEvents Button_DeleteKunjungan As System.Windows.Forms.Button
    Friend WithEvents Button_EditKunjungan As System.Windows.Forms.Button
    Friend WithEvents DataGridView_Kunjungan As System.Windows.Forms.DataGridView
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents TextBox_DiagnosaKunjungan As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents TextBox_TekananDarahKunjungan As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents TextBox_BeratBadanKunjungan As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents TextBox_TindakanKunjungan As System.Windows.Forms.TextBox
    Friend WithEvents Label_IDPasienKunjungan As System.Windows.Forms.Label
    Friend WithEvents Label_IDKunjungan As System.Windows.Forms.Label
    Friend WithEvents Label_ModeFormKunjungan As System.Windows.Forms.Label
    Friend WithEvents Textbox_TanggalKunjungan As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel10 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label_JumlahDataKunjungan As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonHome_AddKunjungan As System.Windows.Forms.Button
    Friend WithEvents ButtonHome_ReportKunjungan As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripImportButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel5 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_CatatanPasien As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel11 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel6 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel13 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel8 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel12 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel7 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel14 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel9 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel15 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel10 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton_VisitePoliklinikKunjungan As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_VisiteRumahKunjungan As System.Windows.Forms.RadioButton
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Textbox_TanggalKunjunganLagiKunjungan As System.Windows.Forms.DateTimePicker
    Friend WithEvents TableLayoutPanel16 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel17 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel18 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel19 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel20 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel21 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ColumnKunjungan_Check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ColumnKunjungan_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnKunjungan_Tanggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnKunjungan_NoMedRek As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnKunjungan_Nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnKunjungan_Keluhan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnKunjungan_Diagnosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnKunjungan_TekananDarah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnKunjungan_BeratBadan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnKunjungan_Tindakan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnKunjungan_Visite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnKunjungan_KunjunganLagi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabReporting As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer11 As System.Windows.Forms.SplitContainer
    Friend WithEvents ComboBoxFilterMode1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxDataEntity As System.Windows.Forms.ComboBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents TextBoxParameter1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonRefreshReporting As System.Windows.Forms.Button
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ColumnPasien_Check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ColumnPasien_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPasien_NoMedRek As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPasien_Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPasien_TanggalBuat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPasien_Nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPasien_TanggalLahir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPasien_TempatLahir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPasien_Kelamin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPasien_Alamat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPasien_Telp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPasien_TotalKunjungan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPasien_Catatan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dokterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _db_usedDataSet As RKMedis._db_usedDataSet
    Friend WithEvents dokterTableAdapter As RKMedis._db_usedDataSetTableAdapters.dokterTableAdapter
    Friend WithEvents petugasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents petugasTableAdapter As RKMedis._db_usedDataSetTableAdapters.petugasTableAdapter
    Friend WithEvents poliklinikBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents poliklinikTableAdapter As RKMedis._db_usedDataSetTableAdapters.poliklinikTableAdapter
    Friend WithEvents pasienBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents pasienTableAdapter As RKMedis._db_usedDataSetTableAdapters.pasienTableAdapter
    Friend WithEvents kunjunganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents kunjunganTableAdapter As RKMedis._db_usedDataSetTableAdapters.kunjunganTableAdapter
    Friend WithEvents ComboBox_DokterPoliklinik As System.Windows.Forms.ComboBox
    Friend WithEvents FlowLayoutPanel11 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ComboBox_PetugasPoliklinik As System.Windows.Forms.ComboBox
    Friend WithEvents Button_AddPetugasToPoliklinik As System.Windows.Forms.Button
    Friend WithEvents DataGridView_NamaPetugasPoliklinik As System.Windows.Forms.DataGridView
    Friend WithEvents ColumnPoliklinik_Check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ColumnPoliklinik_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPoliklinik_Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPoliklinik_NamaDokter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPoliklinik_NamaPetugas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Table_PetugasPoliklinik As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button_DeletePetugasFromPoliklinik As System.Windows.Forms.Button
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_UnitPoliklinikKunjungan As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxParameter2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxFilterMode2 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButtonFilterSingle As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonFilterDual As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents FlowPasienNavigasi As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents FlowKunjunganNavigasi As System.Windows.Forms.FlowLayoutPanel
End Class
