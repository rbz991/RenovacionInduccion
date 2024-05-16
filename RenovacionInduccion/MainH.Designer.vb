<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainH
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
        Me.components = New System.ComponentModel.Container()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.tmrHoldUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStart = New System.Windows.Forms.Timer(Me.components)
        Me.lblReforzadores = New System.Windows.Forms.Label()
        Me.tmrVI = New System.Windows.Forms.Timer(Me.components)
        Me.pctRat = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tmrRatJump = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pctRat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(348, 6)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(46, 22)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'tmrHoldUp
        '
        Me.tmrHoldUp.Interval = 1000
        '
        'tmrStart
        '
        '
        'lblReforzadores
        '
        Me.lblReforzadores.AutoSize = True
        Me.lblReforzadores.Location = New System.Drawing.Point(652, 5)
        Me.lblReforzadores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReforzadores.Name = "lblReforzadores"
        Me.lblReforzadores.Size = New System.Drawing.Size(13, 13)
        Me.lblReforzadores.TabIndex = 14
        Me.lblReforzadores.Text = "0"
        '
        'tmrVI
        '
        '
        'pctRat
        '
        Me.pctRat.BackColor = System.Drawing.Color.Transparent
        Me.pctRat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pctRat.Image = Global.RenovacionInduccion.My.Resources.Resources.rat
        Me.pctRat.Location = New System.Drawing.Point(245, 153)
        Me.pctRat.Margin = New System.Windows.Forms.Padding(2)
        Me.pctRat.Name = "pctRat"
        Me.pctRat.Size = New System.Drawing.Size(149, 84)
        Me.pctRat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctRat.TabIndex = 13
        Me.pctRat.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(76, 185)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 12)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tmrRatJump
        '
        Me.tmrRatJump.Interval = 5
        '
        'MainH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RenovacionInduccion.My.Resources.Resources.fondoCalle
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(670, 350)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblReforzadores)
        Me.Controls.Add(Me.pctRat)
        Me.Controls.Add(Me.Button5)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainH"
        Me.Text = "Form1"
        CType(Me.pctRat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button5 As Button
    Friend WithEvents tmrHoldUp As Timer
    Friend WithEvents pctRat As PictureBox
    Friend WithEvents tmrStart As Timer
    Friend WithEvents lblReforzadores As Label
    Friend WithEvents tmrVI As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents tmrRatJump As Timer
End Class
