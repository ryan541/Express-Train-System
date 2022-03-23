Public Class LoginForm
    Private Sub cmdSignIn_Click(sender As Object, e As EventArgs) Handles cmdSignIn.Click
        Dim identity As String
        Dim keyWord As String
        identity = Txtidnumber.Text
        keyWord = Txtpassword.Text
        Booking.Show()
    End Sub
End Class