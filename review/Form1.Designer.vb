<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LblFirstName = New System.Windows.Forms.Label()
        Me.LblLastName = New System.Windows.Forms.Label()
        Me.firstNameBox = New System.Windows.Forms.TextBox()
        Me.lastNameBox = New System.Windows.Forms.TextBox()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.LblAge = New System.Windows.Forms.Label()
        Me.ageBox = New System.Windows.Forms.TextBox()
        Me.LblGender = New System.Windows.Forms.Label()
        Me.genderBox = New System.Windows.Forms.ComboBox()
        Me.PeopleTable = New System.Windows.Forms.DataGridView()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.PeopleTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblFirstName
        '
        Me.LblFirstName.AutoSize = True
        Me.LblFirstName.Location = New System.Drawing.Point(42, 28)
        Me.LblFirstName.Name = "LblFirstName"
        Me.LblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.LblFirstName.TabIndex = 0
        Me.LblFirstName.Text = "FirstName:"
        '
        'LblLastName
        '
        Me.LblLastName.AutoSize = True
        Me.LblLastName.Location = New System.Drawing.Point(42, 57)
        Me.LblLastName.Name = "LblLastName"
        Me.LblLastName.Size = New System.Drawing.Size(58, 13)
        Me.LblLastName.TabIndex = 1
        Me.LblLastName.Text = "LastName:"
        '
        'firstNameBox
        '
        Me.firstNameBox.Location = New System.Drawing.Point(105, 25)
        Me.firstNameBox.Name = "firstNameBox"
        Me.firstNameBox.Size = New System.Drawing.Size(100, 20)
        Me.firstNameBox.TabIndex = 2
        '
        'lastNameBox
        '
        Me.lastNameBox.Location = New System.Drawing.Point(105, 54)
        Me.lastNameBox.Name = "lastNameBox"
        Me.lastNameBox.Size = New System.Drawing.Size(100, 20)
        Me.lastNameBox.TabIndex = 3
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(294, 25)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(75, 23)
        Me.saveBtn.TabIndex = 4
        Me.saveBtn.Text = "SAVE"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'LblAge
        '
        Me.LblAge.AutoSize = True
        Me.LblAge.Location = New System.Drawing.Point(45, 84)
        Me.LblAge.Name = "LblAge"
        Me.LblAge.Size = New System.Drawing.Size(29, 13)
        Me.LblAge.TabIndex = 5
        Me.LblAge.Text = "Age:"
        '
        'ageBox
        '
        Me.ageBox.Location = New System.Drawing.Point(105, 84)
        Me.ageBox.Name = "ageBox"
        Me.ageBox.Size = New System.Drawing.Size(100, 20)
        Me.ageBox.TabIndex = 6
        '
        'LblGender
        '
        Me.LblGender.AutoSize = True
        Me.LblGender.Location = New System.Drawing.Point(48, 112)
        Me.LblGender.Name = "LblGender"
        Me.LblGender.Size = New System.Drawing.Size(45, 13)
        Me.LblGender.TabIndex = 7
        Me.LblGender.Text = "Gender:"
        '
        'genderBox
        '
        Me.genderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.genderBox.FormattingEnabled = True
        Me.genderBox.Items.AddRange(New Object() {"M", "F"})
        Me.genderBox.Location = New System.Drawing.Point(105, 112)
        Me.genderBox.Name = "genderBox"
        Me.genderBox.Size = New System.Drawing.Size(100, 21)
        Me.genderBox.TabIndex = 8
        '
        'PeopleTable
        '
        Me.PeopleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PeopleTable.Location = New System.Drawing.Point(13, 162)
        Me.PeopleTable.Name = "PeopleTable"
        Me.PeopleTable.Size = New System.Drawing.Size(529, 171)
        Me.PeopleTable.TabIndex = 9
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(294, 120)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(294, 57)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(294, 90)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 345)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.PeopleTable)
        Me.Controls.Add(Me.genderBox)
        Me.Controls.Add(Me.LblGender)
        Me.Controls.Add(Me.ageBox)
        Me.Controls.Add(Me.LblAge)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.lastNameBox)
        Me.Controls.Add(Me.firstNameBox)
        Me.Controls.Add(Me.LblLastName)
        Me.Controls.Add(Me.LblFirstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PeopleTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblFirstName As Label
    Friend WithEvents LblLastName As Label
    Friend WithEvents firstNameBox As TextBox
    Friend WithEvents lastNameBox As TextBox
    Friend WithEvents saveBtn As Button
    Friend WithEvents LblAge As Label
    Friend WithEvents ageBox As TextBox
    Friend WithEvents LblGender As Label
    Friend WithEvents genderBox As ComboBox
    Friend WithEvents PeopleTable As DataGridView
    Friend WithEvents btnReset As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
End Class
