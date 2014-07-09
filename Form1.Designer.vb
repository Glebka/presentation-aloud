<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAbout = New System.Windows.Forms.ToolStripButton()
        Me.SpeedBar = New System.Windows.Forms.TrackBar()
        Me.groupSpeakOptions = New System.Windows.Forms.GroupBox()
        Me.cmdTest = New System.Windows.Forms.Button()
        Me.txtTestVoice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbVoice = New System.Windows.Forms.ComboBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tlbManage = New System.Windows.Forms.ToolStrip()
        Me.btnStart = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnStop = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SpeedBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupSpeakOptions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tlbManage.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(311, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Обзор..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAbout})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(419, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAbout
        '
        Me.btnAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAbout.Image = Global.PresentationAloud.My.Resources.Resources.gtk_about
        Me.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(102, 22)
        Me.btnAbout.Text = "О программе"
        '
        'SpeedBar
        '
        Me.SpeedBar.Location = New System.Drawing.Point(6, 19)
        Me.SpeedBar.Minimum = -10
        Me.SpeedBar.Name = "SpeedBar"
        Me.SpeedBar.Size = New System.Drawing.Size(366, 45)
        Me.SpeedBar.TabIndex = 2
        '
        'groupSpeakOptions
        '
        Me.groupSpeakOptions.Controls.Add(Me.cmdTest)
        Me.groupSpeakOptions.Controls.Add(Me.txtTestVoice)
        Me.groupSpeakOptions.Controls.Add(Me.Label4)
        Me.groupSpeakOptions.Controls.Add(Me.GroupBox1)
        Me.groupSpeakOptions.Controls.Add(Me.cmbVoice)
        Me.groupSpeakOptions.Location = New System.Drawing.Point(12, 28)
        Me.groupSpeakOptions.Name = "groupSpeakOptions"
        Me.groupSpeakOptions.Size = New System.Drawing.Size(397, 207)
        Me.groupSpeakOptions.TabIndex = 3
        Me.groupSpeakOptions.TabStop = False
        Me.groupSpeakOptions.Text = "Настройки речи"
        '
        'cmdTest
        '
        Me.cmdTest.Location = New System.Drawing.Point(297, 179)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(88, 23)
        Me.cmdTest.TabIndex = 6
        Me.cmdTest.Text = "Проба голоса"
        Me.cmdTest.UseVisualStyleBackColor = True
        '
        'txtTestVoice
        '
        Me.txtTestVoice.Location = New System.Drawing.Point(7, 153)
        Me.txtTestVoice.Name = "txtTestVoice"
        Me.txtTestVoice.Size = New System.Drawing.Size(384, 20)
        Me.txtTestVoice.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(269, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Использовать следующий текст для пробы голоса:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SpeedBar)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 82)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Скорость голоса"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ниже"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Выше"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(169, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Средняя"
        '
        'cmbVoice
        '
        Me.cmbVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVoice.FormattingEnabled = True
        Me.cmbVoice.Location = New System.Drawing.Point(7, 20)
        Me.cmbVoice.Name = "cmbVoice"
        Me.cmbVoice.Size = New System.Drawing.Size(384, 21)
        Me.cmbVoice.TabIndex = 0
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(164, 19)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(227, 20)
        Me.txtPath.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tlbManage)
        Me.GroupBox2.Controls.Add(Me.txtPath)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 159)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Управление презентацией"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(164, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Выберите презентацию..."
        '
        'tlbManage
        '
        Me.tlbManage.Dock = System.Windows.Forms.DockStyle.None
        Me.tlbManage.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnStart, Me.ToolStripSeparator1, Me.btnStop})
        Me.tlbManage.Location = New System.Drawing.Point(164, 100)
        Me.tlbManage.Name = "tlbManage"
        Me.tlbManage.Size = New System.Drawing.Size(130, 25)
        Me.tlbManage.TabIndex = 6
        Me.tlbManage.Text = "ToolStrip2"
        '
        'btnStart
        '
        Me.btnStart.Enabled = False
        Me.btnStart.Image = Global.PresentationAloud.My.Resources.Resources.start
        Me.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(58, 22)
        Me.btnStart.Text = "Старт"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Image = Global.PresentationAloud.My.Resources.Resources._Stop
        Me.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(54, 22)
        Me.btnStop.Text = "Стоп"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 406)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.groupSpeakOptions)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(435, 379)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presentation Aloud"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.SpeedBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupSpeakOptions.ResumeLayout(False)
        Me.groupSpeakOptions.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tlbManage.ResumeLayout(False)
        Me.tlbManage.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents SpeedBar As System.Windows.Forms.TrackBar
    Friend WithEvents groupSpeakOptions As System.Windows.Forms.GroupBox
    Friend WithEvents cmbVoice As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTestVoice As System.Windows.Forms.TextBox
    Friend WithEvents cmdTest As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tlbManage As System.Windows.Forms.ToolStrip
    Friend WithEvents btnStart As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog

End Class
