Option Strict On
Option Explicit On
Option Infer Off
' *********************************************************************************
' Surname, Initials:PANANA R
' Practical: P2017-08
' Class/Interface name: Rhino
<Serializable> Public Class Rhino
    Inherits Wildlife
    'attribures
    Private _Crash As Integer
    ' constructor
    Public Sub New(tracker As String, rarity As Integer, months As Integer)
        MyBase.New(tracker, rarity, months)
    End Sub
    'property
    Public Property Crash As Integer
        Get
            Return _Crash
        End Get
        Set(value As Integer)
            _Crash = value
        End Set
    End Property
    'methods
    Public Overrides Function CalculateRarityRating() As String
        Return "A"
    End Function
    Public Overrides Function Display() As String
        Return MyBase.Display() + "Number of Rhinos in the Rhino’s Crash" & CStr(Crash)
    End Function
End Class
