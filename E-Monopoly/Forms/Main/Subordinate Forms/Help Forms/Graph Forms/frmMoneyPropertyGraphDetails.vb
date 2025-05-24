Public Class frmMoneyPropertyGraphDetails
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmMoneyPropertyGraph.Show()
        Me.Close()
    End Sub

    Private Sub frmMoneyPropertyGraphDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ChartMoney.Series("MONEY").Points.Clear()
        Me.ChartProperty.Series("PROPERTY").Points.Clear()
        Me.ChartHouse.Series("HOUSE").Points.Clear()
        Me.ChartHotel.Series("HOTEL").Points.Clear()

        If My.Settings.NoofPlayers = 2 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2hotel.Text)

        ElseIf My.Settings.NoofPlayers = 3 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3hotel.Text)

        ElseIf My.Settings.NoofPlayers = 4 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4hotel.Text)

        ElseIf My.Settings.NoofPlayers = 5 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4hotel.Text)


            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5hotel.Text)

        ElseIf My.Settings.NoofPlayers = 6 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4hotel.Text)


            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6hotel.Text)

        ElseIf My.Settings.NoofPlayers = 7 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4hotel.Text)


            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7hotel.Text)

        ElseIf My.Settings.NoofPlayers = 8 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4hotel.Text)


            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp8.Text, EMonopoly.lblp8cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp8.Text, EMonopoly.lblp8property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp8.Text, EMonopoly.lblp8house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp8.Text, EMonopoly.lblp8hotel.Text)
        Else
        End If
    End Sub
    Private Sub Refresh()
        Me.ChartMoney.Series("MONEY").Points.Clear()
        Me.ChartProperty.Series("PROPERTY").Points.Clear()
        Me.ChartHouse.Series("HOUSE").Points.Clear()
        Me.ChartHotel.Series("HOTEL").Points.Clear()

        If My.Settings.NoofPlayers = 2 Then
            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2hotel.Text)

        ElseIf My.Settings.NoofPlayers = 3 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3hotel.Text)

        ElseIf My.Settings.NoofPlayers = 4 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4hotel.Text)

        ElseIf My.Settings.NoofPlayers = 5 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4hotel.Text)


            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5hotel.Text)

        ElseIf My.Settings.NoofPlayers = 6 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4hotel.Text)


            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6hotel.Text)

        ElseIf My.Settings.NoofPlayers = 7 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4hotel.Text)


            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7hotel.Text)

        ElseIf My.Settings.NoofPlayers = 8 Then

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp1.Text, EMonopoly.lblp1hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp2.Text, EMonopoly.lblp2hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp3.Text, EMonopoly.lblp3hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp4.Text, EMonopoly.lblp4hotel.Text)


            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp5.Text, EMonopoly.lblp5hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp6.Text, EMonopoly.lblp6hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp7.Text, EMonopoly.lblp7hotel.Text)

            Me.ChartMoney.Series("MONEY").Points.AddXY("" + EMonopoly.lblp8.Text, EMonopoly.lblp8cost.Text)
            Me.ChartProperty.Series("PROPERTY").Points.AddXY("" + EMonopoly.lblp8.Text, EMonopoly.lblp8property.Text)
            Me.ChartHouse.Series("HOUSE").Points.AddXY("" + EMonopoly.lblp8.Text, EMonopoly.lblp8house.Text)
            Me.ChartHotel.Series("HOTEL").Points.AddXY("" + EMonopoly.lblp8.Text, EMonopoly.lblp8hotel.Text)
        Else
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Refresh()
    End Sub

    Private Sub ChartHouse_Click(sender As Object, e As EventArgs) Handles ChartHouse.Click

    End Sub

    Private Sub ChartProperty_Click(sender As Object, e As EventArgs) Handles ChartProperty.Click

    End Sub
End Class