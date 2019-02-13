Public Class Form1
    'create text variable to show rolls
    Public rollText As String = Nothing
    'creates variable for die size
    Public dieSize = 6
    'creates variable for multiple rolls
    Public rollCount = Nothing
    'creates variable for number of players
    Public playerCount = Nothing
    'creates variable to check if playercount has changed
    Public playerCountOld = Nothing
    'Creates Forms in case of multiple players
    Dim Player_One As New FrmExtraPlayers
    Dim Player_Two As New FrmExtraPlayers
    Dim Player_Three As New FrmExtraPlayers
    Dim Player_Four As New FrmExtraPlayers
    Dim Player_Five As New FrmExtraPlayers
    Dim Player_Six As New FrmExtraPlayers
    'Creates vars for the text of every form
    Public playerOneText = Nothing
    Public playerTwoText = Nothing
    Public playerThreeText = Nothing
    Public playerFourText = Nothing
    Public playerFiveText = Nothing
    Public playerSixText = Nothing
    'checks to see if comma is needed on multiple rolls of multiple players
    Public commaCheck = Nothing
    'Changes the die size when the die size picker is change
    Private Sub nudDieSize_ValueChanged(sender As Object, e As EventArgs) Handles nudDieSize.ValueChanged
        dieSize = nudDieSize.Value
    End Sub
    'Creates a procedure to roll the dice
    Public Sub Roll()
        txtVal.Visible = True
        'creates variable that has roll number
        Static roll As Integer = 0
        'sets roll value as random
        Randomize()
        roll = CInt(Math.Ceiling(Rnd() * dieSize))
        'hides instructions
        lblInstructions.Visible = False
        'adds commas when not the first number
        If rollText = Nothing Then
            'sets text
            rollText = CStr(roll)
            txtVal.Text &= rollText
        Else
            'sets text
            rollText = CStr(roll)
            txtVal.Text &= ", " + rollText
        End If
    End Sub
    'Creates function to get rolls and not specify what to do
    Function rollLight() As String
        Randomize()
        Dim tempRoll = CInt(Math.Ceiling(Rnd() * dieSize))
        Return tempRoll
    End Function
    'rolls the die on click
    Private Sub BtnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Roll()
    End Sub
    Public Sub ResetFrm()
        Randomize()
        'resets all values
        rollText = Nothing
        txtVal.Text = Nothing
        lblInstructions.Visible = True
        playerOneText = Nothing
        playerTwoText = Nothing
        playerThreeText = Nothing
        playerFourText = Nothing
        playerFiveText = Nothing
        playerSixText = Nothing
        Player_One.txtVal.Text = Nothing
        Player_Two.txtVal.Text = Nothing
        Player_Three.txtVal.Text = Nothing
        Player_Four.txtVal.Text = Nothing
        Player_Five.txtVal.Text = Nothing
        Player_Six.txtVal.Text = Nothing
        Player_One.Hide()
        Player_Two.Hide()
        Player_Three.Hide()
        Player_Four.Hide()
        Player_Five.Hide()
        Player_Six.Hide()
        playerCountOld = Nothing
        commaCheck = Nothing
    End Sub
    'resets rolls
    Public Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetFrm()
    End Sub
    'sets rollcount to number in box when number in box is changed
    Private Sub nudRollCount_ValueChanged(sender As Object, e As EventArgs) Handles nudRollCount.ValueChanged
        rollCount = nudRollCount.Value
    End Sub
    Public Sub MultiRoll()
        While rollCount > 0
            Roll()
            rollCount -= 1
        End While
        'resets roll count so that it isn't 0
        rollCount = nudRollCount.Value
    End Sub
    'runs a multiroll for each player
    Function multiRollVal1() As String
        While rollCount > 0
            If commaCheck = "don't reset" Then
                'sets text
                playerOneText &= ", " + rollLight()
                commaCheck = Nothing
            ElseIf playerOneText = Nothing Then
                'sets text
                playerOneText &= CStr(rollLight())
            Else
                'sets text
                playerOneText &= ", " + rollLight()
            End If
            rollCount -= 1
        End While
        'resets roll count so that it isn't 0
        rollCount = nudRollCount.Value
        Return playerOneText
    End Function
    'runs a multiroll for each player
    Function multiRollVal2() As String
        While rollCount > 0
            If commaCheck = "don't reset" Then
                'sets text
                playerTwoText &= ", " + rollLight()
                commaCheck = Nothing
            ElseIf playerTwoText = Nothing Then
                'sets text
                playerTwoText &= CStr(rollLight())
            Else
                'sets text
                playerTwoText &= ", " + rollLight()
            End If
            rollCount -= 1
        End While
        'resets roll count so that it isn't 0
        rollCount = nudRollCount.Value
        Return playerTwoText
    End Function
    Function multiRollVal3() As String
        While rollCount > 0
            If commaCheck = "don't reset" Then
                'sets text
                playerThreeText &= ", " + rollLight()
                commaCheck = Nothing
            ElseIf playerThreeText = Nothing Then
                'sets text
                playerThreeText &= CStr(rollLight())
            Else
                'sets text
                playerThreeText &= ", " + rollLight()
            End If
            rollCount -= 1
        End While
        'resets roll count so that it isn't 0
        rollCount = nudRollCount.Value
        Return playerThreeText
    End Function
    Function multiRollVal4() As String
        While rollCount > 0
            If commaCheck = "don't reset" Then
                'sets text
                playerFourText &= ", " + rollLight()
                commaCheck = Nothing
            ElseIf playerFourText = Nothing Then
                'sets text
                playerFourText &= CStr(rollLight())
            Else
                'sets text
                playerFourText &= ", " + rollLight()
            End If
            rollCount -= 1
        End While
        'resets roll count so that it isn't 0
        rollCount = nudRollCount.Value
        Return playerFourText
    End Function
    Function multiRollVal5() As String
        While rollCount > 0
            If commaCheck = "don't reset" Then
                'sets text
                playerFiveText &= ", " + rollLight()
                commaCheck = Nothing
            ElseIf playerFiveText = Nothing Then
                'sets text
                playerFiveText &= CStr(rollLight())
            Else
                'sets text
                playerFiveText &= ", " + rollLight()
            End If
            rollCount -= 1
        End While
        'resets roll count so that it isn't 0
        rollCount = nudRollCount.Value
        Return playerFiveText
    End Function
    Function multiRollVal6() As String
        While rollCount > 0
            If commaCheck = "don't reset" Then
                'sets text
                playerSixText &= ", " + rollLight()
                commaCheck = Nothing
            ElseIf playerSixText = Nothing Then
                'sets text
                playerSixText &= CStr(rollLight())
            Else
                'sets text
                playerSixText &= ", " + rollLight()
            End If
            rollCount -= 1
        End While
        'resets roll count so that it isn't 0
        rollCount = nudRollCount.Value
        Return playerSixText
    End Function
    'rolls number of rolls
    Private Sub btnMultiRoll_Click(sender As Object, e As EventArgs) Handles btnMultiRoll.Click
        MultiRoll()
    End Sub
    'sets playercount to value on player count picker
    Private Sub nudPlayerCount_ValueChanged(sender As Object, e As EventArgs) Handles nudPlayerCount.ValueChanged
        playerCount = nudPlayerCount.Value
    End Sub
    'creates function to check if playercount is the same. Returns true if it is, returns false if it is not
    Private Function CheckPlayerCountOld(ByVal playCount As Integer)
        If playCount = playerCountOld Then
            commaCheck = "don't reset"
            Return True
        ElseIf playerCountOld = Nothing Then
            Return True
        Else
            Return False
        End If
    End Function
    'creates the player 1 form
    Private Sub playCount1()
        If playerCountOld = Nothing Then
            Player_One.Show()
            Player_One.Text = "Player One"
            Player_One.Location = New Point(0, 0)
        Else
        End If
    End Sub
    'creates the player 2 form
    Private Sub playCount2()
        If playerCountOld = Nothing Then
            Player_Two.Show()
            Player_Two.Text = "Player Two"
            Player_Two.Location = New Point(640, 0)
        Else
        End If
    End Sub
    'creates the player 3 form
    Private Sub playCount3()
        If playerCountOld = Nothing Then
            Player_Three.Show()
            Player_Three.Text = "Player Three"
            Player_Three.Location = New Point(1280, 0)
        Else
        End If
    End Sub
    'creates the player 4 form
    Private Sub playCount4()
        If playerCountOld = Nothing Then
            Player_Four.Show()
            Player_Four.Text = "Player Four"
            Player_Four.Location = New Point(0, 540)
        Else
        End If
    End Sub
    'creates the player 5 form
    Private Sub playCount5()
        If playerCountOld = Nothing Then
            Player_Five.Show()
            Player_Five.Text = "Player Five"
            Player_Five.Location = New Point(640, 540)
        Else
        End If
    End Sub
    'creates the player 6 form
    Private Sub playCount6()
        If playerCountOld = Nothing Then
            Player_Six.Show()
            Player_Six.Text = "Player Six"
            Player_Six.Location = New Point(1280, 540)
        Else
        End If
    End Sub
    Private Sub btnExtraPlayers_Click(sender As Object, e As EventArgs) Handles btnExtraPlayers.Click
        'Sets differentresults per players
        If playerCount = 2 Then
            If CheckPlayerCountOld(2) = True Then
                playCount1()
                Player_One.txtVal.Text = multiRollVal1()
                playCount2()
                Player_Two.txtVal.Text = multiRollVal2()
                playerCountOld = 2
            Else
                ResetFrm()
                playCount1()
                Player_One.txtVal.Text = multiRollVal1()
                playCount2()
                Player_Two.txtVal.Text = multiRollVal2()
                playerCountOld = 2
            End If
        ElseIf playerCount = 3 Then
            If CheckPlayerCountOld(3) = True Then
                playCount1()
                Player_One.txtVal.Text = multiRollVal1()
                playCount2()
                Player_Two.txtVal.Text = multiRollVal2()
                playCount3()
                Player_Three.txtVal.Text = multiRollVal3()
                playerCountOld = 3
            Else
                ResetFrm()
                playCount1()
                Player_One.txtVal.Text = multiRollVal1()
                playCount2()
                Player_Two.txtVal.Text = multiRollVal2()
                playCount3()
                Player_Three.txtVal.Text = multiRollVal3()
                playerCountOld = 3
            End If
        ElseIf playerCount = 4 Then
            If CheckPlayerCountOld(4) = True Then
                playCount1()
                Player_One.txtVal.Text = multiRollVal1()
                playCount2()
                Player_Two.txtVal.Text = multiRollVal2()
                playCount3()
                Player_Three.txtVal.Text = multiRollVal3()
                playCount4()
                Player_Four.txtVal.Text = multiRollVal4()
                playerCountOld = 4
            Else
                ResetFrm()
                playCount1()
                Player_One.txtVal.Text = multiRollVal1()
                playCount2()
                Player_Two.txtVal.Text = multiRollVal2()
                playCount3()
                Player_Three.txtVal.Text = multiRollVal3()
                playCount4()
                Player_Four.txtVal.Text = multiRollVal4()
                playerCountOld = 4
            End If
        ElseIf playerCount = 5 Then
            If CheckPlayerCountOld(5) = True Then
                playCount1()
                Player_One.txtVal.Text = multiRollVal1()
                playCount2()
                Player_Two.txtVal.Text = multiRollVal2()
                playCount3()
                Player_Three.txtVal.Text = multiRollVal3()
                playCount4()
                Player_Four.txtVal.Text = multiRollVal4()
                playCount5()
                Player_Five.txtVal.Text = multiRollVal5()
                playerCountOld = 5
            Else
                ResetFrm()
                playCount1()
                Player_One.txtVal.Text = multiRollVal1()
                playCount2()
                Player_Two.txtVal.Text = multiRollVal2()
                playCount3()
                Player_Three.txtVal.Text = multiRollVal3()
                playCount4()
                Player_Four.txtVal.Text = multiRollVal4()
                playCount5()
                Player_Five.txtVal.Text = multiRollVal5()
                playerCountOld = 5
            End If
        ElseIf playerCount = 6 Then
            If CheckPlayerCountOld(6) = True Then
                playCount1()
                Player_One.txtVal.Text = multiRollVal1()
                playCount2()
                Player_Two.txtVal.Text = multiRollVal2()
                playCount3()
                Player_Three.txtVal.Text = multiRollVal3()
                playCount4()
                Player_Four.txtVal.Text = multiRollVal4()
                playCount5()
                Player_Five.txtVal.Text = multiRollVal5()
                playCount6()
                Player_Six.txtVal.Text = multiRollVal6()
                playerCountOld = 6
            Else
                ResetFrm()
                playCount1()
                Player_One.txtVal.Text = multiRollVal1()
                playCount2()
                Player_Two.txtVal.Text = multiRollVal2()
                playCount3()
                Player_Three.txtVal.Text = multiRollVal3()
                playCount4()
                Player_Four.txtVal.Text = multiRollVal4()
                playCount5()
                Player_Five.txtVal.Text = multiRollVal5()
                playCount6()
                Player_Six.txtVal.Text = multiRollVal6()
                playerCountOld = 6
            End If
        End If
    End Sub
End Class
