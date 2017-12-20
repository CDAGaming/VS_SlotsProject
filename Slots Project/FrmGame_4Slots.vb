' Name:         Slots Project - FINAL - 4 Slot Game
' Purpose:      The Classic Game of Slots!
' Programmer:   Chris Stack on 12/21/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class FrmGame_4Slots
    Dim randGen As New Random
    Dim intNum1 As Integer
    Dim intNum2 As Integer
    Dim intNum3 As Integer
    Dim intNum4 As Integer

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim oForm As FrmAbout = New FrmAbout()
        oForm.ShowDialog()
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        IsQuitting()
    End Sub

    Public Sub IsQuitting()
        My.Settings.WantsToQuit = True
        My.Settings.Save()

        Dim oForm As frmMSGBOX = New frmMSGBOX()
        If oForm.ShowDialog() = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        IsQuitting()
    End Sub

    Private Sub BtnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        RollNumbers()
    End Sub

    Private Sub TmrWinCheck_Tick(sender As Object, e As EventArgs) Handles tmrWinCheck.Tick
        If intNum1 = intNum2 AndAlso intNum1 = intNum3 AndAlso intNum1 = intNum4 Then
            lblNum1.ForeColor = Color.Green
            lblNum2.ForeColor = Color.Green
            lblNum3.ForeColor = Color.Green
            lblNum4.ForeColor = Color.Green

            tmrWinCheck.Stop()
            btnRoll.Enabled = False
            My.Settings.TotalWins += 1
            My.Settings.WantsToRestart = True
            My.Settings.Save()

            Dim oForm As frmMSGBOX = New frmMSGBOX()
            If oForm.ShowDialog() = DialogResult.Yes Then
                RollNumbers()
                tmrWinCheck.Start()
                btnRoll.Enabled = True
                lblWins.Text = "Wins" & ControlChars.NewLine & My.Settings.TotalWins.ToString()
            Else
                My.Settings.WantsToRestart = False
                My.Settings.Save()
                Close()
            End If
        Else
            lblNum1.ForeColor = Color.Maroon
            lblNum2.ForeColor = Color.Maroon
            lblNum3.ForeColor = Color.Maroon
            lblNum4.ForeColor = Color.Maroon
        End If
    End Sub

    Private Sub FrmGame_4Slots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RollNumbers()
    End Sub

    Public Sub RollNumbers()
        intNum1 = randGen.Next(1, My.Settings.RandomNumbers)
        intNum2 = randGen.Next(1, My.Settings.RandomNumbers)
        intNum3 = randGen.Next(1, My.Settings.RandomNumbers)
        intNum4 = randGen.Next(1, My.Settings.RandomNumbers)

        lblNum1.Text = intNum1.ToString()
        lblNum2.Text = intNum2.ToString()
        lblNum3.Text = intNum3.ToString()
        lblNum4.Text = intNum4.ToString()
    End Sub
End Class