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
        CType(Me.Enemy0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Enemy0
        '
        Me.Enemy0.Location = New System.Drawing.Point(116, 63)
        Me.Enemy0.Name = "Enemy0"
        Me.Enemy0.Size = New System.Drawing.Size(100, 120)
        Me.Enemy0.TabIndex = 0
        Me.Enemy0.TabStop = False
        '
        'Bullet0
        '
        Me.Bullet0.Location = New System.Drawing.Point(513, 781)
        Me.Bullet0.Name = "Bullet0"
        Me.Bullet0.Size = New System.Drawing.Size(60, 60)
        Me.Bullet0.TabIndex = 1
        Me.Bullet0.TabStop = False
        '
        'Bullet1
        '
        Me.Bullet1.Location = New System.Drawing.Point(579, 781)
        Me.Bullet1.Name = "Bullet1"
        Me.Bullet1.Size = New System.Drawing.Size(60, 60)
        Me.Bullet1.TabIndex = 2
        Me.Bullet1.TabStop = False
        '
        'Bullet3
        '
        Me.Bullet3.Location = New System.Drawing.Point(711, 781)
        Me.Bullet3.Name = "Bullet3"
        Me.Bullet3.Size = New System.Drawing.Size(60, 60)
        Me.Bullet3.TabIndex = 3
        Me.Bullet3.TabStop = False
        '
        'Enemy1
        '
        Me.Enemy1.Location = New System.Drawing.Point(280, 63)
        Me.Enemy1.Name = "Enemy1"
        Me.Enemy1.Size = New System.Drawing.Size(100, 120)
        Me.Enemy1.TabIndex = 4
        Me.Enemy1.TabStop = False
        '
        'Enemy2
        '
        Me.Enemy2.Location = New System.Drawing.Point(441, 63)
        Me.Enemy2.Name = "Enemy2"
        Me.Enemy2.Size = New System.Drawing.Size(100, 120)
        Me.Enemy2.TabIndex = 5
        Me.Enemy2.TabStop = False
        '
        'Bullet2
        '
        Me.Bullet2.Location = New System.Drawing.Point(645, 781)
        Me.Bullet2.Name = "Bullet2"
        Me.Bullet2.Size = New System.Drawing.Size(60, 60)
        Me.Bullet2.TabIndex = 6
        Me.Bullet2.TabStop = False
        '
        'Player
        '
        Me.Player.Location = New System.Drawing.Point(315, 666)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(136, 175)
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
        Me.Label1.Location = New System.Drawing.Point(16, 741)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "时间："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("楷体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 741)
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
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 853)
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
        Me.Name = "Form2"
        Me.Text = "飞机大战"
        CType(Me.Enemy0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
