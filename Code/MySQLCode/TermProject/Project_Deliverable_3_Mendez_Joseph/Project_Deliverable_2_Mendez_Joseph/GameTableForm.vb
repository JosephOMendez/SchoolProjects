Public Class GameTableForm
    Private Sub GameTableBackButton_Click(sender As Object, e As EventArgs) Handles GameTableBackButton.Click
        Me.Hide()
        WelcomeForm.Show()
    End Sub

    Private Sub GameTableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Deliverable_2_DatabaseDataSet.GAME' table. You can move, or remove it, as needed.
        Me.GAMETableAdapter.Fill(Me.Deliverable_2_DatabaseDataSet.GAME)

    End Sub

    Private Sub FilterByReleaseYearButton_Click(sender As Object, e As EventArgs) Handles FilterByReleaseYearButton.Click
        Try
            Me.GAMETableAdapter.Game_ReleaseYear_Based_on_Imput(Me.Deliverable_2_DatabaseDataSet.GAME, Decimal.Parse(FilterByReleaseYearTextBox.Text))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Please enter a valid year")
        End Try
    End Sub

    Private Sub DefaultGameViewButton_Click(sender As Object, e As EventArgs) Handles DefaultGameViewButton.Click
        Me.GAMETableAdapter.Fill(Me.Deliverable_2_DatabaseDataSet.GAME)
    End Sub

    Private Sub ShowTRatedButton_Click(sender As Object, e As EventArgs) Handles ShowTRatedButton.Click
        Try
            Me.GAMETableAdapter.ShowTRated(Me.Deliverable_2_DatabaseDataSet.GAME)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("There is something wrong with selected query.")
        End Try
    End Sub

    Private Sub ShowMRatedButton_Click(sender As Object, e As EventArgs) Handles ShowMRatedButton.Click
        Try
            Me.GAMETableAdapter.ShowMRated(Me.Deliverable_2_DatabaseDataSet.GAME)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("There is something wrong with selected query.")
        End Try
    End Sub

    Private Sub TitleAscending_Click(sender As Object, e As EventArgs) Handles TitleAscending.Click
        Try
            Me.GAMETableAdapter.SortInAscendingOrder(Me.Deliverable_2_DatabaseDataSet.GAME)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("There is something wrong with selected query.")
        End Try
    End Sub
End Class