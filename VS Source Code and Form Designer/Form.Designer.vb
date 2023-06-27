<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.DwlBtn = New System.Windows.Forms.Button()
        Me.URLBox = New System.Windows.Forms.TextBox()
        Me.StartTimeBox = New System.Windows.Forms.TextBox()
        Me.EndTimeBox = New System.Windows.Forms.TextBox()
        Me.OutputBox = New System.Windows.Forms.TextBox()
        Me.YTLogo = New System.Windows.Forms.PictureBox()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.YtLinkLbl = New System.Windows.Forms.Label()
        Me.StartLbl = New System.Windows.Forms.Label()
        Me.EndLbl = New System.Windows.Forms.Label()
        Me.FilenameLbl = New System.Windows.Forms.Label()
        Me.Format2lbl = New System.Windows.Forms.Label()
        Me.Format1lbl = New System.Windows.Forms.Label()
        Me.FileDescLbl = New System.Windows.Forms.Label()
        Me.WarningLbl = New System.Windows.Forms.Label()
        Me.audioChk = New System.Windows.Forms.CheckBox()
        CType(Me.YTLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DwlBtn
        '
        Me.DwlBtn.Enabled = False
        Me.DwlBtn.Font = New System.Drawing.Font("Open Sans ExtraBold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DwlBtn.Location = New System.Drawing.Point(12, 217)
        Me.DwlBtn.Name = "DwlBtn"
        Me.DwlBtn.Size = New System.Drawing.Size(403, 69)
        Me.DwlBtn.TabIndex = 5
        Me.DwlBtn.Text = "DOWNLOAD"
        Me.DwlBtn.UseVisualStyleBackColor = True
        '
        'URLBox
        '
        Me.URLBox.AllowDrop = True
        Me.URLBox.Location = New System.Drawing.Point(12, 64)
        Me.URLBox.Name = "URLBox"
        Me.URLBox.Size = New System.Drawing.Size(403, 20)
        Me.URLBox.TabIndex = 1
        '
        'StartTimeBox
        '
        Me.StartTimeBox.Location = New System.Drawing.Point(12, 128)
        Me.StartTimeBox.Name = "StartTimeBox"
        Me.StartTimeBox.Size = New System.Drawing.Size(100, 20)
        Me.StartTimeBox.TabIndex = 2
        Me.StartTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EndTimeBox
        '
        Me.EndTimeBox.Location = New System.Drawing.Point(160, 128)
        Me.EndTimeBox.Name = "EndTimeBox"
        Me.EndTimeBox.Size = New System.Drawing.Size(100, 20)
        Me.EndTimeBox.TabIndex = 3
        Me.EndTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OutputBox
        '
        Me.OutputBox.Location = New System.Drawing.Point(314, 128)
        Me.OutputBox.Name = "OutputBox"
        Me.OutputBox.Size = New System.Drawing.Size(101, 20)
        Me.OutputBox.TabIndex = 4
        Me.OutputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'YTLogo
        '
        Me.YTLogo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.YTLogo.Image = Global.YT_portion_download.My.Resources.Resources.yt_logo
        Me.YTLogo.Location = New System.Drawing.Point(6, 4)
        Me.YTLogo.Name = "YTLogo"
        Me.YTLogo.Size = New System.Drawing.Size(65, 35)
        Me.YTLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.YTLogo.TabIndex = 2
        Me.YTLogo.TabStop = False
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TitleLbl.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.TitleLbl.Font = New System.Drawing.Font("Open Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.ForeColor = System.Drawing.Color.Crimson
        Me.TitleLbl.Location = New System.Drawing.Point(76, 3)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(361, 33)
        Me.TitleLbl.TabIndex = 3
        Me.TitleLbl.Text = "Youtube Section Downloader"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Enabled = False
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(425, 41)
        Me.Splitter1.TabIndex = 4
        Me.Splitter1.TabStop = False
        '
        'YtLinkLbl
        '
        Me.YtLinkLbl.AutoSize = True
        Me.YtLinkLbl.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YtLinkLbl.Location = New System.Drawing.Point(164, 44)
        Me.YtLinkLbl.Name = "YtLinkLbl"
        Me.YtLinkLbl.Size = New System.Drawing.Size(104, 18)
        Me.YtLinkLbl.TabIndex = 5
        Me.YtLinkLbl.Text = "YOUTUBE LINK"
        '
        'StartLbl
        '
        Me.StartLbl.AutoSize = True
        Me.StartLbl.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartLbl.Location = New System.Drawing.Point(35, 87)
        Me.StartLbl.Name = "StartLbl"
        Me.StartLbl.Size = New System.Drawing.Size(49, 18)
        Me.StartLbl.TabIndex = 5
        Me.StartLbl.Text = "START"
        '
        'EndLbl
        '
        Me.EndLbl.AutoSize = True
        Me.EndLbl.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndLbl.Location = New System.Drawing.Point(191, 87)
        Me.EndLbl.Name = "EndLbl"
        Me.EndLbl.Size = New System.Drawing.Size(36, 18)
        Me.EndLbl.TabIndex = 5
        Me.EndLbl.Text = "END"
        '
        'FilenameLbl
        '
        Me.FilenameLbl.AutoSize = True
        Me.FilenameLbl.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilenameLbl.Location = New System.Drawing.Point(328, 87)
        Me.FilenameLbl.Name = "FilenameLbl"
        Me.FilenameLbl.Size = New System.Drawing.Size(75, 18)
        Me.FilenameLbl.TabIndex = 5
        Me.FilenameLbl.Text = "FILE NAME"
        '
        'Format2lbl
        '
        Me.Format2lbl.AutoSize = True
        Me.Format2lbl.Font = New System.Drawing.Font("Open Sans SemiBold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Format2lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Format2lbl.Location = New System.Drawing.Point(157, 106)
        Me.Format2lbl.Name = "Format2lbl"
        Me.Format2lbl.Size = New System.Drawing.Size(104, 15)
        Me.Format2lbl.TabIndex = 5
        Me.Format2lbl.Text = "HH:MM:SS | MM:SS"
        '
        'Format1lbl
        '
        Me.Format1lbl.AutoSize = True
        Me.Format1lbl.Font = New System.Drawing.Font("Open Sans SemiBold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Format1lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Format1lbl.Location = New System.Drawing.Point(12, 106)
        Me.Format1lbl.Name = "Format1lbl"
        Me.Format1lbl.Size = New System.Drawing.Size(104, 15)
        Me.Format1lbl.TabIndex = 5
        Me.Format1lbl.Text = "HH:MM:SS | MM:SS"
        '
        'FileDescLbl
        '
        Me.FileDescLbl.AutoSize = True
        Me.FileDescLbl.Font = New System.Drawing.Font("Open Sans SemiBold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileDescLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FileDescLbl.Location = New System.Drawing.Point(311, 106)
        Me.FileDescLbl.Name = "FileDescLbl"
        Me.FileDescLbl.Size = New System.Drawing.Size(110, 15)
        Me.FileDescLbl.TabIndex = 5
        Me.FileDescLbl.Text = "Name the output file"
        '
        'WarningLbl
        '
        Me.WarningLbl.AutoSize = True
        Me.WarningLbl.Font = New System.Drawing.Font("Open Sans SemiBold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.WarningLbl.Location = New System.Drawing.Point(19, 157)
        Me.WarningLbl.Name = "WarningLbl"
        Me.WarningLbl.Size = New System.Drawing.Size(384, 15)
        Me.WarningLbl.TabIndex = 6
        Me.WarningLbl.Text = "It's suggested to add 10 seconds of leeway in the timestamps to avoid issues"
        '
        'audioChk
        '
        Me.audioChk.AutoSize = True
        Me.audioChk.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.audioChk.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.audioChk.Location = New System.Drawing.Point(160, 175)
        Me.audioChk.Name = "audioChk"
        Me.audioChk.Size = New System.Drawing.Size(100, 36)
        Me.audioChk.TabIndex = 7
        Me.audioChk.Text = "AUDIO ONLY?"
        Me.audioChk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.audioChk.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 298)
        Me.Controls.Add(Me.audioChk)
        Me.Controls.Add(Me.WarningLbl)
        Me.Controls.Add(Me.FilenameLbl)
        Me.Controls.Add(Me.EndLbl)
        Me.Controls.Add(Me.FileDescLbl)
        Me.Controls.Add(Me.Format1lbl)
        Me.Controls.Add(Me.Format2lbl)
        Me.Controls.Add(Me.StartLbl)
        Me.Controls.Add(Me.YtLinkLbl)
        Me.Controls.Add(Me.TitleLbl)
        Me.Controls.Add(Me.YTLogo)
        Me.Controls.Add(Me.OutputBox)
        Me.Controls.Add(Me.EndTimeBox)
        Me.Controls.Add(Me.StartTimeBox)
        Me.Controls.Add(Me.URLBox)
        Me.Controls.Add(Me.DwlBtn)
        Me.Controls.Add(Me.Splitter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Youtube Section Downloader"
        CType(Me.YTLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DwlBtn As Button
    Friend WithEvents URLBox As TextBox
    Friend WithEvents StartTimeBox As TextBox
    Friend WithEvents EndTimeBox As TextBox
    Friend WithEvents OutputBox As TextBox
    Friend WithEvents YTLogo As PictureBox
    Friend WithEvents TitleLbl As Label
    Private WithEvents Splitter1 As Splitter
    Friend WithEvents YtLinkLbl As Label
    Friend WithEvents StartLbl As Label
    Friend WithEvents EndLbl As Label
    Friend WithEvents FilenameLbl As Label
    Friend WithEvents Format2lbl As Label
    Friend WithEvents Format1lbl As Label
    Friend WithEvents FileDescLbl As Label
    Friend WithEvents WarningLbl As Label
    Friend WithEvents audioChk As CheckBox
End Class
