Public Class Player1Icon

    Private Sub Player1Icon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class