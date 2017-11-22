<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminCreateHousehold

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblHouseHoldImage = New MaterialSkin.Controls.MaterialLabel()
        Me.lblHouseName = New MaterialSkin.Controls.MaterialLabel()
        Me.lblAddress = New MaterialSkin.Controls.MaterialLabel()
        Me.lblRooms = New MaterialSkin.Controls.MaterialLabel()
        Me.lblWashrooms = New MaterialSkin.Controls.MaterialLabel()
        Me.btnCreateHouse = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtRooms = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtAddress = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtWashrooms = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.pbHouseImage = New System.Windows.Forms.PictureBox()
        Me.tipDragHouseHoldImage = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.pbHouseImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHouseHoldImage
        '
        Me.lblHouseHoldImage.AutoSize = True
        Me.lblHouseHoldImage.Depth = 0
        Me.lblHouseHoldImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblHouseHoldImage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHouseHoldImage.Location = New System.Drawing.Point(138, 92)
        Me.lblHouseHoldImage.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblHouseHoldImage.Name = "lblHouseHoldImage"
        Me.lblHouseHoldImage.Size = New System.Drawing.Size(136, 18)
        Me.lblHouseHoldImage.TabIndex = 0
        Me.lblHouseHoldImage.Text = "Drag House Image:"
        '
        'lblHouseName
        '
        Me.lblHouseName.AutoSize = True
        Me.lblHouseName.Depth = 0
        Me.lblHouseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblHouseName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHouseName.Location = New System.Drawing.Point(22, 341)
        Me.lblHouseName.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblHouseName.Name = "lblHouseName"
        Me.lblHouseName.Size = New System.Drawing.Size(52, 18)
        Me.lblHouseName.TabIndex = 2
        Me.lblHouseName.Text = "Name:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Depth = 0
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(22, 391)
        Me.lblAddress.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(66, 18)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Address:"
        '
        'lblRooms
        '
        Me.lblRooms.AutoSize = True
        Me.lblRooms.Depth = 0
        Me.lblRooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblRooms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblRooms.Location = New System.Drawing.Point(22, 440)
        Me.lblRooms.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblRooms.Name = "lblRooms"
        Me.lblRooms.Size = New System.Drawing.Size(91, 18)
        Me.lblRooms.TabIndex = 4
        Me.lblRooms.Text = "# of Rooms:"
        '
        'lblWashrooms
        '
        Me.lblWashrooms.AutoSize = True
        Me.lblWashrooms.Depth = 0
        Me.lblWashrooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblWashrooms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblWashrooms.Location = New System.Drawing.Point(22, 487)
        Me.lblWashrooms.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblWashrooms.Name = "lblWashrooms"
        Me.lblWashrooms.Size = New System.Drawing.Size(124, 18)
        Me.lblWashrooms.TabIndex = 5
        Me.lblWashrooms.Text = "# of Washrooms:"
        '
        'btnCreateHouse
        '
        Me.btnCreateHouse.Depth = 0
        Me.btnCreateHouse.Location = New System.Drawing.Point(158, 527)
        Me.btnCreateHouse.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCreateHouse.Name = "btnCreateHouse"
        Me.btnCreateHouse.Primary = True
        Me.btnCreateHouse.Size = New System.Drawing.Size(88, 23)
        Me.btnCreateHouse.TabIndex = 6
        Me.btnCreateHouse.Text = "Create"
        Me.btnCreateHouse.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Depth = 0
        Me.txtName.Hint = ""
        Me.txtName.Location = New System.Drawing.Point(161, 341)
        Me.txtName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.SelectedText = ""
        Me.txtName.SelectionLength = 0
        Me.txtName.SelectionStart = 0
        Me.txtName.Size = New System.Drawing.Size(212, 23)
        Me.txtName.TabIndex = 7
        Me.txtName.UseSystemPasswordChar = False
        '
        'txtRooms
        '
        Me.txtRooms.Depth = 0
        Me.txtRooms.Hint = ""
        Me.txtRooms.Location = New System.Drawing.Point(161, 440)
        Me.txtRooms.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtRooms.Name = "txtRooms"
        Me.txtRooms.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRooms.SelectedText = ""
        Me.txtRooms.SelectionLength = 0
        Me.txtRooms.SelectionStart = 0
        Me.txtRooms.Size = New System.Drawing.Size(212, 23)
        Me.txtRooms.TabIndex = 7
        Me.txtRooms.UseSystemPasswordChar = False
        '
        'txtAddress
        '
        Me.txtAddress.Depth = 0
        Me.txtAddress.Hint = ""
        Me.txtAddress.Location = New System.Drawing.Point(161, 387)
        Me.txtAddress.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.SelectionLength = 0
        Me.txtAddress.SelectionStart = 0
        Me.txtAddress.Size = New System.Drawing.Size(212, 23)
        Me.txtAddress.TabIndex = 8
        Me.txtAddress.UseSystemPasswordChar = False
        '
        'txtWashrooms
        '
        Me.txtWashrooms.Depth = 0
        Me.txtWashrooms.Hint = ""
        Me.txtWashrooms.Location = New System.Drawing.Point(161, 487)
        Me.txtWashrooms.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtWashrooms.Name = "txtWashrooms"
        Me.txtWashrooms.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWashrooms.SelectedText = ""
        Me.txtWashrooms.SelectionLength = 0
        Me.txtWashrooms.SelectionStart = 0
        Me.txtWashrooms.Size = New System.Drawing.Size(212, 23)
        Me.txtWashrooms.TabIndex = 9
        Me.txtWashrooms.UseSystemPasswordChar = False
        '
        'pbHouseImage
        '
        Me.pbHouseImage.BackColor = System.Drawing.Color.White
        Me.pbHouseImage.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbHouseImage.Image = My.Resources.Resources.houseDefault
        Me.pbHouseImage.Location = New System.Drawing.Point(64, 145)
        Me.pbHouseImage.Name = "pbHouseImage"
        Me.pbHouseImage.Size = New System.Drawing.Size(277, 156)
        Me.pbHouseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbHouseImage.TabIndex = 1
        Me.pbHouseImage.TabStop = False
        '
        'AdminCreateHousehold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtWashrooms)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtRooms)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnCreateHouse)
        Me.Controls.Add(Me.lblWashrooms)
        Me.Controls.Add(Me.lblRooms)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblHouseName)
        Me.Controls.Add(Me.pbHouseImage)
        Me.Controls.Add(Me.lblHouseHoldImage)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminCreateHousehold"
        Me.Text = "Create Household"
        CType(Me.pbHouseImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHouseHoldImage As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pbHouseImage As PictureBox
    Friend WithEvents lblHouseName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblAddress As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblRooms As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblWashrooms As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnCreateHouse As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtRooms As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtAddress As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtWashrooms As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents tipDragHouseHoldImage As ToolTip
End Class
