Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class Form1

    Private Function bell()

        Me.WindowState = FormWindowState.Normal
        Me.Opacity = 1

        Dim d As String = My.Computer.FileSystem.ReadAllText("d.txt")
        Using com1 As IO.Ports.SerialPort = My.Computer.Ports.OpenSerialPort(My.Settings.port)
            com1.Write(d)
            System.Threading.Thread.Sleep(My.Settings.durb2)
            com1.Write(d)
        End Using

        Me.WindowState = FormWindowState.Minimized
        Me.Opacity = 0
    End Function

    Private Function bellOnce()

        Me.WindowState = FormWindowState.Normal
        Me.Opacity = 1

        Dim d As String = My.Computer.FileSystem.ReadAllText("d.txt")
        Using com1 As IO.Ports.SerialPort = My.Computer.Ports.OpenSerialPort(My.Settings.port)
            com1.Write(d)
        End Using

        If FormatDateTime(l3.Text, DateFormat.ShortTime) = FormatDateTime(dtp8.Text, DateFormat.ShortTime) Then
            Me.Close()
        End If
      

        Me.WindowState = FormWindowState.Minimized
        Me.Opacity = 0
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        l2.Text = TimeOfDay
        l3.Text = DateTime.Now.ToShortTimeString

    End Sub


    Private Sub nt1_BalloonTipClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles nt1.BalloonTipClicked
        Timer3.Enabled = False
        nt1.BalloonTipTitle = "Period Alarm"
        nt1.BalloonTipText = "Period Alarm is running again"
        nt1.ShowBalloonTip(100)

        nt1.BalloonTipTitle = "Period Alarm Closed"
        nt1.BalloonTipText = lbtt.Text
    End Sub


    Private Sub nt1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles nt1.MouseDown
        On Error Resume Next

        Dim pwdb As Integer
        pwdb = pw.ShowDialog

        If pwdb = vbOK Then
            If pw.tpw.Text = My.Settings.spw Then

                If e.Button = Windows.Forms.MouseButtons.Left Then
                    Form2.Show()
                ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
                    msg.Show()
                End If

            Else
                MessageBox.Show("Wrong Password", "Period Alarm Security", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                pw.tpw.Clear()
                Call nt1_MouseDown(sender, e)
            End If
        End If

        pw.tpw.Clear()

    End Sub
    Private Sub l2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles l2.TextChanged
        Select Case l2.Text
            Case dtp1.Text
                bell()
            Case dtp2.Text
               bell()
            Case dtp3.Text
               bell()
            Case dtp4.Text
               bell()
            Case dtpi.Text
                bellOnce()
            Case dtp5.Text
              bell()
            Case dtp6.Text
               bell()
            Case dtp7.Text
                bell()
            Case dtp8.Text
                bellOnce()
        End Select
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Me.Close()
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'datetime picker 
        dtp1.Text = My.Settings.p1
        dtp2.Text = My.Settings.p2
        dtp3.Text = My.Settings.p3
        dtp4.Text = My.Settings.p4

        dtpi.Text = My.Settings.int

        dtp5.Text = My.Settings.p5
        dtp6.Text = My.Settings.p6
        dtp7.Text = My.Settings.p7
        dtp8.Text = My.Settings.p8

    End Sub


    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Normal Then
            Me.Left = My.Computer.Screen.WorkingArea.Width - Me.Width - 10
            Me.Top = My.Computer.Screen.WorkingArea.Height - Me.Height - 10
        End If
    End Sub

End Class
