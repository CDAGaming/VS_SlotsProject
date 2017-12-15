' Name:         Slots Project - FINAL - 4 Slot Game
' Purpose:      The Classic Game of Slots!
' Programmer:   Chris Stack on 12/21/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class FrmGame_4Slots
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
End Class