Public Class frm_information_reception

    Dim cl_reception As New cl_reception
    Public ID_Reception As Long

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frm_information_reception_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgv.DataSource = cl_reception.Select_Information_Reception(ID_Reception).Tables(0)
        dgv.Columns(1).Width = 290
    End Sub
End Class