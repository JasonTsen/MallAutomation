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

Public Class EntranceModule
    Inherits Form
    Private Sub Entrance_Module_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Timer1.Enabled = True

        Try
            client = New FireSharp.FirebaseClient(fcon)
            pic_entrance.Image = My.Resources.entrace
        Catch
            MessageBox.Show("Failed to establish Internet connection.")
        End Try

    End Sub

    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "qpXxaJ3Ud3RlW6LslKq88v22hG8Eh30qNo0hdcCU",
        .BasePath = "https://bait2123-202006-05.firebaseio.com/"
        }
    Private client As IFirebaseClient

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Try
            BackgroundWorker1.RunWorkerAsync()
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

        dtTime = dtTime.AddHours(8) ' <<-- * please modify (n) according to your location *
        ' current time zone is GMT(+8)
        Return dtTime
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = "Current Time:  " + fnc_Get_NTP.ToString("yyyyMMdd/HH/mmss")
        CheckForIllegalCrossThreadCalls = False


        Try
            Dim sec As Long
            sec = Convert.ToInt32(fnc_Get_NTP.ToString("ss"))
            sec = sec Mod (60 * 60)
            If sec.Equals(0) OrElse sec.Equals(10) OrElse sec.Equals(20) OrElse sec.Equals(30) OrElse sec.Equals(40) OrElse sec.Equals(50) Then
                btnStart.PerformClick()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub execution()


        Try
            Dim res = client.Get("PI_05_" + fnc_Get_NTP().ToString("yyyyMMdd/HH/mmss") + "/ultra2")
            Dim res_tempe = client.Get("PI_05_" + fnc_Get_NTP().ToString("yyyyMMdd/HH/mmss") + "/ultra")

            Dim Body_ultra As String
            Dim Body_temp As String
            Dim Body_buzz As String
            'For single digit's ultra value

            If res.Body.Length <= 5 Or res_tempe.Body.Length <= 5 Then
                Body_ultra = res.Body.Substring(1, 1)
                Body_temp = res_tempe.Body.Substring(1, 2)
                Dim ultra As Integer = Convert.ToInt32(Body_ultra)
                Dim temp As Integer = Convert.ToInt32(Body_temp)



                'customer not nearby
                If ultra > 30 Then


                    lblUltra.Text = "Ultra: " + Body_ultra.ToString
                    lblTemp.Text = "Temperature: N/A"
                    Dim buzz = client.Set("PI_05_CONTROL/buzzer", "0")
                    pic_entrance.Image = My.Resources.entrace
                    Dim lcd = client.Set("PI_05_CONTROL/lcdtext", "Waiting customer...")
                    Body_buzz = buzz.Body.Substring(1, 1)
                    Dim buzzer As Integer = Convert.ToInt32(Body_buzz)
                    lblBuzzer.Text = "Buzzer: " + Body_buzz.ToString

                    lblDisplay.Text = lcd.Body.ToString

                    'customer is nearby
                Else
                    lblUltra.Text = "Ultra: " + Body_ultra.ToString
                    lblTemp.Text = "Temperature: " + Body_temp.ToString() + "°C"
                    Dim buzz = client.Set("PI_05_CONTROL/buzzer", "1")
                    Dim lcd = client.Set("PI_05_CONTROL/lcdtext", "Welcome!")


                    pic_entrance.Image = My.Resources.entrance_customer

                    Body_buzz = buzz.Body.Substring(1, 1)
                    Dim buzzer As Integer = Convert.ToInt32(Body_buzz)
                    lblBuzzer.Text = "Buzzer: " + Body_buzz.ToString
                    lblDisplay.Text = lcd.Body.ToString
                End If

                lblEntranceRep.Text += Body_ultra.ToString + "       " + Body_temp.ToString + "         " + fnc_Get_NTP.ToString("yyyyMMdd/HH/mmss") + vbCrLf
            Else
                'For double digits value
                Body_ultra = res.Body.Substring(1, 2)
                Body_temp = res_tempe.Body.Substring(1, 2)

                Dim ultra As Integer = Convert.ToInt32(Body_ultra)
                Dim temp As Integer = Convert.ToInt32(Body_temp)


                'customer not nearby
                If ultra > 30.0 Then


                    lblUltra.Text = "Ultra: " + Body_ultra.ToString
                    lblTemp.Text = "Temperature: N/A"
                    Dim buzz = client.Set("PI_05_CONTROL/buzzer", "0")
                    pic_entrance.Image = My.Resources.entrace
                    Dim lcd = client.Set("PI_05_CONTROL/lcdtext", "Waiting customer...")
                    Body_buzz = buzz.Body.Substring(1, 1)
                    Dim buzzer As Integer = Convert.ToInt32(Body_buzz)
                    lblBuzzer.Text = "Buzzer: " + Body_buzz.ToString

                    lblDisplay.Text = lcd.Body.ToString

                    'customer is nearby
                Else
                    lblUltra.Text = "Ultra: " + Body_ultra.ToString
                    lblTemp.Text = "Temperature: " + Body_temp.ToString() + "°C"
                    Dim buzz = client.Set("PI_05_CONTROL/buzzer", "1")
                    Dim lcd = client.Set("PI_05_CONTROL/lcdtext", "Welcome!")

                    pic_entrance.Image = My.Resources.entrance_customer

                    Body_buzz = buzz.Body.Substring(1, 1)
                    Dim buzzer As Integer = Convert.ToInt32(Body_buzz)
                    lblBuzzer.Text = "Buzzer: " + Body_buzz.ToString
                    lblDisplay.Text = lcd.Body.ToString
                End If

                lblEntranceRep.Text += Body_ultra.ToString + "       " + Body_temp.ToString + "         " + fnc_Get_NTP.ToString("yyyyMMdd/HH/mmss") + vbCrLf
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        CheckForIllegalCrossThreadCalls = False
        Dim t1 As New System.Threading.Thread(AddressOf execution)

        t1.Start()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class