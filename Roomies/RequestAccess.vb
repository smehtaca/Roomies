Imports MaterialSkin
Public Class RequestAccess
    Inherits MaterialSkin.Controls.MaterialForm



    Private Sub RequestAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)

        tipHouse.SetToolTip(Me.txtHouseHold, "Enter Household Name")
    End Sub

    Private Sub btnReqAccess_Click(sender As Object, e As EventArgs) Handles btnReqAccess.Click

    End Sub
End Class