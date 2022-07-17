Public Class frm_define_GroupSick

    Dim cl As New cl_GroupSick

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Insert.Click
        Select Case cl.Insert_GroupSick(txt_Group.Text, cmd_doctor.SelectedValue)
            Case 0
                Me.Select_Group_SickTableAdapter.Fill(Me.Ds_GroupSick.Select_Group_Sick)
                txt_Group.Text = ""
            Case 1
                MessageBox.Show("فیلدهای کلیدی باید پر شود.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 2
                MessageBox.Show("خطایی رخ داده است")
        End Select
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        Try
            If MessageBox.Show("با توجه به ارتباط بین گروه بیماران و پرونده های بیماران،در صورت پاک شدن گروه بیماران، زیر مجموعه بیماران آن گروه نیز پاک شده و راه برگشتی وجود ندارد. آیا مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                If dgv.SelectedCells(0).Value.ToString <> "" Then
                    cl.Delete_GroupSick(dgv.SelectedCells(0).Value.ToString)
                    Me.Select_Group_SickTableAdapter.Fill(Me.Ds_GroupSick.Select_Group_Sick)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frm_define_GroupSick_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Select_doctor_for_GroupSickTableAdapter.Fill(Me.Ds_Personal.Select_doctor_for_GroupSick)
        Me.Select_Group_SickTableAdapter.Fill(Me.Ds_GroupSick.Select_Group_Sick)
    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim frm As New frm_edit_groupSick
        frm.ID_GroupSick = dgv.SelectedCells(0).Value.ToString 'id group
        frm.ID_Personal = Val(dgv.SelectedCells(3).Value.ToString) 'doctor
        frm.Name_GroupSick = dgv.SelectedCells(2).Value.ToString 'name group
        frm.ShowDialog()
        Me.Select_Group_SickTableAdapter.Fill(Me.Ds_GroupSick.Select_Group_Sick)
    End Sub


End Class