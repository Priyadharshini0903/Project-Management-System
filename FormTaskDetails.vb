Imports MySql.Data.MySqlClient

Public Class FormTaskDetails
    Private _taskID As Integer

    Public Sub New(taskID As Integer)
        InitializeComponent()
        _taskID = taskID
        LoadTaskDetails()
        LoadHistory()
    End Sub

    Private Sub LoadTaskDetails()

        Dim sql As String = "SELECT t.*,  p.ProjectName,p.Description AS ProjectDescription, p.StartDate AS ProjectStart, p.EndDate AS ProjectEnd
                             FROM Tasks t JOIN Projects p ON t.ProjectID = p.ProjectID WHERE t.TaskID = @id"
        Dim dt = MysqlCon.ExecuteReader(sql,
                 {New MySqlParameter("@id", _taskID)})

        If dt.Rows.Count = 0 Then Exit Sub

        Dim row = dt.Rows(0)

        ' ---- PROJECT INFO ----
        lblProjectName.Text = row("ProjectName").ToString()

        ' ---- TASK INFO ----
        lblTitle.Text = row("Title").ToString()
        lblDescription.Text = row("ProjectDescription").ToString()
        lblAssigned.Text = row("AssignedTo").ToString()

        If Not IsDBNull(row("Deadline")) Then
            lblDeadline.Text = Convert.ToDateTime(row("Deadline")).ToString("MMM d, yyyy")
        Else
            lblDeadline.Text = "-"
        End If

        lblPriority.Text = row("Priority").ToString()
        lblStatus.Text = row("Status").ToString()

        lblCreated.Text = Convert.ToDateTime(row("CreatedAt")).ToString("MMM d, yyyy hh:mm tt")

    End Sub

    Private Sub LoadHistory()

        Dim sql As String = "SELECT Action, ChangedAt FROM TaskHistory WHERE TaskID = @id ORDER BY ChangedAt DESC"

        Dim dt = MysqlCon.ExecuteReader(sql,
                 {New MySqlParameter("@id", _taskID)})

        dgvHistory.DataSource = dt
        dgvHistory.Columns(0).Width = 200
        dgvHistory.Columns(1).Width = 150
    End Sub


End Class
