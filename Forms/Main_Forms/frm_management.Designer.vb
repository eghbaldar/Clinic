<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_management
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
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnChoiceBG = New System.Windows.Forms.Button()
        Me.btnApply = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Location = New System.Drawing.Point(12, 79)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "خروج"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "انتخاب تصویر پس زمینه صفحه اصلی:"
        '
        'btnChoiceBG
        '
        Me.btnChoiceBG.Location = New System.Drawing.Point(12, 12)
        Me.btnChoiceBG.Name = "btnChoiceBG"
        Me.btnChoiceBG.Size = New System.Drawing.Size(129, 43)
        Me.btnChoiceBG.TabIndex = 2
        Me.btnChoiceBG.Text = "انتخاب تصویر"
        Me.btnChoiceBG.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnApply.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnApply.Location = New System.Drawing.Point(231, 79)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(96, 23)
        Me.btnApply.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnApply.TabIndex = 3
        Me.btnApply.Text = "تایید و خروج"
        '
        'frm_management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 121)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnChoiceBG)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_management"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مدیریت برنامه"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnChoiceBG As System.Windows.Forms.Button
    Friend WithEvents btnApply As DevComponents.DotNetBar.ButtonX
End Class
