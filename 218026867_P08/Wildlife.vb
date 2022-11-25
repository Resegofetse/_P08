Option Strict On
Option Explicit On
Option Infer Off
' *********************************************************************************
' Surname, Initials:PANANA R
' Practical: P2017-08
' Class/Interface name: Wildlife
<Serializable> Public Class Wildlife
    'attributes
    Private _TrackerID As String
    Private _RarityLevel As Integer
    Private _Sightings() As Integer
    Private _Months As Integer
    Private _LeastMonth As Integer
    Private _Average As Double
    'constructor
    Public Sub New(tracker As String, rarity As Integer, months As Integer)
        _TrackerID = tracker
        _RarityLevel = rarity
        _Months = months
        ReDim _Sightings(_Months)
    End Sub
    'property method
    Public Property Sightings(index As Integer) As Integer
        Get
            Return _Sightings(index)
        End Get
        Set(value As Integer)
            _Sightings(index) = validation(value)
        End Set
    End Property

    'methods
    'utility method for validation
    Public Function validation(num As Integer) As Integer
        If num >= 0 Then
            Return num
        Else
            Return 0
        End If

    End Function
    'calculates and returns the average of the _Sightings array
    Public Function calcAve() As Double
        Dim sum As Integer = 0
        For i As Integer = 1 To _Months
            sum += Sightings(i)
        Next
        _Average = sum / _Months
        Return _Average
    End Function
    'calculates the month in which the wildlife was least spotted
    Public Function LowestSightings() As Integer
        _LeastMonth = 3000
        For i As Integer = 1 To _Months
            If Sightings(i) < _LeastMonth Then
                _LeastMonth = Sightings(i)
            End If
        Next
        Return _LeastMonth
    End Function
    'a method that returns a Rarity Rating (A, B, C, or D)
    Public Function CalculateRarityRating(Average As Double) As String
        Dim temp As String = ""

        Select Case _RarityLevel
            Case 1 Or 2
                If _Average <= 15 Then
                    temp = "C"
                Else
                    temp = "D"
                End If
            Case 3
                If _Average <= 15 Then
                    temp = "B"
                Else
                    temp = "C"
                End If
            Case 4 Or 5
                If _Average <= 15 Then
                    temp = "A"
                Else
                    temp = "B"
                End If
        End Select
        Return temp
    End Function
    Public Overridable Function CalculateRarityRating() As String
        Return " "
    End Function

    'provides the Wildlife’s Tracker ID, Rarity Level, Average Sightings, the Least Sightings, And the Rarity Rating 
    Public Overridable Function Display() As String
        Dim temp As String = ""
        temp &= “Tracker ID:  " & _TrackerID & " Rarity Level :  " & CStr(_RarityLevel) & "Average Sightings: " & Format(_Average, "0.00") & " Least Sightings: " & CStr(_LeastMonth) & "Rarity Rating:” & CalculateRarityRating()
        Return temp
    End Function

End Class
