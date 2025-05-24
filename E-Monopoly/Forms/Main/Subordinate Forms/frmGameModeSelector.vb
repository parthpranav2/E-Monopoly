Public Class frmGameModeSelector
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblGMSRGHistory.Text = 0
        EMonopoly.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblGMSRGHistory.Text = 1
        Me.Hide()

        frmPlayerHistory.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblGMSRGHistory.Text = 2
        Me.Hide()

        frmPlayerHistory.Show()
    End Sub

    Private Sub frmGameModeSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub butExit_Click(sender As Object, e As EventArgs) Handles butExit.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lblGMSRGHistory.Text = 3
        Me.Hide()
        frmSettings.Show()
    End Sub
End Class