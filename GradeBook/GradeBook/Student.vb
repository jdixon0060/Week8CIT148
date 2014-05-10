Class Student
    Private m_name As String     'Student name
    Private m_average As Double 'Student average
    Private m_scores As Double() 'Student scores

    Public Property Name() As String 'return a student's name or modify it
        Get
            Return m_name
        End Get
        Set(value As String)
            m_name = value
        End Set
    End Property

    Public Property Average() As Double
        Get
            Return Math.Round(m_average)
        End Get
        Set(value As Double)
            m_average = value
        End Set
    End Property

    Public Property Scores(i As Integer) As Double 'Display a score or change it
        Get
            Return m_scores(i)
        End Get
        Set(value As Double)
            m_scores(i) = value
        End Set
    End Property

    Sub SetScoreNum(i As Integer) 'Change the number of scores to record
        ReDim Preserve m_scores(i)
    End Sub

    Function CalcGrade() As String 'Determine grade
        Dim grade As Double
        grade = Math.Round(m_average)
        Select Case grade
            Case Is >= 90
                Return "A"
            Case Is >= 80
                Return "B"
            Case Is >= 70
                Return "C"
            Case Is >= 60
                Return "D"
            Case Else
                Return "F"
        End Select
    End Function
End Class
