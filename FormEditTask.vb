Imports MySql.Data.MySqlClient
Public Class FormEditTask
    Private _taskID As Integer
    Public Sub New(taskID As Integer)
        InitializeComponent()
        _taskID = taskID
        LoadTask()
    End Sub

    Private Sub LoadTask()
        Dim sql As String = "SELECT Title, AssignedTo, Deadline, Priority, Status FROM Tasks WHERE TaskID = @id"

        Dim dt = MysqlCon.ExecuteReader(sql, {New MySqlParameter("@id", _taskID)})
        If dt.Rows.Count = 0 Then Exit Sub

        Dim row = dt.Rows(0)
        txtTitle.Text = row("Title").ToString()
        txtAssigned.Text = row("AssignedTo").ToString()

        If Not IsDBNull(row("Deadline")) Then
            dtDeadline.Value = Convert.ToDateTime(row("Deadline"))
        End If

        cmbPriority.Items.Clear()
        cmbPriority.Items.AddRange({"High", "Medium", "Low"})
        cmbPriority.Text = row("Priority").ToString()

        cmbStatus.Items.Clear()
        cmbStatus.Items.AddRange({"To-Do", "Doing", "Done"})
        cmbStatus.Text = row("Status").ToString()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sql As String = "UPDATE Tasks SET Title = @title,AssignedTo = @assigned,Deadline = @deadline,Priority = @priority,Status = @status WHERE TaskID = @id"
        MysqlCon.ExecuteNonQuery(sql, {
            New MySqlParameter("@title", txtTitle.Text),
            New MySqlParameter("@assigned", txtAssigned.Text),
            New MySqlParameter("@deadline", dtDeadline.Value),
            New MySqlParameter("@priority", cmbPriority.Text),
            New MySqlParameter("@status", cmbStatus.Text),
            New MySqlParameter("@id", _taskID)
        })
        ' Save history
        Dim action As String = "Task edited"
        Dim sql2 = "INSERT INTO TaskHistory (TaskID, Action, ChangedAt) VALUES (@id,@action,NOW())"
        MysqlCon.ExecuteNonQuery(sql2, {
            New MySqlParameter("@id", _taskID),
            New MySqlParameter("@action", action)
        })
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub


End Class
