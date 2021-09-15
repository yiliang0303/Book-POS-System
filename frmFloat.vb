Public Class frmFloat
    Public blnAdmin As Boolean = False

    Private Sub txtRM100_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRM100.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnEditRM100.Text = "Edit" Then
                NextTextBox(txtRM100, txtRM50, lblRM50)
            Else
                btnEditRM100.PerformClick()
            End If
        End If
    End Sub

    Private Sub txtRM50_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRM50.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnEditRM50.Text = "Edit" Then
                NextTextBox(txtRM50, txtRM20, lblRM20)
            Else
                btnEditRM50.PerformClick()
            End If
        End If
    End Sub

    Private Sub txtRM20_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRM20.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnEditRM20.Text = "Edit" Then
                NextTextBox(txtRM20, txtRM10, lblRM10)
            Else
                btnEditRM20.PerformClick()
            End If
        End If
    End Sub

    Private Sub txtRM10_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRM10.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnEditRM10.Text = "Edit" Then
                NextTextBox(txtRM10, txtRM5, lblRM5)
            Else
                btnEditRM10.PerformClick()
            End If
        End If
    End Sub

    Private Sub txtRM5_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRM5.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnEditRM5.Text = "Edit" Then
                NextTextBox(txtRM5, txtRM1, lblRM1)
            Else
                btnEditRM5.PerformClick()
            End If
        End If
    End Sub

    Private Sub txtRM1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRM1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnEditRM1.Text = "Edit" Then
                NextTextBox(txtRM1, txt50sen, lbl50Sen)
            Else
                btnEditRM1.PerformClick()
            End If
        End If
    End Sub

    Private Sub txt50sen_KeyDown(sender As Object, e As KeyEventArgs) Handles txt50sen.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnEdit50sen.Text = "Edit" Then
                NextTextBox(txt50sen, txt20sen, lbl20sen)
            Else
                btnEdit50sen.PerformClick()
            End If
        End If
    End Sub

    Private Sub txt20sen_KeyDown(sender As Object, e As KeyEventArgs) Handles txt20sen.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnEdit20sen.Text = "Edit" Then
                NextTextBox(txt20sen, txt10sen, lbl10sen)
            Else
                btnEdit20sen.PerformClick()
            End If
        End If
    End Sub

    Private Sub txt10sen_KeyDown(sender As Object, e As KeyEventArgs) Handles txt10sen.KeyDown
        If e.KeyCode = Keys.Enter Then
            If e.KeyCode = Keys.Enter Then
                If btnEdit10sen.Text = "Edit" Then
                    NextTextBox(txt10sen, txt5sen, lbl5sen)
                Else
                    btnEdit10sen.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub txt5sen_KeyDown(sender As Object, e As KeyEventArgs) Handles txt5sen.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnEdit5sen.Text = "Edit" Then
                If txt5sen.Text = "" Then
                    txt5sen.Text = "0"
                End If
                CalTotal(CInt(txt5sen.Text), 0.05)
                txtTotal.Visible = True
                lblTotal.Visible = True
                btnVisible(True)
                txt5sen.Enabled = False
            Else
                btnEdit5sen.PerformClick()
            End If
            If lblInform.Text.Contains("Cash On Hand") Then
                ReportStock()
                btnConfirm.Visible = True
            End If
        End If
        btnConfirm.Focus()
    End Sub

    Private Sub ReportStock()
        lblFloat.Visible = True
        txtFloat.Visible = True

        lblTotalTran.Visible = True
        txtTransaction.Visible = True

        lblTotalFnT.Visible = True
        txtTotalFnT.Visible = True
        Dim dblTotalFnt As Double = CDbl(txtTransaction.Text.Replace("RM", "")) + CDbl(txtFloat.Text.Replace("RM", ""))

        txtTotalFnT.Text = "RM" & dblTotalFnt.ToString("f2")

        lblBalance.Visible = True
        lblBalanceRm.Visible = True

        Dim dblBalance As Double = CDbl(txtTotal.Text.Replace("RM", "")) - dblTotalFnt

        If dblBalance < 0 Then
            lblBalanceRm.Text = "-RM" & (dblBalance.ToString("f2") * -1)
        Else

            lblBalanceRm.Text = "RM" & dblBalance.ToString("f2")
        End If
        btnVisible(False)
    End Sub
    'text
    Private Sub NextTextBox(ByVal txtNow As TextBox, ByVal txtNew As TextBox, ByVal lblNext As Label)
        txtNow.Enabled = False
        txtNew.Visible = True
        lblNext.Visible = True
        Dim amount As String = ""
        If txtNow.Text = "" Then
            txtNow.Text = "0"
        End If
        amount = txtNow.Name.Replace("txt", "")
        If amount.Contains("RM") Then
            amount = amount.Replace("RM", "")
        Else
            amount = (CDbl(amount.Replace("sen", "")) / 100).ToString("f2")
        End If

        CalTotal(CInt(txtNow.Text), CDbl(amount))
        txtNew.Focus()
    End Sub
    'btnEdit
    Private Sub btnEditClick(ByVal btn As Button, ByVal txt As TextBox)
        If btn.Text = "Edit" Then
            txtTotal.Visible = False
            lblTotal.Visible = False
            btnVisible(False)
            btn.Visible = True
            txt.Enabled = True
            txt.Focus()

            Dim amount As String = ""
            amount = txt.Name.Replace("txt", "")
            If amount.Contains("RM") Then
                amount = amount.Replace("RM", "")
            Else
                amount = (CDbl(amount.Replace("sen", "")) / 100).ToString("f2")
            End If

            CalTotal(CInt(txt.Text), CDbl(amount) * -1)
            btn.Text = "Yes"
        Else
            If txt.Text = "" Then
                txt.Text = "0"
            End If
            Dim amount As String = ""
            amount = txt.Name.Replace("txt", "")
            If amount.Contains("RM") Then
                amount = amount.Replace("RM", "")
            Else
                amount = (CDbl(amount.Replace("sen", "")) / 100).ToString("f2")
            End If
            CalTotal(CInt(txt.Text), CDbl(amount))
            txt.Enabled = False
            btn.Text = "Edit"
            btnVisible(True)
            txtTotal.Visible = True
            lblTotal.Visible = True
        End If
    End Sub

    Private Sub reset(ByVal flag As Boolean)
        lblRM100.Visible = flag
        lblRM50.Visible = flag
        lblRM20.Visible = flag
        lblRM10.Visible = flag
        lblRM5.Visible = flag
        lblRM1.Visible = flag
        lbl50Sen.Visible = flag
        lbl20sen.Visible = flag
        lbl10sen.Visible = flag
        lbl5sen.Visible = flag

        txtRM100.Visible = flag
        txtRM50.Visible = flag
        txtRM20.Visible = flag
        txtRM10.Visible = flag
        txtRM5.Visible = flag
        txtRM1.Visible = flag
        txt50sen.Visible = flag
        txt20sen.Visible = flag
        txt10sen.Visible = flag
        txt5sen.Visible = flag

        lblTotal.Visible = flag
        txtTotal.Visible = flag
        lblFloat.Visible = flag
        txtFloat.Visible = flag
        lblTotalTran.Visible = flag
        txtTransaction.Visible = flag
        lblTotalFnT.Visible = flag
        txtTotalFnT.Visible = flag
        lblBalance.Visible = flag
        lblBalanceRm.Visible = flag
    End Sub

    Private Sub btnVisible(ByVal flag As Boolean)
        btnEditRM100.Visible = flag
        btnEditRM50.Visible = flag
        btnEditRM20.Visible = flag
        btnEditRM10.Visible = flag
        btnEditRM5.Visible = flag
        btnEditRM1.Visible = flag
        btnEdit50sen.Visible = flag
        btnEdit20sen.Visible = flag
        btnEdit10sen.Visible = flag
        btnEdit5sen.Visible = flag

        btnConfirm.Visible = flag
        btnReset.Visible = flag
    End Sub

    Private Sub txtEnabled(ByVal flag As Boolean)
        txtRM100.Enabled = flag
        txtRM50.Enabled = flag
        txtRM20.Enabled = flag
        txtRM10.Enabled = flag
        txtRM5.Enabled = flag
        txtRM1.Enabled = flag
        txt50sen.Enabled = flag
        txt20sen.Enabled = flag
        txt10sen.Enabled = flag
        txt5sen.Enabled = flag

        txtRM100.Clear()
        txtRM50.Clear()
        txtRM20.Clear()
        txtRM10.Clear()
        txtRM5.Clear()
        txtRM1.Clear()
        txt50sen.Clear()
        txt20sen.Clear()
        txt10sen.Clear()
        txt5sen.Clear()
    End Sub

    Private Sub CalTotal(ByVal intQty As Integer, ByVal dblAmount As Double)
        Dim dblTotal As Double = (intQty * dblAmount)
        txtTotal.Text = "RM" & (CDbl(txtTotal.Text.Replace("RM", "")) + dblTotal).ToString("f2")
    End Sub

    Private Sub MyText_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRM100.KeyPress, txtRM50.KeyPress, txtRM20.KeyPress,
        txtRM10.KeyPress, txtRM5.KeyPress, txtRM1.KeyPress, txt50sen.KeyPress, txt20sen.KeyPress, txt10sen.KeyPress, txt5sen.KeyPress
        Dim mytxt = DirectCast(sender, TextBox)
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

    Private Sub frmFloat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        Me.btnConfirm.BackColor = My.Settings.buttonColor
        Me.btnConfirm.ForeColor = My.Settings.buttonForeColor

        Me.btnEdit10sen.BackColor = My.Settings.buttonColor
        Me.btnEdit10sen.ForeColor = My.Settings.buttonForeColor

        Me.btnEdit20sen.BackColor = My.Settings.buttonColor
        Me.btnEdit20sen.ForeColor = My.Settings.buttonForeColor

        Me.btnEdit50sen.BackColor = My.Settings.buttonColor
        Me.btnEdit50sen.ForeColor = My.Settings.buttonForeColor

        Me.btnEdit5sen.BackColor = My.Settings.buttonColor
        Me.btnEdit5sen.ForeColor = My.Settings.buttonForeColor

        Me.btnEditRM1.BackColor = My.Settings.buttonColor
        Me.btnEditRM1.ForeColor = My.Settings.buttonForeColor

        Me.btnEditRM5.BackColor = My.Settings.buttonColor
        Me.btnEditRM5.ForeColor = My.Settings.buttonForeColor

        Me.btnEditRM10.BackColor = My.Settings.buttonColor
        Me.btnEditRM10.ForeColor = My.Settings.buttonForeColor

        Me.btnEditRM20.BackColor = My.Settings.buttonColor
        Me.btnEditRM20.ForeColor = My.Settings.buttonForeColor

        Me.btnEditRM50.BackColor = My.Settings.buttonColor
        Me.btnEditRM50.ForeColor = My.Settings.buttonForeColor

        Me.btnEditRM100.BackColor = My.Settings.buttonColor
        Me.btnEditRM100.ForeColor = My.Settings.buttonForeColor

        Me.btnReset.BackColor = My.Settings.buttonColor
        Me.btnReset.ForeColor = My.Settings.buttonForeColor


        txtTotal.Text = "0"
        reset(False)
        txtEnabled(True)
        btnVisible(False)
        lblRM100.Visible = True
        txtRM100.Visible = True
        txtRM100.Focus()
    End Sub

    Private Sub btnEditRM100_Click(sender As Object, e As EventArgs) Handles btnEditRM100.Click
        If btnEditRM100.Text.Contains("Edit") Then
            frmPOSAdminLogin.ShowDialog()
            If blnAdmin = False Then
                Exit Sub
            End If
        End If
        btnEditClick(btnEditRM100, txtRM100)
    End Sub

    Private Sub btnEditRM50_Click(sender As Object, e As EventArgs) Handles btnEditRM50.Click
        If btnEditRM50.Text.Contains("Edit") Then
            frmPOSAdminLogin.ShowDialog()
            If blnAdmin = False Then
                Exit Sub
            End If
        End If
        btnEditClick(btnEditRM50, txtRM50)
    End Sub

    Private Sub btnEditRM20_Click(sender As Object, e As EventArgs) Handles btnEditRM20.Click
        If btnEditRM20.Text.Contains("Edit") Then
            frmPOSAdminLogin.ShowDialog()
            If blnAdmin = False Then
                Exit Sub
            End If
        End If
        btnEditClick(btnEditRM20, txtRM20)
    End Sub

    Private Sub btnEditRM10_Click(sender As Object, e As EventArgs) Handles btnEditRM10.Click
        If btnEditRM10.Text.Contains("Edit") Then
            frmPOSAdminLogin.ShowDialog()
            If blnAdmin = False Then
                Exit Sub
            End If
        End If
        btnEditClick(btnEditRM10, txtRM10)
    End Sub

    Private Sub btnEditRM5_Click(sender As Object, e As EventArgs) Handles btnEditRM5.Click
        If btnEditRM5.Text.Contains("Edit") Then
            frmPOSAdminLogin.ShowDialog()
            If blnAdmin = False Then
                Exit Sub
            End If
        End If
        btnEditClick(btnEditRM5, txtRM5)
    End Sub

    Private Sub btnEditRM1_Click(sender As Object, e As EventArgs) Handles btnEditRM1.Click
        If btnEditRM1.Text.Contains("Edit") Then
            frmPOSAdminLogin.ShowDialog()
            If blnAdmin = False Then
                Exit Sub
            End If
        End If
        btnEditClick(btnEditRM1, txtRM1)
    End Sub

    Private Sub btnEdit50sen_Click(sender As Object, e As EventArgs) Handles btnEdit50sen.Click
        If btnEdit50sen.Text.Contains("Edit") Then
            frmPOSAdminLogin.ShowDialog()
            If blnAdmin = False Then
                Exit Sub
            End If
        End If
        btnEditClick(btnEdit50sen, txt50sen)
    End Sub

    Private Sub btnEdit20sen_Click(sender As Object, e As EventArgs) Handles btnEdit20sen.Click
        If btnEdit20sen.Text.Contains("Edit") Then
            frmPOSAdminLogin.ShowDialog()
            If blnAdmin = False Then
                Exit Sub
            End If
        End If
        btnEditClick(btnEdit20sen, txt20sen)
    End Sub

    Private Sub btnEdit10sen_Click(sender As Object, e As EventArgs) Handles btnEdit10sen.Click
        If btnEdit10sen.Text.Contains("Edit") Then
            frmPOSAdminLogin.ShowDialog()
            If blnAdmin = False Then
                Exit Sub
            End If
        End If
        btnEditClick(btnEdit10sen, txt10sen)
    End Sub

    Private Sub btnEdit5sen_Click(sender As Object, e As EventArgs) Handles btnEdit5sen.Click
        If btnEdit5sen.Text.Contains("Edit") Then
            frmPOSAdminLogin.ShowDialog()
            If blnAdmin = False Then
                Exit Sub
            End If
        End If
        btnEditClick(btnEdit5sen, txt5sen)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        frmPOSAdminLogin.ShowDialog()
        If blnAdmin = False Then
            Exit Sub
        End If
        Dim ans As Long = MessageBox.Show("Confirm to Reset?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbYes Then
            txtTotal.Text = "0"
            reset(False)
            btnVisible(False)
            lblRM100.Visible = True
            txtRM100.Visible = True
            txtEnabled(True)
            txtRM100.Focus()
        End If
    End Sub

    Private Sub showReport()
        Dim strReport As String = ""
        strReport = "FINO SDN BHD" & vbNewLine
        strReport &= "5,Lorong Fino 6," & vbNewLine
        strReport &= "Taman Four In One," & vbNewLine
        strReport &= "13400,Butterworth," & vbNewLine
        strReport &= "Pulau Pinang." & vbNewLine & vbNewLine & vbNewLine
        strReport &= "Staff ID:" & frmOrder.strStaffID & vbNewLine
        strReport &= "Staff Name:" & frmOrder.strStaffName & vbNewLine

        strReport &= "========Stock Report======" & vbNewLine

        strReport &= lblRM100.Text & txtRM100.Text & vbNewLine
        strReport &= lblRM50.Text & txtRM50.Text & vbNewLine
        strReport &= lblRM20.Text & txtRM20.Text & vbNewLine
        strReport &= lblRM10.Text & txtRM10.Text & vbNewLine
        strReport &= lblRM5.Text & txtRM5.Text & vbNewLine
        strReport &= lblRM1.Text & txtRM1.Text & vbNewLine
        strReport &= lbl50Sen.Text & txt50sen.Text & vbNewLine
        strReport &= lbl20sen.Text & txt20sen.Text & vbNewLine
        strReport &= lbl10sen.Text & txt10sen.Text & vbNewLine
        strReport &= lbl5sen.Text & txt5sen.Text & vbNewLine & vbNewLine

        strReport &= lblTotal.Text & txtTotal.Text & vbNewLine
        strReport &= lblFloat.Text & txtFloat.Text & vbNewLine
        strReport &= lblTotalTran.Text & txtTransaction.Text & vbNewLine
        strReport &= lblTotalFnT.Text & txtTotalFnT.Text & vbNewLine & vbNewLine

        strReport &= "============================" & vbNewLine
        strReport &= "Balance:" & lblBalanceRm.Text & vbNewLine
        strReport &= "============================" & vbNewLine
        frmPay.txtReceipt.Text = strReport
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If lblInform.Text.Contains("Cash") Then
            MessageBox.Show("Your Balance is" & lblBalanceRm.Text, "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Question)
            showReport()
            frmPay.btnQRCode.Visible = False
            frmPay.ShowDialog()
            Me.Close()
        Else
            Dim ans As Long = MessageBox.Show("Your Float is " & txtTotal.Text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ans = vbYes Then
                Me.Close()
                txtFloat.Text = txtTotal.Text
            End If
        End If
    End Sub

    Private Sub grpCal_Enter(sender As Object, e As EventArgs) Handles grpCal.Enter

    End Sub
End Class