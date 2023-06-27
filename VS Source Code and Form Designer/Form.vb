Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DwlBtn.Click
        ' Get the YouTube link, beginning and ending timestamps, and output title from the textboxes
        Dim link As String = URLBox.Text
        Dim beginTimestamp As String = StartTimeBox.Text
        Dim endTimestamp As String = EndTimeBox.Text
        Dim title As String = OutputBox.Text

        ' Build the yt-dlp command with the specified download section, link, and output file name (video/audio or audio only)
        Dim outputFileName As String = title & ".mp4"
        Dim ytDlpCmd As String = "yt-dlp.exe --download-sections ""*" & beginTimestamp & "-" & endTimestamp & """ --output """ & outputFileName & """ """ & link & """ --recode mp4"
        Dim outputFileNameMP3 As String = title & ".mp3"
        Dim ytDlpCmdMP3 As String = "yt-dlp.exe -x --audio-format mp3 --audio-quality 0 --download-sections ""*" & beginTimestamp & "-" & endTimestamp & """ --output """ & outputFileNameMP3 & """ """ & link & ""

        ' Check if Audio Only is selected, then run command accordingly
        If audioChk.Checked Then
            ' Run the yt-dlp command
            Dim proc As New Process()
            proc.StartInfo.FileName = "cmd.exe"
            proc.StartInfo.Arguments = "/c " & ytDlpCmdMP3
            proc.StartInfo.UseShellExecute = False
            proc.StartInfo.RedirectStandardOutput = True
            proc.Start()
            proc.WaitForExit()

            ' Play default Windows sound
            System.Media.SystemSounds.Asterisk.Play()

            ' Display a message to the user when done
            MessageBox.Show("Video saved as " & outputFileNameMP3)
        Else
            ' Run the yt-dlp command
            Dim proc As New Process()
            proc.StartInfo.FileName = "cmd.exe"
            proc.StartInfo.Arguments = "/c " & ytDlpCmd
            proc.StartInfo.UseShellExecute = False
            proc.StartInfo.RedirectStandardOutput = True
            proc.Start()
            proc.WaitForExit()

            ' Play default Windows sound
            System.Media.SystemSounds.Asterisk.Play()

            ' Display a message to the user when done
            MessageBox.Show("Video saved as " & outputFileName)
        End If
    End Sub

	' Enable/disable the download button according to input fields
    Private Sub UpdateButtonState()
        If String.IsNullOrWhiteSpace(URLBox.Text) OrElse
    String.IsNullOrWhiteSpace(StartTimeBox.Text) OrElse
    String.IsNullOrWhiteSpace(EndTimeBox.Text) OrElse
    String.IsNullOrWhiteSpace(OutputBox.Text) Then
            DwlBtn.Enabled = False
        Else
            DwlBtn.Enabled = True
        End If
    End Sub
    Private Sub URLBox_TextChanged(sender As Object, e As EventArgs) Handles URLBox.TextChanged
        UpdateButtonState()
    End Sub

    Private Sub StartTimeBox_TextChanged(sender As Object, e As EventArgs) Handles StartTimeBox.TextChanged
        UpdateButtonState()
    End Sub

    Private Sub EndTimeBox_TextChanged(sender As Object, e As EventArgs) Handles EndTimeBox.TextChanged
        UpdateButtonState()
    End Sub

    Private Sub OutputBox_TextChanged(sender As Object, e As EventArgs) Handles OutputBox.TextChanged
        UpdateButtonState()
    End Sub
End Class