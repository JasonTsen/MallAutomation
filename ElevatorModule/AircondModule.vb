Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports System.Threading
Imports FireSharp.Extensions
Imports System.ComponentModel

Public Class AircondModule
    Private fcon As New FirebaseConfig() With
    {
        .AuthSecret = "qpXxaJ3Ud3RlW6LslKq88v22hG8Eh30qNo0hdcCU",
        .BasePath = "https://bait2123-202006-05.firebaseio.com/"
    }

    Private client As IFirebaseClient

    Private Sub AircondModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Timer1.Enabled = True
        fanIcon.Image = My.Resources.fan_ventilator_propeller_rotor_motion_512
        lblTemp.Text = "No Data Currently..."
        lblOnOff.Text = "OFF"

        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show("No Internet Access")
        End Try
    End Sub

    Private Sub btnOn_Click(sender As Object, e As EventArgs) Handles btnOn.Click
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Sub buttonClick()
        Timer1.Enabled = True
        Try
            Dim ultra2 = client.Get("PI_05_" + fnc_Get_NTP().ToString("yyyyMMdd/HH/mmss") + "/ultra2")
            Dim ultraBody As String
            Dim buzzBody As String
            Dim ledBody As String

            If ultra2.Body.Length = 5 Then
                ultraBody = ultra2.Body.Substring(1, 1)
                Dim ultraTemp As Integer = Convert.ToInt32(ultraBody)

                If ultraTemp > 26.0 Then
                    Dim ledLight = client.Set("PI_05_CONTROL/led", "1")
                    Dim buzzer = client.Set("PI_05_CONTROL/buzzer", "1")
                    buzzBody = buzzer.Body.Substring(1, 1)
                    ledBody = ledLight.Body.Substring(1, 1)
                    fanIcon.Image = My.Resources.fan_gif
                    btnOn.Text = "OFF"
                    lblTemp.Text = "Current temperature is " + ultraBody.ToString + "°C"
                Else
                    Dim buzzer = client.Set("PI_05_CONTROL/led", "0")
                    Dim ledLight = client.Set("PI_05_CONTROL/buzzer", "0")
                    buzzBody = buzzer.Body.Substring(1, 1)
                    ledBody = ledLight.Body.Substring(1, 1)
                    fanIcon.Image = My.Resources.fan_ventilator_propeller_rotor_motion_512
                    btnOn.Text = "ON"
                    lblTemp.Text = "Current temperature is " + ultraBody.ToString + "°C"
                End If
            Else
                ultraBody = ultra2.Body.Substring(1, 2)
                Dim ultraTemp As Integer = Convert.ToInt32(ultraBody)

                If ultraTemp > 26.0 Then
                    Dim ledLight = client.Set("PI_05_CONTROL/led", "1")
                    Dim buzzer = client.Set("PI_05_CONTROL/buzzer", "1")
                    buzzBody = buzzer.Body.Substring(1, 1)
                    ledBody = ledLight.Body.Substring(1, 1)
                    fanIcon.Image = My.Resources.fan_gif
                    btnOn.Text = "OFF"
                    lblTemp.Text = "Current temperature is " + ultraBody.ToString + "°C"
                Else
                    Dim buzzer = client.Set("PI_05_CONTROL/led", "0")
                    Dim ledLight = client.Set("PI_05_CONTROL/buzzer", "0")
                    buzzBody = buzzer.Body.Substring(1, 1)
                    ledBody = ledLight.Body.Substring(1, 1)
                    fanIcon.Image = My.Resources.fan_ventilator_propeller_rotor_motion_512
                    btnOn.Text = "ON"
                    lblTemp.Text = "Current temperature is " + ultraBody.ToString + "°C"
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        CheckForIllegalCrossThreadCalls = False
        Dim t1 As New System.Threading.Thread(AddressOf buttonClick)
        t1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = fnc_Get_NTP.ToString("yyyy/MMdd/HH/mmss")
        CheckForIllegalCrossThreadCalls = False

        Dim second As Long
        second = Convert.ToInt32(fnc_Get_NTP.ToString("ss"))
        second = second Mod (60 * 60)
        Try
            If second.Equals(0) OrElse second.Equals(10) OrElse second.Equals(20) OrElse second.Equals(30) OrElse second.Equals(40) OrElse second.Equals(50) Then
                btnOn.PerformClick()
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
        ' elapsed time (date and time) from 1900/01/01 --- 
        Dim elapsedTotalSec As Long ' elapsed seconds from 1900/01/01 --- 

        Dim Days As Long    ' days --- 
        Dim HH As Long    ' hours --- 
        Dim MM As Long    ' minutes ---
        Dim SS As Long    ' seconds --- 
        ' --- elapsed seconds from 1900/01/01 --- 
        elapsedTotalSec = CLng(
              rdat(40) * Math.Pow(2, (8 * 3)) +
              rdat(41) * Math.Pow(2, (8 * 2)) +
              rdat(42) * Math.Pow(2, (8 * 1)) +
              rdat(43))
        ' ---

        Days = elapsedTotalSec \ (24 * 60 * 60)   ' days -- 
        SS = elapsedTotalSec Mod (24 * 60 * 60) ' mod seconds --- 
        HH = SS \ (60 * 60)           ' --- 
        SS = SS Mod (60 * 60)         ' --- 
        MM = MM \ 60                  ' --- 

        ' --- convert to DateTime type --- 
        Dim dtTime As DateTime = #1900/01/01#
        dtTime = dtTime.AddDays(Days)
        dtTime = dtTime.AddHours(HH)
        dtTime = dtTime.AddMinutes(MM)
        dtTime = dtTime.AddSeconds(SS)

        dtTime = dtTime.AddHours(8)

        Return dtTime
    End Function

    Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click

    End Sub
End Class