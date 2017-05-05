<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gradePointForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gradePointForm))
        Me.plusminusGroupBox = New System.Windows.Forms.GroupBox()
        Me.noneRadioButton = New System.Windows.Forms.RadioButton()
        Me.aplusCheckBox = New System.Windows.Forms.CheckBox()
        Me.ufRadioButton = New System.Windows.Forms.RadioButton()
        Me.umRadioButton = New System.Windows.Forms.RadioButton()
        Me.ucfRadioButton = New System.Windows.Forms.RadioButton()
        Me.classCreditsGradeDataGridView = New System.Windows.Forms.DataGridView()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActualDataSet = New Bare_GPA.ActualDataSet()
        Me.coursesTakenTextBox = New System.Windows.Forms.TextBox()
        Me.coursesTakenLabel = New System.Windows.Forms.Label()
        Me.qualityPointsTextBox = New System.Windows.Forms.TextBox()
        Me.qualityPointsLabel = New System.Windows.Forms.Label()
        Me.totalCreditsTextBox = New System.Windows.Forms.TextBox()
        Me.totalCreditsLabel = New System.Windows.Forms.Label()
        Me.cumulativeGpaTextBox = New System.Windows.Forms.TextBox()
        Me.cumulativeGpaLabel = New System.Windows.Forms.Label()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.saveDbButton = New System.Windows.Forms.Button()
        Me.ActualTableAdapter = New Bare_GPA.ActualDataSetTableAdapters.ActualTableAdapter()
        Me.plusminusGroupBox.SuspendLayout()
        CType(Me.classCreditsGradeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'plusminusGroupBox
        '
        Me.plusminusGroupBox.Controls.Add(Me.noneRadioButton)
        Me.plusminusGroupBox.Controls.Add(Me.aplusCheckBox)
        Me.plusminusGroupBox.Controls.Add(Me.ufRadioButton)
        Me.plusminusGroupBox.Controls.Add(Me.umRadioButton)
        Me.plusminusGroupBox.Controls.Add(Me.ucfRadioButton)
        Me.plusminusGroupBox.Location = New System.Drawing.Point(373, 4)
        Me.plusminusGroupBox.Name = "plusminusGroupBox"
        Me.plusminusGroupBox.Size = New System.Drawing.Size(200, 108)
        Me.plusminusGroupBox.TabIndex = 0
        Me.plusminusGroupBox.TabStop = False
        Me.plusminusGroupBox.Text = "+/- GPA Selector"
        '
        'noneRadioButton
        '
        Me.noneRadioButton.AutoSize = True
        Me.noneRadioButton.Checked = True
        Me.noneRadioButton.Location = New System.Drawing.Point(16, 85)
        Me.noneRadioButton.Name = "noneRadioButton"
        Me.noneRadioButton.Size = New System.Drawing.Size(51, 17)
        Me.noneRadioButton.TabIndex = 3
        Me.noneRadioButton.TabStop = True
        Me.noneRadioButton.Text = "None"
        Me.noneRadioButton.UseVisualStyleBackColor = True
        '
        'aplusCheckBox
        '
        Me.aplusCheckBox.AutoSize = True
        Me.aplusCheckBox.Location = New System.Drawing.Point(128, 44)
        Me.aplusCheckBox.Name = "aplusCheckBox"
        Me.aplusCheckBox.Size = New System.Drawing.Size(66, 17)
        Me.aplusCheckBox.TabIndex = 2
        Me.aplusCheckBox.Text = "A+ > 4.0"
        Me.aplusCheckBox.UseVisualStyleBackColor = True
        '
        'ufRadioButton
        '
        Me.ufRadioButton.Location = New System.Drawing.Point(16, 62)
        Me.ufRadioButton.Name = "ufRadioButton"
        Me.ufRadioButton.Size = New System.Drawing.Size(90, 17)
        Me.ufRadioButton.TabIndex = 0
        Me.ufRadioButton.Text = "UF: +/- .33"
        Me.ufRadioButton.UseVisualStyleBackColor = True
        '
        'umRadioButton
        '
        Me.umRadioButton.AutoSize = True
        Me.umRadioButton.Location = New System.Drawing.Point(16, 39)
        Me.umRadioButton.Name = "umRadioButton"
        Me.umRadioButton.Size = New System.Drawing.Size(74, 17)
        Me.umRadioButton.TabIndex = 1
        Me.umRadioButton.Text = "UM: +/- .3"
        Me.umRadioButton.UseVisualStyleBackColor = True
        '
        'ucfRadioButton
        '
        Me.ucfRadioButton.AutoSize = True
        Me.ucfRadioButton.Location = New System.Drawing.Point(16, 20)
        Me.ucfRadioButton.Name = "ucfRadioButton"
        Me.ucfRadioButton.Size = New System.Drawing.Size(84, 17)
        Me.ucfRadioButton.TabIndex = 0
        Me.ucfRadioButton.Text = "UCF: +/- .25"
        Me.ucfRadioButton.UseVisualStyleBackColor = True
        '
        'classCreditsGradeDataGridView
        '
        Me.classCreditsGradeDataGridView.AutoGenerateColumns = False
        Me.classCreditsGradeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.classCreditsGradeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClassDataGridViewTextBoxColumn, Me.CreditsDataGridViewTextBoxColumn, Me.GradeDataGridViewTextBoxColumn})
        Me.classCreditsGradeDataGridView.DataSource = Me.ActualBindingSource
        Me.classCreditsGradeDataGridView.Location = New System.Drawing.Point(2, 4)
        Me.classCreditsGradeDataGridView.Name = "classCreditsGradeDataGridView"
        Me.classCreditsGradeDataGridView.Size = New System.Drawing.Size(365, 555)
        Me.classCreditsGradeDataGridView.TabIndex = 1
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        '
        'CreditsDataGridViewTextBoxColumn
        '
        Me.CreditsDataGridViewTextBoxColumn.DataPropertyName = "Credits"
        Me.CreditsDataGridViewTextBoxColumn.HeaderText = "Credits"
        Me.CreditsDataGridViewTextBoxColumn.Name = "CreditsDataGridViewTextBoxColumn"
        '
        'GradeDataGridViewTextBoxColumn
        '
        Me.GradeDataGridViewTextBoxColumn.DataPropertyName = "Grade"
        Me.GradeDataGridViewTextBoxColumn.HeaderText = "Grade"
        Me.GradeDataGridViewTextBoxColumn.Name = "GradeDataGridViewTextBoxColumn"
        '
        'ActualBindingSource
        '
        Me.ActualBindingSource.DataMember = "Actual"
        Me.ActualBindingSource.DataSource = Me.ActualDataSet
        '
        'ActualDataSet
        '
        Me.ActualDataSet.DataSetName = "ActualDataSet"
        Me.ActualDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'coursesTakenTextBox
        '
        Me.coursesTakenTextBox.Location = New System.Drawing.Point(467, 155)
        Me.coursesTakenTextBox.Name = "coursesTakenTextBox"
        Me.coursesTakenTextBox.ReadOnly = True
        Me.coursesTakenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.coursesTakenTextBox.TabIndex = 2
        Me.coursesTakenTextBox.Text = "0"
        Me.coursesTakenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'coursesTakenLabel
        '
        Me.coursesTakenLabel.AutoSize = True
        Me.coursesTakenLabel.Location = New System.Drawing.Point(373, 158)
        Me.coursesTakenLabel.Name = "coursesTakenLabel"
        Me.coursesTakenLabel.Size = New System.Drawing.Size(82, 13)
        Me.coursesTakenLabel.TabIndex = 3
        Me.coursesTakenLabel.Text = "Courses Taken:"
        '
        'qualityPointsTextBox
        '
        Me.qualityPointsTextBox.Location = New System.Drawing.Point(467, 207)
        Me.qualityPointsTextBox.Name = "qualityPointsTextBox"
        Me.qualityPointsTextBox.ReadOnly = True
        Me.qualityPointsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.qualityPointsTextBox.TabIndex = 4
        Me.qualityPointsTextBox.Text = "0"
        Me.qualityPointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'qualityPointsLabel
        '
        Me.qualityPointsLabel.AutoSize = True
        Me.qualityPointsLabel.Location = New System.Drawing.Point(373, 210)
        Me.qualityPointsLabel.Name = "qualityPointsLabel"
        Me.qualityPointsLabel.Size = New System.Drawing.Size(74, 13)
        Me.qualityPointsLabel.TabIndex = 5
        Me.qualityPointsLabel.Text = "Quality Points:"
        '
        'totalCreditsTextBox
        '
        Me.totalCreditsTextBox.Location = New System.Drawing.Point(467, 181)
        Me.totalCreditsTextBox.Name = "totalCreditsTextBox"
        Me.totalCreditsTextBox.ReadOnly = True
        Me.totalCreditsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.totalCreditsTextBox.TabIndex = 6
        Me.totalCreditsTextBox.Text = "0"
        Me.totalCreditsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'totalCreditsLabel
        '
        Me.totalCreditsLabel.AutoSize = True
        Me.totalCreditsLabel.Location = New System.Drawing.Point(373, 184)
        Me.totalCreditsLabel.Name = "totalCreditsLabel"
        Me.totalCreditsLabel.Size = New System.Drawing.Size(69, 13)
        Me.totalCreditsLabel.TabIndex = 7
        Me.totalCreditsLabel.Text = "Total Credits:"
        '
        'cumulativeGpaTextBox
        '
        Me.cumulativeGpaTextBox.Location = New System.Drawing.Point(467, 234)
        Me.cumulativeGpaTextBox.Name = "cumulativeGpaTextBox"
        Me.cumulativeGpaTextBox.ReadOnly = True
        Me.cumulativeGpaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.cumulativeGpaTextBox.TabIndex = 8
        Me.cumulativeGpaTextBox.Text = "0"
        Me.cumulativeGpaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cumulativeGpaLabel
        '
        Me.cumulativeGpaLabel.AutoSize = True
        Me.cumulativeGpaLabel.Location = New System.Drawing.Point(373, 237)
        Me.cumulativeGpaLabel.Name = "cumulativeGpaLabel"
        Me.cumulativeGpaLabel.Size = New System.Drawing.Size(87, 13)
        Me.cumulativeGpaLabel.TabIndex = 9
        Me.cumulativeGpaLabel.Text = "Cumulative GPA:"
        '
        'updateButton
        '
        Me.updateButton.Location = New System.Drawing.Point(408, 286)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(137, 23)
        Me.updateButton.TabIndex = 10
        Me.updateButton.Text = "Calculate Score"
        Me.updateButton.UseVisualStyleBackColor = True
        '
        'saveDbButton
        '
        Me.saveDbButton.Location = New System.Drawing.Point(408, 315)
        Me.saveDbButton.Name = "saveDbButton"
        Me.saveDbButton.Size = New System.Drawing.Size(137, 23)
        Me.saveDbButton.TabIndex = 11
        Me.saveDbButton.Text = "Save Database Changes"
        Me.saveDbButton.UseVisualStyleBackColor = True
        '
        'ActualTableAdapter
        '
        Me.ActualTableAdapter.ClearBeforeFill = True
        '
        'gradePointForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.saveDbButton)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.cumulativeGpaLabel)
        Me.Controls.Add(Me.cumulativeGpaTextBox)
        Me.Controls.Add(Me.totalCreditsLabel)
        Me.Controls.Add(Me.totalCreditsTextBox)
        Me.Controls.Add(Me.qualityPointsLabel)
        Me.Controls.Add(Me.qualityPointsTextBox)
        Me.Controls.Add(Me.coursesTakenLabel)
        Me.Controls.Add(Me.coursesTakenTextBox)
        Me.Controls.Add(Me.classCreditsGradeDataGridView)
        Me.Controls.Add(Me.plusminusGroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "gradePointForm"
        Me.Text = "Bare GPA"
        Me.plusminusGroupBox.ResumeLayout(False)
        Me.plusminusGroupBox.PerformLayout()
        CType(Me.classCreditsGradeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents plusminusGroupBox As GroupBox
    Friend WithEvents umRadioButton As RadioButton
    Friend WithEvents ucfRadioButton As RadioButton
    Friend WithEvents ufRadioButton As RadioButton
    Friend WithEvents aplusCheckBox As CheckBox
    Friend WithEvents classCreditsGradeDataGridView As DataGridView
    Friend WithEvents ActualDataSet As ActualDataSet
    Friend WithEvents ActualBindingSource As BindingSource
    Friend WithEvents ActualTableAdapter As ActualDataSetTableAdapters.ActualTableAdapter
    Friend WithEvents ClassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreditsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents coursesTakenTextBox As TextBox
    Friend WithEvents coursesTakenLabel As Label
    Friend WithEvents qualityPointsTextBox As TextBox
    Friend WithEvents qualityPointsLabel As Label
    Friend WithEvents totalCreditsTextBox As TextBox
    Friend WithEvents totalCreditsLabel As Label
    Friend WithEvents noneRadioButton As RadioButton
    Friend WithEvents cumulativeGpaTextBox As TextBox
    Friend WithEvents cumulativeGpaLabel As Label
    Friend WithEvents updateButton As Button
    Friend WithEvents saveDbButton As Button
End Class
