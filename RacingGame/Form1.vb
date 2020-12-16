Public Class Form1

    Dim speed As Integer 'brzina ceste'
    Dim road(7) As PictureBox
    Dim score As Integer = 0
    Dim highscore As Integer = 0
    Dim playerName As String = ""
    Dim output = ""
    Dim FileNum As Integer

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainMenu.Hide()

        speed = 3

        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8

        FileNum = FreeFile()
        FileOpen(FileNum, "score.txt", OpenMode.Input)
        playerName = LineInput(FileNum)
        highscore = LineInput(FileNum)
        output = playerName + Str(highscore)
        FileClose(FileNum)

    End Sub

    Private Sub RoadMover_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick
        For x As Integer = 0 To 7
            If road(x) IsNot Nothing Then
                'pomicemo cestu'
                road(x).Top += speed
                'beskonacna petlja koja osigurava ponavljanje bijelih traka:'
                If road(x).Top >= Me.Height Then
                    road(x).Top = -road(x).Height
                End If
            End If
        Next

        If MainMenu.RadBtn_Easy.Checked = True Then
            If score > 10 And score < 20 Then
                speed = 3.2
            End If

            If score > 20 And score < 30 Then
                speed = 3.5
            End If

            If score > 30 And score < 50 Then
                speed = 4
            End If

            If score > 50 And score < 70 Then
                speed = 4.5
            End If

            If score > 70 Then
                speed = 5
            End If
            Speed_Text.Text = "Speed " & speed
        End If

        If MainMenu.RadBtn_Medium.Checked = True Then
            If score > 10 And score < 20 Then
                speed = 4
            End If

            If score > 20 And score < 30 Then
                speed = 4.5
            End If

            If score > 30 And score < 50 Then
                speed = 5
            End If

            If score > 50 And score < 70 Then
                speed = 5.5
            End If

            If score > 70 Then
                speed = 6
            End If
            Speed_Text.Text = "Speed " & speed
        End If

        If MainMenu.RadBtn_Hard.Checked = True Then
            If score > 10 And score < 20 Then
                speed = 4
            End If

            If score > 20 And score < 30 Then
                speed = 5
            End If

            If score > 30 And score < 50 Then
                speed = 5.5
            End If

            If score > 50 And score < 70 Then
                speed = 6
            End If

            If score > 70 Then
                speed = 6.5
            End If
            Speed_Text.Text = "Speed " & speed
        End If

        If (Car.Bounds.IntersectsWith(EnemyCar1.Bounds)) Then
            My.Computer.Audio.Play(My.Resources._72866__tim_kahn__game_over_wav, AudioPlayMode.Background)
            gameOver()
        End If

        If (Car.Bounds.IntersectsWith(EnemyCar2.Bounds)) Then
            My.Computer.Audio.Play(My.Resources._72866__tim_kahn__game_over_wav, AudioPlayMode.Background)
            gameOver()
        End If

        If (Car.Bounds.IntersectsWith(EnemyCar3.Bounds)) Then
            My.Computer.Audio.Play(My.Resources._72866__tim_kahn__game_over_wav, AudioPlayMode.Background)
            gameOver()
        End If

    End Sub
    Private Sub gameOver()
        Replay_Button.Visible = True
        End_Text.Visible = True
        RoadMover.Stop()
        Enemy1_Mover.Stop()
        Enemy2_Mover.Stop()
        Enemy3_Mover.Stop()
        MenuStrip1.Visible = True

        If score > highscore Then
            My.Computer.Audio.Play(My.Resources._353546__maxmakessounds__success, AudioPlayMode.Background)

            MsgBox("NEW HIGHSCORE!")
            MsgBox("Click on File and then Highscore to enter your name.")
        End If

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            RightMover.Start()
        End If

        If e.KeyCode = Keys.Left Then
            LeftMover.Start()
        End If

        If e.KeyCode = Keys.Space Then

            If End_Text.Visible = True Then
                Btn_Pause.Visible = False
                Lbl_Resume.Visible = False
            Else
                RoadMover.Stop()
                Enemy1_Mover.Stop()
                Enemy2_Mover.Stop()
                Enemy3_Mover.Stop()
                Btn_Pause.Visible = True
                Lbl_Resume.Visible = True
                MenuStrip1.Visible = True
                RulesToolStripMenuItem.Visible = False
            End If

        End If

        If e.KeyCode = Keys.A Or e.KeyCode = Keys.Enter Then
            If End_Text.Visible = False Then
                RoadMover.Start()
                Enemy1_Mover.Start()
                Enemy2_Mover.Start()
                Enemy3_Mover.Start()

                Btn_Pause.Visible = False
                Lbl_Resume.Visible = False
                MenuStrip1.Visible = False
                RulesToolStripMenuItem.Visible = True
            Else
                RoadMover.Stop()
                Enemy1_Mover.Stop()
                Enemy2_Mover.Stop()
                Enemy3_Mover.Stop()
            End If

        End If

    End Sub
    Private Sub RightMover_Tick(sender As Object, e As EventArgs) Handles RightMover.Tick
        If (Car.Location.X < 135) Then
            Car.Left += 5
        End If

    End Sub
    Private Sub LeftMover_Tick(sender As Object, e As EventArgs) Handles LeftMover.Tick
        If (Car.Location.X > 0) Then
            Car.Left -= 5
        End If

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        RightMover.Stop()
        LeftMover.Stop()

    End Sub

    Private Sub Enemy1_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy1_Mover.Tick
        EnemyCar1.Top += speed  '-kretanje prvog protivnika'

        'ponovno ponavljanje 1. protivnika'
        If EnemyCar1.Top >= Me.Height Then
            score += 1
            Score_Text.Text = "Score " & score

            EnemyCar1.Top = -CInt(Math.Ceiling(Rnd() * 150) + EnemyCar1.Height)
            EnemyCar1.Left = CInt(Math.Ceiling(Rnd() * 50)) + 0
        End If

    End Sub

    Private Sub Enemy2_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy2_Mover.Tick
        EnemyCar2.Top += speed

        If EnemyCar2.Top >= Me.Height Then
            score += 1
            Score_Text.Text = "Score " & score

            EnemyCar2.Top = -CInt(Math.Ceiling(Rnd() * 150) + EnemyCar2.Height)
            EnemyCar2.Left = CInt(Math.Ceiling(Rnd() * 30)) + 70
        End If

    End Sub

    Private Sub Enemy3_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy3_Mover.Tick
        EnemyCar3.Top += speed

        If EnemyCar3.Top >= Me.Height Then
            score += 1
            Score_Text.Text = "Score " & score

            EnemyCar3.Top = -CInt(Math.Ceiling(Rnd() * 150) + EnemyCar3.Height)
            EnemyCar3.Left = CInt(Math.Ceiling(Rnd() * 40)) + 110
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Replay_Button.Click, NewGameToolStripMenuItem.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
        BackColor = MainMenu.col
        Speed_Text.BackColor = MainMenu.col
        Score_Text.BackColor = MainMenu.col

        If MainMenu.RadioButton1.Checked = True Then
            BackColor = Color.Red
        End If
        If MainMenu.RadioButton2.Checked = True Then
            BackColor = Color.Gray
        End If
        If MainMenu.RadioButton3.Checked = True Then
            BackColor = Color.LightGreen
        End If
        If MainMenu.RadioButton4.Checked = True Then
            BackColor = Color.Blue
        End If
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Close()
    End Sub

    Private Sub RulesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RulesToolStripMenuItem.Click
        MsgBox("Try to avoid as much car as you can.")
    End Sub

    Private Sub HighscoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HighscoreToolStripMenuItem.Click
        If score > highscore Then
            highscore = score
            playerName = InputBox("Enter your name", "Enter your name")
            output = playerName + Str(highscore)
            MessageBox.Show("Best player and high score: " & output)
            FileNum = FreeFile()
            FileOpen(FileNum, "score.txt", OpenMode.Output)
            PrintLine(FileNum, playerName)
            PrintLine(FileNum, highscore)
            FileClose(FileNum)
        End If

        output = playerName + " " + CStr(highscore)
        MessageBox.Show("Best player and highscore: " & output)
    End Sub

End Class
