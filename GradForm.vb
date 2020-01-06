Public Class GradForm
    Private requirementsMet As Boolean = False
    Private gradForm As GraduationRequirementsForm
    Private studentName As String
    Private studentID As String
    Private homeForm As HomeForm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Sub New(sName As String, sID As String, hForm As HomeForm)

        ' This call is required by the designer.
        InitializeComponent()
        studentName = sName
        studentID = sID
        homeForm = hForm
        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Private Sub checkGradStatusButton_Click(sender As Object, e As EventArgs) Handles checkGradStatusButton.Click
        'on click check if all graduation requirements are met if all classes
        If requirementsMet Then
            gradCheckBox.Checked = True
            gradCheckBox.Text = "Eligible For Graduation"
            ApplyButton.Enabled = True
        Else
            gradCheckBox.Checked = False
            gradCheckBox.Text = "Requirements Not Met"
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        homeForm.Show()
        Close()
    End Sub

    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click
    End Sub

    Private Sub ViewReqButton_Click(sender As Object, e As EventArgs) Handles ViewReqButton.Click
        'put student name here 
        gradForm = New GraduationRequirementsForm(studentName, Me)
        Hide()
        gradForm.Show()
    End Sub

End Class
