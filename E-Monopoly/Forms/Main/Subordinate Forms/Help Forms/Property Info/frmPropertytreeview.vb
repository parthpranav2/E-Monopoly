Public Class frmPropertytreeview

    Private Sub butExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExit.Click
        EMonopoly.Show()
        Me.Hide()
    End Sub

    Private Sub butMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized

        Else
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmHelp.Show()
        Me.Hide()
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Select Case TreeView1.SelectedNode.Name
            Case Is = "main"
                PictureBox1.Image = My.Resources.monopoly_man
            Case Is = "Properties"
                PictureBox1.Image = My.Resources.icons8_property_100
            Case Is = "Node0"
                PictureBox1.Image = My.Resources.icons8_prize_100
            Case Is = "Chance"
                PictureBox1.Image = My.Resources.icons8_question_mark_100
            Case Is = "CommunityChest"
                PictureBox1.Image = My.Resources.icons8_treasure_chest_100
            Case Is = "Node1"
                PictureBox1.Image = My.Resources.icons8_streets_100
            Case Is = "Node2"
                PictureBox1.Image = My.Resources.icons8_train_100
            Case Is = "Node3"
                PictureBox1.Image = My.Resources.icons8_water_heater_100
            Case Is = "Colours"
                PictureBox1.Image = My.Resources.icons8_rainbow_100
            Case Is = "Brown"
                PictureBox1.Image = My.Resources.Brown
            Case Is = "Pink"
                PictureBox1.Image = My.Resources.Pink
            Case Is = "Blue"
                PictureBox1.Image = My.Resources.Skyblue
            Case Is = "Red"
                PictureBox1.Image = My.Resources.Red
            Case Is = "Yellow"
                PictureBox1.Image = My.Resources.Yellow
            Case Is = "Purple"
                PictureBox1.Image = My.Resources.purple
            Case Is = "Green"
                PictureBox1.Image = My.Resources.Green
            Case Is = "Orange"
                PictureBox1.Image = My.Resources.Orange
            Case Is = "OldKentRoad"
                PictureBox1.Image = My.Resources.OldKentRoad
            Case Is = "WhitechapelRoad"
                PictureBox1.Image = My.Resources.WhitechapelRoad
            Case Is = "KingCrossStation"
                PictureBox1.Image = My.Resources.KingCrossStation
            Case Is = "TheAngel,Islington"
                PictureBox1.Image = My.Resources.TheAngel_Islington
            Case Is = "EustonRoad"
                PictureBox1.Image = My.Resources.EustonRoad
            Case Is = "PentonvilleRoad"
                PictureBox1.Image = My.Resources.PentonvilleRoad
            Case Is = "PallMall"
                PictureBox1.Image = My.Resources.PallMall
            Case Is = "ElectricCompany"
                PictureBox1.Image = My.Resources.ElectricCompany
            Case Is = "Whitehall"
                PictureBox1.Image = My.Resources.Whitehall
            Case Is = "Northumberl'dAvenue"
                PictureBox1.Image = My.Resources.NorthumberlandAvenue
            Case Is = "MaryleboneStation"
                PictureBox1.Image = My.Resources.MaryleboneStation
            Case Is = "BowStreet"
                PictureBox1.Image = My.Resources.BowStreet
            Case Is = "MarlboroughStreet"
                PictureBox1.Image = My.Resources.MarlboroughStreet
            Case Is = "VineStreet"
                PictureBox1.Image = My.Resources.VineStreet
            Case Is = "Strand"
                PictureBox1.Image = My.Resources.Strand
            Case Is = "FleetStreet"
                PictureBox1.Image = My.Resources.FleetStreet
            Case Is = "TrafalgarSquare"
                PictureBox1.Image = My.Resources.TrafalgarSquare
            Case Is = "FenchurchStreetStation"
                PictureBox1.Image = My.Resources.FrenchchurchStreetStation
            Case Is = "LeicesterSquare"
                PictureBox1.Image = My.Resources.LeicesterSquare
            Case Is = "CoventryStreet"
                PictureBox1.Image = My.Resources.ConventoryStreet
            Case Is = "WaterWorks"
                PictureBox1.Image = My.Resources.WaterWorks
            Case Is = "Picadilly"
                PictureBox1.Image = My.Resources.Picadilly
            Case Is = "RegentStreet"
                PictureBox1.Image = My.Resources.RegentStreet
            Case Is = "OxfordStreet"
                PictureBox1.Image = My.Resources.OxfordStreet
            Case Is = "BondStreet"
                PictureBox1.Image = My.Resources.BondStreet
            Case Is = "LiverpoolStreetStation"
                PictureBox1.Image = My.Resources.LiverpoolStreetStation
            Case Is = "ParkLane"
                PictureBox1.Image = My.Resources.ParkLane
            Case Is = "Mayfair"
                PictureBox1.Image = My.Resources.Mayfair

            Case Is = "C1"
                PictureBox1.Image = My.Resources.C1
            Case Is = "C2"
                PictureBox1.Image = My.Resources.C2p
            Case Is = "C3"
                PictureBox1.Image = My.Resources.C3
            Case Is = "C4"
                PictureBox1.Image = My.Resources.C4
            Case Is = "C5"
                PictureBox1.Image = My.Resources.C5
            Case Is = "C6"
                PictureBox1.Image = My.Resources.C6
            Case Is = "C7"
                PictureBox1.Image = My.Resources.C7
            Case Is = "C8"
                PictureBox1.Image = My.Resources.C8
            Case Is = "C9"
                PictureBox1.Image = My.Resources.C9
            Case Is = "C10"
                PictureBox1.Image = My.Resources.C10
            Case Is = "C11"
                PictureBox1.Image = My.Resources.C11
            Case Is = "C12"
                PictureBox1.Image = My.Resources.C12
            Case Is = "C13"
                PictureBox1.Image = My.Resources.C13
            Case Is = "C14"
                PictureBox1.Image = My.Resources.C14
            Case Is = "C15"
                PictureBox1.Image = My.Resources.C15
            Case Is = "C16"
                PictureBox1.Image = My.Resources.C16

            Case Is = "CC1"
                PictureBox1.Image = My.Resources.CC1
            Case Is = "CC2"
                PictureBox1.Image = My.Resources.CC2
            Case Is = "CC3"
                PictureBox1.Image = My.Resources.CC3
            Case Is = "CC4"
                PictureBox1.Image = My.Resources.CC4
            Case Is = "CC5"
                PictureBox1.Image = My.Resources.CC5
            Case Is = "CC6"
                PictureBox1.Image = My.Resources.CC6
            Case Is = "CC7"
                PictureBox1.Image = My.Resources.CC7
            Case Is = "CC8"
                PictureBox1.Image = My.Resources.CC8
            Case Is = "CC9"
                PictureBox1.Image = My.Resources.CC9
            Case Is = "CC10"
                PictureBox1.Image = My.Resources.CC10
            Case Is = "CC11"
                PictureBox1.Image = My.Resources.CC11
            Case Is = "CC12"
                PictureBox1.Image = My.Resources.CC12
            Case Is = "CC13"
                PictureBox1.Image = My.Resources.CC13
            Case Is = "CC14"
                PictureBox1.Image = My.Resources.CC14
            Case Is = "CC15"
                PictureBox1.Image = My.Resources.CC15
            Case Is = "CC16"
                PictureBox1.Image = My.Resources.CC16
        End Select
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmPropertyDatabase.Show()
    End Sub
End Class