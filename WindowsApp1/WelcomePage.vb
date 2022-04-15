Public Class WelcomePage
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Panel2.Width += 3
        If (Panel2.Width >= 564) Then
            Timer1.Stop()
            Me.Hide()
            LandingPage.Show()
        End If
    End Sub


End Class