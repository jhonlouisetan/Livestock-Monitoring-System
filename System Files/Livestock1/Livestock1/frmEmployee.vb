Public Class frmEmployee

    Dim strQuery = ""

    Public Sub processEmp(ByVal strQuery)
        SQLManager(strQuery)
        strQuery = "select * from properEmp"
        displayRecords(strQuery, DGEmp)
    End Sub

    Public Sub resetEmp()
        btnEmpAdd.Enabled = True
        btnEmpUpdate.Enabled = False
        btnEmpDelete.Enabled = False
        txtEmpID.Enabled = True
        txtEmpID.Clear()
        txtEmpFName.Clear()
        txtEmpMidInit.Clear()
        txtEmpGender.Clear()
        txtEmpContact.Clear()
        txtEmpJob.Clear()
        txtEmpPass.Clear()

    End Sub

    Public Sub setButtonsEmp()
        txtEmpID.Enabled = False
        btnEmpAdd.Enabled = False
        btnEmpUpdate.Enabled = True
        btnEmpDelete.Enabled = True
    End Sub

    Private Sub frmEmployee_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try
            strQuery = "select * from properEmp"
            displayRecords(strQuery, DGEmp)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        strQuery = "select * from properEmp"
        displayRecords(strQuery, DGEmp)
    End Sub

    Private Sub frmEmployee_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        resetEmp()
    End Sub

    Private Sub DGEmp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGEmp.CellClick
        Try
            Dim i = e.RowIndex
            With DGEmp
                txtEmpID.Text = .Item(0, i).Value
                txtEmpFName.Text = .Item(1, i).Value
                txtEmpMidInit.Text = .Item(2, i).Value
                txtEmpLName.Text = .Item(3, i).Value
                txtEmpGender.Text = .Item(4, i).Value
                txtEmpContact.Text = .Item(5, i).Value
                txtEmpJob.Text = .Item(6, i).Value
                txtEmpPass.Text = .Item(7, i).Value
                dtpEmpBirth.Text = .Item(8, i).Value
                dtpEmpHire.Text = .Item(9, i).Value
            End With
            setButtonsEmp()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnEmpAdd_Click(sender As Object, e As EventArgs) Handles btnEmpAdd.Click
        Try
            strQuery = "insert into tbl_emp values(" & txtEmpID.Text & ",'" & txtEmpFName.Text & "','" & txtEmpMidInit.Text & "','" & txtEmpLName.Text & "','" & txtEmpGender.Text & "','" & txtEmpContact.Text & "','" & txtEmpJob.Text & "','" & txtEmpPass.Text & "','" & dtpEmpBirth.Text & "','" & dtpEmpHire.Text & "')"
            processEmp(strQuery)
            resetEmp()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEmpUpdate_Click(sender As Object, e As EventArgs) Handles btnEmpUpdate.Click
        Try
            strQuery = "update tbl_emp set emp_fname='" & txtEmpFName.Text & "', emp_midinit='" & txtEmpMidInit.Text & "', emp_lname='" & txtEmpLName.Text & "', emp_gender='" & txtEmpGender.Text & "', emp_contact='" & txtEmpContact.Text & "', emp_job='" & txtEmpJob.Text & "', emp_pass='" & txtEmpPass.Text & "', emp_birthdate='" & dtpEmpBirth.Text & "', emp_hiredate='" & dtpEmpHire.Text & "' where emp_id = " & txtEmpID.Text & ""
            processEmp(strQuery)
            resetEmp()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEmpDelete_Click(sender As Object, e As EventArgs) Handles btnEmpDelete.Click
        Try
            strQuery = "delete from tbl_emp where emp_id=" & txtEmpID.Text & ""
            processEmp(strQuery)
            resetEmp()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtEmpSearch_TextChanged(sender As Object, e As EventArgs) Handles txtEmpSearch.TextChanged
        strQuery = "select * from properEmp where `Employee ID` like '%" & txtEmpSearch.Text & "%' or `Last Name` like '%" & txtEmpSearch.Text & "%'"
        displayRecords(strQuery, DGEmp)
    End Sub

End Class