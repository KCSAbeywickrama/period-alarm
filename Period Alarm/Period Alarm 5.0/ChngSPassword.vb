Public Class ChngSPassword

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
    End Sub

  

    Private Sub ChngSPassword_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        tcsPassword.Text = ""
        tNew.Text = ""
    End Sub

   

   

    Private Sub ChngSPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tcsPassword.Select()
    End Sub

    Private Sub ChngSPassword_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawRectangle(Pens.OliveDrab, 0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1)
        e.Graphics.DrawRectangle(Pens.BlueViolet, 1, 1, e.ClipRectangle.Width - 3, e.ClipRectangle.Height - 3)
    End Sub

    Private Sub tcsPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles tcsPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            tNew.Select()
        ElseIf e.KeyCode = Keys.Escape Then

            Me.Close()
        End If
    End Sub

    Private Sub tNew_KeyDown(sender As Object, e As KeyEventArgs) Handles tNew.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tcsPassword.Text = My.Settings.SPassWord Then
                My.Settings.SPassWord = tNew.Text
                My.Settings.Save()
                Me.Close()
            Else

                CustomMsg.tMsg.Text = "Wrong current Password"
                CustomMsg.picMsg.Image = CustomMsg.piError.Image
                CustomMsg.btnClose.Visible = False
                CustomMsg.ShowDialog()
                CustomMsg.btnClose.Visible = True
                tcsPassword.Select()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

  
    
    Private Sub tNew_TextChanged(sender As Object, e As EventArgs) Handles tNew.TextChanged

    End Sub
End Class