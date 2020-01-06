Public Class CourseGradesForm


    Private Sub CourseGradesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'only shows for Alex Green since he's in 2nd year
        If GradesForm.winterGrades = True Then
            Me.Label1.Text = "Winter 2017 - Alex Green"
            GradesForm.winterGrades = False
            CourseGrades1.DataGridView1.Rows.Add(New String() {"MTH207", "Calculus and Comp. Methods I", "compulsory", "required & taken", "1", "1"})
            CourseGrades1.DataGridView1.Rows.Add(New String() {"CPS412", "Social Issues, Ethics, and Professionalism", "compulsory", "required & taken", "1", "1"})
            CourseGrades1.DataGridView1.Rows.Add(New String() {"CPS209", "Computer Science II", "compulsory", "required & taken", "1", "1"})
            CourseGrades1.DataGridView1.Rows.Add(New String() {"CPS310", "Computer Org II", "compulsory", "required & taken", "1", "0"})
            CourseGrades1.DataGridView1.Rows.Add(New String() {"SOC103", "How Society Works", "elective", "taken", "1", "1"})
        ElseIf GradesForm.fallGrades = True Then
            Me.Label1.Text = "Fall 2016 - Alex Green"
            GradesForm.fallGrades = False
            CourseGrades1.DataGridView1.Rows.Add(New String() {"MTH110", "Discrete Math I", "compulsory", "required & taken", "1", "1"})
            CourseGrades1.DataGridView1.Rows.Add(New String() {"CHY103", "Chemistry", "elective", "required & taken", "1", "1"})
            CourseGrades1.DataGridView1.Rows.Add(New String() {"CPS109", "Computer Science I", "compulsory", "required & taken", "1", "1"})
            CourseGrades1.DataGridView1.Rows.Add(New String() {"CPS213", "Computer Org I", "compulsory", "required & taken", "1", "0"})
            CourseGrades1.DataGridView1.Rows.Add(New String() {"RTA180", "Music and Film", "elective", "taken", "1", "1"})
        End If
    End Sub


    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click

        CourseGrades1.DataGridView1.Rows.Clear()
        Dim gradesForm As New GradesForm
        gradesForm.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim home As New HomeForm()
        Me.Hide()
        home.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CourseGrades1_Load(sender As Object, e As EventArgs) Handles CourseGrades1.Load

    End Sub
End Class