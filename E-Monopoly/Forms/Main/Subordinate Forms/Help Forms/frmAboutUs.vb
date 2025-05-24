Public Class frmAboutUs

    Private Sub butExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExit.Click
        Close()
    End Sub

    Private Sub butMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        ElseIf Me.WindowState = formWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized

        Else
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmHelp.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If My.Computer.Network.IsAvailable Then
            
            Process.Start("https://www.amazon.in/Funskool-Monopoly-Deluxe/dp/B009PGE2YK")
        Else
            
            MsgBox("Sorry the network isn't available at this movement, please try again later", vbOKOnly + vbExclamation)
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If My.Computer.Network.IsAvailable Then

            Process.Start("https://www.flipkart.com/monopoly-deluxe-money-assets-games-board-game/p/itma20515be38949?pid=BDGFPUKHPDAZVZAQ&lid=LSTBDGFPUKHPDAZVZAQPWDFG0&marketplace=FLIPKART&srno=s_1_1&otracker=AS_QueryStore_OrganicAutoSuggest_1_15_sc_na_na&otracker1=AS_QueryStore_OrganicAutoSuggest_1_15_sc_na_na&fm=SEARCH&iid=e30088b4-beb0-4fe0-a0ba-c239db3fcf50.BDGFPUKHPDAZVZAQ.SEARCH&ppt=sp&ppn=sp&ssid=k7ihnyli1c0000001602078903165&qH=c67af8cedb77f891")
        Else

            MsgBox("Sorry the network isn't available at this movement, please try again later", vbOKOnly + vbExclamation)
        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        If My.Computer.Network.IsAvailable Then

            Process.Start("https://mail.google.com/mail/u/0/#inbox?compose=CllgCJZWxNwwjvKBdZncFXXmXHrTrSHLGwLRSVlLDTtJdJlfLVfslTwQKbhTFWtSTfQtFTSfnQq")
        Else

            MsgBox("Sorry the network isn't available at this movement, please try again later", vbOKOnly + vbExclamation)
        End If
    End Sub
End Class