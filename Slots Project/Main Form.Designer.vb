Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.trkBar_SlotNumber = New System.Windows.Forms.TrackBar()
        Me.trkBar_Numbers = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lbl_trkBarSlotValue = New System.Windows.Forms.Label()
        Me.lbl_trkBarNumbersValue = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.trkBar_Lives = New System.Windows.Forms.TrackBar()
        Me.tmr_ValueChanged = New System.Windows.Forms.Timer(Me.components)
        Me.lblLastWins = New System.Windows.Forms.Label()
        Me.lbl_trkBarLivesValue = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.trkBar_SlotNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkBar_Numbers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkBar_Lives, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.InstructionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(372, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.InstructionsToolStripMenuItem.Text = "Instructions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 33)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Slot Number:"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'trkBar_SlotNumber
        '
        Me.trkBar_SlotNumber.Location = New System.Drawing.Point(12, 125)
        Me.trkBar_SlotNumber.Maximum = 7
        Me.trkBar_SlotNumber.Minimum = 3
        Me.trkBar_SlotNumber.Name = "trkBar_SlotNumber"
        Me.trkBar_SlotNumber.Size = New System.Drawing.Size(324, 56)
        Me.trkBar_SlotNumber.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.trkBar_SlotNumber, "Determines the Number of slots you'll have access to")
        Me.trkBar_SlotNumber.Value = 3
        '
        'trkBar_Numbers
        '
        Me.trkBar_Numbers.Location = New System.Drawing.Point(12, 201)
        Me.trkBar_Numbers.Minimum = 3
        Me.trkBar_Numbers.Name = "trkBar_Numbers"
        Me.trkBar_Numbers.Size = New System.Drawing.Size(324, 56)
        Me.trkBar_Numbers.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.trkBar_Numbers, "The Number Amount the Slots can choose from, for a possible match")
        Me.trkBar_Numbers.Value = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 33)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Numbers:"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Setup Game:"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(119, 400)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(134, 36)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start Game"
        Me.btnStart.UseCompatibleTextRendering = True
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lbl_trkBarSlotValue
        '
        Me.lbl_trkBarSlotValue.AutoSize = True
        Me.lbl_trkBarSlotValue.Location = New System.Drawing.Point(342, 125)
        Me.lbl_trkBarSlotValue.Name = "lbl_trkBarSlotValue"
        Me.lbl_trkBarSlotValue.Size = New System.Drawing.Size(18, 33)
        Me.lbl_trkBarSlotValue.TabIndex = 5
        Me.lbl_trkBarSlotValue.Text = "0"
        Me.lbl_trkBarSlotValue.UseCompatibleTextRendering = True
        '
        'lbl_trkBarNumbersValue
        '
        Me.lbl_trkBarNumbersValue.AutoSize = True
        Me.lbl_trkBarNumbersValue.Location = New System.Drawing.Point(342, 201)
        Me.lbl_trkBarNumbersValue.Name = "lbl_trkBarNumbersValue"
        Me.lbl_trkBarNumbersValue.Size = New System.Drawing.Size(18, 33)
        Me.lbl_trkBarNumbersValue.TabIndex = 8
        Me.lbl_trkBarNumbersValue.Text = "0"
        Me.lbl_trkBarNumbersValue.UseCompatibleTextRendering = True
        '
        'trkBar_Lives
        '
        Me.trkBar_Lives.Location = New System.Drawing.Point(12, 288)
        Me.trkBar_Lives.Maximum = 50
        Me.trkBar_Lives.Minimum = 3
        Me.trkBar_Lives.Name = "trkBar_Lives"
        Me.trkBar_Lives.Size = New System.Drawing.Size(324, 56)
        Me.trkBar_Lives.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.trkBar_Lives, "The Amount of Lives you'll start with at the Start of the Game.")
        Me.trkBar_Lives.Value = 3
        '
        'tmr_ValueChanged
        '
        Me.tmr_ValueChanged.Enabled = True
        Me.tmr_ValueChanged.Interval = 10
        '
        'lblLastWins
        '
        Me.lblLastWins.Location = New System.Drawing.Point(11, 333)
        Me.lblLastWins.Name = "lblLastWins"
        Me.lblLastWins.Size = New System.Drawing.Size(350, 60)
        Me.lblLastWins.TabIndex = 12
        Me.lblLastWins.Text = "You Won 0 Times Last Time!"
        Me.lblLastWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLastWins.UseCompatibleTextRendering = True
        '
        'lbl_trkBarLivesValue
        '
        Me.lbl_trkBarLivesValue.AutoSize = True
        Me.lbl_trkBarLivesValue.Location = New System.Drawing.Point(342, 288)
        Me.lbl_trkBarLivesValue.Name = "lbl_trkBarLivesValue"
        Me.lbl_trkBarLivesValue.Size = New System.Drawing.Size(18, 33)
        Me.lbl_trkBarLivesValue.TabIndex = 11
        Me.lbl_trkBarLivesValue.Text = "0"
        Me.lbl_trkBarLivesValue.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 33)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Lives:"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'FrmMain
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(372, 453)
        Me.Controls.Add(Me.lbl_trkBarLivesValue)
        Me.Controls.Add(Me.trkBar_Lives)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblLastWins)
        Me.Controls.Add(Me.lbl_trkBarNumbersValue)
        Me.Controls.Add(Me.lbl_trkBarSlotValue)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.trkBar_Numbers)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.trkBar_SlotNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Slots"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.trkBar_SlotNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkBar_Numbers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkBar_Lives, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents trkBar_SlotNumber As TrackBar
    Friend WithEvents trkBar_Numbers As TrackBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents lbl_trkBarSlotValue As Label
    Friend WithEvents lbl_trkBarNumbersValue As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents tmr_ValueChanged As Timer
    Friend WithEvents lblLastWins As Label
    Friend WithEvents lbl_trkBarLivesValue As Label
    Friend WithEvents trkBar_Lives As TrackBar
    Friend WithEvents Label4 As Label
End Class
