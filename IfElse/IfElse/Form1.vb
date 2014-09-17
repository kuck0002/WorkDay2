Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largerNum As Double

        Dim st1 As String = txtFirstNum.Text
        Dim st2 As String = txtSecondNum.Text

        num1 = CDbl(st1)
        num2 = CDbl(st2)

        ' Your code here
        If num1 < num2 Then
            largerNum = num2
            txtResult.Text = "The larger number is " & num2

        ElseIf num1 > num2 Then
            largerNum = num1
            txtResult.Text = "The larger number is " & num1
        Else
            txtResult.Text = "They are equal"
        End If


    End Sub

    Private Sub txtResult_TextChanged(sender As Object, e As EventArgs) Handles txtResult.TextChanged

    End Sub
End Class
