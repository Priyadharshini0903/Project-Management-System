<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditTask
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
        txtTitle = New TextBox()
        txtAssigned = New TextBox()
        cmbPriority = New ComboBox()
        cmbStatus = New ComboBox()
        dtDeadline = New DateTimePicker()
        btnSave = New Button()
        btnCancel = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' txtTitle
        ' 
        txtTitle.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        txtTitle.Location = New Point(164, 53)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(270, 26)
        txtTitle.TabIndex = 0
        ' 
        ' txtAssigned
        ' 
        txtAssigned.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        txtAssigned.Location = New Point(164, 97)
        txtAssigned.Name = "txtAssigned"
        txtAssigned.Size = New Size(270, 26)
        txtAssigned.TabIndex = 1
        ' 
        ' cmbPriority
        ' 
        cmbPriority.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        cmbPriority.FormattingEnabled = True
        cmbPriority.Location = New Point(164, 144)
        cmbPriority.Name = "cmbPriority"
        cmbPriority.Size = New Size(270, 30)
        cmbPriority.TabIndex = 2
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(164, 182)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(270, 30)
        cmbStatus.TabIndex = 3
        ' 
        ' dtDeadline
        ' 
        dtDeadline.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        dtDeadline.Location = New Point(164, 235)
        dtDeadline.Name = "dtDeadline"
        dtDeadline.Size = New Size(270, 26)
        dtDeadline.TabIndex = 4
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(122), CByte(170), CByte(206))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        btnSave.Location = New Point(176, 289)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(89, 32)
        btnSave.TabIndex = 5
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(122), CByte(170), CByte(206))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        btnCancel.Location = New Point(298, 289)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(92, 32)
        btnCancel.TabIndex = 6
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 18F, FontStyle.Bold Or FontStyle.Underline)
        Label1.ForeColor = Color.DarkRed
        Label1.Location = New Point(237, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 29)
        Label1.TabIndex = 7
        Label1.Text = "Edit Task"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        Label2.Location = New Point(37, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 22)
        Label2.TabIndex = 8
        Label2.Text = "Title"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        Label3.Location = New Point(37, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 22)
        Label3.TabIndex = 9
        Label3.Text = "Assigned To"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        Label4.Location = New Point(37, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 22)
        Label4.TabIndex = 10
        Label4.Text = "Priority"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        Label5.Location = New Point(37, 186)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 22)
        Label5.TabIndex = 11
        Label5.Text = "Status"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        Label6.Location = New Point(37, 239)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 22)
        Label6.TabIndex = 12
        Label6.Text = "Deadline"
        ' 
        ' FormEditTask
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(489, 342)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(dtDeadline)
        Controls.Add(cmbStatus)
        Controls.Add(cmbPriority)
        Controls.Add(txtAssigned)
        Controls.Add(txtTitle)
        Name = "FormEditTask"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormEditTask"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAssigned As TextBox
    Friend WithEvents cmbPriority As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents dtDeadline As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
