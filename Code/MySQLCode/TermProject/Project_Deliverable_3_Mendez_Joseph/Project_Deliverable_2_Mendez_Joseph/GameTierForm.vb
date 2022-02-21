Public Class GameTierForm
    Private Sub GameTierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Deliverable_2_DatabaseDataSet.GameTierSuperSub' table. You can move, or remove it, as needed.
        Me.GameTierSuperSubTableAdapter.GameTierSuperSub(Me.Deliverable_2_DatabaseDataSet.GameTierSuperSub)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        WelcomeForm.Show()
    End Sub

    Private Sub GamesBasedOnInput_Click(sender As Object, e As EventArgs) Handles GamesBasedOnInput.Click
        Try
            Me.GameTierSuperSubTableAdapter.ShowGamesFromTierInput(Me.Deliverable_2_DatabaseDataSet.GameTierSuperSub, Decimal.Parse(TierInputBox.Text))
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("Please enter a valid tier ID")
        End Try
    End Sub

    Private Sub DefaultView_Click(sender As Object, e As EventArgs) Handles DefaultView.Click
        Me.GameTierSuperSubTableAdapter.GameTierSuperSub(Me.Deliverable_2_DatabaseDataSet.GameTierSuperSub)
    End Sub
End Class