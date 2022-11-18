Public Class EditPort

    Private Sub lb_Click(sender As Object, e As EventArgs) Handles lb.Click
        If lb.Text = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub ListBox1_LostFocus(sender As Object, e As EventArgs) Handles lb.LostFocus
        If lb.Text = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb.SelectedIndexChanged

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        lb.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            lb.Items.Add(sp)
        Next
        lb.SetSelected(0, True)

        If lb.Text = "" Then
            lb.Items.Add("No serial ports in your PC")
            lb.SetSelected(0, False)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error Resume Next
        lb.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            lb.Items.Add(sp)
        Next
        lb.SetSelected(0, True)

        If lb.Text = "" Then
            lb.Items.Add("No serial ports in your PC")
            lb.SetSelected(0, False)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not lb.Text = "No serial ports in your PC" Then
            My.Settings.port = lb.SelectedItem
            My.Settings.Save()
        End If

        Me.Close()
        Edit.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Edit.Show()
    End Sub
End Class