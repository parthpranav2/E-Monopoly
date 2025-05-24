Public Class frmHelp

    Dim Currency As String = "£"
    Dim pc As Integer = "1748"

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

    Private Sub butRules_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRules.Click
        frmRules.Show()
        Close()
    End Sub

    Private Sub timEnd_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub butFunctions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butFunctions.Click
        frmFunction.Show()
        Close()
    End Sub

    Private Sub frmHelp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.DeluxeAssurance = true Then
            Button1.Visible = True
        Else
            Button1.Visible = False
        End If

    End Sub

    Private Sub butRules_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRules.MouseEnter
        Panel3.Visible = True
    End Sub

    Private Sub butRules_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles butRules.MouseLeave
        Panel3.Visible = False
    End Sub

    Private Sub butFunctions_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butFunctions.MouseEnter
        Panel4.Visible = True
    End Sub

    Private Sub butFunctions_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles butFunctions.MouseLeave
        Panel4.Visible = False
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

   
    Private Sub Button3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter
        Panel8.Visible = True
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Panel8.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmAboutUs.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmPropertytreeview.Show()
        Me.Hide()
    End Sub

    Private Sub Panel6_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.MouseEnter

    End Sub

    Private Sub Panel6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel6.MouseLeave

    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Panel6.Visible = True
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Panel6.Visible = False
    End Sub

    Private Sub frmHelp_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter

    End Sub

    Private Sub frmHelp_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover

    End Sub

    Private Sub frmHelp_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave

    End Sub

    Private Sub butSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSetting.Click
        frmSettings.Show()
        Me.Hide()
    End Sub

    Private Sub butSetting_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles butSetting.MouseEnter
        Panel7.Visible = True
    End Sub

    Private Sub butSetting_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles butSetting.MouseLeave
        Panel7.Visible = False
    End Sub

    Private Sub Button2_MouseEnter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Panel9.Visible = True
    End Sub

    Private Sub Button2_MouseLeave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Panel9.Visible = False
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Application.Log.DefaultFileLogWriter.Close()
        frmPlayerHistory.Show()
        Me.Close()
    End Sub

    Private Sub Panel7_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmScaling.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint

    End Sub

    Private Sub butMPG_Click(sender As Object, e As EventArgs) Handles butMPG.Click
        frmMoneyPropertyGraph.Show()
        Me.Close()
    End Sub

    Private Sub butMPG_MouseEnter(sender As Object, e As EventArgs) Handles butMPG.MouseEnter
        Panel10.Visible = True
    End Sub

    Private Sub butMPG_MouseLeave(sender As Object, e As EventArgs) Handles butMPG.MouseLeave
        Panel10.Visible = False
    End Sub

    Private Sub ButPInfo_MouseEnter(sender As Object, e As EventArgs) Handles ButPInfo.MouseEnter
        Panel11.Visible = True
    End Sub

    Private Sub ButPInfo_MouseLeave(sender As Object, e As EventArgs) Handles ButPInfo.MouseLeave
        Panel11.Visible = False
    End Sub

    Private Sub ButPInfo_Click(sender As Object, e As EventArgs) Handles ButPInfo.Click
        frmPlayerInfo.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        frmUnbiarcedDice.Show()
        Me.Close()
    End Sub
End Class