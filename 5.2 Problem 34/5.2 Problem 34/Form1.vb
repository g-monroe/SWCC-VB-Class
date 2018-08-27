Public Class Form1
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Tip As Double = CDbl(txtTip.Text)
        Dim amount As Double = ((Tip / 100) * CDbl(txtBill.Text))
        txtResult.Text = "Tip the " & txtOcc.Text & " " & amount.ToString("C")
    End Sub
End Class
