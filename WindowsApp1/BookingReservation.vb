Public Class BookingResevation
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmdBook_Click(sender As Object, e As EventArgs) Handles cmdBook.Click
        BillingPage.Show()
        Me.Hide()
    End Sub
End Class