Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Microsoft.VisualBasic.ApplicationServices
Imports FireSharp.Extensions
Imports Newtonsoft.Json
Imports System.Globalization

Public Class LightSenseModule
    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "qpXxaJ3Ud3RlW6LslKq88v22hG8Eh30qNo0hdcCU",
        .BasePath = "https://bait2123-202006-05.firebaseio.com/"
        }
    Private client As IFirebaseClient
    Private Sub LightSenseModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer1.Enabled = True
        radManual.Checked = True
        lblName.Text = "No Data Get"
        lblMessage.Text = "No Data Get"
        lblLight.Text = "The Light is Off"
        CheckForIllegalCrossThreadCalls = False

        Try
            client = New FireSharp.FirebaseClient(fcon)

        Catch

            MessageBox.Show("there was a problem in the internet connection")
        End Try
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception

        End Try



    End Sub

    Sub startlightFunction()
        Dim res = client.Get("PI_05_" + lightdata.ToString("yyyyMMdd/HH/mmss") + "/ultra2")
        Try


            Dim Body As String

            If res.Body.Length = 5 Then
                Body = res.Body.Substring(1, 1)
                Dim ultra As Integer = Convert.ToInt32(Body)
                lblName.Text = "Ultra: " + Body.ToString
                If ultra > 10 Then
                    Dim led = client.Set("PI_05_CONTROL/led", "1")
                    PictureBox1.Image = My.Resources.light
                    lblLight.Text = "The Light has been On"
                    Body = led.Body.Substring(1, 1)

                    Dim ledlight As Integer = Convert.ToInt32(Body)
                    lblMessage.Text = "Light: " + Body.ToString
                Else

                    Dim led = client.Set("PI_05_CONTROL/led", "0")
                    PictureBox1.Image = My.Resources.nolight
                    lblLight.Text = "The Light has been Off"
                    Body = led.Body.Substring(1, 1)
                    Dim ledlight As Integer = Convert.ToInt32(Body)
                    lblMessage.Text = "Light: " + Body.ToString
                End If

                lblReport.Text += Body.ToString + "          " + lblName.Text + "         " + lightdata.ToString("yyyyMMdd/HH/mmss") + vbCrLf

            Else

                Body = res.Body.Substring(1, 2)
                Dim ultra As Integer = Convert.ToInt32(Body)
                lblName.Text = "Ultra: " + Body.ToString
                If ultra > 10 Then

                    Dim led = client.Set("PI_05_CONTROL/led", "1")
                    PictureBox1.Image = My.Resources.light
                    lblLight.Text = "The Light has been On"

                    Body = led.Body.Substring(1, 1)

                    Dim ledlight As Integer = Convert.ToInt32(Body)
                    lblMessage.Text = "LED: " + Body.ToString
                Else

                    Dim led = client.Set("PI_05_CONTROL/led", "0")
                    PictureBox1.Image = My.Resources.nolight
                    lblLight.Text = "The Light has been Off"
                    Body = led.Body.Substring(1, 1)
                    Dim ledlight As Integer = Convert.ToInt32(Body)
                    lblMessage.Text = "LED: " + Body.ToString
                End If
            End If

            lblReport.Text += Body.ToString + "          " + lblName.Text + "         " + lightdata.ToString("yyyyMMdd/HH/mmss") + vbCrLf

        Catch ex As Exception

        End Try
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        lblDateTime.Text = lightdata.ToString("yyyy/MM/dd/HH/mmss")
        CheckForIllegalCrossThreadCalls = False

        If radAuto.Checked Then

            Dim sec As Long
            sec = Convert.ToInt32(lightdata.ToString("ss"))
            sec = sec Mod (60 * 60)

            If sec.Equals(0) Or sec.Equals(10) Or sec.Equals(20) Or sec.Equals(30) Or sec.Equals(40) Or sec.Equals(50) Then
                btnStart.PerformClick()
            End If


        End If

    End Sub

    Public Function lightdata() As DateTime
        '--- create instance of UDP
        Dim objSck As System.Net.Sockets.UdpClient
        Dim ipAny As System.Net.IPEndPoint = New System.Net.IPEndPoint(System.Net.IPAddress.Any, 0)
        objSck = New System.Net.Sockets.UdpClient(ipAny)
        '--- send UDP
        Dim sdat As Byte() = New Byte(47) {}
        sdat(0) = &HB
        objSck.Send(sdat, sdat.GetLength(0), "time.windows.com", 123)
        '--- receive UDP
        Dim rdat As Byte() = objSck.Receive(ipAny)
        'elapsed time(Date And time) from 1900/01/01
        Dim elapsedTotalSec As Long ' elapsed seconds from 1900/01/01

        Dim Days As Long    ' days 
        Dim HH As Long    ' hours 
        Dim MM As Long    ' minutes 
        Dim SS As Long    ' seconds 
        '--- elapsed seconds from 1900/01/01
        elapsedTotalSec = CLng(
              rdat(40) * Math.Pow(2, (8 * 3)) +
              rdat(41) * Math.Pow(2, (8 * 2)) +
              rdat(42) * Math.Pow(2, (8 * 1)) +
              rdat(43))
        '---

        Days = elapsedTotalSec \ (24 * 60 * 60)   ' days 
        SS = elapsedTotalSec Mod (24 * 60 * 60) ' mod seconds 
        HH = SS \ (60 * 60)           ' --- 
        SS = SS Mod (60 * 60)         ' --- 
        MM = MM \ 60                  ' --- 

        '--- convert to DateTime type --- 
        Dim dtTime As DateTime = #1900/01/01#
        dtTime = dtTime.AddDays(Days)
        dtTime = dtTime.AddHours(HH)
        dtTime = dtTime.AddMinutes(MM)
        dtTime = dtTime.AddSeconds(SS)

        dtTime = dtTime.AddHours(8) ' <<-- * please modify (n) according to your location *
        '---
        Return dtTime
    End Function

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        CheckForIllegalCrossThreadCalls = False
        Dim starttheLight As New System.Threading.Thread(AddressOf startlightFunction)
        starttheLight.Start()
    End Sub


    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        lblName.Text = "No Data Get"
        lblMessage.Text = "No Data Get"
        lblLight.Text = "The Light is Off"
        radManual.Checked = True
        radAuto.Checked = False
        PictureBox1.Image = My.Resources.nolight
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
