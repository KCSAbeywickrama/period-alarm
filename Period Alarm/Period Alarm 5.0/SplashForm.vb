Public Class SplashForm
    Dim count As Integer = 0
    Dim a As Integer = 0
    Public sc As Boolean = False
    Private Sub SplashForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
    End Sub

    Private Sub SplashForm_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        'e.Graphics.DrawRectangle(Pens.White, 0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1)
        '  e.Graphics.DrawRectangle(Pens.GreenYellow, 1, 1, e.ClipRectangle.Width - 3, e.ClipRectangle.Height - 3)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
       
        If count > 4 And sc Then
            Form1.Opacity = 1
            Form1.Show()
            Timer1.Enabled = False
            Me.Close()


        Else
            count += 1
        End If


        If a = 0 Then
            Me.Opacity = 1

        ElseIf a = 1 Then
            l2.Text = "."
        ElseIf a = 2 Then
            l2.Text = ". ."
        ElseIf a = 3 Then
            l2.Text = ". . ."
        ElseIf a = 4 Then
            l2.Text = ". . . ."
        ElseIf a = 5 Then
            l2.Text = "  . . ."
        ElseIf a = 6 Then
            l2.Text = "    . ."
        ElseIf a = 7 Then
            l2.Text = "      ."
            a = 0
        End If
        a += 1



       
    End Sub

    Private Sub l2_Click(sender As Object, e As EventArgs) Handles l2.Click

    End Sub
End Class