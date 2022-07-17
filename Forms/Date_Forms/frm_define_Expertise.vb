Public Class frm_define_Expertise

    Dim cl As New cl_expertise

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Insert.Click

        Select Case cl.Insert_Expertise(txt_Expertise.Text, False)
            Case 0
                Me.Select_expertiseTableAdapter.Fill(Me.Ds_Expertise.Select_expertise, False)
                txt_Expertise.Text = ""
            Case 1
                MessageBox.Show("فیلد کلیدی (تخصص) باید پر شود.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 2
                MessageBox.Show("خطایی رخ داده است")
        End Select

    End Sub

    Private Sub frm_Expertise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Select_expertiseTableAdapter.Fill(Me.Ds_Expertise.Select_expertise, False)
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        Try
            If dgv.SelectedCells(0).Value.ToString <> "" Then
                If MessageBox.Show("آیا حذف این تخصص مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    cl.Delete_Expertise(dgv.SelectedCells(0).Value.ToString)
                    Me.Select_expertiseTableAdapter.Fill(Me.Ds_Expertise.Select_expertise, False)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class