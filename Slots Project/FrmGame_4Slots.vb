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
        oForm = Nothing
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
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

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        intNum1 = randGen.Next(My.Settings.RandomNumbers)
        intNum2 = randGen.Next(My.Settings.RandomNumbers)
        intNum3 = randGen.Next(My.Settings.RandomNumbers)
        intNum4 = randGen.Next(My.Settings.RandomNumbers)

        lblNum1.Text = intNum1.ToString()
        lblNum2.Text = intNum2.ToString()
        lblNum3.Text = intNum3.ToString()
        lblNum4.Text = intNum4.ToString()
    End Sub

    Private Sub tmrWinCheck_Tick(sender As Object, e As EventArgs) Handles tmrWinCheck.Tick
        If intNum1 = intNum2 AndAlso intNum1 = intNum3 AndAlso intNum1 = intNum4 Then
            lblNum1.BackColor = Color.Green
            lblNum1.ForeColor = Color.Gold
            lblNum2.BackColor = Color.Green
            lblNum2.ForeColor = Color.Gold
            lblNum3.BackColor = Color.Green
            lblNum3.ForeColor = Color.Gold
            lblNum4.BackColor = Color.Green
            lblNum4.ForeColor = Color.Gold

            ' PLACEHOLDER: ADD WIN AND RESTART PROCEDURES
        Else
            lblNum1.BackColor = Color.Transparent
            lblNum1.ForeColor = Color.Black
            lblNum2.BackColor = Color.Transparent
            lblNum2.ForeColor = Color.Black
            lblNum3.BackColor = Color.Transparent
            lblNum3.ForeColor = Color.Black
            lblNum4.BackColor = Color.Transparent
            lblNum4.ForeColor = Color.Black
        End If
    End Sub
End Class