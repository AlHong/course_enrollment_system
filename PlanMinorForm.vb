Public Class PlanMinorForm
    Private Sub HomeButton_Click(sender As Object, e As EventArgs)
        Dim homePage As New HomeForm
        homePage.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Dim loginPage As New LoginForm
        LoginForm.loggedInName = ""
        loginPage.Show()
        Me.Hide()
    End Sub

    Private Sub CoursesDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub PlanMinorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MinorLabel.Text = ViewMajorForm.minor

        CoursesLabel1.Visible = False
        CoursesLabel2.Visible = False
        CoursesLabel3.Visible = False

        MinorCourses1.Visible = False
        MinorCourses2.Visible = False
        MinorCourses3.Visible = False

        MinorCourses1.DataGridView1.Rows.Add(New String() {"MTH110", "Discrete Math I", "required & not taken", "1", "0", "Yes"})
        MinorCourses1.DataGridView1.Rows.Add(New String() {"MTH314", "Discrete Math for Engineers", "not taken", "1", "0", "No"})

        MinorCourses2.DataGridView1.Rows.Add(New String() {"MTH312", "Diff Equations and Vector Calc", "not taken", "1", "0", "No"})
        MinorCourses2.DataGridView1.Rows.Add(New String() {"MTH330", "Calculus and Geometry", "not taken", "1", "0", "No"})
        MinorCourses2.DataGridView1.Rows.Add(New String() {"MTH425", "Diff Equations and Vector Calc", "not taken", "1", "0", "No"})

        MinorCourses3.DataGridView1.Rows.Add(New String() {"MTH210", "Discrete Math II", "not taken", "1", "0", "No"})
        MinorCourses3.DataGridView1.Rows.Add(New String() {"MTH404", "Probability and Statistics II", "not taken", "1", "0", "No"})
        MinorCourses3.DataGridView1.Rows.Add(New String() {"MTH410", "Statistics", "not taken", "1", "0", "No"})
        MinorCourses3.DataGridView1.Rows.Add(New String() {"MTH480", "Probability and Statistics II", "not taken", "1", "0", "No"})
        MinorCourses3.DataGridView1.Rows.Add(New String() {"MTH500", "Introduction to Stochastic Processes", "not taken", "1", "0", "No"})
        MinorCourses3.DataGridView1.Rows.Add(New String() {"MTH501", "Numerical Analysis I", "not taken", "1", "0", "No"})
        MinorCourses3.DataGridView1.Rows.Add(New String() {"MTH430", "Dynamic Systems Differential Equations", "not taken", "1", "0", "No"})
        MinorCourses3.DataGridView1.Rows.Add(New String() {"MTH540", "Geometry", "not taken", "1", "0", "No"})
    End Sub

    Private Sub ViewMinorButton_Click(sender As Object, e As EventArgs) Handles ViewMinorButton.Click
        'if user views math: make data labels and grids visible
        If MinorComboBox.Text = "Mathematics" Then
            CoursesLabel1.Visible = True
            CoursesLabel2.Visible = True
            CoursesLabel3.Visible = True

            MinorCourses1.Visible = True
            MinorCourses2.Visible = True
            MinorCourses3.Visible = True
        End If
    End Sub

    Private Sub ChooseMinorButton_Click(sender As Object, e As EventArgs) Handles ChooseMinorButton.Click
        ViewMajorForm.minor = MinorComboBox.Text
        Me.MinorLabel.Text = ViewMajorForm.minor

        If (Chooseterm.fys) Then
            classoffered.fminor = True
        ElseIf (Chooseterm.sys) Then
            classoffered.sminor = True
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim home As New HomeForm()
        Me.Hide()
        home.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim homeForm As New HomeForm()
        Me.Hide()
        homeForm.Show()
    End Sub
End Class