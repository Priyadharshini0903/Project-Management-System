<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateTask
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
        components = New ComponentModel.Container()
        lstProjects = New ListBox()
        AddProj = New Button()
        AddTsk = New Button()
        Panel1 = New Panel()
        Button4 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Button3 = New Button()
        Panel2 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        flowDoing = New FlowLayoutPanel()
        flowDone = New FlowLayoutPanel()
        flowToDo = New FlowLayoutPanel()
        Panel3 = New Panel()
        PlnUserDetails = New Panel()
        BtnLogOut = New Button()
        lblMobNo = New Label()
        lblUserName = New Label()
        Panel4 = New Panel()
        Label6 = New Label()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        PlnUserDetails.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' lstProjects
        ' 
        lstProjects.BackColor = Color.FromArgb(CByte(213), CByte(216), CByte(220))
        lstProjects.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstProjects.FormattingEnabled = True
        lstProjects.ItemHeight = 18
        lstProjects.Location = New Point(8, 45)
        lstProjects.Name = "lstProjects"
        lstProjects.Size = New Size(215, 400)
        lstProjects.TabIndex = 1
        ' 
        ' AddProj
        ' 
        AddProj.FlatAppearance.BorderSize = 0
        AddProj.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        AddProj.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        AddProj.FlatStyle = FlatStyle.Flat
        AddProj.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        AddProj.Location = New Point(74, 4)
        AddProj.Name = "AddProj"
        AddProj.Size = New Size(119, 29)
        AddProj.TabIndex = 2
        AddProj.Text = "Add Project"
        AddProj.UseVisualStyleBackColor = False
        ' 
        ' AddTsk
        ' 
        AddTsk.FlatAppearance.BorderSize = 0
        AddTsk.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        AddTsk.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        AddTsk.FlatStyle = FlatStyle.Flat
        AddTsk.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        AddTsk.Location = New Point(199, 4)
        AddTsk.Name = "AddTsk"
        AddTsk.Size = New Size(107, 29)
        AddTsk.TabIndex = 3
        AddTsk.Text = "Add Task"
        AddTsk.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(122), CByte(170), CByte(206))
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(AddProj)
        Panel1.Controls.Add(AddTsk)
        Panel1.Location = New Point(-3, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(807, 38)
        Panel1.TabIndex = 4
        ' 
        ' Button4
        ' 
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        Button4.Location = New Point(463, 5)
        Button4.Name = "Button4"
        Button4.Size = New Size(127, 29)
        Button4.TabIndex = 6
        Button4.Text = "DashBoard"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = My.Resources.Resources.list_solid_full
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        Button2.Location = New Point(11, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(22, 28)
        Button2.TabIndex = 5
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        Button1.Location = New Point(312, 6)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 29)
        Button1.TabIndex = 4
        Button1.Text = "Refresh"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = My.Resources.Resources.user_solid_full
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        Button3.Location = New Point(179, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(41, 28)
        Button3.TabIndex = 6
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ScrollBar
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(flowDoing)
        Panel2.Controls.Add(flowDone)
        Panel2.Controls.Add(flowToDo)
        Panel2.Location = New Point(237, 44)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(567, 394)
        Panel2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(272, 227)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 22)
        Label3.TabIndex = 6
        Label3.Text = "Done"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(387, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 22)
        Label2.TabIndex = 5
        Label2.Text = "Doing"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(126, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 22)
        Label1.TabIndex = 4
        Label1.Text = "To-Do"
        ' 
        ' flowDoing
        ' 
        flowDoing.AllowDrop = True
        flowDoing.AutoScroll = True
        flowDoing.BackColor = Color.FromArgb(CByte(213), CByte(216), CByte(220))
        flowDoing.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Bold)
        flowDoing.Location = New Point(292, 42)
        flowDoing.Name = "flowDoing"
        flowDoing.Size = New Size(265, 171)
        flowDoing.TabIndex = 1
        ' 
        ' flowDone
        ' 
        flowDone.AllowDrop = True
        flowDone.AutoScroll = True
        flowDone.BackColor = Color.FromArgb(CByte(213), CByte(216), CByte(220))
        flowDone.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Bold)
        flowDone.Location = New Point(10, 252)
        flowDone.Name = "flowDone"
        flowDone.Size = New Size(547, 130)
        flowDone.TabIndex = 2
        ' 
        ' flowToDo
        ' 
        flowToDo.AllowDrop = True
        flowToDo.AutoScroll = True
        flowToDo.BackColor = Color.FromArgb(CByte(213), CByte(216), CByte(220))
        flowToDo.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        flowToDo.Location = New Point(10, 42)
        flowToDo.Name = "flowToDo"
        flowToDo.Size = New Size(276, 172)
        flowToDo.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(213), CByte(216), CByte(220))
        Panel3.Controls.Add(PlnUserDetails)
        Panel3.Controls.Add(Panel4)
        Panel3.Location = New Point(102, 44)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(223, 400)
        Panel3.TabIndex = 7
        Panel3.Visible = False
        ' 
        ' PlnUserDetails
        ' 
        PlnUserDetails.BackColor = Color.Gainsboro
        PlnUserDetails.Controls.Add(BtnLogOut)
        PlnUserDetails.Controls.Add(lblMobNo)
        PlnUserDetails.Controls.Add(lblUserName)
        PlnUserDetails.Location = New Point(37, 38)
        PlnUserDetails.Name = "PlnUserDetails"
        PlnUserDetails.Size = New Size(183, 90)
        PlnUserDetails.TabIndex = 8
        PlnUserDetails.Visible = False
        ' 
        ' BtnLogOut
        ' 
        BtnLogOut.FlatAppearance.BorderSize = 0
        BtnLogOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(152), CByte(112), CByte(112))
        BtnLogOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(195), CByte(152), CByte(152))
        BtnLogOut.FlatStyle = FlatStyle.Flat
        BtnLogOut.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnLogOut.ForeColor = Color.Red
        BtnLogOut.Location = New Point(3, 55)
        BtnLogOut.Name = "BtnLogOut"
        BtnLogOut.Size = New Size(127, 26)
        BtnLogOut.TabIndex = 7
        BtnLogOut.Text = "Log Out"
        BtnLogOut.TextAlign = ContentAlignment.MiddleLeft
        BtnLogOut.UseVisualStyleBackColor = False
        ' 
        ' lblMobNo
        ' 
        lblMobNo.AutoSize = True
        lblMobNo.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMobNo.Location = New Point(3, 31)
        lblMobNo.Name = "lblMobNo"
        lblMobNo.Size = New Size(64, 18)
        lblMobNo.TabIndex = 6
        lblMobNo.Text = "MobileNo"
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUserName.Location = New Point(3, 4)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(70, 18)
        lblUserName.TabIndex = 5
        lblUserName.Text = "UserName"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(122), CByte(170), CByte(206))
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(Button3)
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(223, 35)
        Panel4.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(96, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 18)
        Label6.TabIndex = 7
        Label6.Text = "UserDetails"
        ' 
        ' Timer1
        ' 
        ' 
        ' CreateTask
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(816, 449)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(lstProjects)
        Name = "CreateTask"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CreateTask"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        PlnUserDetails.ResumeLayout(False)
        PlnUserDetails.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents lstProjects As ListBox
    Friend WithEvents AddProj As Button
    Friend WithEvents AddTsk As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents flowDoing As FlowLayoutPanel
    Friend WithEvents flowDone As FlowLayoutPanel
    Friend WithEvents flowToDo As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PlnUserDetails As Panel
    Friend WithEvents lblMobNo As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnLogOut As Button
    Friend WithEvents Button4 As Button
End Class
