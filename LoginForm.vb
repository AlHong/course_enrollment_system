Public Class LoginForm
    'user for scenario 1
    Dim userName1 As String = "bob.jones"
    Dim password1 As String = "bobjones"

    'user for scenario 2
    Dim userName2 As String = "alex.green"
    Dim password2 As String = "alexgreen"

    Public Shared loggedInName As String

    Private Sub NameLabel_Click(sender As Object, e As EventArgs) Handles NameLabel.Click

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If userName1 = NameTextBox.Text And password1 = PasswordTextBox.Text Then
            loggedInName = userName1
            showHomePage()

        ElseIf userName2 = NameTextBox.Text And password2 = PasswordTextBox.Text Then
            loggedInName = userName2
            showHomePage()
        Else
            showHomePage()
        End If
    End Sub

    Sub showHomePage()
        Dim homePage As New HomeForm
        homePage.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs) Handles PasswordLabel.Click

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub


End Class
