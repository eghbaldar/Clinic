Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frm_BackupDB

    Dim cS As String

    Private Sub frm_BackupDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim Server As String = String.Empty
            Dim instance As SqlDataSourceEnumerator = SqlDataSourceEnumerator.Instance
            Dim table As System.Data.DataTable = instance.GetDataSources()

            For Each row As System.Data.DataRow In table.Rows
                Server = String.Empty
                Server = row("ServerName")
                If row("InstanceName").ToString.Length > 0 Then
                    Server = Server & "\" & row("InstanceName")
                End If
                lbl_Server.Text = Server
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Sub BackUp()
        Try
            Dim save1 As New SaveFileDialog
            save1.Filter = "SQL Backup Files (*.BAK)|*.BAK |All Files(*.*)|*.0*)"
            save1.FileName = "db"
            save1.OverwritePrompt = True
            save1.FilterIndex = 1

            If save1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim con1 As New SqlConnection(cS)
                con1.Open()
                Dim cmd1 As New SqlCommand()
                SqlConnection.ClearAllPools()
                cmd1.Connection = con1
                cmd1.CommandType = CommandType.Text
                con1.ChangeDatabase("master")
                cmd1.CommandText = "backup DATABASE clinic to DISK = N'" + save1.FileName.ToString + " '"
                cmd1.ExecuteNonQuery()
                con1.Close()
                MessageBox.Show("پشتیبان گیری با موفقیت انجامبد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            If Err.Number = 5 Then
                MessageBox.Show("نام سرور نادرست است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Try
    End Sub

    Sub Restore()
        Try
            Dim Open1 As New OpenFileDialog
            Open1.FileName = "db"
            Open1.FilterIndex = 1
            If Open1.ShowDialog = Windows.Forms.DialogResult.OK Then

                Dim con As New SqlConnection(cS)
                con.Open()
                Dim cmd As New SqlCommand()
                SqlConnection.ClearAllPools()
                cmd.Connection = con

                cmd.CommandType = CommandType.Text
                con.ChangeDatabase("master")

                Dim StrCommand As String = String.Empty
                StrCommand = "alter database clinic set single_user with rollback immediate;" 'این دستور باعث می شود که اگه دیتابیس شما فعال و در حال استفاده باشد، موقتا قطع شود
                StrCommand += " USE MASTER RESTORE DATABASE clinic FROM DISK = N'" + Open1.FileName.ToString + " ' with replace;" 'دستورات اصلی برگردان پشتیبان
                StrCommand += "alter database clinic set multi_user;" 'این دستور اتصال دوباره را برقرار میکند
                cmd.CommandText = StrCommand
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("بازیابی با موفقیت انجامبد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            If Err.Number = 5 Then
                MessageBox.Show("نام سرور نادرست است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Try
    End Sub

    Private Sub btnBackUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackUp.Click
        cS = "Data Source=" + lbl_Server.Text + ";Initial Catalog=clinic;Integrated Security=True"
        BackUp()
    End Sub

    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        cS = "Data Source=" + lbl_Server.Text + ";Initial Catalog=clinic;Integrated Security=True"
        Restore()
    End Sub

End Class