Option Strict On
Option Explicit On
Option Infer Off
' *********************************************************************************
' Surname, Initials:PANANA R
' Practical: P2017-08
' Class/Interface name: Lion
<Serializable> Public Class Lion
    Inherits Wildlife
    'attributes
    Private _Pride As Integer
    Private _IsAlpha As Boolean
    'constructor
    Public Sub New(tracker As String, rarity As Integer, months As Integer)
        MyBase.New(tracker, rarity, months)
    End Sub
    'property 
    Public Property Pride As Integer
        Get
            Return _Pride
        End Get
        Set(value As Integer)
            _Pride = value
        End Set
    End Property
    Public Property IsAlpha As Boolean
        Get
            Return _IsAlpha
        End Get
        Set(value As Boolean)
            _IsAlpha = value
        End Set
    End Property
    'methods
    Public Overrides Function CalculateRarityRating() As String
        Return "C"
    End Function
    Public Overrides Function Display() As String
        Return MyBase.Display() + "the Number of Lions in the Lion’s Pride" & CStr(Pride) & " Alpha Male" & CStr(IsAlpha)
    End Function


End Class
