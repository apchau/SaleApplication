<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStaff
        '
        Me.btnStaff.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnStaff.BackgroundImage = CType(resources.GetObject("btnStaff.BackgroundImage"), System.Drawing.Image)
        Me.btnStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStaff.FlatAppearance.BorderSize = 0
        Me.btnStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStaff.Location = New System.Drawing.Point(24, 66)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(83, 78)
        Me.btnStaff.TabIndex = 10
        Me.btnStaff.UseVisualStyleBackColor = False
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCustomer.BackgroundImage = CType(resources.GetObject("btnCustomer.BackgroundImage"), System.Drawing.Image)
        Me.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCustomer.FlatAppearance.BorderSize = 0
        Me.btnCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustomer.Location = New System.Drawing.Point(145, 66)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(83, 78)
        Me.btnCustomer.TabIndex = 11
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'btnProduct
        '
        Me.btnProduct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnProduct.BackgroundImage = CType(resources.GetObject("btnProduct.BackgroundImage"), System.Drawing.Image)
        Me.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnProduct.FlatAppearance.BorderSize = 0
        Me.btnProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProduct.Location = New System.Drawing.Point(266, 66)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(83, 78)
        Me.btnProduct.TabIndex = 12
        Me.btnProduct.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), System.Drawing.Image)
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Location = New System.Drawing.Point(388, 66)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(83, 78)
        Me.btnLogout.TabIndex = 13
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Location = New System.Drawing.Point(507, 66)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 78)
        Me.btnExit.TabIndex = 14
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 212)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(621, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(142, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 23)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(266, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 23)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(388, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 23)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(507, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 23)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Label5"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 234)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnProduct)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.btnStaff)
        Me.Name = "frmMain"
        Me.Text = "Management System"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnStaff As Button
    Private WithEvents btnCustomer As Button
    Private WithEvents btnProduct As Button
    Private WithEvents btnLogout As Button
    Private WithEvents btnExit As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
