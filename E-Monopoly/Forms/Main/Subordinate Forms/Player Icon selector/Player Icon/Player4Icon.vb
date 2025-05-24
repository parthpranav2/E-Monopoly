Public Class Player4Icon

    Private Sub Player4Icon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        End If

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub
End Class