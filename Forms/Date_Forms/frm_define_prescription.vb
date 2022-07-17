Public Class frm_define_prescription

    Dim cl_reception As New cl_reception

    Private Sub frm_define_prescription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Select_doctor_for_GroupSickTableAdapter.Fill(Me.Ds_Personal.Select_doctor_for_GroupSick)
        txt_date.Text = ShamsiDate.MiladiToShamsiFull(Now)
        FillGrid()
        AjustingDataGrid()
    End Sub

    Private Sub FillGrid()
        dgv.DataSource = cl_reception.Select_Reception(cmb_doctor.SelectedValue, ShamsiDate.ShamsiToMiladi(txt_date.Text)).Tables(0)
    End Sub

    Sub AjustingDataGrid()
        dgv.Columns("id").Visible = False
        dgv.Columns("id_file").Visible = False
        dgv.Columns("Patient").HeaderText = "نام بیمار"
        dgv.Columns("User").HeaderText = "کاربر"
        dgv.Columns("Date_Visit").HeaderText = "تاریخ ویزیت شده"
        dgv.Columns("Date_Visit").Width = "140"
        dgv.Columns("Insurance").HeaderText = "نوع بیمه"
        dgv.Columns("Doctor").Visible = False
        dgv.Columns("Tarefeh").Visible = False
        dgv.Columns("Takhfif").Visible = False
        dgv.Columns("Daryaft_shode").Visible = False
        dgv.Columns("Money_Status").Visible = False
        dgv.Columns("Serial_Card").Visible = False
        dgv.Columns("Expire_Card").Visible = False
        dgv.Columns("Number_Card").Visible = False
        dgv.Columns("Number_Card").Visible = False
        dgv.Columns("Detail").Visible = False
        dgv.Columns("Ghabele_Pardakht").Visible = False
    End Sub

    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cmb_doctor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_doctor.SelectedIndexChanged
        FillGrid()
    End Sub

    Private Sub btnShowALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowALL.Click
        frm_show_reception.Show()
    End Sub

    Private Sub btnShowDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDetail.Click
        frm_information_reception.ID_Reception = dgv.Rows(dgv.CurrentRow.Index).Cells("id").Value.ToString
        frm_information_reception.ShowDialog()
    End Sub

    Private Sub btnVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisit.Click
        If dgv.RowCount > 0 Then
            frm_define_prescription_doctor.ID_Reception = dgv.Rows(dgv.CurrentRow.Index).Cells("id").Value.ToString
            frm_define_prescription_doctor.ID_File = dgv.Rows(dgv.CurrentRow.Index).Cells("ID_File").Value.ToString
            frm_define_prescription_doctor.Doctor_name = dgv.Rows(dgv.CurrentRow.Index).Cells("Doctor").Value.ToString
            frm_define_prescription_doctor.ID_Doctor = dgv.Rows(dgv.CurrentRow.Index).Cells("ID_Doctor").Value.ToString
            frm_define_prescription_doctor.ShowDialog()
            FillGrid()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        FillGrid()
    End Sub

End Class