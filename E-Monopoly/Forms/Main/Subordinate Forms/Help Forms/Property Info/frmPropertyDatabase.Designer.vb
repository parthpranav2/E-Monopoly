<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPropertyDatabase
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabCost = New System.Windows.Forms.TabPage()
        Me.CostDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PropertyInfoDataSet = New E_Monopoly.PropertyInfoDataSet()
        Me.tabRent = New System.Windows.Forms.TabPage()
        Me.RentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.CostTableAdapter = New E_Monopoly.PropertyInfoDataSetTableAdapters.CostTableAdapter()
        Me.TableAdapterManager = New E_Monopoly.PropertyInfoDataSetTableAdapters.TableAdapterManager()
        Me.RentTableAdapter = New E_Monopoly.PropertyInfoDataSetTableAdapters.RentTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabCost.SuspendLayout()
        CType(Me.CostDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertyInfoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRent.SuspendLayout()
        CType(Me.RentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(973, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Size = New System.Drawing.Size(973, 606)
        Me.SplitContainer1.SplitterDistance = 554
        Me.SplitContainer1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabCost)
        Me.TabControl1.Controls.Add(Me.tabRent)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(973, 554)
        Me.TabControl1.TabIndex = 0
        '
        'tabCost
        '
        Me.tabCost.Controls.Add(Me.CostDataGridView)
        Me.tabCost.Location = New System.Drawing.Point(4, 22)
        Me.tabCost.Name = "tabCost"
        Me.tabCost.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCost.Size = New System.Drawing.Size(965, 528)
        Me.tabCost.TabIndex = 0
        Me.tabCost.Text = "Cost"
        Me.tabCost.UseVisualStyleBackColor = True
        '
        'CostDataGridView
        '
        Me.CostDataGridView.AutoGenerateColumns = False
        Me.CostDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CostDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.CostDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CostDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CostDataGridView.DataSource = Me.CostBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CostDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.CostDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CostDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.CostDataGridView.Name = "CostDataGridView"
        Me.CostDataGridView.ReadOnly = True
        Me.CostDataGridView.Size = New System.Drawing.Size(959, 522)
        Me.CostDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Property_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Property_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Property_Cost"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Property_Cost"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "House_Cost"
        Me.DataGridViewTextBoxColumn4.HeaderText = "House_Cost"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Hotel_Cost"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Hotel_Cost"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "MortageValue"
        Me.DataGridViewTextBoxColumn6.HeaderText = "MortageValue"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'CostBindingSource
        '
        Me.CostBindingSource.DataMember = "Cost"
        Me.CostBindingSource.DataSource = Me.PropertyInfoDataSet
        '
        'PropertyInfoDataSet
        '
        Me.PropertyInfoDataSet.DataSetName = "PropertyInfoDataSet"
        Me.PropertyInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tabRent
        '
        Me.tabRent.BackColor = System.Drawing.Color.White
        Me.tabRent.Controls.Add(Me.RentDataGridView)
        Me.tabRent.Location = New System.Drawing.Point(4, 22)
        Me.tabRent.Name = "tabRent"
        Me.tabRent.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRent.Size = New System.Drawing.Size(965, 528)
        Me.tabRent.TabIndex = 1
        Me.tabRent.Text = "Rent"
        '
        'RentDataGridView
        '
        Me.RentDataGridView.AutoGenerateColumns = False
        Me.RentDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.RentDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.RentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.RentDataGridView.DataSource = Me.RentBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RentDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.RentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RentDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.RentDataGridView.Name = "RentDataGridView"
        Me.RentDataGridView.ReadOnly = True
        Me.RentDataGridView.Size = New System.Drawing.Size(959, 522)
        Me.RentDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Property_Name"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Property_Name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SiteOnly"
        Me.DataGridViewTextBoxColumn9.HeaderText = "SiteOnly"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "1_House"
        Me.DataGridViewTextBoxColumn10.HeaderText = "1_House"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "2_House"
        Me.DataGridViewTextBoxColumn11.HeaderText = "2_House"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "3_House"
        Me.DataGridViewTextBoxColumn12.HeaderText = "3_House"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "4_House"
        Me.DataGridViewTextBoxColumn13.HeaderText = "4_House"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Hotel"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Hotel"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'RentBindingSource
        '
        Me.RentBindingSource.DataMember = "Rent"
        Me.RentBindingSource.DataSource = Me.PropertyInfoDataSet
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(560, 3)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(100, 20)
        Me.TextBox.TabIndex = 1
        Me.TextBox.Visible = False
        '
        'CostTableAdapter
        '
        Me.CostTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CostTableAdapter = Me.CostTableAdapter
        Me.TableAdapterManager.RentTableAdapter = Me.RentTableAdapter
        Me.TableAdapterManager.UpdateOrder = E_Monopoly.PropertyInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RentTableAdapter
        '
        Me.RentTableAdapter.ClearBeforeFill = True
        '
        'frmPropertyDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 606)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPropertyDatabase"
        Me.Text = "frmPropertyDatabase"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tabCost.ResumeLayout(False)
        CType(Me.CostDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertyInfoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRent.ResumeLayout(False)
        CType(Me.RentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabCost As TabPage
    Friend WithEvents tabRent As TabPage
    Friend WithEvents PropertyInfoDataSet As PropertyInfoDataSet
    Friend WithEvents CostBindingSource As BindingSource
    Friend WithEvents CostTableAdapter As PropertyInfoDataSetTableAdapters.CostTableAdapter
    Friend WithEvents TableAdapterManager As PropertyInfoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CostDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents RentTableAdapter As PropertyInfoDataSetTableAdapters.RentTableAdapter
    Friend WithEvents RentBindingSource As BindingSource
    Friend WithEvents RentDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox As TextBox
End Class
