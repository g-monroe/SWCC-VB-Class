Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim hours, payPerHour, overtimeHours, pay As Double
        InputData(hours, payPerHour)
        CalPay(hours, payPerHour, overtimeHours, pay)
        DisplayPay(overtimeHours, pay)
    End Sub
    Sub InputData(ByRef hours As Double, ByRef payperhour As Double)
        hours = CDbl(txtWorked.Text)
        payperhour = CDbl(txtPay.Text)
    End Sub
    Sub CalPay(ByVal hours As Double, ByVal payperhour As Double, ByRef overtimehours As Double, ByRef pay As Double)
        If hours > 40 Then
            overtimehours = hours - 40
        Else
            overtimehours = 0
        End If
        pay = payperhour * 40 + ((1.5 * payperhour) * overtimehours)
    End Sub
    Sub DisplayPay(ByRef overtimehours As Double, ByRef pay As Double)
        txtResultPay.Text = pay.ToString("c")
        txtHours.Text = CStr(overtimehours)
    End Sub
End Class
