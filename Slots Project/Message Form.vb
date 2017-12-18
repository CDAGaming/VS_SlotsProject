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
            BtnOK_ViewingInstructions()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As System.EventArgs) Handles btnCancel.Click
        If My.Settings.ViewingInstructions Then
            BtnCancel_ViewingInstructions()
        End If
        If My.Settings.AskingForInstructions Then
            BtnCancel_AskingForInstructions()
        End If
    End Sub

    Private Sub BtnYES_Click(sender As Object, e As System.EventArgs) Handles btnYES.Click
        If My.Settings.AskingForInstructions Then
            BtnYES_AskingForInstructions()
        End If
        If My.Settings.WantsToQuit Then
            BtnYES_WantsToQuit()
        End If
    End Sub

    Private Sub BtnNO_Click(sender As Object, e As System.EventArgs) Handles btnNO.Click
        If My.Settings.AskingForInstructions Then
            BtnNO_AskingForInstructions()
        End If
        If My.Settings.WantsToQuit Then
            BtnNO_WantsToQuit()
        End If
    End Sub

    ' <<<<=========== Button MAIN Events END =============>>>>
    Public Sub BtnOK_ViewingInstructions()
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
                'Launch frmGame_5Slots
            Case 6
                'Launch frmGame_6Slots
            Case 7
                'Launch frmGame_7Slots
            Case Else
                MessageBox.Show("Unknown Combination, Please Try Again.", "Slots: Error", MessageBoxButtons.OK)
                Close()
        End Select
        My.Settings.ViewingInstructions = False
        My.Settings.Save()
        DialogResult = DialogResult.OK
    End Sub
    ' <<<<============= BtnCancel Events =============>>>>
    Public Sub BtnCancel_ViewingInstructions()
        My.Settings.ViewingInstructions = False
        My.Settings.Save()
        DialogResult = DialogResult.Cancel
    End Sub

    Public Sub BtnCancel_AskingForInstructions()
        My.Settings.AskingForInstructions = False
        My.Settings.Save()
        DialogResult = DialogResult.Cancel
    End Sub

    ' <<<============= BtnCancel Events END =============>>>
    '  <<<================ BtnYES Events ===============>>>
    Public Sub BtnYES_AskingForInstructions() ' Event is Dual Dialog (No DialogResult until 2nd Dialog)
        My.Settings.AskingForInstructions = False
        My.Settings.ViewingInstructions = True
        My.Settings.Save()
    End Sub

    Public Sub BtnYES_WantsToQuit()
        ' Close the Game Form Currently Opened
        My.Settings.WantsToQuit = False
        My.Settings.Save()
        DialogResult = DialogResult.Yes
    End Sub
    '<<<=============== BtnYES Events END ===============>>>
    ' <<<================ BtnNO Events =================>>>
    Public Sub BtnNO_AskingForInstructions()
        ' Launch this Event instead of Duplicating Code
        BtnOK_ViewingInstructions()
    End Sub

    Public Sub BtnNO_WantsToQuit()
        My.Settings.WantsToQuit = False
        My.Settings.Save()
        DialogResult = DialogResult.No
    End Sub
    '<<<================ BtnNO Events END =================>>>

    Private Sub FrmMSGBOX_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.ViewingInstructions = False
        My.Settings.AskingForInstructions = False
        My.Settings.WantsToQuit = False
        My.Settings.Save()
    End Sub

    Private Sub tmrLoadCheck_Tick(sender As Object, e As EventArgs) Handles tmrLoadCheck.Tick
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