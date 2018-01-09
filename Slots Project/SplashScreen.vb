' Name:         Slots Project - FINAL
' Purpose:      The Classic Game of Slots!
' Programmer:   Chris Stack on 12/21/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class SplashScreen
    Dim FontCollection As New Text.PrivateFontCollection()
    Dim fontMemPointer As IntPtr
    Dim ApplicationTitle As String
    Dim ApplicationVersion As String
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Custom Font Files
        fontMemPointer = Runtime.InteropServices.Marshal.AllocCoTaskMem(My.Resources.Montserrat_Regular.Length)
        Runtime.InteropServices.Marshal.Copy(My.Resources.Montserrat_Regular, 0, fontMemPointer, My.Resources.Montserrat_Regular.Length)
        FontCollection.AddMemoryFont(fontMemPointer, My.Resources.Montserrat_Regular.Length)
        Runtime.InteropServices.Marshal.FreeCoTaskMem(fontMemPointer)

        lblAuthor.Font = New Font(FontCollection.Families(0), 18, FontStyle.Regular)
        lblTitle.Font = New Font(FontCollection.Families(0), 24, FontStyle.Regular)
        lblVersion.Font = New Font(FontCollection.Families(0), 16, FontStyle.Regular)

        ' Set the lblTitle
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        ApplicationVersion = My.Application.Info.Version.ToString.Replace(".0", "")

        lblTitle.Text = ApplicationTitle
        lblAuthor.Text = My.Application.Info.CompanyName
        lblVersion.Text = String.Format("v{0}", ApplicationVersion)
    End Sub
End Class