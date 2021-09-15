Imports System.Net
Imports System.Net.Mail
Imports System.Data.SqlClient
Imports MessagingToolkit.QRCode.Codec

Public Class frmLogin

    Dim reader As New QRCodeDecoder

    Private Sub btnCashierLogin_Click(sender As Object, e As EventArgs) Handles btnCashierLogin.Click
        Dim username As String = ""
        Dim password As String = ""
        Dim db As New DBDataContext
        Try
            username = txtUsername.Text
            password = txtPassword.Text

            If txtPassword.Text = "" Or txtUsername.Text = "" Then
                MessageBox.Show("Please enter Username and Password")
                txtPassword.Clear()
                txtUsername.Clear()
                txtUsername.Focus()
            Else
                Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.sUsername = username)
                If s Is Nothing Then
                    MessageBox.Show("Username or Password are invalid")
                    txtPassword.Clear()
                    txtUsername.Clear()
                    txtUsername.Focus()
                Else
                    If CheckPassword.Hash.VerifyHash(password, s.sPassword) = True Then
                        MessageBox.Show("Start business")
                        Me.Hide()
                        frmOrder.strStaffID = s.staffID
                        frmOrder.strStaffName = s.sName
                        frmOrder.Show()
                    Else
                        MessageBox.Show("Invalid password")
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        Dim username As String = ""
        Dim password As String = ""
        Dim db As New DBDataContext
        Try
            username = txtUsername.Text
            password = txtPassword.Text

            If txtPassword.Text = "" Or txtUsername.Text = "" Then
                MessageBox.Show("Please enter Username and Password")
                txtPassword.Clear()
                txtUsername.Clear()
                txtUsername.Focus()
            Else
                Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.sUsername = username And o.sPosition = "Admin")
                If s Is Nothing Then
                    MessageBox.Show("Username or Password are invalid")
                    txtPassword.Clear()
                    txtUsername.Clear()
                    txtUsername.Focus()
                Else
                    If CheckPassword.Hash.VerifyHash(password, s.sPassword) = True Then
                        MessageBox.Show("Welcome back, " & s.sName)
                        selectAdminId = s.staffID
                        frmHomepage.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid password")
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub lblForgotPass_MouseHover(sender As Object, e As EventArgs) Handles lblForgotPass.MouseHover
        lblForgotPass.Font = New Font("Arial", 12, FontStyle.Underline)
    End Sub

    Private Sub lblForgotPass_MouseLeave(sender As Object, e As EventArgs) Handles lblForgotPass.MouseLeave
        lblForgotPass.Font = New Font("Arial", 12)
    End Sub

    Private Sub lblForgotPass_Click(sender As Object, e As EventArgs) Handles lblForgotPass.Click
        frmPasswordRecovery.ShowDialog()

    End Sub

    Private Sub picVisible_Click(sender As Object, e As EventArgs) Handles picVisible.Click
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
            picVisible.Image = My.Resources.visible
        Else
            txtPassword.UseSystemPasswordChar = True
            picVisible.Image = My.Resources.invisible
        End If
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs)
        frmHomepage.Show()
        Me.Hide()
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            If Not Char.IsLetterOrDigit(e.KeyChar) OrElse
              Not "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789".Contains(e.KeyChar.ToString) Then
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        Me.btnAdminLogin.BackColor = My.Settings.buttonColor
        Me.btnCashierLogin.BackColor = My.Settings.buttonColor
        Me.btnBack.BackColor = My.Settings.buttonColor
        Me.btnSelfPOS.BackColor = My.Settings.buttonColor

        Me.btnAdminLogin.Font = My.Settings.buttonFont
        Me.btnCashierLogin.Font = My.Settings.buttonFont
        Me.btnSelfPOS.Font = My.Settings.buttonFont
        Me.btnBack.Font = My.Settings.buttonFont

        Me.btnAdminLogin.ForeColor = My.Settings.buttonForeColor
        Me.btnCashierLogin.ForeColor = My.Settings.buttonForeColor
        Me.btnBack.ForeColor = My.Settings.buttonForeColor
        Me.btnSelfPOS.ForeColor = My.Settings.buttonForeColor




        Dim db As New DBDataContext
        Dim s1 As Staff = db.Staffs.FirstOrDefault(Function(o) o.sPosition = "Admin")
        Try
            If s1 Is Nothing Then
                frmRegister.Show()
                Me.Hide()
            Else
                Me.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub picAdmin_Click(sender As Object, e As EventArgs) Handles picAdmin.Click
        Dim pic4 As New PictureBox
        Me.Controls.Add(pic4)
        pic4.Visible = False
        Try

            Dim od As New OpenFileDialog
            od.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\code")
            If od.ShowDialog() = DialogResult.OK Then
                pic4.Load(od.FileName)
                reader = New QRCodeDecoder
                Dim QRstaff As String = reader.decode(New Data.QRCodeBitmapImage(pic4.Image))
                Dim db As New DBDataContext

                Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = QRstaff And o.sPosition = "Admin")
                If s IsNot Nothing Then
                    MessageBox.Show("Welcome back, " & s.sName)
                    selectAdminId = s.staffID
                    frmHomepage.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid QR code")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub picStaff_Click(sender As Object, e As EventArgs) Handles picStaff.Click
        Dim pic4 As New PictureBox
        Me.Controls.Add(pic4)
        pic4.Visible = False
        Try

            Dim od As New OpenFileDialog
            od.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\code")
            If od.ShowDialog() = DialogResult.OK Then
                pic4.Load(od.FileName)
                reader = New QRCodeDecoder
                Dim QRstaff As String = reader.decode(New Data.QRCodeBitmapImage(pic4.Image))
                Dim db As New DBDataContext

                Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = QRstaff)
                If s IsNot Nothing Then
                    MessageBox.Show("Welcome back, " & s.sName)
                    Me.Hide()
                    frmOrder.strStaffID = s.staffID
                    frmOrder.strStaffName = s.sName
                    frmOrder.Show()
                Else
                    MessageBox.Show("Invalid QR code")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSelfPOS_Click(sender As Object, e As EventArgs) Handles btnSelfPOS.Click
        frmOrder.strStaffID = "SELF-POS"
        frmOrder.strStaffName = "Self POS System"
        Me.Hide()
        frmOrder.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmHomepage.Show()

    End Sub
End Class
