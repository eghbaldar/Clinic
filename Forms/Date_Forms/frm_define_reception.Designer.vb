<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_define_reception
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_doctor = New System.Windows.Forms.ComboBox()
        Me.SelectdoctorforGroupSickBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Personal = New Clinic.ds_Personal()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_Period = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Select_doctor_for_GroupSickTableAdapter = New Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.gp_attribiute = New System.Windows.Forms.GroupBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.dgv_attribiutes = New System.Windows.Forms.DataGridView()
        Me.gp_reception = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmb_insurance_1 = New System.Windows.Forms.ComboBox()
        Me.SelectinsuranceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_insurance = New Clinic.ds_insurance()
        Me.txt_Expire = New System.Windows.Forms.MaskedTextBox()
        Me.txt_NumberCard = New TextualControl.TextualControl()
        Me.txt_detail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_Serial = New TextualControl.TextualControl()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chk_free = New System.Windows.Forms.CheckBox()
        Me.cmb_insurance = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_receievd = New TextualControl.TextualControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Payable = New TextualControl.TextualControl()
        Me.txt_Discount = New TextualControl.TextualControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_TotalPay = New TextualControl.TextualControl()
        Me.btnInsert = New DevComponents.DotNetBar.ButtonX()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Select_insuranceTableAdapter = New Clinic.ds_insuranceTableAdapters.Select_insuranceTableAdapter()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Period, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gp_attribiute.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_attribiutes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gp_reception.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.SelectinsuranceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_insurance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_doctor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dgv_Period)
        Me.GroupBox1.Location = New System.Drawing.Point(307, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 673)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "نوبت های امروز"
        '
        'cmb_doctor
        '
        Me.cmb_doctor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_doctor.DataSource = Me.SelectdoctorforGroupSickBindingSource
        Me.cmb_doctor.DisplayMember = "Doctor_Name"
        Me.cmb_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_doctor.FormattingEnabled = True
        Me.cmb_doctor.Location = New System.Drawing.Point(144, 24)
        Me.cmb_doctor.Name = "cmb_doctor"
        Me.cmb_doctor.Size = New System.Drawing.Size(243, 21)
        Me.cmb_doctor.TabIndex = 13
        Me.cmb_doctor.ValueMember = "id"
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
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(393, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "پرشک معالج:"
        '
        'dgv_Period
        '
        Me.dgv_Period.AllowUserToAddRows = False
        Me.dgv_Period.AllowUserToDeleteRows = False
        Me.dgv_Period.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Period.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Period.EnableHeadersVisualStyles = False
        Me.dgv_Period.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgv_Period.Location = New System.Drawing.Point(6, 54)
        Me.dgv_Period.MultiSelect = False
        Me.dgv_Period.Name = "dgv_Period"
        Me.dgv_Period.ReadOnly = True
        Me.dgv_Period.RowHeadersVisible = False
        Me.dgv_Period.Size = New System.Drawing.Size(454, 613)
        Me.dgv_Period.TabIndex = 0
        '
        'Select_doctor_for_GroupSickTableAdapter
        '
        Me.Select_doctor_for_GroupSickTableAdapter.ClearBeforeFill = True
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Location = New System.Drawing.Point(5, 654)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "خروج"
        '
        'gp_attribiute
        '
        Me.gp_attribiute.Controls.Add(Me.PictureBox)
        Me.gp_attribiute.Controls.Add(Me.dgv_attribiutes)
        Me.gp_attribiute.Enabled = False
        Me.gp_attribiute.Location = New System.Drawing.Point(5, 4)
        Me.gp_attribiute.Name = "gp_attribiute"
        Me.gp_attribiute.Size = New System.Drawing.Size(296, 119)
        Me.gp_attribiute.TabIndex = 3
        Me.gp_attribiute.TabStop = False
        Me.gp_attribiute.Text = "مشخصات بیمار"
        '
        'PictureBox
        '
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox.Location = New System.Drawing.Point(214, 20)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(76, 88)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 8
        Me.PictureBox.TabStop = False
        '
        'dgv_attribiutes
        '
        Me.dgv_attribiutes.BackgroundColor = System.Drawing.Color.White
        Me.dgv_attribiutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_attribiutes.ColumnHeadersVisible = False
        Me.dgv_attribiutes.Location = New System.Drawing.Point(6, 20)
        Me.dgv_attribiutes.Name = "dgv_attribiutes"
        Me.dgv_attribiutes.RowHeadersVisible = False
        Me.dgv_attribiutes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_attribiutes.Size = New System.Drawing.Size(202, 88)
        Me.dgv_attribiutes.TabIndex = 9
        '
        'gp_reception
        '
        Me.gp_reception.Controls.Add(Me.GroupBox5)
        Me.gp_reception.Controls.Add(Me.GroupBox6)
        Me.gp_reception.Enabled = False
        Me.gp_reception.Location = New System.Drawing.Point(4, 126)
        Me.gp_reception.Name = "gp_reception"
        Me.gp_reception.Size = New System.Drawing.Size(297, 522)
        Me.gp_reception.TabIndex = 4
        Me.gp_reception.TabStop = False
        Me.gp_reception.Text = "ثبت پذیرش"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmb_insurance_1)
        Me.GroupBox5.Controls.Add(Me.txt_Expire)
        Me.GroupBox5.Controls.Add(Me.txt_NumberCard)
        Me.GroupBox5.Controls.Add(Me.txt_detail)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.txt_Serial)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 229)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(283, 287)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "اختیاری"
        '
        'cmb_insurance_1
        '
        Me.cmb_insurance_1.DataSource = Me.SelectinsuranceBindingSource
        Me.cmb_insurance_1.DisplayMember = "Name"
        Me.cmb_insurance_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_insurance_1.FormattingEnabled = True
        Me.cmb_insurance_1.Location = New System.Drawing.Point(10, 114)
        Me.cmb_insurance_1.Name = "cmb_insurance_1"
        Me.cmb_insurance_1.Size = New System.Drawing.Size(143, 21)
        Me.cmb_insurance_1.TabIndex = 25
        Me.cmb_insurance_1.ValueMember = "Id"
        Me.cmb_insurance_1.Visible = False
        '
        'SelectinsuranceBindingSource
        '
        Me.SelectinsuranceBindingSource.DataMember = "Select_insurance"
        Me.SelectinsuranceBindingSource.DataSource = Me.Ds_insurance
        '
        'Ds_insurance
        '
        Me.Ds_insurance.DataSetName = "ds_insurance"
        Me.Ds_insurance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_Expire
        '
        Me.txt_Expire.Location = New System.Drawing.Point(9, 54)
        Me.txt_Expire.Mask = "0000/00/00"
        Me.txt_Expire.Name = "txt_Expire"
        Me.txt_Expire.Size = New System.Drawing.Size(144, 21)
        Me.txt_Expire.TabIndex = 24
        '
        'txt_NumberCard
        '
        Me.txt_NumberCard.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_NumberCard.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_NumberCard.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_NumberCard.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_NumberCard.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_NumberCard.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_NumberCard.__NextFocuse = True
        Me.txt_NumberCard.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_NumberCard.__Type = TextualControl.TextualControl.No.Numeric
        Me.txt_NumberCard.Location = New System.Drawing.Point(9, 87)
        Me.txt_NumberCard.Name = "txt_NumberCard"
        Me.txt_NumberCard.Size = New System.Drawing.Size(144, 21)
        Me.txt_NumberCard.TabIndex = 23
        '
        'txt_detail
        '
        Me.txt_detail.Location = New System.Drawing.Point(15, 145)
        Me.txt_detail.Multiline = True
        Me.txt_detail.Name = "txt_detail"
        Me.txt_detail.Size = New System.Drawing.Size(256, 136)
        Me.txt_detail.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(223, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "توضیحات:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(170, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "تاریخ انقضای دفترچه:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(202, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "شماره صفحه:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(166, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "سریال شماره دفترچه:"
        '
        'txt_Serial
        '
        Me.txt_Serial.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_Serial.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Serial.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Serial.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_Serial.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_Serial.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_Serial.__NextFocuse = True
        Me.txt_Serial.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_Serial.__Type = TextualControl.TextualControl.No.Numeric
        Me.txt_Serial.Location = New System.Drawing.Point(9, 20)
        Me.txt_Serial.Name = "txt_Serial"
        Me.txt_Serial.Size = New System.Drawing.Size(144, 21)
        Me.txt_Serial.TabIndex = 16
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.chk_free)
        Me.GroupBox6.Controls.Add(Me.cmb_insurance)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.txt_receievd)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.txt_Payable)
        Me.GroupBox6.Controls.Add(Me.txt_Discount)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.txt_TotalPay)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 20)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(283, 203)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "اجباری"
        '
        'chk_free
        '
        Me.chk_free.AutoSize = True
        Me.chk_free.Location = New System.Drawing.Point(111, 82)
        Me.chk_free.Name = "chk_free"
        Me.chk_free.Size = New System.Drawing.Size(41, 17)
        Me.chk_free.TabIndex = 18
        Me.chk_free.Text = "آزاد"
        Me.chk_free.UseVisualStyleBackColor = True
        '
        'cmb_insurance
        '
        Me.cmb_insurance.DataSource = Me.SelectinsuranceBindingSource
        Me.cmb_insurance.DisplayMember = "Name"
        Me.cmb_insurance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_insurance.FormattingEnabled = True
        Me.cmb_insurance.Location = New System.Drawing.Point(9, 49)
        Me.cmb_insurance.Name = "cmb_insurance"
        Me.cmb_insurance.Size = New System.Drawing.Size(143, 21)
        Me.cmb_insurance.TabIndex = 17
        Me.cmb_insurance.ValueMember = "Percentage"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(246, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "بیمه:"
        '
        'txt_receievd
        '
        Me.txt_receievd.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_receievd.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_receievd.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_receievd.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_receievd.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_receievd.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_receievd.__NextFocuse = True
        Me.txt_receievd.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_receievd.__Type = TextualControl.TextualControl.No.Numeric
        Me.txt_receievd.Location = New System.Drawing.Point(9, 171)
        Me.txt_receievd.Name = "txt_receievd"
        Me.txt_receievd.Size = New System.Drawing.Size(143, 21)
        Me.txt_receievd.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(208, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "مبلغ دریافتی:"
        '
        'txt_Payable
        '
        Me.txt_Payable.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_Payable.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Payable.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Payable.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_Payable.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_Payable.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_Payable.__NextFocuse = True
        Me.txt_Payable.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_Payable.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_Payable.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Payable.Location = New System.Drawing.Point(9, 141)
        Me.txt_Payable.Name = "txt_Payable"
        Me.txt_Payable.ReadOnly = True
        Me.txt_Payable.Size = New System.Drawing.Size(143, 21)
        Me.txt_Payable.TabIndex = 13
        '
        'txt_Discount
        '
        Me.txt_Discount.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_Discount.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Discount.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Discount.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Discount.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_Discount.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_Discount.__NextFocuse = True
        Me.txt_Discount.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_Discount.__Type = TextualControl.TextualControl.No.Numeric
        Me.txt_Discount.Location = New System.Drawing.Point(9, 110)
        Me.txt_Discount.Name = "txt_Discount"
        Me.txt_Discount.Size = New System.Drawing.Size(143, 21)
        Me.txt_Discount.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(236, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "تخفیف:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "مبلغ قابل پرداخت:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "تعرفه:"
        '
        'txt_TotalPay
        '
        Me.txt_TotalPay.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_TotalPay.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_TotalPay.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_TotalPay.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_TotalPay.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_TotalPay.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_TotalPay.__NextFocuse = True
        Me.txt_TotalPay.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_TotalPay.__Type = TextualControl.TextualControl.No.Numeric
        Me.txt_TotalPay.Location = New System.Drawing.Point(9, 20)
        Me.txt_TotalPay.Name = "txt_TotalPay"
        Me.txt_TotalPay.Size = New System.Drawing.Size(143, 21)
        Me.txt_TotalPay.TabIndex = 8
        '
        'btnInsert
        '
        Me.btnInsert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnInsert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnInsert.Location = New System.Drawing.Point(177, 654)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(118, 23)
        Me.btnInsert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnInsert.TabIndex = 5
        Me.btnInsert.Text = "ذخیره سازی"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(86, 654)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "پذیرش شدگان"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Select_insuranceTableAdapter
        '
        Me.Select_insuranceTableAdapter.ClearBeforeFill = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(158, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 10)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "(تومان)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(158, 118)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 10)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "(تومان)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(158, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 10)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "(تومان)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(158, 177)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 10)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "(تومان)"
        '
        'frm_define_reception
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 680)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.gp_reception)
        Me.Controls.Add(Me.gp_attribiute)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_define_reception"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ثبت پذیرش"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Period, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gp_attribiute.ResumeLayout(False)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_attribiutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gp_reception.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.SelectinsuranceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_insurance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_Period As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cmb_doctor As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SelectdoctorforGroupSickBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Personal As Clinic.ds_Personal
    Friend WithEvents Select_doctor_for_GroupSickTableAdapter As Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gp_attribiute As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents dgv_attribiutes As System.Windows.Forms.DataGridView
    Friend WithEvents gp_reception As System.Windows.Forms.GroupBox
    Friend WithEvents btnInsert As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_NumberCard As TextualControl.TextualControl
    Friend WithEvents txt_detail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_Serial As TextualControl.TextualControl
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_receievd As TextualControl.TextualControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Payable As TextualControl.TextualControl
    Friend WithEvents txt_Discount As TextualControl.TextualControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_TotalPay As TextualControl.TextualControl
    Friend WithEvents txt_Expire As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_insurance As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Ds_insurance As Clinic.ds_insurance
    Friend WithEvents SelectinsuranceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Select_insuranceTableAdapter As Clinic.ds_insuranceTableAdapters.Select_insuranceTableAdapter
    Friend WithEvents cmb_insurance_1 As System.Windows.Forms.ComboBox
    Friend WithEvents chk_free As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
