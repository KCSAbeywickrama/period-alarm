<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShutDownMsg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShutDownMsg))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.picMsg = New System.Windows.Forms.PictureBox()
        Me.tMsg = New System.Windows.Forms.Label()
        Me.tcd = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMsg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox14)
        Me.Panel1.Location = New System.Drawing.Point(236, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(80, 45)
        Me.Panel1.TabIndex = 33
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(41, 8)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 28
        Me.PictureBox5.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = Global.Period_Alarm_5._0.My.Resources.Resources.jghjg
        Me.PictureBox14.Location = New System.Drawing.Point(5, 10)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox14.TabIndex = 29
        Me.PictureBox14.TabStop = False
        '
        'picMsg
        '
        Me.picMsg.Image = Global.Period_Alarm_5._0.My.Resources.Resources.ico_danger_48
        Me.picMsg.Location = New System.Drawing.Point(12, 16)
        Me.picMsg.Name = "picMsg"
        Me.picMsg.Size = New System.Drawing.Size(77, 75)
        Me.picMsg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picMsg.TabIndex = 30
        Me.picMsg.TabStop = False
        '
        'tMsg
        '
        Me.tMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tMsg.Location = New System.Drawing.Point(106, 24)
        Me.tMsg.Name = "tMsg"
        Me.tMsg.Size = New System.Drawing.Size(192, 45)
        Me.tMsg.TabIndex = 34
        Me.tMsg.Text = "Period Alarm is going to shut down your computer"
        Me.tMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tcd
        '
        Me.tcd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcd.Location = New System.Drawing.Point(157, 75)
        Me.tcd.Name = "tcd"
        Me.tcd.Size = New System.Drawing.Size(41, 22)
        Me.tcd.TabIndex = 35
        Me.tcd.Text = "20"
        Me.tcd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ShutDownMsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(328, 144)
        Me.Controls.Add(Me.tcd)
        Me.Controls.Add(Me.tMsg)
        Me.Controls.Add(Me.picMsg)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ShutDownMsg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMsg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents picMsg As System.Windows.Forms.PictureBox
    Friend WithEvents tMsg As System.Windows.Forms.Label
    Friend WithEvents tcd As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
