Public Class frmEditItem
    Public strProductid As String = ""
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim ans As Long = MessageBox.Show("Sure to Cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ans = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmEditItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        Me.btnAdd.BackColor = My.Settings.buttonColor
        Me.btnAdd.ForeColor = My.Settings.buttonForeColor

        Me.btnCancel.BackColor = My.Settings.buttonColor
        Me.btnCancel.ForeColor = My.Settings.buttonForeColor

        Me.btnMax.BackColor = My.Settings.buttonColor
        Me.btnMax.ForeColor = My.Settings.buttonForeColor

        Me.BtnMin.BackColor = My.Settings.buttonColor
        Me.BtnMin.ForeColor = My.Settings.buttonForeColor

        Me.btnAdd.BackColor = My.Settings.buttonColor
        Me.btnAdd.ForeColor = My.Settings.buttonForeColor

        Me.btnCancel.BackColor = My.Settings.buttonColor
        Me.btnCancel.ForeColor = My.Settings.buttonForeColor

        Me.btnMax.BackColor = My.Settings.buttonColor
        Me.btnMax.ForeColor = My.Settings.buttonForeColor

        Me.BtnMin.BackColor = My.Settings.buttonColor
        Me.BtnMin.ForeColor = My.Settings.buttonForeColor

        Me.btnAdd.BackColor = My.Settings.buttonColor
        Me.btnAdd.ForeColor = My.Settings.buttonForeColor

        Me.btnCancel.BackColor = My.Settings.buttonColor
        Me.btnCancel.ForeColor = My.Settings.buttonForeColor

        Me.btnMax.BackColor = My.Settings.buttonColor
        Me.btnMax.ForeColor = My.Settings.buttonForeColor

        Me.BtnMin.BackColor = My.Settings.buttonColor
        Me.BtnMin.ForeColor = My.Settings.buttonForeColor

        Me.btnConfirm.BackColor = My.Settings.buttonColor
        Me.btnConfirm.ForeColor = My.Settings.buttonForeColor

        Me.BtnMinus.BackColor = My.Settings.buttonColor
        Me.BtnMinus.ForeColor = My.Settings.buttonForeColor


        Try
            picBook.Image = Image.FromFile("..\..\Resources\BookImage\" & strProductid.Trim & ".jpg")
        Catch ex As Exception
        End Try

        Dim db As New DBDataContext()
        Dim b As book = db.books.FirstOrDefault(Function(o) o.bookID = strProductid)
        btnMax.Text = "Max(" & b.quantity.ToString() & ")"
        CalAmount()
        txtQty.Focus()
    End Sub

    Private Sub CalAmount()

        txtAmount.Text = "RM" & (CDbl(txtPrice.Text.Replace("RM", "")) * CInt(txtQty.Text)).ToString("f2")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim db As New DBDataContext()
        Dim b As book = db.books.FirstOrDefault(Function(o) o.bookID = strProductid)

        If CInt(txtQty.Text) < b.quantity Then
            txtQty.Text = (CInt(txtQty.Text) + 1).ToString
            CalAmount()
        Else
            MessageBox.Show("Maximum" & CStr(b.quantity), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnMinus_Click(sender As Object, e As EventArgs) Handles BtnMinus.Click
        If CInt(txtQty.Text) > 1 Then
            txtQty.Text = (CInt(txtQty.Text) - 1).ToString
            CalAmount()
        Else
            MessageBox.Show("Minumum 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        txtQty.Text = "1"
        CalAmount()
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        Dim db As New DBDataContext()
        Dim b As book = db.books.FirstOrDefault(Function(o) o.bookID = strProductid)

        txtQty.Text = CStr(b.quantity)
        CalAmount()
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        lblDigitOnly.Visible = False
        Dim db As New DBDataContext()
        Dim b As book = db.books.FirstOrDefault(Function(o) o.bookID = strProductid)
        If b IsNot Nothing Then
            Try
                If CInt(txtQty.Text) >= 1 And CInt(txtQty.Text) <= b.quantity Then
                    CalAmount()
                Else
                    MessageBox.Show("Min 1 and Max " & b.quantity, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtQty.Text = "1"
                    txtQty.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtQty.Text = "1"
                txtQty.Focus()
            End Try
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Or e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Exit Sub
        Else
            If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "" Then
                If Not Char.IsDigit(e.KeyChar) OrElse
                  Not "0123456789".Contains(e.KeyChar.ToString) Then
                    e.Handled = True
                    lblDigitOnly.Visible = True
                Else
                    lblDigitOnly.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub txtQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnConfirm.PerformClick()
        End If
    End Sub
End Class