'开始界面
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.ShowDialog()
        Me.Close()
    End Sub
End Class
