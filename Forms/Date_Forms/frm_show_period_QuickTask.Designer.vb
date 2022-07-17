<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_show_period_QuickTask
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
        Me.cmb_doctor = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv_Period = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.SelectdoctorforGroupSickBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Personal = New Clinic.ds_Personal()
        Me.Select_doctor_for_GroupSickTableAdapter = New Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter()
        CType(Me.dgv_Period, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_doctor
        '
        Me.cmb_doctor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_doctor.DisplayMember = "Doctor_Name"
        Me.cmb_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_doctor.FormattingEnabled = True
        Me.cmb_doctor.Location = New System.Drawing.Point(69, 10)
        Me.cmb_doctor.Name = "cmb_doctor"
        Me.cmb_doctor.Size = New System.Drawing.Size(243, 21)
        Me.cmb_doctor.TabIndex = 15
        Me.cmb_doctor.ValueMember = "id"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(318, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "پرشک معالج:"
        '
        'dgv_Period
        '
        Me.dgv_Period.AllowUserToAddRows = False
        Me.dgv_Period.AllowUserToDeleteRows = False
        Me.dgv_Period.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Period.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Period.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Period.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Period.EnableHeadersVisualStyles = False
        Me.dgv_Period.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgv_Period.Location = New System.Drawing.Point(12, 39)
        Me.dgv_Period.MultiSelect = False
        Me.dgv_Period.Name = "dgv_Period"
        Me.dgv_Period.ReadOnly = True
        Me.dgv_Period.RowHeadersVisible = False
        Me.dgv_Period.Size = New System.Drawing.Size(374, 369)
        Me.dgv_Period.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.Clinic.My.Resources.Resources.btnClose
        Me.btnClose.Location = New System.Drawing.Point(12, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(39, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.TabStop = False
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
        'Select_doctor_for_GroupSickTableAdapter
        '
        Me.Select_doctor_for_GroupSickTableAdapter.ClearBeforeFill = True
        '
        'frm_show_period_QuickTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 420)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgv_Period)
        Me.Controls.Add(Me.cmb_doctor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frm_show_period_QuickTask"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "نوبت های امروز"
        CType(Me.dgv_Period, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_doctor As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgv_Period As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents SelectdoctorforGroupSickBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Personal As Clinic.ds_Personal
    Friend WithEvents Select_doctor_for_GroupSickTableAdapter As Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter
End Class
