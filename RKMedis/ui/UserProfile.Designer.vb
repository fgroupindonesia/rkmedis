<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserProfile
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
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox_LogoPreview = New System.Windows.Forms.PictureBox()
        Me.Button_Reset = New System.Windows.Forms.Button()
        Me.Button_Change = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_ShowPassword = New System.Windows.Forms.CheckBox()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.TextBox_Username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox_SecurityAnswer = New System.Windows.Forms.TextBox()
        Me.TextBox_SecurityQuestion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox_LogoPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(453, 245)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(75, 23)
        Me.Button_Save.TabIndex = 0
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Button_Clear
        '
        Me.Button_Clear.Location = New System.Drawing.Point(534, 245)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 1
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox_LogoPreview)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 130)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Logo"
        '
        'PictureBox_LogoPreview
        '
        Me.PictureBox_LogoPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox_LogoPreview.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox_LogoPreview.Name = "PictureBox_LogoPreview"
        Me.PictureBox_LogoPreview.Size = New System.Drawing.Size(124, 111)
        Me.PictureBox_LogoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_LogoPreview.TabIndex = 0
        Me.PictureBox_LogoPreview.TabStop = False
        '
        'Button_Reset
        '
        Me.Button_Reset.Location = New System.Drawing.Point(96, 148)
        Me.Button_Reset.Name = "Button_Reset"
        Me.Button_Reset.Size = New System.Drawing.Size(75, 23)
        Me.Button_Reset.TabIndex = 4
        Me.Button_Reset.Text = "Reset"
        Me.Button_Reset.UseVisualStyleBackColor = True
        '
        'Button_Change
        '
        Me.Button_Change.Location = New System.Drawing.Point(15, 148)
        Me.Button_Change.Name = "Button_Change"
        Me.Button_Change.Size = New System.Drawing.Size(75, 23)
        Me.Button_Change.TabIndex = 3
        Me.Button_Change.Text = "Change"
        Me.Button_Change.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox_ShowPassword)
        Me.GroupBox2.Controls.Add(Me.TextBox_Password)
        Me.GroupBox2.Controls.Add(Me.TextBox_Username)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(182, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(437, 107)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Login"
        '
        'CheckBox_ShowPassword
        '
        Me.CheckBox_ShowPassword.AutoSize = True
        Me.CheckBox_ShowPassword.Location = New System.Drawing.Point(299, 62)
        Me.CheckBox_ShowPassword.Name = "CheckBox_ShowPassword"
        Me.CheckBox_ShowPassword.Size = New System.Drawing.Size(53, 17)
        Me.CheckBox_ShowPassword.TabIndex = 5
        Me.CheckBox_ShowPassword.Text = "Show"
        Me.CheckBox_ShowPassword.UseVisualStyleBackColor = True
        '
        'TextBox_Password
        '
        Me.TextBox_Password.Location = New System.Drawing.Point(141, 60)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.Size = New System.Drawing.Size(151, 20)
        Me.TextBox_Password.TabIndex = 4
        Me.TextBox_Password.Text = "1234"
        '
        'TextBox_Username
        '
        Me.TextBox_Username.Location = New System.Drawing.Point(141, 34)
        Me.TextBox_Username.Name = "TextBox_Username"
        Me.TextBox_Username.Size = New System.Drawing.Size(151, 20)
        Me.TextBox_Username.TabIndex = 3
        Me.TextBox_Username.Text = "admin"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(35, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(35, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox_SecurityAnswer)
        Me.GroupBox3.Controls.Add(Me.TextBox_SecurityQuestion)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(182, 138)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(437, 101)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recovery"
        '
        'TextBox_SecurityAnswer
        '
        Me.TextBox_SecurityAnswer.Location = New System.Drawing.Point(141, 56)
        Me.TextBox_SecurityAnswer.Name = "TextBox_SecurityAnswer"
        Me.TextBox_SecurityAnswer.Size = New System.Drawing.Size(151, 20)
        Me.TextBox_SecurityAnswer.TabIndex = 8
        '
        'TextBox_SecurityQuestion
        '
        Me.TextBox_SecurityQuestion.Location = New System.Drawing.Point(141, 30)
        Me.TextBox_SecurityQuestion.Name = "TextBox_SecurityQuestion"
        Me.TextBox_SecurityQuestion.Size = New System.Drawing.Size(151, 20)
        Me.TextBox_SecurityQuestion.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(35, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Answer:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(35, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Security Question:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'UserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 277)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button_Reset)
        Me.Controls.Add(Me.Button_Change)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_Clear)
        Me.Controls.Add(Me.Button_Save)
        Me.Name = "UserProfile"
        Me.Text = "User Profile"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox_LogoPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_Save As System.Windows.Forms.Button
    Friend WithEvents Button_Clear As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox_LogoPreview As System.Windows.Forms.PictureBox
    Friend WithEvents Button_Reset As System.Windows.Forms.Button
    Friend WithEvents Button_Change As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_Password As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Username As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_SecurityAnswer As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_SecurityQuestion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_ShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
