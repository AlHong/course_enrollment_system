Public Class GraduationRequirementsForm

    Private checkBoxArray As ArrayList
    Private gradForm As GradForm
    Public Sub New(studentName As String, gForm As GradForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If studentName = "Bob Jones" Then
            EmptyColumns(Table12)
            EmptyColumns(Table34)
            EmptyColumns(Table56)
            EmptyColumns(Table78)
        ElseIf studentName = "Alex Green" Then
            CheckBox12.Checked = True
            CheckBox12.Text = "Satisfied"
            FillColumn(1, "Passed", Table12)
            EmptyColumns(Table34)
            EmptyColumns(Table56)
            EmptyColumns(Table78)
        Else
            'clear all pass,fail,in progress
            EmptyColumns(Table12)
            EmptyColumns(Table34)
            EmptyColumns(Table56)
            EmptyColumns(Table78)
        End If
        gradForm = gForm
    End Sub

    Public Sub FillColumn(columnNum As Integer, status As String, table As TableLayoutPanel)
        For i As Integer = 0 To 9 Step 1
            Dim c As Control = table.GetControlFromPosition(1, i)
            c.Text = status
        Next
    End Sub

    Public Sub EmptyColumns(table As TableLayoutPanel)
        For Each c As Control In table.Controls
            Dim pos As TableLayoutPanelCellPosition = table.GetCellPosition(c)
            If pos.Column = 1 Then
                c.Text = ""
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gradForm.Show()
        Close()
    End Sub
End Class