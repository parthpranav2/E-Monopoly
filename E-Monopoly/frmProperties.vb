Public Class frmProperties

    Private Sub PropertiesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PropertiesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._E_Monopoly__properties_DataSet)

    End Sub

    Private Sub frmProperties_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_E_Monopoly__properties_DataSet.Properties' table. You can move, or remove it, as needed.
        Me.PropertiesTableAdapter.Fill(Me._E_Monopoly__properties_DataSet.Properties)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmHelp.Show()
        Me.Hide()
    End Sub

    Private Sub butMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butMaximize.Click
        If Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal

        ElseIf Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized

        Else
        End If
    End Sub

    Private Sub butExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExit.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PropertiesDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PropertiesDataGridView.CellContentClick

    End Sub

  
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmPropertyEdit.Show()
        Me.Close()
    End Sub
End Class