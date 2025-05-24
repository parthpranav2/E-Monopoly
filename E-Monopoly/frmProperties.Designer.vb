<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProperties
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProperties))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblp1Currency = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.PropertiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._E_Monopoly__properties_DataSet = New E_Monopoly._E_Monopoly__properties_DataSet()
        Me.Property_NameTextBox = New System.Windows.Forms.TextBox()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.RentTextBox = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PropertiesTableAdapter = New E_Monopoly._E_Monopoly__properties_DataSetTableAdapters.PropertiesTableAdapter()
        Me.TableAdapterManager = New E_Monopoly._E_Monopoly__properties_DataSetTableAdapters.TableAdapterManager()
        Me.PropertiesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.butMaximize = New System.Windows.Forms.Button()
        Me.butExit = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        IDLabel = New System.Windows.Forms.Label()
        Property_NameLabel = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        RentLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PropertiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._E_Monopoly__properties_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PropertiesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(12, 187)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 153
        IDLabel.Text = "ID:"
        '
        'Property_NameLabel
        '
        Property_NameLabel.AutoSize = True
        Property_NameLabel.Location = New System.Drawing.Point(12, 213)
        Property_NameLabel.Name = "Property_NameLabel"
        Property_NameLabel.Size = New System.Drawing.Size(80, 13)
        Property_NameLabel.TabIndex = 155
        Property_NameLabel.Text = "Property Name:"
        '
        'CostLabel
        '
        CostLabel.AutoSize = True
        CostLabel.Location = New System.Drawing.Point(12, 239)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(31, 13)
        CostLabel.TabIndex = 157
        CostLabel.Text = "Cost:"
        '
        'RentLabel
        '
        RentLabel.AutoSize = True
        RentLabel.Location = New System.Drawing.Point(12, 265)
        RentLabel.Name = "RentLabel"
        RentLabel.Size = New System.Drawing.Size(33, 13)
        RentLabel.TabIndex = 159
        RentLabel.Text = "Rent:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblp1Currency)
        Me.Panel1.Controls.Add(IDLabel)
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Controls.Add(Property_NameLabel)
        Me.Panel1.Controls.Add(Me.Property_NameTextBox)
        Me.Panel1.Controls.Add(CostLabel)
        Me.Panel1.Controls.Add(Me.CostTextBox)
        Me.Panel1.Controls.Add(RentLabel)
        Me.Panel1.Controls.Add(Me.RentTextBox)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 491)
        Me.Panel1.TabIndex = 155
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.PanEast
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(77, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 16)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "£"
        '
        'lblp1Currency
        '
        Me.lblp1Currency.AutoSize = True
        Me.lblp1Currency.Cursor = System.Windows.Forms.Cursors.PanEast
        Me.lblp1Currency.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp1Currency.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblp1Currency.Location = New System.Drawing.Point(77, 239)
        Me.lblp1Currency.Name = "lblp1Currency"
        Me.lblp1Currency.Size = New System.Drawing.Size(15, 16)
        Me.lblp1Currency.TabIndex = 161
        Me.lblp1Currency.Text = "£"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropertiesBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(98, 184)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 154
        '
        'PropertiesBindingSource
        '
        Me.PropertiesBindingSource.DataMember = "Properties"
        Me.PropertiesBindingSource.DataSource = Me._E_Monopoly__properties_DataSet
        '
        '_E_Monopoly__properties_DataSet
        '
        Me._E_Monopoly__properties_DataSet.DataSetName = "_E_Monopoly__properties_DataSet"
        Me._E_Monopoly__properties_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Property_NameTextBox
        '
        Me.Property_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropertiesBindingSource, "Property Name", True))
        Me.Property_NameTextBox.Enabled = False
        Me.Property_NameTextBox.Location = New System.Drawing.Point(98, 210)
        Me.Property_NameTextBox.Name = "Property_NameTextBox"
        Me.Property_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Property_NameTextBox.TabIndex = 156
        '
        'CostTextBox
        '
        Me.CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropertiesBindingSource, "Cost", True))
        Me.CostTextBox.Enabled = False
        Me.CostTextBox.Location = New System.Drawing.Point(98, 236)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CostTextBox.TabIndex = 158
        '
        'RentTextBox
        '
        Me.RentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PropertiesBindingSource, "Rent", True))
        Me.RentTextBox.Enabled = False
        Me.RentTextBox.Location = New System.Drawing.Point(98, 262)
        Me.RentTextBox.Name = "RentTextBox"
        Me.RentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RentTextBox.TabIndex = 160
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightGreen
        Me.Panel5.Controls.Add(Me.butMaximize)
        Me.Panel5.Controls.Add(Me.butExit)
        Me.Panel5.Location = New System.Drawing.Point(3, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(54, 21)
        Me.Panel5.TabIndex = 152
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(223, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(473, 34)
        Me.Panel2.TabIndex = 156
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Properties"
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
        'PropertiesDataGridView
        '
        Me.PropertiesDataGridView.AutoGenerateColumns = False
        Me.PropertiesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.PropertiesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PropertiesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.PropertiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PropertiesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.PropertiesDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PropertiesDataGridView.DataSource = Me.PropertiesBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PropertiesDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.PropertiesDataGridView.Location = New System.Drawing.Point(230, 42)
        Me.PropertiesDataGridView.MultiSelect = False
        Me.PropertiesDataGridView.Name = "PropertiesDataGridView"
        Me.PropertiesDataGridView.Size = New System.Drawing.Size(461, 436)
        Me.PropertiesDataGridView.TabIndex = 157
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Rent"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Rent"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cost"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cost"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Property Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Property Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(51, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 82)
        Me.Button2.TabIndex = 153
        Me.Button2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = True
        '
        'butMaximize
        '
        Me.butMaximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butMaximize.FlatAppearance.BorderSize = 0
        Me.butMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butMaximize.Image = CType(resources.GetObject("butMaximize.Image"), System.Drawing.Image)
        Me.butMaximize.Location = New System.Drawing.Point(27, 0)
        Me.butMaximize.Name = "butMaximize"
        Me.butMaximize.Size = New System.Drawing.Size(18, 18)
        Me.butMaximize.TabIndex = 160
        Me.butMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.butMaximize.UseVisualStyleBackColor = True
        '
        'butExit
        '
        Me.butExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butExit.FlatAppearance.BorderSize = 0
        Me.butExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butExit.Image = CType(resources.GetObject("butExit.Image"), System.Drawing.Image)
        Me.butExit.Location = New System.Drawing.Point(3, 0)
        Me.butExit.Name = "butExit"
        Me.butExit.Size = New System.Drawing.Size(18, 18)
        Me.butExit.TabIndex = 159
        Me.butExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.butExit.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(77, 320)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(75, 13)
        Me.LinkLabel1.TabIndex = 164
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Edit Properties"
        '
        'frmProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 491)
        Me.Controls.Add(Me.PropertiesDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProperties"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PropertiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._E_Monopoly__properties_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PropertiesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents butMaximize As System.Windows.Forms.Button
    Friend WithEvents butExit As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents _E_Monopoly__properties_DataSet As E_Monopoly._E_Monopoly__properties_DataSet
    Friend WithEvents PropertiesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PropertiesTableAdapter As E_Monopoly._E_Monopoly__properties_DataSetTableAdapters.PropertiesTableAdapter
    Friend WithEvents TableAdapterManager As E_Monopoly._E_Monopoly__properties_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PropertiesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Property_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblp1Currency As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
