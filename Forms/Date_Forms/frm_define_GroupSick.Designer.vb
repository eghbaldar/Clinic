<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_define_GroupSick
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmd_doctor = New System.Windows.Forms.ComboBox()
        Me.SelectdoctorforGroupSickBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Personal = New Clinic.ds_Personal()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Insert = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Cancel = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Delete = New DevComponents.DotNetBar.ButtonX()
        Me.dgv = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_Doctor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_personal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectGroupSickBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_GroupSick = New Clinic.ds_GroupSick()
        Me.Select_Group_SickTableAdapter = New Clinic.ds_GroupSickTableAdapters.Select_Group_SickTableAdapter()
        Me.Select_doctor_for_GroupSickTableAdapter = New Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter()
        Me.txt_Group = New TextualControl.TextualControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectGroupSickBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_GroupSick, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_Group)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmd_doctor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_Insert)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 114)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اضافه کردن گروه جدید"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(265, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "پزشک:"
        '
        'cmd_doctor
        '
        Me.cmd_doctor.DataSource = Me.SelectdoctorforGroupSickBindingSource
        Me.cmd_doctor.DisplayMember = "Doctor_Name"
        Me.cmd_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmd_doctor.FormattingEnabled = True
        Me.cmd_doctor.Location = New System.Drawing.Point(6, 53)
        Me.cmd_doctor.Name = "cmd_doctor"
        Me.cmd_doctor.Size = New System.Drawing.Size(253, 21)
        Me.cmd_doctor.TabIndex = 7
        Me.cmd_doctor.ValueMember = "Id"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(265, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "گروه:"
        '
        'btn_Insert
        '
        Me.btn_Insert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Insert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Insert.Location = New System.Drawing.Point(6, 85)
        Me.btn_Insert.Name = "btn_Insert"
        Me.btn_Insert.Size = New System.Drawing.Size(87, 23)
        Me.btn_Insert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Insert.TabIndex = 1
        Me.btn_Insert.Text = "اضافه کردن"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Cancel.Location = New System.Drawing.Point(214, 456)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(108, 23)
        Me.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Cancel.TabIndex = 8
        Me.btn_Cancel.Text = "خروج"
        '
        'btn_Delete
        '
        Me.btn_Delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Delete.Location = New System.Drawing.Point(12, 456)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(45, 23)
        Me.btn_Delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Delete.TabIndex = 7
        Me.btn_Delete.Text = "حذف "
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.Name_Doctor, Me.NameDataGridViewTextBoxColumn, Me.Id_personal})
        Me.dgv.DataSource = Me.SelectGroupSickBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(9, 128)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.ShowCellErrors = False
        Me.dgv.ShowCellToolTips = False
        Me.dgv.ShowEditingIcon = False
        Me.dgv.ShowRowErrors = False
        Me.dgv.Size = New System.Drawing.Size(314, 323)
        Me.dgv.TabIndex = 6
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'Name_Doctor
        '
        Me.Name_Doctor.DataPropertyName = "Name_Doctor"
        Me.Name_Doctor.HeaderText = "پزشک"
        Me.Name_Doctor.Name = "Name_Doctor"
        Me.Name_Doctor.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "گروه"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 160
        '
        'Id_personal
        '
        Me.Id_personal.DataPropertyName = "Id_personal"
        Me.Id_personal.HeaderText = "Id_personal"
        Me.Id_personal.Name = "Id_personal"
        Me.Id_personal.ReadOnly = True
        Me.Id_personal.Visible = False
        '
        'SelectGroupSickBindingSource
        '
        Me.SelectGroupSickBindingSource.DataMember = "Select_Group_Sick"
        Me.SelectGroupSickBindingSource.DataSource = Me.Ds_GroupSick
        '
        'Ds_GroupSick
        '
        Me.Ds_GroupSick.DataSetName = "ds_GroupSick"
        Me.Ds_GroupSick.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Select_Group_SickTableAdapter
        '
        Me.Select_Group_SickTableAdapter.ClearBeforeFill = True
        '
        'Select_doctor_for_GroupSickTableAdapter
        '
        Me.Select_doctor_for_GroupSickTableAdapter.ClearBeforeFill = True
        '
        'txt_Group
        '
        Me.txt_Group.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_Group.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Group.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Group.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_Group.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_Group.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_Group.__NextFocuse = True
        Me.txt_Group.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_Group.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_Group.Location = New System.Drawing.Point(102, 26)
        Me.txt_Group.Name = "txt_Group"
        Me.txt_Group.Size = New System.Drawing.Size(157, 21)
        Me.txt_Group.TabIndex = 9
        '
        'frm_define_GroupSick
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 483)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.dgv)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_define_GroupSick"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گروه بیماران"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectGroupSickBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_GroupSick, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Insert As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Cancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Delete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgv As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Ds_GroupSick As Clinic.ds_GroupSick
    Friend WithEvents SelectGroupSickBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Select_Group_SickTableAdapter As Clinic.ds_GroupSickTableAdapters.Select_Group_SickTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmd_doctor As System.Windows.Forms.ComboBox
    Friend WithEvents Ds_Personal As Clinic.ds_Personal
    Friend WithEvents SelectdoctorforGroupSickBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Select_doctor_for_GroupSickTableAdapter As Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Name_Doctor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_personal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_Group As TextualControl.TextualControl
End Class
