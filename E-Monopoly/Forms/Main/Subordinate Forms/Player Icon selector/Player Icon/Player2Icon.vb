Public Class Player2Icon

    Private Sub Player2Icon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class