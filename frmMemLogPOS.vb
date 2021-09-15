Imports MessagingToolkit.QRCode.Codec
Public Class frmMemLogPOS
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim db As New DBDataContext()
        Dim m As Member = db.Members.FirstOrDefault(Function(o) o.mUsername = txtUser.Text)

        If m IsNot Nothing Then
            If CheckPassword.Hash.VerifyHash(txtPassword.Text, m.mPassword) Then
                frmOrder.strMemberID = m.memberID
                MessageBox.Show("Member ID: " & m.memberID & vbNewLine & "Member Level: " & m.mLevel & vbNewLine & "Member Rate: " & m.mRate & vbNewLine & "Point: " & m.mPoint, "Member Detail", MessageBoxButtons.OK)
                Me.Close()
            Else
                MessageBox.Show("Wrong ID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Wrong ID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUser.Focus()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim ans As Long = MessageBox.Show("Confirm to Close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        Me.Close()
        FrmMemberRegister.ShowDialog()
    End Sub

    Private Sub frmMemLogPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        Me.btnConfirm.BackColor = My.Settings.buttonColor
        Me.btnConfirm.Font = My.Settings.buttonFont
        Me.btnConfirm.ForeColor = My.Settings.buttonForeColor

        Me.btnCancel.BackColor = My.Settings.buttonColor
        Me.btnCancel.Font = My.Settings.buttonFont
        Me.btnCancel.ForeColor = My.Settings.buttonForeColor


        Me.btnQRCode.BackColor = My.Settings.buttonColor
        Me.btnQRCode.Font = My.Settings.buttonFont
        Me.btnQRCode.ForeColor = My.Settings.buttonForeColor

        Me.btnReg.BackColor = My.Settings.buttonColor
        Me.btnReg.Font = My.Settings.buttonFont
        Me.btnReg.ForeColor = My.Settings.buttonForeColor


        txtUser.Clear()
        txtPassword.Clear()
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
            od.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\MemberQRcode")
            If od.ShowDialog() = DialogResult.OK Then
                pic.Load(od.FileName)
                reader = New QRCodeDecoder
                Dim QRMember As String = reader.decode(New Data.QRCodeBitmapImage(pic.Image))
                Dim db As New DBDataContext

                Dim m As Member = db.Members.FirstOrDefault(Function(o) o.memberID = QRMember)
                If m IsNot Nothing Then
                    frmOrder.strMemberID = m.memberID
                    MessageBox.Show("Member ID: " & m.memberID & vbNewLine & "Member Level: " & m.mLevel & vbNewLine & "Member Rate: " & m.mRate & vbNewLine & "Point: " & m.mPoint, "Member Detail", MessageBoxButtons.OK)
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