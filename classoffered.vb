Public Class classoffered

    Public Shared co As Boolean
    Public Shared fminor As Boolean = False
    Public Shared sminor As Boolean = False

    Private Sub classoffered_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        co = False
        Label3.Hide()
        ComboBox2.Hide()

        'math minor 
        Label4.Hide()
        ComboBox3.Hide()

        ' Lower level liberal
        Label6.Hide()
        ComboBox4.Hide()


        If (HomeForm.addcheck And HomeForm.swapcheck) Then

            Label5.Text = "Choose the course you would like (" + choosesearch.swapcourse + ") to be swapped with."

        ElseIf (HomeForm.addcheck And Not HomeForm.swapcheck) Then
            Label5.Text = "Choose the course you would like to enroll in."
        End If

        '  minor = True
        If (fminor And Chooseterm.fys) Then

            Label4.Show()
            ComboBox3.Show()
            Label4.Text = "Math Minor Requirements (need to take six to achieve minor)"

            If (Chooseterm.term = "fall") Then
                ComboBox3.Items.Add("MTH430 - Dynamic Systems: Differential Equations")
            ElseIf (Chooseterm.term = "winter") Then
                ComboBox3.Items.Add("MTH430 - Dynamic Systems: Differential Equations")
                ComboBox3.Items.Add("MTH540 - Geometry")
            End If

        ElseIf (sminor And Chooseterm.sys) Then
            Label4.Show()
            ComboBox3.Show()
            Label4.Text = "Math Minor Requirements (need to take six to achieve minor)"

            If (Chooseterm.term = "fall") Then
                ComboBox3.Items.Add("MTH430 - Dynamic Systems: Differential Equations")
            ElseIf (Chooseterm.term = "winter") Then
                ComboBox3.Items.Add("MTH430 - Dynamic Systems: Differential Equations")
                ComboBox3.Items.Add("MTH540 - Geometry")
            End If

        End If

            If (Chooseterm.fys) Then

                Label3.Show()
                ComboBox2.Show()


                Label6.Show()
                ComboBox4.Show()

                '    Label4.Show()
                '   ComboBox3.Show()

                Label2.Text = "First Year Requirements "
                Label3.Text = "Science course (required to take one in your major) "
                Label6.Text = "Lower-Level Electives (required to take two in your major)"
                '  Label4.Text = "Lower-Level Elective Courses (Must take two in total.) "

                If (Chooseterm.term = "fall") Then
                    Label1.Text = "Courses Offered in Fall Semester:"
                    Label2.Text = Label2.Text
                    Label3.Text = Label3.Text

                    ComboBox1.Items.Add("CPS109 - Computer Science I")
                    ComboBox2.Items.Add("BLG143 - Biology I")

                    ComboBox4.Items.Add("RTA180 - Music and Film")
                    ComboBox4.Items.Add("SOC103 - How Society Works")

                    ' ComboBox3.Items.Add("MUS110 - Music and Film")

                ElseIf (Chooseterm.term = "winter") Then
                    Label1.Text = "Courses Offered in Winter Semester:"
                    Label2.Text = Label2.Text
                    Label3.Text = Label3.Text

                    ComboBox1.Items.Add("CPS209 - Computer Science II")

                    ComboBox2.Items.Add("PCS110 - Physics")
                    ComboBox2.Items.Add("CHY103 - General Chemistry I")

                    ComboBox4.Items.Add("RTA180 - Music and Film")
                    ComboBox4.Items.Add("SOC103 - How Society Works")

                    '  ComboBox3.Items.Add("CRM 100 - Crime in Canada")
                End If

            ElseIf (Chooseterm.sys) Then

                Label2.Text = "Second Year Requirements: "


            Label6.Show()
            ComboBox4.Show()



            Label6.Text = "Open Electives (required to take two in your major)"

                If (Chooseterm.term = "fall") Then

                    Label1.Text = "Courses Offered in Fall Semester:"
                    Label2.Text = Label2.Text
                    Label4.Text = Label4.Text

                    ComboBox1.Items.Add("CPS420 - Discrete Structures")

                ComboBox4.Items.Add("CRM200 - Criminal Law")
                ComboBox4.Items.Add("DST500 - A History of Madness")


                ElseIf (Chooseterm.term = "winter") Then
                    Label1.Text = "Courses Offered in Winter Semester:"
                    Label2.Text = Label2.Text

                    ComboBox1.Items.Add("CPS590 - Introduction to Operating Systems")

                ComboBox4.Items.Add("CRM200 - Criminal Law")
                ComboBox4.Items.Add("DST500 - A History of Madness")
                End If

            End If

    End Sub

    ' Continue
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        co = True
        '  MsgBox(ComboBox1.SelectedItem)

        If (Not ComboBox1.SelectedItem = Nothing And ComboBox2.SelectedItem = Nothing And ComboBox3.SelectedItem = Nothing And ComboBox4.SelectedItem = Nothing) Then
            Chooseterm.course = ComboBox1.SelectedItem

            Dim add As New add()
            Me.Hide()
            add.Show()

        ElseIf (Not ComboBox2.SelectedItem = Nothing And ComboBox1.SelectedItem = Nothing And ComboBox3.SelectedItem = Nothing And ComboBox4.SelectedItem = Nothing) Then
            Chooseterm.course = ComboBox2.SelectedItem

            Dim add As New add()
            Me.Hide()
            add.Show()

        ElseIf (ComboBox1.SelectedItem = Nothing And ComboBox2.SelectedItem = Nothing And Not ComboBox3.SelectedItem = Nothing And ComboBox4.SelectedItem = Nothing) Then
            Chooseterm.course = ComboBox3.SelectedItem

            Dim add As New add()
            Me.Hide()
            add.Show()

        ElseIf (ComboBox1.SelectedItem = Nothing And ComboBox2.SelectedItem = Nothing And ComboBox3.SelectedItem = Nothing And Not ComboBox4.SelectedItem = Nothing) Then
            Chooseterm.course = ComboBox4.SelectedItem

            Dim add As New add()
            Me.Hide()
            add.Show()

        Else
            MsgBox("Please choose only one course before continuing")

            ComboBox1.SelectedItem = Nothing

            ComboBox2.SelectedItem = Nothing
            ComboBox3.SelectedItem = Nothing
        End If

    End Sub

    ' Go back
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim choosesearch As New choosesearch()
        Me.Hide()
        choosesearch.Show()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim home As New HomeForm()
        Me.Hide()
        home.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim chooseterm As New Chooseterm()
        Me.Hide()
        chooseterm.Show()
    End Sub


End Class