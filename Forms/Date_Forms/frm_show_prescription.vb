Public Class frm_show_prescription

    Dim cl_prescription As New cl_prescription

    Private Sub cmb_doctor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_doctor.SelectedIndexChanged
        Me.Select_prescription_allTableAdapter.Fill(Me.Ds_prescription.Select_prescription_all, cmb_doctor.SelectedValue)
    End Sub

    Private Sub frm_show_prescription_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Select_doctor_for_GroupSickTableAdapter.Fill(Me.Ds_Personal.Select_doctor_for_GroupSick)
        Me.Select_prescription_allTableAdapter.Fill(Me.Ds_prescription.Select_prescription_all, cmb_doctor.SelectedValue)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgv_Prescription.DoubleClick
        frm_edit_prescription.ID_Prescription = Dgv_Prescription.Rows(Dgv_Prescription.CurrentRow.Index).Cells(0).Value.ToString
        frm_edit_prescription.CheckDrug = Dgv_Prescription.Rows(Dgv_Prescription.CurrentRow.Index).Cells(5).Value
        frm_edit_prescription.Prescription = Dgv_Prescription.Rows(Dgv_Prescription.CurrentRow.Index).Cells(3).Value.ToString
        frm_edit_prescription.Detail = Dgv_Prescription.Rows(Dgv_Prescription.CurrentRow.Index).Cells(6).Value.ToString
        frm_edit_prescription.ShowDialog()
        Me.Select_prescription_allTableAdapter.Fill(Me.Ds_prescription.Select_prescription_all, cmb_doctor.SelectedValue)
    End Sub

    Private Sub btn_DeleteVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DeleteVisit.Click
        If Dgv_Prescription.RowCount > 0 Then
            If MessageBox.Show("آیا از حذف این ویزیت مطمئن هستید؟", "نوجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cl_prescription.Delete_Prescription(Dgv_Prescription.Rows(Dgv_Prescription.CurrentRow.Index).Cells(0).Value.ToString)
                Me.Select_prescription_allTableAdapter.Fill(Me.Ds_prescription.Select_prescription_all, cmb_doctor.SelectedValue)
            End If
        End If
    End Sub

End Class