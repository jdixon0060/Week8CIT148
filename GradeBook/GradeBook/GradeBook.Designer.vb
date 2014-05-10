<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradeBook
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.btnNewStudent = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAssignmentName = New System.Windows.Forms.TextBox()
        Me.txtAssignmentMaxScore = New System.Windows.Forms.TextBox()
        Me.btnNewAssignment = New System.Windows.Forms.Button()
        Me.lstStudents = New System.Windows.Forms.ListBox()
        Me.dgvScores = New System.Windows.Forms.DataGridView()
        Me.txtEditScore = New System.Windows.Forms.TextBox()
        Me.btnUpdateScore = New System.Windows.Forms.Button()
        Me.lblAssignment = New System.Windows.Forms.Label()
        Me.lblPointValue = New System.Windows.Forms.Label()
        Me.grpAssignments = New System.Windows.Forms.GroupBox()
        Me.btnAssignmentFinishAdd = New System.Windows.Forms.Button()
        Me.dgvAssignments = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpStudentList = New System.Windows.Forms.GroupBox()
        Me.grpStudentAverage = New System.Windows.Forms.GroupBox()
        Me.lblScores = New System.Windows.Forms.Label()
        Me.lblStudentGrade = New System.Windows.Forms.Label()
        Me.lblUpdateScore = New System.Windows.Forms.Label()
        Me.tabGradeBook = New System.Windows.Forms.TabControl()
        Me.tabAdd = New System.Windows.Forms.TabPage()
        Me.tabGrades = New System.Windows.Forms.TabPage()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvScores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAssignments.SuspendLayout()
        CType(Me.dgvAssignments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStudentList.SuspendLayout()
        Me.grpStudentAverage.SuspendLayout()
        Me.tabGradeBook.SuspendLayout()
        Me.tabAdd.SuspendLayout()
        Me.tabGrades.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Location = New System.Drawing.Point(54, 145)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(78, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Student Name:"
        '
        'txtStudentName
        '
        Me.txtStudentName.Enabled = False
        Me.txtStudentName.Location = New System.Drawing.Point(138, 142)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(122, 20)
        Me.txtStudentName.TabIndex = 35
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToDeleteRows = False
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvStudents.Location = New System.Drawing.Point(15, 35)
        Me.dgvStudents.MultiSelect = False
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.RowHeadersVisible = False
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudents.Size = New System.Drawing.Size(271, 166)
        Me.dgvStudents.TabIndex = 8
        '
        'btnNewStudent
        '
        Me.btnNewStudent.Enabled = False
        Me.btnNewStudent.Location = New System.Drawing.Point(99, 171)
        Me.btnNewStudent.Name = "btnNewStudent"
        Me.btnNewStudent.Size = New System.Drawing.Size(90, 23)
        Me.btnNewStudent.TabIndex = 36
        Me.btnNewStudent.Text = "Enter Student"
        Me.btnNewStudent.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Location = New System.Drawing.Point(591, 297)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 27)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtAssignmentName
        '
        Me.txtAssignmentName.Location = New System.Drawing.Point(72, 158)
        Me.txtAssignmentName.Name = "txtAssignmentName"
        Me.txtAssignmentName.Size = New System.Drawing.Size(100, 20)
        Me.txtAssignmentName.TabIndex = 30
        '
        'txtAssignmentMaxScore
        '
        Me.txtAssignmentMaxScore.Location = New System.Drawing.Point(223, 158)
        Me.txtAssignmentMaxScore.Name = "txtAssignmentMaxScore"
        Me.txtAssignmentMaxScore.Size = New System.Drawing.Size(41, 20)
        Me.txtAssignmentMaxScore.TabIndex = 31
        '
        'btnNewAssignment
        '
        Me.btnNewAssignment.Location = New System.Drawing.Point(72, 184)
        Me.btnNewAssignment.Name = "btnNewAssignment"
        Me.btnNewAssignment.Size = New System.Drawing.Size(75, 23)
        Me.btnNewAssignment.TabIndex = 32
        Me.btnNewAssignment.Text = "Add"
        Me.btnNewAssignment.UseVisualStyleBackColor = True
        '
        'lstStudents
        '
        Me.lstStudents.FormattingEnabled = True
        Me.lstStudents.Location = New System.Drawing.Point(27, 28)
        Me.lstStudents.Name = "lstStudents"
        Me.lstStudents.Size = New System.Drawing.Size(244, 108)
        Me.lstStudents.TabIndex = 17
        '
        'dgvScores
        '
        Me.dgvScores.AllowUserToAddRows = False
        Me.dgvScores.AllowUserToDeleteRows = False
        Me.dgvScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvScores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvScores.Location = New System.Drawing.Point(324, 35)
        Me.dgvScores.MultiSelect = False
        Me.dgvScores.Name = "dgvScores"
        Me.dgvScores.RowHeadersVisible = False
        Me.dgvScores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvScores.Size = New System.Drawing.Size(267, 159)
        Me.dgvScores.TabIndex = 18
        '
        'txtEditScore
        '
        Me.txtEditScore.Enabled = False
        Me.txtEditScore.Location = New System.Drawing.Point(374, 202)
        Me.txtEditScore.Name = "txtEditScore"
        Me.txtEditScore.Size = New System.Drawing.Size(100, 20)
        Me.txtEditScore.TabIndex = 37
        '
        'btnUpdateScore
        '
        Me.btnUpdateScore.Enabled = False
        Me.btnUpdateScore.Location = New System.Drawing.Point(480, 200)
        Me.btnUpdateScore.Name = "btnUpdateScore"
        Me.btnUpdateScore.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateScore.TabIndex = 38
        Me.btnUpdateScore.Text = "Update"
        Me.btnUpdateScore.UseVisualStyleBackColor = True
        '
        'lblAssignment
        '
        Me.lblAssignment.AutoSize = True
        Me.lblAssignment.Location = New System.Drawing.Point(28, 161)
        Me.lblAssignment.Name = "lblAssignment"
        Me.lblAssignment.Size = New System.Drawing.Size(38, 13)
        Me.lblAssignment.TabIndex = 21
        Me.lblAssignment.Text = "Name:"
        '
        'lblPointValue
        '
        Me.lblPointValue.AutoSize = True
        Me.lblPointValue.Location = New System.Drawing.Point(178, 161)
        Me.lblPointValue.Name = "lblPointValue"
        Me.lblPointValue.Size = New System.Drawing.Size(37, 13)
        Me.lblPointValue.TabIndex = 22
        Me.lblPointValue.Text = "Value:"
        '
        'grpAssignments
        '
        Me.grpAssignments.Controls.Add(Me.btnAssignmentFinishAdd)
        Me.grpAssignments.Controls.Add(Me.dgvAssignments)
        Me.grpAssignments.Controls.Add(Me.txtAssignmentName)
        Me.grpAssignments.Controls.Add(Me.lblPointValue)
        Me.grpAssignments.Controls.Add(Me.lblAssignment)
        Me.grpAssignments.Controls.Add(Me.txtAssignmentMaxScore)
        Me.grpAssignments.Controls.Add(Me.btnNewAssignment)
        Me.grpAssignments.Location = New System.Drawing.Point(20, 17)
        Me.grpAssignments.Name = "grpAssignments"
        Me.grpAssignments.Size = New System.Drawing.Size(302, 221)
        Me.grpAssignments.TabIndex = 23
        Me.grpAssignments.TabStop = False
        Me.grpAssignments.Text = "Assignments"
        '
        'btnAssignmentFinishAdd
        '
        Me.btnAssignmentFinishAdd.Location = New System.Drawing.Point(163, 184)
        Me.btnAssignmentFinishAdd.Name = "btnAssignmentFinishAdd"
        Me.btnAssignmentFinishAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAssignmentFinishAdd.TabIndex = 34
        Me.btnAssignmentFinishAdd.Text = "Done"
        Me.btnAssignmentFinishAdd.UseVisualStyleBackColor = True
        '
        'dgvAssignments
        '
        Me.dgvAssignments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssignments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvAssignments.Location = New System.Drawing.Point(33, 28)
        Me.dgvAssignments.MultiSelect = False
        Me.dgvAssignments.Name = "dgvAssignments"
        Me.dgvAssignments.RowHeadersVisible = False
        Me.dgvAssignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAssignments.Size = New System.Drawing.Size(243, 124)
        Me.dgvAssignments.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(371, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Score:"
        '
        'grpStudentList
        '
        Me.grpStudentList.Controls.Add(Me.lblName)
        Me.grpStudentList.Controls.Add(Me.txtStudentName)
        Me.grpStudentList.Controls.Add(Me.btnNewStudent)
        Me.grpStudentList.Controls.Add(Me.lstStudents)
        Me.grpStudentList.Location = New System.Drawing.Point(332, 17)
        Me.grpStudentList.Name = "grpStudentList"
        Me.grpStudentList.Size = New System.Drawing.Size(299, 204)
        Me.grpStudentList.TabIndex = 27
        Me.grpStudentList.TabStop = False
        Me.grpStudentList.Text = "Students"
        '
        'grpStudentAverage
        '
        Me.grpStudentAverage.Controls.Add(Me.lblScores)
        Me.grpStudentAverage.Controls.Add(Me.lblStudentGrade)
        Me.grpStudentAverage.Controls.Add(Me.lblUpdateScore)
        Me.grpStudentAverage.Controls.Add(Me.dgvStudents)
        Me.grpStudentAverage.Controls.Add(Me.dgvScores)
        Me.grpStudentAverage.Controls.Add(Me.txtEditScore)
        Me.grpStudentAverage.Controls.Add(Me.btnUpdateScore)
        Me.grpStudentAverage.Location = New System.Drawing.Point(20, 6)
        Me.grpStudentAverage.Name = "grpStudentAverage"
        Me.grpStudentAverage.Size = New System.Drawing.Size(611, 241)
        Me.grpStudentAverage.TabIndex = 28
        Me.grpStudentAverage.TabStop = False
        Me.grpStudentAverage.Text = "Grades"
        '
        'lblScores
        '
        Me.lblScores.AutoSize = True
        Me.lblScores.Location = New System.Drawing.Point(321, 19)
        Me.lblScores.Name = "lblScores"
        Me.lblScores.Size = New System.Drawing.Size(40, 13)
        Me.lblScores.TabIndex = 32
        Me.lblScores.Text = "Scores"
        '
        'lblStudentGrade
        '
        Me.lblStudentGrade.AutoSize = True
        Me.lblStudentGrade.Location = New System.Drawing.Point(12, 19)
        Me.lblStudentGrade.Name = "lblStudentGrade"
        Me.lblStudentGrade.Size = New System.Drawing.Size(81, 13)
        Me.lblStudentGrade.TabIndex = 31
        Me.lblStudentGrade.Text = "Student Grades"
        '
        'lblUpdateScore
        '
        Me.lblUpdateScore.AutoSize = True
        Me.lblUpdateScore.Location = New System.Drawing.Point(329, 207)
        Me.lblUpdateScore.Name = "lblUpdateScore"
        Me.lblUpdateScore.Size = New System.Drawing.Size(45, 13)
        Me.lblUpdateScore.TabIndex = 30
        Me.lblUpdateScore.Text = "Update:"
        '
        'tabGradeBook
        '
        Me.tabGradeBook.Controls.Add(Me.tabAdd)
        Me.tabGradeBook.Controls.Add(Me.tabGrades)
        Me.tabGradeBook.Location = New System.Drawing.Point(12, 12)
        Me.tabGradeBook.Name = "tabGradeBook"
        Me.tabGradeBook.SelectedIndex = 0
        Me.tabGradeBook.Size = New System.Drawing.Size(662, 279)
        Me.tabGradeBook.TabIndex = 39
        '
        'tabAdd
        '
        Me.tabAdd.Controls.Add(Me.grpAssignments)
        Me.tabAdd.Controls.Add(Me.grpStudentList)
        Me.tabAdd.Location = New System.Drawing.Point(4, 22)
        Me.tabAdd.Name = "tabAdd"
        Me.tabAdd.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAdd.Size = New System.Drawing.Size(654, 253)
        Me.tabAdd.TabIndex = 0
        Me.tabAdd.Text = "Add Data"
        Me.tabAdd.UseVisualStyleBackColor = True
        '
        'tabGrades
        '
        Me.tabGrades.Controls.Add(Me.grpStudentAverage)
        Me.tabGrades.Controls.Add(Me.Label1)
        Me.tabGrades.Location = New System.Drawing.Point(4, 22)
        Me.tabGrades.Name = "tabGrades"
        Me.tabGrades.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGrades.Size = New System.Drawing.Size(654, 253)
        Me.tabGrades.TabIndex = 1
        Me.tabGrades.Text = "Grades"
        Me.tabGrades.UseVisualStyleBackColor = True
        '
        'frmGradeBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 336)
        Me.Controls.Add(Me.tabGradeBook)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmGradeBook"
        Me.Text = "Student Grade Book"
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvScores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAssignments.ResumeLayout(False)
        Me.grpAssignments.PerformLayout()
        CType(Me.dgvAssignments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStudentList.ResumeLayout(False)
        Me.grpStudentList.PerformLayout()
        Me.grpStudentAverage.ResumeLayout(False)
        Me.grpStudentAverage.PerformLayout()
        Me.tabGradeBook.ResumeLayout(False)
        Me.tabAdd.ResumeLayout(False)
        Me.tabGrades.ResumeLayout(False)
        Me.tabGrades.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents dgvStudents As System.Windows.Forms.DataGridView
    Friend WithEvents btnNewStudent As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtAssignmentName As System.Windows.Forms.TextBox
    Friend WithEvents txtAssignmentMaxScore As System.Windows.Forms.TextBox
    Friend WithEvents btnNewAssignment As System.Windows.Forms.Button
    Friend WithEvents lstStudents As System.Windows.Forms.ListBox
    Friend WithEvents dgvScores As System.Windows.Forms.DataGridView
    Friend WithEvents txtEditScore As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdateScore As System.Windows.Forms.Button
    Friend WithEvents lblAssignment As System.Windows.Forms.Label
    Friend WithEvents lblPointValue As System.Windows.Forms.Label
    Friend WithEvents grpAssignments As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpStudentList As System.Windows.Forms.GroupBox
    Friend WithEvents dgvAssignments As System.Windows.Forms.DataGridView
    Friend WithEvents btnAssignmentFinishAdd As System.Windows.Forms.Button
    Friend WithEvents grpStudentAverage As System.Windows.Forms.GroupBox
    Friend WithEvents tabGradeBook As System.Windows.Forms.TabControl
    Friend WithEvents tabAdd As System.Windows.Forms.TabPage
    Friend WithEvents tabGrades As System.Windows.Forms.TabPage
    Friend WithEvents lblScores As System.Windows.Forms.Label
    Friend WithEvents lblStudentGrade As System.Windows.Forms.Label
    Friend WithEvents lblUpdateScore As System.Windows.Forms.Label

End Class
