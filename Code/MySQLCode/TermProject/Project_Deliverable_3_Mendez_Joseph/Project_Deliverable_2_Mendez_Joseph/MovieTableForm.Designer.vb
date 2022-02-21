<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MovieTableForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MovieTableBackButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ShowMexicanMoviesButton = New System.Windows.Forms.Button()
        Me.DefaultViewButton = New System.Windows.Forms.Button()
        Me.FilterByReleaseYearButton = New System.Windows.Forms.Button()
        Me.FilterByReleaseYearTextBox = New System.Windows.Forms.TextBox()
        Me.ShowAmericanMovies = New System.Windows.Forms.Button()
        Me.SortTitlesAscButton = New System.Windows.Forms.Button()
        Me.MovieIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieReleaseYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieGenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieDurationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirectorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPARatingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOVIEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Deliverable_2_DatabaseDataSet = New Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSet()
        Me.MOVIETableAdapter = New Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSetTableAdapters.MOVIETableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVIEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Deliverable_2_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MovieTableBackButton
        '
        Me.MovieTableBackButton.AutoSize = True
        Me.MovieTableBackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MovieTableBackButton.Location = New System.Drawing.Point(1050, 453)
        Me.MovieTableBackButton.Name = "MovieTableBackButton"
        Me.MovieTableBackButton.Size = New System.Drawing.Size(55, 30)
        Me.MovieTableBackButton.TabIndex = 0
        Me.MovieTableBackButton.Text = "&Back"
        Me.MovieTableBackButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovieIDDataGridViewTextBoxColumn, Me.MovieTitleDataGridViewTextBoxColumn, Me.FullTitleDataGridViewTextBoxColumn, Me.MovieReleaseYearDataGridViewTextBoxColumn, Me.MovieGenreDataGridViewTextBoxColumn, Me.MovieDurationDataGridViewTextBoxColumn, Me.DirectorIDDataGridViewTextBoxColumn, Me.MPARatingDataGridViewTextBoxColumn, Me.CountryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MOVIEBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1116, 335)
        Me.DataGridView1.TabIndex = 1
        '
        'ShowMexicanMoviesButton
        '
        Me.ShowMexicanMoviesButton.AutoSize = True
        Me.ShowMexicanMoviesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ShowMexicanMoviesButton.Location = New System.Drawing.Point(12, 381)
        Me.ShowMexicanMoviesButton.Name = "ShowMexicanMoviesButton"
        Me.ShowMexicanMoviesButton.Size = New System.Drawing.Size(195, 30)
        Me.ShowMexicanMoviesButton.TabIndex = 3
        Me.ShowMexicanMoviesButton.Text = "Show All Mexican Movies"
        Me.ShowMexicanMoviesButton.UseVisualStyleBackColor = True
        '
        'DefaultViewButton
        '
        Me.DefaultViewButton.AutoSize = True
        Me.DefaultViewButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DefaultViewButton.Location = New System.Drawing.Point(971, 389)
        Me.DefaultViewButton.Name = "DefaultViewButton"
        Me.DefaultViewButton.Size = New System.Drawing.Size(134, 30)
        Me.DefaultViewButton.TabIndex = 4
        Me.DefaultViewButton.Text = "Show All Entries"
        Me.DefaultViewButton.UseVisualStyleBackColor = True
        '
        'FilterByReleaseYearButton
        '
        Me.FilterByReleaseYearButton.AutoSize = True
        Me.FilterByReleaseYearButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FilterByReleaseYearButton.Location = New System.Drawing.Point(12, 453)
        Me.FilterByReleaseYearButton.Name = "FilterByReleaseYearButton"
        Me.FilterByReleaseYearButton.Size = New System.Drawing.Size(214, 30)
        Me.FilterByReleaseYearButton.TabIndex = 5
        Me.FilterByReleaseYearButton.Text = "Show movies released after"
        Me.FilterByReleaseYearButton.UseVisualStyleBackColor = True
        '
        'FilterByReleaseYearTextBox
        '
        Me.FilterByReleaseYearTextBox.Location = New System.Drawing.Point(232, 455)
        Me.FilterByReleaseYearTextBox.Name = "FilterByReleaseYearTextBox"
        Me.FilterByReleaseYearTextBox.Size = New System.Drawing.Size(99, 26)
        Me.FilterByReleaseYearTextBox.TabIndex = 6
        '
        'ShowAmericanMovies
        '
        Me.ShowAmericanMovies.AutoSize = True
        Me.ShowAmericanMovies.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ShowAmericanMovies.Location = New System.Drawing.Point(12, 417)
        Me.ShowAmericanMovies.Name = "ShowAmericanMovies"
        Me.ShowAmericanMovies.Size = New System.Drawing.Size(202, 30)
        Me.ShowAmericanMovies.TabIndex = 7
        Me.ShowAmericanMovies.Text = "Show all American Movies"
        Me.ShowAmericanMovies.UseVisualStyleBackColor = True
        '
        'SortTitlesAscButton
        '
        Me.SortTitlesAscButton.AutoSize = True
        Me.SortTitlesAscButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SortTitlesAscButton.Location = New System.Drawing.Point(12, 345)
        Me.SortTitlesAscButton.Name = "SortTitlesAscButton"
        Me.SortTitlesAscButton.Size = New System.Drawing.Size(203, 30)
        Me.SortTitlesAscButton.TabIndex = 8
        Me.SortTitlesAscButton.Text = "Show all in ascening order"
        Me.SortTitlesAscButton.UseVisualStyleBackColor = True
        '
        'MovieIDDataGridViewTextBoxColumn
        '
        Me.MovieIDDataGridViewTextBoxColumn.DataPropertyName = "Movie_ID"
        Me.MovieIDDataGridViewTextBoxColumn.HeaderText = "Movie_ID"
        Me.MovieIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MovieIDDataGridViewTextBoxColumn.Name = "MovieIDDataGridViewTextBoxColumn"
        Me.MovieIDDataGridViewTextBoxColumn.Width = 112
        '
        'MovieTitleDataGridViewTextBoxColumn
        '
        Me.MovieTitleDataGridViewTextBoxColumn.DataPropertyName = "Movie_Title"
        Me.MovieTitleDataGridViewTextBoxColumn.HeaderText = "Movie_Title"
        Me.MovieTitleDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MovieTitleDataGridViewTextBoxColumn.Name = "MovieTitleDataGridViewTextBoxColumn"
        Me.MovieTitleDataGridViewTextBoxColumn.Width = 124
        '
        'FullTitleDataGridViewTextBoxColumn
        '
        Me.FullTitleDataGridViewTextBoxColumn.DataPropertyName = "Full_Title"
        Me.FullTitleDataGridViewTextBoxColumn.HeaderText = "Full_Title"
        Me.FullTitleDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FullTitleDataGridViewTextBoxColumn.Name = "FullTitleDataGridViewTextBoxColumn"
        Me.FullTitleDataGridViewTextBoxColumn.Width = 108
        '
        'MovieReleaseYearDataGridViewTextBoxColumn
        '
        Me.MovieReleaseYearDataGridViewTextBoxColumn.DataPropertyName = "Movie_ReleaseYear"
        Me.MovieReleaseYearDataGridViewTextBoxColumn.HeaderText = "Movie_ReleaseYear"
        Me.MovieReleaseYearDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MovieReleaseYearDataGridViewTextBoxColumn.Name = "MovieReleaseYearDataGridViewTextBoxColumn"
        Me.MovieReleaseYearDataGridViewTextBoxColumn.Width = 188
        '
        'MovieGenreDataGridViewTextBoxColumn
        '
        Me.MovieGenreDataGridViewTextBoxColumn.DataPropertyName = "Movie_Genre"
        Me.MovieGenreDataGridViewTextBoxColumn.HeaderText = "Movie_Genre"
        Me.MovieGenreDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MovieGenreDataGridViewTextBoxColumn.Name = "MovieGenreDataGridViewTextBoxColumn"
        Me.MovieGenreDataGridViewTextBoxColumn.Width = 140
        '
        'MovieDurationDataGridViewTextBoxColumn
        '
        Me.MovieDurationDataGridViewTextBoxColumn.DataPropertyName = "Movie_Duration"
        Me.MovieDurationDataGridViewTextBoxColumn.HeaderText = "Movie_Duration"
        Me.MovieDurationDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MovieDurationDataGridViewTextBoxColumn.Name = "MovieDurationDataGridViewTextBoxColumn"
        Me.MovieDurationDataGridViewTextBoxColumn.Width = 156
        '
        'DirectorIDDataGridViewTextBoxColumn
        '
        Me.DirectorIDDataGridViewTextBoxColumn.DataPropertyName = "Director_ID"
        Me.DirectorIDDataGridViewTextBoxColumn.HeaderText = "Director_ID"
        Me.DirectorIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DirectorIDDataGridViewTextBoxColumn.Name = "DirectorIDDataGridViewTextBoxColumn"
        Me.DirectorIDDataGridViewTextBoxColumn.Width = 127
        '
        'MPARatingDataGridViewTextBoxColumn
        '
        Me.MPARatingDataGridViewTextBoxColumn.DataPropertyName = "MPA_Rating"
        Me.MPARatingDataGridViewTextBoxColumn.HeaderText = "MPA_Rating"
        Me.MPARatingDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MPARatingDataGridViewTextBoxColumn.Name = "MPARatingDataGridViewTextBoxColumn"
        Me.MPARatingDataGridViewTextBoxColumn.Width = 135
        '
        'CountryDataGridViewTextBoxColumn
        '
        Me.CountryDataGridViewTextBoxColumn.DataPropertyName = "Country"
        Me.CountryDataGridViewTextBoxColumn.HeaderText = "Country"
        Me.CountryDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CountryDataGridViewTextBoxColumn.Name = "CountryDataGridViewTextBoxColumn"
        '
        'MOVIEBindingSource
        '
        Me.MOVIEBindingSource.DataMember = "MOVIE"
        Me.MOVIEBindingSource.DataSource = Me.Deliverable_2_DatabaseDataSet
        '
        'Deliverable_2_DatabaseDataSet
        '
        Me.Deliverable_2_DatabaseDataSet.DataSetName = "Deliverable_2_DatabaseDataSet"
        Me.Deliverable_2_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MOVIETableAdapter
        '
        Me.MOVIETableAdapter.ClearBeforeFill = True
        '
        'MovieTableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1117, 491)
        Me.Controls.Add(Me.SortTitlesAscButton)
        Me.Controls.Add(Me.ShowAmericanMovies)
        Me.Controls.Add(Me.FilterByReleaseYearTextBox)
        Me.Controls.Add(Me.FilterByReleaseYearButton)
        Me.Controls.Add(Me.DefaultViewButton)
        Me.Controls.Add(Me.ShowMexicanMoviesButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MovieTableBackButton)
        Me.Name = "MovieTableForm"
        Me.Text = "Movie Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVIEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Deliverable_2_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MovieTableBackButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Deliverable_2_DatabaseDataSet As Deliverable_2_DatabaseDataSet
    Friend WithEvents MOVIEBindingSource As BindingSource
    Friend WithEvents MOVIETableAdapter As Deliverable_2_DatabaseDataSetTableAdapters.MOVIETableAdapter
    Friend WithEvents MovieIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieReleaseYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieGenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieDurationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DirectorIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MPARatingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShowMexicanMoviesButton As Button
    Friend WithEvents DefaultViewButton As Button
    Friend WithEvents FilterByReleaseYearButton As Button
    Friend WithEvents FilterByReleaseYearTextBox As TextBox
    Friend WithEvents ShowAmericanMovies As Button
    Friend WithEvents SortTitlesAscButton As Button
End Class
