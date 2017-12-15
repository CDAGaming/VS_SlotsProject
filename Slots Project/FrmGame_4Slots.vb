' Name:         Slots Project - FINAL - 4 Slot Game
' Purpose:      The Classic Game of Slots!
' Programmer:   Chris Stack on 12/21/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class FrmGame_4Slots
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim oForm As FrmAbout
        oForm = New FrmAbout()
        oForm.Show()
        oForm = Nothing
    End Sub
End Class