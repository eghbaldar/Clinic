<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_define_user
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_cancel = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Personal = New Clinic.ds_Personal()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_Personal = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource_Personal = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Personal_ = New Clinic.ds_Personal()
        Me.PersonalTableAdapter = New Clinic.ds_PersonalTableAdapters.PersonalTableAdapter()
        Me.PersonalTableAdapter_Personal = New Clinic.ds_PersonalTableAdapters.PersonalTableAdapter()
        Me.gp_attributes = New System.Windows.Forms.GroupBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.dgv_Attributes = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.gp_rules = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rb_nurse = New System.Windows.Forms.RadioButton()
        Me.rb_admin = New System.Windows.Forms.RadioButton()
        Me.rb_general_admin = New System.Windows.Forms.RadioButton()
        Me.gp_userpass = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_confirm_Password = New TextualControl.TextualControl()
        Me.txt_password = New TextualControl.TextualControl()
        Me.txt_username = New TextualControl.TextualControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rb_invisible = New System.Windows.Forms.RadioButton()
        Me.rb_visible = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_InsertUpdate = New DevComponents.DotNetBar.ButtonX()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Personal_, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gp_attributes.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Attributes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gp_rules.SuspendLayout()
        Me.gp_userpass.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancel
        '
        Me.btn_cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(587, 428)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(114, 23)
        Me.btn_cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_cancel.TabIndex = 0
        Me.btn_cancel.Text = "خروج"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 439)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "انتخاب کاربر"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 20)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(264, 413)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(256, 387)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "پزشکان"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FNameDataGridViewTextBoxColumn, Me.LNameDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.PersonalBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(6, 6)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.ShowCellErrors = False
        Me.dgv.ShowEditingIcon = False
        Me.dgv.ShowRowErrors = False
        Me.dgv.Size = New System.Drawing.Size(244, 375)
        Me.dgv.TabIndex = 11
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'FNameDataGridViewTextBoxColumn
        '
        Me.FNameDataGridViewTextBoxColumn.DataPropertyName = "F_Name"
        Me.FNameDataGridViewTextBoxColumn.HeaderText = "نام"
        Me.FNameDataGridViewTextBoxColumn.Name = "FNameDataGridViewTextBoxColumn"
        Me.FNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FNameDataGridViewTextBoxColumn.Width = 70
        '
        'LNameDataGridViewTextBoxColumn
        '
        Me.LNameDataGridViewTextBoxColumn.DataPropertyName = "L_Name"
        Me.LNameDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی"
        Me.LNameDataGridViewTextBoxColumn.Name = "LNameDataGridViewTextBoxColumn"
        Me.LNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LNameDataGridViewTextBoxColumn.Width = 120
        '
        'PersonalBindingSource
        '
        Me.PersonalBindingSource.DataMember = "Personal"
        Me.PersonalBindingSource.DataSource = Me.Ds_Personal
        '
        'Ds_Personal
        '
        Me.Ds_Personal.DataSetName = "ds_Personal"
        Me.Ds_Personal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_Personal)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(256, 387)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "پرسنل"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_Personal
        '
        Me.dgv_Personal.AllowUserToAddRows = False
        Me.dgv_Personal.AllowUserToDeleteRows = False
        Me.dgv_Personal.AutoGenerateColumns = False
        Me.dgv_Personal.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Personal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Personal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgv_Personal.DataSource = Me.BindingSource_Personal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Personal.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Personal.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgv_Personal.Location = New System.Drawing.Point(6, 6)
        Me.dgv_Personal.MultiSelect = False
        Me.dgv_Personal.Name = "dgv_Personal"
        Me.dgv_Personal.ReadOnly = True
        Me.dgv_Personal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Personal.ShowCellErrors = False
        Me.dgv_Personal.ShowEditingIcon = False
        Me.dgv_Personal.ShowRowErrors = False
        Me.dgv_Personal.Size = New System.Drawing.Size(244, 375)
        Me.dgv_Personal.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "F_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "نام"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "L_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "نام خانوادگی"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'BindingSource_Personal
        '
        Me.BindingSource_Personal.DataMember = "Personal"
        Me.BindingSource_Personal.DataSource = Me.Ds_Personal_
        '
        'Ds_Personal_
        '
        Me.Ds_Personal_.DataSetName = "ds_Personal"
        Me.Ds_Personal_.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonalTableAdapter
        '
        Me.PersonalTableAdapter.ClearBeforeFill = True
        '
        'PersonalTableAdapter_Personal
        '
        Me.PersonalTableAdapter_Personal.ClearBeforeFill = True
        '
        'gp_attributes
        '
        Me.gp_attributes.Controls.Add(Me.PictureBox)
        Me.gp_attributes.Controls.Add(Me.dgv_Attributes)
        Me.gp_attributes.Enabled = False
        Me.gp_attributes.Location = New System.Drawing.Point(294, 12)
        Me.gp_attributes.Name = "gp_attributes"
        Me.gp_attributes.Size = New System.Drawing.Size(407, 141)
        Me.gp_attributes.TabIndex = 2
        Me.gp_attributes.TabStop = False
        Me.gp_attributes.Text = "اطلاعات کاربر"
        '
        'PictureBox
        '
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox.Location = New System.Drawing.Point(311, 20)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(90, 113)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 4
        Me.PictureBox.TabStop = False
        '
        'dgv_Attributes
        '
        Me.dgv_Attributes.AllowUserToAddRows = False
        Me.dgv_Attributes.AllowUserToDeleteRows = False
        Me.dgv_Attributes.AllowUserToResizeColumns = False
        Me.dgv_Attributes.AllowUserToResizeRows = False
        Me.dgv_Attributes.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Attributes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_Attributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Attributes.ColumnHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Attributes.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Attributes.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgv_Attributes.Location = New System.Drawing.Point(6, 20)
        Me.dgv_Attributes.MultiSelect = False
        Me.dgv_Attributes.Name = "dgv_Attributes"
        Me.dgv_Attributes.ReadOnly = True
        Me.dgv_Attributes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_Attributes.RowHeadersVisible = False
        Me.dgv_Attributes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_Attributes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Attributes.ShowCellErrors = False
        Me.dgv_Attributes.ShowCellToolTips = False
        Me.dgv_Attributes.ShowEditingIcon = False
        Me.dgv_Attributes.ShowRowErrors = False
        Me.dgv_Attributes.Size = New System.Drawing.Size(299, 113)
        Me.dgv_Attributes.TabIndex = 3
        '
        'gp_rules
        '
        Me.gp_rules.Controls.Add(Me.Label3)
        Me.gp_rules.Controls.Add(Me.Label2)
        Me.gp_rules.Controls.Add(Me.Label1)
        Me.gp_rules.Controls.Add(Me.rb_nurse)
        Me.gp_rules.Controls.Add(Me.rb_admin)
        Me.gp_rules.Controls.Add(Me.rb_general_admin)
        Me.gp_rules.Enabled = False
        Me.gp_rules.Location = New System.Drawing.Point(294, 159)
        Me.gp_rules.Name = "gp_rules"
        Me.gp_rules.Size = New System.Drawing.Size(407, 96)
        Me.gp_rules.TabIndex = 3
        Me.gp_rules.TabStop = False
        Me.gp_rules.Text = "نقش کاربری"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(82, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "دسترسی به پرونده ها و نوبت دهی بیماران"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(119, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "توانایی دسترسی به کلیه بخش ها "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(23, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "توانایی دسترسی به کلیه بخش ها بعلاوه مدیریت کاربری"
        '
        'rb_nurse
        '
        Me.rb_nurse.AutoSize = True
        Me.rb_nurse.Location = New System.Drawing.Point(310, 66)
        Me.rb_nurse.Name = "rb_nurse"
        Me.rb_nurse.Size = New System.Drawing.Size(87, 17)
        Me.rb_nurse.TabIndex = 2
        Me.rb_nurse.TabStop = True
        Me.rb_nurse.Text = "نقش پرستاری"
        Me.rb_nurse.UseVisualStyleBackColor = True
        '
        'rb_admin
        '
        Me.rb_admin.AutoSize = True
        Me.rb_admin.Location = New System.Drawing.Point(327, 43)
        Me.rb_admin.Name = "rb_admin"
        Me.rb_admin.Size = New System.Drawing.Size(74, 17)
        Me.rb_admin.TabIndex = 1
        Me.rb_admin.TabStop = True
        Me.rb_admin.Text = "مدیر برنامه"
        Me.rb_admin.UseVisualStyleBackColor = True
        '
        'rb_general_admin
        '
        Me.rb_general_admin.AutoSize = True
        Me.rb_general_admin.Location = New System.Drawing.Point(311, 20)
        Me.rb_general_admin.Name = "rb_general_admin"
        Me.rb_general_admin.Size = New System.Drawing.Size(91, 17)
        Me.rb_general_admin.TabIndex = 0
        Me.rb_general_admin.TabStop = True
        Me.rb_general_admin.Text = "مدیر کل برنامه"
        Me.rb_general_admin.UseVisualStyleBackColor = True
        '
        'gp_userpass
        '
        Me.gp_userpass.Controls.Add(Me.PictureBox1)
        Me.gp_userpass.Controls.Add(Me.txt_confirm_Password)
        Me.gp_userpass.Controls.Add(Me.txt_password)
        Me.gp_userpass.Controls.Add(Me.txt_username)
        Me.gp_userpass.Controls.Add(Me.Panel1)
        Me.gp_userpass.Controls.Add(Me.Label6)
        Me.gp_userpass.Controls.Add(Me.Label5)
        Me.gp_userpass.Controls.Add(Me.Label4)
        Me.gp_userpass.Enabled = False
        Me.gp_userpass.Location = New System.Drawing.Point(294, 261)
        Me.gp_userpass.Name = "gp_userpass"
        Me.gp_userpass.Size = New System.Drawing.Size(407, 155)
        Me.gp_userpass.TabIndex = 4
        Me.gp_userpass.TabStop = False
        Me.gp_userpass.Text = "مشخصات کاربری"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox1.Image = Global.Clinic.My.Resources.Resources.question
        Me.PictureBox1.Location = New System.Drawing.Point(13, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 70)
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "فقط از حروف انگلیسی برای وارد کردن نام کاربری و کلمه عبور استفاده کنید.")
        '
        'txt_confirm_Password
        '
        Me.txt_confirm_Password.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_confirm_Password.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_confirm_Password.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_confirm_Password.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_confirm_Password.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban_Characters
        Me.txt_confirm_Password.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_confirm_Password.__NextFocuse = True
        Me.txt_confirm_Password.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_confirm_Password.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_confirm_Password.Location = New System.Drawing.Point(82, 74)
        Me.txt_confirm_Password.Name = "txt_confirm_Password"
        Me.txt_confirm_Password.Size = New System.Drawing.Size(223, 21)
        Me.txt_confirm_Password.TabIndex = 73
        Me.txt_confirm_Password.UseSystemPasswordChar = True
        '
        'txt_password
        '
        Me.txt_password.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_password.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_password.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_password.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_password.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban_Characters
        Me.txt_password.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_password.__NextFocuse = True
        Me.txt_password.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_password.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_password.Location = New System.Drawing.Point(82, 47)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(223, 21)
        Me.txt_password.TabIndex = 72
        Me.txt_password.UseSystemPasswordChar = True
        '
        'txt_username
        '
        Me.txt_username.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_username.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_username.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_username.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_username.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban_Characters
        Me.txt_username.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_username.__NextFocuse = True
        Me.txt_username.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_username.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_username.Location = New System.Drawing.Point(82, 20)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(223, 21)
        Me.txt_username.TabIndex = 71
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.rb_invisible)
        Me.Panel1.Controls.Add(Me.rb_visible)
        Me.Panel1.Location = New System.Drawing.Point(13, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 28)
        Me.Panel1.TabIndex = 70
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(329, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "وضعیت:"
        '
        'rb_invisible
        '
        Me.rb_invisible.AutoSize = True
        Me.rb_invisible.Location = New System.Drawing.Point(173, 3)
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
        Me.rb_visible.Checked = True
        Me.rb_visible.Location = New System.Drawing.Point(244, 4)
        Me.rb_visible.Name = "rb_visible"
        Me.rb_visible.Size = New System.Drawing.Size(46, 17)
        Me.rb_visible.TabIndex = 67
        Me.rb_visible.TabStop = True
        Me.rb_visible.Text = "فعال"
        Me.rb_visible.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(321, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "تکرار کلمه عبور:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(344, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "کلمه عبور:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(343, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "نام کاربری:"
        '
        'btn_InsertUpdate
        '
        Me.btn_InsertUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_InsertUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_InsertUpdate.Enabled = False
        Me.btn_InsertUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_InsertUpdate.Location = New System.Drawing.Point(294, 428)
        Me.btn_InsertUpdate.Name = "btn_InsertUpdate"
        Me.btn_InsertUpdate.Size = New System.Drawing.Size(111, 23)
        Me.btn_InsertUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_InsertUpdate.TabIndex = 5
        Me.btn_InsertUpdate.Text = "ذخیره سازی"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.InitialDelay = 10
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'frm_define_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 457)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_InsertUpdate)
        Me.Controls.Add(Me.gp_userpass)
        Me.Controls.Add(Me.gp_rules)
        Me.Controls.Add(Me.gp_attributes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_define_user"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مدیریت کاربران"
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Personal_, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gp_attributes.ResumeLayout(False)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Attributes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gp_rules.ResumeLayout(False)
        Me.gp_rules.PerformLayout()
        Me.gp_userpass.ResumeLayout(False)
        Me.gp_userpass.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_cancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgv As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PersonalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Personal As Clinic.ds_Personal
    Friend WithEvents PersonalTableAdapter As Clinic.ds_PersonalTableAdapters.PersonalTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_Personal As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PersonalTableAdapter_Personal As Clinic.ds_PersonalTableAdapters.PersonalTableAdapter
    Friend WithEvents Ds_Personal_ As Clinic.ds_Personal
    Friend WithEvents BindingSource_Personal As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gp_attributes As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents dgv_Attributes As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents gp_rules As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rb_nurse As System.Windows.Forms.RadioButton
    Friend WithEvents rb_admin As System.Windows.Forms.RadioButton
    Friend WithEvents rb_general_admin As System.Windows.Forms.RadioButton
    Friend WithEvents gp_userpass As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_InsertUpdate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rb_invisible As System.Windows.Forms.RadioButton
    Friend WithEvents rb_visible As System.Windows.Forms.RadioButton
    Friend WithEvents txt_confirm_Password As TextualControl.TextualControl
    Friend WithEvents txt_password As TextualControl.TextualControl
    Friend WithEvents txt_username As TextualControl.TextualControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
