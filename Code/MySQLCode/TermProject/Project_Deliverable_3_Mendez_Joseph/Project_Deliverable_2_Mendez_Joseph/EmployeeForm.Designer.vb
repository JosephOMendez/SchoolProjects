<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
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
        Me.BackButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpFNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpLNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupervisorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLOYEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Deliverable_2_DatabaseDataSet = New Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSet()
        Me.EMPLOYEETableAdapter = New Project_Deliverable_2_Mendez_Joseph.Deliverable_2_DatabaseDataSetTableAdapters.EMPLOYEETableAdapter()
        Me.ShowEmpWithNoSupervisor = New System.Windows.Forms.Button()
        Me.ShowEmpWithSupervisor = New System.Windows.Forms.Button()
        Me.DefaultButton = New System.Windows.Forms.Button()
        Me.DepartmentInputBox = New System.Windows.Forms.TextBox()
        Me.EmployeeBasedOnInputDepartmentFName = New System.Windows.Forms.Button()
        Me.FirstNameInitial = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Deliverable_2_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.AutoSize = True
        Me.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackButton.Location = New System.Drawing.Point(733, 383)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIDDataGridViewTextBoxColumn, Me.EmpFNameDataGridViewTextBoxColumn, Me.EmpLNameDataGridViewTextBoxColumn, Me.SupervisorDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EMPLOYEEBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-1, -1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(801, 244)
        Me.DataGridView1.TabIndex = 1
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        Me.EmployeeIDDataGridViewTextBoxColumn.Width = 141
        '
        'EmpFNameDataGridViewTextBoxColumn
        '
        Me.EmpFNameDataGridViewTextBoxColumn.DataPropertyName = "Emp_FName"
        Me.EmpFNameDataGridViewTextBoxColumn.HeaderText = "Emp_FName"
        Me.EmpFNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EmpFNameDataGridViewTextBoxColumn.Name = "EmpFNameDataGridViewTextBoxColumn"
        Me.EmpFNameDataGridViewTextBoxColumn.Width = 139
        '
        'EmpLNameDataGridViewTextBoxColumn
        '
        Me.EmpLNameDataGridViewTextBoxColumn.DataPropertyName = "Emp_LName"
        Me.EmpLNameDataGridViewTextBoxColumn.HeaderText = "Emp_LName"
        Me.EmpLNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EmpLNameDataGridViewTextBoxColumn.Name = "EmpLNameDataGridViewTextBoxColumn"
        Me.EmpLNameDataGridViewTextBoxColumn.Width = 138
        '
        'SupervisorDataGridViewTextBoxColumn
        '
        Me.SupervisorDataGridViewTextBoxColumn.DataPropertyName = "Supervisor"
        Me.SupervisorDataGridViewTextBoxColumn.HeaderText = "Supervisor"
        Me.SupervisorDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SupervisorDataGridViewTextBoxColumn.Name = "SupervisorDataGridViewTextBoxColumn"
        Me.SupervisorDataGridViewTextBoxColumn.Width = 120
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.Width = 130
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.Width = 74
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.Width = 99
        '
        'EMPLOYEEBindingSource
        '
        Me.EMPLOYEEBindingSource.DataMember = "EMPLOYEE"
        Me.EMPLOYEEBindingSource.DataSource = Me.Deliverable_2_DatabaseDataSet
        '
        'Deliverable_2_DatabaseDataSet
        '
        Me.Deliverable_2_DatabaseDataSet.DataSetName = "Deliverable_2_DatabaseDataSet"
        Me.Deliverable_2_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPLOYEETableAdapter
        '
        Me.EMPLOYEETableAdapter.ClearBeforeFill = True
        '
        'ShowEmpWithNoSupervisor
        '
        Me.ShowEmpWithNoSupervisor.AutoSize = True
        Me.ShowEmpWithNoSupervisor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ShowEmpWithNoSupervisor.Location = New System.Drawing.Point(10, 263)
        Me.ShowEmpWithNoSupervisor.Name = "ShowEmpWithNoSupervisor"
        Me.ShowEmpWithNoSupervisor.Size = New System.Drawing.Size(269, 30)
        Me.ShowEmpWithNoSupervisor.TabIndex = 2
        Me.ShowEmpWithNoSupervisor.Text = "Show employees with no supervisor"
        Me.ShowEmpWithNoSupervisor.UseVisualStyleBackColor = True
        '
        'ShowEmpWithSupervisor
        '
        Me.ShowEmpWithSupervisor.AutoSize = True
        Me.ShowEmpWithSupervisor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ShowEmpWithSupervisor.Location = New System.Drawing.Point(11, 304)
        Me.ShowEmpWithSupervisor.Name = "ShowEmpWithSupervisor"
        Me.ShowEmpWithSupervisor.Size = New System.Drawing.Size(260, 30)
        Me.ShowEmpWithSupervisor.TabIndex = 3
        Me.ShowEmpWithSupervisor.Text = "Show employees with a supervisor"
        Me.ShowEmpWithSupervisor.UseVisualStyleBackColor = True
        '
        'DefaultButton
        '
        Me.DefaultButton.AutoSize = True
        Me.DefaultButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DefaultButton.Location = New System.Drawing.Point(708, 249)
        Me.DefaultButton.Name = "DefaultButton"
        Me.DefaultButton.Size = New System.Drawing.Size(80, 30)
        Me.DefaultButton.TabIndex = 4
        Me.DefaultButton.Text = "Show All"
        Me.DefaultButton.UseVisualStyleBackColor = True
        '
        'DepartmentInputBox
        '
        Me.DepartmentInputBox.Location = New System.Drawing.Point(361, 373)
        Me.DepartmentInputBox.Name = "DepartmentInputBox"
        Me.DepartmentInputBox.Size = New System.Drawing.Size(100, 26)
        Me.DepartmentInputBox.TabIndex = 8
        Me.DepartmentInputBox.Text = "Department"
        '
        'EmployeeBasedOnInputDepartmentFName
        '
        Me.EmployeeBasedOnInputDepartmentFName.Location = New System.Drawing.Point(11, 360)
        Me.EmployeeBasedOnInputDepartmentFName.Name = "EmployeeBasedOnInputDepartmentFName"
        Me.EmployeeBasedOnInputDepartmentFName.Size = New System.Drawing.Size(344, 53)
        Me.EmployeeBasedOnInputDepartmentFName.TabIndex = 7
        Me.EmployeeBasedOnInputDepartmentFName.Text = "List all employees from ________ department with ______ as their first name initi" &
    "al"
        Me.EmployeeBasedOnInputDepartmentFName.UseVisualStyleBackColor = True
        '
        'FirstNameInitial
        '
        Me.FirstNameInitial.Location = New System.Drawing.Point(467, 373)
        Me.FirstNameInitial.Name = "FirstNameInitial"
        Me.FirstNameInitial.Size = New System.Drawing.Size(134, 26)
        Me.FirstNameInitial.TabIndex = 9
        Me.FirstNameInitial.Text = "First Name Initial"
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 425)
        Me.Controls.Add(Me.FirstNameInitial)
        Me.Controls.Add(Me.DepartmentInputBox)
        Me.Controls.Add(Me.EmployeeBasedOnInputDepartmentFName)
        Me.Controls.Add(Me.DefaultButton)
        Me.Controls.Add(Me.ShowEmpWithSupervisor)
        Me.Controls.Add(Me.ShowEmpWithNoSupervisor)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "EmployeeForm"
        Me.Text = "EmployeeForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Deliverable_2_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Deliverable_2_DatabaseDataSet As Deliverable_2_DatabaseDataSet
    Friend WithEvents EMPLOYEEBindingSource As BindingSource
    Friend WithEvents EMPLOYEETableAdapter As Deliverable_2_DatabaseDataSetTableAdapters.EMPLOYEETableAdapter
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpFNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpLNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupervisorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShowEmpWithNoSupervisor As Button
    Friend WithEvents ShowEmpWithSupervisor As Button
    Friend WithEvents DefaultButton As Button
    Friend WithEvents DepartmentInputBox As TextBox
    Friend WithEvents EmployeeBasedOnInputDepartmentFName As Button
    Friend WithEvents FirstNameInitial As TextBox
End Class
