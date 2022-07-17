<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_search_Files_byCodeFile
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_SearchFile = New System.Windows.Forms.Label()
        Me.txt_CodeFile = New TextualControl.TextualControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Cancel = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Close = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.dgv_attribiutes = New System.Windows.Forms.DataGridView()
        Me.btnDetail = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_attribiutes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_SearchFile)
        Me.GroupBox1.Controls.Add(Me.txt_CodeFile)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(757, 84)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "جستجو ..."
        '
        'btn_SearchFile
        '
        Me.btn_SearchFile.AutoSize = True
        Me.btn_SearchFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SearchFile.ForeColor = System.Drawing.Color.Blue
        Me.btn_SearchFile.Location = New System.Drawing.Point(282, 14)
        Me.btn_SearchFile.Name = "btn_SearchFile"
        Me.btn_SearchFile.Size = New System.Drawing.Size(116, 13)
        Me.btn_SearchFile.TabIndex = 8
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
        Me.txt_CodeFile.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.No
        Me.txt_CodeFile.__Type = TextualControl.TextualControl.No.Numeric
        Me.txt_CodeFile.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_CodeFile.Location = New System.Drawing.Point(269, 34)
        Me.txt_CodeFile.Name = "txt_CodeFile"
        Me.txt_CodeFile.Size = New System.Drawing.Size(218, 40)
        Me.txt_CodeFile.TabIndex = 7
        Me.txt_CodeFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(404, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "شماره پرونده:"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Cancel.Location = New System.Drawing.Point(965, 504)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(54, 52)
        Me.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Cancel.TabIndex = 3
        Me.btn_Cancel.Text = "خروج"
        '
        'btn_Close
        '
        Me.btn_Close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_Close.Location = New System.Drawing.Point(7, 452)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(169, 23)
        Me.btn_Close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Close.TabIndex = 8
        Me.btn_Close.Text = "خروج"
        '
        'PictureBox
        '
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox.Location = New System.Drawing.Point(7, 95)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(169, 214)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 9
        Me.PictureBox.TabStop = False
        '
        'dgv_attribiutes
        '
        Me.dgv_attribiutes.BackgroundColor = System.Drawing.Color.White
        Me.dgv_attribiutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_attribiutes.ColumnHeadersVisible = False
        Me.dgv_attribiutes.Location = New System.Drawing.Point(182, 95)
        Me.dgv_attribiutes.Name = "dgv_attribiutes"
        Me.dgv_attribiutes.RowHeadersVisible = False
        Me.dgv_attribiutes.Size = New System.Drawing.Size(580, 380)
        Me.dgv_attribiutes.TabIndex = 10
        '
        'btnDetail
        '
        Me.btnDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDetail.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDetail.Location = New System.Drawing.Point(7, 315)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(169, 88)
        Me.btnDetail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDetail.TabIndex = 11
        Me.btnDetail.Text = "مشاهده جزییات"
        '
        'frm_search_Files_byCodeFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 482)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDetail)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.dgv_attribiutes)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_search_Files_byCodeFile"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "لیست پرونده های بیماران"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_attribiutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_CodeFile As TextualControl.TextualControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Marriage1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_SearchFile As System.Windows.Forms.Label
    Friend WithEvents btn_Close As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents dgv_attribiutes As System.Windows.Forms.DataGridView
    Friend WithEvents btnDetail As DevComponents.DotNetBar.ButtonX
End Class
