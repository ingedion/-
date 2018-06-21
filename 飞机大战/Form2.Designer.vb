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
        Me.HP.Location = New System.Drawing.Point(71, 775)
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
        Me.Label5.Location = New System.Drawing.Point(16, 773)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "HP："
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
        Me.Boss_Laser1.Size = New System.Drawing.Size(40, 633)
        Me.Boss_Laser1.TabIndex = 16
        Me.Boss_Laser1.TabStop = False
        '
        'Boss_Laser2
        '
        Me.Boss_Laser2.BackColor = System.Drawing.Color.Yellow
        Me.Boss_Laser2.Location = New System.Drawing.Point(421, 188)
        Me.Boss_Laser2.Name = "Boss_Laser2"
        Me.Boss_Laser2.Size = New System.Drawing.Size(40, 633)
        Me.Boss_Laser2.TabIndex = 17
        Me.Boss_Laser2.TabStop = False
        '
        'Raser
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 853)
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
End Class
