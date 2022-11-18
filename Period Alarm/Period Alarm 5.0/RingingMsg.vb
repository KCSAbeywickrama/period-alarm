Public Class RingingMsg
    Private dragging As Boolean
    Private beginX, beginY As Integer
    Private Sub RingingMsg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = My.Settings.RngMsgLocation
        Me.TopMost = My.Settings.RngMsgTM
    End Sub

    Private Sub RingingMsg_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        dragging = True
        beginX = e.X
        beginY = e.Y
    End Sub

    Private Sub RingingMsg_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If dragging = True Then
            Me.Location = New Point(Me.Location.X + e.X - beginX, Me.Location.Y + e.Y - beginY)
            Me.Refresh()
        End If
    End Sub

    Private Sub RingingMsg_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        dragging = False
    End Sub

    Private Sub RingingMsg_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawRectangle(Pens.DarkGreen, 0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1)
        e.Graphics.DrawRectangle(Pens.GreenYellow, 1, 1, e.ClipRectangle.Width - 3, e.ClipRectangle.Height - 3)
    End Sub

    Private Sub l1_Click(sender As Object, e As EventArgs) Handles l1.Click

    End Sub

    Private Sub l1_DoubleClick(sender As Object, e As EventArgs) Handles l1.DoubleClick
        Me.Close()
    End Sub
End Class