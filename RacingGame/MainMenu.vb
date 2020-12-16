Public Class MainMenu
    Public col As Color
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Form1.BackColor = Color.Red
        Form1.Speed_Text.BackColor = Color.Red
        Form1.Score_Text.BackColor = Color.Red
        col = Color.Red
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Form1.BackColor = Color.Gray
        Form1.Speed_Text.BackColor = Color.Gray
        Form1.Score_Text.BackColor = Color.Gray
        col = Color.Gray
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Form1.BackColor = Color.LightGreen
        Form1.Speed_Text.BackColor = Color.LightGreen
        Form1.Score_Text.BackColor = Color.LightGreen
        col = Color.LightGreen
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RadioButton1.Checked = True Or RadioButton2.Checked = True Or RadioButton3.Checked = True Or RadioButton4.Checked = True) And (RadBtn_Easy.Checked = True Or RadBtn_Medium.Checked = True Or RadBtn_Hard.Checked = True) Then
            Form1.Show()
        Else
            MsgBox("You must choose a color and difficulty level!")
            Return
        End If

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Form1.BackColor = Color.Blue
        Form1.Speed_Text.BackColor = Color.Blue
        Form1.Score_Text.BackColor = Color.Blue
        col = Color.Blue
    End Sub

End Class