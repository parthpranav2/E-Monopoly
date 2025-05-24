Public Class Player6Icon

    Private Sub Player6Icon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.Player6Icon = "Hat" Then
            PictureBox6.Image = My.Resources.icons8_hat_100
        ElseIf My.Settings.Player6Icon = "Iron" Then
            PictureBox6.Image = My.Resources.icons8_iron_100
        ElseIf My.Settings.Player6Icon = "Carriage" Then
            PictureBox6.Image = My.Resources.icons8_mine_cart_100
        ElseIf My.Settings.Player6Icon = "Horse" Then
            PictureBox6.Image = My.Resources.icons8_trotting_horse_100
        ElseIf My.Settings.Player6Icon = "Dog" Then
            PictureBox6.Image = My.Resources.icons8_dog_100
        ElseIf My.Settings.Player6Icon = "Shoe" Then
            PictureBox6.Image = My.Resources.icons8_children_shoes_100
        ElseIf My.Settings.Player6Icon = "Ship" Then
            PictureBox6.Image = My.Resources.icons8_cargo_ship_100
        ElseIf My.Settings.Player6Icon = "Car" Then
            PictureBox6.Image = My.Resources.icons8_car_100
        ElseIf My.Settings.Player6Icon = "Cap" Then
            PictureBox6.Image = My.Resources.icons8_cap_100
        ElseIf My.Settings.Player6Icon = "Cannon" Then
            PictureBox6.Image = My.Resources.icons8_cannon_100
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub
End Class