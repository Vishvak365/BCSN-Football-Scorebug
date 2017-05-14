Public Class Form1
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
End Class
