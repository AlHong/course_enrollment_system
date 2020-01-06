Public Class search

    Public Shared s As Boolean

    Private Sub search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MsgBox(Chooseterm.term)
        s = False



        If (HomeForm.addcheck And HomeForm.swapcheck) Then

            Label3.Text = "Choose the course you would like (" + choosesearch.swapcourse + ") to be swapped with."

        ElseIf (HomeForm.addcheck And Not HomeForm.swapcheck) Then
            Label3.Text = "Choose the course you would like to enroll in."
        End If


    End Sub

    ' Search
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        s = True
        Chooseterm.course = TextBox1.Text

        If (TextBox1.Text = "") Then
            MsgBox("The search course text field seems to be empty. Please provide a course code before searching.")
        Else
            Dim add As New add()
            Me.Hide()

            add.Show()
        End If

    End Sub

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