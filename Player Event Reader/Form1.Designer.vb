<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListBoxFiles = New System.Windows.Forms.ListBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ListBoxD = New System.Windows.Forms.ListBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.lbFilterDirectory = New System.Windows.Forms.ListBox()
        Me.lbFilterPath = New System.Windows.Forms.ListBox()
        Me.rtcHistory = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.butMinimize = New System.Windows.Forms.Button()
        Me.butMaximize = New System.Windows.Forms.Button()
        Me.butExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxFiles
        '
        Me.ListBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxFiles.FormattingEnabled = True
        Me.ListBoxFiles.ItemHeight = 17
        Me.ListBoxFiles.Location = New System.Drawing.Point(0, 0)
        Me.ListBoxFiles.Name = "ListBoxFiles"
        Me.ListBoxFiles.Size = New System.Drawing.Size(270, 217)
        Me.ListBoxFiles.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ListBoxD)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ListBoxFiles)
        Me.SplitContainer2.Size = New System.Drawing.Size(270, 470)
        Me.SplitContainer2.SplitterDistance = 249
        Me.SplitContainer2.TabIndex = 0
        '
        'ListBoxD
        '
        Me.ListBoxD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxD.FormattingEnabled = True
        Me.ListBoxD.ItemHeight = 17
        Me.ListBoxD.Location = New System.Drawing.Point(0, 0)
        Me.ListBoxD.Name = "ListBoxD"
        Me.ListBoxD.Size = New System.Drawing.Size(270, 249)
        Me.ListBoxD.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(160, 39)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbFilterDirectory)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbFilterPath)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rtcHistory)
        Me.SplitContainer1.Size = New System.Drawing.Size(846, 521)
        Me.SplitContainer1.SplitterDistance = 270
        Me.SplitContainer1.TabIndex = 165
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer3.Panel1.Controls.Add(Me.cmbFilter)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer3.Size = New System.Drawing.Size(270, 521)
        Me.SplitContainer3.SplitterDistance = 47
        Me.SplitContainer3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Filter by player name :"
        '
        'cmbFilter
        '
        Me.cmbFilter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.Enabled = False
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Location = New System.Drawing.Point(0, 26)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(270, 21)
        Me.cmbFilter.TabIndex = 1
        '
        'lbFilterDirectory
        '
        Me.lbFilterDirectory.FormattingEnabled = True
        Me.lbFilterDirectory.Location = New System.Drawing.Point(479, 453)
        Me.lbFilterDirectory.Name = "lbFilterDirectory"
        Me.lbFilterDirectory.Size = New System.Drawing.Size(81, 56)
        Me.lbFilterDirectory.TabIndex = 166
        Me.lbFilterDirectory.Visible = False
        '
        'lbFilterPath
        '
        Me.lbFilterPath.FormattingEnabled = True
        Me.lbFilterPath.Location = New System.Drawing.Point(452, 426)
        Me.lbFilterPath.Name = "lbFilterPath"
        Me.lbFilterPath.Size = New System.Drawing.Size(120, 95)
        Me.lbFilterPath.TabIndex = 2
        Me.lbFilterPath.Visible = False
        '
        'rtcHistory
        '
        Me.rtcHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtcHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtcHistory.Location = New System.Drawing.Point(0, 0)
        Me.rtcHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.rtcHistory.Name = "rtcHistory"
        Me.rtcHistory.ReadOnly = True
        Me.rtcHistory.Size = New System.Drawing.Size(572, 521)
        Me.rtcHistory.TabIndex = 0
        Me.rtcHistory.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(373, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Player history"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(160, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(846, 39)
        Me.Panel2.TabIndex = 164
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 52)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "Note : Click Twice on the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "folder name in list box" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to open directly the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Main.l" &
    "og file"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightGreen
        Me.Panel5.Controls.Add(Me.butMinimize)
        Me.Panel5.Controls.Add(Me.butMaximize)
        Me.Panel5.Controls.Add(Me.butExit)
        Me.Panel5.Location = New System.Drawing.Point(3, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(75, 21)
        Me.Panel5.TabIndex = 152
        '
        'butMinimize
        '
        Me.butMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butMinimize.FlatAppearance.BorderSize = 0
        Me.butMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butMinimize.Image = Global.Player_Event_Reader.My.Resources.Resources.butMaximized
        Me.butMinimize.Location = New System.Drawing.Point(51, 0)
        Me.butMinimize.Name = "butMinimize"
        Me.butMinimize.Size = New System.Drawing.Size(18, 18)
        Me.butMinimize.TabIndex = 166
        Me.butMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.butMinimize.UseVisualStyleBackColor = True
        '
        'butMaximize
        '
        Me.butMaximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butMaximize.FlatAppearance.BorderSize = 0
        Me.butMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butMaximize.Image = Global.Player_Event_Reader.My.Resources.Resources.but_Minimize_2
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
        Me.butExit.Image = Global.Player_Event_Reader.My.Resources.Resources.butExit1
        Me.butExit.Location = New System.Drawing.Point(3, 0)
        Me.butExit.Name = "butExit"
        Me.butExit.Size = New System.Drawing.Size(18, 18)
        Me.butExit.TabIndex = 159
        Me.butExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.butExit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 560)
        Me.Panel1.TabIndex = 163
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Player_Event_Reader.My.Resources.Resources.icons8_file_85
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Location = New System.Drawing.Point(16, 73)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 112)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Select Another File"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 560)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Player Event Reader"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxFiles As ListBox
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents ListBoxD As ListBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents rtcHistory As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents butMaximize As Button
    Friend WithEvents butExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents butMinimize As Button
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbFilterPath As ListBox
    Friend WithEvents lbFilterDirectory As ListBox
End Class
