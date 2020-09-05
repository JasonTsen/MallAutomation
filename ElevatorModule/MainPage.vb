Public Class MainPage
    Private Sub btnEscalator_Click(sender As Object, e As EventArgs) Handles btnEscalator.Click
        EscalatorSyst.Show()

    End Sub

    Private Sub btnEntrance_Click(sender As Object, e As EventArgs) Handles btnEntrance.Click
        EntranceModule.Show()
    End Sub

    Private Sub btnAircon_Click(sender As Object, e As EventArgs) Handles btnAircon.Click
        AircondModule.Show()
    End Sub

    Private Sub btnLight_Click(sender As Object, e As EventArgs) Handles btnLight.Click
        LightSenseModule.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class