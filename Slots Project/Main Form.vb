' Name:         Slots Project - FINAL
' Purpose:      The Classic Game of Slots!
' Programmer:   Chris Stack on 12/21/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class FrmMain
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim oForm As FrmAbout
        oForm = New FrmAbout()
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles InstructionsToolStripMenuItem.Click
        My.Settings.ViewingInstructions = True
        My.Settings.Save()
        Dim oForm As frmMSGBOX
        oForm = New frmMSGBOX()
        oForm.ShowDialog()
        oForm = Nothing
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        trkBar_SlotNumber.Value = My.Settings.Slots
        trkBar_Numbers.Value = My.Settings.RandomNumbers
    End Sub

    Private Sub SlotNumber_ValuesChanged(sender As Object, e As System.EventArgs) Handles trkBar_SlotNumber.ValueChanged
        lbl_trkBarSlotValue.Text = trkBar_SlotNumber.Value.ToString()

        My.Settings.Slots = trkBar_SlotNumber.Value
        My.Settings.Save()
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As System.EventArgs) Handles btnStart.Click

    End Sub

    Private Sub RandomNumbers_ValueChanged(sender As Object, e As System.EventArgs) Handles trkBar_Numbers.ValueChanged
        lbl_trkBarNumbersValue.Text = trkBar_Numbers.Value.ToString()

        My.Settings.RandomNumbers = trkBar_Numbers.Value
        My.Settings.Save()
    End Sub
End Class
