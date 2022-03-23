Imports System.Data.OleDb
Public Class LoginPage
    Dim link As String
    Dim conString As String
    Dim command As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub conDB()
        link = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\TrainBooking.mdb"
        conString = link
        myConnection.ConnectionString = conString
        myConnection.Open()
    End Sub

    'ReadOnly con As New OleDbConnection(My.Settings.link)


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Registration.Show()
        Me.Hide()
    End Sub

    Private Sub cmdSignIn_Click(sender As Object, e As EventArgs) Handles cmdSignIn.Click
        Call conDB()
        If txtID.Text = Nothing Or txtPass.Text = Nothing Then
            MsgBox("Please Enter Credentials!!!")
        End If

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If

        'Using command As New OleDbCommand("SELECT COUNT (*) from Bookings Where txtID = @txtID AND txtPass = @txtPass", myConnection)
        'command.Parameters.AddWithValue("@txtID", OleDbType.VarChar).Value = txtID.Text.Trim
        'command.Parameters.AddWithValue("@txtPass", OleDbType.VarChar).Value = txtPass.Text.Trim
        'MsgBox("Login Found")
        'Dim count = Convert.ToInt32(command.ExecuteScalar())

        ''If count > 0 Then
        'MsgBox("Login Found")
        'BookingPage.Show()
        'Me.Hide()

        'Else
        'MsgBox("Invalid Credentials!!!")
        'End If

        'End Using



        BookingPage.Show()
        Me.Hide()
    End Sub
End Class