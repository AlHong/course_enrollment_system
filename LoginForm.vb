Public Class LoginForm
    'user for scenario 1
    Dim userName1 As String = "bob.jones"
    Dim password1 As String = "bobjones"

    'user for scenario 2
    Dim userName2 As String = "alex.green"
    Dim password2 As String = "alexgreen"

    Public Shared loggedInName As String

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If userName1 = NameTextBox.Text And password1 = PasswordTextBox.Text Then
            loggedInName = userName1
           showHomePage() 

        ElseIf userName2 = NameTextBox.Text And password2 = PasswordTextBox.Text Then
            loggedInName = userName2
            Dim homePage As New HomeForm
             showHomePage() 
        Else
            showHomePage()
        End If
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


    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NameLabel.Hide()
        LoginButton.Hide()
        NameTextBox.Hide()
        PasswordLabel.Hide()
        PasswordTextBox.Hide()

        Button1.Text = "Log in as first year student Bob Jones"
        Button2.Text = "Log in as second year student Alex Green"
    End Sub

    ' Log in as Bob Jones
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loggedInName = "bob.jones"
        showHomePage()
        Chooseterm.fys = True
        Chooseterm.sys = False
    End Sub

    ' Log in as Alex Green
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        loggedInName = "alex.green"
        showHomePage()
        Chooseterm.fys = False
        Chooseterm.sys = True
    End Sub

    Sub showHomePage()
        Dim homePage As New HomeForm
        homePage.Show()
        Me.Hide()
    End Sub


End Class
