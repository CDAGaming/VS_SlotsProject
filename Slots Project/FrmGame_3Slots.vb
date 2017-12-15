' Name:         Slots Project - FINAL - 3 Slot Game
' Purpose:      The Classic Game of Slots!
' Programmer:   Chris Stack on 12/21/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class FrmGame_3Slots
    Dim randGen As New Random
    Private Sub FrmGame_3Slots_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim oForm As FrmAbout
        oForm = New FrmAbout()
        oForm.Show()
        oForm = Nothing
    End Sub
End Class