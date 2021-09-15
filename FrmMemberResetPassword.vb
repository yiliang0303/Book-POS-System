Public Class FrmMemberResetPassword
    Dim orgPass As String = ""
    Public selectedID As String = ""
    Private Sub FrmMemberResetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        Me.btnCheck.BackColor = My.Settings.buttonColor
        Me.btnCheck.Font = My.Settings.buttonFont
        Me.btnCheck.ForeColor = My.Settings.buttonForeColor

        Me.btnReset.BackColor = My.Settings.buttonColor
        Me.btnReset.Font = My.Settings.buttonFont
        Me.btnReset.ForeColor = My.Settings.buttonForeColor

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If txtPassword.UseSystemPasswordChar = False Then
            txtPassword.UseSystemPasswordChar = True
            PictureBox1.Image = My.Resources.showHidePass
        Else
            txtPassword.UseSystemPasswordChar = False
            PictureBox1.Image = My.Resources.showPass
        End If
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

    Private Sub txtCurrentPass_TextChanged(sender As Object, e As EventArgs) Handles txtCurrentPass.TextChanged
        Dim current As String = txtCurrentPass.Text
        If current = "" Then
            lblCurrentPassFalse.ForeColor = Color.Red
            lblCurrentPassFalse.Text = "*Required"
        Else
            lblCurrentPassFalse.Text = ""
        End If
        'Dim db As New DbDataContext
        '    Dim m As Member = db.Members.FirstOrDefault(Function(o) o.memberID = selectedID)
        '    If m Is Nothing Then
        '        MessageBox.Show("Member not found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Me.Close()
        '        Return

        '    End If
        '    orgPass = m.mPassword

        'Dim pass As String = CStr(txtCurrentPass.Text)
        'If pass = "" Then
        '    lblCurrentPassFalse.Text = "*Required"
        '    lblCurrentPassFalse.ForeColor = Color.Red

        'End If
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
        ElseIf pass.Length < 8 Then
            lblPassFalse.Text = "At least 8 alphanumeric"
        ElseIf pass = orgPass Then
            lblPassFalse.Text = "Cannot same with current password"
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
                lblPassFalse.Text = "Weak Password"
                flag = False
            End If

        End If
        Return flag
    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim pass As Boolean = IsValidPass1Format()
        Dim pass2 As Boolean = IsValidConfirmPass()
        Try
            If pass = False Then
                txtPassword.Focus()
            ElseIf pass2 = False Then
                txtConfirmPass.Focus()


            Else
                Dim db As New DBDataContext
                Dim m As Member = db.Members.FirstOrDefault(Function(o) o.memberID = selectedID)
                If CheckPassword.Hash.VerifyHash(pass2, m.mPassword) = False Then

                    MessageBox.Show("Reset password sucessfully !", "Confirm Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Dim str As String = CheckPassword.Hash.ComputeHash(pass2, Nothing)
                    m.mPassword = str

                    db.SubmitChanges()

                Else

                    MessageBox.Show("Cannot same with current password")

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        Dim ans As Boolean = IsValidConfirmPass()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        Dim ans As Boolean = IsValidPass1Format()
    End Sub

    Private Sub PanelEdit_Paint(sender As Object, e As PaintEventArgs) Handles PanelEdit.Paint

    End Sub


    Private Sub lblEdit_DoubleClick(sender As Object, e As EventArgs) Handles lblEdit.DoubleClick
        FrmMemberEdit.Show()
        Me.Hide()
    End Sub

    Private Sub picEdit_Click(sender As Object, e As EventArgs) Handles picEdit.Click
        FrmMemberEdit.Show()
        Me.Hide()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim current As String = ""
        Dim db As New DBDataContext
        Dim m As Member = db.Members.FirstOrDefault(Function(o) o.memberID = selectedID)
        Try

            current = txtCurrentPass.Text

            If CheckPassword.Hash.VerifyHash(current, m.mPassword) = True Then
                    MessageBox.Show("Matched")
                    Label5.Visible = True
                    Label6.Visible = True
                    btnReset.Visible = True
                    txtPassword.Visible = True
                    txtConfirmPass.Visible = True
                    PictureBox2.Visible = True
                    lblPassFalse.Visible = True
                    lblConfirmPassFalse.Visible = True
                orgPass = current
            Else

                MessageBox.Show("Wrong Password")
                txtCurrentPass.Clear()
                txtCurrentPass.Focus()

            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub lblEdit_Click(sender As Object, e As EventArgs) Handles lblEdit.Click
        FrmMemberEdit.selectedID = selectedID
        FrmMemberEdit.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim ans As Single = MessageBox.Show("You are signing out of myBook apps on this device", "Confirm Sign Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If DialogResult.OK = ans Then
            Me.Close()


        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        FrmMemberHomepage.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmMemberHomepage.Show()
        Me.Close()
    End Sub
End Class