Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MessagingToolkit
Imports System.Net
Imports System.Net.Mail

Public Class frmRegister

    Private Sub BindData()
        Dim db As New DBDataContext
        Dim rs1 = From s In db.Staffs
                  Where s.staffID <> "SELF-POS"
                  Select s
        dgv.DataSource = rs1
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEmail.Clear()
        txtPassword1.Clear()
        txtPassword2.Clear()
        txtUsername.Clear()
        txtUsername.Focus()
        txtName.Clear()
        txt4number.Clear()
        txt2number.Clear()
        txtPhone1st.Clear()
        txtPhone2nd.Clear()
        txtYMD.Clear()
        txtAddress.Clear()
        lblAddressFalse.Text = ""
        txt2number.Enabled = False
        txt4number.Enabled = False
        txtPhone2nd.Enabled = False
        lblBirthFalse.Text = " "
        lblContactFalse.Text = ""
        lblEmailFalse.Text = ""
        lblNameFalse.Text = ""
        lblNRICFalse.Text = ""
        lblPass1False.Text = ""
        lblPass2False.Text = ""
        lblUsernameFalse.Text = ""
        timeBirthdate.Text = Now.ToShortDateString
    End Sub

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        Me.btnAdminRegister.BackColor = My.Settings.buttonColor
        Me.btnClear.BackColor = My.Settings.buttonColor
        Me.btnStaffRegister.BackColor = My.Settings.buttonColor
        Me.btnBack.BackColor = My.Settings.buttonColor

        Me.btnAdminRegister.Font = My.Settings.buttonFont
        Me.btnClear.Font = My.Settings.buttonFont
        Me.btnStaffRegister.Font = My.Settings.buttonFont
        Me.btnBack.Font = My.Settings.buttonFont

        Me.btnClear.ForeColor = My.Settings.buttonForeColor
        Me.btnAdminRegister.ForeColor = My.Settings.buttonForeColor
        Me.btnStaffRegister.ForeColor = My.Settings.buttonForeColor
        Me.btnBack.ForeColor = My.Settings.buttonForeColor

        BindData()
        Label2.Text = "Admin Registration"
        cboPosition.SelectedIndex = 0
        cboPosition.Enabled = False
        txtUsername.Focus()
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

    Private Function IsValidUsernameFormat() As Boolean
        Dim flag As Boolean = False
        If CStr(txtUsername.Text) = "" Then
            lblUsernameFalse.Text = "*Required"
        Else
            lblUsernameFalse.Text = ""
            flag = True
        End If
        Return flag
    End Function

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        Dim result As Boolean = IsValidUsernameFormat()
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            If Not Char.IsLetterOrDigit(e.KeyChar) OrElse
              Not "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789".Contains(e.KeyChar.ToString) Then
                e.Handled = True
            End If
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

    Private Sub txtPassword1_TextChanged(sender As Object, e As EventArgs) Handles txtPassword1.TextChanged
        Dim result As Boolean = IsValidPass1Format()
    End Sub


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

    Private Sub txtPassword2_TextChanged(sender As Object, e As EventArgs) Handles txtPassword2.TextChanged
        Dim result As Boolean = IsValidPass2Format()
    End Sub


    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Dim result As Boolean = IsValidNameFormat()
    End Sub

    Private Function IsValidNameFormat() As Boolean
        Dim flag As Boolean = False
        If CStr(txtName.Text) = "" Then
            lblNameFalse.Text = "*Required"
        Else
            lblNameFalse.Text = ""
            flag = True
        End If
        Return flag
    End Function

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            If Not Char.IsLetter(e.KeyChar) OrElse
              Not "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz".Contains(e.KeyChar.ToString) Then
                e.Handled = True
            End If
        End If
    End Sub



    Private Function IsValidEmailFormat() As Boolean
        Dim flag As Boolean = False
        Dim format As String = "^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$"
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

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        Dim result As Boolean = IsValidEmailFormat()
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            If Not "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789@.-_".Contains(e.KeyChar.ToString) Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Function IsValidBirthDateFormat() As Boolean
        Dim flag As Boolean = False
        Dim today = DateTime.Now.ToShortDateString
        Dim selectedDate As String = CStr(timeBirthdate.Text)
        Dim currentYear As Integer = Date.Today.Year
        Dim DigitYear As Integer = timeBirthdate.Value.Year.ToString().Substring(2, 2)
        Dim selectedYear As Integer = timeBirthdate.Value.Year
        Dim selectedMonth As Integer = timeBirthdate.Value.Month
        Dim selectedDay As Integer = timeBirthdate.Value.Day

        Dim str As String = ""
        If timeBirthdate.Enabled = False Then
            lblBirthFalse.Text = ""
        End If
        If currentYear - selectedYear > 120 Then
            lblBirthFalse.Text = "*Invalid age"
            txtYMD.Text = str
        ElseIf currentYear - selectedYear < 18 Then
            lblBirthFalse.Text = "*Invalid age"
            txtYMD.Text = str
        ElseIf selectedDate = today Then
            lblBirthFalse.Text = "*Required"
        Else
            txtYMD.ReadOnly = True
            txt2number.Enabled = True
            lblBirthFalse.Text = ""
            grpDetail.Focus()
            str &= DigitYear.ToString("D2")
            str &= selectedMonth.ToString("D2")
            str &= selectedDay.ToString("D2")
            txtYMD.Text = str
            flag = True
        End If
        Return flag
    End Function

    Private Sub Birthdate_ValueChanged(sender As Object, e As EventArgs) Handles timeBirthdate.ValueChanged
        Dim ans As Boolean = IsValidBirthDateFormat()
    End Sub

    Private Function IsValidICFormat() As Boolean
        Dim flag As Boolean = False
        Dim format As String = "^[0,1,2,3,4,5,6,7,8,9][0,1,2,3,4,5,6,7,8,9]"
        If Regex.IsMatch(CStr(txt2number.Text), format) Then
            If Not (CStr(txt2number.Text) = "00" Or CStr(txt2number.Text) = "17" Or CStr(txt2number.Text) = "18" Or
                CStr(txt2number.Text) = "20" Or CStr(txt2number.Text) = "69" Or CStr(txt2number.Text) = "70" Or
                CStr(txt2number.Text) = "73" Or CStr(txt2number.Text) = "80" Or CStr(txt2number.Text) = "81" Or
                CStr(txt2number.Text) = "94" Or CStr(txt2number.Text) = "95" Or CStr(txt2number.Text) = "96" Or
                CStr(txt2number.Text) = "97" Or CStr(txt2number.Text) = "19") Then

                lblNRICFalse.Text = ""
                flag = True
                txt4number.Enabled = True
                txt4number.Focus()
            End If
        ElseIf CStr(txt2number.Text) = "" Then
            lblNRICFalse.Text = "*Required"
        Else
            lblNRICFalse.Text = "Wrong format"
        End If
        Return flag

    End Function

    Private Function IsValidIC2Format() As Boolean
        Dim flag As Boolean = False
        Dim code As String = CStr(txt4number.Text)
        Dim format As String = "^[0,1,2,3,4,5,6,7,8,9][0,1,2,3,4,5,6,7,8,9][0,1,2,3,4,5,6,7,8,9][0,1,2,3,4,5,6,7,8,9]"
        If Regex.IsMatch(CStr(txt4number.Text), format) Then
            lblNRICFalse.Text = ""
            txtEmail.Focus()
            flag = True
        ElseIf code = "" Then
            lblNRICFalse.Text = "*Required"
        Else
            lblNRICFalse.Text = "Wrong format"
        End If
        Return flag
    End Function

    Private Function IsValidPhone1st() As Boolean
        Dim flag As Boolean = False
        Dim format As String = "^01[0,1,2,3,4,6,7,8,9]"
        If Regex.IsMatch(CStr(txtPhone1st.Text), format) Then
            lblContactFalse.Text = ""
            flag = True
            txtPhone2nd.Enabled = True
        ElseIf CStr(txtPhone1st.Text) = "" Then
            lblContactFalse.Text = "*Required"
        Else
            lblContactFalse.Text = "Wrong Format"
        End If
        Return flag
    End Function

    Private Function IsValidPhone2nd() As Boolean
        Dim flag As Boolean = False
        Dim length As Integer = CStr(txtPhone2nd.Text).Length

        If length = txtPhone2nd.MaxLength Then
            lblContactFalse.Text = ""
            flag = True
            txtPhone2nd.Enabled = True
        ElseIf CStr(txtPhone1st.Text) = "" Then
            lblContactFalse.Text = "*Required"
        Else
            lblContactFalse.Text = "in " & txtPhone2nd.MaxLength & " digits"
        End If
        Return flag
    End Function

    Private Sub txtPhone1st_TextChanged(sender As Object, e As EventArgs) Handles txtPhone1st.TextChanged
        Dim result As Boolean = IsValidPhone1st()
        If result = True Then
            txtPhone2nd.Focus()
        End If
    End Sub

    Private Sub txtPhone2nd_TextChanged(sender As Object, e As EventArgs) Handles txtPhone2nd.TextChanged
        Dim prefix As String = txtPhone1st.Text
        If prefix.Equals("011") Then
            txtPhone2nd.MaxLength = 8
        Else
            txtPhone2nd.MaxLength = 7
        End If
        Dim ans As Boolean = IsValidPhone2nd()
    End Sub

    Private Sub txtPhone2nd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone2nd.KeyPress
        If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            If Not Char.IsDigit(e.KeyChar) OrElse
              Not "0123456789".Contains(e.KeyChar.ToString) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPhone1st_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone1st.KeyPress
        If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            If Not Char.IsDigit(e.KeyChar) OrElse
              Not "0123456789".Contains(e.KeyChar.ToString) Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txt2number_TextChanged(sender As Object, e As EventArgs) Handles txt2number.TextChanged
        Dim result As Boolean = IsValidICFormat()
    End Sub

    Private Sub txt2number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt2number.KeyPress
        If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            If Not Char.IsDigit(e.KeyChar) OrElse
              Not "0123456789".Contains(e.KeyChar.ToString) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt4number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt4number.KeyPress
        If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            If Not Char.IsDigit(e.KeyChar) OrElse
              Not "0123456789".Contains(e.KeyChar.ToString) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt4number_TextChanged(sender As Object, e As EventArgs) Handles txt4number.TextChanged
        Dim result As Boolean = IsValidIC2Format()
    End Sub


    Private Sub btnAdminRegister_Click(sender As Object, e As EventArgs) Handles btnAdminRegister.Click
        Try
            Dim username As Boolean = IsValidUsernameFormat()
            Dim pass1 As Boolean = IsValidPass1Format()
            Dim pass2 As Boolean = IsValidPass2Format()
            Dim name As Boolean = IsValidNameFormat()
            Dim birthdate As Boolean = IsValidBirthDateFormat()
            Dim ic2 As Boolean = IsValidICFormat()
            Dim ic4 As Boolean = IsValidIC2Format()
            Dim email As Boolean = IsValidEmailFormat()
            Dim phoneprefix As Boolean = IsValidPhone1st()
            Dim phone As Boolean = IsValidPhone2nd()
            Dim address As Boolean = isValidAddress()
            If address = False Or name = False Or ic2 = False Or ic4 = False Or phoneprefix = False Or phone = False Or birthdate = False Or username = False Or email = False Or pass1 = False Or pass2 = False Then
                MessageBox.Show("Register failed")
            Else
                Dim strUsername As String = ""
                Dim strEmail As String = ""
                Dim strIC As String = ""
                Dim db As New DBDataContext
                Try
                    strUsername = txtUsername.Text
                    strEmail = txtEmail.Text
                    strIC = txtYMD.Text & txt2number.Text & txt4number.Text
                    Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.sUsername = strUsername Or o.sEmail = strEmail Or o.sIC = strIC)
                    If s Is Nothing Then
                        Dim db1 As New DBDataContext
                        Dim staff As New Staff
                        Dim intlastnumber As Integer = 0
                        BindData()
                        For i As Integer = 0 To dgv.Rows.Count - 2
                            Dim strLastNumber As String = CStr(dgv.Rows(i).Cells(0).Value)
                            If strLastNumber.Contains(Date.Today.ToString("yy") & "S") Then
                                intlastnumber += 1
                            End If
                        Next

                        Dim id As String = Date.Today.ToString("yy") & "S" & (intlastnumber + 1).ToString("00000")
                        staff.staffID = id
                        createQRcode(id)

                        Dim position As String = ""
                        If cboPosition.SelectedIndex = 0 Then
                            position = "Admin"
                        ElseIf cboPosition.SelectedIndex = 1 Then
                            position = "Staff"
                        End If

                        staff.sUsername = txtUsername.Text
                        Dim passwordEn As String = CheckPassword.Hash.ComputeHash(txtPassword2.Text, Nothing)
                        staff.sPassword = passwordEn
                        staff.sPosition = position
                        staff.sName = txtName.Text
                        staff.sIC = txtYMD.Text & txt2number.Text & txt4number.Text
                        staff.sEmail = txtEmail.Text
                        staff.sPhone = txtPhone1st.Text & txtPhone2nd.Text
                        staff.sAddress = txtAddress.Text

                        db1.Staffs.InsertOnSubmit(staff)
                        db1.SubmitChanges()
                        BindData()


                        Dim A As System.Net.Mail.Attachment = New System.Net.Mail.Attachment(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\code\" & staff.staffID & ".jpg"))

                        Dim from, pass, messageBody As String
                        Dim message As MailMessage = New MailMessage
                        toUser = staff.sEmail
                        from = "mybook1433@gmail.com"
                        pass = "mybookpos"
                        message.Attachments.Add(A)
                        messageBody = "The attached image is your QR code. Please do no share with others."
                        messageBody &= "This is an auto-generated email, please do not reply this email." & vbNewLine
                        messageBody &= "For feedback or support, kindly reach out to us at http://mybook.com.my/support"
                        message.To.Add(toUser)
                        message.From = New MailAddress(from)
                        message.Body = messageBody
                        message.Subject = "QR Code for MYBOOKPOS"
                        Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
                        smtp.EnableSsl = True
                        smtp.Port = 587
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network
                        smtp.Credentials = New NetworkCredential(from, pass)
                        smtp.Send(message)
                        MessageBox.Show("Register successfully. Kindly check your email to get your QR code.")

                        MessageBox.Show("Register successfully")
                        frmLogin.Show()
                        Me.Close()
                        Exit Sub
                    ElseIf s.sUsername.Equals(strUsername) Then
                        MessageBox.Show("Duplicated Username")
                    ElseIf s.sIC.Equals(strIC) Then
                        MessageBox.Show("Duplicated IC")

                    ElseIf s.sEmail.Equals(strEmail) Then
                        MessageBox.Show("Duplicated Email")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function isValidAddress() As Boolean
        Dim flag As Boolean = False
        If CStr(txtAddress.Text) = "" Then
            lblAddressFalse.Text = "*Required"
        Else
            lblAddressFalse.Text = ""
            flag = True
        End If
        Return flag
    End Function

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged
        Dim result As Boolean = isValidAddress()
    End Sub

    Private Sub btnStaffRegister_Click(sender As Object, e As EventArgs) Handles btnStaffRegister.Click
        Dim username As Boolean = IsValidUsernameFormat()
        Dim pass1 As Boolean = IsValidPass1Format()
        Dim pass2 As Boolean = IsValidPass2Format()
        Dim name As Boolean = IsValidNameFormat()
        Dim birthdate As Boolean = IsValidBirthDateFormat()
        Dim ic2 As Boolean = IsValidICFormat()
        Dim ic4 As Boolean = IsValidIC2Format()
        Dim email As Boolean = IsValidEmailFormat()
        Dim phoneprefix As Boolean = IsValidPhone1st()
        Dim phone As Boolean = IsValidPhone2nd()
        Dim address As Boolean = isValidAddress()




        If address = False Or name = False Or ic2 = False Or ic4 = False Or phoneprefix = False Or phone = False Or birthdate = False Or username = False Or email = False Or pass1 = False Or pass2 = False Then
            MessageBox.Show("Register failed")
        Else
            Dim strUsername As String = ""
            Dim strEmail As String = ""
            Dim strIC As String = ""
            Dim db As New DBDataContext
            strUsername = txtUsername.Text
            strEmail = txtEmail.Text
            strIC = txtYMD.Text & txt2number.Text & txt4number.Text
            Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.sUsername = strUsername Or o.sEmail = strEmail Or o.sIC = strIC)
            If s Is Nothing Then
                Dim db1 As New DBDataContext
                Dim staff As New Staff
                Dim intlastnumber As Integer = 0
                BindData()
                Dim lastID As String = CStr(dgv.Rows((dgv.Rows.Count - 2)).Cells(0).Value)

                lastID = Microsoft.VisualBasic.Right(lastID, 5)

                Dim id As String = Date.Today.ToString("yy") & "S" & (CInt(lastID) + 1).ToString("00000")
                staff.staffID = id
                createQRcode(id)

                Dim position As String = ""

                If cboPosition.SelectedIndex = 0 Then
                    position = "Admin"
                ElseIf cboPosition.SelectedIndex = 1 Then
                    position = "Staff"
                End If

                staff.sUsername = txtUsername.Text
                Dim passwordEn As String = CheckPassword.Hash.ComputeHash(txtPassword2.Text, Nothing)
                staff.sPassword = passwordEn
                staff.sPosition = position
                staff.sName = txtName.Text
                staff.sIC = txtYMD.Text & txt2number.Text & txt4number.Text
                staff.sEmail = txtEmail.Text
                staff.sPhone = txtPhone1st.Text & txtPhone2nd.Text
                staff.sAddress = txtAddress.Text

                db1.Staffs.InsertOnSubmit(staff)
                db1.SubmitChanges()
                BindData()


                Dim A As System.Net.Mail.Attachment = New System.Net.Mail.Attachment(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\code\" & staff.staffID & ".jpg"))

                Dim from, pass, messageBody As String
                Dim message As MailMessage = New MailMessage
                toUser = staff.sEmail
                from = "mybook1433@gmail.com"
                pass = "mybookpos"
                message.Attachments.Add(A)
                messageBody = "The attached image is your QR code. Please do no share with others."
                messageBody &= "This is an auto-generated email, please do not reply this email." & vbNewLine
                messageBody &= "For feedback or support, kindly reach out to us at http://mybook.com.my/support"
                message.To.Add(toUser)
                message.From = New MailAddress(from)
                message.Body = messageBody
                message.Subject = "QR Code for MYBOOKPOS"
                Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
                smtp.EnableSsl = True
                smtp.Port = 587
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network
                smtp.Credentials = New NetworkCredential(from, pass)
                smtp.Send(message)
                MessageBox.Show("Register successfully. Kindly check your email to get your QR code.")
                frmUserList.Show()
                Me.Close()
                'frmLogin.Show()
            ElseIf s.sUsername.Equals(strUsername) Then
                MessageBox.Show("Duplicated Username")
            ElseIf s.sIC.Equals(strIC) Then
                MessageBox.Show("Duplicated IC")

            ElseIf s.sEmail.Equals(strEmail) Then
                MessageBox.Show("Duplicated Email")
            End If
        End If


    End Sub

    Private Sub frmRegister_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        txtEmail.Clear()
        txtPassword1.Clear()
        txtPassword2.Clear()
        txtUsername.Clear()
        txtUsername.Focus()
        txtName.Clear()
        txt4number.Clear()
        txt2number.Clear()
        txtPhone1st.Clear()
        txtPhone2nd.Clear()
        txtYMD.Clear()
        txtAddress.Clear()
        lblAddressFalse.Text = ""
        txt2number.Enabled = False
        txt4number.Enabled = False
        txtPhone2nd.Enabled = False
        lblBirthFalse.Text = " "
        lblContactFalse.Text = ""
        lblEmailFalse.Text = ""
        lblNameFalse.Text = ""
        lblNRICFalse.Text = ""
        lblPass1False.Text = ""
        lblPass2False.Text = ""
        lblUsernameFalse.Text = ""

        timeBirthdate.Text = Now.ToShortDateString
    End Sub

    Private Sub createQRcode(ByVal primaryKey As String)
        Dim pic As New PictureBox
        Me.Controls.Add(pic)
        pic.Visible = False

        Dim gen As New QRCoder.QRCodeGenerator
        Dim data = gen.CreateQrCode(primaryKey, QRCoder.QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCoder.QRCode(data)
        pic.Image = code.GetGraphic(6)
        SaveImageCopy(primaryKey, pic.Image)
    End Sub

    Private Sub SaveImageCopy(filename As String, image As Image)
        Dim path As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\code"), filename & ".jpg")
        Dim dest As New Bitmap(image.Width, image.Height)
        Dim gfx As Graphics = Graphics.FromImage(dest)
        gfx.DrawImageUnscaled(image, Point.Empty)
        gfx.Dispose()
        dest.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg)
        dest.Dispose()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim intResult As Long = 0
        intResult = MessageBox.Show("Are you sure you want to back ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If intResult = vbOK Then
            frmUserList.Show()
            Me.Close()
        End If

    End Sub
End Class
