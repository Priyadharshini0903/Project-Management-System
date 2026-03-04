Public Class ToastForm
    Private WithEvents displayTimer As New Timer()
    Private WithEvents fadeTimer As New Timer()

    Public Sub New(message As String)
        InitializeComponent()

        Me.FormBorderStyle = FormBorderStyle.None
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        Me.Opacity = 0.9
        Me.Width = 300
        Me.Height = 30
        Me.ShowInTaskbar = False

        Dim lbl As New Label()
        lbl.Text = message
        lbl.ForeColor = Color.White
        lbl.Font = New Font("Trebuchet MS", 10, FontStyle.Bold)
        lbl.AutoSize = False
        lbl.Dock = DockStyle.Fill
        lbl.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(lbl)

        displayTimer.Interval = 1000
        displayTimer.Start()

        fadeTimer.Interval = 50
    End Sub


    Private Sub displayTimer_Tick(sender As Object, e As EventArgs) Handles displayTimer.Tick
        displayTimer.Stop()
        fadeTimer.Start()
    End Sub


    Private Sub fadeTimer_Tick(sender As Object, e As EventArgs) Handles fadeTimer.Tick
        If Me.Opacity > 0 Then
            Me.Opacity -= 0.05
        Else
            fadeTimer.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub ToastForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

