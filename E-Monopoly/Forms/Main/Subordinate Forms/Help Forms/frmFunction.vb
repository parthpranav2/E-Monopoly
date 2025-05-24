Public Class frmFunction

    Private Sub butExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExit.Click
        Close()

    End Sub

    Private Sub butMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = formWindowState.Normal

        ElseIf Me.WindowState = formWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized

        Else
        End If
    End Sub

    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub butp1addproperty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butp1addproperty.Click
        MsgBox("This button helps you to add the following things" + vbNewLine + vbNewLine & "1. Add Property" + vbNewLine & "2. Add House" + vbNewLine & "3. Add Hotel")
    End Sub

    Private Sub frmFunction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.MusicSite = "Amazon Music" Then
            Button4.Image = My.Resources.icons8_amazon_music_30
        End If
        If My.Settings.MusicSite = "Google Play Music" Then
            Button4.Image = My.Resources.icons8_google_play_music_30
        End If
        If My.Settings.MusicSite = "Ganna" Then
            Button4.Image = My.Resources.Gana
        End If
        If My.Settings.MusicSite = "Hungama" Then
            Button4.Image = My.Resources.Hungama
        End If
        If My.Settings.MusicSite = "Jio Savan" Then
            Button4.Image = My.Resources.JioSavan
        End If
        If My.Settings.MusicSite = "Wynk" Then
            Button4.Image = My.Resources.Wyink
        End If
    End Sub

    Private Sub butp1subproperty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butp1subproperty.Click
        MsgBox("This button helps you to deduct the following things" + vbNewLine + vbNewLine & "1. Deduct Property" + vbNewLine & "2. Deduct House" + vbNewLine & "3. Deduct Hotel")

    End Sub

    Private Sub butaddp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butaddp1.Click
        MsgBox("This button will add money to your account")
    End Sub

    Private Sub butsubp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butsubp1.Click
        MsgBox("This button will deduct money from your account")
    End Sub

    Private Sub butanotherp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butanotherp1.Click
        MsgBox("This button will help you to add money to others playesr's account")
    End Sub

    Private Sub butround_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butround.Click
        MsgBox("This button will add round complition reward to your account")
    End Sub

    Private Sub butjail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butjail.Click
        MsgBox("This button will cutt money from the players account who has visited a jail")
    End Sub

    Private Sub butsupertax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butsupertax.Click
        MsgBox("This button will deduct the Income Tax from your account")
    End Sub

    Private Sub butloan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butloan.Click
        MsgBox("This button will enable you to take loans from the bank")
    End Sub

    Private Sub butloandew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butloandew.Click
        MsgBox("This button will enable you to pay loan dews of your account")
    End Sub

    Private Sub butincometax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butincometax.Click
        MsgBox("This button will deduct the Super Tax from your account")
    End Sub

    Private Sub lblcheckdews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcheckdews.Click
        MsgBox("This button will help you to check dews in your account")
    End Sub

    Private Sub timEnd_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timEnd.Tick
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmHelp.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("This button helps you to roll a virtal dice.")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("This button will help you to play music online or on dekstop")
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class