Public Class frmMoneyPropertyGraph
    Private Sub butExit_Click(sender As Object, e As EventArgs) Handles butExit.Click
        EMonopoly.Show()
        Me.Hide()
    End Sub

    Private Sub butMaximize_Click(sender As Object, e As EventArgs) Handles butMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized

        Else
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmHelp.Show()
        Me.Hide()
    End Sub
    Private Sub Refresh()
        Me.ChartMoney.Series("MONEY").Points.Clear()
        Me.Chartproperty.Series("PROPERTY").Points.Clear()
        If My.Settings.NoofPlayers = 2 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)

        ElseIf My.Settings.NoofPlayers = 3 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)

        ElseIf My.Settings.NoofPlayers = 4 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)

        ElseIf My.Settings.NoofPlayers = 5 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5property.Text)

        ElseIf My.Settings.NoofPlayers = 6 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6property.Text)

        ElseIf My.Settings.NoofPlayers = 7 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7property.Text)

        ElseIf My.Settings.NoofPlayers = 8 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp8.Text, EMonopoly.lblp8cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp8.Text, EMonopoly.lblp8property.Text)
        Else
        End If
    End Sub

    Private Sub frmMoneyPropertyGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ChartMoney.Series("MONEY").Points.Clear()
        Me.Chartproperty.Series("PROPERTY").Points.Clear()

        If My.Settings.NoofPlayers = 2 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)

        ElseIf My.Settings.NoofPlayers = 3 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)

        ElseIf My.Settings.NoofPlayers = 4 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)

        ElseIf My.Settings.NoofPlayers = 5 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5property.Text)

        ElseIf My.Settings.NoofPlayers = 6 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6property.Text)

        ElseIf My.Settings.NoofPlayers = 7 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7property.Text)

        ElseIf My.Settings.NoofPlayers = 8 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7property.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp8.Text, EMonopoly.lblp8cost.Text)
            Me.Chartproperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp8.Text, EMonopoly.lblp8property.Text)
        Else
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmMoneyPropertyGraphDetails.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChartMoney_Click(sender As Object, e As EventArgs) Handles ChartMoney.Click

    End Sub

    Private Sub butRefresh_Click(sender As Object, e As EventArgs) Handles butRefresh.Click
        Refresh()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class