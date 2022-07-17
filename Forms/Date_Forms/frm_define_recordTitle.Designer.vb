<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_define_recordTitle
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmd_doctor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Insert = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Cancel = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Delete = New DevComponents.DotNetBar.ButtonX()
        Me.dgv = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPersonalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IduserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDoctorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectRecordTitleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_RecordTitle = New Clinic.ds_RecordTitle()
        Me.Select_RecordTitleTableAdapter = New Clinic.ds_RecordTitleTableAdapters.Select_RecordTitleTableAdapter()
        Me.Ds_Personal = New Clinic.ds_Personal()
        Me.SelectdoctorforGroupSickBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Select_doctor_for_GroupSickTableAdapter = New Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter()
        Me.txt_RecordTitle = New TextualControl.TextualControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectRecordTitleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_RecordTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_RecordTitle)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmd_doctor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_Insert)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 101)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اضافه کردن عناوین سوابق"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(394, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "پزشک:"
        '
        'cmd_doctor
        '
        Me.cmd_doctor.DataSource = Me.SelectdoctorforGroupSickBindingSource
        Me.cmd_doctor.DisplayMember = "Doctor_Name"
        Me.cmd_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmd_doctor.FormattingEnabled = True
        Me.cmd_doctor.Location = New System.Drawing.Point(6, 47)
        Me.cmd_doctor.Name = "cmd_doctor"
        Me.cmd_doctor.Size = New System.Drawing.Size(382, 21)
        Me.cmd_doctor.TabIndex = 12
        Me.cmd_doctor.ValueMember = "Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(394, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "عنوان:"
        '
        'btn_Insert
        '
        Me.btn_Insert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Insert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Insert.Location = New System.Drawing.Point(6, 73)
        Me.btn_Insert.Name = "btn_Insert"
        Me.btn_Insert.Size = New System.Drawing.Size(87, 23)
        Me.btn_Insert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Insert.TabIndex = 9
        Me.btn_Insert.Text = "اضافه کردن"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Cancel.Location = New System.Drawing.Point(350, 436)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(108, 23)
        Me.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Cancel.TabIndex = 12
        Me.btn_Cancel.Text = "خروج"
        '
        'btn_Delete
        '
        Me.btn_Delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Delete.Location = New System.Drawing.Point(13, 436)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(45, 23)
        Me.btn_Delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Delete.TabIndex = 11
        Me.btn_Delete.Text = "حذف "
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdPersonalDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.IduserDataGridViewTextBoxColumn, Me.NameDoctorDataGridViewTextBoxColumn, Me.NameUserDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.SelectRecordTitleBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(13, 113)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.ShowCellErrors = False
        Me.dgv.ShowCellToolTips = False
        Me.dgv.ShowEditingIcon = False
        Me.dgv.ShowRowErrors = False
        Me.dgv.Size = New System.Drawing.Size(445, 317)
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
        'IdPersonalDataGridViewTextBoxColumn
        '
        Me.IdPersonalDataGridViewTextBoxColumn.DataPropertyName = "Id_Personal"
        Me.IdPersonalDataGridViewTextBoxColumn.HeaderText = "Id_Personal"
        Me.IdPersonalDataGridViewTextBoxColumn.Name = "IdPersonalDataGridViewTextBoxColumn"
        Me.IdPersonalDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPersonalDataGridViewTextBoxColumn.Visible = False
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "عنوان"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitleDataGridViewTextBoxColumn.Width = 200
        '
        'IduserDataGridViewTextBoxColumn
        '
        Me.IduserDataGridViewTextBoxColumn.DataPropertyName = "Id_user"
        Me.IduserDataGridViewTextBoxColumn.HeaderText = "Id_user"
        Me.IduserDataGridViewTextBoxColumn.Name = "IduserDataGridViewTextBoxColumn"
        Me.IduserDataGridViewTextBoxColumn.ReadOnly = True
        Me.IduserDataGridViewTextBoxColumn.Visible = False
        '
        'NameDoctorDataGridViewTextBoxColumn
        '
        Me.NameDoctorDataGridViewTextBoxColumn.DataPropertyName = "Name_Doctor"
        Me.NameDoctorDataGridViewTextBoxColumn.HeaderText = "پزشک"
        Me.NameDoctorDataGridViewTextBoxColumn.Name = "NameDoctorDataGridViewTextBoxColumn"
        Me.NameDoctorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameUserDataGridViewTextBoxColumn
        '
        Me.NameUserDataGridViewTextBoxColumn.DataPropertyName = "Name_User"
        Me.NameUserDataGridViewTextBoxColumn.HeaderText = "کاربر"
        Me.NameUserDataGridViewTextBoxColumn.Name = "NameUserDataGridViewTextBoxColumn"
        Me.NameUserDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SelectRecordTitleBindingSource
        '
        Me.SelectRecordTitleBindingSource.DataMember = "Select_RecordTitle"
        Me.SelectRecordTitleBindingSource.DataSource = Me.Ds_RecordTitle
        '
        'Ds_RecordTitle
        '
        Me.Ds_RecordTitle.DataSetName = "ds_RecordTitle"
        Me.Ds_RecordTitle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Select_RecordTitleTableAdapter
        '
        Me.Select_RecordTitleTableAdapter.ClearBeforeFill = True
        '
        'Ds_Personal
        '
        Me.Ds_Personal.DataSetName = "ds_Personal"
        Me.Ds_Personal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SelectdoctorforGroupSickBindingSource
        '
        Me.SelectdoctorforGroupSickBindingSource.DataMember = "Select_doctor_for_GroupSick"
        Me.SelectdoctorforGroupSickBindingSource.DataSource = Me.Ds_Personal
        '
        'Select_doctor_for_GroupSickTableAdapter
        '
        Me.Select_doctor_for_GroupSickTableAdapter.ClearBeforeFill = True
        '
        'txt_RecordTitle
        '
        Me.txt_RecordTitle.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_RecordTitle.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_RecordTitle.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_RecordTitle.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_RecordTitle.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_RecordTitle.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_RecordTitle.__NextFocuse = True
        Me.txt_RecordTitle.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_RecordTitle.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_RecordTitle.Location = New System.Drawing.Point(6, 20)
        Me.txt_RecordTitle.Name = "txt_RecordTitle"
        Me.txt_RecordTitle.Size = New System.Drawing.Size(382, 21)
        Me.txt_RecordTitle.TabIndex = 14
        '
        'frm_define_recordTitle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 465)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.dgv)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_define_recordTitle"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تعریف سوابق "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectRecordTitleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_RecordTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Delete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgv As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmd_doctor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Insert As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Ds_RecordTitle As Clinic.ds_RecordTitle
    Friend WithEvents SelectRecordTitleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Select_RecordTitleTableAdapter As Clinic.ds_RecordTitleTableAdapters.Select_RecordTitleTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPersonalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IduserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDoctorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameUserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ds_Personal As Clinic.ds_Personal
    Friend WithEvents SelectdoctorforGroupSickBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Select_doctor_for_GroupSickTableAdapter As Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter
    Friend WithEvents txt_RecordTitle As TextualControl.TextualControl
End Class
