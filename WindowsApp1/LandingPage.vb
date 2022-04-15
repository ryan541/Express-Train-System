Public Class LandingPage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdSignIn.Click
        LoginPage.Show()
        Me.Hide()

    End Sub

    Private Sub cmdSignUp_Click(sender As Object, e As EventArgs) Handles cmdSignUp.Click
        Registration.Show()
        Me.Hide()

    End Sub

    Private Sub BookingToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class