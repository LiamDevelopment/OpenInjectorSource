Public Class About
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Try
            Process.Start("https://www.mpgh.net/forum/member.php?u=545374")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        LogDebug("Update log loaded")
        UpdateLogDialog.ShowDialog()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Process.Start("https://github.com/LiamDevelopment/OpenInjectorSource")
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = "Project started by Liam (2018-" & Date.Today.Year & ")"
    End Sub
End Class