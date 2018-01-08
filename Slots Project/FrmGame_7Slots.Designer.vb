<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGame_7Slots
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGame_7Slots))
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrWinCheck = New System.Windows.Forms.Timer(Me.components)
        Me.lblNum6 = New System.Windows.Forms.Label()
        Me.lblNum5 = New System.Windows.Forms.Label()
        Me.lblNum4 = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.lblNum3 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.lblNum7 = New System.Windows.Forms.Label()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum1.ForeColor = System.Drawing.Color.Maroon
        Me.lblNum1.Location = New System.Drawing.Point(14, 53)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(54, 84)
        Me.lblNum1.TabIndex = 3
        Me.lblNum1.Text = "0"
        Me.lblNum1.UseCompatibleTextRendering = True
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(125, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(125, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'tmrWinCheck
        '
        Me.tmrWinCheck.Enabled = True
        Me.tmrWinCheck.Interval = 10
        '
        'lblNum6
        '
        Me.lblNum6.AutoSize = True
        Me.lblNum6.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum6.ForeColor = System.Drawing.Color.Maroon
        Me.lblNum6.Location = New System.Drawing.Point(209, 128)
        Me.lblNum6.Name = "lblNum6"
        Me.lblNum6.Size = New System.Drawing.Size(54, 84)
        Me.lblNum6.TabIndex = 8
        Me.lblNum6.Text = "0"
        Me.lblNum6.UseCompatibleTextRendering = True
        '
        'lblNum5
        '
        Me.lblNum5.AutoSize = True
        Me.lblNum5.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum5.ForeColor = System.Drawing.Color.Maroon
        Me.lblNum5.Location = New System.Drawing.Point(52, 128)
        Me.lblNum5.Name = "lblNum5"
        Me.lblNum5.Size = New System.Drawing.Size(54, 84)
        Me.lblNum5.TabIndex = 5
        Me.lblNum5.Text = "0"
        Me.lblNum5.UseCompatibleTextRendering = True
        '
        'lblNum4
        '
        Me.lblNum4.AutoSize = True
        Me.lblNum4.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum4.ForeColor = System.Drawing.Color.Maroon
        Me.lblNum4.Location = New System.Drawing.Point(260, 53)
        Me.lblNum4.Name = "lblNum4"
        Me.lblNum4.Size = New System.Drawing.Size(54, 84)
        Me.lblNum4.TabIndex = 6
        Me.lblNum4.Text = "0"
        Me.lblNum4.UseCompatibleTextRendering = True
        '
        'btnQuit
        '
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.Location = New System.Drawing.Point(12, 363)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(102, 38)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseCompatibleTextRendering = True
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(220, 363)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(102, 38)
        Me.btnRoll.TabIndex = 2
        Me.btnRoll.Text = "Roll"
        Me.btnRoll.UseCompatibleTextRendering = True
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'lblNum3
        '
        Me.lblNum3.AutoSize = True
        Me.lblNum3.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum3.ForeColor = System.Drawing.Color.Maroon
        Me.lblNum3.Location = New System.Drawing.Point(190, 53)
        Me.lblNum3.Name = "lblNum3"
        Me.lblNum3.Size = New System.Drawing.Size(54, 84)
        Me.lblNum3.TabIndex = 7
        Me.lblNum3.Text = "0"
        Me.lblNum3.UseCompatibleTextRendering = True
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum2.ForeColor = System.Drawing.Color.Maroon
        Me.lblNum2.Location = New System.Drawing.Point(67, 53)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(54, 84)
        Me.lblNum2.TabIndex = 4
        Me.lblNum2.Text = "0"
        Me.lblNum2.UseCompatibleTextRendering = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(334, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'lblNum7
        '
        Me.lblNum7.AutoSize = True
        Me.lblNum7.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum7.ForeColor = System.Drawing.Color.Maroon
        Me.lblNum7.Location = New System.Drawing.Point(132, 128)
        Me.lblNum7.Name = "lblNum7"
        Me.lblNum7.Size = New System.Drawing.Size(54, 84)
        Me.lblNum7.TabIndex = 9
        Me.lblNum7.Text = "0"
        Me.lblNum7.UseCompatibleTextRendering = True
        '
        'lblLives
        '
        Me.lblLives.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLives.ForeColor = System.Drawing.Color.Yellow
        Me.lblLives.Location = New System.Drawing.Point(224, 296)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(94, 64)
        Me.lblLives.TabIndex = 11
        Me.lblLives.Text = "Lives" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00"
        Me.lblLives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLives.UseCompatibleTextRendering = True
        '
        'lblWins
        '
        Me.lblWins.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWins.ForeColor = System.Drawing.Color.Yellow
        Me.lblWins.Location = New System.Drawing.Point(16, 296)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(94, 64)
        Me.lblWins.TabIndex = 10
        Me.lblWins.Text = "Wins" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00"
        Me.lblWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWins.UseCompatibleTextRendering = True
        '
        'FrmGame_7Slots
        '
        Me.AcceptButton = Me.btnRoll
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(334, 413)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.lblWins)
        Me.Controls.Add(Me.lblNum7)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.lblNum6)
        Me.Controls.Add(Me.lblNum5)
        Me.Controls.Add(Me.lblNum4)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.lblNum3)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGame_7Slots"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Slots - 7 Slot Game"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNum1 As Label
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tmrWinCheck As Timer
    Friend WithEvents lblNum6 As Label
    Friend WithEvents lblNum5 As Label
    Friend WithEvents lblNum4 As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnRoll As Button
    Friend WithEvents lblNum3 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents lblNum7 As Label
    Friend WithEvents lblLives As Label
    Friend WithEvents lblWins As Label
End Class
