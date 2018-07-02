Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form2.HP.Value = 0 Then
            Label1.Text = "挑战失败"
            Button3.Visible = False
        ElseIf Form2.Layer < 3 Then
            Label1.Text = "击败首领"
            Button1.Visible = False
            Button3.Visible = True
        Else
            Label1.Text = "挑战成功"
            Button3.Visible = False
            Button1.Visible = True
        End If
        Form2.Layer += 1
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form4.ShowDialog()
        Me.Close()
    End Sub
End Class