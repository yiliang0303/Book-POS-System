Public Class FrmMemberLogout
    Private Sub FrmMemberLogout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor
        Timer1.Enabled = True
        lblConnect.ForeColor = Color.Black
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static count As Byte = 0

        If count = 3 Then

            Timer1.Enabled = False

            Me.Close()
            FrmMemberLogin.Show()
        Else
            count += 1
        End If

    End Sub
End Class