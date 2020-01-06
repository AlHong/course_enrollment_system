Public Class FinancialForm
    Private studentName As String
    Private homeForm As HomeForm
    Private term As String = ""
    Private year As String = ""
    Private update As Boolean = False
    Public Sub New(sName As String, hform As HomeForm)
        ' This call is required by the designer.
        InitializeComponent()
        studentName = sName
        homeForm = hform
        If studentName Is "Bob Jones" Then
            'fill table with fees for bob
        ElseIf studentName Is "Alex Green" Then
            'fill table with fees for alex
        Else
            'fill table with no fees for anything
        End If
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        homeForm.Show()
        Close()
    End Sub

    Private Sub ComboBoxes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged, ComboBox2.SelectedIndexChanged
        'if both c1 and c2 are valid selections load fee data
        UpdateTermAndYear()
        If update Then
            EmptyColumns(1, FeeTable)
            paymentDateLabel.Text = ""
            owedDateLabel.Text = ""
            If studentName Is "Bob Jones" Then
                Select Case term
                    Case "Fall"
                        If year Is "2017" Then
                            'load
                            LoadFees(add.flecname, "Fall", "2017")
                        End If

                    Case "Winter"
                        If year Is "2018" Then
                            'load
                            LoadFees(add.wlecname, "Winter", "2018")

                        End If
                End Select
            ElseIf studentName Is "Alex Green" Then
                Select Case term
                    Case "Fall"
                        If year Is "2016" Then
                            'static
                            owedDateLabel.Text = "09/09/2016"
                            paymentDateLabel.Text = "09/07/2016"
                            totalTuitionFeesPaidLabel.Text = "$4000.00"
                            totalTuitionFeesOwedLabel.Text = "$0"
                        ElseIf year Is "2017" Then
                            'load
                            LoadFees(add.sflecname, "Fall", "2017")
                        End If
                    Case "Winter"
                        If year Is "2017" Then
                            'static
                            owedDateLabel.Text = "01/13/2017"
                            paymentDateLabel.Text = "01/09/2017"
                            totalTuitionFeesPaidLabel.Text = "$4000.00"
                            totalTuitionFeesOwedLabel.Text = "$0"
                        ElseIf year Is "2018" Then
                            'load
                            LoadFees(add.swlecname, "Winter", "2018")
                        End If
                End Select
            End If
            update = False
        End If
    End Sub

    Private Sub LoadFees(courses As ArrayList, term As String, year As String)
        'load
        Dim owed As Label = FeeTable.GetControlFromPosition(1, 1)
        Dim fee As Double = 0
        For Each s As String In courses
            fee += 800
        Next
        owed.Text = "$" + Convert.ToString(fee) + ".00"
        Console.WriteLine(owed.Text)
        If fee = 0 Then
            owedDateLabel.Text = ""
        Else
            If term Is "Winter" Then
                owedDateLabel.Text = "01/13/" + year
            ElseIf term Is "Fall" Then
                owedDateLabel.Text = "09/09/" + year
            End If
        End If
    End Sub

    Private Sub UpdateTermAndYear()
        Dim selection1 As String = ComboBox1.SelectedItem
        Dim selection2 As String = ComboBox2.SelectedItem
        Select Case selection1
            Case "Winter"
                term = "Winter"
            Case "Fall"
                term = "Fall"
        End Select
        Select Case selection2
            Case "2016"
                year = "2016"
            Case "2017"
                year = "2017"
            Case "2018"
                year = "2018"
        End Select
        If Not term Is "" And Not year Is "" Then
            update = True
            Console.WriteLine("update table")
        End If
    End Sub

    Public Sub EmptyColumns(columnNum As Integer, table As TableLayoutPanel)
        For Each c As Control In table.Controls
            Dim pos As TableLayoutPanelCellPosition = table.GetCellPosition(c)
            If pos.Column = columnNum And Not pos.Row = 0 Then
                c.Text = "$0.00"
            End If
        Next
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim home As New HomeForm()
        Me.Hide()
        home.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim home As New HomeForm()
        Me.Hide()
        home.Show()
    End Sub
End Class