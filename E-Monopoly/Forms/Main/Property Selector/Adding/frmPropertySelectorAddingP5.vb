Public Class frmPropertySelectorAddingP5
    Private Sub SplitContainer2_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer2.Panel1.Paint

    End Sub

    Private Sub ListBoxPN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPN.SelectedIndexChanged
        Dim itemname1 As String
        itemname1 = Convert.ToString(ListBoxPN.SelectedItem)

        If itemname1 = "OldKentRoad" Then
            PictureBox1.Image = My.Resources.OldKentRoad
        ElseIf itemname1 = "WhitechapelRoad" Then
            PictureBox1.Image = My.Resources.WhitechapelRoad
        ElseIf itemname1 = "KingCrossStation" Then
            PictureBox1.Image = My.Resources.KingCrossStation
        ElseIf itemname1 = "TheAngel_Islington" Then
            PictureBox1.Image = My.Resources.TheAngel_Islington
        ElseIf itemname1 = "EustonRoad" Then
            PictureBox1.Image = My.Resources.EustonRoad
        ElseIf itemname1 = "PentonvilleRoad" Then
            PictureBox1.Image = My.Resources.PentonvilleRoad
        ElseIf itemname1 = "PallMall" Then
            PictureBox1.Image = My.Resources.PallMall
        ElseIf itemname1 = "ElectricCompany" Then
            PictureBox1.Image = My.Resources.ElectricCompany
        ElseIf itemname1 = "Whitehall" Then
            PictureBox1.Image = My.Resources.Whitehall
        ElseIf itemname1 = "NorthumberlandAvenue" Then
            PictureBox1.Image = My.Resources.NorthumberlandAvenue
        ElseIf itemname1 = "MarlboroughStreet" Then
            PictureBox1.Image = My.Resources.MarlboroughStreet
        ElseIf itemname1 = "BowStreet" Then
            PictureBox1.Image = My.Resources.BowStreet
        ElseIf itemname1 = "MaryleboneStation" Then
            PictureBox1.Image = My.Resources.MaryleboneStation
        ElseIf itemname1 = "VineStreet" Then
            PictureBox1.Image = My.Resources.VineStreet
        ElseIf itemname1 = "Strand" Then
            PictureBox1.Image = My.Resources.Strand
        ElseIf itemname1 = "FleetStreet" Then
            PictureBox1.Image = My.Resources.FleetStreet
        ElseIf itemname1 = "TrafalgarSquare" Then
            PictureBox1.Image = My.Resources.TrafalgarSquare
        ElseIf itemname1 = "FrenchchurchStreetStation" Then
            PictureBox1.Image = My.Resources.FrenchchurchStreetStation
        ElseIf itemname1 = "LeicesterSquare" Then
            PictureBox1.Image = My.Resources.LeicesterSquare
        ElseIf itemname1 = "ConventoryStreet" Then
            PictureBox1.Image = My.Resources.ConventoryStreet
        ElseIf itemname1 = "WaterWorks" Then
            PictureBox1.Image = My.Resources.WaterWorks
        ElseIf itemname1 = "Picadilly" Then
            PictureBox1.Image = My.Resources.Picadilly
        ElseIf itemname1 = "RegentStreet" Then
            PictureBox1.Image = My.Resources.RegentStreet
        ElseIf itemname1 = "OxfordStreet" Then
            PictureBox1.Image = My.Resources.OxfordStreet
        ElseIf itemname1 = "BondStreet" Then
            PictureBox1.Image = My.Resources.BondStreet
        ElseIf itemname1 = "LiverpoolStreetStation" Then
            PictureBox1.Image = My.Resources.LiverpoolStreetStation
        ElseIf itemname1 = "ParkLane" Then
            PictureBox1.Image = My.Resources.ParkLane
        ElseIf itemname1 = "Mayfair" Then
            PictureBox1.Image = My.Resources.Mayfair
        Else
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub

    Private Sub SplitContainer2_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer2.SplitterMoved

    End Sub

    Private Sub lblp1n_Click(sender As Object, e As EventArgs) Handles lblp1n.Click

    End Sub

    Private Sub frmPropertySelectorAddingP5_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave

    End Sub

    Private Sub frmPropertySelectorAddingP5_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblp1n.Text = EMonopoly.lblp5.Text
        ListBoxPN.Items.Clear()

        For Each propertyN As String In EMonopoly.CheckedListBoxPN.Items
            ListBoxPN.Items.Add(propertyN)
        Next

    End Sub

    Private Sub ListBoxPN_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBoxPN.MouseDoubleClick
        Try
            Dim itemname As String
            Dim itemindex As Integer
            itemname = Convert.ToString(ListBoxPN.SelectedItem)
            itemindex = EMonopoly.CheckedListBoxPN.Items.IndexOf(itemname)
            EMonopoly.CheckedListBoxPN.Items.RemoveAt(itemindex)

            EMonopoly.CheckedListBoxP5Sold.Items.Add(itemname)

            If My.Settings.Sound_SFX = True Then
                My.Computer.Audio.Play(My.Resources._Property, AudioPlayMode.Background)
            End If

            My.Application.Log.WriteEntry("Property " + "(" + itemname + ")" + " added", TraceEventType.Information, 2)
            MsgBox("Property " + "(" + itemname + ")" + " added to " + EMonopoly.lblp5.Text)
            My.Application.Log.WriteEntry("Money With " + EMonopoly.lblp5.Text + " " + My.Settings.Currency + " " & +EMonopoly.lblp5cost.Text, TraceEventType.Information, 2)
            My.Application.Log.WriteEntry("Property With " + EMonopoly.lblp5.Text + " " + EMonopoly.lblp5property.Text, TraceEventType.Information, 2)
            My.Application.Log.WriteEntry("Money in Bank " & My.Settings.Currency + " " & +EMonopoly.lblBankCost.Text, TraceEventType.Information, 2)
            My.Application.Log.WriteEntry("Property(s) with Bank " & +EMonopoly.lblPropertiesLeft.Text, TraceEventType.Information, 2)
            My.Application.Log.WriteEntry("--------------------------------------")
            EMonopoly.pnlP5.Visible = False


            If EMonopoly.lblPropertiesLeft.Text = 1 Then
                EMonopoly.pnlP5.Visible = True
                If My.Settings.Sound_SFX = True Then
                    My.Computer.Audio.Play(My.Resources.Alarm1, AudioPlayMode.Background)
                End If
                MsgBox("Hurry up players there is only one property remaining (" + EMonopoly.CheckedListBoxPN.GetItemText(0) + ")", vbOKOnly + vbInformation)
                EMonopoly.pnlP5.Visible = False

            ElseIf EMonopoly.lblPropertiesLeft.Text = 0 Then
                EMonopoly.pnlP5.Visible = True
                MsgBox("There is no property left to be sold", vbOKOnly + vbExclamation)
                EMonopoly.pnlP5.Visible = False

            Else

            End If


            Me.Close()
        Catch ex As Exception
            MsgBox("Please select the property again")
        End Try
    End Sub
End Class