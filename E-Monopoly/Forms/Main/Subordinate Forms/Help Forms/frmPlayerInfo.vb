
Public Class frmPlayerInfo
    Private Sub butExit_Click(sender As Object, e As EventArgs) Handles butExit.Click
        Close()
    End Sub

    Private Sub butMaximize_Click(sender As Object, e As EventArgs)
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized

        Else
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        frmHelp.Show()
        Me.Close()
    End Sub

    Private Sub frmPlayerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.DeluxeAssurance = False Then
            PictureBoxPrimary.Visible = False
            ListBoxPrimary.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Label7.Visible = False
            Label9.Visible = False
            Label10.Visible = False
            Label11.Visible = False
            Label16.Visible = False
            Label21.Visible = False
        ElseIf My.Settings.DeluxeAssurance = True Then
            PictureBoxPrimary.Visible = True
            ListBoxPrimary.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Label7.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            Label11.Visible = True
            Label16.Visible = True
            Label21.Visible = True
        Else
        End If

        If My.Settings.NoofPlayers = 2 Then
            P1Activation()
            P2Activation()
        ElseIf My.Settings.NoofPlayers = 3 Then
            P1Activation()
            P2Activation()
            P3Activation()
        ElseIf My.Settings.NoofPlayers = 4 Then
            P1Activation()
            P2Activation()
            P3Activation()
            P4Activation()
        ElseIf My.Settings.NoofPlayers = 5 Then
            P1Activation()
            P2Activation()
            P3Activation()
            P4Activation()
            P5Activation()
        ElseIf My.Settings.NoofPlayers = 6 Then
            P1Activation()
            P2Activation()
            P3Activation()
            P4Activation()
            P5Activation()
            P6Activation()
        ElseIf My.Settings.NoofPlayers = 7 Then
            P1Activation()
            P2Activation()
            P3Activation()
            P4Activation()
            P5Activation()
            P6Activation()
            P7Activation()
        ElseIf My.Settings.NoofPlayers = 8 Then
            P1Activation()
            P2Activation()
            P3Activation()
            P4Activation()
            P5Activation()
            P6Activation()
            P7Activation()
            P8Activation()
        End If
    End Sub
    Private Sub P1Activation()
        butP1.Text = EMonopoly.lblp1.Text

        butP1.Visible = True
    End Sub
    Private Sub P2Activation()
        butP2.Text = EMonopoly.lblp2.Text

        butP2.Visible = True
    End Sub
    Private Sub P3Activation()
        butP3.Text = EMonopoly.lblp3.Text

        butP3.Visible = True
    End Sub
    Private Sub P4Activation()
        butP4.Text = EMonopoly.lblp4.Text

        butP4.Visible = True
    End Sub
    Private Sub P5Activation()
        butP5.Text = EMonopoly.lblp5.Text

        butP5.Visible = True
    End Sub
    Private Sub P6Activation()
        butP6.Text = EMonopoly.lblp6.Text

        butP6.Visible = True
    End Sub
    Private Sub P7Activation()
        butP7.Text = EMonopoly.lblp7.Text

        butP7.Visible = True
    End Sub
    Private Sub P8Activation()
        butP8.Text = EMonopoly.lblp8.Text

        butP8.Visible = True
    End Sub

    Private Sub butP1_Click(sender As Object, e As EventArgs) Handles butP1.Click
        P1Show()
    End Sub

    Private Sub butP2_Click(sender As Object, e As EventArgs) Handles butP2.Click
        P2Show()
    End Sub

    Private Sub butP3_Click(sender As Object, e As EventArgs) Handles butP3.Click
        P3Show()
    End Sub

    Private Sub butP4_Click(sender As Object, e As EventArgs) Handles butP4.Click
        P4Show()
    End Sub

    Private Sub butP5_Click(sender As Object, e As EventArgs) Handles butP5.Click
        P5Show()
    End Sub

    Private Sub butP6_Click(sender As Object, e As EventArgs) Handles butP6.Click
        P6Show()
    End Sub

    Private Sub butP7_Click(sender As Object, e As EventArgs) Handles butP7.Click
        P7Show()
    End Sub

    Private Sub butP8_Click(sender As Object, e As EventArgs) Handles butP8.Click
        P8Show()
    End Sub



    Private Sub P1Load()
        lblp1n.Text = EMonopoly.lblp1.Text

        If My.Settings.Player1Icon = "Hat" Then
            PictureBox1.Image = My.Resources.icons8_hat_100
        ElseIf My.Settings.Player1Icon = "Iron" Then
            PictureBox1.Image = My.Resources.icons8_iron_100
        ElseIf My.Settings.Player1Icon = "Carriage" Then
            PictureBox1.Image = My.Resources.icons8_mine_cart_100
        ElseIf My.Settings.Player1Icon = "Horse" Then
            PictureBox1.Image = My.Resources.icons8_trotting_horse_100
        ElseIf My.Settings.Player1Icon = "Dog" Then
            PictureBox1.Image = My.Resources.icons8_dog_100
        ElseIf My.Settings.Player1Icon = "Shoe" Then
            PictureBox1.Image = My.Resources.icons8_children_shoes_100
        ElseIf My.Settings.Player1Icon = "Ship" Then
            PictureBox1.Image = My.Resources.icons8_cargo_ship_100
        ElseIf My.Settings.Player1Icon = "Car" Then
            PictureBox1.Image = My.Resources.icons8_car_100
        ElseIf My.Settings.Player1Icon = "Cap" Then
            PictureBox1.Image = My.Resources.icons8_cap_100
        ElseIf My.Settings.Player1Icon = "Cannon" Then
            PictureBox1.Image = My.Resources.icons8_cannon_100
        ElseIf My.Settings.Player1Icon = Nothing Then
            PictureBox1.Image = Nothing
        End If

        lblP1Money.Text = EMonopoly.lblp1cost.Text
        lblP1Property.Text = EMonopoly.lblp1property.Text
        lblP1Houses.Text = EMonopoly.lblp1house.Text
        lblP1Hotels.Text = EMonopoly.lblp1hotel.Text

        PictureBoxPrimary.Image = Nothing
        ListBoxPrimary.Items.Clear()

        For Each propertyN As String In EMonopoly.CheckedListBoxP1Sold.Items
            ListBoxPrimary.Items.Add(propertyN)
        Next
    End Sub
    Private Sub P2Load()
        lblp2n.Text = EMonopoly.lblp2.Text

        If My.Settings.Player2Icon = "Hat" Then
            PictureBox2.Image = My.Resources.icons8_hat_100
        ElseIf My.Settings.Player2Icon = "Iron" Then
            PictureBox2.Image = My.Resources.icons8_iron_100
        ElseIf My.Settings.Player2Icon = "Carriage" Then
            PictureBox2.Image = My.Resources.icons8_mine_cart_100
        ElseIf My.Settings.Player2Icon = "Horse" Then
            PictureBox2.Image = My.Resources.icons8_trotting_horse_100
        ElseIf My.Settings.Player2Icon = "Dog" Then
            PictureBox2.Image = My.Resources.icons8_dog_100
        ElseIf My.Settings.Player2Icon = "Shoe" Then
            PictureBox2.Image = My.Resources.icons8_children_shoes_100
        ElseIf My.Settings.Player2Icon = "Ship" Then
            PictureBox2.Image = My.Resources.icons8_cargo_ship_100
        ElseIf My.Settings.Player2Icon = "Car" Then
            PictureBox2.Image = My.Resources.icons8_car_100
        ElseIf My.Settings.Player2Icon = "Cap" Then
            PictureBox2.Image = My.Resources.icons8_cap_100
        ElseIf My.Settings.Player2Icon = "Cannon" Then
            PictureBox2.Image = My.Resources.icons8_cannon_100
        ElseIf My.Settings.Player2Icon = Nothing Then
            PictureBox2.Image = Nothing
        End If

        lblP2Money.Text = EMonopoly.lblp2cost.Text
        lblP2Property.Text = EMonopoly.lblp2property.Text
        lblP2Houses.Text = EMonopoly.lblp2house.Text
        lblP2Hotels.Text = EMonopoly.lblp2hotel.Text

        PictureBoxPrimary.Image = Nothing
        ListBoxPrimary.Items.Clear()

        For Each propertyN As String In EMonopoly.CheckedListBoxP2Sold.Items
            ListBoxPrimary.Items.Add(propertyN)
        Next
    End Sub
    Private Sub P3Load()
        lblp3n.Text = EMonopoly.lblp3.Text

        If My.Settings.Player3Icon = "Hat" Then
            PictureBox3.Image = My.Resources.icons8_hat_100
        ElseIf My.Settings.Player3Icon = "Iron" Then
            PictureBox3.Image = My.Resources.icons8_iron_100
        ElseIf My.Settings.Player3Icon = "Carriage" Then
            PictureBox3.Image = My.Resources.icons8_mine_cart_100
        ElseIf My.Settings.Player3Icon = "Horse" Then
            PictureBox3.Image = My.Resources.icons8_trotting_horse_100
        ElseIf My.Settings.Player3Icon = "Dog" Then
            PictureBox3.Image = My.Resources.icons8_dog_100
        ElseIf My.Settings.Player3Icon = "Shoe" Then
            PictureBox3.Image = My.Resources.icons8_children_shoes_100
        ElseIf My.Settings.Player3Icon = "Ship" Then
            PictureBox3.Image = My.Resources.icons8_cargo_ship_100
        ElseIf My.Settings.Player3Icon = "Car" Then
            PictureBox3.Image = My.Resources.icons8_car_100
        ElseIf My.Settings.Player3Icon = "Cap" Then
            PictureBox3.Image = My.Resources.icons8_cap_100
        ElseIf My.Settings.Player3Icon = "Cannon" Then
            PictureBox3.Image = My.Resources.icons8_cannon_100
        ElseIf My.Settings.Player3Icon = Nothing Then
            PictureBox3.Image = Nothing
        End If

        lblP3Money.Text = EMonopoly.lblp3cost.Text
        lblP3Property.Text = EMonopoly.lblp3property.Text
        lblP3Houses.Text = EMonopoly.lblp3house.Text
        lblP3Hotels.Text = EMonopoly.lblp3hotel.Text

        PictureBoxPrimary.Image = Nothing
        ListBoxPrimary.Items.Clear()

        For Each propertyN As String In EMonopoly.CheckedListBoxP3Sold.Items
            ListBoxPrimary.Items.Add(propertyN)
        Next
    End Sub
    Private Sub P4Load()
        lblp4n.Text = EMonopoly.lblp4.Text
        If My.Settings.Player4Icon = "Hat" Then
            PictureBox4.Image = My.Resources.icons8_hat_100
        ElseIf My.Settings.Player4Icon = "Iron" Then
            PictureBox4.Image = My.Resources.icons8_iron_100
        ElseIf My.Settings.Player4Icon = "Carriage" Then
            PictureBox4.Image = My.Resources.icons8_mine_cart_100
        ElseIf My.Settings.Player4Icon = "Horse" Then
            PictureBox4.Image = My.Resources.icons8_trotting_horse_100
        ElseIf My.Settings.Player4Icon = "Dog" Then
            PictureBox4.Image = My.Resources.icons8_dog_100
        ElseIf My.Settings.Player4Icon = "Shoe" Then
            PictureBox4.Image = My.Resources.icons8_children_shoes_100
        ElseIf My.Settings.Player4Icon = "Ship" Then
            PictureBox4.Image = My.Resources.icons8_cargo_ship_100
        ElseIf My.Settings.Player4Icon = "Car" Then
            PictureBox4.Image = My.Resources.icons8_car_100
        ElseIf My.Settings.Player4Icon = "Cap" Then
            PictureBox4.Image = My.Resources.icons8_cap_100
        ElseIf My.Settings.Player4Icon = "Cannon" Then
            PictureBox4.Image = My.Resources.icons8_cannon_100
        ElseIf My.Settings.Player4Icon = Nothing Then
            PictureBox4.Image = Nothing
        End If

        lblP4Money.Text = EMonopoly.lblp4cost.Text
        lblP4Property.Text = EMonopoly.lblp4property.Text
        lblP4Houses.Text = EMonopoly.lblp4house.Text
        lblP4Hotels.Text = EMonopoly.lblp4hotel.Text

        PictureBoxPrimary.Image = Nothing
        ListBoxPrimary.Items.Clear()

        For Each propertyN As String In EMonopoly.CheckedListBoxP4Sold.Items
            ListBoxPrimary.Items.Add(propertyN)
        Next
    End Sub
    Private Sub P5Load()
        lblp5n.Text = EMonopoly.lblp5.Text
        If My.Settings.Player5Icon = "Hat" Then
            PictureBox5.Image = My.Resources.icons8_hat_100
        ElseIf My.Settings.Player5Icon = "Iron" Then
            PictureBox5.Image = My.Resources.icons8_iron_100
        ElseIf My.Settings.Player5Icon = "Carriage" Then
            PictureBox5.Image = My.Resources.icons8_mine_cart_100
        ElseIf My.Settings.Player5Icon = "Horse" Then
            PictureBox5.Image = My.Resources.icons8_trotting_horse_100
        ElseIf My.Settings.Player5Icon = "Dog" Then
            PictureBox5.Image = My.Resources.icons8_dog_100
        ElseIf My.Settings.Player5Icon = "Shoe" Then
            PictureBox5.Image = My.Resources.icons8_children_shoes_100
        ElseIf My.Settings.Player5Icon = "Ship" Then
            PictureBox5.Image = My.Resources.icons8_cargo_ship_100
        ElseIf My.Settings.Player5Icon = "Car" Then
            PictureBox5.Image = My.Resources.icons8_car_100
        ElseIf My.Settings.Player5Icon = "Cap" Then
            PictureBox5.Image = My.Resources.icons8_cap_100
        ElseIf My.Settings.Player5Icon = "Cannon" Then
            PictureBox5.Image = My.Resources.icons8_cannon_100
        ElseIf My.Settings.Player5Icon = Nothing Then
            PictureBox5.Image = Nothing
        End If

        lblP5Money.Text = EMonopoly.lblp5cost.Text
        lblP5Property.Text = EMonopoly.lblp5property.Text
        lblP5Houses.Text = EMonopoly.lblp5house.Text
        lblP5Hotels.Text = EMonopoly.lblp5hotel.Text

        PictureBoxPrimary.Image = Nothing
        ListBoxPrimary.Items.Clear()

        For Each propertyN As String In EMonopoly.CheckedListBoxP5Sold.Items
            ListBoxPrimary.Items.Add(propertyN)
        Next
    End Sub
    Private Sub P6Load()
        lblp6n.Text = EMonopoly.lblp6.Text
        If My.Settings.Player6Icon = "Hat" Then
            PictureBox6.Image = My.Resources.icons8_hat_100
        ElseIf My.Settings.Player6Icon = "Iron" Then
            PictureBox6.Image = My.Resources.icons8_iron_100
        ElseIf My.Settings.Player6Icon = "Carriage" Then
            PictureBox6.Image = My.Resources.icons8_mine_cart_100
        ElseIf My.Settings.Player6Icon = "Horse" Then
            PictureBox6.Image = My.Resources.icons8_trotting_horse_100
        ElseIf My.Settings.Player6Icon = "Dog" Then
            PictureBox6.Image = My.Resources.icons8_dog_100
        ElseIf My.Settings.Player6Icon = "Shoe" Then
            PictureBox6.Image = My.Resources.icons8_children_shoes_100
        ElseIf My.Settings.Player6Icon = "Ship" Then
            PictureBox6.Image = My.Resources.icons8_cargo_ship_100
        ElseIf My.Settings.Player6Icon = "Car" Then
            PictureBox6.Image = My.Resources.icons8_car_100
        ElseIf My.Settings.Player6Icon = "Cap" Then
            PictureBox6.Image = My.Resources.icons8_cap_100
        ElseIf My.Settings.Player6Icon = "Cannon" Then
            PictureBox6.Image = My.Resources.icons8_cannon_100
        ElseIf My.Settings.Player6Icon = Nothing Then
            PictureBox6.Image = Nothing
        End If

        lblP6Money.Text = EMonopoly.lblp6cost.Text
        lblP6Property.Text = EMonopoly.lblp6property.Text
        lblP6Houses.Text = EMonopoly.lblp6house.Text
        lblP6Hotels.Text = EMonopoly.lblp6hotel.Text

        PictureBoxPrimary.Image = Nothing
        ListBoxPrimary.Items.Clear()

        For Each propertyN As String In EMonopoly.CheckedListBoxP6Sold.Items
            ListBoxPrimary.Items.Add(propertyN)
        Next
    End Sub
    Private Sub P7Load()
        lblp7n.Text = EMonopoly.lblp7.Text
        If My.Settings.Player7Icon = "Hat" Then
            PictureBox7.Image = My.Resources.icons8_hat_100
        ElseIf My.Settings.Player7Icon = "Iron" Then
            PictureBox7.Image = My.Resources.icons8_iron_100
        ElseIf My.Settings.Player7Icon = "Carriage" Then
            PictureBox7.Image = My.Resources.icons8_mine_cart_100
        ElseIf My.Settings.Player7Icon = "Horse" Then
            PictureBox7.Image = My.Resources.icons8_trotting_horse_100
        ElseIf My.Settings.Player7Icon = "Dog" Then
            PictureBox7.Image = My.Resources.icons8_dog_100
        ElseIf My.Settings.Player7Icon = "Shoe" Then
            PictureBox7.Image = My.Resources.icons8_children_shoes_100
        ElseIf My.Settings.Player7Icon = "Ship" Then
            PictureBox7.Image = My.Resources.icons8_cargo_ship_100
        ElseIf My.Settings.Player7Icon = "Car" Then
            PictureBox7.Image = My.Resources.icons8_car_100
        ElseIf My.Settings.Player7Icon = "Cap" Then
            PictureBox7.Image = My.Resources.icons8_cap_100
        ElseIf My.Settings.Player7Icon = "Cannon" Then
            PictureBox7.Image = My.Resources.icons8_cannon_100
        ElseIf My.Settings.Player7Icon = Nothing Then
            PictureBox7.Image = Nothing
        End If

        lblP7Money.Text = EMonopoly.lblp7cost.Text
        lblP7Property.Text = EMonopoly.lblp7property.Text
        lblP7Houses.Text = EMonopoly.lblp7house.Text
        lblP7Hotels.Text = EMonopoly.lblp7hotel.Text

        PictureBoxPrimary.Image = Nothing
        ListBoxPrimary.Items.Clear()

        For Each propertyN As String In EMonopoly.CheckedListBoxP7Sold.Items
            ListBoxPrimary.Items.Add(propertyN)
        Next
    End Sub
    Private Sub P8Load()
        lblp8n.Text = EMonopoly.lblp8.Text
        If My.Settings.Player8Icon = "Hat" Then
            PictureBox8.Image = My.Resources.icons8_hat_100
        ElseIf My.Settings.Player8Icon = "Iron" Then
            PictureBox8.Image = My.Resources.icons8_iron_100
        ElseIf My.Settings.Player8Icon = "Carriage" Then
            PictureBox8.Image = My.Resources.icons8_mine_cart_100
        ElseIf My.Settings.Player8Icon = "Horse" Then
            PictureBox8.Image = My.Resources.icons8_trotting_horse_100
        ElseIf My.Settings.Player8Icon = "Dog" Then
            PictureBox8.Image = My.Resources.icons8_dog_100
        ElseIf My.Settings.Player8Icon = "Shoe" Then
            PictureBox8.Image = My.Resources.icons8_children_shoes_100
        ElseIf My.Settings.Player8Icon = "Ship" Then
            PictureBox8.Image = My.Resources.icons8_cargo_ship_100
        ElseIf My.Settings.Player8Icon = "Car" Then
            PictureBox8.Image = My.Resources.icons8_car_100
        ElseIf My.Settings.Player8Icon = "Cap" Then
            PictureBox8.Image = My.Resources.icons8_cap_100
        ElseIf My.Settings.Player8Icon = "Cannon" Then
            PictureBox8.Image = My.Resources.icons8_cannon_100
        ElseIf My.Settings.Player8Icon = Nothing Then
            PictureBox8.Image = Nothing
        End If

        lblP8Money.Text = EMonopoly.lblp8cost.Text
        lblP8Property.Text = EMonopoly.lblp8property.Text
        lblP8Houses.Text = EMonopoly.lblp8house.Text
        lblP8Hotels.Text = EMonopoly.lblp8hotel.Text

        PictureBoxPrimary.Image = Nothing
        ListBoxPrimary.Items.Clear()

        For Each propertyN As String In EMonopoly.CheckedListBoxP8Sold.Items
            ListBoxPrimary.Items.Add(propertyN)
        Next
    End Sub
    Private Sub ListBoxPrimary_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPrimary.SelectedIndexChanged
        Dim itemname1 As String
        itemname1 = Convert.ToString(ListBoxPrimary.SelectedItem)

        If itemname1 = "OldKentRoad" Then
            PictureBoxPrimary.Image = My.Resources.OldKentRoad
        ElseIf itemname1 = "WhitechapelRoad" Then
            PictureBoxPrimary.Image = My.Resources.WhitechapelRoad
        ElseIf itemname1 = "KingCrossStation" Then
            PictureBoxPrimary.Image = My.Resources.KingCrossStation
        ElseIf itemname1 = "TheAngel_Islington" Then
            PictureBoxPrimary.Image = My.Resources.TheAngel_Islington
        ElseIf itemname1 = "EustonRoad" Then
            PictureBoxPrimary.Image = My.Resources.EustonRoad
        ElseIf itemname1 = "PentonvilleRoad" Then
            PictureBoxPrimary.Image = My.Resources.PentonvilleRoad
        ElseIf itemname1 = "PallMall" Then
            PictureBoxPrimary.Image = My.Resources.PallMall
        ElseIf itemname1 = "ElectricCompany" Then
            PictureBoxPrimary.Image = My.Resources.ElectricCompany
        ElseIf itemname1 = "Whitehall" Then
            PictureBoxPrimary.Image = My.Resources.Whitehall
        ElseIf itemname1 = "NorthumberlandAvenue" Then
            PictureBoxPrimary.Image = My.Resources.NorthumberlandAvenue
        ElseIf itemname1 = "MarlboroughStreet" Then
            PictureBoxPrimary.Image = My.Resources.MarlboroughStreet
        ElseIf itemname1 = "BowStreet" Then
            PictureBoxPrimary.Image = My.Resources.BowStreet
        ElseIf itemname1 = "MaryleboneStation" Then
            PictureBoxPrimary.Image = My.Resources.MaryleboneStation
        ElseIf itemname1 = "VineStreet" Then
            PictureBoxPrimary.Image = My.Resources.VineStreet
        ElseIf itemname1 = "Strand" Then
            PictureBoxPrimary.Image = My.Resources.Strand
        ElseIf itemname1 = "FleetStreet" Then
            PictureBoxPrimary.Image = My.Resources.FleetStreet
        ElseIf itemname1 = "TrafalgarSquare" Then
            PictureBoxPrimary.Image = My.Resources.TrafalgarSquare
        ElseIf itemname1 = "FrenchchurchStreetStation" Then
            PictureBoxPrimary.Image = My.Resources.FrenchchurchStreetStation
        ElseIf itemname1 = "LeicesterSquare" Then
            PictureBoxPrimary.Image = My.Resources.LeicesterSquare
        ElseIf itemname1 = "ConventoryStreet" Then
            PictureBoxPrimary.Image = My.Resources.ConventoryStreet
        ElseIf itemname1 = "WaterWorks" Then
            PictureBoxPrimary.Image = My.Resources.WaterWorks
        ElseIf itemname1 = "Picadilly" Then
            PictureBoxPrimary.Image = My.Resources.Picadilly
        ElseIf itemname1 = "RegentStreet" Then
            PictureBoxPrimary.Image = My.Resources.RegentStreet
        ElseIf itemname1 = "OxfordStreet" Then
            PictureBoxPrimary.Image = My.Resources.OxfordStreet
        ElseIf itemname1 = "BondStreet" Then
            PictureBoxPrimary.Image = My.Resources.BondStreet
        ElseIf itemname1 = "LiverpoolStreetStation" Then
            PictureBoxPrimary.Image = My.Resources.LiverpoolStreetStation
        ElseIf itemname1 = "ParkLane" Then
            PictureBoxPrimary.Image = My.Resources.ParkLane
        ElseIf itemname1 = "Mayfair" Then
            PictureBoxPrimary.Image = My.Resources.Mayfair
        Else
        End If

    End Sub




    Public Sub P1Show()
        pnlP2.Dock = DockStyle.None
        pnlP2.Visible = False

        pnlP3.Dock = DockStyle.None
        pnlP3.Visible = False

        pnlP4.Dock = DockStyle.None
        pnlP4.Visible = False

        pnlP5.Dock = DockStyle.None
        pnlP5.Visible = False

        pnlP6.Dock = DockStyle.None
        pnlP6.Visible = False

        pnlP7.Dock = DockStyle.None
        pnlP7.Visible = False

        pnlP8.Dock = DockStyle.None
        pnlP8.Visible = False

        butP2.BackColor = Panel1.BackColor
        butP3.BackColor = Panel1.BackColor
        butP4.BackColor = Panel1.BackColor
        butP5.BackColor = Panel1.BackColor
        butP6.BackColor = Panel1.BackColor
        butP7.BackColor = Panel1.BackColor
        butP8.BackColor = Panel1.BackColor

        butP1.BackColor = pnlP1.BackColor

        pnlP1.Dock = DockStyle.Fill
        pnlP1.BringToFront()
        P1Load()
        RefreshGraph()
        pnlP1.Visible = True
    End Sub
    Public Sub P2Show()
        pnlP1.Dock = DockStyle.None
        pnlP1.Visible = False

        pnlP3.Dock = DockStyle.None
        pnlP3.Visible = False

        pnlP4.Dock = DockStyle.None
        pnlP4.Visible = False

        pnlP5.Dock = DockStyle.None
        pnlP5.Visible = False

        pnlP6.Dock = DockStyle.None
        pnlP6.Visible = False

        pnlP7.Dock = DockStyle.None
        pnlP7.Visible = False

        pnlP8.Dock = DockStyle.None
        pnlP8.Visible = False

        butP1.BackColor = Panel1.BackColor
        butP3.BackColor = Panel1.BackColor
        butP4.BackColor = Panel1.BackColor
        butP5.BackColor = Panel1.BackColor
        butP6.BackColor = Panel1.BackColor
        butP7.BackColor = Panel1.BackColor
        butP8.BackColor = Panel1.BackColor

        butP2.BackColor = pnlP2.BackColor

        pnlP2.Dock = DockStyle.Fill
        pnlP2.BringToFront()
        P2Load()
        RefreshGraph()
        pnlP2.Visible = True

    End Sub
    Public Sub P3Show()
        pnlP1.Dock = DockStyle.Fill
        pnlP1.Visible = True

        pnlP2.Dock = DockStyle.None
        pnlP2.Visible = False

        pnlP4.Dock = DockStyle.None
        pnlP4.Visible = False

        pnlP5.Dock = DockStyle.None
        pnlP5.Visible = False

        pnlP6.Dock = DockStyle.None
        pnlP6.Visible = False

        pnlP7.Dock = DockStyle.None
        pnlP7.Visible = False

        pnlP8.Dock = DockStyle.None
        pnlP8.Visible = False

        butP1.BackColor = Panel1.BackColor
        butP2.BackColor = Panel1.BackColor
        butP4.BackColor = Panel1.BackColor
        butP5.BackColor = Panel1.BackColor
        butP6.BackColor = Panel1.BackColor
        butP7.BackColor = Panel1.BackColor
        butP8.BackColor = Panel1.BackColor

        butP3.BackColor = pnlP3.BackColor

        pnlP3.Dock = DockStyle.Fill
        pnlP3.BringToFront()
        P3Load()
        RefreshGraph()
        pnlP3.Visible = True
    End Sub
    Public Sub P4Show()
        pnlP1.Dock = DockStyle.None
        pnlP1.Visible = True

        pnlP2.Dock = DockStyle.None
        pnlP2.Visible = False

        pnlP3.Dock = DockStyle.None
        pnlP3.Visible = False

        pnlP5.Dock = DockStyle.None
        pnlP5.Visible = False

        pnlP6.Dock = DockStyle.None
        pnlP6.Visible = False

        pnlP7.Dock = DockStyle.None
        pnlP7.Visible = False

        pnlP8.Dock = DockStyle.None
        pnlP8.Visible = False

        butP1.BackColor = Panel1.BackColor
        butP2.BackColor = Panel1.BackColor
        butP3.BackColor = Panel1.BackColor
        butP5.BackColor = Panel1.BackColor
        butP6.BackColor = Panel1.BackColor
        butP7.BackColor = Panel1.BackColor
        butP8.BackColor = Panel1.BackColor

        butP4.BackColor = pnlP4.BackColor

        pnlP4.Dock = DockStyle.Fill
        pnlP4.BringToFront()
        P4Load()
        RefreshGraph()
        pnlP4.Visible = True
    End Sub
    Public Sub P5Show()
        pnlP1.Dock = DockStyle.None
        pnlP1.Visible = True

        pnlP2.Dock = DockStyle.None
        pnlP2.Visible = False

        pnlP3.Dock = DockStyle.None
        pnlP3.Visible = False

        pnlP4.Dock = DockStyle.None
        pnlP4.Visible = False

        pnlP6.Dock = DockStyle.None
        pnlP6.Visible = False

        pnlP7.Dock = DockStyle.None
        pnlP7.Visible = False

        pnlP8.Dock = DockStyle.None
        pnlP8.Visible = False

        butP1.BackColor = Panel1.BackColor
        butP2.BackColor = Panel1.BackColor
        butP3.BackColor = Panel1.BackColor
        butP4.BackColor = Panel1.BackColor
        butP6.BackColor = Panel1.BackColor
        butP7.BackColor = Panel1.BackColor
        butP8.BackColor = Panel1.BackColor

        butP5.BackColor = pnlP5.BackColor

        pnlP5.Dock = DockStyle.Fill
        pnlP5.BringToFront()
        P5Load()
        RefreshGraph()
        pnlP5.Visible = True
    End Sub
    Public Sub P6Show()
        pnlP1.Dock = DockStyle.None
        pnlP1.Visible = True

        pnlP2.Dock = DockStyle.None
        pnlP2.Visible = False

        pnlP3.Dock = DockStyle.None
        pnlP3.Visible = False

        pnlP4.Dock = DockStyle.None
        pnlP4.Visible = False

        pnlP5.Dock = DockStyle.None
        pnlP5.Visible = False

        pnlP7.Dock = DockStyle.None
        pnlP7.Visible = False

        pnlP8.Dock = DockStyle.None
        pnlP8.Visible = False

        butP1.BackColor = Panel1.BackColor
        butP2.BackColor = Panel1.BackColor
        butP3.BackColor = Panel1.BackColor
        butP4.BackColor = Panel1.BackColor
        butP5.BackColor = Panel1.BackColor
        butP7.BackColor = Panel1.BackColor
        butP8.BackColor = Panel1.BackColor

        butP6.BackColor = pnlP6.BackColor

        pnlP6.Dock = DockStyle.Fill
        pnlP6.BringToFront()
        P6Load()
        RefreshGraph()
        pnlP6.Visible = True
    End Sub
    Public Sub P7Show()
        pnlP1.Dock = DockStyle.None
        pnlP1.Visible = True

        pnlP2.Dock = DockStyle.None
        pnlP2.Visible = False

        pnlP3.Dock = DockStyle.None
        pnlP3.Visible = False

        pnlP4.Dock = DockStyle.None
        pnlP4.Visible = False

        pnlP5.Dock = DockStyle.None
        pnlP5.Visible = False

        pnlP6.Dock = DockStyle.None
        pnlP6.Visible = False

        pnlP8.Dock = DockStyle.None
        pnlP8.Visible = False

        butP1.BackColor = Panel1.BackColor
        butP2.BackColor = Panel1.BackColor
        butP3.BackColor = Panel1.BackColor
        butP4.BackColor = Panel1.BackColor
        butP5.BackColor = Panel1.BackColor
        butP6.BackColor = Panel1.BackColor
        butP8.BackColor = Panel1.BackColor

        butP7.BackColor = pnlP7.BackColor

        pnlP7.Dock = DockStyle.Fill
        pnlP7.BringToFront()
        P7Load()
        RefreshGraph()
        pnlP7.Visible = True
    End Sub
    Public Sub P8Show()
        pnlP1.Dock = DockStyle.None
        pnlP1.Visible = True

        pnlP2.Dock = DockStyle.None
        pnlP2.Visible = False

        pnlP3.Dock = DockStyle.None
        pnlP3.Visible = False

        pnlP4.Dock = DockStyle.None
        pnlP4.Visible = False

        pnlP5.Dock = DockStyle.None
        pnlP5.Visible = False

        pnlP6.Dock = DockStyle.None
        pnlP6.Visible = False

        pnlP7.Dock = DockStyle.None
        pnlP7.Visible = False

        butP1.BackColor = Panel1.BackColor
        butP2.BackColor = Panel1.BackColor
        butP3.BackColor = Panel1.BackColor
        butP4.BackColor = Panel1.BackColor
        butP5.BackColor = Panel1.BackColor
        butP6.BackColor = Panel1.BackColor
        butP7.BackColor = Panel1.BackColor

        butP8.BackColor = pnlP8.BackColor

        pnlP8.Dock = DockStyle.Fill
        pnlP8.BringToFront()
        P8Load()
        RefreshGraph()
        pnlP8.Visible = True
    End Sub

    Public Sub RefreshGraph()
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

    Private Sub butEG_Click(sender As Object, e As EventArgs) Handles butEG.Click
        butGB.Visible = False
        butEG.Visible = False
        butExit.Visible = True

        Me.Close()
        EMonopoly.Ending()

    End Sub

    Private Sub butGB_Click(sender As Object, e As EventArgs) Handles butGB.Click
        butGB.Visible = False
        butEG.Visible = False
        butExit.Visible = True
        Me.Close()
    End Sub

    Private Sub SplitContainer2_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer2.Panel1.Paint

    End Sub
End Class