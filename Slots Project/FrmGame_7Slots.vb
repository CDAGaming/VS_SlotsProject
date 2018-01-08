' Name:         Slots Project - FINAL - 7 Slot Game
' Purpose:      The Classic Game of Slots!
' Programmer:   Chris Stack on 12/21/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class FrmGame_7Slots
    Dim randGen As New Random
    Dim intNum1 As Integer
    Dim intNum2 As Integer
    Dim intNum3 As Integer
    Dim intNum4 As Integer
    Dim intNum5 As Integer
    Dim intNum6 As Integer
    Dim intNum7 As Integer
    Dim OriginalLifeCount As Integer
    Dim FontCollection As New Text.PrivateFontCollection()
    Dim fontMemPointer As IntPtr
    Dim AboutForm As FrmAbout = New FrmAbout()
    Dim MSGBoxForm As frmMSGBOX = New frmMSGBOX()
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        IsQuitting()
    End Sub

    Public Sub IsQuitting()
        My.Settings.WantsToQuit = True
        If MSGBoxForm.ShowDialog() = DialogResult.Yes Then
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
        If intNum1 = intNum2 AndAlso intNum1 = intNum3 AndAlso intNum1 = intNum4 AndAlso intNum1 = intNum5 AndAlso intNum1 = intNum6 AndAlso intNum1 = intNum7 Then
            lblNum1.ForeColor = Color.Green
            lblNum2.ForeColor = Color.Green
            lblNum3.ForeColor = Color.Green
            lblNum4.ForeColor = Color.Green
            lblNum5.ForeColor = Color.Green
            lblNum6.ForeColor = Color.Green
            lblNum7.ForeColor = Color.Green
            tmrWinCheck.Stop()
            btnRoll.Enabled = False
            My.Settings.Wins += 1
            lblWins.Text = "Wins" & ControlChars.NewLine & My.Settings.Wins.ToString()

            If My.Settings.Lives > 0 Then
                My.Settings.WantsToRestart = True
                If MSGBoxForm.ShowDialog() = DialogResult.Yes Then
                    RollNumbers()
                    tmrWinCheck.Start()
                    btnRoll.Enabled = True
                Else
                    My.Settings.LastWins = My.Settings.Wins
                    Threading.Thread.Sleep(1) 'Ensures Thread does the Lines above before continuing
                    My.Settings.Wins = 0
                    Close()
                End If
            End If
        Else
            lblNum1.ForeColor = Color.Maroon
            lblNum2.ForeColor = Color.Maroon
            lblNum3.ForeColor = Color.Maroon
            lblNum4.ForeColor = Color.Maroon
            lblNum5.ForeColor = Color.Maroon
            lblNum6.ForeColor = Color.Maroon
            lblNum7.ForeColor = Color.Maroon
        End If
        If My.Settings.Lives = 0 Then
            tmrWinCheck.Stop()
            btnRoll.Enabled = False
            My.Settings.OutOfLives = True
            If MSGBoxForm.ShowDialog() = DialogResult.Yes Then
                My.Settings.Lives = OriginalLifeCount
                RollNumbers()
                tmrWinCheck.Start()
                btnRoll.Enabled = True
            Else
                My.Settings.LastWins = My.Settings.Wins
                Threading.Thread.Sleep(1) 'Ensures Thread does the Lines above before continuing
                My.Settings.Wins = 0
                Close()
            End If
        End If
        My.Settings.Save()
    End Sub

    Private Sub FrmGame_7Slots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Custom Font Files
        fontMemPointer = Runtime.InteropServices.Marshal.AllocCoTaskMem(My.Resources.Montserrat_Regular.Length)
        Runtime.InteropServices.Marshal.Copy(My.Resources.Montserrat_Regular, 0, fontMemPointer, My.Resources.Montserrat_Regular.Length)
        FontCollection.AddMemoryFont(fontMemPointer, My.Resources.Montserrat_Regular.Length)
        Runtime.InteropServices.Marshal.FreeCoTaskMem(fontMemPointer)

        lblNum1.Font = New Font(FontCollection.Families(0), 36, FontStyle.Regular)
        lblNum2.Font = New Font(FontCollection.Families(0), 36, FontStyle.Regular)
        lblNum3.Font = New Font(FontCollection.Families(0), 36, FontStyle.Regular)
        lblNum4.Font = New Font(FontCollection.Families(0), 36, FontStyle.Regular)
        lblNum5.Font = New Font(FontCollection.Families(0), 36, FontStyle.Regular)
        lblNum6.Font = New Font(FontCollection.Families(0), 36, FontStyle.Regular)
        lblNum7.Font = New Font(FontCollection.Families(0), 36, FontStyle.Regular)
        lblWins.Font = New Font(FontCollection.Families(0), 18, FontStyle.Regular)
        lblLives.Font = New Font(FontCollection.Families(0), 18, FontStyle.Regular)
        btnRoll.Font = New Font(FontCollection.Families(0), 12, FontStyle.Regular)
        btnQuit.Font = New Font(FontCollection.Families(0), 12, FontStyle.Regular)
        ' Perform Initial Setup (Lives Storage + 1st Roll)
        My.Settings.Lives += 1
        OriginalLifeCount = My.Settings.Lives
        Threading.Thread.Sleep(1) 'Ensures Thread does the Line above before continuing
        RollNumbers()
    End Sub

    Public Sub RollNumbers()
        intNum1 = randGen.Next(1, My.Settings.RandomNumbers + 1)
        intNum2 = randGen.Next(1, My.Settings.RandomNumbers + 1)
        intNum3 = randGen.Next(1, My.Settings.RandomNumbers + 1)
        intNum4 = randGen.Next(1, My.Settings.RandomNumbers + 1)
        intNum5 = randGen.Next(1, My.Settings.RandomNumbers + 1)
        intNum6 = randGen.Next(1, My.Settings.RandomNumbers + 1)
        intNum7 = randGen.Next(1, My.Settings.RandomNumbers + 1)
        lblNum1.Text = intNum1.ToString()
        lblNum2.Text = intNum2.ToString()
        lblNum3.Text = intNum3.ToString()
        lblNum4.Text = intNum4.ToString()
        lblNum5.Text = intNum5.ToString()
        lblNum6.Text = intNum6.ToString()
        lblNum7.Text = intNum7.ToString()

        My.Settings.Lives -= 1
        My.Settings.Save()
        lblLives.Text = "Lives" & ControlChars.NewLine & My.Settings.Lives.ToString()
    End Sub

    Private Sub FrmGame_7Slots_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Save()
    End Sub
End Class