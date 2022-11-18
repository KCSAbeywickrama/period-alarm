Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.nt1.ShowBalloonTip(750)
        Form1.Timer3.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.WindowState = FormWindowState.Normal
        Form1.Opacity = 1

        Dim d As String = My.Computer.FileSystem.ReadAllText("d.txt")
        Using com1 As IO.Ports.SerialPort = My.Computer.Ports.OpenSerialPort(My.Settings.port)
            com1.Write(d)
        End Using

        Form1.WindowState = FormWindowState.Minimized
        Form1.Opacity = 0
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Edit.Show()
    End Sub

    Private Sub Form2_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Activate()
        Me.Left = My.Computer.Screen.WorkingArea.Width - Me.Width - 110
        Me.Top = My.Computer.Screen.WorkingArea.Height - Me.Height
    End Sub
End Class