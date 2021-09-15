Public Class frmSplashScreen

    Private Sub frmSplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)


        Copyright.Text = My.Application.Info.Copyright
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblNumber.Text = ProgressBar1.Value & " %"
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Increment(4)
            Threading.Thread.Sleep(100)
        ElseIf ProgressBar1.Value = 100 Then
            lblLoading.Text = "Completed"
            Timer1.Stop()

        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
