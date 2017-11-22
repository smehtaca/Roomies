<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main


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
        Me.btnUserA = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnUser = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblLogin = New MaterialSkin.Controls.MaterialLabel()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUserA
        '
        Me.btnUserA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUserA.Depth = 0
        Me.btnUserA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserA.Location = New System.Drawing.Point(154, 347)
        Me.btnUserA.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnUserA.Name = "btnUserA"
        Me.btnUserA.Primary = True
        Me.btnUserA.Size = New System.Drawing.Size(72, 23)
        Me.btnUserA.TabIndex = 2
        Me.btnUserA.Text = "Admin"
        Me.btnUserA.UseVisualStyleBackColor = False
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUser.Depth = 0
        Me.btnUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.Location = New System.Drawing.Point(154, 404)
        Me.btnUser.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Primary = True
        Me.btnUser.Size = New System.Drawing.Size(72, 23)
        Me.btnUser.TabIndex = 3
        Me.btnUser.Text = "User"
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Depth = 0
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLogin.Location = New System.Drawing.Point(150, 288)
        Me.lblLogin.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(69, 18)
        Me.lblLogin.TabIndex = 4
        Me.lblLogin.Text = "Login As:"
        '
        'pbLogo
        '
        Me.pbLogo.BackColor = System.Drawing.Color.White
        Me.pbLogo.Image = Global.Roomies.My.Resources.Resources.home
        Me.pbLogo.Location = New System.Drawing.Point(103, 104)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(186, 121)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 562)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.btnUser)
        Me.Controls.Add(Me.btnUserA)
        Me.Controls.Add(Me.pbLogo)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roomies"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUser As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnUserA As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblLogin As MaterialSkin.Controls.MaterialLabel
End Class
