<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserManager


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
        Me.Container = New System.Windows.Forms.Panel()
        Me.lblInvite = New MaterialSkin.Controls.MaterialLabel()
        Me.txtInvitedUser = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblAcceptUsers = New MaterialSkin.Controls.MaterialLabel()
        Me.btnInvite = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnAcceptRoomate = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.rdbAccept = New MaterialSkin.Controls.MaterialRadioButton()
        Me.lblUserB = New MaterialSkin.Controls.MaterialLabel()
        Me.rdbDecline = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'Container
        '
        Me.Container.BackColor = System.Drawing.Color.White
        Me.Container.Controls.Add(Me.rdbDecline)
        Me.Container.Controls.Add(Me.lblUserB)
        Me.Container.Controls.Add(Me.rdbAccept)
        Me.Container.Controls.Add(Me.btnAcceptRoomate)
        Me.Container.Controls.Add(Me.btnInvite)
        Me.Container.Controls.Add(Me.lblAcceptUsers)
        Me.Container.Controls.Add(Me.txtInvitedUser)
        Me.Container.Controls.Add(Me.lblInvite)
        Me.Container.Location = New System.Drawing.Point(0, 63)
        Me.Container.Name = "Container"
        Me.Container.Size = New System.Drawing.Size(404, 498)
        Me.Container.TabIndex = 0
        '
        'lblInvite
        '
        Me.lblInvite.AutoSize = True
        Me.lblInvite.Depth = 0
        Me.lblInvite.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblInvite.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInvite.Location = New System.Drawing.Point(13, 22)
        Me.lblInvite.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblInvite.Name = "lblInvite"
        Me.lblInvite.Size = New System.Drawing.Size(135, 19)
        Me.lblInvite.TabIndex = 0
        Me.lblInvite.Text = "Invite Roommates:"
        '
        'txtInvitedUser
        '
        Me.txtInvitedUser.Depth = 0
        Me.txtInvitedUser.Hint = ""
        Me.txtInvitedUser.Location = New System.Drawing.Point(177, 22)
        Me.txtInvitedUser.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtInvitedUser.Name = "txtInvitedUser"
        Me.txtInvitedUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInvitedUser.SelectedText = ""
        Me.txtInvitedUser.SelectionLength = 0
        Me.txtInvitedUser.SelectionStart = 0
        Me.txtInvitedUser.Size = New System.Drawing.Size(144, 23)
        Me.txtInvitedUser.TabIndex = 1
        Me.txtInvitedUser.UseSystemPasswordChar = False
        '
        'lblAcceptUsers
        '
        Me.lblAcceptUsers.AutoSize = True
        Me.lblAcceptUsers.Depth = 0
        Me.lblAcceptUsers.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblAcceptUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAcceptUsers.Location = New System.Drawing.Point(13, 128)
        Me.lblAcceptUsers.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAcceptUsers.Name = "lblAcceptUsers"
        Me.lblAcceptUsers.Size = New System.Drawing.Size(261, 19)
        Me.lblAcceptUsers.TabIndex = 2
        Me.lblAcceptUsers.Text = "Accept/Decline Roommate Requests:"
        '
        'btnInvite
        '
        Me.btnInvite.Depth = 0
        Me.btnInvite.Location = New System.Drawing.Point(129, 64)
        Me.btnInvite.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnInvite.Name = "btnInvite"
        Me.btnInvite.Primary = True
        Me.btnInvite.Size = New System.Drawing.Size(108, 32)
        Me.btnInvite.TabIndex = 4
        Me.btnInvite.Text = "Invite"
        Me.btnInvite.UseVisualStyleBackColor = True
        '
        'btnAcceptRoomate
        '
        Me.btnAcceptRoomate.Depth = 0
        Me.btnAcceptRoomate.Location = New System.Drawing.Point(129, 233)
        Me.btnAcceptRoomate.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAcceptRoomate.Name = "btnAcceptRoomate"
        Me.btnAcceptRoomate.Primary = True
        Me.btnAcceptRoomate.Size = New System.Drawing.Size(108, 34)
        Me.btnAcceptRoomate.TabIndex = 5
        Me.btnAcceptRoomate.Text = "Accept Roommates"
        Me.btnAcceptRoomate.UseVisualStyleBackColor = True
        '
        'rdbAccept
        '
        Me.rdbAccept.AutoSize = True
        Me.rdbAccept.Depth = 0
        Me.rdbAccept.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbAccept.Location = New System.Drawing.Point(93, 156)
        Me.rdbAccept.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbAccept.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbAccept.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbAccept.Name = "rdbAccept"
        Me.rdbAccept.Ripple = True
        Me.rdbAccept.Size = New System.Drawing.Size(72, 30)
        Me.rdbAccept.TabIndex = 6
        Me.rdbAccept.TabStop = True
        Me.rdbAccept.Text = "Accept"
        Me.rdbAccept.UseVisualStyleBackColor = True
        '
        'lblUserB
        '
        Me.lblUserB.AutoSize = True
        Me.lblUserB.Depth = 0
        Me.lblUserB.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblUserB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblUserB.Location = New System.Drawing.Point(17, 161)
        Me.lblUserB.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblUserB.Name = "lblUserB"
        Me.lblUserB.Size = New System.Drawing.Size(53, 19)
        Me.lblUserB.TabIndex = 7
        Me.lblUserB.Text = "User B"
        '
        'rdbDecline
        '
        Me.rdbDecline.AutoSize = True
        Me.rdbDecline.Depth = 0
        Me.rdbDecline.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbDecline.Location = New System.Drawing.Point(177, 156)
        Me.rdbDecline.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbDecline.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbDecline.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbDecline.Name = "rdbDecline"
        Me.rdbDecline.Ripple = True
        Me.rdbDecline.Size = New System.Drawing.Size(74, 30)
        Me.rdbDecline.TabIndex = 8
        Me.rdbDecline.TabStop = True
        Me.rdbDecline.Text = "Decline"
        Me.rdbDecline.UseVisualStyleBackColor = True
        '
        'UserManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.Container)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserManager"
        Me.Text = "UserManager"
        Me.Container.ResumeLayout(False)
        Me.Container.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Container As Panel
    Friend WithEvents txtInvitedUser As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblInvite As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblAcceptUsers As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnInvite As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnAcceptRoomate As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblUserB As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents rdbAccept As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdbDecline As MaterialSkin.Controls.MaterialRadioButton
End Class
