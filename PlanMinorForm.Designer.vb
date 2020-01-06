<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanMinorForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MinorComboBox = New System.Windows.Forms.ComboBox()
        Me.ChooseMinorButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MinorLabel = New System.Windows.Forms.Label()
        Me.CoursesLabel1 = New System.Windows.Forms.Label()
        Me.CoursesLabel2 = New System.Windows.Forms.Label()
        Me.CoursesLabel3 = New System.Windows.Forms.Label()
        Me.ViewMinorButton = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MinorCourses1 = New Project.MinorCoursesUserControl()
        Me.MinorCourses3 = New Project.MinorCoursesUserControl()
        Me.MinorCourses2 = New Project.MinorCoursesUserControl()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 401)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Minor:"
        '
        'MinorComboBox
        '
        Me.MinorComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinorComboBox.FormattingEnabled = True
        Me.MinorComboBox.Items.AddRange(New Object() {"Mathematics"})
        Me.MinorComboBox.Location = New System.Drawing.Point(175, 398)
        Me.MinorComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinorComboBox.Name = "MinorComboBox"
        Me.MinorComboBox.Size = New System.Drawing.Size(160, 33)
        Me.MinorComboBox.TabIndex = 2
        '
        'ChooseMinorButton
        '
        Me.ChooseMinorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChooseMinorButton.Location = New System.Drawing.Point(344, 431)
        Me.ChooseMinorButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChooseMinorButton.Name = "ChooseMinorButton"
        Me.ChooseMinorButton.Size = New System.Drawing.Size(177, 37)
        Me.ChooseMinorButton.TabIndex = 3
        Me.ChooseMinorButton.Text = "Choose"
        Me.ChooseMinorButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 475)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Required courses:"
        '
        'LogoutButton
        '
        Me.LogoutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutButton.Location = New System.Drawing.Point(863, 263)
        Me.LogoutButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(100, 42)
        Me.LogoutButton.TabIndex = 7
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(89, 348)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Your minor:"
        '
        'MinorLabel
        '
        Me.MinorLabel.AutoSize = True
        Me.MinorLabel.BackColor = System.Drawing.SystemColors.Window
        Me.MinorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinorLabel.Location = New System.Drawing.Point(232, 348)
        Me.MinorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MinorLabel.MaximumSize = New System.Drawing.Size(133, 0)
        Me.MinorLabel.Name = "MinorLabel"
        Me.MinorLabel.Size = New System.Drawing.Size(46, 25)
        Me.MinorLabel.TabIndex = 9
        Me.MinorLabel.Text = "N/A"
        '
        'CoursesLabel1
        '
        Me.CoursesLabel1.AutoSize = True
        Me.CoursesLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.CoursesLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoursesLabel1.Location = New System.Drawing.Point(91, 511)
        Me.CoursesLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CoursesLabel1.Name = "CoursesLabel1"
        Me.CoursesLabel1.Size = New System.Drawing.Size(162, 25)
        Me.CoursesLabel1.TabIndex = 10
        Me.CoursesLabel1.Text = "1 of the following:"
        '
        'CoursesLabel2
        '
        Me.CoursesLabel2.AutoSize = True
        Me.CoursesLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.CoursesLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoursesLabel2.Location = New System.Drawing.Point(91, 671)
        Me.CoursesLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CoursesLabel2.Name = "CoursesLabel2"
        Me.CoursesLabel2.Size = New System.Drawing.Size(162, 25)
        Me.CoursesLabel2.TabIndex = 11
        Me.CoursesLabel2.Text = "1 of the following:"
        '
        'CoursesLabel3
        '
        Me.CoursesLabel3.AutoSize = True
        Me.CoursesLabel3.BackColor = System.Drawing.SystemColors.Window
        Me.CoursesLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoursesLabel3.Location = New System.Drawing.Point(991, 511)
        Me.CoursesLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CoursesLabel3.Name = "CoursesLabel3"
        Me.CoursesLabel3.Size = New System.Drawing.Size(162, 25)
        Me.CoursesLabel3.TabIndex = 12
        Me.CoursesLabel3.Text = "4 of the following:"
        '
        'ViewMinorButton
        '
        Me.ViewMinorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewMinorButton.Location = New System.Drawing.Point(344, 390)
        Me.ViewMinorButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ViewMinorButton.Name = "ViewMinorButton"
        Me.ViewMinorButton.Size = New System.Drawing.Size(177, 36)
        Me.ViewMinorButton.TabIndex = 17
        Me.ViewMinorButton.Text = "View"
        Me.ViewMinorButton.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.White
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.MidnightBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(90, 286)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(120, 32)
        Me.LinkLabel1.TabIndex = 22
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "RAMSS"
        '
        'MinorCourses1
        '
        Me.MinorCourses1.Location = New System.Drawing.Point(96, 539)
        Me.MinorCourses1.Margin = New System.Windows.Forms.Padding(5)
        Me.MinorCourses1.Name = "MinorCourses1"
        Me.MinorCourses1.Size = New System.Drawing.Size(897, 128)
        Me.MinorCourses1.TabIndex = 16
        '
        'MinorCourses3
        '
        Me.MinorCourses3.Location = New System.Drawing.Point(997, 539)
        Me.MinorCourses3.Margin = New System.Windows.Forms.Padding(5)
        Me.MinorCourses3.Name = "MinorCourses3"
        Me.MinorCourses3.Size = New System.Drawing.Size(897, 156)
        Me.MinorCourses3.TabIndex = 15
        '
        'MinorCourses2
        '
        Me.MinorCourses2.Location = New System.Drawing.Point(96, 699)
        Me.MinorCourses2.Margin = New System.Windows.Forms.Padding(5)
        Me.MinorCourses2.Name = "MinorCourses2"
        Me.MinorCourses2.Size = New System.Drawing.Size(897, 156)
        Me.MinorCourses2.TabIndex = 14
        '
        'PlanMinorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.A3orLedgersizeBrowserWindow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1685, 1045)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.ViewMinorButton)
        Me.Controls.Add(Me.MinorCourses1)
        Me.Controls.Add(Me.MinorCourses3)
        Me.Controls.Add(Me.MinorCourses2)
        Me.Controls.Add(Me.CoursesLabel3)
        Me.Controls.Add(Me.CoursesLabel2)
        Me.Controls.Add(Me.CoursesLabel1)
        Me.Controls.Add(Me.MinorLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ChooseMinorButton)
        Me.Controls.Add(Me.MinorComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PlanMinorForm"
        Me.Text = "RAMSS - Plan Minor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents MinorComboBox As ComboBox
    Friend WithEvents ChooseMinorButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LogoutButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents MinorLabel As Label
    Friend WithEvents CoursesLabel1 As Label
    Friend WithEvents CoursesLabel2 As Label
    Friend WithEvents CoursesLabel3 As Label
    Friend WithEvents MinorCourses2 As MinorCoursesUserControl
    Friend WithEvents MinorCourses3 As MinorCoursesUserControl
    Friend WithEvents MinorCourses1 As MinorCoursesUserControl
    Friend WithEvents ViewMinorButton As Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
