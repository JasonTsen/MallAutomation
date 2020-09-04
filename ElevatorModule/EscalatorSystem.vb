Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Microsoft.VisualBasic.ApplicationServices
Imports FireSharp.Extensions
Imports Newtonsoft.Json
Imports System.Globalization
Imports System.Threading
Imports System.Windows.Forms
Imports System.ComponentModel
Public Class EscalatorSyst
    Inherits Form

    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "qpXxaJ3Ud3RlW6LslKq88v22hG8Eh30qNo0hdcCU",
        .BasePath = "https://bait2123-202006-05.firebaseio.com/"
        }

    Private client As IFirebaseClient
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer.Enabled = True
        CheckForIllegalCrossThreadCalls = False

        Try
            client = New FireSharp.FirebaseClient(fcon)
            stopEscalator.Visible = True
            startEscalator.Visible = False
        Catch

            MessageBox.Show("there was a problem in the internet connection")
        End Try
    End Sub
    Sub firebase()

        Try
            Dim res = client.Get("PI_05_" + fnc_Get_NTP.ToString("yyyyMMdd/HH/mmss") + "/ultra2")

            Dim resBody As String
            Dim buzzBody As String


            If res.Body.Length = 5 Then
                resBody = res.Body.Substring(1, 1)
                Dim ultra As Integer = Convert.ToInt32(resBody)
                lblName.Text = "" + resBody.ToString


                If ultra > 30 Then

                    Dim buzz = client.Set("PI_05_CONTROL/buzzer", "0")

                    stopEscalator.Visible = True
                    startEscalator.Visible = False
                    buzzBody = buzz.Body.Substring(1, 1)
                    lblBuzzer.Text = "Buzzer: " + buzzBody.ToString
                Else

                    Dim buzz = client.Set("PI_05_CONTROL/buzzer", "1")
                    stopEscalator.Visible = False
                    startEscalator.Visible = True
                    buzzBody = buzz.Body.Substring(1, 1)

                    lblBuzzer.Text = "Buzzer: " + buzzBody.ToString


                End If

            Else

                resBody = res.Body.Substring(1, 2)
                Dim ultra As Integer = Convert.ToInt32(resBody)
                lblName.Text = "Ultra: " + resBody.ToString

                If ultra > 30.0 Then

                    Dim buzz = client.Set("PI_05_CONTROL/buzzer", "0")
                    stopEscalator.Visible = True
                    startEscalator.Visible = False
                    buzzBody = buzz.Body.Substring(1, 1)

                    lblBuzzer.Text = "Buzzer: " + buzzBody.ToString
                Else
                    stopEscalator.Visible = False
                    startEscalator.Visible = True
                    Dim buzz = client.Set("PI_05_CONTROL/buzzer", "1")

                    buzzBody = buzz.Body.Substring(1, 1)

                    lblBuzzer.Text = "Buzzer: " + buzzBody.ToString
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        lblDateTime.Text = "Current Date and Time : " + fnc_Get_NTP.ToString("yyyy/MMdd/HH/mmss")
        CheckForIllegalCrossThreadCalls = False

        Dim sec As Long
        sec = Convert.ToInt32(fnc_Get_NTP.ToString("ss"))
        sec = sec Mod (60 * 60)
        Try
            If sec.Equals(0) OrElse sec.Equals(10) OrElse sec.Equals(20) OrElse sec.Equals(30) OrElse sec.Equals(40) OrElse sec.Equals(50) Then
                btnStart.PerformClick()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Function fnc_Get_NTP() As DateTime
        '　--- create instance of UDP
        Dim objSck As System.Net.Sockets.UdpClient
        Dim ipAny As System.Net.IPEndPoint = New System.Net.IPEndPoint(System.Net.IPAddress.Any, 0)
        objSck = New System.Net.Sockets.UdpClient(ipAny)
        ' --- send UDP
        Dim sdat As Byte() = New Byte(47) {}
        sdat(0) = &HB
        objSck.Send(sdat, sdat.GetLength(0), "time.windows.com", 123)
        ' --- receive UDP
        Dim rdat As Byte() = objSck.Receive(ipAny)
        ' elapsed time (date and time) from 1900/01/01
        Dim elapsedTotalSec As Long ' elapsed seconds from 1900/01/01

        Dim Days As Long    ' days 
        Dim HH As Long    ' hours 
        Dim MM As Long    ' minutes 
        Dim SS As Long    ' seconds 
        ' --- elapsed seconds from 1900/01/01
        elapsedTotalSec = CLng(
              rdat(40) * Math.Pow(2, (8 * 3)) +
              rdat(41) * Math.Pow(2, (8 * 2)) +
              rdat(42) * Math.Pow(2, (8 * 1)) +
              rdat(43))
        ' ---

        Days = elapsedTotalSec \ (24 * 60 * 60)   ' days 
        SS = elapsedTotalSec Mod (24 * 60 * 60) ' mod seconds 
        HH = SS \ (60 * 60)           ' --- 
        SS = SS Mod (60 * 60)         ' --- 
        MM = MM \ 60                  ' --- 

        ' --- convert to DateTime type --- 
        Dim dtTime As DateTime = #1900/01/01#
        dtTime = dtTime.AddDays(Days)
        dtTime = dtTime.AddHours(HH)
        dtTime = dtTime.AddMinutes(MM)
        dtTime = dtTime.AddSeconds(SS)

        dtTime = dtTime.AddHours(8) ' <<-- * modify (n) according to location *
        ' ---
        Return dtTime
    End Function

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        CheckForIllegalCrossThreadCalls = False
        Dim t1 As New System.Threading.Thread(AddressOf firebase)
        t1.Start()
    End Sub
End Class