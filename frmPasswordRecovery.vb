Imports System.Net
Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class frmPasswordRecovery
    Dim oripass As String = ""
    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged
        Dim strCheck As String = ""
        strCheck = txtCode.Text
        If String.Compare(strCheck, randomCode) = 0 Then
            picValidCode.Image = My.Resources._true
            picValidCode.Visible = True
            lblStatus.Visible = True
            lblStatus.Text = "Correct"
            txtCode.Enabled = False
            btnSendCode.Enabled = False
            btnResend.Enabled = False
            grpResetPassword.Visible = True

        Else
            picValidCode.Image = My.Resources._false
            picValidCode.Visible = True
            lblStatus.Visible = True
            lblStatus.Text = "Wrong"
        End If
    End Sub

    Private Sub frmPasswordResettingCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        Me.btnResend.BackColor = My.Settings.buttonColor
        Me.btnSendCode.BackColor = My.Settings.buttonColor
        Me.btnReset.BackColor = My.Settings.buttonColor

        Me.btnResend.Font = My.Settings.buttonFont
        Me.btnSendCode.Font = My.Settings.buttonFont
        Me.btnReset.Font = My.Settings.buttonFont

        Me.btnResend.ForeColor = My.Settings.buttonForeColor
        Me.btnReset.ForeColor = My.Settings.buttonForeColor
        Me.btnSendCode.ForeColor = My.Settings.buttonForeColor

        grpResetPassword.Visible = False
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim email As String = txtEmail.Text
        Dim db As New DBDataContext
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.sEmail = email)

        Dim username As String = ""
        Dim newPass As String = ""
        Dim password1 As String = ""
        Dim password2 As String = ""

        Dim from, pass, messageBody As String
        Dim message As MailMessage = New MailMessage

        toUser = txtEmail.Text
        from = "mybook1433@gmail.com"
        pass = "mybookpos"
        Dim A As System.Net.Mail.Attachment = New System.Net.Mail.Attachment(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\code\" & s.staffID & ".jpg"))
        message.Attachments.Add(A)

        messageBody = "This email confirms that your password has been changed." & vbNewLine
        messageBody &= "The attached image is your QR code. Please do no share with others." & vbNewLine
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

        Dim pass1 As Boolean = IsValidPass1Format()
        Dim pass2 As Boolean = IsValidPass2Format()
        Try
            If pass1 = False Or pass2 = False Then
                MessageBox.Show("Reset Failed")
            Else
                password1 = txtPassword1.Text
                password2 = txtPassword2.Text
                If CheckPassword.Hash.VerifyHash(password2, s.sPassword) = False Then
                    MessageBox.Show("Reset password sucessfully !", "Confirm Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim passwordEn As String = CheckPassword.Hash.ComputeHash(txtPassword2.Text, Nothing)
                    s.sPassword = passwordEn
                    db.SubmitChanges()
                    smtp.Send(message)
                    frmLogin.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Cannot same with previous password")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub picVisible_Click(sender As Object, e As EventArgs) Handles picVisible.Click
        If txtPassword1.UseSystemPasswordChar = True Then
            txtPassword1.UseSystemPasswordChar = False
            picVisible.Image = My.Resources.visible
        Else
            txtPassword1.UseSystemPasswordChar = True
            picVisible.Image = My.Resources.invisible
        End If
    End Sub

    Private Sub picVisible2_Click(sender As Object, e As EventArgs) Handles picVisible2.Click
        If txtPassword2.UseSystemPasswordChar = True Then
            txtPassword2.UseSystemPasswordChar = False
            picVisible2.Image = My.Resources.visible
        Else
            txtPassword2.UseSystemPasswordChar = True
            picVisible2.Image = My.Resources.invisible
        End If
    End Sub

    Private Function IsValidPass1Format() As Boolean
        Dim flag As Boolean = False
        Dim pass As String = CStr(txtPassword1.Text)
        Dim letter As Integer = 0
        Dim num As Integer = 0
        Dim other As Integer = 0

        If pass = "" Then
            lblPass1False.ForeColor = Color.Red
            lblPass1False.Text = "*Required"
        ElseIf pass.Length < 8 Then
            lblPass1False.Text = "At least 8 alphanumeric"
        
        Else
            For Each c In pass
                If Not Char.IsLetterOrDigit(c.ToString(), 0) Then
                    other += 1
                ElseIf Char.IsLetter(c.ToString(), 0) Then
                    letter += 1
                ElseIf Char.IsDigit(c.ToString(), 0) Then
                    num += 1
                End If
            Next
            If other >= 1 And letter >= 1 And num >= 1 Then
                lblPass1False.ForeColor = Color.Green
                lblPass1False.Text = "Strong Password "
                flag = True
            ElseIf other = 0 Then
                lblPass1False.ForeColor = Color.Red
                lblPass1False.Text = "Weak Password" & vbNewLine
                lblPass1False.Text &= "must consist " & vbNewLine & "special character"
                flag = False
            ElseIf letter = 0 Then
                lblPass1False.ForeColor = Color.Red
                lblPass1False.Text = "Weak Password" & vbNewLine
                lblPass1False.Text &= "must consist " & vbNewLine & "letter"
                flag = False
            ElseIf num = 0 Then
                lblPass1False.ForeColor = Color.Red
                lblPass1False.Text = "Weak Password" & vbNewLine
                lblPass1False.Text &= "must consist " & vbNewLine & "number"
                flag = False
            End If
        End If
        Return flag
    End Function

    Private Function IsValidPass2Format() As Boolean
        Dim flag As Boolean = False
        lblPass2False.ForeColor = Color.Red
        If CStr(txtPassword2.Text) = "" Then
            lblPass2False.Text = "*Required"
        ElseIf Not CStr(txtPassword1.Text) = CStr(txtPassword2.Text) Then
            lblPass2False.Text = "Not match"
        Else
            lblPass2False.ForeColor = Color.Green
            lblPass2False.Text = "Matched"
            flag = True
        End If
        Return flag
    End Function

    Private Sub txtPassword1_TextChanged(sender As Object, e As EventArgs) Handles txtPassword1.TextChanged
        Dim result As Boolean = IsValidPass1Format()
    End Sub

    Private Sub txtPassword1_Leave(sender As Object, e As EventArgs) Handles txtPassword1.Leave
        Dim result As Boolean = IsValidPass1Format()
        If result = False Then
            txtPassword1.Focus()
        End If
    End Sub

    Private Sub txtPassword2_TextChanged(sender As Object, e As EventArgs) Handles txtPassword2.TextChanged
        Dim result As Boolean = IsValidPass2Format()
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        Dim format As String = "^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$"
        lblEmailFalse.ForeColor = Color.Red
        If Regex.IsMatch(CStr(txtEmail.Text), format) Then
            lblEmailFalse.Text = ""
            btnSendCode.Visible = True
        ElseIf CStr(txtEmail.Text) = "" Then
            lblEmailFalse.Text = "*Required"
        Else
            lblEmailFalse.Text = "Wrong Format"
        End If



    End Sub

    Private Sub btnSendCode_Click(sender As Object, e As EventArgs) Handles btnSendCode.Click
        Dim from, pass, messageBody As String
        Dim rand As Random = New Random
        randomCode = rand.Next(0, 1000000).ToString("d6")
        Dim message As MailMessage = New MailMessage
        Dim db As New DBDataContext
        Dim email As String = ""
        toUser = txtEmail.Text
        from = "mybook1433@gmail.com"
        pass = "mybookpos"
        messageBody = "Your reset code is " & randomCode & vbNewLine
        messageBody &= "This is an auto-generated email, please do not reply this email." & vbNewLine
        messageBody &= "For feedback or support, kindly reach out to us at http://mybook.com.my/support"
        message.To.Add(toUser)
        message.From = New MailAddress(from)
        message.Body = messageBody
        message.Subject = "Password resetting code"
        Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
        smtp.EnableSsl = True
        smtp.Port = 587
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network
        smtp.Credentials = New NetworkCredential(from, pass)

        Try
            email = txtEmail.Text
            Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.sEmail = email)

            If s Is Nothing Then
                MessageBox.Show("No Such Email in Database")
                txtEmail.Clear()
                txtEmail.Focus()
                btnSendCode.Visible = False
                lblEmailFalse.Text = ""
            Else
                oripass = s.sPassword
                smtp.Send(message)
                MessageBox.Show("Code sent ! Please check your email.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCode.Visible = True
                Label2.Visible = True
                btnSendCode.Visible = False
                btnResend.Visible = True
                txtEmail.Enabled = False
                txtCode.Clear()
                txtCode.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            If Not "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789@.".Contains(e.KeyChar.ToString) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            If Not Char.IsDigit(e.KeyChar) OrElse
              Not "0123456789".Contains(e.KeyChar.ToString) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnResend_Click(sender As Object, e As EventArgs) Handles btnResend.Click
        Dim from, pass, messageBody As String
        Dim rand As Random = New Random
        randomCode = rand.Next(0, 1000000).ToString("d6")
        Dim message As MailMessage = New MailMessage
        toUser = txtEmail.Text
        from = "mybook1433@gmail.com"
        pass = "mybookpos"
        messageBody = "Your reset code is " & randomCode & vbNewLine
        messageBody &= "This is an auto-generated email, please do not reply this email." & vbNewLine
        messageBody &= "For feedback or support, kindly reach out to us at http://mybook.com.my/support"
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
        Dim email As String = ""
        Try
            email = txtEmail.Text
            Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.sEmail = email)

            If s Is Nothing Then

            Else
                smtp.Send(message)
                MessageBox.Show("Code sent ! Please check your email.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCode.Visible = True
                Label2.Visible = True
                btnSendCode.Visible = False
                btnResend.Visible = True
                txtEmail.Enabled = False
                txtCode.Clear()
                txtCode.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class