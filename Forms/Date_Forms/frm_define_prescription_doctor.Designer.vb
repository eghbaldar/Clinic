<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_define_prescription_doctor
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnInsertVisit = New DevComponents.DotNetBar.ButtonX()
        Me.btnFontDrug = New System.Windows.Forms.Button()
        Me.btnFontDetail = New System.Windows.Forms.Button()
        Me.txt_Drug = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Detail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_DoctorName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.dgv_Info_Complete = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
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
        Me.SelectprescriptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_prescription = New Clinic.ds_prescription()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgv_RecordForTitle = New System.Windows.Forms.DataGridView()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectRecordForFileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_RecordTitle = New Clinic.ds_RecordTitle()
        Me.Select_RecordForFileTableAdapter = New Clinic.ds_RecordTitleTableAdapters.Select_RecordForFileTableAdapter()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.Select_prescriptionTableAdapter = New Clinic.ds_prescriptionTableAdapters.Select_prescriptionTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Info_Complete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Dgv_Prescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectprescriptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_prescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgv_RecordForTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectRecordForFileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_RecordTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(732, 727)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnInsertVisit)
        Me.TabPage1.Controls.Add(Me.btnFontDrug)
        Me.TabPage1.Controls.Add(Me.btnFontDetail)
        Me.TabPage1.Controls.Add(Me.txt_Drug)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_Detail)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.lbl_DoctorName)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(724, 701)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ثبت ویزیت"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnInsertVisit
        '
        Me.btnInsertVisit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnInsertVisit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnInsertVisit.Location = New System.Drawing.Point(22, 667)
        Me.btnInsertVisit.Name = "btnInsertVisit"
        Me.btnInsertVisit.Size = New System.Drawing.Size(685, 23)
        Me.btnInsertVisit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnInsertVisit.TabIndex = 11
        Me.btnInsertVisit.Text = "ثبت ویزیت"
        '
        'btnFontDrug
        '
        Me.btnFontDrug.Location = New System.Drawing.Point(20, 376)
        Me.btnFontDrug.Name = "btnFontDrug"
        Me.btnFontDrug.Size = New System.Drawing.Size(24, 23)
        Me.btnFontDrug.TabIndex = 10
        Me.btnFontDrug.Text = "F"
        Me.btnFontDrug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFontDrug.UseVisualStyleBackColor = True
        '
        'btnFontDetail
        '
        Me.btnFontDetail.Location = New System.Drawing.Point(20, 36)
        Me.btnFontDetail.Name = "btnFontDetail"
        Me.btnFontDetail.Size = New System.Drawing.Size(24, 23)
        Me.btnFontDetail.TabIndex = 6
        Me.btnFontDetail.Text = "F"
        Me.btnFontDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFontDetail.UseVisualStyleBackColor = True
        '
        'txt_Drug
        '
        Me.txt_Drug.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Drug.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txt_Drug.Location = New System.Drawing.Point(22, 405)
        Me.txt_Drug.Multiline = True
        Me.txt_Drug.Name = "txt_Drug"
        Me.txt_Drug.Size = New System.Drawing.Size(685, 255)
        Me.txt_Drug.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(655, 381)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "تجویز دارو:"
        '
        'txt_Detail
        '
        Me.txt_Detail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Detail.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txt_Detail.Location = New System.Drawing.Point(20, 65)
        Me.txt_Detail.Multiline = True
        Me.txt_Detail.Name = "txt_Detail"
        Me.txt_Detail.Size = New System.Drawing.Size(686, 305)
        Me.txt_Detail.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(639, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "تشریح ویزیت:"
        '
        'lbl_DoctorName
        '
        Me.lbl_DoctorName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_DoctorName.AutoSize = True
        Me.lbl_DoctorName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DoctorName.ForeColor = System.Drawing.Color.Red
        Me.lbl_DoctorName.Location = New System.Drawing.Point(507, 14)
        Me.lbl_DoctorName.Name = "lbl_DoctorName"
        Me.lbl_DoctorName.Size = New System.Drawing.Size(44, 13)
        Me.lbl_DoctorName.TabIndex = 1
        Me.lbl_DoctorName.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(639, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "پزشک معالج:"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.dgv_Info_Complete)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(724, 701)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "مشخصات اصلی بیمار"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox)
        Me.GroupBox1.Location = New System.Drawing.Point(269, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(187, 257)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "تصویر بیمار"
        '
        'PictureBox
        '
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox.Location = New System.Drawing.Point(6, 20)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(175, 231)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 12
        Me.PictureBox.TabStop = False
        '
        'dgv_Info_Complete
        '
        Me.dgv_Info_Complete.AllowUserToAddRows = False
        Me.dgv_Info_Complete.AllowUserToDeleteRows = False
        Me.dgv_Info_Complete.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Info_Complete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Info_Complete.ColumnHeadersVisible = False
        Me.dgv_Info_Complete.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_Info_Complete.Location = New System.Drawing.Point(0, 339)
        Me.dgv_Info_Complete.Name = "dgv_Info_Complete"
        Me.dgv_Info_Complete.ReadOnly = True
        Me.dgv_Info_Complete.Size = New System.Drawing.Size(724, 362)
        Me.dgv_Info_Complete.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Dgv_Prescription)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(724, 701)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "سوابق ویزیت"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Dgv_Prescription
        '
        Me.Dgv_Prescription.AllowUserToAddRows = False
        Me.Dgv_Prescription.AllowUserToDeleteRows = False
        Me.Dgv_Prescription.AutoGenerateColumns = False
        Me.Dgv_Prescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Prescription.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdReceptionDataGridViewTextBoxColumn, Me.IdPersonalDataGridViewTextBoxColumn, Me.PrescriptionDataGridViewTextBoxColumn, Me.LightPenDataGridViewImageColumn, Me.MedicationReviewDataGridViewTextBoxColumn, Me.DetailDataGridViewTextBoxColumn, Me.PaientDataGridViewTextBoxColumn, Me.DatePrescripptionDataGridViewTextBoxColumn, Me.IDPeriodDataGridViewTextBoxColumn})
        Me.Dgv_Prescription.DataSource = Me.SelectprescriptionBindingSource
        Me.Dgv_Prescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_Prescription.Location = New System.Drawing.Point(3, 3)
        Me.Dgv_Prescription.MultiSelect = False
        Me.Dgv_Prescription.Name = "Dgv_Prescription"
        Me.Dgv_Prescription.ReadOnly = True
        Me.Dgv_Prescription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Prescription.Size = New System.Drawing.Size(718, 695)
        Me.Dgv_Prescription.TabIndex = 0
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
        Me.PaientDataGridViewTextBoxColumn.Width = 500
        '
        'DatePrescripptionDataGridViewTextBoxColumn
        '
        Me.DatePrescripptionDataGridViewTextBoxColumn.DataPropertyName = "Date_Prescripption"
        Me.DatePrescripptionDataGridViewTextBoxColumn.HeaderText = "تاریخ ویزیت"
        Me.DatePrescripptionDataGridViewTextBoxColumn.Name = "DatePrescripptionDataGridViewTextBoxColumn"
        Me.DatePrescripptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DatePrescripptionDataGridViewTextBoxColumn.Width = 170
        '
        'IDPeriodDataGridViewTextBoxColumn
        '
        Me.IDPeriodDataGridViewTextBoxColumn.DataPropertyName = "ID_Period"
        Me.IDPeriodDataGridViewTextBoxColumn.HeaderText = "ID_Period"
        Me.IDPeriodDataGridViewTextBoxColumn.Name = "IDPeriodDataGridViewTextBoxColumn"
        Me.IDPeriodDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDPeriodDataGridViewTextBoxColumn.Visible = False
        '
        'SelectprescriptionBindingSource
        '
        Me.SelectprescriptionBindingSource.DataMember = "Select_prescription"
        Me.SelectprescriptionBindingSource.DataSource = Me.Ds_prescription
        '
        'Ds_prescription
        '
        Me.Ds_prescription.DataSetName = "ds_prescription"
        Me.Ds_prescription.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgv_RecordForTitle)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(724, 701)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "سوابق بیماری"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgv_RecordForTitle
        '
        Me.dgv_RecordForTitle.AllowUserToAddRows = False
        Me.dgv_RecordForTitle.AllowUserToDeleteRows = False
        Me.dgv_RecordForTitle.AutoGenerateColumns = False
        Me.dgv_RecordForTitle.BackgroundColor = System.Drawing.Color.White
        Me.dgv_RecordForTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_RecordForTitle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TitleDataGridViewTextBoxColumn, Me.DetailsDataGridViewTextBoxColumn})
        Me.dgv_RecordForTitle.DataSource = Me.SelectRecordForFileBindingSource
        Me.dgv_RecordForTitle.Location = New System.Drawing.Point(13, 16)
        Me.dgv_RecordForTitle.Name = "dgv_RecordForTitle"
        Me.dgv_RecordForTitle.ReadOnly = True
        Me.dgv_RecordForTitle.Size = New System.Drawing.Size(695, 649)
        Me.dgv_RecordForTitle.TabIndex = 63
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "عنوان سابقه"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitleDataGridViewTextBoxColumn.Width = 120
        '
        'DetailsDataGridViewTextBoxColumn
        '
        Me.DetailsDataGridViewTextBoxColumn.DataPropertyName = "Details"
        Me.DetailsDataGridViewTextBoxColumn.HeaderText = "توضیحات"
        Me.DetailsDataGridViewTextBoxColumn.Name = "DetailsDataGridViewTextBoxColumn"
        Me.DetailsDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetailsDataGridViewTextBoxColumn.Width = 520
        '
        'SelectRecordForFileBindingSource
        '
        Me.SelectRecordForFileBindingSource.DataMember = "Select_RecordForFile"
        Me.SelectRecordForFileBindingSource.DataSource = Me.Ds_RecordTitle
        '
        'Ds_RecordTitle
        '
        Me.Ds_RecordTitle.DataSetName = "ds_RecordTitle"
        Me.Ds_RecordTitle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Select_RecordForFileTableAdapter
        '
        Me.Select_RecordForFileTableAdapter.ClearBeforeFill = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.Clinic.My.Resources.Resources.btnClose
        Me.btnClose.Location = New System.Drawing.Point(14, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(39, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.TabStop = False
        '
        'Select_prescriptionTableAdapter
        '
        Me.Select_prescriptionTableAdapter.ClearBeforeFill = True
        '
        'frm_define_prescription_doctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 751)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_define_prescription_doctor"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ثبت ویزیت"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Info_Complete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Dgv_Prescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectprescriptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_prescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgv_RecordForTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectRecordForFileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_RecordTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents btnFontDetail As System.Windows.Forms.Button
    Friend WithEvents txt_Drug As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Detail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_DoctorName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFontDrug As System.Windows.Forms.Button
    Friend WithEvents dgv_RecordForTitle As System.Windows.Forms.DataGridView
    Friend WithEvents SelectRecordForFileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_RecordTitle As Clinic.ds_RecordTitle
    Friend WithEvents Select_RecordForFileTableAdapter As Clinic.ds_RecordTitleTableAdapters.Select_RecordForFileTableAdapter
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetailsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_Info_Complete As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents btnInsertVisit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Dgv_Prescription As System.Windows.Forms.DataGridView
    Friend WithEvents Ds_prescription As Clinic.ds_prescription
    Friend WithEvents SelectprescriptionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Select_prescriptionTableAdapter As Clinic.ds_prescriptionTableAdapters.Select_prescriptionTableAdapter
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
