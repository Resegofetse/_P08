Option Strict On
Option Explicit On
Option Infer Off
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
' *********************************************************************************
' Surname, Initials: PANANA R 
' Practical: P2017-08
' Class/Interface name:frm_nationalpark
Public Class frm_nationalpark
    'Variables
    Private wildlifes() As Wildlife
    Private Lions As Lion
    Private Rhinos As Rhino
    Private numwildlife As Integer
    'file stuff
    Private FS As FileStream
    Private BF As BinaryFormatter
    Private Const Filename As String = "218026867_P08.ipb"

    'instantiating objects to store information of the different Lions and rhinos.
    'The number Of Wildlife, type Of Wildlife (Lion Or Rhino), And values For Each Wildlife will beinput by the user Of the program
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim type As Integer
        Dim trackerID As String
        Dim RarityLevel As Integer
        Dim Months As Integer
        numwildlife = CInt(InputBox("Enter Number of wildlife"))
        ReDim wildlifes(numwildlife)

        For i As Integer = 1 To numwildlife
            type = CInt(InputBox("Type of wildlife" & Environment.NewLine & " 1. Lion" & Environment.NewLine & " 2. Rhino"))
            trackerID = InputBox("Enter ID of wildlife" & CStr(i))
            RarityLevel = CInt(InputBox("Enter Rarity level of wildlife, (1-5, 1 for common, 5 for rare)"))
            Select Case type
                Case 1
                    Months = CInt(InputBox("Number of months that the Lions is monitored for"))
                    Lions = New Lion(trackerID, RarityLevel, Months)
                    For x As Integer = 1 To Months
                        Lions.Sightings(x) = CInt(InputBox("Enter number of times a Lion spotted in month" & CStr(x)))
                    Next x
                    Lions.Pride = CInt(InputBox("Enter number of lions that belong to this lion's pride"))
                    Lions.IsAlpha = CBool(InputBox("Enter True if Lion is alpha male and False if not"))
                    Lions.calcAve()
                    Lions.LowestSightings()
                    Lions.CalculateRarityRating()
                    wildlifes(i) = Lions

                Case 2
                    Rhinos = New Rhino(trackerID, RarityLevel, 2)
                    For a As Integer = 1 To 2
                        Rhinos.Sightings(a) = CInt(InputBox("Enter number of times a Rhino spotted in month" & CStr(a)))

                    Next a
                    Rhinos.Crash = CInt(InputBox("Enter Number of rhinos in this rhino's family"))
                    Rhinos.calcAve()
                    Rhinos.LowestSightings()
                    Rhinos.CalculateRarityRating()
                    wildlifes(i) = Rhinos

            End Select
        Next i

    End Sub
    'display the details Of all the Wildlife In a multi-line textbox
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim temp As String = ""
        For i As Integer = 1 To numwildlife
            temp &= wildlifes(i).Display() & Environment.NewLine
        Next i
        txtdisplaydetails.Text = temp
    End Sub
    ' calculating the Rarity Rating of all Lions and Rhinos.
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        For i As Integer = 1 To numwildlife
            wildlifes(i).CalculateRarityRating(wildlifes(i).calcAve())
        Next i

    End Sub
    'saving all the Rhino objects to a sequential file
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        FS = New FileStream(Filename, FileMode.Create, FileAccess.Write)
        BF = New BinaryFormatter()
        'downcasting
        For i As Integer = 1 To numwildlife
            Rhinos = TryCast(wildlifes(i), Rhino)
            If Not (Rhinos Is Nothing) Then
                BF.Serialize(FS, wildlifes(i))
            End If
        Next i
        FS.Close()
    End Sub

    'displaying the details of all the Rhino objects that have been saved to file
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        FS = New FileStream(Filename, FileMode.Open, FileAccess.Read)
        BF = New BinaryFormatter()
        Dim counter As Integer
        Dim tempo() As Wildlife
        Dim temp As String = ""
        While FS.Position < FS.Length
            counter += 1
            ReDim Preserve tempo(counter)
            tempo(counter) = DirectCast(BF.Deserialize(FS), Wildlife)
        End While
        FS.Close()
        For i As Integer = 1 To counter
            temp &= tempo(i).Display() & Environment.NewLine
        Next i
        txtdisplaysaved.Text = temp
    End Sub
End Class
