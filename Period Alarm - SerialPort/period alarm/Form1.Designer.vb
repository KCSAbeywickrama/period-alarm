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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.l1 = New System.Windows.Forms.Label()
        Me.nt1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.l2 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.lbtt = New System.Windows.Forms.Label()
        Me.dtp8 = New System.Windows.Forms.DateTimePicker()
        Me.dtp7 = New System.Windows.Forms.DateTimePicker()
        Me.dtp6 = New System.Windows.Forms.DateTimePicker()
        Me.dtp5 = New System.Windows.Forms.DateTimePicker()
        Me.dtpi = New System.Windows.Forms.DateTimePicker()
        Me.dtp4 = New System.Windows.Forms.DateTimePicker()
        Me.dtp3 = New System.Windows.Forms.DateTimePicker()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.l3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'l1
        '
        Me.l1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.Location = New System.Drawing.Point(12, 9)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(207, 61)
        Me.l1.TabIndex = 0
        Me.l1.Text = "Bell Is Ringing . . ."
        Me.l1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nt1
        '
        Me.nt1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.nt1.BalloonTipText = "If you want to run it again" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click here"
        Me.nt1.BalloonTipTitle = "Period Alarm Closed"
        Me.nt1.Icon = CType(resources.GetObject("nt1.Icon"), System.Drawing.Icon)
        Me.nt1.Text = "Period Alarm"
        Me.nt1.Visible = True
        '
        'l2
        '
        Me.l2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.ForeColor = System.Drawing.Color.Blue
        Me.l2.Location = New System.Drawing.Point(12, 280)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(138, 32)
        Me.l2.TabIndex = 3
        Me.l2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer3
        '
        Me.Timer3.Interval = 10000
        '
        'lbtt
        '
        Me.lbtt.AutoSize = True
        Me.lbtt.Location = New System.Drawing.Point(14, 235)
        Me.lbtt.Name = "lbtt"
        Me.lbtt.Size = New System.Drawing.Size(126, 26)
        Me.lbtt.TabIndex = 27
        Me.lbtt.Text = "If you want to run it again" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click here" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lbtt.Visible = False
        '
        'dtp8
        '
        Me.dtp8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp8.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp8.Location = New System.Drawing.Point(283, 377)
        Me.dtp8.Name = "dtp8"
        Me.dtp8.ShowUpDown = True
        Me.dtp8.Size = New System.Drawing.Size(96, 22)
        Me.dtp8.TabIndex = 49
        '
        'dtp7
        '
        Me.dtp7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp7.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp7.Location = New System.Drawing.Point(283, 348)
        Me.dtp7.Name = "dtp7"
        Me.dtp7.ShowUpDown = True
        Me.dtp7.Size = New System.Drawing.Size(96, 22)
        Me.dtp7.TabIndex = 48
        '
        'dtp6
        '
        Me.dtp6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp6.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp6.Location = New System.Drawing.Point(283, 319)
        Me.dtp6.Name = "dtp6"
        Me.dtp6.ShowUpDown = True
        Me.dtp6.Size = New System.Drawing.Size(96, 22)
        Me.dtp6.TabIndex = 47
        '
        'dtp5
        '
        Me.dtp5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp5.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp5.Location = New System.Drawing.Point(283, 290)
        Me.dtp5.Name = "dtp5"
        Me.dtp5.ShowUpDown = True
        Me.dtp5.Size = New System.Drawing.Size(96, 22)
        Me.dtp5.TabIndex = 46
        '
        'dtpi
        '
        Me.dtpi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpi.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpi.Location = New System.Drawing.Point(181, 411)
        Me.dtpi.Name = "dtpi"
        Me.dtpi.ShowUpDown = True
        Me.dtpi.Size = New System.Drawing.Size(96, 22)
        Me.dtpi.TabIndex = 45
        '
        'dtp4
        '
        Me.dtp4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp4.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp4.Location = New System.Drawing.Point(181, 382)
        Me.dtp4.Name = "dtp4"
        Me.dtp4.ShowUpDown = True
        Me.dtp4.Size = New System.Drawing.Size(96, 22)
        Me.dtp4.TabIndex = 44
        '
        'dtp3
        '
        Me.dtp3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp3.Location = New System.Drawing.Point(181, 353)
        Me.dtp3.Name = "dtp3"
        Me.dtp3.ShowUpDown = True
        Me.dtp3.Size = New System.Drawing.Size(96, 22)
        Me.dtp3.TabIndex = 43
        '
        'dtp2
        '
        Me.dtp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp2.Location = New System.Drawing.Point(181, 319)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.ShowUpDown = True
        Me.dtp2.Size = New System.Drawing.Size(96, 22)
        Me.dtp2.TabIndex = 42
        '
        'dtp1
        '
        Me.dtp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp1.Location = New System.Drawing.Point(181, 290)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.ShowUpDown = True
        Me.dtp1.Size = New System.Drawing.Size(96, 22)
        Me.dtp1.TabIndex = 41
        '
        'l3
        '
        Me.l3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l3.ForeColor = System.Drawing.Color.Blue
        Me.l3.Location = New System.Drawing.Point(5, 70)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(206, 32)
        Me.l3.TabIndex = 50
        Me.l3.Text = "10:45 AM"
        Me.l3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(223, 118)
        Me.Controls.Add(Me.l3)
        Me.Controls.Add(Me.dtp8)
        Me.Controls.Add(Me.dtp7)
        Me.Controls.Add(Me.dtp6)
        Me.Controls.Add(Me.dtp5)
        Me.Controls.Add(Me.dtpi)
        Me.Controls.Add(Me.dtp4)
        Me.Controls.Add(Me.dtp3)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.lbtt)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.l1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Opacity = 0.0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Period Alarm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents l1 As System.Windows.Forms.Label
    Friend WithEvents nt1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents l2 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents lbtt As System.Windows.Forms.Label
    Friend WithEvents dtp8 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp7 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp6 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp5 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpi As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents l3 As System.Windows.Forms.Label

End Class
