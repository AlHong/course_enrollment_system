Public Class contactinfo



    Private Sub contactinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Chooseterm.fys Then
            Label5.Text = "123 FYS Crescent. Toronto ON, L1S 1S1"
            Label6.Text = "123 FYS Crescent. Toronto ON, L1S 1S1"
            Label7.Text = "416-111-1111"
            Label8.Text = "bob.jones@ryerson.ca"
        ElseIf Chooseterm.sys Then
            Label5.Text = "123 SYS St. Toronto ON, L2S 2S2"
            Label6.Text = "123 SYS St. Toronto ON, L2S 2S2"
            Label7.Text = "416-222-2222"
            Label8.Text = "alex.green@ryerson.ca"
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim home As New HomeForm()
        Me.Hide()
        home.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim home As New HomeForm()
        Me.Hide()
        home.Show()
    End Sub
End Class