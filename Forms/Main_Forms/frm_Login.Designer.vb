<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
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
        Me.btnLogin = New DevComponents.DotNetBar.ButtonX()
        Me.btnEnd = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_User = New TextualControl.TextualControl()
        Me.txt_pass = New TextualControl.TextualControl()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLogin.Location = New System.Drawing.Point(12, 144)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(122, 23)
        Me.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "ورود"
        '
        'btnEnd
        '
        Me.btnEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEnd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEnd.Location = New System.Drawing.Point(140, 144)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(122, 23)
        Me.btnEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEnd.TabIndex = 1
        Me.btnEnd.Text = "خروج"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "نام کاربری:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "کلمه عبور:"
        '
        'txt_User
        '
        Me.txt_User.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_User.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_User.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_User.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_User.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban_Characters
        Me.txt_User.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_User.__NextFocuse = True
        Me.txt_User.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_User.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_User.Location = New System.Drawing.Point(92, 77)
        Me.txt_User.Name = "txt_User"
        Me.txt_User.Size = New System.Drawing.Size(171, 21)
        Me.txt_User.TabIndex = 4
        '
        'txt_pass
        '
        Me.txt_pass.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txt_pass.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pass.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pass.__ColorFocus = System.Drawing.Color.Empty
        Me.txt_pass.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban_Characters
        Me.txt_pass.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txt_pass.__NextFocuse = True
        Me.txt_pass.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txt_pass.__Type = TextualControl.TextualControl.No.Normal
        Me.txt_pass.Location = New System.Drawing.Point(92, 106)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(170, 21)
        Me.txt_pass.TabIndex = 5
        '
        'frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 174)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_User)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnLogin)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_Login"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ورود کاربران"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEnd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_User As TextualControl.TextualControl
    Friend WithEvents txt_pass As TextualControl.TextualControl
End Class
