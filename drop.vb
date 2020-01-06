Public Class drop

    Public Shared dropcoursedesc As String
    Public Shared dropcoursemd As String
    Public Shared dropcourseprof As String
    Public Shared dropcourseroom As String
    Public Shared dropcoursedate As String

    Public Shared droplecname As String
    Public Shared droplecdate As String
    Public Shared dropstartlectime As String
    Public Shared dropendlectime As String
    Public Shared droplecroom As String

    Public Shared droplabname As String
    Public Shared droplabdate As String
    Public Shared dropstartlabtime As String
    Public Shared dropendlabtime As String
    Public Shared droplabroom As String


    Private Sub drop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button3.Hide()


        ' MsgBox(choosesearch.dropcourse)

        Label2.Text = "Dropping a course in the " + Chooseterm.term + " semester."
        Label1.Text = "Are you sure you want to drop the course " + choosesearch.dropcourse
        Button1.Text = "Go Back"
        Button2.Text = "Drop Course"

        Button3.Text = "My Account"

        If (Chooseterm.fys And Chooseterm.term = "fall") Then
            If (choosesearch.dropcourse = "CPS109 - Computer Science I") Then


                dropcoursedesc = "An introductory programming course designed to introduce fundamental Computer Science concepts such as abstraction, modelling and algorithm design. Emphasis is placed on producing correct software. This course uses Java as its programming language." + vbNewLine + vbNewLine + "Lect: 3 hrs./Lab: 2 hrs." + vbNewLine
                dropcoursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine

                dropcourseprof = "Instructor: Tim McInnerny" + vbNewLine

                dropcoursedate = "Days & Times: Monday 9:00am-12:00pm (LEC)" + vbTab + "Wednesday 12:00pm-2:00pm (LAB)" + vbNewLine

                dropcourseroom = "Rooms: " + vbTab + vbTab + "TRS2139 (LEC)" + vbTab + vbTab + vbTab + "ENG202 (LAB)"

                droplecname = choosesearch.dropcourse
                droplecdate = "Monday"
                dropstartlectime = "9:00am"
                dropendlectime = "12:00pm"
                droplecroom = "TRS2139" + " (LEC)"

                droplabname = choosesearch.dropcourse
                droplabdate = "Wednesday"
                dropstartlabtime = "12:00pm"
                dropendlabtime = "2:00pm"
                droplabroom = "ENG202" + " (LAB)"

            ElseIf (choosesearch.dropcourse = "BLG143 - Biology I") Then

                dropcoursedesc = "This course is an introduction to the cellular and molecular mechanisms in the cell. Topics include macromolecule structure and function, enzymes, cell membrane structure and function, cell cycle control, cell division, metabolism, and photosynthesis. Also included is an introduction to genetics and patterns of inheritance, gene expression and developmental biology. Laboratory exercises complement lectures." + vbNewLine + vbNewLine + "Lect: 3 hrs./Lab: 2 hrs." + vbNewLine
                dropcoursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine
                dropcourseprof = "Instructor: John Smith" + vbNewLine
                dropcoursedate = "Days & Times: Thursday 6:00pm-9:00pm (LEC)" + vbTab + "Friday 9:00am-11:00am (LAB)" + vbNewLine
                dropcourseroom = "Rooms: " + vbTab + vbTab + vbTab + "RCC222 (LEC)" + vbTab + vbTab + "KHN203 (LAB)"

                droplecname = choosesearch.dropcourse
                droplecdate = "Thursday"
                dropstartlectime = "6:00pm"
                dropendlectime = "9:00pm"
                droplecroom = "RCC222" + " (LEC)"

                droplabname = choosesearch.dropcourse
                droplabdate = "Friday"
                dropstartlabtime = "9:00am"
                dropendlabtime = "11:00am"
                droplabroom = "KHN203" + " (LAB)"


            End If

        ElseIf (Chooseterm.fys And Chooseterm.term = "winter") Then

            If (choosesearch.dropcourse = "CPS209 - Computer Science II") Then
                dropcoursedesc = "A continuation of CPS 109. Emphasis is placed on code optimization, algorithm and program correctness. Fundamental Computer Science Algorithms will be introduced." + vbNewLine + vbNewLine + "Lect: 3 hrs./Lab: 1 hr." + vbNewLine
                dropcoursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine
                dropcourseprof = "Instructor: Eric Harley" + vbNewLine
                dropcoursedate = "Days & Times: Monday 12:00pm-3:00pm (LEC)" + vbTab + "Tuesday 2:00pm-4:00pm (LAB)" + vbNewLine
                dropcourseroom = "Rooms: " + vbTab + vbTab + vbTab + "KHW321 (LEC)" + vbTab + vbTab + "ENG205 (LAB)"

                droplecname = choosesearch.dropcourse
                droplecdate = "Monday"
                dropstartlectime = " 12:00pm"
                dropendlectime = "3:00pm"
                droplecroom = "KHW321" + " (LEC)"

                droplabname = choosesearch.dropcourse
                droplabdate = "Tuesday"
                dropstartlabtime = "2:00pm"
                dropendlabtime = "4:00pm"
                droplabroom = "ENG205" + " (LAB)"


            ElseIf (choosesearch.dropcourse = "CHY103 - General Chemistry I") Then
                dropcoursedesc = "This foundation course begins with an introduction to types of chemical compounds, chemical reactions and stoichiometry. Subsequent topics include the investigation of the states of matter (primarily liquids and gases), solutions and colligative properties, chemical equilibrium, acids and bases, and thermochemistry. This course acts as the first half of a full year general chemistry sequence and is a precursor to CHY 113 General Chemistry II." + vbNewLine + vbNewLine + "Lect: 3 hrs./Lab: 2 hrs." + vbNewLine
                dropcoursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine
                dropcourseprof = "Instructor: David Miller" + vbNewLine
                dropcoursedate = "Days & Times: Monday 12:00pm-3:00pm (LEC)" + vbTab + "Wednesday 3:00pm-5:00pm (LAB)" + vbNewLine
                dropcourseroom = "Rooms: " + vbTab + vbTab + vbTab + "KHW221 (LEC)" + vbTab + vbTab + "KHS311 (LAB)"

                droplecname = choosesearch.dropcourse
                droplecdate = "Monday"
                dropstartlectime = " 12:00pm"
                dropendlectime = "3:00pm"
                droplecroom = "KHW221" + " (LEC)"

                droplabname = choosesearch.dropcourse
                droplabdate = "Wednesday"
                dropstartlabtime = "3:00pm"
                dropendlabtime = "5:00pm"
                droplabroom = "KHS311" + " (LAB)"

            ElseIf (choosesearch.dropcourse = "PCS110 - Physics") Then
                dropcoursedesc = "Units and vectors. Motion: linear, projectile, circular and oscillatory motion. Newton's laws: Force, mass and acceleration; work, energy and power; linear and angular momentum. Electrostatics: Electric force and field; potential and potential energy; capacitance. Electric current and DC circuits. Magnetic field and force: magnetic force on currents and charges; Hall effect; torque on current loops; Waves: classification of waves; energy transfer; light and electromagnetic waves; diffraction and interference. MAPLE used for simulation/visualization of physical phenomena and problem solving." + vbNewLine + vbNewLine + "Lect: 3 hrs./Lab: 2 hrs." + vbNewLine
                dropcoursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine
                dropcourseprof = "Instructor: Carl Jackson" + vbNewLine
                dropcoursedate = "Days & Times: Thursday 11:00am-2:00pm (LEC)" + vbTab + "Friday 10:00am-12:00pm (LAB)" + vbNewLine
                dropcourseroom = "Rooms: " + vbTab + vbTab + vbTab + "KHE109 (LEC)" + vbTab + vbTab + "KHN206 (LAB)"


                droplecname = choosesearch.dropcourse
                droplecdate = "Thursday"
                dropstartlectime = " 11:00am"
                dropendlectime = "2:00pm"
                droplecroom = "KHE109" + " (LEC)"

                droplabname = choosesearch.dropcourse
                droplabdate = "Friday"
                dropstartlabtime = "10:00am"
                dropendlabtime = "12:00pm"
                droplabroom = "KHN206" + " (LAB)"
            End If


        ElseIf (Chooseterm.sys And Chooseterm.term = "fall") Then

            If (choosesearch.dropcourse = "CPS420 - Discrete Structures") Then
                dropcoursedesc = "Introduction to discrete structures and probability as they apply to design and analysis. Review of proof techniques: induction and recursion. Graphs and trees, and their applications in computing. Finite automata and computability. Counting: arithmetic and geometric progressions, permutations and combinations, modular arithmetic. Probability." + vbNewLine + vbNewLine + "Lect: 3 hrs." + vbNewLine
                dropcoursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine

                dropcourseprof = "Instructor: Denise Woit" + vbNewLine

                dropcoursedate = "Days & Times: Monday 9:00am-12:00pm (LEC)" + vbNewLine

                dropcourseroom = "Rooms: " + vbTab + vbTab + "TRS2100 (LEC)" + vbNewLine


                droplecname = choosesearch.dropcourse
                droplecdate = "Monday"
                dropstartlectime = " 9:00am"
                dropendlectime = "12:00pm"
                droplecroom = "TRS2100" + " (LEC)"

                droplabname = choosesearch.dropcourse
                droplabdate = "nolab"
                dropstartlabtime = "nolab"
                dropendlabtime = "nolab"
                droplabroom = "nolab" + " (LAB)"

            ElseIf (choosesearch.dropcourse = "MTH430 - Dynamic Systems: Differential Equations") Then
                dropcoursedesc = "First-order differential equations, first order systems, linear systems; numerical methods and applications. Non-linear systems, discrete dynamical systems. Linear Algebra; Eigenvalues and eigenvectors." + vbNewLine + vbNewLine + "Lect: 3 hrs." + vbNewLine
                dropcoursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine

                dropcourseprof = "Instructor: Masjed Alqasas" + vbNewLine

                dropcoursedate = "Days & Times: Monday 12:00pm-3:00pm (LEC)" + vbNewLine

                dropcourseroom = "Rooms: " + vbTab + vbTab + "TRS2110 (LEC)" + vbNewLine


                droplecname = choosesearch.dropcourse
                droplecdate = "Monday"
                dropstartlectime = "12:00pm"
                dropendlectime = "3:00pm"
                droplecroom = "TRS2110" + " (LEC)"

                droplabname = choosesearch.dropcourse
                droplabdate = "nolab"
                dropstartlabtime = "nolab"
                dropendlabtime = "nolab"
                droplabroom = "nolab" + " (LAB)"

            End If

        ElseIf (Chooseterm.sys And Chooseterm.term = "winter") Then


            If (choosesearch.dropcourse = "CPS590 - Introduction to Operating Systems") Then

                dropcoursedesc = "Introduction to O/S (system calls, interrupts, synchronous and asynchronous traps, O/S structure), using processes (process communication and synchronization), primitive communications (signals and signal management calls), pipes, messages, semaphores, shared memory, memory management, file systems, and (time permitting) remote procedure calls." + vbNewLine + vbNewLine + "Lect: 3 hrs./Lab: 1 hr." + vbNewLine
                dropcoursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine

                dropcourseprof = "Instructor: Eric Harley" + vbNewLine

                dropcoursedate = "Days & Times: Thursday 11:00am-2:00pm (LEC)" + vbTab + "Friday 10:00am-11:00am (LAB)" + vbNewLine

                dropcourseroom = "Rooms: " + vbTab + vbTab + "TRS2100 (LEC)" + vbTab + vbTab + "ENG205 (LAB)"


                droplecname = choosesearch.dropcourse
                droplecdate = "Thursday"
                dropstartlectime = "11:00am"
                dropendlectime = "2:00pm"
                droplecroom = "TRS2100" + " (LEC)"

                droplabname = choosesearch.dropcourse
                droplabdate = "Friday"
                dropstartlabtime = "10:00am"
                dropendlabtime = "11:00am"
                droplabroom = "ENG205" + " (LAB)"

            ElseIf (choosesearch.dropcourse = "MTH430 - Dynamic Systems: Differential Equations") Then
                dropcoursedesc = "First-order differential equations, first order systems, linear systems; numerical methods and applications. Non-linear systems, discrete dynamical systems. Linear Algebra; Eigenvalues and eigenvectors." + vbNewLine + vbNewLine + "Lect: 3 hrs." + vbNewLine
                dropcoursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine

                dropcourseprof = "Instructor: Masjed Alqasas" + vbNewLine

                dropcoursedate = "Days & Times: Monday 12:00am-3:00pm (LEC)" + vbNewLine

                dropcourseroom = "Rooms: " + vbTab + vbTab + "TRS2110 (LEC)" + vbNewLine

                droplecname = choosesearch.dropcourse
                droplecdate = "Monday"
                dropstartlectime = "12:00pm"
                dropendlectime = "3:00pm"
                droplecroom = "TRS2110" + " (LEC)"

                droplabname = choosesearch.dropcourse
                droplabdate = "nolab"
                dropstartlabtime = "nolab"
                dropendlabtime = "nolab"
                droplabroom = "nolab" + " (LAB)"

            ElseIf (choosesearch.dropcourse = "MTH540 - Geometry") Then

                dropcoursedesc = "Projective plane and 3-space. Cross-ratio, perspectivity, conics and quadrics, poles and polars. Line geometry in projective 3-space. Euclidean, elliptic and hyperbolic interpretation of projective results. Inversive geometry and the complex projective line. Classification of motions in the Euclidean, elliptic, Gaussian and hyperbolic cases." + vbNewLine + vbNewLine + "Lect: 3 hrs." + vbNewLine
                dropcoursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine

                dropcourseprof = "Instructor: Andrea Smith" + vbNewLine

                dropcoursedate = "Days & Times: Friday 9:00am-12:00pm (LEC)" + vbNewLine

                dropcourseroom = "Rooms: " + vbTab + vbTab + "KHS203 (LEC)"

                droplecname = choosesearch.dropcourse
                droplecdate = "Friday"
                dropstartlectime = "9:00am"
                dropendlectime = "12:00pm"
                droplecroom = "KHS203" + " (LEC)"

                droplabname = choosesearch.dropcourse
                droplabdate = "nolab"
                dropstartlabtime = "nolab"
                dropendlabtime = "nolab"
                droplabroom = "nolab" + " (LAB)"
            End If
        End If


    End Sub

    ' Go BACK
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim choosesearch As New choosesearch()
        Me.Hide()
        choosesearch.Show()
    End Sub

    ' DROP COURSE
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If (Chooseterm.term = "fall") Then

            If (Chooseterm.fys) Then

                If (choosesearch.dropcourse = "CPS109 - Computer Science I" And Chooseterm.fyswc.Contains("CPS209 - Computer Science II")) Then

                    Button2.Enabled = False
                    Label1.Text = "Can not drop this course because you are enrolled in the antirequisite (CPS209 - Computer Science II)"


                Else
                    HomeForm.fcourse.Remove(choosesearch.dropcourse)

                    Chooseterm.fysfc.Remove(choosesearch.dropcourse)

                    Chooseterm.fysfc.Remove(dropcoursemd)
                    Chooseterm.fysfc.Remove(dropcourseprof)
                    Chooseterm.fysfc.Remove(dropcoursedate)
                    Chooseterm.fysfc.Remove(dropcourseroom)
                    Chooseterm.fysfc.Remove("")


                    For i As Integer = add.flecname.Count - 1 To 0 Step -1
                        ' MsgBox("i: " + i.ToString)
                        '  MsgBox(add.flecname.ToArray.Length)
                        '  MsgBox(add.flecname.ToArray.ElementAt(i))
                        ' MsgBox(add.flecname.ToArray.ElementAt(i).ToString)
                        ' MsgBox(choosesearch.dropcourse)
                        If ((add.flecname.ToArray.ElementAt(i).ToString = choosesearch.dropcourse)) Then
                            add.flecname.RemoveAt(i)
                            add.flecdate.RemoveAt(i)
                            add.fstartlectime.RemoveAt(i)
                            add.fendlectime.RemoveAt(i)
                            add.flecroom.RemoveAt(i)

                            add.flabname.RemoveAt(i)
                            add.flabdate.RemoveAt(i)
                            add.fstartlabtime.RemoveAt(i)
                            add.fendlabtime.RemoveAt(i)
                            add.flabroom.RemoveAt(i)
                        End If
                    Next
                        

                    Label1.Text = "The course (" + choosesearch.dropcourse + ") has been successfully dropped."
                    Button2.Hide()


                    Button3.Show()

                End If

            ElseIf (Chooseterm.sys) Then

                HomeForm.fcourse.Remove(choosesearch.dropcourse)

                Chooseterm.sysfc.Remove(choosesearch.dropcourse)

                Chooseterm.sysfc.Remove(dropcoursemd)
                Chooseterm.sysfc.Remove(dropcourseprof)
                Chooseterm.sysfc.Remove(dropcoursedate)
                Chooseterm.sysfc.Remove(dropcourseroom)
                Chooseterm.sysfc.Remove("")

                For i As Integer = add.sflecname.Count - 1 To 0 Step -1
                    ' MsgBox("i: " + i.ToString)
                    '  MsgBox(add.flecname.ToArray.Length)
                    '  MsgBox(add.flecname.ToArray.ElementAt(i))
                    ' MsgBox(add.flecname.ToArray.ElementAt(i).ToString)
                    ' MsgBox(choosesearch.dropcourse)
                    If ((add.sflecname.ToArray.ElementAt(i).ToString = choosesearch.dropcourse)) Then
                        add.sflecname.RemoveAt(i)
                        add.sflecdate.RemoveAt(i)
                        add.sfstartlectime.RemoveAt(i)
                        add.sfendlectime.RemoveAt(i)
                        add.sflecroom.RemoveAt(i)

                        add.sflabname.RemoveAt(i)
                        add.sflabdate.RemoveAt(i)
                        add.sfstartlabtime.RemoveAt(i)
                        add.sfendlabtime.RemoveAt(i)
                        add.sflabroom.RemoveAt(i)
                    End If
                Next

                Label1.Text = "The course (" + choosesearch.dropcourse + ") has been successfully dropped."
                Button2.Hide()


                Button3.Show()

            End If


            ElseIf (Chooseterm.term = "winter") Then

                If (Chooseterm.fys) Then

                    HomeForm.wcourse.Remove(choosesearch.dropcourse)

                    Chooseterm.fyswc.Remove(choosesearch.dropcourse)

                    Chooseterm.fyswc.Remove(dropcoursemd)
                    Chooseterm.fyswc.Remove(dropcourseprof)
                    Chooseterm.fyswc.Remove(dropcoursedate)
                    Chooseterm.fyswc.Remove(dropcourseroom)
                Chooseterm.fyswc.Remove("")

                For i As Integer = add.wlecname.Count - 1 To 0 Step -1
                    ' MsgBox("i: " + i.ToString)
                    '  MsgBox(add.flecname.ToArray.Length)
                    '  MsgBox(add.flecname.ToArray.ElementAt(i))
                    ' MsgBox(add.flecname.ToArray.ElementAt(i).ToString)
                    ' MsgBox(choosesearch.dropcourse)
                    If ((add.wlecname.ToArray.ElementAt(i).ToString = choosesearch.dropcourse)) Then
                        add.wlecname.RemoveAt(i)
                        add.wlecdate.RemoveAt(i)
                        add.wstartlectime.RemoveAt(i)
                        add.wendlectime.RemoveAt(i)
                        add.wlecroom.RemoveAt(i)

                        add.wlabname.RemoveAt(i)
                        add.wlabdate.RemoveAt(i)
                        add.wstartlabtime.RemoveAt(i)
                        add.wendlabtime.RemoveAt(i)
                        add.wlabroom.RemoveAt(i)
                    End If
                Next


                Label1.Text = "The course (" + choosesearch.dropcourse + ") has been successfully dropped."
                Button2.Hide()


                Button3.Show()

                ElseIf (Chooseterm.sys) Then

                    HomeForm.wcourse.Remove(choosesearch.dropcourse)

                    Chooseterm.syswc.Remove(choosesearch.dropcourse)

                    Chooseterm.syswc.Remove(dropcoursemd)
                    Chooseterm.syswc.Remove(dropcourseprof)
                    Chooseterm.syswc.Remove(dropcoursedate)
                    Chooseterm.syswc.Remove(dropcourseroom)
                Chooseterm.syswc.Remove("")


                For i As Integer = add.swlecname.Count - 1 To 0 Step -1
                    ' MsgBox("i: " + i.ToString)
                    '  MsgBox(add.flecname.ToArray.Length)
                    '  MsgBox(add.flecname.ToArray.ElementAt(i))
                    ' MsgBox(add.flecname.ToArray.ElementAt(i).ToString)
                    ' MsgBox(choosesearch.dropcourse)
                    If ((add.swlecname.ToArray.ElementAt(i).ToString = choosesearch.dropcourse)) Then
                        add.swlecname.RemoveAt(i)
                        add.swlecdate.RemoveAt(i)
                        add.swstartlectime.RemoveAt(i)
                        add.swendlectime.RemoveAt(i)
                        add.swlecroom.RemoveAt(i)

                        add.swlabname.RemoveAt(i)
                        add.swlabdate.RemoveAt(i)
                        add.swstartlabtime.RemoveAt(i)
                        add.swendlabtime.RemoveAt(i)
                        add.swlabroom.RemoveAt(i)
                    End If
                Next

                Label1.Text = "The course (" + choosesearch.dropcourse + ") has been successfully dropped."
                Button2.Hide()


                Button3.Show()

                End If

            End If



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim account As New HomeForm()
        Me.Hide()
        account.Show()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim home As New HomeForm()
        Me.Hide()
        home.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim chooseterm As New Chooseterm()
        Me.Hide()
        chooseterm.Show()
    End Sub
End Class