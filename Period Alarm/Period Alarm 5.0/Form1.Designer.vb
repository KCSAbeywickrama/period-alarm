<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UDbellDur = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelRB = New System.Windows.Forms.Panel()
        Me.wmp = New AxWMPLib.AxWindowsMediaPlayer()
        Me.nico1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tmrPrepWMP = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tnt = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.picBell = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picBellStop = New System.Windows.Forms.PictureBox()
        Me.picBellPlay = New System.Windows.Forms.PictureBox()
        Me.tmrPrepCMG = New System.Windows.Forms.Timer(Me.components)
        Me.tmrIB = New System.Windows.Forms.Timer(Me.components)
        CType(Me.UDbellDur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelRB.SuspendLayout()
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBell, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBellStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBellPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(58, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Period Alarm"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UDbellDur
        '
        Me.UDbellDur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UDbellDur.Location = New System.Drawing.Point(10, 26)
        Me.UDbellDur.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.UDbellDur.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UDbellDur.Name = "UDbellDur"
        Me.UDbellDur.Size = New System.Drawing.Size(37, 22)
        Me.UDbellDur.TabIndex = 2
        Me.UDbellDur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UDbellDur.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Duration"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "(Seconds)"
        '
        'panelRB
        '
        Me.panelRB.Controls.Add(Me.Label3)
        Me.panelRB.Controls.Add(Me.UDbellDur)
        Me.panelRB.Controls.Add(Me.Label2)
        Me.panelRB.Location = New System.Drawing.Point(167, 65)
        Me.panelRB.Name = "panelRB"
        Me.panelRB.Size = New System.Drawing.Size(90, 75)
        Me.panelRB.TabIndex = 5
        '
        'wmp
        '
        Me.wmp.Enabled = True
        Me.wmp.Location = New System.Drawing.Point(12, 181)
        Me.wmp.Name = "wmp"
        Me.wmp.OcxState = CType(resources.GetObject("wmp.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmp.Size = New System.Drawing.Size(225, 67)
        Me.wmp.TabIndex = 12
        Me.wmp.TabStop = False
        '
        'nico1
        '
        Me.nico1.Icon = CType(resources.GetObject("nico1.Icon"), System.Drawing.Icon)
        Me.nico1.Text = "Period Alarm"
        Me.nico1.Visible = True
        '
        'tmrMain
        '
        Me.tmrMain.Enabled = True
        '
        't1
        '
        Me.t1.Location = New System.Drawing.Point(243, 197)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(66, 20)
        Me.t1.TabIndex = 13
        Me.t1.TabStop = False
        Me.t1.Text = "4:20:00 PM"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(243, 222)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 26)
        Me.Button2.TabIndex = 14
        Me.Button2.TabStop = False
        Me.Button2.Text = "Now Time"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(281, 223)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 25)
        Me.Button3.TabIndex = 15
        Me.Button3.TabStop = False
        Me.Button3.Text = "Set p1"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tmrPrepWMP
        '
        Me.tmrPrepWMP.Interval = 1000
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(247, 256)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(61, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(162, 324)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(105, 81)
        Me.Panel1.TabIndex = 17
        '
        'tnt
        '
        Me.tnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnt.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.tnt.Location = New System.Drawing.Point(18, 69)
        Me.tnt.Name = "tnt"
        Me.tnt.Size = New System.Drawing.Size(55, 26)
        Me.tnt.TabIndex = 18
        Me.tnt.Text = "10:40"
        Me.tnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.tnt, "Current Time")
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Period_Alarm_5._0.My.Resources.Resources.bel
        Me.PictureBox5.Location = New System.Drawing.Point(10, 13)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 19
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "About")
        '
        'picBell
        '
        Me.picBell.Image = Global.Period_Alarm_5._0.My.Resources.Resources.stock_photo_alarm_red_circle_web_glossy_iconfhgfh_135731207
        Me.picBell.Location = New System.Drawing.Point(91, 65)
        Me.picBell.Name = "picBell"
        Me.picBell.Size = New System.Drawing.Size(70, 74)
        Me.picBell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBell.TabIndex = 5
        Me.picBell.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picBell, "Ring the bell")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Period_Alarm_5._0.My.Resources.Resources.gear_47203_960_720
        Me.PictureBox4.Location = New System.Drawing.Point(279, 110)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 33)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Settings")
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Period_Alarm_5._0.My.Resources.Resources.ico_info_48
        Me.PictureBox3.Location = New System.Drawing.Point(279, 72)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 34)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "About")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(281, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Close")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(4, 114)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Hide")
        '
        'picBellStop
        '
        Me.picBellStop.Image = Global.Period_Alarm_5._0.My.Resources.Resources.stock_photo_alarm_red_circle_web_glossy_iconfhgfh_1357312071
        Me.picBellStop.Location = New System.Drawing.Point(69, 301)
        Me.picBellStop.Name = "picBellStop"
        Me.picBellStop.Size = New System.Drawing.Size(47, 46)
        Me.picBellStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBellStop.TabIndex = 16
        Me.picBellStop.TabStop = False
        '
        'picBellPlay
        '
        Me.picBellPlay.Image = Global.Period_Alarm_5._0.My.Resources.Resources.stock_photo_alarm_red_circle_web_glossy_iconfhgfh_135731207
        Me.picBellPlay.Location = New System.Drawing.Point(16, 301)
        Me.picBellPlay.Name = "picBellPlay"
        Me.picBellPlay.Size = New System.Drawing.Size(47, 46)
        Me.picBellPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBellPlay.TabIndex = 6
        Me.picBellPlay.TabStop = False
        '
        'tmrPrepCMG
        '
        Me.tmrPrepCMG.Interval = 1000
        '
        'tmrIB
        '
        Me.tmrIB.Interval = 2500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(317, 156)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.tnt)
        Me.Controls.Add(Me.picBell)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picBellStop)
        Me.Controls.Add(Me.picBellPlay)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.wmp)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.panelRB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.UDbellDur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelRB.ResumeLayout(False)
        Me.panelRB.PerformLayout()
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBell, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBellStop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBellPlay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UDbellDur As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panelRB As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents wmp As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents nico1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents t1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents picBell As System.Windows.Forms.PictureBox
    Friend WithEvents tmrPrepWMP As System.Windows.Forms.Timer
    Friend WithEvents picBellPlay As System.Windows.Forms.PictureBox
    Friend WithEvents picBellStop As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tnt As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrPrepCMG As System.Windows.Forms.Timer
    Friend WithEvents tmrIB As System.Windows.Forms.Timer

End Class
