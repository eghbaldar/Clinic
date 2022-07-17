<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_edit_groupSick
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
        Me.btn_update = New DevComponents.DotNetBar.ButtonX()
        Me.txt_groupName = New TextualControl.TextualControl()
        Me.cmb_doctor = New System.Windows.Forms.ComboBox()
        Me.SelectdoctorforGroupSickBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Personal = New Clinic.ds_Personal()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Select_doctor_for_GroupSickTableAdapter = New Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_update.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_update.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_update.Location = New System.Drawing.Point(0, 92)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(278, 35)
        Me.btn_update.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_update.TabIndex = 0
        Me.btn_update.Text = "بروز رسانی"
        '
        'txt_groupName
        '
        Me.txt_groupName.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_groupName.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_groupName.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_groupName.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_groupName.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_groupName.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_groupName.__NextFocuse = True
        Me.txt_groupName.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_groupName.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_groupName.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_groupName.Location = New System.Drawing.Point(12, 43)
        Me.txt_groupName.Name = "txt_groupName"
        Me.txt_groupName.Size = New System.Drawing.Size(254, 36)
        Me.txt_groupName.TabIndex = 3
        Me.txt_groupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_doctor
        '
        Me.cmb_doctor.DataSource = Me.SelectdoctorforGroupSickBindingSource
        Me.cmb_doctor.DisplayMember = "Doctor_Name"
        Me.cmb_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_doctor.FormattingEnabled = True
        Me.cmb_doctor.Location = New System.Drawing.Point(59, 12)
        Me.cmb_doctor.Name = "cmb_doctor"
        Me.cmb_doctor.Size = New System.Drawing.Size(207, 21)
        Me.cmb_doctor.TabIndex = 4
        Me.cmb_doctor.ValueMember = "Id"
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
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "پزشک:"
        '
        'Select_doctor_for_GroupSickTableAdapter
        '
        Me.Select_doctor_for_GroupSickTableAdapter.ClearBeforeFill = True
        '
        'frm_edit_groupSick
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 127)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_doctor)
        Me.Controls.Add(Me.txt_groupName)
        Me.Controls.Add(Me.btn_update)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_edit_groupSick"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گروه"
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_update As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_groupName As TextualControl.TextualControl
    Friend WithEvents cmb_doctor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ds_Personal As Clinic.ds_Personal
    Friend WithEvents SelectdoctorforGroupSickBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Select_doctor_for_GroupSickTableAdapter As Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter
End Class
