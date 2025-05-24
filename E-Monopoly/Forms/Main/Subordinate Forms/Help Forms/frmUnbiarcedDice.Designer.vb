<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnbiarcedDice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUnbiarcedDice))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.butMaximize = New System.Windows.Forms.Button()
        Me.butExit = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.butRollDie = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(194, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(834, 34)
        Me.Panel2.TabIndex = 157
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Unbiarceness of dice"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(194, 616)
        Me.Panel1.TabIndex = 156
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(40, 122)
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
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PictureBox8.Location = New System.Drawing.Point(476, 77)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(230, 230)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 183
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PictureBox7.Location = New System.Drawing.Point(205, 77)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(230, 230)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 182
        Me.PictureBox7.TabStop = False
        '
        'butRollDie
        '
        Me.butRollDie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butRollDie.FlatAppearance.BorderSize = 0
        Me.butRollDie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRollDie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butRollDie.ForeColor = System.Drawing.Color.Black
        Me.butRollDie.Image = Global.E_Monopoly.My.Resources.Resources.icons8_dice_20
        Me.butRollDie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.butRollDie.Location = New System.Drawing.Point(209, 393)
        Me.butRollDie.Name = "butRollDie"
        Me.butRollDie.Size = New System.Drawing.Size(501, 46)
        Me.butRollDie.TabIndex = 185
        Me.butRollDie.Text = "Roll"
        Me.butRollDie.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.ProgressBar1.Location = New System.Drawing.Point(205, 334)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(501, 32)
        Me.ProgressBar1.TabIndex = 184
        '
        'tmrTimer
        '
        Me.tmrTimer.Interval = 160
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(716, 34)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(312, 582)
        Me.ListBox1.TabIndex = 187
        '
        'frmUnbiarcedDice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 616)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.butRollDie)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUnbiarcedDice"
        Me.Text = "frmUnbiarcedDice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents butMaximize As Button
    Friend WithEvents butExit As Button
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents butRollDie As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents tmrTimer As Timer
    Friend WithEvents ListBox1 As ListBox
End Class
