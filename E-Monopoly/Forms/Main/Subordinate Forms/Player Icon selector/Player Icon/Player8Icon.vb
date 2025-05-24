Public Class Player8Icon

    Private Sub Player8Icon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

    End Sub
End Class