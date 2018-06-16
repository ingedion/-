'主游戏界面
'=============================================
Public Class Form2
    '-------------------初始化--------------------
    Dim x(0 To 2), y(0 To 2) As Integer                     '敌机移动参数
    Dim P_Up, P_Down, P_Left, P_Right As Boolean '玩家控制参数
    Dim v As Integer 'Boss飞行参数
    Dim Fire As Boolean '开火
    Dim TimeList As New ArrayList  '时间队列
    Dim Enemy As New ArrayList '敌机队列
    Dim Bullet As New ArrayList '子弹队列
    Dim Time As Int32
    Dim Score As Integer
    Private Sub BuildTimeArray()
        TimeList.Add(PLayer_Move)
        TimeList.Add(Open_Fire)
        TimeList.Add(Enemy_Move)
        TimeList.Add(Enemy_Reborn)
        TimeList.Add(Bullet_Move)
    End Sub
    Private Sub BuildEnemyArray()
        Enemy.Add(Enemy0)
        Enemy.Add(Enemy1)
        Enemy.Add(Enemy2)
    End Sub
    Private Sub BuildBulletArray()
        Bullet.Add(Bullet0)
        Bullet.Add(Bullet1)
        Bullet.Add(Bullet2)
        Bullet.Add(Bullet3)
    End Sub
    Public Sub Exitgame() '退出游戏
        Me.Close()
    End Sub
    Private Sub Pause_or_go() '暂停和继续
        Dim i As Integer
        For i = 0 To 4 Step 1
            TimeList(i).Enabled = Not (TimeList(i).Enabled)
        Next
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Player.Image = Image.FromFile(Application.StartupPath + "\draw\f1.jpg")
        Boss.Image = Image.FromFile(Application.StartupPath + "\draw\boss.jpg")
        Enemy0.Image = Image.FromFile(Application.StartupPath + "\draw\f2.jpg")
        Enemy1.Image = Image.FromFile(Application.StartupPath + "\draw\f2.jpg")
        Enemy2.Image = Image.FromFile(Application.StartupPath + "\draw\f2.jpg")
        Bullet0.Image = Image.FromFile(Application.StartupPath + "\draw\z1.jpg")
        Bullet1.Image = Image.FromFile(Application.StartupPath + "\draw\z1.jpg")
        Bullet2.Image = Image.FromFile(Application.StartupPath + "\draw\z1.jpg")
        Bullet3.Image = Image.FromFile(Application.StartupPath + "\draw\z1.jpg")
        BuildTimeArray()
        BuildBulletArray()
        BuildEnemyArray()
        Dim i As Integer
        For i = 0 To 3 Step 1
            Bullet(i).Visible = False
        Next
        'Bullet0.Visible = False
        'Bullet1.Visible = False
        'Bullet2.Visible = False
        'Bullet3.Visible = False
        For i = 0 To 2 Step 1
            Enemy(i).visible = False
        Next
        Boss.Visible = False
        BossHP.Visible = False
        'Enemy0.Visible = False
        'Enemy1.Visible = False
        'Enemy2.Visible = False
        P_Up = False
        P_Down = False
        P_Left = False
        P_Right = False
        Fire = False
        PLayer_Move.Enabled = True '可移动
        PLayer_Move.Interval = 1
        Open_Fire.Enabled = True      '可开火
        Open_Fire.Interval = 200
        Bullet_Move.Enabled = True '子弹可动
        Bullet_Move.Interval = 1
        Enemy_Move.Enabled = True '敌机可动
        Enemy_Move.Interval = 10
        Enemy_Reborn.Enabled = True '敌机刷新
        Enemy_Reborn.Interval = 1000
        Boss_Move.Enabled = False 'Boss开局不存在
        Boss_Move.Interval = 1
        Time = 20
        Score = 0
    End Sub
    '-----------------事件捕捉----------------------

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.W Then
            P_Up = True
        End If
        If e.KeyValue = Keys.S Then
            P_Down = True
        End If
        If e.KeyValue = Keys.A Then
            P_Left = True
        End If
        If e.KeyValue = Keys.D Then
            P_Right = True
        End If
        If e.KeyValue = Keys.J Then
            Fire = True
        End If
    End Sub

    Private Sub Form2_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyValue = Keys.W Then
            P_Up = False
        End If
        If e.KeyValue = Keys.S Then
            P_Down = False
        End If
        If e.KeyValue = Keys.A Then
            P_Left = False
        End If
        If e.KeyValue = Keys.D Then
            P_Right = False
        End If
        If e.KeyValue = Keys.J Then
            Fire = False
        End If
    End Sub
    '-----------------屏幕刷新----------------------
    '玩家飞行及碰撞检查
    Private Sub PLayer_Move_Tick(sender As Object, e As EventArgs) Handles PLayer_Move.Tick
        Dim Bottom = Height - Player.Height '界面底边界
        Dim Right = Width - Player.Width '界面右边界
        If P_Up Then
            If Player.Top > 0 Then
                Player.Top -= 4
            Else
                Player.Top = 0
            End If
        End If
        If P_Down Then
            If Player.Top < Bottom Then
                Player.Top += 4
            Else
                Player.Top = Bottom
            End If
        End If
        If P_Left Then
            If Player.Left > 0 Then
                Player.Left -= 4
            Else
                Player.Left = 0
            End If
        End If
        If P_Right Then
            If Player.Left < Right Then
                Player.Left += 4
            Else
                Player.Left = Right
            End If
        End If

        Dim px As Integer
        Dim py As Integer
        Dim dx As Integer
        Dim dy As Integer
        Dim ex(3) As Integer
        Dim ey(3) As Integer
        px = Player.Left + Int(Player.Width / 2)
        py = Player.Top + Int(Player.Height / 2)
        For i = 0 To 2 Step 1
            ex(i) = Enemy(i).Left + Enemy(i).Width / 2
            ey(i) = Enemy(i).Top + Enemy(i).Height / 2
            dx = System.Math.Abs(ex(i) - px)
            dy = System.Math.Abs(ey(i) - py)
            If (System.Math.Sqrt(dx * dx + dy * dy)) < 100 And Enemy(i).visible Then
                HP.Value -= 10
                Enemy(i).visible = False
                If HP.Value <= 0 Then
                    'Exitgame()
                End If
            End If
        Next

        Label4.Text = Score
        Label2.Text = Time
    End Sub

    '敌机飞行
    Private Sub Enemy_Move_Tick(sender As Object, e As EventArgs) Handles Enemy_Move.Tick
        Dim i As Integer
        For i = 0 To 2 Step 1
            If Enemy(i).Visible = True Then
                Enemy(i).Top = Enemy(i).Top + y(i)
                Enemy(i).Left = Enemy(i).Left + x(i)
                If Enemy(i).Top > Height Then
                    Enemy(i).Visible = False
                End If
                If Enemy(i).Left < 0 Then
                    Enemy(i).left = 0
                    x(i) = -x(i)
                End If
                If Enemy(i).Left > Width - Enemy(i).Width Then
                    Enemy(i).left = Width - Enemy(i).Width
                    x(i) = -x(i)
                End If
            End If
        Next
    End Sub

    '刷新敌机
    Private Sub Enemy_Reborn_Tick(sender As Object, e As EventArgs) Handles Enemy_Reborn.Tick
        Dim i As Integer
        For i = 0 To 2 Step 1
            If Enemy(i).visible = False Then
                Enemy(i).Top = 0 - Enemy0.Height
                Enemy(i).Left = Int(Rnd(1) * 1000) Mod Width
                Enemy(i).Visible = True
                x(i) = Int(Rnd(2) * 100) Mod 10 - 5
                y(i) = 1 + Int(Rnd(2) * 100) Mod 6
            End If
        Next

        If Time > 0 Then
            Time -= 1
        End If

        If Time = 0 Then
            Enemy_Reborn.Enabled = False
            Boss_Move.Enabled = True
            Boss.Visible = True
            BossHP.Visible = True
            v = 2
        End If
    End Sub

    '开火
    Private Sub Open_Fire_Tick(sender As Object, e As EventArgs) Handles Open_Fire.Tick
        Dim i As Integer
        If Fire Then
            For i = 0 To 3 Step 1
                If Bullet(i).visible = False Then
                    Bullet(i).Top = Player.Top
                    Bullet(i).Left = Player.Left + (Player.Width - Bullet(i).Width) \ 2
                    Bullet(i).Visible = True
                    Exit For
                End If
            Next
        End If
    End Sub

    '子弹飞行及其碰撞检查(中心距离检测法)
    Private Sub Bullet_Move_Tick(sender As Object, e As EventArgs) Handles Bullet_Move.Tick
        Dim bx(4) As Integer '中心坐标
        Dim by(4) As Integer
        Dim ex(3) As Integer
        Dim ey(3) As Integer
        Dim i As Integer
        For i = 0 To 3 Step 1
            bx(i) = Bullet(i).Left + Bullet(i).Width / 2
            by(i) = Bullet(i).Top + Bullet(i).Height / 2
        Next
        For i = 0 To 2 Step 1
            ex(i) = Enemy(i).Left + Enemy(i).Width / 2
            ey(i) = Enemy(i).Top + Enemy(i).Height / 2
        Next
        Dim j As Integer
        For i = 0 To 3 Step 1
            For j = 0 To 2 Step 1
                Dim dx As Integer
                Dim dy As Integer
                dx = bx(i) - ex(j)
                dy = by(i) - ey(j)
                If (System.Math.Sqrt(dx * dx + dy * dy) < 70) And (Bullet(i).visible = True) Then
                    Bullet(i).visible = False
                    Enemy(j).visible = False
                    Score += 1
                End If
            Next
        Next

        For i = 0 To 3 Step 1
            If Bullet(i).Visible = True Then
                Bullet(i).Top = Bullet(i).Top - 10
                If Bullet(i).Top < 0 Then
                    Bullet(i).Visible = False
                End If
            End If
        Next
    End Sub
    'Boss飞行
    Private Sub Boss_Move_Tick(sender As Object, e As EventArgs) Handles Boss_Move.Tick
        If Boss.Visible = True Then
            If BossHP.Value = 0 Then
                Boss.Visible = False
                BossHP.Visible = False
            End If
            Boss.Left = Boss.Left + v
            If Boss.Left > Width - Boss.Width Then
                Boss.Left = Width - Boss.Width
                v = -v
            End If
            If Boss.Left < 0 Then
                Boss.Left = 0
                v = -v
            End If

            BossHP.Left = Boss.Left + (Boss.Width - BossHP.Width) / 2

            Dim i As Integer
            For i = 0 To 3 Step 1
                If Bullet(i).Visible = True Then
                    If (Bullet(i).Top <= Boss.Top + Boss.Height) And (Bullet(i).Left + Bullet(i).Width > Boss.Left) And (Bullet(i).Left < Boss.Left + Boss.Width) Then
                        Bullet(i).Visible = False
                        If BossHP.Value > 0 Then
                            BossHP.Value -= 20
                        End If
                    End If
                End If
            Next
        End If
    End Sub
End Class