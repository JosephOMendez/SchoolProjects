<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeForm
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ShowMovieTableButton = New System.Windows.Forms.Button()
        Me.ShowGameTableButton = New System.Windows.Forms.Button()
        Me.ComboboxViewButton = New System.Windows.Forms.Button()
        Me.JoinTableButton = New System.Windows.Forms.Button()
        Me.ShowEmployeeButton = New System.Windows.Forms.Button()
        Me.ShowGameTierTable = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.AutoSize = True
        Me.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ExitButton.Location = New System.Drawing.Point(290, 347)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(45, 30)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ShowMovieTableButton
        '
        Me.ShowMovieTableButton.AutoSize = True
        Me.ShowMovieTableButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ShowMovieTableButton.Location = New System.Drawing.Point(239, 12)
        Me.ShowMovieTableButton.Name = "ShowMovieTableButton"
        Me.ShowMovieTableButton.Size = New System.Drawing.Size(147, 30)
        Me.ShowMovieTableButton.TabIndex = 1
        Me.ShowMovieTableButton.Text = "Show &Movie Table"
        Me.ShowMovieTableButton.UseVisualStyleBackColor = True
        '
        'ShowGameTableButton
        '
        Me.ShowGameTableButton.AutoSize = True
        Me.ShowGameTableButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ShowGameTableButton.Location = New System.Drawing.Point(237, 69)
        Me.ShowGameTableButton.Name = "ShowGameTableButton"
        Me.ShowGameTableButton.Size = New System.Drawing.Size(150, 30)
        Me.ShowGameTableButton.TabIndex = 2
        Me.ShowGameTableButton.Text = "Show &Game Table"
        Me.ShowGameTableButton.UseVisualStyleBackColor = True
        '
        'ComboboxViewButton
        '
        Me.ComboboxViewButton.AutoSize = True
        Me.ComboboxViewButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ComboboxViewButton.Location = New System.Drawing.Point(228, 126)
        Me.ComboboxViewButton.Name = "ComboboxViewButton"
        Me.ComboboxViewButton.Size = New System.Drawing.Size(169, 30)
        Me.ComboboxViewButton.TabIndex = 3
        Me.ComboboxViewButton.Text = "Show Tier &Combobox"
        Me.ComboboxViewButton.UseVisualStyleBackColor = True
        '
        'JoinTableButton
        '
        Me.JoinTableButton.AutoSize = True
        Me.JoinTableButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.JoinTableButton.Location = New System.Drawing.Point(116, 297)
        Me.JoinTableButton.Name = "JoinTableButton"
        Me.JoinTableButton.Size = New System.Drawing.Size(392, 30)
        Me.JoinTableButton.TabIndex = 4
        Me.JoinTableButton.Text = "Show Customer and Tier Relationship Demographics"
        Me.JoinTableButton.UseVisualStyleBackColor = True
        '
        'ShowEmployeeButton
        '
        Me.ShowEmployeeButton.AutoSize = True
        Me.ShowEmployeeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ShowEmployeeButton.Location = New System.Drawing.Point(224, 183)
        Me.ShowEmployeeButton.Name = "ShowEmployeeButton"
        Me.ShowEmployeeButton.Size = New System.Drawing.Size(176, 30)
        Me.ShowEmployeeButton.TabIndex = 5
        Me.ShowEmployeeButton.Text = "Show Employee Table"
        Me.ShowEmployeeButton.UseVisualStyleBackColor = True
        '
        'ShowGameTierTable
        '
        Me.ShowGameTierTable.AutoSize = True
        Me.ShowGameTierTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ShowGameTierTable.Location = New System.Drawing.Point(222, 240)
        Me.ShowGameTierTable.Name = "ShowGameTierTable"
        Me.ShowGameTierTable.Size = New System.Drawing.Size(181, 30)
        Me.ShowGameTierTable.TabIndex = 6
        Me.ShowGameTierTable.Text = "Show Game-Tier Table"
        Me.ShowGameTierTable.UseVisualStyleBackColor = True
        '
        'WelcomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 389)
        Me.Controls.Add(Me.ShowGameTierTable)
        Me.Controls.Add(Me.ShowEmployeeButton)
        Me.Controls.Add(Me.JoinTableButton)
        Me.Controls.Add(Me.ComboboxViewButton)
        Me.Controls.Add(Me.ShowGameTableButton)
        Me.Controls.Add(Me.ShowMovieTableButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "WelcomeForm"
        Me.Text = "Welcome to Visio's Database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents ShowMovieTableButton As Button
    Friend WithEvents ShowGameTableButton As Button
    Friend WithEvents ComboboxViewButton As Button
    Friend WithEvents JoinTableButton As Button
    Friend WithEvents ShowEmployeeButton As Button
    Friend WithEvents ShowGameTierTable As Button
End Class
