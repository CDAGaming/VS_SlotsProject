Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMSGBOX
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
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.lblMSG = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnYES = New System.Windows.Forms.Button()
        Me.btnNO = New System.Windows.Forms.Button()
        Me.tmrLoadCheck = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picIcon
        '
        Me.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picIcon.Location = New System.Drawing.Point(12, 12)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(120, 120)
        Me.picIcon.TabIndex = 0
        Me.picIcon.TabStop = False
        '
        'lblMSG
        '
        Me.lblMSG.AutoSize = True
        Me.lblMSG.Location = New System.Drawing.Point(148, 12)
        Me.lblMSG.Name = "lblMSG"
        Me.lblMSG.Size = New System.Drawing.Size(439, 46)
        Me.lblMSG.TabIndex = 1
        Me.lblMSG.Text = "This is a Dynamic Messagebox. In here, other Forms Can" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " specify what text they w" &
    "ould want in here besides this."
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(490, 176)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 35)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        Me.btnOK.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(12, 176)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 35)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnYES
        '
        Me.btnYES.Enabled = False
        Me.btnYES.Location = New System.Drawing.Point(197, 176)
        Me.btnYES.Name = "btnYES"
        Me.btnYES.Size = New System.Drawing.Size(100, 35)
        Me.btnYES.TabIndex = 4
        Me.btnYES.Text = "Yes"
        Me.btnYES.UseVisualStyleBackColor = True
        Me.btnYES.Visible = False
        '
        'btnNO
        '
        Me.btnNO.Enabled = False
        Me.btnNO.Location = New System.Drawing.Point(303, 176)
        Me.btnNO.Name = "btnNO"
        Me.btnNO.Size = New System.Drawing.Size(100, 35)
        Me.btnNO.TabIndex = 5
        Me.btnNO.Text = "No"
        Me.btnNO.UseVisualStyleBackColor = True
        Me.btnNO.Visible = False
        '
        'tmrLoadCheck
        '
        Me.tmrLoadCheck.Enabled = True
        Me.tmrLoadCheck.Interval = 10
        '
        'frmMSGBOX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 223)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnNO)
        Me.Controls.Add(Me.btnYES)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblMSG)
        Me.Controls.Add(Me.picIcon)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimizeBox = False
        Me.Name = "frmMSGBOX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MessageBoxTitle"
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picIcon As PictureBox
    Friend WithEvents lblMSG As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnYES As Button
    Friend WithEvents btnNO As Button
    Friend WithEvents tmrLoadCheck As Timer
End Class
