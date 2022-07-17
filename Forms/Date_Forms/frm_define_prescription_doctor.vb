Imports System.IO

Public Class frm_define_prescription_doctor

    Public ID_Reception As Long
    Public ID_File As Long
    Public ID_Doctor As Long
    Public Doctor_name As String

    Dim cl_file As New cl_files
    Dim cl_prescription As New cl_prescription

    Private Sub frm_define_prescription_doctor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Select_prescriptionTableAdapter.Fill(Me.Ds_prescription.Select_prescription, ID_Doctor, ID_File)
        Me.Select_RecordForFileTableAdapter.Fill(Me.Ds_RecordTitle.Select_RecordForFile, ID_File)
        Dgv_Prescription.Columns(0).Visible = False
        lbl_DoctorName.Text = Doctor_name
        dgv_Info_Complete.DataSource = cl_file.Select_File_Information_Complete(ID_File).Tables(0)
        dgv_Info_Complete.Columns(0).Width = 120
        dgv_Info_Complete.Columns(1).Width = 560
        getInfo(ID_File)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub getInfo(ByVal ID_FILE As Long)
        Try
            Dim file() As Byte = cl_file.Get_Avatar_File(ID_FILE)
            Dim MS As New MemoryStream()
            MS.Write(file, 0, file.Length)
            PictureBox.Image = Bitmap.FromStream(MS)

        Catch ex As Exception
            PictureBox.Image = My.Resources.ResourceManager.GetObject("avatar")
        End Try

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

    Private Sub btnInsertVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertVisit.Click

        Select Case cl_prescription.Insert_Prescription(ID_Reception, ID_Doctor, txt_Drug.Text, txt_Detail.Text)
            Case 0
                txt_Detail.Text = ""
                txt_Drug.Text = ""
                MessageBox.Show("ویزیت مورد نظر با موفقیت ثبت شد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Select_prescriptionTableAdapter.Fill(Me.Ds_prescription.Select_prescription, ID_Doctor, ID_File)
            Case 1
                MessageBox.Show("فیلدهای کلیدی (تشریح ویزیت - تجویز دارو) باید پر شود.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 2
                MessageBox.Show("خطایی رخ داده است")
        End Select

    End Sub

    Private Sub Dgv_Prescription_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgv_Prescription.DoubleClick
        frm_edit_prescription.ID_Prescription = Dgv_Prescription.Rows(Dgv_Prescription.CurrentRow.Index).Cells(0).Value.ToString
        frm_edit_prescription.CheckDrug = Dgv_Prescription.Rows(Dgv_Prescription.CurrentRow.Index).Cells(5).Value
        frm_edit_prescription.Prescription = Dgv_Prescription.Rows(Dgv_Prescription.CurrentRow.Index).Cells(3).Value.ToString
        frm_edit_prescription.Detail = Dgv_Prescription.Rows(Dgv_Prescription.CurrentRow.Index).Cells(6).Value.ToString
        frm_edit_prescription.ShowDialog()
        Me.Select_prescriptionTableAdapter.Fill(Me.Ds_prescription.Select_prescription, ID_Doctor, ID_File)
    End Sub

End Class