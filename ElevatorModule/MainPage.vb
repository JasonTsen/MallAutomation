﻿Public Class MainPage
    'Private Sub btnEscalator_Click(sender As Object, e As EventArgs)
    '    EscalatorSyst.Show()

    'End Sub

    'Private Sub btnEntrance_Click(sender As Object, e As EventArgs)
    '    EntranceModule.Show()
    'End Sub

    'Private Sub btnAircon_Click(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub btnLight_Click(sender As Object, e As EventArgs)
    '    LightSenseModule.Show()
    'End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnEntrance_Click(sender As Object, e As EventArgs) Handles btnEntrance.Click
        EntranceModule.Show()
    End Sub

    Private Sub btnEscalator_Click(sender As Object, e As EventArgs) Handles btnEscalator.Click
        EscalatorSyst.Show()
    End Sub

    Private Sub btnLight_Click(sender As Object, e As EventArgs) Handles btnLight.Click
        LightSenseModule.Show()
    End Sub

    Private Sub btnAircon_Click(sender As Object, e As EventArgs) Handles btnAircon.Click

    End Sub
End Class