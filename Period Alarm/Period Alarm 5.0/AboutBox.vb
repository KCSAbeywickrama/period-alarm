Public Class AboutBox
    Private dragging As Boolean
    Private beginX, beginY As Integer
    Private Sub AboutBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub AboutBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub AboutBox_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        dragging = True
        beginX = e.X
        beginY = e.Y
    End Sub

    Private Sub AboutBox_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If dragging = True Then
            Me.Location = New Point(Me.Location.X + e.X - beginX, Me.Location.Y + e.Y - beginY)
            Me.Refresh()
        End If
    End Sub

    Private Sub AboutBox_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        dragging = False
    End Sub

    Private Sub AboutBox_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawRectangle(Pens.DarkGreen, 0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1)
        e.Graphics.DrawRectangle(Pens.GreenYellow, 1, 1, e.ClipRectangle.Width - 3, e.ClipRectangle.Height - 3)
    End Sub


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub
End Class