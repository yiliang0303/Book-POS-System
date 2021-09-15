Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.IO
Public Class frmUserProfile
    Public selectedId As String = ""
    Public oriPass As String = ""

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim intResult As Long
        Dim db As New DBDataContext()
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = selectedId)

        If s Is Nothing Then
            MessageBox.Show("Staff no found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        intResult = MessageBox.Show("Are you sure you want to delete", "Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If intResult = vbOK Then
            db.Staffs.DeleteOnSubmit(s)
            db.SubmitChanges()
            MessageBox.Show("Delete Sucessfully")
            frmUserList.Show()
            Me.Close()
            File.Delete(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\code\" & s.staffID & ".jpg"))
        Else
            MessageBox.Show("Delete Failed")
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtEmail.ReadOnly = False
        txtUsername.ReadOnly = False
        txtPhone1st.ReadOnly = False
        txtAddress.ReadOnly = False
        txtName.ReadOnly = False
        btnEdit.Visible = False
        btnDelete.Visible = False
        btnSave.Visible = True
        btnBack2.Visible = True
        btnBack1.Visible = False
        txtName.Focus()
        lblChangepassword.Visible = True
        txt2number.ReadOnly = False
        txt4number.ReadOnly = False
        txtEmail.Cursor = Cursors.IBeam
        txtUsername.Cursor = Cursors.IBeam
        txtPhone1st.Cursor = Cursors.IBeam
        txtAddress.Cursor = Cursors.IBeam
        txtName.Cursor = Cursors.IBeam
        cboPosition.Cursor = Cursors.Default
        txtPhone2nd.ReadOnly = False
        txt4number.ReadOnly = False
        txt2number.ReadOnly = False
        txtPhone2nd.Cursor = Cursors.IBeam
        txt4number.Cursor = Cursors.IBeam
        txt2number.Cursor = Cursors.IBeam
        txtUsername.ReadOnly = False
        txtUsername.Cursor = Cursors.IBeam
        If selectAdminId = selectedId Then
            cboPosition.Enabled = False
        Else
            cboPosition.Enabled = True
        End If
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
        If currentYear - selectedYear > 70 Then
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
        'If result = True Then
        '    txtPhone2nd.Focus()
        'End If
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim username As Boolean = IsValidUsernameFormat()
        Dim name As Boolean = IsValidNameFormat()
        Dim birthdate As Boolean = IsValidBirthDateFormat()
        Dim ic2 As Boolean = IsValidICFormat()
        Dim ic4 As Boolean = IsValidIC2Format()
        Dim email As Boolean = IsValidEmailFormat()
        Dim phoneprefix As Boolean = IsValidPhone1st()
        Dim phone As Boolean = IsValidPhone2nd()
        Dim address As Boolean = isValidAddress()
        Dim db As New DBDataContext()
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = selectedId)

        If address = False Or name = False Or ic2 = False Or ic4 = False Or phoneprefix = False Or phone = False Or birthdate = False Or username = False Or email = False Then
            MessageBox.Show("Edit failed")
        Else

            Dim strUsername As String = txtUsername.Text
            Dim strEmail As String = txtEmail.Text
            Dim strIC As String = txtYMD.Text & txt2number.Text & txt4number.Text
            Dim s1 As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID <> selectedId And (o.sUsername = strUsername Or o.sEmail = strEmail Or o.sIC = strIC))
            If s1 Is Nothing Then
                s.sName = txtName.Text
                s.sAddress = txtAddress.Text
                s.sEmail = txtEmail.Text
                Dim position As String = ""
                If cboPosition.SelectedIndex = 0 Then
                    position = "Admin"
                    Dim s2 As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = selectAdminId And o.sPosition = "Admin")

                    If s2 Is Nothing Then
                        MessageBox.Show(selectAdminId)
                    Else
                        s2.sPosition = "Staff"
                        db.SubmitChanges()
                    End If

                Else
                    position = "Staff"
                End If
                s.sPosition = position
                s.sUsername = txtUsername.Text
                s.sIC = txtYMD.Text & txt2number.Text & txt4number.Text
                s.sPhone = txtPhone1st.Text & txtPhone2nd.Text
                db.SubmitChanges()

                MessageBox.Show("Edit sucessfully")
                If s.sPosition = "Admin" Then
                    Me.Close()
                    frmLogin.Show()
                    frmLogin.btnBack.Visible = False
                    frmLogin.lblAdmin.Text = "Admin Login"
                Else
                    Me.Close()
                    frmUserList.Show()
                End If

            ElseIf s1.sUsername.Equals(strUsername) Then
                MessageBox.Show("Duplicated Username")
            ElseIf s1.sIC.Equals(strIC) Then
                MessageBox.Show("Duplicated IC")
            ElseIf s1.sEmail.Equals(strEmail) Then
                MessageBox.Show("Duplicated Email")
            End If
        End If

    End Sub


    Private Sub frmUserProfile_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim db As New DBDataContext()
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = selectedId)

        If s Is Nothing Then
            MessageBox.Show("Staff no found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        mskID.Text = s.staffID
        txtName.Text = s.sName
        txtAddress.Text = s.sAddress
        txtEmail.Text = s.sEmail
        Dim ic As String = s.sIC
        txtYMD.Text = ic.Substring(0, 6)
        txt2number.Text = ic.Substring(6, 2)
        txt4number.Text = ic.Substring(8, 4)
        Dim phone As String = s.sPhone
        txtPhone1st.Text = phone.Substring(0, 3)
        Dim phoneLength As Integer = s.sPhone.Length
        If phoneLength = 10 Then
            txtPhone2nd.Text = phone.Substring(3, 7)
        Else
            txtPhone2nd.Text = phone.Substring(3, 8)
        End If
        Dim position As String = s.sPosition
        If position.Equals("Admin") Then
            cboPosition.SelectedIndex = 0
        Else
            cboPosition.SelectedIndex = 1
        End If
        txtUsername.Text = s.sUsername
        oriPass = s.sPassword
        Dim birthday As String = s.sIC.Substring(0, 6)
        Dim year As String = birthday.Substring(0, 2)
        Dim month As String = birthday.Substring(2, 2)
        Dim day As String = birthday.Substring(4, 2)
        Dim fullYear As String = ""
        If CInt(year) >= 50 And CInt(year) <= 99 Then
            fullYear = "19" & year
        Else
            fullYear = "20" & year
        End If
        timeBirthdate.Text = day & "/" & month & "/" & fullYear
    End Sub

    Private Sub lblChangepassword_Click(sender As Object, e As EventArgs) Handles lblChangepassword.Click
        txtOriPass.Visible = True
        Label17.Visible = True
        picVisibleOri.Visible = True
        btnCheck.Visible = True
    End Sub

    Private Sub lblChangepassword_MouseLeave(sender As Object, e As EventArgs) Handles lblChangepassword.MouseLeave
        lblChangepassword.Font = New Font("Arial", 14)
    End Sub

    Private Sub lblChangepassword_MouseMove(sender As Object, e As MouseEventArgs) Handles lblChangepassword.MouseMove
        lblChangepassword.Font = New Font("Arial", 14, FontStyle.Underline)
    End Sub

    Private Sub picVisibleOri_Click(sender As Object, e As EventArgs) Handles picVisibleOri.Click
        If txtOriPass.UseSystemPasswordChar = True Then
            txtOriPass.UseSystemPasswordChar = False
            picVisibleOri.Image = My.Resources.visible
        Else
            txtPassword1.UseSystemPasswordChar = True
            picVisibleOri.Image = My.Resources.invisible
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim db As New DBDataContext()
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = selectedId)
        Dim pass1 As Boolean = IsValidPass1Format()
        Dim pass2 As Boolean = IsValidPass2Format()
        Dim password1 As String = ""
        Dim password2 As String = ""

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
                    frmUserList.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Cannot same with previous password")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmUserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor
        Me.grpAcc.BackColor = My.Settings.backgroundColor
        Me.grpDetail.BackColor = My.Settings.backgroundColor

        Me.btnDelete.BackColor = My.Settings.buttonColor
        Me.btnEdit.BackColor = My.Settings.buttonColor
        Me.btnSave.BackColor = My.Settings.buttonColor
        Me.btnConfirm.BackColor = My.Settings.buttonColor
        Me.btnBack1.BackColor = My.Settings.buttonColor
        Me.btnBack2.BackColor = My.Settings.buttonColor

        Me.btnDelete.Font = My.Settings.buttonFont
        Me.btnEdit.Font = My.Settings.buttonFont
        Me.btnSave.Font = My.Settings.buttonFont
        Me.btnConfirm.Font = My.Settings.buttonFont
        Me.btnCheck.Font = My.Settings.buttonFont
        Me.btnBack1.Font = My.Settings.buttonFont
        Me.btnBack2.Font = My.Settings.buttonFont

        Me.btnSave.ForeColor = My.Settings.buttonForeColor
        Me.btnEdit.ForeColor = My.Settings.buttonForeColor
        Me.btnDelete.ForeColor = My.Settings.buttonForeColor
        Me.btnConfirm.ForeColor = My.Settings.buttonForeColor
        Me.btnCheck.ForeColor = My.Settings.buttonForeColor
        Me.btnBack1.ForeColor = My.Settings.buttonForeColor
        Me.btnBack2.ForeColor = My.Settings.buttonForeColor


        If selectedId = selectAdminId Then
            btnDelete.Visible = False
            cboPosition.Enabled = False
        End If

    End Sub

    Private Sub lblCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim db As New DBDataContext
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.staffID = selectedId)
        Dim userPass As String = ""
        Try
            userPass = txtOriPass.Text
            If CheckPassword.Hash.VerifyHash(userPass, s.sPassword) = True Then
                userPass = txtOriPass.Text
                txtPassword1.Visible = True
                txtPassword2.Visible = True
                lblPass1False.Visible = True
                lblPass2False.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                picVisible.Visible = True
                picVisible2.Visible = True
                txtPassword1.Enabled = True
                txtPassword2.Enabled = True
                btnConfirm.Visible = True
                btnCheck.Enabled = False
                txtOriPass.Enabled = False
                picVisibleOri.Visible = False
            ElseIf userPass = "" Then
                MessageBox.Show("Please enter original password")
            Else
                MessageBox.Show("Wrong password")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmUserProfile_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Me.txtEmail.ReadOnly = True
        Me.txtUsername.ReadOnly = True
        Me.txtPhone1st.ReadOnly = True
        Me.txtAddress.ReadOnly = True
        Me.txtName.ReadOnly = True
        Me.cboPosition.Enabled = False
        Me.picProfilePic.Enabled = False
        Me.picProfilePic.Cursor = Cursors.No
        Me.btnEdit.Visible = True
        Me.btnDelete.Visible = True
        Me.btnSave.Visible = False
        Me.btnback2.Visible = False
        Me.btnBack1.Visible = True
        Me.lblChangepassword.Visible = False
        Me.txt2number.ReadOnly = True
        Me.txt4number.ReadOnly = True
        Me.txtEmail.Cursor = Cursors.No
        Me.txtUsername.Cursor = Cursors.No
        Me.txtPhone1st.Cursor = Cursors.No
        Me.txtAddress.Cursor = Cursors.No
        Me.txtName.Cursor = Cursors.No
        Me.cboPosition.Cursor = Cursors.Default
        Me.txtPhone2nd.ReadOnly = True
        Me.txt4number.ReadOnly = True
        Me.txt2number.ReadOnly = True
        Me.txtPhone2nd.Cursor = Cursors.No
        Me.txt4number.Cursor = Cursors.No
        Me.txt2number.Cursor = Cursors.No
        Me.grpAcc.Visible = False

        Me.txtPassword1.Visible = False
        Me.txtPassword2.Visible = False
        Me.lblPass1False.Visible = False
        Me.lblPass2False.Visible = False
        Me.Label3.Visible = False
        Me.Label4.Visible = False
        Me.picVisible.Visible = False
        Me.picVisible2.Visible = False
        Me.txtPassword1.Enabled = False
        Me.txtPassword2.Enabled = False
        Me.btnConfirm.Visible = False
        Me.txtOriPass.Clear()
        Me.lblOriPassFalse.Text = ""
        Me.txtPassword1.Clear()
        Me.lblPass1False.Text = ""
        Me.txtPassword2.Clear()
        Me.lblPass2False.Text = ""
    End Sub

    Private Sub btnBack1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click
        Me.Close()
        frmUserList.Show()
    End Sub

    Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        Dim intResult As Long = 0
        intResult = MessageBox.Show("Are you sure you want to go back without save?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If intResult = vbYes Then
            frmUserList.Show()
            Me.Close()
        End If
    End Sub
End Class