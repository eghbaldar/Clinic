<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_show_personal
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gb_Edit = New System.Windows.Forms.GroupBox()
        Me.btn_FullScreen = New System.Windows.Forms.PictureBox()
        Me.btn_Delete = New System.Windows.Forms.PictureBox()
        Me.btn_Open = New System.Windows.Forms.PictureBox()
        Me.txt_mobile = New TextualControl.TextualControl()
        Me.txt_phone = New TextualControl.TextualControl()
        Me.txt_Lname = New TextualControl.TextualControl()
        Me.txt_Fname = New TextualControl.TextualControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rb_invisible = New System.Windows.Forms.RadioButton()
        Me.rb_visible = New System.Windows.Forms.RadioButton()
        Me.btn_Update = New DevComponents.DotNetBar.ButtonX()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_address = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox_Edit = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_expertise = New System.Windows.Forms.ComboBox()
        Me.SelectexpertiseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Expertise = New Clinic.ds_Expertise()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rb_famale = New System.Windows.Forms.RadioButton()
        Me.rb_male = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgv_Info = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_show = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.Select_expertiseTableAdapter = New Clinic.ds_ExpertiseTableAdapters.Select_expertiseTableAdapter()
        Me.btn_DeletePersonal = New System.Windows.Forms.Button()
        Me.gb_Edit.SuspendLayout()
        CType(Me.btn_FullScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Open, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox_Edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectexpertiseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Expertise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_Info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_show, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_Edit
        '
        Me.gb_Edit.Controls.Add(Me.btn_DeletePersonal)
        Me.gb_Edit.Controls.Add(Me.btn_FullScreen)
        Me.gb_Edit.Controls.Add(Me.btn_Delete)
        Me.gb_Edit.Controls.Add(Me.btn_Open)
        Me.gb_Edit.Controls.Add(Me.txt_mobile)
        Me.gb_Edit.Controls.Add(Me.txt_phone)
        Me.gb_Edit.Controls.Add(Me.txt_Lname)
        Me.gb_Edit.Controls.Add(Me.txt_Fname)
        Me.gb_Edit.Controls.Add(Me.Panel1)
        Me.gb_Edit.Controls.Add(Me.btn_Update)
        Me.gb_Edit.Controls.Add(Me.Label9)
        Me.gb_Edit.Controls.Add(Me.txt_address)
        Me.gb_Edit.Controls.Add(Me.PictureBox_Edit)
        Me.gb_Edit.Controls.Add(Me.Label8)
        Me.gb_Edit.Controls.Add(Me.cmb_expertise)
        Me.gb_Edit.Controls.Add(Me.Label7)
        Me.gb_Edit.Controls.Add(Me.Label6)
        Me.gb_Edit.Controls.Add(Me.rb_famale)
        Me.gb_Edit.Controls.Add(Me.rb_male)
        Me.gb_Edit.Controls.Add(Me.Label4)
        Me.gb_Edit.Controls.Add(Me.Label3)
        Me.gb_Edit.Controls.Add(Me.Label2)
        Me.gb_Edit.Controls.Add(Me.Label1)
        Me.gb_Edit.Controls.Add(Me.ShapeContainer1)
        Me.gb_Edit.Enabled = False
        Me.gb_Edit.Location = New System.Drawing.Point(272, 217)
        Me.gb_Edit.Name = "gb_Edit"
        Me.gb_Edit.Size = New System.Drawing.Size(474, 253)
        Me.gb_Edit.TabIndex = 19
        Me.gb_Edit.TabStop = False
        Me.gb_Edit.Text = "ویرایش اطلاعات"
        '
        'btn_FullScreen
        '
        Me.btn_FullScreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_FullScreen.Image = Global.Clinic.My.Resources.Resources.fullscreen
        Me.btn_FullScreen.Location = New System.Drawing.Point(63, 158)
        Me.btn_FullScreen.Name = "btn_FullScreen"
        Me.btn_FullScreen.Size = New System.Drawing.Size(21, 20)
        Me.btn_FullScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_FullScreen.TabIndex = 83
        Me.btn_FullScreen.TabStop = False
        '
        'btn_Delete
        '
        Me.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Delete.Image = Global.Clinic.My.Resources.Resources.delete
        Me.btn_Delete.Location = New System.Drawing.Point(63, 132)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(21, 20)
        Me.btn_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Delete.TabIndex = 82
        Me.btn_Delete.TabStop = False
        '
        'btn_Open
        '
        Me.btn_Open.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Open.Image = Global.Clinic.My.Resources.Resources.open
        Me.btn_Open.Location = New System.Drawing.Point(63, 106)
        Me.btn_Open.Name = "btn_Open"
        Me.btn_Open.Size = New System.Drawing.Size(21, 20)
        Me.btn_Open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Open.TabIndex = 81
        Me.btn_Open.TabStop = False
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
        Me.txt_mobile.Location = New System.Drawing.Point(63, 79)
        Me.txt_mobile.Name = "txt_mobile"
        Me.txt_mobile.Size = New System.Drawing.Size(100, 21)
        Me.txt_mobile.TabIndex = 73
        '
        'txt_phone
        '
        Me.txt_phone.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_phone.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_phone.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_phone.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_phone.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_phone.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_phone.__NextFocuse = True
        Me.txt_phone.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_phone.__Type = TextualControl.TextualControl.No.Numeric
        Me.txt_phone.Location = New System.Drawing.Point(63, 52)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(100, 21)
        Me.txt_phone.TabIndex = 72
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
        Me.txt_Lname.Location = New System.Drawing.Point(214, 47)
        Me.txt_Lname.Name = "txt_Lname"
        Me.txt_Lname.Size = New System.Drawing.Size(173, 21)
        Me.txt_Lname.TabIndex = 71
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
        Me.txt_Fname.Location = New System.Drawing.Point(214, 20)
        Me.txt_Fname.Name = "txt_Fname"
        Me.txt_Fname.Size = New System.Drawing.Size(173, 21)
        Me.txt_Fname.TabIndex = 70
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.rb_invisible)
        Me.Panel1.Controls.Add(Me.rb_visible)
        Me.Panel1.Location = New System.Drawing.Point(13, 219)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(196, 28)
        Me.Panel1.TabIndex = 69
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(132, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "وضعیت:"
        '
        'rb_invisible
        '
        Me.rb_invisible.AutoSize = True
        Me.rb_invisible.Location = New System.Drawing.Point(4, 4)
        Me.rb_invisible.Name = "rb_invisible"
        Me.rb_invisible.Size = New System.Drawing.Size(65, 17)
        Me.rb_invisible.TabIndex = 68
        Me.rb_invisible.TabStop = True
        Me.rb_invisible.Text = "غیر فعال"
        Me.rb_invisible.UseVisualStyleBackColor = True
        '
        'rb_visible
        '
        Me.rb_visible.AutoSize = True
        Me.rb_visible.Location = New System.Drawing.Point(75, 5)
        Me.rb_visible.Name = "rb_visible"
        Me.rb_visible.Size = New System.Drawing.Size(46, 17)
        Me.rb_visible.TabIndex = 67
        Me.rb_visible.TabStop = True
        Me.rb_visible.Text = "فعال"
        Me.rb_visible.UseVisualStyleBackColor = True
        '
        'btn_Update
        '
        Me.btn_Update.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Update.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Update.Location = New System.Drawing.Point(377, 219)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(88, 23)
        Me.btn_Update.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Update.TabIndex = 65
        Me.btn_Update.Text = "ذخیره سازی"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(388, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "آدرس:"
        '
        'txt_address
        '
        Me.txt_address.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_address.Border.Class = "TextBoxBorder"
        Me.txt_address.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_address.DisabledBackColor = System.Drawing.Color.White
        Me.txt_address.ForeColor = System.Drawing.Color.Black
        Me.txt_address.Location = New System.Drawing.Point(214, 99)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.PreventEnterBeep = True
        Me.txt_address.Size = New System.Drawing.Size(173, 95)
        Me.txt_address.TabIndex = 62
        '
        'PictureBox_Edit
        '
        Me.PictureBox_Edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox_Edit.Location = New System.Drawing.Point(89, 106)
        Me.PictureBox_Edit.Name = "PictureBox_Edit"
        Me.PictureBox_Edit.Size = New System.Drawing.Size(74, 88)
        Me.PictureBox_Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Edit.TabIndex = 61
        Me.PictureBox_Edit.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(169, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "موبایل:"
        '
        'cmb_expertise
        '
        Me.cmb_expertise.DataSource = Me.SelectexpertiseBindingSource
        Me.cmb_expertise.DisplayMember = "Name"
        Me.cmb_expertise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_expertise.FormattingEnabled = True
        Me.cmb_expertise.Location = New System.Drawing.Point(8, 22)
        Me.cmb_expertise.Name = "cmb_expertise"
        Me.cmb_expertise.Size = New System.Drawing.Size(155, 21)
        Me.cmb_expertise.TabIndex = 58
        '
        'SelectexpertiseBindingSource
        '
        Me.SelectexpertiseBindingSource.DataMember = "Select_expertise"
        Me.SelectexpertiseBindingSource.DataSource = Me.Ds_Expertise
        '
        'Ds_Expertise
        '
        Me.Ds_Expertise.DataSetName = "ds_Expertise"
        Me.Ds_Expertise.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(169, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "تلفن:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(169, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "تخصص:"
        '
        'rb_famale
        '
        Me.rb_famale.AutoSize = True
        Me.rb_famale.Location = New System.Drawing.Point(299, 76)
        Me.rb_famale.Name = "rb_famale"
        Me.rb_famale.Size = New System.Drawing.Size(36, 17)
        Me.rb_famale.TabIndex = 51
        Me.rb_famale.TabStop = True
        Me.rb_famale.Text = "زن"
        Me.rb_famale.UseVisualStyleBackColor = True
        '
        'rb_male
        '
        Me.rb_male.AutoSize = True
        Me.rb_male.Location = New System.Drawing.Point(346, 76)
        Me.rb_male.Name = "rb_male"
        Me.rb_male.Size = New System.Drawing.Size(41, 17)
        Me.rb_male.TabIndex = 50
        Me.rb_male.TabStop = True
        Me.rb_male.Text = "مرد"
        Me.rb_male.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "تصویر:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(388, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "جنسیت:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(388, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "نام خانوادگی:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(388, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "نام:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 17)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(468, 233)
        Me.ShapeContainer1.TabIndex = 64
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 10
        Me.LineShape1.X2 = 462
        Me.LineShape1.Y1 = 193
        Me.LineShape1.Y2 = 193
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgv_Info)
        Me.GroupBox3.Controls.Add(Me.PictureBox)
        Me.GroupBox3.Location = New System.Drawing.Point(272, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(474, 209)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "مشخصات"
        '
        'dgv_Info
        '
        Me.dgv_Info.AllowUserToAddRows = False
        Me.dgv_Info.AllowUserToDeleteRows = False
        Me.dgv_Info.AllowUserToResizeColumns = False
        Me.dgv_Info.AllowUserToResizeRows = False
        Me.dgv_Info.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Info.ColumnHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Info.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Info.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgv_Info.Location = New System.Drawing.Point(6, 19)
        Me.dgv_Info.MultiSelect = False
        Me.dgv_Info.Name = "dgv_Info"
        Me.dgv_Info.ReadOnly = True
        Me.dgv_Info.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_Info.RowHeadersVisible = False
        Me.dgv_Info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_Info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Info.ShowCellErrors = False
        Me.dgv_Info.ShowCellToolTips = False
        Me.dgv_Info.ShowEditingIcon = False
        Me.dgv_Info.ShowRowErrors = False
        Me.dgv_Info.Size = New System.Drawing.Size(311, 183)
        Me.dgv_Info.TabIndex = 2
        '
        'PictureBox
        '
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox.Location = New System.Drawing.Point(323, 19)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(142, 183)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 0
        Me.PictureBox.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_show)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 371)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "پرسنل اضافه شده"
        '
        'dgv_show
        '
        Me.dgv_show.AllowUserToAddRows = False
        Me.dgv_show.AllowUserToDeleteRows = False
        Me.dgv_show.BackgroundColor = System.Drawing.Color.White
        Me.dgv_show.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_show.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_show.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_show.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgv_show.Location = New System.Drawing.Point(11, 20)
        Me.dgv_show.MultiSelect = False
        Me.dgv_show.Name = "dgv_show"
        Me.dgv_show.ReadOnly = True
        Me.dgv_show.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_show.RowHeadersVisible = False
        Me.dgv_show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_show.ShowCellErrors = False
        Me.dgv_show.ShowEditingIcon = False
        Me.dgv_show.ShowRowErrors = False
        Me.dgv_show.Size = New System.Drawing.Size(234, 345)
        Me.dgv_show.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_Search)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 50)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "جستجو ..."
        '
        'txt_Search
        '
        Me.txt_Search.Location = New System.Drawing.Point(11, 20)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(234, 21)
        Me.txt_Search.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCancel.Location = New System.Drawing.Point(0, 475)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(753, 43)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "روئیت شد"
        '
        'Select_expertiseTableAdapter
        '
        Me.Select_expertiseTableAdapter.ClearBeforeFill = True
        '
        'btn_DeletePersonal
        '
        Me.btn_DeletePersonal.BackColor = System.Drawing.Color.Red
        Me.btn_DeletePersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DeletePersonal.ForeColor = System.Drawing.Color.White
        Me.btn_DeletePersonal.Location = New System.Drawing.Point(279, 218)
        Me.btn_DeletePersonal.Name = "btn_DeletePersonal"
        Me.btn_DeletePersonal.Size = New System.Drawing.Size(92, 23)
        Me.btn_DeletePersonal.TabIndex = 82
        Me.btn_DeletePersonal.Text = "حذف پرسنل"
        Me.btn_DeletePersonal.UseVisualStyleBackColor = False
        '
        'frm_show_personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 518)
        Me.ControlBox = False
        Me.Controls.Add(Me.gb_Edit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_show_personal"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نمایش پرسنل"
        Me.gb_Edit.ResumeLayout(False)
        Me.gb_Edit.PerformLayout()
        CType(Me.btn_FullScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Open, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox_Edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectexpertiseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Expertise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgv_Info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_show, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_Edit As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rb_invisible As System.Windows.Forms.RadioButton
    Friend WithEvents rb_visible As System.Windows.Forms.RadioButton
    Friend WithEvents btn_Update As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_address As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox_Edit As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_expertise As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rb_famale As System.Windows.Forms.RadioButton
    Friend WithEvents rb_male As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_Info As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_show As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Search As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SelectexpertiseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Expertise As Clinic.ds_Expertise
    Friend WithEvents Select_expertiseTableAdapter As Clinic.ds_ExpertiseTableAdapters.Select_expertiseTableAdapter
    Friend WithEvents txt_mobile As TextualControl.TextualControl
    Friend WithEvents txt_phone As TextualControl.TextualControl
    Friend WithEvents txt_Lname As TextualControl.TextualControl
    Friend WithEvents txt_Fname As TextualControl.TextualControl
    Friend WithEvents btn_FullScreen As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Delete As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Open As System.Windows.Forms.PictureBox
    Friend WithEvents btn_DeletePersonal As System.Windows.Forms.Button
End Class
