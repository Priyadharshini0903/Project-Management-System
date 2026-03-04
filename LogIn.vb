Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class LogIn
    Dim ClosingFL As Boolean

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        NewUser.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String = "SELECT * FROM userdetails WHERE UserName = @UserName AND PassWord =@PassWord"
        Dim dt As DataTable = MysqlCon.ExecuteReader(sql, {
            New MySqlParameter("@UserName", TextBox1.Text.Trim()),
            New MySqlParameter("@PassWord", TextBox2.Text.Trim())
        })
        If dt.Rows.Count = 0 Then
            ShowToast("Invalid UserName or Password..")
            'MessageBox.Show("Invalid UserName or Password..", "Invalid Credential", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            ShowToast("Logged In Successfully!..")
            'MessageBox.Show("Logged In Successfully!..", "Success", MessageBoxButtons.OK)
            Dim row = dt.Rows(0)
            UserMobNumber = row("MailId").ToString()
            UserName = row("UserName").ToString()
            CreateTask.Show()
            ClosingFL = True
            Me.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.Visible = False
        Button4.Visible = True
        TextBox2.PasswordChar = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Visible = False
        Button5.Visible = True
        TextBox2.PasswordChar = "●"
    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogIn_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not ClosingFL Then
            FrmMysql.Close()
        End If

    End Sub
End Class