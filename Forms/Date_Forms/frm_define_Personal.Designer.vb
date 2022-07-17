<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_define_Personal
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
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btn_clear = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Refresh = New DevComponents.DotNetBar.ButtonX()
        Me.btn_ShowInfo = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Insert = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.cmb_expertise = New System.Windows.Forms.ComboBox()
        Me.SelectexpertiseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Expertise = New Clinic.ds_Expertise()
        Me.rb_famale = New System.Windows.Forms.RadioButton()
        Me.rb_male = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_address = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Personal = New Clinic.ds_Personal()
        Me.Select_expertiseTableAdapter = New Clinic.ds_ExpertiseTableAdapters.Select_expertiseTableAdapter()
        Me.PersonalTableAdapter = New Clinic.ds_PersonalTableAdapters.PersonalTableAdapter()
        Me.btn_FullScreen = New System.Windows.Forms.PictureBox()
        Me.btn_Delete = New System.Windows.Forms.PictureBox()
        Me.btn_Open = New System.Windows.Forms.PictureBox()
        Me.txt_Fname = New TextualControl.TextualControl()
        Me.txt_Lname = New TextualControl.TextualControl()
        Me.txt_phone = New TextualControl.TextualControl()
        Me.txt_mobile = New TextualControl.TextualControl()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectexpertiseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Expertise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_FullScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Open, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Location = New System.Drawing.Point(301, 400)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 25)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "خروج"
        '
        'btn_clear
        '
        Me.btn_clear.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
        Me.btn_clear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_clear.Location = New System.Drawing.Point(299, 157)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(109, 40)
        Me.btn_clear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_clear.TabIndex = 16
        Me.btn_clear.Text = "خالی کردن"
        '
        'btn_Refresh
        '
        Me.btn_Refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Refresh.Location = New System.Drawing.Point(299, 111)
        Me.btn_Refresh.Name = "btn_Refresh"
        Me.btn_Refresh.Size = New System.Drawing.Size(109, 40)
        Me.btn_Refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Refresh.TabIndex = 15
        Me.btn_Refresh.Text = "بروزرسانی"
        '
        'btn_ShowInfo
        '
        Me.btn_ShowInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_ShowInfo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_ShowInfo.Location = New System.Drawing.Point(299, 65)
        Me.btn_ShowInfo.Name = "btn_ShowInfo"
        Me.btn_ShowInfo.Size = New System.Drawing.Size(109, 38)
        Me.btn_ShowInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_ShowInfo.TabIndex = 14
        Me.btn_ShowInfo.Text = "نمایش اطلاعات"
        '
        'btn_Insert
        '
        Me.btn_Insert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Insert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Insert.Location = New System.Drawing.Point(299, 19)
        Me.btn_Insert.Name = "btn_Insert"
        Me.btn_Insert.Size = New System.Drawing.Size(109, 39)
        Me.btn_Insert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Insert.TabIndex = 12
        Me.btn_Insert.Text = "اضافه کردن"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_mobile)
        Me.GroupBox2.Controls.Add(Me.txt_phone)
        Me.GroupBox2.Controls.Add(Me.txt_Lname)
        Me.GroupBox2.Controls.Add(Me.txt_Fname)
        Me.GroupBox2.Controls.Add(Me.btn_FullScreen)
        Me.GroupBox2.Controls.Add(Me.btn_Delete)
        Me.GroupBox2.Controls.Add(Me.btn_Open)
        Me.GroupBox2.Controls.Add(Me.PictureBox)
        Me.GroupBox2.Controls.Add(Me.cmb_expertise)
        Me.GroupBox2.Controls.Add(Me.rb_famale)
        Me.GroupBox2.Controls.Add(Me.rb_male)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_address)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(281, 418)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "پرسنل جدید"
        '
        'PictureBox
        '
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox.Location = New System.Drawing.Point(103, 104)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(76, 89)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 22
        Me.PictureBox.TabStop = False
        '
        'cmb_expertise
        '
        Me.cmb_expertise.DataSource = Me.SelectexpertiseBindingSource
        Me.cmb_expertise.DisplayMember = "Name"
        Me.cmb_expertise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_expertise.FormattingEnabled = True
        Me.cmb_expertise.Location = New System.Drawing.Point(6, 228)
        Me.cmb_expertise.Name = "cmb_expertise"
        Me.cmb_expertise.Size = New System.Drawing.Size(173, 21)
        Me.cmb_expertise.TabIndex = 21
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
        'rb_famale
        '
        Me.rb_famale.AutoSize = True
        Me.rb_famale.Location = New System.Drawing.Point(91, 76)
        Me.rb_famale.Name = "rb_famale"
        Me.rb_famale.Size = New System.Drawing.Size(36, 17)
        Me.rb_famale.TabIndex = 19
        Me.rb_famale.Text = "زن"
        Me.rb_famale.UseVisualStyleBackColor = True
        '
        'rb_male
        '
        Me.rb_male.AutoSize = True
        Me.rb_male.Checked = True
        Me.rb_male.Location = New System.Drawing.Point(138, 76)
        Me.rb_male.Name = "rb_male"
        Me.rb_male.Size = New System.Drawing.Size(41, 17)
        Me.rb_male.TabIndex = 18
        Me.rb_male.TabStop = True
        Me.rb_male.Text = "مرد"
        Me.rb_male.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(185, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 17
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
        Me.txt_address.Location = New System.Drawing.Point(6, 310)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.PreventEnterBeep = True
        Me.txt_address.Size = New System.Drawing.Size(173, 102)
        Me.txt_address.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(185, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "موبایل:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(185, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "تلفن:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(185, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "سمت:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(185, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "تصویر:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(185, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "جنسیت:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(185, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "نام خانوادگی:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(185, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "نام:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv)
        Me.GroupBox1.Location = New System.Drawing.Point(416, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 421)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "پرسنل اضافه شده"
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
        Me.dgv.Location = New System.Drawing.Point(11, 20)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.ShowCellErrors = False
        Me.dgv.ShowEditingIcon = False
        Me.dgv.ShowRowErrors = False
        Me.dgv.Size = New System.Drawing.Size(234, 395)
        Me.dgv.TabIndex = 10
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
        'Select_expertiseTableAdapter
        '
        Me.Select_expertiseTableAdapter.ClearBeforeFill = True
        '
        'PersonalTableAdapter
        '
        Me.PersonalTableAdapter.ClearBeforeFill = True
        '
        'btn_FullScreen
        '
        Me.btn_FullScreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_FullScreen.Image = Global.Clinic.My.Resources.Resources.fullscreen
        Me.btn_FullScreen.Location = New System.Drawing.Point(104, 199)
        Me.btn_FullScreen.Name = "btn_FullScreen"
        Me.btn_FullScreen.Size = New System.Drawing.Size(21, 20)
        Me.btn_FullScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_FullScreen.TabIndex = 42
        Me.btn_FullScreen.TabStop = False
        '
        'btn_Delete
        '
        Me.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Delete.Image = Global.Clinic.My.Resources.Resources.delete
        Me.btn_Delete.Location = New System.Drawing.Point(132, 199)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(21, 20)
        Me.btn_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Delete.TabIndex = 41
        Me.btn_Delete.TabStop = False
        '
        'btn_Open
        '
        Me.btn_Open.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Open.Image = Global.Clinic.My.Resources.Resources.open
        Me.btn_Open.Location = New System.Drawing.Point(159, 199)
        Me.btn_Open.Name = "btn_Open"
        Me.btn_Open.Size = New System.Drawing.Size(21, 20)
        Me.btn_Open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Open.TabIndex = 40
        Me.btn_Open.TabStop = False
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
        Me.txt_Fname.Location = New System.Drawing.Point(6, 19)
        Me.txt_Fname.Name = "txt_Fname"
        Me.txt_Fname.Size = New System.Drawing.Size(174, 21)
        Me.txt_Fname.TabIndex = 43
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
        Me.txt_Lname.Location = New System.Drawing.Point(6, 46)
        Me.txt_Lname.Name = "txt_Lname"
        Me.txt_Lname.Size = New System.Drawing.Size(174, 21)
        Me.txt_Lname.TabIndex = 44
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
        Me.txt_phone.Location = New System.Drawing.Point(80, 255)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(100, 21)
        Me.txt_phone.TabIndex = 45
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
        Me.txt_mobile.Location = New System.Drawing.Point(80, 283)
        Me.txt_mobile.Name = "txt_mobile"
        Me.txt_mobile.Size = New System.Drawing.Size(100, 21)
        Me.txt_mobile.TabIndex = 46
        '
        'frm_define_Personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 430)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_Refresh)
        Me.Controls.Add(Me.btn_ShowInfo)
        Me.Controls.Add(Me.btn_Insert)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_define_Personal"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تعریف پرسنل"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectexpertiseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Expertise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_FullScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Open, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_clear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Refresh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_ShowInfo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Insert As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents cmb_expertise As System.Windows.Forms.ComboBox
    Friend WithEvents rb_famale As System.Windows.Forms.RadioButton
    Friend WithEvents rb_male As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_address As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents SelectexpertiseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Expertise As Clinic.ds_Expertise
    Friend WithEvents Select_expertiseTableAdapter As Clinic.ds_ExpertiseTableAdapters.Select_expertiseTableAdapter
    Friend WithEvents Ds_Personal As Clinic.ds_Personal
    Friend WithEvents PersonalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonalTableAdapter As Clinic.ds_PersonalTableAdapters.PersonalTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_FullScreen As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Delete As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Open As System.Windows.Forms.PictureBox
    Friend WithEvents txt_mobile As TextualControl.TextualControl
    Friend WithEvents txt_phone As TextualControl.TextualControl
    Friend WithEvents txt_Lname As TextualControl.TextualControl
    Friend WithEvents txt_Fname As TextualControl.TextualControl
End Class
