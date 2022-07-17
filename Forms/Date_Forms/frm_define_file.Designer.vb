<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_define_file
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmb_doctors = New System.Windows.Forms.ComboBox()
        Me.SelectdoctorforGroupSickBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Personal = New Clinic.ds_Personal()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rb_divorced = New System.Windows.Forms.RadioButton()
        Me.rb_marriage = New System.Windows.Forms.RadioButton()
        Me.rb_single = New System.Windows.Forms.RadioButton()
        Me.btn_webcam = New System.Windows.Forms.PictureBox()
        Me.txt_dateBirth = New HM_FarsiCalendar.HM_FarsiCalendar()
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
        Me.SelectGroupSickfordoctorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_GroupSick = New Clinic.ds_GroupSick()
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
        Me.btn_Insert = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Cancel = New DevComponents.DotNetBar.ButtonX()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Select_GroupSick_for_doctorTableAdapter = New Clinic.ds_GroupSickTableAdapters.Select_GroupSick_for_doctorTableAdapter()
        Me.Select_doctor_for_GroupSickTableAdapter = New Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter()
        Me.btn_CreateNewFile = New DevComponents.DotNetBar.ButtonX()
        Me.txt_weight_ = New System.Windows.Forms.NumericUpDown()
        Me.txt_height = New System.Windows.Forms.NumericUpDown()
        Me.txt_presenter = New TextualControl.TextualControl()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btn_webcam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_FullScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Open, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectGroupSickfordoctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_GroupSick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_weight_, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_height, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(906, 355)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_weight_)
        Me.TabPage1.Controls.Add(Me.txt_height)
        Me.TabPage1.Controls.Add(Me.cmb_doctors)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.btn_webcam)
        Me.TabPage1.Controls.Add(Me.txt_dateBirth)
        Me.TabPage1.Controls.Add(Me.txt_presenter)
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
        Me.TabPage1.Size = New System.Drawing.Size(898, 329)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "تکمیل اطلاعات"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        Me.ToolTip1.SetToolTip(Me.btn_webcam, "عکس گرفتن با دوربین")
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
        Me.ToolTip1.SetToolTip(Me.btn_FullScreen, "تصویر بزرگ")
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
        Me.ToolTip1.SetToolTip(Me.btn_Delete, "حذف تصویر")
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
        Me.ToolTip1.SetToolTip(Me.btn_Open, "انتخاب از فایل سیستم")
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
        Me.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.txt_detail.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban_Characters
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
        Me.txt_address.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban_Characters
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
        'btn_Insert
        '
        Me.btn_Insert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Insert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Insert.Location = New System.Drawing.Point(4, 369)
        Me.btn_Insert.Name = "btn_Insert"
        Me.btn_Insert.Size = New System.Drawing.Size(131, 23)
        Me.btn_Insert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Insert.TabIndex = 1
        Me.btn_Insert.Text = "ذخیره سازی"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Cancel.Location = New System.Drawing.Point(831, 369)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Cancel.TabIndex = 2
        Me.btn_Cancel.Text = "خروج"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 10
        Me.ToolTip1.ReshowDelay = 100
        '
        'Select_GroupSick_for_doctorTableAdapter
        '
        Me.Select_GroupSick_for_doctorTableAdapter.ClearBeforeFill = True
        '
        'Select_doctor_for_GroupSickTableAdapter
        '
        Me.Select_doctor_for_GroupSickTableAdapter.ClearBeforeFill = True
        '
        'btn_CreateNewFile
        '
        Me.btn_CreateNewFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_CreateNewFile.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btn_CreateNewFile.Location = New System.Drawing.Point(147, 369)
        Me.btn_CreateNewFile.Name = "btn_CreateNewFile"
        Me.btn_CreateNewFile.Size = New System.Drawing.Size(267, 23)
        Me.btn_CreateNewFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_CreateNewFile.TabIndex = 3
        Me.btn_CreateNewFile.Text = "تشکیل پرونده تکراری برای پزشک جدید"
        '
        'txt_weight_
        '
        Me.txt_weight_.Location = New System.Drawing.Point(295, 74)
        Me.txt_weight_.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.txt_weight_.Minimum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.txt_weight_.Name = "txt_weight_"
        Me.txt_weight_.Size = New System.Drawing.Size(52, 21)
        Me.txt_weight_.TabIndex = 56
        Me.txt_weight_.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'txt_height
        '
        Me.txt_height.Location = New System.Drawing.Point(295, 46)
        Me.txt_height.Maximum = New Decimal(New Integer() {280, 0, 0, 0})
        Me.txt_height.Minimum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.txt_height.Name = "txt_height"
        Me.txt_height.Size = New System.Drawing.Size(52, 21)
        Me.txt_height.TabIndex = 55
        Me.txt_height.Value = New Decimal(New Integer() {20, 0, 0, 0})
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
        'frm_define_file
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 404)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_CreateNewFile)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Insert)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_define_file"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بیمار جدید"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.SelectGroupSickfordoctorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_GroupSick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_weight_, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_height, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
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
    Friend WithEvents btn_Insert As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Cancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmb_groupSick As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btn_FullScreen As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Delete As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Open As System.Windows.Forms.PictureBox
    Friend WithEvents cmb_blood As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rb_famale As System.Windows.Forms.RadioButton
    Friend WithEvents rb_male As System.Windows.Forms.RadioButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_dateBirth As HM_FarsiCalendar.HM_FarsiCalendar
    Friend WithEvents btn_webcam As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rb_divorced As System.Windows.Forms.RadioButton
    Friend WithEvents rb_marriage As System.Windows.Forms.RadioButton
    Friend WithEvents rb_single As System.Windows.Forms.RadioButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents cmb_doctors As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents SelectGroupSickfordoctorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_GroupSick As Clinic.ds_GroupSick
    Friend WithEvents Select_GroupSick_for_doctorTableAdapter As Clinic.ds_GroupSickTableAdapters.Select_GroupSick_for_doctorTableAdapter
    Friend WithEvents Ds_Personal As Clinic.ds_Personal
    Friend WithEvents SelectdoctorforGroupSickBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Select_doctor_for_GroupSickTableAdapter As Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter
    Friend WithEvents btn_CreateNewFile As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_weight_ As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_height As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_presenter As TextualControl.TextualControl
End Class
