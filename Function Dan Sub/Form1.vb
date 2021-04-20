Public Class Form1

    Private Sub S1()
        lblText1.Text = "Hi Kabilan"
    End Sub
    Private Sub btnSubmit1_Click(sender As Object, e As EventArgs) Handles btnSubmit1.Click
        S1()
    End Sub
    Private Sub S2()
        Dim strText As String
        strText = txtBox1.Text
        lblText2.Text = strText
    End Sub
    Private Sub btnSubmit2_Click(sender As Object, e As EventArgs) Handles btnSubmit2.Click
        S2()
    End Sub
    Private Function S3()
        lblText3.Text = "KABILAN "
        Return lblText3
    End Function
    Private Sub btnSubmit3_Click(sender As Object, e As EventArgs) Handles btnSubmit3.Click
        S3()
    End Sub

    Private Function S4()
        Dim strText2 As String
        strText2 = txtBox2.Text
        lblText4.Text = strText2
        Return lblText4
    End Function
    Private Sub btnSubmit4_Click(sender As Object, e As EventArgs) Handles btnSubmit4.Click
        S4()
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles btnSubmit1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSubmit3.Click

    End Sub
End Class