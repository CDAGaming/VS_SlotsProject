' Name:         Slots Project - FINAL
' Purpose:      The Classic Game of Slots!
' Programmer:   Chris Stack on 12/21/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class FrmMain
    Dim FontCollection As New Text.PrivateFontCollection()
    Dim fontMemPointer As IntPtr
    Dim AboutForm As FrmAbout = New FrmAbout()
    Dim MSGBoxForm As frmMSGBOX = New frmMSGBOX()
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles InstructionsToolStripMenuItem.Click
        My.Settings.ViewingInstructions = True
        My.Settings.Save()

        If Not MSGBoxForm.ShowDialog = DialogResult.Cancel Then
            Close()
        End If
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        ' Load Custom Font Files
        fontMemPointer = Runtime.InteropServices.Marshal.AllocCoTaskMem(My.Resources.Montserrat_Regular.Length)
        Runtime.InteropServices.Marshal.Copy(My.Resources.Montserrat_Regular, 0, fontMemPointer, My.Resources.Montserrat_Regular.Length)
        FontCollection.AddMemoryFont(fontMemPointer, My.Resources.Montserrat_Regular.Length)
        Runtime.InteropServices.Marshal.FreeCoTaskMem(fontMemPointer)

        lblLastWins.Font = New Font(FontCollection.Families(0), 10, FontStyle.Regular)
        lbl_trkBarNumbersValue.Font = New Font(FontCollection.Families(0), 10, FontStyle.Regular)
        lbl_trkBarSlotValue.Font = New Font(FontCollection.Families(0), 10, FontStyle.Regular)
        lbl_trkBarLivesValue.Font = New Font(FontCollection.Families(0), 10, FontStyle.Regular)
        Label1.Font = New Font(FontCollection.Families(0), 10, FontStyle.Regular)
        Label2.Font = New Font(FontCollection.Families(0), 10, FontStyle.Regular)
        Label3.Font = New Font(FontCollection.Families(0), 10, FontStyle.Regular)
        Label4.Font = New Font(FontCollection.Families(0), 10, FontStyle.Regular)
        btnStart.Font = New Font(FontCollection.Families(0), 10, FontStyle.Regular)

        ' Check if this application is already Open
        ' If so Then, Close this to prevent Issues
        If Process.GetProcessesByName("Slots").Count > 1 Then
            Close()
        End If

        ' Check If any Settings that could are as a Negative Value
        ' If so Then, Revert that Setting to it's Default Value
        If My.Settings.Slots < 0 Then
            My.Settings.Slots = 3
        ElseIf My.Settings.RandomNumbers < 0 Then
            My.Settings.RandomNumbers = 3
        End If
        My.Settings.Lives = 20
        My.Settings.Save()

        ' Initial Loading of TrackBars & Labels
        trkBar_SlotNumber.Value = My.Settings.Slots
        lbl_trkBarSlotValue.Text = My.Settings.Slots.ToString()

        trkBar_Numbers.Value = My.Settings.RandomNumbers
        lbl_trkBarNumbersValue.Text = My.Settings.RandomNumbers.ToString()

        trkBar_Lives.Value = My.Settings.Lives
        lbl_trkBarLivesValue.Text = My.Settings.Lives.ToString()

        If My.Settings.LastWins = 1 Then
            lblLastWins.Text = My.Resources.MSGLastWins.Replace("0", My.Settings.LastWins.ToString()).Replace("Times", "Time")
        Else
            lblLastWins.Text = My.Resources.MSGLastWins.Replace("0", My.Settings.LastWins.ToString())
        End If
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As System.EventArgs) Handles btnStart.Click
        My.Settings.AskingForInstructions = True
        My.Settings.Save()

        If Not MSGBoxForm.ShowDialog() = DialogResult.Cancel Then
            Close()
        End If
    End Sub

    Private Sub Tmr_ValueChanged_Tick(sender As Object, e As EventArgs) Handles tmr_ValueChanged.Tick
        ' On Each Tick, Apply any changes for Settings on Front and Backend
        lbl_trkBarNumbersValue.Text = trkBar_Numbers.Value.ToString()
        lbl_trkBarSlotValue.Text = trkBar_SlotNumber.Value.ToString()
        lbl_trkBarLivesValue.Text = trkBar_Lives.Value.ToString()

        My.Settings.RandomNumbers = trkBar_Numbers.Value
        My.Settings.Slots = trkBar_SlotNumber.Value
        My.Settings.Lives = trkBar_Lives.Value
        My.Settings.Save()
    End Sub
End Class
