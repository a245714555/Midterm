Public Class Form1


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim F, C As Single
        C = Val(TextBox1.Text)
        F = C * (1.8) + 32
        TextBox1.Text = F

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim F, C As Single
        F = Val(TextBox1.Text)
        C = (F - 32) / (1.8)
        TextBox1.Text = C
    End Sub
End Class
