<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExtraPlayers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExtraPlayers))
        Me.txtVal = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.BtnRoll = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtVal
        '
        Me.txtVal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVal.Location = New System.Drawing.Point(12, 69)
        Me.txtVal.Multiline = True
        Me.txtVal.Name = "txtVal"
        Me.txtVal.ReadOnly = True
        Me.txtVal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVal.Size = New System.Drawing.Size(606, 398)
        Me.txtVal.TabIndex = 10
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(486, 473)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "E&xit all rolls"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'BtnRoll
        '
        Me.BtnRoll.Location = New System.Drawing.Point(354, 473)
        Me.BtnRoll.Name = "BtnRoll"
        Me.BtnRoll.Size = New System.Drawing.Size(126, 23)
        Me.BtnRoll.TabIndex = 12
        Me.BtnRoll.Text = "&Roll again"
        Me.BtnRoll.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(599, 57)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "The program breaks if you try to close this window without using the exit all rol" &
    "ls button, so do not do that"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmExtraPlayers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 501)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRoll)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtVal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmExtraPlayers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Player X"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtVal As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents BtnRoll As Button
    Friend WithEvents Label1 As Label
End Class
