Public Class Player3Icon

    Private Sub Player3Icon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class