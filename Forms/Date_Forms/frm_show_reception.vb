Public Class frm_show_reception

    Dim cl_reception As New cl_reception

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frm_show_reception_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Select_doctor_for_GroupSickTableAdapter.Fill(Me.Ds_Personal.Select_doctor_for_GroupSick)
        FillGrid()
        AjustingDataGrid()
    End Sub

    Private Sub cmb_doctor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_doctor.SelectedIndexChanged
        FillGrid()
    End Sub

    Private Sub FillGrid()
        dgv.DataSource = cl_reception.Select_Reception_Reception(cmb_doctor.SelectedValue, ShamsiDate.ShamsiToMiladi(txt_date.Text)).Tables(0)
    End Sub

    Sub AjustingDataGrid()
        dgv.Columns("id").Visible = False
        dgv.Columns("id_file").Visible = False
        dgv.Columns("Patient").HeaderText = "نام بیمار"

        dgv.Columns("User").HeaderText = "کاربر"

        dgv.Columns("Date_Visit").HeaderText = "تاریخ ویزیت شده"
        dgv.Columns("Date_Visit").Width = "140"
        dgv.Columns("Insurance").HeaderText = "نوع بیمه"

        dgv.Columns("Doctor").HeaderText = "پزشک معالح"

        dgv.Columns("Tarefeh").HeaderText = "تعرفه اخذ شده"
        dgv.Columns("Tarefeh").Width = "120"

        dgv.Columns("Takhfif").HeaderText = "تخفیف داده شده"
        dgv.Columns("Takhfif").Width = "120"
        dgv.Columns("Ghabele_Pardakht").HeaderText = "مبلغ قابل پرداخت"
        dgv.Columns("Ghabele_Pardakht").Width = "120"

        dgv.Columns("Daryaft_shode").HeaderText = "مبلغ اخذ شده"
        dgv.Columns("Money_Status").HeaderText = "وضغیت مالی"
        dgv.Columns("Money_Status").Width = "200"

        dgv.Columns("Serial_Card").HeaderText = "سریال دفترچه"
        dgv.Columns("Expire_Card").HeaderText = "تاریخ انقضا دفترچه"
        dgv.Columns("Expire_Card").Width = "120"
        dgv.Columns("Number_Card").HeaderText = "شماره صفحه"
        dgv.Columns("Detail").HeaderText = "توضیحات"

    End Sub

    Private Sub mnu_DeleteReception_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_DeleteReception.Click
        Try
            If dgv.Rows(dgv.CurrentRow.Index).Cells("id").Value.ToString <> 0 Then
                If MessageBox.Show("آیا از حذف این پذیرش مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    cl_reception.Delete_Reception(Val(dgv.Rows(dgv.CurrentRow.Index).Cells("id").Value.ToString))
                    FillGrid()
                End If
            End If
        Catch ex As Exception
            If Err.Number = 91 Then MessageBox.Show("رکوردی انتخاب نشده است", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        FillGrid()
    End Sub

End Class