Public Class EditDurations

    Private Sub udr_ValueChanged(sender As Object, e As EventArgs) Handles udr.ValueChanged
        tr.Text = udr.Value
    End Sub

    Private Sub udd_ValueChanged(sender As Object, e As EventArgs) Handles udd.ValueChanged
        td.Text = udd.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.durb2 = td.Text * 1000
        My.Settings.ringdur = tr.Text * 1000
        My.Settings.Save()

        Dim da As String = ""
        For i = 1 To My.Settings.ringdur
            da = da & "A"
        Next
        My.Computer.FileSystem.WriteAllText("d.txt", da, False)

        Me.Close()
        Edit.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Edit.Show()
    End Sub

    Private Sub EditDurations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        udd.Value = My.Settings.durb2 / 1000
        udr.Value = My.Settings.ringdur / 1000
    End Sub

    Private Sub tr_TextChanged(sender As Object, e As EventArgs) Handles tr.TextChanged
        udr.Value = tr.Text
    End Sub

    Private Sub td_TextChanged(sender As Object, e As EventArgs) Handles td.TextChanged
        udd.Value = td.Text
    End Sub
End Class