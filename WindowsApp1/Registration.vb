Imports System.Data.OleDb
Public Class Registration
    Dim link As String
    Dim conString As String
    Dim command As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    'Sub that connects the form to Database Access
    Private Sub conDB()
        link = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\TrainBooking.mdb"
        conString = link
        myConnection.ConnectionString = conString
        myConnection.Open()
    End Sub

    'Submit Button Functionality
    Private Sub Cmd_Save_Click(sender As Object, e As EventArgs) Handles Cmd_Save.Click
        Call conDB()
        command = "Insert into Bookings ([First Name],[Second Name],[ID Number],[Phone Number],[Email Address],[Password]) values ('" & txtFirstName.Text & "' , '" & txtSecondName.Text & "' , '" & txtID.Text & "' , '" & txtNumber.Text & "' , '" & txtEmail.Text & "' , '" & txtPassword.Text & "' )"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myConnection)
        cmd.Parameters.Add(New OleDbParameter("First Name", CType(txtFirstName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Second Name", CType(txtSecondName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("ID Number", CType(txtID.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Phone Number", CType(txtNumber.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Email Address", CType(txtEmail.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Password", CType(txtPassword.Text, String)))
        MsgBox("" & (txtFirstName.Text) & " " & (txtSecondName.Text) & " Sign Up Saved!!!")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            txtFirstName.Clear()
            txtSecondName.Clear()
            txtID.Clear()
            txtNumber.Clear()
            txtEmail.Clear()
            txtPassword.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    'Update Button Functionality
    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Call conDB()
        command = "UPDATE Bookings SET [First Name]='" & txtFirstName.Text & "',[Second Name]='" & txtSecondName.Text & "' ,[Phone Number]='" & txtNumber.Text & "',[Email Address]='" & txtEmail.Text & "',[Password]='" & txtPassword.Text & "' WHERE [ID Number]='" & txtID.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myConnection)
        MsgBox("" & txtFirstName.Text & " " & txtSecondName.Text & " Updated!!!!")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            txtFirstName.Clear()
            txtSecondName.Clear()
            txtID.Clear()
            txtNumber.Clear()
            txtEmail.Clear()
            txtPassword.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Call conDB()
        command = "Delete from Bookings where [ID Number]= '" & txtID.Text & "' "
        Dim cmd As OleDbCommand = New OleDbCommand(command, myConnection)
        MsgBox("" & txtID.Text & " Deleted!!!!")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            txtFirstName.Clear()
            txtSecondName.Clear()
            txtID.Clear()
            txtNumber.Clear()
            txtEmail.Clear()
            txtPassword.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
