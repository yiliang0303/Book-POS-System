Public Class frmEditReturn
    Public qty As Integer = 0
    Private Sub frmEditReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

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
            picBook.Image = Image.FromFile("..\..\Resources\BookImage\" & txtBookID.Text.Trim & ".jpg")
        Catch ex As Exception
        End Try
        txtQty.Focus()
        txtRemark.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim ans As Long = MessageBox.Show("Confirm to Close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If txtRemark.Text <> "" Then
            frmOrder.dgvCart.Rows.Add(txtBookTitle.Text, txtQty.Text, txtRemark.Text, txtBookID.Text)
            For Each row As DataGridViewRow In frmReturn.dgvTransDetail.Rows
                Dim i As Integer = 0
                If CStr(row.Cells(0).Value) = txtBookID.Text Then
                    row.Cells(3).Value = CInt(frmReturn.dgvTrans2.Rows(i).Cells(3).Value) - CInt(txtQty.Text)
                End If
                i += 1
            Next
            Me.Close()
        Else
            MessageBox.Show("Write the Remark First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtRemark.Focus()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If CInt(txtQty.Text) < qty Then
            txtQty.Text = (CInt(txtQty.Text) + 1).ToString
        Else
            MessageBox.Show("Maximum" & CStr(qty), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnMinus_Click(sender As Object, e As EventArgs) Handles BtnMinus.Click
        If CInt(txtQty.Text) > 1 Then
            txtQty.Text = (CInt(txtQty.Text) - 1).ToString
        Else
            MessageBox.Show("Minumum 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        txtQty.Text = "1"
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        txtQty.Text = CStr(qty)
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        Try
            If CInt(txtQty.Text) >= 1 And CInt(txtQty.Text) <= qty Then

            Else
                MessageBox.Show("Min 1 and Max " & qty, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtQty.Text = "1"
                txtQty.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtQty.Text = "1"
            txtQty.Focus()
        End Try
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
            txtRemark.Focus()
        End If
    End Sub

    Private Sub txtRemark_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRemark.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnConfirm.PerformClick()
        End If
    End Sub
End Class