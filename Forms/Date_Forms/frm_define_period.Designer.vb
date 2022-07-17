<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_define_period
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Cmb_Considration = New System.Windows.Forms.ComboBox()
        Me.SelectdoctorforGroupSickBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Personal = New Clinic.ds_Personal()
        Me.btn_Consideration = New System.Windows.Forms.Button()
        Me.txt_date_Considration = New HM_FarsiCalendar.HM_FarsiCalendar()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgv = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePeriodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimePeriodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShapePeriodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectPeriodByDateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Period = New Clinic.ds_Period()
        Me.btnShowPeriodAll = New System.Windows.Forms.Button()
        Me.btnShowPeriodToday = New System.Windows.Forms.Button()
        Me.btnShowPeriodTomorrow = New System.Windows.Forms.Button()
        Me.gp = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txt_Insert_Time = New System.Windows.Forms.MaskedTextBox()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txt_inseret_Date = New HM_FarsiCalendar.HM_FarsiCalendar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_insert_doctor = New System.Windows.Forms.ComboBox()
        Me.rb_insert_Tel = New System.Windows.Forms.RadioButton()
        Me.rb_insert_absent = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_Insert = New DevComponents.DotNetBar.ButtonX()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gp_attributes = New System.Windows.Forms.GroupBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.dgv_attribiutes = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_showAttributes = New DevComponents.DotNetBar.ButtonX()
        Me.btn_SearchFile = New System.Windows.Forms.Label()
        Me.txt_CodeFile = New TextualControl.TextualControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmb_groupSick = New System.Windows.Forms.ComboBox()
        Me.SelectGroupSickfordoctorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_GroupSick = New Clinic.ds_GroupSick()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmb_doctors = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnInsertFile = New DevComponents.DotNetBar.ButtonX()
        Me.txt_mobile = New TextualControl.TextualControl()
        Me.txt_l_name = New TextualControl.TextualControl()
        Me.txt_f_name = New TextualControl.TextualControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Select_doctor_for_GroupSickTableAdapter = New Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter()
        Me.Select_Period_ByDateTableAdapter = New Clinic.ds_PeriodTableAdapters.Select_Period_ByDateTableAdapter()
        Me.Select_GroupSick_for_doctorTableAdapter = New Clinic.ds_GroupSickTableAdapters.Select_GroupSick_for_doctorTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectPeriodByDateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Period, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gp.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gp_attributes.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_attribiutes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SelectGroupSickfordoctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_GroupSick, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Location = New System.Drawing.Point(12, 549)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "خروج"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Cmb_Considration)
        Me.GroupBox1.Controls.Add(Me.btn_Consideration)
        Me.GroupBox1.Controls.Add(Me.txt_date_Considration)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dgv)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 540)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بررسی تاریخ نوبت درخواستی"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(259, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "پزشک معالج:"
        '
        'Cmb_Considration
        '
        Me.Cmb_Considration.DataSource = Me.SelectdoctorforGroupSickBindingSource
        Me.Cmb_Considration.DisplayMember = "Doctor_Name"
        Me.Cmb_Considration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Considration.FormattingEnabled = True
        Me.Cmb_Considration.Location = New System.Drawing.Point(55, 64)
        Me.Cmb_Considration.Name = "Cmb_Considration"
        Me.Cmb_Considration.Size = New System.Drawing.Size(182, 21)
        Me.Cmb_Considration.TabIndex = 19
        Me.Cmb_Considration.ValueMember = "id"
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
        'btn_Consideration
        '
        Me.btn_Consideration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Consideration.Location = New System.Drawing.Point(7, 96)
        Me.btn_Consideration.Name = "btn_Consideration"
        Me.btn_Consideration.Size = New System.Drawing.Size(394, 23)
        Me.btn_Consideration.TabIndex = 18
        Me.btn_Consideration.Text = "بررسی ..."
        Me.btn_Consideration.UseVisualStyleBackColor = True
        '
        'txt_date_Considration
        '
        Me.txt_date_Considration.BodyBackColor = System.Drawing.Color.White
        Me.txt_date_Considration.BodyForeColor = System.Drawing.Color.Black
        Me.txt_date_Considration.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_date_Considration.HeaderBackColor = System.Drawing.Color.Gray
        Me.txt_date_Considration.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txt_date_Considration.HeaderForeColor = System.Drawing.Color.White
        Me.txt_date_Considration.Location = New System.Drawing.Point(112, 37)
        Me.txt_date_Considration.Max_Date = "1400/12/30"
        Me.txt_date_Considration.Min_Date = "1350/01/01"
        Me.txt_date_Considration.Name = "txt_date_Considration"
        Me.txt_date_Considration.SelectedBackColor = System.Drawing.Color.Blue
        Me.txt_date_Considration.SelectedForeColor = System.Drawing.Color.White
        Me.txt_date_Considration.Size = New System.Drawing.Size(125, 21)
        Me.txt_date_Considration.TabIndex = 17
        Me.txt_date_Considration.TitleFont = New System.Drawing.Font("Tahoma", 8.25!)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(243, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "تاریخ نوبت درخواستی:"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DatePeriodDataGridViewTextBoxColumn, Me.TimePeriodDataGridViewTextBoxColumn, Me.ShapePeriodDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.SelectPeriodByDateBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(7, 124)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(394, 410)
        Me.dgv.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'DatePeriodDataGridViewTextBoxColumn
        '
        Me.DatePeriodDataGridViewTextBoxColumn.DataPropertyName = "Date_Period"
        Me.DatePeriodDataGridViewTextBoxColumn.HeaderText = "تاریخ نوبت"
        Me.DatePeriodDataGridViewTextBoxColumn.Name = "DatePeriodDataGridViewTextBoxColumn"
        Me.DatePeriodDataGridViewTextBoxColumn.ReadOnly = True
        Me.DatePeriodDataGridViewTextBoxColumn.Width = 150
        '
        'TimePeriodDataGridViewTextBoxColumn
        '
        Me.TimePeriodDataGridViewTextBoxColumn.DataPropertyName = "Time_Period"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TimePeriodDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.TimePeriodDataGridViewTextBoxColumn.HeaderText = "زمان نوبت"
        Me.TimePeriodDataGridViewTextBoxColumn.Name = "TimePeriodDataGridViewTextBoxColumn"
        Me.TimePeriodDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShapePeriodDataGridViewTextBoxColumn
        '
        Me.ShapePeriodDataGridViewTextBoxColumn.DataPropertyName = "Shape_Period"
        Me.ShapePeriodDataGridViewTextBoxColumn.HeaderText = "وضعیت نوبت"
        Me.ShapePeriodDataGridViewTextBoxColumn.Name = "ShapePeriodDataGridViewTextBoxColumn"
        Me.ShapePeriodDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SelectPeriodByDateBindingSource
        '
        Me.SelectPeriodByDateBindingSource.DataMember = "Select_Period_ByDate"
        Me.SelectPeriodByDateBindingSource.DataSource = Me.Ds_Period
        '
        'Ds_Period
        '
        Me.Ds_Period.DataSetName = "ds_Period"
        Me.Ds_Period.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnShowPeriodAll
        '
        Me.btnShowPeriodAll.Location = New System.Drawing.Point(430, 549)
        Me.btnShowPeriodAll.Name = "btnShowPeriodAll"
        Me.btnShowPeriodAll.Size = New System.Drawing.Size(144, 23)
        Me.btnShowPeriodAll.TabIndex = 2
        Me.btnShowPeriodAll.Text = "لیست نوبت ها"
        Me.btnShowPeriodAll.UseVisualStyleBackColor = True
        '
        'btnShowPeriodToday
        '
        Me.btnShowPeriodToday.Location = New System.Drawing.Point(745, 549)
        Me.btnShowPeriodToday.Name = "btnShowPeriodToday"
        Me.btnShowPeriodToday.Size = New System.Drawing.Size(159, 23)
        Me.btnShowPeriodToday.TabIndex = 3
        Me.btnShowPeriodToday.Text = "لیست نوبت های امروز "
        Me.btnShowPeriodToday.UseVisualStyleBackColor = True
        '
        'btnShowPeriodTomorrow
        '
        Me.btnShowPeriodTomorrow.Location = New System.Drawing.Point(580, 549)
        Me.btnShowPeriodTomorrow.Name = "btnShowPeriodTomorrow"
        Me.btnShowPeriodTomorrow.Size = New System.Drawing.Size(159, 23)
        Me.btnShowPeriodTomorrow.TabIndex = 4
        Me.btnShowPeriodTomorrow.Text = "لیست نوبت های فردا"
        Me.btnShowPeriodTomorrow.UseVisualStyleBackColor = True
        '
        'gp
        '
        Me.gp.Controls.Add(Me.Label11)
        Me.gp.Controls.Add(Me.Label8)
        Me.gp.Controls.Add(Me.GroupPanel2)
        Me.gp.Controls.Add(Me.GroupPanel1)
        Me.gp.Controls.Add(Me.Label7)
        Me.gp.Controls.Add(Me.cmb_insert_doctor)
        Me.gp.Controls.Add(Me.rb_insert_Tel)
        Me.gp.Controls.Add(Me.rb_insert_absent)
        Me.gp.Controls.Add(Me.Label6)
        Me.gp.Controls.Add(Me.btn_Insert)
        Me.gp.Enabled = False
        Me.gp.Location = New System.Drawing.Point(418, 229)
        Me.gp.Name = "gp"
        Me.gp.Size = New System.Drawing.Size(493, 314)
        Me.gp.TabIndex = 5
        Me.gp.TabStop = False
        Me.gp.Text = "ثبت نوبت جدید"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(56, 205)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(387, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "** دقت کنید که زمان بصورت دستی وارد می شود، بنابراین به تداخل ها دقت کنید **"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(241, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "و"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.txt_Insert_Time)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(26, 97)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(209, 102)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 17
        Me.GroupPanel2.Text = "ساعت نوبت"
        '
        'txt_Insert_Time
        '
        Me.txt_Insert_Time.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_Insert_Time.Location = New System.Drawing.Point(50, 25)
        Me.txt_Insert_Time.Mask = "00:00"
        Me.txt_Insert_Time.Name = "txt_Insert_Time"
        Me.txt_Insert_Time.Size = New System.Drawing.Size(100, 30)
        Me.txt_Insert_Time.TabIndex = 15
        Me.txt_Insert_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.txt_inseret_Date)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(258, 97)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(209, 102)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 16
        Me.GroupPanel1.Text = "تاریخ نوبت"
        '
        'txt_inseret_Date
        '
        Me.txt_inseret_Date.BodyBackColor = System.Drawing.Color.White
        Me.txt_inseret_Date.BodyForeColor = System.Drawing.Color.Black
        Me.txt_inseret_Date.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_inseret_Date.HeaderBackColor = System.Drawing.Color.Gray
        Me.txt_inseret_Date.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txt_inseret_Date.HeaderForeColor = System.Drawing.Color.White
        Me.txt_inseret_Date.Location = New System.Drawing.Point(37, 25)
        Me.txt_inseret_Date.Max_Date = "1400/12/30"
        Me.txt_inseret_Date.Min_Date = "1350/01/01"
        Me.txt_inseret_Date.Name = "txt_inseret_Date"
        Me.txt_inseret_Date.SelectedBackColor = System.Drawing.Color.Blue
        Me.txt_inseret_Date.SelectedForeColor = System.Drawing.Color.White
        Me.txt_inseret_Date.Size = New System.Drawing.Size(125, 30)
        Me.txt_inseret_Date.TabIndex = 13
        Me.txt_inseret_Date.TitleFont = New System.Drawing.Font("Tahoma", 8.25!)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(401, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "پزشک معالج:"
        '
        'cmb_insert_doctor
        '
        Me.cmb_insert_doctor.DataSource = Me.SelectdoctorforGroupSickBindingSource
        Me.cmb_insert_doctor.DisplayMember = "Doctor_Name"
        Me.cmb_insert_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_insert_doctor.FormattingEnabled = True
        Me.cmb_insert_doctor.Location = New System.Drawing.Point(197, 60)
        Me.cmb_insert_doctor.Name = "cmb_insert_doctor"
        Me.cmb_insert_doctor.Size = New System.Drawing.Size(182, 21)
        Me.cmb_insert_doctor.TabIndex = 10
        Me.cmb_insert_doctor.ValueMember = "id"
        '
        'rb_insert_Tel
        '
        Me.rb_insert_Tel.AutoSize = True
        Me.rb_insert_Tel.Checked = True
        Me.rb_insert_Tel.Location = New System.Drawing.Point(326, 27)
        Me.rb_insert_Tel.Name = "rb_insert_Tel"
        Me.rb_insert_Tel.Size = New System.Drawing.Size(53, 17)
        Me.rb_insert_Tel.TabIndex = 9
        Me.rb_insert_Tel.TabStop = True
        Me.rb_insert_Tel.Text = "تلفنی"
        Me.rb_insert_Tel.UseVisualStyleBackColor = True
        '
        'rb_insert_absent
        '
        Me.rb_insert_absent.AutoSize = True
        Me.rb_insert_absent.Location = New System.Drawing.Point(252, 25)
        Me.rb_insert_absent.Name = "rb_insert_absent"
        Me.rb_insert_absent.Size = New System.Drawing.Size(60, 17)
        Me.rb_insert_absent.TabIndex = 8
        Me.rb_insert_absent.Text = "حضوری"
        Me.rb_insert_absent.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(401, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "روش نوبت:"
        '
        'btn_Insert
        '
        Me.btn_Insert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Insert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Insert.Location = New System.Drawing.Point(12, 282)
        Me.btn_Insert.Name = "btn_Insert"
        Me.btn_Insert.Size = New System.Drawing.Size(474, 23)
        Me.btn_Insert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Insert.TabIndex = 6
        Me.btn_Insert.Text = "ذخیره سازی"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Location = New System.Drawing.Point(418, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.RightToLeftLayout = True
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(493, 211)
        Me.TabControl.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gp_attributes)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(485, 185)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "دارای پرونده"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gp_attributes
        '
        Me.gp_attributes.Controls.Add(Me.PictureBox)
        Me.gp_attributes.Controls.Add(Me.dgv_attribiutes)
        Me.gp_attributes.Enabled = False
        Me.gp_attributes.Location = New System.Drawing.Point(6, 6)
        Me.gp_attributes.Name = "gp_attributes"
        Me.gp_attributes.Size = New System.Drawing.Size(327, 217)
        Me.gp_attributes.TabIndex = 9
        Me.gp_attributes.TabStop = False
        Me.gp_attributes.Text = "مشخصات بیمار"
        '
        'PictureBox
        '
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox.Location = New System.Drawing.Point(248, 18)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(76, 88)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 6
        Me.PictureBox.TabStop = False
        '
        'dgv_attribiutes
        '
        Me.dgv_attribiutes.BackgroundColor = System.Drawing.Color.White
        Me.dgv_attribiutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_attribiutes.ColumnHeadersVisible = False
        Me.dgv_attribiutes.Location = New System.Drawing.Point(6, 18)
        Me.dgv_attribiutes.Name = "dgv_attribiutes"
        Me.dgv_attribiutes.RowHeadersVisible = False
        Me.dgv_attribiutes.Size = New System.Drawing.Size(239, 155)
        Me.dgv_attribiutes.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_showAttributes)
        Me.GroupBox3.Controls.Add(Me.btn_SearchFile)
        Me.GroupBox3.Controls.Add(Me.txt_CodeFile)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(344, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(132, 119)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "بیمار"
        '
        'btn_showAttributes
        '
        Me.btn_showAttributes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_showAttributes.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_showAttributes.Location = New System.Drawing.Point(7, 87)
        Me.btn_showAttributes.Name = "btn_showAttributes"
        Me.btn_showAttributes.Size = New System.Drawing.Size(75, 28)
        Me.btn_showAttributes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_showAttributes.TabIndex = 5
        Me.btn_showAttributes.Text = ">>>>>"
        '
        'btn_SearchFile
        '
        Me.btn_SearchFile.AutoSize = True
        Me.btn_SearchFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SearchFile.ForeColor = System.Drawing.Color.Blue
        Me.btn_SearchFile.Location = New System.Drawing.Point(7, 69)
        Me.btn_SearchFile.Name = "btn_SearchFile"
        Me.btn_SearchFile.Size = New System.Drawing.Size(116, 13)
        Me.btn_SearchFile.TabIndex = 2
        Me.btn_SearchFile.Text = "( جستجو شماره پرونده)"
        '
        'txt_CodeFile
        '
        Me.txt_CodeFile.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_CodeFile.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_CodeFile.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_CodeFile.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_CodeFile.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_CodeFile.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_CodeFile.__NextFocuse = False
        Me.txt_CodeFile.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_CodeFile.__Type = TextualControl.TextualControl.No.Numeric
        Me.txt_CodeFile.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_CodeFile.Location = New System.Drawing.Point(7, 36)
        Me.txt_CodeFile.Name = "txt_CodeFile"
        Me.txt_CodeFile.Size = New System.Drawing.Size(113, 30)
        Me.txt_CodeFile.TabIndex = 1
        Me.txt_CodeFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شماره پرونده:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmb_groupSick)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.cmb_doctors)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.btnInsertFile)
        Me.TabPage2.Controls.Add(Me.txt_mobile)
        Me.TabPage2.Controls.Add(Me.txt_l_name)
        Me.TabPage2.Controls.Add(Me.txt_f_name)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(485, 185)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "بدون پرونده"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmb_groupSick
        '
        Me.cmb_groupSick.DataSource = Me.SelectGroupSickfordoctorBindingSource
        Me.cmb_groupSick.DisplayMember = "Name"
        Me.cmb_groupSick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_groupSick.FormattingEnabled = True
        Me.cmb_groupSick.Location = New System.Drawing.Point(219, 133)
        Me.cmb_groupSick.Name = "cmb_groupSick"
        Me.cmb_groupSick.Size = New System.Drawing.Size(161, 21)
        Me.cmb_groupSick.TabIndex = 57
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
        Me.Label15.Location = New System.Drawing.Point(386, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 13)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "گروه بیمار:"
        '
        'cmb_doctors
        '
        Me.cmb_doctors.DataSource = Me.SelectdoctorforGroupSickBindingSource
        Me.cmb_doctors.DisplayMember = "Doctor_Name"
        Me.cmb_doctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_doctors.FormattingEnabled = True
        Me.cmb_doctors.Location = New System.Drawing.Point(219, 103)
        Me.cmb_doctors.Name = "cmb_doctors"
        Me.cmb_doctors.Size = New System.Drawing.Size(161, 21)
        Me.cmb_doctors.TabIndex = 55
        Me.cmb_doctors.ValueMember = "id"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(385, 107)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 13)
        Me.Label20.TabIndex = 54
        Me.Label20.Text = "پزشک معالج:"
        '
        'btnInsertFile
        '
        Me.btnInsertFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnInsertFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnInsertFile.Location = New System.Drawing.Point(22, 15)
        Me.btnInsertFile.Name = "btnInsertFile"
        Me.btnInsertFile.Size = New System.Drawing.Size(80, 139)
        Me.btnInsertFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnInsertFile.TabIndex = 7
        Me.btnInsertFile.Text = "ثبت پرونده"
        '
        'txt_mobile
        '
        Me.txt_mobile.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_mobile.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_mobile.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_mobile.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_mobile.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_mobile.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_mobile.__NextFocuse = True
        Me.txt_mobile.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_mobile.__Type = TextualControl.TextualControl.No.Numeric
        Me.txt_mobile.Location = New System.Drawing.Point(219, 74)
        Me.txt_mobile.Name = "txt_mobile"
        Me.txt_mobile.Size = New System.Drawing.Size(161, 21)
        Me.txt_mobile.TabIndex = 6
        '
        'txt_l_name
        '
        Me.txt_l_name.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_l_name.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_l_name.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_l_name.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_l_name.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_l_name.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_l_name.__NextFocuse = True
        Me.txt_l_name.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_l_name.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_l_name.Location = New System.Drawing.Point(219, 46)
        Me.txt_l_name.Name = "txt_l_name"
        Me.txt_l_name.Size = New System.Drawing.Size(161, 21)
        Me.txt_l_name.TabIndex = 5
        '
        'txt_f_name
        '
        Me.txt_f_name.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_f_name.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_f_name.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_f_name.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_f_name.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_f_name.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_f_name.__NextFocuse = True
        Me.txt_f_name.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_f_name.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_f_name.Location = New System.Drawing.Point(219, 15)
        Me.txt_f_name.Name = "txt_f_name"
        Me.txt_f_name.Size = New System.Drawing.Size(161, 21)
        Me.txt_f_name.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(397, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "شماره موبایل:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(397, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "نام خانوادگی:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(397, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "نام:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(11, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(468, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "** در این مرحله به جهت سهولت در نوبت دهی، مشخصات کلیدی برای ایجاد پرونده گرفته می" & _
            " شود **"
        '
        'Select_doctor_for_GroupSickTableAdapter
        '
        Me.Select_doctor_for_GroupSickTableAdapter.ClearBeforeFill = True
        '
        'Select_Period_ByDateTableAdapter
        '
        Me.Select_Period_ByDateTableAdapter.ClearBeforeFill = True
        '
        'Select_GroupSick_for_doctorTableAdapter
        '
        Me.Select_GroupSick_for_doctorTableAdapter.ClearBeforeFill = True
        '
        'frm_define_period
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.gp)
        Me.Controls.Add(Me.btnShowPeriodTomorrow)
        Me.Controls.Add(Me.btnShowPeriodToday)
        Me.Controls.Add(Me.btnShowPeriodAll)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_define_period"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نوبت دهی"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectPeriodByDateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Period, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gp.ResumeLayout(False)
        Me.gp.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gp_attributes.ResumeLayout(False)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_attribiutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.SelectGroupSickfordoctorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_GroupSick, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnShowPeriodAll As System.Windows.Forms.Button
    Friend WithEvents btnShowPeriodToday As System.Windows.Forms.Button
    Friend WithEvents btnShowPeriodTomorrow As System.Windows.Forms.Button
    Friend WithEvents gp As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Insert As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents gp_attributes As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents dgv_attribiutes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_showAttributes As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_SearchFile As System.Windows.Forms.Label
    Friend WithEvents txt_CodeFile As TextualControl.TextualControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txt_mobile As TextualControl.TextualControl
    Friend WithEvents txt_l_name As TextualControl.TextualControl
    Friend WithEvents txt_f_name As TextualControl.TextualControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_insert_doctor As System.Windows.Forms.ComboBox
    Friend WithEvents rb_insert_Tel As System.Windows.Forms.RadioButton
    Friend WithEvents rb_insert_absent As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnInsertFile As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_inseret_Date As HM_FarsiCalendar.HM_FarsiCalendar
    Friend WithEvents txt_date_Considration As HM_FarsiCalendar.HM_FarsiCalendar
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_Insert_Time As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btn_Consideration As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Cmb_Considration As System.Windows.Forms.ComboBox
    Friend WithEvents SelectPeriodByDateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Period As Clinic.ds_Period
    Friend WithEvents Select_Period_ByDateTableAdapter As Clinic.ds_PeriodTableAdapters.Select_Period_ByDateTableAdapter
    Friend WithEvents Ds_Personal As Clinic.ds_Personal
    Friend WithEvents SelectdoctorforGroupSickBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Select_doctor_for_GroupSickTableAdapter As Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatePeriodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimePeriodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShapePeriodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmb_doctors As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmb_groupSick As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents SelectGroupSickfordoctorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_GroupSick As Clinic.ds_GroupSick
    Friend WithEvents Select_GroupSick_for_doctorTableAdapter As Clinic.ds_GroupSickTableAdapters.Select_GroupSick_for_doctorTableAdapter
End Class
