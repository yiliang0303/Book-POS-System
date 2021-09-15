Public Class FrmLoading
    Public selectedID As String
    Private Sub FrmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor
        If Timer1.Enabled = True Then
            Timer1.Start()
        Else
            Timer1.Start()

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Timer1.Interval = 300
        lblConnect.ForeColor = Color.Black
        If lblConnect.Text = 0 Then
            lblConnect.ForeColor = Color.Red

            FrmMemberHomepage.Show()
            Me.Hide()

        Else
            lblConnect.Text = Val(lblConnect.Text) - 1

        End If
    End Sub

    Private Sub lblConnect_Click(sender As Object, e As EventArgs) Handles lblConnect.Click

    End Sub
End Class