' Name:         Slots Project - FINAL
' Purpose:      The Classic Game of Slots!
' Programmer:   Chris Stack on 12/21/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMSGBOX
    Private Sub FrmMSGBOX_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        'Choose Data & Events to Display Depending on Settings
        If My.Settings.ViewingInstructions Then
            Text = My.Resources.TitleInstructions
            picIcon.BackgroundImage = My.Resources.msgBox_Info
            lblMSG.Text = My.Resources.MSGInstructions
            btnCancel.Visible = True
            btnOK.Visible = True
            btnOK.Enabled = True
            btnCancel.Enabled = True
        End If

        If My.Settings.AskingForInstructions Then
            Text = My.Resources.Title_AskingInstructions
            picIcon.BackgroundImage = My.Resources.msgBox_Info
            lblMSG.Text = My.Resources.MSG_AskingInstructions
            btnCancel.Visible = True
            btnYES.Visible = True
            btnNO.Visible = True
            btnCancel.Enabled = True
            btnYES.Enabled = True
            btnNO.Enabled = True
        End If

        If My.Settings.WantsToQuit Then
            Text = My.Resources.Title_IsQuitting
            picIcon.BackgroundImage = My.Resources.msgBox_Warning
            lblMSG.Text = My.Resources.MSG_IsQuitting
            btnCancel.Visible = True
            btnYES.Visible = True
            btnNO.Visible = True
            btnCancel.Enabled = True
            btnYES.Enabled = True
            btnNO.Enabled = True
        End If
    End Sub
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
        If My.Settings.WantsToQuit Then
            BtnCancel_WantsToQuit()
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
        'Launch Game Form Based on Slots
        Select Case My.Settings.Slots
            Case 3
                Dim oForm As FrmGame_3Slots
                oForm = New FrmGame_3Slots()
                oForm.ShowDialog()
                oForm = Nothing
            Case 4
                Dim oForm As FrmGame_4Slots
                oForm = New FrmGame_4Slots()
                oForm.ShowDialog()
                oForm = Nothing
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
        Close()
    End Sub
    ' <<<<============= BtnCancel Events =============>>>>
    Public Sub BtnCancel_ViewingInstructions()
        My.Settings.ViewingInstructions = False
        My.Settings.Save()
        Close()
    End Sub

    Public Sub BtnCancel_AskingForInstructions()
        My.Settings.AskingForInstructions = False
        My.Settings.Save()
        Close()
    End Sub

    Public Sub BtnCancel_WantsToQuit()
        My.Settings.WantsToQuit = False
        My.Settings.Save()
        Close()
    End Sub
    ' <<<============= BtnCancel Events END =============>>>
    '  <<<================ BtnYES Events ===============>>>
    Public Sub BtnYES_AskingForInstructions()
        My.Settings.AskingForInstructions = False
        My.Settings.ViewingInstructions = True
        My.Settings.Save()

        Dim oForm As frmMSGBOX
        oForm = New frmMSGBOX()
        oForm.ShowDialog()
        oForm = Nothing
        Close()
    End Sub

    Public Sub BtnYES_WantsToQuit()
        ' Close the Game Form Currently Opened
        ' Via Setting IsQuitting to True, hooked to a Timer
        My.Settings.IsQuitting = True
        My.Settings.Save()
        Close()
    End Sub
    '<<<=============== BtnYES Events END ===============>>>
    ' <<<================ BtnNO Events =================>>>
    Public Sub BtnNO_AskingForInstructions()
        ' Launch this Event instead of Duplicating Code
        BtnOK_ViewingInstructions()
    End Sub

    Public Sub BtnNO_WantsToQuit()
        ' Launch this Event instead of Duplicating Code
        BtnCancel_WantsToQuit()
    End Sub
    '<<<================ BtnNO Events END =================>>>

    Private Sub FrmMSGBOX_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.ViewingInstructions = False
        My.Settings.AskingForInstructions = False
        My.Settings.WantsToQuit = False
        My.Settings.IsQuitting = False
        My.Settings.Save()
    End Sub
End Class