<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_edit_Priority
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
        Me.txtP = New TextualControl.TextualControl()
        Me.SuspendLayout()
        '
        'txtP
        '
        Me.txtP.__AfterColorFocus = System.Drawing.Color.Empty
        Me.txtP.__CharNotEnter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtP.__CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtP.__ColorFocus = System.Drawing.Color.Empty
        Me.txtP.__JustLanguage = TextualControl.TextualControl.JustZaban.Just_Zaban
        Me.txtP.__Language = TextualControl.TextualControl.Zaban.Engilsh
        Me.txtP.__NextFocuse = False
        Me.txtP.__SelectAllFocuse = TextualControl.TextualControl.SelectAllText.No
        Me.txtP.__Type = TextualControl.TextualControl.No.Numeric
        Me.txtP.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP.Location = New System.Drawing.Point(12, 12)
        Me.txtP.Name = "txtP"
        Me.txtP.Size = New System.Drawing.Size(151, 85)
        Me.txtP.TabIndex = 0
        Me.txtP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm_edit_Priority
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(176, 110)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtP)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_edit_Priority"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  تغییر اولویت نوبت"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtP As TextualControl.TextualControl
End Class
