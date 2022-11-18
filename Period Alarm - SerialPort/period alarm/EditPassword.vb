Public Class EditPassword

   

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Edit.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cpw.Text = My.Settings.spw Then

            If npw.Text = rpw.Text Then
                My.Settings.spw = npw.Text
                My.Settings.Save()

                Me.Close()
                Edit.Show()
            Else
                MessageBox.Show("Retype the password again.You have not retyped the password correctly", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                rpw.Clear()
                rpw.Select()
            End If

        Else
            MessageBox.Show("Wrong Current Password", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cpw.Clear()
            cpw.Select()
        End If

       
    End Sub
End Class