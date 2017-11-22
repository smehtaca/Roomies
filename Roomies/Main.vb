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
        Dim AdminMain As New AdminApp.AdminCreateHousehold
        AdminMain.Show()
    End Sub
End Class
