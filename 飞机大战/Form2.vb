'主游戏界面
'=============================================
Public Class Form2
    '-------------------初始化--------------------
    Dim x(0 To 2), y(0 To 2) As Integer                     '敌机移动参数
    Dim P_Up As Boolean, P_Down As Boolean, P_Left As Boolean, P_Right As Boolean '玩家控制参数
    Dim v As Integer 'Boss飞行参数
    Dim Fire As Boolean '开火
    Dim TimeList As New ArrayList  '时间队列
    Dim Enemy As New ArrayList '敌机队列
    Dim Bullet As New ArrayList '子弹队列
    Dim Ebul As New ArrayList '敌机子弹队列
    Dim B_N = 15
    Dim Baoz As Integer
    Public Time As Int32
    Public Score As Integer

    '玩家初始化,生命值，生命上限，攻击速度
    Public Sub InitPlayer(nhp As Integer, hpmax As Integer, ss As Integer)
        Player.Image = Image.FromFile(Application.StartupPath + "\draw\f1.jpg")
        Player.Location = New Point(260, 560)
        HP.Maximum = hpmax
        HP.Value = nhp
        HPN.Text = nhp
        ''HPN.Parent = Me
        'HPN.BackColor = Color.Transparent
        P_Up = False
        P_Down = False
        P_Left = False
        P_Right = False
        Fire = False
        PLayer_Move.Enabled = True '可移动
        PLayer_Move.Interval = 1
        Open_Fire.Enabled = True      '可开火
        Open_Fire.Interval = ss
    End Sub
    '宝物初始化
    Public Sub InitBao()
        'Bao.Image = Image.FromFile(Application.StartupPath + "\draw\bao1.jpg")
        Bao.Visible = False
    End Sub
    'boss初始化
    Public Sub InitBoss()
        Boss.Image = Image.FromFile(Application.StartupPath + "\draw\boss.jpg")
        Boss.Top = 0 - Boss.Height
        Boss_Move.Enabled = False 'Boss开局不存在
        Boss_Move.Interval = 1
        Boss.Visible = False
        BossHP.Visible = False
        BossHP.Value = 500
        Boss_Laser1.Visible = False
        Boss_Laser2.Visible = False
        Raser.Enabled = False
        Raser.Interval = 10
    End Sub
    '初始化子弹
    Public Sub InitBullet(type As String)
        Dim i As Integer
        For i = 0 To B_N Step 1
            Bullet(i).Image = Image.FromFile(Application.StartupPath + type)
            Bullet(i).Visible = False
        Next
        For i = 0 To 3 Step 1
            Ebul(i).Image = Image.FromFile(Application.StartupPath + "\draw\z2s.jpg")
            Ebul(i).Visible = False
        Next
        Bullet_Move.Enabled = True '子弹可动
        Bullet_Move.Interval = 1
    End Sub
    '初始化敌机
    Public Sub InitEnemy(type As String)
        Dim i As Integer
        For i = 0 To 2 Step 1
            Enemy(i).Image = Image.FromFile(Application.StartupPath + type)
            Enemy(i).visible = False
        Next
        Enemy_Move.Enabled = True '敌机可动
        Enemy_Move.Interval = 10
        Enemy_Reborn.Enabled = True '敌机刷新
        Enemy_Reborn.Interval = 1000
    End Sub

    '数组构建
    Public Sub BuildTimeArray() 'timer控件数组
        TimeList.Add(PLayer_Move)
        TimeList.Add(Open_Fire)
        TimeList.Add(Enemy_Move)
        TimeList.Add(Enemy_Reborn)
        TimeList.Add(Bullet_Move)
        TimeList.Add(Boss_Move)
        TimeList.Add(Raser)
    End Sub
    Public Sub BuildEnemyArray() '敌机数组
        Enemy.Add(Enemy0)
        Enemy.Add(Enemy1)
        Enemy.Add(Enemy2)
    End Sub
    Public Sub BuildBulletArray() '子弹数组
        Bullet.Add(Bullet0)
        Bullet.Add(Bullet1)
        Bullet.Add(Bullet2)
        Bullet.Add(Bullet3)
        Bullet.Add(Bullet4)
        Bullet.Add(Bullet5)
        Bullet.Add(Bullet6)
        Bullet.Add(Bullet7)
        Bullet.Add(Bullet8)
        Bullet.Add(Bullet9)
        Bullet.Add(Bullet10)
        Bullet.Add(Bullet11)
        Bullet.Add(Bullet12)
        Bullet.Add(Bullet13)
        Bullet.Add(Bullet14)
        Bullet.Add(Bullet15)
        Ebul.Add(Ebul0)
        Ebul.Add(Ebul1)
        Ebul.Add(Ebul2)
        Ebul.Add(Ebul3)
    End Sub

    '系统操作
    Public Sub Lose() '输了退出游戏
        Pause()
        Me.Hide()
        Form5.ShowDialog()
        Me.Show()
    End Sub
    Public Sub Win() '赢了退出游戏
        Pause()
        Me.Hide()
        Form5.ShowDialog()
        Me.Show()
    End Sub
    Public Sub Pause() '暂停
        Dim i As Integer
        For i = 0 To 6 Step 1
            TimeList(i).Enabled = False
        Next
        P_Up = False
        P_Down = False
        P_Left = False
        P_Right = False
        Fire = False
    End Sub
    Public Sub Go() '继续
        Dim i As Integer
        For i = 0 To 6 Step 1
            TimeList(i).Enabled = True
        Next
    End Sub
    '强化选择
    Public Sub Choose_One()
        Pause()
        Me.Hide()
        Form4.ShowDialog()
        Me.Show()
    End Sub
    Public Sub Init()
        BuildTimeArray()
        BuildBulletArray()
        BuildEnemyArray()
        InitPlayer(100, 100, 300)
        InitBao()
        InitBoss()
        InitEnemy("\draw\f2.jpg")
        InitBullet("\draw\z1s.jpg")
        Time = 0
        Score = 0
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load '主窗体加载
        Init()
        'BuildTimeArray()
        'BuildBulletArray()
        'BuildEnemyArray()
        'InitPlayer(100, 100, 300)
        'InitBoss()
        'InitEnemy("\draw\f2.jpg")
        'InitBullet("\draw\z1s.jpg")
        'Time = 0
        'Score = 0
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

    Private Sub Form2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress '全屏大招
        If e.KeyChar = "k" Then
            Win()
            'InitEnemy("\draw\f2.jpg")
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

        If HP.Value <= 0 Then '死亡
            Lose()
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
                If HP.Value - 10 > 0 Then
                    HP.Value -= 10
                Else
                    HP.Value = 0
                End If
                Enemy(i).visible = False
            End If
        Next

        HPN.Text = HP.Value
        Label4.Text = Score
        Label2.Text = Time
    End Sub

    '敌机飞行与开火
    Private Sub Enemy_Move_Tick(sender As Object, e As EventArgs) Handles Enemy_Move.Tick
        Dim i As Integer
        Dim j As Integer
        For i = 0 To 2 Step 1
            If Enemy(i).Visible = True Then
                Enemy(i).Top = Enemy(i).Top + y(i)
                Enemy(i).Left = Enemy(i).Left + x(i)

                If Rnd(1) > 0.99 Then
                    For j = 0 To 3 Step 1
                        If Ebul(j).visible = False Then
                            Ebul(j).Top = Enemy(i).Top + Enemy(i).Height
                            Ebul(j).Left = Enemy(i).Left + (Enemy(i).Width - Ebul(j).Width) \ 2
                            Ebul(j).Visible = True
                            Exit For
                        End If
                    Next
                End If

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
                y(i) = 1 + Int(Rnd(2) * 100) Mod 3
            End If
        Next

        Time += 1
        'If Time = 180 Then '胜利条件
        '    Win()
        'End If


        If (Time = 60) And (Boss.Visible = False) Then
            Enemy_Reborn.Enabled = False
            InitBoss()
            Boss_Move.Enabled = True
            Boss.Visible = True
            BossHP.Visible = True
            Raser.Enabled = True
            v = 2
        End If
    End Sub

    '开火
    Private Sub Open_Fire_Tick(sender As Object, e As EventArgs) Handles Open_Fire.Tick
        Dim i As Integer
        If Fire Then
            For i = 0 To B_N Step 1
                If Bullet(i).visible = False Then
                    Bullet(i).Top = Player.Top
                    Bullet(i).Left = Player.Left + (Player.Width - Bullet(i).Width) \ 2
                    Bullet(i).Visible = True
                    Exit For
                End If
            Next
        End If
    End Sub

    '子弹飞行及其碰撞检查
    Private Sub Bullet_Move_Tick(sender As Object, e As EventArgs) Handles Bullet_Move.Tick
        '(中心距离检测法)
        'Dim bx(4) As Integer '中心坐标
        'Dim by(4) As Integer
        'Dim ex(3) As Integer
        'Dim ey(3) As Integer
        'Dim i As Integer
        'For i = 0 To 3 Step 1
        '    bx(i) = Bullet(i).Left + Bullet(i).Width / 2
        '    by(i) = Bullet(i).Top + Bullet(i).Height / 2
        'Next
        'For i = 0 To 2 Step 1
        '    ex(i) = Enemy(i).Left + Enemy(i).Width / 2
        '    ey(i) = Enemy(i).Top + Enemy(i).Height / 2
        'Next
        'Dim j As Integer
        'For i = 0 To 3 Step 1
        '    For j = 0 To 2 Step 1
        '        Dim dx As Integer
        '        Dim dy As Integer
        '        dx = bx(i) - ex(j)
        '        dy = by(i) - ey(j)
        '        If (System.Math.Sqrt(dx * dx + dy * dy) < 70) And (Bullet(i).visible = True) And Enemy(j).visible = True Then
        '            Bullet(i).visible = False
        '            Enemy(j).visible = False
        '            Score += 1
        '        End If
        '    Next
        'Next

        '(重叠检测法)
        '玩家子弹
        Dim i As Integer
        Dim j As Integer
        For i = 0 To B_N Step 1 '击中
            For j = 0 To 2 Step 1
                If ((Bullet(i).Left < Enemy(j).Left + Enemy(j).Width) And (Bullet(i).Left + Bullet(i).Width > Enemy(j).Left) And
                    (Bullet(i).Top < Enemy(j).Top + Enemy(j).Height) And (Bullet(i).Top + Bullet(i).Height > Enemy(j).Top) And
                    Bullet(i).visible = True And Enemy(j).visible = True) Then
                    Bullet(i).visible = False
                    Enemy(j).visible = False
                    Dim x As Double
                    x = Rnd(1) '宝物掉落
                    If Bao.Visible = False Then
                        If (x > 0.95) Then
                            Bao.Visible = True
                            Bao.Image = Image.FromFile(Application.StartupPath + "\draw\bao1.jpg")
                            Bao.Left = Enemy(j).Left
                            Bao.Top = Enemy(j).Top
                            Baoz = 1
                        End If
                        x = Rnd(2)
                        If (x > 0.8) And (Bao.Visible = True) Then
                            Bao.Visible = True
                            Bao.Image = Image.FromFile(Application.StartupPath + "\draw\bao2.jpg")
                            Bao.Left = Enemy(j).Left
                            Bao.Top = Enemy(j).Top
                            Baoz = 2
                        End If
                    End If
                    Score += 1
                End If
            Next
        Next
        For i = 0 To B_N Step 1 '飞行
            If Bullet(i).Visible = True Then
                Bullet(i).Top = Bullet(i).Top - 10
                If Bullet(i).Top < 0 Then
                    Bullet(i).Visible = False
                End If
            End If
        Next
        '-----------------------
        '敌机子弹
        For i = 0 To 3 Step 1 '击中
            If ((Ebul(i).Left < Player.Left + Player.Width) And (Ebul(i).Left + Ebul(i).Width > Player.Left) And
                    (Ebul(i).Top < Player.Top + Player.Height) And (Ebul(i).Top + Ebul(i).Height > Player.Top) And
                    Ebul(i).visible = True) Then
                Ebul(i).visible = False
                If HP.Value - 5 > 0 Then
                    HP.Value -= 5
                End If
            End If
        Next
        For i = 0 To 3 Step 1 '飞行
            If Ebul(i).Visible = True Then
                Ebul(i).Top = Ebul(i).Top + 10
                If Ebul(i).Top > Height Then
                    Ebul(i).Visible = False
                End If
            End If
        Next
        '宝物
        If ((Bao.Left < Player.Left + Player.Width) And (Bao.Left + Bao.Width > Player.Left) And
                    (Bao.Top < Player.Top + Player.Height) And (Bao.Top + Bao.Height > Player.Top) And
                    Bao.Visible = True) Then
            Bao.Visible = False
            If Baoz = 1 Then
                If HP.Value + 25 < HP.Maximum Then
                    HP.Value += 25
                Else
                    HP.Value = HP.Maximum
                End If
            ElseIf Baoz = 2 Then
                Choose_One()
            End If
        End If
        If Bao.Visible = True Then '飞行
            Bao.Top += 1
            If Bao.Top > Height Then
                Bao.Visible = False
            End If
        End If

    End Sub
    'Boss飞行
    Private Sub Boss_Move_Tick(sender As Object, e As EventArgs) Handles Boss_Move.Tick
        If Boss.Visible = True Then
            If BossHP.Value = 0 Then
                Boss.Visible = False
                BossHP.Visible = False
                Raser.Enabled = False
                'Choose_One()
                Score += 10
                Win()
            End If
            If Boss.Top < 0 Then
                Boss.Top += 2
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
            BossHP.Top = Boss.Top
            Boss_Laser1.Left = Boss.Left + 10
            Boss_Laser1.Top = Boss.Top + 135
            Boss_Laser2.Left = Boss.Left + Boss.Width - Boss_Laser2.Width - 10
            Boss_Laser2.Top = Boss.Top + 135

            Dim i As Integer
            For i = 0 To B_N Step 1
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

    'boss镭射
    Private Sub Raser_Tick(sender As Object, e As EventArgs) Handles Raser.Tick
        If (Boss.Left > 300 And Boss.Left < 400 And v > 0) Or (Boss.Left > 50 And Boss.Left < 150 And v < 0) Then
            Boss_Laser1.Visible = True
            Boss_Laser2.Visible = True
        Else
            Boss_Laser1.Visible = False
            Boss_Laser2.Visible = False
        End If

        If (Boss_Laser1.Left < Player.Left + Player.Width And Boss_Laser1.Left + Boss_Laser1.Width > Player.Left) And Boss_Laser1.Visible Then
            If HP.Value > 0 Then
                HP.Value -= 1
            End If
        End If

        If (Boss_Laser2.Left < Player.Left + Player.Width And Boss_Laser2.Left + Boss_Laser2.Width > Player.Left) And Boss_Laser2.Visible Then
            If HP.Value > 0 Then
                HP.Value -= 1
            End If
        End If
    End Sub

End Class