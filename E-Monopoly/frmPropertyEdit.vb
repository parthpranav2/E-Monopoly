Public Class frmPropertyEdit

    Private Sub PropertiesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PropertiesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._E_Monopoly__properties_DataSet)

    End Sub

    Private Sub frmPropertyEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_E_Monopoly__properties_DataSet.Properties' table. You can move, or remove it, as needed.
        Me.PropertiesTableAdapter.Fill(Me._E_Monopoly__properties_DataSet.Properties)

    End Sub

    

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmProperties.Show()
        Me.Close()
    End Sub
End Class