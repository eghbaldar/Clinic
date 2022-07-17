<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_information_surgery
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
        Me.lbl_Title = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_DateSurgery = New System.Windows.Forms.TextBox()
        Me.lbl_detail_done = New System.Windows.Forms.TextBox()
        Me.lbl_Type = New System.Windows.Forms.TextBox()
        Me.lbl_dateDone = New System.Windows.Forms.TextBox()
        Me.lbl_result = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_Close = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_Title.Location = New System.Drawing.Point(106, 12)
        Me.lbl_Title.Multiline = True
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.ReadOnly = True
        Me.lbl_Title.Size = New System.Drawing.Size(209, 20)
        Me.lbl_Title.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "توضیحات:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 13)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "تاریخ انجام شده:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(46, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "وضعیت:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "تاریخ جراحی:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "عنوان:"
        '
        'lbl_DateSurgery
        '
        Me.lbl_DateSurgery.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_DateSurgery.Location = New System.Drawing.Point(106, 39)
        Me.lbl_DateSurgery.Multiline = True
        Me.lbl_DateSurgery.Name = "lbl_DateSurgery"
        Me.lbl_DateSurgery.ReadOnly = True
        Me.lbl_DateSurgery.Size = New System.Drawing.Size(209, 20)
        Me.lbl_DateSurgery.TabIndex = 54
        '
        'lbl_detail_done
        '
        Me.lbl_detail_done.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_detail_done.Location = New System.Drawing.Point(106, 65)
        Me.lbl_detail_done.Multiline = True
        Me.lbl_detail_done.Name = "lbl_detail_done"
        Me.lbl_detail_done.ReadOnly = True
        Me.lbl_detail_done.Size = New System.Drawing.Size(585, 77)
        Me.lbl_detail_done.TabIndex = 55
        '
        'lbl_Type
        '
        Me.lbl_Type.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_Type.Location = New System.Drawing.Point(106, 155)
        Me.lbl_Type.Multiline = True
        Me.lbl_Type.Name = "lbl_Type"
        Me.lbl_Type.ReadOnly = True
        Me.lbl_Type.Size = New System.Drawing.Size(209, 20)
        Me.lbl_Type.TabIndex = 56
        '
        'lbl_dateDone
        '
        Me.lbl_dateDone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_dateDone.Location = New System.Drawing.Point(106, 185)
        Me.lbl_dateDone.Multiline = True
        Me.lbl_dateDone.Name = "lbl_dateDone"
        Me.lbl_dateDone.ReadOnly = True
        Me.lbl_dateDone.Size = New System.Drawing.Size(209, 20)
        Me.lbl_dateDone.TabIndex = 57
        '
        'lbl_result
        '
        Me.lbl_result.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_result.Location = New System.Drawing.Point(106, 211)
        Me.lbl_result.Multiline = True
        Me.lbl_result.Name = "lbl_result"
        Me.lbl_result.ReadOnly = True
        Me.lbl_result.Size = New System.Drawing.Size(585, 89)
        Me.lbl_result.TabIndex = 58
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 252)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "نتایج جراحی:"
        '
        'btn_Close
        '
        Me.btn_Close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Close.Location = New System.Drawing.Point(616, 309)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 23)
        Me.btn_Close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Close.TabIndex = 60
        Me.btn_Close.Text = "رویت شد"
        '
        'frm_information_surgery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(704, 341)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_result)
        Me.Controls.Add(Me.lbl_dateDone)
        Me.Controls.Add(Me.lbl_Type)
        Me.Controls.Add(Me.lbl_detail_done)
        Me.Controls.Add(Me.lbl_DateSurgery)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_Title)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_information_surgery"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اطلاعات جراحی"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Title As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_DateSurgery As System.Windows.Forms.TextBox
    Friend WithEvents lbl_detail_done As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Type As System.Windows.Forms.TextBox
    Friend WithEvents lbl_dateDone As System.Windows.Forms.TextBox
    Friend WithEvents lbl_result As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_Close As DevComponents.DotNetBar.ButtonX
End Class
