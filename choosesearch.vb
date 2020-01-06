Public Class choosesearch

    Public sem As String
    Public Shared dropcourse As String
    Public Shared swapcourse As String

    Private Sub choosesearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MsgBox(Chooseterm.term)
        ListBox1.Items.Clear()

        Label2.Hide()

        RadioButton1.Hide()
        RadioButton2.Hide()
        ComboBox1.Hide()

        If (Chooseterm.term = "fall") Then
            sem = "in the fall semester."
        ElseIf (Chooseterm.term = "winter") Then
            sem = "in the winter semester."
        End If

        If (HomeForm.addcheck And Not HomeForm.swapcheck) Then

            RadioButton1.Show()
            RadioButton2.Show()
            Label4.Text = "Adding a course"
            Label1.Text = "Please choose one of the following options to choose course by then click Continue"

        ElseIf (HomeForm.swapcheck And Not HomeForm.addcheck) Then
            Label4.Text = "Swapping a course"
            Label1.Text = "Please choose the course you would like to swap " + sem
            ComboBox1.Show()


            If (Chooseterm.term = "fall" And Chooseterm.fys) Then
                For Each obj As Object In add.flecname
                    ComboBox1.Items.Add(obj)
                Next
            ElseIf (Chooseterm.term = "fall" And Chooseterm.sys) Then
                For Each obj As Object In add.sflecname
                    ComboBox1.Items.Add(obj)
                Next
            ElseIf (Chooseterm.term = "winter" And Chooseterm.fys) Then
                For Each obj As Object In add.wlecname
                    ComboBox1.Items.Add(obj)
                Next

            ElseIf (Chooseterm.term = "winter" And Chooseterm.sys) Then
                For Each obj As Object In add.swlecname
                    ComboBox1.Items.Add(obj)
                Next


            End If

        ElseIf (HomeForm.swapcheck And HomeForm.addcheck) Then
            RadioButton1.Show()
            RadioButton2.Show()
            Label4.Text = "Swapping a course with ( " + swapcourse + " )"
            Label1.Text = "Please choose one of the following options to choose course by then click Continue"

        ElseIf (HomeForm.dropcheck) Then
            Label4.Text = "Dropping a course"
            Label1.Text = "Please choose the course you would like to drop " + sem
            ComboBox1.Show()

            If (Chooseterm.term = "fall" And Chooseterm.fys) Then
                For Each obj As Object In add.flecname
                    ComboBox1.Items.Add(obj)
                Next
            ElseIf (Chooseterm.term = "fall" And Chooseterm.sys) Then
                For Each obj As Object In add.sflecname
                    ComboBox1.Items.Add(obj)
                Next
            ElseIf (Chooseterm.term = "winter" And Chooseterm.fys) Then
                For Each obj As Object In add.wlecname
                    ComboBox1.Items.Add(obj)
                Next
       
            ElseIf (Chooseterm.term = "winter" And Chooseterm.sys) Then
                For Each obj As Object In add.swlecname
                    ComboBox1.Items.Add(obj)
                Next


            End If


        End If


        ListBox1.SelectedItem = False
        If (Chooseterm.term = "fall" And Chooseterm.fys = True) Then

            Label3.Text = "Courses currently enrolled for fall 2017 semester: "
            'MsgBox("bob and fall")
            If (Chooseterm.fysfc.Count = 0) Then
                Label2.Show()
                Label2.Text = "There are currently no courses in your fall 2017 semester"
            ElseIf (Chooseterm.fysfc.Count > 0) Then
                Label2.Hide()

                For Each obj As Object In Chooseterm.fysfc

                    ListBox1.Items.Add(obj)

                Next
            End If

        End If

        If (Chooseterm.term = "winter" And Chooseterm.fys = True) Then
            ListBox1.Items.Clear()
            'MsgBox("Ben and winter")

            Label3.Text = "Courses currently enrolled for winter 2018 semester: "
            If (Chooseterm.fyswc.Count = 0) Then
                Label2.Show()
                Label2.Text = "There are currently no courses in your winter 2018 semester"
            ElseIf (Chooseterm.fyswc.Count > 0) Then
                Label2.Hide()

                For Each obj As Object In Chooseterm.fyswc

                    ListBox1.Items.Add(obj)
                Next
            End If

        End If

        If (Chooseterm.term = "fall" And Chooseterm.sys = True) Then

            Label3.Text = "Courses currently enrolled for fall 2017 semester: "

            If (Chooseterm.sysfc.Count = 0) Then
                Label2.Show()
                Label2.Text = "There are currently no courses in your fall 2017 semester"
            ElseIf (Chooseterm.sysfc.Count > 0) Then
                Label2.Hide()

                For Each obj As Object In Chooseterm.sysfc

                    ListBox1.Items.Add(obj)

                Next
            End If

        End If


        If (Chooseterm.term = "winter" And Chooseterm.sys = True) Then
            '  MsgBox("Jim and winter")

            Label3.Text = "Courses currently enrolled for winter 2018 semester: "

            If (Chooseterm.syswc.Count = 0) Then
                Label2.Show()
                Label2.Text = "There are currently no courses in your winter 2018 semester"
            ElseIf (Chooseterm.syswc.Count > 0) Then
                Label2.Hide()

                For Each obj As Object In Chooseterm.syswc

                    ListBox1.Items.Add(obj)

                Next
            End If

        End If

    End Sub

    ' Continue
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (HomeForm.addcheck And Not HomeForm.swapcheck) Then

            If (RadioButton1.Checked = True) Then
                Dim search As New search()
                Me.Hide()
                search.Show()


            ElseIf (RadioButton2.Checked = True) Then

                Dim co As New classoffered()
                Me.Hide()
                co.Show()

            End If

        ElseIf (HomeForm.swapcheck And Not HomeForm.addcheck) Then

            swapcourse = ComboBox1.SelectedItem

            HomeForm.addcheck = True
            HomeForm.swapcheck = True

            Dim swap As New choosesearch()
            Me.Hide()
            swap.Show()

        ElseIf (HomeForm.swapcheck And HomeForm.addcheck) Then

            HomeForm.addcheck = True
            HomeForm.swapcheck = True

            If (RadioButton1.Checked = True) Then
                Dim search As New search()
                Me.Hide()
                search.Show()


            ElseIf (RadioButton2.Checked = True) Then

                Dim co As New classoffered()
                Me.Hide()
                co.Show()

            End If

        ElseIf (HomeForm.dropcheck) Then

            dropcourse = ComboBox1.SelectedItem

            Dim drop As New drop()
            Me.Hide()
            drop.Show()

        End If


    End Sub

    ' Choose Select Course
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.Click
        RadioButton1.Checked = True
        RadioButton2.Checked = False
    End Sub

    ' Choose Class Offered
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = True
    End Sub


    ' GO BACk
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim chooseterm As New Chooseterm()
        Me.Hide()
        chooseterm.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim home As New HomeForm()
        Me.Hide()
        home.Show()

    End Sub
End Class
