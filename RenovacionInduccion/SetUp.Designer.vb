<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetUp
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
        Me.grpActiveLever = New System.Windows.Forms.GroupBox()
        Me.rdoCenter = New System.Windows.Forms.RadioButton()
        Me.rdoAll = New System.Windows.Forms.RadioButton()
        Me.lblSujeto = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.lblSesion = New System.Windows.Forms.Label()
        Me.txtCOM = New System.Windows.Forms.TextBox()
        Me.txtSession = New System.Windows.Forms.TextBox()
        Me.grpPhase = New System.Windows.Forms.GroupBox()
        Me.rdoReinforcement = New System.Windows.Forms.RadioButton()
        Me.rdoExtinction = New System.Windows.Forms.RadioButton()
        Me.grpActiveLever.SuspendLayout()
        Me.grpPhase.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpActiveLever
        '
        Me.grpActiveLever.Controls.Add(Me.rdoCenter)
        Me.grpActiveLever.Controls.Add(Me.rdoAll)
        Me.grpActiveLever.Location = New System.Drawing.Point(13, 144)
        Me.grpActiveLever.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.grpActiveLever.Name = "grpActiveLever"
        Me.grpActiveLever.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.grpActiveLever.Size = New System.Drawing.Size(106, 64)
        Me.grpActiveLever.TabIndex = 24
        Me.grpActiveLever.TabStop = False
        Me.grpActiveLever.Text = "Active Lever"
        '
        'rdoCenter
        '
        Me.rdoCenter.AutoSize = True
        Me.rdoCenter.Location = New System.Drawing.Point(4, 39)
        Me.rdoCenter.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.rdoCenter.Name = "rdoCenter"
        Me.rdoCenter.Size = New System.Drawing.Size(56, 17)
        Me.rdoCenter.TabIndex = 7
        Me.rdoCenter.Text = "Center"
        Me.rdoCenter.UseVisualStyleBackColor = True
        '
        'rdoAll
        '
        Me.rdoAll.AutoSize = True
        Me.rdoAll.Location = New System.Drawing.Point(4, 22)
        Me.rdoAll.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.rdoAll.Name = "rdoAll"
        Me.rdoAll.Size = New System.Drawing.Size(36, 17)
        Me.rdoAll.TabIndex = 8
        Me.rdoAll.Text = "All"
        Me.rdoAll.UseVisualStyleBackColor = True
        '
        'lblSujeto
        '
        Me.lblSujeto.AutoSize = True
        Me.lblSujeto.Location = New System.Drawing.Point(10, 9)
        Me.lblSujeto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSujeto.Name = "lblSujeto"
        Me.lblSujeto.Size = New System.Drawing.Size(46, 13)
        Me.lblSujeto.TabIndex = 21
        Me.lblSujeto.Text = "Subject:"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(10, 51)
        Me.lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(29, 13)
        Me.lbl.TabIndex = 23
        Me.lbl.Text = "Port:"
        '
        'btnComenzar
        '
        Me.btnComenzar.Location = New System.Drawing.Point(13, 214)
        Me.btnComenzar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(106, 65)
        Me.btnComenzar.TabIndex = 17
        Me.btnComenzar.Text = "Start"
        Me.btnComenzar.UseVisualStyleBackColor = True
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(63, 7)
        Me.txtSubject.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(62, 20)
        Me.txtSubject.TabIndex = 18
        Me.txtSubject.Text = "BG"
        '
        'lblSesion
        '
        Me.lblSesion.AutoSize = True
        Me.lblSesion.Location = New System.Drawing.Point(10, 31)
        Me.lblSesion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSesion.Name = "lblSesion"
        Me.lblSesion.Size = New System.Drawing.Size(47, 13)
        Me.lblSesion.TabIndex = 22
        Me.lblSesion.Text = "Session:"
        '
        'txtCOM
        '
        Me.txtCOM.Location = New System.Drawing.Point(63, 48)
        Me.txtCOM.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtCOM.Name = "txtCOM"
        Me.txtCOM.Size = New System.Drawing.Size(62, 20)
        Me.txtCOM.TabIndex = 20
        Me.txtCOM.Text = "COM1"
        '
        'txtSession
        '
        Me.txtSession.Location = New System.Drawing.Point(63, 29)
        Me.txtSession.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtSession.Name = "txtSession"
        Me.txtSession.Size = New System.Drawing.Size(62, 20)
        Me.txtSession.TabIndex = 19
        Me.txtSession.Text = "1"
        '
        'grpPhase
        '
        Me.grpPhase.Controls.Add(Me.rdoReinforcement)
        Me.grpPhase.Controls.Add(Me.rdoExtinction)
        Me.grpPhase.Location = New System.Drawing.Point(13, 78)
        Me.grpPhase.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.grpPhase.Name = "grpPhase"
        Me.grpPhase.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.grpPhase.Size = New System.Drawing.Size(106, 64)
        Me.grpPhase.TabIndex = 27
        Me.grpPhase.TabStop = False
        Me.grpPhase.Text = "Phase"
        '
        'rdoReinforcement
        '
        Me.rdoReinforcement.AutoSize = True
        Me.rdoReinforcement.Location = New System.Drawing.Point(4, 20)
        Me.rdoReinforcement.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.rdoReinforcement.Name = "rdoReinforcement"
        Me.rdoReinforcement.Size = New System.Drawing.Size(94, 17)
        Me.rdoReinforcement.TabIndex = 7
        Me.rdoReinforcement.Text = "Reinforcement"
        Me.rdoReinforcement.UseVisualStyleBackColor = True
        '
        'rdoExtinction
        '
        Me.rdoExtinction.AutoSize = True
        Me.rdoExtinction.Location = New System.Drawing.Point(4, 37)
        Me.rdoExtinction.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.rdoExtinction.Name = "rdoExtinction"
        Me.rdoExtinction.Size = New System.Drawing.Size(71, 17)
        Me.rdoExtinction.TabIndex = 8
        Me.rdoExtinction.Text = "Extinction"
        Me.rdoExtinction.UseVisualStyleBackColor = True
        '
        'SetUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(136, 293)
        Me.Controls.Add(Me.grpPhase)
        Me.Controls.Add(Me.grpActiveLever)
        Me.Controls.Add(Me.lblSujeto)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.btnComenzar)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.lblSesion)
        Me.Controls.Add(Me.txtCOM)
        Me.Controls.Add(Me.txtSession)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "SetUp"
        Me.Text = "Form1"
        Me.grpActiveLever.ResumeLayout(False)
        Me.grpActiveLever.PerformLayout()
        Me.grpPhase.ResumeLayout(False)
        Me.grpPhase.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpActiveLever As GroupBox
    Friend WithEvents rdoCenter As RadioButton
    Friend WithEvents rdoAll As RadioButton
    Friend WithEvents lblSujeto As Label
    Friend WithEvents lbl As Label
    Friend WithEvents btnComenzar As Button
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents lblSesion As Label
    Friend WithEvents txtCOM As TextBox
    Friend WithEvents txtSession As TextBox
    Friend WithEvents grpPhase As GroupBox
    Friend WithEvents rdoReinforcement As RadioButton
    Friend WithEvents rdoExtinction As RadioButton
End Class
