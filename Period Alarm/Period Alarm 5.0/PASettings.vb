Public Class PASettings

    Dim ml, rl As Point
    Dim mf As Object
    Dim op As Integer
    Dim d As Byte
    Dim movf As Boolean = True
    Dim IShwRng As Boolean = False

    Dim st As String = "play"


    Private dragging As Boolean
    Private beginX, beginY As Integer

    Dim chngSet As Boolean = False

    Private Sub PASettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If chngSet Then
            e.Cancel = True
            CustomMsg.tMsg.Text = "Do you want to save changes of Settings ?"
            CustomMsg.picMsg.Image = CustomMsg.picQue.Image
            CustomMsg.ShowDialog()

            If CustomMsg.dlg = "ok" Then
                SavePASettings()
            End If

            If IShwRng Then
                RingingMsg.Hide()
            End If

            chngSet = False
            Me.Close()

        End If
    End Sub

    Private Sub PASettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'wmp.URL = My.Settings.BellFile
        wmpS.settings.volume = My.Settings.sVolume

        DTP1.Value = My.Settings.sp1
        DTP2.Value = My.Settings.sp2
        DTP3.Value = My.Settings.sp3
        DTP4.Value = My.Settings.sp4
        DTPbr.Value = My.Settings.sbr
        DTP5.Value = My.Settings.sp5
        DTP6.Value = My.Settings.sp6
        DTP7.Value = My.Settings.sp7
        DTP8.Value = My.Settings.sp8

        DTPf1.Value = My.Settings.sf1
        DTPf2.Value = My.Settings.sf2
        'DTPf3.Value = My.Settings.sf3



        UDdelay.Value = My.Settings.sDelay
        UDprdDur.Value = My.Settings.sPrdDur
        UDbrBDur.Value = My.Settings.sBrBDur
        UDbrEDur.Value = My.Settings.sBrEDur
        UDf1Dur.Value = My.Settings.sF1Dur
        UDf2Dur.Value = My.Settings.sF2Dur
        Udf3Dur.Value = My.Settings.sF3Dur

        tbfp.Text = My.Settings.BellFile
        tcmgfp.Text = My.Settings.CMGFile

        VolumeBar.Value = My.Settings.sVolume

        tml.Text = "X=" & Form1.Location.X & " | " & "Y=" & Form1.Location.Y
        trl.Text = "X=" & RingingMsg.Location.X & " | " & "Y=" & RingingMsg.Location.Y
        ml = Form1.Location
        rl = RingingMsg.Location

        chShtDwn.Checked = My.Settings.ShtDwn
        chShwWrn.Checked = My.Settings.ShwWar
        chRngMsg.Checked = My.Settings.RngMsgTM
        chAskWD.Checked = My.Settings.AskRW
        chProtect.Checked = My.Settings.Protect

        ofd1.Filter = "Audio Files|*mp3;*mp2;*wma;*wav;*wv;*ogg;*ape;*fla;*aac;*mmf;*amr;*m4a;*m4r|All Files|*.*"

        chngSet = False


        ' /////////////////////////////////


        For Each cntrl As Control In Me.Controls
            AddHandler cntrl.KeyDown, AddressOf Control_KeyDown
           
        Next
    End Sub

    Private Sub Control_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            PictureBox14_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then
            PictureBox5_Click(sender, e)
        End If

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
        If IShwRng Then
            RingingMsg.Hide()
        End If
    End Sub




    Private Sub PictureBox8_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox8.MouseDown
        Form1.Show()
        mf = Form1


        op = -1
        d = 1
        tmr1.Start()



    End Sub
    Private Sub PictureBox9_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox9.MouseDown
        Form1.Show()
        mf = Form1


        op = 1
        d = 1
        tmr1.Start()


    End Sub

    Private Sub PictureBox6_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox6.MouseDown
        Form1.Show()
        mf = Form1
        op = -1
        d = 0
        tmr1.Start()
    End Sub

    Private Sub PictureBox7_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseDown
        Form1.Show()
        mf = Form1
        op = 1
        d = 0
        tmr1.Start()
    End Sub
    Private Sub PictureBox6_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox6.MouseUp
        tmr1.Stop()
    End Sub
    Private Sub PictureBox7_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseUp
        tmr1.Stop()
    End Sub
    Private Sub PictureBox8_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox8.MouseUp
        tmr1.Stop()
    End Sub

    Private Sub PictureBox9_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox9.MouseUp
        tmr1.Stop()
    End Sub


    Private Sub PictureBox10_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox10.MouseDown
        RingingMsg.Show()
        IShwRng = True
        mf = RingingMsg
        op = -1
        d = 0
        tmr1.Start()

    End Sub
    Private Sub PictureBox11_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox11.MouseDown
        RingingMsg.Show()
        IShwRng = True
        mf = RingingMsg
        op = 1
        d = 0
        tmr1.Start()
    End Sub
    Private Sub PictureBox12_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox12.MouseDown
        RingingMsg.Show()
        IShwRng = True
        mf = RingingMsg
        op = -1
        d = 1
        tmr1.Start()
    End Sub
    Private Sub PictureBox13_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox13.MouseDown
        RingingMsg.Show()
        IShwRng = True
        mf = RingingMsg
        op = 1
        d = 1
        tmr1.Start()
    End Sub
    Private Sub PictureBox10_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox10.MouseUp
        tmr1.Stop()
    End Sub
    Private Sub PictureBox11_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox11.MouseUp
        tmr1.Stop()
    End Sub
    Private Sub PictureBox12_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox12.MouseUp
        tmr1.Stop()
    End Sub
    Private Sub PictureBox13_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox13.MouseUp
        tmr1.Stop()
    End Sub
    Private Sub tmr1_Tick(sender As Object, e As EventArgs) Handles tmr1.Tick


        If d = 0 Then
            mf.left = mf.left + op
        ElseIf d = 1 Then
            mf.Top = mf.top + op
        End If

        tml.Text = "X=" & Form1.Location.X & " | " & "Y=" & Form1.Location.Y
        trl.Text = "X=" & RingingMsg.Location.X & " | " & "Y=" & RingingMsg.Location.Y

        ml = Form1.Location
        rl = RingingMsg.Location

        If IShwRng Then
            tmr2.Stop()
            tmr2.Start()
        End If


    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ofd1.ShowDialog()
        wmpS.URL = ofd1.FileName
        tbfp.Text = ofd1.FileName
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ofd1.ShowDialog()
        wmpS.URL = ofd1.FileName
        tcmgfp.Text = ofd1.FileName
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        wmpS.URL = tbfp.Text
        If st = "play" Then
            PictureBox3.Image = PicStop.Image
            wmpS.Ctlcontrols.play()
            st = "stop"
        ElseIf st = "stop" Then
            PictureBox3.Image = picPlay.Image
            wmpS.Ctlcontrols.stop()
            st = "play"
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        wmpS.URL = tcmgfp.Text
        If st = "play" Then
            PictureBox4.Image = PicStop.Image
            wmpS.Ctlcontrols.play()
            st = "stop"
        ElseIf st = "stop" Then
            PictureBox4.Image = picPlay.Image
            wmpS.Ctlcontrols.stop()
            st = "play"
        End If
    End Sub


    Private Sub SavePASettings()
        My.Settings.BellFile = wmpS.URL
        My.Settings.sVolume = wmpS.settings.volume

        My.Settings.sp1 = DTP1.Value
        My.Settings.sp2 = DTP2.Value
        My.Settings.sp3 = DTP3.Value
        My.Settings.sp4 = DTP4.Value
        My.Settings.sbr = DTPbr.Value
        My.Settings.sp5 = DTP5.Value
        My.Settings.sp6 = DTP6.Value
        My.Settings.sp7 = DTP7.Value
        My.Settings.sp8 = DTP8.Value

        My.Settings.sf1 = DTPf1.Value
        My.Settings.sf2 = DTPf2.Value
        'DTPf3.Value = My.Settings.sf3



        My.Settings.sDelay = UDdelay.Value
        My.Settings.sPrdDur = UDprdDur.Value
        My.Settings.sBrBDur = UDbrBDur.Value
        My.Settings.sBrEDur = UDbrEDur.Value
        My.Settings.sF1Dur = UDf1Dur.Value
        My.Settings.sF2Dur = UDf2Dur.Value
        My.Settings.sF3Dur = Udf3Dur.Value

        My.Settings.BellFile = tbfp.Text
        My.Settings.CMGFile = tcmgfp.Text

        My.Settings.sVolume = VolumeBar.Value

        My.Settings.MainLocation = ml
        My.Settings.RngMsgLocation = rl


        My.Settings.ShtDwn = chShtDwn.Checked
        My.Settings.ShwWar = chShwWrn.Checked
        My.Settings.RngMsgTM = chRngMsg.Checked
        My.Settings.AskRW = chAskWD.Checked
        My.Settings.Protect = chProtect.Checked

        My.Settings.Save()

        Form1.LoadSettings()

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        SavePASettings()
        chngSet = False
        Me.Close()

        If IShwRng Then
            RingingMsg.Hide()
        End If
    End Sub

    Private Sub tmr2_Tick(sender As Object, e As EventArgs) Handles tmr2.Tick
        RingingMsg.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ChngSPassword.ShowDialog()
    End Sub

    Private Sub PASettings_PaddingChanged(sender As Object, e As EventArgs) Handles Me.PaddingChanged

    End Sub

    Private Sub PASettings_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawRectangle(Pens.Blue, 0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1)
        e.Graphics.DrawRectangle(Pens.CadetBlue, 1, 1, e.ClipRectangle.Width - 3, e.ClipRectangle.Height - 3)
    End Sub

    Private Sub wmpS_Enter(sender As Object, e As EventArgs) Handles wmpS.Enter

    End Sub

    Private Sub wmpS_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles wmpS.PlayStateChange
        If wmpS.status = "Stopped" Then

            PictureBox3.Image = picPlay.Image
            PictureBox4.Image = picPlay.Image

            st = "play"
        End If
    End Sub

    Private Sub PASettings_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        dragging = True
        beginX = e.X
        beginY = e.Y
    End Sub

    Private Sub PASettings_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If dragging = True Then
            Me.Location = New Point(Me.Location.X + e.X - beginX, Me.Location.Y + e.Y - beginY)

        End If
    End Sub

    Private Sub PASettings_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        dragging = False
        Me.Refresh()
    End Sub

   
    Private Sub DTP1_ValueChanged(sender As Object, e As EventArgs) Handles DTP1.ValueChanged
        chngSet = True
    End Sub

    Private Sub DTP2_ValueChanged(sender As Object, e As EventArgs) Handles DTP2.ValueChanged
        chngSet = True
    End Sub

    Private Sub DTP3_ValueChanged(sender As Object, e As EventArgs) Handles DTP3.ValueChanged
        chngSet = True
    End Sub

    Private Sub DTP4_ValueChanged(sender As Object, e As EventArgs) Handles DTP4.ValueChanged
        chngSet = True
    End Sub

    Private Sub DTPbr_ValueChanged(sender As Object, e As EventArgs) Handles DTPbr.ValueChanged
        chngSet = True
    End Sub

    Private Sub DTP5_ValueChanged(sender As Object, e As EventArgs) Handles DTP5.ValueChanged
        chngSet = True
    End Sub

    Private Sub DTP6_ValueChanged(sender As Object, e As EventArgs) Handles DTP6.ValueChanged
        chngSet = True
    End Sub

    Private Sub DTP7_ValueChanged(sender As Object, e As EventArgs) Handles DTP7.ValueChanged
        chngSet = True
    End Sub

    Private Sub DTP8_ValueChanged(sender As Object, e As EventArgs) Handles DTP8.ValueChanged
        chngSet = True
    End Sub

    Private Sub DTPf1_ValueChanged(sender As Object, e As EventArgs) Handles DTPf1.ValueChanged
        chngSet = True
    End Sub

    Private Sub DTPf2_ValueChanged(sender As Object, e As EventArgs) Handles DTPf2.ValueChanged
        chngSet = True
    End Sub

    Private Sub UDprdDur_ValueChanged(sender As Object, e As EventArgs) Handles UDprdDur.ValueChanged
        chngSet = True
    End Sub

    Private Sub UDbrBDur_ValueChanged(sender As Object, e As EventArgs) Handles UDbrBDur.ValueChanged
        chngSet = True
    End Sub

    Private Sub UDbrEDur_ValueChanged(sender As Object, e As EventArgs) Handles UDbrEDur.ValueChanged
        chngSet = True
    End Sub

    Private Sub UDf1Dur_ValueChanged(sender As Object, e As EventArgs) Handles UDf1Dur.ValueChanged
        chngSet = True
    End Sub

    Private Sub UDf2Dur_KeyDown(sender As Object, e As KeyEventArgs) Handles UDf2Dur.KeyDown

    End Sub

    Private Sub UDf2Dur_ValueChanged(sender As Object, e As EventArgs) Handles UDf2Dur.ValueChanged
        chngSet = True
    End Sub

    Private Sub Udf3Dur_ValueChanged(sender As Object, e As EventArgs) Handles Udf3Dur.ValueChanged
        chngSet = True
    End Sub

    Private Sub UDdelay_ValueChanged(sender As Object, e As EventArgs) Handles UDdelay.ValueChanged
        chngSet = True
    End Sub

    Private Sub VolumeBar_Scroll(sender As Object, e As EventArgs) Handles VolumeBar.Scroll
        chngSet = True
    End Sub

    Private Sub tbfp_TextChanged(sender As Object, e As EventArgs) Handles tbfp.TextChanged
        chngSet = True
    End Sub

    Private Sub tcmgfp_TextChanged(sender As Object, e As EventArgs) Handles tcmgfp.TextChanged
        chngSet = True
    End Sub

    Private Sub tml_TextChanged(sender As Object, e As EventArgs) Handles tml.TextChanged
        chngSet = True
    End Sub

    Private Sub trl_TextChanged(sender As Object, e As EventArgs) Handles trl.TextChanged
        chngSet = True
    End Sub

    Private Sub chShtDwn_CheckedChanged(sender As Object, e As EventArgs) Handles chShtDwn.CheckedChanged
        chngSet = True
    End Sub

    Private Sub chShwWrn_CheckedChanged(sender As Object, e As EventArgs) Handles chShwWrn.CheckedChanged
        chngSet = True
    End Sub

    Private Sub chRngMsg_CheckedChanged(sender As Object, e As EventArgs) Handles chRngMsg.CheckedChanged
        chngSet = True
    End Sub

    Private Sub chAskWD_CheckedChanged(sender As Object, e As EventArgs) Handles chAskWD.CheckedChanged
        chngSet = True
    End Sub

    Private Sub chProtect_CheckedChanged(sender As Object, e As EventArgs) Handles chProtect.CheckedChanged
        chngSet = True
    End Sub
End Class