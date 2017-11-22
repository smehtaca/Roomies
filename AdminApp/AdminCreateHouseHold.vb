Imports MaterialSkin
Public Class AdminCreateHousehold
    Inherits MaterialSkin.Controls.MaterialForm
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)

        Me.AllowDrop = True
        Me.BackgroundImageLayout = ImageLayout.Stretch
        AddHandler Me.DragDrop, AddressOf Form_DragDrop
        AddHandler Me.DragEnter, AddressOf Form_DragEnter

        Me.Location = New Point((My.Computer.Screen.Bounds.Size.Width / 2) - (Me.Width / 2) - 500, (My.Computer.Screen.Bounds.Size.Height / 2) - (Me.Height / 2) - 20)

    End Sub

    Private Sub Form_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim Files() As String
            Files = e.Data.GetData(DataFormats.FileDrop)
            Dim img As Image
            img = Image.FromFile(Files(0))
            Me.pbHouseImage.Image = img
            Me.pbHouseImage.BackColor = System.Drawing.Color.White
        End If
    End Sub

    Private Sub Form_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub btnCreateHouse_Click(sender As Object, e As EventArgs) Handles btnCreateHouse.Click
        Dim file As System.IO.StreamWriter
        Dim directory As String = My.Application.Info.DirectoryPath
        file = My.Computer.FileSystem.OpenTextFileWriter(directory & "\household.txt", False)
        file.WriteLine(txtName.Text)
        file.WriteLine(txtAddress.Text)
        file.WriteLine(txtRooms.Text)
        file.WriteLine(txtWashrooms.Text)
        file.Close()

        Dim FileToSaveAs As String = System.IO.Path.Combine(directory, "Household.png")
        pbHouseImage.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Png)


        Dim controlsContainer As Panel = UserManager.controlsContainer
        Me.Controls.Clear()
        Me.Controls.Add(controlsContainer)
        For i As Integer = Me.ClientRectangle.Width To 0 Step -1
            controlsContainer.Left = i
            Me.Refresh()
            Me.Text = "Invite or Accept Users"
        Next i


    End Sub
End Class
