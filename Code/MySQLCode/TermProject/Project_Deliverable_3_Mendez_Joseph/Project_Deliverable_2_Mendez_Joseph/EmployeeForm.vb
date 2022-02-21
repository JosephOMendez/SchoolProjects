Public Class EmployeeForm
    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Deliverable_2_DatabaseDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
        Me.EMPLOYEETableAdapter.Fill(Me.Deliverable_2_DatabaseDataSet.EMPLOYEE)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        WelcomeForm.Show()
    End Sub

    Private Sub ShowEmpWithNoSupervisor_Click(sender As Object, e As EventArgs) Handles ShowEmpWithNoSupervisor.Click
        Me.EMPLOYEETableAdapter.EmployeeWithNoSupervisor(Me.Deliverable_2_DatabaseDataSet.EMPLOYEE)
    End Sub

    Private Sub DefaultButton_Click(sender As Object, e As EventArgs) Handles DefaultButton.Click
        Me.EMPLOYEETableAdapter.Fill(Me.Deliverable_2_DatabaseDataSet.EMPLOYEE)
    End Sub

    Private Sub ShowEmpWithSupervisor_Click(sender As Object, e As EventArgs) Handles ShowEmpWithSupervisor.Click
        Me.EMPLOYEETableAdapter.EmployeeWithSupervisor(Me.Deliverable_2_DatabaseDataSet.EMPLOYEE)
    End Sub

    Private Sub EmployeeBasedOnInputDepartmentFName_Click(sender As Object, e As EventArgs) Handles EmployeeBasedOnInputDepartmentFName.Click
        Try
            Me.EMPLOYEETableAdapter.EmployeeBasedOnFNameDepartment(Me.Deliverable_2_DatabaseDataSet.EMPLOYEE, DepartmentInputBox.Text, FirstNameInitial.Text)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("There was an issue with the query. Please check your imput.")
        End Try
    End Sub
End Class