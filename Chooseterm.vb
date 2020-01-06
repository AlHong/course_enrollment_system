Public Class Chooseterm

    Public Shared student As String
    Public Shared term As String
    ' First year student check
    Public Shared fys As Boolean
    Public Shared fysfc As ArrayList = New ArrayList()
    Public Shared fyswc As ArrayList = New ArrayList()
    ' Second year student check
    Public Shared sys As Boolean
    Public Shared sysfc As ArrayList = New ArrayList()
    Public Shared syswc As ArrayList = New ArrayList()

    Public Shared course As String


    Public Sub Chooseterm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (HomeForm.addcheck And Not HomeForm.swapcheck) Then
            Label2.Text = "Adding a Course"
        ElseIf ((HomeForm.swapcheck And HomeForm.addcheck) Or (HomeForm.swapcheck And Not HomeForm.addcheck)) Then
            Label2.Text = "Swapping a Course"
        ElseIf (HomeForm.dropcheck) Then
            Label2.Text = "Dropping a Course"
        ElseIf (HomeForm.schedulecheck) Then
            Label2.Text = "Viewing Schedule"
        End If

        student = HomeForm.studentName
        '    MsgBox(student)

        If (student = "Bob Jones") Then
            '     MsgBox("bob")
            fys = True
            sys = False
        End If

        If (student = "Alex Green") Then
            '  MsgBox("alex")
            fys = False
            sys = True
        End If

    End Sub

    ' If Continue clicked
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        ' Save fall option and continue
        If (RadioButton1.Checked = True) Then
            term = "fall"

            If (HomeForm.schedulecheck) Then
                Dim schedule As New schedule()
                Me.Hide()
                schedule.Show()
            Else
                ' MsgBox(term)
                Dim choosesearch As New choosesearch()
                Me.Hide()
                choosesearch.Show()
            End If

            ' Save winter option and continue 
        ElseIf (RadioButton2.Checked = True) Then
            term = "winter"
            If (HomeForm.schedulecheck) Then
                Dim schedule As New schedule()
                Me.Hide()
                schedule.Show()
            Else
                ' MsgBox(term)
                Dim choosesearch As New choosesearch()
                Me.Hide()
                choosesearch.Show()

            End If

        End If

    End Sub

    ' Choose Select Fall
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.Click
        RadioButton1.Checked = True
        RadioButton2.Checked = False
    End Sub

    ' Choose Select Winter
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = True
    End Sub

    ' Go back
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim home As New HomeForm()
        Me.Hide()
        home.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim home As New HomeForm()
        Me.Hide()
        home.Show()
    End Sub
End Class