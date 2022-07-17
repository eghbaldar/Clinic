Public Class frm_define_recordTitle

    Dim cl As New cl_RecordTitle

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_define_recordTitle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Select_doctor_for_GroupSickTableAdapter.Fill(Me.Ds_Personal.Select_doctor_for_GroupSick)
        Me.Select_RecordTitleTableAdapter.Fill(Me.Ds_RecordTitle.Select_RecordTitle, cmd_doctor.SelectedValue)

    End Sub

    Private Sub btn_Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Insert.Click
        Select Case cl.Insert_RecordTitle(cmd_doctor.SelectedValue, txt_RecordTitle.Text)
            Case 0
                Me.Select_RecordTitleTableAdapter.Fill(Me.Ds_RecordTitle.Select_RecordTitle, cmd_doctor.SelectedValue)
                txt_RecordTitle.Text = ""
            Case 1
                MessageBox.Show("فیلدهای کلیدی باید پر شود.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 2
                MessageBox.Show("خطایی رخ داده است")
        End Select
    End Sub

    Private Sub cmd_doctor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_doctor.SelectedIndexChanged
        Me.Select_RecordTitleTableAdapter.Fill(Me.Ds_RecordTitle.Select_RecordTitle, cmd_doctor.SelectedValue)
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        Try
            If MessageBox.Show("با توجه به ارتباط بین سوابق بیماری و سوابق بیماران،در صورت پاک شدن سوابق، زیر مجموعه سوابق بیماران نیز پاک شده و راه برگشتی وجود ندارد. آیا مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                If dgv.SelectedCells(0).Value.ToString <> "" Then
                    cl.Delete_RecordTitle(dgv.SelectedCells(0).Value.ToString)
                    Me.Select_RecordTitleTableAdapter.Fill(Me.Ds_RecordTitle.Select_RecordTitle, cmd_doctor.SelectedValue)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub


End Class