Public Class Vishvak_Seenichamy_BCSN_FB_SB
    Dim scoreHome As Integer
    Dim scoreAway As Integer


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
        lblDowns.Text = "1st Down"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        lblDowns.Text = "2nd Down"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        lblDowns.Text = "3rd Down"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        lblDowns.Text = "4th Down"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        lblDowns.Text = "1st && Goal"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        lblDowns.Text = "2nd && Goal"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        lblDowns.Text = "3rd && Goal"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        lblDowns.Text = "4th && Goal"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        lblDowns.Text = "FIELD GOAL"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        lblDowns.Text = "Field Goal"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        lblDowns.Text = "EXTRA POINT "
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        lblDowns.Text = "Extra Pt."
    End Sub
End Class
