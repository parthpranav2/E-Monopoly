Public Class frmWelcome
    'Timing of Theme
    Dim starttime As Integer = 6
    Dim endtime As Integer = 18

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        frmGameModeSelector.Show()
        Timer1.Enabled = False
        Me.Hide()
    End Sub

    Private Sub Welcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ThemeApplier()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Public Sub ThemeApplier()
        'Auto Theme
        If My.Settings.Theme = Val(0) Then
            If Date.Now.Hour > starttime And Date.Now.Hour < endtime Then
                EMonopoly.pbIcon.Image = My.Resources.IconM

                EMonopoly.LinkLabel1.LinkColor = Color.Blue

                EMonopoly.BackColor = Color.White
                EMonopoly.Panel1.BackColor = Color.MediumTurquoise
                EMonopoly.Panel2.BackColor = Color.Gold
                EMonopoly.Panel3.BackColor = Color.HotPink
                EMonopoly.Panel4.BackColor = Color.HotPink
                EMonopoly.Label2.ForeColor = Color.Purple

                EMonopoly.CheckedListBoxPN.BackColor = Color.White
                EMonopoly.CheckedListBoxPN.ForeColor = Color.Black

                EMonopoly.butaddp1.ForeColor = Color.Black
                EMonopoly.butaddp2.ForeColor = Color.Black
                EMonopoly.butaddp3.ForeColor = Color.Black
                EMonopoly.butaddp4.ForeColor = Color.Black
                EMonopoly.butaddp5.ForeColor = Color.Black
                EMonopoly.butaddp6.ForeColor = Color.Black
                EMonopoly.butaddp7.ForeColor = Color.Black
                EMonopoly.butaddp8.ForeColor = Color.Black

                EMonopoly.butsubp1.ForeColor = Color.Black
                EMonopoly.butsubp2.ForeColor = Color.Black
                EMonopoly.butsubp3.ForeColor = Color.Black
                EMonopoly.butsubp4.ForeColor = Color.Black
                EMonopoly.butsubp5.ForeColor = Color.Black
                EMonopoly.butsubp6.ForeColor = Color.Black
                EMonopoly.butsubp7.ForeColor = Color.Black
                EMonopoly.butsubp8.ForeColor = Color.Black

                EMonopoly.butanotherp1.ForeColor = Color.Black
                EMonopoly.butanotherp2.ForeColor = Color.Black
                EMonopoly.butanotherp3.ForeColor = Color.Black
                EMonopoly.butanotherp4.ForeColor = Color.Black
                EMonopoly.butanotherp5.ForeColor = Color.Black
                EMonopoly.butanotherp6.ForeColor = Color.Black
                EMonopoly.butanotherp7.ForeColor = Color.Black
                EMonopoly.butanotherp8.ForeColor = Color.Black

                EMonopoly.lblp1property.ForeColor = Color.Black
                EMonopoly.lblp2property.ForeColor = Color.Black
                EMonopoly.lblp3property.ForeColor = Color.Black
                EMonopoly.lblp4property.ForeColor = Color.Black
                EMonopoly.lblp5property.ForeColor = Color.Black
                EMonopoly.lblp6property.ForeColor = Color.Black
                EMonopoly.lblp7property.ForeColor = Color.Black
                EMonopoly.lblp8property.ForeColor = Color.Black

                EMonopoly.lblp1house.ForeColor = Color.Black
                EMonopoly.lblp2house.ForeColor = Color.Black
                EMonopoly.lblp3house.ForeColor = Color.Black
                EMonopoly.lblp4house.ForeColor = Color.Black
                EMonopoly.lblp5house.ForeColor = Color.Black
                EMonopoly.lblp6house.ForeColor = Color.Black
                EMonopoly.lblp7house.ForeColor = Color.Black
                EMonopoly.lblp8house.ForeColor = Color.Black

                EMonopoly.lblp1hotel.ForeColor = Color.Black
                EMonopoly.lblp2hotel.ForeColor = Color.Black
                EMonopoly.lblp3hotel.ForeColor = Color.Black
                EMonopoly.lblp4hotel.ForeColor = Color.Black
                EMonopoly.lblp5hotel.ForeColor = Color.Black
                EMonopoly.lblp6hotel.ForeColor = Color.Black
                EMonopoly.lblp7hotel.ForeColor = Color.Black
                EMonopoly.lblp8hotel.ForeColor = Color.Black

                EMonopoly.lblBank.ForeColor = Color.Black
                EMonopoly.Label14.ForeColor = Color.Black
                EMonopoly.lblBankCost.ForeColor = Color.Black
                EMonopoly.lblproperties.ForeColor = Color.Black
                EMonopoly.lblPropertiesLeft.ForeColor = Color.Black
                EMonopoly.lblhouses.ForeColor = Color.Black
                EMonopoly.lblHousesLeft.ForeColor = Color.Black
                EMonopoly.lblhotels.ForeColor = Color.Black
                EMonopoly.lblHotelLeft.ForeColor = Color.Black

                EMonopoly.Label12.ForeColor = Color.Black
                EMonopoly.Label6.ForeColor = Color.Black
                EMonopoly.Label7.ForeColor = Color.Black
                EMonopoly.Label9.ForeColor = Color.Black
                EMonopoly.Label8.ForeColor = Color.Black
                EMonopoly.Label10.ForeColor = Color.Black
                EMonopoly.Label11.ForeColor = Color.Black

                EMonopoly.lblp1.ForeColor = Color.Black
                EMonopoly.lblp2.ForeColor = Color.Black
                EMonopoly.lblp3.ForeColor = Color.Black
                EMonopoly.lblp4.ForeColor = Color.Black
                EMonopoly.lblp5.ForeColor = Color.Black
                EMonopoly.lblp6.ForeColor = Color.Black
                EMonopoly.lblp7.ForeColor = Color.Black
                EMonopoly.lblp8.ForeColor = Color.Black

                EMonopoly.lblp1Currency.ForeColor = Color.Black
                EMonopoly.lblp2Currency.ForeColor = Color.Black
                EMonopoly.lblp3Currency.ForeColor = Color.Black
                EMonopoly.lblp4Currency.ForeColor = Color.Black
                EMonopoly.lblp5Currency.ForeColor = Color.Black
                EMonopoly.lblp6Currency.ForeColor = Color.Black
                EMonopoly.lblp7Currency.ForeColor = Color.Black
                EMonopoly.lblp8Currency.ForeColor = Color.Black

                EMonopoly.lblp1cost.ForeColor = Color.Black
                EMonopoly.lblp2cost.ForeColor = Color.Black
                EMonopoly.lblp3cost.ForeColor = Color.Black
                EMonopoly.lblp4cost.ForeColor = Color.Black
                EMonopoly.lblp5cost.ForeColor = Color.Black
                EMonopoly.lblp6cost.ForeColor = Color.Black
                EMonopoly.lblp7cost.ForeColor = Color.Black
                EMonopoly.lblp8cost.ForeColor = Color.Black

                EMonopoly.Label5.ForeColor = Color.Black

                EMonopoly.butRollDie.ForeColor = Color.Black

                EMonopoly.lblIConnection.ForeColor = Color.Black

                EMonopoly.pnladdp1.BackColor = Color.Red
                EMonopoly.pnladdp2.BackColor = Color.Red
                EMonopoly.pnladdp3.BackColor = Color.Red
                EMonopoly.pnladdp4.BackColor = Color.Red
                EMonopoly.pnladdp5.BackColor = Color.Red
                EMonopoly.pnladdp6.BackColor = Color.Red
                EMonopoly.pnladdp7.BackColor = Color.Red
                EMonopoly.pnladdp8.BackColor = Color.Red

                EMonopoly.pnlsubp1.BackColor = Color.Red
                EMonopoly.pnlsubp2.BackColor = Color.Red
                EMonopoly.pnlsubp3.BackColor = Color.Red
                EMonopoly.pnlsubp4.BackColor = Color.Red
                EMonopoly.pnlsubp5.BackColor = Color.Red
                EMonopoly.pnlsubp6.BackColor = Color.Red
                EMonopoly.pnlsubp7.BackColor = Color.Red
                EMonopoly.pnlsubp8.BackColor = Color.Red

                EMonopoly.pnlanotherp1.BackColor = Color.Red
                EMonopoly.pnlanotherp2.BackColor = Color.Red
                EMonopoly.pnlanotherp3.BackColor = Color.Red
                EMonopoly.pnlanotherp4.BackColor = Color.Red
                EMonopoly.pnlanotherp5.BackColor = Color.Red
                EMonopoly.pnlanotherp6.BackColor = Color.Red
                EMonopoly.pnlanotherp7.BackColor = Color.Red
                EMonopoly.pnlanotherp8.BackColor = Color.Red

                EMonopoly.Panel10.BackColor = Color.Green
                EMonopoly.Panel7.BackColor = Color.Green
                EMonopoly.Panel8.BackColor = Color.Green

            Else
                EMonopoly.pbIcon.Image = My.Resources.IconN
            End If
        End If

        'Customize theme
        If My.Settings.Theme = Val(1) Then   'light
            EMonopoly.pbIcon.Image = My.Resources.IconM

            EMonopoly.LinkLabel1.LinkColor = Color.Blue

            EMonopoly.BackColor = Color.White
            EMonopoly.Panel1.BackColor = Color.MediumTurquoise
            EMonopoly.Panel2.BackColor = Color.Gold
            EMonopoly.Panel3.BackColor = Color.HotPink
            EMonopoly.Panel4.BackColor = Color.HotPink
            EMonopoly.Label2.ForeColor = Color.Purple

            EMonopoly.CheckedListBoxPN.BackColor = Color.White
            EMonopoly.CheckedListBoxPN.ForeColor = Color.Black

            EMonopoly.butaddp1.ForeColor = Color.Black
            EMonopoly.butaddp2.ForeColor = Color.Black
            EMonopoly.butaddp3.ForeColor = Color.Black
            EMonopoly.butaddp4.ForeColor = Color.Black
            EMonopoly.butaddp5.ForeColor = Color.Black
            EMonopoly.butaddp6.ForeColor = Color.Black
            EMonopoly.butaddp7.ForeColor = Color.Black
            EMonopoly.butaddp8.ForeColor = Color.Black

            EMonopoly.butsubp1.ForeColor = Color.Black
            EMonopoly.butsubp2.ForeColor = Color.Black
            EMonopoly.butsubp3.ForeColor = Color.Black
            EMonopoly.butsubp4.ForeColor = Color.Black
            EMonopoly.butsubp5.ForeColor = Color.Black
            EMonopoly.butsubp6.ForeColor = Color.Black
            EMonopoly.butsubp7.ForeColor = Color.Black
            EMonopoly.butsubp8.ForeColor = Color.Black

            EMonopoly.butanotherp1.ForeColor = Color.Black
            EMonopoly.butanotherp2.ForeColor = Color.Black
            EMonopoly.butanotherp3.ForeColor = Color.Black
            EMonopoly.butanotherp4.ForeColor = Color.Black
            EMonopoly.butanotherp5.ForeColor = Color.Black
            EMonopoly.butanotherp6.ForeColor = Color.Black
            EMonopoly.butanotherp7.ForeColor = Color.Black
            EMonopoly.butanotherp8.ForeColor = Color.Black

            EMonopoly.lblp1property.ForeColor = Color.Black
            EMonopoly.lblp2property.ForeColor = Color.Black
            EMonopoly.lblp3property.ForeColor = Color.Black
            EMonopoly.lblp4property.ForeColor = Color.Black
            EMonopoly.lblp5property.ForeColor = Color.Black
            EMonopoly.lblp6property.ForeColor = Color.Black
            EMonopoly.lblp7property.ForeColor = Color.Black
            EMonopoly.lblp8property.ForeColor = Color.Black

            EMonopoly.lblp1house.ForeColor = Color.Black
            EMonopoly.lblp2house.ForeColor = Color.Black
            EMonopoly.lblp3house.ForeColor = Color.Black
            EMonopoly.lblp4house.ForeColor = Color.Black
            EMonopoly.lblp5house.ForeColor = Color.Black
            EMonopoly.lblp6house.ForeColor = Color.Black
            EMonopoly.lblp7house.ForeColor = Color.Black
            EMonopoly.lblp8house.ForeColor = Color.Black

            EMonopoly.lblp1hotel.ForeColor = Color.Black
            EMonopoly.lblp2hotel.ForeColor = Color.Black
            EMonopoly.lblp3hotel.ForeColor = Color.Black
            EMonopoly.lblp4hotel.ForeColor = Color.Black
            EMonopoly.lblp5hotel.ForeColor = Color.Black
            EMonopoly.lblp6hotel.ForeColor = Color.Black
            EMonopoly.lblp7hotel.ForeColor = Color.Black
            EMonopoly.lblp8hotel.ForeColor = Color.Black

            EMonopoly.lblBank.ForeColor = Color.Black
            EMonopoly.Label14.ForeColor = Color.Black
            EMonopoly.lblBankCost.ForeColor = Color.Black
            EMonopoly.lblproperties.ForeColor = Color.Black
            EMonopoly.lblPropertiesLeft.ForeColor = Color.Black
            EMonopoly.lblhouses.ForeColor = Color.Black
            EMonopoly.lblHousesLeft.ForeColor = Color.Black
            EMonopoly.lblhotels.ForeColor = Color.Black
            EMonopoly.lblHotelLeft.ForeColor = Color.Black

            EMonopoly.Label12.ForeColor = Color.Black
            EMonopoly.Label6.ForeColor = Color.Black
            EMonopoly.Label7.ForeColor = Color.Black
            EMonopoly.Label9.ForeColor = Color.Black
            EMonopoly.Label8.ForeColor = Color.Black
            EMonopoly.Label10.ForeColor = Color.Black
            EMonopoly.Label11.ForeColor = Color.Black

            EMonopoly.lblp1.ForeColor = Color.Black
            EMonopoly.lblp2.ForeColor = Color.Black
            EMonopoly.lblp3.ForeColor = Color.Black
            EMonopoly.lblp4.ForeColor = Color.Black
            EMonopoly.lblp5.ForeColor = Color.Black
            EMonopoly.lblp6.ForeColor = Color.Black
            EMonopoly.lblp7.ForeColor = Color.Black
            EMonopoly.lblp8.ForeColor = Color.Black

            EMonopoly.lblp1Currency.ForeColor = Color.Black
            EMonopoly.lblp2Currency.ForeColor = Color.Black
            EMonopoly.lblp3Currency.ForeColor = Color.Black
            EMonopoly.lblp4Currency.ForeColor = Color.Black
            EMonopoly.lblp5Currency.ForeColor = Color.Black
            EMonopoly.lblp6Currency.ForeColor = Color.Black
            EMonopoly.lblp7Currency.ForeColor = Color.Black
            EMonopoly.lblp8Currency.ForeColor = Color.Black

            EMonopoly.lblp1cost.ForeColor = Color.Black
            EMonopoly.lblp2cost.ForeColor = Color.Black
            EMonopoly.lblp3cost.ForeColor = Color.Black
            EMonopoly.lblp4cost.ForeColor = Color.Black
            EMonopoly.lblp5cost.ForeColor = Color.Black
            EMonopoly.lblp6cost.ForeColor = Color.Black
            EMonopoly.lblp7cost.ForeColor = Color.Black
            EMonopoly.lblp8cost.ForeColor = Color.Black

            EMonopoly.Label5.ForeColor = Color.Black

            EMonopoly.butRollDie.ForeColor = Color.Black

            EMonopoly.lblIConnection.ForeColor = Color.Black

            EMonopoly.pnladdp1.BackColor = Color.Red
            EMonopoly.pnladdp2.BackColor = Color.Red
            EMonopoly.pnladdp3.BackColor = Color.Red
            EMonopoly.pnladdp4.BackColor = Color.Red
            EMonopoly.pnladdp5.BackColor = Color.Red
            EMonopoly.pnladdp6.BackColor = Color.Red
            EMonopoly.pnladdp7.BackColor = Color.Red
            EMonopoly.pnladdp8.BackColor = Color.Red

            EMonopoly.pnlsubp1.BackColor = Color.Red
            EMonopoly.pnlsubp2.BackColor = Color.Red
            EMonopoly.pnlsubp3.BackColor = Color.Red
            EMonopoly.pnlsubp4.BackColor = Color.Red
            EMonopoly.pnlsubp5.BackColor = Color.Red
            EMonopoly.pnlsubp6.BackColor = Color.Red
            EMonopoly.pnlsubp7.BackColor = Color.Red
            EMonopoly.pnlsubp8.BackColor = Color.Red

            EMonopoly.pnlanotherp1.BackColor = Color.Red
            EMonopoly.pnlanotherp2.BackColor = Color.Red
            EMonopoly.pnlanotherp3.BackColor = Color.Red
            EMonopoly.pnlanotherp4.BackColor = Color.Red
            EMonopoly.pnlanotherp5.BackColor = Color.Red
            EMonopoly.pnlanotherp6.BackColor = Color.Red
            EMonopoly.pnlanotherp7.BackColor = Color.Red
            EMonopoly.pnlanotherp8.BackColor = Color.Red

            EMonopoly.Panel10.BackColor = Color.Green
            EMonopoly.Panel7.BackColor = Color.Green
            EMonopoly.Panel8.BackColor = Color.Green


            starttime = Val(0)
            endtime = Val(23)

        ElseIf My.Settings.Theme = Val(2) Then 'dark
            EMonopoly.pbIcon.Image = My.Resources.IconN
            starttime = Val(0)
            endtime = Val(0)
        End If
    End Sub
End Class