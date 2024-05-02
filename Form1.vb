Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hours As Double
        Dim rate As Double
        Dim gross As Double
        Dim deduct As Double
        Dim nett As Double

        hours = TextBox1.Text
        rate = TextBox2.Text

        gross = hours * rate

        TextBox3.Text = gross

        deduct = gross * 0.2

        TextBox4.Text = deduct

        nett = gross - deduct

        TextBox5.Text = nett
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
