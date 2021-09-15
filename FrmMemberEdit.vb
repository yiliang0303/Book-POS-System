Imports System.Text.RegularExpressions
Imports MessagingToolkit.QRCode.Codec
Imports System.ComponentModel
Imports QRCoder
Public Class FrmMemberEdit
    Public selectedID As String
    Public memberHold As Member
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        Dim result As Boolean = IsValidUsernameFormat()
    End Sub
    Private Function IsValidUsernameFormat() As Boolean
        Dim flag As Boolean = False
        If CStr(txtUsername.Text) = "" Then
            lblUsernameFalse.Text = "*Required"
        ElseIf CStr(txtUsername.Text).Length < 5 Then
            lblUsernameFalse.Text = "At least 5 Alphanumeric"
        Else
            lblUsernameFalse.Text = ""
            flag = True
        End If
        Return flag
    End Function

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Dim result As Boolean = IsValidNameFormat()
    End Sub
    Private Function IsValidNameFormat() As Boolean
        Dim flag As Boolean = False
        Dim format As String = "^\(?([A-za-z]{1,32})\)?[ ]{0,1}?([A-za-z]{0,32})[ ]{0,1}?([A-za-z]{0,32})[ ]{0,1}?([A-za-z]{0,32})$"
        lblNameFalse.ForeColor = Color.Red
        If CStr(txtName.Text) = "" Then
            lblNameFalse.Text = "*Required"

        ElseIf Regex.IsMatch(CStr(txtName.Text), format) = False Then
            lblNameFalse.Text = "Wrong Format"
        Else
            lblNameFalse.Text = ""
            flag = True

        End If
        Return flag
    End Function

    Private Sub Birthdate_ValueChanged(sender As Object, e As EventArgs) Handles Birthdate.ValueChanged
        Dim ans As Boolean = IsValidBirthDateFormat()
    End Sub

    Private Function IsValidBirthDateFormat() As Boolean
        Dim flag As Boolean = False
        Dim today = DateTime.Now.ToShortDateString
        Dim selectedDate As String = CStr(Birthdate.Text)
        Dim currentYear As Integer = Date.Today.Year
        Dim DigitYear As Integer = Birthdate.Value.Year.ToString().Substring(2, 2)
        Dim selectedYear As Integer = Birthdate.Value.Year
        Dim selectedMonth As Integer = Birthdate.Value.Month
        Dim selectedDay As Integer = Birthdate.Value.Day

        Dim str As String = ""
        If Birthdate.Enabled = False Then
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
            txtNumberList.Enabled = True
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

    Private Function IsValidICFormat() As Boolean
        Dim flag As Boolean = False
        Dim code As String = CStr(txtNumberList.Text)
        Dim length As Integer = code.Length
        Dim code2 As String = CStr(txtNumber.Text)
        Dim length2 As Integer = code2.Length
        lblNRICFalse.ForeColor = Color.Red
        If code = "" Or CStr(txtNumber.Text) = "" Then
            lblNRICFalse.Text = "*Required"
        ElseIf length < 2 Then
            lblNRICFalse.Text = "*Required state number"
        ElseIf length2 < 4 Then
            lblNRICFalse.Text = "*Required last 4 digit"
        Else
            lblNRICFalse.Text = ""
            flag = True

        End If
        Return flag
    End Function
    Private Sub txt2number_TextChanged(sender As Object, e As EventArgs)
        Dim result As Boolean = IsValidICFormat()
    End Sub


    Private Function CheckIsDigit(ByVal str As String) As Boolean
        Dim flag As Boolean = False
        Dim notDigit As Integer = 0
        For Each c In str
            If Not Char.IsLetterOrDigit(c.ToString(), 0) Then

                notDigit += 1
                flag = True
            End If
        Next
        Return flag
    End Function

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

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        Dim ans As Boolean = IsValidEmailFormat()
    End Sub

    Private Sub txtPhone1st_TextChanged(sender As Object, e As EventArgs) Handles txtPhone1st.TextChanged
        Dim result As Boolean = IsValidPhone1st()
        If result = True Then
            txtPhone2nd.Focus()
        End If
    End Sub

    Private Function IsValidPhone1st() As Boolean
        Dim flag As Boolean = False
        Dim format As String = "^01[0,1,2,3,4,6,7,8,9]"
        If Regex.IsMatch(CStr(txtPhone1st.Text), format) Then
            lblContactFalse.Text = ""
            flag = True
            txtPhone2nd.Enabled = True
        ElseIf CStr(txtPhone1st.Text) = "" Then
            lblContactFalse.Text = "*Required"
            lblContactFalse.ForeColor = Color.Red
        Else
            lblContactFalse.Text = "Wrong Format"
            lblContactFalse.ForeColor = Color.Red
        End If
        Return flag
    End Function

    Private Sub txtPhone2nd_TextChanged(sender As Object, e As EventArgs) Handles txtPhone2nd.TextChanged
        Dim prefix As String = txtPhone1st.Text
        If prefix.Equals("011") Then
            txtPhone2nd.MaxLength = 8
        Else
            txtPhone2nd.MaxLength = 7
        End If
        Dim ans As Boolean = IsValidPhone2nd()
    End Sub

    Private Function IsValidPhone2nd() As Boolean
        Dim flag As Boolean = False
        Dim length As Integer = CStr(txtPhone2nd.Text).Length

        If length = txtPhone2nd.MaxLength Then
            lblContactFalse.Text = ""
            flag = True
            txtPhone2nd.Enabled = True
        ElseIf CStr(txtPhone1st.Text) = "" Then
            lblContactFalse.Text = "*Required"
            lblContactFalse.ForeColor = Color.Red
        Else
            lblContactFalse.Text = "in " & txtPhone2nd.MaxLength & " digits"
        End If
        Return flag
    End Function

    Private Sub txtPhone2nd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone2nd.KeyPress
        If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            If Not Char.IsDigit(e.KeyChar) OrElse
              Not "0123456789".Contains(e.KeyChar.ToString) Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Function IsValidAddrFormat() As Boolean
        Dim flag As Boolean = False

        lblAddressFalse.ForeColor = Color.Red
        If CStr(RichTxtAddr.Text) Is "" Then
            lblAddressFalse.Text = "*Required"
        Else
            lblAddressFalse.Text = ""
            flag = True
        End If
        Return flag
    End Function
    Private Sub RichTxtAddr_TextChanged(sender As Object, e As EventArgs) Handles RichTxtAddr.TextChanged
        Dim ans As Boolean = IsValidAddrFormat()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim name As Boolean = IsValidNameFormat()
        Dim date1 As Boolean = IsValidBirthDateFormat()
        Dim NRIC As Boolean = IsValidICFormat()
        Dim addr As Boolean = IsValidAddrFormat()
        Dim phone1st As Boolean = IsValidPhone1st()
        Dim phone2nd As Boolean = IsValidPhone2nd()

        Dim user As Boolean = IsValidUsernameFormat()
        Dim email As Boolean = IsValidEmailFormat()
        Dim db As New DBDataContext
        Dim mem As Member = db.Members.FirstOrDefault(Function(o) o.memberID = selectedID)
        'Try
        If name = False Then
                txtName.Focus()
                txtName.Clear()
            ElseIf date1 = False Then
                Birthdate.Focus()

            ElseIf NRIC = False Then
                txtNumberList.Focus()
                txtNumber.Focus()
            ElseIf phone1st = False Then
                txtPhone1st.Focus()
                txtPhone1st.Clear()
            ElseIf phone2nd = False Then
                txtPhone2nd.Focus()
                txtPhone2nd.Clear()
            ElseIf addr = False Then
                RichTxtAddr.Focus()
                RichTxtAddr.Clear()

            ElseIf user = False Then
                txtUsername.Focus()
                txtUsername.Clear()
            ElseIf email = False Then
                txtEmail.Focus()
                txtEmail.Clear()

            Else
            'Try


            Dim strUser As String = txtUsername.Text
            Dim strEmail As String = txtEmail.Text
            Dim strIC As String = txtYMD.Text & txtNumberList.Text & txtNumber.Text
            Dim m As Member = db.Members.FirstOrDefault(Function(o) o.memberID <> selectedID And (o.mUsername = strUser Or o.mEmail = strEmail Or o.mIC = strIC))
            If m Is Nothing Then

                mem.mUsername = txtUsername.Text
                mem.mLevel = cboMLevel.Text
                mem.memberID = txtmID.Text
                mem.mPoint = txtPoint.Text

                mem.mName = txtName.Text
                mem.mIC = txtYMD.Text & txtNumberList.Text & txtNumber.Text
                mem.mEmail = txtEmail.Text
                mem.mPhoneNo = txtPhone1st.Text & txtPhone2nd.Text
                mem.mAddress = RichTxtAddr.Text

                db.SubmitChanges()
                MessageBox.Show("Edit Successfully!!!")

            ElseIf m.mUsername.Equals(strUser) Then
                MessageBox.Show("Duplicated Username")
            ElseIf m.mIC.Equals(strIC) Then
                MessageBox.Show("Duplicated IC")

            ElseIf m.mEmail.Equals(strEmail) Then
                MessageBox.Show("Duplicated Email")
            Else

            End If

        End If


    End Sub



    Private Sub FrmMemberEdit_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        ' Dim od As New OpenFileDialog
        ' Dim QRmem As String = reader.decode(New Data.QRCodeBitmapImage(picProfilePic.Image))
        Dim db As New DBDataContext()

        'If od.ShowDialog() = DialogResult.OK Then
        '    picProfilePic.Load(od.FileName)
        'End If

        Dim m As Member = db.Members.FirstOrDefault(Function(o) o.memberID = selectedID)
        If m Is Nothing Then
            MessageBox.Show("Member not found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return

        End If
        'od.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\MemberQRcode\")
        'member found --> Display details
        txtUsername.Text = m.mUsername
        cboMLevel.Text = m.mLevel
        txtmID.Text = m.memberID
        txtPoint.Text = m.mPoint



        txtName.Text = m.mName
        Dim year As String = m.mIC.Substring(0, 2)
        Dim month As String = m.mIC.Substring(2, 2)
        Dim date1 As String = m.mIC.Substring(4, 2)
        Dim year1 As String = ""
        If CInt(year <= 99) And CInt(year >= 50) Then
            year1 = "19"
        Else
            year1 = "20"
        End If
        Birthdate.Text = date1 & "/" & month & "/" & year1 & year
        Dim IC As String = m.mIC
        txtYMD.Text = IC.Substring(0, 6)

        txtNumberList.Text = IC.Substring(6, 2)

        txtNumber.Text = IC.Substring(8, 4)
        txtEmail.Text = m.mEmail
        Dim phone As String = m.mPhoneNo
        txtPhone1st.Text = phone.Substring(0, 3)
        Dim phoneLength As Integer = m.mPhoneNo.Length()
        If phoneLength = 10 Then
            txtPhone2nd.Text = phone.Substring(3, 7)
        Else
            txtPhone2nd.Text = phone.Substring(3, 8)
        End If

        RichTxtAddr.Text = m.mAddress
        memberHold = m
        db.SubmitChanges()

    End Sub

    Private Sub lblResetPass_Click(sender As Object, e As EventArgs) Handles lblResetPass.Click
        FrmMemberResetPassword.selectedID = selectedID
        FrmMemberResetPassword.Show()
        Me.Close()
    End Sub

    Private Sub picReset_Click(sender As Object, e As EventArgs) Handles picReset.Click
        FrmMemberResetPassword.selectedID = selectedID
        FrmMemberResetPassword.ShowDialog()
        Me.Close()
    End Sub

    Private Sub FrmMemberEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        Me.btnSave.BackColor = My.Settings.buttonColor
        Me.btnSave.Font = My.Settings.buttonFont
        Me.btnSave.ForeColor = My.Settings.buttonForeColor
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim ans As Single = MessageBox.Show("You are signing out of myBook apps on this device", "Confirm Sign Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If DialogResult.OK = ans Then
            FrmMemberHomepage.Close()
            Me.Close()


        End If
    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        FrmMemberHomepage.Show()
        Me.Close()
    End Sub


End Class