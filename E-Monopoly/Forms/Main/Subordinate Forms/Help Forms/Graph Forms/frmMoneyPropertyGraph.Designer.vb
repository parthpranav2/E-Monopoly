<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMoneyPropertyGraph
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMoneyPropertyGraph))
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.butMaximize = New System.Windows.Forms.Button()
        Me.butExit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChartMoney = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Chartproperty = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.butRefresh = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ChartMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Chartproperty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.butRefresh)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 603)
        Me.Panel1.TabIndex = 158
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(30, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 120)
        Me.Button1.TabIndex = 154
        Me.Button1.Text = "Get More Details"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(30, 58)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 82)
        Me.Button2.TabIndex = 153
        Me.Button2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = True
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(160, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(777, 32)
        Me.Panel2.TabIndex = 161
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Money, Property Graph"
        '
        'ChartMoney
        '
        ChartArea3.Name = "ChartArea1"
        Me.ChartMoney.ChartAreas.Add(ChartArea3)
        Me.ChartMoney.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.Name = "Legend1"
        Me.ChartMoney.Legends.Add(Legend3)
        Me.ChartMoney.Location = New System.Drawing.Point(0, 0)
        Me.ChartMoney.Name = "ChartMoney"
        Series3.ChartArea = "ChartArea1"
        Series3.Color = System.Drawing.Color.DodgerBlue
        Series3.Legend = "Legend1"
        Series3.Name = "MONEY"
        Series3.YValuesPerPoint = 2
        Me.ChartMoney.Series.Add(Series3)
        Me.ChartMoney.Size = New System.Drawing.Size(777, 285)
        Me.ChartMoney.TabIndex = 162
        Me.ChartMoney.Text = "Chart1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(160, 32)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ChartMoney)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Chartproperty)
        Me.SplitContainer1.Size = New System.Drawing.Size(777, 571)
        Me.SplitContainer1.SplitterDistance = 285
        Me.SplitContainer1.TabIndex = 163
        '
        'Chartproperty
        '
        ChartArea4.Name = "ChartArea1"
        Me.Chartproperty.ChartAreas.Add(ChartArea4)
        Me.Chartproperty.Dock = System.Windows.Forms.DockStyle.Fill
        Legend4.Name = "Legend1"
        Me.Chartproperty.Legends.Add(Legend4)
        Me.Chartproperty.Location = New System.Drawing.Point(0, 0)
        Me.Chartproperty.Name = "Chartproperty"
        Series4.ChartArea = "ChartArea1"
        Series4.Color = System.Drawing.Color.Orange
        Series4.Legend = "Legend1"
        Series4.Name = "PROPERTY"
        Me.Chartproperty.Series.Add(Series4)
        Me.Chartproperty.Size = New System.Drawing.Size(777, 282)
        Me.Chartproperty.TabIndex = 163
        Me.Chartproperty.Text = "Chart1"
        '
        'butRefresh
        '
        Me.butRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butRefresh.FlatAppearance.BorderSize = 0
        Me.butRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butRefresh.Image = Global.E_Monopoly.My.Resources.Resources.icons8_refresh_30
        Me.butRefresh.Location = New System.Drawing.Point(40, 166)
        Me.butRefresh.Name = "butRefresh"
        Me.butRefresh.Size = New System.Drawing.Size(68, 63)
        Me.butRefresh.TabIndex = 155
        Me.butRefresh.Text = "Refresh"
        Me.butRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.butRefresh.UseVisualStyleBackColor = True
        '
        'frmMoneyPropertyGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 603)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMoneyPropertyGraph"
        Me.Text = "frmMoneyPropertyGraph"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ChartMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Chartproperty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents butMaximize As Button
    Friend WithEvents butExit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ChartMoney As DataVisualization.Charting.Chart
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Chartproperty As DataVisualization.Charting.Chart
    Friend WithEvents Button1 As Button
    Friend WithEvents butRefresh As Button
End Class
