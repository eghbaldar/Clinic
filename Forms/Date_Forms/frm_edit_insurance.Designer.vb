<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_edit_insurance
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
        Me.btn_update = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_percentage = New TextualControl.TextualControl()
        Me.txt_name = New TextualControl.TextualControl()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_update.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_update.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_update.Location = New System.Drawing.Point(0, 67)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(278, 35)
        Me.btn_update.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_update.TabIndex = 0
        Me.btn_update.Text = "بروز رسانی"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "(درصد)"
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
        Me.txt_percentage.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_percentage.Location = New System.Drawing.Point(125, 12)
        Me.txt_percentage.Name = "txt_percentage"
        Me.txt_percentage.Size = New System.Drawing.Size(100, 43)
        Me.txt_percentage.TabIndex = 3
        Me.txt_percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.txt_name.Location = New System.Drawing.Point(10, 23)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 21)
        Me.txt_name.TabIndex = 4
        '
        'frm_edit_insurance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 102)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_percentage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_update)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_edit_insurance"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بیمه"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_update As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_percentage As TextualControl.TextualControl
    Friend WithEvents txt_name As TextualControl.TextualControl
End Class
