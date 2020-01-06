Public Class schedule

    Public Shared array As ArrayList = New ArrayList
    Public Shared val As String


    Private Sub schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (Chooseterm.term = "fall") Then
            Label1.Text = "Viewing Fall 2017 Schedule"
        ElseIf (Chooseterm.term = "winter") Then
            Label1.Text = "Viewing Winter 2018 Schedule"
        End If

        '    DataGridView1.RowTemplate.Height = 1000
        schedule()
        val = ""
    End Sub

    Private Sub schedule()

        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders

        Me.DataGridView1.Font = New Font("Arial", 6.5, FontStyle.Bold)

        DataGridView1.ReadOnly = True

        Dim row As ArrayList = New ArrayList
        row.Add("8:00am")

        DataGridView1.Rows.Add(row.ToArray)
        '    For i As Integer = 0 To Chooseterm.fysfc.Count - 1
        'val = Chooseterm.fysfc(i).ToString()
        '  Next

        '  MsgBox(val)

        For Each str As String In Chooseterm.fysfc

            array.Add(str)
        Next

        row = New ArrayList
        row.Add("9:00am")

        DataGridView1.Rows.Add(row.ToArray)

        '     If (array.Contains("CPS109 - Computer Science I")) Then

        'For Each str As String In Chooseterm.fysfc
        'val = val + vbCrLf + Str() + vbCrLf
        '  Next
        '  MsgBox(val)
        ' row.Add(val)

        '      End If
        '   DataGridView1.Rows.Add(row.ToArray)

        row = New ArrayList
        row.Add("10:00am")

        DataGridView1.Rows.Add(row.ToArray)


        row = New ArrayList
        row.Add("11:00am")

        DataGridView1.Rows.Add(row.ToArray)


        row = New ArrayList
        row.Add("12:00pm")

        DataGridView1.Rows.Add(row.ToArray)

        row = New ArrayList
        row.Add("1:00pm")

        DataGridView1.Rows.Add(row.ToArray)

        row = New ArrayList
        row.Add("2:00pm")

        DataGridView1.Rows.Add(row.ToArray)

        row = New ArrayList
        row.Add("3:00pm")

        DataGridView1.Rows.Add(row.ToArray)

        row = New ArrayList
        row.Add("4:00pm")

        DataGridView1.Rows.Add(row.ToArray)

        row = New ArrayList
        row.Add("5:00pm")

        DataGridView1.Rows.Add(row.ToArray)

        row = New ArrayList
        row.Add("6:00pm")

        DataGridView1.Rows.Add(row.ToArray)

        row = New ArrayList
        row.Add("7:00pm")

        DataGridView1.Rows.Add(row.ToArray)

        row = New ArrayList
        row.Add("8:00pm")

        DataGridView1.Rows.Add(row.ToArray)

        If (Chooseterm.term = "fall" And Chooseterm.fys) Then
            For r As Integer = 0 To DataGridView1.RowCount - 1 Step 1
                For cl As Integer = 1 To DataGridView1.ColumnCount - 1 Step 1
                    For Each c As DataGridViewColumn In DataGridView1.Columns
                        For i As Integer = 0 To add.flecdate.ToArray.Length - 1 Step 1
                            If ((add.flecdate.ToArray.ElementAt(i) = c.HeaderCell.Value) And (add.fstartlectime.ToArray.ElementAt(i) = DataGridView1(0, r).Value)) Then
                                DataGridView1(c.HeaderCell.ColumnIndex, r).Value = add.flecname.ToArray.ElementAt(i).ToString
                                DataGridView1(c.HeaderCell.ColumnIndex, r + 1).Value = add.fstartlectime.ToArray.ElementAt(i).ToString + " - " + add.fendlectime.ToArray.ElementAt(i).ToString
                                DataGridView1(c.HeaderCell.ColumnIndex, r + 2).Value = add.flecroom.ToArray.ElementAt(i).ToString

                                DataGridView1.Rows(r).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.AliceBlue
                                DataGridView1.Rows(r + 1).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.AliceBlue
                                DataGridView1.Rows(r + 2).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.AliceBlue
                            End If

                            If ((add.flabdate.ToArray.ElementAt(i) = c.HeaderCell.Value) And (add.fstartlabtime.ToArray.ElementAt(i) = DataGridView1(0, r).Value)) Then
                                DataGridView1(c.HeaderCell.ColumnIndex, r).Value = add.flabname.ToArray.ElementAt(i).ToString
                                DataGridView1(c.HeaderCell.ColumnIndex, r + 1).Value = add.fstartlabtime.ToArray.ElementAt(i).ToString + " - " + add.fendlabtime.ToArray.ElementAt(i).ToString + " " + add.flabroom.ToArray.ElementAt(i).ToString()
                                DataGridView1.Rows(r).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.Bisque
                                DataGridView1.Rows(r + 1).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.Bisque
                            End If
                            '  c.HeaderCell.Value = "Row " & rowNumber
                            ' c = rowNumber + 1
                        Next
                    Next
                Next
            Next

        ElseIf (Chooseterm.term = "fall" And Chooseterm.sys) Then
            For r As Integer = 0 To DataGridView1.RowCount - 1 Step 1
                For cl As Integer = 1 To DataGridView1.ColumnCount - 1 Step 1
                    For Each c As DataGridViewColumn In DataGridView1.Columns
                        For i As Integer = 0 To add.sflecdate.ToArray.Length - 1 Step 1
                            If ((add.sflecdate.ToArray.ElementAt(i) = c.HeaderCell.Value) And (add.sfstartlectime.ToArray.ElementAt(i) = DataGridView1(0, r).Value)) Then
                                DataGridView1(c.HeaderCell.ColumnIndex, r).Value = add.sflecname.ToArray.ElementAt(i).ToString
                                DataGridView1(c.HeaderCell.ColumnIndex, r + 1).Value = add.sfstartlectime.ToArray.ElementAt(i).ToString + " - " + add.sfendlectime.ToArray.ElementAt(i).ToString
                                DataGridView1(c.HeaderCell.ColumnIndex, r + 2).Value = add.sflecroom.ToArray.ElementAt(i).ToString

                                DataGridView1.Rows(r).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.AliceBlue
                                DataGridView1.Rows(r + 1).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.AliceBlue
                                DataGridView1.Rows(r + 2).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.AliceBlue
                            End If

                            If ((add.sflabdate.ToArray.ElementAt(i) = c.HeaderCell.Value) And (add.sfstartlabtime.ToArray.ElementAt(i) = DataGridView1(0, r).Value)) Then
                                DataGridView1(c.HeaderCell.ColumnIndex, r).Value = add.sflabname.ToArray.ElementAt(i).ToString
                                DataGridView1(c.HeaderCell.ColumnIndex, r + 1).Value = add.sfstartlabtime.ToArray.ElementAt(i).ToString + " - " + add.sfendlabtime.ToArray.ElementAt(i).ToString + " " + add.sflabroom.ToArray.ElementAt(i).ToString()

                                DataGridView1.Rows(r).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.Bisque
                                DataGridView1.Rows(r + 1).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.Bisque
                            End If
                            '  c.HeaderCell.Value = "Row " & rowNumber
                            ' c = rowNumber + 1
                        Next
                    Next
                Next
            Next

        ElseIf (Chooseterm.term = "winter" And Chooseterm.fys) Then
            For r As Integer = 0 To DataGridView1.RowCount - 1 Step 1
                For cl As Integer = 1 To DataGridView1.ColumnCount - 1 Step 1
                    For Each c As DataGridViewColumn In DataGridView1.Columns
                        For i As Integer = 0 To add.wlecdate.ToArray.Length - 1 Step 1
                            If ((add.wlecdate.ToArray.ElementAt(i) = c.HeaderCell.Value) And (add.wstartlectime.ToArray.ElementAt(i) = DataGridView1(0, r).Value)) Then
                                DataGridView1(c.HeaderCell.ColumnIndex, r).Value = add.wlecname.ToArray.ElementAt(i).ToString
                                DataGridView1(c.HeaderCell.ColumnIndex, r + 1).Value = add.wstartlectime.ToArray.ElementAt(i).ToString + " - " + add.wendlectime.ToArray.ElementAt(i).ToString
                                DataGridView1(c.HeaderCell.ColumnIndex, r + 2).Value = add.wlecroom.ToArray.ElementAt(i).ToString

                                DataGridView1.Rows(r).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.AliceBlue
                                DataGridView1.Rows(r + 1).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.AliceBlue
                                DataGridView1.Rows(r + 2).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.AliceBlue
                            End If

                            If ((add.wlabdate.ToArray.ElementAt(i) = c.HeaderCell.Value) And (add.wstartlabtime.ToArray.ElementAt(i) = DataGridView1(0, r).Value)) Then
                                DataGridView1(c.HeaderCell.ColumnIndex, r).Value = add.wlabname.ToArray.ElementAt(i).ToString
                                DataGridView1(c.HeaderCell.ColumnIndex, r + 1).Value = add.wstartlabtime.ToArray.ElementAt(i).ToString + " - " + add.wendlabtime.ToArray.ElementAt(i).ToString + " " + add.wlabroom.ToArray.ElementAt(i).ToString()
                                DataGridView1.Rows(r).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.Bisque
                                DataGridView1.Rows(r + 1).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.Bisque

                            End If
                            '  c.HeaderCell.Value = "Row " & rowNumber
                            ' c = rowNumber + 1
                        Next
                    Next
                Next
            Next

        ElseIf (Chooseterm.term = "winter" And Chooseterm.sys) Then
            For r As Integer = 0 To DataGridView1.RowCount - 1 Step 1
                For cl As Integer = 1 To DataGridView1.ColumnCount - 1 Step 1
                    For Each c As DataGridViewColumn In DataGridView1.Columns
                        For i As Integer = 0 To add.swlecdate.ToArray.Length - 1 Step 1
                            If ((add.swlecdate.ToArray.ElementAt(i) = c.HeaderCell.Value) And (add.swstartlectime.ToArray.ElementAt(i) = DataGridView1(0, r).Value)) Then
                                DataGridView1(c.HeaderCell.ColumnIndex, r).Value = add.swlecname.ToArray.ElementAt(i).ToString
                                DataGridView1(c.HeaderCell.ColumnIndex, r + 1).Value = add.swstartlectime.ToArray.ElementAt(i).ToString + " - " + add.swendlectime.ToArray.ElementAt(i).ToString
                                DataGridView1(c.HeaderCell.ColumnIndex, r + 2).Value = add.swlecroom.ToArray.ElementAt(i).ToString

                                DataGridView1.Rows(r).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.AliceBlue
                                DataGridView1.Rows(r + 1).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.AliceBlue
                                DataGridView1.Rows(r + 2).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.AliceBlue
                            End If

                            If ((add.swlabdate.ToArray.ElementAt(i) = c.HeaderCell.Value) And (add.swstartlabtime.ToArray.ElementAt(i) = DataGridView1(0, r).Value)) Then
                                DataGridView1(c.HeaderCell.ColumnIndex, r).Value = add.swlabname.ToArray.ElementAt(i).ToString
                                DataGridView1(c.HeaderCell.ColumnIndex, r + 1).Value = add.swstartlabtime.ToArray.ElementAt(i).ToString + " - " + add.swendlabtime.ToArray.ElementAt(i).ToString + " " + add.swlabroom.ToArray.ElementAt(i).ToString()

                                DataGridView1.Rows(r).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.Bisque
                                DataGridView1.Rows(r + 1).Cells(c.HeaderCell.ColumnIndex).Style.BackColor = Color.Bisque

                            End If
                            '  c.HeaderCell.Value = "Row " & rowNumber
                            ' c = rowNumber + 1
                        Next
                    Next
                Next
            Next

        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim home As New HomeForm()
        Me.Hide()
        home.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim chooseterm As New Chooseterm()
        Me.Hide()
        chooseterm.Show()
    End Sub

End Class