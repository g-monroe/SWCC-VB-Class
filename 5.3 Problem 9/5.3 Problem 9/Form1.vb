Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim newSal As Double
        CalSalary(CDbl(txtSal.Text), newSal)
        txtResult.Text = "New salary for " & txtFirst.Text & " " & txtLast.Text & ": " & newSal.ToString("C")
    End Sub
    Sub CalSalary(ByVal Amount As Double, ByRef newSal As Double)
        If Amount < 40000 Then
            newSal = Amount + 2000 + (0.02 * Amount)
        Else
            newSal = Amount + (0.05 * Amount)
        End If
    End Sub
End Class
