<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Search_File_Advance
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt__date = New System.Windows.Forms.MaskedTextBox()
        Me.txt_Birth = New System.Windows.Forms.MaskedTextBox()
        Me.rb_sex_all = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rb_all_marriage = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rb_single = New System.Windows.Forms.RadioButton()
        Me.rb_marriage = New System.Windows.Forms.RadioButton()
        Me.rb_divorced = New System.Windows.Forms.RadioButton()
        Me.txt_presenter = New TextualControl.TextualControl()
        Me.txt_job = New TextualControl.TextualControl()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rb_famale = New System.Windows.Forms.RadioButton()
        Me.rb_male = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_doctors = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_Blood = New System.Windows.Forms.ComboBox()
        Me.cmb_group = New System.Windows.Forms.ComboBox()
        Me.txt_mobile = New TextualControl.TextualControl()
        Me.txt_Lname = New TextualControl.TextualControl()
        Me.txt_Fname = New TextualControl.TextualControl()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.btn_Close = New DevComponents.DotNetBar.ButtonX()
        Me.chk_showAvatar = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_searchedFiles = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btn_returnValue = New DevComponents.DotNetBar.ButtonX()
        Me.btnUpdateGrid = New System.Windows.Forms.Button()
        Me.txt_height = New TextualControl.TextualControl()
        Me.txt_weight = New TextualControl.TextualControl()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_weight)
        Me.GroupBox1.Controls.Add(Me.txt_height)
        Me.GroupBox1.Controls.Add(Me.txt__date)
        Me.GroupBox1.Controls.Add(Me.txt_Birth)
        Me.GroupBox1.Controls.Add(Me.rb_sex_all)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.txt_presenter)
        Me.GroupBox1.Controls.Add(Me.txt_job)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.rb_famale)
        Me.GroupBox1.Controls.Add(Me.rb_male)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmb_doctors)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmb_Blood)
        Me.GroupBox1.Controls.Add(Me.cmb_group)
        Me.GroupBox1.Controls.Add(Me.txt_mobile)
        Me.GroupBox1.Controls.Add(Me.txt_Lname)
        Me.GroupBox1.Controls.Add(Me.txt_Fname)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(906, 134)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "فیلتر گذاری"
        '
        'txt__date
        '
        Me.txt__date.Location = New System.Drawing.Point(13, 103)
        Me.txt__date.Mask = "00/00/0000"
        Me.txt__date.Name = "txt__date"
        Me.txt__date.Size = New System.Drawing.Size(123, 21)
        Me.txt__date.TabIndex = 32
        Me.txt__date.ValidatingType = GetType(Date)
        Me.txt__date.Visible = False
        '
        'txt_Birth
        '
        Me.txt_Birth.Location = New System.Drawing.Point(267, 19)
        Me.txt_Birth.Mask = "0000/00/00"
        Me.txt_Birth.Name = "txt_Birth"
        Me.txt_Birth.Size = New System.Drawing.Size(143, 21)
        Me.txt_Birth.TabIndex = 31
        '
        'rb_sex_all
        '
        Me.rb_sex_all.AutoSize = True
        Me.rb_sex_all.Location = New System.Drawing.Point(476, 49)
        Me.rb_sex_all.Name = "rb_sex_all"
        Me.rb_sex_all.Size = New System.Drawing.Size(46, 17)
        Me.rb_sex_all.TabIndex = 30
        Me.rb_sex_all.TabStop = True
        Me.rb_sex_all.Text = "همه"
        Me.rb_sex_all.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rb_all_marriage)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.rb_single)
        Me.Panel1.Controls.Add(Me.rb_marriage)
        Me.Panel1.Controls.Add(Me.rb_divorced)
        Me.Panel1.Location = New System.Drawing.Point(577, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 23)
        Me.Panel1.TabIndex = 29
        '
        'rb_all_marriage
        '
        Me.rb_all_marriage.AutoSize = True
        Me.rb_all_marriage.Location = New System.Drawing.Point(27, 3)
        Me.rb_all_marriage.Name = "rb_all_marriage"
        Me.rb_all_marriage.Size = New System.Drawing.Size(46, 17)
        Me.rb_all_marriage.TabIndex = 20
        Me.rb_all_marriage.TabStop = True
        Me.rb_all_marriage.Text = "همه"
        Me.rb_all_marriage.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(255, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "وضعیت تاهل:"
        '
        'rb_single
        '
        Me.rb_single.AutoSize = True
        Me.rb_single.Location = New System.Drawing.Point(201, 4)
        Me.rb_single.Name = "rb_single"
        Me.rb_single.Size = New System.Drawing.Size(48, 17)
        Me.rb_single.TabIndex = 3
        Me.rb_single.TabStop = True
        Me.rb_single.Text = "مجرد"
        Me.rb_single.UseVisualStyleBackColor = True
        '
        'rb_marriage
        '
        Me.rb_marriage.AutoSize = True
        Me.rb_marriage.Location = New System.Drawing.Point(141, 3)
        Me.rb_marriage.Name = "rb_marriage"
        Me.rb_marriage.Size = New System.Drawing.Size(54, 17)
        Me.rb_marriage.TabIndex = 19
        Me.rb_marriage.TabStop = True
        Me.rb_marriage.Text = "متاهل"
        Me.rb_marriage.UseVisualStyleBackColor = True
        '
        'rb_divorced
        '
        Me.rb_divorced.AutoSize = True
        Me.rb_divorced.Location = New System.Drawing.Point(78, 3)
        Me.rb_divorced.Name = "rb_divorced"
        Me.rb_divorced.Size = New System.Drawing.Size(61, 17)
        Me.rb_divorced.TabIndex = 4
        Me.rb_divorced.TabStop = True
        Me.rb_divorced.Text = "مطعلقه"
        Me.rb_divorced.UseVisualStyleBackColor = True
        '
        'txt_presenter
        '
        Me.txt_presenter.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_presenter.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_presenter.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_presenter.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_presenter.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_presenter.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_presenter.__NextFocuse = True
        Me.txt_presenter.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_presenter.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_presenter.Location = New System.Drawing.Point(267, 101)
        Me.txt_presenter.Name = "txt_presenter"
        Me.txt_presenter.Size = New System.Drawing.Size(143, 21)
        Me.txt_presenter.TabIndex = 28
        '
        'txt_job
        '
        Me.txt_job.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_job.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_job.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_job.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_job.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_job.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_job.__NextFocuse = True
        Me.txt_job.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_job.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_job.Location = New System.Drawing.Point(506, 70)
        Me.txt_job.Name = "txt_job"
        Me.txt_job.Size = New System.Drawing.Size(126, 21)
        Me.txt_job.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(415, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "معرف:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(638, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "شغل:"
        '
        'rb_famale
        '
        Me.rb_famale.AutoSize = True
        Me.rb_famale.Location = New System.Drawing.Point(541, 49)
        Me.rb_famale.Name = "rb_famale"
        Me.rb_famale.Size = New System.Drawing.Size(36, 17)
        Me.rb_famale.TabIndex = 24
        Me.rb_famale.TabStop = True
        Me.rb_famale.Text = "زن"
        Me.rb_famale.UseVisualStyleBackColor = True
        '
        'rb_male
        '
        Me.rb_male.AutoSize = True
        Me.rb_male.Location = New System.Drawing.Point(590, 48)
        Me.rb_male.Name = "rb_male"
        Me.rb_male.Size = New System.Drawing.Size(41, 17)
        Me.rb_male.TabIndex = 23
        Me.rb_male.TabStop = True
        Me.rb_male.Text = "مرد"
        Me.rb_male.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(638, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "جسنیت:"
        '
        'cmb_doctors
        '
        Me.cmb_doctors.DisplayMember = "Id"
        Me.cmb_doctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_doctors.FormattingEnabled = True
        Me.cmb_doctors.Location = New System.Drawing.Point(704, 74)
        Me.cmb_doctors.Name = "cmb_doctors"
        Me.cmb_doctors.Size = New System.Drawing.Size(121, 21)
        Me.cmb_doctors.TabIndex = 17
        Me.cmb_doctors.ValueMember = "Id"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(831, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "پزشک معالج:"
        '
        'cmb_Blood
        '
        Me.cmb_Blood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Blood.FormattingEnabled = True
        Me.cmb_Blood.Items.AddRange(New Object() {"O", "A", "B", "AB", "-- همه موارد --"})
        Me.cmb_Blood.Location = New System.Drawing.Point(11, 46)
        Me.cmb_Blood.Name = "cmb_Blood"
        Me.cmb_Blood.Size = New System.Drawing.Size(125, 21)
        Me.cmb_Blood.TabIndex = 19
        '
        'cmb_group
        '
        Me.cmb_group.DisplayMember = "Id"
        Me.cmb_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_group.FormattingEnabled = True
        Me.cmb_group.Location = New System.Drawing.Point(11, 19)
        Me.cmb_group.Name = "cmb_group"
        Me.cmb_group.Size = New System.Drawing.Size(125, 21)
        Me.cmb_group.TabIndex = 3
        Me.cmb_group.ValueMember = "Id"
        '
        'txt_mobile
        '
        Me.txt_mobile.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_mobile.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_mobile.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_mobile.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_mobile.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_mobile.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_mobile.__NextFocuse = True
        Me.txt_mobile.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_mobile.__Type = TextualControl.TextualControl.No.Numeric
        Me.txt_mobile.Location = New System.Drawing.Point(506, 20)
        Me.txt_mobile.Name = "txt_mobile"
        Me.txt_mobile.Size = New System.Drawing.Size(126, 21)
        Me.txt_mobile.TabIndex = 14
        '
        'txt_Lname
        '
        Me.txt_Lname.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_Lname.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Lname.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Lname.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_Lname.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_Lname.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_Lname.__NextFocuse = True
        Me.txt_Lname.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_Lname.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_Lname.Location = New System.Drawing.Point(704, 46)
        Me.txt_Lname.Name = "txt_Lname"
        Me.txt_Lname.Size = New System.Drawing.Size(121, 21)
        Me.txt_Lname.TabIndex = 14
        '
        'txt_Fname
        '
        Me.txt_Fname.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_Fname.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Fname.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Fname.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_Fname.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_Fname.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_Fname.__NextFocuse = True
        Me.txt_Fname.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_Fname.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_Fname.Location = New System.Drawing.Point(704, 19)
        Me.txt_Fname.Name = "txt_Fname"
        Me.txt_Fname.Size = New System.Drawing.Size(121, 21)
        Me.txt_Fname.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(142, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "گروه خونی:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(142, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "گروه بیماری:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(142, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "تاریخ تشکیل پرونده:"
        Me.Label12.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(416, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "وزن:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(416, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "قد:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(416, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "تاریخ تولد:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(638, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "موبایل:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(831, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "نام خانوادگی:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(831, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "نام:"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(4, 144)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgv.Size = New System.Drawing.Size(906, 330)
        Me.dgv.TabIndex = 3
        '
        'btn_Close
        '
        Me.btn_Close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Close.Location = New System.Drawing.Point(835, 480)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 23)
        Me.btn_Close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Close.TabIndex = 4
        Me.btn_Close.Text = "خروج"
        '
        'chk_showAvatar
        '
        Me.chk_showAvatar.AutoSize = True
        Me.chk_showAvatar.Location = New System.Drawing.Point(181, 484)
        Me.chk_showAvatar.Name = "chk_showAvatar"
        Me.chk_showAvatar.Size = New System.Drawing.Size(139, 17)
        Me.chk_showAvatar.TabIndex = 7
        Me.chk_showAvatar.Text = "عکس دار شدن پرونده ها"
        Me.chk_showAvatar.UseVisualStyleBackColor = True
        Me.chk_showAvatar.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbl_searchedFiles})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 514)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(916, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(144, 17)
        Me.ToolStripStatusLabel1.Text = "تعداد پرونده های جستجو شده:"
        '
        'lbl_searchedFiles
        '
        Me.lbl_searchedFiles.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_searchedFiles.ForeColor = System.Drawing.Color.Red
        Me.lbl_searchedFiles.Name = "lbl_searchedFiles"
        Me.lbl_searchedFiles.Size = New System.Drawing.Size(0, 17)
        '
        'btn_returnValue
        '
        Me.btn_returnValue.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_returnValue.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_returnValue.Location = New System.Drawing.Point(599, 480)
        Me.btn_returnValue.Name = "btn_returnValue"
        Me.btn_returnValue.Size = New System.Drawing.Size(230, 23)
        Me.btn_returnValue.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_returnValue.TabIndex = 9
        Me.btn_returnValue.Text = "برگرداندن شماره پرونده شخص انتخاب شده"
        Me.btn_returnValue.Visible = False
        '
        'btnUpdateGrid
        '
        Me.btnUpdateGrid.Location = New System.Drawing.Point(4, 480)
        Me.btnUpdateGrid.Name = "btnUpdateGrid"
        Me.btnUpdateGrid.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateGrid.TabIndex = 10
        Me.btnUpdateGrid.Text = "بروزرسانی"
        Me.btnUpdateGrid.UseVisualStyleBackColor = True
        '
        'txt_height
        '
        Me.txt_height.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_height.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_height.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_height.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_height.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_height.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_height.__NextFocuse = True
        Me.txt_height.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_height.__Type = TextualControl.TextualControl.No.Numeric
        Me.txt_height.Location = New System.Drawing.Point(377, 48)
        Me.txt_height.Name = "txt_height"
        Me.txt_height.Size = New System.Drawing.Size(33, 21)
        Me.txt_height.TabIndex = 33
        '
        'txt_weight
        '
        Me.txt_weight.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_weight.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_weight.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_weight.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_weight.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_weight.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_weight.__NextFocuse = True
        Me.txt_weight.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_weight.__Type = TextualControl.TextualControl.No.Numeric
        Me.txt_weight.Location = New System.Drawing.Point(377, 74)
        Me.txt_weight.Name = "txt_weight"
        Me.txt_weight.Size = New System.Drawing.Size(33, 21)
        Me.txt_weight.TabIndex = 34
        '
        'frm_Search_File_Advance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 536)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnUpdateGrid)
        Me.Controls.Add(Me.btn_returnValue)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.chk_showAvatar)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_Search_File_Advance"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "جستجوی پرونده ها"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Blood As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_doctors As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_group As System.Windows.Forms.ComboBox
    Friend WithEvents txt_mobile As TextualControl.TextualControl
    Friend WithEvents txt_Lname As TextualControl.TextualControl
    Friend WithEvents txt_Fname As TextualControl.TextualControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rb_single As System.Windows.Forms.RadioButton
    Friend WithEvents rb_marriage As System.Windows.Forms.RadioButton
    Friend WithEvents rb_divorced As System.Windows.Forms.RadioButton
    Friend WithEvents rb_famale As System.Windows.Forms.RadioButton
    Friend WithEvents rb_male As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgv As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btn_Close As DevComponents.DotNetBar.ButtonX
    Friend WithEvents chk_showAvatar As System.Windows.Forms.CheckBox
    Friend WithEvents txt_presenter As TextualControl.TextualControl
    Friend WithEvents txt_job As TextualControl.TextualControl
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_searchedFiles As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rb_sex_all As System.Windows.Forms.RadioButton
    Friend WithEvents rb_all_marriage As System.Windows.Forms.RadioButton
    Friend WithEvents txt__date As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Birth As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_returnValue As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnUpdateGrid As System.Windows.Forms.Button
    Friend WithEvents txt_weight As TextualControl.TextualControl
    Friend WithEvents txt_height As TextualControl.TextualControl

End Class
