<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerTierJoin
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
        Me.BackButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustLNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustFNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerTierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Deliverable_2_DatabaseDataSet = New Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSet()
        Me.MaxAgeTier = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TierNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OldestCustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaxAgeByTierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Deliverable_2_DatabaseDataSet1 = New Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSet()
        Me.DemographicLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.TierNameDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumOfCustSubscribedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumOfCustByTierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Deliverable_2_DatabaseDataSet3 = New Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSet()
        Me.MoreThan1Button = New System.Windows.Forms.Button()
        Me.DefaultViewButton = New System.Windows.Forms.Button()
        Me.AgeGreaterThanAvgButton = New System.Windows.Forms.Button()
        Me.AgeLessThanAvgButton = New System.Windows.Forms.Button()
        Me.DefaultCustTierButton = New System.Windows.Forms.Button()
        Me.Deliverable_2_DatabaseDataSet2 = New Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSet()
        Me.CustomerTierTableAdapter = New Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSetTableAdapters.CustomerTierTableAdapter()
        Me.MaxAgeByTierTableAdapter = New Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSetTableAdapters.MaxAgeByTierTableAdapter()
        Me.NumOfCustByTierTableAdapter = New Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSetTableAdapters.NumOfCustByTierTableAdapter()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.MinAgeByTierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MinAgeByTierTableAdapter = New Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSetTableAdapters.MinAgeByTierTableAdapter()
        Me.TierNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YoungestCustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Deliverable_2_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxAgeByTierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Deliverable_2_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumOfCustByTierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Deliverable_2_DatabaseDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Deliverable_2_DatabaseDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinAgeByTierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.AutoSize = True
        Me.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackButton.Location = New System.Drawing.Point(936, 809)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(55, 30)
        Me.BackButton.TabIndex = 0
        Me.BackButton.Text = "&Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.CustLNameDataGridViewTextBoxColumn, Me.CustFNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.TierIDDataGridViewTextBoxColumn, Me.TierNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerTierBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(1, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1002, 243)
        Me.DataGridView1.TabIndex = 1
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.Width = 140
        '
        'CustLNameDataGridViewTextBoxColumn
        '
        Me.CustLNameDataGridViewTextBoxColumn.DataPropertyName = "Cust_LName"
        Me.CustLNameDataGridViewTextBoxColumn.HeaderText = "Cust_LName"
        Me.CustLNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CustLNameDataGridViewTextBoxColumn.Name = "CustLNameDataGridViewTextBoxColumn"
        Me.CustLNameDataGridViewTextBoxColumn.Width = 138
        '
        'CustFNameDataGridViewTextBoxColumn
        '
        Me.CustFNameDataGridViewTextBoxColumn.DataPropertyName = "Cust_FName"
        Me.CustFNameDataGridViewTextBoxColumn.HeaderText = "Cust_FName"
        Me.CustFNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CustFNameDataGridViewTextBoxColumn.Name = "CustFNameDataGridViewTextBoxColumn"
        Me.CustFNameDataGridViewTextBoxColumn.Width = 139
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.Width = 99
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.Width = 74
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
        'CustomerTierBindingSource
        '
        Me.CustomerTierBindingSource.DataMember = "CustomerTier"
        Me.CustomerTierBindingSource.DataSource = Me.Deliverable_2_DatabaseDataSet
        '
        'Deliverable_2_DatabaseDataSet
        '
        Me.Deliverable_2_DatabaseDataSet.DataSetName = "Deliverable_2_DatabaseDataSet"
        Me.Deliverable_2_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaxAgeTier
        '
        Me.MaxAgeTier.AutoSize = True
        Me.MaxAgeTier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxAgeTier.Location = New System.Drawing.Point(8, 417)
        Me.MaxAgeTier.Name = "MaxAgeTier"
        Me.MaxAgeTier.Size = New System.Drawing.Size(238, 20)
        Me.MaxAgeTier.TabIndex = 3
        Me.MaxAgeTier.Text = "Oldest Customer Age by Tier"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TierNameDataGridViewTextBoxColumn1, Me.OldestCustomerDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.MaxAgeByTierBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(12, 440)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(447, 184)
        Me.DataGridView2.TabIndex = 4
        '
        'TierNameDataGridViewTextBoxColumn1
        '
        Me.TierNameDataGridViewTextBoxColumn1.DataPropertyName = "Tier_Name"
        Me.TierNameDataGridViewTextBoxColumn1.HeaderText = "Tier_Name"
        Me.TierNameDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.TierNameDataGridViewTextBoxColumn1.Name = "TierNameDataGridViewTextBoxColumn1"
        Me.TierNameDataGridViewTextBoxColumn1.Width = 122
        '
        'OldestCustomerDataGridViewTextBoxColumn
        '
        Me.OldestCustomerDataGridViewTextBoxColumn.DataPropertyName = "Oldest_Customer"
        Me.OldestCustomerDataGridViewTextBoxColumn.HeaderText = "Oldest_Customer"
        Me.OldestCustomerDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.OldestCustomerDataGridViewTextBoxColumn.Name = "OldestCustomerDataGridViewTextBoxColumn"
        Me.OldestCustomerDataGridViewTextBoxColumn.ReadOnly = True
        Me.OldestCustomerDataGridViewTextBoxColumn.Width = 169
        '
        'MaxAgeByTierBindingSource
        '
        Me.MaxAgeByTierBindingSource.DataMember = "MaxAgeByTier"
        Me.MaxAgeByTierBindingSource.DataSource = Me.Deliverable_2_DatabaseDataSet1
        '
        'Deliverable_2_DatabaseDataSet1
        '
        Me.Deliverable_2_DatabaseDataSet1.DataSetName = "Deliverable_2_DatabaseDataSet"
        Me.Deliverable_2_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DemographicLabel
        '
        Me.DemographicLabel.AutoSize = True
        Me.DemographicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DemographicLabel.Location = New System.Drawing.Point(4, 360)
        Me.DemographicLabel.Name = "DemographicLabel"
        Me.DemographicLabel.Size = New System.Drawing.Size(278, 46)
        Me.DemographicLabel.TabIndex = 5
        Me.DemographicLabel.Text = "Demographics"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(540, 417)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Youngest Customer Age by Tier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 640)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Number of Customers per Tier"
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TierNameDataGridViewTextBoxColumn3, Me.NumOfCustSubscribedDataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.NumOfCustByTierBindingSource
        Me.DataGridView4.Location = New System.Drawing.Point(12, 663)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 62
        Me.DataGridView4.RowTemplate.Height = 28
        Me.DataGridView4.Size = New System.Drawing.Size(447, 174)
        Me.DataGridView4.TabIndex = 9
        '
        'TierNameDataGridViewTextBoxColumn3
        '
        Me.TierNameDataGridViewTextBoxColumn3.DataPropertyName = "Tier_Name"
        Me.TierNameDataGridViewTextBoxColumn3.HeaderText = "Tier_Name"
        Me.TierNameDataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.TierNameDataGridViewTextBoxColumn3.Name = "TierNameDataGridViewTextBoxColumn3"
        Me.TierNameDataGridViewTextBoxColumn3.Width = 122
        '
        'NumOfCustSubscribedDataGridViewTextBoxColumn
        '
        Me.NumOfCustSubscribedDataGridViewTextBoxColumn.DataPropertyName = "NumOfCustSubscribed"
        Me.NumOfCustSubscribedDataGridViewTextBoxColumn.HeaderText = "NumOfCustSubscribed"
        Me.NumOfCustSubscribedDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NumOfCustSubscribedDataGridViewTextBoxColumn.Name = "NumOfCustSubscribedDataGridViewTextBoxColumn"
        Me.NumOfCustSubscribedDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumOfCustSubscribedDataGridViewTextBoxColumn.Width = 208
        '
        'NumOfCustByTierBindingSource
        '
        Me.NumOfCustByTierBindingSource.DataMember = "NumOfCustByTier"
        Me.NumOfCustByTierBindingSource.DataSource = Me.Deliverable_2_DatabaseDataSet3
        '
        'Deliverable_2_DatabaseDataSet3
        '
        Me.Deliverable_2_DatabaseDataSet3.DataSetName = "Deliverable_2_DatabaseDataSet"
        Me.Deliverable_2_DatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MoreThan1Button
        '
        Me.MoreThan1Button.AutoSize = True
        Me.MoreThan1Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MoreThan1Button.Location = New System.Drawing.Point(465, 807)
        Me.MoreThan1Button.Name = "MoreThan1Button"
        Me.MoreThan1Button.Size = New System.Drawing.Size(288, 30)
        Me.MoreThan1Button.TabIndex = 10
        Me.MoreThan1Button.Text = "Show Tiers with more than 1 customer"
        Me.MoreThan1Button.UseVisualStyleBackColor = True
        '
        'DefaultViewButton
        '
        Me.DefaultViewButton.AutoSize = True
        Me.DefaultViewButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DefaultViewButton.Location = New System.Drawing.Point(465, 771)
        Me.DefaultViewButton.Name = "DefaultViewButton"
        Me.DefaultViewButton.Size = New System.Drawing.Size(80, 30)
        Me.DefaultViewButton.TabIndex = 11
        Me.DefaultViewButton.Text = "Show All"
        Me.DefaultViewButton.UseVisualStyleBackColor = True
        '
        'AgeGreaterThanAvgButton
        '
        Me.AgeGreaterThanAvgButton.AutoSize = True
        Me.AgeGreaterThanAvgButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AgeGreaterThanAvgButton.Location = New System.Drawing.Point(12, 250)
        Me.AgeGreaterThanAvgButton.Name = "AgeGreaterThanAvgButton"
        Me.AgeGreaterThanAvgButton.Size = New System.Drawing.Size(300, 30)
        Me.AgeGreaterThanAvgButton.TabIndex = 12
        Me.AgeGreaterThanAvgButton.Text = "Show customers older than the average"
        Me.AgeGreaterThanAvgButton.UseVisualStyleBackColor = True
        '
        'AgeLessThanAvgButton
        '
        Me.AgeLessThanAvgButton.AutoSize = True
        Me.AgeLessThanAvgButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AgeLessThanAvgButton.Location = New System.Drawing.Point(13, 287)
        Me.AgeLessThanAvgButton.Name = "AgeLessThanAvgButton"
        Me.AgeLessThanAvgButton.Size = New System.Drawing.Size(322, 30)
        Me.AgeLessThanAvgButton.TabIndex = 13
        Me.AgeLessThanAvgButton.Text = "Show customers younger than the average"
        Me.AgeLessThanAvgButton.UseVisualStyleBackColor = True
        '
        'DefaultCustTierButton
        '
        Me.DefaultCustTierButton.AutoSize = True
        Me.DefaultCustTierButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DefaultCustTierButton.Location = New System.Drawing.Point(915, 250)
        Me.DefaultCustTierButton.Name = "DefaultCustTierButton"
        Me.DefaultCustTierButton.Size = New System.Drawing.Size(76, 30)
        Me.DefaultCustTierButton.TabIndex = 14
        Me.DefaultCustTierButton.Text = "ShowAll"
        Me.DefaultCustTierButton.UseVisualStyleBackColor = True
        '
        'Deliverable_2_DatabaseDataSet2
        '
        Me.Deliverable_2_DatabaseDataSet2.DataSetName = "Deliverable_2_DatabaseDataSet"
        Me.Deliverable_2_DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTierTableAdapter
        '
        Me.CustomerTierTableAdapter.ClearBeforeFill = True
        '
        'MaxAgeByTierTableAdapter
        '
        Me.MaxAgeByTierTableAdapter.ClearBeforeFill = True
        '
        'NumOfCustByTierTableAdapter
        '
        Me.NumOfCustByTierTableAdapter.ClearBeforeFill = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TierNameDataGridViewTextBoxColumn2, Me.YoungestCustomerDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.MinAgeByTierBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(544, 440)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 62
        Me.DataGridView3.RowTemplate.Height = 28
        Me.DataGridView3.Size = New System.Drawing.Size(447, 184)
        Me.DataGridView3.TabIndex = 15
        '
        'MinAgeByTierBindingSource
        '
        Me.MinAgeByTierBindingSource.DataMember = "MinAgeByTier"
        Me.MinAgeByTierBindingSource.DataSource = Me.Deliverable_2_DatabaseDataSet
        '
        'MinAgeByTierTableAdapter
        '
        Me.MinAgeByTierTableAdapter.ClearBeforeFill = True
        '
        'TierNameDataGridViewTextBoxColumn2
        '
        Me.TierNameDataGridViewTextBoxColumn2.DataPropertyName = "Tier_Name"
        Me.TierNameDataGridViewTextBoxColumn2.HeaderText = "Tier_Name"
        Me.TierNameDataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.TierNameDataGridViewTextBoxColumn2.Name = "TierNameDataGridViewTextBoxColumn2"
        Me.TierNameDataGridViewTextBoxColumn2.Width = 122
        '
        'YoungestCustomerDataGridViewTextBoxColumn
        '
        Me.YoungestCustomerDataGridViewTextBoxColumn.DataPropertyName = "Youngest_Customer"
        Me.YoungestCustomerDataGridViewTextBoxColumn.HeaderText = "Youngest_Customer"
        Me.YoungestCustomerDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.YoungestCustomerDataGridViewTextBoxColumn.Name = "YoungestCustomerDataGridViewTextBoxColumn"
        Me.YoungestCustomerDataGridViewTextBoxColumn.ReadOnly = True
        Me.YoungestCustomerDataGridViewTextBoxColumn.Width = 192
        '
        'CustomerTierJoin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1003, 851)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DefaultCustTierButton)
        Me.Controls.Add(Me.AgeLessThanAvgButton)
        Me.Controls.Add(Me.AgeGreaterThanAvgButton)
        Me.Controls.Add(Me.DefaultViewButton)
        Me.Controls.Add(Me.MoreThan1Button)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DemographicLabel)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.MaxAgeTier)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "CustomerTierJoin"
        Me.Text = "CustomerTierJoin"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Deliverable_2_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxAgeByTierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Deliverable_2_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumOfCustByTierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Deliverable_2_DatabaseDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Deliverable_2_DatabaseDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinAgeByTierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Deliverable_2_DatabaseDataSet As Deliverable_2_DatabaseDataSet
    Friend WithEvents CustomerTierBindingSource As BindingSource
    Friend WithEvents CustomerTierTableAdapter As Deliverable_2_DatabaseDataSetTableAdapters.CustomerTierTableAdapter
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustFNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TierNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaxAgeTier As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Deliverable_2_DatabaseDataSet1 As Deliverable_2_DatabaseDataSet
    Friend WithEvents MaxAgeByTierBindingSource As BindingSource
    Friend WithEvents MaxAgeByTierTableAdapter As Deliverable_2_DatabaseDataSetTableAdapters.MaxAgeByTierTableAdapter
    Friend WithEvents TierNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents OldestCustomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DemographicLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Deliverable_2_DatabaseDataSet2 As Deliverable_2_DatabaseDataSet
    Friend WithEvents OldestCustomerDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Deliverable_2_DatabaseDataSet3 As Deliverable_2_DatabaseDataSet
    Friend WithEvents NumOfCustByTierBindingSource As BindingSource
    Friend WithEvents NumOfCustByTierTableAdapter As Deliverable_2_DatabaseDataSetTableAdapters.NumOfCustByTierTableAdapter
    Friend WithEvents TierNameDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents NumOfCustSubscribedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MoreThan1Button As Button
    Friend WithEvents DefaultViewButton As Button
    Friend WithEvents AgeGreaterThanAvgButton As Button
    Friend WithEvents AgeLessThanAvgButton As Button
    Friend WithEvents DefaultCustTierButton As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents MinAgeByTierBindingSource As BindingSource
    Friend WithEvents MinAgeByTierTableAdapter As Deliverable_2_DatabaseDataSetTableAdapters.MinAgeByTierTableAdapter
    Friend WithEvents TierNameDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents YoungestCustomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
