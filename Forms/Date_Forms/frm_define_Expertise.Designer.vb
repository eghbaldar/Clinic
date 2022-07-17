<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_define_Expertise
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
        Me.dgv = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectexpertiseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Expertise = New Clinic.ds_Expertise()
        Me.btn_Insert = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Delete = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Cancel = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Select_expertiseTableAdapter = New Clinic.ds_ExpertiseTableAdapters.Select_expertiseTableAdapter()
        Me.txt_Expertise = New TextualControl.TextualControl()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectexpertiseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Expertise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.SelectexpertiseBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(7, 67)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.ShowCellErrors = False
        Me.dgv.ShowCellToolTips = False
        Me.dgv.ShowEditingIcon = False
        Me.dgv.ShowRowErrors = False
        Me.dgv.Size = New System.Drawing.Size(310, 323)
        Me.dgv.TabIndex = 0
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
        Me.NameDataGridViewTextBoxColumn.HeaderText = "نام تخصص"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 265
        '
        'SelectexpertiseBindingSource
        '
        Me.SelectexpertiseBindingSource.DataMember = "Select_expertise"
        Me.SelectexpertiseBindingSource.DataSource = Me.Ds_Expertise
        '
        'Ds_Expertise
        '
        Me.Ds_Expertise.DataSetName = "ds_Expertise"
        Me.Ds_Expertise.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_Insert
        '
        Me.btn_Insert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Insert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Insert.Location = New System.Drawing.Point(7, 25)
        Me.btn_Insert.Name = "btn_Insert"
        Me.btn_Insert.Size = New System.Drawing.Size(87, 23)
        Me.btn_Insert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Insert.TabIndex = 1
        Me.btn_Insert.Text = "اضافه کردن"
        '
        'btn_Delete
        '
        Me.btn_Delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Delete.Location = New System.Drawing.Point(7, 396)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(45, 23)
        Me.btn_Delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Delete.TabIndex = 2
        Me.btn_Delete.Text = "حذف "
        '
        'btn_Cancel
        '
        Me.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Cancel.Location = New System.Drawing.Point(209, 396)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(108, 23)
        Me.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Cancel.TabIndex = 3
        Me.btn_Cancel.Text = "خروج"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_Expertise)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_Insert)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 55)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اضافه کردن تخصص جدید"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(266, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "تخصص:"
        '
        'Select_expertiseTableAdapter
        '
        Me.Select_expertiseTableAdapter.ClearBeforeFill = True
        '
        'txt_Expertise
        '
        Me.txt_Expertise.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_Expertise.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Expertise.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Expertise.__ColorFocus = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_Expertise.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_Expertise.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_Expertise.__NextFocuse = True
        Me.txt_Expertise.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_Expertise.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_Expertise.Location = New System.Drawing.Point(103, 26)
        Me.txt_Expertise.Name = "txt_Expertise"
        Me.txt_Expertise.Size = New System.Drawing.Size(157, 21)
        Me.txt_Expertise.TabIndex = 6
        '
        'frm_define_Expertise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 425)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.dgv)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_define_Expertise"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تخصص پزشکان"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectexpertiseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Expertise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btn_Insert As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Delete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Cancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ds_Expertise As Clinic.ds_Expertise
    Friend WithEvents SelectexpertiseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Select_expertiseTableAdapter As Clinic.ds_ExpertiseTableAdapters.Select_expertiseTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_Expertise As TextualControl.TextualControl
End Class
