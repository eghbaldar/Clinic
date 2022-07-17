Public Class frm_show_period_Todday

    Dim cl_period As New cl_period

    Private Sub frm_show_period_Todday_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Select_doctor_for_GroupSickTableAdapter.Fill(Me.Ds_Personal.Select_doctor_for_GroupSick)
        dgv.DataSource = cl_period.Select_Period_ByDate(cmb_doctor.SelectedValue, Now).Tables(0)
        AjustingDataGrid()
        lblDateToday.Text = ShamsiDate.Miladi2Shamsi(Now, ShamsiDate.ShowType.LongDate)
    End Sub

    Sub AjustingDataGrid()
        dgv.Columns(0).Visible = False
        dgv.Columns(1).Visible = False
        dgv.Columns("Date_Period").Width = 190
        dgv.Columns("Date_Period").HeaderText = "تارخ نوبت"

        dgv.Columns("Time_Period").HeaderText = "زمان نوبت"
        dgv.Columns("Time_Period").DefaultCellStyle.Font = New Font("Tahoma", 11, FontStyle.Bold)
        dgv.Columns("Time_Period").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgv.Columns("Patient").Width = 140
        dgv.Columns("Patient").HeaderText = "نام بیمار"

        dgv.Columns("Status").HeaderText = "وضعیت نوبت"

        dgv.Columns(4).Visible = False
        dgv.Columns("Way").HeaderText = "طریقه نوبت"

        dgv.Columns("Doctor").HeaderText = "پزشک معالج"

        dgv.Columns("Shape_Period").HeaderText = "حالت نوبت"

        dgv.Columns("User").HeaderText = "کاربر"

        dgv.Columns(8).Visible = False
        dgv.Columns(10).Visible = False
        dgv.Columns(12).Visible = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cmb_doctor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_doctor.SelectedIndexChanged
        dgv.DataSource = cl_period.Select_Period_ByDate(cmb_doctor.SelectedValue, Now).Tables(0)
    End Sub

    Private Sub mnu_DeletePeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_DeletePeriod.Click
        If dgv.Rows(dgv.CurrentRow.Index).Cells("id").Value.ToString <> "" Then
            If MessageBox.Show("آیا از حذف این نوبت مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                cl_period.Delete_Period(dgv.Rows(dgv.CurrentRow.Index).Cells("id").Value.ToString)
                dgv.DataSource = cl_period.Select_Period_ByDate(cmb_doctor.SelectedValue, Now).Tables(0)
            End If
        End If
    End Sub

End Class