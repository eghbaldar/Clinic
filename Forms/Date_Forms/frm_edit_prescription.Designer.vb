<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_edit_prescription
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
        Me.btnInsertVisit = New DevComponents.DotNetBar.ButtonX()
        Me.btnFontDrug = New System.Windows.Forms.Button()
        Me.btnFontDetail = New System.Windows.Forms.Button()
        Me.txt_Drug = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Detail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.chkDrug = New System.Windows.Forms.CheckBox()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInsertVisit
        '
        Me.btnInsertVisit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnInsertVisit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnInsertVisit.Location = New System.Drawing.Point(16, 696)
        Me.btnInsertVisit.Name = "btnInsertVisit"
        Me.btnInsertVisit.Size = New System.Drawing.Size(561, 34)
        Me.btnInsertVisit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnInsertVisit.TabIndex = 20
        Me.btnInsertVisit.Text = "ذخیره سازی"
        '
        'btnFontDrug
        '
        Me.btnFontDrug.Location = New System.Drawing.Point(14, 374)
        Me.btnFontDrug.Name = "btnFontDrug"
        Me.btnFontDrug.Size = New System.Drawing.Size(24, 23)
        Me.btnFontDrug.TabIndex = 19
        Me.btnFontDrug.Text = "F"
        Me.btnFontDrug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFontDrug.UseVisualStyleBackColor = True
        '
        'btnFontDetail
        '
        Me.btnFontDetail.Location = New System.Drawing.Point(14, 34)
        Me.btnFontDetail.Name = "btnFontDetail"
        Me.btnFontDetail.Size = New System.Drawing.Size(24, 23)
        Me.btnFontDetail.TabIndex = 18
        Me.btnFontDetail.Text = "F"
        Me.btnFontDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFontDetail.UseVisualStyleBackColor = True
        '
        'txt_Drug
        '
        Me.txt_Drug.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_Drug.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txt_Drug.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Drug.Location = New System.Drawing.Point(16, 404)
        Me.txt_Drug.Multiline = True
        Me.txt_Drug.Name = "txt_Drug"
        Me.txt_Drug.Size = New System.Drawing.Size(685, 255)
        Me.txt_Drug.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(649, 379)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "تجویز دارو:"
        '
        'txt_Detail
        '
        Me.txt_Detail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_Detail.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txt_Detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Detail.Location = New System.Drawing.Point(14, 63)
        Me.txt_Detail.Multiline = True
        Me.txt_Detail.Name = "txt_Detail"
        Me.txt_Detail.Size = New System.Drawing.Size(686, 308)
        Me.txt_Detail.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(633, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "تشریح ویزیت:"
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.Clinic.My.Resources.Resources.btnClose
        Me.btnClose.Location = New System.Drawing.Point(16, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(39, 23)
        Me.btnClose.TabIndex = 21
        Me.btnClose.TabStop = False
        '
        'chkDrug
        '
        Me.chkDrug.AutoSize = True
        Me.chkDrug.Location = New System.Drawing.Point(446, 670)
        Me.chkDrug.Name = "chkDrug"
        Me.chkDrug.Size = New System.Drawing.Size(256, 17)
        Me.chkDrug.TabIndex = 22
        Me.chkDrug.Text = "آیا دارو گرفته شده توسط بیمار بررسی شده است؟"
        Me.chkDrug.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDelete.Location = New System.Drawing.Point(583, 696)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(117, 34)
        Me.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "حذف ویزیت"
        '
        'frm_edit_prescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 735)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.chkDrug)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnInsertVisit)
        Me.Controls.Add(Me.btnFontDrug)
        Me.Controls.Add(Me.btnFontDetail)
        Me.Controls.Add(Me.txt_Drug)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Detail)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_edit_prescription"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " جزییات ویزیت"
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInsertVisit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnFontDrug As System.Windows.Forms.Button
    Friend WithEvents btnFontDetail As System.Windows.Forms.Button
    Friend WithEvents txt_Drug As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Detail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents chkDrug As System.Windows.Forms.CheckBox
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
End Class
