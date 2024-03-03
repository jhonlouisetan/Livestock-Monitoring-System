Public Class frmAdmin


    Private Sub btnCow_Click(sender As Object, e As EventArgs) Handles btnCow.Click
        frmBook.Show()
    End Sub

    Private Sub btnListOut_Click(sender As Object, e As EventArgs) Handles btnListOut.Click
        frmListOut.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    
    Private Sub btnOwner_Click(sender As Object, e As EventArgs) Handles btnOwner.Click
        frmOwner.Show()
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        frmEmployee.Show()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        frmView.Show()
    End Sub
End Class