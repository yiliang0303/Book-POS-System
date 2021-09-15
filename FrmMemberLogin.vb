Imports System.ComponentModel
Imports System.Data.SqlClient
Imports MessagingToolkit.QRCode.Codec
Public Class FrmMemberLogin
    Dim reader As New QRCodeDecoder
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If txtPassword.UseSystemPasswordChar = False Then
            txtPassword.UseSystemPasswordChar = True
            PictureBox2.Image = My.Resources.showHidePass
        Else
            txtPassword.UseSystemPasswordChar = False
            PictureBox2.Image = My.Resources.showPass
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim dbUser As String = ""
        Dim dbPass As String = ""

        Dim pass As String = ""
        Dim db As New DBDataContext
        Dim user As String = ""
        Dim intResult As Long = 0
        Try
            user = txtUser.Text
            pass = txtPassword.Text

            If txtUser.Text = "" And txtPassword.Text = "" Then
                MessageBox.Show("Please enter your USERNAME Or PASSWORD")
                txtUser.Clear()
                txtPassword.Clear()
            Else

                Dim m As Member = db.Members.FirstOrDefault(Function(o) o.mUsername = user)

                If m Is Nothing Then
                    MessageBox.Show("No such user or password")
                    txtUser.Clear()
                    txtPassword.Clear()
                Else

                    If CheckPassword.Hash.VerifyHash(pass, m.mPassword) = True Then
                        frmOrder.strMemberID = m.memberID

                        FrmMemberResetPassword.selectedID = m.memberID
                        FrmMemberHomepage.selectedID = m.memberID
                        FrmMemberEdit.selectedID = m.memberID
                        FrmBookDetails.selectedID = m.memberID
                        FrmCommentBook.mUsername = m.mUsername
                        FrmLoading.Label1.Text = "Welcome back, " & txtUser.Text & " !!!"
                        FrmLoading.selectedID = m.memberID
                        FrmLoading.ShowDialog()
                        Me.Close()


                    Else
                        MessageBox.Show("No such user in database!!!")
                    End If
                End If

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try


    End Sub



    Private Sub LinklblForgotPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinklblForgotPass.LinkClicked
        Me.Hide()
        FrmMemberForgotPassword.Show()
    End Sub

    Private Sub LinklblSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinklblSignUp.LinkClicked
        Me.Hide()
        FrmMemberRegister.ShowDialog()
    End Sub



    Private Sub btnQRcode_Click(sender As Object, e As EventArgs) Handles btnQRcode.Click

        Dim pic4 As New PictureBox
        Me.Controls.Add(pic4)
        pic4.Visible = False

        Try
            Dim od As New OpenFileDialog
            od.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resouces\MemberQRcode\")
            If od.ShowDialog() = DialogResult.OK Then
                pic4.Load(od.FileName)
                reader = New QRCodeDecoder
                Dim QRmem As String = reader.decode(New Data.QRCodeBitmapImage(pic4.Image))
                Dim db As New DBDataContext

                Dim m As Member = db.Members.FirstOrDefault(Function(o) o.memberID = QRmem)
                If m IsNot Nothing Then
                    FrmMemberResetPassword.selectedID = m.memberID
                    FrmMemberHomepage.selectedID = m.memberID
                    FrmMemberEdit.selectedID = m.memberID
                    FrmLoading.selectedID = m.memberID
                    FrmBookDetails.selectedID = m.memberID
                    FrmCommentBook.mUsername = m.mUsername
                    FrmLoading.Label1.Text = "Welcome Back," & m.mUsername & "!"
                    Me.Hide()
                    FrmLoading.ShowDialog()

                Else
                    MessageBox.Show("No such user or password")
                    txtUser.Clear()
                    txtPassword.Clear()




                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmMemberLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        Me.btnLogin.BackColor = My.Settings.buttonColor
        Me.btnLogin.Font = My.Settings.buttonFont
        Me.btnLogin.ForeColor = My.Settings.buttonForeColor

        Me.btnQRcode.BackColor = My.Settings.buttonColor
        Me.btnQRcode.Font = My.Settings.buttonFont
        Me.btnQRcode.ForeColor = My.Settings.buttonForeColor
    End Sub
End Class








