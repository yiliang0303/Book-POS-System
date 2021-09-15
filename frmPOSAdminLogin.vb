Imports MessagingToolkit.QRCode.Codec
Public Class frmPOSAdminLogin
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim db As New DBDataContext()
        Dim a As Staff = db.Staffs.FirstOrDefault(Function(o) o.sPosition = "Admin")

        If txtUser.Text = a.sUsername And CheckPassword.Hash.VerifyHash(txtPassword.Text, a.sPassword) Then
            frmOrder.blnAdmin = True
            frmFloat.blnAdmin = True
            Me.Close()
        Else
            MessageBox.Show("Wrong ID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim ans As Long = MessageBox.Show("Confirm to Close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmPOSAdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor


        Me.btnConfirm.BackColor = My.Settings.buttonColor
        Me.btnConfirm.ForeColor = My.Settings.buttonForeColor

        Me.btnCancel.BackColor = My.Settings.buttonColor
        Me.btnCancel.ForeColor = My.Settings.buttonForeColor

        Me.btnQRCode.BackColor = My.Settings.buttonColor
        Me.btnQRCode.ForeColor = My.Settings.buttonForeColor

        Dim db As New DBDataContext()
        Dim a As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = frmOrder.strStaffID)

        If a.sPosition = "Admin" Then
            frmOrder.blnAdmin = True
            frmFloat.blnAdmin = True
            Me.Close()
        Else
            txtUser.Clear()
            txtPassword.Clear()
            frmOrder.blnAdmin = False
            frmFloat.blnAdmin = False
        End If
    End Sub

    Private Sub txtUser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnConfirm.PerformClick()
        End If
    End Sub

    Dim reader As New QRCodeDecoder
    Private Sub btnQRCode_Click(sender As Object, e As EventArgs) Handles btnQRCode.Click
        Dim pic As New PictureBox
        Me.Controls.Add(pic)
        pic.Visible = False
        Try
            Dim od As New OpenFileDialog
            od.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\code")
            If od.ShowDialog() = DialogResult.OK Then
                pic.Load(od.FileName)
                reader = New QRCodeDecoder
                Dim QRstaff As String = reader.decode(New Data.QRCodeBitmapImage(pic.Image))
                Dim db As New DBDataContext

                Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = QRstaff And o.sPosition = "Admin")
                If s IsNot Nothing Then
                    frmOrder.blnAdmin = True
                    frmFloat.blnAdmin = True
                    Me.Close()
                Else
                    MessageBox.Show("Invalid QR code")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class