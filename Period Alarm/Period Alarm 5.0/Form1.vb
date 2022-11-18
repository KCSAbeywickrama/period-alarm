Public Class Form1
    Dim p1 As Date
    Dim p2 As Date
    Dim p3 As Date
    Dim p4 As Date
    Dim br As Date
    Dim p5 As Date
    Dim p6 As Date
    Dim p7 As Date
    Dim p8 As Date

    Dim SclF1 As Date
    Dim SclF2 As Date
    Dim SclF3 As Date

    Dim NowTime As Date
    Dim NowPrd As Byte
    Dim NowPrdStr = New String() {"", "1st", "2nd", "3rd", "4th", "5th", "6th", "7th", "8th"}
    Dim RnAgn As Date
    Dim RnCMG As Date

    Dim wmpCD As Integer
    Dim wmpCMGD As Integer
    Dim wmpCMGT As Date


    Dim delay As Integer
    Dim PrdDur As Integer
    Dim BrBDur As Integer
    Dim BrEDur As Integer
    Dim SclF1Dur As Integer
    Dim SclF2Dur As Integer
    Dim SclF3Dur As Integer

    Private dragging As Boolean
    Private beginX, beginY As Integer

    Dim st As String = "play"

    Dim TrnOff As Boolean
    Public ShtDownPC As Boolean

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub Form1_BindingContextChanged(sender As Object, e As EventArgs) Handles Me.BindingContextChanged

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not TrnOff Then
            e.Cancel = True

            CustomMsg.tMsg.Text = "Are you sure you want to close the Period Alarm ?"
            CustomMsg.picMsg.Image = CustomMsg.piError.Image
            CustomMsg.ShowDialog()

            If CustomMsg.dlg = "ok" Then
                EnterPass.ShowDialog()
                If EnterPass.dlg = "c" Then
                    My.Settings.NBRDur = UDbellDur.Value
                    TrnOff = True
                    Application.Exit()
                ElseIf EnterPass.dlg = "ic" Then
                    CustomMsg.tMsg.Text = "Incorrect password."
                    CustomMsg.picMsg.Image = CustomMsg.piError.Image
                    CustomMsg.btnClose.Visible = False
                    CustomMsg.ShowDialog()
                    CustomMsg.btnClose.Visible = True
                    Me.Hide()
                End If
            End If


        End If
    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0


        If My.Settings.AskRW Then
            If Now.ToString("dddd") = "Sunday" Or Now.ToString("dddd") = "Saturday" Then
                CustomMsg.tMsg.Text = "Today is " & Now.ToString("dddd") & ". Do you want to start Period Alarm ?"
                CustomMsg.picMsg.Image = AboutBox.PictureBox1.Image
                CustomMsg.StartPosition = FormStartPosition.CenterScreen
                CustomMsg.ShowDialog()
                CustomMsg.StartPosition = FormStartPosition.CenterParent
                If CustomMsg.dlg = "close" Then
                    TrnOff = True
                    Application.Exit()
                    Exit Sub
                End If
            End If
        End If

        SplashForm.Show()

        ' RingingMsg.Show()
        ' RingingMsg.Hide()
        'RingingMsg.Opacity = 1
        LoadSettings()

        'PrepareWMP()


    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'Me.WindowState = FormWindowState.Minimized
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        AboutBox.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
       


        EnterPass.ShowDialog()
        If EnterPass.dlg = "c" Then
            PASettings.Show()
        ElseIf EnterPass.dlg = "ic" Then
            CustomMsg.tMsg.Text = "Incorrect password."
            CustomMsg.picMsg.Image = CustomMsg.piError.Image
            CustomMsg.btnClose.Visible = False
            CustomMsg.ShowDialog()
            CustomMsg.btnClose.Visible = True
        End If




    End Sub

    Private Sub nico1_Click(sender As Object, e As EventArgs) Handles nico1.Click
        Me.Show()
        Me.Activate()
    End Sub

    Private Sub nico1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles nico1.MouseDoubleClick

    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        NowTime = DateTime.Now.ToLongTimeString

        tnt.Text = TimeOfDay.ToString("h:mm")
        'tnt.Text = NowTime
        'Label1.Text = p1

        Select Case NowTime
            Case RnAgn
                wmp.URL = My.Settings.BellFile
                ' wmp.settings.volume = My.Settings.sVolume
                'wmp.settings.mute = True
                wmp.Ctlcontrols.currentPosition = wmpCD - PrdDur
                'wmp.Ctlcontrols.pause()
                wmp.Ctlcontrols.play()
                ' 
                RingingMsg.l2.Text = NowPrdStr(NowPrd + 1) & " Period is begin"
                RingingMsg.Show()
                'wmp.settings.mute = False
            Case p1
                wmp.URL = My.Settings.BellFile
                wmp.Ctlcontrols.currentPosition = wmpCD - PrdDur
                wmp.Ctlcontrols.play()
                RnAgn = NowTime.AddSeconds(PrdDur + delay)
                NowPrd = 1
                RingingMsg.l2.Text = NowPrdStr(NowPrd) & " Period is over"
                RingingMsg.Show()

            Case p2
                wmp.URL = My.Settings.BellFile
                wmp.Ctlcontrols.currentPosition = wmpCD - PrdDur
                wmp.Ctlcontrols.play()
                RnAgn = NowTime.AddSeconds(PrdDur + delay)
                NowPrd = 2
                RingingMsg.l2.Text = NowPrdStr(NowPrd) & " Period is over"
                RingingMsg.Show()

            Case p3
                wmp.URL = My.Settings.BellFile
                wmp.Ctlcontrols.currentPosition = wmpCD - PrdDur
                wmp.Ctlcontrols.play()
                RnAgn = NowTime.AddSeconds(PrdDur + delay)
                NowPrd = 3
                RingingMsg.l2.Text = NowPrdStr(NowPrd) & " Period is over"
                RingingMsg.Show()

            Case p4
                wmp.URL = My.Settings.BellFile
                wmp.Ctlcontrols.currentPosition = wmpCD - BrBDur
                wmp.Ctlcontrols.play()
                RingingMsg.l2.Text = "4th Period is over"
                RingingMsg.Show()
                tmrIB.Interval = (BrBDur / 2) * 1000
                Label1.Text = tmrIB.Interval
                tmrIB.Start()

            Case br
                wmp.URL = My.Settings.BellFile
                wmp.Ctlcontrols.currentPosition = wmpCD - BrEDur
                wmp.Ctlcontrols.play()
                RingingMsg.l2.Text = "Interval is over"
                RingingMsg.Show()

            Case p5
                wmp.URL = My.Settings.BellFile
                wmp.Ctlcontrols.currentPosition = wmpCD - PrdDur
                wmp.Ctlcontrols.play()
                RnAgn = NowTime.AddSeconds(PrdDur + delay)
                NowPrd = 5
                RingingMsg.l2.Text = NowPrdStr(NowPrd) & " Period is over"
                RingingMsg.Show()

            Case p6
                wmp.URL = My.Settings.BellFile
                wmp.Ctlcontrols.currentPosition = wmpCD - PrdDur
                wmp.Ctlcontrols.play()
                RnAgn = NowTime.AddSeconds(PrdDur + delay)
                NowPrd = 6
                RingingMsg.l2.Text = NowPrdStr(NowPrd) & " Period is over"
                RingingMsg.Show()

            Case p7
                wmp.URL = My.Settings.BellFile
                wmp.Ctlcontrols.currentPosition = wmpCD - PrdDur
                wmp.Ctlcontrols.play()
                RnAgn = NowTime.AddSeconds(PrdDur + delay)
                NowPrd = 7
                RingingMsg.l2.Text = NowPrdStr(NowPrd) & " Period is over"
                RingingMsg.Show()

            Case p8
                wmp.URL = My.Settings.BellFile
                wmp.Ctlcontrols.currentPosition = wmpCD - PrdDur
                wmp.Ctlcontrols.play()
                'RnAgn = NowTime.AddSeconds(PrdDur + delay)
                NowPrd = 8
                RingingMsg.l2.Text = NowPrdStr(NowPrd) & " Period is over"
                RingingMsg.Show()

                '////////////////////////////////////
            Case SclF1
                wmp.URL = My.Settings.BellFile
                wmp.Ctlcontrols.currentPosition = wmpCD - SclF1Dur
                wmp.Ctlcontrols.play()
                RingingMsg.l2.Text = "Last 1st bell"
                RingingMsg.Show()

            Case SclF2
                wmp.URL = My.Settings.BellFile
                wmp.Ctlcontrols.currentPosition = wmpCD - SclF2Dur
                wmp.Ctlcontrols.play()
                RnCMG = NowTime.AddSeconds(SclF2Dur)
                RingingMsg.l2.Text = "Last 2nd bell"
                RingingMsg.Show()

            Case RnCMG
                wmp.URL = My.Settings.CMGFile
                wmp.Ctlcontrols.play()
                wmpCMGT = NowTime
                tmrPrepCMG.Start()
                RingingMsg.l1.Text = "Playing Gatha . . ."
                RingingMsg.l2.Text = ". . ."
                RingingMsg.Show()

            Case SclF3
                wmp.URL = My.Settings.BellFile
                wmp.Ctlcontrols.currentPosition = wmpCD - SclF3Dur
                wmp.Ctlcontrols.play()
                RingingMsg.l1.Text = "Bell is ringing . . ."
                RingingMsg.l2.Text = "School is over"
                RingingMsg.Show()
                TrnOff = True




        End Select


    End Sub

    Private Sub wmp_Enter(sender As Object, e As EventArgs) Handles wmp.Enter

    End Sub

    Private Sub wmp_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles wmp.PlayStateChange
        If wmp.status = "Stopped" Then
            RingingMsg.Hide()
            picBell.Image = picBellPlay.Image
            ToolTip1.SetToolTip(picBell, "Ring the bell")
            st = "play"

            If TrnOff And My.Settings.ShtDwn Then
                ShutDownMsg.ShowDialog()
                If ShtDownPC Then
                    Shell("shutdown /s /t 003")
                End If
                Application.Exit()
            ElseIf TrnOff Then
                Application.Exit()
            End If
        End If
    End Sub

   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        't1.Text = TimeOfDay
        't1.Text = wmp.currentMedia.durationString
        Me.BackColor = Color.Red
        wmp.Ctlcontrols.play()
        Me.BackColor = Color.Gray
        t1.Text = wmp.settings.volume
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        p1 = t1.Text
    End Sub


    Public Sub LoadSettings()
        wmp.URL = My.Settings.BellFile
        wmp.settings.volume = My.Settings.sVolume

        p1 = My.Settings.sp1.ToLongTimeString
        p2 = My.Settings.sp2.ToLongTimeString
        p3 = My.Settings.sp3.ToLongTimeString
        p4 = My.Settings.sp4.ToLongTimeString
        br = My.Settings.sbr.ToLongTimeString
        p5 = My.Settings.sp5.ToLongTimeString
        p6 = My.Settings.sp6.ToLongTimeString
        p7 = My.Settings.sp7.ToLongTimeString
        p8 = My.Settings.sp8.ToLongTimeString

        SclF1 = My.Settings.sf1.ToLongTimeString
        SclF2 = My.Settings.sf2.ToLongTimeString
        'SclF3 = My.Settings.sf3

        UDbellDur.Value = My.Settings.NBRDur


        delay = My.Settings.sDelay
        PrdDur = My.Settings.sPrdDur
        BrBDur = My.Settings.sBrBDur
        BrEDur = My.Settings.sBrEDur
        SclF1Dur = My.Settings.sF1Dur
        SclF2Dur = My.Settings.sF2Dur
        SclF3Dur = My.Settings.sF3Dur

        Me.Location = My.Settings.MainLocation
        RingingMsg.Location = My.Settings.RngMsgLocation
        RingingMsg.TopMost = My.Settings.RngMsgTM

        PrepareWMP()

    End Sub

    Private Sub PrepareWMP()
        wmp.settings.mute = True
        wmp.Ctlcontrols.play()
        tmrPrepWMP.Start()
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        dragging = True
        beginX = e.X
        beginY = e.Y
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If dragging = True Then
            Me.Location = New Point(Me.Location.X + e.X - beginX, Me.Location.Y + e.Y - beginY)
            Me.Refresh()
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        dragging = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles picBell.Click




        If st = "play" Then

            If My.Settings.ShwWar Then
                CustomMsg.tMsg.Text = "Are you sure you want to ring the bell."
                CustomMsg.picMsg.Image = CustomMsg.picAstric.Image
                CustomMsg.ShowDialog()
            End If



            If CustomMsg.dlg = "ok" Or Not My.Settings.ShwWar Then





                wmp.Ctlcontrols.currentPosition = wmp.currentMedia.duration - UDbellDur.Value
                wmp.Ctlcontrols.play()
                RingingMsg.l1.Text = "Bell is ringing. . ."
                RingingMsg.l2.Text = ". . ."
                RingingMsg.Show()
                picBell.Image = picBellStop.Image
                ToolTip1.SetToolTip(picBell, "Stop ringing")
                st = "stop"

            End If
        ElseIf st = "stop" Then
            picBell.Image = picBellPlay.Image()
            wmp.Ctlcontrols.stop()
            ToolTip1.SetToolTip(picBell, "Ring the bell")
            st = "play"

        End If

    End Sub

    Private Sub tmrPrepWMP_Tick(sender As Object, e As EventArgs) Handles tmrPrepWMP.Tick
        wmp.Ctlcontrols.stop()
        wmp.settings.mute = False
        tmrPrepWMP.Stop()
        SplashForm.sc = True
        wmpCD = wmp.currentMedia.duration
    End Sub

    Private Sub picBellStop_Click(sender As Object, e As EventArgs) Handles picBellStop.Click

    End Sub

    Private Sub picBellPlay_Click(sender As Object, e As EventArgs) Handles picBellPlay.Click

    End Sub

   

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        e.Graphics.DrawRectangle(Pens.Blue, 0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1)
        e.Graphics.DrawRectangle(Pens.CadetBlue, 1, 1, e.ClipRectangle.Width - 3, e.ClipRectangle.Height - 3)


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        

    End Sub

    Private Sub tnt_Click(sender As Object, e As EventArgs) Handles tnt.Click

    End Sub

    Private Sub panelRB_Paint(sender As Object, e As PaintEventArgs) Handles panelRB.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        'Label1.Text = My.Settings.NBRDur
        'My.Settings.Save()
    End Sub

    Private Sub UDbellDur_Click(sender As Object, e As EventArgs) Handles UDbellDur.Click

    End Sub

    Private Sub UDbellDur_ValueChanged(sender As Object, e As EventArgs) Handles UDbellDur.ValueChanged


    End Sub

    Private Sub tmrPrepCMG_Tick(sender As Object, e As EventArgs) Handles tmrPrepCMG.Tick
        ' wmpCMGT = DateTime.Now.ToLongTimeString
        SclF3 = wmpCMGT.AddSeconds(wmp.currentMedia.duration)
        SclF3 = SclF3.ToLongTimeString
        'SclF3 = PASettings.DTPf1.Value.ToLongTimeString
        'Label1.Text = SclF3
        tmrPrepCMG.Stop()
    End Sub

    Private Sub tmrIB_Tick(sender As Object, e As EventArgs) Handles tmrIB.Tick
        RingingMsg.l2.Text = "Interval is begin"
        tmrIB.Stop()
    End Sub
End Class
