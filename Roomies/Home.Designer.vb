<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home


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
        Me.tbsMain = New MaterialSkin.Controls.MaterialTabSelector()
        Me.tbcMain = New MaterialSkin.Controls.MaterialTabControl()
        Me.tabUsers = New System.Windows.Forms.TabPage()
        Me.tabChores = New System.Windows.Forms.TabPage()
        Me.lblUserB = New MaterialSkin.Controls.MaterialLabel()
        Me.btnEditInfo = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.tbcMain.SuspendLayout()
        Me.tabUsers.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbsMain
        '
        Me.tbsMain.BaseTabControl = Me.tbcMain
        Me.tbsMain.Depth = 0
        Me.tbsMain.Location = New System.Drawing.Point(-1, 64)
        Me.tbsMain.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbsMain.Name = "tbsMain"
        Me.tbsMain.Size = New System.Drawing.Size(405, 23)
        Me.tbsMain.TabIndex = 0
        '
        'tbcMain
        '
        Me.tbcMain.Controls.Add(Me.tabUsers)
        Me.tbcMain.Controls.Add(Me.tabChores)
        Me.tbcMain.Depth = 0
        Me.tbcMain.Location = New System.Drawing.Point(-1, 85)
        Me.tbcMain.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbcMain.Name = "tbcMain"
        Me.tbcMain.SelectedIndex = 0
        Me.tbcMain.Size = New System.Drawing.Size(404, 480)
        Me.tbcMain.TabIndex = 1
        '
        'tabUsers
        '
        Me.tabUsers.Controls.Add(Me.btnEditInfo)
        Me.tabUsers.Controls.Add(Me.lblUserB)
        Me.tabUsers.Location = New System.Drawing.Point(4, 22)
        Me.tabUsers.Name = "tabUsers"
        Me.tabUsers.Padding = New System.Windows.Forms.Padding(3)
        Me.tabUsers.Size = New System.Drawing.Size(396, 454)
        Me.tabUsers.TabIndex = 0
        Me.tabUsers.Text = "Users"
        Me.tabUsers.UseVisualStyleBackColor = True
        '
        'tabChores
        '
        Me.tabChores.Location = New System.Drawing.Point(4, 22)
        Me.tabChores.Name = "tabChores"
        Me.tabChores.Padding = New System.Windows.Forms.Padding(3)
        Me.tabChores.Size = New System.Drawing.Size(396, 454)
        Me.tabChores.TabIndex = 1
        Me.tabChores.Text = "Chores"
        Me.tabChores.UseVisualStyleBackColor = True
        '
        'lblUserB
        '
        Me.lblUserB.AutoSize = True
        Me.lblUserB.Depth = 0
        Me.lblUserB.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblUserB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblUserB.Location = New System.Drawing.Point(9, 16)
        Me.lblUserB.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblUserB.Name = "lblUserB"
        Me.lblUserB.Size = New System.Drawing.Size(53, 19)
        Me.lblUserB.TabIndex = 0
        Me.lblUserB.Text = "User B"
        '
        'btnEditInfo
        '
        Me.btnEditInfo.BackgroundImage = Global.Roomies.My.Resources.Resources.gear
        Me.btnEditInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditInfo.Depth = 0
        Me.btnEditInfo.Location = New System.Drawing.Point(101, 14)
        Me.btnEditInfo.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEditInfo.Name = "btnEditInfo"
        Me.btnEditInfo.Primary = True
        Me.btnEditInfo.Size = New System.Drawing.Size(72, 24)
        Me.btnEditInfo.TabIndex = 1
        Me.btnEditInfo.Text = "Edit"
        Me.btnEditInfo.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbcMain)
        Me.Controls.Add(Me.tbsMain)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.tbcMain.ResumeLayout(False)
        Me.tabUsers.ResumeLayout(False)
        Me.tabUsers.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbsMain As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents tbcMain As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents tabUsers As TabPage
    Friend WithEvents tabChores As TabPage
    Friend WithEvents lblUserB As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnEditInfo As MaterialSkin.Controls.MaterialRaisedButton
End Class
