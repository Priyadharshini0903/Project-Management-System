<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTaskDetails
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
        dgvHistory = New DataGridView()
        Label4 = New Label()
        Panel1 = New Panel()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblUpdated = New Label()
        lblCreated = New Label()
        lblStatus = New Label()
        lblPriority = New Label()
        lblDeadline = New Label()
        lblAssigned = New Label()
        lblDescription = New Label()
        lblTitle = New Label()
        lblProjectName = New Label()
        CType(dgvHistory, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvHistory
        ' 
        dgvHistory.BackgroundColor = SystemColors.ScrollBar
        dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHistory.Location = New Point(32, 362)
        dgvHistory.Name = "dgvHistory"
        dgvHistory.Size = New Size(752, 187)
        dgvHistory.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Trebuchet MS", 18F, FontStyle.Bold Or FontStyle.Underline)
        Label4.ForeColor = Color.DarkRed
        Label4.Location = New Point(324, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 29)
        Label4.TabIndex = 10
        Label4.Text = "Task Details"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ScrollBar
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lblUpdated)
        Panel1.Controls.Add(lblCreated)
        Panel1.Controls.Add(lblStatus)
        Panel1.Controls.Add(lblPriority)
        Panel1.Controls.Add(lblDeadline)
        Panel1.Controls.Add(lblAssigned)
        Panel1.Controls.Add(lblDescription)
        Panel1.Controls.Add(lblTitle)
        Panel1.Controls.Add(lblProjectName)
        Panel1.Location = New Point(32, 48)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(752, 299)
        Panel1.TabIndex = 20
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Label10.Location = New Point(41, 270)
        Label10.Name = "Label10"
        Label10.Size = New Size(95, 20)
        Label10.TabIndex = 37
        Label10.Text = "Updated At:"
        Label10.Visible = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Label9.Location = New Point(312, 47)
        Label9.Name = "Label9"
        Label9.Size = New Size(91, 20)
        Label9.TabIndex = 36
        Label9.Text = "Created At:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Label8.Location = New Point(312, 13)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 20)
        Label8.TabIndex = 35
        Label8.Text = "Status:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Label7.Location = New Point(24, 167)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 20)
        Label7.TabIndex = 34
        Label7.Text = "Priority:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Label6.Location = New Point(24, 132)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 20)
        Label6.TabIndex = 33
        Label6.Text = "Deadline:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Label5.Location = New Point(24, 91)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 20)
        Label5.TabIndex = 32
        Label5.Text = "Assigned to:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Label3.Location = New Point(313, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 20)
        Label3.TabIndex = 31
        Label3.Text = "Description:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(24, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 30
        Label2.Text = "Title:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        Label1.Location = New Point(24, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 20)
        Label1.TabIndex = 29
        Label1.Text = "Project Name:"
        ' 
        ' lblUpdated
        ' 
        lblUpdated.AutoSize = True
        lblUpdated.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        lblUpdated.Location = New Point(154, 272)
        lblUpdated.Name = "lblUpdated"
        lblUpdated.Size = New Size(56, 20)
        lblUpdated.TabIndex = 28
        lblUpdated.Text = "Label6"
        lblUpdated.Visible = False
        ' 
        ' lblCreated
        ' 
        lblCreated.AutoSize = True
        lblCreated.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        lblCreated.Location = New Point(425, 47)
        lblCreated.Name = "lblCreated"
        lblCreated.Size = New Size(56, 20)
        lblCreated.TabIndex = 27
        lblCreated.Text = "Label6"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        lblStatus.Location = New Point(425, 13)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(56, 20)
        lblStatus.TabIndex = 26
        lblStatus.Text = "Label6"
        ' 
        ' lblPriority
        ' 
        lblPriority.AutoSize = True
        lblPriority.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        lblPriority.Location = New Point(153, 167)
        lblPriority.Name = "lblPriority"
        lblPriority.Size = New Size(56, 20)
        lblPriority.TabIndex = 25
        lblPriority.Text = "Label6"
        ' 
        ' lblDeadline
        ' 
        lblDeadline.AutoSize = True
        lblDeadline.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        lblDeadline.Location = New Point(153, 132)
        lblDeadline.Name = "lblDeadline"
        lblDeadline.Size = New Size(56, 20)
        lblDeadline.TabIndex = 24
        lblDeadline.Text = "Label5"
        ' 
        ' lblAssigned
        ' 
        lblAssigned.AutoSize = True
        lblAssigned.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        lblAssigned.Location = New Point(153, 91)
        lblAssigned.Name = "lblAssigned"
        lblAssigned.Size = New Size(56, 20)
        lblAssigned.TabIndex = 23
        lblAssigned.Text = "Label4"
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        lblDescription.Location = New Point(425, 78)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(56, 20)
        lblDescription.TabIndex = 22
        lblDescription.Text = "Label3"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        lblTitle.Location = New Point(153, 52)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(56, 20)
        lblTitle.TabIndex = 21
        lblTitle.Text = "Label2"
        ' 
        ' lblProjectName
        ' 
        lblProjectName.AutoSize = True
        lblProjectName.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold)
        lblProjectName.Location = New Point(153, 13)
        lblProjectName.Name = "lblProjectName"
        lblProjectName.Size = New Size(56, 20)
        lblProjectName.TabIndex = 20
        lblProjectName.Text = "Label1"
        ' 
        ' FormTaskDetails
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(796, 561)
        Controls.Add(Panel1)
        Controls.Add(Label4)
        Controls.Add(dgvHistory)
        Name = "FormTaskDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormTaskDetails"
        CType(dgvHistory, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUpdated As Label
    Friend WithEvents lblCreated As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblPriority As Label
    Friend WithEvents lblDeadline As Label
    Friend WithEvents lblAssigned As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblProjectName As Label
End Class
