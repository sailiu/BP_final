<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Semester = New System.Windows.Forms.Label()
        Me.ltear = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.semestersel = New System.Windows.Forms.ComboBox()
        Me.yearsel = New System.Windows.Forms.ComboBox()
        Me.deptsel = New System.Windows.Forms.ComboBox()
        Me.numbertxt = New System.Windows.Forms.TextBox()
        Me.coursenametxt = New System.Windows.Forms.TextBox()
        Me.semsel = New System.Windows.Forms.ComboBox()
        Me.gradesel = New System.Windows.Forms.ComboBox()
        Me.majorsel = New System.Windows.Forms.ComboBox()
        Me.retakesel = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.listbox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.majorl = New System.Windows.Forms.Label()
        Me.overall = New System.Windows.Forms.Label()
        Me.major = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(400, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MY COLLEGE COURSES"
        '
        'Semester
        '
        Me.Semester.AutoSize = True
        Me.Semester.Location = New System.Drawing.Point(37, 62)
        Me.Semester.Name = "Semester"
        Me.Semester.Size = New System.Drawing.Size(53, 12)
        Me.Semester.TabIndex = 1
        Me.Semester.Text = "Semester"
        '
        'ltear
        '
        Me.ltear.AutoSize = True
        Me.ltear.Location = New System.Drawing.Point(120, 62)
        Me.ltear.Name = "ltear"
        Me.ltear.Size = New System.Drawing.Size(29, 12)
        Me.ltear.TabIndex = 2
        Me.ltear.Text = "Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dept"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(253, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(385, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Course Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(542, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Sem Hrs"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(629, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 12)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Grade"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(687, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 12)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Major Course"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(792, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 12)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Course Retake"
        '
        'semestersel
        '
        Me.semestersel.FormattingEnabled = True
        Me.semestersel.Items.AddRange(New Object() {"Fall"})
        Me.semestersel.Location = New System.Drawing.Point(39, 90)
        Me.semestersel.Name = "semestersel"
        Me.semestersel.Size = New System.Drawing.Size(51, 20)
        Me.semestersel.TabIndex = 10
        '
        'yearsel
        '
        Me.yearsel.FormattingEnabled = True
        Me.yearsel.Items.AddRange(New Object() {"2013", "2014", "2015"})
        Me.yearsel.Location = New System.Drawing.Point(110, 90)
        Me.yearsel.Name = "yearsel"
        Me.yearsel.Size = New System.Drawing.Size(51, 20)
        Me.yearsel.TabIndex = 11
        '
        'deptsel
        '
        Me.deptsel.FormattingEnabled = True
        Me.deptsel.Items.AddRange(New Object() {"ACCT", "MSCI", "MGMT", "MKTG", "FIN", "ECON"})
        Me.deptsel.Location = New System.Drawing.Point(180, 90)
        Me.deptsel.Name = "deptsel"
        Me.deptsel.Size = New System.Drawing.Size(51, 20)
        Me.deptsel.TabIndex = 12
        '
        'numbertxt
        '
        Me.numbertxt.Location = New System.Drawing.Point(246, 89)
        Me.numbertxt.Name = "numbertxt"
        Me.numbertxt.Size = New System.Drawing.Size(65, 21)
        Me.numbertxt.TabIndex = 13
        '
        'coursenametxt
        '
        Me.coursenametxt.Location = New System.Drawing.Point(335, 89)
        Me.coursenametxt.Name = "coursenametxt"
        Me.coursenametxt.Size = New System.Drawing.Size(190, 21)
        Me.coursenametxt.TabIndex = 14
        '
        'semsel
        '
        Me.semsel.FormattingEnabled = True
        Me.semsel.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.semsel.Location = New System.Drawing.Point(538, 89)
        Me.semsel.Name = "semsel"
        Me.semsel.Size = New System.Drawing.Size(51, 20)
        Me.semsel.TabIndex = 15
        '
        'gradesel
        '
        Me.gradesel.FormattingEnabled = True
        Me.gradesel.Items.AddRange(New Object() {"A+", "A", "A- ", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F"})
        Me.gradesel.Location = New System.Drawing.Point(622, 89)
        Me.gradesel.Name = "gradesel"
        Me.gradesel.Size = New System.Drawing.Size(51, 20)
        Me.gradesel.TabIndex = 16
        '
        'majorsel
        '
        Me.majorsel.FormattingEnabled = True
        Me.majorsel.Items.AddRange(New Object() {"Yes", "No"})
        Me.majorsel.Location = New System.Drawing.Point(689, 89)
        Me.majorsel.Name = "majorsel"
        Me.majorsel.Size = New System.Drawing.Size(75, 20)
        Me.majorsel.TabIndex = 17
        '
        'retakesel
        '
        Me.retakesel.FormattingEnabled = True
        Me.retakesel.Items.AddRange(New Object() {"Yes", "No"})
        Me.retakesel.Location = New System.Drawing.Point(794, 89)
        Me.retakesel.Name = "retakesel"
        Me.retakesel.Size = New System.Drawing.Size(81, 20)
        Me.retakesel.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(903, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(122, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "By Chronology"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(340, 140)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "By Department"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(557, 140)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 23)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Major Courses"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(759, 140)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(116, 23)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Retaken Course"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(903, 140)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "Clear"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'listbox
        '
        Me.listbox.Location = New System.Drawing.Point(39, 205)
        Me.listbox.Multiline = True
        Me.listbox.Name = "listbox"
        Me.listbox.Size = New System.Drawing.Size(836, 305)
        Me.listbox.TabIndex = 25
        Me.listbox.Text = "Gradevbtab Sem    Year    Dept    Num    Sem Hrs    Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(903, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 12)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Overall GPA"
        '
        'majorl
        '
        Me.majorl.AutoSize = True
        Me.majorl.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.majorl.Location = New System.Drawing.Point(901, 304)
        Me.majorl.Name = "majorl"
        Me.majorl.Size = New System.Drawing.Size(68, 12)
        Me.majorl.TabIndex = 27
        Me.majorl.Text = "Major GPA"
        '
        'overall
        '
        Me.overall.AutoSize = True
        Me.overall.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.overall.ForeColor = System.Drawing.Color.Maroon
        Me.overall.Location = New System.Drawing.Point(903, 263)
        Me.overall.Name = "overall"
        Me.overall.Size = New System.Drawing.Size(26, 12)
        Me.overall.TabIndex = 28
        Me.overall.Text = "3.6"
        '
        'major
        '
        Me.major.AutoSize = True
        Me.major.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.major.ForeColor = System.Drawing.Color.Maroon
        Me.major.Location = New System.Drawing.Point(903, 339)
        Me.major.Name = "major"
        Me.major.Size = New System.Drawing.Size(26, 12)
        Me.major.TabIndex = 29
        Me.major.Text = "3.6"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 535)
        Me.Controls.Add(Me.major)
        Me.Controls.Add(Me.overall)
        Me.Controls.Add(Me.majorl)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.listbox)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.retakesel)
        Me.Controls.Add(Me.majorsel)
        Me.Controls.Add(Me.gradesel)
        Me.Controls.Add(Me.semsel)
        Me.Controls.Add(Me.coursenametxt)
        Me.Controls.Add(Me.numbertxt)
        Me.Controls.Add(Me.deptsel)
        Me.Controls.Add(Me.yearsel)
        Me.Controls.Add(Me.semestersel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ltear)
        Me.Controls.Add(Me.Semester)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "My Courses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Semester As System.Windows.Forms.Label
    Friend WithEvents ltear As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents semestersel As System.Windows.Forms.ComboBox
    Friend WithEvents yearsel As System.Windows.Forms.ComboBox
    Friend WithEvents deptsel As System.Windows.Forms.ComboBox
    Friend WithEvents numbertxt As System.Windows.Forms.TextBox
    Friend WithEvents coursenametxt As System.Windows.Forms.TextBox
    Friend WithEvents semsel As System.Windows.Forms.ComboBox
    Friend WithEvents gradesel As System.Windows.Forms.ComboBox
    Friend WithEvents majorsel As System.Windows.Forms.ComboBox
    Friend WithEvents retakesel As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Protected WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents listbox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents majorl As System.Windows.Forms.Label
    Friend WithEvents overall As System.Windows.Forms.Label
    Friend WithEvents major As System.Windows.Forms.Label

End Class
