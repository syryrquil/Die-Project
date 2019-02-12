<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblInfoNumber = New System.Windows.Forms.Label()
        Me.btnMultiRoll = New System.Windows.Forms.Button()
        Me.nudRollCount = New System.Windows.Forms.NumericUpDown()
        Me.nudDieSize = New System.Windows.Forms.NumericUpDown()
        Me.lblInfoSize = New System.Windows.Forms.Label()
        Me.txtVal = New System.Windows.Forms.TextBox()
        Me.nudPlayerCount = New System.Windows.Forms.NumericUpDown()
        Me.lblInfoPlayerCount = New System.Windows.Forms.Label()
        Me.btnExtraPlayers = New System.Windows.Forms.Button()
        CType(Me.nudRollCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDieSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPlayerCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(150, 442)
        Me.btnRoll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(156, 46)
        Me.btnRoll.TabIndex = 1
        Me.btnRoll.Text = "&Roll the die once"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(12, 9)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(399, 400)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "Click roll to roll the die!"
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(923, 442)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(156, 46)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Re&set Rolls"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblInfoNumber
        '
        Me.lblInfoNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblInfoNumber.Location = New System.Drawing.Point(20, 409)
        Me.lblInfoNumber.Name = "lblInfoNumber"
        Me.lblInfoNumber.Size = New System.Drawing.Size(120, 48)
        Me.lblInfoNumber.TabIndex = 5
        Me.lblInfoNumber.Text = "Enter a number 1-1,000,000,000 for number of faces on the dice"
        Me.lblInfoNumber.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnMultiRoll
        '
        Me.btnMultiRoll.Location = New System.Drawing.Point(461, 442)
        Me.btnMultiRoll.Name = "btnMultiRoll"
        Me.btnMultiRoll.Size = New System.Drawing.Size(156, 46)
        Me.btnMultiRoll.TabIndex = 6
        Me.btnMultiRoll.Text = "R&oll die multiple times"
        Me.btnMultiRoll.UseVisualStyleBackColor = True
        '
        'nudRollCount
        '
        Me.nudRollCount.Location = New System.Drawing.Point(312, 460)
        Me.nudRollCount.Name = "nudRollCount"
        Me.nudRollCount.Size = New System.Drawing.Size(132, 23)
        Me.nudRollCount.TabIndex = 7
        Me.nudRollCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudDieSize
        '
        Me.nudDieSize.Location = New System.Drawing.Point(12, 460)
        Me.nudDieSize.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.nudDieSize.Name = "nudDieSize"
        Me.nudDieSize.Size = New System.Drawing.Size(132, 23)
        Me.nudDieSize.TabIndex = 7
        Me.nudDieSize.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'lblInfoSize
        '
        Me.lblInfoSize.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblInfoSize.Location = New System.Drawing.Point(312, 409)
        Me.lblInfoSize.Name = "lblInfoSize"
        Me.lblInfoSize.Size = New System.Drawing.Size(120, 48)
        Me.lblInfoSize.TabIndex = 8
        Me.lblInfoSize.Text = "Enter a number 1-100 for roll count"
        Me.lblInfoSize.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtVal
        '
        Me.txtVal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVal.Location = New System.Drawing.Point(12, 9)
        Me.txtVal.Multiline = True
        Me.txtVal.Name = "txtVal"
        Me.txtVal.ReadOnly = True
        Me.txtVal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVal.Size = New System.Drawing.Size(1084, 397)
        Me.txtVal.TabIndex = 9
        Me.txtVal.Visible = False
        '
        'nudPlayerCount
        '
        Me.nudPlayerCount.Location = New System.Drawing.Point(623, 465)
        Me.nudPlayerCount.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudPlayerCount.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudPlayerCount.Name = "nudPlayerCount"
        Me.nudPlayerCount.Size = New System.Drawing.Size(132, 23)
        Me.nudPlayerCount.TabIndex = 7
        Me.nudPlayerCount.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lblInfoPlayerCount
        '
        Me.lblInfoPlayerCount.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblInfoPlayerCount.Location = New System.Drawing.Point(623, 409)
        Me.lblInfoPlayerCount.Name = "lblInfoPlayerCount"
        Me.lblInfoPlayerCount.Size = New System.Drawing.Size(120, 48)
        Me.lblInfoPlayerCount.TabIndex = 8
        Me.lblInfoPlayerCount.Text = "Enter a number 2-6 for number of players to roll for"
        Me.lblInfoPlayerCount.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnExtraPlayers
        '
        Me.btnExtraPlayers.Location = New System.Drawing.Point(761, 442)
        Me.btnExtraPlayers.Name = "btnExtraPlayers"
        Me.btnExtraPlayers.Size = New System.Drawing.Size(156, 46)
        Me.btnExtraPlayers.TabIndex = 6
        Me.btnExtraPlayers.Text = "Ro&ll the dice for multiple players"
        Me.btnExtraPlayers.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 516)
        Me.Controls.Add(Me.lblInfoPlayerCount)
        Me.Controls.Add(Me.lblInfoSize)
        Me.Controls.Add(Me.nudDieSize)
        Me.Controls.Add(Me.nudPlayerCount)
        Me.Controls.Add(Me.nudRollCount)
        Me.Controls.Add(Me.btnExtraPlayers)
        Me.Controls.Add(Me.btnMultiRoll)
        Me.Controls.Add(Me.lblInfoNumber)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.txtVal)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Dice Rolling Program"
        CType(Me.nudRollCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDieSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPlayerCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRoll As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents lblInfoNumber As Label
    Friend WithEvents btnMultiRoll As Button
    Friend WithEvents nudRollCount As NumericUpDown
    Friend WithEvents nudDieSize As NumericUpDown
    Friend WithEvents lblInfoSize As Label
    Friend WithEvents txtVal As TextBox
    Friend WithEvents nudPlayerCount As NumericUpDown
    Friend WithEvents lblInfoPlayerCount As Label
    Friend WithEvents btnExtraPlayers As Button
End Class
