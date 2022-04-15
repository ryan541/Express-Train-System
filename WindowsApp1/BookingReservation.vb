Imports System.Data.OleDb
Public Class BookingResevation
    Dim link As String
    Dim conString As String
    Dim command As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim Total1, Total2, Total3, Total4, Total5, Total6 As Integer
    Private Sub conDB()
        link = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ryanm\Documents\TrainBooking.mdb"
        conString = link
        myConnection.ConnectionString = conString
        myConnection.Open()
    End Sub



    Private Sub cmdBook_Click(sender As Object, e As EventArgs) Handles cmdBook.Click
        Call conDB()
        command = "Insert into Accomodation ([Adults],[Children1],[Children2],[Coach]) values ('" & txtAdults.Text & "' , '" & txtChildren1.Text & "' , '" & txtChildren2.Text & "','" & txtCoach.Text & "' )"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myConnection)
        cmd.Parameters.Add(New OleDbParameter("Adults", CType(txtAdults.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Departure", CType(txtChildren1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Destination", CType(txtChildren2.Text, String)))
        MsgBox("Your Train Booking Has Been Saved!", MsgBoxStyle.Information)
        BillingPage.Show()
        Me.Hide()

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            txtAdults.Hide()
            txtChildren1.Hide()
            txtChildren2.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub txtAdults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtAdults.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtCoach.Text = "First Class" Then
            Total1 = txtAdults.Text * 3000
            Total2 = txtChildren1.Text * 1500
            Total3 = Total1 + Total2
            txtTotal.Text = Total3

        ElseIf txtCoach.Text = "Economy Class" Then
            Total4 = txtAdults.Text * 1000
            Total5 = txtChildren1.Text * 500
            Total6 = Total5 + Total4
            txtTotal.Text = Total6

        End If


    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub BookingResevation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class