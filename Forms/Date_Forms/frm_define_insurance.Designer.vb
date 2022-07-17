<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_define_insurance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_define_insurance))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_percentage = New TextualControl.TextualControl()
        Me.txt_name = New TextualControl.TextualControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Insert = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Cancel = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Delete = New DevComponents.DotNetBar.ButtonX()
        Me.dgv = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectinsuranceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_insurance = New Clinic.ds_insurance()
        Me.Select_insuranceTableAdapter = New Clinic.ds_insuranceTableAdapters.Select_insuranceTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectinsuranceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_insurance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txt_percentage)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_Insert)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 85)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اضافه کردن بیمه جدید"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBox1.Image = Global.Clinic.My.Resources.Resources.animated_warning
        Me.PictureBox1.Location = New System.Drawing.Point(6, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 17)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, resources.GetString("PictureBox1.ToolTip"))
        '
        'txt_percentage
        '
        Me.txt_percentage.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_percentage.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_percentage.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_percentage.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_percentage.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_percentage.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_percentage.__NextFocuse = True
        Me.txt_percentage.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_percentage.__Type = TextualControl.TextualControl.No.Numeric
        Me.txt_percentage.Location = New System.Drawing.Point(210, 52)
        Me.txt_percentage.Name = "txt_percentage"
        Me.txt_percentage.Size = New System.Drawing.Size(49, 21)
        Me.txt_percentage.TabIndex = 10
        '
        'txt_name
        '
        Me.txt_name.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_name.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_name.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_name.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_name.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_name.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_name.__NextFocuse = True
        Me.txt_name.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_name.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_name.Location = New System.Drawing.Point(99, 25)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(160, 21)
        Me.txt_name.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(265, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "درصد:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(265, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "بیمه:"
        '
        'btn_Insert
        '
        Me.btn_Insert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Insert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Insert.Location = New System.Drawing.Point(6, 25)
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
        Me.btn_Cancel.Location = New System.Drawing.Point(215, 437)
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
        Me.btn_Delete.Location = New System.Drawing.Point(13, 437)
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
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PercentageDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.SelectinsuranceBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(13, 98)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.ShowCellErrors = False
        Me.dgv.ShowCellToolTips = False
        Me.dgv.ShowEditingIcon = False
        Me.dgv.ShowRowErrors = False
        Me.dgv.Size = New System.Drawing.Size(310, 333)
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
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "بیمه"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 185
        '
        'PercentageDataGridViewTextBoxColumn
        '
        Me.PercentageDataGridViewTextBoxColumn.DataPropertyName = "Percentage"
        Me.PercentageDataGridViewTextBoxColumn.HeaderText = "درصد بیمه"
        Me.PercentageDataGridViewTextBoxColumn.Name = "PercentageDataGridViewTextBoxColumn"
        Me.PercentageDataGridViewTextBoxColumn.ReadOnly = True
        Me.PercentageDataGridViewTextBoxColumn.Width = 80
        '
        'SelectinsuranceBindingSource
        '
        Me.SelectinsuranceBindingSource.DataMember = "Select_insurance"
        Me.SelectinsuranceBindingSource.DataSource = Me.Ds_insurance
        '
        'Ds_insurance
        '
        Me.Ds_insurance.DataSetName = "ds_insurance"
        Me.Ds_insurance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Select_insuranceTableAdapter
        '
        Me.Select_insuranceTableAdapter.ClearBeforeFill = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.InitialDelay = 10
        Me.ToolTip1.ReshowDelay = 100
        '
        'frm_define_insurance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 465)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.dgv)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "frm_define_insurance"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " بیمه"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectinsuranceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_insurance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Insert As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Cancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Delete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgv As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Ds_insurance As Clinic.ds_insurance
    Friend WithEvents SelectinsuranceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Select_insuranceTableAdapter As Clinic.ds_insuranceTableAdapters.Select_insuranceTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PercentageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_percentage As TextualControl.TextualControl
    Friend WithEvents txt_name As TextualControl.TextualControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
