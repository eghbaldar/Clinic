Imports System.IO

Public Class frm_define_reception

    Dim cl_period As New cl_period
    Dim exec As New ExecuteSP
    Dim cl_file As New cl_files
    Dim cl_reception As New cl_reception
    Dim _ID_File As Long
    Dim _ID_Period As Long
    Dim Free As Boolean 'False=insurance True=free

    Private Sub frm_define_reception_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Select_insuranceTableAdapter.Fill(Me.Ds_insurance.Select_insurance)
        Me.Select_doctor_for_GroupSickTableAdapter.Fill(Me.Ds_Personal.Select_doctor_for_GroupSick)
        dgv_Period.DataSource = cl_period.Select_Period_ByDate(cmb_doctor.SelectedValue, Now).Tables(0)
        AjustingDataGrid()
    End Sub

    Sub AjustingDataGrid()

        dgv_Period.Columns(0).Visible = False
        dgv_Period.Columns(1).Visible = False
        dgv_Period.Columns("Date_Period").Width = 135
        dgv_Period.Columns("Date_Period").HeaderText = "تارخ نوبت"

        dgv_Period.Columns("Time_Period").HeaderText = "زمان نوبت"
        dgv_Period.Columns("Time_Period").DefaultCellStyle.Font = New Font("Tahoma", 11, FontStyle.Bold)
        dgv_Period.Columns("Time_Period").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgv_Period.Columns("Patient").Width = 110
        dgv_Period.Columns("Patient").HeaderText = "نام بیمار"

        dgv_Period.Columns("Status").HeaderText = "وضعیت نوبت"

        dgv_Period.Columns("Shape_Period").Visible = False
        dgv_Period.Columns(4).Visible = False
        dgv_Period.Columns("Way").Visible = False
        dgv_Period.Columns("User").Visible = False
        dgv_Period.Columns("Doctor").Visible = False
        dgv_Period.Columns(8).Visible = False
        dgv_Period.Columns(10).Visible = False
        dgv_Period.Columns(12).Visible = False
        '''''''''''''''' change color 
        For i As Integer = 0 To dgv_Period.Rows.Count - 1
            If Not cl_reception.Check_Reception(dgv_Period.Rows(i).Cells("ID").Value.ToString) Then
                dgv_Period.Rows(i).DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#f5d0d0")
            End If
        Next

    End Sub

    Sub CheckColorDgv()
        '''''''''''''''' change color 
        For i As Integer = 0 To dgv_Period.Rows.Count - 1
            If Not cl_reception.Check_Reception(dgv_Period.Rows(i).Cells("ID").Value.ToString) Then
                dgv_Period.Rows(i).DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#f5d0d0")
            End If
        Next
    End Sub

    Private Sub cmb_doctor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_doctor.SelectedIndexChanged
        dgv_Period.DataSource = cl_period.Select_Period_ByDate(cmb_doctor.SelectedValue, Now).Tables(0)
        CheckColorDgv()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click

        If _ID_File = 0 Then
            MessageBox.Show("ابتدا بیمار را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If txt_TotalPay.Text = "" Or txt_receievd.Text = "" Or txt_Payable.Text = "" Then
            MessageBox.Show("فیلد های کلیدی باید پر شود." _
                                                                             + vbCrLf _
                                                                             + "(" _
                                                                             + "تعرفه" _
                                                                             + "دریافتی" _
                                                                             + ")" _
                                                                             , "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If Not Free Then
            'If cmb_insurance.SelectedValue <> 0 Then
            If cmb_doctor.SelectedValue <> 0 Then
                Select Case cl_reception.Insert_Receprion(_ID_File, Keep_ID_USER.ID_USER, _ID_Period, txt_TotalPay.Text, cmb_insurance_1.SelectedValue, txt_Payable.Text, txt_Discount.Text, txt_receievd.Text, _
                                 txt_Serial.Text, txt_Expire.Text, txt_NumberCard.Text, txt_detail.Text, Nothing, cmb_doctor.SelectedValue)
                    Case 0
                        MessageBox.Show("پذیرش بیمار انجام شد و" + vbCrLf + "وضعیت مالی این بیمار:" + vbCrLf + cl_reception.Get_MoneyStatus(_ID_File), "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        clear()
                        frm_define_priority._Doctor = cmb_doctor.SelectedValue
                        frm_define_priority.ShowDialog()
                        dgv_Period.DataSource = cl_period.Select_Period_ByDate(cmb_doctor.SelectedValue, Now).Tables(0)
                        CheckColorDgv()
                    Case 1
                        MessageBox.Show("فیلد های کلیدی باید پر شود." _
                                                                          + vbCrLf _
                                                                          + "(" _
                                                                          + "تعرفه," _
                                                                          + "دریافتی" _
                                                                          + ")" _
                                                                          , "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 2
                        MessageBox.Show("خطایی رخ داده است")
                End Select
            Else
                MessageBox.Show("پرشک معالج انتخاب شود", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        'End If
        If Free Then
            'If cmb_doctor.SelectedValue <> 0 Then
            Select Case cl_reception.Insert_Receprion(_ID_File, Keep_ID_USER.ID_USER, _ID_Period, txt_TotalPay.Text, cmb_insurance.SelectedValue, txt_Payable.Text, txt_Discount.Text, txt_receievd.Text, _
                             txt_Serial.Text, txt_Expire.Text, txt_NumberCard.Text, txt_detail.Text, Nothing, cmb_doctor.SelectedValue)
                Case 0
                    MessageBox.Show("پذیرش بیمار انجام شد و" + vbCrLf + "وضعیت مالی این بیمار:" + vbCrLf + cl_reception.Get_MoneyStatus(_ID_File), "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clear()
                    frm_define_priority._Doctor = cmb_doctor.SelectedValue
                    frm_define_priority.ShowDialog()
                    dgv_Period.DataSource = cl_period.Select_Period_ByDate(cmb_doctor.SelectedValue, Now).Tables(0)
                    CheckColorDgv()
                Case 1
                    MessageBox.Show("فیلد های کلیدی باید پر شود." _
                                                                          + vbCrLf _
                                                                          + "(" _
                                                                          + "تعرفه," _
                                                                          + "دریافتی" _
                                                                          + ")" _
                                                                          , "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 2
                    MessageBox.Show("خطایی رخ داده است")
            End Select
        Else
            MessageBox.Show("پرشک معالج انتخاب شود", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'End If

    End Sub

    Sub clear()
        txt_detail.Text = ""
        txt_Discount.Text = ""
        txt_Expire.Text = ""
        txt_NumberCard.Text = ""
        txt_Payable.Text = ""
        txt_receievd.Text = ""
        txt_Serial.Text = ""
        txt_TotalPay.Text = ""
        _ID_File = Nothing
        _ID_Period = Nothing
    End Sub

    Private Sub getInfo(ByVal ID_FILE As Long)

        dgv_attribiutes.DataSource = exec.ReturnSelectFromSP("sp_Select_information_File " & ID_FILE.ToString).Tables(0)
        dgv_attribiutes.Columns(1).Width = 320
        dgv_attribiutes.Refresh()

        Try
            Dim file() As Byte = cl_file.Get_Avatar_File(ID_FILE)
            Dim MS As New MemoryStream()
            MS.Write(file, 0, file.Length)
            PictureBox.Image = Bitmap.FromStream(MS)

        Catch ex As Exception
            PictureBox.Image = My.Resources.ResourceManager.GetObject("avatar")
        End Try

    End Sub

    Private Sub dgv_Period_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Period.CellClick


        _ID_Period = Val(dgv_Period.Rows(dgv_Period.CurrentRow.Index).Cells("Id").Value.ToString)
        If cl_reception.Check_Reception(_ID_Period) Then
            _ID_File = Val(dgv_Period.Rows(dgv_Period.CurrentRow.Index).Cells("id_file").Value.ToString)

            If _ID_File <> 0 Then
                getInfo(_ID_File)
                gp_attribiute.Enabled = True
                gp_reception.Enabled = True
            End If
        Else
            MessageBox.Show("این بیمار قبلا پذیرش شده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub txt_TotalPay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TotalPay.TextChanged
        Dim Number As Decimal
        If Decimal.TryParse(txt_TotalPay.Text, Number) Then
            txt_TotalPay.Text = String.Format("{0:N0}", Number)
            txt_TotalPay.SelectionStart = txt_TotalPay.Text.Length
        End If
        If Free Then txt_Payable.Text = Str(Val(txt_TotalPay.Text.Replace(",", Nothing)) - Val(txt_Discount.Text.Replace(",", Nothing)))
        If Not Free Then txt_Payable.Text = Str(Val(Val(txt_TotalPay.Text.Replace(",", Nothing)) - (((Val(txt_TotalPay.Text.Replace(",", Nothing)) * Val(cmb_insurance.SelectedValue)) / 100) + Val(txt_Discount.Text.Replace(",", Nothing)))))
    End Sub

    Private Sub cmb_insurance_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_insurance.SelectedIndexChanged
        If Free Then txt_Payable.Text = Str(Val(txt_TotalPay.Text.Replace(",", Nothing)) - Val(txt_Discount.Text.Replace(",", Nothing)))
        If Not Free Then txt_Payable.Text = Str(Val(Val(txt_TotalPay.Text.Replace(",", Nothing)) - (((Val(txt_TotalPay.Text.Replace(",", Nothing)) * Val(cmb_insurance.SelectedValue)) / 100) + Val(txt_Discount.Text.Replace(",", Nothing)))))
    End Sub

    Private Sub txt_Discount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Discount.TextChanged
        Dim Number As Decimal
        If Decimal.TryParse(txt_Discount.Text, Number) Then
            txt_Discount.Text = String.Format("{0:N0}", Number)
            txt_Discount.SelectionStart = txt_Discount.Text.Length
        End If
        If Free Then txt_Payable.Text = Str(Val(txt_TotalPay.Text.Replace(",", Nothing)) - Val(txt_Discount.Text.Replace(",", Nothing)))
        If Not Free Then txt_Payable.Text = Str(Val(Val(txt_TotalPay.Text.Replace(",", Nothing)) - (((Val(txt_TotalPay.Text.Replace(",", Nothing)) * Val(cmb_insurance.SelectedValue)) / 100) + Val(txt_Discount.Text.Replace(",", Nothing)))))

    End Sub

    Private Sub txt_Payable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Payable.TextChanged
        Dim Number As Decimal
        If Decimal.TryParse(txt_Payable.Text, Number) Then
            txt_Payable.Text = String.Format("{0:N0}", Number)
            txt_Payable.SelectionStart = txt_Payable.Text.Length
        End If
    End Sub

    Private Sub chk_free_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_free.CheckedChanged
        If chk_free.Checked Then
            Free = True
        End If
        If Not chk_free.Checked Then
            Free = False
        End If
        If Free Then txt_Payable.Text = Str(Val(txt_TotalPay.Text.Replace(",", Nothing)) - Val(txt_Discount.Text.Replace(",", Nothing)))
        If Not Free Then txt_Payable.Text = Str(Val(Val(txt_TotalPay.Text.Replace(",", Nothing)) - (((Val(txt_TotalPay.Text.Replace(",", Nothing)) * Val(cmb_insurance.SelectedValue)) / 100) + Val(txt_Discount.Text.Replace(",", Nothing)))))
    End Sub

    Private Sub txt_receievd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_receievd.TextChanged
        Dim Number As Decimal
        If Decimal.TryParse(txt_receievd.Text, Number) Then
            txt_receievd.Text = String.Format("{0:N0}", Number)
            txt_receievd.SelectionStart = txt_receievd.Text.Length
        End If
    End Sub

End Class