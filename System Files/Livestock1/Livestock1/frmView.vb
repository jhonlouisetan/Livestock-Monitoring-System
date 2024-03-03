Public Class frmView
    Dim strQuery = ""

    Private Sub frmView_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try
            Livestock.displayRecords("select * from proper", DGViewCow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        strQuery = "select * from proper"
        displayRecords(strQuery, DGViewCow)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblViewSearch.Click

    End Sub

    Private Sub txtViewSearch_TextChanged(sender As Object, e As EventArgs) Handles txtViewSearch.TextChanged
        strQuery = "select * from proper where `Cow ID` like '%" & txtViewSearch.Text & "%' or `Owner` like '%" & txtViewSearch.Text & "%'"
        displayRecords(strQuery, DGViewCow)
    End Sub


End Class