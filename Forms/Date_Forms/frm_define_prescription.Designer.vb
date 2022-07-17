<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_define_prescription
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.btnShowALL = New System.Windows.Forms.Button()
        Me.btnShowDetail = New System.Windows.Forms.Button()
        Me.cmb_doctor = New System.Windows.Forms.ComboBox()
        Me.SelectdoctorforGroupSickBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Personal = New Clinic.ds_Personal()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Label()
        Me.Select_doctor_for_GroupSickTableAdapter = New Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter()
        Me.btnVisit = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_date = New HM_FarsiCalendar.HM_FarsiCalendar()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(6, 91)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(450, 411)
        Me.dgv.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_date)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnShowALL)
        Me.GroupBox1.Controls.Add(Me.btnShowDetail)
        Me.GroupBox1.Controls.Add(Me.cmb_doctor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.dgv)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 540)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "پذیرش شدگان"
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Location = New System.Drawing.Point(6, 22)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "خروج"
        '
        'btnShowALL
        '
        Me.btnShowALL.Location = New System.Drawing.Point(6, 508)
        Me.btnShowALL.Name = "btnShowALL"
        Me.btnShowALL.Size = New System.Drawing.Size(278, 23)
        Me.btnShowALL.TabIndex = 16
        Me.btnShowALL.Text = "مشاهده تمامی پذیرش های این پزشک" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnShowALL.UseVisualStyleBackColor = True
        '
        'btnShowDetail
        '
        Me.btnShowDetail.Location = New System.Drawing.Point(290, 508)
        Me.btnShowDetail.Name = "btnShowDetail"
        Me.btnShowDetail.Size = New System.Drawing.Size(166, 23)
        Me.btnShowDetail.TabIndex = 15
        Me.btnShowDetail.Text = "مشاهده جزییات این پذیرش"
        Me.btnShowDetail.UseVisualStyleBackColor = True
        '
        'cmb_doctor
        '
        Me.cmb_doctor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_doctor.DataSource = Me.SelectdoctorforGroupSickBindingSource
        Me.cmb_doctor.DisplayMember = "Doctor_Name"
        Me.cmb_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_doctor.FormattingEnabled = True
        Me.cmb_doctor.Location = New System.Drawing.Point(195, 24)
        Me.cmb_doctor.Name = "cmb_doctor"
        Me.cmb_doctor.Size = New System.Drawing.Size(182, 21)
        Me.cmb_doctor.TabIndex = 14
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
        Me.Label3.Location = New System.Drawing.Point(383, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "پرشک معالج:"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.AutoSize = True
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.ForeColor = System.Drawing.Color.Gray
        Me.btnSearch.Location = New System.Drawing.Point(139, 27)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(50, 13)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "(جستجو)"
        '
        'Select_doctor_for_GroupSickTableAdapter
        '
        Me.Select_doctor_for_GroupSickTableAdapter.ClearBeforeFill = True
        '
        'btnVisit
        '
        Me.btnVisit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnVisit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnVisit.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisit.Location = New System.Drawing.Point(12, 562)
        Me.btnVisit.Name = "btnVisit"
        Me.btnVisit.Size = New System.Drawing.Size(462, 99)
        Me.btnVisit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnVisit.TabIndex = 8
        Me.btnVisit.Text = "ویزیت"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(383, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "تاریخ پذیرش:"
        '
        'txt_date
        '
        Me.txt_date.BodyBackColor = System.Drawing.Color.White
        Me.txt_date.BodyForeColor = System.Drawing.Color.Black
        Me.txt_date.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_date.HeaderBackColor = System.Drawing.Color.Gray
        Me.txt_date.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txt_date.HeaderForeColor = System.Drawing.Color.White
        Me.txt_date.Location = New System.Drawing.Point(252, 57)
        Me.txt_date.Max_Date = "1400/12/30"
        Me.txt_date.Min_Date = "1350/01/01"
        Me.txt_date.Name = "txt_date"
        Me.txt_date.SelectedBackColor = System.Drawing.Color.Blue
        Me.txt_date.SelectedForeColor = System.Drawing.Color.White
        Me.txt_date.Size = New System.Drawing.Size(125, 21)
        Me.txt_date.TabIndex = 18
        Me.txt_date.TitleFont = New System.Drawing.Font("Tahoma", 8.25!)
        '
        'frm_define_prescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 669)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVisit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_define_prescription"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " ویزیت"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SelectdoctorforGroupSickBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_doctor As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Label
    Friend WithEvents SelectdoctorforGroupSickBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Personal As Clinic.ds_Personal
    Friend WithEvents Select_doctor_for_GroupSickTableAdapter As Clinic.ds_PersonalTableAdapters.Select_doctor_for_GroupSickTableAdapter
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnShowALL As System.Windows.Forms.Button
    Friend WithEvents btnShowDetail As System.Windows.Forms.Button
    Friend WithEvents btnVisit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_date As HM_FarsiCalendar.HM_FarsiCalendar
End Class
