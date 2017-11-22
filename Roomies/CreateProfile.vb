Imports MaterialSkin
Public Class CreateProfile
    Inherits MaterialSkin.Controls.MaterialForm
    Private Sub CreateProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)

        Me.Location = New Point((My.Computer.Screen.Bounds.Size.Width / 2) - (Me.Width / 2) - 500, (My.Computer.Screen.Bounds.Size.Height / 2) - (Me.Height / 2) - 20)

        tipDragImage.SetToolTip(Me.pbUserPic, "Drag Image to change picture")

        Me.AllowDrop = True
        Me.BackgroundImageLayout = ImageLayout.Stretch
        AddHandler Me.DragDrop, AddressOf Form_DragDrop
        AddHandler Me.DragEnter, AddressOf Form_DragEnter
    End Sub
    Private Sub Form_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim Files() As String
            Files = e.Data.GetData(DataFormats.FileDrop)
            Dim img As Image
            img = Image.FromFile(Files(0))
            Me.pbUserPic.Image = img
            Me.pbUserPic.BackColor = System.Drawing.Color.White
        End If
    End Sub

    Private Sub Form_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click

        Dim directory As String = My.Application.Info.DirectoryPath
        Dim FileToSaveAs As String = System.IO.Path.Combine(directory, txtUserName.Text & ".png")
        pbUserPic.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Png)
    End Sub
End Class