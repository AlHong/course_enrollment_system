Public Class GradesForm

    'check if it's bob or alex
    Public view As String = "MainPage"
    Public student As String = "Bob"
    Public title As String

    Public Shared winterGrades As Boolean
    Public Shared fallGrades As Boolean

    Private Sub Status_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Status.LinkClicked

        Label1.Visible = True
        Label1.Text = "Status"

        view = "Options"

        If (Chooseterm.fys) Then
            RichTextBox1.AppendText("Clear")
        ElseIf (Chooseterm.sys) Then
            RichTextBox1.AppendText("PROB" & Environment.NewLine & "Reason: GPA below 2.0")
        End If

        Me.RichTextBox1.Show()
        hideLabels()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click

        If view = "MainPage" Then
            'Me.LinkLabel1.Show()

            'Me.Back.Hide()
            'hideLabels()
            Dim home As New HomeForm()
            Me.Hide()
            home.Show()
        ElseIf view = "Options" Then
            view = "MainPage"

            Me.Label1.Visible = False
            'Me.LinkLabel1.Hide()
            Me.RichTextBox1.Hide()
            Me.RichTextBox1.Clear()

            Me.Back.Show()
            showLabels()

            Me.ProbContract.Hide()
            Me.EAPContract.Hide()
            Me.viewTermGPA.Hide()
            Me.viewTermCourseGrades.Hide()
            Me.viewGradeProjection.Hide()

            termButton1.Hide()
            termButton2.Hide()
            termButton3.Hide()
            termButton4.Hide()

            RichTextBox2.Hide()
            RichTextBox2.Clear()
            viewSpecificCourse.Hide()

        ElseIf view = "TermGPA" Then
            view = "Options"

            Me.Back.Show()
            If (Chooseterm.sys) Then
                termButton1.Show()
                termButton2.Show()
                termButton3.Show()
                termButton4.Show()
                termButton1.Text = "Winter 2018"
                termButton2.Text = "Fall 2017"
                termButton3.Text = "Winter 2017"
                termButton4.Text = "Fall 2016"
            ElseIf (Chooseterm.fys) Then
                termButton1.Show()
                termButton2.Show()
                termButton3.Hide()
                termButton4.Hide()
                termButton1.Text = "Winter 2018"
                termButton2.Text = "Fall 2017"
            End If

            viewTermGPA.Show()

            hideLabels()
            Me.RichTextBox1.Hide()
        ElseIf view = "TermCourseGrades" Then
            view = "Options"

            Me.Back.Show()
            If (Chooseterm.sys) Then
                termButton1.Show()
                termButton2.Show()
                termButton3.Show()
                termButton4.Show()
                termButton1.Text = "Winter 2018"
                termButton2.Text = "Fall 2017"
                termButton3.Text = "Winter 2017"
                termButton4.Text = "Fall 2016"
            ElseIf (Chooseterm.fys) Then
                termButton1.Show()
                termButton2.Show()
                termButton3.Hide()
                termButton4.Hide()
                termButton1.Text = "Winter 2018"
                termButton2.Text = "Fall 2017"
            End If

            viewTermCourseGrades.Show()

            hideLabels()
            Me.RichTextBox1.Hide()
        ElseIf view = "GradeProjection" Then
            view = "Options"

            viewGradeProjection.Show()
            hideLabels()
        End If

    End Sub

    Private Sub LinkLabel2_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked


        Label1.Visible = True
        Label1.Text = "Probationary and EAP contracts"

        view = "Options"

        Me.RichTextBox1.Show()
        Me.ProbContract.Show()
        Me.EAPContract.Show()

        hideLabels()

    End Sub


    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked


        Label1.Visible = True
        Label1.Text = "Deadlines to apply for reinstatement and Fresh Start"

        view = "Options"

        If (Chooseterm.fys) Then
            RichTextBox1.AppendText("Your Status is: Clear" & Environment.NewLine & Environment.NewLine & "Deadlines are only available for students that have a RTW and EAP status.")
        ElseIf (Chooseterm.sys) Then
            RichTextBox1.AppendText("Your Status is: PROB" & Environment.NewLine & Environment.NewLine & "Deadlines are only available for students that have a RTW and EAP status.")
            'RichTextBox1.AppendText("Restatement Deadline: October 14, 2018" & Environment.NewLine & Environment.NewLine & "Fresh Start Deadline: November 2, 2018")
        End If

        Me.RichTextBox1.Show()

        hideLabels()

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked

        Label1.Visible = True
        Label1.Text = "Cumulative GPA"

        view = "Options"

        If (Chooseterm.fys) Then
            RichTextBox1.Text = "N/A"
        ElseIf (Chooseterm.sys) Then
            RichTextBox1.Text = "1.9"
        End If

        Me.RichTextBox1.Show()

        hideLabels()

    End Sub

    Private Sub ProbContract_Click(sender As Object, e As EventArgs) Handles ProbContract.Click
        RichTextBox1.Clear()
        RichTextBox1.AppendText("Probationary Contract" & Environment.NewLine & Environment.NewLine & "Probationary students who do not confirm and submit a signed copy of this contract with their School/Department within five (5) business days from the start of the term will be dropped from their classes by their School/Department.")
        RichTextBox1.AppendText(Environment.NewLine & Environment.NewLine & "Maximum Number of Courses to be taken:" & Environment.NewLine & "Minimum Number of Courses to be taken:")
        RichTextBox1.AppendText(Environment.NewLine & Environment.NewLine & "Student ID:" & Environment.NewLine & "First Name:" & Environment.NewLine & "Program:")
        RichTextBox1.AppendText(Environment.NewLine & Environment.NewLine & "Signature:")
    End Sub

    Private Sub EAPContract_Click(sender As Object, e As EventArgs) Handles EAPContract.Click
        RichTextBox1.Clear()
        RichTextBox1.AppendText("Extended Academic Pobation Contract 1" & Environment.NewLine & Environment.NewLine)
        RichTextBox1.AppendText("Student:" & Environment.NewLine & "Reviews EAP Contract 1 details" & Environment.NewLine & "Acknowledges EAP Contract 1 requirements by signing the contract")
        RichTextBox1.AppendText(Environment.NewLine & Environment.NewLine & "Student Information:" & Environment.NewLine & Environment.NewLine & "Student ID:" & Environment.NewLine & "First Name:" & Environment.NewLine & "Program:")
        RichTextBox1.AppendText(Environment.NewLine & Environment.NewLine & "EAP Contract 1 Term Requirements:" & Environment.NewLine & "Term and Year of EAP Contract 1 Plan of Study:" & Environment.NewLine)
        RichTextBox1.AppendText(Environment.NewLine & "Student Signature:" & Environment.NewLine & "Date:" & Environment.NewLine)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "RAMMS - Grades, GPA, and Status"

        'Me.LinkLabel1.Hide()
        Me.RichTextBox1.Hide()

        Me.Back.Show()
        showLabels()
        Me.Label1.Visible = False


    End Sub

    Private Sub viewTermGPAButton_Click(sender As Object, e As EventArgs) Handles viewTermGPA.Click
        RichTextBox1.Clear()
        view = "TermGPA"

        'WinterButton1.Show()
        'FallButton2.Show()
        'WinterButton3.Show()
        'FallButton4.Show()

        If (Chooseterm.sys) And termButton1.Checked = True Then
            view = "Options"
            MsgBox("Cannot view course GPA. Student in progress of enrolling in this term.")
        ElseIf (Chooseterm.sys) And termButton2.Checked = True Then
            view = "Options"
            MsgBox("Cannot view course GPA. Student in progress of enrolling in this term.")
        ElseIf (Chooseterm.sys) And termButton3.Checked = True Then
            RichTextBox1.Text = "Winter 2017 - GPA: 1.9"
            termButton1.Hide()
            termButton2.Hide()
            termButton3.Hide()
            termButton4.Hide()

            viewTermGPA.Hide()
            RichTextBox1.Show()
        ElseIf (Chooseterm.sys) And termButton4.Checked = True Then
            RichTextBox1.Text = "Fall 2016 - GPA: 1.9"
            termButton1.Hide()
            termButton2.Hide()
            termButton3.Hide()
            termButton4.Hide()

            viewTermGPA.Hide()
            RichTextBox1.Show()
        ElseIf (Chooseterm.fys) And termButton1.Checked = True Then
            view = "Options"
            MsgBox("Cannot view course GPA. Student in progress of enrolling in this term.")
        ElseIf (Chooseterm.fys) And termButton2.Checked = True Then
            view = "Options"
            MsgBox("Cannot view course GPA. Student in progress of enrolling in this term.")
        End If
    End Sub



    Private Sub viewTermCourseGrades_Click(sender As Object, e As EventArgs) Handles viewTermCourseGrades.Click

        view = "TermCourseGrades"

        If (Chooseterm.sys) And termButton1.Checked = True Then
            view = "Options"
            MsgBox("Cannot view course grades. Student in progress of enrolling in this term.")
        ElseIf (Chooseterm.sys) And termButton2.Checked = True Then
            view = "Options"
            MsgBox("Cannot view course grades. Student in progress of enrolling in this term.")
        ElseIf (Chooseterm.sys) And termButton3.Checked = True Then

            GradesForm.winterGrades = True
            'replace this with winter 2016 classes for first year
            Dim courseGradesForm As New CourseGradesForm
            courseGradesForm.Show()
            Me.Hide()



            'RichTextBox1.Text = "Winter 2016 - GPA: 4.0 asdasdasdasd"
            ' termButton1.Hide()
            'termButton2.Hide()
            'termButton3.Hide()
            'termButton4.Hide()

            'viewTermCourseGrades.Hide()
            'RichTextBox1.Show()
        ElseIf (Chooseterm.sys) And termButton4.Checked = True Then

            'replace this with Fall 2015 classes for first year
            GradesForm.fallGrades = True
            Dim courseGradesForm As New CourseGradesForm
            courseGradesForm.Show()
            Me.Hide()

            'RichTextBox1.Text = "Fall 2015 - GPA: 4.0"
            'termButton1.Hide()
            'termButton2.Hide()
            'termButton3.Hide()
            'termButton4.Hide()

            'viewTermCourseGrades.Hide()
            'RichTextBox1.Show()
        ElseIf (Chooseterm.fys) And termButton1.Checked = True Then
            view = "Options"
            MsgBox("Cannot view course grades. Student in progress of enrolling in this term.")
        ElseIf (Chooseterm.fys) And termButton2.Checked = True Then
            view = "Options"
            MsgBox("Cannot view course grades. Student in progress of enrolling in this term.")
        End If

    End Sub

    Private Sub termButton1_CheckedChanged(sender As Object, e As EventArgs) Handles termButton1.Click
        termButton1.Checked = True
        termButton2.Checked = False
        termButton3.Checked = False
        termButton4.Checked = False
    End Sub

    Private Sub termButton2_CheckedChanged(sender As Object, e As EventArgs) Handles termButton2.Click
        termButton1.Checked = False
        termButton2.Checked = True
        termButton3.Checked = False
        termButton4.Checked = False
    End Sub

    Private Sub termButton3_CheckedChanged(sender As Object, e As EventArgs) Handles termButton3.Click
        termButton1.Checked = False
        termButton2.Checked = False
        termButton3.Checked = True
        termButton4.Checked = False
    End Sub

    Private Sub termButton4_CheckedChanged(sender As Object, e As EventArgs) Handles termButton4.Click
        termButton1.Checked = False
        termButton2.Checked = False
        termButton3.Checked = False
        termButton4.Checked = True
    End Sub


    Private Sub termGPA_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles termGPA.LinkClicked

        Label1.Visible = True
        Label1.Text = "Term GPA"

        view = "Options"

        viewTermGPA.Show()

        'change based on which student checked the mark
        If (Chooseterm.sys) Then
            termButton1.Show()
            termButton2.Show()
            termButton3.Show()
            termButton4.Show()
            termButton1.Text = "Winter 2018"
            termButton2.Text = "Fall 2017"
            termButton3.Text = "Winter 2017"
            termButton4.Text = "Fall 2016"
        ElseIf (Chooseterm.fys) Then
            termButton1.Show()
            termButton2.Show()
            termButton3.Hide()
            termButton4.Hide()
            termButton1.Text = "Winter 2018"
            termButton2.Text = "Fall 2017"
        End If

        hideLabels()

    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked

        Label1.Visible = True
        Label1.Text = "Course Grades"

        view = "Options"

        viewTermCourseGrades.Show()

        'change based on which student checked the mark
        If (Chooseterm.sys) Then
            termButton1.Show()
            termButton2.Show()
            termButton3.Show()
            termButton4.Show()
            termButton1.Text = "Winter 2018"
            termButton2.Text = "Fall 2017"
            termButton3.Text = "Winter 2017"
            termButton4.Text = "Fall 2016"
        ElseIf (Chooseterm.fys) Then
            termButton1.Show()
            termButton2.Show()
            termButton3.Hide()
            termButton4.Hide()
            termButton1.Text = "Winter 2018"
            termButton2.Text = "Fall 2017"
        End If

        hideLabels()

    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked

        

        view = "Options"

        viewGradeProjection.Show()

        termButton1.Show()
        termButton1.Text = "First Year - First Term"

        hideLabels()
    End Sub


    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked

        If (Chooseterm.fys) Then
            MsgBox("User is in first year and in progress of enrolling. No grades available.")
        ElseIf (Chooseterm.sys) Then

            view = "Options"
            RichTextBox2.Visible = True
            Label1.Visible = True
            Label1.Text = "Grade for specific course in Fall 2016"

            termButton1.Show()
            termButton2.Show()
            termButton3.Show()
            termButton4.Show()

            termButton1.Text = "Discrete Math I"
            termButton2.Text = "Chemistry"
            termButton3.Text = "Computer Science I"
            termButton4.Text = "Music and Film"

            viewSpecificCourse.Show()

            hideLabels()
        End If

    End Sub

    Private Sub viewGradeProjection_Click(sender As Object, e As EventArgs) Handles viewGradeProjection.Click

        If (Chooseterm.fys) And termButton1.Checked = True Then
            'put something else
            RichTextBox2.Visible = True
            RichTextBox2.AppendText("- Discrete Math I (MTH110) is needed in second year to take Discrete Structures")
            RichTextBox2.AppendText(Environment.NewLine & Environment.NewLine & "- Computer Science I is needed to take Computer Science II (CPS209) in the following semester and also C and Unix (CPS393) in the second year.")
            RichTextBox2.AppendText(Environment.NewLine & Environment.NewLine & "- Computer Organization I (CPS213) is needed to take Computer Organization II (CPS310) in the following semester")
        ElseIf (Chooseterm.sys) And termButton1.Checked = True Then
            RichTextBox2.Visible = True
            RichTextBox2.AppendText("- Discrete Math I (MTH110) is needed in second year to take Discrete Structures")
            RichTextBox2.AppendText(Environment.NewLine & Environment.NewLine & "- Computer Science I is needed to take Computer Science II (CPS209) in the following semester and also C and Unix (CPS393) in the second year.")
            RichTextBox2.AppendText(Environment.NewLine & Environment.NewLine & "- Computer Organization I (CPS213) is needed to take Computer Organization II (CPS310) in the following semester")
        End If

    End Sub

    Sub hideLabels()
        Me.Status.Hide()
        Me.LinkLabel2.Hide()
        Me.LinkLabel3.Hide()
        Me.LinkLabel4.Hide()
        Me.LinkLabel5.Hide()
        Me.termGPA.Hide()
        Me.LinkLabel6.Hide()
        Me.LinkLabel7.Hide()
        Me.LinkLabel8.Hide()
    End Sub

    Sub showLabels()
        Me.Status.Show()
        Me.LinkLabel2.Show()
        Me.LinkLabel3.Show()
        Me.LinkLabel4.Show()
        Me.LinkLabel5.Show()
        Me.termGPA.Show()
        Me.LinkLabel6.Show()
        Me.LinkLabel7.Show()
        Me.LinkLabel8.Show()
    End Sub

    Private Sub LinkLabel9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        Dim home As New HomeForm()
        Me.Hide()
        home.Show()
    End Sub

    Private Sub viewSpecificCourse_Click(sender As Object, e As EventArgs) Handles viewSpecificCourse.Click
        RichTextBox2.Clear()
        If termButton1.Checked = True Then
            RichTextBox2.Text = "Grade: C+"
        ElseIf termButton2.Checked = True Then
            RichTextBox2.Text = "Grade: B+"
        ElseIf termButton3.Checked = True Then
            RichTextBox2.Text = "Grade: C"
        ElseIf termButton4.Checked = True Then
            RichTextBox2.Text = "Grade: B"
        End If

    End Sub

End Class