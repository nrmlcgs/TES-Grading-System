Public Class Form1
    Dim hpsSum, scoreSum, percentageScoreSum, weightedScoreSum As Double
    Dim varhps4 As Integer
    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged, TextBox9.TextChanged, TextBox8.TextChanged, TextBox7.TextChanged, TextBox6.TextChanged, TextBox5.TextChanged, TextBox4.TextChanged, TextBox3.TextChanged, TextBox2.TextChanged, TextBox1.TextChanged
        getTotalScore()
    End Sub

    Public Sub transferValues()

    End Sub

    Public Sub getTotalScore()
        Dim varhps1 As Integer = Val(hps1.Text)
        Dim varhps2 As Integer = Val(hps2.Text)
        Dim varhps3 As Integer = Val(hps3.Text)
        varhps4 = Val(hps4.Text)
        Dim varhps5 As Integer = Val(hps5.Text)
        Dim varhps6 As Integer = Val(hps6.Text)
        Dim varhps7 As Integer = Val(hps7.Text)
        Dim varhps8 As Integer = Val(hps8.Text)
        Dim varhps9 As Integer = Val(hps9.Text)
        Dim varhps10 As Integer = Val(hps10.Text)
        Dim varScoreWW1 As Integer = Val(TextBox10.Text)
        Dim varScoreWW2 As Integer = Val(TextBox9.Text)
        Dim varScoreWW3 As Integer = Val(TextBox8.Text)
        Dim varScoreWW4 As Integer = Val(TextBox7.Text)
        Dim varScoreWW5 As Integer = Val(TextBox6.Text)
        Dim varScoreWW6 As Integer = Val(TextBox5.Text)
        Dim varScoreWW7 As Integer = Val(TextBox4.Text)
        Dim varScoreWW8 As Integer = Val(TextBox3.Text)
        Dim varScoreWW9 As Integer = Val(TextBox2.Text)
        Dim varScoreWW10 As Integer = Val(TextBox1.Text)

        hpsSum = varhps1 + varhps2 + varhps3 + varhps4 + varhps5 + varhps6 + varhps7 + varhps8 + varhps9 + varhps10
        scoreSum = varScoreWW1 + varScoreWW2 + varScoreWW3 + varScoreWW4 + varScoreWW5 + varScoreWW6 + varScoreWW7 + varScoreWW8 + varScoreWW9 + varScoreWW10
        percentageScoreSum = Format((scoreSum / hpsSum) * 100, "0.00")
        weightedScoreSum = Format(percentageScoreSum * 0.4, "0.00")
        lblTotalHPS.Text = hpsSum.ToString
        lblTotalScore.Text = scoreSum.ToString
        lblWrittenWorksPS.Text = percentageScoreSum.ToString
        lblWrittenWorksWS.Text = weightedScoreSum.ToString
    End Sub

    Private Sub TextBox7_GotFocus(sender As Object, e As EventArgs) Handles TextBox7.GotFocus
        ToolTip1.ToolTipTitle = "Highest Possible Score is " & varhps4
    End Sub

    Private Sub TextBox7_DoubleClick(sender As Object, e As EventArgs) Handles TextBox7.DoubleClick
        Dim a = InputBox("Enter new HPS for Written Work here", "Written Work 4")
        hps4.Text = a
        getTotalScore()
    End Sub
    'first trial codes
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    TextBox10.Text = txt1.Text
    '    TextBox9.Text = txt2.Text
    '    TextBox8.Text = txt3.Text
    '    TextBox7.Text = txt4.Text
    '    TextBox6.Text = txt5.Text
    '    TextBox5.Text = txt6.Text
    '    TextBox4.Text = txt7.Text
    '    TextBox3.Text = txt8.Text
    '    TextBox2.Text = txt9.Text
    '    TextBox1.Text = txt10.Text
    'End Sub

    'Private Sub TextBox8_LostFocus(sender As Object, e As EventArgs) Handles TextBox8.LostFocus
    '    If Val(TextBox8.Text) > Val(hps3.Text) Then
    '        'MsgBox("Entered score is greater than declared HPS for Written Work 1: " & hps3.Text, MsgBoxStyle.Critical, "Error")
    '        TextBox8.Focus()
    '    End If
    'End Sub

    'Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
    '    lblWWTotal.Text = Val(hps1.Text) + Val(hps2.Text) + Val(hps3.Text)
    '    scoreSum += Val(TextBox8.Text)
    '    lblWrittenWorksPS.Text = scoreSum
    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    'End Sub

    'Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    'End Sub

    'Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
    '    varhps1 = Val(hps3.Text)
    '    Dim a, b
    '    If Val(hps1.Text) < 1 Then
    '        Do While Val(hps3.Text) < 1
    '            a = InputBox("Please enter Highest Possible Score: ", "HPS Input for Written Work 1")
    '            hps3.Text = a
    '        Loop
    '    ElseIf Val(TextBox8.Text) > varhps1 Then
    '        b = MsgBox("Entered score is greater than declared HPS for Written Work 1: " & hps3.Text & "Reenter HPS?", MsgBoxStyle.YesNo & MsgBoxStyle.Critical, "Error")
    '        If b = vbYes Then

    '        End If
    '    End If
    '    lblWWTotal.Text = Val(hps1.Text) + Val(hps2.Text) + Val(hps3.Text)
    '    scoreSum += Val(TextBox8.Text)
    '    lblWrittenWorksPS.Text = scoreSum
    'End Sub
End Class
