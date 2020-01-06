Public Class add


    Public Shared coursedesc As String
    Public Shared coursemd As String
    Public Shared courseprof As String
    Public Shared coursedate As String
    Public Shared courseroom As String
    Public Shared prereq As String

    ' swapping
    Public Shared swapcoursedesc As String
    Public Shared swapcoursemd As String
    Public Shared swapcourseprof As String
    Public Shared swapcoursedate As String
    Public Shared swapcourseroom As String

    'SCHEDULE
    Public Shared flecname As ArrayList = New ArrayList
    Public Shared flecdate As ArrayList = New ArrayList
    Public Shared fstartlectime As ArrayList = New ArrayList
    Public Shared fendlectime As ArrayList = New ArrayList
    Public Shared flecroom As ArrayList = New ArrayList

    Public Shared flabname As ArrayList = New ArrayList
    Public Shared flabdate As ArrayList = New ArrayList
    Public Shared fstartlabtime As ArrayList = New ArrayList
    Public Shared fendlabtime As ArrayList = New ArrayList
    Public Shared flabroom As ArrayList = New ArrayList


    Public Shared wlecname As ArrayList = New ArrayList
    Public Shared wlecdate As ArrayList = New ArrayList
    Public Shared wstartlectime As ArrayList = New ArrayList
    Public Shared wendlectime As ArrayList = New ArrayList
    Public Shared wlecroom As ArrayList = New ArrayList

    Public Shared wlabname As ArrayList = New ArrayList
    Public Shared wlabdate As ArrayList = New ArrayList
    Public Shared wstartlabtime As ArrayList = New ArrayList
    Public Shared wendlabtime As ArrayList = New ArrayList
    Public Shared wlabroom As ArrayList = New ArrayList

    ' SECOND YEAR
    Public Shared sflecname As ArrayList = New ArrayList
    Public Shared sflecdate As ArrayList = New ArrayList
    Public Shared sfstartlectime As ArrayList = New ArrayList
    Public Shared sfendlectime As ArrayList = New ArrayList
    Public Shared sflecroom As ArrayList = New ArrayList

    Public Shared sflabname As ArrayList = New ArrayList
    Public Shared sflabdate As ArrayList = New ArrayList
    Public Shared sfstartlabtime As ArrayList = New ArrayList
    Public Shared sfendlabtime As ArrayList = New ArrayList
    Public Shared sflabroom As ArrayList = New ArrayList


    Public Shared swlecname As ArrayList = New ArrayList
    Public Shared swlecdate As ArrayList = New ArrayList
    Public Shared swstartlectime As ArrayList = New ArrayList
    Public Shared swendlectime As ArrayList = New ArrayList
    Public Shared swlecroom As ArrayList = New ArrayList

    Public Shared swlabname As ArrayList = New ArrayList
    Public Shared swlabdate As ArrayList = New ArrayList
    Public Shared swstartlabtime As ArrayList = New ArrayList
    Public Shared swendlabtime As ArrayList = New ArrayList
    Public Shared swlabroom As ArrayList = New ArrayList

    Public Shared lec As String
    Public Shared lecday As String
    Public Shared lecstime As String
    Public Shared lecetime As String
    Public Shared lecroom As String

    Public Shared lab As String
    Public Shared labday As String
    Public Shared labstime As String
    Public Shared labetime As String
    Public Shared labroom As String

    Public success As Boolean



    Private Sub add_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Chooseterm.term = "fall" Then
            Label4.Text = "Courses Offered in Fall 2017 Semester"
        ElseIf Chooseterm.term = "winter" Then
            Label4.Text = "Courses Offered in Winter 2018 Semester"
        End If


        Label3.Hide()
        RichTextBox1.Show()
        RichTextBox2.Hide()
        Button1.Hide()
        Button3.Hide()
        Button4.Hide()
        Button5.Hide()
        RichTextBox1.Enabled = False

        Label2.Text = Chooseterm.course
        'MsgBox(Label2.Text)

        ' if swap
        If (HomeForm.addcheck And HomeForm.swapcheck) Then

            Label3.Show()
            Label3.Text = "Choose the course you would like (" + choosesearch.swapcourse + ") to be swapped with."
            Button5.Show()
            Button5.Text = "Swap Courses"

            'Add
        ElseIf (HomeForm.addcheck And Not HomeForm.swapcheck) Then
            Button1.Show()
            Button5.Hide()

        End If

        ' FALL COURSES

        If Chooseterm.fys Then

            If Chooseterm.term = "fall" Then

                If (Label2.Text.ToUpper = "CPS109" Or Label2.Text = "CPS109 - Computer Science I") Then
                    Label2.Text = "CPS109 - Computer Science I"

                    coursedesc = "An introductory programming course designed to introduce fundamental Computer Science concepts such as abstraction, modelling and algorithm design. Emphasis is placed on producing correct software. This course uses Java as its programming language." + vbNewLine + vbNewLine + "Lect: 3 hrs./Lab: 2 hrs." + vbNewLine
                    coursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine

                    courseprof = "Instructor: Tim McInnerny" + vbNewLine

                    coursedate = "Days & Times: Monday 9:00am-12:00pm (LEC)" + vbTab + "Wednesday 12:00pm-2:00pm (LAB)" + vbNewLine

                    courseroom = "Rooms: " + vbTab + vbTab + "TRS2139 (LEC)" + vbTab + vbTab + vbTab + "ENG202 (LAB)"
                    prereq = "Prerequisites: No Prerequisites" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom


                    lec = Label2.Text
                    lecday = "Monday"
                    lecstime = "9:00am"
                    lecetime = "12:00pm"
                    lecroom = "TRS2139" + " (LEC)"

                    lab = Label2.Text
                    labday = "Wednesday"
                    labstime = "12:00pm"
                    labetime = "2:00pm"
                    labroom = "ENG202" + " (LAB)"


                ElseIf (Label2.Text.ToUpper = "BLG143" Or Label2.Text = "BLG143 - Biology I") Then
                    Label2.Text = "BLG143 - Biology I"
                    coursedesc = "This course is an introduction to the cellular and molecular mechanisms in the cell. Topics include macromolecule structure and function, enzymes, cell membrane structure and function, cell cycle control, cell division, metabolism, and photosynthesis. Also included is an introduction to genetics and patterns of inheritance, gene expression and developmental biology. Laboratory exercises complement lectures." + vbNewLine + vbNewLine + "Lect: 3 hrs./Lab: 2 hrs." + vbNewLine
                    coursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine
                    courseprof = "Instructor: John Smith" + vbNewLine
                    coursedate = "Days & Times: Thursday 6:00pm-9:00pm (LEC)" + vbTab + "Friday 9:00am-11:00am (LAB)" + vbNewLine
                    courseroom = "Rooms: " + vbTab + vbTab + vbTab + "RCC222 (LEC)" + vbTab + vbTab + "KHN203 (LAB)"
                    prereq = "Prerequisites: No Prerequisites" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Thursday"
                    lecstime = "6:00pm"
                    lecetime = "9:00pm"
                    lecroom = "RCC222" + " (LEC)"

                    lab = Label2.Text
                    labday = "Friday"
                    labstime = "9:00am"
                    labetime = "11:00am"
                    labroom = "KHN203" + " (LAB)"

                ElseIf (Label2.Text.ToUpper = "MTH430" Or Label2.Text = "MTH430 - Dynamic Systems: Differential Equations") Then

                    Label2.Text = "MTH430 - Dynamic Systems: Differential Equations"

                    coursedesc = "First-order differential equations, first order systems, linear systems; numerical methods and applications. Non-linear systems, discrete dynamical systems. Linear Algebra; Eigenvalues and eigenvectors." + vbNewLine + vbNewLine + "Lect: 3 hrs." + vbNewLine
                    coursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine

                    courseprof = "Instructor: Masjed Alqasas" + vbNewLine

                    coursedate = "Days & Times: Monday 1:00pm-4:00pm (LEC)" + vbNewLine

                    courseroom = "Rooms: " + vbTab + vbTab + "TRS2110 (LEC)" + vbNewLine
                    prereq = "Prerequisites: (MTH 108 and (MTH 231 OR MTH 310)) or ECN 230" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Monday"
                    lecstime = "1:00pm"
                    lecetime = "4:00pm"
                    lecroom = "TRS2110" + " (LEC)"

                    lab = Label2.Text
                    labday = "nolab"
                    labstime = "nolab"
                    labetime = "nolab"
                    labroom = "nolab"

                ElseIf (Label2.Text.ToUpper = "RTA180" Or Label2.Text = "RTA180 - Music and Film") Then
                    Label2.Text = "RTA180 - Music and Film"
                    coursedesc = "The use of music with film has evolved from early stereotyped borrowing of nineteenth century classical European repertoire to newly created scores that enhance and support the dramatic themes of the film. This course explores the relationship between music and film, the functions and effects of music and how the music supports or plays against the visual images. Analysis of selected film genres will demonstrate how music can strengthen the film's dramatic themes. (Formerly MUS 110)"
                    coursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine
                    courseprof = "Instructor: Ann Smith" + vbNewLine
                    coursedate = "Days & Times: Monday 6:00pm-9:00pm (LEC)" + vbNewLine
                    courseroom = "Rooms: " + vbTab + vbTab + vbTab + "RCC222 (LEC)"
                    prereq = "Prerequisites: No Prerequisites" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Monday"
                    lecstime = "6:00pm"
                    lecetime = "9:00pm"
                    lecroom = "RCC222" + " (LEC)"

                    lab = Label2.Text
                    labday = "nolab"
                    labstime = "nolab"
                    labetime = "nolab"
                    labroom = "nolab"

                ElseIf (Label2.Text.ToUpper = "SOC103" Or Label2.Text = "SOC103 - How Society Works") Then
                    Label2.Text = "SOC103 - How Society Works"
                    coursedesc = "This course provides an introduction to some of the major issues in sociology. It examines how societies come into existence, how they are organized and maintained, and how they change. The major sociological perspectives are used to understand the relationship between culture, institutions and social behaviour; the process of socialization; globalization and the political-economic structure of Canadian society; and the resulting social inequalities of class, race and gender. SOC 103 is not available for credit to students who choose SOC 11A/B or SOC111 or SOC112, SOC104, or SOC 105, or SOC 107."
                    coursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine
                    courseprof = "Instructor: Mary Joan" + vbNewLine
                    coursedate = "Days & Times: Thursday 6:00pm-9:00pm (LEC)" + vbNewLine
                    courseroom = "Rooms: " + vbTab + vbTab + vbTab + "RCC222 (LEC)"
                    prereq = "Prerequisites: No Prerequisites" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Thursday"
                    lecstime = "6:00pm"
                    lecetime = "9:00pm"
                    lecroom = "RCC222" + " (LEC)"

                    lab = Label2.Text
                    labday = "nolab"
                    labstime = "nolab"
                    labetime = "nolab"
                    labroom = "nolab"

                    ' No such class found
                Else
                    Label2.Text = "Could not find the course you have searched for."
                    RichTextBox1.Hide()
                    Button1.Hide()
                    Button2.Hide()
                    Button3.Show()
                    Button4.Show()

                End If

                ' SWAPPING FALL COURSES 

                If (choosesearch.swapcourse = "CPS109 - Computer Science I") Then


                    swapcoursedesc = "An introductory programming course designed to introduce fundamental Computer Science concepts such as abstraction, modelling and algorithm design. Emphasis is placed on producing correct software. This course uses Java as its programming language." + vbNewLine + vbNewLine + "Lect: 3 hrs./Lab: 2 hrs." + vbNewLine
                    swapcoursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine

                    swapcourseprof = "Instructor: Tim McInnerny" + vbNewLine
                    '  MsgBox(swapcourseprof)
                    swapcoursedate = "Days & Times: Monday 9:00am-12:00pm (LEC)" + vbTab + "Wednesday 12:00pm-2:00pm (LAB)" + vbNewLine

                    swapcourseroom = "Rooms: " + vbTab + vbTab + "TRS2139 (LEC)" + vbTab + vbTab + vbTab + "ENG202 (LAB)"



                ElseIf (choosesearch.swapcourse = "BLG143 - Biology I") Then

                    swapcoursedesc = "This course is an introduction to the cellular and molecular mechanisms in the cell. Topics include macromolecule structure and function, enzymes, cell membrane structure and function, cell cycle control, cell division, metabolism, and photosynthesis. Also included is an introduction to genetics and patterns of inheritance, gene expression and developmental biology. Laboratory exercises complement lectures." + vbNewLine + vbNewLine + "Lect: 3 hrs./Lab: 1.5 hrs." + vbNewLine
                    swapcoursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine
                    swapcourseprof = "Instructor: John Smith" + vbNewLine
                    swapcoursedate = "Days & Times: Thursday 6:00pm-9:00pm (LEC)" + vbTab + "Friday 9:00am-11:00am (LAB)" + vbNewLine

                    swapcourseroom = "Rooms: " + vbTab + vbTab + vbTab + "RCC222 (LEC)" + vbTab + vbTab + "KHN203 (LAB)"

                ElseIf (choosesearch.swapcourse = "RTA180 - Music and Film") Then
                    swapcoursedesc = "The use of music with film has evolved from early stereotyped borrowing of nineteenth century classical European repertoire to newly created scores that enhance and support the dramatic themes of the film. This course explores the relationship between music and film, the functions and effects of music and how the music supports or plays against the visual images. Analysis of selected film genres will demonstrate how music can strengthen the film's dramatic themes. (Formerly MUS 110)"
                    swapcoursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine
                    swapcourseprof = "Instructor: Ann Smith" + vbNewLine
                    swapcoursedate = "Days & Times: Monday 6:00pm-9:00pm (LEC)" + vbNewLine
                    swapcourseroom = "Rooms: " + vbTab + vbTab + vbTab + "RCC222 (LEC)"

                ElseIf (choosesearch.swapcourse = "SOC103 - How Society Works") Then
                    swapcoursedesc = "This course provides an introduction to some of the major issues in sociology. It examines how societies come into existence, how they are organized and maintained, and how they change. The major sociological perspectives are used to understand the relationship between culture, institutions and social behaviour; the process of socialization; globalization and the political-economic structure of Canadian society; and the resulting social inequalities of class, race and gender. SOC 103 is not available for credit to students who choose SOC 11A/B or SOC111 or SOC112, SOC104, or SOC 105, or SOC 107."
                    swapcoursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine
                    swapcourseprof = "Instructor: Mary Joan" + vbNewLine
                    swapcoursedate = "Days & Times: Thursday 6:00pm-9:00pm (LEC)" + vbNewLine
                    swapcourseroom = "Rooms: " + vbTab + vbTab + vbTab + "RCC222 (LEC)"


                ElseIf (choosesearch.swapcourse = "MTH430 - Dynamic Systems: Differential Equations") Then


                    swapcoursedesc = "First-order differential equations, first order systems, linear systems; numerical methods and applications. Non-linear systems, discrete dynamical systems. Linear Algebra; Eigenvalues and eigenvectors." + vbNewLine + vbNewLine + "Lect: 3 hrs." + vbNewLine
                    swapcoursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine

                    swapcourseprof = "Instructor: Masjed Alqasas" + vbNewLine

                    swapcoursedate = "Days & Times: Monday 1:00pm-4:00pm (LEC)" + vbNewLine

                    swapcourseroom = "Rooms: " + vbTab + vbTab + "TRS2110 (LEC)" + vbNewLine

                End If



                ' WINTER COURSES
            ElseIf Chooseterm.term = "winter" Then
                If (Label2.Text.ToUpper = "CPS209" Or Label2.Text = "CPS209 - Computer Science II") Then
                    Label2.Text = "CPS209 - Computer Science II"
                    coursedesc = "A continuation of CPS 109. Emphasis is placed on code optimization, algorithm and program correctness. Fundamental Computer Science Algorithms will be introduced." + vbNewLine + vbNewLine + "Lect: 3 hrs./Lab: 2 hrs." + vbNewLine
                    coursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine
                    courseprof = "Instructor: Eric Harley" + vbNewLine
                    coursedate = "Days & Times: Monday 12:00pm-3:00pm (LEC)" + vbTab + "Tuesday 2:00pm-4:00pm (LAB)" + vbNewLine
                    courseroom = "Rooms: " + vbTab + vbTab + vbTab + "KHW321 (LEC)" + vbTab + vbTab + "ENG205 (LAB)"
                    prereq = "Prerequisites: CPS109" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Monday"
                    lecstime = "12:00pm"
                    lecetime = "3:00pm"
                    lecroom = "KHW321" + " (LEC)"

                    lab = Label2.Text
                    labday = "Tuesday"
                    labstime = "2:00pm"
                    labetime = "4:00pm"
                    labroom = "ENG205" + " (LAB)"

                ElseIf (Label2.Text.ToUpper = "CHY103" Or Label2.Text = "CHY103 - General Chemistry I") Then
                    Label2.Text = "CHY103 - General Chemistry I"
                    coursedesc = "This foundation course begins with an introduction to types of chemical compounds, chemical reactions and stoichiometry. Subsequent topics include the investigation of the states of matter (primarily liquids and gases), solutions and colligative properties, chemical equilibrium, acids and bases, and thermochemistry. This course acts as the first half of a full year general chemistry sequence and is a precursor to CHY 113 General Chemistry II." + vbNewLine + vbNewLine + "Lect: 3 hrs./Lab: 2 hrs." + vbNewLine
                    coursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine
                    courseprof = "Instructor: David Miller" + vbNewLine
                    coursedate = "Days & Times: Monday 12:00pm-3:00pm (LEC)" + vbTab + "Wednesday 3:00pm-5:00pm (LAB)" + vbNewLine
                    courseroom = "Rooms: " + vbTab + vbTab + vbTab + "KHW221 (LEC)" + vbTab + vbTab + "KHS311 (LAB)"
                    prereq = "Prerequisites: No Prerequisites" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Monday"
                    lecstime = "12:00pm"
                    lecetime = "3:00pm"
                    lecroom = "KHW221" + " (LEC)"

                    lab = Label2.Text
                    labday = "Wednesday"
                    labstime = "3:00pm"
                    labetime = "5:00pm"
                    labroom = "KHS311" + " (LAB)"

                ElseIf (Label2.Text.ToUpper = "PCS110" Or Label2.Text = "PCS110 - Physics") Then
                    Label2.Text = "PCS110 - Physics"
                    coursedesc = "Units and vectors. Motion: linear, projectile, circular and oscillatory motion. Newton's laws: Force, mass and acceleration; work, energy and power; linear and angular momentum. Electrostatics: Electric force and field; potential and potential energy; capacitance. Electric current and DC circuits. Magnetic field and force: magnetic force on currents and charges; Hall effect; torque on current loops; Waves: classification of waves; energy transfer; light and electromagnetic waves; diffraction and interference. MAPLE used for simulation/visualization of physical phenomena and problem solving." + vbNewLine + vbNewLine + "Lect: 3 hrs./Lab: 2 hrs." + vbNewLine
                    coursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine
                    courseprof = "Instructor: Carl Jackson" + vbNewLine
                    coursedate = "Days & Times: Thursday 11:00am-2:00pm (LEC)" + vbTab + "Friday 10:00am-12:00pm (LAB)" + vbNewLine
                    courseroom = "Rooms: " + vbTab + vbTab + vbTab + "KHE109 (LEC)" + vbTab + vbTab + "KHN206 (LAB)"
                    prereq = "Prerequisites: No Prerequisites" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Thursday"
                    lecstime = "11:00am"
                    lecetime = "2:00pm"
                    lecroom = "KHE109" + " (LEC)"

                    lab = Label2.Text
                    labday = "Friday"
                    labstime = "10:00am"
                    labetime = "12:00pm"
                    labroom = "KHN206" + " (LAB)"

                ElseIf (Label2.Text.ToUpper = "RTA180" Or Label2.Text = "RTA180 - Music and Film") Then
                    Label2.Text = "RTA180 - Music and Film"
                    coursedesc = "The use of music with film has evolved from early stereotyped borrowing of nineteenth century classical European repertoire to newly created scores that enhance and support the dramatic themes of the film. This course explores the relationship between music and film, the functions and effects of music and how the music supports or plays against the visual images. Analysis of selected film genres will demonstrate how music can strengthen the film's dramatic themes. (Formerly MUS 110)"
                    coursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine
                    courseprof = "Instructor: Ann Smith" + vbNewLine
                    coursedate = "Days & Times: Monday 6:00pm-9:00pm (LEC)" + vbNewLine
                    courseroom = "Rooms: " + vbTab + vbTab + vbTab + "RCC222 (LEC)"
                    prereq = "Prerequisites: No Prerequisites" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Monday"
                    lecstime = "6:00pm"
                    lecetime = "9:00pm"
                    lecroom = "RCC222" + " (LEC)"

                    lab = Label2.Text
                    labday = "nolab"
                    labstime = "nolab"
                    labetime = "nolab"
                    labroom = "nolab"

                ElseIf (Label2.Text.ToUpper = "SOC103" Or Label2.Text = "SOC103 - How Society Works") Then
                    Label2.Text = "SOC103 - How Society Works"
                    coursedesc = "This course provides an introduction to some of the major issues in sociology. It examines how societies come into existence, how they are organized and maintained, and how they change. The major sociological perspectives are used to understand the relationship between culture, institutions and social behaviour; the process of socialization; globalization and the political-economic structure of Canadian society; and the resulting social inequalities of class, race and gender. SOC 103 is not available for credit to students who choose SOC 11A/B or SOC111 or SOC112, SOC104, or SOC 105, or SOC 107."
                    coursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine
                    courseprof = "Instructor: Mary Joan" + vbNewLine
                    coursedate = "Days & Times: Thursday 6:00pm-9:00pm (LEC)" + vbNewLine
                    courseroom = "Rooms: " + vbTab + vbTab + vbTab + "RCC222 (LEC)"
                    prereq = "Prerequisites: No Prerequisites" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Thursday"
                    lecstime = "6:00pm"
                    lecetime = "9:00pm"
                    lecroom = "RCC222" + " (LEC)"

                    lab = Label2.Text
                    labday = "nolab"
                    labstime = "nolab"
                    labetime = "nolab"
                    labroom = "nolab"


                ElseIf (Label2.Text.ToUpper = "MTH540" Or Label2.Text = "MTH540 - Geometry") Then
                    Label2.Text = "MTH540 - Geometry"

                    coursedesc = "Projective plane and 3-space. Cross-ratio, perspectivity, conics and quadrics, poles and polars. Line geometry in projective 3-space. Euclidean, elliptic and hyperbolic interpretation of projective results. Inversive geometry and the complex projective line. Classification of motions in the Euclidean, elliptic, Gaussian and hyperbolic cases." + vbNewLine + vbNewLine + "Lect: 3 hrs." + vbNewLine
                    coursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine

                    courseprof = "Instructor: Andrea Smith" + vbNewLine

                    coursedate = "Days & Times: Friday 9:00am-12:00pm (LEC)" + vbNewLine

                    courseroom = "Rooms: " + vbTab + vbTab + "KHS203 (LEC)"
                    prereq = "Prerequisites: MTH108" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Friday"
                    lecstime = "9:00am"
                    lecetime = "12:00pm"
                    lecroom = "KHS203" + " (LEC)"

                    lab = Label2.Text
                    labday = "nolab"
                    labstime = "nolab"
                    labetime = "nolab"
                    labroom = "nolab"

                ElseIf (Label2.Text.ToUpper = "MTH430" Or Label2.Text = "MTH430 - Dynamic Systems: Differential Equations") Then

                    Label2.Text = "MTH430 - Dynamic Systems: Differential Equations"

                    coursedesc = "First-order differential equations, first order systems, linear systems; numerical methods and applications. Non-linear systems, discrete dynamical systems. Linear Algebra; Eigenvalues and eigenvectors." + vbNewLine + vbNewLine + "Lect: 3 hrs." + vbNewLine
                    coursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine

                    courseprof = "Instructor: Masjed Alqasas" + vbNewLine

                    coursedate = "Days & Times: Wednesday 12:00pm-3:00pm (LEC)" + vbNewLine

                    courseroom = "Rooms: " + vbTab + vbTab + "TRS2110 (LEC)" + vbNewLine
                    prereq = "Prerequisites: (MTH 108 and (MTH 231 OR MTH 310)) or ECN 230" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Wednesday"
                    lecstime = "12:00pm"
                    lecetime = "3:00pm"
                    lecroom = "TRS2110" + " (LEC)"

                    lab = Label2.Text
                    labday = "nolab"
                    labstime = "nolab"
                    labetime = "nolab"
                    labroom = "nolab"


                    ' No such class found
                Else
                    Label2.Text = "Could not find the course you have searched for."
                    RichTextBox1.Hide()
                    Button1.Hide()
                    Button2.Hide()
                    Button3.Show()
                    Button4.Show()

                End If

                ' SWAPPING WINTER COURSES
                If (choosesearch.swapcourse = "CPS209 - Computer Science II") Then
                    swapcoursedesc = "A continuation of CPS 109. Emphasis is placed on code optimization, algorithm and program correctness. Fundamental Computer Science Algorithms will be introduced." + vbNewLine + vbNewLine + "Lect: 3 hrs./Lab: 1 hr." + vbNewLine
                    swapcoursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine
                    swapcourseprof = "Instructor: Eric Harley" + vbNewLine
                    swapcoursedate = "Days & Times: Monday 12:00pm-3:00pm (LEC)" + vbTab + "Tuesday 2:00pm-4:00pm (LAB)" + vbNewLine

                    swapcourseroom = "Rooms: " + vbTab + vbTab + vbTab + "KHW321 (LEC)" + vbTab + vbTab + "ENG205 (LAB)"


                ElseIf (choosesearch.swapcourse = "CHY103 - General Chemistry I") Then
                    swapcoursedesc = "This foundation course begins with an introduction to types of chemical compounds, chemical reactions and stoichiometry. Subsequent topics include the investigation of the states of matter (primarily liquids and gases), solutions and colligative properties, chemical equilibrium, acids and bases, and thermochemistry. This course acts as the first half of a full year general chemistry sequence and is a precursor to CHY 113 General Chemistry II." + vbNewLine + vbNewLine + "Lect: 3 hrs./Lab: 3 hrs." + vbNewLine
                    swapcoursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine
                    swapcourseprof = "Instructor: David Miller" + vbNewLine
                    swapcoursedate = "Days & Times: Monday 12:00pm-3:00pm (LEC)" + vbTab + "Wednesday 3:00pm-5:00pm (LAB)" + vbNewLine

                    swapcourseroom = "Rooms: " + vbTab + vbTab + vbTab + "KHW221 (LEC)" + vbTab + vbTab + "KHS311 (LAB)"


                ElseIf (choosesearch.swapcourse = "PCS110 - Physics") Then
                    swapcoursedesc = "Units and vectors. Motion: linear, projectile, circular and oscillatory motion. Newton's laws: Force, mass and acceleration; work, energy and power; linear and angular momentum. Electrostatics: Electric force and field; potential and potential energy; capacitance. Electric current and DC circuits. Magnetic field and force: magnetic force on currents and charges; Hall effect; torque on current loops; Waves: classification of waves; energy transfer; light and electromagnetic waves; diffraction and interference. MAPLE used for simulation/visualization of physical phenomena and problem solving." + vbNewLine + vbNewLine + "Lect: 3 hrs./Lab: 1 hr." + vbNewLine
                    swapcoursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine
                    swapcourseprof = "Instructor: Carl Jackson" + vbNewLine
                    swapcoursedate = "Days & Times: Thursday 11:00am-2:00pm (LEC)" + vbTab + "Friday 10:00am-12:00pm (LAB)" + vbNewLine

                    swapcourseroom = "Rooms: " + vbTab + vbTab + vbTab + "KHE109 (LEC)" + vbTab + vbTab + "KHN206 (LAB)"

                ElseIf (choosesearch.swapcourse = "RTA180 - Music and Film") Then
                    swapcoursedesc = "The use of music with film has evolved from early stereotyped borrowing of nineteenth century classical European repertoire to newly created scores that enhance and support the dramatic themes of the film. This course explores the relationship between music and film, the functions and effects of music and how the music supports or plays against the visual images. Analysis of selected film genres will demonstrate how music can strengthen the film's dramatic themes. (Formerly MUS 110)"
                    swapcoursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine
                    swapcourseprof = "Instructor: Ann Smith" + vbNewLine
                    swapcoursedate = "Days & Times: Monday 6:00pm-9:00pm (LEC)" + vbNewLine
                    swapcourseroom = "Rooms: " + vbTab + vbTab + vbTab + "RCC222 (LEC)"

                ElseIf (choosesearch.swapcourse = "SOC103 - How Society Works") Then
                    swapcoursedesc = "This course provides an introduction to some of the major issues in sociology. It examines how societies come into existence, how they are organized and maintained, and how they change. The major sociological perspectives are used to understand the relationship between culture, institutions and social behaviour; the process of socialization; globalization and the political-economic structure of Canadian society; and the resulting social inequalities of class, race and gender. SOC 103 is not available for credit to students who choose SOC 11A/B or SOC111 or SOC112, SOC104, or SOC 105, or SOC 107."
                    swapcoursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine
                    swapcourseprof = "Instructor: Mary Joan" + vbNewLine
                    swapcoursedate = "Days & Times: Thursday 6:00pm-9:00pm (LEC)" + vbNewLine
                    swapcourseroom = "Rooms: " + vbTab + vbTab + vbTab + "RCC222 (LEC)"

                ElseIf (choosesearch.swapcourse = "MTH430 - Dynamic Systems: Differential Equations") Then
                    swapcoursedesc = "First-order differential equations, first order systems, linear systems; numerical methods and applications. Non-linear systems, discrete dynamical systems. Linear Algebra; Eigenvalues and eigenvectors." + vbNewLine + vbNewLine + "Lect: 3 hrs." + vbNewLine
                    swapcoursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine

                    swapcourseprof = "Instructor: Masjed Alqasas" + vbNewLine

                    swapcoursedate = "Days & Times: Monday 12:00am-3:00pm (LEC)" + vbNewLine

                    swapcourseroom = "Rooms: " + vbTab + vbTab + "TRS2110 (LEC)" + vbNewLine


                ElseIf (choosesearch.swapcourse = "MTH540 - Geometry") Then

                    swapcoursedesc = "Projective plane and 3-space. Cross-ratio, perspectivity, conics and quadrics, poles and polars. Line geometry in projective 3-space. Euclidean, elliptic and hyperbolic interpretation of projective results. Inversive geometry and the complex projective line. Classification of motions in the Euclidean, elliptic, Gaussian and hyperbolic cases." + vbNewLine + vbNewLine + "Lect: 3 hrs." + vbNewLine
                    swapcoursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine

                    swapcourseprof = "Instructor: Andrea Smith" + vbNewLine
                    swapcoursedate = "Days & Times: Wednesday 12:00pm-3:00pm (LEC)" + vbNewLine

                    swapcourseroom = "Rooms: " + vbTab + vbTab + "KHS203 (LEC)"
                End If

            End If

        End If

        ' SECOND YEAR STUDENT 
        If Chooseterm.sys Then

            If Chooseterm.term = "fall" Then

                If (Label2.Text.ToUpper = "CPS420" Or Label2.Text = "CPS420 - Discrete Structures") Then
                    Label2.Text = "CPS420 - Discrete Structures"

                    coursedesc = "Introduction to discrete structures and probability as they apply to design and analysis. Review of proof techniques: induction and recursion. Graphs and trees, and their applications in computing. Finite automata and computability. Counting: arithmetic and geometric progressions, permutations and combinations, modular arithmetic. Probability." + vbNewLine + vbNewLine + "Lect: 3 hrs." + vbNewLine
                    coursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine

                    courseprof = "Instructor: Denise Woit" + vbNewLine

                    coursedate = "Days & Times: Monday 9:00am-12:00pm (LEC)" + vbNewLine

                    courseroom = "Rooms: " + vbTab + vbTab + "TRS2100 (LEC)" + vbNewLine
                    prereq = "Prerequisites: No Prerequisites" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Monday"
                    lecstime = "9:00am"
                    lecetime = "12:00pm"
                    lecroom = "TRS2100" + " (LEC)"

                    lab = Label2.Text
                    labday = "nolab"
                    labstime = "nolab"
                    labetime = "nolab"
                    labroom = "nolab"


                ElseIf (Label2.Text.ToUpper = "MTH430" Or Label2.Text = "MTH430 - Dynamic Systems: Differential Equations") Then

                    Label2.Text = "MTH430 - Dynamic Systems: Differential Equations"

                    coursedesc = "First-order differential equations, first order systems, linear systems; numerical methods and applications. Non-linear systems, discrete dynamical systems. Linear Algebra; Eigenvalues and eigenvectors." + vbNewLine + vbNewLine + "Lect: 3 hrs." + vbNewLine
                    coursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine

                    courseprof = "Instructor: Masjed Alqasas" + vbNewLine

                    coursedate = "Days & Times: Monday 1:00pm-4:00pm (LEC)" + vbNewLine

                    courseroom = "Rooms: " + vbTab + vbTab + "TRS2110 (LEC)" + vbNewLine
                    prereq = "Prerequisites: (MTH 108 and (MTH 231 OR MTH 310)) or ECN 230" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Monday"
                    lecstime = "1:00pm"
                    lecetime = "4:00pm"
                    lecroom = "TRS2110" + " (LEC)"

                    lab = Label2.Text
                    labday = "nolab"
                    labstime = "nolab"
                    labetime = "nolab"
                    labroom = "nolab"

                ElseIf (Label2.Text.ToUpper = "CRM200" Or Label2.Text = "CRM200 - Criminal Law") Then
                    Label2.Text = "CRM200 - Criminal Law"
                    coursedesc = "Students are introduced to the basic concepts and substance of the criminal law in Canada. The historical and theoretical foundations of criminal law, elements of an offence, and criminal defenses are considered. The role of criminal law in society, and its intersection with other forms of social regulation are highlighted. This course is not a technical legal course in criminal procedure; rather, it provides students with basic knowledge of criminal law in Canada."
                    coursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine
                    courseprof = "Instructor: Joe Turner" + vbNewLine
                    coursedate = "Days & Times: Monday 6:00pm-9:00pm (LEC)" + vbNewLine
                    courseroom = "Rooms: " + vbTab + vbTab + vbTab + "RCC333 (LEC)"
                    prereq = "Prerequisites: No Prerequisites" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Monday"
                    lecstime = "6:00pm"
                    lecetime = "9:00pm"
                    lecroom = "RCC333" + " (LEC)"

                    lab = Label2.Text
                    labday = "nolab"
                    labstime = "nolab"
                    labetime = "nolab"
                    labroom = "nolab"

                ElseIf (Label2.Text.ToUpper = "DST500" Or Label2.Text = "DST500 - A History of Madness") Then
                    Label2.Text = "DST500 - A History of Madness"
                    coursedesc = "Where do diverse concepts of 'madness' come from? How have these ideas changed over time? How have 'mad people' interpreted their own experiences? This course will be in the tradition of social history from 'below'. It will survey the social medical, political, economic, cultural and religious factors that have influenced interpretations of what it means to be 'mad' from ancient time to the present."
                    coursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine
                    courseprof = "Instructor: Ben Gunt" + vbNewLine
                    coursedate = "Days & Times: Thursday 6:00pm-9:00pm (LEC)" + vbNewLine
                    courseroom = "Rooms: " + vbTab + vbTab + vbTab + "RCC333 (LEC)"
                    prereq = "Prerequisites: No Prerequisites" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Thursday"
                    lecstime = "6:00pm"
                    lecetime = "9:00pm"
                    lecroom = "RCC333" + " (LEC)"

                    lab = Label2.Text
                    labday = "nolab"
                    labstime = "nolab"
                    labetime = "nolab"
                    labroom = "nolab"

                    ' No such class found
                Else
                    Label2.Text = "Could not find the course you have searched for."
                    RichTextBox1.Hide()
                    Button1.Hide()
                    Button2.Hide()
                    Button3.Show()
                    Button4.Show()

                End If


                ' SWAP FALL COURSES 

                If (choosesearch.swapcourse = "CPS420 - Discrete Structures") Then
                    swapcoursedesc = "Introduction to discrete structures and probability as they apply to design and analysis. Review of proof techniques: induction and recursion. Graphs and trees, and their applications in computing. Finite automata and computability. Counting: arithmetic and geometric progressions, permutations and combinations, modular arithmetic. Probability." + vbNewLine + vbNewLine + "Lect: 3 hrs." + vbNewLine
                    swapcoursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine

                    swapcourseprof = "Instructor: Denise Woit" + vbNewLine
                    swapcoursedate = "Days & Times: Monday 9:00am-12:00pm (LEC)" + vbNewLine

                    swapcourseroom = "Rooms: " + vbTab + vbTab + "TRS2100 (LEC)" + vbNewLine


                ElseIf (choosesearch.swapcourse = "MTH430 - Dynamic Systems: Differential Equations") Then
                    swapcoursedesc = "First-order differential equations, first order systems, linear systems; numerical methods and applications. Non-linear systems, discrete dynamical systems. Linear Algebra; Eigenvalues and eigenvectors." + vbNewLine + vbNewLine + "Lect: 3 hrs." + vbNewLine
                    swapcoursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine

                    swapcourseprof = "Instructor: Masjed Alqasas" + vbNewLine
                    swapcoursedate = "Days & Times: Monday 1:00pm-4:00pm (LEC)" + vbNewLine

                    swapcourseroom = "Rooms: " + vbTab + vbTab + "TRS2110 (LEC)" + vbNewLine

                ElseIf (choosesearch.swapcourse = "CRM200 - Criminal Law") Then
                    swapcoursedesc = "Students are introduced to the basic concepts and substance of the criminal law in Canada. The historical and theoretical foundations of criminal law, elements of an offence, and criminal defenses are considered. The role of criminal law in society, and its intersection with other forms of social regulation are highlighted. This course is not a technical legal course in criminal procedure; rather, it provides students with basic knowledge of criminal law in Canada."
                    swapcoursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine
                    swapcourseprof = "Instructor: Joe Turner" + vbNewLine
                    swapcoursedate = "Days & Times: Monday 6:00pm-9:00pm (LEC)" + vbNewLine
                    courseroom = "Rooms: " + vbTab + vbTab + vbTab + "RCC333 (LEC)"

                ElseIf (choosesearch.swapcourse = "DST500 - A History of Madness") Then
                    swapcoursedesc = "Where do diverse concepts of 'madness' come from? How have these ideas changed over time? How have 'mad people' interpreted their own experiences? This course will be in the tradition of social history from 'below'. It will survey the social medical, political, economic, cultural and religious factors that have influenced interpretations of what it means to be 'mad' from ancient time to the present."
                    swapcoursemd = "Meeting Dates: 08/09/2017 - 10/12/2017" + vbNewLine
                    swapcourseprof = "Instructor: Ben Gunt" + vbNewLine
                    swapcoursedate = "Days & Times: Thursday 6:00pm-9:00pm (LEC)" + vbNewLine
                    swapcourseroom = "Rooms: " + vbTab + vbTab + vbTab + "RCC333 (LEC)"

                End If


            ElseIf Chooseterm.term = "winter" Then


                If (Label2.Text.ToUpper = "MTH540" Or Label2.Text = "MTH540 - Geometry") Then
                    Label2.Text = "MTH540 - Geometry"

                    coursedesc = "Projective plane and 3-space. Cross-ratio, perspectivity, conics and quadrics, poles and polars. Line geometry in projective 3-space. Euclidean, elliptic and hyperbolic interpretation of projective results. Inversive geometry and the complex projective line. Classification of motions in the Euclidean, elliptic, Gaussian and hyperbolic cases." + vbNewLine + vbNewLine + "Lect: 3 hrs." + vbNewLine
                    coursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine

                    courseprof = "Instructor: Andrea Smith" + vbNewLine

                    coursedate = "Days & Times: Friday 9:00am-12:00pm (LEC)" + vbNewLine

                    courseroom = "Rooms: " + vbTab + vbTab + "KHS203 (LEC)"
                    prereq = "Prerequisites: MTH108" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Friday"
                    lecstime = "9:00am"
                    lecetime = "12:00pm"
                    lecroom = "KHS203" + " (LEC)"

                    lab = Label2.Text
                    labday = "nolab"
                    labstime = "nolab"
                    labetime = "nolab"
                    labroom = "nolab"

                ElseIf (Label2.Text.ToUpper = "MTH430" Or Label2.Text = "MTH430 - Dynamic Systems: Differential Equations") Then

                    Label2.Text = "MTH430 - Dynamic Systems: Differential Equations"

                    coursedesc = "First-order differential equations, first order systems, linear systems; numerical methods and applications. Non-linear systems, discrete dynamical systems. Linear Algebra; Eigenvalues and eigenvectors." + vbNewLine + vbNewLine + "Lect: 3 hrs." + vbNewLine
                    coursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine

                    courseprof = "Instructor: Masjed Alqasas" + vbNewLine

                    coursedate = "Days & Times: Wednesday 12:00pm-3:00pm (LEC)" + vbNewLine

                    courseroom = "Rooms: " + vbTab + vbTab + "TRS2110 (LEC)" + vbNewLine
                    prereq = "Prerequisites: (MTH 108 and (MTH 231 OR MTH 310)) or ECN 230" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Wednesday"
                    lecstime = "12:00pm"
                    lecetime = "3:00pm"
                    lecroom = "TRS2110" + " (LEC)"

                    lab = Label2.Text
                    labday = "nolab"
                    labstime = "nolab"
                    labetime = "nolab"
                    labroom = "nolab"

                ElseIf (Label2.Text.ToUpper = "CPS590" Or Label2.Text = "CPS590 - Introduction to Operating Systems") Then

                    Label2.Text = "CPS590 - Introduction to Operating Systems"

                    coursedesc = "Introduction to O/S (system calls, interrupts, synchronous and asynchronous traps, O/S structure), using processes (process communication and synchronization), primitive communications (signals and signal management calls), pipes, messages, semaphores, shared memory, memory management, file systems, and (time permitting) remote procedure calls." + vbNewLine + vbNewLine + "Lect: 3 hrs./Lab: 2 hrs." + vbNewLine
                    coursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine

                    courseprof = "Instructor: Eric Harley" + vbNewLine

                    coursedate = "Days & Times: Thursday 11:00am-2:00pm (LEC)" + vbTab + "Friday 4:00pm-6:00pm (LAB)" + vbNewLine

                    courseroom = "Rooms: " + vbTab + vbTab + "TRS2100 (LEC)" + vbTab + vbTab + "ENG205 (LAB)"
                    prereq = "Prerequisites: No Prerequisites" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Thursday"
                    lecstime = "11:00am"
                    lecetime = "2:00pm"
                    lecroom = "TRS2100" + " (LEC)"

                    lab = Label2.Text
                    labday = "Friday"
                    labstime = "4:00pm"
                    labetime = "6:00pm"
                    labroom = "ENG205" + " (LAB)"


                ElseIf (Label2.Text.ToUpper = "CRM200" Or Label2.Text = "CRM200 - Criminal Law") Then
                    Label2.Text = "CRM200 - Criminal Law"
                    coursedesc = "Students are introduced to the basic concepts and substance of the criminal law in Canada. The historical and theoretical foundations of criminal law, elements of an offence, and criminal defenses are considered. The role of criminal law in society, and its intersection with other forms of social regulation are highlighted. This course is not a technical legal course in criminal procedure; rather, it provides students with basic knowledge of criminal law in Canada."
                    coursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine
                    courseprof = "Instructor: Joe Turner" + vbNewLine
                    coursedate = "Days & Times: Monday 6:00pm-9:00pm (LEC)" + vbNewLine
                    courseroom = "Rooms: " + vbTab + vbTab + vbTab + "RCC333 (LEC)"
                    prereq = "Prerequisites: No Prerequisites" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Monday"
                    lecstime = "6:00pm"
                    lecetime = "9:00pm"
                    lecroom = "RCC333" + " (LEC)"

                    lab = Label2.Text
                    labday = "nolab"
                    labstime = "nolab"
                    labetime = "nolab"
                    labroom = "nolab"

                ElseIf (Label2.Text.ToUpper = "DST500" Or Label2.Text = "DST500 - A History of Madness") Then
                    Label2.Text = "DST500 - A History of Madness"
                    coursedesc = "Where do diverse concepts of 'madness' come from? How have these ideas changed over time? How have 'mad people' interpreted their own experiences? This course will be in the tradition of social history from 'below'. It will survey the social medical, political, economic, cultural and religious factors that have influenced interpretations of what it means to be 'mad' from ancient time to the present."
                    coursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine
                    courseprof = "Instructor: Ben Gunt" + vbNewLine
                    coursedate = "Days & Times: Thursday 6:00pm-9:00pm (LEC)" + vbNewLine
                    courseroom = "Rooms: " + vbTab + vbTab + vbTab + "RCC333 (LEC)"
                    prereq = "Prerequisites: No Prerequisites" + vbNewLine
                    RichTextBox1.Text = coursedesc + prereq + coursemd + courseprof + coursedate + courseroom

                    lec = Label2.Text
                    lecday = "Thursday"
                    lecstime = "6:00pm"
                    lecetime = "9:00pm"
                    lecroom = "RCC333" + " (LEC)"

                    lab = Label2.Text
                    labday = "nolab"
                    labstime = "nolab"
                    labetime = "nolab"
                    labroom = "nolab"

                    ' No such class found
                Else
                    Label2.Text = "Could not find the course you have searched for."
                    RichTextBox1.Hide()
                    Button1.Hide()
                    Button2.Hide()
                    Button3.Show()
                    Button4.Show()

                End If

                ' SWAP SECOND YEAR WINTER COURSES

                If (choosesearch.swapcourse = "CPS590 - Introduction to Operating Systems") Then

                    swapcoursedesc = "Introduction to O/S (system calls, interrupts, synchronous and asynchronous traps, O/S structure), using processes (process communication and synchronization), primitive communications (signals and signal management calls), pipes, messages, semaphores, shared memory, memory management, file systems, and (time permitting) remote procedure calls." + vbNewLine + vbNewLine + "Lect: 3 hrs./Lab: 1 hr." + vbNewLine
                    swapcoursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine

                    swapcourseprof = "Instructor: Eric Harley" + vbNewLine
                    swapcoursedate = "Days & Times: Thursday 11:00am-2:00pm (LEC)" + vbTab + "Friday 4:00pm-6:00pm (LAB)" + vbNewLine

                    swapcourseroom = "Rooms: " + vbTab + vbTab + "TRS2100 (LEC)" + vbTab + vbTab + "ENG205 (LAB)"


                ElseIf (choosesearch.swapcourse = "MTH430 - Dynamic Systems: Differential Equations") Then
                    swapcoursedesc = "First-order differential equations, first order systems, linear systems; numerical methods and applications. Non-linear systems, discrete dynamical systems. Linear Algebra; Eigenvalues and eigenvectors." + vbNewLine + vbNewLine + "Lect: 3 hrs." + vbNewLine
                    swapcoursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine

                    swapcourseprof = "Instructor: Masjed Alqasas" + vbNewLine

                    swapcoursedate = "Days & Times: Monday 12:00am-3:00pm (LEC)" + vbNewLine

                    swapcourseroom = "Rooms: " + vbTab + vbTab + "TRS2110 (LEC)" + vbNewLine


                ElseIf (choosesearch.swapcourse = "MTH540 - Geometry") Then

                    swapcoursedesc = "Projective plane and 3-space. Cross-ratio, perspectivity, conics and quadrics, poles and polars. Line geometry in projective 3-space. Euclidean, elliptic and hyperbolic interpretation of projective results. Inversive geometry and the complex projective line. Classification of motions in the Euclidean, elliptic, Gaussian and hyperbolic cases." + vbNewLine + vbNewLine + "Lect: 3 hrs." + vbNewLine
                    swapcoursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine

                    swapcourseprof = "Instructor: Andrea Smith" + vbNewLine
                    swapcoursedate = "Days & Times: Wednesday 12:00pm-3:00pm (LEC)" + vbNewLine

                    swapcourseroom = "Rooms: " + vbTab + vbTab + "KHS203 (LEC)"


                ElseIf (choosesearch.swapcourse = "CRM200 - Criminal Law") Then
                    swapcoursedesc = "Students are introduced to the basic concepts and substance of the criminal law in Canada. The historical and theoretical foundations of criminal law, elements of an offence, and criminal defenses are considered. The role of criminal law in society, and its intersection with other forms of social regulation are highlighted. This course is not a technical legal course in criminal procedure; rather, it provides students with basic knowledge of criminal law in Canada."
                    swapcoursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine
                    swapcourseprof = "Instructor: Joe Turner" + vbNewLine
                    swapcoursedate = "Days & Times: Monday 6:00pm-9:00pm (LEC)" + vbNewLine
                    courseroom = "Rooms: " + vbTab + vbTab + vbTab + "RCC333 (LEC)"

                ElseIf (choosesearch.swapcourse = "DST500 - A History of Madness") Then
                    swapcoursedesc = "Where do diverse concepts of 'madness' come from? How have these ideas changed over time? How have 'mad people' interpreted their own experiences? This course will be in the tradition of social history from 'below'. It will survey the social medical, political, economic, cultural and religious factors that have influenced interpretations of what it means to be 'mad' from ancient time to the present."
                    swapcoursemd = "Meeting Dates: 08/01/2018 - 10/04/2018" + vbNewLine
                    swapcourseprof = "Instructor: Ben Gunt" + vbNewLine
                    swapcoursedate = "Days & Times: Thursday 6:00pm-9:00pm (LEC)" + vbNewLine
                    swapcourseroom = "Rooms: " + vbTab + vbTab + vbTab + "RCC333 (LEC)"
                End If

            End If


        End If


        '  MsgBox(Label2.Text)
        '  MsgBox(Chooseterm.fysfc.Contains(Label2.Text))


        If Chooseterm.fys Then
            If Chooseterm.term = "fall" And Chooseterm.fysfc.Contains(Label2.Text) Then

                Button1.Show()
                Button1.Text = "Class is already added"
                Button1.Enabled = False

                Button5.Hide()

            ElseIf Chooseterm.term = "winter" And Chooseterm.fyswc.Contains(Label2.Text) Then

                Button1.Show()
                Button1.Text = "Class is already added"
                Button1.Enabled = False

                Button5.Hide()

            End If
        End If

        If Chooseterm.sys Then
            If Chooseterm.term = "fall" And Chooseterm.sysfc.Contains(Label2.Text) Then
                Button1.Show()
                Button1.Text = "Class is already added"
                Button1.Enabled = False

                Button5.Hide()

            ElseIf Chooseterm.term = "winter" And Chooseterm.syswc.Contains(Label2.Text) Then
                Button1.Show()
                Button1.Text = "Class is already added"
                Button1.Enabled = False

                Button5.Hide()
            End If
        End If


    End Sub

    ' Add class button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' FIRST YEAR STUDENT ADD
        If (Chooseterm.term = "fall" And Chooseterm.fys) Then

            success = True
            If Label2.Text = "MTH430 - Dynamic Systems: Differential Equations" Then
                success = False
            End If

            If (success) Then
                HomeForm.fcourse.Add(Label2.Text)
                Chooseterm.fysfc.Add(Label2.Text)

                Chooseterm.fysfc.Add(coursemd)
                Chooseterm.fysfc.Add(courseprof)
                Chooseterm.fysfc.Add(coursedate)
                Chooseterm.fysfc.Add(courseroom)
                Chooseterm.fysfc.Add("")


                flecname.Add(lec)
                flecdate.Add(lecday)
                fstartlectime.Add(lecstime)
                fendlectime.Add(lecetime)
                flecroom.Add(lecroom)

                flabname.Add(lab)
                flabdate.Add(labday)
                fstartlabtime.Add(labstime)
                fendlabtime.Add(labetime)
                flabroom.Add(labroom)

                Button1.Hide()
                Button2.Hide()
                Button3.Show()
                Button4.Show()

                RichTextBox1.Hide()
                RichTextBox2.Show()
                RichTextBox2.Enabled = False

                RichTextBox2.Text = "This course has been added to your fall 2017 semester successfully."

            ElseIf (success = False) Then
                Button1.Hide()
                Button2.Hide()
                Button3.Show()
                Button4.Show()

                RichTextBox1.Hide()
                RichTextBox2.Show()
                RichTextBox2.Enabled = False

                RichTextBox2.Text = "This course could not be added because you are missing the " + prereq + ". Please complete this prerequisite or enroll in the prerequiste course in a semester prior to this semesters course offering."
            End If

        ElseIf (Chooseterm.term = "winter" And Chooseterm.fys) Then

            If Chooseterm.fyswc.Contains(coursemd) And Label2.Text = "CHY103 - General Chemistry I" Then
                Button1.Hide()
                Button2.Hide()
                Button3.Show()
                Button4.Show()

                RichTextBox1.Hide()
                RichTextBox2.Show()
                RichTextBox2.Enabled = False

                RichTextBox2.Text = "This course can not be added because there is a time conflict with the course  CPS209."

            ElseIf Chooseterm.fyswc.Contains(coursemd) And Label2.Text = "CPS209 - Computer Science II" Then
                Button1.Hide()
                Button2.Hide()
                Button3.Show()
                Button4.Show()

                RichTextBox1.Hide()
                RichTextBox2.Show()
                RichTextBox2.Enabled = False

                RichTextBox2.Text = "This course can not be added because there is a time conflict with the course  CHY103."

            Else
                success = True

                If Label2.Text = "CPS209 - Computer Science II" And Chooseterm.fysfc.Contains("CPS109 - Computer Science I") Then
                    success = True
                ElseIf Label2.Text = "CPS209 - Computer Science II" And Not Chooseterm.fysfc.Contains("CPS109 - Computer Science I") Then
                    success = False
                End If

                If Label2.Text = "MTH430 - Dynamic Systems: Differential Equations" Then
                    success = False
                End If

                If (success) Then

                    HomeForm.wcourse.Add(Label2.Text)

                    Chooseterm.fyswc.Add(Label2.Text)

                    Chooseterm.fyswc.Add(coursemd)
                    Chooseterm.fyswc.Add(courseprof)
                    Chooseterm.fyswc.Add(coursedate)
                    Chooseterm.fyswc.Add(courseroom)
                    Chooseterm.fyswc.Add("")

                    wlecname.Add(lec)
                    wlecdate.Add(lecday)
                    wstartlectime.Add(lecstime)
                    wendlectime.Add(lecetime)
                    wlecroom.Add(lecroom)

                    wlabname.Add(lab)
                    wlabdate.Add(labday)
                    wstartlabtime.Add(labstime)
                    wendlabtime.Add(labetime)
                    wlabroom.Add(labroom)

                    Button1.Hide()
                    Button2.Hide()
                    Button3.Show()
                    Button4.Show()

                    RichTextBox1.Hide()
                    RichTextBox2.Show()
                    RichTextBox2.Enabled = False

                    RichTextBox2.Text = "This course has been added to your winter 2018 semester successfully."

                ElseIf (success = False) Then
                    Button1.Hide()
                    Button2.Hide()
                    Button3.Show()
                    Button4.Show()

                    RichTextBox1.Hide()
                    RichTextBox2.Show()
                    RichTextBox2.Enabled = False

                    RichTextBox2.Text = "This course could not be added because you are missing the " + prereq + ". Please complete this prerequisite or enroll in the prerequiste course in a semester prior to this semesters course offering."
                End If

            End If

        End If



            ' SECOND YEAR STUDENT ADD 

            If (Chooseterm.term = "fall" And Chooseterm.sys) Then

                success = True

                If Label2.Text = "MTH430 - Dynamic Systems: Differential Equations" Then
                    success = False
                End If

                If (success) Then

                    HomeForm.fcourse.Add(Label2.Text)

                    Chooseterm.sysfc.Add(Label2.Text)

                    Chooseterm.sysfc.Add(coursemd)
                    Chooseterm.sysfc.Add(courseprof)
                    Chooseterm.sysfc.Add(coursedate)
                    Chooseterm.sysfc.Add(courseroom)
                    Chooseterm.sysfc.Add("")


                    sflecname.Add(lec)
                    sflecdate.Add(lecday)
                    sfstartlectime.Add(lecstime)
                    sfendlectime.Add(lecetime)
                    sflecroom.Add(lecroom)

                    sflabname.Add(lab)
                    sflabdate.Add(labday)
                    sfstartlabtime.Add(labstime)
                    sfendlabtime.Add(labetime)
                    sflabroom.Add(labroom)


                    Button1.Hide()
                    Button2.Hide()
                    Button3.Show()
                    Button4.Show()

                    RichTextBox1.Hide()
                    RichTextBox2.Show()
                    RichTextBox2.Enabled = False

                    RichTextBox2.Text = "This course has been added to your winter 2018 semester successfully."

                ElseIf (success = False) Then
                    Button1.Hide()
                    Button2.Hide()
                    Button3.Show()
                    Button4.Show()

                    RichTextBox1.Hide()
                    RichTextBox2.Show()
                    RichTextBox2.Enabled = False

                    RichTextBox2.Text = "This course could not be added because you are missing the (" + prereq + "). Please complete this prerequisite or enroll in the prerequiste course in a semester prior to this semesters course offering."
                End If

            ElseIf (Chooseterm.term = "winter" And Chooseterm.sys) Then
                success = True

                If Label2.Text = "MTH430 - Dynamic Systems: Differential Equations" Then
                    success = False
                End If

                If (success) Then

                    HomeForm.wcourse.Add(Label2.Text)

                    Chooseterm.syswc.Add(Label2.Text)

                    Chooseterm.syswc.Add(coursemd)
                    Chooseterm.syswc.Add(courseprof)
                    Chooseterm.syswc.Add(coursedate)
                    Chooseterm.syswc.Add(courseroom)
                    Chooseterm.syswc.Add("")


                    swlecname.Add(lec)
                    swlecdate.Add(lecday)
                    swstartlectime.Add(lecstime)
                    swendlectime.Add(lecetime)
                    swlecroom.Add(lecroom)

                    swlabname.Add(lab)
                    swlabdate.Add(labday)
                    swstartlabtime.Add(labstime)
                    swendlabtime.Add(labetime)
                    swlabroom.Add(labroom)

                    Button1.Hide()
                    Button2.Hide()
                    Button3.Show()
                    Button4.Show()

                    RichTextBox1.Hide()
                    RichTextBox2.Show()
                    RichTextBox2.Enabled = False

                    RichTextBox2.Text = "This course has been added to your winter 2018 semester successfully."

                ElseIf (success = False) Then
                    Button1.Hide()
                    Button2.Hide()
                    Button3.Show()
                    Button4.Show()

                    RichTextBox1.Hide()
                    RichTextBox2.Show()
                    RichTextBox2.Enabled = False

                    RichTextBox2.Text = "This course could not be added because you are missing the (" + prereq + "). Please complete this prerequisite or enroll in the prerequiste course in a semester prior to this semesters course offering."
                End If

            End If

    End Sub

    ' Go back to search
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If (search.s) Then
            search.s = False
            Dim searching As New search()
            Me.Hide()
            searching.Show()
        End If

        If (classoffered.co) Then
            classoffered.co = False
            Dim offered As New classoffered()
            Me.Hide()
            offered.Show()
        End If

    End Sub

    ' Add another class
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If (Button3.Text = "Swap Another Class") Then

            choosesearch.swapcourse = ""
            HomeForm.addcheck = False

            Dim swap As New choosesearch()
            Me.Hide()
            swap.Show()

        Else

            If (search.s) Then
                search.s = False
                Dim searching As New search()
                Me.Hide()
                searching.Show()
            End If

            If (classoffered.co) Then
                classoffered.co = False
                Dim offered As New classoffered()
                Me.Hide()
                offered.Show()
            End If

        End If

    End Sub


    ' SWAP COURSE 
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        If (Chooseterm.term = "fall" And Chooseterm.fys) Then

            If (choosesearch.swapcourse = "CPS109 - Computer Science I" And Chooseterm.fyswc.Contains("CPS209 - Computer Science II")) Then
                Button5.Enabled = False
                RichTextBox1.Hide()
                RichTextBox2.Show()
                RichTextBox2.Enabled = False

                RichTextBox2.Text = "The course (CPS109 - Computer Science I) can not swapped out because you are enrolled in the antirequisite (CPS209 - Computer Science II)"

            Else


                If Label2.Text = "MTH430 - Dynamic Systems: Differential Equations" Then
                    success = False
                End If

                If (success) Then

                    HomeForm.fcourse.Remove(choosesearch.swapcourse)

                    Chooseterm.fysfc.Remove(choosesearch.swapcourse)

                    Chooseterm.fysfc.Remove(add.swapcoursemd)
                    Chooseterm.fysfc.Remove(add.swapcourseprof)
                    Chooseterm.fysfc.Remove(add.swapcoursedate)
                    Chooseterm.fysfc.Remove(add.swapcourseroom)
                    Chooseterm.fysfc.Remove("")

                    HomeForm.fcourse.Add(Label2.Text)
                    Chooseterm.fysfc.Add(Label2.Text)

                    Chooseterm.fysfc.Add(coursemd)
                    Chooseterm.fysfc.Add(courseprof)
                    Chooseterm.fysfc.Add(coursedate)
                    Chooseterm.fysfc.Add(courseroom)
                    Chooseterm.fysfc.Add("")

                    For i As Integer = flecname.Count - 1 To 0 Step -1
                        ' MsgBox("i: " + i.ToString)
                        '  MsgBox(add.flecname.ToArray.Length)
                        '  MsgBox(add.flecname.ToArray.ElementAt(i))
                        ' MsgBox(add.flecname.ToArray.ElementAt(i).ToString)
                        ' MsgBox(choosesearch.dropcourse)
                        If ((add.flecname.ToArray.ElementAt(i).ToString = choosesearch.swapcourse)) Then
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

                    flecname.Add(lec)
                    flecdate.Add(lecday)
                    fstartlectime.Add(lecstime)
                    fendlectime.Add(lecetime)
                    flecroom.Add(lecroom)

                    flabname.Add(lab)
                    flabdate.Add(labday)
                    fstartlabtime.Add(labstime)
                    fendlabtime.Add(labetime)
                    flabroom.Add(labroom)

                    Button1.Hide()
                    Button2.Hide()
                    Button3.Text = "Swap Another Class"

                    Button3.Show()
                    Button4.Show()

                    Button5.Hide()

                    RichTextBox1.Hide()
                    RichTextBox2.Show()
                    RichTextBox2.Enabled = False

                    RichTextBox2.Text = "The course " + Label2.Text + " has been swapped with " + choosesearch.swapcourse + " into your fall 2017 semester successfully."


                ElseIf (success = False) Then
                    Button1.Hide()
                    Button2.Hide()

                    Button3.Text = "Swap Another Class"
                    Button3.Show()
                    Button4.Show()

                    Button5.Hide()


                    RichTextBox1.Hide()
                    RichTextBox2.Show()
                    RichTextBox2.Enabled = False

                    RichTextBox2.Text = "This course could not be swapped because you are missing the (" + prereq + "). Please complete this prerequisite or enroll in the prerequiste course in a semester prior to this semesters course offering."
                End If

                End If


        ElseIf (Chooseterm.term = "winter" And Chooseterm.fys) Then

                success = True

                If Label2.Text = "MTH430 - Dynamic Systems: Differential Equations" Then
                    success = False
                End If


                If (success) Then
                    HomeForm.wcourse.Remove(choosesearch.swapcourse)

                    Chooseterm.fyswc.Remove(choosesearch.swapcourse)

                    Chooseterm.fyswc.Remove(add.swapcoursemd)
                    Chooseterm.fyswc.Remove(add.swapcourseprof)
                    Chooseterm.fyswc.Remove(add.swapcoursedate)
                    Chooseterm.fyswc.Remove(add.swapcourseroom)
                    Chooseterm.fyswc.Remove("")

                    HomeForm.wcourse.Add(Label2.Text)

                    Chooseterm.fyswc.Add(Label2.Text)

                    Chooseterm.fyswc.Add(coursemd)
                    Chooseterm.fyswc.Add(courseprof)
                    Chooseterm.fyswc.Add(coursedate)
                    Chooseterm.fyswc.Add(courseroom)
                    Chooseterm.fyswc.Add("")


                    For i As Integer = add.wlecname.Count - 1 To 0 Step -1
                        ' MsgBox("i: " + i.ToString)
                        '  MsgBox(add.flecname.ToArray.Length)
                        '  MsgBox(add.flecname.ToArray.ElementAt(i))
                        ' MsgBox(add.flecname.ToArray.ElementAt(i).ToString)
                        ' MsgBox(choosesearch.dropcourse)
                        If ((add.wlecname.ToArray.ElementAt(i).ToString = choosesearch.swapcourse)) Then
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

                    wlecname.Add(lec)
                    wlecdate.Add(lecday)
                    wstartlectime.Add(lecstime)
                    wendlectime.Add(lecetime)
                    wlecroom.Add(lecroom)

                    wlabname.Add(lab)
                    wlabdate.Add(labday)
                    wstartlabtime.Add(labstime)
                    wendlabtime.Add(labetime)
                    wlabroom.Add(labroom)


                    Button1.Hide()
                    Button2.Hide()

                    Button3.Text = "Swap Another Class"
                    Button3.Show()
                    Button4.Show()

                    Button5.Hide()

                    RichTextBox1.Hide()
                    RichTextBox2.Show()
                    RichTextBox2.Enabled = False

                    RichTextBox2.Text = "The course (" + Label2.Text + ") has been swapped with (" + choosesearch.swapcourse + ") into your winter 2018 semester successfully."

                ElseIf (success = False) Then
                    Button1.Hide()
                    Button2.Hide()

                    Button3.Text = "Swap Another Class"
                    Button3.Show()
                    Button4.Show()

                    Button5.Hide()


                    RichTextBox1.Hide()
                    RichTextBox2.Show()
                    RichTextBox2.Enabled = False

                    RichTextBox2.Text = "This course could not be swapped because you are missing the (" + prereq + "). Please complete this prerequisite or enroll in the prerequiste course in a semester prior to this semesters course offering."
                End If


                'SECOND YEAR SWAP
        ElseIf (Chooseterm.term = "fall" And Chooseterm.sys) Then

                success = True

                If Label2.Text = "MTH430 - Dynamic Systems: Differential Equations" Then
                    success = False
                End If

                If (success) Then
                    HomeForm.fcourse.Remove(choosesearch.swapcourse)

                    Chooseterm.sysfc.Remove(choosesearch.swapcourse)

                    Chooseterm.sysfc.Remove(add.swapcoursemd)
                    Chooseterm.sysfc.Remove(add.swapcourseprof)
                    Chooseterm.sysfc.Remove(add.swapcoursedate)
                    Chooseterm.sysfc.Remove(add.swapcourseroom)
                    Chooseterm.sysfc.Remove("")

                    HomeForm.fcourse.Add(Label2.Text)
                    Chooseterm.sysfc.Add(Label2.Text)

                    Chooseterm.sysfc.Add(coursemd)
                    Chooseterm.sysfc.Add(courseprof)
                    Chooseterm.sysfc.Add(coursedate)
                    Chooseterm.sysfc.Add(courseroom)
                    Chooseterm.sysfc.Add("")


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

                    sflecname.Add(lec)
                    sflecdate.Add(lecday)
                    sfstartlectime.Add(lecstime)
                    sfendlectime.Add(lecetime)
                    sflecroom.Add(lecroom)

                    sflabname.Add(lab)
                    sflabdate.Add(labday)
                    sfstartlabtime.Add(labstime)
                    sfendlabtime.Add(labetime)
                    sflabroom.Add(labroom)

                    Button1.Hide()
                    Button2.Hide()

                    Button3.Text = "Swap Another Class"
                    Button3.Show()
                    Button4.Show()

                    Button5.Hide()


                    RichTextBox1.Hide()
                    RichTextBox2.Show()
                    RichTextBox2.Enabled = False

                    RichTextBox2.Text = "The course " + Label2.Text + " has been swapped with " + choosesearch.swapcourse + " into your fall 2017 semester successfully."

                ElseIf (success = False) Then
                    Button1.Hide()
                    Button2.Hide()

                    Button3.Text = "Swap Another Class"
                    Button3.Show()
                    Button4.Show()

                    Button5.Hide()


                    RichTextBox1.Hide()
                    RichTextBox2.Show()
                    RichTextBox2.Enabled = False

                    RichTextBox2.Text = "This course could not be swapped because you are missing the (" + prereq + "). Please complete this prerequisite or enroll in the prerequiste course in a semester prior to this semesters course offering."
                End If

        ElseIf (Chooseterm.term = "winter" And Chooseterm.sys) Then



                success = True

                If Label2.Text = "MTH430 - Dynamic Systems: Differential Equations" Then
                    success = False
                End If

                If (success) Then
                    HomeForm.wcourse.Remove(choosesearch.swapcourse)

                    Chooseterm.syswc.Remove(choosesearch.swapcourse)

                    Chooseterm.syswc.Remove(add.swapcoursemd)
                    Chooseterm.syswc.Remove(add.swapcourseprof)
                    Chooseterm.syswc.Remove(add.swapcoursedate)
                    Chooseterm.syswc.Remove(add.swapcourseroom)
                    Chooseterm.syswc.Remove("")

                    HomeForm.wcourse.Add(Label2.Text)

                    Chooseterm.syswc.Add(Label2.Text)

                    Chooseterm.syswc.Add(coursemd)
                    Chooseterm.syswc.Add(courseprof)
                    Chooseterm.syswc.Add(coursedate)
                    Chooseterm.syswc.Add(courseroom)
                    Chooseterm.syswc.Add("")


                    For i As Integer = add.swlecname.Count - 1 To 0 Step -1
                        ' MsgBox("i: " + i.ToString)
                        '  MsgBox(add.flecname.ToArray.Length)
                        '  MsgBox(add.flecname.ToArray.ElementAt(i))
                        ' MsgBox(add.flecname.ToArray.ElementAt(i).ToString)
                        ' MsgBox(choosesearch.dropcourse)
                        If ((add.swlecname.ToArray.ElementAt(i).ToString = choosesearch.swapcourse)) Then
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

                    swlecname.Add(lec)
                    swlecdate.Add(lecday)
                    swstartlectime.Add(lecstime)
                    swendlectime.Add(lecetime)
                    swlecroom.Add(lecroom)

                    swlabname.Add(lab)
                    swlabdate.Add(labday)
                    swstartlabtime.Add(labstime)
                    swendlabtime.Add(labetime)
                    swlabroom.Add(labroom)

                    Button1.Hide()
                    Button2.Hide()

                    Button3.Text = "Swap Another Class"
                    Button3.Show()
                    Button4.Show()

                    Button5.Hide()


                    RichTextBox1.Hide()
                    RichTextBox2.Show()
                    RichTextBox2.Enabled = False

                    RichTextBox2.Text = "The course (" + Label2.Text + ") has been swapped with (" + choosesearch.swapcourse + ") into your winter 2018 semester successfully."


                ElseIf (success = False) Then
                    Button1.Hide()
                    Button2.Hide()

                    Button3.Text = "Swap Another Class"
                    Button3.Show()
                    Button4.Show()

                    Button5.Hide()

                    RichTextBox1.Hide()
                    RichTextBox2.Show()
                    RichTextBox2.Enabled = False

                    RichTextBox2.Text = "This course could not be swapped because you are missing the (" + prereq + "). Please complete this prerequisite or enroll in the prerequiste course in a semester prior to this semesters course offering."
                End If

        End If

    End Sub

    ' Go back to account page
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim account As New HomeForm()
        Me.Hide()
        account.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim home As New HomeForm()
        Me.Hide()
        home.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim chooseterm As New Chooseterm()
        Me.Hide()
        chooseterm.Show()
    End Sub

End Class