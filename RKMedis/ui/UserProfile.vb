Imports System.IO

Public Class UserProfile

    Dim userData As New Users()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Save.Click

        userData.Username = TextBox_Username.Text
        userData.PasswordNew = TextBox_Password.Text
        userData.RecoveryQuestion = TextBox_SecurityQuestion.Text
        userData.RecoveryAnswer = TextBox_SecurityAnswer.Text
        userData.LogoFileName = PictureBox_LogoPreview.Tag

        If (PictureBox_LogoPreview.Tag IsNot Nothing) Then
            Dim data As Byte() = File.ReadAllBytes(PictureBox_LogoPreview.Tag)
            userData.Logo = data
        End If

        DBOperation.UpdateUser(userData)

        'new reference for later usage
        userData.PasswordOld = TextBox_Password.Text
    End Sub



    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userData.PasswordOld = TextBox_Password.Text

    End Sub

    Private Sub Button_Change_Click(sender As Object, e As EventArgs) Handles Button_Change.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        OpenFileDialog1.Title = "Select a Picture"

        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then

            PictureBox_LogoPreview.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox_LogoPreview.Tag = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button_Reset_Click(sender As Object, e As EventArgs) Handles Button_Reset.Click
        PictureBox_LogoPreview.Tag = Nothing
        PictureBox_LogoPreview.Image = Nothing
    End Sub

    Private Sub CheckBox_ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_ShowPassword.CheckedChanged
        If (CheckBox_ShowPassword.Checked) Then
            TextBox_Password.PasswordChar = "*"
        Else
            TextBox_Password.PasswordChar = ""
        End If
    End Sub
End Class