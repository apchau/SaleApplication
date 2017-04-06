<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.Maroon
        Me.panel2.Controls.Add(Me.lblTitle)
        Me.panel2.Location = New System.Drawing.Point(1, 1)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(587, 54)
        Me.panel2.TabIndex = 26
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("High Tower Text", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(123, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(320, 34)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Customer Management"
        '
        'button4
        '
        Me.button4.BackColor = System.Drawing.Color.Maroon
        Me.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.button4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.ForeColor = System.Drawing.SystemColors.Control
        Me.button4.Location = New System.Drawing.Point(434, 291)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(75, 34)
        Me.button4.TabIndex = 22
        Me.button4.Text = "&Close"
        Me.button4.UseVisualStyleBackColor = False
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.Maroon
        Me.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.SystemColors.Control
        Me.button3.Location = New System.Drawing.Point(315, 291)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(75, 34)
        Me.button3.TabIndex = 23
        Me.button3.Text = "&Search"
        Me.button3.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Maroon
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUpdate.Location = New System.Drawing.Point(198, 291)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 34)
        Me.btnUpdate.TabIndex = 24
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Maroon
        Me.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNew.Location = New System.Drawing.Point(79, 291)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 34)
        Me.btnNew.TabIndex = 25
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 337)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNew)
        Me.Name = "frmCustomer"
        Me.Text = "frmCustomer"
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel2 As Panel
    Private WithEvents lblTitle As Label
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents btnUpdate As Button
    Private WithEvents btnNew As Button
End Class
