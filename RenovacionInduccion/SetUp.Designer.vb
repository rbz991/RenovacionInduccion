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
        Me.txtCOM = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIV = New System.Windows.Forms.TextBox()
        Me.grpActiveLever.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpActiveLever
        '
        Me.grpActiveLever.Controls.Add(Me.rdoCenter)
        Me.grpActiveLever.Controls.Add(Me.rdoAll)
        Me.grpActiveLever.Location = New System.Drawing.Point(76, 228)
        Me.grpActiveLever.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.grpActiveLever.Name = "grpActiveLever"
        Me.grpActiveLever.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.grpActiveLever.Size = New System.Drawing.Size(212, 123)
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
        Me.rdoAll.Text = "All"
        Me.rdoAll.UseVisualStyleBackColor = True
        '
        'lblSujeto
        '
        Me.lblSujeto.AutoSize = True
        Me.lblSujeto.Location = New System.Drawing.Point(72, 17)
        Me.lblSujeto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSujeto.Name = "lblSujeto"
        Me.lblSujeto.Size = New System.Drawing.Size(90, 25)
        Me.lblSujeto.TabIndex = 21
        Me.lblSujeto.Text = "Subject:"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(72, 123)
        Me.lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(57, 25)
        Me.lbl.TabIndex = 23
        Me.lbl.Text = "Port:"
        '
        'btnComenzar
        '
        Me.btnComenzar.Location = New System.Drawing.Point(88, 483)
        Me.btnComenzar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(212, 88)
        Me.btnComenzar.TabIndex = 17
        Me.btnComenzar.Text = "Start"
        Me.btnComenzar.UseVisualStyleBackColor = True
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(178, 12)
        Me.txtSubject.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(120, 31)
        Me.txtSubject.TabIndex = 18
        '
        'txtCOM
        '
        Me.txtCOM.Location = New System.Drawing.Point(178, 117)
        Me.txtCOM.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtCOM.Name = "txtCOM"
        Me.txtCOM.Size = New System.Drawing.Size(120, 31)
        Me.txtCOM.TabIndex = 20
        Me.txtCOM.Text = "COM3"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(84, 381)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(112, 29)
        Me.CheckBox1.TabIndex = 28
        Me.CheckBox1.Text = "Human"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 25)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "IV:"
        '
        'txtIV
        '
        Me.txtIV.Location = New System.Drawing.Point(178, 64)
        Me.txtIV.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtIV.Name = "txtIV"
        Me.txtIV.Size = New System.Drawing.Size(120, 31)
        Me.txtIV.TabIndex = 29
        Me.txtIV.Text = "2"
        '
        'SetUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 616)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIV)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.grpActiveLever)
        Me.Controls.Add(Me.lblSujeto)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.btnComenzar)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.txtCOM)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SetUp"
        Me.Text = "Form1"
        Me.grpActiveLever.ResumeLayout(False)
        Me.grpActiveLever.PerformLayout()
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
    Friend WithEvents txtCOM As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIV As TextBox
End Class
