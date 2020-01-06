Public Class ViewMajorForm
    Public Shared minor As String = "N/A"

    Private Sub ViewMajorForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MinorLabel.Text = minor

        'load first year courses
        'assumes that user is new first year comp sci student




        '****Check if alex the second year log ins*****
        If (Chooseterm.sys) Then
            'load year 1 fall courses
            Year1FallUserControl.DataGridView1.Rows.Add(New String() {"MTH110", "Discrete Math I", "compulsory", "required & not taken", "1", "1"})
            Year1FallUserControl.DataGridView1.Rows.Add(New String() {"PCS110", "Physics", "elective", "required & not taken", "1", "0"})
            Year1FallUserControl.DataGridView1.Rows.Add(New String() {"BLG143", "Biology", "elective", "required & not taken", "1", "0"})
            Year1FallUserControl.DataGridView1.Rows.Add(New String() {"CHY103", "Chemistry", "elective", "required & not taken", "1", "1"})
            Year1FallUserControl.DataGridView1.Rows.Add(New String() {"CPS109", "Computer Science I", "compulsory", "required & not taken", "1", "1"})
            Year1FallUserControl.DataGridView1.Rows.Add(New String() {"CPS213", "Computer Org I", "compulsory", "required & not taken", "1", "0"})
            Year1FallUserControl.DataGridView1.Rows.Add(New String() {"RTA180", "Music and Film", "elective", "not taken", "1", "1"})
            Year1FallUserControl.DataGridView1.Rows.Add(New String() {"SOC103", "How Society Works", "elective", "not taken", "1", "0"})

            'load year 1 winter courses
            Year1WinterUserControl.DataGridView1.Rows.Add(New String() {"MTH207", "Calculus and Comp. Methods I", "compulsory", "required & not taken", "1", "1"})
            Year1WinterUserControl.DataGridView1.Rows.Add(New String() {"CPS412", "Social Issues, Ethics, and Professionalism", "compulsory", "required & not taken", "1", "1"})
            Year1WinterUserControl.DataGridView1.Rows.Add(New String() {"CPS209", "Computer Science II", "compulsory", "required & not taken", "1", "1"})
            Year1WinterUserControl.DataGridView1.Rows.Add(New String() {"CPS310", "Computer Org II", "compulsory", "required & not taken", "1", "0"})
            Year1WinterUserControl.DataGridView1.Rows.Add(New String() {"RTA180", "Music and Film", "elective", "not taken", "1", "0"})
            Year1WinterUserControl.DataGridView1.Rows.Add(New String() {"SOC103", "How Society Works", "elective", "not taken", "1", "1"})
        Else
            'load year 1 fall courses
            Year1FallUserControl.DataGridView1.Rows.Add(New String() {"MTH110", "Discrete Math I", "compulsory", "required & not taken", "1", "0"})
            Year1FallUserControl.DataGridView1.Rows.Add(New String() {"PCS110", "Physics", "elective", "required & not taken", "1", "0"})
            Year1FallUserControl.DataGridView1.Rows.Add(New String() {"BLG143", "Biology", "elective", "required & not taken", "1", "0"})
            Year1FallUserControl.DataGridView1.Rows.Add(New String() {"CHY103", "Chemistry", "elective", "required & not taken", "1", "0"})
            Year1FallUserControl.DataGridView1.Rows.Add(New String() {"CPS109", "Computer Science I", "compulsory", "required & not taken", "1", "0"})
            Year1FallUserControl.DataGridView1.Rows.Add(New String() {"CPS213", "Computer Org I", "compulsory", "required & not taken", "1", "0"})
            Year1FallUserControl.DataGridView1.Rows.Add(New String() {"RTA180", "Music and Film", "elective", "not taken", "1", "0"})
            Year1FallUserControl.DataGridView1.Rows.Add(New String() {"SOC103", "How Society Works", "elective", "not taken", "1", "0"})

            'load year 1 winter courses
            Year1WinterUserControl.DataGridView1.Rows.Add(New String() {"MTH207", "Calculus and Comp. Methods I", "compulsory", "required & not taken", "1", "0"})
            Year1WinterUserControl.DataGridView1.Rows.Add(New String() {"CPS412", "Social Issues, Ethics, and Professionalism", "compulsory", "required & not taken", "1", "0"})
            Year1WinterUserControl.DataGridView1.Rows.Add(New String() {"CPS209", "Computer Science II", "compulsory", "required & not taken", "1", "0"})
            Year1WinterUserControl.DataGridView1.Rows.Add(New String() {"CPS310", "Computer Org II", "compulsory", "required & not taken", "1", "0"})
            Year1WinterUserControl.DataGridView1.Rows.Add(New String() {"RTA180", "Music and Film", "elective", "not taken", "1", "0"})
            Year1WinterUserControl.DataGridView1.Rows.Add(New String() {"SOC103", "How Society Works", "elective", "not taken", "1", "0"})
        End If

        'load year 2 fall courses
        Year2FallUserControl.DataGridView1.Rows.Add(New String() {"MTH108", "Linear Algebra", "compulsory", "required & not taken", "1", "0"})
        Year2FallUserControl.DataGridView1.Rows.Add(New String() {"CMN300", "Communications in the Comp. Industry", "compulsory", "required & not taken", "1", "0"})
        Year2FallUserControl.DataGridView1.Rows.Add(New String() {"CPS305", "Data Structures", "compulsory", "required & not taken", "1", "0"})
        Year2FallUserControl.DataGridView1.Rows.Add(New String() {"CPS393", "C and UNIX", "compulsory", "required & not taken", "1", "0"})
        Year2FallUserControl.DataGridView1.Rows.Add(New String() {"CRM200", "Criminal Law", "elective", "not taken", "1", "0"})
        Year2FallUserControl.DataGridView1.Rows.Add(New String() {"DST500", "A History of Madness", "elective", "not taken", "1", "0"})
        'load year 2 winter courses
        Year2WinterUserControl.DataGridView1.Rows.Add(New String() {"CPS420", "Discrete Structures", "compulsory", "required & not taken", "1", "0"})
        Year2WinterUserControl.DataGridView1.Rows.Add(New String() {"CPS406", "Software Engineering", "compulsory", "required & not taken", "1", "0"})
        Year2WinterUserControl.DataGridView1.Rows.Add(New String() {"CPS506", "Comparative Prog. Languages", "compulsory", "required & not taken", "1", "0"})
        Year2WinterUserControl.DataGridView1.Rows.Add(New String() {"CPS590", "Operating Systems I", "compulsory", "required & not taken", "1", "0"})
        Year2WinterUserControl.DataGridView1.Rows.Add(New String() {"CRM200", "Criminal Law", "elective", "not taken", "1", "0"})
        Year2WinterUserControl.DataGridView1.Rows.Add(New String() {"DST500", "A History of Madness", "elective", "not taken", "1", "0"})
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Dim loginPage As New LoginForm
        LoginForm.loggedInName = ""
        loginPage.Show()
        Me.Hide()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs)
        Dim homePage As New HomeForm
        homePage.Show()
        Me.Hide()
    End Sub

    Private Sub MinorLabel_Click(sender As Object, e As EventArgs) Handles MinorLabel.Click

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