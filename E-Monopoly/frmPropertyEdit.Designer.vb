<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPropertyEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim Property_NameLabel As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Dim RentLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPropertyEdit))
        Me._E_Monopoly__properties_DataSet = New E_Monopoly._E_Monopoly__properties_DataSet()
        Me.PropertiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PropertiesTableAdapter = New E_Monopoly._E_Monopoly__properties_DataSetTableAdapters.PropertiesTableAdapter()
        Me.TableAdapterManager = New E_Monopoly._E_Monopoly__properties_DataSetTableAdapters.TableAdapterManager()
        Me.PropertiesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropertiesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Property_NameTextBox = New System.Windows.Forms.TextBox()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.RentTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.PropertiesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        IDLabel = New System.Windows.Forms.Label()
        Property_NameLabel = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        RentLabel = New System.Windows.Forms.Label()
        CType(Me._E_Monopoly__properties_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertiesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PropertiesBindingNavigator.SuspendLayout()
        CType(Me.PropertiesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(12, 40)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 155
        IDLabel.Text = "ID:"
        '
        'Property_NameLabel
        '
        Property_NameLabel.AutoSize = True
        Property_NameLabel.Location = New System.Drawing.Point(12, 66)
        Property_NameLabel.Name = "Property_NameLabel"
        Property_NameLabel.Size = New System.Drawing.Size(80, 13)
        Property_NameLabel.TabIndex = 157
        Property_NameLabel.Text = "Property Name:"
        '
        'CostLabel
        '
        CostLabel.AutoSize = True
        CostLabel.Location = New System.Drawing.Point(12, 92)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(31, 13)
        CostLabel.TabIndex = 159
        CostLabel.Text = "Cost:"
        '
        'RentLabel
        '
        RentLabel.AutoSize = True
        RentLabel.Location = New System.Drawing.Point(12, 118)
        RentLabel.Name = "RentLabel"
        RentLabel.Size = New System.Drawing.Size(33, 13)
        RentLabel.TabIndex = 161
        RentLabel.Text = "Rent:"
        '
        '_E_Monopoly__properties_DataSet
        '
        Me._E_Monopoly__properties_DataSet.DataSetName = "_E_Monopoly__properties_DataSet"
        Me._E_Monopoly__properties_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PropertiesBindingSource
        '
        Me.PropertiesBindingSource.DataMember = "Properties"
        Me.PropertiesBindingSource.DataSource = Me._E_Monopoly__properties_DataSet
        '
        'PropertiesTableAdapter
        '
        Me.PropertiesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PropertiesTableAdapter = Me.PropertiesTableAdapter
        Me.TableAdapterManager.UpdateOrder = E_Monopoly._E_Monopoly__properties_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PropertiesBindingNavigator
        '
        Me.PropertiesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PropertiesBindingNavigator.BindingSource = Me.PropertiesBindingSource
        Me.PropertiesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PropertiesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PropertiesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PropertiesBindingNavigatorSaveItem})
        Me.PropertiesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PropertiesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PropertiesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PropertiesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PropertiesBindingNavigator.Name = "PropertiesBindingNavigator"
        Me.PropertiesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PropertiesBindingNavigator.Size = New System.Drawing.Size(688, 25)
        Me.PropertiesBindingNavigator.TabIndex = 0
        Me.PropertiesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PropertiesDataGridView
        '
        Me.PropertiesDataGridView.AutoGenerateColumns = False
        Me.PropertiesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.PropertiesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PropertiesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PropertiesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PropertiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PropertiesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.PropertiesDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PropertiesDataGridView.DataSource = Me.PropertiesBindingSource
        Me.PropertiesDataGridView.Location = New System.Drawing.Point(220, 28)
        Me.PropertiesDataGridView.Name = "PropertiesDataGridView"
        Me.PropertiesDataGridView.Size = New System.Drawing.Size(462, 402)
        Me.PropertiesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Property Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Property Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cost"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cost"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Rent"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Rent"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(IDLabel)
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Controls.Add(Property_NameLabel)
        Me.Panel1.Controls.Add(Me.Property_NameTextBox)
        Me.Panel1.Controls.Add(CostLabel)
        Me.Panel1.Controls.Add(Me.CostTextBox)
        Me.Panel1.Controls.Add(RentLabel)
        Me.Panel1.Controls.Add(Me.RentTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 417)
        Me.Panel1.TabIndex = 155
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropertiesBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(98, 37)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 156
        '
        'Property_NameTextBox
        '
        Me.Property_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropertiesBindingSource, "Property Name", True))
        Me.Property_NameTextBox.Location = New System.Drawing.Point(98, 63)
        Me.Property_NameTextBox.Name = "Property_NameTextBox"
        Me.Property_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Property_NameTextBox.TabIndex = 158
        '
        'CostTextBox
        '
        Me.CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropertiesBindingSource, "Cost", True))
        Me.CostTextBox.Location = New System.Drawing.Point(98, 89)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CostTextBox.TabIndex = 160
        '
        'RentTextBox
        '
        Me.RentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropertiesBindingSource, "Rent", True))
        Me.RentTextBox.Location = New System.Drawing.Point(98, 115)
        Me.RentTextBox.Name = "RentTextBox"
        Me.RentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RentTextBox.TabIndex = 162
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(59, 191)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 82)
        Me.Button2.TabIndex = 163
        Me.Button2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'PropertiesBindingNavigatorSaveItem
        '
        Me.PropertiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PropertiesBindingNavigatorSaveItem.Image = CType(resources.GetObject("PropertiesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PropertiesBindingNavigatorSaveItem.Name = "PropertiesBindingNavigatorSaveItem"
        Me.PropertiesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PropertiesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'frmPropertyEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(688, 442)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PropertiesDataGridView)
        Me.Controls.Add(Me.PropertiesBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPropertyEdit"
        Me.Text = "frmPropertyEdit"
        CType(Me._E_Monopoly__properties_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertiesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PropertiesBindingNavigator.ResumeLayout(False)
        Me.PropertiesBindingNavigator.PerformLayout()
        CType(Me.PropertiesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _E_Monopoly__properties_DataSet As E_Monopoly._E_Monopoly__properties_DataSet
    Friend WithEvents PropertiesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PropertiesTableAdapter As E_Monopoly._E_Monopoly__properties_DataSetTableAdapters.PropertiesTableAdapter
    Friend WithEvents TableAdapterManager As E_Monopoly._E_Monopoly__properties_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PropertiesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PropertiesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PropertiesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Property_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RentTextBox As System.Windows.Forms.TextBox
End Class
