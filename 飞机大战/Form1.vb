'开始界面
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Visible = True
        Button3.Visible = True
        Button1.Visible = False
        Button2.Visible = False
        Button4.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Visible = True
        Label2.Visible = False
        Button3.Visible = False
        Button1.Visible = True
        Button2.Visible = True
        Button4.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

End Class
