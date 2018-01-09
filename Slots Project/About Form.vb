' Name:         Slots Project - FINAL
' Purpose:      The Classic Game of Slots!
' Programmer:   Chris Stack on 12/21/2017

Option Explicit On
Option Strict On
Option Infer Off

Public NotInheritable Class FrmAbout
    Dim FontCollection As New Text.PrivateFontCollection()
    Dim fontMemPointer As IntPtr
    Dim ApplicationTitle As String
    Dim ApplicationVersion As String
    Private Sub About_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Load Custom Font Files
        fontMemPointer = Runtime.InteropServices.Marshal.AllocCoTaskMem(My.Resources.Montserrat_Regular.Length)
        Runtime.InteropServices.Marshal.Copy(My.Resources.Montserrat_Regular, 0, fontMemPointer, My.Resources.Montserrat_Regular.Length)
        FontCollection.AddMemoryFont(fontMemPointer, My.Resources.Montserrat_Regular.Length)
        Runtime.InteropServices.Marshal.FreeCoTaskMem(fontMemPointer)

        LabelCompanyName.Font = New Font(FontCollection.Families(0), 10, FontStyle.Regular)
        LabelCopyright.Font = New Font(FontCollection.Families(0), 10, FontStyle.Regular)
        LabelProductName.Font = New Font(FontCollection.Families(0), 10, FontStyle.Regular)
        LabelVersion.Font = New Font(FontCollection.Families(0), 10, FontStyle.Regular)
        LabelDescription.Font = New Font(FontCollection.Families(0), 10, FontStyle.Regular)
        OKButton.Font = New Font(FontCollection.Families(0), 10, FontStyle.Regular)

        ' Set the title of the form.
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        ApplicationVersion = My.Application.Info.Version.ToString.Replace(".0", "")
        Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        LabelProductName.Text = My.Application.Info.ProductName
        LabelVersion.Text = String.Format("v{0}", ApplicationVersion)
        LabelCopyright.Text = My.Application.Info.Copyright
        LabelCompanyName.Text = My.Application.Info.CompanyName
        LabelDescription.Text = My.Application.Info.Description
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Close()
    End Sub
End Class
