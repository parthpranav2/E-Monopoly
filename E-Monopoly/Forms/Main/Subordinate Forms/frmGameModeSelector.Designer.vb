<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameModeSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGameModeSelector))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.butExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblGMSRGHistory = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.E_Monopoly.My.Resources.Resources.icons8_cash_100_overlay__1_
        Me.Button1.Location = New System.Drawing.Point(50, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 155)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "New Game"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.E_Monopoly.My.Resources.Resources.icons8_payment_history_100
        Me.Button2.Location = New System.Drawing.Point(233, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(177, 155)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Review Game History"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Panel1.Controls.Add(Me.butExit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(644, 35)
        Me.Panel1.TabIndex = 2
        '
        'butExit
        '
        Me.butExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butExit.FlatAppearance.BorderSize = 0
        Me.butExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butExit.Image = CType(resources.GetObject("butExit.Image"), System.Drawing.Image)
        Me.butExit.Location = New System.Drawing.Point(3, 6)
        Me.butExit.Name = "butExit"
        Me.butExit.Size = New System.Drawing.Size(18, 18)
        Me.butExit.TabIndex = 0
        Me.butExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.butExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Action"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.E_Monopoly.My.Resources.Resources.icons8_cash_100_overlay__2_
        Me.Button3.Location = New System.Drawing.Point(416, 52)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(177, 155)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Restore Game Progress"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblGMSRGHistory
        '
        Me.lblGMSRGHistory.AutoSize = True
        Me.lblGMSRGHistory.Location = New System.Drawing.Point(600, 203)
        Me.lblGMSRGHistory.Name = "lblGMSRGHistory"
        Me.lblGMSRGHistory.Size = New System.Drawing.Size(13, 13)
        Me.lblGMSRGHistory.TabIndex = 4
        Me.lblGMSRGHistory.Text = "0"
        Me.lblGMSRGHistory.Visible = False
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(50, 213)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(543, 76)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Settings"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmGameModeSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 305)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.lblGMSRGHistory)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGameModeSelector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGameModeSelector"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents lblGMSRGHistory As Label
    Friend WithEvents butExit As Button
    Friend WithEvents Button4 As Button
End Class
