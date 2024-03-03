Public Class frmOwner

    Dim strQuery = ""

    Public Sub processOwner(ByVal strQuery)
        SQLManager(strQuery)
        strQuery = "select * from properOwner"
        displayRecords(strQuery, DGOwner)
    End Sub

    Public Sub resetOwner()
        btnOwnerAdd.Enabled = True
        btnOwnerUpdate.Enabled = False
        btnOwnerDelete.Enabled = False
        txtOwnerID.Enabled = True
        txtOwnerID.Clear()
        txtOwnerName.Clear()
        txtOwnerInitials.Clear()
        txtOwnerContact.Clear()

    End Sub

    Public Sub setButtonsOwner()
        txtOwnerID.Enabled = False
        btnOwnerAdd.Enabled = False
        btnOwnerUpdate.Enabled = True
        btnOwnerDelete.Enabled = True
    End Sub

    Private Sub frmOwner_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try
            strQuery = "select * from properOwner"
            displayRecords(strQuery, DGOwner)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmOwner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()

        strQuery = "select * from properOwner"
        displayRecords(strQuery, DGOwner)



    End Sub

    Private Sub frmOwner_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        resetOwner()
    End Sub

    Private Sub DGOwner_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGOwner.CellClick
        Try
            Dim i = e.RowIndex
            With DGOwner
                txtOwnerID.Text = .Item(0, i).Value
                txtOwnerName.Text = .Item(1, i).Value
                txtOwnerInitials.Text = .Item(2, i).Value
                txtOwnerContact.Text = .Item(3, i).Value
            End With
            setButtonsOwner()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnOwnerAdd_Click(sender As Object, e As EventArgs) Handles btnOwnerAdd.Click
        Try
            strQuery = "insert into tbl_owner values(" & txtOwnerID.Text & ",'" & txtOwnerName.Text & "','" & txtOwnerInitials.Text & "','" & txtOwnerContact.Text & "')"
            processOwner(strQuery)
            resetOwner()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnOwnerUpdate_Click(sender As Object, e As EventArgs) Handles btnOwnerUpdate.Click
        Try
            strQuery = "update tbl_owner set owner_name='" & txtOwnerName.Text & "', owner_initials='" & txtOwnerInitials.Text & "', owner_contact='" & txtOwnerContact.Text & "' where owner_id=" & txtOwnerID.Text & ""
            processOwner(strQuery)
            resetOwner()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnOwnerDelete_Click(sender As Object, e As EventArgs) Handles btnOwnerDelete.Click
        Try
            strQuery = "delete from tbl_owner where owner_id=" & txtOwnerID.Text & ""
            processOwner(strQuery)
            resetOwner()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtOwnerSearch_TextChanged(sender As Object, e As EventArgs) Handles txtOwnerSearch.TextChanged
        strQuery = "select * from properOwner where `Name` like '%" & txtOwnerSearch.Text & "%' or `Initials` like '%" & txtOwnerSearch.Text & "%'"
        displayRecords(strQuery, DGOwner)
    End Sub
End Class