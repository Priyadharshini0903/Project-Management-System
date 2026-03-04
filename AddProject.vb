Imports MySql.Data.MySqlClient

Public Class AddProject
    Dim ProjectName As String
    Dim Description As String
    Dim StartDate As String
    Dim EndDate As String
    Public Sub AddProject(projectName As String, description As String, startDate As DateTime?, endDate As DateTime?)
        Dim sql = "INSERT INTO Projects (ProjectName, Description, StartDate, EndDate) VALUES (@name,@desc,@startDate,@endDate)"
        Dim Parameters As MySqlParameter() = {
               New MySqlParameter("@name", projectName),
               New MySqlParameter("@desc", description),
               New MySqlParameter("@startDate", If(startDate.HasValue, startDate.Value.ToString("yyyy-MM-dd"), DBNull.Value)),
               New MySqlParameter("@endDate", If(endDate.HasValue, endDate.Value.ToString("yyyy-MM-dd"), DBNull.Value))
            }
        MysqlCon.ExecuteNonQuery(sql, Parameters)
        ShowToast("Project Added Successfully")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProjectName = TxtProjName.Text
        Description = TxtDesp.Text
        StartDate = StartingDate.Value
        EndDate = EndingDate.Value
        AddProject(ProjectName, Description, StartDate, EndDate)
    End Sub


End Class