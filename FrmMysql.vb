Public Class FrmMysql
    Dim host As String
    Dim UserName As String
    Dim Password As String
    Dim Port As String

    Private Sub Mysql_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Function InitializeDatabase() As Boolean
        Try
            Dim tempConn As New MySQLDBHelper(host, Port, "", UserName, Password)


            tempConn.ExecuteNonQuery("CREATE DATABASE IF NOT EXISTS ProjectManager")
            tempConn.CloseConnection()


            MysqlCon = New MySQLDBHelper(host, Port, "ProjectManager", UserName, Password)


            Dim createProjectsTable As String =
        "CREATE TABLE IF NOT EXISTS Projects (" &
        " ProjectID INT AUTO_INCREMENT PRIMARY KEY," &
        " ProjectName VARCHAR(200) NOT NULL," &
        " Description TEXT," &
        " StartDate DATE," &
        " EndDate DATE," &
        " Status ENUM('Active','Completed') DEFAULT 'Active'," &
        " CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP" &
        ")"

            MysqlCon.ExecuteNonQuery(createProjectsTable)


            Dim createTasksTable As String =
        "CREATE TABLE IF NOT EXISTS Tasks (" &
        " TaskID INT AUTO_INCREMENT PRIMARY KEY," &
        " ProjectID INT NOT NULL," &
        " Title VARCHAR(255) NOT NULL," &
        " AssignedTo VARCHAR(150)," &
        " Deadline DATE," &
        " Priority ENUM('High','Medium','Low') DEFAULT 'Medium'," &
        " Status ENUM('To-Do','Doing','Done') DEFAULT 'To-Do'," &
        " CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP," &
        " File VARCHAR(550)," &
        " FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID) ON DELETE CASCADE" &
        ")"
            MysqlCon.ExecuteNonQuery(createTasksTable)


            Dim TasksHistoryTable As String = "CREATE TABLE IF Not EXISTS TaskHistory (
                        HistoryID Int AUTO_INCREMENT PRIMARY KEY,
                        TaskID Int Not NULL,
                        Action VARCHAR(255),
                        ChangedAt DATETIME Default CURRENT_TIMESTAMP,
                        FOREIGN KEY(TaskID) REFERENCES Tasks(TaskID) ON DELETE CASCADE
                    );"
            MysqlCon.ExecuteNonQuery(TasksHistoryTable)


            Dim UserDetailsTable As String = "CREATE TABLE IF Not EXISTS UserDetails (
                        UserID Int AUTO_INCREMENT PRIMARY KEY,
                        UserName VARCHAR(255),
                        MailId VARCHAR(100) Not NULL,  
                        PassWord VARCHAR(255),
                        CreatedAt DATETIME Default CURRENT_TIMESTAMP               
                    );"
            MysqlCon.ExecuteNonQuery(UserDetailsTable)

            ShowToast("Database initialized successfully!")
            Return True

        Catch ex As Exception
            MessageBox.Show("Error initializing DB: " & ex.Message)
            Return False
        End Try
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        host = TextBox1.Text.Trim()
        UserName = TextBox2.Text.Trim()
        Password = TextBox3.Text.Trim()
        Port = TextBox4.Text.Trim()
        Dim CreateDB As Boolean = InitializeDatabase()
        If CreateDB Then
            LogIn.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles TextBox1.MouseEnter
        TextBox1.BackColor = Color.LightYellow     ' Hover color
    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles TextBox1.MouseLeave
        TextBox1.BackColor = Color.White           ' Normal color
    End Sub
    Private Sub TextBox2_MouseEnter(sender As Object, e As EventArgs) Handles TextBox2.MouseEnter
        TextBox2.BackColor = Color.LightYellow     ' Hover color
    End Sub

    Private Sub TextBox2_MouseLeave(sender As Object, e As EventArgs) Handles TextBox2.MouseLeave
        TextBox2.BackColor = Color.White           ' Normal color
    End Sub
    Private Sub TextBox3_MouseEnter(sender As Object, e As EventArgs) Handles TextBox3.MouseEnter
        TextBox3.BackColor = Color.LightYellow     ' Hover color
    End Sub

    Private Sub TextBox3_MouseLeave(sender As Object, e As EventArgs) Handles TextBox3.MouseLeave
        TextBox3.BackColor = Color.White           ' Normal color
    End Sub

End Class
