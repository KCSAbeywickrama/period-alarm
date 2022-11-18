Public Class EditTimes
    Dim a As Integer
    Dim m As Integer

    Private Sub EditTimes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If a = 1 Then
            m = MessageBox.Show("Do you want to save changes?", "Period Alarm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If m = MsgBoxResult.Yes Then
                My.Settings.p1 = dtp1.Text
                My.Settings.p2 = dtp2.Text
                My.Settings.p3 = dtp3.Text
                My.Settings.p4 = dtp4.Text

                My.Settings.int = dtpi.Text

                My.Settings.p5 = dtp5.Text
                My.Settings.p6 = dtp6.Text
                My.Settings.p7 = dtp7.Text
                My.Settings.p8 = dtp8.Text

                Form1.dtp1.Text = My.Settings.p1
                Form1.dtp2.Text = My.Settings.p2
                Form1.dtp3.Text = My.Settings.p3
                Form1.dtp4.Text = My.Settings.p4

                Form1.dtpi.Text = My.Settings.int

                Form1.dtp5.Text = My.Settings.p5
                Form1.dtp6.Text = My.Settings.p6
                Form1.dtp7.Text = My.Settings.p7
                Form1.dtp8.Text = My.Settings.p8

                My.Settings.Save()

                ' Button2.Text = "OK"
            End If
        End If

        'If Button2.Text = "Cancel" Then
        'Edit.Show()
        'End If
    End Sub
    Private Sub EditTimes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp1.Text = My.Settings.p1
        dtp2.Text = My.Settings.p2
        dtp3.Text = My.Settings.p3
        dtp4.Text = My.Settings.p4

        dtpi.Text = My.Settings.int

        dtp5.Text = My.Settings.p5
        dtp6.Text = My.Settings.p6
        dtp7.Text = My.Settings.p7
        dtp8.Text = My.Settings.p8

        a = 0
        Me.Activate()
        Button1.Text = "OK"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Save" Then
            My.Settings.p1 = dtp1.Text
            My.Settings.p2 = dtp2.Text
            My.Settings.p3 = dtp3.Text
            My.Settings.p4 = dtp4.Text

            My.Settings.int = dtpi.Text

            My.Settings.p5 = dtp5.Text
            My.Settings.p6 = dtp6.Text
            My.Settings.p7 = dtp7.Text
            My.Settings.p8 = dtp8.Text

            a = 0

            Form1.dtp1.Text = My.Settings.p1
            Form1.dtp2.Text = My.Settings.p2
            Form1.dtp3.Text = My.Settings.p3
            Form1.dtp4.Text = My.Settings.p4

            Form1.dtpi.Text = My.Settings.int

            Form1.dtp5.Text = My.Settings.p5
            Form1.dtp6.Text = My.Settings.p6
            Form1.dtp7.Text = My.Settings.p7
            Form1.dtp8.Text = My.Settings.p8

            My.Settings.Save()
           
        Else
            Me.Close()
            Edit.Show()
        End If

        If Button1.Text = "Save" Then
            Button1.Text = "OK"
        Else
            Button1.Text = "Save"
        End If


    End Sub

   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Edit.Show()
    End Sub

    Private Sub dtp1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp1.ValueChanged
        a = 1
        Button1.Text = "Save"
    End Sub

    Private Sub dtp2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp2.ValueChanged
        a = 1
        Button1.Text = "Save"
    End Sub

    Private Sub dtp3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp3.ValueChanged
        a = 1
        Button1.Text = "Save"
    End Sub

    Private Sub dtp4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp4.ValueChanged
        a = 1
        Button1.Text = "Save"
    End Sub

    Private Sub dtpi_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpi.ValueChanged
        a = 1
        Button1.Text = "Save"
    End Sub

    Private Sub dtp5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp5.ValueChanged
        a = 1
        Button1.Text = "Save"
    End Sub

    Private Sub dtp6_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp6.ValueChanged
        a = 1
        Button1.Text = "Save"
    End Sub

    Private Sub dtp7_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp7.ValueChanged
        a = 1
        Button1.Text = "Save"
    End Sub

    Private Sub dtp8_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp8.ValueChanged
        a = 1
        Button1.Text = "Save"
    End Sub
End Class