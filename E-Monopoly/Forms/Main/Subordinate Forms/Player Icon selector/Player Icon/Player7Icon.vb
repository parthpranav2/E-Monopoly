Public Class Player7Icon

    Private Sub Player7Icon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub
End Class