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
    End Sub

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
    End Sub

    Private Sub BtnNO_Click(sender As Object, e As System.EventArgs) Handles btnNO.Click
        If My.Settings.AskingForInstructions Then

        End If
    End Sub

    Public Sub BtnOK_ViewingInstructions()
        'Launch Game Form Based on Slots
        Select Case My.Settings.Slots
            Case 3
                Dim oForm As FrmGame_3Slots
                oForm = New FrmGame_3Slots()
                oForm.ShowDialog()
                oForm = Nothing
            Case 4
                'Launch frmGame_4Slots
            Case 5
                'Launch frmGame_5Slots
            Case 6
                'Launch frmGame_6Slots
            Case 7
                'Launch frmGame_7Slots
        End Select
        My.Settings.ViewingInstructions = False
        My.Settings.Save()
        Close()
    End Sub

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

    Public Sub BtnNO_AskingForInstructions()
        'Launch Game Form Based on Slots
        Select Case My.Settings.Slots
            Case 3
                Dim oForm As FrmGame_3Slots
                oForm = New FrmGame_3Slots()
                oForm.ShowDialog()
                oForm = Nothing
            Case 4
                'Launch frmGame_4Slots
            Case 5
                'Launch frmGame_5Slots
            Case 6
                'Launch frmGame_6Slots
            Case 7
                'Launch frmGame_7Slots
        End Select
        My.Settings.AskingForInstructions = False
        My.Settings.Save()
        Close()
    End Sub

    Private Sub FrmMSGBOX_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.ViewingInstructions = False
        My.Settings.AskingForInstructions = False
        My.Settings.Save()
    End Sub
End Class