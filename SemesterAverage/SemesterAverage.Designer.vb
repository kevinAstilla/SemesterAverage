<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterGrades
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lbCourseOne = New System.Windows.Forms.Label()
        Me.tbCourseOne = New System.Windows.Forms.TextBox()
        Me.tbCourseTwo = New System.Windows.Forms.TextBox()
        Me.lbLetterGradeOne = New System.Windows.Forms.Label()
        Me.lbCourseTwo = New System.Windows.Forms.Label()
        Me.lbLetterGradeTwo = New System.Windows.Forms.Label()
        Me.lbCourseThree = New System.Windows.Forms.Label()
        Me.lbLetterGradeThree = New System.Windows.Forms.Label()
        Me.lbCourseFour = New System.Windows.Forms.Label()
        Me.lbLetterGradeFour = New System.Windows.Forms.Label()
        Me.lbCourseFive = New System.Windows.Forms.Label()
        Me.lbLetterGradeFive = New System.Windows.Forms.Label()
        Me.lbCourseSix = New System.Windows.Forms.Label()
        Me.lbLetterGradeSix = New System.Windows.Forms.Label()
        Me.lbSemester = New System.Windows.Forms.Label()
        Me.lbLetterGradeSemester = New System.Windows.Forms.Label()
        Me.tbCourseThree = New System.Windows.Forms.TextBox()
        Me.tbCourseFour = New System.Windows.Forms.TextBox()
        Me.tbCourseFive = New System.Windows.Forms.TextBox()
        Me.tbCourseSix = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbSemesterAverage = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lbCourseOne
        '
        Me.lbCourseOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbCourseOne.Location = New System.Drawing.Point(82, 61)
        Me.lbCourseOne.Name = "lbCourseOne"
        Me.lbCourseOne.Size = New System.Drawing.Size(70, 23)
        Me.lbCourseOne.TabIndex = 0
        Me.lbCourseOne.Text = "Course &1:"
        Me.lbCourseOne.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbCourseOne
        '
        Me.tbCourseOne.Location = New System.Drawing.Point(164, 61)
        Me.tbCourseOne.Name = "tbCourseOne"
        Me.tbCourseOne.Size = New System.Drawing.Size(100, 22)
        Me.tbCourseOne.TabIndex = 1
        Me.tbCourseOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip.SetToolTip(Me.tbCourseOne, "Student's grade for the first course")
        '
        'tbCourseTwo
        '
        Me.tbCourseTwo.Location = New System.Drawing.Point(164, 93)
        Me.tbCourseTwo.Name = "tbCourseTwo"
        Me.tbCourseTwo.Size = New System.Drawing.Size(100, 22)
        Me.tbCourseTwo.TabIndex = 4
        Me.tbCourseTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip.SetToolTip(Me.tbCourseTwo, "Student's grade for the second course")
        '
        'lbLetterGradeOne
        '
        Me.lbLetterGradeOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbLetterGradeOne.Location = New System.Drawing.Point(275, 61)
        Me.lbLetterGradeOne.Name = "lbLetterGradeOne"
        Me.lbLetterGradeOne.Size = New System.Drawing.Size(100, 23)
        Me.lbLetterGradeOne.TabIndex = 2
        Me.lbLetterGradeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.lbLetterGradeOne, "Displays student's letter grade")
        '
        'lbCourseTwo
        '
        Me.lbCourseTwo.Location = New System.Drawing.Point(83, 94)
        Me.lbCourseTwo.Name = "lbCourseTwo"
        Me.lbCourseTwo.Size = New System.Drawing.Size(70, 23)
        Me.lbCourseTwo.TabIndex = 3
        Me.lbCourseTwo.Text = "Course &2:"
        Me.lbCourseTwo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbLetterGradeTwo
        '
        Me.lbLetterGradeTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbLetterGradeTwo.Location = New System.Drawing.Point(275, 92)
        Me.lbLetterGradeTwo.Name = "lbLetterGradeTwo"
        Me.lbLetterGradeTwo.Size = New System.Drawing.Size(100, 23)
        Me.lbLetterGradeTwo.TabIndex = 5
        Me.lbLetterGradeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.lbLetterGradeTwo, "Displays student's letter grade")
        '
        'lbCourseThree
        '
        Me.lbCourseThree.Location = New System.Drawing.Point(83, 125)
        Me.lbCourseThree.Name = "lbCourseThree"
        Me.lbCourseThree.Size = New System.Drawing.Size(70, 23)
        Me.lbCourseThree.TabIndex = 6
        Me.lbCourseThree.Text = "Course &3:"
        Me.lbCourseThree.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbLetterGradeThree
        '
        Me.lbLetterGradeThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbLetterGradeThree.Location = New System.Drawing.Point(275, 123)
        Me.lbLetterGradeThree.Name = "lbLetterGradeThree"
        Me.lbLetterGradeThree.Size = New System.Drawing.Size(100, 23)
        Me.lbLetterGradeThree.TabIndex = 8
        Me.lbLetterGradeThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.lbLetterGradeThree, "Displays student's letter grade")
        '
        'lbCourseFour
        '
        Me.lbCourseFour.Location = New System.Drawing.Point(83, 156)
        Me.lbCourseFour.Name = "lbCourseFour"
        Me.lbCourseFour.Size = New System.Drawing.Size(70, 23)
        Me.lbCourseFour.TabIndex = 9
        Me.lbCourseFour.Text = "Course &4:"
        Me.lbCourseFour.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbLetterGradeFour
        '
        Me.lbLetterGradeFour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbLetterGradeFour.Location = New System.Drawing.Point(275, 154)
        Me.lbLetterGradeFour.Name = "lbLetterGradeFour"
        Me.lbLetterGradeFour.Size = New System.Drawing.Size(100, 23)
        Me.lbLetterGradeFour.TabIndex = 11
        Me.lbLetterGradeFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.lbLetterGradeFour, "Displays student's letter grade")
        '
        'lbCourseFive
        '
        Me.lbCourseFive.Location = New System.Drawing.Point(83, 187)
        Me.lbCourseFive.Name = "lbCourseFive"
        Me.lbCourseFive.Size = New System.Drawing.Size(70, 23)
        Me.lbCourseFive.TabIndex = 12
        Me.lbCourseFive.Text = "Course &5:"
        Me.lbCourseFive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbLetterGradeFive
        '
        Me.lbLetterGradeFive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbLetterGradeFive.Location = New System.Drawing.Point(275, 185)
        Me.lbLetterGradeFive.Name = "lbLetterGradeFive"
        Me.lbLetterGradeFive.Size = New System.Drawing.Size(100, 23)
        Me.lbLetterGradeFive.TabIndex = 14
        Me.lbLetterGradeFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.lbLetterGradeFive, "Displays student's letter grade")
        '
        'lbCourseSix
        '
        Me.lbCourseSix.Location = New System.Drawing.Point(83, 218)
        Me.lbCourseSix.Name = "lbCourseSix"
        Me.lbCourseSix.Size = New System.Drawing.Size(70, 23)
        Me.lbCourseSix.TabIndex = 15
        Me.lbCourseSix.Text = "Course &6:"
        Me.lbCourseSix.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbLetterGradeSix
        '
        Me.lbLetterGradeSix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbLetterGradeSix.Location = New System.Drawing.Point(275, 216)
        Me.lbLetterGradeSix.Name = "lbLetterGradeSix"
        Me.lbLetterGradeSix.Size = New System.Drawing.Size(100, 23)
        Me.lbLetterGradeSix.TabIndex = 17
        Me.lbLetterGradeSix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.lbLetterGradeSix, "Displays student's letter grade")
        '
        'lbSemester
        '
        Me.lbSemester.Location = New System.Drawing.Point(81, 249)
        Me.lbSemester.Name = "lbSemester"
        Me.lbSemester.Size = New System.Drawing.Size(70, 23)
        Me.lbSemester.TabIndex = 18
        Me.lbSemester.Text = "&Semester:"
        Me.lbSemester.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbLetterGradeSemester
        '
        Me.lbLetterGradeSemester.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbLetterGradeSemester.Location = New System.Drawing.Point(275, 247)
        Me.lbLetterGradeSemester.Name = "lbLetterGradeSemester"
        Me.lbLetterGradeSemester.Size = New System.Drawing.Size(100, 23)
        Me.lbLetterGradeSemester.TabIndex = 20
        Me.lbLetterGradeSemester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.lbLetterGradeSemester, "Displays student's letter grade for the semester average")
        '
        'tbCourseThree
        '
        Me.tbCourseThree.Location = New System.Drawing.Point(164, 123)
        Me.tbCourseThree.Name = "tbCourseThree"
        Me.tbCourseThree.Size = New System.Drawing.Size(100, 22)
        Me.tbCourseThree.TabIndex = 7
        Me.tbCourseThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip.SetToolTip(Me.tbCourseThree, "Student's grade for the third course")
        '
        'tbCourseFour
        '
        Me.tbCourseFour.Location = New System.Drawing.Point(164, 154)
        Me.tbCourseFour.Name = "tbCourseFour"
        Me.tbCourseFour.Size = New System.Drawing.Size(100, 22)
        Me.tbCourseFour.TabIndex = 10
        Me.tbCourseFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip.SetToolTip(Me.tbCourseFour, "Student's grade for the fourth course")
        '
        'tbCourseFive
        '
        Me.tbCourseFive.Location = New System.Drawing.Point(164, 185)
        Me.tbCourseFive.Name = "tbCourseFive"
        Me.tbCourseFive.Size = New System.Drawing.Size(100, 22)
        Me.tbCourseFive.TabIndex = 13
        Me.tbCourseFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip.SetToolTip(Me.tbCourseFive, "Student's grade for the fifth course")
        '
        'tbCourseSix
        '
        Me.tbCourseSix.Location = New System.Drawing.Point(164, 216)
        Me.tbCourseSix.Name = "tbCourseSix"
        Me.tbCourseSix.Size = New System.Drawing.Size(100, 22)
        Me.tbCourseSix.TabIndex = 16
        Me.tbCourseSix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip.SetToolTip(Me.tbCourseSix, "Student's grade for the sixth course")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(52, 493)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(99, 32)
        Me.btnCalculate.TabIndex = 22
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTip.SetToolTip(Me.btnCalculate, "Calculates the average for the semester")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(174, 493)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(99, 32)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "&Reset"
        Me.ToolTip.SetToolTip(Me.btnReset, "Clears the inputs in the program")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(296, 493)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 32)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "&Exit"
        Me.ToolTip.SetToolTip(Me.btnExit, "Ends the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbSemesterAverage
        '
        Me.lbSemesterAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSemesterAverage.Location = New System.Drawing.Point(164, 247)
        Me.lbSemesterAverage.Name = "lbSemesterAverage"
        Me.lbSemesterAverage.Size = New System.Drawing.Size(100, 23)
        Me.lbSemesterAverage.TabIndex = 19
        Me.lbSemesterAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.lbSemesterAverage, "Student's average grade for the semester")
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(85, 280)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(290, 192)
        Me.lblResult.TabIndex = 21
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSemesterGrades
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(454, 556)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lbSemesterAverage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.tbCourseSix)
        Me.Controls.Add(Me.tbCourseFive)
        Me.Controls.Add(Me.tbCourseFour)
        Me.Controls.Add(Me.tbCourseThree)
        Me.Controls.Add(Me.lbLetterGradeSemester)
        Me.Controls.Add(Me.lbSemester)
        Me.Controls.Add(Me.lbLetterGradeSix)
        Me.Controls.Add(Me.lbCourseSix)
        Me.Controls.Add(Me.lbLetterGradeFive)
        Me.Controls.Add(Me.lbCourseFive)
        Me.Controls.Add(Me.lbLetterGradeFour)
        Me.Controls.Add(Me.lbCourseFour)
        Me.Controls.Add(Me.lbLetterGradeThree)
        Me.Controls.Add(Me.lbCourseThree)
        Me.Controls.Add(Me.lbLetterGradeTwo)
        Me.Controls.Add(Me.lbCourseTwo)
        Me.Controls.Add(Me.lbLetterGradeOne)
        Me.Controls.Add(Me.tbCourseTwo)
        Me.Controls.Add(Me.tbCourseOne)
        Me.Controls.Add(Me.lbCourseOne)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemesterGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbCourseOne As Label
    Friend WithEvents tbCourseOne As TextBox
    Friend WithEvents tbCourseTwo As TextBox
    Friend WithEvents lbLetterGradeOne As Label
    Friend WithEvents lbCourseTwo As Label
    Friend WithEvents lbLetterGradeTwo As Label
    Friend WithEvents lbCourseThree As Label
    Friend WithEvents lbLetterGradeThree As Label
    Friend WithEvents lbCourseFour As Label
    Friend WithEvents lbLetterGradeFour As Label
    Friend WithEvents lbCourseFive As Label
    Friend WithEvents lbLetterGradeFive As Label
    Friend WithEvents lbCourseSix As Label
    Friend WithEvents lbLetterGradeSix As Label
    Friend WithEvents lbSemester As Label
    Friend WithEvents lbLetterGradeSemester As Label
    Friend WithEvents tbCourseThree As TextBox
    Friend WithEvents tbCourseFour As TextBox
    Friend WithEvents tbCourseFive As TextBox
    Friend WithEvents tbCourseSix As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbSemesterAverage As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents ToolTip As ToolTip
End Class
