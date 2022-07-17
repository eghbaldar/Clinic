<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_define_PhotoBank
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
        Me.gp_attributes = New System.Windows.Forms.GroupBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.dgv_attribiutes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_showAttributes = New DevComponents.DotNetBar.ButtonX()
        Me.btn_SearchFile = New System.Windows.Forms.Label()
        Me.txt_CodeFile = New TextualControl.TextualControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gp_insert_photos = New System.Windows.Forms.GroupBox()
        Me.btn_full = New System.Windows.Forms.PictureBox()
        Me.txt_insert_detail = New System.Windows.Forms.TextBox()
        Me.btn_Manual_Delete_1 = New System.Windows.Forms.PictureBox()
        Me.btn_insert = New DevComponents.DotNetBar.ButtonX()
        Me.btnl_open = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_insert_title = New TextualControl.TextualControl()
        Me.gp_Photos = New System.Windows.Forms.GroupBox()
        Me.pnl = New System.Windows.Forms.FlowLayoutPanel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_CountPics = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btn_Close = New DevComponents.DotNetBar.ButtonX()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.gp_attributes.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_attribiutes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gp_insert_photos.SuspendLayout()
        CType(Me.btn_full, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Manual_Delete_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnl_open, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gp_Photos.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gp_attributes
        '
        Me.gp_attributes.Controls.Add(Me.PictureBox)
        Me.gp_attributes.Controls.Add(Me.dgv_attribiutes)
        Me.gp_attributes.Enabled = False
        Me.gp_attributes.Location = New System.Drawing.Point(470, 4)
        Me.gp_attributes.Name = "gp_attributes"
        Me.gp_attributes.Size = New System.Drawing.Size(327, 119)
        Me.gp_attributes.TabIndex = 3
        Me.gp_attributes.TabStop = False
        Me.gp_attributes.Text = "مشخصات بیمار"
        '
        'PictureBox
        '
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox.Location = New System.Drawing.Point(248, 18)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(76, 88)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 6
        Me.PictureBox.TabStop = False
        '
        'dgv_attribiutes
        '
        Me.dgv_attribiutes.BackgroundColor = System.Drawing.Color.White
        Me.dgv_attribiutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_attribiutes.ColumnHeadersVisible = False
        Me.dgv_attribiutes.Location = New System.Drawing.Point(6, 18)
        Me.dgv_attribiutes.Name = "dgv_attribiutes"
        Me.dgv_attribiutes.RowHeadersVisible = False
        Me.dgv_attribiutes.Size = New System.Drawing.Size(239, 88)
        Me.dgv_attribiutes.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_showAttributes)
        Me.GroupBox1.Controls.Add(Me.btn_SearchFile)
        Me.GroupBox1.Controls.Add(Me.txt_CodeFile)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(803, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(132, 119)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بیمار"
        '
        'btn_showAttributes
        '
        Me.btn_showAttributes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_showAttributes.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_showAttributes.Location = New System.Drawing.Point(7, 87)
        Me.btn_showAttributes.Name = "btn_showAttributes"
        Me.btn_showAttributes.Size = New System.Drawing.Size(75, 28)
        Me.btn_showAttributes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_showAttributes.TabIndex = 5
        Me.btn_showAttributes.Text = ">>>>>"
        '
        'btn_SearchFile
        '
        Me.btn_SearchFile.AutoSize = True
        Me.btn_SearchFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SearchFile.ForeColor = System.Drawing.Color.Blue
        Me.btn_SearchFile.Location = New System.Drawing.Point(7, 69)
        Me.btn_SearchFile.Name = "btn_SearchFile"
        Me.btn_SearchFile.Size = New System.Drawing.Size(116, 13)
        Me.btn_SearchFile.TabIndex = 2
        Me.btn_SearchFile.Text = "( جستجو شماره پرونده)"
        '
        'txt_CodeFile
        '
        Me.txt_CodeFile.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_CodeFile.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_CodeFile.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_CodeFile.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_CodeFile.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txt_CodeFile.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_CodeFile.__NextFocuse = False
        Me.txt_CodeFile.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_CodeFile.__Type = TextualControl.TextualControl.No.Numeric
        Me.txt_CodeFile.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_CodeFile.Location = New System.Drawing.Point(7, 36)
        Me.txt_CodeFile.Name = "txt_CodeFile"
        Me.txt_CodeFile.Size = New System.Drawing.Size(113, 30)
        Me.txt_CodeFile.TabIndex = 1
        Me.txt_CodeFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شماره پرونده:"
        '
        'gp_insert_photos
        '
        Me.gp_insert_photos.Controls.Add(Me.btn_full)
        Me.gp_insert_photos.Controls.Add(Me.txt_insert_detail)
        Me.gp_insert_photos.Controls.Add(Me.btn_Manual_Delete_1)
        Me.gp_insert_photos.Controls.Add(Me.btn_insert)
        Me.gp_insert_photos.Controls.Add(Me.btnl_open)
        Me.gp_insert_photos.Controls.Add(Me.Label8)
        Me.gp_insert_photos.Controls.Add(Me.pic)
        Me.gp_insert_photos.Controls.Add(Me.Label2)
        Me.gp_insert_photos.Controls.Add(Me.txt_insert_title)
        Me.gp_insert_photos.Enabled = False
        Me.gp_insert_photos.Location = New System.Drawing.Point(7, 3)
        Me.gp_insert_photos.Name = "gp_insert_photos"
        Me.gp_insert_photos.Size = New System.Drawing.Size(456, 119)
        Me.gp_insert_photos.TabIndex = 4
        Me.gp_insert_photos.TabStop = False
        Me.gp_insert_photos.Text = "ثبت تصویر"
        '
        'btn_full
        '
        Me.btn_full.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_full.Image = Global.Clinic.My.Resources.Resources.fullscreen
        Me.btn_full.Location = New System.Drawing.Point(424, 89)
        Me.btn_full.Name = "btn_full"
        Me.btn_full.Size = New System.Drawing.Size(21, 20)
        Me.btn_full.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_full.TabIndex = 44
        Me.btn_full.TabStop = False
        '
        'txt_insert_detail
        '
        Me.txt_insert_detail.Location = New System.Drawing.Point(89, 47)
        Me.txt_insert_detail.Multiline = True
        Me.txt_insert_detail.Name = "txt_insert_detail"
        Me.txt_insert_detail.Size = New System.Drawing.Size(200, 62)
        Me.txt_insert_detail.TabIndex = 47
        '
        'btn_Manual_Delete_1
        '
        Me.btn_Manual_Delete_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Manual_Delete_1.Image = Global.Clinic.My.Resources.Resources.delete
        Me.btn_Manual_Delete_1.Location = New System.Drawing.Point(424, 55)
        Me.btn_Manual_Delete_1.Name = "btn_Manual_Delete_1"
        Me.btn_Manual_Delete_1.Size = New System.Drawing.Size(21, 20)
        Me.btn_Manual_Delete_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Manual_Delete_1.TabIndex = 43
        Me.btn_Manual_Delete_1.TabStop = False
        '
        'btn_insert
        '
        Me.btn_insert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_insert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_insert.Location = New System.Drawing.Point(8, 47)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(75, 62)
        Me.btn_insert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_insert.TabIndex = 44
        Me.btn_insert.Text = "ذخیره سازی"
        '
        'btnl_open
        '
        Me.btnl_open.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnl_open.Image = Global.Clinic.My.Resources.Resources.open
        Me.btnl_open.Location = New System.Drawing.Point(424, 21)
        Me.btnl_open.Name = "btnl_open"
        Me.btnl_open.Size = New System.Drawing.Size(21, 20)
        Me.btnl_open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnl_open.TabIndex = 42
        Me.btnl_open.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(295, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "توضیحات:"
        '
        'pic
        '
        Me.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic.Location = New System.Drawing.Point(352, 21)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(66, 88)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic.TabIndex = 41
        Me.pic.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "عنوان:"
        '
        'txt_insert_title
        '
        Me.txt_insert_title.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_insert_title.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_insert_title.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_insert_title.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_insert_title.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban_Characters
        Me.txt_insert_title.__Language = TextualControl.TextualControl.Zaban.Persian
        Me.txt_insert_title.__NextFocuse = True
        Me.txt_insert_title.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_insert_title.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_insert_title.Location = New System.Drawing.Point(8, 20)
        Me.txt_insert_title.Name = "txt_insert_title"
        Me.txt_insert_title.Size = New System.Drawing.Size(281, 21)
        Me.txt_insert_title.TabIndex = 0
        '
        'gp_Photos
        '
        Me.gp_Photos.Controls.Add(Me.pnl)
        Me.gp_Photos.Enabled = False
        Me.gp_Photos.Location = New System.Drawing.Point(7, 126)
        Me.gp_Photos.Name = "gp_Photos"
        Me.gp_Photos.Size = New System.Drawing.Size(928, 366)
        Me.gp_Photos.TabIndex = 5
        Me.gp_Photos.TabStop = False
        Me.gp_Photos.Text = "تصاویر"
        '
        'pnl
        '
        Me.pnl.AutoScroll = True
        Me.pnl.Location = New System.Drawing.Point(11, 20)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(906, 340)
        Me.pnl.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbl_CountPics})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 530)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(940, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(84, 17)
        Me.ToolStripStatusLabel1.Text = "تعداد کل تصاویر:"
        '
        'lbl_CountPics
        '
        Me.lbl_CountPics.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CountPics.ForeColor = System.Drawing.Color.Red
        Me.lbl_CountPics.Name = "lbl_CountPics"
        Me.lbl_CountPics.Size = New System.Drawing.Size(0, 17)
        '
        'btn_Close
        '
        Me.btn_Close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Close.Location = New System.Drawing.Point(7, 498)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 23)
        Me.btn_Close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Close.TabIndex = 7
        Me.btn_Close.Text = "خروج"
        '
        'ToolTip
        '
        Me.ToolTip.AutoPopDelay = 5000
        Me.ToolTip.InitialDelay = 10
        Me.ToolTip.ReshowDelay = 100
        '
        'frm_define_PhotoBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 552)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gp_Photos)
        Me.Controls.Add(Me.gp_insert_photos)
        Me.Controls.Add(Me.gp_attributes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_define_PhotoBank"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بانک تصویر بیماران"
        Me.gp_attributes.ResumeLayout(False)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_attribiutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gp_insert_photos.ResumeLayout(False)
        Me.gp_insert_photos.PerformLayout()
        CType(Me.btn_full, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Manual_Delete_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnl_open, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gp_Photos.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gp_attributes As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents dgv_attribiutes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_showAttributes As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_SearchFile As System.Windows.Forms.Label
    Friend WithEvents txt_CodeFile As TextualControl.TextualControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gp_insert_photos As System.Windows.Forms.GroupBox
    Friend WithEvents btn_insert As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_insert_title As TextualControl.TextualControl
    Friend WithEvents txt_insert_detail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gp_Photos As System.Windows.Forms.GroupBox
    Friend WithEvents btn_full As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Manual_Delete_1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnl_open As System.Windows.Forms.PictureBox
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btn_Close As DevComponents.DotNetBar.ButtonX
    Friend WithEvents pnl As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_CountPics As System.Windows.Forms.ToolStripStatusLabel
End Class
