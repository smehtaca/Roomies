Imports System.IO

Public Class Chore

    Private Sub Save(sender As Object, e As EventArgs) Handles pbSave.Click
        Me.pbSave.Visible = False
        Dim dir As String = My.Application.Info.DirectoryPath
        Dim path = dir & "\Chores\"

        If Directory.Exists(path) = False Then
            Dim di As DirectoryInfo = Directory.CreateDirectory(path)
        End If
        Dim img As String = path & txtTitle.Text & ".png"
        If File.Exists(img) = False Then

            TakeScreenShot(Me).Save(img, System.Drawing.Imaging.ImageFormat.Png)
            Me.Close()
        End If
    End Sub

    Private Function TakeScreenShot(ByVal Control As Control) As Bitmap

        Dim tempImg As New Bitmap(Control.Width, Control.Height)
        Using gfx As Graphics = Graphics.FromImage(tempImg)
            gfx.CopyFromScreen(Me.PointToScreen(New Point(0, 0)), New Point(0, 0), New Size(Me.Width, Me.Height))
        End Using
        Return tempImg
    End Function
End Class