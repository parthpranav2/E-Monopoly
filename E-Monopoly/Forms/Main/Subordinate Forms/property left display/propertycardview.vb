Public Class frmpropertycardview
    Private Sub frmpropertycardview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''code to centeralign the picture box
        Timer1.Interval = My.Settings.frmpropertyviewTimer
        Dim primaryScreenSize As Size = Screen.PrimaryScreen.Bounds.Size
        PictureBox1.Location = New Point((primaryScreenSize.Width) / 2 - (PictureBox1.Width) / 2, (primaryScreenSize.Height) / 2 - (PictureBox1.Height) / 2)
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
        frmBackground.Close()
    End Sub
    Public Sub UpdatePictureBoxImage(newImage As Image)
        PictureBox1.Image = newImage
    End Sub
End Class