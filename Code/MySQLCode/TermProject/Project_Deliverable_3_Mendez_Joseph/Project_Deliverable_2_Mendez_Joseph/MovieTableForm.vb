Public Class MovieTableForm
    Private Sub MovieTableBackButton_Click(sender As Object, e As EventArgs) Handles MovieTableBackButton.Click
        Me.Hide()
        WelcomeForm.Show()
    End Sub

    Private Sub MovieTableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Deliverable_2_DatabaseDataSet.MOVIE' table. You can move, or remove it, as needed.
        Me.MOVIETableAdapter.Fill(Me.Deliverable_2_DatabaseDataSet.MOVIE)
    End Sub

    Private Sub ShowMexicanMoviesButton_Click(sender As Object, e As EventArgs) Handles ShowMexicanMoviesButton.Click
        Try
            Me.MOVIETableAdapter.Show_Mexican_Movies(Me.Deliverable_2_DatabaseDataSet.MOVIE)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("There was an error with the selected query.")
        End Try
    End Sub

    Private Sub DefaultViewButton_Click(sender As Object, e As EventArgs) Handles DefaultViewButton.Click
        Me.MOVIETableAdapter.Fill(Me.Deliverable_2_DatabaseDataSet.MOVIE)
    End Sub

    Private Sub FilterByReleaseYearButton_Click(sender As Object, e As EventArgs) Handles FilterByReleaseYearButton.Click
        Try
            Me.MOVIETableAdapter.ReleaseYear_Based_On_Input(Me.Deliverable_2_DatabaseDataSet.MOVIE, Decimal.Parse(FilterByReleaseYearTextBox.Text))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Please enter a valid year")
        End Try
    End Sub

    Private Sub ShowAmericanMovies_Click(sender As Object, e As EventArgs) Handles ShowAmericanMovies.Click
        Try
            Me.MOVIETableAdapter.Show_American_Movies(Me.Deliverable_2_DatabaseDataSet.MOVIE)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("There was an error with the selected query.")
        End Try
    End Sub

    Private Sub SortTitlesAscButton_Click(sender As Object, e As EventArgs) Handles SortTitlesAscButton.Click
        Try
            Me.MOVIETableAdapter.SortMovieTitlesAscending(Me.Deliverable_2_DatabaseDataSet.MOVIE)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("There was an error with the selected query.")
        End Try
    End Sub
End Class