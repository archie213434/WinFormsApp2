Public Class Form14
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        r = Val(TextBox1.Text)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        v = 4 / 3 * pi * r ^ 3
        TextBox2.Text = Str(v)
    End Sub
    Private r As Integer
    Private v As Double
    Const pi = 3.1416
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class