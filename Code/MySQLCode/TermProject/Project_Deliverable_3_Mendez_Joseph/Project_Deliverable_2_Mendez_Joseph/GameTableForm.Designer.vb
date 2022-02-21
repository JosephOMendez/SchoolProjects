<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameTableForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GameTableBackButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GameIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GameTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GameReleaseYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GameGenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RatingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeveloperIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GAMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Deliverable_2_DatabaseDataSet = New Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSet()
        Me.GAMETableAdapter = New Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSetTableAdapters.GAMETableAdapter()
        Me.FilterByReleaseYearButton = New System.Windows.Forms.Button()
        Me.DefaultGameViewButton = New System.Windows.Forms.Button()
        Me.FilterByReleaseYearTextBox = New System.Windows.Forms.TextBox()
        Me.ShowMRatedButton = New System.Windows.Forms.Button()
        Me.ShowTRatedButton = New System.Windows.Forms.Button()
        Me.TitleAscending = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GAMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Deliverable_2_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GameTableBackButton
        '
        Me.GameTableBackButton.AutoSize = True
        Me.GameTableBackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GameTableBackButton.Location = New System.Drawing.Point(801, 416)
        Me.GameTableBackButton.Name = "GameTableBackButton"
        Me.GameTableBackButton.Size = New System.Drawing.Size(55, 30)
        Me.GameTableBackButton.TabIndex = 0
        Me.GameTableBackButton.Text = "&Back"
        Me.GameTableBackButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GameIDDataGridViewTextBoxColumn, Me.GameTitleDataGridViewTextBoxColumn, Me.GameReleaseYearDataGridViewTextBoxColumn, Me.GameGenreDataGridViewTextBoxColumn, Me.RatingDataGridViewTextBoxColumn, Me.DeveloperIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GAMEBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-2, -1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(868, 303)
        Me.DataGridView1.TabIndex = 1
        '
        'GameIDDataGridViewTextBoxColumn
        '
        Me.GameIDDataGridViewTextBoxColumn.DataPropertyName = "Game_ID"
        Me.GameIDDataGridViewTextBoxColumn.HeaderText = "Game_ID"
        Me.GameIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GameIDDataGridViewTextBoxColumn.Name = "GameIDDataGridViewTextBoxColumn"
        Me.GameIDDataGridViewTextBoxColumn.Width = 115
        '
        'GameTitleDataGridViewTextBoxColumn
        '
        Me.GameTitleDataGridViewTextBoxColumn.DataPropertyName = "Game_Title"
        Me.GameTitleDataGridViewTextBoxColumn.HeaderText = "Game_Title"
        Me.GameTitleDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GameTitleDataGridViewTextBoxColumn.Name = "GameTitleDataGridViewTextBoxColumn"
        Me.GameTitleDataGridViewTextBoxColumn.Width = 127
        '
        'GameReleaseYearDataGridViewTextBoxColumn
        '
        Me.GameReleaseYearDataGridViewTextBoxColumn.DataPropertyName = "Game_ReleaseYear"
        Me.GameReleaseYearDataGridViewTextBoxColumn.HeaderText = "Game_ReleaseYear"
        Me.GameReleaseYearDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GameReleaseYearDataGridViewTextBoxColumn.Name = "GameReleaseYearDataGridViewTextBoxColumn"
        Me.GameReleaseYearDataGridViewTextBoxColumn.Width = 191
        '
        'GameGenreDataGridViewTextBoxColumn
        '
        Me.GameGenreDataGridViewTextBoxColumn.DataPropertyName = "Game_Genre"
        Me.GameGenreDataGridViewTextBoxColumn.HeaderText = "Game_Genre"
        Me.GameGenreDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GameGenreDataGridViewTextBoxColumn.Name = "GameGenreDataGridViewTextBoxColumn"
        Me.GameGenreDataGridViewTextBoxColumn.Width = 143
        '
        'RatingDataGridViewTextBoxColumn
        '
        Me.RatingDataGridViewTextBoxColumn.DataPropertyName = "Rating"
        Me.RatingDataGridViewTextBoxColumn.HeaderText = "Rating"
        Me.RatingDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RatingDataGridViewTextBoxColumn.Name = "RatingDataGridViewTextBoxColumn"
        Me.RatingDataGridViewTextBoxColumn.Width = 92
        '
        'DeveloperIDDataGridViewTextBoxColumn
        '
        Me.DeveloperIDDataGridViewTextBoxColumn.DataPropertyName = "Developer_ID"
        Me.DeveloperIDDataGridViewTextBoxColumn.HeaderText = "Developer_ID"
        Me.DeveloperIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DeveloperIDDataGridViewTextBoxColumn.Name = "DeveloperIDDataGridViewTextBoxColumn"
        Me.DeveloperIDDataGridViewTextBoxColumn.Width = 143
        '
        'GAMEBindingSource
        '
        Me.GAMEBindingSource.DataMember = "GAME"
        Me.GAMEBindingSource.DataSource = Me.Deliverable_2_DatabaseDataSet
        '
        'Deliverable_2_DatabaseDataSet
        '
        Me.Deliverable_2_DatabaseDataSet.DataSetName = "Deliverable_2_DatabaseDataSet"
        Me.Deliverable_2_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GAMETableAdapter
        '
        Me.GAMETableAdapter.ClearBeforeFill = True
        '
        'FilterByReleaseYearButton
        '
        Me.FilterByReleaseYearButton.AutoSize = True
        Me.FilterByReleaseYearButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FilterByReleaseYearButton.Location = New System.Drawing.Point(12, 416)
        Me.FilterByReleaseYearButton.Name = "FilterByReleaseYearButton"
        Me.FilterByReleaseYearButton.Size = New System.Drawing.Size(213, 30)
        Me.FilterByReleaseYearButton.TabIndex = 3
        Me.FilterByReleaseYearButton.Text = "Show games released after"
        Me.FilterByReleaseYearButton.UseVisualStyleBackColor = True
        '
        'DefaultGameViewButton
        '
        Me.DefaultGameViewButton.AutoSize = True
        Me.DefaultGameViewButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DefaultGameViewButton.Location = New System.Drawing.Point(722, 359)
        Me.DefaultGameViewButton.Name = "DefaultGameViewButton"
        Me.DefaultGameViewButton.Size = New System.Drawing.Size(134, 30)
        Me.DefaultGameViewButton.TabIndex = 4
        Me.DefaultGameViewButton.Text = "Show All Entries"
        Me.DefaultGameViewButton.UseVisualStyleBackColor = True
        '
        'FilterByReleaseYearTextBox
        '
        Me.FilterByReleaseYearTextBox.Location = New System.Drawing.Point(240, 418)
        Me.FilterByReleaseYearTextBox.Name = "FilterByReleaseYearTextBox"
        Me.FilterByReleaseYearTextBox.Size = New System.Drawing.Size(100, 26)
        Me.FilterByReleaseYearTextBox.TabIndex = 5
        '
        'ShowMRatedButton
        '
        Me.ShowMRatedButton.AutoSize = True
        Me.ShowMRatedButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ShowMRatedButton.Location = New System.Drawing.Point(12, 380)
        Me.ShowMRatedButton.Name = "ShowMRatedButton"
        Me.ShowMRatedButton.Size = New System.Drawing.Size(188, 30)
        Me.ShowMRatedButton.TabIndex = 6
        Me.ShowMRatedButton.Text = "Show all games rated M"
        Me.ShowMRatedButton.UseVisualStyleBackColor = True
        '
        'ShowTRatedButton
        '
        Me.ShowTRatedButton.AutoSize = True
        Me.ShowTRatedButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ShowTRatedButton.Location = New System.Drawing.Point(12, 344)
        Me.ShowTRatedButton.Name = "ShowTRatedButton"
        Me.ShowTRatedButton.Size = New System.Drawing.Size(184, 30)
        Me.ShowTRatedButton.TabIndex = 7
        Me.ShowTRatedButton.Text = "Show all games rated T"
        Me.ShowTRatedButton.UseVisualStyleBackColor = True
        '
        'TitleAscending
        '
        Me.TitleAscending.AutoSize = True
        Me.TitleAscending.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TitleAscending.Location = New System.Drawing.Point(12, 308)
        Me.TitleAscending.Name = "TitleAscending"
        Me.TitleAscending.Size = New System.Drawing.Size(212, 30)
        Me.TitleAscending.TabIndex = 8
        Me.TitleAscending.Text = "Show all in ascending order"
        Me.TitleAscending.UseVisualStyleBackColor = True
        '
        'GameTableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(868, 458)
        Me.Controls.Add(Me.TitleAscending)
        Me.Controls.Add(Me.ShowTRatedButton)
        Me.Controls.Add(Me.ShowMRatedButton)
        Me.Controls.Add(Me.FilterByReleaseYearTextBox)
        Me.Controls.Add(Me.DefaultGameViewButton)
        Me.Controls.Add(Me.FilterByReleaseYearButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GameTableBackButton)
        Me.Name = "GameTableForm"
        Me.Text = "Game Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GAMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Deliverable_2_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GameTableBackButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Deliverable_2_DatabaseDataSet As Deliverable_2_DatabaseDataSet
    Friend WithEvents GAMEBindingSource As BindingSource
    Friend WithEvents GAMETableAdapter As Deliverable_2_DatabaseDataSetTableAdapters.GAMETableAdapter
    Friend WithEvents GameIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GameTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GameReleaseYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GameGenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RatingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeveloperIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FilterByReleaseYearButton As Button
    Friend WithEvents DefaultGameViewButton As Button
    Friend WithEvents FilterByReleaseYearTextBox As TextBox
    Friend WithEvents ShowMRatedButton As Button
    Friend WithEvents ShowTRatedButton As Button
    Friend WithEvents TitleAscending As Button
End Class
