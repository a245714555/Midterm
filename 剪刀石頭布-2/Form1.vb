Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getAnswer(1)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        getAnswer(2)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        getAnswer(3)

    End Sub

    Private Sub getAnswer(UserCmd As Integer)
      
        Dim r As Integer
        Dim ans As String
        r = Rnd() * 3 + 1

        Select Case r

        End Select

            Select UserCmd
            Case 1
                Label3.Text = "剪刀"
                Select Case UserCmd
                    Case 1
                        MsgBox("peer")
                        ans = "Peer"
                    Case 2
                        MsgBox("lose")
                        ans = "Lose"
                    Case 3
                        MsgBox("win")
                        ans = "Win"
                End Select
        End Select

        Select Case UserCmd
            Case 2
                Label3.Text = "石頭"
                Select Case UserCmd
                    Case 1
                        MsgBox("lose")
                        ans = "Lose"
                    Case 2
                        MsgBox("peer")
                        ans = "Peer"
                    Case 3
                        MsgBox("win")
                        ans = "Win"
                End Select
        End Select

        Select Case UserCmd
            Case 3
                Label3.Text = "布"
                Select Case UserCmd
                    Case 1
                        MsgBox("win")
                        ans = "Win"
                    Case 2
                        MsgBox("lose")
                        ans = "lose"
                    Case 3
                        MsgBox("peer")
                        ans = "Peer"
                End Select

        End Select

    End Sub
End Class


