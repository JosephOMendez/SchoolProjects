Public Class CustomerTierJoin
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        WelcomeForm.Show()
    End Sub

    Private Sub CustomerTierJoin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Deliverable_2_DatabaseDataSet.MinAgeByTier' table. You can move, or remove it, as needed.
        Me.MinAgeByTierTableAdapter.MinAgeByTier(Me.Deliverable_2_DatabaseDataSet.MinAgeByTier)
        'TODO: This line of code loads data into the 'Deliverable_2_DatabaseDataSet3.NumOfCustByTier' table. You can move, or remove it, as needed.
        Me.NumOfCustByTierTableAdapter.COUNTCustomersPerTier(Me.Deliverable_2_DatabaseDataSet3.NumOfCustByTier)
        'TODO: This line of code loads data into the 'Deliverable_2_DatabaseDataSet1.MaxAgeByTier' table. You can move, or remove it, as needed.
        Me.MaxAgeByTierTableAdapter.MaxAgeByTier(Me.Deliverable_2_DatabaseDataSet1.MaxAgeByTier)
        'TODO: This line of code loads data into the 'Deliverable_2_DatabaseDataSet.CustomerTier' table. You can move, or remove it, as needed.
        Me.CustomerTierTableAdapter.JoinedCustomerTierTable(Me.Deliverable_2_DatabaseDataSet.CustomerTier)
    End Sub

    Private Sub MoreThan1Button_Click(sender As Object, e As EventArgs) Handles MoreThan1Button.Click
        Me.NumOfCustByTierTableAdapter.CountGreaterThan1(Me.Deliverable_2_DatabaseDataSet3.NumOfCustByTier)
    End Sub

    Private Sub DefaultViewButton_Click(sender As Object, e As EventArgs) Handles DefaultViewButton.Click
        Me.NumOfCustByTierTableAdapter.COUNTCustomersPerTier(Me.Deliverable_2_DatabaseDataSet3.NumOfCustByTier)
    End Sub

    Private Sub AgeGreaterThanAvgButton_Click(sender As Object, e As EventArgs) Handles AgeGreaterThanAvgButton.Click
        Me.CustomerTierTableAdapter.AgeGreaterThanAvg(Me.Deliverable_2_DatabaseDataSet.CustomerTier)
    End Sub

    Private Sub AgeLessThanAvgButton_Click(sender As Object, e As EventArgs) Handles AgeLessThanAvgButton.Click
        Me.CustomerTierTableAdapter.AgeLessThanAvg(Me.Deliverable_2_DatabaseDataSet.CustomerTier)
    End Sub

    Private Sub DefaultCustTierButton_Click(sender As Object, e As EventArgs) Handles DefaultCustTierButton.Click
        Me.CustomerTierTableAdapter.JoinedCustomerTierTable(Me.Deliverable_2_DatabaseDataSet.CustomerTier)
    End Sub
End Class