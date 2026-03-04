Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class NewUser
    Dim ClosingFL As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox4.Text <> "" Then
            Dim pwd As String = TextBox2.Text
            If pwd.Length < 8 Then
                Label6.Visible = True
                Button1.Visible = False
                Label6.Text = "Password should be minimum 8 characters"
                Exit Sub
            End If

            Dim hasLetter As Boolean = False
            Dim hasDigit As Boolean = False
            Dim hasSpecial As Boolean = False

            For Each ch As Char In pwd
                If Char.IsLetter(ch) Then
                    hasLetter = True
                ElseIf Char.IsDigit(ch) Then
                    hasDigit = True
                Else
                    hasSpecial = True
                End If
            Next

            If Not hasLetter Or Not hasDigit Or Not hasSpecial Then
                Label6.Visible = True
                Label6.Text = "Password must contain at least 1 alphabet" & vbCrLf &
                              "Password must contain at least 1 number" & vbCrLf &
                              "Password must contain at least 1 special character"
                Exit Sub
            End If

            Label6.Visible = False
            Dim sql2 = "INSERT INTO userdetails (UserName, PassWord, MailId,CreatedAt) VALUES (@UserName,@PassWord,@MailId,NOW())"
            MysqlCon.ExecuteNonQuery(sql2, {
                New MySqlParameter("@UserName", TextBox1.Text.Trim),
                New MySqlParameter("@PassWord", TextBox2.Text.Trim),
                New MySqlParameter("@MailId", TextBox4.Text.Trim)
            })
            ShowToast("User Created Successfully")
            'MessageBox.Show("User Created Successfully", "Success", MessageBoxButtons.OK)
            LogIn.Show()
            ClosingFL = True
            Me.Close()
        Else
            Label6.Visible = True
            Label6.Text = "Fill all the Fields"
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Visible = False
        Button3.Visible = True
        TextBox3.PasswordChar = ""
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Visible = False
        Button5.Visible = True
        TextBox2.PasswordChar = "●"
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.Visible = False
        Button4.Visible = True
        TextBox2.PasswordChar = ""
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Visible = False
        Button2.Visible = True
        TextBox3.PasswordChar = "●"
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Button1.Visible = True
        Label6.Visible = False
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Button1.Visible = True
        Label6.Visible = False
    End Sub
    Private Sub NewUser_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not ClosingFL Then
            FrmMysql.Close()
        End If
    End Sub
End Class