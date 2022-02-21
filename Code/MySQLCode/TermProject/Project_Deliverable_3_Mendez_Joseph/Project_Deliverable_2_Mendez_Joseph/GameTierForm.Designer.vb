<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameTierForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GameIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GameTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GameReleaseYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RatingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GameTierSuperSubBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Deliverable_2_DatabaseDataSet = New Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSet()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.GamesBasedOnInput = New System.Windows.Forms.Button()
        Me.TierInputBox = New System.Windows.Forms.TextBox()
        Me.DefaultView = New System.Windows.Forms.Button()
        Me.GameTierSuperSubTableAdapter = New Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSetTableAdapters.GameTierSuperSubTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameTierSuperSubBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Deliverable_2_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TierIDDataGridViewTextBoxColumn, Me.TierNameDataGridViewTextBoxColumn, Me.GameIDDataGridViewTextBoxColumn, Me.GameTitleDataGridViewTextBoxColumn, Me.GameReleaseYearDataGridViewTextBoxColumn, Me.RatingDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GameTierSuperSubBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-1, -1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(828, 321)
        Me.DataGridView1.TabIndex = 0
        '
        'TierIDDataGridViewTextBoxColumn
        '
        Me.TierIDDataGridViewTextBoxColumn.DataPropertyName = "Tier_ID"
        Me.TierIDDataGridViewTextBoxColumn.HeaderText = "Tier_ID"
        Me.TierIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TierIDDataGridViewTextBoxColumn.Name = "TierIDDataGridViewTextBoxColumn"
        Me.TierIDDataGridViewTextBoxColumn.Width = 97
        '
        'TierNameDataGridViewTextBoxColumn
        '
        Me.TierNameDataGridViewTextBoxColumn.DataPropertyName = "Tier_Name"
        Me.TierNameDataGridViewTextBoxColumn.HeaderText = "Tier_Name"
        Me.TierNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TierNameDataGridViewTextBoxColumn.Name = "TierNameDataGridViewTextBoxColumn"
        Me.TierNameDataGridViewTextBoxColumn.Width = 122
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
        'RatingDataGridViewTextBoxColumn
        '
        Me.RatingDataGridViewTextBoxColumn.DataPropertyName = "Rating"
        Me.RatingDataGridViewTextBoxColumn.HeaderText = "Rating"
        Me.RatingDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RatingDataGridViewTextBoxColumn.Name = "RatingDataGridViewTextBoxColumn"
        Me.RatingDataGridViewTextBoxColumn.Width = 92
        '
        'GameTierSuperSubBindingSource
        '
        Me.GameTierSuperSubBindingSource.DataMember = "GameTierSuperSub"
        Me.GameTierSuperSubBindingSource.DataSource = Me.Deliverable_2_DatabaseDataSet
        '
        'Deliverable_2_DatabaseDataSet
        '
        Me.Deliverable_2_DatabaseDataSet.DataSetName = "Deliverable_2_DatabaseDataSet"
        Me.Deliverable_2_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BackButton
        '
        Me.BackButton.AutoSize = True
        Me.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackButton.Location = New System.Drawing.Point(760, 363)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(55, 30)
        Me.BackButton.TabIndex = 1
        Me.BackButton.Text = "&Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'GamesBasedOnInput
        '
        Me.GamesBasedOnInput.AutoSize = True
        Me.GamesBasedOnInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GamesBasedOnInput.Location = New System.Drawing.Point(12, 327)
        Me.GamesBasedOnInput.Name = "GamesBasedOnInput"
        Me.GamesBasedOnInput.Size = New System.Drawing.Size(240, 30)
        Me.GamesBasedOnInput.TabIndex = 2
        Me.GamesBasedOnInput.Text = "Show games from _______ tier"
        Me.GamesBasedOnInput.UseVisualStyleBackColor = True
        '
        'TierInputBox
        '
        Me.TierInputBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TierInputBox.Location = New System.Drawing.Point(269, 330)
        Me.TierInputBox.Name = "TierInputBox"
        Me.TierInputBox.Size = New System.Drawing.Size(110, 26)
        Me.TierInputBox.TabIndex = 3
        Me.TierInputBox.Text = "E.g. 3, 4, or 5"
        '
        'DefaultView
        '
        Me.DefaultView.AutoSize = True
        Me.DefaultView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DefaultView.Location = New System.Drawing.Point(740, 327)
        Me.DefaultView.Name = "DefaultView"
        Me.DefaultView.Size = New System.Drawing.Size(80, 30)
        Me.DefaultView.TabIndex = 4
        Me.DefaultView.Text = "Show All"
        Me.DefaultView.UseVisualStyleBackColor = True
        '
        'GameTierSuperSubTableAdapter
        '
        Me.GameTierSuperSubTableAdapter.ClearBeforeFill = True
        '
        'GameTierForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 404)
        Me.Controls.Add(Me.DefaultView)
        Me.Controls.Add(Me.TierInputBox)
        Me.Controls.Add(Me.GamesBasedOnInput)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "GameTierForm"
        Me.Text = "GameTierForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameTierSuperSubBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Deliverable_2_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Deliverable_2_DatabaseDataSet As Deliverable_2_DatabaseDataSet
    Friend WithEvents GameTierSuperSubBindingSource As BindingSource
    Friend WithEvents GameTierSuperSubTableAdapter As Deliverable_2_DatabaseDataSetTableAdapters.GameTierSuperSubTableAdapter
    Friend WithEvents TierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TierNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GameIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GameTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GameReleaseYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RatingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BackButton As Button
    Friend WithEvents GamesBasedOnInput As Button
    Friend WithEvents TierInputBox As TextBox
    Friend WithEvents DefaultView As Button
End Class
