'/****************************** Module Header ******************************\
'Module Name : SemesterAverage.vb
'Project: Lab 2 Semester Average
'Copyright (c) Kevin Astilla
'Date Modified: February , 2018

'this program is designed to calculate the students semester average 
'by using the other six courses of the studend, an appropriate grade letter
'is also provided for every grade given

'THIS CODE And INFORMATION Is PROVIDED "AS IS" WITHOUT WARRANTY Of ANY KIND,
'EITHER EXPRESSED Or IMPLIED, INCLUDING BUT Not LIMITED To THE IMPLIED
'WARRANTIES OF MERCHANTABILITY And/Or FITNESS FOR A PARTICULAR PURPOSE.
'\*****************************************************************

Option Strict On
Public Class frmSemesterGrades
    Private grades(5) As Double

    ''' <summary> LetterGrade(Double)
    ''' the private funtion LetterGrade takes in the double 
    ''' grade and works through a series of if elseif statements
    ''' to find the appropirate letter grade
    ''' the elseif chain starts with the lowest number working its
    ''' way to 100. once the appropriate letter grade mathces
    ''' the string is assigned and then returned to the call
    ''' </summary>
    ''' <param name="studentGrade"></param>
    ''' <returns></returns>
    Private Function LetterGrade(studentGrade As Double) As String
        Dim letterGradeEquivalent As String = ""
        'think of a way to convert or to either use if elses
        If (studentGrade < 50) Then
            letterGradeEquivalent = "F"
        ElseIf (studentGrade < 53) Then
            letterGradeEquivalent = "D-"
        ElseIf (studentGrade < 57) Then
            letterGradeEquivalent = "D"
        ElseIf (studentGrade < 60) Then
            letterGradeEquivalent = "D+"
        ElseIf (studentGrade < 63) Then
            letterGradeEquivalent = "C-"
        ElseIf (studentGrade < 67) Then
            letterGradeEquivalent = "C"
        ElseIf (studentGrade < 70) Then
            letterGradeEquivalent = "C+"
        ElseIf (studentGrade < 73) Then
            letterGradeEquivalent = "B-"
        ElseIf (studentGrade < 77) Then
            letterGradeEquivalent = "B"
        ElseIf (studentGrade < 80) Then
            letterGradeEquivalent = "B+"
        ElseIf (studentGrade < 85) Then
            letterGradeEquivalent = "A-"
        ElseIf (studentGrade < 90) Then
            letterGradeEquivalent = "A"
        ElseIf (studentGrade <= 100) Then
            letterGradeEquivalent = "A+"
        End If

        Return letterGradeEquivalent

    End Function


    ''' <summary>
    ''' this subroutine is programed to reset the texbox and labels in the form
    ''' </summary>
    Private Sub ResetForm()

        'this loof Is desined that it will go through for both texbox And labels in the 
        'Form.and If does come across it. it will clear the string as empty
        'for labels, it will only clear ir it has a fixed3d border which implies
        'that is is an output label
        For Each controlBox As Object In Me.Controls
            If (TypeOf (controlBox) Is TextBox) Then
                CType(controlBox, TextBox).Text = String.Empty

            ElseIf (TypeOf (controlBox) Is Label) Then
                If (CType(controlBox, Label).BorderStyle = BorderStyle.Fixed3D) Then
                    CType(controlBox, Label).Text = String.Empty
                End If
            End If
        Next
        'this loop renders the array empty 
        For index As Integer = 0 To 5
            grades(index) = 0
        Next

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim semesterAverage As Double

        'once the user presses enter or clicks calculate
        'the code goes through a loop doing the calculations for the average 
        'for the semester
        For course As Integer = 0 To 5
                semesterAverage += grades(course) / grades.Length()
            Next course

        'once the semester average has been calculated
        'it is then displayed in the textbox and then 
        'the function for the letterGrade is called as well
        lbSemesterAverage.Text = semesterAverage.ToString("N2")
        lbLetterGradeSemester.Text = LetterGrade(semesterAverage)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'once the player presses the exit button
        'the program closes evetything in the form
        Me.Close()
    End Sub


    ''' <summary>leave even
    ''' the next three event has the same functionalities but the explanation is in tbCourseOne
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tbCourseOne_Leave(sender As Object, e As EventArgs) Handles tbCourseOne.Leave
        Dim inputCheck As Double

        'the first validation is to check if it is a double
        'if it is the number is store of not a message is displayed
        'it also auto selects all whenever there is an error in the validation
        If (Not Double.TryParse(tbCourseOne.Text, inputCheck)) Then
            lblResult.Text = "Please enter a valid grade number"
            tbCourseOne.Focus()
            tbCourseOne.SelectAll()

            'this part validated whether the grade is in the range of 0 to 100
        ElseIf (inputCheck < 0 Or inputCheck > 100) Then
            lblResult.Text = "Please enter a grade from 0 to 100"
            tbCourseOne.Focus()
            tbCourseOne.SelectAll()

            'lastly once everything is in place the number is stored to its 
            'respective slot and then the appropriate letter grade is given
            'by the LetterGrade function
        Else
            grades(0) = inputCheck
            lbLetterGradeOne.Text = LetterGrade(inputCheck)

            'this line of code simply resets the text in the result label
            lblResult.ResetText()
        End If
    End Sub

    Private Sub tbCourseTwo_Leave(sender As Object, e As EventArgs) Handles tbCourseTwo.Leave
        Dim inputCheck As Double

        If (Not Double.TryParse(tbCourseTwo.Text, inputCheck)) Then
            lblResult.Text = "Please enter a valid grade number"
            tbCourseTwo.Focus()
            tbCourseTwo.SelectAll()
        ElseIf (inputCheck < 0 Or inputCheck > 100) Then
            lblResult.Text = "Please enter a grade from 0 to 100"
            tbCourseTwo.Focus()
            tbCourseTwo.SelectAll()
        Else
            grades(1) = inputCheck
            lbLetterGradeTwo.Text = LetterGrade(inputCheck)
            lblResult.ResetText()
        End If
    End Sub

    Private Sub tbCourseThree_Leave(sender As Object, e As EventArgs) Handles tbCourseThree.Leave
        Dim inputCheck As Double

        If (Not Double.TryParse(tbCourseThree.Text, inputCheck)) Then
            lblResult.Text = "Please enter a valid grade number"
            tbCourseThree.Focus()
            tbCourseThree.SelectAll()
        ElseIf (inputCheck < 0 Or inputCheck > 100) Then
            lblResult.Text = "Please enter a grade from 0 to 100"
            tbCourseThree.Focus()
            tbCourseThree.SelectAll()
        Else
            grades(2) = inputCheck
            lbLetterGradeThree.Text = LetterGrade(inputCheck)
            lblResult.ResetText()
        End If
    End Sub

    Private Sub tbCourseFour_Leave(sender As Object, e As EventArgs) Handles tbCourseFour.Leave
        Dim inputCheck As Double

        If (Not Double.TryParse(tbCourseFour.Text, inputCheck)) Then
            lblResult.Text = "Please enter a valid grade number"
            tbCourseFour.Focus()
            tbCourseFour.SelectAll()
        ElseIf (inputCheck < 0 Or inputCheck > 100) Then
            lblResult.Text = "Please enter a grade from 0 to 100"
            tbCourseFour.Focus()
            tbCourseFour.SelectAll()
        Else
            grades(3) = inputCheck
            lbLetterGradeFour.Text = LetterGrade(inputCheck)
            lblResult.ResetText()
        End If
    End Sub

    Private Sub tbCourseFive_Leave(sender As Object, e As EventArgs) Handles tbCourseFive.Leave
        Dim inputCheck As Double

        If (Not Double.TryParse(tbCourseFive.Text, inputCheck)) Then
            lblResult.Text = "Please enter a valid grade number"
            tbCourseFive.Focus()
            tbCourseFive.SelectAll()
        ElseIf (inputCheck < 0 Or inputCheck > 100) Then
            lblResult.Text = "Please enter a grade from 0 to 100"
            tbCourseFive.Focus()
            tbCourseFive.SelectAll()
        Else
            grades(4) = inputCheck
            lbLetterGradeFive.Text = LetterGrade(inputCheck)
            lblResult.ResetText()
        End If
    End Sub

    Private Sub tbCourseSix_Leave(sender As Object, e As EventArgs) Handles tbCourseSix.Leave
        Dim inputCheck As Double

        If (Not Double.TryParse(tbCourseSix.Text, inputCheck)) Then
            lblResult.Text = "Please enter a valid grade number"
            tbCourseSix.Focus()
            tbCourseSix.SelectAll()
        ElseIf (inputCheck < 0 Or inputCheck > 100) Then
            lblResult.Text = "Please enter a grade from 0 to 100"
            tbCourseSix.Focus()
            tbCourseSix.SelectAll()
        Else
            grades(5) = inputCheck
            lbLetterGradeSix.Text = LetterGrade(inputCheck)
            lblResult.ResetText()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()

    End Sub
End Class
