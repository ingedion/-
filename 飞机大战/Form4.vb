﻿Public Class Form4
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Go()
        Form2.InitPlayer(Form2.HP.Value, Form2.HP.Maximum, Form2.Open_Fire.Interval)
        Form2.InitBoss()
        Form2.InitEnemy("\draw\f2.jpg")
        Form2.InitBullet("\draw\z1.jpg")
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form2.Go()
        Form2.InitPlayer(200, 200, Form2.Open_Fire.Interval)
        Form2.InitBoss()
        Form2.InitEnemy("\draw\f2.jpg")
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form2.Go()
        Form2.InitBoss()
        Form2.InitEnemy("\draw\f2.jpg")
        If Form2.Open_Fire.Interval > 100 Then
            Form2.InitPlayer(Form2.HP.Value, Form2.HP.Maximum, Form2.Open_Fire.Interval - 100)
        End If
        Me.Close()
    End Sub
End Class