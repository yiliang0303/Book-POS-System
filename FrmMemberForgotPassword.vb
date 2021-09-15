Imports System.Net
Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class FrmMemberForgotPassword
    Dim getEmail As String = ""
    Dim orgPass As String = ""

    Private Sub FrmMemberForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 500
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.BackColor = My.Settings.backgroundColor

        Me.btnReset.BackColor = My.Settings.buttonColor
        Me.btnReset.Font = My.Settings.buttonFont
        Me.btnReset.ForeColor = My.Settings.buttonForeColor

        Me.btnSend.BackColor = My.Settings.buttonColor
        Me.btnSend.Font = My.Settings.buttonFont
        Me.btnSend.ForeColor = My.Settings.buttonForeColor

        Dim password1 As String = ""
        Dim password2 As String = ""
        Dim from, pass, messageBody As String
        Dim message As MailMessage = New MailMessage
        toUser = txtEmail.Text
        from = "mybook1433@gmail.com"
        pass = "mybookpos"
        messageBody = "This email confirms that your password has been changed." & vbNewLine
        messageBody &= "Please do not reply this email." & vbNewLine
        messageBody &= "For feedback or support, kindly reach out to us at http://mybook.com.my/support"
        message.To.Add(toUser)
        message.From = New MailAddress(from)
        message.Body = messageBody
        message.Subject = "Your Password Has Been Changed"
        Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
        smtp.EnableSsl = True
        smtp.Port = 587
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network
        smtp.Credentials = New NetworkCredential(from, pass)
        Dim db As New DBDataContext
        'Dim getEmail = txtEmail.Text



        Try
            password1 = txtPassword1.Text
            password2 = txtPassword2.Text


            Dim m As Member = db.Members.FirstOrDefault(Function(o) o.mEmail = getEmail)


            If CheckPassword.Hash.VerifyHash(password2, m.mPassword) = False Then

                MessageBox.Show("Reset password sucessfully !", "Confirm Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim str As String = CheckPassword.Hash.ComputeHash(txtPassword2.Text, Nothing)
                m.mPassword = str
                FrmMemberResetPassword.selectedID = m.memberID
                FrmMemberHomepage.selectedID = m.memberID
                FrmMemberEdit.selectedID = m.memberID

                db.SubmitChanges()
                smtp.Send(message)
                FrmMemberHomepage.Show()
                Me.Hide()

            Else

                MessageBox.Show("Cannot same with current password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword1.Clear()
                txtPassword2.Clear()

            End If



        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim from, pass, messageBody As String
        Dim rand As Random = New Random()
        randomCode = rand.Next(0, 1000000).ToString("d6")
        Dim message As MailMessage = New MailMessage
        toUser = txtEmail.Text
        from = "mybook1433@gmail.com"
        pass = "mybookpos"
        messageBody = "Your reset code is " & randomCode & vbNewLine
        messageBody &= "This is an auto-generated email, please do not reply this email." & vbNewLine
        messageBody &= "For feedback or support, kindly reach out to us at http://mybook.com.my/support"
        Try
            message.To.Add(toUser)
            message.From = New MailAddress(from)
            message.Body = messageBody
            message.Subject = "Password resetting code"
            Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
            smtp.EnableSsl = True
            smtp.Port = 587
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network
            smtp.Credentials = New NetworkCredential(from, pass)

            Dim db As New DBDataContext

            Try
                getEmail = txtEmail.Text
                Dim m As Member = db.Members.FirstOrDefault(Function(o) o.mEmail = getEmail)

                If m Is Nothing Then
                    lblEmailFalse.Text = "No such email in MyBook"
                    txtEmail.Focus()


                ElseIf getEmail = "" Then
                    lblEmailFalse.Text = "*Required"
                    txtEmail.Focus()
                Else
                    lblEmailFalse.Text = ""
                    smtp.Send(message)
                    MessageBox.Show("Code sent ! Please check your email.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    orgPass = m.mPassword
                    txtCode.Visible = True
                    Label3.Visible = True
                    txtCode.Clear()
                    txtCode.Focus()
                End If


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        Dim ans As Boolean = IsValidEmailFormat()
    End Sub
    Private Function IsValidEmailFormat() As Boolean
        Dim flag As Boolean = False
        Dim format As String = "^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$"
        lblEmailFalse.ForeColor = Color.Red
        If Regex.IsMatch(CStr(txtEmail.Text), format) Then
            lblEmailFalse.Text = ""
            flag = True
        ElseIf CStr(txtEmail.Text) = "" Then
            lblEmailFalse.Text = "*Required"
        Else
            lblEmailFalse.Text = "Wrong Format"
        End If
        Return flag
    End Function
    Private Sub picValidCode_Click(sender As Object, e As EventArgs) Handles picValidCode.Click

    End Sub

    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged
        Dim strCheck As String = ""
        strCheck = txtCode.Text
        If String.Compare(strCheck, randomCode) = 0 Then
            picValidCode.Image = My.Resources._true
            picValidCode.Visible = True
            lblStatus.Visible = True
            lblStatus.Text = "Correct"
            txtCode.Enabled = False
            GroupBox1.Visible = True
            Me.Height = 800
        Else
            picValidCode.Image = My.Resources._false
            picValidCode.Visible = True
            lblStatus.Visible = True
            lblStatus.Text = "Wrong"
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        If txtPassword1.UseSystemPasswordChar = False Then
            txtPassword1.UseSystemPasswordChar = True
            PictureBox2.Image = My.Resources.showHidePass
        Else
            txtPassword1.UseSystemPasswordChar = False
            PictureBox2.Image = My.Resources.showPass
        End If
    End Sub

    Private Sub txtPassword1_TextChanged(sender As Object, e As EventArgs) Handles txtPassword1.TextChanged
        Dim result As Boolean = IsValidPass1Format()
    End Sub

    Private Function IsValidPass1Format() As Boolean
        Dim flag As Boolean = False

        Dim pass As String = CStr(txtPassword1.Text)
        'Dim flag As Integer = -1
        lblPassFalse.ForeColor = Color.Red

        Dim upper As Integer = 0
        Dim lower As Integer = 0
        Dim num As Integer = 0
        Dim other As Integer
        Dim db As New DBDataContext



        If pass = "" Then
            lblPassFalse.Text = "*Required"
        ElseIf pass.Length < 8 Then
            lblPassFalse.Text = "At least 8 alphanumeric"


        Else

            For Each c In pass
                If Not Char.IsLetterOrDigit(c.ToString(), 0) Then

                    other += 1
                ElseIf Char.IsLetter(c.ToString(), 0) Then
                    If Char.IsUpper(c.ToString(), 0) Then
                        upper += 1
                    Else
                        lower += 1
                    End If
                ElseIf Char.IsDigit(c.ToString(), 0) Then
                    'Will count numbers
                    num += 1
                End If
            Next
            lblPassFalse.ForeColor = Color.Black
            If other >= 1 And lower >= 1 And num >= 1 And upper >= 1 Then

                lblPassFalse.Text = "Strong Password"

                flag = True
            Else
                lblPassFalse.ForeColor = Color.Red
                lblPassFalse.Text = "Weak Password (SPECIAL CHARACTER)"
                flag = False
            End If

        End If
        Return flag
    End Function

    Private Sub txtPassword2_TextChanged(sender As Object, e As EventArgs) Handles txtPassword2.TextChanged
        Dim ans As Boolean = IsValidConfirmPass()
    End Sub

    Private Function IsValidConfirmPass() As Boolean
        Dim flag As Boolean = False
        lblConfirmPassFalse.ForeColor = Color.Red
        If Not txtPassword1.Text = txtPassword2.Text Then
            lblConfirmPassFalse.Text = "Not match"
        Else
            lblConfirmPassFalse.Text = ""
            flag = True
        End If
        Return flag
    End Function

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FrmMemberLogin.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        FrmMemberRegister.Show()
        Me.Close()
    End Sub
End Class