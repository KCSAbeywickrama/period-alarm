<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomMsg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomMsg))
        Me.picMsg = New System.Windows.Forms.PictureBox()
        Me.tMsg = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnOk = New System.Windows.Forms.PictureBox()
        Me.picAstric = New System.Windows.Forms.PictureBox()
        Me.piError = New System.Windows.Forms.PictureBox()
        Me.PicInfo = New System.Windows.Forms.PictureBox()
        Me.picQue = New System.Windows.Forms.PictureBox()
        CType(Me.picMsg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAstric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMsg
        '
        Me.picMsg.Location = New System.Drawing.Point(6, 12)
        Me.picMsg.Name = "picMsg"
        Me.picMsg.Size = New System.Drawing.Size(77, 75)
        Me.picMsg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picMsg.TabIndex = 0
        Me.picMsg.TabStop = False
        '
        'tMsg
        '
        Me.tMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tMsg.Location = New System.Drawing.Point(90, 25)
        Me.tMsg.Name = "tMsg"
        Me.tMsg.Size = New System.Drawing.Size(192, 45)
        Me.tMsg.TabIndex = 1
        Me.tMsg.Text = "Doyou want to save changes ?"
        Me.tMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Location = New System.Drawing.Point(210, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(80, 47)
        Me.Panel1.TabIndex = 33
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(41, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(34, 34)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 28
        Me.btnClose.TabStop = False
        '
        'btnOk
        '
        Me.btnOk.Image = Global.Period_Alarm_5._0.My.Resources.Resources.jghjg
        Me.btnOk.Location = New System.Drawing.Point(5, 3)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(30, 30)
        Me.btnOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnOk.TabIndex = 29
        Me.btnOk.TabStop = False
        '
        'picAstric
        '
        Me.picAstric.Image = Global.Period_Alarm_5._0.My.Resources.Resources.ico_warning_48
        Me.picAstric.Location = New System.Drawing.Point(22, 153)
        Me.picAstric.Name = "picAstric"
        Me.picAstric.Size = New System.Drawing.Size(91, 88)
        Me.picAstric.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picAstric.TabIndex = 34
        Me.picAstric.TabStop = False
        '
        'piError
        '
        Me.piError.Image = Global.Period_Alarm_5._0.My.Resources.Resources.ico_danger_48
        Me.piError.Location = New System.Drawing.Point(223, 153)
        Me.piError.Name = "piError"
        Me.piError.Size = New System.Drawing.Size(90, 81)
        Me.piError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.piError.TabIndex = 35
        Me.piError.TabStop = False
        '
        'PicInfo
        '
        Me.PicInfo.Image = Global.Period_Alarm_5._0.My.Resources.Resources.ico_info_48
        Me.PicInfo.Location = New System.Drawing.Point(108, 153)
        Me.PicInfo.Name = "PicInfo"
        Me.PicInfo.Size = New System.Drawing.Size(72, 81)
        Me.PicInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicInfo.TabIndex = 36
        Me.PicInfo.TabStop = False
        '
        'picQue
        '
        Me.picQue.Image = Global.Period_Alarm_5._0.My.Resources.Resources._3282__2_
        Me.picQue.Location = New System.Drawing.Point(172, 153)
        Me.picQue.Name = "picQue"
        Me.picQue.Size = New System.Drawing.Size(78, 76)
        Me.picQue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picQue.TabIndex = 39
        Me.picQue.TabStop = False
        '
        'CustomMsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(302, 122)
        Me.Controls.Add(Me.picQue)
        Me.Controls.Add(Me.PicInfo)
        Me.Controls.Add(Me.piError)
        Me.Controls.Add(Me.picAstric)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tMsg)
        Me.Controls.Add(Me.picMsg)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CustomMsg"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        CType(Me.picMsg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAstric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picMsg As System.Windows.Forms.PictureBox
    Friend WithEvents tMsg As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents btnOk As System.Windows.Forms.PictureBox
    Friend WithEvents picAstric As System.Windows.Forms.PictureBox
    Friend WithEvents piError As System.Windows.Forms.PictureBox
    Friend WithEvents PicInfo As System.Windows.Forms.PictureBox
    Friend WithEvents picQue As System.Windows.Forms.PictureBox
End Class
