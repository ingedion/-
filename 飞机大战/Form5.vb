Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form2.HP.Value <> 0 Then
            Label1.Text = "你胜利了"
        Else
            Label1.Text = "挑战失败"
        End If
        Label3.Text = Form2.Score
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Close()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Init()
        Me.Close()
    End Sub
End Class