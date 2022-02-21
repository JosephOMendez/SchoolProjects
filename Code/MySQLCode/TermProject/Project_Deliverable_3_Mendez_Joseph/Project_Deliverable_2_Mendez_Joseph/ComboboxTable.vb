Public Class ComboboxTable
    Private Sub ComboBoxBackButton_Click(sender As Object, e As EventArgs) Handles ComboBoxBackButton.Click
        Me.Hide()
        WelcomeForm.Show()
    End Sub

    Private Sub TIERBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TIERBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TIERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Deliverable_2_DatabaseDataSet)

    End Sub

    Private Sub ComboboxTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Deliverable_2_DatabaseDataSet.TIER' table. You can move, or remove it, as needed.
        Me.TIERTableAdapter.Fill(Me.Deliverable_2_DatabaseDataSet.TIER)

    End Sub
End Class