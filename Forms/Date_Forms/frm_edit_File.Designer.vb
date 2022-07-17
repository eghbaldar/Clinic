<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Edit_File
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_Update_OriginalInfo = New DevComponents.DotNetBar.ButtonX()
        Me.cmb_doctors = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rb_divorced = New System.Windows.Forms.RadioButton()
        Me.rb_marriage = New System.Windows.Forms.RadioButton()
        Me.rb_single = New System.Windows.Forms.RadioButton()
        Me.btn_webcam = New System.Windows.Forms.PictureBox()
        Me.txt_dateBirth = New HM_FarsiCalendar.HM_FarsiCalendar()
        Me.txt_presenter = New TextualControl.TextualControl()
        Me.txt_wieght = New TextualControl.TextualControl()
        Me.txt_height = New TextualControl.TextualControl()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rb_famale = New System.Windows.Forms.RadioButton()
        Me.rb_male = New System.Windows.Forms.RadioButton()
        Me.cmb_blood = New System.Windows.Forms.ComboBox()
        Me.btn_FullScreen = New System.Windows.Forms.PictureBox()
        Me.btn_Delete = New System.Windows.Forms.PictureBox()
        Me.btn_Open = New System.Windows.Forms.PictureBox()
        Me.cmb_groupSick = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_DateRegister = New TextualControl.TextualControl()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_job = New TextualControl.TextualControl()
        Me.txt_email = New TextualControl.TextualControl()
        Me.txt_mobile = New TextualControl.TextualControl()
        Me.txt_phone = New TextualControl.TextualControl()
        Me.txt_detail = New TextualControl.TextualControl()
        Me.txt_address = New TextualControl.TextualControl()
        Me.txt_l_name = New TextualControl.TextualControl()
        Me.txt_f_name = New TextualControl.TextualControl()
        Me.txt_Code = New TextualControl.TextualControl()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_RecordForTitle = New System.Windows.Forms.DataGridView()
        Me.IdRecordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdFileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SelectRecordForFileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_RecordTitle = New Clinic.ds_RecordTitle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lst_Records = New System.Windows.Forms.ListBox()
        Me.SelectRecordTitleForFileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_Record_Doctor = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btn_InsertRecord = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btn_showPhotoBank = New DevComponents.DotNetBar.ButtonX()
        Me.dgv_BankPhoto = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDFileDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectPhotoBankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_PhotoBank = New Clinic.ds_PhotoBank()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Dgv_Prescription = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdReceptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPersonalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LightPenDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MedicationReviewDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaientDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePrescripptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPeriodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectprescriptionFileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_prescription = New Clinic.ds_prescription()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.dgv_list_surgery = New System.Windows.Forms.DataGridView()
        Me.IdFileDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.عنوانDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.تاریخجراحیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.وضعیتجراحیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.توضیحاتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.تاریخنهاییDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.نتیجهجراحیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectSurgeryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Surgery = New Clinic.ds_Surgery()
        Me.btnShowInfo = New DevComponents.DotNetBar.ButtonX()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.btn_Update_ManualFile = New DevComponents.DotNetBar.ButtonX()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btn_Manual_full_2 = New System.Windows.Forms.PictureBox()
        Me.btn_Manual_delete_2 = New System.Windows.Forms.PictureBox()
        Me.btn_Manual_open_2 = New System.Windows.Forms.PictureBox()
        Me.pic_Manual_2 = New System.Windows.Forms.PictureBox()
        Me.btn_Manual_full_1 = New System.Windows.Forms.PictureBox()
        Me.btn_Manual_Delete_1 = New System.Windows.Forms.PictureBox()
        Me.btn_Manual_open_1 = New System.Windows.Forms.PictureBox()
        Me.pic_Manual_1 = New System.Windows.Forms.PictureBox()
        Me.txt_CodeManual = New TextualControl.TextualControl()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btn_Cancel = New DevComponents.DotNetBar.ButtonX()
        Me.Select_RecordTitleForFileTableAdapter = New Clinic.ds_RecordTitleTableAdapters.Select_RecordTitleForFileTableAdapter()
        Me.Select_RecordForFileTableAdapter = New Clinic.ds_RecordTitleTableAdapters.Select_RecordForFileTableAdapter()
        Me.Select_SurgeryTableAdapter = New Clinic.ds_SurgeryTableAdapters.Select_SurgeryTableAdapter()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Surgery1 = New Clinic.ds_Surgery()
        Me.Select_SurgeryTableAdapter1 = New Clinic.ds_SurgeryTableAdapters.Select_SurgeryTableAdapter()
        Me.Select_PhotoBankTableAdapter = New Clinic.ds_PhotoBankTableAdapters.Select_PhotoBankTableAdapter()
        Me.Select_prescription_FileTableAdapter = New Clinic.ds_prescriptionTableAdapters.Select_prescription_FileTableAdapter()
        Me.SelectGroupSickfordoctorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_GroupSick = New Clinic.ds_GroupSick()
        Me.Select_GroupSick_for_doctorTableAdapter = New Clinic.ds_GroupSickTableAdapters.Select_GroupSick_for_doctorTableAdapter()
        Me.SelectdoctorforGroupSickBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Personal = New Clinic.ds_Personal()
        Me.Select_doctor_for_GroupSickTableAdapter = New Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btn_webcam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_FullScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Open, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_RecordForTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectRecordForFileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_RecordTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SelectRecordTitleForFileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgv_BankPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectPhotoBankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_PhotoBank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.Dgv_Prescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectprescriptionFileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_prescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgv_list_surgery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectSurgeryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Surgery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.btn_Manual_full_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Manual_delete_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Manual_open_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Manual_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Manual_full_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Manual_Delete_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Manual_open_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Manual_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Surgery1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectGroupSickfordoctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_GroupSick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(5, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(906, 389)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_Update_OriginalInfo)
        Me.TabPage1.Controls.Add(Me.cmb_doctors)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.btn_webcam)
        Me.TabPage1.Controls.Add(Me.txt_dateBirth)
        Me.TabPage1.Controls.Add(Me.txt_presenter)
        Me.TabPage1.Controls.Add(Me.txt_wieght)
        Me.TabPage1.Controls.Add(Me.txt_height)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.cmb_blood)
        Me.TabPage1.Controls.Add(Me.btn_FullScreen)
        Me.TabPage1.Controls.Add(Me.btn_Delete)
        Me.TabPage1.Controls.Add(Me.btn_Open)
        Me.TabPage1.Controls.Add(Me.cmb_groupSick)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.txt_DateRegister)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.txt_job)
        Me.TabPage1.Controls.Add(Me.txt_email)
        Me.TabPage1.Controls.Add(Me.txt_mobile)
        Me.TabPage1.Controls.Add(Me.txt_phone)
        Me.TabPage1.Controls.Add(Me.txt_detail)
        Me.TabPage1.Controls.Add(Me.txt_address)
        Me.TabPage1.Controls.Add(Me.txt_l_name)
        Me.TabPage1.Controls.Add(Me.txt_f_name)
        Me.TabPage1.Controls.Add(Me.txt_Code)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.PictureBox)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(898, 363)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "اطلاعات اصلی"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_Update_OriginalInfo
        '
        Me.btn_Update_OriginalInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Update_OriginalInfo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Update_OriginalInfo.Location = New System.Drawing.Point(749, 334)
        Me.btn_Update_OriginalInfo.Name = "btn_Update_OriginalInfo"
        Me.btn_Update_OriginalInfo.Size = New System.Drawing.Size(131, 23)
        Me.btn_Update_OriginalInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Update_OriginalInfo.TabIndex = 54
        Me.btn_Update_OriginalInfo.Text = "ذخیره سازی"
        '
        'cmb_doctors
        '
        Me.cmb_doctors.DataSource = Me.SelectdoctorforGroupSickBindingSource
        Me.cmb_doctors.DisplayMember = "Doctor_Name"
        Me.cmb_doctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_doctors.FormattingEnabled = True
        Me.cmb_doctors.Location = New System.Drawing.Point(650, 39)
        Me.cmb_doctors.Name = "cmb_doctors"
        Me.cmb_doctors.Size = New System.Drawing.Size(157, 21)
        Me.cmb_doctors.TabIndex = 53
        Me.cmb_doctors.ValueMember = "id"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(812, 43)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 13)
        Me.Label20.TabIndex = 52
        Me.Label20.Text = "پزشک معالج:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RadioButton1)
        Me.Panel3.Location = New System.Drawing.Point(14, 268)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(121, 26)
        Me.Panel3.TabIndex = 51
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(73, 5)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton1.TabIndex = 14
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "فعال"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rb_divorced)
        Me.Panel2.Controls.Add(Me.rb_marriage)
        Me.Panel2.Controls.Add(Me.rb_single)
        Me.Panel2.Location = New System.Drawing.Point(642, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(167, 28)
        Me.Panel2.TabIndex = 50
        '
        'rb_divorced
        '
        Me.rb_divorced.AutoSize = True
        Me.rb_divorced.Location = New System.Drawing.Point(1, 6)
        Me.rb_divorced.Name = "rb_divorced"
        Me.rb_divorced.Size = New System.Drawing.Size(61, 17)
        Me.rb_divorced.TabIndex = 42
        Me.rb_divorced.Tag = "2"
        Me.rb_divorced.Text = "مطعلقه"
        Me.rb_divorced.UseVisualStyleBackColor = True
        '
        'rb_marriage
        '
        Me.rb_marriage.AutoSize = True
        Me.rb_marriage.Location = New System.Drawing.Point(63, 6)
        Me.rb_marriage.Name = "rb_marriage"
        Me.rb_marriage.Size = New System.Drawing.Size(54, 17)
        Me.rb_marriage.TabIndex = 41
        Me.rb_marriage.Tag = "2"
        Me.rb_marriage.Text = "متاهل"
        Me.rb_marriage.UseVisualStyleBackColor = True
        '
        'rb_single
        '
        Me.rb_single.AutoSize = True
        Me.rb_single.Checked = True
        Me.rb_single.Location = New System.Drawing.Point(116, 6)
        Me.rb_single.Name = "rb_single"
        Me.rb_single.Size = New System.Drawing.Size(48, 17)
        Me.rb_single.TabIndex = 40
        Me.rb_single.TabStop = True
        Me.rb_single.Tag = "2"
        Me.rb_single.Text = "مجرد"
        Me.rb_single.UseVisualStyleBackColor = True
        '
        'btn_webcam
        '
        Me.btn_webcam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_webcam.Image = Global.Clinic.My.Resources.Resources.webcam
        Me.btn_webcam.Location = New System.Drawing.Point(162, 241)
        Me.btn_webcam.Name = "btn_webcam"
        Me.btn_webcam.Size = New System.Drawing.Size(21, 20)
        Me.btn_webcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_webcam.TabIndex = 49
        Me.btn_webcam.TabStop = False
        '
        'txt_dateBirth
        '
        Me.txt_dateBirth.BodyBackColor = System.Drawing.Color.White
        Me.txt_dateBirth.BodyForeColor = System.Drawing.Color.Black
        Me.txt_dateBirth.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_dateBirth.HeaderBackColor = System.Drawing.Color.Gray
        Me.txt_dateBirth.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txt_dateBirth.HeaderForeColor = System.Drawing.Color.White
        Me.txt_dateBirth.Location = New System.Drawing.Point(222, 14)
        Me.txt_dateBirth.Max_Date = "1400/12/30"
        Me.txt_dateBirth.Min_Date = "1350/01/01"
        Me.txt_dateBirth.Name = "txt_dateBirth"
        Me.txt_dateBirth.SelectedBackColor = System.Drawing.Color.Blue
        Me.txt_dateBirth.SelectedForeColor = System.Drawing.Color.White
        Me.txt_dateBirth.Size = New System.Drawing.Size(125, 21)
        Me.txt_dateBirth.TabIndex = 48
        Me.txt_dateBirth.TitleFont = New System.Drawing.Font("Tahoma", 8.25!)
        '
        'txt_presenter
        '
        Me.txt_presenter.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_presenter.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_presenter.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_presenter.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_presenter.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_presenter.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_presenter.__NextFocuse = True
        Me.txt_presenter.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_presenter.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_presenter.Location = New System.Drawing.Point(190, 106)
        Me.txt_presenter.Name = "txt_presenter"
        Me.txt_presenter.Size = New System.Drawing.Size(157, 21)
        Me.txt_presenter.TabIndex = 47
        '
        'txt_wieght
        '
        Me.txt_wieght.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_wieght.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_wieght.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_wieght.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_wieght.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_wieght.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_wieght.__NextFocuse = True
        Me.txt_wieght.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_wieght.__Type = TextualControl.TextualControl.No.Numeric
        Me.txt_wieght.Location = New System.Drawing.Point(190, 74)
        Me.txt_wieght.Name = "txt_wieght"
        Me.txt_wieght.Size = New System.Drawing.Size(157, 21)
        Me.txt_wieght.TabIndex = 46
        '
        'txt_height
        '
        Me.txt_height.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_height.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_height.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_height.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_height.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_height.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_height.__NextFocuse = True
        Me.txt_height.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_height.__Type = TextualControl.TextualControl.No.Numeric
        Me.txt_height.Location = New System.Drawing.Point(190, 45)
        Me.txt_height.Name = "txt_height"
        Me.txt_height.Size = New System.Drawing.Size(157, 21)
        Me.txt_height.TabIndex = 45
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(353, 109)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "معرف:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(353, 76)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(27, 13)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "وزن:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(353, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(22, 13)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "قد:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(353, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "تاریخ تولد:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rb_famale)
        Me.Panel1.Controls.Add(Me.rb_male)
        Me.Panel1.Location = New System.Drawing.Point(651, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(158, 27)
        Me.Panel1.TabIndex = 38
        '
        'rb_famale
        '
        Me.rb_famale.AutoSize = True
        Me.rb_famale.Location = New System.Drawing.Point(72, 5)
        Me.rb_famale.Name = "rb_famale"
        Me.rb_famale.Size = New System.Drawing.Size(36, 17)
        Me.rb_famale.TabIndex = 27
        Me.rb_famale.Tag = "1"
        Me.rb_famale.Text = "زن"
        Me.rb_famale.UseVisualStyleBackColor = True
        '
        'rb_male
        '
        Me.rb_male.AutoSize = True
        Me.rb_male.Checked = True
        Me.rb_male.Location = New System.Drawing.Point(114, 5)
        Me.rb_male.Name = "rb_male"
        Me.rb_male.Size = New System.Drawing.Size(41, 17)
        Me.rb_male.TabIndex = 26
        Me.rb_male.TabStop = True
        Me.rb_male.Tag = "1"
        Me.rb_male.Text = "مرد"
        Me.rb_male.UseVisualStyleBackColor = True
        '
        'cmb_blood
        '
        Me.cmb_blood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_blood.FormattingEnabled = True
        Me.cmb_blood.Items.AddRange(New Object() {"-O", "+O", "-A", "+A", "-B", "+B", "-AB", "+AB"})
        Me.cmb_blood.Location = New System.Drawing.Point(409, 166)
        Me.cmb_blood.Name = "cmb_blood"
        Me.cmb_blood.Size = New System.Drawing.Size(159, 21)
        Me.cmb_blood.TabIndex = 37
        '
        'btn_FullScreen
        '
        Me.btn_FullScreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_FullScreen.Image = Global.Clinic.My.Resources.Resources.fullscreen
        Me.btn_FullScreen.Location = New System.Drawing.Point(68, 242)
        Me.btn_FullScreen.Name = "btn_FullScreen"
        Me.btn_FullScreen.Size = New System.Drawing.Size(21, 20)
        Me.btn_FullScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_FullScreen.TabIndex = 36
        Me.btn_FullScreen.TabStop = False
        '
        'btn_Delete
        '
        Me.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Delete.Image = Global.Clinic.My.Resources.Resources.delete
        Me.btn_Delete.Location = New System.Drawing.Point(41, 242)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(21, 20)
        Me.btn_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Delete.TabIndex = 35
        Me.btn_Delete.TabStop = False
        '
        'btn_Open
        '
        Me.btn_Open.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Open.Image = Global.Clinic.My.Resources.Resources.open
        Me.btn_Open.Location = New System.Drawing.Point(14, 242)
        Me.btn_Open.Name = "btn_Open"
        Me.btn_Open.Size = New System.Drawing.Size(21, 20)
        Me.btn_Open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Open.TabIndex = 34
        Me.btn_Open.TabStop = False
        '
        'cmb_groupSick
        '
        Me.cmb_groupSick.DataSource = Me.SelectGroupSickfordoctorBindingSource
        Me.cmb_groupSick.DisplayMember = "Name"
        Me.cmb_groupSick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_groupSick.FormattingEnabled = True
        Me.cmb_groupSick.Location = New System.Drawing.Point(409, 14)
        Me.cmb_groupSick.Name = "cmb_groupSick"
        Me.cmb_groupSick.Size = New System.Drawing.Size(157, 21)
        Me.cmb_groupSick.TabIndex = 33
        Me.cmb_groupSick.ValueMember = "Id"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(572, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "گروه بیمار:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(574, 168)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "گروه خونی:"
        '
        'txt_DateRegister
        '
        Me.txt_DateRegister.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_DateRegister.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_DateRegister.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_DateRegister.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_DateRegister.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_DateRegister.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_DateRegister.__NextFocuse = True
        Me.txt_DateRegister.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_DateRegister.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_DateRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_DateRegister.Location = New System.Drawing.Point(14, 299)
        Me.txt_DateRegister.Name = "txt_DateRegister"
        Me.txt_DateRegister.ReadOnly = True
        Me.txt_DateRegister.Size = New System.Drawing.Size(114, 21)
        Me.txt_DateRegister.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(134, 302)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "تاریخ ثبت:"
        '
        'txt_job
        '
        Me.txt_job.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_job.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_job.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_job.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_job.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_job.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_job.__NextFocuse = True
        Me.txt_job.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_job.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_job.Location = New System.Drawing.Point(411, 138)
        Me.txt_job.Name = "txt_job"
        Me.txt_job.Size = New System.Drawing.Size(157, 21)
        Me.txt_job.TabIndex = 23
        '
        'txt_email
        '
        Me.txt_email.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_email.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_email.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban_Characters
        Me.txt_email.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_email.__NextFocuse = True
        Me.txt_email.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_email.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_email.Location = New System.Drawing.Point(411, 109)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(157, 21)
        Me.txt_email.TabIndex = 22
        '
        'txt_mobile
        '
        Me.txt_mobile.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_mobile.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_mobile.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_mobile.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_mobile.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_mobile.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_mobile.__NextFocuse = True
        Me.txt_mobile.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_mobile.__Type = TextualControl.TextualControl.No.Numeric
        Me.txt_mobile.Location = New System.Drawing.Point(411, 77)
        Me.txt_mobile.Name = "txt_mobile"
        Me.txt_mobile.Size = New System.Drawing.Size(157, 21)
        Me.txt_mobile.TabIndex = 21
        '
        'txt_phone
        '
        Me.txt_phone.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_phone.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_phone.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_phone.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_phone.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_phone.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_phone.__NextFocuse = True
        Me.txt_phone.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_phone.__Type = TextualControl.TextualControl.No.Numeric
        Me.txt_phone.Location = New System.Drawing.Point(411, 47)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(157, 21)
        Me.txt_phone.TabIndex = 20
        '
        'txt_detail
        '
        Me.txt_detail.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_detail.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_detail.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_detail.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_detail.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_detail.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_detail.__NextFocuse = True
        Me.txt_detail.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_detail.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_detail.Location = New System.Drawing.Point(194, 228)
        Me.txt_detail.Multiline = True
        Me.txt_detail.Name = "txt_detail"
        Me.txt_detail.Size = New System.Drawing.Size(613, 89)
        Me.txt_detail.TabIndex = 19
        '
        'txt_address
        '
        Me.txt_address.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_address.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_address.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_address.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_address.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_address.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_address.__NextFocuse = True
        Me.txt_address.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_address.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_address.Location = New System.Drawing.Point(194, 197)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(613, 21)
        Me.txt_address.TabIndex = 18
        '
        'txt_l_name
        '
        Me.txt_l_name.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_l_name.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_l_name.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_l_name.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_l_name.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_l_name.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_l_name.__NextFocuse = True
        Me.txt_l_name.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_l_name.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_l_name.Location = New System.Drawing.Point(650, 95)
        Me.txt_l_name.Name = "txt_l_name"
        Me.txt_l_name.Size = New System.Drawing.Size(157, 21)
        Me.txt_l_name.TabIndex = 17
        '
        'txt_f_name
        '
        Me.txt_f_name.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_f_name.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_f_name.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_f_name.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_f_name.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_f_name.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_f_name.__NextFocuse = True
        Me.txt_f_name.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_f_name.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_f_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_f_name.Location = New System.Drawing.Point(650, 66)
        Me.txt_f_name.Name = "txt_f_name"
        Me.txt_f_name.Size = New System.Drawing.Size(157, 21)
        Me.txt_f_name.TabIndex = 0
        '
        'txt_Code
        '
        Me.txt_Code.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_Code.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Code.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Code.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_Code.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_Code.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_Code.__NextFocuse = True
        Me.txt_Code.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_Code.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_Code.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Code.Location = New System.Drawing.Point(726, 11)
        Me.txt_Code.Name = "txt_Code"
        Me.txt_Code.ReadOnly = True
        Me.txt_Code.Size = New System.Drawing.Size(80, 21)
        Me.txt_Code.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(813, 231)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "توضیحات:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(141, 273)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "وضعیت:"
        '
        'PictureBox
        '
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox.Location = New System.Drawing.Point(14, 19)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(169, 216)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 11
        Me.PictureBox.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(813, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "آدرس:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(813, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "وضعیت تاهل:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(574, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "شغل:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(574, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "ایمیل:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(574, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "موبایل:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(574, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "تلفن:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(813, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "جنسیت:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(813, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "نام خانوادگی:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(813, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "نام:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(812, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شماره پرونده:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.btn_InsertRecord)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(898, 363)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "سوابق بیمار"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_RecordForTitle)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(561, 351)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "سابقه بیماری ثبت شده"
        '
        'dgv_RecordForTitle
        '
        Me.dgv_RecordForTitle.AllowUserToAddRows = False
        Me.dgv_RecordForTitle.AllowUserToDeleteRows = False
        Me.dgv_RecordForTitle.AutoGenerateColumns = False
        Me.dgv_RecordForTitle.BackgroundColor = System.Drawing.Color.White
        Me.dgv_RecordForTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_RecordForTitle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRecordDataGridViewTextBoxColumn, Me.IdFileDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.DetailsDataGridViewTextBoxColumn, Me.delete})
        Me.dgv_RecordForTitle.DataSource = Me.SelectRecordForFileBindingSource
        Me.dgv_RecordForTitle.Location = New System.Drawing.Point(6, 22)
        Me.dgv_RecordForTitle.Name = "dgv_RecordForTitle"
        Me.dgv_RecordForTitle.Size = New System.Drawing.Size(549, 323)
        Me.dgv_RecordForTitle.TabIndex = 62
        '
        'IdRecordDataGridViewTextBoxColumn
        '
        Me.IdRecordDataGridViewTextBoxColumn.DataPropertyName = "Id_Record"
        Me.IdRecordDataGridViewTextBoxColumn.HeaderText = "Id_Record"
        Me.IdRecordDataGridViewTextBoxColumn.Name = "IdRecordDataGridViewTextBoxColumn"
        Me.IdRecordDataGridViewTextBoxColumn.Visible = False
        '
        'IdFileDataGridViewTextBoxColumn
        '
        Me.IdFileDataGridViewTextBoxColumn.DataPropertyName = "Id_File"
        Me.IdFileDataGridViewTextBoxColumn.HeaderText = "Id_File"
        Me.IdFileDataGridViewTextBoxColumn.Name = "IdFileDataGridViewTextBoxColumn"
        Me.IdFileDataGridViewTextBoxColumn.Visible = False
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "سابقه"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'DetailsDataGridViewTextBoxColumn
        '
        Me.DetailsDataGridViewTextBoxColumn.DataPropertyName = "Details"
        Me.DetailsDataGridViewTextBoxColumn.HeaderText = "توضیحات"
        Me.DetailsDataGridViewTextBoxColumn.Name = "DetailsDataGridViewTextBoxColumn"
        Me.DetailsDataGridViewTextBoxColumn.Width = 380
        '
        'delete
        '
        Me.delete.HeaderText = ""
        Me.delete.Image = Global.Clinic.My.Resources.Resources.delete
        Me.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.delete.Name = "delete"
        Me.delete.Width = 20
        '
        'SelectRecordForFileBindingSource
        '
        Me.SelectRecordForFileBindingSource.DataMember = "Select_RecordForFile"
        Me.SelectRecordForFileBindingSource.DataSource = Me.Ds_RecordTitle
        '
        'Ds_RecordTitle
        '
        Me.Ds_RecordTitle.DataSetName = "ds_RecordTitle"
        Me.Ds_RecordTitle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.lst_Records)
        Me.GroupBox1.Controls.Add(Me.lbl_Record_Doctor)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Location = New System.Drawing.Point(633, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 351)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "انتخاب سابقه"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(187, 44)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(40, 13)
        Me.Label27.TabIndex = 63
        Me.Label27.Text = "سابقه:"
        '
        'lst_Records
        '
        Me.lst_Records.DataSource = Me.SelectRecordTitleForFileBindingSource
        Me.lst_Records.DisplayMember = "Title"
        Me.lst_Records.FormattingEnabled = True
        Me.lst_Records.Location = New System.Drawing.Point(7, 44)
        Me.lst_Records.Name = "lst_Records"
        Me.lst_Records.Size = New System.Drawing.Size(171, 303)
        Me.lst_Records.TabIndex = 62
        Me.lst_Records.ValueMember = "Id"
        '
        'SelectRecordTitleForFileBindingSource
        '
        Me.SelectRecordTitleForFileBindingSource.DataMember = "Select_RecordTitleForFile"
        Me.SelectRecordTitleForFileBindingSource.DataSource = Me.Ds_RecordTitle
        '
        'lbl_Record_Doctor
        '
        Me.lbl_Record_Doctor.AutoSize = True
        Me.lbl_Record_Doctor.Location = New System.Drawing.Point(99, 22)
        Me.lbl_Record_Doctor.Name = "lbl_Record_Doctor"
        Me.lbl_Record_Doctor.Size = New System.Drawing.Size(82, 13)
        Me.lbl_Record_Doctor.TabIndex = 61
        Me.lbl_Record_Doctor.Text = "نام پزشک معالج"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(187, 22)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(70, 13)
        Me.Label26.TabIndex = 60
        Me.Label26.Text = "پزشک معالج:"
        '
        'btn_InsertRecord
        '
        Me.btn_InsertRecord.Location = New System.Drawing.Point(573, 166)
        Me.btn_InsertRecord.Name = "btn_InsertRecord"
        Me.btn_InsertRecord.Size = New System.Drawing.Size(54, 23)
        Me.btn_InsertRecord.TabIndex = 60
        Me.btn_InsertRecord.Text = ">>>>"
        Me.btn_InsertRecord.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btn_showPhotoBank)
        Me.TabPage3.Controls.Add(Me.dgv_BankPhoto)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(898, 363)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "بانک تصاویر"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btn_showPhotoBank
        '
        Me.btn_showPhotoBank.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_showPhotoBank.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_showPhotoBank.Location = New System.Drawing.Point(723, 333)
        Me.btn_showPhotoBank.Name = "btn_showPhotoBank"
        Me.btn_showPhotoBank.Size = New System.Drawing.Size(170, 23)
        Me.btn_showPhotoBank.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.btn_showPhotoBank.TabIndex = 6
        Me.btn_showPhotoBank.Text = "نمایش تصویر"
        '
        'dgv_BankPhoto
        '
        Me.dgv_BankPhoto.AllowUserToAddRows = False
        Me.dgv_BankPhoto.AllowUserToDeleteRows = False
        Me.dgv_BankPhoto.AutoGenerateColumns = False
        Me.dgv_BankPhoto.BackgroundColor = System.Drawing.Color.White
        Me.dgv_BankPhoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_BankPhoto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.IDFileDataGridViewTextBoxColumn2, Me.TitleDataGridViewTextBoxColumn1, Me.PhotoDataGridViewImageColumn, Me.DateDataGridViewTextBoxColumn, Me.DetailDataGridViewTextBoxColumn})
        Me.dgv_BankPhoto.DataSource = Me.SelectPhotoBankBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_BankPhoto.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_BankPhoto.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgv_BankPhoto.Location = New System.Drawing.Point(4, 3)
        Me.dgv_BankPhoto.Name = "dgv_BankPhoto"
        Me.dgv_BankPhoto.ReadOnly = True
        Me.dgv_BankPhoto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_BankPhoto.Size = New System.Drawing.Size(891, 324)
        Me.dgv_BankPhoto.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn1.Visible = False
        '
        'IDFileDataGridViewTextBoxColumn2
        '
        Me.IDFileDataGridViewTextBoxColumn2.DataPropertyName = "ID_File"
        Me.IDFileDataGridViewTextBoxColumn2.HeaderText = "ID_File"
        Me.IDFileDataGridViewTextBoxColumn2.Name = "IDFileDataGridViewTextBoxColumn2"
        Me.IDFileDataGridViewTextBoxColumn2.ReadOnly = True
        Me.IDFileDataGridViewTextBoxColumn2.Visible = False
        '
        'TitleDataGridViewTextBoxColumn1
        '
        Me.TitleDataGridViewTextBoxColumn1.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn1.HeaderText = "عنوان"
        Me.TitleDataGridViewTextBoxColumn1.Name = "TitleDataGridViewTextBoxColumn1"
        Me.TitleDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PhotoDataGridViewImageColumn
        '
        Me.PhotoDataGridViewImageColumn.DataPropertyName = "Photo"
        Me.PhotoDataGridViewImageColumn.HeaderText = "Photo"
        Me.PhotoDataGridViewImageColumn.Name = "PhotoDataGridViewImageColumn"
        Me.PhotoDataGridViewImageColumn.ReadOnly = True
        Me.PhotoDataGridViewImageColumn.Visible = False
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date_"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "تاریخ درج"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DetailDataGridViewTextBoxColumn
        '
        Me.DetailDataGridViewTextBoxColumn.DataPropertyName = "Detail"
        Me.DetailDataGridViewTextBoxColumn.HeaderText = "توضیحات"
        Me.DetailDataGridViewTextBoxColumn.Name = "DetailDataGridViewTextBoxColumn"
        Me.DetailDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetailDataGridViewTextBoxColumn.Width = 640
        '
        'SelectPhotoBankBindingSource
        '
        Me.SelectPhotoBankBindingSource.DataMember = "Select_PhotoBank"
        Me.SelectPhotoBankBindingSource.DataSource = Me.Ds_PhotoBank
        '
        'Ds_PhotoBank
        '
        Me.Ds_PhotoBank.DataSetName = "ds_PhotoBank"
        Me.Ds_PhotoBank.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Dgv_Prescription)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(898, 363)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "ویزیت های انجام شده"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Dgv_Prescription
        '
        Me.Dgv_Prescription.AllowUserToAddRows = False
        Me.Dgv_Prescription.AllowUserToDeleteRows = False
        Me.Dgv_Prescription.AutoGenerateColumns = False
        Me.Dgv_Prescription.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_Prescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Prescription.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn2, Me.IdReceptionDataGridViewTextBoxColumn, Me.IdPersonalDataGridViewTextBoxColumn, Me.PrescriptionDataGridViewTextBoxColumn, Me.LightPenDataGridViewImageColumn, Me.MedicationReviewDataGridViewTextBoxColumn, Me.DetailDataGridViewTextBoxColumn1, Me.PaientDataGridViewTextBoxColumn, Me.DatePrescripptionDataGridViewTextBoxColumn, Me.IDPeriodDataGridViewTextBoxColumn})
        Me.Dgv_Prescription.DataSource = Me.SelectprescriptionFileBindingSource
        Me.Dgv_Prescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_Prescription.Location = New System.Drawing.Point(0, 0)
        Me.Dgv_Prescription.MultiSelect = False
        Me.Dgv_Prescription.Name = "Dgv_Prescription"
        Me.Dgv_Prescription.ReadOnly = True
        Me.Dgv_Prescription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Prescription.Size = New System.Drawing.Size(898, 363)
        Me.Dgv_Prescription.TabIndex = 2
        '
        'IdDataGridViewTextBoxColumn2
        '
        Me.IdDataGridViewTextBoxColumn2.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn2.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn2.Name = "IdDataGridViewTextBoxColumn2"
        Me.IdDataGridViewTextBoxColumn2.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn2.Visible = False
        '
        'IdReceptionDataGridViewTextBoxColumn
        '
        Me.IdReceptionDataGridViewTextBoxColumn.DataPropertyName = "Id_Reception"
        Me.IdReceptionDataGridViewTextBoxColumn.HeaderText = "Id_Reception"
        Me.IdReceptionDataGridViewTextBoxColumn.Name = "IdReceptionDataGridViewTextBoxColumn"
        Me.IdReceptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdReceptionDataGridViewTextBoxColumn.Visible = False
        '
        'IdPersonalDataGridViewTextBoxColumn
        '
        Me.IdPersonalDataGridViewTextBoxColumn.DataPropertyName = "Id_Personal"
        Me.IdPersonalDataGridViewTextBoxColumn.HeaderText = "Id_Personal"
        Me.IdPersonalDataGridViewTextBoxColumn.Name = "IdPersonalDataGridViewTextBoxColumn"
        Me.IdPersonalDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPersonalDataGridViewTextBoxColumn.Visible = False
        '
        'PrescriptionDataGridViewTextBoxColumn
        '
        Me.PrescriptionDataGridViewTextBoxColumn.DataPropertyName = "Prescription"
        Me.PrescriptionDataGridViewTextBoxColumn.HeaderText = "Prescription"
        Me.PrescriptionDataGridViewTextBoxColumn.Name = "PrescriptionDataGridViewTextBoxColumn"
        Me.PrescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrescriptionDataGridViewTextBoxColumn.Visible = False
        '
        'LightPenDataGridViewImageColumn
        '
        Me.LightPenDataGridViewImageColumn.DataPropertyName = "LightPen"
        Me.LightPenDataGridViewImageColumn.HeaderText = "LightPen"
        Me.LightPenDataGridViewImageColumn.Name = "LightPenDataGridViewImageColumn"
        Me.LightPenDataGridViewImageColumn.ReadOnly = True
        Me.LightPenDataGridViewImageColumn.Visible = False
        '
        'MedicationReviewDataGridViewTextBoxColumn
        '
        Me.MedicationReviewDataGridViewTextBoxColumn.DataPropertyName = "Medication_Review"
        Me.MedicationReviewDataGridViewTextBoxColumn.HeaderText = "Medication_Review"
        Me.MedicationReviewDataGridViewTextBoxColumn.Name = "MedicationReviewDataGridViewTextBoxColumn"
        Me.MedicationReviewDataGridViewTextBoxColumn.ReadOnly = True
        Me.MedicationReviewDataGridViewTextBoxColumn.Visible = False
        '
        'DetailDataGridViewTextBoxColumn1
        '
        Me.DetailDataGridViewTextBoxColumn1.DataPropertyName = "Detail"
        Me.DetailDataGridViewTextBoxColumn1.HeaderText = "Detail"
        Me.DetailDataGridViewTextBoxColumn1.Name = "DetailDataGridViewTextBoxColumn1"
        Me.DetailDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DetailDataGridViewTextBoxColumn1.Visible = False
        '
        'PaientDataGridViewTextBoxColumn
        '
        Me.PaientDataGridViewTextBoxColumn.DataPropertyName = "Paient"
        Me.PaientDataGridViewTextBoxColumn.HeaderText = "نام بیمار"
        Me.PaientDataGridViewTextBoxColumn.Name = "PaientDataGridViewTextBoxColumn"
        Me.PaientDataGridViewTextBoxColumn.ReadOnly = True
        Me.PaientDataGridViewTextBoxColumn.Width = 600
        '
        'DatePrescripptionDataGridViewTextBoxColumn
        '
        Me.DatePrescripptionDataGridViewTextBoxColumn.DataPropertyName = "Date_Prescripption"
        Me.DatePrescripptionDataGridViewTextBoxColumn.HeaderText = "تاریخ ویزیت"
        Me.DatePrescripptionDataGridViewTextBoxColumn.Name = "DatePrescripptionDataGridViewTextBoxColumn"
        Me.DatePrescripptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DatePrescripptionDataGridViewTextBoxColumn.Width = 200
        '
        'IDPeriodDataGridViewTextBoxColumn
        '
        Me.IDPeriodDataGridViewTextBoxColumn.DataPropertyName = "ID_Period"
        Me.IDPeriodDataGridViewTextBoxColumn.HeaderText = "ID_Period"
        Me.IDPeriodDataGridViewTextBoxColumn.Name = "IDPeriodDataGridViewTextBoxColumn"
        Me.IDPeriodDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDPeriodDataGridViewTextBoxColumn.Visible = False
        '
        'SelectprescriptionFileBindingSource
        '
        Me.SelectprescriptionFileBindingSource.DataMember = "Select_prescription_File"
        Me.SelectprescriptionFileBindingSource.DataSource = Me.Ds_prescription
        '
        'Ds_prescription
        '
        Me.Ds_prescription.DataSetName = "ds_prescription"
        Me.Ds_prescription.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.dgv_list_surgery)
        Me.TabPage5.Controls.Add(Me.btnShowInfo)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(898, 363)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "جراحی های انجام شده"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'dgv_list_surgery
        '
        Me.dgv_list_surgery.AllowUserToAddRows = False
        Me.dgv_list_surgery.AllowUserToDeleteRows = False
        Me.dgv_list_surgery.AutoGenerateColumns = False
        Me.dgv_list_surgery.BackgroundColor = System.Drawing.Color.White
        Me.dgv_list_surgery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_list_surgery.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFileDataGridViewTextBoxColumn1, Me.IdDataGridViewTextBoxColumn, Me.عنوانDataGridViewTextBoxColumn, Me.تاریخجراحیDataGridViewTextBoxColumn, Me.وضعیتجراحیDataGridViewTextBoxColumn, Me.توضیحاتDataGridViewTextBoxColumn, Me.تاریخنهاییDataGridViewTextBoxColumn, Me.نتیجهجراحیDataGridViewTextBoxColumn})
        Me.dgv_list_surgery.DataSource = Me.SelectSurgeryBindingSource
        Me.dgv_list_surgery.Location = New System.Drawing.Point(4, 3)
        Me.dgv_list_surgery.Name = "dgv_list_surgery"
        Me.dgv_list_surgery.ReadOnly = True
        Me.dgv_list_surgery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_list_surgery.Size = New System.Drawing.Size(891, 324)
        Me.dgv_list_surgery.TabIndex = 0
        '
        'IdFileDataGridViewTextBoxColumn1
        '
        Me.IdFileDataGridViewTextBoxColumn1.DataPropertyName = "Id_File"
        Me.IdFileDataGridViewTextBoxColumn1.HeaderText = "Id_File"
        Me.IdFileDataGridViewTextBoxColumn1.Name = "IdFileDataGridViewTextBoxColumn1"
        Me.IdFileDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdFileDataGridViewTextBoxColumn1.Visible = False
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'عنوانDataGridViewTextBoxColumn
        '
        Me.عنوانDataGridViewTextBoxColumn.DataPropertyName = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.HeaderText = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.Name = "عنوانDataGridViewTextBoxColumn"
        Me.عنوانDataGridViewTextBoxColumn.ReadOnly = True
        Me.عنوانDataGridViewTextBoxColumn.Width = 200
        '
        'تاریخجراحیDataGridViewTextBoxColumn
        '
        Me.تاریخجراحیDataGridViewTextBoxColumn.DataPropertyName = "تاریخ جراحی"
        Me.تاریخجراحیDataGridViewTextBoxColumn.HeaderText = "تاریخ جراحی"
        Me.تاریخجراحیDataGridViewTextBoxColumn.Name = "تاریخجراحیDataGridViewTextBoxColumn"
        Me.تاریخجراحیDataGridViewTextBoxColumn.ReadOnly = True
        Me.تاریخجراحیDataGridViewTextBoxColumn.Width = 150
        '
        'وضعیتجراحیDataGridViewTextBoxColumn
        '
        Me.وضعیتجراحیDataGridViewTextBoxColumn.DataPropertyName = "وضعیت جراحی"
        Me.وضعیتجراحیDataGridViewTextBoxColumn.HeaderText = "وضعیت جراحی"
        Me.وضعیتجراحیDataGridViewTextBoxColumn.Name = "وضعیتجراحیDataGridViewTextBoxColumn"
        Me.وضعیتجراحیDataGridViewTextBoxColumn.ReadOnly = True
        '
        'توضیحاتDataGridViewTextBoxColumn
        '
        Me.توضیحاتDataGridViewTextBoxColumn.DataPropertyName = "توضیحات"
        Me.توضیحاتDataGridViewTextBoxColumn.HeaderText = "توضیحات"
        Me.توضیحاتDataGridViewTextBoxColumn.Name = "توضیحاتDataGridViewTextBoxColumn"
        Me.توضیحاتDataGridViewTextBoxColumn.ReadOnly = True
        Me.توضیحاتDataGridViewTextBoxColumn.Visible = False
        '
        'تاریخنهاییDataGridViewTextBoxColumn
        '
        Me.تاریخنهاییDataGridViewTextBoxColumn.DataPropertyName = "تاریخ نهایی"
        Me.تاریخنهاییDataGridViewTextBoxColumn.HeaderText = "تاریخ نهایی"
        Me.تاریخنهاییDataGridViewTextBoxColumn.Name = "تاریخنهاییDataGridViewTextBoxColumn"
        Me.تاریخنهاییDataGridViewTextBoxColumn.ReadOnly = True
        Me.تاریخنهاییDataGridViewTextBoxColumn.Width = 150
        '
        'نتیجهجراحیDataGridViewTextBoxColumn
        '
        Me.نتیجهجراحیDataGridViewTextBoxColumn.DataPropertyName = "نتیجه جراحی"
        Me.نتیجهجراحیDataGridViewTextBoxColumn.HeaderText = "نتیجه جراحی"
        Me.نتیجهجراحیDataGridViewTextBoxColumn.Name = "نتیجهجراحیDataGridViewTextBoxColumn"
        Me.نتیجهجراحیDataGridViewTextBoxColumn.ReadOnly = True
        Me.نتیجهجراحیDataGridViewTextBoxColumn.Visible = False
        '
        'SelectSurgeryBindingSource
        '
        Me.SelectSurgeryBindingSource.DataMember = "Select_Surgery"
        Me.SelectSurgeryBindingSource.DataSource = Me.Ds_Surgery
        '
        'Ds_Surgery
        '
        Me.Ds_Surgery.DataSetName = "ds_Surgery"
        Me.Ds_Surgery.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnShowInfo
        '
        Me.btnShowInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnShowInfo.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btnShowInfo.Location = New System.Drawing.Point(723, 333)
        Me.btnShowInfo.Name = "btnShowInfo"
        Me.btnShowInfo.Size = New System.Drawing.Size(170, 23)
        Me.btnShowInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.btnShowInfo.TabIndex = 5
        Me.btnShowInfo.Text = "نمایش اطلاعات جراحی"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.btn_Update_ManualFile)
        Me.TabPage6.Controls.Add(Me.Label25)
        Me.TabPage6.Controls.Add(Me.Label24)
        Me.TabPage6.Controls.Add(Me.Label23)
        Me.TabPage6.Controls.Add(Me.btn_Manual_full_2)
        Me.TabPage6.Controls.Add(Me.btn_Manual_delete_2)
        Me.TabPage6.Controls.Add(Me.btn_Manual_open_2)
        Me.TabPage6.Controls.Add(Me.pic_Manual_2)
        Me.TabPage6.Controls.Add(Me.btn_Manual_full_1)
        Me.TabPage6.Controls.Add(Me.btn_Manual_Delete_1)
        Me.TabPage6.Controls.Add(Me.btn_Manual_open_1)
        Me.TabPage6.Controls.Add(Me.pic_Manual_1)
        Me.TabPage6.Controls.Add(Me.txt_CodeManual)
        Me.TabPage6.Controls.Add(Me.Label22)
        Me.TabPage6.Controls.Add(Me.Label21)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(898, 363)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "پرونده کاغذی بیمار"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'btn_Update_ManualFile
        '
        Me.btn_Update_ManualFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Update_ManualFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Update_ManualFile.Location = New System.Drawing.Point(749, 334)
        Me.btn_Update_ManualFile.Name = "btn_Update_ManualFile"
        Me.btn_Update_ManualFile.Size = New System.Drawing.Size(131, 23)
        Me.btn_Update_ManualFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Update_ManualFile.TabIndex = 55
        Me.btn_Update_ManualFile.Text = "ذخیره سازی"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Gray
        Me.Label25.Location = New System.Drawing.Point(338, 28)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(222, 13)
        Me.Label25.TabIndex = 47
        Me.Label25.Text = "توصیه می شود تصویر پرونده اسکن شده باشد."
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(322, 139)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 13)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "تصویر پرونده (2):"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(493, 139)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 13)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "تصویر پرونده (1):"
        '
        'btn_Manual_full_2
        '
        Me.btn_Manual_full_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Manual_full_2.Image = Global.Clinic.My.Resources.Resources.fullscreen
        Me.btn_Manual_full_2.Location = New System.Drawing.Point(376, 324)
        Me.btn_Manual_full_2.Name = "btn_Manual_full_2"
        Me.btn_Manual_full_2.Size = New System.Drawing.Size(21, 20)
        Me.btn_Manual_full_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Manual_full_2.TabIndex = 44
        Me.btn_Manual_full_2.TabStop = False
        '
        'btn_Manual_delete_2
        '
        Me.btn_Manual_delete_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Manual_delete_2.Image = Global.Clinic.My.Resources.Resources.delete
        Me.btn_Manual_delete_2.Location = New System.Drawing.Point(349, 324)
        Me.btn_Manual_delete_2.Name = "btn_Manual_delete_2"
        Me.btn_Manual_delete_2.Size = New System.Drawing.Size(21, 20)
        Me.btn_Manual_delete_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Manual_delete_2.TabIndex = 43
        Me.btn_Manual_delete_2.TabStop = False
        '
        'btn_Manual_open_2
        '
        Me.btn_Manual_open_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Manual_open_2.Image = Global.Clinic.My.Resources.Resources.open
        Me.btn_Manual_open_2.Location = New System.Drawing.Point(322, 324)
        Me.btn_Manual_open_2.Name = "btn_Manual_open_2"
        Me.btn_Manual_open_2.Size = New System.Drawing.Size(21, 20)
        Me.btn_Manual_open_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Manual_open_2.TabIndex = 42
        Me.btn_Manual_open_2.TabStop = False
        '
        'pic_Manual_2
        '
        Me.pic_Manual_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Manual_2.Location = New System.Drawing.Point(296, 160)
        Me.pic_Manual_2.Name = "pic_Manual_2"
        Me.pic_Manual_2.Size = New System.Drawing.Size(134, 158)
        Me.pic_Manual_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Manual_2.TabIndex = 41
        Me.pic_Manual_2.TabStop = False
        '
        'btn_Manual_full_1
        '
        Me.btn_Manual_full_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Manual_full_1.Image = Global.Clinic.My.Resources.Resources.fullscreen
        Me.btn_Manual_full_1.Location = New System.Drawing.Point(549, 324)
        Me.btn_Manual_full_1.Name = "btn_Manual_full_1"
        Me.btn_Manual_full_1.Size = New System.Drawing.Size(21, 20)
        Me.btn_Manual_full_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Manual_full_1.TabIndex = 40
        Me.btn_Manual_full_1.TabStop = False
        '
        'btn_Manual_Delete_1
        '
        Me.btn_Manual_Delete_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Manual_Delete_1.Image = Global.Clinic.My.Resources.Resources.delete
        Me.btn_Manual_Delete_1.Location = New System.Drawing.Point(522, 324)
        Me.btn_Manual_Delete_1.Name = "btn_Manual_Delete_1"
        Me.btn_Manual_Delete_1.Size = New System.Drawing.Size(21, 20)
        Me.btn_Manual_Delete_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Manual_Delete_1.TabIndex = 39
        Me.btn_Manual_Delete_1.TabStop = False
        '
        'btn_Manual_open_1
        '
        Me.btn_Manual_open_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Manual_open_1.Image = Global.Clinic.My.Resources.Resources.open
        Me.btn_Manual_open_1.Location = New System.Drawing.Point(495, 324)
        Me.btn_Manual_open_1.Name = "btn_Manual_open_1"
        Me.btn_Manual_open_1.Size = New System.Drawing.Size(21, 20)
        Me.btn_Manual_open_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Manual_open_1.TabIndex = 38
        Me.btn_Manual_open_1.TabStop = False
        '
        'pic_Manual_1
        '
        Me.pic_Manual_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Manual_1.Location = New System.Drawing.Point(469, 160)
        Me.pic_Manual_1.Name = "pic_Manual_1"
        Me.pic_Manual_1.Size = New System.Drawing.Size(134, 158)
        Me.pic_Manual_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Manual_1.TabIndex = 37
        Me.pic_Manual_1.TabStop = False
        '
        'txt_CodeManual
        '
        Me.txt_CodeManual.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_CodeManual.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_CodeManual.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_CodeManual.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_CodeManual.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_CodeManual.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_CodeManual.__NextFocuse = False
        Me.txt_CodeManual.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.No
        Me.txt_CodeManual.__Type = TextualControl.TextualControl.No.Numeric
        Me.txt_CodeManual.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_CodeManual.Location = New System.Drawing.Point(331, 81)
        Me.txt_CodeManual.Name = "txt_CodeManual"
        Me.txt_CodeManual.Size = New System.Drawing.Size(230, 52)
        Me.txt_CodeManual.TabIndex = 2
        Me.txt_CodeManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(378, 58)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(151, 13)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "شماره پرونده درج شده در کاغذ:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Gray
        Me.Label21.Location = New System.Drawing.Point(53, 12)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(793, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "این قسمت بدین منظور طراحی شده است که اگر پرونده کاغذی برای این بیمار از قبل وجود " & _
            "دارد، بصورت سیستمی درج شود  تا در پیدا کردن آن پرونده با مشکلی مواجه نشوید."
        '
        'btn_Cancel
        '
        Me.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Cancel.Location = New System.Drawing.Point(832, 401)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Cancel.TabIndex = 4
        Me.btn_Cancel.Text = "خروج"
        '
        'Select_RecordTitleForFileTableAdapter
        '
        Me.Select_RecordTitleForFileTableAdapter.ClearBeforeFill = True
        '
        'Select_RecordForFileTableAdapter
        '
        Me.Select_RecordForFileTableAdapter.ClearBeforeFill = True
        '
        'Select_SurgeryTableAdapter
        '
        Me.Select_SurgeryTableAdapter.ClearBeforeFill = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Select_Surgery"
        Me.BindingSource1.DataSource = Me.Ds_Surgery1
        '
        'Ds_Surgery1
        '
        Me.Ds_Surgery1.DataSetName = "ds_Surgery"
        Me.Ds_Surgery1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Select_SurgeryTableAdapter1
        '
        Me.Select_SurgeryTableAdapter1.ClearBeforeFill = True
        '
        'Select_PhotoBankTableAdapter
        '
        Me.Select_PhotoBankTableAdapter.ClearBeforeFill = True
        '
        'Select_prescription_FileTableAdapter
        '
        Me.Select_prescription_FileTableAdapter.ClearBeforeFill = True
        '
        'SelectGroupSickfordoctorBindingSource
        '
        Me.SelectGroupSickfordoctorBindingSource.DataMember = "Select_GroupSick_for_doctor"
        Me.SelectGroupSickfordoctorBindingSource.DataSource = Me.Ds_GroupSick
        '
        'Ds_GroupSick
        '
        Me.Ds_GroupSick.DataSetName = "ds_GroupSick"
        Me.Ds_GroupSick.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Select_GroupSick_for_doctorTableAdapter
        '
        Me.Select_GroupSick_for_doctorTableAdapter.ClearBeforeFill = True
        '
        'SelectdoctorforGroupSickBindingSource
        '
        Me.SelectdoctorforGroupSickBindingSource.DataMember = "Select_doctor_for_GroupSick"
        Me.SelectdoctorforGroupSickBindingSource.DataSource = Me.Ds_Personal
        '
        'Ds_Personal
        '
        Me.Ds_Personal.DataSetName = "ds_Personal"
        Me.Ds_Personal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Select_doctor_for_GroupSickTableAdapter
        '
        Me.Select_doctor_for_GroupSickTableAdapter.ClearBeforeFill = True
        '
        'frm_Edit_File
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 436)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_Edit_File"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تکمیل پرونده بیماران"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btn_webcam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_FullScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Open, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_RecordForTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectRecordForFileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_RecordTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SelectRecordTitleForFileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgv_BankPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectPhotoBankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_PhotoBank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.Dgv_Prescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectprescriptionFileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_prescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.dgv_list_surgery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectSurgeryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Surgery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.btn_Manual_full_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Manual_delete_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Manual_open_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Manual_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Manual_full_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Manual_Delete_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Manual_open_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Manual_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Surgery1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectGroupSickfordoctorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_GroupSick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cmb_doctors As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rb_divorced As System.Windows.Forms.RadioButton
    Friend WithEvents rb_marriage As System.Windows.Forms.RadioButton
    Friend WithEvents rb_single As System.Windows.Forms.RadioButton
    Friend WithEvents btn_webcam As System.Windows.Forms.PictureBox
    Friend WithEvents txt_dateBirth As HM_FarsiCalendar.HM_FarsiCalendar
    Friend WithEvents txt_presenter As TextualControl.TextualControl
    Friend WithEvents txt_wieght As TextualControl.TextualControl
    Friend WithEvents txt_height As TextualControl.TextualControl
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rb_famale As System.Windows.Forms.RadioButton
    Friend WithEvents rb_male As System.Windows.Forms.RadioButton
    Friend WithEvents cmb_blood As System.Windows.Forms.ComboBox
    Friend WithEvents btn_FullScreen As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Delete As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Open As System.Windows.Forms.PictureBox
    Friend WithEvents cmb_groupSick As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_DateRegister As TextualControl.TextualControl
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_job As TextualControl.TextualControl
    Friend WithEvents txt_email As TextualControl.TextualControl
    Friend WithEvents txt_mobile As TextualControl.TextualControl
    Friend WithEvents txt_phone As TextualControl.TextualControl
    Friend WithEvents txt_detail As TextualControl.TextualControl
    Friend WithEvents txt_address As TextualControl.TextualControl
    Friend WithEvents txt_l_name As TextualControl.TextualControl
    Friend WithEvents txt_f_name As TextualControl.TextualControl
    Friend WithEvents txt_Code As TextualControl.TextualControl
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Update_OriginalInfo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents btn_Cancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents txt_CodeManual As TextualControl.TextualControl
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btn_Manual_full_2 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Manual_delete_2 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Manual_open_2 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_Manual_2 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Manual_full_1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Manual_Delete_1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Manual_open_1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_Manual_1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents btn_Update_ManualFile As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_RecordForTitle As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lst_Records As System.Windows.Forms.ListBox
    Friend WithEvents lbl_Record_Doctor As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents btn_InsertRecord As System.Windows.Forms.Button
    Friend WithEvents SelectRecordTitleForFileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_RecordTitle As Clinic.ds_RecordTitle
    Friend WithEvents Select_RecordTitleForFileTableAdapter As Clinic.ds_RecordTitleTableAdapters.Select_RecordTitleForFileTableAdapter
    Friend WithEvents SelectRecordForFileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Select_RecordForFileTableAdapter As Clinic.ds_RecordTitleTableAdapters.Select_RecordForFileTableAdapter
    Friend WithEvents IdRecordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdFileDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetailsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents delete As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents dgv_list_surgery As System.Windows.Forms.DataGridView
    Friend WithEvents SelectSurgeryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Surgery As Clinic.ds_Surgery
    Friend WithEvents Select_SurgeryTableAdapter As Clinic.ds_SurgeryTableAdapters.Select_SurgeryTableAdapter
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Surgery1 As Clinic.ds_Surgery
    Friend WithEvents Select_SurgeryTableAdapter1 As Clinic.ds_SurgeryTableAdapters.Select_SurgeryTableAdapter
    Friend WithEvents IdFileDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents عنوانDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخجراحیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents وضعیتجراحیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents توضیحاتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخنهاییDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نتیجهجراحیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnShowInfo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgv_BankPhoto As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDFileDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhotoDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SelectPhotoBankBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_PhotoBank As Clinic.ds_PhotoBank
    Friend WithEvents Select_PhotoBankTableAdapter As Clinic.ds_PhotoBankTableAdapters.Select_PhotoBankTableAdapter
    Friend WithEvents btn_showPhotoBank As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Dgv_Prescription As System.Windows.Forms.DataGridView
    Friend WithEvents SelectprescriptionFileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_prescription As Clinic.ds_prescription
    Friend WithEvents Select_prescription_FileTableAdapter As Clinic.ds_prescriptionTableAdapters.Select_prescription_FileTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdReceptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPersonalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LightPenDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents MedicationReviewDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetailDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaientDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatePrescripptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPeriodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SelectGroupSickfordoctorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_GroupSick As Clinic.ds_GroupSick
    Friend WithEvents Select_GroupSick_for_doctorTableAdapter As Clinic.ds_GroupSickTableAdapters.Select_GroupSick_for_doctorTableAdapter
    Friend WithEvents SelectdoctorforGroupSickBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Personal As Clinic.ds_Personal
    Friend WithEvents Select_doctor_for_GroupSickTableAdapter As Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter
End Class
