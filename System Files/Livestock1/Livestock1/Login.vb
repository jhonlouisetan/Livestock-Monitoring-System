Imports MySql.Data.MySqlClient

Public Class frmLogin
    Dim dtconn As New DTConnection
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim StrQuery = ""


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        StrQuery = "select emp_id, emp_pass from tbl_emp where emp_id=" & txtUName.Text & " and emp_pass='" & txtPass.Text & "'"
        da = New MySqlDataAdapter("select emp_id, emp_pass from tbl_emp where emp_id=" & txtUName.Text & " and emp_pass='" & txtPass.Text & "'", dtconn.open)
        dt.Clear()
        da.Fill(dt)
        If txtUName.Text = "11111" And txtPass.Text = "admin" Then
            frmAdmin.Show()
            Me.Close()
        ElseIf dt.Rows.Count = Nothing Then
            MsgBox("Incorrect username or password")
            txtUName.Clear()
            txtPass.Clear()
        ElseIf txtUName.Text.Length = 2 Then
            frmBook.Show()
            Me.Close()
        Else
            frmView.Show()
            Me.Close()
        End If
        dtconn.close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class