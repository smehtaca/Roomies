Imports MaterialSkin
Public Class RequestAccess
    Inherits MaterialSkin.Controls.MaterialForm

    Private userName As String

    Private Sub RequestAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
        Me.Location = New Point((My.Computer.Screen.Bounds.Size.Width / 2) - (Me.Width / 2) + 500, (My.Computer.Screen.Bounds.Size.Height / 2) - (Me.Height / 2) - 20)

        tipHouse.SetToolTip(Me.txtHouseHold, "Enter Household Name")
    End Sub

    Public Property NameRecieved() As String
        Get
            Return userName
        End Get
        Set(ByVal value As String)
            userName = value
        End Set
    End Property
    Private Sub btnReqAccess_Click(sender As Object, e As EventArgs) Handles btnReqAccess.Click

        Dim req As New AdminApp.UserManager
        req.ReqRecieved = userName
        Console.WriteLine(userName)
    End Sub
End Class