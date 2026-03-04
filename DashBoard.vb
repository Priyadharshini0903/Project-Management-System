Imports System.Windows.Forms.DataVisualization.Charting

Public Class DashBoard
    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGraphByProject()
    End Sub

    Private Sub LoadGraphByProject()
        Dim dt As DataTable = GetProjectPriorityCounts()

        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()

        Dim area = New DataVisualization.Charting.ChartArea("Main")
        Chart1.ChartAreas.Add(area)

        With area
            .AxisX.Interval = 1
            .AxisX.LabelStyle.Angle = 0
            .AxisX.Title = "Projects"
            .AxisY.Title = "Task Count"
            .BackColor = Color.FromArgb(245, 245, 245)
            .AxisX.MajorGrid.Enabled = False
            .AxisY.MajorGrid.Enabled = False
        End With

        Dim sHigh = Chart1.Series.Add("High")
        Dim sMedium = Chart1.Series.Add("Medium")
        Dim sLow = Chart1.Series.Add("Low")

        ' Common series settings
        For Each s In Chart1.Series
            s.ChartType = DataVisualization.Charting.SeriesChartType.Column
            s.IsValueShownAsLabel = True
            s.IsXValueIndexed = True
            s.IsValueShownAsLabel = False
            s.ChartArea = "Main"
        Next

        ' Add project data
        For Each row As DataRow In dt.Rows
            Dim projectName As String = row("ProjectName").ToString()
            Dim high = Convert.ToInt32(row("HighCount"))
            Dim medium = Convert.ToInt32(row("MediumCount"))
            Dim low = Convert.ToInt32(row("LowCount"))

            Dim idxHigh = sHigh.Points.AddXY(projectName, high)
            sHigh.Points(idxHigh).ToolTip = $"High: {high}"

            Dim idxMedium = sMedium.Points.AddXY(projectName, medium)
            sMedium.Points(idxMedium).ToolTip = $"Medium: {medium}"

            Dim idxLow = sLow.Points.AddXY(projectName, low)
            sLow.Points(idxLow).ToolTip = $"Low: {low}"
        Next
        ' Better legend placement
        Chart1.Legends(0).Docking = Docking.Top
    End Sub
    Private Function GetProjectPriorityCounts() As DataTable
        Dim SQL As String =
            "SELECT p.ProjectID,p.ProjectName,SUM(CASE WHEN t.priority='High' THEN 1 ELSE 0 END) AS HighCount,
            SUM(CASE WHEN t.priority='Medium' THEN 1 ELSE 0 END) AS MediumCount,
            SUM(CASE WHEN t.priority='Low' THEN 1 ELSE 0 END) AS LowCount
            FROM tasks t INNER JOIN projects p ON t.ProjectID = p.ProjectID GROUP BY p.ProjectID,
            p.ProjectName ORDER BY p.ProjectName"

        Return MysqlCon.ExecuteReader(SQL)
    End Function
    Private Sub Chart1_MouseClick(sender As Object, e As MouseEventArgs) Handles Chart1.MouseClick
        Dim result = Chart1.HitTest(e.X, e.Y)

        If result.ChartElementType = DataVisualization.Charting.ChartElementType.LegendItem Then
            Dim s = result.Series

            ' If already hidden, restore original color from Tag
            If s.Color = Color.Transparent Then
                If s.Tag IsNot Nothing Then
                    s.Color = CType(s.Tag, Color)
                End If
            Else
                ' Save current color and hide the series visually
                s.Tag = s.Color
                s.Color = Color.Transparent
            End If
        End If
    End Sub

    Private Sub DashBoard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Chart1.Width = Me.ClientSize.Width / 2
        Chart1.Height = Me.ClientSize.Height / 2
        Chart2.Width = Me.ClientSize.Width / 2
        Chart2.Height = Me.ClientSize.Height / 2
        Chart2.Left = Chart1.Width
    End Sub
End Class