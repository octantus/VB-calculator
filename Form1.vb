﻿Public Class Form1
    Private Sub exit_button_Click(sender As Object, e As EventArgs) Handles exit_button.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "0" Then TextBox1.Clear()
        TextBox1.Text += "1"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text += "2"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text += "3"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text += "4"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text += "5"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text += "6"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text += "7"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text += "8"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text += "9"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Text += "0"
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox1.Text += ","
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "/"
        TextBox1.Text = ""
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "*"
        TextBox1.Text = ""
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "-"
        TextBox1.Text = ""
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "+"
        TextBox1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Label2.Text = "/" Then
            TextBox1.Text = Val(Label1.Text) / Val(TextBox1.Text)
            Label1.Text = ""
            Label2.Text = "="
        End If
        If Label2.Text = "*" Then
            TextBox1.Text = Val(Label1.Text) * Val(TextBox1.Text)
            Label1.Text = ""
            Label2.Text = "="
        End If
        If Label2.Text = "-" Then
            TextBox1.Text = Val(Label1.Text) - Val(TextBox1.Text)
            Label1.Text = ""
            Label2.Text = "="
        End If
        If Label2.Text = "+" Then
            TextBox1.Text = Val(Label1.Text) + Val(TextBox1.Text)
            Label1.Text = ""
            Label2.Text = "="
        End If
    End Sub
End Class
