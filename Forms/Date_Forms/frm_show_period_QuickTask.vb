Public Class frm_show_period_QuickTask
    Dim cl_period As New cl_period
    Private Sub frm_show_period_QuickTask_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Select_doctor_for_GroupSickTableAdapter.Fill(Me.Ds_Personal.Select_doctor_for_GroupSick)

        With cl_period.Select_Period_ByDate(cmb_doctor.SelectedValue, Now)
            If .Tables(0).Rows.Count > 0 Then
                dgv_Period.DataSource = .Tables(0)

                dgv_Period.Columns(0).Visible = False
                dgv_Period.Columns(1).Visible = False
                dgv_Period.Columns("Date_Period").Width = 110
                dgv_Period.Columns("Date_Period").HeaderText = "تارخ نوبت"

                dgv_Period.Columns("Time_Period").HeaderText = "زمان نوبت"
                dgv_Period.Columns("Time_Period").DefaultCellStyle.Font = New Font("Tahoma", 11, FontStyle.Bold)
                dgv_Period.Columns("Time_Period").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                dgv_Period.Columns("Patient").Width = 110
                dgv_Period.Columns("Patient").HeaderText = "نام بیمار"

                dgv_Period.Columns("Status").HeaderText = "وضعیت نوبت"

                dgv_Period.Columns("Shape_Period").Visible = False
                dgv_Period.Columns(4).Visible = False
                dgv_Period.Columns("Way").Visible = False
                dgv_Period.Columns("User").Visible = False
                dgv_Period.Columns("Doctor").Visible = False
                dgv_Period.Columns(8).Visible = False
                dgv_Period.Columns(10).Visible = False
                dgv_Period.Columns(12).Visible = False
            End If
        End With
    End Sub
    Private Sub cmb_doctor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dgv_Period.DataSource = cl_period.Select_Period_ByDate(cmb_doctor.SelectedValue, Now).Tables(0)
    End Sub
End Class