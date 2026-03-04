Imports System.Net

Module Module1
    Public MysqlCon As MySQLDBHelper
    Public UserName As String
    Public UserMobNumber As String
    Public Sub ShowToast(msg As String)
        Dim toast As New ToastForm(msg)

        toast.StartPosition = FormStartPosition.Manual

        ' Calculate bottom-center position
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height

        Dim x As Integer = (screenWidth - toast.Width) \ 2
        Dim y As Integer = screenHeight - toast.Height - 20

        toast.Location = New Point(x, y)

        toast.TopMost = True
        toast.Show()
    End Sub


End Module




