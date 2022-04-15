Imports System.Data.OleDb
Public Class BillingPage
    Dim link As String
    Dim conString As String
    Dim command As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim cmd As String

    'Sub that connects the form to Database Access
    Private Sub conDB()
        link = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ryanm\Documents\TrainBooking.mdb"
        conString = link
        myConnection.ConnectionString = conString
        myConnection.Open()
    End Sub

    Private Sub BillingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIDNumber.Text = BookingPage.txtID.Text
        txtTravel.Text = BookingPage.txtDate.Text
        txtClass.Text = BookingResevation.txtCoach.Text
        txtDepart.Text = BookingPage.txtDeparture.Text
        txtArrival.Text = BookingPage.txtDestination.Text
        txtTotalFare.Text = BookingResevation.txtTotal.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Your Train Leaves at 00:00hrs.Thank You For Booking With Us!", MsgBoxStyle.Information)
        LandingPage.Show()
        Me.Hide()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        MsgBox("You Have Canceled Your Reservations!", MsgBoxStyle.Critical)
        LandingPage.Show()
        Me.Hide()
    End Sub
End Class