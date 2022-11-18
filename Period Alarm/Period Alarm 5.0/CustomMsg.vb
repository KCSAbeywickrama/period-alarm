Public Class CustomMsg
    Public dlg As String

    Private Sub CustomMsg_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            dlg = "ok"
            Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            dlg = "close"
            Me.Close()
        End If
    End Sub
    Private Sub CustomMsg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        dlg = "ok"
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        dlg = "close"
        Me.Close()
    End Sub

    Private Sub CustomMsg_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawRectangle(Pens.DarkGreen, 0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1)
        e.Graphics.DrawRectangle(Pens.GreenYellow, 1, 1, e.ClipRectangle.Width - 3, e.ClipRectangle.Height - 3)
    End Sub
End Class