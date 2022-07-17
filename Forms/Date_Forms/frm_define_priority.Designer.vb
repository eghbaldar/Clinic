<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_define_priority
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDateToday = New System.Windows.Forms.Label()
        Me.cmb_doctor = New System.Windows.Forms.ComboBox()
        Me.SelectdoctorforGroupSickBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Personal = New Clinic.ds_Personal()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnSearch = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ویرایشنوبتجاریToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.حذفبیمارجاریToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.دیدنمشخصاتبیمارجاریToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgv = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Select_doctor_for_GroupSickTableAdapter = New Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblDateToday)
        Me.Panel1.Controls.Add(Me.cmb_doctor)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(806, 76)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(497, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(297, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "توجه: بیمارهایی که در لیست زیر قرار گرفته اند، پذیرش شده  اند"
        '
        'lblDateToday
        '
        Me.lblDateToday.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateToday.AutoSize = True
        Me.lblDateToday.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateToday.ForeColor = System.Drawing.Color.Red
        Me.lblDateToday.Location = New System.Drawing.Point(671, 15)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(86, 13)
        Me.lblDateToday.TabIndex = 12
        Me.lblDateToday.Text = "تمامی تاریخ ها"
        '
        'cmb_doctor
        '
        Me.cmb_doctor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_doctor.DataSource = Me.SelectdoctorforGroupSickBindingSource
        Me.cmb_doctor.DisplayMember = "Doctor_Name"
        Me.cmb_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_doctor.FormattingEnabled = True
        Me.cmb_doctor.Location = New System.Drawing.Point(380, 12)
        Me.cmb_doctor.Name = "cmb_doctor"
        Me.cmb_doctor.Size = New System.Drawing.Size(182, 21)
        Me.cmb_doctor.TabIndex = 11
        Me.cmb_doctor.ValueMember = "id"
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
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(568, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "پرشک معالج:"
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
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.AutoSize = True
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.ForeColor = System.Drawing.Color.Gray
        Me.btnSearch.Location = New System.Drawing.Point(324, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(50, 13)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "(جستجو)"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(763, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "تاریخ:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 534)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(806, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ویرایشنوبتجاریToolStripMenuItem, Me.ToolStripMenuItem2, Me.حذفبیمارجاریToolStripMenuItem, Me.ToolStripMenuItem1, Me.دیدنمشخصاتبیمارجاریToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = Global.Clinic.My.Resources.Resources.setting
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 20)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'ویرایشنوبتجاریToolStripMenuItem
        '
        Me.ویرایشنوبتجاریToolStripMenuItem.Image = Global.Clinic.My.Resources.Resources.edit
        Me.ویرایشنوبتجاریToolStripMenuItem.Name = "ویرایشنوبتجاریToolStripMenuItem"
        Me.ویرایشنوبتجاریToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ویرایشنوبتجاریToolStripMenuItem.Text = "ویرایش نوبت جاری"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(194, 6)
        '
        'حذفبیمارجاریToolStripMenuItem
        '
        Me.حذفبیمارجاریToolStripMenuItem.Image = Global.Clinic.My.Resources.Resources.delete
        Me.حذفبیمارجاریToolStripMenuItem.Name = "حذفبیمارجاریToolStripMenuItem"
        Me.حذفبیمارجاریToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.حذفبیمارجاریToolStripMenuItem.Text = "حذف نوبت جاری"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(194, 6)
        '
        'دیدنمشخصاتبیمارجاریToolStripMenuItem
        '
        Me.دیدنمشخصاتبیمارجاریToolStripMenuItem.Image = Global.Clinic.My.Resources.Resources.show
        Me.دیدنمشخصاتبیمارجاریToolStripMenuItem.Name = "دیدنمشخصاتبیمارجاریToolStripMenuItem"
        Me.دیدنمشخصاتبیمارجاریToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.دیدنمشخصاتبیمارجاریToolStripMenuItem.Text = "دیدن مشخصات بیمار جاری"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(0, 76)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(806, 458)
        Me.dgv.TabIndex = 7
        '
        'Select_doctor_for_GroupSickTableAdapter
        '
        Me.Select_doctor_for_GroupSickTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(461, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(334, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "توجه: برای تغییر اولویت ویزیت شدن، روی رکورد مورد نظر دابل کلیک کنید"
        '
        'frm_define_priority
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 556)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_define_priority"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اولویت بندی نویت ها"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblDateToday As System.Windows.Forms.Label
    Friend WithEvents cmb_doctor As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents btnSearch As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ویرایشنوبتجاریToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents حذفبیمارجاریToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents دیدنمشخصاتبیمارجاریToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgv As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents SelectdoctorforGroupSickBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Personal As Clinic.ds_Personal
    Friend WithEvents Select_doctor_for_GroupSickTableAdapter As Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter
    Friend WithEvents DatePeriod1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
