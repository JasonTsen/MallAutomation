Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Microsoft.VisualBasic.ApplicationServices
Imports FireSharp.Extensions
Imports Newtonsoft.Json
Imports System.Globalization

Public Class Entrance_Module
    Private Sub Entrance_Module_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Try
            client = New FireSharp.FirebaseClient(fcon)
            fnc_Get_NTP()
            'btnStart.PerformClick()
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
        Dim res = client.Get("PI_05_" + fnc_Get_NTP().ToString("yyyyMMd/HH/mmss") + "/ultra2")

        Try
            Dim tempUltra = New With {Key .Body = ""}
            Dim Body As String

            If res.Body.Length <= 4 Then
                Body = res.Body.Substring(1, 1)
            Else
                Body = res.Body.Substring(1, 2)
            End If
            Dim ultra As Double = Convert.ToInt32(Body)
            Label1.Text = "Ultra: " + Body.ToString
            If ultra > 55 Then
                Dim buzz = client.Set("PI_05_CONTROL/buzzer", "1")

                Body = buzz.Body.Substring(1, 1)

                Dim buzzer As Integer = Convert.ToInt32(Body)
                lblTemp.Text = "Buzzer: " + Body.ToString
            Else
                Dim buzz = client.Set("PI_05_CONTROL/buzzer", "0")
                Dim tempBuzz = New With {Key .Body = ""}

                Body = buzz.Body.Substring(1, 1)

                Dim buzzer As Integer = Convert.ToInt32(Body)
                lblTemp.Text = "Buzzer: " + Body.ToString
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

        dtTime = dtTime.AddHours(8) ' <<-- * please modify (n) according to your location *
        ' current time zone is GMT(+8)
        Return dtTime
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = "Current Time:" + "   " + DateTime.Now.ToString("MMMM dd, yyyy   HH:mm:ss")
    End Sub

End Class

