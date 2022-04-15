Imports System.Data.OleDb
Public Class LoginPage
    Dim link As String
    Dim conString As String
    Dim command As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    'connection to the DataBase
    Private Sub conDB()
        link = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ryanm\Documents\TrainBooking.mdb"
        conString = link
        myConnection.ConnectionString = conString
        myConnection.Open()
    End Sub

    'link to register
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Registration.Show()
        Me.Hide()
    End Sub

    Private Sub cmdSignIn_Click(sender As Object, e As EventArgs) Handles cmdSignIn.Click
        Call conDB()

        'checks if data is entered
        If txtID.Text = Nothing Or txtPass.Text = Nothing Then
            MsgBox("Please Enter Credentials!!!", MsgBoxStyle.Exclamation)
            Close()
        Else

            'Checks ID number and password
            Dim cmd As OleDbCommand = New OleDbCommand(command, myConnection)
            cmd = New OleDbCommand("SELECT * FROM Registration WHERE [ID Number] = '" & txtID.Text & "' and [Password] ='" & txtPass.Text & "' ", myConnection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtID.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtPass.Text

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myConnection.Close()
                txtID.Clear()
                txtPass.Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MsgBox("Login Found", MsgBoxStyle.Information)
            BookingPage.Show()
            Me.Hide()
        End If
        myConnection.Close()
    End Sub

    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class