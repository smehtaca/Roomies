<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequestAccess


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
        Me.controlsContainer = New System.Windows.Forms.Panel()
        Me.btnReqAccess = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtHouseHold = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblReqAccess = New MaterialSkin.Controls.MaterialLabel()
        Me.tipHouse = New System.Windows.Forms.ToolTip(Me.components)
        Me.controlsContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'controlsContainer
        '
        Me.controlsContainer.BackColor = System.Drawing.Color.White
        Me.controlsContainer.Controls.Add(Me.btnReqAccess)
        Me.controlsContainer.Controls.Add(Me.txtHouseHold)
        Me.controlsContainer.Controls.Add(Me.lblReqAccess)
        Me.controlsContainer.Location = New System.Drawing.Point(0, 63)
        Me.controlsContainer.Name = "controlsContainer"
        Me.controlsContainer.Size = New System.Drawing.Size(404, 498)
        Me.controlsContainer.TabIndex = 0
        '
        'btnReqAccess
        '
        Me.btnReqAccess.Depth = 0
        Me.btnReqAccess.Location = New System.Drawing.Point(103, 245)
        Me.btnReqAccess.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnReqAccess.Name = "btnReqAccess"
        Me.btnReqAccess.Primary = True
        Me.btnReqAccess.Size = New System.Drawing.Size(204, 23)
        Me.btnReqAccess.TabIndex = 2
        Me.btnReqAccess.Text = "Join Household"
        Me.btnReqAccess.UseVisualStyleBackColor = True
        '
        'txtHouseHold
        '
        Me.txtHouseHold.Depth = 0
        Me.txtHouseHold.Hint = ""
        Me.txtHouseHold.Location = New System.Drawing.Point(103, 156)
        Me.txtHouseHold.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtHouseHold.Name = "txtHouseHold"
        Me.txtHouseHold.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHouseHold.SelectedText = ""
        Me.txtHouseHold.SelectionLength = 0
        Me.txtHouseHold.SelectionStart = 0
        Me.txtHouseHold.Size = New System.Drawing.Size(204, 23)
        Me.txtHouseHold.TabIndex = 1
        Me.txtHouseHold.UseSystemPasswordChar = False
        '
        'lblReqAccess
        '
        Me.lblReqAccess.AutoSize = True
        Me.lblReqAccess.Depth = 0
        Me.lblReqAccess.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblReqAccess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblReqAccess.Location = New System.Drawing.Point(151, 107)
        Me.lblReqAccess.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblReqAccess.Name = "lblReqAccess"
        Me.lblReqAccess.Size = New System.Drawing.Size(119, 19)
        Me.lblReqAccess.TabIndex = 0
        Me.lblReqAccess.Text = "Join Household:"
        '
        'RequestAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.controlsContainer)
        Me.Name = "RequestAccess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Request Access"
        Me.controlsContainer.ResumeLayout(False)
        Me.controlsContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents controlsContainer As Panel
    Friend WithEvents btnReqAccess As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtHouseHold As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblReqAccess As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tipHouse As ToolTip
End Class
