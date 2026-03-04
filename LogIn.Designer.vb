<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        LinkLabel1 = New LinkLabel()
        Button5 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(122), CByte(170), CByte(206))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        Button1.Location = New Point(43, 135)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 29)
        Button1.TabIndex = 5
        Button1.Text = "Log In"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 18F, FontStyle.Bold Or FontStyle.Underline)
        Label1.ForeColor = Color.DarkRed
        Label1.Location = New Point(92, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 29)
        Label1.TabIndex = 6
        Label1.Text = "User Log In"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 22)
        Label2.TabIndex = 7
        Label2.Text = "Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 22)
        Label3.TabIndex = 8
        Label3.Text = "Password:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        TextBox1.Location = New Point(103, 46)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(211, 26)
        TextBox1.TabIndex = 10
        TextBox1.Text = "Priya"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        TextBox2.Location = New Point(103, 86)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "●"c
        TextBox2.Size = New Size(211, 26)
        TextBox2.TabIndex = 11
        TextBox2.Text = "Priya123"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.Blue
        LinkLabel1.Location = New Point(185, 141)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(72, 18)
        LinkLabel1.TabIndex = 12
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "New User?"
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
        Button5.Location = New Point(286, 91)
        Button5.Name = "Button5"
        Button5.Size = New Size(26, 18)
        Button5.TabIndex = 28
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.Window
        Button4.BackgroundImage = My.Resources.Resources.eye_slash_regular_full
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(152), CByte(112), CByte(112))
        Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(195), CByte(152), CByte(152))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold)
        Button4.Location = New Point(286, 91)
        Button4.Name = "Button4"
        Button4.Size = New Size(26, 18)
        Button4.TabIndex = 27
        Button4.UseVisualStyleBackColor = False
        ' 
        ' LogIn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(333, 177)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(LinkLabel1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "LogIn"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LogIn"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
End Class
