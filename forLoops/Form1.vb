Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intNumber As Integer

        For intNumber = 1 To 10
            'initial = 1
            'end = 10
            'growth = 1
            MessageBox.Show(intNumber)
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim intNumber As Integer

        For intNumber = 2 To 12 Step 2
            'initial = 2
            'end = 12
            'growth = 2
            MessageBox.Show(intNumber)
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim intNumber As Integer

        For intNumber = 10 To 1 Step -1
            'initial = 10
            'end = 1
            'growth = -1
            MessageBox.Show(intNumber)
        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim intNumber As Integer
        Dim intTotal As Integer = 0
        Dim intUserNum As Integer
        Dim intEntries As Integer
        Dim sngAverage As Single

        intEntries = InputBox("How Many Numbers To Enter")

        For intNumber = 1 To intEntries
            intUserNum = InputBox("Enter Number " & intNumber)
            intTotal = intTotal + intUserNum
        Next
        MessageBox.Show("Total= " & intTotal)
        sngAverage = intTotal / intEntries
        MessageBox.Show("Average= " & sngAverage)

    End Sub
End Class
