Public Class frmBook
    Dim strQuery = ""

    Public Sub processCow(ByVal strQuery)
        SQLManager(strQuery)
        strQuery = "select * from proper"
        displayRecords(strQuery, DGCow)
    End Sub

    Public Sub resetCow()
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtCowID.Enabled = True
        txtCowID.Clear()
        'txtGender.Clear()
        'txtAgeGroup.Clear()
        'txtInventoryStatus.Clear()
        txtOwner.Clear()
        txtSearch.Clear()
        cboxGender.Text = "Select Gender"
        cboxAgeGroup.Text = "Select Age Group"
        cboxInventoryStatus.Text = "Select Inventory Status"

    End Sub

    Public Sub setButtonsCow()
        txtCowID.Enabled = False
        btnAdd.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub frmBook_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try
            displayRecords("select * from proper", DGCow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()

        cboxGender.Items.Add("N/A")
        cboxGender.Items.Add("Male")
        cboxGender.Items.Add("Female")
        cboxAgeGroup.Items.Add("N/A")
        cboxAgeGroup.Items.Add("Anak")
        cboxAgeGroup.Items.Add("Torete")
        cboxAgeGroup.Items.Add("Dinalaga")
        cboxAgeGroup.Items.Add("Toro")
        cboxAgeGroup.Items.Add("Inahin")
        cboxInventoryStatus.Items.Add("N/A")
        cboxInventoryStatus.Items.Add("IN")
        cboxInventoryStatus.Items.Add("OUT")

        strQuery = "select * from proper"
        displayRecords(strQuery, DGCow)

        

    End Sub

    Private Sub frmBook_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        resetCow()
    End Sub

    Private Sub DGCow_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCow.CellClick
        Try
            Dim i = e.RowIndex
            With DGCow
                txtCowID.Text = .Item(0, i).Value
                txtOwner.Text = .Item(1, i).Value
                'txtGender.Text = .Item(2, i).Value
                'txtAgeGroup.Text = .Item(3, i).Value
                'txtInventoryStatus.Text = .Item(4, i).Value
                cboxGender.Text = .Item(2, i).Value
                cboxAgeGroup.Text = .Item(3, i).Value
                cboxInventoryStatus.Text = .Item(4, i).Value
                dtpInventory.Text = .Item(5, i).Value
                dtpRecorded.Text = .Item(6, i).Value
                dtpOut.Text = .Item(7, i).Value
            End With
            setButtonsCow()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            'strQuery = "insert into tbl_cow values(" & txtCowID.Text & ",'" & txtOwner.Text & "','" & txtGender.Text & "','" & txtAgeGroup.Text & "','" & txtInventoryStatus.Text & "','" & dtpInventory.Text & "','" & dtpRecorded.Text & "','" & dtpOut.Text & "')"
            strQuery = "insert into tbl_cow values(" & txtCowID.Text & ",'" & txtOwner.Text & "','" & cboxGender.SelectedItem & "','" & cboxAgeGroup.SelectedItem & "','" & cboxInventoryStatus.SelectedItem & "','" & dtpInventory.Text & "','" & dtpRecorded.Text & "', NULL)"
            processCow(strQuery)
            resetCow()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            'strQuery = "update tbl_cow set owner_initials='" & txtOwner.Text & "', cow_gender='" & txtGender.Text & "', cow_ageGroup='" & txtAgeGroup.Text & "', cow_invStatus='" & txtInventoryStatus.Text & "', date_inventory='" & dtpInventory.Text & "', date_recorded='" & dtpRecorded.Text & "', date_out='" & dtpOut.Text & "' where cow_id=" & txtCowID.Text & ""
            If cboxInventoryStatus.SelectedItem = "OUT" Then
                strQuery = "update tbl_cow set owner_initials='" & txtOwner.Text & "', cow_gender='" & cboxGender.SelectedItem & "', cow_ageGroup='" & cboxAgeGroup.SelectedItem & "', cow_invStatus='" & cboxInventoryStatus.SelectedItem & "', date_inventory='" & dtpInventory.Text & "', date_recorded='" & dtpRecorded.Text & "', date_out= '" & dtpOut.Text & "' where cow_id=" & txtCowID.Text & ""
            Else
                strQuery = "update tbl_cow set owner_initials='" & txtOwner.Text & "', cow_gender='" & cboxGender.SelectedItem & "', cow_ageGroup='" & cboxAgeGroup.SelectedItem & "', cow_invStatus='" & cboxInventoryStatus.SelectedItem & "', date_inventory='" & dtpInventory.Text & "', date_recorded='" & dtpRecorded.Text & "', date_out= NULL where cow_id=" & txtCowID.Text & ""
            End If
            processCow(strQuery)
            resetCow()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            strQuery = "delete from proper where `Cow ID` =" & txtCowID.Text & ""
            processCow(strQuery)
            resetCow()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        strQuery = "select * from proper where `Cow ID` like '%" & txtSearch.Text & "%' or `Owner` like '%" & txtSearch.Text & "%'"
        displayRecords(strQuery, DGCow)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()
        Me.Close()
    End Sub
End Class