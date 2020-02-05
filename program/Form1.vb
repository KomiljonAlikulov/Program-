Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        a = Val(TextBox1.Text)
        ListBox1.Items.Clear()
        For i = 1 To 10
            ListBox1.Items.Add(i & " x " & a & " = " & a * i)
        Next
        MsgBox("ok")
    End Sub
End Class
