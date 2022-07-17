<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_show_prescription
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
        Me.SelectdoctorforGroupSickBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Personal = New Clinic.ds_Personal()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.btn_DeleteVisit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Select_doctor_for_GroupSickTableAdapter = New Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter()
        Me.Dgv_Prescription = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdReceptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPersonalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LightPenDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MedicationReviewDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaientDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePrescripptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPeriodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectprescriptionallBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_prescription = New Clinic.ds_prescription()
        Me.btnSearch = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_doctor = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Select_prescription_allTableAdapter = New Clinic.ds_prescriptionTableAdapters.Select_prescription_allTableAdapter()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Dgv_Prescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectprescriptionallBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_prescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 590)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(397, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_DeleteVisit})
        Me.ToolStripSplitButton1.Image = Global.Clinic.My.Resources.Resources.setting
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 20)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'btn_DeleteVisit
        '
        Me.btn_DeleteVisit.Image = Global.Clinic.My.Resources.Resources.delete
        Me.btn_DeleteVisit.Name = "btn_DeleteVisit"
        Me.btn_DeleteVisit.Size = New System.Drawing.Size(155, 22)
        Me.btn_DeleteVisit.Text = "حذف ویزیت جاری"
        '
        'Select_doctor_for_GroupSickTableAdapter
        '
        Me.Select_doctor_for_GroupSickTableAdapter.ClearBeforeFill = True
        '
        'Dgv_Prescription
        '
        Me.Dgv_Prescription.AllowUserToAddRows = False
        Me.Dgv_Prescription.AllowUserToDeleteRows = False
        Me.Dgv_Prescription.AutoGenerateColumns = False
        Me.Dgv_Prescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Prescription.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdReceptionDataGridViewTextBoxColumn, Me.IdPersonalDataGridViewTextBoxColumn, Me.PrescriptionDataGridViewTextBoxColumn, Me.LightPenDataGridViewImageColumn, Me.MedicationReviewDataGridViewTextBoxColumn, Me.DetailDataGridViewTextBoxColumn, Me.PaientDataGridViewTextBoxColumn, Me.DatePrescripptionDataGridViewTextBoxColumn, Me.IDPeriodDataGridViewTextBoxColumn})
        Me.Dgv_Prescription.DataSource = Me.SelectprescriptionallBindingSource
        Me.Dgv_Prescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_Prescription.Location = New System.Drawing.Point(0, 41)
        Me.Dgv_Prescription.MultiSelect = False
        Me.Dgv_Prescription.Name = "Dgv_Prescription"
        Me.Dgv_Prescription.ReadOnly = True
        Me.Dgv_Prescription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Prescription.Size = New System.Drawing.Size(397, 549)
        Me.Dgv_Prescription.TabIndex = 4
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'IdReceptionDataGridViewTextBoxColumn
        '
        Me.IdReceptionDataGridViewTextBoxColumn.DataPropertyName = "Id_Reception"
        Me.IdReceptionDataGridViewTextBoxColumn.HeaderText = "Id_Reception"
        Me.IdReceptionDataGridViewTextBoxColumn.Name = "IdReceptionDataGridViewTextBoxColumn"
        Me.IdReceptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdReceptionDataGridViewTextBoxColumn.Visible = False
        '
        'IdPersonalDataGridViewTextBoxColumn
        '
        Me.IdPersonalDataGridViewTextBoxColumn.DataPropertyName = "Id_Personal"
        Me.IdPersonalDataGridViewTextBoxColumn.HeaderText = "Id_Personal"
        Me.IdPersonalDataGridViewTextBoxColumn.Name = "IdPersonalDataGridViewTextBoxColumn"
        Me.IdPersonalDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPersonalDataGridViewTextBoxColumn.Visible = False
        '
        'PrescriptionDataGridViewTextBoxColumn
        '
        Me.PrescriptionDataGridViewTextBoxColumn.DataPropertyName = "Prescription"
        Me.PrescriptionDataGridViewTextBoxColumn.HeaderText = "Prescription"
        Me.PrescriptionDataGridViewTextBoxColumn.Name = "PrescriptionDataGridViewTextBoxColumn"
        Me.PrescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrescriptionDataGridViewTextBoxColumn.Visible = False
        '
        'LightPenDataGridViewImageColumn
        '
        Me.LightPenDataGridViewImageColumn.DataPropertyName = "LightPen"
        Me.LightPenDataGridViewImageColumn.HeaderText = "LightPen"
        Me.LightPenDataGridViewImageColumn.Name = "LightPenDataGridViewImageColumn"
        Me.LightPenDataGridViewImageColumn.ReadOnly = True
        Me.LightPenDataGridViewImageColumn.Visible = False
        '
        'MedicationReviewDataGridViewTextBoxColumn
        '
        Me.MedicationReviewDataGridViewTextBoxColumn.DataPropertyName = "Medication_Review"
        Me.MedicationReviewDataGridViewTextBoxColumn.HeaderText = "Medication_Review"
        Me.MedicationReviewDataGridViewTextBoxColumn.Name = "MedicationReviewDataGridViewTextBoxColumn"
        Me.MedicationReviewDataGridViewTextBoxColumn.ReadOnly = True
        Me.MedicationReviewDataGridViewTextBoxColumn.Visible = False
        '
        'DetailDataGridViewTextBoxColumn
        '
        Me.DetailDataGridViewTextBoxColumn.DataPropertyName = "Detail"
        Me.DetailDataGridViewTextBoxColumn.HeaderText = "Detail"
        Me.DetailDataGridViewTextBoxColumn.Name = "DetailDataGridViewTextBoxColumn"
        Me.DetailDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetailDataGridViewTextBoxColumn.Visible = False
        '
        'PaientDataGridViewTextBoxColumn
        '
        Me.PaientDataGridViewTextBoxColumn.DataPropertyName = "Paient"
        Me.PaientDataGridViewTextBoxColumn.HeaderText = "نام بیمار"
        Me.PaientDataGridViewTextBoxColumn.Name = "PaientDataGridViewTextBoxColumn"
        Me.PaientDataGridViewTextBoxColumn.ReadOnly = True
        Me.PaientDataGridViewTextBoxColumn.Width = 200
        '
        'DatePrescripptionDataGridViewTextBoxColumn
        '
        Me.DatePrescripptionDataGridViewTextBoxColumn.DataPropertyName = "Date_Prescripption"
        Me.DatePrescripptionDataGridViewTextBoxColumn.HeaderText = "تاربخ ویزیت"
        Me.DatePrescripptionDataGridViewTextBoxColumn.Name = "DatePrescripptionDataGridViewTextBoxColumn"
        Me.DatePrescripptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DatePrescripptionDataGridViewTextBoxColumn.Width = 150
        '
        'IDPeriodDataGridViewTextBoxColumn
        '
        Me.IDPeriodDataGridViewTextBoxColumn.DataPropertyName = "ID_Period"
        Me.IDPeriodDataGridViewTextBoxColumn.HeaderText = "ID_Period"
        Me.IDPeriodDataGridViewTextBoxColumn.Name = "IDPeriodDataGridViewTextBoxColumn"
        Me.IDPeriodDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDPeriodDataGridViewTextBoxColumn.Visible = False
        '
        'SelectprescriptionallBindingSource
        '
        Me.SelectprescriptionallBindingSource.DataMember = "Select_prescription_all"
        Me.SelectprescriptionallBindingSource.DataSource = Me.Ds_prescription
        '
        'Ds_prescription
        '
        Me.Ds_prescription.DataSetName = "ds_prescription"
        Me.Ds_prescription.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.AutoSize = True
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.ForeColor = System.Drawing.Color.Gray
        Me.btnSearch.Location = New System.Drawing.Point(72, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(50, 13)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "(جستجو)"
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.Clinic.My.Resources.Resources.btnClose
        Me.btnClose.Location = New System.Drawing.Point(11, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(39, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(316, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "پرشک معالج:"
        '
        'cmb_doctor
        '
        Me.cmb_doctor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_doctor.DataSource = Me.SelectdoctorforGroupSickBindingSource
        Me.cmb_doctor.DisplayMember = "Doctor_Name"
        Me.cmb_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_doctor.FormattingEnabled = True
        Me.cmb_doctor.Location = New System.Drawing.Point(128, 12)
        Me.cmb_doctor.Name = "cmb_doctor"
        Me.cmb_doctor.Size = New System.Drawing.Size(182, 21)
        Me.cmb_doctor.TabIndex = 11
        Me.cmb_doctor.ValueMember = "id"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmb_doctor)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(397, 41)
        Me.Panel1.TabIndex = 1
        '
        'Select_prescription_allTableAdapter
        '
        Me.Select_prescription_allTableAdapter.ClearBeforeFill = True
        '
        'frm_show_prescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 612)
        Me.ControlBox = False
        Me.Controls.Add(Me.Dgv_Prescription)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_show_prescription"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "لیست ویزیت شدگان"
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Dgv_Prescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectprescriptionallBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_prescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents btn_DeleteVisit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectdoctorforGroupSickBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Personal As Clinic.ds_Personal
    Friend WithEvents Select_doctor_for_GroupSickTableAdapter As Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter
    Friend WithEvents Dgv_Prescription As System.Windows.Forms.DataGridView
    Friend WithEvents DoctorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend Select_prescription_AllTableAdapter_1 As Clinic.ds_prescriptionTableAdapters.Select_prescription_AllTableAdapter
    Friend WithEvents btnSearch As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_doctor As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SelectprescriptionallBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_prescription As Clinic.ds_prescription
    Friend WithEvents Select_prescription_allTableAdapter As Clinic.ds_prescriptionTableAdapters.Select_prescription_allTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdReceptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPersonalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LightPenDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents MedicationReviewDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaientDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatePrescripptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPeriodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
