<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pbSave = New System.Windows.Forms.PictureBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        CType(Me.pbSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbSave
        '
        Me.pbSave.BackColor = System.Drawing.Color.Transparent
        Me.pbSave.Image = Global.Roomies.My.Resources.Resources.save
        Me.pbSave.Location = New System.Drawing.Point(47, 79)
        Me.pbSave.Name = "pbSave"
        Me.pbSave.Size = New System.Drawing.Size(25, 20)
        Me.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSave.TabIndex = 2
        Me.pbSave.TabStop = False
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(3, 13)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(90, 16)
        Me.txtTitle.TabIndex = 3
        Me.txtTitle.Text = "Title"
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDesc.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(5, 42)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(90, 16)
        Me.txtDesc.TabIndex = 4
        Me.txtDesc.Text = "Description"
        '
        'Chore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Roomies.My.Resources.Resources.sticky
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(100, 100)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.pbSave)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Chore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Chore"
        CType(Me.pbSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbSave As PictureBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtDesc As TextBox
End Class
