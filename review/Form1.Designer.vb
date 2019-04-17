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
        Me.saveBtn.Location = New System.Drawing.Point(45, 107)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(75, 23)
        Me.saveBtn.TabIndex = 4
        Me.saveBtn.Text = "SAVE"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 263)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.lastNameBox)
        Me.Controls.Add(Me.firstNameBox)
        Me.Controls.Add(Me.LblLastName)
        Me.Controls.Add(Me.LblFirstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblFirstName As Label
    Friend WithEvents LblLastName As Label
    Friend WithEvents firstNameBox As TextBox
    Friend WithEvents lastNameBox As TextBox
    Friend WithEvents saveBtn As Button
End Class
