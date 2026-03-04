<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addTask
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Txtpriority = New TextBox()
        DeadlinePicker = New DateTimePicker()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Txttitle = New TextBox()
        Label1 = New Label()
        Txtassignedto = New TextBox()
        Label2 = New Label()
        Button1 = New Button()
        CmbProjectName = New ComboBox()
        SuspendLayout()
        ' 
        ' Txtpriority
        ' 
        Txtpriority.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Txtpriority.Location = New Point(124, 163)
        Txtpriority.Name = "Txtpriority"
        Txtpriority.Size = New Size(281, 25)
        Txtpriority.TabIndex = 8
        Txtpriority.TextAlign = HorizontalAlignment.Center
        ' 
        ' DeadlinePicker
        ' 
        DeadlinePicker.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        DeadlinePicker.Location = New Point(125, 202)
        DeadlinePicker.Name = "DeadlinePicker"
        DeadlinePicker.Size = New Size(281, 25)
        DeadlinePicker.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Label7.Location = New Point(12, 168)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 20)
        Label7.TabIndex = 3
        Label7.Text = "Priority"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Label8.Location = New Point(12, 204)
        Label8.Name = "Label8"
        Label8.Size = New Size(75, 20)
        Label8.TabIndex = 2
        Label8.Text = "DeadLine"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Label9.Location = New Point(12, 55)
        Label9.Name = "Label9"
        Label9.Size = New Size(106, 20)
        Label9.TabIndex = 1
        Label9.Text = "Project Name"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Trebuchet MS", 18F, FontStyle.Bold Or FontStyle.Underline)
        Label10.ForeColor = Color.DarkRed
        Label10.Location = New Point(171, 16)
        Label10.Name = "Label10"
        Label10.Size = New Size(111, 29)
        Label10.TabIndex = 0
        Label10.Text = "Add Task"
        ' 
        ' Txttitle
        ' 
        Txttitle.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Txttitle.Location = New Point(125, 91)
        Txttitle.Name = "Txttitle"
        Txttitle.Size = New Size(281, 25)
        Txttitle.TabIndex = 10
        Txttitle.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Label1.Location = New Point(12, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 20)
        Label1.TabIndex = 9
        Label1.Text = "Title"
        ' 
        ' Txtassignedto
        ' 
        Txtassignedto.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Txtassignedto.Location = New Point(125, 128)
        Txtassignedto.Name = "Txtassignedto"
        Txtassignedto.Size = New Size(281, 25)
        Txtassignedto.TabIndex = 12
        Txtassignedto.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Label2.Location = New Point(12, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 20)
        Label2.TabIndex = 11
        Label2.Text = "Assigned To"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(122), CByte(170), CByte(206))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(153, 255)
        Button1.Name = "Button1"
        Button1.Size = New Size(191, 29)
        Button1.TabIndex = 19
        Button1.Text = "Add Task"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' CmbProjectName
        ' 
        CmbProjectName.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        CmbProjectName.FormattingEnabled = True
        CmbProjectName.Location = New Point(124, 56)
        CmbProjectName.Name = "CmbProjectName"
        CmbProjectName.Size = New Size(282, 28)
        CmbProjectName.TabIndex = 20
        ' 
        ' addTask
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(433, 305)
        Controls.Add(CmbProjectName)
        Controls.Add(Button1)
        Controls.Add(Txtassignedto)
        Controls.Add(Label2)
        Controls.Add(Txttitle)
        Controls.Add(Label1)
        Controls.Add(Txtpriority)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(DeadlinePicker)
        Controls.Add(Label7)
        Name = "addTask"
        StartPosition = FormStartPosition.CenterScreen
        Text = "addTask"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Txtpriority As TextBox
    Friend WithEvents DeadlinePicker As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Txttitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtassignedto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CmbProjectName As ComboBox
End Class
