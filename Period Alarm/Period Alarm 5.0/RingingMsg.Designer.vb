﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RingingMsg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RingingMsg))
        Me.l1 = New System.Windows.Forms.Label()
        Me.l2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'l1
        '
        Me.l1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.ForeColor = System.Drawing.Color.Blue
        Me.l1.Location = New System.Drawing.Point(23, 11)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(152, 24)
        Me.l1.TabIndex = 0
        Me.l1.Text = "Bell is ringing . . ."
        Me.l1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'l2
        '
        Me.l2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.l2.Location = New System.Drawing.Point(4, 43)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(181, 18)
        Me.l2.TabIndex = 1
        Me.l2.Text = "Period"
        Me.l2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RingingMsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(187, 78)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.l1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RingingMsg"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents l1 As System.Windows.Forms.Label
    Friend WithEvents l2 As System.Windows.Forms.Label
End Class
