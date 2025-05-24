Public Class frmUnbiarcedDice
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmHelp.Show()
        Me.Close()
    End Sub

    Private Sub butExit_Click(sender As Object, e As EventArgs) Handles butExit.Click
        Close()
    End Sub

    Private Sub butMaximize_Click(sender As Object, e As EventArgs) Handles butMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
        End If
    End Sub

    Private Sub butRollDie_Click(sender As Object, e As EventArgs) Handles butRollDie.Click
        tmrTimer.Start()

        butRollDie.Enabled = False
    End Sub
    Dim random As Random
    Dim dicetotal As Integer
    Dim gamedicetotal As Integer
    Dim gamedicetotalA As Integer
    Dim dice1, dice2 As Integer

    Private Sub frmUnbiarcedDice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
    End Sub

    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        random = New Random
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            tmrTimer.Stop()
            dicetotal = dice1 + dice2
            ListBox1.Items.Add(dice1 & ", " & dice2 & "; " & dicetotal)

            gamedicetotalA = gamedicetotal
            gamedicetotal = dicetotal + gamedicetotalA
            butRollDie.Enabled = True
            ProgressBar1.Value = 0
        Else
            dice1 = random.Next(1, 7)
            dice2 = random.Next(1, 7)

            If dice1 = 1 Then
                PictureBox7.Image = My.Resources._1
            ElseIf dice1 = 2 Then
                PictureBox7.Image = My.Resources._2
            ElseIf dice1 = 3 Then
                PictureBox7.Image = My.Resources._3
            ElseIf dice1 = 4 Then
                PictureBox7.Image = My.Resources._4
            ElseIf dice1 = 5 Then
                PictureBox7.Image = My.Resources._5
            ElseIf dice1 = 6 Then
                PictureBox7.Image = My.Resources._6
            End If

            If dice2 = 1 Then
                PictureBox8.Image = My.Resources._1
            ElseIf dice2 = 2 Then
                PictureBox8.Image = My.Resources._2
            ElseIf dice2 = 3 Then
                PictureBox8.Image = My.Resources._3
            ElseIf dice2 = 4 Then
                PictureBox8.Image = My.Resources._4
            ElseIf dice2 = 5 Then
                PictureBox8.Image = My.Resources._5
            ElseIf dice2 = 6 Then
                PictureBox8.Image = My.Resources._6
            End If

        End If

    End Sub
End Class