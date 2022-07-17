Public Class frm_information_surgery

    Public Shared ID_Surgery As Long
    Dim cl_surgery As New cl_Surgery

    Private Sub frm_information_surgery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            With cl_surgery.Select_SurgeryWithID(ID_Surgery)

                lbl_Title.Text = .Rows(0)("surgery_title").ToString
                lbl_DateSurgery.Text = ShamsiDate.Miladi2Shamsi(.Rows(0)("Surgery_Date").ToString, ShamsiDate.ShowType.LongDate)

                If .Rows(0)("type").ToString = "0" Then
                    lbl_Type.Text = "انجام نشده"
                ElseIf .Rows(0)("type").ToString = "1" Then
                    lbl_Type.Text = "انجام شده"
                End If

                lbl_dateDone.Text = ShamsiDate.Miladi2Shamsi(.Rows(0)("done_date").ToString, ShamsiDate.ShowType.ShortDate)

                lbl_detail_done.Text = .Rows(0)("detail").ToString
                lbl_result.Text = .Rows(0)("result").ToString
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

End Class