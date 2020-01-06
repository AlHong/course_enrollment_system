<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradesForm
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
        Me.viewGradeProjection = New System.Windows.Forms.Button()
        Me.viewTermCourseGrades = New System.Windows.Forms.Button()
        Me.termButton4 = New System.Windows.Forms.RadioButton()
        Me.termButton3 = New System.Windows.Forms.RadioButton()
        Me.termButton2 = New System.Windows.Forms.RadioButton()
        Me.termButton1 = New System.Windows.Forms.RadioButton()
        Me.LinkLabel9 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.viewTermGPA = New System.Windows.Forms.Button()
        Me.EAPContract = New System.Windows.Forms.Button()
        Me.ProbContract = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.termGPA = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Status = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.viewSpecificCourse = New System.Windows.Forms.Button()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'viewGradeProjection
        '
        Me.viewGradeProjection.BackColor = System.Drawing.SystemColors.Control
        Me.viewGradeProjection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewGradeProjection.Location = New System.Drawing.Point(294, 319)
        Me.viewGradeProjection.Name = "viewGradeProjection"
        Me.viewGradeProjection.Size = New System.Drawing.Size(175, 87)
        Me.viewGradeProjection.TabIndex = 61
        Me.viewGradeProjection.Text = "Select term to view grade projection"
        Me.viewGradeProjection.UseVisualStyleBackColor = False
        Me.viewGradeProjection.Visible = False
        '
        'viewTermCourseGrades
        '
        Me.viewTermCourseGrades.BackColor = System.Drawing.SystemColors.Control
        Me.viewTermCourseGrades.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewTermCourseGrades.Location = New System.Drawing.Point(294, 319)
        Me.viewTermCourseGrades.Name = "viewTermCourseGrades"
        Me.viewTermCourseGrades.Size = New System.Drawing.Size(175, 87)
        Me.viewTermCourseGrades.TabIndex = 60
        Me.viewTermCourseGrades.Text = "Select term to view course grades"
        Me.viewTermCourseGrades.UseVisualStyleBackColor = False
        Me.viewTermCourseGrades.Visible = False
        '
        'termButton4
        '
        Me.termButton4.AutoSize = True
        Me.termButton4.BackColor = System.Drawing.Color.White
        Me.termButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.termButton4.Location = New System.Drawing.Point(57, 418)
        Me.termButton4.Name = "termButton4"
        Me.termButton4.Size = New System.Drawing.Size(101, 24)
        Me.termButton4.TabIndex = 59
        Me.termButton4.TabStop = True
        Me.termButton4.Text = "Fall 2016"
        Me.termButton4.UseVisualStyleBackColor = False
        Me.termButton4.Visible = False
        '
        'termButton3
        '
        Me.termButton3.AutoSize = True
        Me.termButton3.BackColor = System.Drawing.Color.White
        Me.termButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.termButton3.Location = New System.Drawing.Point(57, 382)
        Me.termButton3.Name = "termButton3"
        Me.termButton3.Size = New System.Drawing.Size(124, 24)
        Me.termButton3.TabIndex = 58
        Me.termButton3.TabStop = True
        Me.termButton3.Text = "Winter 2017"
        Me.termButton3.UseVisualStyleBackColor = False
        Me.termButton3.Visible = False
        '
        'termButton2
        '
        Me.termButton2.AutoSize = True
        Me.termButton2.BackColor = System.Drawing.Color.White
        Me.termButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.termButton2.Location = New System.Drawing.Point(57, 352)
        Me.termButton2.Name = "termButton2"
        Me.termButton2.Size = New System.Drawing.Size(101, 24)
        Me.termButton2.TabIndex = 57
        Me.termButton2.TabStop = True
        Me.termButton2.Text = "Fall 2017"
        Me.termButton2.UseVisualStyleBackColor = False
        Me.termButton2.Visible = False
        '
        'termButton1
        '
        Me.termButton1.AutoSize = True
        Me.termButton1.BackColor = System.Drawing.Color.White
        Me.termButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.termButton1.Location = New System.Drawing.Point(57, 319)
        Me.termButton1.Name = "termButton1"
        Me.termButton1.Size = New System.Drawing.Size(124, 24)
        Me.termButton1.TabIndex = 56
        Me.termButton1.TabStop = True
        Me.termButton1.Text = "Winter 2018"
        Me.termButton1.UseVisualStyleBackColor = False
        Me.termButton1.Visible = False
        '
        'LinkLabel9
        '
        Me.LinkLabel9.AutoSize = True
        Me.LinkLabel9.BackColor = System.Drawing.Color.White
        Me.LinkLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel9.LinkColor = System.Drawing.Color.MidnightBlue
        Me.LinkLabel9.Location = New System.Drawing.Point(34, 207)
        Me.LinkLabel9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel9.Name = "LinkLabel9"
        Me.LinkLabel9.Size = New System.Drawing.Size(96, 26)
        Me.LinkLabel9.TabIndex = 55
        Me.LinkLabel9.TabStop = True
        Me.LinkLabel9.Text = "RAMSS"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.BackColor = System.Drawing.Color.White
        Me.LinkLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel5.Location = New System.Drawing.Point(53, 472)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(443, 20)
        Me.LinkLabel5.TabIndex = 54
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "View GPA requirements for awards or graduate school"
        Me.LinkLabel5.Visible = False
        '
        'viewTermGPA
        '
        Me.viewTermGPA.BackColor = System.Drawing.SystemColors.Control
        Me.viewTermGPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewTermGPA.Location = New System.Drawing.Point(294, 319)
        Me.viewTermGPA.Name = "viewTermGPA"
        Me.viewTermGPA.Size = New System.Drawing.Size(175, 87)
        Me.viewTermGPA.TabIndex = 53
        Me.viewTermGPA.Text = "Select term to view GPA"
        Me.viewTermGPA.UseVisualStyleBackColor = False
        Me.viewTermGPA.Visible = False
        '
        'EAPContract
        '
        Me.EAPContract.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EAPContract.Location = New System.Drawing.Point(593, 299)
        Me.EAPContract.Name = "EAPContract"
        Me.EAPContract.Size = New System.Drawing.Size(175, 87)
        Me.EAPContract.TabIndex = 52
        Me.EAPContract.Text = "View EAP Contract"
        Me.EAPContract.UseVisualStyleBackColor = True
        Me.EAPContract.Visible = False
        '
        'ProbContract
        '
        Me.ProbContract.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProbContract.Location = New System.Drawing.Point(593, 418)
        Me.ProbContract.Name = "ProbContract"
        Me.ProbContract.Size = New System.Drawing.Size(175, 87)
        Me.ProbContract.TabIndex = 51
        Me.ProbContract.Text = "View Probabtionary Contract"
        Me.ProbContract.UseVisualStyleBackColor = True
        Me.ProbContract.Visible = False
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(593, 596)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(104, 50)
        Me.Back.TabIndex = 50
        Me.Back.Text = "Go Back"
        Me.Back.UseVisualStyleBackColor = True
        Me.Back.Visible = False
        '
        'LinkLabel8
        '
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.BackColor = System.Drawing.Color.White
        Me.LinkLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel8.Location = New System.Drawing.Point(53, 570)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(144, 20)
        Me.LinkLabel8.TabIndex = 49
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "Grade Projection"
        Me.LinkLabel8.Visible = False
        '
        'LinkLabel7
        '
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.BackColor = System.Drawing.Color.White
        Me.LinkLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel7.Location = New System.Drawing.Point(53, 534)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(325, 20)
        Me.LinkLabel7.TabIndex = 48
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "View grades so far for a specific course"
        Me.LinkLabel7.Visible = False
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.BackColor = System.Drawing.Color.White
        Me.LinkLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel6.Location = New System.Drawing.Point(53, 503)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(166, 20)
        Me.LinkLabel6.TabIndex = 47
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "View course grades"
        Me.LinkLabel6.Visible = False
        '
        'termGPA
        '
        Me.termGPA.AutoSize = True
        Me.termGPA.BackColor = System.Drawing.Color.White
        Me.termGPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.termGPA.Location = New System.Drawing.Point(53, 441)
        Me.termGPA.Name = "termGPA"
        Me.termGPA.Size = New System.Drawing.Size(130, 20)
        Me.termGPA.TabIndex = 46
        Me.termGPA.TabStop = True
        Me.termGPA.Text = "View term GPA"
        Me.termGPA.Visible = False
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.BackColor = System.Drawing.Color.White
        Me.LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.Location = New System.Drawing.Point(53, 409)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(179, 20)
        Me.LinkLabel4.TabIndex = 45
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "View cumulative GPA"
        Me.LinkLabel4.Visible = False
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.Color.White
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(53, 378)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(457, 20)
        Me.LinkLabel3.TabIndex = 44
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "View deadlines to apply for restatement and Fresh Start"
        Me.LinkLabel3.Visible = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.White
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(53, 348)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(307, 20)
        Me.LinkLabel2.TabIndex = 43
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "View probationary and EAP contracts"
        Me.LinkLabel2.Visible = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.RichTextBox1.Location = New System.Drawing.Point(39, 299)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(494, 538)
        Me.RichTextBox1.TabIndex = 42
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.BackColor = System.Drawing.Color.White
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.Location = New System.Drawing.Point(53, 317)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(105, 20)
        Me.Status.TabIndex = 41
        Me.Status.TabStop = True
        Me.Status.Text = "View Status"
        Me.Status.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Label1"
        '
        'viewSpecificCourse
        '
        Me.viewSpecificCourse.BackColor = System.Drawing.SystemColors.Control
        Me.viewSpecificCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewSpecificCourse.Location = New System.Drawing.Point(294, 319)
        Me.viewSpecificCourse.Name = "viewSpecificCourse"
        Me.viewSpecificCourse.Size = New System.Drawing.Size(175, 87)
        Me.viewSpecificCourse.TabIndex = 63
        Me.viewSpecificCourse.Text = "Select course to view current grade"
        Me.viewSpecificCourse.UseVisualStyleBackColor = False
        Me.viewSpecificCourse.Visible = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(58, 484)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(452, 256)
        Me.RichTextBox2.TabIndex = 64
        Me.RichTextBox2.Text = ""
        Me.RichTextBox2.Visible = False
        '
        'GradesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.A3orLedgersizeBrowserWindow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 977)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.viewSpecificCourse)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.viewGradeProjection)
        Me.Controls.Add(Me.viewTermCourseGrades)
        Me.Controls.Add(Me.termButton4)
        Me.Controls.Add(Me.termButton3)
        Me.Controls.Add(Me.termButton2)
        Me.Controls.Add(Me.termButton1)
        Me.Controls.Add(Me.LinkLabel9)
        Me.Controls.Add(Me.LinkLabel5)
        Me.Controls.Add(Me.viewTermGPA)
        Me.Controls.Add(Me.EAPContract)
        Me.Controls.Add(Me.ProbContract)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.LinkLabel8)
        Me.Controls.Add(Me.LinkLabel7)
        Me.Controls.Add(Me.LinkLabel6)
        Me.Controls.Add(Me.termGPA)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Status)
        Me.Name = "GradesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GradesForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents viewGradeProjection As System.Windows.Forms.Button
    Friend WithEvents viewTermCourseGrades As System.Windows.Forms.Button
    Friend WithEvents termButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents termButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents termButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents termButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents LinkLabel9 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents viewTermGPA As System.Windows.Forms.Button
    Friend WithEvents EAPContract As System.Windows.Forms.Button
    Friend WithEvents ProbContract As System.Windows.Forms.Button
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents LinkLabel8 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel7 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel6 As System.Windows.Forms.LinkLabel
    Friend WithEvents termGPA As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Status As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents viewSpecificCourse As System.Windows.Forms.Button
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
End Class
