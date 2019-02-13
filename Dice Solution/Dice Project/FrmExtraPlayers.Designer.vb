<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmExtraPlayers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExtraPlayers))
        Me.txtVal = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.BtnRoll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtVal
        '
        Me.txtVal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVal.Location = New System.Drawing.Point(12, 12)
        Me.txtVal.Multiline = True
        Me.txtVal.Name = "txtVal"
        Me.txtVal.ReadOnly = True
        Me.txtVal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVal.Size = New System.Drawing.Size(606, 455)
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
        'FrmExtraPlayers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 501)
        Me.ControlBox = False
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
End Class
