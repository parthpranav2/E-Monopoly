Public Class frmRules

    Private Sub butExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExit.Click
        Close()

    End Sub

    Private Sub butMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = formWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
        End If
    End Sub

    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel5.Paint

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmHelp.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()

    End Sub

    Private Sub timEnd_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timEnd.Tick
        Close()

    End Sub

    Private Sub timEnd_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class