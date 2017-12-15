﻿' Name:         Slots Project - FINAL - 3 Slot Game
' Purpose:      The Classic Game of Slots!
' Programmer:   Chris Stack on 12/21/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class FrmGame_3Slots
    Dim randGen As New Random
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim oForm As FrmAbout
        oForm = New FrmAbout()
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub tmr_IsQuittingcheck_Tick(sender As Object, e As EventArgs) Handles tmr_IsQuittingcheck.Tick
        If My.Settings.IsQuitting Then
            Close()
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        IsQuitting()
    End Sub

    Public Sub IsQuitting()
        My.Settings.WantsToQuit = True
        My.Settings.Save()

        Dim oForm As frmMSGBOX
        oForm = New frmMSGBOX()
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        IsQuitting()
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim intNum1 As Integer = randGen.Next(My.Settings.RandomNumbers)
        Dim intNum2 As Integer = randGen.Next(My.Settings.RandomNumbers)
        Dim intNum3 As Integer = randGen.Next(My.Settings.RandomNumbers)

        lblNum1.Text = intNum1.ToString()
        lblNum2.Text = intNum2.ToString()
        lblNum3.Text = intNum3.ToString()

        If intNum1 = intNum2 AndAlso intNum1 = intNum3 Then
            lblNum1.BackColor = Color.Green
            lblNum2.BackColor = Color.Green
            lblNum3.BackColor = Color.Green
        End If
    End Sub
End Class