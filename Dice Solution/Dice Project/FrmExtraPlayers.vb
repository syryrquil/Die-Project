Public Class FrmExtraPlayers
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Form1.ResetFrm()
    End Sub
    Private Sub BtnRoll_Click(sender As Object, e As System.EventArgs) Handles BtnRoll.Click
        'presses extra players roll button on the original form
        My.Forms.Form1.btnExtraPlayers.PerformClick()
    End Sub

    Private Sub FrmExtraPlayers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.ResetFrm()
        e.Cancel = True
    End Sub
End Class