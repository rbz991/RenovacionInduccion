﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.tmrHoldUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStart = New System.Windows.Forms.Timer(Me.components)
        Me.lblReforzadores = New System.Windows.Forms.Label()
        Me.tmrVI = New System.Windows.Forms.Timer(Me.components)
        Me.pctRat = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tmrRatJump = New System.Windows.Forms.Timer(Me.components)
        Me.tmrComponent = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBin = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pctRat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lblReforzadores.Location = New System.Drawing.Point(978, 8)
        Me.lblReforzadores.Name = "lblReforzadores"
        Me.lblReforzadores.Size = New System.Drawing.Size(18, 20)
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
        Me.pctRat.Location = New System.Drawing.Point(368, 285)
        Me.pctRat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pctRat.Name = "pctRat"
        Me.pctRat.Size = New System.Drawing.Size(224, 129)
        Me.pctRat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctRat.TabIndex = 13
        Me.pctRat.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(114, 285)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 129)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tmrRatJump
        '
        Me.tmrRatJump.Interval = 5
        '
        'tmrComponent
        '
        Me.tmrComponent.Enabled = True
        Me.tmrComponent.Interval = 180000
        '
        'tmrBin
        '
        Me.tmrBin.Enabled = True
        Me.tmrBin.Interval = 1000
        '
        'MainH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RenovacionInduccion.My.Resources.Resources.fondoCalle
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1005, 539)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblReforzadores)
        Me.Controls.Add(Me.pctRat)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MainH"
        Me.Text = "Form1"
        CType(Me.pctRat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrHoldUp As Timer
    Friend WithEvents pctRat As PictureBox
    Friend WithEvents tmrStart As Timer
    Friend WithEvents lblReforzadores As Label
    Friend WithEvents tmrVI As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents tmrRatJump As Timer
    Friend WithEvents tmrComponent As Timer
    Friend WithEvents tmrBin As Timer
End Class
