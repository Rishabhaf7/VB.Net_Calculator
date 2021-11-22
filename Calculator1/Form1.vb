Public Class Form1


    Private maths As Maths
    Dim value1, value2, value3 As Integer
    Dim sign As String

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & 0

    End Sub


    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = TextBox1.Text & 3

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & 1

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & 2

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & 4

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & 5

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text & 6

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & 7

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & 8

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & 9
        TextBox2.Text = TextBox2.Text & 9
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        value1 = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        sign = "-"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        value1 = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        sign = "*"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        value1 = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        sign = "/"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        value1 = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        sign = "+"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        value2 = TextBox2.Text
        If sign = "+" Then
            TextBox3.Text = value1 + value2
        ElseIf sign = "-" Then
            TextBox3.Text = value1 - value2
        ElseIf sign = "*" Then
            TextBox3.Text = value1 * value2
        ElseIf sign = "/" Then
            TextBox3.Text = value1 / value2
        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.ComboBox1.Items
            .Add(Maths.add)
            .Add(Maths.subtract)
            .Add(Maths.multiple)
            .Add(Maths.divided)

        End With
    End Sub

End Class
