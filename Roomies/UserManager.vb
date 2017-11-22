Imports MaterialSkin
Public Class UserManager
    Inherits MaterialSkin.Controls.MaterialForm

    Private requested As String
    Private Sub UserManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)

        If requested Is "" Then

            lblUserB.Text = "No Join Requests"
            rdbAccept.Visible = False
            rdbDecline.Visible = False
            btnAcceptRoomate.Enabled = False
        End If

        Me.Location = New Point((My.Computer.Screen.Bounds.Size.Width / 2) - (Me.Width / 2) - 500, (My.Computer.Screen.Bounds.Size.Height / 2) - (Me.Height / 2) - 20)

    End Sub

    Public Property ReqRecieved() As String
        Get
            Return requested
        End Get
        Set(ByVal value As String)
            requested = value
            lblUserB.Text = requested
        End Set
    End Property

    Private Sub btnAcceptRoomate_Click(sender As Object, e As EventArgs) Handles btnAcceptRoomate.Click

    End Sub

    Private Sub btnInvite_Click(sender As Object, e As EventArgs) Handles btnInvite.Click
        Dim err = New PopUp
        err.Show()
    End Sub
End Class