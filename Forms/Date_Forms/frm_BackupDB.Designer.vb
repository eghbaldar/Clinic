<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BackupDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_BackupDB))
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.btnRestore = New DevComponents.DotNetBar.ButtonX()
        Me.btnBackUp = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_Server = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Location = New System.Drawing.Point(7, 404)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "خروج"
        '
        'btnRestore
        '
        Me.btnRestore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRestore.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnRestore.Location = New System.Drawing.Point(7, 154)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 20, 20, 2)
        Me.btnRestore.Size = New System.Drawing.Size(316, 49)
        Me.btnRestore.TabIndex = 10
        Me.btnRestore.Text = "بازگردان پشتیبان (Restore)"
        '
        'btnBackUp
        '
        Me.btnBackUp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBackUp.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnBackUp.Location = New System.Drawing.Point(7, 96)
        Me.btnBackUp.Name = "btnBackUp"
        Me.btnBackUp.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 20, 20, 2)
        Me.btnBackUp.Size = New System.Drawing.Size(316, 51)
        Me.btnBackUp.TabIndex = 11
        Me.btnBackUp.Text = "پشتیبان گیری (Backup)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_Server)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 86)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اطلاعات"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Clinic"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Microsoft SQL Server 2008"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(276, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "مدل:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(219, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "نام بانک اطلاعات:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(254, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "نام سرور:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(316, 189)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "تذکرات"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(3, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(306, 65)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = resources.GetString("Label7.Text")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(30, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(276, 65)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "نکته بسیار مهم:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "در هنگام پشتیبان گیری و بازگردان پشتیبان تمام برنامه های" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "باز سی" & _
            "ستم را ببندید و تا اتمام عملیات صبور بوده و از بستن" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "پنجره جاری خودداری کنید." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "م" & _
            "مکن است عملیات زمان زیادی طلب کند."
        '
        'lbl_Server
        '
        Me.lbl_Server.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_Server.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_Server.ForeColor = System.Drawing.Color.White
        Me.lbl_Server.Location = New System.Drawing.Point(6, 40)
        Me.lbl_Server.Name = "lbl_Server"
        Me.lbl_Server.Size = New System.Drawing.Size(206, 21)
        Me.lbl_Server.TabIndex = 12
        Me.lbl_Server.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.lbl_Server, "لطفا به این قسمت را تغییر ندهید.")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 10
        Me.ToolTip1.ReshowDelay = 100
        '
        'frm_BackupDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 433)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBackUp)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_BackupDB"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "پشتبان گیری"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnRestore As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBackUp As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_Server As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
