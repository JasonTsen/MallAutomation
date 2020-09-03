Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Microsoft.VisualBasic.ApplicationServices
Imports FireSharp.Extensions
Imports Newtonsoft.Json
Imports System.Globalization

Public Class EscalatorSyst

    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "qpXxaJ3Ud3RlW6LslKq88v22hG8Eh30qNo0hdcCU",
        .BasePath = "https://bait2123-202006-05.firebaseio.com/"
        }
    Private client As IFirebaseClient
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer.Enabled = True


        Try
            client = New FireSharp.FirebaseClient(fcon)
            stopEscalator.Visible = True
            startEscalator.Visible = False
        Catch

            MessageBox.Show("there was a problem in the internet connection")
        End Try
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click




        Dim res = client.Get("PI_05_" + fnc_Get_NTP.ToString("yyyyMMdd/HH/mmss") + "/ultra2")



        Try
                Dim tempUltra = New With {Key .Body = ""}

                Dim Body As String

                If res.Body.Length = 5 Then
                    Body = res.Body.Substring(1, 1)
                    Dim ultra As Integer = Convert.ToInt32(Body)
                    lblName.Text = "Ultra: " + Body.ToString
                    If ultra > 30.0 Then
                        stopEscalator.Visible = True
                        startEscalator.Visible = False
                        Dim buzz = client.Set("PI_05_CONTROL/buzzer", "0")


                        Body = buzz.Body.Substring(1, 1)

                        Dim buzzer As Integer = Convert.ToInt32(Body)
                        lblBuzzer.Text = "Buzzer: " + Body.ToString
                    Else
                        stopEscalator.Visible = False
                        startEscalator.Visible = True
                        Dim buzz = client.Set("PI_05_CONTROL/buzzer", "1")

                    Body = buzz.Body.Substring(1, 1)
                        Dim buzzer As Integer = Convert.ToInt32(Body)
                        lblBuzzer.Text = "Buzzer: " + Body.ToString
                    End If

                Else

                    Body = res.Body.Substring(1, 2)
                    Dim ultra As Integer = Convert.ToInt32(Body)
                    lblName.Text = "Ultra: " + Body.ToString
                    If ultra > 30.0 Then
                        stopEscalator.Visible = True
                        startEscalator.Visible = False
                        Dim buzz = client.Set("PI_05_CONTROL/buzzer", "0")


                        Body = buzz.Body.Substring(1, 1)

                        Dim buzzer As Integer = Convert.ToInt32(Body)
                        lblBuzzer.Text = "Buzzer: " + Body.ToString
                    Else
                        stopEscalator.Visible = False
                        startEscalator.Visible = True
                        Dim buzz = client.Set("PI_05_CONTROL/buzzer", "1")

                        Body = buzz.Body.Substring(1, 1)
                        Dim buzzer As Integer = Convert.ToInt32(Body)
                        lblBuzzer.Text = "Buzzer: " + Body.ToString
                    End If
                End If


        Catch ex As FormatException

            End Try

    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        lblDateTime.Text = fnc_Get_NTP.ToString("yyyyMMdd/HH/mmss")
        Dim sec As Long
        sec = Convert.ToInt32(fnc_Get_NTP.ToString("ss"))
        sec = sec Mod (60 * 60)
        If sec.Equals(0) Or sec.Equals(10) Or sec.Equals(20) Or sec.Equals(30) Or sec.Equals(40) Or sec.Equals(50) Then
            btnStart.PerformClick()
        End If
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
End Class