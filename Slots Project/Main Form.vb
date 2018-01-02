' Name:         Slots Project - FINAL
' Purpose:      The Classic Game of Slots!
' Programmer:   Chris Stack on 12/21/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class FrmMain
    Dim Slots() As Process
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim oForm As FrmAbout = New FrmAbout()
        oForm.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles InstructionsToolStripMenuItem.Click
        My.Settings.ViewingInstructions = True
        My.Settings.Save()

        Dim oForm As frmMSGBOX = New frmMSGBOX()
        If oForm.ShowDialog = DialogResult.Cancel Then
        Else
            Close()
        End If
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        ' Check if this application is already Open, and If so, Close this
        If Process.GetProcessesByName("Slots").Count > 1 Then
            Close()
        End If

        ' Initial Loading of TrackBars & Labels
        trkBar_SlotNumber.Value = My.Settings.Slots
        lbl_trkBarSlotValue.Text = My.Settings.Slots.ToString()

        trkBar_Numbers.Value = My.Settings.RandomNumbers
        lbl_trkBarNumbersValue.Text = My.Settings.RandomNumbers.ToString()

        If My.Settings.LastWins = 1 Then
            lblLastWins.Text = My.Resources.MSGLastWins.Replace("0", My.Settings.LastWins.ToString()).Replace("Times", "Time")
        Else
            lblLastWins.Text = My.Resources.MSGLastWins.Replace("0", My.Settings.LastWins.ToString())
        End If
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As System.EventArgs) Handles btnStart.Click
        My.Settings.AskingForInstructions = True
        My.Settings.Save()

        Dim oForm As frmMSGBOX = New frmMSGBOX()
        If oForm.ShowDialog() = DialogResult.Cancel Then
        Else
            Close()
        End If
    End Sub

    Private Sub tmr_ValueChanged_Tick(sender As Object, e As EventArgs) Handles tmr_ValueChanged.Tick
        ' On Each Tick, Apply any changes for Settings on Front and Backend
        lbl_trkBarNumbersValue.Text = trkBar_Numbers.Value.ToString()
        lbl_trkBarSlotValue.Text = trkBar_SlotNumber.Value.ToString()

        My.Settings.RandomNumbers = trkBar_Numbers.Value
        My.Settings.Slots = trkBar_SlotNumber.Value
        My.Settings.Save()
    End Sub
End Class
