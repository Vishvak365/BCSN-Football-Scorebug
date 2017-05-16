Public Class Vishvak_Seenichamy_BCSN_FB_SB
    Dim scoreHome As Integer
    Dim scoreAway As Integer
    Dim timeOutAway As Integer
    Dim timeOutHome As Integer
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short


    Private Sub lblAwayScore_Click(sender As Object, e As EventArgs) Handles lblAwayScore.Click

    End Sub

    Private Sub btnScoreAway1_Click(sender As Object, e As EventArgs) Handles btnScoreAway1.Click
        scoreAway += 1
        lblAwayScore.Text = scoreAway
    End Sub

    Private Sub btnScoreAway2_Click(sender As Object, e As EventArgs) Handles btnScoreAway2.Click
        scoreAway += 2
        lblAwayScore.Text = scoreAway
    End Sub

    Private Sub btnScoreAway3_Click(sender As Object, e As EventArgs) Handles btnScoreAway3.Click
        scoreAway += 3
        lblAwayScore.Text = scoreAway
    End Sub

    Private Sub btnScoreAway6_Click(sender As Object, e As EventArgs) Handles btnScoreAway6.Click
        scoreAway += 6
        lblAwayScore.Text = scoreAway
    End Sub

    Private Sub btnScoreAway1m_Click(sender As Object, e As EventArgs) Handles btnScoreAway1m.Click
        scoreAway -= 1
        lblAwayScore.Text = scoreAway
    End Sub

    Private Sub btnScoreAway2m_Click(sender As Object, e As EventArgs) Handles btnScoreAway2m.Click
        scoreAway -= 2
        lblAwayScore.Text = scoreAway
    End Sub

    Private Sub btnScoreAway3m_Click(sender As Object, e As EventArgs) Handles btnScoreAway3m.Click
        scoreAway -= 3
        lblAwayScore.Text = scoreAway
    End Sub

    Private Sub btnScoreAway6m_Click(sender As Object, e As EventArgs) Handles btnScoreAway6m.Click
        scoreAway -= 6
        lblAwayScore.Text = scoreAway
    End Sub

    Private Sub btnScoreHome1_Click(sender As Object, e As EventArgs) Handles btnScoreHome1.Click
        scoreHome += 1
        lblScoreHome.Text = scoreHome
    End Sub

    Private Sub btnScoreHome2_Click(sender As Object, e As EventArgs) Handles btnScoreHome2.Click
        scoreHome += 2
        lblScoreHome.Text = scoreHome
    End Sub

    Private Sub btnScoreHome3_Click(sender As Object, e As EventArgs) Handles btnScoreHome3.Click
        scoreHome += 3
        lblScoreHome.Text = scoreHome
    End Sub

    Private Sub btnScoreHome6_Click(sender As Object, e As EventArgs) Handles btnScoreHome6.Click
        scoreHome += 6
        lblScoreHome.Text = scoreHome
    End Sub

    Private Sub btnScoreHome1m_Click(sender As Object, e As EventArgs) Handles btnScoreHome1m.Click
        scoreHome -= 1
        lblScoreHome.Text = scoreHome
    End Sub

    Private Sub btnScoreHome2m_Click(sender As Object, e As EventArgs) Handles btnScoreHome2m.Click
        scoreHome -= 2
        lblScoreHome.Text = scoreHome
    End Sub

    Private Sub btnScoreHome3m_Click(sender As Object, e As EventArgs) Handles btnScoreHome3m.Click
        scoreHome -= 3
        lblScoreHome.Text = scoreHome
    End Sub

    Private Sub btnScoreHome6m_Click(sender As Object, e As EventArgs) Handles btnScoreHome6m.Click
        scoreHome -= 6
        lblScoreHome.Text = scoreHome
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblPeriod.Text = "1st"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblPeriod.Text = "2nd"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblPeriod.Text = "3rd"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lblPeriod.Text = "4th"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        lblPeriod.Text = "OT"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        lblPeriod.Text = "2OT"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        lblPeriod.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lblPeriod.Text = "Final"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        'lblDowns.Location = New Point(53, 312)
        lblDowns.Text = "1st DOWN"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        'lblDowns.Location = New Point(53, 312)
        lblDowns.Text = "2nd DOWN"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        'lblDowns.Location = New Point(53, 312)
        lblDowns.Text = "3rd DOWN"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'lblDowns.Location = New Point(53, 312)
        lblDowns.Text = "4th DOWN"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'lblDowns.Location = New Point(49, 312)
        lblDowns.Text = "1st && Goal"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'lblDowns.Location = New Point(49, 312)
        lblDowns.Text = "2nd && Goal"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'lblDowns.Location = New Point(49, 312)
        lblDowns.Text = "3rd && Goal"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'lblDowns.Location = New Point(49, 312)
        lblDowns.Text = "4th && Goal"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        'lblDowns.Location = New Point(59, 312)
        lblDowns.Text = "FIELD GL."
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        'lblDowns.Location = New Point(44, 312)
        lblDowns.Text = "2PT CONV."
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        'lblDowns.Location = New Point(45, 312)
        lblDowns.Text = "EXTRA PT."
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        'lblDowns.Location = New Point(59, 312)
        lblDowns.Text = ""
    End Sub

    Private Sub Vishvak_Seenichamy_BCSN_FB_SB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timeOutAway = 3
        timeOutHome = 3
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        timeOutAway -= 1
        If timeOutAway = 3 Then
            topLeftTO.Visible = True
            MiddleLeftTO.Visible = True
            BottomLeftTO.Visible = True
        End If
        If timeOutAway = 2 Then
            topLeftTO.Visible = False
            MiddleLeftTO.Visible = True
            BottomLeftTO.Visible = True
        End If
        If timeOutAway = 1 Then
            topLeftTO.Visible = False
            MiddleLeftTO.Visible = False
            BottomLeftTO.Visible = True
        End If
        If timeOutAway = 0 Then
            topLeftTO.Visible = False
            MiddleLeftTO.Visible = False
            BottomLeftTO.Visible = False
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        timeOutAway += 1
        If timeOutAway = 3 Then
            topLeftTO.Visible = True
            MiddleLeftTO.Visible = True
            BottomLeftTO.Visible = True
        End If
        If timeOutAway = 2 Then
            topLeftTO.Visible = False
            MiddleLeftTO.Visible = True
            BottomLeftTO.Visible = True
        End If
        If timeOutAway = 1 Then
            topLeftTO.Visible = False
            MiddleLeftTO.Visible = False
            BottomLeftTO.Visible = True
        End If
        If timeOutAway = 0 Then
            topLeftTO.Visible = False
            MiddleLeftTO.Visible = False
            BottomLeftTO.Visible = False
        End If
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        timeOutHome -= 1
        If timeOutHome = 3 Then
            TopRightTO.Visible = True
            MiddleRightTO.Visible = True
            BottomRightTO.Visible = True
        End If
        If timeOutHome = 2 Then
            TopRightTO.Visible = False
            MiddleRightTO.Visible = True
            BottomRightTO.Visible = True
        End If
        If timeOutHome = 1 Then
            TopRightTO.Visible = False
            MiddleRightTO.Visible = False
            BottomRightTO.Visible = True
        End If
        If timeOutHome = 0 Then
            TopRightTO.Visible = False
            MiddleRightTO.Visible = False
            BottomRightTO.Visible = False
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        timeOutHome += 1
        If timeOutHome = 3 Then
            TopRightTO.Visible = True
            MiddleRightTO.Visible = True
            BottomRightTO.Visible = True
        End If
        If timeOutHome = 2 Then
            TopRightTO.Visible = False
            MiddleRightTO.Visible = True
            BottomRightTO.Visible = True
        End If
        If timeOutHome = 1 Then
            TopRightTO.Visible = False
            MiddleRightTO.Visible = False
            BottomRightTO.Visible = True
        End If
        If timeOutHome = 0 Then
            TopRightTO.Visible = False
            MiddleRightTO.Visible = False
            BottomRightTO.Visible = False
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        playerAway.Visible = True
        playerHome.Visible = False
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        playerAway.Visible = 0
        playerHome.Visible = 1
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        timeOutAway = 3
        topLeftTO.Visible = True
        MiddleLeftTO.Visible = True
        BottomLeftTO.Visible = True
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        timeOutHome = 3
        TopRightTO.Visible = True
        MiddleRightTO.Visible = True
        BottomRightTO.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (GetAsyncKeyState(Keys.D1)) Then
            lblDowns.Text = "1st DOWN"
        End If
        If (GetAsyncKeyState(Keys.D2)) Then
            lblDowns.Text = "2nd DOWN"
        End If
        If (GetAsyncKeyState(Keys.D3)) Then
            lblDowns.Text = "3rd DOWN"
        End If
        If (GetAsyncKeyState(Keys.D4)) Then
            lblDowns.Text = "4th DOWN"
        End If
        If (GetAsyncKeyState(Keys.D5)) Then
            playerAway.Visible = 1
            playerHome.Visible = 0
        End If
        If (GetAsyncKeyState(Keys.D6)) Then
            playerAway.Visible = 0
            playerHome.Visible = 1
        End If
    End Sub

End Class
