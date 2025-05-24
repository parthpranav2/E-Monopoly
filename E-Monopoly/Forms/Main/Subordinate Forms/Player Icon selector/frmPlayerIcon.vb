Public Class frmPlayerIcon

    Private Sub butExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExit.Click
        EMonopoly.SecondaryScreen()
        EMonopoly.Show()
        Me.Close()
    End Sub

    Private Sub butMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Settings.IconSelector = 1
        Me.Close()
        frmPlayerIconSelector.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Settings.IconSelector = 3
        Me.Close()
        frmPlayerIconSelector.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Settings.IconSelector = 4
        Me.Close()
        frmPlayerIconSelector.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PlayerIcon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.NoofPlayers = 1 Then
            Label1.Visible = True
            Label1.Text = EMonopoly.lblp1.Text
            PictureBoxP1.Visible = True

        ElseIf My.Settings.NoofPlayers = 2 Then
            Label1.Visible = True
            Label1.Text = EMonopoly.lblp1.Text
            PictureBoxP1.Visible = True

            Label2.Visible = True
            Label2.Text = EMonopoly.lblp2.Text
            PictureBoxP2.Visible = True

        ElseIf My.Settings.NoofPlayers = 3 Then
            Label1.Visible = True
            Label1.Text = EMonopoly.lblp1.Text
            PictureBoxP1.Visible = True

            Label2.Visible = True
            Label2.Text = EMonopoly.lblp2.Text
            PictureBoxP2.Visible = True

            Label3.Visible = True
            Label3.Text = EMonopoly.lblp3.Text
            PictureBoxP3.Visible = True

        ElseIf My.Settings.NoofPlayers = 4 Then
            Label1.Visible = True
            Label1.Text = EMonopoly.lblp1.Text
            PictureBoxP1.Visible = True

            Label2.Visible = True
            Label2.Text = EMonopoly.lblp2.Text
            PictureBoxP2.Visible = True

            Label3.Visible = True
            Label3.Text = EMonopoly.lblp3.Text
            PictureBoxP3.Visible = True


            Label4.Visible = True
            Label4.Text = EMonopoly.lblp4.Text
            PictureBoxP4.Visible = True

        ElseIf My.Settings.NoofPlayers = 5 Then
            Label1.Visible = True
            Label1.Text = EMonopoly.lblp1.Text
            PictureBoxP1.Visible = True

            Label2.Visible = True
            Label2.Text = EMonopoly.lblp2.Text
            PictureBoxP2.Visible = True

            Label3.Visible = True
            Label3.Text = EMonopoly.lblp3.Text
            PictureBoxP3.Visible = True


            Label4.Visible = True
            Label4.Text = EMonopoly.lblp4.Text
            PictureBoxP4.Visible = True

            Label5.Visible = True
            Label5.Text = EMonopoly.lblp5.Text
            PictureBoxP5.Visible = True

        ElseIf My.Settings.NoofPlayers = 6 Then
            Label1.Visible = True
            Label1.Text = EMonopoly.lblp1.Text
            PictureBoxP1.Visible = True

            Label2.Visible = True
            Label2.Text = EMonopoly.lblp2.Text
            PictureBoxP2.Visible = True

            Label3.Visible = True
            Label3.Text = EMonopoly.lblp3.Text
            PictureBoxP3.Visible = True


            Label4.Visible = True
            Label4.Text = EMonopoly.lblp4.Text
            PictureBoxP4.Visible = True

            Label5.Visible = True
            Label5.Text = EMonopoly.lblp5.Text
            PictureBoxP5.Visible = True

            Label6.Visible = True
            Label6.Text = EMonopoly.lblp6.Text
            PictureBoxP6.Visible = True


        ElseIf My.Settings.NoofPlayers = 7 Then
            Label1.Visible = True
            Label1.Text = EMonopoly.lblp1.Text
            PictureBoxP1.Visible = True

            Label2.Visible = True
            Label2.Text = EMonopoly.lblp2.Text
            PictureBoxP2.Visible = True

            Label3.Visible = True
            Label3.Text = EMonopoly.lblp3.Text
            PictureBoxP3.Visible = True

            Label4.Visible = True
            Label4.Text = EMonopoly.lblp4.Text
            PictureBoxP4.Visible = True

            Label5.Visible = True
            Label5.Text = EMonopoly.lblp5.Text
            PictureBoxP5.Visible = True

            Label6.Visible = True
            Label6.Text = EMonopoly.lblp6.Text
            PictureBoxP6.Visible = True

            Label7.Visible = True
            Label7.Text = EMonopoly.lblp7.Text
            PictureBoxP7.Visible = True

        ElseIf My.Settings.NoofPlayers = 8 Then
            Label1.Visible = True
            Label1.Text = EMonopoly.lblp1.Text
            PictureBoxP1.Visible = True

            Label2.Visible = True
            Label2.Text = EMonopoly.lblp2.Text
            PictureBoxP2.Visible = True

            Label3.Visible = True
            Label3.Text = EMonopoly.lblp3.Text
            PictureBoxP3.Visible = True

            Label4.Visible = True
            Label4.Text = EMonopoly.lblp4.Text
            PictureBoxP4.Visible = True

            Label5.Visible = True
            Label5.Text = EMonopoly.lblp5.Text
            PictureBoxP5.Visible = True

            Label6.Visible = True
            Label6.Text = EMonopoly.lblp6.Text
            PictureBoxP6.Visible = True

            Label7.Visible = True
            Label7.Text = EMonopoly.lblp7.Text
            PictureBoxP7.Visible = True

            Label8.Visible = True
            Label8.Text = EMonopoly.lblp8.Text
            PictureBoxP8.Visible = True

        End If

        If My.Settings.Player1Icon = "Hat" Then
            PictureBoxP1.Image = My.Resources.icons8_hat_100
        ElseIf My.Settings.Player1Icon = "Iron" Then
            PictureBoxP1.Image = My.Resources.icons8_iron_100
        ElseIf My.Settings.Player1Icon = "Carriage" Then
            PictureBoxP1.Image = My.Resources.icons8_mine_cart_100
        ElseIf My.Settings.Player1Icon = "Horse" Then
            PictureBoxP1.Image = My.Resources.icons8_trotting_horse_100
        ElseIf My.Settings.Player1Icon = "Dog" Then
            PictureBoxP1.Image = My.Resources.icons8_dog_100
        ElseIf My.Settings.Player1Icon = "Shoe" Then
            PictureBoxP1.Image = My.Resources.icons8_children_shoes_100
        ElseIf My.Settings.Player1Icon = "Ship" Then
            PictureBoxP1.Image = My.Resources.icons8_cargo_ship_100
        ElseIf My.Settings.Player1Icon = "Car" Then
            PictureBoxP1.Image = My.Resources.icons8_car_100
        ElseIf My.Settings.Player1Icon = "Cap" Then
            PictureBoxP1.Image = My.Resources.icons8_cap_100
        ElseIf My.Settings.Player1Icon = "Cannon" Then
            PictureBoxP1.Image = My.Resources.icons8_cannon_100
        ElseIf My.Settings.Player1Icon = Nothing Then
            PictureBoxP1.Image = Nothing
        End If

        If My.Settings.Player2Icon = "Hat" Then
            PictureBoxP2.Image = My.Resources.icons8_hat_100
        ElseIf My.Settings.Player2Icon = "Iron" Then
            PictureBoxP2.Image = My.Resources.icons8_iron_100
        ElseIf My.Settings.Player2Icon = "Carriage" Then
            PictureBoxP2.Image = My.Resources.icons8_mine_cart_100
        ElseIf My.Settings.Player2Icon = "Horse" Then
            PictureBoxP2.Image = My.Resources.icons8_trotting_horse_100
        ElseIf My.Settings.Player2Icon = "Dog" Then
            PictureBoxP2.Image = My.Resources.icons8_dog_100
        ElseIf My.Settings.Player2Icon = "Shoe" Then
            PictureBoxP2.Image = My.Resources.icons8_children_shoes_100
        ElseIf My.Settings.Player2Icon = "Ship" Then
            PictureBoxP2.Image = My.Resources.icons8_cargo_ship_100
        ElseIf My.Settings.Player2Icon = "Car" Then
            PictureBoxP2.Image = My.Resources.icons8_car_100
        ElseIf My.Settings.Player2Icon = "Cap" Then
            PictureBoxP2.Image = My.Resources.icons8_cap_100
        ElseIf My.Settings.Player2Icon = "Cannon" Then
            PictureBoxP2.Image = My.Resources.icons8_cannon_100
        ElseIf My.Settings.Player2Icon = Nothing Then
            PictureBoxP2.Image = Nothing
        End If

        If My.Settings.Player3Icon = "Hat" Then
            PictureBoxP3.Image = My.Resources.icons8_hat_100
        ElseIf My.Settings.Player3Icon = "Iron" Then
            PictureBoxP3.Image = My.Resources.icons8_iron_100
        ElseIf My.Settings.Player3Icon = "Carriage" Then
            PictureBoxP3.Image = My.Resources.icons8_mine_cart_100
        ElseIf My.Settings.Player3Icon = "Horse" Then
            PictureBoxP3.Image = My.Resources.icons8_trotting_horse_100
        ElseIf My.Settings.Player3Icon = "Dog" Then
            PictureBoxP3.Image = My.Resources.icons8_dog_100
        ElseIf My.Settings.Player3Icon = "Shoe" Then
            PictureBoxP3.Image = My.Resources.icons8_children_shoes_100
        ElseIf My.Settings.Player3Icon = "Ship" Then
            PictureBoxP3.Image = My.Resources.icons8_cargo_ship_100
        ElseIf My.Settings.Player3Icon = "Car" Then
            PictureBoxP3.Image = My.Resources.icons8_car_100
        ElseIf My.Settings.Player3Icon = "Cap" Then
            PictureBoxP3.Image = My.Resources.icons8_cap_100
        ElseIf My.Settings.Player3Icon = "Cannon" Then
            PictureBoxP3.Image = My.Resources.icons8_cannon_100
        ElseIf My.Settings.Player3Icon = Nothing Then
            PictureBoxP3.Image = Nothing
        End If

        If My.Settings.Player4Icon = "Hat" Then
            PictureBoxP4.Image = My.Resources.icons8_hat_100
        ElseIf My.Settings.Player4Icon = "Iron" Then
            PictureBoxP4.Image = My.Resources.icons8_iron_100
        ElseIf My.Settings.Player4Icon = "Carriage" Then
            PictureBoxP4.Image = My.Resources.icons8_mine_cart_100
        ElseIf My.Settings.Player4Icon = "Horse" Then
            PictureBoxP4.Image = My.Resources.icons8_trotting_horse_100
        ElseIf My.Settings.Player4Icon = "Dog" Then
            PictureBoxP4.Image = My.Resources.icons8_dog_100
        ElseIf My.Settings.Player4Icon = "Shoe" Then
            PictureBoxP4.Image = My.Resources.icons8_children_shoes_100
        ElseIf My.Settings.Player4Icon = "Ship" Then
            PictureBoxP4.Image = My.Resources.icons8_cargo_ship_100
        ElseIf My.Settings.Player4Icon = "Car" Then
            PictureBoxP4.Image = My.Resources.icons8_car_100
        ElseIf My.Settings.Player4Icon = "Cap" Then
            PictureBoxP4.Image = My.Resources.icons8_cap_100
        ElseIf My.Settings.Player4Icon = "Cannon" Then
            PictureBoxP4.Image = My.Resources.icons8_cannon_100
        ElseIf My.Settings.Player4Icon = Nothing Then
            PictureBoxP4.Image = Nothing
        End If

        If My.Settings.Player5Icon = "Hat" Then
            PictureBoxP5.Image = My.Resources.icons8_hat_100
        ElseIf My.Settings.Player5Icon = "Iron" Then
            PictureBoxP5.Image = My.Resources.icons8_iron_100
        ElseIf My.Settings.Player5Icon = "Carriage" Then
            PictureBoxP5.Image = My.Resources.icons8_mine_cart_100
        ElseIf My.Settings.Player5Icon = "Horse" Then
            PictureBoxP5.Image = My.Resources.icons8_trotting_horse_100
        ElseIf My.Settings.Player5Icon = "Dog" Then
            PictureBoxP5.Image = My.Resources.icons8_dog_100
        ElseIf My.Settings.Player5Icon = "Shoe" Then
            PictureBoxP5.Image = My.Resources.icons8_children_shoes_100
        ElseIf My.Settings.Player5Icon = "Ship" Then
            PictureBoxP5.Image = My.Resources.icons8_cargo_ship_100
        ElseIf My.Settings.Player5Icon = "Car" Then
            PictureBoxP5.Image = My.Resources.icons8_car_100
        ElseIf My.Settings.Player5Icon = "Cap" Then
            PictureBoxP5.Image = My.Resources.icons8_cap_100
        ElseIf My.Settings.Player5Icon = "Cannon" Then
            PictureBoxP5.Image = My.Resources.icons8_cannon_100
        ElseIf My.Settings.Player5Icon = Nothing Then
            PictureBoxP5.Image = Nothing
        End If

        If My.Settings.Player6Icon = "Hat" Then
            PictureBoxP6.Image = My.Resources.icons8_hat_100
        ElseIf My.Settings.Player6Icon = "Iron" Then
            PictureBoxP6.Image = My.Resources.icons8_iron_100
        ElseIf My.Settings.Player6Icon = "Carriage" Then
            PictureBoxP6.Image = My.Resources.icons8_mine_cart_100
        ElseIf My.Settings.Player6Icon = "Horse" Then
            PictureBoxP6.Image = My.Resources.icons8_trotting_horse_100
        ElseIf My.Settings.Player6Icon = "Dog" Then
            PictureBoxP6.Image = My.Resources.icons8_dog_100
        ElseIf My.Settings.Player6Icon = "Shoe" Then
            PictureBoxP6.Image = My.Resources.icons8_children_shoes_100
        ElseIf My.Settings.Player6Icon = "Ship" Then
            PictureBoxP6.Image = My.Resources.icons8_cargo_ship_100
        ElseIf My.Settings.Player6Icon = "Car" Then
            PictureBoxP6.Image = My.Resources.icons8_car_100
        ElseIf My.Settings.Player6Icon = "Cap" Then
            PictureBoxP6.Image = My.Resources.icons8_cap_100
        ElseIf My.Settings.Player6Icon = "Cannon" Then
            PictureBoxP6.Image = My.Resources.icons8_cannon_100
        ElseIf My.Settings.Player6Icon = Nothing Then
            PictureBoxP6.Image = Nothing
        End If

        If My.Settings.Player7Icon = "Hat" Then
            PictureBoxP7.Image = My.Resources.icons8_hat_100
        ElseIf My.Settings.Player7Icon = "Iron" Then
            PictureBoxP7.Image = My.Resources.icons8_iron_100
        ElseIf My.Settings.Player7Icon = "Carriage" Then
            PictureBoxP7.Image = My.Resources.icons8_mine_cart_100
        ElseIf My.Settings.Player7Icon = "Horse" Then
            PictureBoxP7.Image = My.Resources.icons8_trotting_horse_100
        ElseIf My.Settings.Player7Icon = "Dog" Then
            PictureBoxP7.Image = My.Resources.icons8_dog_100
        ElseIf My.Settings.Player7Icon = "Shoe" Then
            PictureBoxP7.Image = My.Resources.icons8_children_shoes_100
        ElseIf My.Settings.Player7Icon = "Ship" Then
            PictureBoxP7.Image = My.Resources.icons8_cargo_ship_100
        ElseIf My.Settings.Player7Icon = "Car" Then
            PictureBoxP7.Image = My.Resources.icons8_car_100
        ElseIf My.Settings.Player7Icon = "Cap" Then
            PictureBoxP7.Image = My.Resources.icons8_cap_100
        ElseIf My.Settings.Player7Icon = "Cannon" Then
            PictureBoxP7.Image = My.Resources.icons8_cannon_100
        ElseIf My.Settings.Player7Icon = Nothing Then
            PictureBoxP7.Image = Nothing
        End If

        If My.Settings.Player8Icon = "Hat" Then
            PictureBoxP8.Image = My.Resources.icons8_hat_100
        ElseIf My.Settings.Player8Icon = "Iron" Then
            PictureBoxP8.Image = My.Resources.icons8_iron_100
        ElseIf My.Settings.Player8Icon = "Carriage" Then
            PictureBoxP8.Image = My.Resources.icons8_mine_cart_100
        ElseIf My.Settings.Player8Icon = "Horse" Then
            PictureBoxP8.Image = My.Resources.icons8_trotting_horse_100
        ElseIf My.Settings.Player8Icon = "Dog" Then
            PictureBoxP8.Image = My.Resources.icons8_dog_100
        ElseIf My.Settings.Player8Icon = "Shoe" Then
            PictureBoxP8.Image = My.Resources.icons8_children_shoes_100
        ElseIf My.Settings.Player8Icon = "Ship" Then
            PictureBoxP8.Image = My.Resources.icons8_cargo_ship_100
        ElseIf My.Settings.Player8Icon = "Car" Then
            PictureBoxP8.Image = My.Resources.icons8_car_100
        ElseIf My.Settings.Player8Icon = "Cap" Then
            PictureBoxP8.Image = My.Resources.icons8_cap_100
        ElseIf My.Settings.Player8Icon = "Cannon" Then
            PictureBoxP8.Image = My.Resources.icons8_cannon_100
        ElseIf My.Settings.Player8Icon = Nothing Then
            PictureBoxP8.Image = Nothing
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBoxP1.Click
        My.Settings.IconSelector = 1
        Me.Close()
        frmPlayerIconSelector.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBoxP4.Click
        My.Settings.IconSelector = 4
        Me.Close()
        frmPlayerIconSelector.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBoxP5.Click
        My.Settings.IconSelector = 5
        Me.Close()
        frmPlayerIconSelector.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBoxP6.Click
        My.Settings.IconSelector = 6
        Me.Close()
        frmPlayerIconSelector.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBoxP7.Click
        My.Settings.IconSelector = 7
        Me.Close()
        frmPlayerIconSelector.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBoxP8.Click
        My.Settings.IconSelector = 8
        Me.Close()
        frmPlayerIconSelector.Show()
    End Sub

    Private Sub PictureBoxP3_Click(sender As Object, e As EventArgs) Handles PictureBoxP3.Click
        My.Settings.IconSelector = 3
        Me.Close()
        frmPlayerIconSelector.Show()
    End Sub

    Private Sub PictureBoxP2_Click(sender As Object, e As EventArgs) Handles PictureBoxP2.Click
        My.Settings.IconSelector = 2
        Me.Close()
        frmPlayerIconSelector.Show()
    End Sub
End Class