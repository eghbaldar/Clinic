Public Class frm_define_priority

    Dim cl_Priority As New cl_priority
    Public _Doctor As Long

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frm_define_priority_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Select_doctor_for_GroupSickTableAdapter.Fill(Me.Ds_Personal.Select_doctor_for_GroupSick)
        dgv.DataSource = cl_Priority.Select_Period_SetPriority(cmb_doctor.SelectedValue).Tables(0)
        cmb_doctor.SelectedValue = _Doctor
        AjustingDataGrid()
    End Sub

    Private Sub cmb_doctor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_doctor.SelectedIndexChanged
        dgv.DataSource = cl_Priority.Select_Period_SetPriority(cmb_doctor.SelectedValue).Tables(0)
    End Sub

    Sub AjustingDataGrid()

        dgv.Columns("id").Visible = False

        dgv.Columns("Patient").HeaderText = "نام بیمار"
        dgv.Columns("Patient").Width = "200"

        dgv.Columns("Priority").HeaderText = "اولویت نوبت"
        dgv.Columns("Priority").DefaultCellStyle.Font = New Font("Tahoma", 11, FontStyle.Bold)
        dgv.Columns("Priority").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns("Priority").DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#9c3535")
        dgv.Columns("Priority").DefaultCellStyle.ForeColor = Color.White

        dgv.Columns("Shape_Period").HeaderText = "حالت نوبت"

        dgv.Columns("SDate_Period").HeaderText = "تاریخ نوبت"
        dgv.Columns("SDate_Period").Width = "130"

        dgv.Columns("Time_Period").HeaderText = "زمان نوبت"

    End Sub

    Private Sub dgv_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv.DoubleClick
        frm_edit_Priority._ID_Period = dgv.Rows(dgv.CurrentRow.Index).Cells("id").Value.ToString
        frm_edit_Priority._Priority = dgv.Rows(dgv.CurrentRow.Index).Cells("priority").Value.ToString
        frm_edit_Priority.ShowDialog()
        dgv.DataSource = cl_Priority.Select_Period_SetPriority(cmb_doctor.SelectedValue).Tables(0)
    End Sub

End Class