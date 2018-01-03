' Name:         Slots Project - FINAL
' Purpose:      The Classic Game of Slots!
' Programmer:   Chris Stack on 12/21/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMSGBOX
    ' <<<<============= Button MAIN Events =============>>>>
    Private Sub BtnOK_Click(sender As Object, e As System.EventArgs) Handles btnOK.Click
        If My.Settings.ViewingInstructions Then
            LaunchGame()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As System.EventArgs) Handles btnCancel.Click
        If My.Settings.ViewingInstructions Then
            My.Settings.ViewingInstructions = False
            My.Settings.Save()
            DialogResult = DialogResult.Cancel
        ElseIf My.Settings.AskingForInstructions Then
            My.Settings.AskingForInstructions = False
            My.Settings.Save()
            DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub BtnYES_Click(sender As Object, e As System.EventArgs) Handles btnYES.Click
        If My.Settings.AskingForInstructions Then
            ' Dual-Dialog (Opens Viewing Instructions MSG)
            My.Settings.AskingForInstructions = False
            My.Settings.ViewingInstructions = True
            My.Settings.Save()
        ElseIf My.Settings.WantsToQuit Then
            ' Close the Game Form Currently Opened
            My.Settings.WantsToQuit = False
            My.Settings.Save()
            DialogResult = DialogResult.Yes
        ElseIf My.Settings.WantsToRestart Then
            My.Settings.WantsToRestart = False
            My.Settings.Save()
            DialogResult = DialogResult.Yes
        End If
    End Sub

    Private Sub BtnNO_Click(sender As Object, e As System.EventArgs) Handles btnNO.Click
        If My.Settings.AskingForInstructions Then
            ' Launch this Event instead of Duplicating Code
            LaunchGame()
        ElseIf My.Settings.WantsToQuit Then
            My.Settings.WantsToQuit = False
            My.Settings.Save()
            DialogResult = DialogResult.No
        ElseIf My.Settings.WantsToRestart Then
            My.Settings.WantsToRestart = False
            My.Settings.Save()
            DialogResult = DialogResult.No
        End If
    End Sub

    ' <<<<=========== Button MAIN Events END =============>>>>
    Public Sub LaunchGame()
        'Launch Game Form Based on Slots you Picked
        Select Case My.Settings.Slots
            Case 3
                Dim oForm_3Game As FrmGame_3Slots = New FrmGame_3Slots()
                oForm_3Game.Show()
                Close()
            Case 4
                Dim oForm_4Game As FrmGame_4Slots = New FrmGame_4Slots()
                oForm_4Game.Show()
                Close()
            Case 5
                Dim oForm_5Game As FrmGame_5Slots = New FrmGame_5Slots()
                oForm_5Game.Show()
                Close()
            Case 6
                Dim oForm_6Game As FrmGame_6Slots = New FrmGame_6Slots()
                oForm_6Game.Show()
                Close()
            Case 7
                Dim oForm_7Game As FrmGame_7Slots = New FrmGame_7Slots()
                oForm_7Game.Show()
                Close()
            Case Else
                MessageBox.Show("Unknown Combination, Please Try Again.", "Slots: Error", MessageBoxButtons.OK)
                Close()
        End Select
        My.Settings.ViewingInstructions = False
        My.Settings.Save()
        DialogResult = DialogResult.OK
    End Sub

    Private Sub FrmMSGBOX_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.ViewingInstructions = False
        My.Settings.AskingForInstructions = False
        My.Settings.WantsToQuit = False
        My.Settings.Save()
    End Sub

    Private Sub TmrLoadCheck_Tick(sender As Object, e As EventArgs) Handles tmrLoadCheck.Tick
        ' On Each Tick, Check & Adjust MessageBox According to Settings
        If My.Settings.ViewingInstructions Then
            Text = My.Resources.TitleInstructions
            picIcon.BackgroundImage = My.Resources.msgBox_Info
            lblMSG.Text = My.Resources.MSGInstructions
            btnCancel.Visible = True
            btnCancel.Enabled = True
            btnOK.Visible = True
            btnOK.Enabled = True
            btnNO.Visible = False
            btnNO.Enabled = False
            btnYES.Visible = False
            btnYES.Enabled = False
            AcceptButton = btnOK
            CancelButton = btnCancel
        ElseIf My.Settings.AskingForInstructions Then
            Text = My.Resources.Title_AskingInstructions
            picIcon.BackgroundImage = My.Resources.msgBox_Info
            lblMSG.Text = My.Resources.MSG_AskingInstructions
            btnCancel.Visible = True
            btnCancel.Enabled = True
            btnYES.Visible = True
            btnYES.Enabled = True
            btnNO.Visible = True
            btnNO.Enabled = True
            btnOK.Visible = False
            btnOK.Enabled = False
            AcceptButton = btnYES
            CancelButton = btnCancel
        ElseIf My.Settings.WantsToQuit Then
            Text = My.Resources.Title_IsQuitting
            picIcon.BackgroundImage = My.Resources.msgBox_Warning
            lblMSG.Text = My.Resources.MSG_IsQuitting
            btnYES.Visible = True
            btnYES.Enabled = True
            btnNO.Visible = True
            btnNO.Enabled = True
            btnOK.Visible = False
            btnOK.Enabled = False
            btnCancel.Visible = False
            btnCancel.Enabled = False
            AcceptButton = btnYES
            CancelButton = btnNO
        ElseIf My.Settings.WantsToRestart Then
            Text = My.Resources.Title_IsRestarting
            picIcon.BackgroundImage = My.Resources.msgBox_Info
            lblMSG.Text = My.Resources.MSG_IsRestarting
            btnYES.Visible = True
            btnYES.Enabled = True
            btnNO.Visible = True
            btnNO.Enabled = True
            btnOK.Visible = False
            btnOK.Enabled = False
            btnCancel.Visible = False
            btnCancel.Enabled = False
            AcceptButton = btnYES
            CancelButton = btnNO
        End If
    End Sub
End Class