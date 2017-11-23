Imports System.IO
Imports System.Text
Imports MaterialSkin
Public Class Home
    Inherits MaterialSkin.Controls.MaterialForm

    Private Moving As Boolean

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
        pbAddChore.Visible = False
        timerUpdate.Interval = 3000
        timerUpdate.Enabled = True
    End Sub

    Private Sub TabChores_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabChores.Enter

        pbAddChore.Visible = True
        UpdateChores()
    End Sub

    Public Function UpdateChores()
        Dim dir As String = My.Application.Info.DirectoryPath & "\Chores\"
        If Directory.Exists(dir) Then
            Dim files() As String = IO.Directory.GetFiles(dir)
            Dim x As Integer
            x = 0
            For Each file As String In files
                Console.WriteLine(file)
                Dim pbChore As New PictureBox
                With pbChore
                    .Name = file
                    .Image = Image.FromFile(file)
                    .Location = New Point(5 + x / 10, 5 + x)
                    .Size = New Size(90, 90)

                End With

                choreContainer.Controls.Add(pbChore)
                pbChore.BringToFront()

                x = x + 100
            Next
        End If
    End Function
    Private Sub TabChores_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabChores.Leave
        pbAddChore.Visible = False
        UpdateChores()
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

    Private Sub pbAddChore_Click(sender As Object, e As EventArgs) Handles pbAddChore.Click

        Chore.ShowDialog()

        UpdateChores()
    End Sub

    Private Sub timerUpdate_Tick(sender As Object, e As EventArgs) Handles timerUpdate.Tick
        UpdateChores()
    End Sub
End Class