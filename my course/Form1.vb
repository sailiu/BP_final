Public Class Form1
    Private cList(100) As Course
    Private length As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If semestersel.Text = "" Then
            MsgBox("Please select semester")
        ElseIf yearsel.Text = "" Then
            MsgBox("Please select year")
        ElseIf deptsel.Text = "" Then
            MsgBox("Please select a department")
        ElseIf numbertxt.Text = "" Then
            MsgBox("Please enter the number")
        ElseIf Len(numbertxt.Text) <> 4 Then
            MsgBox("The number must be 4 digits")
        ElseIf coursenametxt.Text = "" Then
            MsgBox("please enter the course name")
        ElseIf semsel.Text = "" Then
            MsgBox("Please select semester hour")
        ElseIf gradesel.Text = "" Then
            MsgBox("Please select grade")
        ElseIf majorsel.Text = "" Then
            MsgBox("Please select major course")
        ElseIf retakesel.Text = "" Then
            MsgBox("Please select course retake")
        Else
            Dim c As New Course
            c.semester = semestersel.Text
            c.year = Int(yearsel.Text)
            c.dept = deptsel.Text
            c.number = numbertxt.Text
            c.courseName = coursenametxt.Text
            c.semhrs = semsel.Text
            c.grade = gradesel.Text
            c.majorcourse = majorsel.Text
            c.courseretake = retakesel.Text
            cList(length) = c
            length = length + 1
            Dim line As String
            line = c.grade & vbTab & c.semester & vbTab & c.year & vbTab & c.dept & vbTab
            line = line & c.number & vbTab & c.semhrs & vbTab & vbTab & c.courseName & vbCrLf
            listbox.Text = listbox.Text & line
            saveCourse()
            Call calOverall()
            Call calMajor()

        End If
    End Sub
    Private Sub saveCourse()
        Dim i As Integer
        Dim write As New System.IO.StreamWriter("data.txt", False, System.Text.Encoding.Default)
        For i = 0 To length - 1
            Dim c As Course = cList(i)
            Dim line As String
            line = c.semester & ";" & c.year & ";" & c.dept & ";" & c.number & ";" & c.courseName
            line = line & ";" & c.semhrs & ";" & c.grade & ";" & c.majorcourse & ";" & c.courseretake
            write.WriteLine(line)
        Next
        write.Close()
    End Sub
    Private Sub loadCourse()

        Dim read As New System.IO.StreamReader("data.txt", System.Text.Encoding.Default)
        Dim line As String
        length = 0

        Do While Not read.EndOfStream
            line = read.ReadLine
            Dim values() As String = line.Split(CChar(";"))

            Dim c As New Course
            c.semester = values(0)
            c.year = Int(values(1))
            c.dept = values(2)
            c.number = values(3)
            c.courseName = values(4)
            c.semhrs = values(5)
            c.grade = values(6)
            c.majorcourse = values(7)
            c.courseretake = values(8)
            Dim l As String
            l = c.grade & vbTab & c.semester & vbTab & c.year & vbTab & c.dept & vbTab
            l = l & c.number & vbTab & c.semhrs & vbTab & vbTab & c.courseName & vbCrLf
            listbox.Text = listbox.Text & l
            cList(length) = c
            length = length + 1
        Loop
        read.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim line As String = "Grade" & vbTab & "Sem" & vbTab & "Year" & vbTab & "Dept" & vbTab & "Num" & vbTab & "Sem Hrs" & vbTab & vbTab & "Name" & vbCrLf
        listbox.Text = line
        overall.Text = ""
        major.Text = ""
        Call loadCourse()
        Call calOverall()
        Call calMajor()

    End Sub

    Private Function getGPA(gradesel As String) As Double

        If gradesel = "A+" Then
            getGPA = 4.33
        ElseIf gradesel = "A" Then
            getGPA = 4.0
        ElseIf gradesel = "A-" Then
            getGPA = 3.67
        ElseIf gradesel = "B+" Then
            getGPA = 3.33
        ElseIf gradesel = "B" Then
            getGPA = 3.0
        ElseIf gradesel = "B-" Then
            getGPA = 2.67
        ElseIf gradesel = "C+" Then
            getGPA = 2.33
        ElseIf gradesel = "C" Then
            getGPA = 2.0
        ElseIf gradesel = "C-" Then
            getGPA = 1.67
        ElseIf gradesel = "D+" Then
            getGPA = 1.33
        ElseIf gradesel = "D" Then
            getGPA = 1.0
        ElseIf gradesel = "D-" Then
            getGPA = 0.67
        ElseIf gradesel = "F" Then
            getGPA = 0
        Else
            getGPA = 0
        End If
    End Function

    Private Sub calMajor()

        major.Text = ""
        Dim i As Integer
        Dim ret As Double
        Dim c As Integer

        ret = 0
        c = 0
        For i = 0 To length - 1
            If cList(i).majorcourse = "Yes" Then
                ret = ret + getGPA(cList(i).grade)
                c = c + 1
            End If
        Next
        major.Text = Str(Format(ret / c, ".0"))
    End Sub

    Private Sub calOverall()
        overall.Text = ""
        Dim i As Integer
        Dim ret As Double

        ret = 0
        For i = 0 To length - 1
            ret = ret + getGPA(cList(i).grade)
        Next
        overall.Text = Str(Format(ret / length, ".0"))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        length = 0
        saveCourse()
    End Sub
End Class

Public Class Course
    Public semester As String
    Public year As Integer
    Public dept As String
    Public number As String
    Public courseName As String
    Public semhrs As Integer
    Public grade As String
    Public majorcourse As String
    Public courseretake As String

End Class
