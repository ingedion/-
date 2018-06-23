Public Class Form3
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        '强化1
        Form2.Pause_or_go()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        '强化2
        Form2.Pause_or_go()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        '强化3
        Form2.Pause_or_go()
        Me.Close()
    End Sub
End Class