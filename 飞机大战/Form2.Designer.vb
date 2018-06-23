<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Enemy0 = New System.Windows.Forms.PictureBox()
        Me.Bullet0 = New System.Windows.Forms.PictureBox()
        Me.Bullet1 = New System.Windows.Forms.PictureBox()
        Me.Bullet3 = New System.Windows.Forms.PictureBox()
        Me.Enemy1 = New System.Windows.Forms.PictureBox()
        Me.Enemy2 = New System.Windows.Forms.PictureBox()
        Me.Bullet2 = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.PLayer_Move = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy_Move = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy_Reborn = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Open_Fire = New System.Windows.Forms.Timer(Me.components)
        Me.Bullet_Move = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HP = New System.Windows.Forms.ProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Boss = New System.Windows.Forms.PictureBox()
        Me.BossHP = New System.Windows.Forms.ProgressBar()
        Me.Boss_Move = New System.Windows.Forms.Timer(Me.components)
        Me.Boss_Laser1 = New System.Windows.Forms.PictureBox()
        Me.Boss_Laser2 = New System.Windows.Forms.PictureBox()
        Me.Raser = New System.Windows.Forms.Timer(Me.components)
        Me.Bullet4 = New System.Windows.Forms.PictureBox()
        Me.Bullet5 = New System.Windows.Forms.PictureBox()
        Me.Bullet6 = New System.Windows.Forms.PictureBox()
        Me.Bullet7 = New System.Windows.Forms.PictureBox()
        Me.Bullet11 = New System.Windows.Forms.PictureBox()
        Me.Bullet10 = New System.Windows.Forms.PictureBox()
        Me.Bullet9 = New System.Windows.Forms.PictureBox()
        Me.Bullet8 = New System.Windows.Forms.PictureBox()
        Me.Bullet15 = New System.Windows.Forms.PictureBox()
        Me.Bullet14 = New System.Windows.Forms.PictureBox()
        Me.Bullet13 = New System.Windows.Forms.PictureBox()
        Me.Bullet12 = New System.Windows.Forms.PictureBox()
        Me.Ebul0 = New System.Windows.Forms.PictureBox()
        Me.Ebul1 = New System.Windows.Forms.PictureBox()
        Me.Ebul2 = New System.Windows.Forms.PictureBox()
        Me.Ebul3 = New System.Windows.Forms.PictureBox()
        Me.HPN = New System.Windows.Forms.Label()
        Me.Bao = New System.Windows.Forms.PictureBox()
        CType(Me.Enemy0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Boss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Boss_Laser1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Boss_Laser2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ebul0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ebul1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ebul2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ebul3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Enemy0
        '
        Me.Enemy0.Location = New System.Drawing.Point(671, 27)
        Me.Enemy0.Name = "Enemy0"
        Me.Enemy0.Size = New System.Drawing.Size(100, 120)
        Me.Enemy0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Enemy0.TabIndex = 0
        Me.Enemy0.TabStop = False
        '
        'Bullet0
        '
        Me.Bullet0.Location = New System.Drawing.Point(513, 781)
        Me.Bullet0.Name = "Bullet0"
        Me.Bullet0.Size = New System.Drawing.Size(60, 60)
        Me.Bullet0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bullet0.TabIndex = 1
        Me.Bullet0.TabStop = False
        '
        'Bullet1
        '
        Me.Bullet1.Location = New System.Drawing.Point(579, 781)
        Me.Bullet1.Name = "Bullet1"
        Me.Bullet1.Size = New System.Drawing.Size(60, 60)
        Me.Bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bullet1.TabIndex = 2
        Me.Bullet1.TabStop = False
        '
        'Bullet3
        '
        Me.Bullet3.Location = New System.Drawing.Point(711, 781)
        Me.Bullet3.Name = "Bullet3"
        Me.Bullet3.Size = New System.Drawing.Size(60, 60)
        Me.Bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bullet3.TabIndex = 3
        Me.Bullet3.TabStop = False
        '
        'Enemy1
        '
        Me.Enemy1.Location = New System.Drawing.Point(539, 170)
        Me.Enemy1.Name = "Enemy1"
        Me.Enemy1.Size = New System.Drawing.Size(100, 120)
        Me.Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Enemy1.TabIndex = 4
        Me.Enemy1.TabStop = False
        '
        'Enemy2
        '
        Me.Enemy2.Location = New System.Drawing.Point(539, 27)
        Me.Enemy2.Name = "Enemy2"
        Me.Enemy2.Size = New System.Drawing.Size(100, 120)
        Me.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Enemy2.TabIndex = 5
        Me.Enemy2.TabStop = False
        '
        'Bullet2
        '
        Me.Bullet2.Location = New System.Drawing.Point(645, 781)
        Me.Bullet2.Name = "Bullet2"
        Me.Bullet2.Size = New System.Drawing.Size(60, 60)
        Me.Bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bullet2.TabIndex = 6
        Me.Bullet2.TabStop = False
        '
        'Player
        '
        Me.Player.Location = New System.Drawing.Point(315, 666)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(136, 175)
        Me.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Player.TabIndex = 7
        Me.Player.TabStop = False
        '
        'PLayer_Move
        '
        '
        'Enemy_Move
        '
        '
        'Enemy_Reborn
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("楷体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 801)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "时间："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("楷体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 801)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "100"
        '
        'Open_Fire
        '
        '
        'Bullet_Move
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("楷体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 829)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "得分："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("楷体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(74, 829)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "0"
        '
        'HP
        '
        Me.HP.BackColor = System.Drawing.Color.White
        Me.HP.ForeColor = System.Drawing.Color.DimGray
        Me.HP.Location = New System.Drawing.Point(53, 775)
        Me.HP.Name = "HP"
        Me.HP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HP.Size = New System.Drawing.Size(130, 18)
        Me.HP.TabIndex = 12
        Me.HP.Value = 100
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("楷体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 773)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "HP"
        '
        'Boss
        '
        Me.Boss.BackColor = System.Drawing.SystemColors.Control
        Me.Boss.Location = New System.Drawing.Point(279, 12)
        Me.Boss.Name = "Boss"
        Me.Boss.Size = New System.Drawing.Size(200, 250)
        Me.Boss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Boss.TabIndex = 14
        Me.Boss.TabStop = False
        '
        'BossHP
        '
        Me.BossHP.Location = New System.Drawing.Point(300, 12)
        Me.BossHP.Maximum = 500
        Me.BossHP.Name = "BossHP"
        Me.BossHP.Size = New System.Drawing.Size(161, 23)
        Me.BossHP.TabIndex = 15
        Me.BossHP.Value = 500
        '
        'Boss_Move
        '
        '
        'Boss_Laser1
        '
        Me.Boss_Laser1.BackColor = System.Drawing.Color.Yellow
        Me.Boss_Laser1.Location = New System.Drawing.Point(300, 188)
        Me.Boss_Laser1.Name = "Boss_Laser1"
        Me.Boss_Laser1.Size = New System.Drawing.Size(40, 800)
        Me.Boss_Laser1.TabIndex = 16
        Me.Boss_Laser1.TabStop = False
        '
        'Boss_Laser2
        '
        Me.Boss_Laser2.BackColor = System.Drawing.Color.Yellow
        Me.Boss_Laser2.Location = New System.Drawing.Point(421, 188)
        Me.Boss_Laser2.Name = "Boss_Laser2"
        Me.Boss_Laser2.Size = New System.Drawing.Size(40, 800)
        Me.Boss_Laser2.TabIndex = 17
        Me.Boss_Laser2.TabStop = False
        '
        'Raser
        '
        '
        'Bullet4
        '
        Me.Bullet4.Location = New System.Drawing.Point(513, 715)
        Me.Bullet4.Name = "Bullet4"
        Me.Bullet4.Size = New System.Drawing.Size(60, 60)
        Me.Bullet4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bullet4.TabIndex = 18
        Me.Bullet4.TabStop = False
        '
        'Bullet5
        '
        Me.Bullet5.Location = New System.Drawing.Point(579, 715)
        Me.Bullet5.Name = "Bullet5"
        Me.Bullet5.Size = New System.Drawing.Size(60, 60)
        Me.Bullet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bullet5.TabIndex = 19
        Me.Bullet5.TabStop = False
        '
        'Bullet6
        '
        Me.Bullet6.Location = New System.Drawing.Point(645, 715)
        Me.Bullet6.Name = "Bullet6"
        Me.Bullet6.Size = New System.Drawing.Size(60, 60)
        Me.Bullet6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bullet6.TabIndex = 20
        Me.Bullet6.TabStop = False
        '
        'Bullet7
        '
        Me.Bullet7.Location = New System.Drawing.Point(710, 715)
        Me.Bullet7.Name = "Bullet7"
        Me.Bullet7.Size = New System.Drawing.Size(60, 60)
        Me.Bullet7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bullet7.TabIndex = 21
        Me.Bullet7.TabStop = False
        '
        'Bullet11
        '
        Me.Bullet11.Location = New System.Drawing.Point(710, 649)
        Me.Bullet11.Name = "Bullet11"
        Me.Bullet11.Size = New System.Drawing.Size(60, 60)
        Me.Bullet11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bullet11.TabIndex = 25
        Me.Bullet11.TabStop = False
        '
        'Bullet10
        '
        Me.Bullet10.Location = New System.Drawing.Point(645, 649)
        Me.Bullet10.Name = "Bullet10"
        Me.Bullet10.Size = New System.Drawing.Size(60, 60)
        Me.Bullet10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bullet10.TabIndex = 24
        Me.Bullet10.TabStop = False
        '
        'Bullet9
        '
        Me.Bullet9.Location = New System.Drawing.Point(579, 649)
        Me.Bullet9.Name = "Bullet9"
        Me.Bullet9.Size = New System.Drawing.Size(60, 60)
        Me.Bullet9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bullet9.TabIndex = 23
        Me.Bullet9.TabStop = False
        '
        'Bullet8
        '
        Me.Bullet8.Location = New System.Drawing.Point(513, 649)
        Me.Bullet8.Name = "Bullet8"
        Me.Bullet8.Size = New System.Drawing.Size(60, 60)
        Me.Bullet8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bullet8.TabIndex = 22
        Me.Bullet8.TabStop = False
        '
        'Bullet15
        '
        Me.Bullet15.Location = New System.Drawing.Point(710, 583)
        Me.Bullet15.Name = "Bullet15"
        Me.Bullet15.Size = New System.Drawing.Size(60, 60)
        Me.Bullet15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bullet15.TabIndex = 29
        Me.Bullet15.TabStop = False
        '
        'Bullet14
        '
        Me.Bullet14.Location = New System.Drawing.Point(645, 583)
        Me.Bullet14.Name = "Bullet14"
        Me.Bullet14.Size = New System.Drawing.Size(60, 60)
        Me.Bullet14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bullet14.TabIndex = 28
        Me.Bullet14.TabStop = False
        '
        'Bullet13
        '
        Me.Bullet13.Location = New System.Drawing.Point(579, 583)
        Me.Bullet13.Name = "Bullet13"
        Me.Bullet13.Size = New System.Drawing.Size(60, 60)
        Me.Bullet13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bullet13.TabIndex = 27
        Me.Bullet13.TabStop = False
        '
        'Bullet12
        '
        Me.Bullet12.Location = New System.Drawing.Point(513, 583)
        Me.Bullet12.Name = "Bullet12"
        Me.Bullet12.Size = New System.Drawing.Size(60, 60)
        Me.Bullet12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bullet12.TabIndex = 26
        Me.Bullet12.TabStop = False
        '
        'Ebul0
        '
        Me.Ebul0.Location = New System.Drawing.Point(677, 183)
        Me.Ebul0.Name = "Ebul0"
        Me.Ebul0.Size = New System.Drawing.Size(27, 33)
        Me.Ebul0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Ebul0.TabIndex = 30
        Me.Ebul0.TabStop = False
        '
        'Ebul1
        '
        Me.Ebul1.Location = New System.Drawing.Point(720, 183)
        Me.Ebul1.Name = "Ebul1"
        Me.Ebul1.Size = New System.Drawing.Size(27, 33)
        Me.Ebul1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Ebul1.TabIndex = 31
        Me.Ebul1.TabStop = False
        '
        'Ebul2
        '
        Me.Ebul2.Location = New System.Drawing.Point(678, 222)
        Me.Ebul2.Name = "Ebul2"
        Me.Ebul2.Size = New System.Drawing.Size(27, 33)
        Me.Ebul2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Ebul2.TabIndex = 32
        Me.Ebul2.TabStop = False
        '
        'Ebul3
        '
        Me.Ebul3.Location = New System.Drawing.Point(720, 222)
        Me.Ebul3.Name = "Ebul3"
        Me.Ebul3.Size = New System.Drawing.Size(27, 33)
        Me.Ebul3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Ebul3.TabIndex = 33
        Me.Ebul3.TabStop = False
        '
        'HPN
        '
        Me.HPN.AutoSize = True
        Me.HPN.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.HPN.ForeColor = System.Drawing.Color.Black
        Me.HPN.Location = New System.Drawing.Point(99, 776)
        Me.HPN.Name = "HPN"
        Me.HPN.Size = New System.Drawing.Size(31, 15)
        Me.HPN.TabIndex = 34
        Me.HPN.Text = "100"
        '
        'Bao
        '
        Me.Bao.Location = New System.Drawing.Point(69, 365)
        Me.Bao.Name = "Bao"
        Me.Bao.Size = New System.Drawing.Size(60, 63)
        Me.Bao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bao.TabIndex = 35
        Me.Bao.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 853)
        Me.Controls.Add(Me.Bao)
        Me.Controls.Add(Me.HPN)
        Me.Controls.Add(Me.Ebul3)
        Me.Controls.Add(Me.Ebul2)
        Me.Controls.Add(Me.Ebul1)
        Me.Controls.Add(Me.Ebul0)
        Me.Controls.Add(Me.Bullet15)
        Me.Controls.Add(Me.Bullet14)
        Me.Controls.Add(Me.Bullet13)
        Me.Controls.Add(Me.Bullet12)
        Me.Controls.Add(Me.Bullet11)
        Me.Controls.Add(Me.Bullet10)
        Me.Controls.Add(Me.Bullet9)
        Me.Controls.Add(Me.Bullet8)
        Me.Controls.Add(Me.Bullet7)
        Me.Controls.Add(Me.Bullet6)
        Me.Controls.Add(Me.Bullet5)
        Me.Controls.Add(Me.Bullet4)
        Me.Controls.Add(Me.Boss_Laser2)
        Me.Controls.Add(Me.Boss_Laser1)
        Me.Controls.Add(Me.BossHP)
        Me.Controls.Add(Me.Boss)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.HP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.Bullet2)
        Me.Controls.Add(Me.Enemy2)
        Me.Controls.Add(Me.Enemy1)
        Me.Controls.Add(Me.Bullet3)
        Me.Controls.Add(Me.Bullet1)
        Me.Controls.Add(Me.Bullet0)
        Me.Controls.Add(Me.Enemy0)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "战机传说"
        CType(Me.Enemy0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Boss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Boss_Laser1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Boss_Laser2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ebul0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ebul1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ebul2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ebul3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bullet0 As PictureBox
    Friend WithEvents Bullet1 As PictureBox
    Friend WithEvents Bullet3 As PictureBox
    Friend WithEvents Enemy1 As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Bullet2 As PictureBox
    Friend WithEvents Player As PictureBox
    Friend WithEvents PLayer_Move As Timer
    Friend WithEvents Enemy0 As PictureBox
    Friend WithEvents Enemy_Move As Timer
    Friend WithEvents Enemy_Reborn As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Open_Fire As Timer
    Friend WithEvents Bullet_Move As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents HP As ProgressBar
    Friend WithEvents Label5 As Label
    Friend WithEvents Boss As PictureBox
    Friend WithEvents BossHP As ProgressBar
    Friend WithEvents Boss_Move As Timer
    Friend WithEvents Boss_Laser1 As PictureBox
    Friend WithEvents Boss_Laser2 As PictureBox
    Friend WithEvents Raser As Timer
    Friend WithEvents Bullet4 As PictureBox
    Friend WithEvents Bullet5 As PictureBox
    Friend WithEvents Bullet6 As PictureBox
    Friend WithEvents Bullet7 As PictureBox
    Friend WithEvents Bullet11 As PictureBox
    Friend WithEvents Bullet10 As PictureBox
    Friend WithEvents Bullet9 As PictureBox
    Friend WithEvents Bullet8 As PictureBox
    Friend WithEvents Bullet15 As PictureBox
    Friend WithEvents Bullet14 As PictureBox
    Friend WithEvents Bullet13 As PictureBox
    Friend WithEvents Bullet12 As PictureBox
    Friend WithEvents Ebul0 As PictureBox
    Friend WithEvents Ebul1 As PictureBox
    Friend WithEvents Ebul2 As PictureBox
    Friend WithEvents Ebul3 As PictureBox
    Friend WithEvents HPN As Label
    Friend WithEvents Bao As PictureBox
End Class
