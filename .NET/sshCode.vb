//Starter Classen Form1
Public Class Form1
    //Adder Arrys!
    Dim connInfo As New Renci.SshNet.PasswordConnectionInfo("192.168.1.200", "root", "root")
    Dim sshClient As New Renci.SshNet.SshClient(connInfo)
    Dim cmd As Renci.SshNet.SshCommand
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor

        Using sshClient

            sshClient.Connect()

            cmd = sshClient.RunCommand("python2 test.py " + TextBox1.Text)
            sshClient.Disconnect()
            Me.Cursor = Cursors.Default
        End Using

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Cursor = Cursors.WaitCursor

        Using sshClient

            sshClient.Connect()

            cmd = sshClient.RunCommand("python2 test.py blink")
            sshClient.Disconnect()
            Me.Cursor = Cursors.Default
        End Using
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Cursor = Cursors.WaitCursor

        Using sshClient

            sshClient.Connect()

            cmd = sshClient.RunCommand("python2 test.py off")
            sshClient.Disconnect()
            Me.Cursor = Cursors.Default
        End Using
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Cursor = Cursors.WaitCursor

        Using sshClient

            sshClient.Connect()

            cmd = sshClient.RunCommand("python2 test.py on")
            sshClient.Disconnect()
            Me.Cursor = Cursors.Default
        End Using
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Me.Cursor = Cursors.WaitCursor

        Using sshClient

            sshClient.Connect()

            cmd = sshClient.RunCommand("python2 test.py troll")
            sshClient.Disconnect()
            Me.Cursor = Cursors.Default
        End Using
    End Sub
End Class
