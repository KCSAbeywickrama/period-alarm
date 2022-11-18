Public Class ShutDownMsg
    Dim s As Boolean = True
    Private Sub ShutDownMsg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ShutDownMsg_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawRectangle(Pens.DarkGreen, 0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1)
        e.Graphics.DrawRectangle(Pens.GreenYellow, 1, 1, e.ClipRectangle.Width - 3, e.ClipRectangle.Height - 3)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tcd.Text = 0 Then
            Form1.ShtDownPC = True
            Me.Close()

        Else
            tcd.Text = tcd.Text - 1
        End If


    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Form1.ShtDownPC = s
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        tMsg.Text = "Shutdown process is Cancelled"
        tcd.Text = ""
        Timer1.Stop()
        picMsg.Image = Form1.PictureBox3.Image
        s = False
        PictureBox5.Visible = False
        'Me.Close()

    End Sub

    
End Class