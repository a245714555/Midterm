Module Module1

    Sub Main()
        Dim i, j, ans As Integer
        Dim outstring As String
        For i = 1 To 9
            For j = 1 To 9
                ans = i * j
                Console.Write(Format(ans, "0#") & " ")
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub

End Module
