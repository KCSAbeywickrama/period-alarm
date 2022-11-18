<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDurations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditDurations))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.udr = New System.Windows.Forms.NumericUpDown()
        Me.tr = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.udd = New System.Windows.Forms.NumericUpDown()
        Me.td = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.udr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.udd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(125, 179)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 26)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 26)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.udr)
        Me.GroupBox1.Controls.Add(Me.tr)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(161, 59)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ringing Duration"
        '
        'udr
        '
        Me.udr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.udr.ForeColor = System.Drawing.Color.White
        Me.udr.Hexadecimal = True
        Me.udr.Location = New System.Drawing.Point(41, 26)
        Me.udr.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.udr.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.udr.Name = "udr"
        Me.udr.Size = New System.Drawing.Size(18, 20)
        Me.udr.TabIndex = 28
        Me.udr.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'tr
        '
        Me.tr.Location = New System.Drawing.Point(16, 24)
        Me.tr.Name = "tr"
        Me.tr.Size = New System.Drawing.Size(44, 24)
        Me.tr.TabIndex = 29
        Me.tr.Text = "5"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.udd)
        Me.GroupBox2.Controls.Add(Me.td)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(161, 59)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Between Delay"
        '
        'udd
        '
        Me.udd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.udd.ForeColor = System.Drawing.Color.White
        Me.udd.Hexadecimal = True
        Me.udd.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.udd.Location = New System.Drawing.Point(41, 26)
        Me.udd.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.udd.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.udd.Name = "udd"
        Me.udd.Size = New System.Drawing.Size(18, 20)
        Me.udd.TabIndex = 26
        Me.udd.Value = New Decimal(New Integer() {15, 0, 0, 65536})
        '
        'td
        '
        Me.td.Location = New System.Drawing.Point(16, 24)
        Me.td.Name = "td"
        Me.td.Size = New System.Drawing.Size(44, 24)
        Me.td.TabIndex = 27
        Me.td.Text = "1"
        '
        'EditDurations
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 214)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EditDurations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Durations"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.udr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.udd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents udd As System.Windows.Forms.NumericUpDown
    Friend WithEvents udr As System.Windows.Forms.NumericUpDown
    Friend WithEvents tr As System.Windows.Forms.TextBox
    Friend WithEvents td As System.Windows.Forms.TextBox
End Class
