Imports MaterialSkin
Public Class Main
    Inherits MaterialSkin.Controls.MaterialForm
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub btnUserA_Click(sender As Object, e As EventArgs) Handles btnUserA.Click

        Dim CreateAdminProfile = New CreateProfile
        CreateAdminProfile.rdbAdmin.Checked() = True
        CreateAdminProfile.Location = New Point((My.Computer.Screen.Bounds.Size.Width / 2) - (Me.Width / 2) - 500, (My.Computer.Screen.Bounds.Size.Height / 2) - (Me.Height / 2) - 20)
        CreateAdminProfile.Show()

    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Dim CreateRegularProfile = New CreateProfile

        CreateRegularProfile.rdbRegular.Checked() = True
        CreateRegularProfile.Location = New Point((My.Computer.Screen.Bounds.Size.Width / 2) - (Me.Width / 2) + 500, (My.Computer.Screen.Bounds.Size.Height / 2) - (Me.Height / 2) - 20)
        CreateRegularProfile.Show()
    End Sub
End Class
