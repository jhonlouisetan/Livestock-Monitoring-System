Public Class frmListOut

    Dim strQuery = ""

    Private Sub frmView_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try
            strQuery = "select * from proper where `Inventory Status` = 'OUT'"
            displayRecords(strQuery, DGCow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        strQuery = "select * from proper where `Inventory Status` = 'OUT'"
        displayRecords(strQuery, DGCow)
    End Sub

    Private Sub txtOutSearch_TextChanged(sender As Object, e As EventArgs) Handles txtOutSearch.TextChanged
        strQuery = "select * from proper where `Cow ID` like '%" & txtOutSearch.Text & "%' or `Owner` like '%" & txtOutSearch.Text & "%'"
        displayRecords(strQuery, DGCow)
    End Sub

    Private Sub btnOutLogout_Click(sender As Object, e As EventArgs) Handles btnOutLogout.Click
        frmLogin.Show()
        Me.Close()
    End Sub
End Class