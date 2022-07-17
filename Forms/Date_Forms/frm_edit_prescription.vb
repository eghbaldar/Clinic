Public Class frm_edit_prescription

    Public ID_Prescription As Long
    Public Prescription As String
    Public Detail As String
    Public CheckDrug As Boolean
    Dim cl_prescription As New cl_prescription

    Private Sub frm_edit_prescription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Fill()
    End Sub

    Sub Fill()
        txt_Drug.Text = Prescription
        txt_Detail.Text = Detail
        chkDrug.Checked = Convert.ToBoolean(CheckDrug)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnInsertVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertVisit.Click

        Dim check As String
        If chkDrug.Checked Then check = "1"
        If Not chkDrug.Checked Then check = "0"

        Select Case cl_prescription.Update_Prescription(ID_Prescription, txt_Drug.Text, check, txt_Detail.Text)
            Case 0
                MessageBox.Show("ویزیت مورد نظر با موفقیت اصلاح شد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Fill()
                Me.Close()
            Case 1
                MessageBox.Show("فیلدهای کلیدی (تشریح ویزیت - تجویز دارو) باید پر شود.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 2
                MessageBox.Show("خطایی رخ داده است")
        End Select

    End Sub

    Private Sub btnFontDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFontDetail.Click
        Dim f As New FontDialog
        f.ShowDialog()
        txt_Detail.Font = f.Font
    End Sub

    Private Sub btnFontDrug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFontDrug.Click
        Dim f As New FontDialog
        f.ShowDialog()
        txt_Drug.Font = f.Font
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("آیا از حذف این ویزیت مطمئن هستید؟", "نوجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            cl_prescription.Delete_Prescription(ID_Prescription)
            Me.Close()
        End If
    End Sub

End Class