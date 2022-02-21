<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ComboboxTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComboboxTable))
        Dim Tier_IDLabel As System.Windows.Forms.Label
        Dim Tier_NameLabel As System.Windows.Forms.Label
        Dim Movie_TierLabel As System.Windows.Forms.Label
        Dim Game_TierLabel As System.Windows.Forms.Label
        Dim Tier_PriceLabel As System.Windows.Forms.Label
        Dim Tier_LeadLabel As System.Windows.Forms.Label
        Me.ComboBoxBackButton = New System.Windows.Forms.Button()
        Me.Deliverable_2_DatabaseDataSet = New Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSet()
        Me.TIERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIERTableAdapter = New Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSetTableAdapters.TIERTableAdapter()
        Me.TableAdapterManager = New Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.TIERBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TIERBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tier_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.Tier_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Movie_TierCheckBox = New System.Windows.Forms.CheckBox()
        Me.Game_TierCheckBox = New System.Windows.Forms.CheckBox()
        Me.Tier_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Tier_LeadTextBox = New System.Windows.Forms.TextBox()
        Tier_IDLabel = New System.Windows.Forms.Label()
        Tier_NameLabel = New System.Windows.Forms.Label()
        Movie_TierLabel = New System.Windows.Forms.Label()
        Game_TierLabel = New System.Windows.Forms.Label()
        Tier_PriceLabel = New System.Windows.Forms.Label()
        Tier_LeadLabel = New System.Windows.Forms.Label()
        CType(Me.Deliverable_2_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIERBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TIERBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxBackButton
        '
        Me.ComboBoxBackButton.AutoSize = True
        Me.ComboBoxBackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ComboBoxBackButton.Location = New System.Drawing.Point(574, 313)
        Me.ComboBoxBackButton.Name = "ComboBoxBackButton"
        Me.ComboBoxBackButton.Size = New System.Drawing.Size(55, 30)
        Me.ComboBoxBackButton.TabIndex = 0
        Me.ComboBoxBackButton.Text = "&Back"
        Me.ComboBoxBackButton.UseVisualStyleBackColor = True
        '
        'Deliverable_2_DatabaseDataSet
        '
        Me.Deliverable_2_DatabaseDataSet.DataSetName = "Deliverable_2_DatabaseDataSet"
        Me.Deliverable_2_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TIERBindingSource
        '
        Me.TIERBindingSource.DataMember = "TIER"
        Me.TIERBindingSource.DataSource = Me.Deliverable_2_DatabaseDataSet
        '
        'TIERTableAdapter
        '
        Me.TIERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CUSTOMERTableAdapter = Nothing
        Me.TableAdapterManager.DEVELOPERTableAdapter = Nothing
        Me.TableAdapterManager.DIRECTORTableAdapter = Nothing
        Me.TableAdapterManager.DLCTableAdapter = Nothing
        Me.TableAdapterManager.EMPLOYEETableAdapter = Nothing
        Me.TableAdapterManager.GAME_TIERTableAdapter = Nothing
        Me.TableAdapterManager.GAMETableAdapter = Nothing
        Me.TableAdapterManager.MOVIE_TIERTableAdapter = Nothing
        Me.TableAdapterManager.MOVIETableAdapter = Nothing
        Me.TableAdapterManager.PARENT_COMPANYTableAdapter = Nothing
        Me.TableAdapterManager.TIERTableAdapter = Me.TIERTableAdapter
        Me.TableAdapterManager.UpdateOrder = Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TIERBindingNavigator
        '
        Me.TIERBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TIERBindingNavigator.BindingSource = Me.TIERBindingSource
        Me.TIERBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TIERBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TIERBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TIERBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TIERBindingNavigatorSaveItem})
        Me.TIERBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TIERBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TIERBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TIERBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TIERBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TIERBindingNavigator.Name = "TIERBindingNavigator"
        Me.TIERBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TIERBindingNavigator.Size = New System.Drawing.Size(649, 33)
        Me.TIERBindingNavigator.TabIndex = 1
        Me.TIERBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 20)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 20)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 25)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TIERBindingNavigatorSaveItem
        '
        Me.TIERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TIERBindingNavigatorSaveItem.Image = CType(resources.GetObject("TIERBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TIERBindingNavigatorSaveItem.Name = "TIERBindingNavigatorSaveItem"
        Me.TIERBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TIERBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tier_IDLabel
        '
        Tier_IDLabel.AutoSize = True
        Tier_IDLabel.Location = New System.Drawing.Point(169, 96)
        Tier_IDLabel.Name = "Tier_IDLabel"
        Tier_IDLabel.Size = New System.Drawing.Size(60, 20)
        Tier_IDLabel.TabIndex = 2
        Tier_IDLabel.Text = "Tier ID:"
        '
        'Tier_IDComboBox
        '
        Me.Tier_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIERBindingSource, "Tier_ID", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.Tier_IDComboBox.DataSource = Me.TIERBindingSource
        Me.Tier_IDComboBox.DisplayMember = "Tier_ID"
        Me.Tier_IDComboBox.FormattingEnabled = True
        Me.Tier_IDComboBox.Location = New System.Drawing.Point(262, 93)
        Me.Tier_IDComboBox.Name = "Tier_IDComboBox"
        Me.Tier_IDComboBox.Size = New System.Drawing.Size(174, 28)
        Me.Tier_IDComboBox.TabIndex = 3
        '
        'Tier_NameLabel
        '
        Tier_NameLabel.AutoSize = True
        Tier_NameLabel.Location = New System.Drawing.Point(169, 130)
        Tier_NameLabel.Name = "Tier_NameLabel"
        Tier_NameLabel.Size = New System.Drawing.Size(85, 20)
        Tier_NameLabel.TabIndex = 4
        Tier_NameLabel.Text = "Tier Name:"
        '
        'Tier_NameTextBox
        '
        Me.Tier_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIERBindingSource, "Tier_Name", True))
        Me.Tier_NameTextBox.Location = New System.Drawing.Point(262, 127)
        Me.Tier_NameTextBox.Name = "Tier_NameTextBox"
        Me.Tier_NameTextBox.Size = New System.Drawing.Size(174, 26)
        Me.Tier_NameTextBox.TabIndex = 5
        '
        'Movie_TierLabel
        '
        Movie_TierLabel.AutoSize = True
        Movie_TierLabel.Location = New System.Drawing.Point(169, 164)
        Movie_TierLabel.Name = "Movie_TierLabel"
        Movie_TierLabel.Size = New System.Drawing.Size(84, 20)
        Movie_TierLabel.TabIndex = 6
        Movie_TierLabel.Text = "Movie Tier:"
        '
        'Movie_TierCheckBox
        '
        Me.Movie_TierCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TIERBindingSource, "Movie_Tier", True))
        Me.Movie_TierCheckBox.Location = New System.Drawing.Point(262, 159)
        Me.Movie_TierCheckBox.Name = "Movie_TierCheckBox"
        Me.Movie_TierCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.Movie_TierCheckBox.TabIndex = 7
        Me.Movie_TierCheckBox.UseVisualStyleBackColor = True
        '
        'Game_TierLabel
        '
        Game_TierLabel.AutoSize = True
        Game_TierLabel.Location = New System.Drawing.Point(169, 195)
        Game_TierLabel.Name = "Game_TierLabel"
        Game_TierLabel.Size = New System.Drawing.Size(87, 20)
        Game_TierLabel.TabIndex = 8
        Game_TierLabel.Text = "Game Tier:"
        '
        'Game_TierCheckBox
        '
        Me.Game_TierCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TIERBindingSource, "Game_Tier", True))
        Me.Game_TierCheckBox.Location = New System.Drawing.Point(262, 190)
        Me.Game_TierCheckBox.Name = "Game_TierCheckBox"
        Me.Game_TierCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.Game_TierCheckBox.TabIndex = 9
        Me.Game_TierCheckBox.UseVisualStyleBackColor = True
        '
        'Tier_PriceLabel
        '
        Tier_PriceLabel.AutoSize = True
        Tier_PriceLabel.Location = New System.Drawing.Point(169, 224)
        Tier_PriceLabel.Name = "Tier_PriceLabel"
        Tier_PriceLabel.Size = New System.Drawing.Size(78, 20)
        Tier_PriceLabel.TabIndex = 10
        Tier_PriceLabel.Text = "Tier Price:"
        '
        'Tier_PriceTextBox
        '
        Me.Tier_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIERBindingSource, "Tier_Price", True))
        Me.Tier_PriceTextBox.Location = New System.Drawing.Point(262, 221)
        Me.Tier_PriceTextBox.Name = "Tier_PriceTextBox"
        Me.Tier_PriceTextBox.Size = New System.Drawing.Size(174, 26)
        Me.Tier_PriceTextBox.TabIndex = 11
        '
        'Tier_LeadLabel
        '
        Tier_LeadLabel.AutoSize = True
        Tier_LeadLabel.Location = New System.Drawing.Point(169, 256)
        Tier_LeadLabel.Name = "Tier_LeadLabel"
        Tier_LeadLabel.Size = New System.Drawing.Size(79, 20)
        Tier_LeadLabel.TabIndex = 12
        Tier_LeadLabel.Text = "Tier Lead:"
        '
        'Tier_LeadTextBox
        '
        Me.Tier_LeadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIERBindingSource, "Tier_Lead", True))
        Me.Tier_LeadTextBox.Location = New System.Drawing.Point(262, 253)
        Me.Tier_LeadTextBox.Name = "Tier_LeadTextBox"
        Me.Tier_LeadTextBox.Size = New System.Drawing.Size(174, 26)
        Me.Tier_LeadTextBox.TabIndex = 13
        '
        'ComboboxTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(649, 363)
        Me.Controls.Add(Tier_IDLabel)
        Me.Controls.Add(Me.Tier_IDComboBox)
        Me.Controls.Add(Tier_NameLabel)
        Me.Controls.Add(Me.Tier_NameTextBox)
        Me.Controls.Add(Movie_TierLabel)
        Me.Controls.Add(Me.Movie_TierCheckBox)
        Me.Controls.Add(Game_TierLabel)
        Me.Controls.Add(Me.Game_TierCheckBox)
        Me.Controls.Add(Tier_PriceLabel)
        Me.Controls.Add(Me.Tier_PriceTextBox)
        Me.Controls.Add(Tier_LeadLabel)
        Me.Controls.Add(Me.Tier_LeadTextBox)
        Me.Controls.Add(Me.TIERBindingNavigator)
        Me.Controls.Add(Me.ComboBoxBackButton)
        Me.Name = "ComboboxTable"
        Me.Text = "ComboboxTable"
        CType(Me.Deliverable_2_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIERBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TIERBindingNavigator.ResumeLayout(False)
        Me.TIERBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxBackButton As Button
    Friend WithEvents Deliverable_2_DatabaseDataSet As Deliverable_2_DatabaseDataSet
    Friend WithEvents TIERBindingSource As BindingSource
    Friend WithEvents TIERTableAdapter As Deliverable_2_DatabaseDataSetTableAdapters.TIERTableAdapter
    Friend WithEvents TableAdapterManager As Deliverable_2_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TIERBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TIERBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tier_IDComboBox As ComboBox
    Friend WithEvents Tier_NameTextBox As TextBox
    Friend WithEvents Movie_TierCheckBox As CheckBox
    Friend WithEvents Game_TierCheckBox As CheckBox
    Friend WithEvents Tier_PriceTextBox As TextBox
    Friend WithEvents Tier_LeadTextBox As TextBox
End Class
