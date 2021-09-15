Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class FrmMemberRegister
    Dim QRgenerateID As String = ""

    Dim intLastNum As Integer = 0



    Dim DrawingFont As New Font("Arial", 25)
    Dim CaptchaImage As New Bitmap(140, 40)
    Dim CaptchaGraf As Graphics = Graphics.FromImage(CaptchaImage)
    Dim Alphabet As String = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz"
    Dim CaptchaString, TickRandom As String
    Dim ProcessNumber As Integer


    Private Function IsValidUsernameFormat() As Boolean
        Dim flag As Boolean = False
        lblUserFalse.ForeColor = Color.Red
        If CStr(txtUser.Text) = "" Then
            lblUserFalse.Text = "*Required"
        ElseIf CStr(txtUser.Text).Length < 5 Then
            lblUserFalse.Text = "At least 5 Alphanumeric"
        Else
            lblUserFalse.Text = ""
            flag = True
        End If
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

    Private Function IsValidPass1Format() As Boolean
        Dim flag As Boolean = False

        Dim pass As String = CStr(txtPassword.Text)
        'Dim flag As Integer = -1
        lblPassFalse.ForeColor = Color.Red

        Dim upper As Integer = 0
        Dim lower As Integer = 0
        Dim num As Integer = 0
        Dim other As Integer
        If pass = "" Then
            lblPassFalse.Text = "*Required"
            lblPassFalse2.Visible = False
        ElseIf pass.Length < 8 Then
            lblPassFalse.Text = "At least 8 alphanumeric"
            lblPassFalse2.Visible = False
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

                lblPassFalse.Text = "Strong Password "
                lblPassFalse2.Visible = False
                flag = True

            Else
                lblPassFalse.ForeColor = Color.Red
                lblPassFalse.Text = "Weak Password"
                lblPassFalse2.Visible = True
                lblPassFalse2.Text = " (SPECIAL CHARACTER)"

                flag = False
            End If

        End If
        Return flag
    End Function

    Private Function IsDuplicateIC() As Boolean
        Dim flag As Boolean = True


        Return flag
    End Function
    Private Function IsValidBirthDateFormat() As Boolean
        Dim flag As Boolean = False
        Dim today = DateTime.Now.ToShortDateString
        Dim selectedDate As String = CStr(Birthdate.Text) '18/12/2019
        Dim currentYear As Integer = Date.Today.Year
        Dim DigitYear As Integer = Birthdate.Value.Year.ToString().Substring(2, 2) 'IC
        Dim selectedYear As Integer = Birthdate.Value.Year 'compare
        Dim selectedMonth As Integer = Birthdate.Value.Month
        Dim selectedDay As Integer = Birthdate.Value.Day

        lblBirthFalse.ForeColor = Color.Red
        If selectedDate = today Then
            lblBirthFalse.Text = "*Cannot today date!"
        ElseIf currentYear - selectedYear > 120 Then
            lblBirthFalse.Text = "*invalid age"

        ElseIf currentYear - selectedYear < 12 Then
            lblBirthFalse.Text = "*invalid age"

        Else

            MaskedTxtNumberList.Enabled = True
            MaskedTxtNumber.Enabled = True
            lblBirthFalse.Text = ""
            Dim str As String = ""

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
        Dim code As String = CStr(MaskedTxtNumberList.Text)

        Dim length As Integer = code.Length
        Dim code2 As String = CStr(MaskedTxtNumber.Text)
        Dim length2 As Integer = code2.Length
        lblNRICFalse.ForeColor = Color.Red
        'Dim numList As Integer = CInt(MaskedTxtNumberList.Text)

        If code = "" Or CStr(MaskedTxtNumber.Text) = "" Then
            lblNRICFalse.Text = "*Required"
            'ElseIf reader.HasRows Then
            '    lblNRICFalse.ForeColor = Color.Red
            '    lblNRICFalse.Text = "No duplicate"

        ElseIf length < 2 Then
            lblNRICFalse.Text = "*Required state number"

        ElseIf length2 < 4 Then
            lblNRICFalse.Text = "*Required last 4 digit"
        Else
            lblNRICFalse.Text = ""
            flag = True

        End If
        Return flag
        'con.Close()
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
            lblContactFalse.ForeColor = Color.Red
        Else
            lblContactFalse.Text = "in " & txtPhone2nd.MaxLength & " digits"
        End If
        Return flag
    End Function

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
    Private Function IsValidPostCodeFormat() As Boolean
        Dim flag As Boolean = False

        lblPostCodeFalse.ForeColor = Color.Red
        Dim code As String = CStr(MaskedTxtPostcode.Text)
        Dim length As Integer = code.Length
        If code Is "" Then
            lblPostCodeFalse.Text = "*Required"
        ElseIf length < 5 Then
            lblPostCodeFalse.Text = "Not enough"
        Else

            lblPostCodeFalse.Text = ""
            flag = True
        End If
        Return flag
    End Function

    Private Sub Birthdate_ValueChanged(sender As Object, e As EventArgs) Handles Birthdate.ValueChanged
        Dim ans As Boolean = IsValidBirthDateFormat()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Dim ans As Boolean = IsValidNameFormat()
    End Sub


    Private Function IsValidConfirmPass() As Boolean
        Dim flag As Boolean = False
        lblConfirmPassFalse.ForeColor = Color.Red
        If Not txtPassword.Text = txtConfirmPass.Text Then
            lblConfirmPassFalse.Text = "Not match"
        Else
            lblConfirmPassFalse.Text = ""
            flag = True
        End If
        Return flag
    End Function
    Private Sub txtConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        Dim ans As Boolean = IsValidConfirmPass()
    End Sub
    Private Function IsValidStateFormat() As Boolean
        Dim flag As Boolean = False
        lblStateFalse.ForeColor = Color.Red
        If cboState.SelectedIndex > -1 Then
            lblStateFalse.Text = ""
            flag = True
        Else
            lblStateFalse.Text = "*Required"
        End If
        Return flag
    End Function




    Private Sub FrmMemberRegister_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        lblContactFalse.Text = ""

    End Sub

    Private Sub RichTxtAddr_TextChanged(sender As Object, e As EventArgs) Handles RichTxtAddr.TextChanged
        Dim ans As Boolean = IsValidAddrFormat()
    End Sub

    Private Sub MaskedTxtPostcode_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTxtPostcode.MaskInputRejected
        Dim ans As Boolean = IsValidPostCodeFormat()
    End Sub

    Private Sub cboState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboState.SelectedIndexChanged
        Dim ans As Boolean = IsValidStateFormat()
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged
        Dim ans As Boolean = IsValidUsernameFormat()
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        Dim ans As Boolean = IsValidEmailFormat()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        Dim ans As Boolean = IsValidPass1Format()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If txtPassword.UseSystemPasswordChar = False Then
            txtPassword.UseSystemPasswordChar = True
            PictureBox2.Image = My.Resources.showHidePass
        Else
            txtPassword.UseSystemPasswordChar = False
            PictureBox2.Image = My.Resources.showPass
        End If
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtName.Clear()
        Birthdate.Text = Now.ToShortDateString
        txtYMD.Clear()
        txtYMD.Enabled = False
        MaskedTxtNumberList.Clear()
        MaskedTxtNumberList.Enabled = False
        MaskedTxtNumber.Clear()
        MaskedTxtNumber.Enabled = False
        txtPhone1st.Clear()
        txtPhone2nd.Clear()
        RichTxtAddr.Clear()
        MaskedTxtPostcode.Clear()
        cboState.Text = ""

        txtUser.Clear()
        txtEmail.Clear()
        txtPassword.Clear()
        txtConfirmPass.Clear()


    End Sub



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

        Me.Hide()
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

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim name As Boolean = IsValidNameFormat()
        Dim date1 As Boolean = IsValidBirthDateFormat()
        Dim NRIC As Boolean = IsValidICFormat()
        Dim addr As Boolean = IsValidAddrFormat()
        Dim phone1st As Boolean = IsValidPhone1st()
        Dim phone2nd As Boolean = IsValidPhone2nd()
        Dim postcode As Boolean = IsValidPostCodeFormat()
        Dim state As Boolean = IsValidStateFormat()
        Dim user As Boolean = IsValidUsernameFormat()
        Dim email As Boolean = IsValidEmailFormat()
        Dim pass1 As Boolean = IsValidPass1Format()
        Dim pass2 As Boolean = IsValidConfirmPass()



        If name = False Or date1 = False Or NRIC = False Or phone1st = False Or phone2nd = False Or postcode = False Or user = False Or email = False Or pass1 = False Or pass2 = False Then
            MessageBox.Show("Register Failed")
            '    txtName.Focus()
            '    txtName.Clear()
            'ElseIf date1 = False Then
            '    Birthdate.Focus()

            'ElseIf NRIC = False Then
            '    MaskedTxtNumberList.Focus()
            '    MaskedTxtNumber.Focus()
            'ElseIf phone1st = False Then
            '    txtPhone1st.Focus()
            '    txtPhone1st.Clear()
            'ElseIf phone2nd = False Then
            '    txtPhone2nd.Focus()
            '    txtPhone2nd.Clear()
            'ElseIf addr = False Then
            '    RichTxtAddr.Focus()
            '    RichTxtAddr.Clear()
            'ElseIf postcode = False Then
            '    MaskedTxtPostcode.Focus()
            '    MaskedTxtPostcode.Clear()
            'ElseIf state = False Then
            '    cboState.Focus()
            'ElseIf user = False Then
            '    txtUser.Focus()
            '    txtUser.Clear()
            'ElseIf email = False Then
            '    txtEmail.Focus()
            '    txtEmail.Clear()
            'ElseIf pass1 = False Then
            '    txtPassword.Focus()
            '    txtPassword.Clear()
            'ElseIf pass2 = False Then
            '    txtConfirmPass.Focus()
            '    txtConfirmPass.Clear()

        Else
            Dim strUser As String = ""
            Dim strEmail As String = ""
            Dim strIC As String = ""
            Dim db As New DBDataContext

            'Try
            strUser = txtUser.Text
                strEmail = txtEmail.Text
                strIC = txtYMD.Text & MaskedTxtNumberList.Text & MaskedTxtNumber.Text

                Dim m As Member = db.Members.FirstOrDefault(Function(o) o.mUsername = strUser Or o.mEmail = strEmail Or o.mIC = strIC)

            If m Is Nothing Then
                Dim db1 As New DBDataContext
                Dim member As New Member

                BindData()
                Dim lastID As String = CStr(dgv.Rows((dgv.Rows.Count - 2)).Cells(0).Value)
                lastID = Microsoft.VisualBasic.Right(lastID, 5)

                Dim id As String = "M" & Date.Today.ToString("yy") & (lastID + 1).ToString("00000")
                createQRcode(id)
                member.memberID = id

                member.mName = txtName.Text
                member.mIC = txtYMD.Text & MaskedTxtNumberList.Text & MaskedTxtNumber.Text
                member.mPhoneNo = txtPhone1st.Text & txtPhone2nd.Text
                member.mAddress = RichTxtAddr.Text & "," & MaskedTxtPostcode.Text & " " & cboState.Text & " " & "Malaysia"
                member.mUsername = txtUser.Text
                member.mLevel = "Normal"
                member.mPoint = 0
                member.mRate = 0.0
                member.mEmail = txtEmail.Text

                Dim str As String = CheckPassword.Hash.ComputeHash(txtConfirmPass.Text, Nothing)
                member.mPassword = str

                db.Members.InsertOnSubmit(member)
                db.SubmitChanges()
                BindData()

                MessageBox.Show("Register successfully")
                frmOrder.strMemberID = member.memberID
                Me.Hide()
                frmOrder.dgvCart.Rows.Add("Member Card", "1", "20", "memberCard")
            ElseIf m.mUsername.Equals(strUser) Then
                MessageBox.Show("Duplicated Username")
            ElseIf m.mIC.Equals(strIC) Then
                MessageBox.Show("Duplicated IC")

            ElseIf m.mEmail.Equals(strEmail) Then
                MessageBox.Show("Duplicated Email")
            Else

            End If

            'Catch ex As Exception
            'MessageBox.Show(ex.Message)
            'End Try

        End If


    End Sub

    Private Sub BindData()
        Dim db As New DBDataContext
        Dim rs1 = From m In db.Members
                  Select m
        dgv.DataSource = rs1
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

    Private Sub MaskedtxtNumberList_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub txtPhone1st_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone1st.KeyPress
        If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            If Not Char.IsDigit(e.KeyChar) OrElse
              Not "0123456789".Contains(e.KeyChar.ToString) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MaskedtxtNumberList_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaskedTxtNumberList_MaskInputRejected_1(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub FrmMemberRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        Me.btnRegister.BackColor = My.Settings.buttonColor
        Me.btnRegister.Font = My.Settings.buttonFont
        Me.btnRegister.ForeColor = My.Settings.buttonForeColor

        Me.btnReset.BackColor = My.Settings.buttonColor
        Me.btnReset.Font = My.Settings.buttonFont
        Me.btnReset.ForeColor = My.Settings.buttonForeColor

    End Sub

    Private Sub MaskedtxtNumberList_TextChanged(sender As Object, e As EventArgs)
        Dim result As Boolean = IsValidICFormat()
    End Sub


    Private Sub createQRcode(ByVal primaryKey As String)
        Dim gen As New QRCoder.QRCodeGenerator
        Dim data = gen.CreateQrCode(primaryKey, QRCoder.QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCoder.QRCode(data)
        pic.Image = code.GetGraphic(6)
        SaveImageCopy(primaryKey, pic.Image)
    End Sub

    Private Sub MaskedTxtNumberList_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub MaskedTxtNumberList_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaskedTxtNumberList_MaskInputRejected_2(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTxtNumberList.MaskInputRejected

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmMemberLogin.Show()
        Me.Close()
    End Sub

    Private Sub SaveImageCopy(filename As String, image As Image)

        Dim path As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\MemberQRcode"), filename & ".jpg")
        Dim dest As New Bitmap(image.Width, image.Height)
        Dim gfx As Graphics = Graphics.FromImage(dest)
        gfx.DrawImageUnscaled(image, Point.Empty)
        gfx.Dispose()
        dest.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg)
        dest.Dispose()
    End Sub
End Class