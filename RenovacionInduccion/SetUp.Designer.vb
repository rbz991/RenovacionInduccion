﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.grpActiveLever.Location = New System.Drawing.Point(26, 277)
        Me.grpActiveLever.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.grpActiveLever.Name = "grpActiveLever"
        Me.grpActiveLever.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.grpActiveLever.Size = New System.Drawing.Size(213, 123)
        Me.grpActiveLever.TabIndex = 24
        Me.grpActiveLever.TabStop = False
        Me.grpActiveLever.Text = "Active Lever"
        '
        'rdoCenter
        '
        Me.rdoCenter.AutoSize = True
        Me.rdoCenter.Location = New System.Drawing.Point(8, 75)
        Me.rdoCenter.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.rdoCenter.Name = "rdoCenter"
        Me.rdoCenter.Size = New System.Drawing.Size(107, 29)
        Me.rdoCenter.TabIndex = 7
        Me.rdoCenter.TabStop = True
        Me.rdoCenter.Text = "Center"
        Me.rdoCenter.UseVisualStyleBackColor = True
        '
        'rdoAll
        '
        Me.rdoAll.AutoSize = True
        Me.rdoAll.Location = New System.Drawing.Point(8, 42)
        Me.rdoAll.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.rdoAll.Name = "rdoAll"
        Me.rdoAll.Size = New System.Drawing.Size(67, 29)
        Me.rdoAll.TabIndex = 8
        Me.rdoAll.TabStop = True
        Me.rdoAll.Text = "All"
        Me.rdoAll.UseVisualStyleBackColor = True
        '
        'lblSujeto
        '
        Me.lblSujeto.AutoSize = True
        Me.lblSujeto.Location = New System.Drawing.Point(21, 18)
        Me.lblSujeto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSujeto.Name = "lblSujeto"
        Me.lblSujeto.Size = New System.Drawing.Size(90, 25)
        Me.lblSujeto.TabIndex = 21
        Me.lblSujeto.Text = "Subject:"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(21, 99)
        Me.lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(57, 25)
        Me.lbl.TabIndex = 23
        Me.lbl.Text = "Port:"
        '
        'btnComenzar
        '
        Me.btnComenzar.Location = New System.Drawing.Point(26, 412)
        Me.btnComenzar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(213, 125)
        Me.btnComenzar.TabIndex = 17
        Me.btnComenzar.Text = "Start"
        Me.btnComenzar.UseVisualStyleBackColor = True
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(126, 14)
        Me.txtSubject.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(121, 31)
        Me.txtSubject.TabIndex = 18
        Me.txtSubject.Text = "BG"
        '
        'lblSesion
        '
        Me.lblSesion.AutoSize = True
        Me.lblSesion.Location = New System.Drawing.Point(19, 59)
        Me.lblSesion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSesion.Name = "lblSesion"
        Me.lblSesion.Size = New System.Drawing.Size(95, 25)
        Me.lblSesion.TabIndex = 22
        Me.lblSesion.Text = "Session:"
        '
        'txtCOM
        '
        Me.txtCOM.Location = New System.Drawing.Point(126, 93)
        Me.txtCOM.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtCOM.Name = "txtCOM"
        Me.txtCOM.Size = New System.Drawing.Size(121, 31)
        Me.txtCOM.TabIndex = 20
        Me.txtCOM.Text = "COM4"
        '
        'txtSession
        '
        Me.txtSession.Location = New System.Drawing.Point(126, 55)
        Me.txtSession.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtSession.Name = "txtSession"
        Me.txtSession.Size = New System.Drawing.Size(121, 31)
        Me.txtSession.TabIndex = 19
        Me.txtSession.Text = "1"
        '
        'grpPhase
        '
        Me.grpPhase.Controls.Add(Me.rdoReinforcement)
        Me.grpPhase.Controls.Add(Me.rdoExtinction)
        Me.grpPhase.Location = New System.Drawing.Point(26, 150)
        Me.grpPhase.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.grpPhase.Name = "grpPhase"
        Me.grpPhase.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.grpPhase.Size = New System.Drawing.Size(213, 123)
        Me.grpPhase.TabIndex = 27
        Me.grpPhase.TabStop = False
        Me.grpPhase.Text = "Phase"
        '
        'rdoReinforcement
        '
        Me.rdoReinforcement.AutoSize = True
        Me.rdoReinforcement.Location = New System.Drawing.Point(8, 39)
        Me.rdoReinforcement.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.rdoReinforcement.Name = "rdoReinforcement"
        Me.rdoReinforcement.Size = New System.Drawing.Size(182, 29)
        Me.rdoReinforcement.TabIndex = 7
        Me.rdoReinforcement.TabStop = True
        Me.rdoReinforcement.Text = "Reinforcement"
        Me.rdoReinforcement.UseVisualStyleBackColor = True
        '
        'rdoExtinction
        '
        Me.rdoExtinction.AutoSize = True
        Me.rdoExtinction.Location = New System.Drawing.Point(8, 72)
        Me.rdoExtinction.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.rdoExtinction.Name = "rdoExtinction"
        Me.rdoExtinction.Size = New System.Drawing.Size(137, 29)
        Me.rdoExtinction.TabIndex = 8
        Me.rdoExtinction.TabStop = True
        Me.rdoExtinction.Text = "Extinction"
        Me.rdoExtinction.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 563)
        Me.Controls.Add(Me.grpPhase)
        Me.Controls.Add(Me.grpActiveLever)
        Me.Controls.Add(Me.lblSujeto)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.btnComenzar)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.lblSesion)
        Me.Controls.Add(Me.txtCOM)
        Me.Controls.Add(Me.txtSession)
        Me.Name = "Form1"
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