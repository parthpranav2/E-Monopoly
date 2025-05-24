Public Class frmPropertyDatabase
    Private Sub ChartHotel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChartProperty_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SplitContainer3_SplitterMoved(sender As Object, e As SplitterEventArgs)

    End Sub

    Private Sub SplitContainer5_SplitterMoved(sender As Object, e As SplitterEventArgs)

    End Sub

    Private Sub ChartHouse_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub SplitContainer4_SplitterMoved(sender As Object, e As SplitterEventArgs)

    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub

    Private Sub ChartMoney_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SplitContainer2_SplitterMoved(sender As Object, e As SplitterEventArgs)

    End Sub

    Private Sub CostBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CostBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PropertyInfoDataSet)

    End Sub

    Private Sub frmPropertyDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PropertyInfoDataSet.Rent' table. You can move, or remove it, as needed.
        Me.RentTableAdapter.Fill(Me.PropertyInfoDataSet.Rent)
        'TODO: This line of code loads data into the 'PropertyInfoDataSet.Cost' table. You can move, or remove it, as needed.
        Me.CostTableAdapter.Fill(Me.PropertyInfoDataSet.Cost)

    End Sub

    Private Sub RentDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles RentDataGridView.CellContentDoubleClick

    End Sub

    Dim CostSelected As String 
    Dim RentSelected As String

    Private Sub CostDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles CostDataGridView.CellDoubleClick
        If e.ColumnIndex >= 0 And e.ColumnIndex <= 5 Then
            Dim row As DataGridViewRow = CostDataGridView.Rows(e.RowIndex)

            CostSelected = row.Cells(1).Value.ToString
            TextBox.Text = CostSelected

            PropertyFinder()
        End If
    End Sub

    Private Sub CostDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CostDataGridView.CellMouseDoubleClick

    End Sub

    Private Sub RentDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles RentDataGridView.CellDoubleClick
        If e.ColumnIndex >= 0 And e.ColumnIndex <= 7 Then
            Dim row As DataGridViewRow = RentDataGridView.Rows(e.RowIndex)

            RentSelected = row.Cells(1).Value.ToString
            TextBox.Text = RentSelected

            PropertyFinder()
        End If
    End Sub


    Private Sub PropertyFinder()
        EMonopoly.CheckedListBoxP1Sold.SelectedItem = Nothing
        EMonopoly.CheckedListBoxP2Sold.SelectedItem = Nothing
        EMonopoly.CheckedListBoxP3Sold.SelectedItem = Nothing
        EMonopoly.CheckedListBoxP4Sold.SelectedItem = Nothing
        EMonopoly.CheckedListBoxP5Sold.SelectedItem = Nothing
        EMonopoly.CheckedListBoxP6Sold.SelectedItem = Nothing
        EMonopoly.CheckedListBoxP7Sold.SelectedItem = Nothing
        EMonopoly.CheckedListBoxP8Sold.SelectedItem = Nothing
        EMonopoly.CheckedListBoxPN.SelectedItem = Nothing

        If My.Settings.NoofPlayers = 2 Then '2
            Try
                EMonopoly.CheckedListBoxP1Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP1Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp1.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P1Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP2Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP2Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp2.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P2Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxPN.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxPN.SelectedItem = Nothing Then
                Else
                    MsgBox("The property is yet to be sold...")
                End If
            Catch ex As Exception

            End Try

        ElseIf My.Settings.NoofPlayers = 3 Then '3
            Try
                EMonopoly.CheckedListBoxP1Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP1Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp1.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P1Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP2Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP2Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp2.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P2Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP3Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP3Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp3.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P3Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxPN.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxPN.SelectedItem = Nothing Then
                Else
                    MsgBox("The property is yet to be sold...")
                End If
            Catch ex As Exception

            End Try

        ElseIf My.Settings.NoofPlayers = 4 Then '4
            Try
                EMonopoly.CheckedListBoxP1Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP1Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp1.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P1Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP2Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP2Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp2.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P2Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP3Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP3Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp3.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P3Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP4Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP4Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp4.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P4Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If

            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxPN.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxPN.SelectedItem = Nothing Then
                Else
                    MsgBox("The property is yet to be sold...")
                End If
            Catch ex As Exception

            End Try

        ElseIf My.Settings.NoofPlayers = 5 Then '5
            Try
                EMonopoly.CheckedListBoxP1Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP1Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp1.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P1Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP2Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP2Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp2.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P2Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP3Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP3Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp3.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P3Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP4Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP4Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp4.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P4Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP5Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP5Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp5.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P5Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxPN.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxPN.SelectedItem = Nothing Then
                Else
                    MsgBox("The property is yet to be sold...")
                End If
            Catch ex As Exception

            End Try

        ElseIf My.Settings.NoofPlayers = 6 Then  '6
            Try
                EMonopoly.CheckedListBoxP1Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP1Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp1.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P1Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP2Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP2Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp2.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P2Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP3Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP3Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp3.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P3Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP4Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP4Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp4.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P4Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP5Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP5Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp5.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P5Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP6Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP6Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp6.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P6Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxPN.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxPN.SelectedItem = Nothing Then
                Else
                    MsgBox("The property is yet to be sold...")
                End If
            Catch ex As Exception

            End Try

        ElseIf My.Settings.NoofPlayers = 7 Then  '7
            Try
                EMonopoly.CheckedListBoxP1Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP1Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp1.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P1Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP2Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP2Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp2.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P2Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP3Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP3Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp3.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P3Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP4Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP4Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp4.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P4Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP5Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP5Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp5.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P5Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP6Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP6Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp6.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P6Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP7Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP7Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp7.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P7Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxPN.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxPN.SelectedItem = Nothing Then
                Else
                    MsgBox("The property is yet to be sold...")
                End If
            Catch ex As Exception

            End Try

        ElseIf My.Settings.NoofPlayers = 8 Then '8
            Try
                EMonopoly.CheckedListBoxP1Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP1Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp1.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P1Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP2Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP2Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp2.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P2Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP3Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP3Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp3.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P3Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP4Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP4Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp4.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P4Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP5Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP5Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp5.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P5Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP6Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP6Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp6.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P6Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP7Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP7Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp7.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P7Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxP8Sold.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxP8Sold.SelectedItem = Nothing Then
                Else
                    MsgBox("" + EMonopoly.lblp8.Text + " has the property")
                    frmPlayerInfo.Show()
                    frmPlayerInfo.P8Show()
                    frmPlayerInfo.ListBoxPrimary.SelectedItem = TextBox.Text
                End If
            Catch ex As Exception

            End Try

            Try
                EMonopoly.CheckedListBoxPN.SelectedItem = TextBox.Text
                If EMonopoly.CheckedListBoxPN.SelectedItem = Nothing Then
                Else
                    MsgBox("The property is yet to be sold...")
                End If
            Catch ex As Exception

            End Try
        Else

        End If
    End Sub

End Class