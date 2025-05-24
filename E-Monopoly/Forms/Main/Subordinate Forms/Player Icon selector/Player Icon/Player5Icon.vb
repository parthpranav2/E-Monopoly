Public Class Player5Icon

    Private Sub Player5Icon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub
End Class