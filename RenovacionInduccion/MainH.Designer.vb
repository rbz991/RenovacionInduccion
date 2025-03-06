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
        Me.tmrHoldUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStart = New System.Windows.Forms.Timer(Me.components)
        Me.lblReforzadores = New System.Windows.Forms.Label()
        Me.tmrVI = New System.Windows.Forms.Timer(Me.components)
        Me.pctRat = New System.Windows.Forms.PictureBox()
        Me.tmrRatJump = New System.Windows.Forms.Timer(Me.components)
        Me.tmrComponent = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBin = New System.Windows.Forms.Timer(Me.components)
        Me.lblMasUno = New System.Windows.Forms.Label()
        Me.tmrMasUno = New System.Windows.Forms.Timer(Me.components)
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
        Me.lblReforzadores.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReforzadores.AutoSize = True
        Me.lblReforzadores.BackColor = System.Drawing.Color.Transparent
        Me.lblReforzadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReforzadores.ForeColor = System.Drawing.Color.Lime
        Me.lblReforzadores.Location = New System.Drawing.Point(1130, 9)
        Me.lblReforzadores.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReforzadores.Name = "lblReforzadores"
        Me.lblReforzadores.Size = New System.Drawing.Size(421, 85)
        Me.lblReforzadores.TabIndex = 14
        Me.lblReforzadores.Text = "$0.00 MXN"
        '
        'tmrVI
        '
        '
        'pctRat
        '
        Me.pctRat.BackColor = System.Drawing.Color.Transparent
        Me.pctRat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pctRat.Image = Global.RenovacionInduccion.My.Resources.Resources.rat
        Me.pctRat.Location = New System.Drawing.Point(976, 679)
        Me.pctRat.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.pctRat.Name = "pctRat"
        Me.pctRat.Size = New System.Drawing.Size(720, 369)
        Me.pctRat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctRat.TabIndex = 13
        Me.pctRat.TabStop = False
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
        Me.tmrBin.Interval = 5000
        '
        'lblMasUno
        '
        Me.lblMasUno.AutoSize = True
        Me.lblMasUno.BackColor = System.Drawing.Color.Transparent
        Me.lblMasUno.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMasUno.ForeColor = System.Drawing.Color.Lime
        Me.lblMasUno.Location = New System.Drawing.Point(1130, 558)
        Me.lblMasUno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMasUno.Name = "lblMasUno"
        Me.lblMasUno.Size = New System.Drawing.Size(466, 85)
        Me.lblMasUno.TabIndex = 16
        Me.lblMasUno.Text = "+$0.50 MXN"
        Me.lblMasUno.Visible = False
        '
        'tmrMasUno
        '
        Me.tmrMasUno.Interval = 1000
        '
        'MainH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RenovacionInduccion.My.Resources.Resources.fondoCalle
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1564, 892)
        Me.Controls.Add(Me.lblMasUno)
        Me.Controls.Add(Me.lblReforzadores)
        Me.Controls.Add(Me.pctRat)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
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
    Friend WithEvents tmrRatJump As Timer
    Friend WithEvents tmrComponent As Timer
    Friend WithEvents tmrBin As Timer
    Friend WithEvents lblMasUno As Label
    Friend WithEvents tmrMasUno As Timer
End Class
