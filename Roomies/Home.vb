Imports System.IO
Imports System.Text
Imports MaterialSkin
Public Class Home
    Inherits MaterialSkin.Controls.MaterialForm
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub btnEditInfo_Click(sender As Object, e As EventArgs) Handles btnEditInfo.Click
        Dim dir As String = My.Application.Info.DirectoryPath
        Dim path = dir & "\Users\" & "Regular_User.txt"
        Dim reader As New StreamReader(path, Encoding.Default)

        Dim line As String = Nothing

        Dim lines As Integer = 0

        While (reader.Peek() <> -1 And lines < 4)
            line = reader.ReadLine()
            If lines = 0 Then
                CreateProfile.txtUserName.Text = line

                CreateProfile.pbUserPic.Image = Image.FromFile(dir & "\" & line & ".png")
            ElseIf lines = 1 Then
                CreateProfile.txtEmail.Text = line
            ElseIf lines = 2 Then
                CreateProfile.txtPhoneNumber.Text = line
            ElseIf lines = 3 Then
                CreateProfile.rdbRegular.Checked = True
            End If
            lines = lines + 1
        End While



        CreateProfile.Show()

    End Sub
End Class