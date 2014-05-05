<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradeBook
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
        Me.btnAddAssignment = New System.Windows.Forms.Button()
        Me.dgvAssignment = New System.Windows.Forms.DataGridView()
        Me.txtAssignmentName = New System.Windows.Forms.TextBox()
        Me.txtMaxScore = New System.Windows.Forms.TextBox()
        CType(Me.dgvAssignment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddAssignment
        '
        Me.btnAddAssignment.Location = New System.Drawing.Point(91, 227)
        Me.btnAddAssignment.Name = "btnAddAssignment"
        Me.btnAddAssignment.Size = New System.Drawing.Size(75, 23)
        Me.btnAddAssignment.TabIndex = 1
        Me.btnAddAssignment.Text = "Button1"
        Me.btnAddAssignment.UseVisualStyleBackColor = True
        '
        'dgvAssignment
        '
        Me.dgvAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssignment.Location = New System.Drawing.Point(12, 54)
        Me.dgvAssignment.Name = "dgvAssignment"
        Me.dgvAssignment.Size = New System.Drawing.Size(240, 150)
        Me.dgvAssignment.TabIndex = 2
        '
        'txtAssignmentName
        '
        Me.txtAssignmentName.Location = New System.Drawing.Point(12, 12)
        Me.txtAssignmentName.Name = "txtAssignmentName"
        Me.txtAssignmentName.Size = New System.Drawing.Size(100, 20)
        Me.txtAssignmentName.TabIndex = 3
        '
        'txtMaxScore
        '
        Me.txtMaxScore.Location = New System.Drawing.Point(179, 12)
        Me.txtMaxScore.Name = "txtMaxScore"
        Me.txtMaxScore.Size = New System.Drawing.Size(100, 20)
        Me.txtMaxScore.TabIndex = 4
        '
        'GradeBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtMaxScore)
        Me.Controls.Add(Me.txtAssignmentName)
        Me.Controls.Add(Me.dgvAssignment)
        Me.Controls.Add(Me.btnAddAssignment)
        Me.Name = "GradeBook"
        Me.Text = "Form1"
        CType(Me.dgvAssignment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddAssignment As System.Windows.Forms.Button
    Friend WithEvents dgvAssignment As System.Windows.Forms.DataGridView
    Friend WithEvents txtAssignmentName As System.Windows.Forms.TextBox
    Friend WithEvents txtMaxScore As System.Windows.Forms.TextBox

End Class
