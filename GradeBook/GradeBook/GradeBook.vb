Public Class frmGradeBook
    Dim student As Student() 'Array of Student objects; there should be multiple students

    Structure Assignment
        Dim name As String
        Dim points As Double
        Dim maxScore As Double
    End Structure

    Dim i As Integer = -1
    Dim j As Integer = -1
    Dim totalPoints As Double = 0
    Dim totalMax
    Dim score As Assignment() 'There are multiple assignments
    Private Sub btnNewAssignment_Click(sender As Object, e As EventArgs) Handles btnNewAssignment.Click
        If txtAssignmentName.Text = "" Then
            MessageBox.Show("Please enter a name for the assignment.", "Assignment Add Error")
            txtAssignmentName.Clear()
            txtAssignmentName.Focus()
        ElseIf txtAssignmentMaxScore.Text = "" Or Not IsNumeric(txtAssignmentMaxScore.Text) Then
            MessageBox.Show("Please enter a point value for the assignment", "Assignment Add Error")
            txtAssignmentMaxScore.Clear()
            txtAssignmentMaxScore.Focus()
        Else
            j += 1
            ReDim Preserve score(j)
            score(j) = New Assignment
            score(j).name = txtAssignmentName.Text
            score(j).maxScore = txtAssignmentMaxScore.Text
            Dim query = From classwork In score
                        Select classwork.name, classwork.maxScore
            dgvAssignments.DataSource = query.ToList
            dgvAssignments.CurrentCell = Nothing
            dgvAssignments.Columns("name").HeaderText = "Name"
            dgvAssignments.Columns("maxScore").HeaderText = "Point Value"
            txtAssignmentName.Clear()
            txtAssignmentMaxScore.Clear()
            txtAssignmentName.Focus()

        End If

    End Sub

    Private Sub btnAssignmentFinishAdd_Click(sender As Object, e As EventArgs) Handles btnAssignmentFinishAdd.Click
        txtStudentName.Enabled = True
        btnNewStudent.Enabled = True
        txtAssignmentName.Enabled = False
        txtAssignmentMaxScore.Enabled = False
        btnNewAssignment.Enabled = False
        btnAssignmentFinishAdd.Enabled = False
    End Sub

    Private Sub btnNewStudent_Click() Handles btnNewStudent.Click 'Enters text box info into the object button

        If txtStudentName.Text = "" Or IsNumeric(txtStudentName.Text) Then
            MessageBox.Show("Please enter a student name", "Student Entry Error")
        Else
            i += 1
            ReDim Preserve student(i)
            student(i) = New Student
            student(i).SetScoreNum(j + 1)
            student(i).Name = txtStudentName.Text
            For l As Integer = 0 To j
                student(i).Scores(l) = 0
                score(l).points = student(i).Scores(l)
            Next
            txtStudentName.Clear()
            MessageBox.Show("Student " & student(i).Name & " was recorded")
            Dim query = From stu In student
                        Select stu.Name, stu.Average, stu.CalcGrade
            lstStudents.Items.Add(student(i).Name)
            dgvStudents.DataSource = query.ToList
            dgvStudents.CurrentCell = Nothing
            dgvStudents.Columns("name").HeaderText = "Student Name"
            dgvStudents.Columns("average").HeaderText = "Student Average"
            dgvStudents.Columns("CalcGrade").HeaderText = "Grade"
            txtStudentName.Clear()
            txtStudentName.Focus()
        End If
    End Sub



    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        For m As Integer = 0 To j
            score(m).points = student(dgvStudents.CurrentCell.RowIndex).Scores(m)
        Next
        Dim query = From classwork In score
                Select classwork.name, classwork.points, classwork.maxScore
        dgvScores.DataSource = query.ToList
        dgvScores.CurrentCell = Nothing
        dgvScores.Columns("name").HeaderText = "Assignment Name"
        dgvScores.Columns("points").HeaderText = "Score"
        dgvScores.Columns("maxScore").HeaderText = "Points Possible"
    End Sub

    Private Sub dgvScores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvScores.CellClick
        txtEditScore.Enabled = True
        btnUpdateScore.Enabled = True
    End Sub

    Private Sub btnUpdateScore_Click(sender As Object, e As EventArgs) Handles btnUpdateScore.Click
        If txtEditScore.Text = "" Or Not IsNumeric(txtEditScore.Text) Then
            MessageBox.Show("Please enter a valid score", "Score Entry Error")
        ElseIf CDbl(txtEditScore.Text) > score(dgvScores.CurrentCell.RowIndex).maxScore Then
            MessageBox.Show("The score entered exceeds the number of points possible for the assignment.", "Score Entry Error")
        Else
            score(dgvScores.CurrentCell.RowIndex).points = txtEditScore.Text
            student(dgvStudents.CurrentCell.RowIndex).Scores(dgvScores.CurrentCell.RowIndex) = score(dgvScores.CurrentCell.RowIndex).points 'dgvScores.CurrentCell.Value

            Dim query = From classwork In score
                    Select classwork.name, classwork.points, classwork.maxScore
            dgvScores.DataSource = query.ToList
            dgvScores.CurrentCell = dgvScores.Rows(dgvScores.CurrentCell.RowIndex).Cells(1)
            dgvScores.Columns("name").HeaderText = "Assignment Name"
            dgvScores.Columns("points").HeaderText = "Score"
            dgvScores.Columns("maxScore").HeaderText = "Points Possible"
            For n As Integer = 0 To j
                totalPoints += student(dgvStudents.CurrentCell.RowIndex).Scores(n)
                totalMax += score(n).maxScore
            Next
            student(dgvStudents.CurrentCell.RowIndex).Average = ((totalPoints / totalMax) * 100)
            totalPoints = 0
            totalMax = 0
            updateDgvStudents()
            txtEditScore.Clear()
            txtEditScore.Focus()
        End If

    End Sub

    Private Sub updateDgvStudents()
        Dim query = From stu In student
                   Select stu.Name, stu.Average, stu.CalcGrade
        dgvStudents.DataSource = query.ToList
        dgvStudents.CurrentCell = dgvStudents.Rows(dgvStudents.CurrentCell.RowIndex).Cells(1)
        dgvStudents.Columns("name").HeaderText = "Student Name"
        dgvStudents.Columns("average").HeaderText = "Student Average"
        dgvStudents.Columns("CalcGrade").HeaderText = "Grade"
    End Sub

    Private Sub btnExit_Click() Handles btnExit.Click
        Me.Close()
    End Sub
End Class

