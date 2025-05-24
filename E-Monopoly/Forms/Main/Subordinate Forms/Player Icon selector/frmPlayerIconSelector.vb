Public Class frmPlayerIconSelector

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmPlayerIcon.Show()
        Me.Close()
    End Sub

    Private Sub Shoe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Shoe.Click
        If My.Settings.IconSelector = 1 Then
            My.Settings.Player1Icon = "Shoe"
        End If

        If My.Settings.IconSelector = 2 Then
            My.Settings.Player2Icon = "Shoe"
        End If

        If My.Settings.IconSelector = 3 Then
            My.Settings.Player3Icon = "Shoe"
        End If

        If My.Settings.IconSelector = 4 Then
            My.Settings.Player4Icon = "Shoe"
        End If

        If My.Settings.IconSelector = 5 Then
            My.Settings.Player5Icon = "Shoe"
        End If

        If My.Settings.IconSelector = 6 Then
            My.Settings.Player6Icon = "Shoe"
        End If

        If My.Settings.IconSelector = 7 Then
            My.Settings.Player7Icon = "Shoe"
            Shoe.Text = frmPlayerIcon.Label7.Text
        End If

        If My.Settings.IconSelector = 8 Then
            My.Settings.Player8Icon = "Shoe"
        End If

        frmPlayerIcon.Show()
        Me.Close()
    End Sub

    Private Sub PlayerIconSelector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.Player1Icon = "Hat" Or My.Settings.Player2Icon = "Hat" Or My.Settings.Player3Icon = "Hat" Or My.Settings.Player4Icon = "Hat" Or My.Settings.Player5Icon = "Hat" Or My.Settings.Player6Icon = "Hat" Or My.Settings.Player7Icon = "Hat" Or My.Settings.Player8Icon = "Hat" Then
            Hat.Enabled = False
        End If

        If My.Settings.Player1Icon = "Iron" Or My.Settings.Player2Icon = "Iron" Or My.Settings.Player3Icon = "Iron" Or My.Settings.Player4Icon = "Iron" Or My.Settings.Player5Icon = "Iron" Or My.Settings.Player6Icon = "Iron" Or My.Settings.Player7Icon = "Iron" Or My.Settings.Player8Icon = "Iron" Then
            Iron.Enabled = False
        End If

        If My.Settings.Player1Icon = "Carriage" Or My.Settings.Player2Icon = "Carriage" Or My.Settings.Player3Icon = "Carriage" Or My.Settings.Player4Icon = "Carriage" Or My.Settings.Player5Icon = "Carriage" Or My.Settings.Player6Icon = "Carriage" Or My.Settings.Player7Icon = "Carriage" Or My.Settings.Player8Icon = "Carriage" Then
            Carriage.Enabled = False
        End If

        If My.Settings.Player1Icon = "Horse" Or My.Settings.Player2Icon = "Horse" Or My.Settings.Player3Icon = "Horse" Or My.Settings.Player4Icon = "Horse" Or My.Settings.Player5Icon = "Horse" Or My.Settings.Player6Icon = "Horse" Or My.Settings.Player7Icon = "Horse" Or My.Settings.Player8Icon = "Horse" Then
            Horse.Enabled = False
        End If

        If My.Settings.Player1Icon = "Dog" Or My.Settings.Player2Icon = "Dog" Or My.Settings.Player3Icon = "Dog" Or My.Settings.Player4Icon = "Dog" Or My.Settings.Player5Icon = "Dog" Or My.Settings.Player6Icon = "Dog" Or My.Settings.Player7Icon = "Dog" Or My.Settings.Player8Icon = "Dog" Then
            Dog.Enabled = False
        End If

        If My.Settings.Player1Icon = "Shoe" Or My.Settings.Player2Icon = "Shoe" Or My.Settings.Player3Icon = "Shoe" Or My.Settings.Player4Icon = "Shoe" Or My.Settings.Player5Icon = "Shoe" Or My.Settings.Player6Icon = "Shoe" Or My.Settings.Player7Icon = "Shoe" Or My.Settings.Player8Icon = "Shoe" Then
            Shoe.Enabled = False
        End If

        If My.Settings.Player1Icon = "Ship" Or My.Settings.Player2Icon = "Ship" Or My.Settings.Player3Icon = "Ship" Or My.Settings.Player4Icon = "Ship" Or My.Settings.Player5Icon = "Ship" Or My.Settings.Player6Icon = "Ship" Or My.Settings.Player7Icon = "Ship" Or My.Settings.Player8Icon = "Ship" Then
            Ship.Enabled = False
        End If

        If My.Settings.Player1Icon = "Car" Or My.Settings.Player2Icon = "Car" Or My.Settings.Player3Icon = "Car" Or My.Settings.Player4Icon = "Car" Or My.Settings.Player5Icon = "Car" Or My.Settings.Player6Icon = "Car" Or My.Settings.Player7Icon = "Car" Or My.Settings.Player8Icon = "Car" Then
            Car.Enabled = False
        End If

        If My.Settings.Player1Icon = "Cap" Or My.Settings.Player2Icon = "Cap" Or My.Settings.Player3Icon = "Cap" Or My.Settings.Player4Icon = "Cap" Or My.Settings.Player5Icon = "Cap" Or My.Settings.Player6Icon = "Cap" Or My.Settings.Player7Icon = "Cap" Or My.Settings.Player8Icon = "Cap" Then
            Cap.Enabled = False
        End If

        If My.Settings.Player1Icon = "Cannon" Or My.Settings.Player2Icon = "Cannon" Or My.Settings.Player3Icon = "Cannon" Or My.Settings.Player4Icon = "Cannon" Or My.Settings.Player5Icon = "Cannon" Or My.Settings.Player6Icon = "Cannon" Or My.Settings.Player7Icon = "Cannon" Or My.Settings.Player8Icon = "Cannon" Then
            Cannon.Enabled = False
        End If

    End Sub

    Private Sub Hat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hat.Click
        If My.Settings.IconSelector = 1 Then
            My.Settings.Player1Icon = "Hat"
        End If

        If My.Settings.IconSelector = 2 Then
            My.Settings.Player2Icon = "Hat"
        End If

        If My.Settings.IconSelector = 3 Then
            My.Settings.Player3Icon = "Hat"
        End If

        If My.Settings.IconSelector = 4 Then
            My.Settings.Player4Icon = "Hat"
        End If

        If My.Settings.IconSelector = 5 Then
            My.Settings.Player5Icon = "Hat"
        End If

        If My.Settings.IconSelector = 6 Then
            My.Settings.Player6Icon = "Hat"
        End If

        If My.Settings.IconSelector = 7 Then
            My.Settings.Player7Icon = "Hat"
        End If

        If My.Settings.IconSelector = 8 Then
            My.Settings.Player8Icon = "Hat"
        End If

        frmPlayerIcon.Show()
        Me.Close()
    End Sub

    Private Sub Iron_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Iron.Click
        If My.Settings.IconSelector = 1 Then
            My.Settings.Player1Icon = "Iron"
        End If

        If My.Settings.IconSelector = 2 Then
            My.Settings.Player2Icon = "Iron"
        End If

        If My.Settings.IconSelector = 3 Then
            My.Settings.Player3Icon = "Iron"
        End If

        If My.Settings.IconSelector = 4 Then
            My.Settings.Player4Icon = "Iron"
        End If

        If My.Settings.IconSelector = 5 Then
            My.Settings.Player5Icon = "Iron"
        End If

        If My.Settings.IconSelector = 6 Then
            My.Settings.Player6Icon = "Iron"
        End If

        If My.Settings.IconSelector = 7 Then
            My.Settings.Player7Icon = "Iron"
        End If

        If My.Settings.IconSelector = 8 Then
            My.Settings.Player8Icon = "Iron"
        End If

        frmPlayerIcon.Show()
        Me.Close()
    End Sub

    Private Sub Carriage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Carriage.Click
        If My.Settings.IconSelector = 1 Then
            My.Settings.Player1Icon = "Carriage"
        End If

        If My.Settings.IconSelector = 2 Then
            My.Settings.Player2Icon = "Carriage"
        End If

        If My.Settings.IconSelector = 3 Then
            My.Settings.Player3Icon = "Carriage"
        End If

        If My.Settings.IconSelector = 4 Then
            My.Settings.Player4Icon = "Carriage"
        End If

        If My.Settings.IconSelector = 5 Then
            My.Settings.Player5Icon = "Carriage"
        End If

        If My.Settings.IconSelector = 6 Then
            My.Settings.Player6Icon = "Carriage"
        End If

        If My.Settings.IconSelector = 7 Then
            My.Settings.Player7Icon = "Carriage"
        End If

        If My.Settings.IconSelector = 8 Then
            My.Settings.Player8Icon = "Carriage"
        End If

        frmPlayerIcon.Show()
        Me.Close()
    End Sub

    Private Sub Horse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Horse.Click
        If My.Settings.IconSelector = 1 Then
            My.Settings.Player1Icon = "Horse"
        End If

        If My.Settings.IconSelector = 2 Then
            My.Settings.Player2Icon = "Horse"
        End If

        If My.Settings.IconSelector = 3 Then
            My.Settings.Player3Icon = "Horse"
        End If

        If My.Settings.IconSelector = 4 Then
            My.Settings.Player4Icon = "Horse"
        End If

        If My.Settings.IconSelector = 5 Then
            My.Settings.Player5Icon = "Horse"
        End If

        If My.Settings.IconSelector = 6 Then
            My.Settings.Player6Icon = "Horse"
        End If

        If My.Settings.IconSelector = 7 Then
            My.Settings.Player7Icon = "Horse"
        End If

        If My.Settings.IconSelector = 8 Then
            My.Settings.Player8Icon = "Horse"
        End If

        frmPlayerIcon.Show()
        Me.Close()
    End Sub

    Private Sub Dog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dog.Click
        If My.Settings.IconSelector = 1 Then
            My.Settings.Player1Icon = "Dog"
        End If

        If My.Settings.IconSelector = 2 Then
            My.Settings.Player2Icon = "Dog"
        End If

        If My.Settings.IconSelector = 3 Then
            My.Settings.Player3Icon = "Dog"
        End If

        If My.Settings.IconSelector = 4 Then
            My.Settings.Player4Icon = "Dog"
        End If

        If My.Settings.IconSelector = 5 Then
            My.Settings.Player5Icon = "Dog"
        End If

        If My.Settings.IconSelector = 6 Then
            My.Settings.Player6Icon = "Dog"
        End If

        If My.Settings.IconSelector = 7 Then
            My.Settings.Player7Icon = "Dog"
        End If

        If My.Settings.IconSelector = 8 Then
            My.Settings.Player8Icon = "Dog"
        End If

        frmPlayerIcon.Show()
        Me.Close()
    End Sub

    Private Sub Ship_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ship.Click
        If My.Settings.IconSelector = 1 Then
            My.Settings.Player1Icon = "Ship"
        End If

        If My.Settings.IconSelector = 2 Then
            My.Settings.Player2Icon = "Ship"
        End If

        If My.Settings.IconSelector = 3 Then
            My.Settings.Player3Icon = "Ship"
        End If

        If My.Settings.IconSelector = 4 Then
            My.Settings.Player4Icon = "Ship"
        End If

        If My.Settings.IconSelector = 5 Then
            My.Settings.Player5Icon = "Ship"
        End If

        If My.Settings.IconSelector = 6 Then
            My.Settings.Player6Icon = "Ship"
        End If

        If My.Settings.IconSelector = 7 Then
            My.Settings.Player7Icon = "Ship"
        End If

        If My.Settings.IconSelector = 8 Then
            My.Settings.Player8Icon = "Ship"
        End If

        frmPlayerIcon.Show()
        Me.Close()
    End Sub

    Private Sub Car_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Car.Click
        If My.Settings.IconSelector = 1 Then
            My.Settings.Player1Icon = "Car"
        End If

        If My.Settings.IconSelector = 2 Then
            My.Settings.Player2Icon = "Car"
        End If

        If My.Settings.IconSelector = 3 Then
            My.Settings.Player3Icon = "Car"
        End If

        If My.Settings.IconSelector = 4 Then
            My.Settings.Player4Icon = "Car"
        End If

        If My.Settings.IconSelector = 5 Then
            My.Settings.Player5Icon = "Car"
        End If

        If My.Settings.IconSelector = 6 Then
            My.Settings.Player6Icon = "Car"
        End If

        If My.Settings.IconSelector = 7 Then
            My.Settings.Player7Icon = "Car"
        End If

        If My.Settings.IconSelector = 8 Then
            My.Settings.Player8Icon = "Car"
        End If

        frmPlayerIcon.Show()
        Me.Close()
    End Sub

    Private Sub Cap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cap.Click
        If My.Settings.IconSelector = 1 Then
            My.Settings.Player1Icon = "Cap"
        End If

        If My.Settings.IconSelector = 2 Then
            My.Settings.Player2Icon = "Cap"
        End If

        If My.Settings.IconSelector = 3 Then
            My.Settings.Player3Icon = "Cap"
        End If

        If My.Settings.IconSelector = 4 Then
            My.Settings.Player4Icon = "Cap"
        End If

        If My.Settings.IconSelector = 5 Then
            My.Settings.Player5Icon = "Cap"
        End If

        If My.Settings.IconSelector = 6 Then
            My.Settings.Player6Icon = "Cap"
        End If

        If My.Settings.IconSelector = 7 Then
            My.Settings.Player7Icon = "Cap"
        End If

        If My.Settings.IconSelector = 8 Then
            My.Settings.Player8Icon = "Cap"
        End If

        frmPlayerIcon.Show()
        Me.Close()
    End Sub

    Private Sub Cannon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cannon.Click
        If My.Settings.IconSelector = 1 Then
            My.Settings.Player1Icon = "Cannon"
        End If

        If My.Settings.IconSelector = 2 Then
            My.Settings.Player2Icon = "Cannon"
        End If

        If My.Settings.IconSelector = 3 Then
            My.Settings.Player3Icon = "Cannon"
        End If

        If My.Settings.IconSelector = 4 Then
            My.Settings.Player4Icon = "Cannon"
        End If

        If My.Settings.IconSelector = 5 Then
            My.Settings.Player5Icon = "Cannon"
        End If

        If My.Settings.IconSelector = 6 Then
            My.Settings.Player6Icon = "Cannon"
        End If

        If My.Settings.IconSelector = 7 Then
            My.Settings.Player7Icon = "Cannon"
        End If

        If My.Settings.IconSelector = 8 Then
            My.Settings.Player8Icon = "Cannon"
        End If

        frmPlayerIcon.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If My.Settings.IconSelector = 1 Then
            My.Settings.Player1Icon = Nothing
        End If

        If My.Settings.IconSelector = 2 Then
            My.Settings.Player2Icon = Nothing
        End If

        If My.Settings.IconSelector = 3 Then
            My.Settings.Player3Icon = Nothing
        End If

        If My.Settings.IconSelector = 4 Then
            My.Settings.Player4Icon = Nothing
        End If

        If My.Settings.IconSelector = 5 Then
            My.Settings.Player5Icon = Nothing
        End If

        If My.Settings.IconSelector = 6 Then
            My.Settings.Player6Icon = Nothing
        End If

        If My.Settings.IconSelector = 7 Then
            My.Settings.Player7Icon = Nothing
        End If

        If My.Settings.IconSelector = 8 Then
            My.Settings.Player8Icon = Nothing
        End If

        MsgBox("By this function your icon will be cleared", vbOKOnly + vbExclamation)

        frmPlayerIcon.Show()
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class