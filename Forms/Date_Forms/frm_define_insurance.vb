Public Class frm_define_insurance

    Dim cl As New cl_insurance

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_define_insurance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Select_insuranceTableAdapter.Fill(Me.Ds_insurance.Select_insurance)
    End Sub

    Private Sub btn_Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Insert.Click

        If txt_percentage.Text.Length > 2 Then
            MessageBox.Show("مقدار درصد نمی تواند عددی بیش از دو رقم باشد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Select Case cl.Insert_Insurance(txt_name.Text, txt_percentage.Text.Trim)
            Case 0
                MessageBox.Show("بیمه مورد نظر به درستی اعمال شد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Select_insuranceTableAdapter.Fill(Me.Ds_insurance.Select_insurance)
                txt_name.Text = ""
                txt_percentage.Text = ""
            Case 1
                MessageBox.Show("فیلدهای کلیدی باید پر شود.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 2
                MessageBox.Show("خطایی رخ داده است")
        End Select

    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim frm As New frm_edit_insurance
        frm.ID_Insurance = dgv.SelectedCells(0).Value.ToString
        frm.Name_Insurance = dgv.SelectedCells(1).Value.ToString
        frm.Percentage_Insurance = dgv.SelectedCells(2).Value.ToString.Trim
        frm.ShowDialog()
        Me.Select_insuranceTableAdapter.Fill(Me.Ds_insurance.Select_insurance)
    End Sub
End Class