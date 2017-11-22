Imports MaterialSkin
Imports System
Imports System.IO
Public Class CreateProfile
    Inherits MaterialSkin.Controls.MaterialForm
    Private Sub CreateProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)

        Me.Opacity = 0.99

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

        Dim dir As String = My.Application.Info.DirectoryPath
        If txtUserName.Text IsNot "" Then
            Dim FileToSaveAs As String = System.IO.Path.Combine(dir, txtUserName.Text & ".png")
            pbUserPic.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Png)
        End If

        Dim file As System.IO.StreamWriter
        Dim userDir = dir & "\Users\"
        Dim di As DirectoryInfo = Directory.CreateDirectory(userDir)

        file = My.Computer.FileSystem.OpenTextFileWriter(userDir & txtUserName.Text & ".txt", False)
        file.WriteLine(txtUserName.Text)
        file.WriteLine(txtEmail.Text)
        file.WriteLine(txtPhoneNumber.Text)
        If rdbAdmin.Checked = True Then
            file.WriteLine(rdbAdmin.Text)
        Else
            file.WriteLine(rdbRegular.Text)
        End If
        file.Close()

        If rdbAdmin.Checked = True Then
            FadingForm()
            Dim AdminMain As New AdminApp.AdminCreateHousehold
            AdminMain.Show()
        Else
            Dim controlsContainer As Panel = RequestAccess.controlsContainer
            Me.Controls.Clear()
            Me.Controls.Add(controlsContainer)
            For i As Integer = Me.ClientRectangle.Width To 0 Step -1
                controlsContainer.Left = i
                Me.Refresh()
                Me.Text = "Join Household"
            Next i
        End If


    End Sub
    Private Sub FadingForm()
        Dim iCount As Integer


        For iCount = 90 To 10 Step -10


            Me.Opacity = iCount / 100


            Me.Refresh()


            Threading.Thread.Sleep(25)


        Next


        Me.Hide()


    End Sub
End Class