Public Class EnterPass
    Public dlg As String

    Private Sub EnterPass_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        tsPassword.Text = ""
    End Sub
    Private Sub EnterPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Settings.Protect Then
            dlg = "c"
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        dlg = "close"
        Me.Close()

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        If tsPassword.Text = My.Settings.SPassWord Then
            dlg = "c"
        Else
            dlg = "ic"
        End If
        Me.Close()

    End Sub

    Private Sub tsPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles tsPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tsPassword.Text = My.Settings.SPassWord Then
                dlg = "c"
            Else
                dlg = "ic"
            End If
            Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            dlg = "close"
            Me.Close()
        End If
    End Sub

    Private Sub tsPassword_TextChanged(sender As Object, e As EventArgs) Handles tsPassword.TextChanged

    End Sub

    Private Sub EnterPass_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawRectangle(Pens.DarkGreen, 0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1)
        e.Graphics.DrawRectangle(Pens.GreenYellow, 1, 1, e.ClipRectangle.Width - 3, e.ClipRectangle.Height - 3)
    End Sub
End Class