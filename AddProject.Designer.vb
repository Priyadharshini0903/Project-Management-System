<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProject
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
        TxtDesp = New TextBox()
        TxtProjName = New TextBox()
        EndingDate = New DateTimePicker()
        StartingDate = New DateTimePicker()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' TxtDesp
        ' 
        TxtDesp.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        TxtDesp.Location = New Point(128, 158)
        TxtDesp.Multiline = True
        TxtDesp.Name = "TxtDesp"
        TxtDesp.Size = New Size(281, 90)
        TxtDesp.TabIndex = 17
        ' 
        ' TxtProjName
        ' 
        TxtProjName.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        TxtProjName.Location = New Point(128, 62)
        TxtProjName.Name = "TxtProjName"
        TxtProjName.Size = New Size(281, 25)
        TxtProjName.TabIndex = 16
        ' 
        ' EndingDate
        ' 
        EndingDate.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        EndingDate.Location = New Point(128, 129)
        EndingDate.Name = "EndingDate"
        EndingDate.Size = New Size(281, 25)
        EndingDate.TabIndex = 15
        ' 
        ' StartingDate
        ' 
        StartingDate.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        StartingDate.Location = New Point(128, 95)
        StartingDate.Name = "StartingDate"
        StartingDate.Size = New Size(281, 25)
        StartingDate.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Label5.Location = New Point(16, 129)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 20)
        Label5.TabIndex = 13
        Label5.Text = "End Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Label4.Location = New Point(16, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 20)
        Label4.TabIndex = 12
        Label4.Text = "Description"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Label3.Location = New Point(18, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 20)
        Label3.TabIndex = 11
        Label3.Text = "StartDate"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Label2.Location = New Point(20, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 20)
        Label2.TabIndex = 10
        Label2.Text = "Project Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 18F, FontStyle.Bold Or FontStyle.Underline)
        Label1.ForeColor = Color.DarkRed
        Label1.Location = New Point(179, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 29)
        Label1.TabIndex = 9
        Label1.Text = "Add Project"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(122), CByte(170), CByte(206))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(154, 266)
        Button1.Name = "Button1"
        Button1.Size = New Size(191, 29)
        Button1.TabIndex = 18
        Button1.Text = "Add Project"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' AddProject
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(436, 323)
        Controls.Add(Button1)
        Controls.Add(TxtDesp)
        Controls.Add(TxtProjName)
        Controls.Add(EndingDate)
        Controls.Add(StartingDate)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AddProject"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddProject"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtDesp As TextBox
    Friend WithEvents TxtProjName As TextBox
    Friend WithEvents EndingDate As DateTimePicker
    Friend WithEvents StartingDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
