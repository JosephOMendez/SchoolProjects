Public Class WelcomeForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ShowMovieTableButton_Click(sender As Object, e As EventArgs) Handles ShowMovieTableButton.Click
        Me.Hide()
        MovieTableForm.Show()
    End Sub

    Private Sub ShowGameTableButton_Click(sender As Object, e As EventArgs) Handles ShowGameTableButton.Click
        Me.Hide()
        GameTableForm.Show()
    End Sub

    Private Sub JoinTableButton_Click(sender As Object, e As EventArgs) Handles JoinTableButton.Click
        Me.Hide()
        CustomerTierJoin.Show()
    End Sub

    Private Sub ComboboxViewButton_Click(sender As Object, e As EventArgs) Handles ComboboxViewButton.Click
        Me.Hide()
        ComboboxTable.Show()
    End Sub

    Private Sub ShowEmployeeButton_Click(sender As Object, e As EventArgs) Handles ShowEmployeeButton.Click
        Me.Hide()
        EmployeeForm.Show()
    End Sub

    Private Sub ShowGameTierTable_Click(sender As Object, e As EventArgs) Handles ShowGameTierTable.Click
        Me.Hide()
        GameTierForm.Show()
    End Sub
End Class
