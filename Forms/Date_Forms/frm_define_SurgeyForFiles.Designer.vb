<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_define_SurgeyForFiles
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_showAttributes = New DevComponents.DotNetBar.ButtonX()
        Me.btn_SearchFile = New System.Windows.Forms.Label()
        Me.txt_CodeFile = New TextualControl.TextualControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gp_attributes = New System.Windows.Forms.GroupBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.dgv_attribiutes = New System.Windows.Forms.DataGridView()
        Me.gp_insert_Surgey = New System.Windows.Forms.GroupBox()
        Me.txt_insert_detail = New System.Windows.Forms.TextBox()
        Me.txt_insert_date = New HM_FarsiCalendar.HM_FarsiCalendar()
        Me.btn_insert = New DevComponents.DotNetBar.ButtonX()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_insert_title = New TextualControl.TextualControl()
        Me.gp_list_surgey = New System.Windows.Forms.GroupBox()
        Me.dgv_list = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdFileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.عنوانDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.تاریخجراحیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.وضعیتجراحیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.توضیحاتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.تاریخنهاییDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.نتیجهجراحیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectSurgeryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Surgery = New Clinic.ds_Surgery()
        Me.btn_Close = New DevComponents.DotNetBar.ButtonX()
        Me.gp_DetailSurgery = New System.Windows.Forms.GroupBox()
        Me.txt_result = New System.Windows.Forms.TextBox()
        Me.txt_detail_done = New System.Windows.Forms.TextBox()
        Me.btn_Delete = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_dateDone = New HM_FarsiCalendar.HM_FarsiCalendar()
        Me.btn_update = New DevComponents.DotNetBar.ButtonX()
        Me.rb_OK = New System.Windows.Forms.RadioButton()
        Me.rb_NOK = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_DateSurgery = New System.Windows.Forms.Label()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Select_SurgeryTableAdapter = New Clinic.ds_SurgeryTableAdapters.Select_SurgeryTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.gp_attributes.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_attribiutes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gp_insert_Surgey.SuspendLayout()
        Me.gp_list_surgey.SuspendLayout()
        CType(Me.dgv_list, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectSurgeryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Surgery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gp_DetailSurgery.SuspendLayout()
        CType(Me.btn_Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_showAttributes)
        Me.GroupBox1.Controls.Add(Me.btn_SearchFile)
        Me.GroupBox1.Controls.Add(Me.txt_CodeFile)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(132, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بیمار"
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
        'gp_attributes
        '
        Me.gp_attributes.Controls.Add(Me.PictureBox)
        Me.gp_attributes.Controls.Add(Me.dgv_attribiutes)
        Me.gp_attributes.Enabled = False
        Me.gp_attributes.Location = New System.Drawing.Point(143, 2)
        Me.gp_attributes.Name = "gp_attributes"
        Me.gp_attributes.Size = New System.Drawing.Size(327, 119)
        Me.gp_attributes.TabIndex = 1
        Me.gp_attributes.TabStop = False
        Me.gp_attributes.Text = "مشخصات بیمار"
        '
        'PictureBox
        '
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox.Location = New System.Drawing.Point(248, 18)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(76, 95)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 6
        Me.PictureBox.TabStop = False
        '
        'dgv_attribiutes
        '
        Me.dgv_attribiutes.BackgroundColor = System.Drawing.Color.White
        Me.dgv_attribiutes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        'Me.dgv_attribiutes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Custom
        Me.dgv_attribiutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_attribiutes.ColumnHeadersVisible = False
        Me.dgv_attribiutes.GridColor = System.Drawing.Color.Silver
        Me.dgv_attribiutes.Location = New System.Drawing.Point(6, 18)
        Me.dgv_attribiutes.Name = "dgv_attribiutes"
        Me.dgv_attribiutes.ReadOnly = True
        Me.dgv_attribiutes.RowHeadersVisible = False
        Me.dgv_attribiutes.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgv_attribiutes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_attribiutes.Size = New System.Drawing.Size(239, 95)
        Me.dgv_attribiutes.TabIndex = 7
        '
        'gp_insert_Surgey
        '
        Me.gp_insert_Surgey.Controls.Add(Me.txt_insert_detail)
        Me.gp_insert_Surgey.Controls.Add(Me.txt_insert_date)
        Me.gp_insert_Surgey.Controls.Add(Me.btn_insert)
        Me.gp_insert_Surgey.Controls.Add(Me.Label8)
        Me.gp_insert_Surgey.Controls.Add(Me.Label3)
        Me.gp_insert_Surgey.Controls.Add(Me.Label2)
        Me.gp_insert_Surgey.Controls.Add(Me.txt_insert_title)
        Me.gp_insert_Surgey.Enabled = False
        Me.gp_insert_Surgey.Location = New System.Drawing.Point(479, 2)
        Me.gp_insert_Surgey.Name = "gp_insert_Surgey"
        Me.gp_insert_Surgey.Size = New System.Drawing.Size(456, 119)
        Me.gp_insert_Surgey.TabIndex = 2
        Me.gp_insert_Surgey.TabStop = False
        Me.gp_insert_Surgey.Text = "ثبت جراحی"
        '
        'txt_insert_detail
        '
        Me.txt_insert_detail.Location = New System.Drawing.Point(89, 44)
        Me.txt_insert_detail.Multiline = True
        Me.txt_insert_detail.Name = "txt_insert_detail"
        Me.txt_insert_detail.Size = New System.Drawing.Size(306, 62)
        Me.txt_insert_detail.TabIndex = 47
        '
        'txt_insert_date
        '
        Me.txt_insert_date.BodyBackColor = System.Drawing.Color.White
        Me.txt_insert_date.BodyForeColor = System.Drawing.Color.Black
        Me.txt_insert_date.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_insert_date.HeaderBackColor = System.Drawing.Color.Gray
        Me.txt_insert_date.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txt_insert_date.HeaderForeColor = System.Drawing.Color.White
        Me.txt_insert_date.Location = New System.Drawing.Point(7, 17)
        Me.txt_insert_date.Max_Date = "1400/12/30"
        Me.txt_insert_date.Min_Date = "1350/01/01"
        Me.txt_insert_date.Name = "txt_insert_date"
        Me.txt_insert_date.SelectedBackColor = System.Drawing.Color.Blue
        Me.txt_insert_date.SelectedForeColor = System.Drawing.Color.White
        Me.txt_insert_date.Size = New System.Drawing.Size(125, 21)
        Me.txt_insert_date.TabIndex = 46
        Me.txt_insert_date.TitleFont = New System.Drawing.Font("Tahoma", 8.25!)
        '
        'btn_insert
        '
        Me.btn_insert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_insert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_insert.Location = New System.Drawing.Point(8, 44)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(75, 62)
        Me.btn_insert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_insert.TabIndex = 44
        Me.btn_insert.Text = "ذخیره سازی"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(401, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "توضیحات:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "تاریخ جراحی:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(415, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "عنوان:"
        '
        'txt_insert_title
        '
        Me.txt_insert_title.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_insert_title.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_insert_title.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_insert_title.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_insert_title.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_insert_title.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_insert_title.__NextFocuse = True
        Me.txt_insert_title.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_insert_title.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_insert_title.Location = New System.Drawing.Point(228, 17)
        Me.txt_insert_title.Name = "txt_insert_title"
        Me.txt_insert_title.Size = New System.Drawing.Size(169, 21)
        Me.txt_insert_title.TabIndex = 0
        '
        'gp_list_surgey
        '
        Me.gp_list_surgey.Controls.Add(Me.dgv_list)
        Me.gp_list_surgey.Enabled = False
        Me.gp_list_surgey.Location = New System.Drawing.Point(476, 127)
        Me.gp_list_surgey.Name = "gp_list_surgey"
        Me.gp_list_surgey.Size = New System.Drawing.Size(459, 426)
        Me.gp_list_surgey.TabIndex = 3
        Me.gp_list_surgey.TabStop = False
        Me.gp_list_surgey.Text = "لیست جراحی ها"
        '
        'dgv_list
        '
        Me.dgv_list.AllowUserToAddRows = False
        Me.dgv_list.AllowUserToDeleteRows = False
        Me.dgv_list.AutoGenerateColumns = False
        Me.dgv_list.BackgroundColor = System.Drawing.Color.White
        Me.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.IdFileDataGridViewTextBoxColumn, Me.عنوانDataGridViewTextBoxColumn, Me.تاریخجراحیDataGridViewTextBoxColumn, Me.وضعیتجراحیDataGridViewTextBoxColumn, Me.توضیحاتDataGridViewTextBoxColumn, Me.تاریخنهاییDataGridViewTextBoxColumn, Me.نتیجهجراحیDataGridViewTextBoxColumn})
        Me.dgv_list.DataSource = Me.SelectSurgeryBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_list.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_list.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgv_list.Location = New System.Drawing.Point(6, 20)
        Me.dgv_list.MultiSelect = False
        Me.dgv_list.Name = "dgv_list"
        Me.dgv_list.ReadOnly = True
        Me.dgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_list.Size = New System.Drawing.Size(447, 397)
        Me.dgv_list.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'IdFileDataGridViewTextBoxColumn
        '
        Me.IdFileDataGridViewTextBoxColumn.DataPropertyName = "Id_File"
        Me.IdFileDataGridViewTextBoxColumn.HeaderText = "Id_File"
        Me.IdFileDataGridViewTextBoxColumn.Name = "IdFileDataGridViewTextBoxColumn"
        Me.IdFileDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdFileDataGridViewTextBoxColumn.Visible = False
        '
        'عنوانDataGridViewTextBoxColumn
        '
        Me.عنوانDataGridViewTextBoxColumn.DataPropertyName = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.HeaderText = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.Name = "عنوانDataGridViewTextBoxColumn"
        Me.عنوانDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاریخجراحیDataGridViewTextBoxColumn
        '
        Me.تاریخجراحیDataGridViewTextBoxColumn.DataPropertyName = "تاریخ جراحی"
        Me.تاریخجراحیDataGridViewTextBoxColumn.HeaderText = "تاریخ جراحی"
        Me.تاریخجراحیDataGridViewTextBoxColumn.Name = "تاریخجراحیDataGridViewTextBoxColumn"
        Me.تاریخجراحیDataGridViewTextBoxColumn.ReadOnly = True
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
        'btn_Close
        '
        Me.btn_Close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Close.Location = New System.Drawing.Point(476, 559)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(459, 29)
        Me.btn_Close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Close.TabIndex = 5
        Me.btn_Close.Text = "رویت شد"
        '
        'gp_DetailSurgery
        '
        Me.gp_DetailSurgery.Controls.Add(Me.txt_result)
        Me.gp_DetailSurgery.Controls.Add(Me.txt_detail_done)
        Me.gp_DetailSurgery.Controls.Add(Me.btn_Delete)
        Me.gp_DetailSurgery.Controls.Add(Me.Label6)
        Me.gp_DetailSurgery.Controls.Add(Me.txt_dateDone)
        Me.gp_DetailSurgery.Controls.Add(Me.btn_update)
        Me.gp_DetailSurgery.Controls.Add(Me.rb_OK)
        Me.gp_DetailSurgery.Controls.Add(Me.rb_NOK)
        Me.gp_DetailSurgery.Controls.Add(Me.Label10)
        Me.gp_DetailSurgery.Controls.Add(Me.Label11)
        Me.gp_DetailSurgery.Controls.Add(Me.Label9)
        Me.gp_DetailSurgery.Controls.Add(Me.lbl_DateSurgery)
        Me.gp_DetailSurgery.Controls.Add(Me.lbl_Title)
        Me.gp_DetailSurgery.Controls.Add(Me.Label4)
        Me.gp_DetailSurgery.Controls.Add(Me.Label5)
        Me.gp_DetailSurgery.Enabled = False
        Me.gp_DetailSurgery.Location = New System.Drawing.Point(5, 127)
        Me.gp_DetailSurgery.Name = "gp_DetailSurgery"
        Me.gp_DetailSurgery.Size = New System.Drawing.Size(465, 461)
        Me.gp_DetailSurgery.TabIndex = 8
        Me.gp_DetailSurgery.TabStop = False
        Me.gp_DetailSurgery.Text = "جزییات جراحی"
        '
        'txt_result
        '
        Me.txt_result.Location = New System.Drawing.Point(6, 247)
        Me.txt_result.Multiline = True
        Me.txt_result.Name = "txt_result"
        Me.txt_result.Size = New System.Drawing.Size(361, 174)
        Me.txt_result.TabIndex = 52
        '
        'txt_detail_done
        '
        Me.txt_detail_done.Location = New System.Drawing.Point(6, 83)
        Me.txt_detail_done.Multiline = True
        Me.txt_detail_done.Name = "txt_detail_done"
        Me.txt_detail_done.Size = New System.Drawing.Size(372, 99)
        Me.txt_detail_done.TabIndex = 51
        '
        'btn_Delete
        '
        Me.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Delete.Image = Global.Clinic.My.Resources.Resources.delete
        Me.btn_Delete.Location = New System.Drawing.Point(87, 433)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(24, 22)
        Me.btn_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Delete.TabIndex = 50
        Me.btn_Delete.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(405, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "توضیحات:"
        '
        'txt_dateDone
        '
        Me.txt_dateDone.BodyBackColor = System.Drawing.Color.White
        Me.txt_dateDone.BodyForeColor = System.Drawing.Color.Black
        Me.txt_dateDone.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_dateDone.HeaderBackColor = System.Drawing.Color.Gray
        Me.txt_dateDone.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txt_dateDone.HeaderForeColor = System.Drawing.Color.White
        Me.txt_dateDone.Location = New System.Drawing.Point(242, 216)
        Me.txt_dateDone.Max_Date = "1400/12/30"
        Me.txt_dateDone.Min_Date = "1350/01/01"
        Me.txt_dateDone.Name = "txt_dateDone"
        Me.txt_dateDone.SelectedBackColor = System.Drawing.Color.Blue
        Me.txt_dateDone.SelectedForeColor = System.Drawing.Color.White
        Me.txt_dateDone.Size = New System.Drawing.Size(125, 21)
        Me.txt_dateDone.TabIndex = 47
        Me.txt_dateDone.TitleFont = New System.Drawing.Font("Tahoma", 8.25!)
        '
        'btn_update
        '
        Me.btn_update.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_update.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_update.Location = New System.Drawing.Point(6, 432)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_update.TabIndex = 45
        Me.btn_update.Text = "ذخیره سازی"
        '
        'rb_OK
        '
        Me.rb_OK.AutoSize = True
        Me.rb_OK.Location = New System.Drawing.Point(205, 188)
        Me.rb_OK.Name = "rb_OK"
        Me.rb_OK.Size = New System.Drawing.Size(73, 17)
        Me.rb_OK.TabIndex = 44
        Me.rb_OK.TabStop = True
        Me.rb_OK.Text = "انجام شده"
        Me.rb_OK.UseVisualStyleBackColor = True
        '
        'rb_NOK
        '
        Me.rb_NOK.AutoSize = True
        Me.rb_NOK.Location = New System.Drawing.Point(288, 188)
        Me.rb_NOK.Name = "rb_NOK"
        Me.rb_NOK.Size = New System.Drawing.Size(77, 17)
        Me.rb_NOK.TabIndex = 43
        Me.rb_NOK.TabStop = True
        Me.rb_NOK.Text = "انجام نشده"
        Me.rb_NOK.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(388, 327)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "نتایج جراحی:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(373, 220)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "تاریخ انجام شده:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(411, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "وضعیت:"
        '
        'lbl_DateSurgery
        '
        Me.lbl_DateSurgery.AutoSize = True
        Me.lbl_DateSurgery.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_DateSurgery.ForeColor = System.Drawing.Color.Red
        Me.lbl_DateSurgery.Location = New System.Drawing.Point(10, 60)
        Me.lbl_DateSurgery.Name = "lbl_DateSurgery"
        Me.lbl_DateSurgery.Size = New System.Drawing.Size(0, 13)
        Me.lbl_DateSurgery.TabIndex = 37
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_Title.Location = New System.Drawing.Point(10, 33)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Title.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(388, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "تاریخ جراحی:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(419, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "عنوان:"
        '
        'Select_SurgeryTableAdapter
        '
        Me.Select_SurgeryTableAdapter.ClearBeforeFill = True
        '
        'frm_define_SurgeyForFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 594)
        Me.ControlBox = False
        Me.Controls.Add(Me.gp_DetailSurgery)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.gp_list_surgey)
        Me.Controls.Add(Me.gp_insert_Surgey)
        Me.Controls.Add(Me.gp_attributes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_define_SurgeyForFiles"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مدیریت عمل جراحی بیماران"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gp_attributes.ResumeLayout(False)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_attribiutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gp_insert_Surgey.ResumeLayout(False)
        Me.gp_insert_Surgey.PerformLayout()
        Me.gp_list_surgey.ResumeLayout(False)
        CType(Me.dgv_list, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectSurgeryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Surgery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gp_DetailSurgery.ResumeLayout(False)
        Me.gp_DetailSurgery.PerformLayout()
        CType(Me.btn_Delete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_SearchFile As System.Windows.Forms.Label
    Friend WithEvents txt_CodeFile As TextualControl.TextualControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_showAttributes As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gp_attributes As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents gp_insert_Surgey As System.Windows.Forms.GroupBox
    Friend WithEvents gp_list_surgey As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Close As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgv_attribiutes As System.Windows.Forms.DataGridView
    Friend WithEvents txt_insert_title As TextualControl.TextualControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgv_list As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents gp_DetailSurgery As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_DateSurgery As System.Windows.Forms.Label
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_insert As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_update As DevComponents.DotNetBar.ButtonX
    Friend WithEvents rb_OK As System.Windows.Forms.RadioButton
    Friend WithEvents rb_NOK As System.Windows.Forms.RadioButton
    Friend WithEvents txt_insert_date As HM_FarsiCalendar.HM_FarsiCalendar
    Friend WithEvents txt_dateDone As HM_FarsiCalendar.HM_FarsiCalendar
    Friend WithEvents SurgeryTitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurgeryDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DoneDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResultDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SelectSurgeryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Surgery As Clinic.ds_Surgery
    Friend WithEvents Select_SurgeryTableAdapter As Clinic.ds_SurgeryTableAdapters.Select_SurgeryTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdFileDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents عنوانDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخجراحیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents وضعیتجراحیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents توضیحاتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخنهاییDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نتیجهجراحیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_Delete As System.Windows.Forms.PictureBox
    Friend WithEvents txt_insert_detail As System.Windows.Forms.TextBox
    Friend WithEvents txt_result As System.Windows.Forms.TextBox
    Friend WithEvents txt_detail_done As System.Windows.Forms.TextBox
End Class
