Imports System.Net
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Public Class addTask
    Dim ProjectName As String
    Dim ProjectId As String
    Dim Title As String
    Dim Priority As String
    Dim AssignedTo As String
    Dim Deadline As DateTime

    Public Sub AddTask(projectID As Integer, title As String, assignedTo As String, deadline As DateTime?, priority As String)
        Dim sql = "INSERT INTO Tasks (ProjectID, Title, AssignedTo, Deadline, Priority) VALUES (@ProjectID,@Title,@AssignedTo,@Deadline,@priority)"
        Dim Parameters As MySqlParameter() = {
             New MySqlParameter("@ProjectID", projectID),
             New MySqlParameter("@Title", title),
             New MySqlParameter("@AssignedTo", assignedTo),
             New MySqlParameter("@Deadline", If(deadline.HasValue, deadline.Value.ToString("yyyy-MM-dd"), DBNull.Value)),
             New MySqlParameter("@priority", priority)
            }
        MysqlCon.ExecuteNonQuery(sql, Parameters)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProjectName = CmbProjectName.Text
        Title = Txttitle.Text
        Priority = Txtpriority.Text
        AssignedTo = Txtassignedto.Text
        Deadline = DeadlinePicker.Value
        If ProjectName <> "" And Title <> "" And Priority <> "" And AssignedTo <> "" Then
            Dim sql = "SELECT ProjectID from projects where ProjectName=@ProjectName"
            Dim Parameters As MySqlParameter() = {
             New MySqlParameter("@ProjectName", ProjectName)
            }

            Dim dt As DataTable = MysqlCon.ExecuteReader(sql, Parameters)
            If dt.Rows.Count > 0 Then
                ProjectId = dt.Rows(0)("ProjectID").ToString()
            End If

            AddTask(ProjectId, Title, AssignedTo, Deadline, Priority)
            MessageBox.Show("Task Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim msg As String = $"New Task Assigned:
                                Project Name :{ProjectName}
                                Task:{Title}
                                Deadline:{Deadline}
                                Assigned By:{UserName}
                                "
            Dim AssignedPerson As String = GetAssignedPersonMobile(Txtassignedto.Text)
            SendGmail(AssignedPerson, "New Task Assigned", msg)
            ' SendWhatsAppMessage(AssignedPerson, msg)
            CreateTask.LoadProjects()
            Me.Close()
        Else
            MessageBox.Show("Please Fill All the Value", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Function GetAssignedPersonMobile(AssignedTo As String) As String
        Dim sql As String = "SELECT MailId FROM userdetails WHERE UserName = @UserName"

        Dim dt As DataTable = MysqlCon.ExecuteReader(sql, {
        New MySqlParameter("@UserName", AssignedTo)})

        If dt.Rows.Count = 0 Then

            MessageBox.Show("No User Found", "Invalid Credential", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End If

        Return dt.Rows(0)("MailId").ToString()
    End Function

    Public Sub SendWhatsAppMessage(userNumber As String, message As String)
        Dim client As New WebClient()

        Dim url As String = $"http://localhost:3000/sendMessage?phone={userNumber}&text={message}"
        Dim result As String = client.DownloadString(url)

        Console.WriteLine("Result: " & result)
    End Sub


    Public Sub SendGmail(toEmail As String, subject As String, body As String)
        Try
            Dim smtp As New SmtpClient("smtp.gmail.com", 587)
            smtp.EnableSsl = True

            smtp.Credentials = New NetworkCredential("priyaaccsys09@gmail.com", "ulvk lcab dylt vwqa")

            Dim mail As New MailMessage()
            mail.From = New MailAddress("priyaaccsys09@gmail.com")
            mail.To.Add(toEmail)
            mail.Subject = subject
            mail.Body = body
            mail.IsBodyHtml = False

            smtp.Send(mail)
            ShowToast("Email sent successfully!")
        Catch ex As Exception
            MessageBox.Show("Email error: " & ex.Message)
        End Try
    End Sub

    Private Sub addTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql = "SELECT DISTINCT ProjectName from projects"
        Dim dt As DataTable = MysqlCon.ExecuteReader(sql)
        If dt.Rows.Count > 0 Then
            For Each j As DataRow In dt.Rows
                CmbProjectName.Items.Add(j("ProjectName").ToString())
            Next
        End If
    End Sub
End Class