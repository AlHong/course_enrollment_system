Public Class HomeForm
    Public Shared studentName As String
    Public Shared studentNumber As String

    Public Shared addcheck As Boolean
    Public Shared dropcheck As Boolean
    Public Shared swapcheck As Boolean
    Public Shared schedulecheck As Boolean

    Public Shared fcourse As ArrayList = New ArrayList()
    Public Shared wcourse As ArrayList = New ArrayList()


    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        addcheck = False
        dropcheck = False
        swapcheck = False
        schedulecheck = False

        ComboBox1.Items.Add("View Schedule")
        ComboBox1.Items.Add("Add Course")
        ComboBox1.Items.Add("Swap Course")
        ComboBox1.Items.Add("Drop Course")
        ComboBox1.Items.Add("Manage Personal Information")
        ComboBox1.Items.Add("View Grades, GPA, and Status")
        ComboBox1.Items.Add("View Major")
        ComboBox1.Items.Add("Plan Minor")
        ComboBox1.Items.Add("Graduation Status")
        ComboBox1.Items.Add("Financial Status")


        studentName = LoginForm.loggedInName

        If studentName = "bob.jones" Then
            studentName = "Bob Jones"
            studentNumber = "111222333"
            Chooseterm.fys = True
            Chooseterm.sys = False
        ElseIf studentName = "alex.green" Then
            studentName = "Alex Green"
            studentNumber = "444555666"
            Chooseterm.sys = True
            Chooseterm.fys = False
        Else
            studentName = "N/A"
            studentNumber = "N/A"
        End If

        StudentNameLabel.Text = studentName
        StudentNumberLabel.Text = studentNumber

        If (Chooseterm.fys) Then
            If (Chooseterm.fysfc.Count = 0) Then
                Label7.Show()
                Label7.Text = "There are currently no courses in your fall 2017 semester"
            Else
                Label7.Hide()
            End If

            If (Chooseterm.fyswc.Count = 0) Then
                Label8.Show()
                Label8.Text = "There are currently no courses in your winter 2018 semester"
            Else
                Label8.Hide()
            End If

            For Each obj As Object In Chooseterm.fysfc

                FallListBox.Items.Add(obj)

            Next

            For Each obj As Object In Chooseterm.fyswc

                WinterListBox.Items.Add(obj)

            Next

        ElseIf (Chooseterm.sys) Then

            If (Chooseterm.sysfc.Count = 0) Then
                Label7.Show()
                Label7.Text = "There are currently no courses in your fall 2017 semester"
            Else
                Label7.Hide()
            End If

            If (Chooseterm.syswc.Count = 0) Then
                Label8.Show()
                Label8.Text = "There are currently no courses in your winter 2018 semester"
            Else
                Label8.Hide()
            End If

            For Each obj As Object In Chooseterm.sysfc

                FallListBox.Items.Add(obj)

            Next

            For Each obj As Object In Chooseterm.syswc

                WinterListBox.Items.Add(obj)

            Next

        End If


    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click

        Chooseterm.fys = False
        Chooseterm.sys = False

        Dim loginPage As New LoginForm
        LoginForm.loggedInName = ""
        loginPage.Show()
        Me.Hide()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.SelectedItem = "View Schedule" Then

            schedulecheck = True
            Dim chooseterm As New Chooseterm()
            Me.Hide()
            chooseterm.Show()

        ElseIf ComboBox1.SelectedItem = "Add Course" Then

            addcheck = True
            dropcheck = False
            swapcheck = False

            Dim chooseterm As New Chooseterm()
            Me.Hide()
            chooseterm.Show()



        ElseIf ComboBox1.SelectedItem = "Swap Course" Then
            addcheck = False
            dropcheck = False
            swapcheck = True

            Dim chooseterm As New Chooseterm()
            Me.Hide()
            chooseterm.Show()


        ElseIf ComboBox1.SelectedItem = "Drop Course" Then
            addcheck = False
            dropcheck = True
            swapcheck = False

            Dim chooseterm As New Chooseterm()
            Me.Hide()
            chooseterm.Show()


        ElseIf ComboBox1.SelectedItem = "Manage Personal Information" Then

            addcheck = True
            dropcheck = False
            swapcheck = False

            Dim personal As New contactinfo()
            Me.Hide()
            personal.Show()

        ElseIf ComboBox1.SelectedItem = "View Major" Then
            Dim viewMajorPage As New ViewMajorForm
            viewMajorPage.Show()
            Me.Hide()

        ElseIf ComboBox1.SelectedItem = "Plan Minor" Then
            Dim planMinorPage As New PlanMinorForm
            planMinorPage.Show()
            Me.Hide()

        ElseIf ComboBox1.SelectedItem = "View Grades, GPA, and Status" Then
            addcheck = False
            dropcheck = True
            swapcheck = False

            Dim gradesForm As New GradesForm()
            Me.Hide()
            gradesForm.Show()

        ElseIf ComboBox1.SelectedItem = "Graduation Status" Then
            Hide()
            Dim gradForm As GradForm = New GradForm(studentName, studentNumber, Me)
            gradForm.Show()
        ElseIf ComboBox1.SelectedItem = "Financial Status" Then
            Hide()
            Dim financialForm As FinancialForm = New FinancialForm(studentName, Me)
            financialForm.Show()
        Else
            MsgBox("Please choose an option that is listed.")
            ComboBox1.SelectedItem = Nothing
            ComboBox1.Text = ""

        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim home As New HomeForm
        Me.Hide()
        home.Show()
    End Sub
End Class