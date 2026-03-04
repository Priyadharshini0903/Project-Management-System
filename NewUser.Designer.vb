<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUser
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
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        TextBox3 = New TextBox()
        Label4 = New Label()
        TextBox4 = New TextBox()
        Label5 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        TextBox2.Location = New Point(175, 146)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "●"c
        TextBox2.Size = New Size(211, 26)
        TextBox2.TabIndex = 17
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        TextBox1.Location = New Point(175, 61)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(211, 26)
        TextBox1.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(21, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 22)
        Label3.TabIndex = 15
        Label3.Text = "Password:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(21, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 22)
        Label2.TabIndex = 14
        Label2.Text = "Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 18F, FontStyle.Bold Or FontStyle.Underline)
        Label1.ForeColor = Color.DarkRed
        Label1.Location = New Point(105, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(203, 29)
        Label1.TabIndex = 13
        Label1.Text = "Create New User"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(122), CByte(170), CByte(206))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(175, 229)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 27)
        Button1.TabIndex = 12
        Button1.Text = "Create User"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        TextBox3.Location = New Point(175, 184)
        TextBox3.Name = "TextBox3"
        TextBox3.PasswordChar = "●"c
        TextBox3.Size = New Size(211, 26)
        TextBox3.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(21, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(153, 22)
        Label4.TabIndex = 18
        Label4.Text = "Confrim Password:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        TextBox4.Location = New Point(175, 102)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(211, 26)
        TextBox4.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(21, 106)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 22)
        Label5.TabIndex = 20
        Label5.Text = "Email Id:"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Window
        Button2.BackgroundImage = My.Resources.Resources.eye_regular_full
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = SystemColors.Window
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        Button2.Location = New Point(356, 188)
        Button2.Name = "Button2"
        Button2.Size = New Size(26, 18)
        Button2.TabIndex = 22
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Window
        Button3.BackgroundImage = My.Resources.Resources.eye_slash_regular_full
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = SystemColors.Window
        Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        Button3.Location = New Point(356, 187)
        Button3.Name = "Button3"
        Button3.Size = New Size(26, 18)
        Button3.TabIndex = 23
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.Window
        Button4.BackgroundImage = My.Resources.Resources.eye_slash_regular_full
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = SystemColors.Window
        Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        Button4.Location = New Point(356, 150)
        Button4.Name = "Button4"
        Button4.Size = New Size(26, 18)
        Button4.TabIndex = 24
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.Window
        Button5.BackgroundImage = My.Resources.Resources.eye_regular_full
        Button5.BackgroundImageLayout = ImageLayout.Stretch
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseDownBackColor = SystemColors.Window
        Button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        Button5.Location = New Point(356, 150)
        Button5.Name = "Button5"
        Button5.Size = New Size(26, 18)
        Button5.TabIndex = 25
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Trebuchet MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Maroon
        Label6.Location = New Point(60, 229)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 16)
        Label6.TabIndex = 26
        Label6.Text = "Note:"
        Label6.Visible = False
        ' 
        ' NewUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(409, 290)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Controls.Add(Label6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "NewUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NewUser"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label6 As Label
End Class
