Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class CreateTask
    Private currentProjectID As Integer = 0
    Private slidingIn As Boolean
    Private slidingOut As Boolean
    Private LogoutFl As Boolean

    Private Sub CreateTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProjects()
        AddHandler flowToDo.DragEnter, AddressOf flow_DragEnter
        AddHandler flowToDo.DragDrop, AddressOf flow_DragDrop

        AddHandler flowDoing.DragEnter, AddressOf flow_DragEnter
        AddHandler flowDoing.DragDrop, AddressOf flow_DragDrop

        AddHandler flowDone.DragEnter, AddressOf flow_DragEnter
        AddHandler flowDone.DragDrop, AddressOf FlowDone_DragDrop
        AttachDragEvents(flowDone)

        Panel3.Left = -Panel3.Width
        Panel3.Visible = False
        lstProjects.Left = 0
    End Sub
    Public Sub LoadProjects()
        Dim dt As DataTable = GetProjects()
        lstProjects.DisplayMember = "ProjectName"
        lstProjects.ValueMember = "ProjectID"
        lstProjects.DataSource = dt
    End Sub
    Public Function GetProjects() As DataTable
        Dim sql As String = "SELECT ProjectID, ProjectName, Status FROM Projects ORDER BY CreatedAt DESC"
        Return MysqlCon.ExecuteReader(sql)
    End Function

    Public Function GetTasksForProject(projectID As Integer) As DataTable
        Dim Sql = "SELECT * FROM Tasks WHERE ProjectID = @pid ORDER BY Deadline IS NULL, Deadline"
        Dim Parameters As MySqlParameter() = {
              New MySqlParameter("@pid", projectID)
            }
        Return MysqlCon.ExecuteReader(Sql, Parameters)
    End Function

    Public Sub UpdateTaskStatus(taskID As Integer, newStatus As String, Optional filePath As String = Nothing)
        Dim sql = "UPDATE Tasks SET Status = @st, File = @file WHERE TaskID = @tid"

        Dim Parameters As MySqlParameter() = {
        New MySqlParameter("@st", newStatus),
        New MySqlParameter("@file", filePath),
        New MySqlParameter("@tid", taskID)
    }

        MysqlCon.ExecuteNonQuery(sql, Parameters)
    End Sub
    Public Sub UpdateTask(taskID As Integer, title As String, assignedTo As String, deadline As DateTime?, priority As String, status As String)
        Dim sql = "UPDATE Tasks SET Title=@title, AssignedTo=@ass, Deadline=@ddl, Priority=@pri, Status=@st WHERE TaskID=@tid"
        Dim Parameters As MySqlParameter() = {
           New MySqlParameter("@title", title),
           New MySqlParameter("@ass", assignedTo),
           New MySqlParameter("@ddl", If(deadline.HasValue, deadline.Value.ToString("yyyy-MM-dd"), DBNull.Value)),
           New MySqlParameter("@pri", priority),
           New MySqlParameter("@st", status),
           New MySqlParameter("@tid", taskID)
        }
        MysqlCon.ExecuteNonQuery(sql, Parameters)
    End Sub
    Private Sub adjustLayout()
        Panel1.Width = Me.ClientSize.Width
        lstProjects.Height = Me.ClientSize.Height - 50
        Panel2.Width = Me.ClientSize.Width - (lstProjects.Width * 1.2)
        Panel2.Height = lstProjects.Height

        '----PANEL3--
        Panel3.Location = Panel2.Location
        Panel3.Height = lstProjects.Height

        Dim padding As Integer = 10
        Dim spacing As Integer = 10
        Dim topSpacing As Integer = 10

        ' --- flowToDo and Label1 ---
        flowToDo.Width = (Panel2.Width - 2 * padding - spacing) \ 2
        flowToDo.Height = Panel2.Width / 3
        flowToDo.Left = padding
        flowToDo.Top = padding + Label1.Height + topSpacing

        Label1.Top = padding
        Label1.Left = flowToDo.Left + (flowToDo.Width - Label1.Width) \ 2  ' center over flowToDo

        ' --- flowDoing and Label2 ---
        flowDoing.Width = (Panel2.Width - 2 * padding - spacing) \ 2
        flowDoing.Height = Panel2.Width / 3
        flowDoing.Left = flowToDo.Right + spacing
        flowDoing.Top = padding + Label2.Height + topSpacing

        Label2.Top = padding
        Label2.Left = flowDoing.Left + (flowDoing.Width - Label2.Width) \ 2  ' center over flowDoing

        ' --- Label3 below flowDoing ---
        Label3.Top = flowDoing.Bottom + topSpacing
        Label3.Left = flowDoing.Left

        ' --- flowDone below Label3 ---
        flowDone.Left = padding
        flowDone.Top = Label3.Bottom + topSpacing
        flowDone.Width = Panel2.Width - 2 * padding
        flowDone.Height = Panel2.Height - flowDone.Top - padding
    End Sub

    Private Sub AttachDragEvents(ctrl As Control)
        AddHandler ctrl.DragEnter, AddressOf flow_DragEnter
        AddHandler ctrl.DragDrop, AddressOf FlowDone_DragDrop

        ' For nested controls inside FlowDone
        For Each child As Control In ctrl.Controls
            AttachDragEvents(child)
        Next
    End Sub

    Private Function CreateTaskCard(row As DataRow) As Panel
        Dim card As New Panel With {
        .Width = 240,
        .Height = 140,
        .BorderStyle = BorderStyle.FixedSingle,
        .Margin = New Padding(6),
        .Tag = row("TaskID")
    }

        ' Title
        Dim lblTitle As New Label With {
        .Text = row("Title").ToString(),
        .Font = New Font("Segoe UI", 10, FontStyle.Bold),
        .AutoSize = False,
        .Width = 220,
        .Location = New Point(8, 8)
    }

        ' Assigned To
        Dim lblAssigned As New Label With {
        .Text = "By: " & row("AssignedTo").ToString(),
        .Location = New Point(8, 32)
    }

        Dim priority As String = row("Priority").ToString().Trim()

        Dim lblPriority As New Label With {
            .Text = "Priority: " & priority,
            .Width = 240,
            .Location = New Point(8, 52)
        }

        Select Case priority.ToLower()
            Case "high"
                lblPriority.ForeColor = Color.DarkRed

            Case "medium"
                lblPriority.ForeColor = Color.Blue

            Case Else
                lblPriority.ForeColor = Color.Green
        End Select
        ' Deadline
        Dim lblDeadline As New Label With {
        .Text = "Due: " & Convert.ToDateTime(row("Deadline")).ToString("MMM d"),
        .ForeColor = Color.DarkRed,
        .Location = New Point(8, 72)
    }

        ' --- NEW BUTTONS ---

        Dim btnEdit As New Button With {
        .Text = "Edit",
        .Width = 50,
        .Height = 25,
        .Location = New Point(10, 110)
    }
        AddHandler btnEdit.Click, Sub() EditTask(row("TaskID"))

        Dim btnDelete As New Button With {
        .Text = "Del",
        .Width = 50,
        .Height = 25,
        .Location = New Point(70, 110)
    }
        AddHandler btnDelete.Click, Sub() DeleteTask(row("TaskID"), card)

        ' Add controls
        card.Controls.Add(lblTitle)
        card.Controls.Add(lblAssigned)
        card.Controls.Add(lblDeadline)
        card.Controls.Add(lblPriority)
        card.Controls.Add(btnEdit)
        card.Controls.Add(btnDelete)

        ' Allow drag
        AddHandler card.MouseDown, Sub(s, e)
                                       If e.Button = MouseButtons.Left Then
                                           ' Explicitly pass as Panel
                                           card.DoDragDrop(CType(card, Panel), DragDropEffects.Move)
                                       End If
                                   End Sub

        ' Double-Click
        For Each c As Control In card.Controls
            AddHandler c.DoubleClick, Sub() ShowTaskDetails(row("TaskID"))
        Next
        AddHandler card.DoubleClick, Sub() ShowTaskDetails(row("TaskID"))
        Return card
    End Function
    Private Sub EditTask(taskID As Integer)
        Dim f As New FormEditTask(taskID)
        If f.ShowDialog() = DialogResult.OK Then
            LoadTasksForProject(currentProjectID)
        End If
    End Sub
    Private Sub ShowTaskDetails(taskID As Integer)
        Dim f As New FormTaskDetails(taskID)
        f.ShowDialog()
    End Sub

    Private Sub LoadTasksForProject(projectID As Integer)
        'Clear old tasks
        flowToDo.Controls.Clear()
        flowDoing.Controls.Clear()
        flowDone.Controls.Clear()

        Dim sql As String =
        "SELECT * FROM Tasks WHERE ProjectID = @pid ORDER BY CreatedAt DESC"

        Dim dt = MysqlCon.ExecuteReader(sql, {
        New MySqlParameter("@pid", projectID)
    })

        For Each row As DataRow In dt.Rows
            Dim card = CreateTaskCard(row)

            Select Case row("Status").ToString()
                Case "To-Do"
                    flowToDo.Controls.Add(card)

                Case "Doing"
                    flowDoing.Controls.Add(card)

                Case "Done"
                    flowDone.Controls.Add(card)
            End Select
        Next
    End Sub


    Private Sub SaveHistory(taskID As Integer, action As String)
        Dim sql = "INSERT INTO TaskHistory (TaskID, Action, ChangedAt)
               VALUES (@id, @action, NOW())"

        MysqlCon.ExecuteNonQuery(sql, {
        New MySqlParameter("@id", taskID),
        New MySqlParameter("@action", action)
    })
    End Sub

    Private Sub DeleteTask(taskID As Integer, card As Panel)
        If MessageBox.Show("Delete this task?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Dim sql = "DELETE FROM Tasks WHERE TaskID = @id"
            MysqlCon.ExecuteNonQuery(sql, {
            New MySqlParameter("@id", taskID)
        })
            ' Remove from UI
            If card.Parent IsNot Nothing Then
                card.Parent.Controls.Remove(card)
            End If
        End If
    End Sub



    Private Sub LoadBoard(projectID As Integer)
        flowToDo.Controls.Clear()
        flowDoing.Controls.Clear()
        flowDone.Controls.Clear()

        Dim dt As DataTable = GetTasksForProject(projectID)
        For Each r As DataRow In dt.Rows
            Dim card = CreateTaskCard(r)
            Dim status = r("Status").ToString()
            Select Case status
                Case "To-Do"
                    flowToDo.Controls.Add(card)
                Case "Doing"
                    flowDoing.Controls.Add(card)
                Case "Done"
                    flowDone.Controls.Add(card)
            End Select
        Next
    End Sub

    Private Sub FlowDone_DragDrop(sender As Object, e As DragEventArgs)
        ' Only process if sender is FlowDone itself
        If Not TypeOf sender Is FlowLayoutPanel Then Exit Sub

        ' Get the dragged card
        Dim draggedCard As Panel = TryCast(e.Data.GetData(GetType(Panel)), Panel)
        If draggedCard Is Nothing Then Exit Sub

        ' Prevent double processing
        Static lastCard As Panel = Nothing
        If lastCard Is draggedCard Then Exit Sub
        lastCard = draggedCard

        ' Mandatory file upload
        Dim ofd As New OpenFileDialog() With {
        .Title = "Upload required file",
        .Filter = "All Files (*.*)|*.*"
    }

        If ofd.ShowDialog() = DialogResult.OK Then
            If draggedCard.Parent IsNot Nothing Then draggedCard.Parent.Controls.Remove(draggedCard)
            flowDone.Controls.Add(draggedCard)
            UpdateTaskStatus(draggedCard.Tag, "Done", ofd.FileName)
            SaveHistory(draggedCard.Tag, "Moved to Done")
        Else
            MessageBox.Show("You must upload a file.")
            If draggedCard.Parent IsNot Nothing Then draggedCard.Parent.Controls.Remove(draggedCard)
            flowDoing.Controls.Add(draggedCard)
        End If

        ' Reset after short delay
        Dim t As New System.Windows.Forms.Timer()
        t.Interval = 100

        AddHandler t.Tick, Sub()
                               lastCard = Nothing
                               t.Stop()
                               t.Dispose()
                           End Sub

        t.Start()
    End Sub


    'On FlowPanel DragEnter
    Private Sub flow_DragEnter(sender As Object, e As DragEventArgs)
        If e.Data.GetDataPresent(GetType(Panel)) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' On FlowPanel DragDrop
    Private Sub flow_DragDrop(sender As Object, e As DragEventArgs)
        Dim targetFlow = CType(sender, FlowLayoutPanel)
        Dim card = CType(e.Data.GetData(GetType(Panel)), Panel)
        If card Is Nothing Then Return

        ' Remove from old parent and add to new
        Dim oldParent = CType(card.Parent, FlowLayoutPanel)
        If oldParent IsNot Nothing Then oldParent.Controls.Remove(card)
        targetFlow.Controls.Add(card)

        ' Update DB
        Dim taskID = Convert.ToInt32(card.Tag)
        Dim newStatus = "To-Do"
        If targetFlow Is flowDoing Then newStatus = "Doing"
        If targetFlow Is flowDone Then newStatus = "Done"
        SaveHistory(taskID, "Moved to " & newStatus)
        UpdateTaskStatus(taskID, newStatus)
    End Sub

    Private Sub lstProjects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProjects.SelectedIndexChanged
        If lstProjects.SelectedItem Is Nothing Then Return

        Dim rowView = CType(lstProjects.SelectedItem, DataRowView)
        currentProjectID = Convert.ToInt32(rowView("ProjectID"))

        LoadBoard(currentProjectID)
    End Sub

    Private Sub AddProj_Click(sender As Object, e As EventArgs) Handles AddProj.Click
        AddProject.Show()
    End Sub

    Private Sub AddTsk_Click(sender As Object, e As EventArgs) Handles AddTsk.Click
        addTask.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadProjects()
    End Sub

    Private Sub CreateTask_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        adjustLayout()
    End Sub

    Private Sub CreateTask_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not LogoutFl Then
            FrmMysql.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not PlnUserDetails.Visible Then
            Dim sql As String = "SELECT MailId from userdetails WHERE UserName=@UserName"
            Dim dt = MysqlCon.ExecuteReader(sql,
                     {New MySqlParameter("@UserName", UserName)})
            If dt.Rows.Count = 0 Then Exit Sub
            Dim row = dt.Rows(0)
            lblUserName.Text = UserName
            lblMobNo.Text = row("MailId").ToString()
            UserMobNumber = lblMobNo.Text
            PlnUserDetails.Visible = True
        Else
            PlnUserDetails.Visible = False
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not Panel3.Visible Then
            ' Show sidebar
            slidingIn = True
            slidingOut = False
            Panel3.Visible = True
        Else
            ' Hide sidebar
            slidingIn = False
            slidingOut = True
        End If

        Timer1.Interval = 10
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Const stepPx As Integer = 10

        If slidingIn Then
            Panel3.Left = Math.Min(0, Panel3.Left + stepPx)
            Panel3.BringToFront()

            If Panel3.Left >= 0 Then
                Timer1.Stop()
                slidingIn = False
            End If

        ElseIf slidingOut Then
            Panel3.Left = Math.Max(-Panel3.Width, Panel3.Left - stepPx)
            Panel3.BringToFront()

            If Panel3.Left <= -Panel3.Width Then
                Panel3.Visible = False
                Timer1.Stop()
                slidingOut = False
            End If
        End If
    End Sub

    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        LogoutFl = True
        UserName = ""
        LogIn.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DashBoard.Show()
    End Sub
End Class
