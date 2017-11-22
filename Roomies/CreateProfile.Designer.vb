<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateProfile


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
        Me.components = New System.ComponentModel.Container()
        Me.lblUserName = New MaterialSkin.Controls.MaterialLabel()
        Me.rdbAdmin = New MaterialSkin.Controls.MaterialRadioButton()
        Me.lblEmail = New MaterialSkin.Controls.MaterialLabel()
        Me.lblPhoneNumber = New MaterialSkin.Controls.MaterialLabel()
        Me.txtUserName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtEmail = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtPhoneNumber = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnCreateUser = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblType = New MaterialSkin.Controls.MaterialLabel()
        Me.rdbRegular = New MaterialSkin.Controls.MaterialRadioButton()
        Me.lblPhoto = New MaterialSkin.Controls.MaterialLabel()
        Me.pbUserPic = New System.Windows.Forms.PictureBox()
        Me.tipDragImage = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.pbUserPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Depth = 0
        Me.lblUserName.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblUserName.Location = New System.Drawing.Point(12, 235)
        Me.lblUserName.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(53, 19)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "Name:"
        '
        'rdbAdmin
        '
        Me.rdbAdmin.AutoSize = True
        Me.rdbAdmin.Depth = 0
        Me.rdbAdmin.Enabled = False
        Me.rdbAdmin.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbAdmin.Location = New System.Drawing.Point(115, 379)
        Me.rdbAdmin.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbAdmin.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbAdmin.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbAdmin.Name = "rdbAdmin"
        Me.rdbAdmin.Ripple = True
        Me.rdbAdmin.Size = New System.Drawing.Size(69, 30)
        Me.rdbAdmin.TabIndex = 1
        Me.rdbAdmin.Text = "Admin"
        Me.rdbAdmin.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Depth = 0
        Me.lblEmail.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(12, 284)
        Me.lblEmail.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(51, 19)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email:"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Depth = 0
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(12, 339)
        Me.lblPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(68, 19)
        Me.lblPhoneNumber.TabIndex = 3
        Me.lblPhoneNumber.Text = "Phone #:"
        '
        'txtUserName
        '
        Me.txtUserName.Depth = 0
        Me.txtUserName.Hint = ""
        Me.txtUserName.Location = New System.Drawing.Point(115, 231)
        Me.txtUserName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserName.SelectedText = ""
        Me.txtUserName.SelectionLength = 0
        Me.txtUserName.SelectionStart = 0
        Me.txtUserName.Size = New System.Drawing.Size(174, 23)
        Me.txtUserName.TabIndex = 4
        Me.txtUserName.UseSystemPasswordChar = False
        '
        'txtEmail
        '
        Me.txtEmail.Depth = 0
        Me.txtEmail.Hint = ""
        Me.txtEmail.Location = New System.Drawing.Point(115, 280)
        Me.txtEmail.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.Size = New System.Drawing.Size(174, 23)
        Me.txtEmail.TabIndex = 5
        Me.txtEmail.UseSystemPasswordChar = False
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Depth = 0
        Me.txtPhoneNumber.Hint = ""
        Me.txtPhoneNumber.Location = New System.Drawing.Point(115, 335)
        Me.txtPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneNumber.SelectedText = ""
        Me.txtPhoneNumber.SelectionLength = 0
        Me.txtPhoneNumber.SelectionStart = 0
        Me.txtPhoneNumber.Size = New System.Drawing.Size(174, 23)
        Me.txtPhoneNumber.TabIndex = 6
        Me.txtPhoneNumber.UseSystemPasswordChar = False
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Depth = 0
        Me.btnCreateUser.Location = New System.Drawing.Point(105, 477)
        Me.btnCreateUser.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Primary = True
        Me.btnCreateUser.Size = New System.Drawing.Size(174, 32)
        Me.btnCreateUser.TabIndex = 7
        Me.btnCreateUser.Text = "Create Profile"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Depth = 0
        Me.lblType.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblType.Location = New System.Drawing.Point(12, 390)
        Me.lblType.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(45, 19)
        Me.lblType.TabIndex = 8
        Me.lblType.Text = "Type:"
        '
        'rdbRegular
        '
        Me.rdbRegular.AutoSize = True
        Me.rdbRegular.Depth = 0
        Me.rdbRegular.Enabled = False
        Me.rdbRegular.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbRegular.Location = New System.Drawing.Point(213, 379)
        Me.rdbRegular.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbRegular.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbRegular.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbRegular.Name = "rdbRegular"
        Me.rdbRegular.Ripple = True
        Me.rdbRegular.Size = New System.Drawing.Size(76, 30)
        Me.rdbRegular.TabIndex = 9
        Me.rdbRegular.TabStop = True
        Me.rdbRegular.Text = "Regular"
        Me.rdbRegular.UseVisualStyleBackColor = True
        '
        'lblPhoto
        '
        Me.lblPhoto.AutoSize = True
        Me.lblPhoto.Depth = 0
        Me.lblPhoto.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblPhoto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPhoto.Location = New System.Drawing.Point(10, 189)
        Me.lblPhoto.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(53, 19)
        Me.lblPhoto.TabIndex = 11
        Me.lblPhoto.Text = "Photo:"
        '
        'pbUserPic
        '
        Me.pbUserPic.BackColor = System.Drawing.Color.White
        Me.pbUserPic.Image = Global.Roomies.My.Resources.Resources.user
        Me.pbUserPic.Location = New System.Drawing.Point(134, 79)
        Me.pbUserPic.Name = "pbUserPic"
        Me.pbUserPic.Size = New System.Drawing.Size(128, 128)
        Me.pbUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbUserPic.TabIndex = 10
        Me.pbUserPic.TabStop = False
        '
        'tipDragImage
        '
        Me.tipDragImage.AutoPopDelay = 500
        Me.tipDragImage.InitialDelay = 500
        Me.tipDragImage.ReshowDelay = 100
        '
        'CreateProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblPhoto)
        Me.Controls.Add(Me.pbUserPic)
        Me.Controls.Add(Me.rdbRegular)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.btnCreateUser)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.rdbAdmin)
        Me.Controls.Add(Me.lblUserName)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Create Profile"
        CType(Me.pbUserPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUserName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents rdbAdmin As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents lblEmail As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblPhoneNumber As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtUserName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtEmail As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtPhoneNumber As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnCreateUser As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblType As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents rdbRegular As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents pbUserPic As PictureBox
    Friend WithEvents lblPhoto As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tipDragImage As ToolTip
End Class
