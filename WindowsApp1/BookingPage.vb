Imports System.Data.OleDb
Public Class BookingPage
    Dim link As String
    Dim conString As String
    Dim command As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    'Sub that connects the form to Database Access
    Private Sub conDB()
        link = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ryanm\Documents\TrainBooking.mdb"
        conString = link
        myConnection.ConnectionString = conString
        myConnection.Open()
    End Sub
    Private Sub cmdBookingTrain_Click(sender As Object, e As EventArgs) Handles cmdBookingTrain.Click
        Call conDB()
        command = "Insert into Reservations ([ID Number],[Train Type],[Departure],[Destination],[Departure Date]) values ('" & txtID.Text & "' , '" & txtTrainType.Text & "' , '" & txtDeparture.Text & "' , '" & txtDestination.Text & "' , '" & txtDate.MaxDate & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myConnection)
        cmd.Parameters.Add(New OleDbParameter("Train Type", CType(txtTrainType.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Departure", CType(txtDeparture.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Destination", CType(txtDestination.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Departure Date", CType(txtDate.Text, Date)))
        MsgBox("Trip Details Saved!!!", MsgBoxStyle.Information)

        BookingResevation.Show()
        Me.Hide()

        Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myConnection.Close()
                txtTrainType.Hide()
                txtDeparture.Hide()
                txtDestination.Hide()
                txtDate.Hide()

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try


    End Sub

End Class