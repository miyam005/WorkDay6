﻿Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim result As Double
        Dim aSt As String = txtSideOne.Text
        Dim bSt As String = txtSideTwo.Text

        Dim a, b As Double
        a = CDbl(aSt)
        b = CDbl(bSt)
        result = Hypotenuse(a, b)
        txtHyp.Text = CStr(result)

    End Sub

    Function Hypotenuse(ByVal a As Double, ByVal b As Double) _
        As String


        Dim c As Double
        c = Math.Sqrt(a ^ 2 + b ^ 2)

        Return "Hello"
    End Function
End Class
