<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMysql
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        TextBox4 = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 18F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkRed
        Label1.Location = New Point(117, 9)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(250, 29)
        Label1.TabIndex = 0
        Label1.Text = "Database Connection"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 14.25F, FontStyle.Bold)
        Label2.ForeColor = Color.SaddleBrown
        Label2.Location = New Point(14, 66)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 24)
        Label2.TabIndex = 1
        Label2.Text = "Server Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Trebuchet MS", 14.25F, FontStyle.Bold)
        Label4.ForeColor = Color.SaddleBrown
        Label4.Location = New Point(14, 155)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 24)
        Label4.TabIndex = 3
        Label4.Text = "User Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Trebuchet MS", 14.25F, FontStyle.Bold)
        Label5.ForeColor = Color.SaddleBrown
        Label5.Location = New Point(14, 195)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 24)
        Label5.TabIndex = 5
        Label5.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Trebuchet MS", 14.25F, FontStyle.Bold)
        TextBox1.Location = New Point(149, 62)
        TextBox1.Margin = New Padding(5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(283, 30)
        TextBox1.TabIndex = 6
        TextBox1.Text = "localhost"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Trebuchet MS", 14.25F, FontStyle.Bold)
        TextBox2.Location = New Point(149, 150)
        TextBox2.Margin = New Padding(5)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(283, 30)
        TextBox2.TabIndex = 7
        TextBox2.Text = "root"
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(149, 192)
        TextBox3.Margin = New Padding(5)
        TextBox3.Name = "TextBox3"
        TextBox3.PasswordChar = "●"c
        TextBox3.Size = New Size(283, 30)
        TextBox3.TabIndex = 8
        TextBox3.Text = "abc123!@"
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(122), CByte(170), CByte(206))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(149, 245)
        Button1.Name = "Button1"
        Button1.Size = New Size(283, 34)
        Button1.TabIndex = 11
        Button1.Text = "OK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Trebuchet MS", 14.25F, FontStyle.Bold)
        TextBox4.Location = New Point(149, 105)
        TextBox4.Margin = New Padding(5)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(283, 30)
        TextBox4.TabIndex = 13
        TextBox4.Text = "3306"
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 14.25F, FontStyle.Bold)
        Label3.ForeColor = Color.SaddleBrown
        Label3.Location = New Point(14, 109)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 24)
        Label3.TabIndex = 12
        Label3.Text = "Port"
        ' 
        ' FrmMysql
        ' 
        AutoScaleDimensions = New SizeF(11F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(464, 297)
        Controls.Add(TextBox4)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Trebuchet MS", 14.25F, FontStyle.Bold)
        Margin = New Padding(5)
        Name = "FrmMysql"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mysql"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label

End Class
