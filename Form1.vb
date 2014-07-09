Imports System.Speech.Synthesis
Imports System.Runtime.InteropServices
Imports System.IO

Public Class frmMain
    Private WithEvents slideshowWnd As Microsoft.Office.Interop.PowerPoint.Application
    Dim oApp As New Microsoft.Office.Interop.PowerPoint.Application
    Dim index As Integer
    Dim obj As SpeechSynthesizer = New SpeechSynthesizer()
    Dim WithEvents speaker As SpeechSynthesizer = New SpeechSynthesizer()
    Dim isTest As Boolean = False
    Shared MAX_PATH As Integer = 1024
    Delegate Sub DelegatePresentationStopped()
    Public myDelegatePresentationStopped As New DelegatePresentationStopped(AddressOf Stopped)

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OFD.Title = "Выберите файл презентации..."
        OFD.Filter = "Презентация MS PowerPoint (*.pptx)|*.pptx"
        OFD.RestoreDirectory = True
        If OFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            slideshowWnd = oApp
            oApp.Presentations.Open(OFD.FileName)
            oApp.Visible = Microsoft.Office.Core.MsoTriState.msoTrue
            Me.BringToFront()
            btnStart.Enabled = True
            Label5.Text = oApp.ActivePresentation.Name
            txtPath.Text = OFD.FileName
            PictureBox1.Image = GetThumbnailImage(OFD.FileName, 500, 256)
        End If
        'Dim SAPI
        'slideshowWnd = oApp
        'oApp.Presentations.Open(Application.StartupPath + "\1.pptx")
        'oApp.Visible = Microsoft.Office.Core.MsoTriState.msoTrue
        'oApp.ActivePresentation.SlideShowSettings.Run()
        'oApp.ActivePresentation.nam()
        'SAPI = CreateObject("SAPI.spvoice")
        'SAPI.Speak("This is a test string from Visual Basic .NET")
    End Sub

    Private Sub slideshowWnd_SlideShowBegin(ByVal Wn As Microsoft.Office.Interop.PowerPoint.SlideShowWindow) Handles slideshowWnd.SlideShowBegin
        'index = 1
        'Dim obj As SpeechSynthesizer = New SpeechSynthesizer()
        'For Each shape As Microsoft.Office.Interop.PowerPoint.Shape In oApp.ActivePresentation.Slides.Item(1).Shapes
        ' obj.Speak(shape.AlternativeText)
        'Next
    End Sub

    Private Sub slideshowWnd_SlideShowEnd(ByVal Pres As Microsoft.Office.Interop.PowerPoint.Presentation) Handles slideshowWnd.SlideShowEnd
        'myDelegatePresentationStopped.Invoke()
        tlbManage.BeginInvoke(myDelegatePresentationStopped)
    End Sub
    Public Sub Stopped()
        btnStart.Enabled = True
        btnStop.Enabled = False
    End Sub

    Private Sub slideshowWnd_SlideShowNextClick(ByVal Wn As Microsoft.Office.Interop.PowerPoint.SlideShowWindow, ByVal nEffect As Microsoft.Office.Interop.PowerPoint.Effect) Handles slideshowWnd.SlideShowNextClick

        'Dim obj As SpeechSynthesizer = New SpeechSynthesizer()
        For Each shape As Microsoft.Office.Interop.PowerPoint.Shape In Wn.View.Slide.Shapes
            speaker.Speak(shape.AlternativeText)
        Next
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        speaker.SpeakAsyncCancelAll()
        speaker.Dispose()
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            cmbVoice.Items.Clear()
            Dim tmpvoice As InstalledVoice
            For Each voice As InstalledVoice In speaker.GetInstalledVoices
                cmbVoice.Items.Add(voice.VoiceInfo.Name + " - " + voice.VoiceInfo.Culture.DisplayName)
                tmpvoice = voice
            Next
            cmbVoice.SelectedIndex = 0
            speaker.SelectVoice(speaker.GetInstalledVoices.Item(cmbVoice.SelectedIndex).VoiceInfo.Name)
            speaker.Rate = SpeedBar.Value
            txtTestVoice.Text = "You have selected " + tmpvoice.VoiceInfo.Name + " as the computer's default voice."
            'PictureBox1.Image = GetThumbnailImage(Application.StartupPath + "\1.pptx", 500, 256)
        Catch ex As Exception
            MsgBox("Произошла ошибка во время загрузки программы." + vbNewLine + ex.Message, MsgBoxStyle.Critical, "Presentation Aloud")
        End Try
    End Sub

    Private Sub cmbVoice_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVoice.SelectedValueChanged
        Try
            Dim tmpvoice As InstalledVoice = speaker.GetInstalledVoices.Item(cmbVoice.SelectedIndex)
            speaker.SelectVoice(speaker.GetInstalledVoices.Item(cmbVoice.SelectedIndex).VoiceInfo.Name)
            txtTestVoice.Text = "You have selected " + tmpvoice.VoiceInfo.Name + " as the computer's default voice."
        Catch ex As Exception
            MsgBox("Произошла ошибка при выборе голоса." + vbNewLine + ex.Message, MsgBoxStyle.Critical, "Presentation Aloud")
        End Try
    End Sub

    Private Sub SpeedBar_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SpeedBar.ValueChanged
        speaker.Rate = SpeedBar.Value
    End Sub

    Private Sub cmdTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest.Click
        Try
            If cmdTest.Text = "Проба голоса" Then
                isTest = True
                cmdTest.Text = "Стоп"
                speaker.SpeakAsync(txtTestVoice.Text)
            Else
                speaker.SpeakAsyncCancelAll()
            End If
        Catch ex As Exception
            MsgBox("Произошла ошибка во время пробы голоса." + vbNewLine + ex.Message, MsgBoxStyle.Critical, "Presentation Aloud")
        End Try
    End Sub

    Private Sub speaker_SpeakCompleted(ByVal sender As Object, ByVal e As System.Speech.Synthesis.SpeakCompletedEventArgs) Handles speaker.SpeakCompleted
        If isTest Then
            cmdTest.Text = "Проба голоса"
            isTest = False
            cmdTest.Focus()
        Else
            
        End If
        
    End Sub

    Private Sub speaker_SpeakProgress(ByVal sender As Object, ByVal e As System.Speech.Synthesis.SpeakProgressEventArgs) Handles speaker.SpeakProgress
        'txtTestVoice.SelectionStart = 1
        'txtTestVoice.SelectionLength = e.CharacterCount
        Try
            txtTestVoice.Focus()
            txtTestVoice.Select(e.CharacterPosition, e.CharacterCount)
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Function GetThumbnailImage(ByVal fileName As String, _
  ByVal longestEdge As Integer, ByVal colorDepth As Integer) As Image

        'Dim desktopFolder As IShellFolder
        'Dim someFolder As IShellFolder
        'Dim extract As IExtractImage
        'Dim pidl As IntPtr
        'Dim filePidl As IntPtr

        ''Manually define the IIDs for IShellFolder and IExtractImage
        'Dim IID_IShellFolder = New Guid("000214E6-0000-0000-C000-000000000046")
        'Dim IID_IExtractImage = New Guid("BB2E617C-0920-11d1-9A0B-00C04FC2D6C1")

        ''Divide the file name into a path and file name
        'Dim folderName = Path.GetDirectoryName(fileName)
        'Dim shortFileName = Path.GetFileName(fileName)

        ''Get the desktop IShellFolder
        'ShellInterop.SHGetDesktopFolder(desktopFolder)

        ''Get the parent folder IShellFolder
        'desktopFolder.ParseDisplayName(IntPtr.Zero, IntPtr.Zero, folderName, 0, pidl, 0)
        'desktopFolder.BindToObject(pidl, IntPtr.Zero, IID_IShellFolder, someFolder)

        ''Get the file's IExtractImage
        'someFolder.ParseDisplayName(IntPtr.Zero, IntPtr.Zero, shortFileName, 0, filePidl, 0)
        'someFolder.GetUIObjectOf(IntPtr.Zero, 1, filePidl, IID_IExtractImage, 0, extract)

        ''Set the size
        'Dim size As SIZE
        'size.cx = 500
        'size.cy = 500

        'Dim flags = IEIFLAG.ORIGSIZE Or IEIFLAG.QUALITY
        'Dim bmp As IntPtr
        'Dim thePath = Marshal.AllocHGlobal(MAX_PATH)

        ''Interop will throw an exception if one of these calls fail.
        'Try
        '    extract.GetLocation(thePath, MAX_PATH, 0, size, colorDepth, flags)
        '    extract.Extract(bmp)
        'Catch ex As Exception
        'End Try


        ''Free the global memory we allocated for the path string
        'Marshal.FreeHGlobal(thePath)

        ''Free the pidls. The Runtime Callable Wrappers 
        ''should automatically release the COM objects
        'Marshal.FreeCoTaskMem(pidl)
        'Marshal.FreeCoTaskMem(filePidl)

        'If Not bmp.Equals(IntPtr.Zero) Then
        '    GetThumbnailImage = Image.FromHbitmap(bmp)
        'Else
        GetThumbnailImage = Nothing
        'End If
    End Function

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        btnStop.Enabled = True
        btnStart.Enabled = False
        Me.SendToBack()
        Try
            oApp.ActivePresentation.SlideShowSettings.Run()
        Catch ex As Exception
            slideshowWnd = oApp
            oApp.Presentations.Open(OFD.FileName)
            oApp.Visible = Microsoft.Office.Core.MsoTriState.msoTrue
            oApp.ActivePresentation.SlideShowSettings.Run()
            Me.BringToFront()
        End Try
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        speaker.SpeakAsyncCancelAll()
        btnStart.Enabled = True
        btnStop.Enabled = False
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        AboutBox1.ShowDialog()
    End Sub
End Class
