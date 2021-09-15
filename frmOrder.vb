Imports System.IO
Imports MessagingToolkit.QRCode.Codec
Public Class frmOrder
    Private Const TAX_RATE As Double = 0.06
    Public blnRecallBill As Boolean = False
    Public strRecallID As String = ""
    Public strStaffID As String = "20S00003"
    Public strStaffName As String = "Self POS System"
    Public strMemberID As String = ""
    Public strAdmin As String = ""
    Public DbltotalAMount As Double = 0
    Public blnAdmin As Boolean = False

    'bind data
    Private Sub BindData()
        Dim search As String = txtSearch.Text

        Dim db As New DBDataContext()
        If cboSearchType.SelectedIndex = 0 Then
            Dim rs = From b In db.books
                     Where b.bookTitle.Contains(search) And b.bookTitle IsNot "Member Card" And b.status = True
                     Select b
            dgv.DataSource = rs
        ElseIf cboSearchType.SelectedIndex = 1 Then
            Dim rs = From b In db.books
                     Where b.bookID.Contains(search) And b.bookTitle IsNot "Member Card" And b.status = True
                     Select b
            dgv.DataSource = rs
        ElseIf cboSearchType.SelectedIndex = 2 Then
            Dim rs = From b In db.books
                     Where b.category.categoryName.Contains(cboCategories.Text) And b.bookTitle IsNot "Member Card" And b.status = True
                     Select b
            dgv.DataSource = rs
        End If
    End Sub

    Private Sub BindDataTran()
        Dim db As New DBDataContext()

        Dim rs = From t In db.Transactions
                 Order By t.Transaction_ID
                 Select t

        dgvTrans.DataSource = rs
    End Sub

    Private Sub BindDataTD()
        Dim db As New DBDataContext()

        Dim rs = From td In db.TransactionDetails
                 Select td

        dgvDetail.DataSource = rs
    End Sub

    Private Sub BindDataReturn()
        Dim db As New DBDataContext()

        Dim rs = From br In db.BookReturns
                 Select br

        dgvReturnBook.DataSource = rs
    End Sub
    'dynamic
    Private Sub DynamicButton()
        Dim totalwidth As Integer = 0
        Dim x As Integer = 0
        Dim y As Integer = 0
        flp.Controls.Clear()

        For i = 0 To dgv.Rows.Count - 2
            'Panel
            Dim pnl As New Panel
            pnl.Name = "txt" & i
            pnl.Enabled = True
            pnl.Dock = DockStyle.Top
            pnl.Visible = True
            flp.Controls.Add(pnl)
            pnl.Width = 180
            pnl.Height = 200

            'lblPrice
            Dim lblPrice As New Label
            Dim dblPrice As Double = CDbl(dgv.Rows(i).Cells(2).Value)
            lblPrice.Text = "RM " & dblPrice.ToString("f2")
            lblPrice.Name = "lblPrice" & i
            lblPrice.Dock = DockStyle.Top
            lblPrice.Visible = True
            lblPrice.BorderStyle = BorderStyle.Fixed3D
            lblPrice.Anchor = AnchorStyles.Left + AnchorStyles.Top
            pnl.Controls.Add(lblPrice)

            If CInt(dgv.Rows(i).Cells(3).Value) = 0 Then
                pnl.Enabled = False
                Dim lblSoldOut As New Label
                lblSoldOut.Text = "(Sold Out)"
                lblSoldOut.Name = "lblSoldOut" & i
                lblSoldOut.Dock = DockStyle.None
                lblSoldOut.Visible = True
                lblSoldOut.Anchor = AnchorStyles.Left + AnchorStyles.Top
                lblSoldOut.BorderStyle = BorderStyle.Fixed3D
                pnl.Controls.Add(lblSoldOut)
            End If

            'LabelName
            Dim lbl As New Label
            Dim strName As String = CStr(dgv.Rows(i).Cells(1).Value)
            lbl.Text = strName
            lbl.Name = "lbl" & i
            lbl.Dock = DockStyle.Top
            lbl.Visible = True
            lbl.Anchor = AnchorStyles.Left + AnchorStyles.Top
            pnl.Controls.Add(lbl)

            'Picture
            Dim pb As New PictureBox
            AddHandler pb.Click, AddressOf ClickPicture
            pb.Name = i
            pb.Width = 100 'or whatever
            pb.Height = 100
            pb.Visible = True
            pb.Image = Image.FromFile("..\..\Resources\BookImage\" & CStr(dgv.Rows(i).Cells(0).Value).Trim & ".jpg")
            pnl.Controls.Add(pb)
            pb.SizeMode = PictureBoxSizeMode.StretchImage
            pb.Dock = DockStyle.Top
        Next
    End Sub
    'Add to Cart
    Private Sub ClickPicture(ByVal sendr As Object, ByVal e As EventArgs)
        If strStaffName = "Self POS System" Then
            Exit Sub
        End If
        Dim pb As New PictureBox
        pb = DirectCast(sendr, PictureBox)
        Dim strID As String = CStr(dgv.Rows(pb.Name).Cells(0).Value)
        Dim strName As String = CStr(dgv.Rows(pb.Name).Cells(1).Value)
        Dim dblPrice As Double = CDbl(dgv.Rows(pb.Name).Cells(2).Value)
        Dim intQtyLeft As Integer = CInt(dgv.Rows(pb.Name).Cells(3).Value)

        For Each row As DataGridViewRow In dgvCart.Rows
            If row.Cells(0).Value = strName Then
                row.Cells(1).Value = CInt(row.Cells(1).Value) + 1
                row.Cells(2).Value = (CInt(row.Cells(1).Value) * dblPrice).ToString("f2")
                SubmitQuantityLeft(strID, 1)
                ShowTotal()
                Exit Sub
            End If
        Next

        dgvCart.Rows.Add(strName, "1", dblPrice.ToString("f2"), strID)

        SubmitQuantityLeft(strID, 1)
        ShowTotal()
    End Sub

    Private Sub SubmitQuantityLeft(ByVal booKID As String, ByVal bookQty As Integer)
        Dim db As New DBDataContext()
        Dim b As book = db.books.FirstOrDefault(Function(o) o.bookID = booKID)
        b.quantity -= bookQty
        db.SubmitChanges()
        BindData()
        If b.quantity = 0 Then
            flp.Controls.Clear()
            DynamicButton()
        End If
    End Sub

    Private Sub dgvclmbtnStyle()
        dgvclmbtnRemove.FlatStyle = FlatStyle.Popup
        dgvclmbtnRemove.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvclmbtnRemove.DefaultCellStyle.ForeColor = Color.Maroon
    End Sub

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        Me.btnHoldBill.BackColor = My.Settings.buttonColor
        Me.btnHoldBill.ForeColor = My.Settings.buttonForeColor

        Me.btnCancel.BackColor = My.Settings.buttonColor
        Me.btnCancel.ForeColor = My.Settings.buttonForeColor


        Me.btnLogOut.BackColor = My.Settings.buttonColor
        Me.btnLogOut.ForeColor = My.Settings.buttonForeColor

        Me.btnMember.BackColor = My.Settings.buttonColor
        Me.btnMember.ForeColor = My.Settings.buttonForeColor


        Me.btnPayRtn.BackColor = My.Settings.buttonColor
        Me.btnPayRtn.ForeColor = My.Settings.buttonForeColor

        Me.btnRecallBill.BackColor = My.Settings.buttonColor
        Me.btnRecallBill.ForeColor = My.Settings.buttonForeColor


        Me.btnReceipt.BackColor = My.Settings.buttonColor
        Me.btnReceipt.ForeColor = My.Settings.buttonForeColor

        Me.btnReturn.BackColor = My.Settings.buttonColor
        Me.btnReturn.ForeColor = My.Settings.buttonForeColor

        Me.btnUpload.BackColor = My.Settings.buttonColor
        Me.btnUpload.ForeColor = My.Settings.buttonForeColor


        Me.WindowState = FormWindowState.Maximized
        frmFloat.ShowDialog()
        cboSearchType.SelectedIndex = 0
        cboPaymentMethod.SelectedIndex = 0
        Timer1.Enabled = True
        BindData()
        BindDataCat()
        BindDataTran()
        'intFirstTranIndex = (dgvTrans.Rows.Count - 1)
        dgvclmbtnStyle()
        lblStaffID.Text = strStaffID
        lblStaffName.Text = strStaffName

        If strStaffName = "Self POS System" Then
            btnHoldBill.Visible = False
            btnRecallBill.Visible = False
            btnReturn.Visible = False
        End If
    End Sub
    'calculate
    Private Function CalSubTotal() As Double
        Dim dblSubTotal As Double = 0
        Dim i As Integer = 0

        For i = 0 To dgvCart.Rows.Count - 1
            dblSubTotal = dblSubTotal + CDbl(dgvCart.Rows(i).Cells(2).Value)
        Next

        Return dblSubTotal
    End Function

    Private Function CalTax() As Double
        Dim dblTax As Double = 0
        dblTax = CalSubTotal() * TAX_RATE
        Return dblTax
    End Function

    Private Function CalMemberDiscount() As Double
        Dim dblMemberDiscount As Double = 0
        If strMemberID = "" Then
            Return dblMemberDiscount
        End If
        Dim dblRate As Double = 0
        Dim db As New DBDataContext()
        Dim m As Member = db.Members.FirstOrDefault(Function(o) o.memberID = strMemberID)
        dblRate = m.mRate
        dblMemberDiscount = CalSubTotal() * dblRate

        Return dblMemberDiscount
    End Function

    Private Function CalRndAdj() As Double
        Dim dblRndAdj As Double = 0
        Dim dblLastDecimal As Integer = ((CalSubTotal() + CalTax() - CalMemberDiscount()) * 100) Mod 10
        If dblLastDecimal = 3 Or dblLastDecimal = 4 Then
            dblRndAdj = 5 - dblLastDecimal
        ElseIf dblLastDecimal = 8 Or dblLastDecimal = 9 Then
            dblRndAdj = 10 - dblLastDecimal
        ElseIf dblLastDecimal = 1 Or dblLastDecimal = 2 Then
            dblRndAdj -= dblLastDecimal
        ElseIf dblLastDecimal = 6 Or dblLastDecimal = 7 Then
            dblRndAdj -= dblLastDecimal - 5
        End If

        Return dblRndAdj / 100
    End Function

    Private Function CalTotal() As Double
        Dim dblTotal As Double = 0
        dblTotal = CalSubTotal() + CalTax() - CalMemberDiscount() + CalRndAdj()
        Return dblTotal
    End Function

    Private Sub ShowTotal()
        If dgvCart.Rows.Count > 0 Then
            txtSubTotal.Text = "RM" & CalSubTotal().ToString（"f2"）
            txtTax.Text = "RM" & CalTax().ToString（"f2"）
            txtMemberDisc.Text = "RM" & CalMemberDiscount().ToString（"f2"）
            txtRndAdj.Text = "RM" & CalRndAdj().ToString（"f2"）
            txtTotal.Text = "RM" & CalTotal().ToString（"f2"）
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        flp.Controls.Clear()
        BindData()
        DynamicButton()
    End Sub
    'SaveTran
    Private Sub SaveData(ByVal strStatus As String, ByVal strPaymentMethod As String)
        Dim db As New DBDataContext()
        Dim count As Integer = dgvCart.Rows.Count - 1

        If blnRecallBill = True Then
            Dim t As Transaction = db.Transactions.FirstOrDefault(Function(o) o.Transaction_ID = strRecallID)
            t.Date = DateTime.Today.ToShortDateString & " " & DateTime.Now.ToLongTimeString
            db.SubmitChanges()
            t.Status = strStatus
            'td
            BindDataTD()
            For i As Integer = 0 To count
                Dim td As New TransactionDetail
                td.qty = CDbl(dgvCart.Rows(i).Cells(1).Value)
                td.TransactionDetail_ID = strRecallID & (i + 1).ToString("00")
                td.Transaction_ID = strRecallID
                td.BookID = CStr(dgvCart.Rows(i).Cells(3).Value)
                db.TransactionDetails.InsertOnSubmit(td)
                db.SubmitChanges()
            Next
            BindDataTD()
            blnRecallBill = False
        Else
            BindDataTran()
            Dim trans As New Transaction
            Dim intLastNum As Integer = 0

            Try
                Dim strTest As String = CStr(dgvTrans.Rows(dgvTrans.Rows.Count - 2).Cells(0).Value)
                If strTest.Contains(Date.Today.ToString("yyMMdd")) Then
                    strTest = Microsoft.VisualBasic.Right(strTest, 4)
                    intLastNum = CInt(strTest)
                Else
                    intLastNum = 0
                End If
            Catch ex As Exception
                intLastNum = 0
            End Try
            trans.Transaction_ID = "T" & Date.Today.ToString("yyMMdd") & (intLastNum + 1).ToString("0000")

            trans.Date = DateTime.Today.ToShortDateString & " " & DateTime.Now.ToLongTimeString
            trans.Status = strStatus
            trans.PaymentMethod = strPaymentMethod
            trans.StaffID = strStaffID
            db.Transactions.InsertOnSubmit(trans)
            db.SubmitChanges()

            'td
            BindDataTD()
            For i As Integer = 0 To count
                Dim td As New TransactionDetail
                td.qty = CDbl(dgvCart.Rows(i).Cells(1).Value)
                td.TransactionDetail_ID = trans.Transaction_ID & (i + 1).ToString("00")
                td.Transaction_ID = trans.Transaction_ID
                td.BookID = CStr(dgvCart.Rows(i).Cells(3).Value)
                db.TransactionDetails.InsertOnSubmit(td)
                db.SubmitChanges()
            Next
            BindDataTD()
            dgvDetail.Refresh()
            blnRecallBill = False
        End If
    End Sub

    Private Sub saveDataReturn()
        Dim db As New DBDataContext()
        Dim count As Integer = dgvCart.Rows.Count - 1
        BindDataReturn()
        Dim intLastNum As Integer = 0
        Try
            Dim strTest As String = CStr(dgvReturnBook.Rows(dgvReturnBook.Rows.Count - 2).Cells(0).Value)
            strTest = Microsoft.VisualBasic.Right(strTest, 4)
            intLastNum = CInt(strTest)
        Catch ex As Exception
            intLastNum = 0
        End Try
        'br
        BindDataReturn()
        For i As Integer = 0 To count
            Dim br As New BookReturn
            br.Return_ID = "R" & Date.Today.ToString("yyMMdd") & (intLastNum + 1).ToString("0000")
            intLastNum += 1
            br.Transaction_ID = frmEditReturn.txtTransaction.Text
            br.Date = DateTime.Today.ToShortDateString & " " & DateTime.Now.ToLongTimeString
            br.Qty = CInt(dgvCart.Rows(i).Cells(1).Value)
            br.remark = CStr(dgvCart.Rows(i).Cells(2).Value)
            br.bookID = CStr(dgvCart.Rows(i).Cells(3).Value)
            br.StaffID = strStaffID

            db.BookReturns.InsertOnSubmit(br)
            db.SubmitChanges()
        Next
        BindDataReturn()
        dgvReturnBook.Refresh()
    End Sub

    Private Sub btnHoldBill_Click(sender As Object, e As EventArgs) Handles btnHoldBill.Click
        For Each row As DataGridViewRow In dgvCart.Rows
            If row.Cells(0).Value = "Member Card" Then
                MessageBox.Show("Member Card Cannot Be Hold Only Cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next
        If dgvCart.Rows.Count() > 0 Then
            SaveData("Hold", "Hold")
            Clear()
        Else
            MessageBox.Show("No Bill Can Be Hold", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRecallBill_Click(sender As Object, e As EventArgs) Handles btnRecallBill.Click
        If dgvCart.Rows.Count() > 0 Then
            MessageBox.Show("Hold Bill Or Complete It Before Recall Bill", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            frmHoldBill.ShowDialog()
            ShowTotal()
        End If
    End Sub

    Private Sub Clear()
        dgvCart.Rows.Clear()
        dgvCart.Refresh()
        txtSubTotal.Clear()
        txtMemberDisc.Clear()
        txtRndAdj.Clear()
        txtTax.Clear()
        txtTotal.Clear()
        strMemberID = ""
        btnMember.Text = "&Member"
        txtCash.Clear()
        txtCash.Visible = "False"
        lblCash.Visible = "False"
        cboPaymentMethod.Visible = "False"
    End Sub

    Private Sub EnableControl(ByVal flag As Boolean)
        txtSearch.Enabled = flag
        btnHoldBill.Enabled = flag
        btnRecallBill.Enabled = flag
        btnReturn.Enabled = flag
        btnMember.Enabled = flag
        btnLogOut.Enabled = flag
        cboSearchType.Enabled = flag
        flp.Enabled = flag
        btnUpload.Enabled = flag
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If strStaffName <> "Self POS System" Then
            frmPOSAdminLogin.ShowDialog()
            If blnAdmin = False Then
                Exit Sub
            End If
        End If
        If btnCancel.Text.Contains("Transaction") Then
            If btnMember.Text = "&Member Detail" And dgvCart.Rows.Count() = 0 Then
                btnMember.Text = "&Member"
                strMemberID = ""
                MessageBox.Show("Already Log Out For Member.", "Log Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If dgvCart.Rows.Count() > 0 Then
                    Dim ans As Long = 0
                    ans = MessageBox.Show("Sure To Cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If ans = vbYes Then

                        For i As Integer = 0 To dgvCart.Rows.Count() - 1
                            Dim bookID As String = CStr(dgvCart.Rows(i).Cells(3).Value)
                            If bookID <> "memberCard" Then
                                Dim bookQty As Integer = CInt(dgvCart.Rows(i).Cells(1).Value)
                                SubmitQuantityLeft(bookID, bookQty * -1)
                            Else
                                Dim db As New DBDataContext()
                                Dim m As Member = db.Members.FirstOrDefault(Function(o) o.memberID = strMemberID)
                                db.Members.DeleteOnSubmit(m)
                                db.SubmitChanges()
                                File.Delete(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\MemberQRcode\" & m.memberID & ".jpg"))
                            End If
                        Next

                        SaveData("Cancel", "Cancel")
                        flp.Controls.Clear()
                        DynamicButton()
                        blnRecallBill = False
                        Clear()
                    End If
                Else
                    MessageBox.Show("No Thing can Cancel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        ElseIf btnCancel.Text.Contains("Pay") Then
            Dim ans As Long = 0
            ans = MessageBox.Show("Sure To Cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ans = vbYes Then
                Dim flag As Boolean = True
                EnableControl(flag)
                btnPayRtn.Text = "&Pay"
                btnCancel.Text = "Cancel Transaction"
                txtCash.Visible = False
                lblCash.Visible = False
                cboPaymentMethod.Visible = False
            End If
        Else
            Dim ans As Long = 0
            ans = MessageBox.Show("Sure To Cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ans = vbYes Then
                Dim flag As Boolean = True
                EnableControl(flag)
                btnPayRtn.Text = "&Pay"
                btnCancel.Text = "Cancel Transaction"
                dgvCart.Columns(2).HeaderText = "Amount"
                Clear()
            End If

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = DateTime.Today.ToShortDateString & " " & DateTime.Now.ToLongTimeString
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If dgvCart.Rows.Count() > 0 Or btnCancel.Text.Contains("Return") Then
            If btnCancel.Text.Contains("Return") Then
                frmReturn.ShowDialog()
            Else
                MessageBox.Show("Hold Bill Or Complete It Before Return", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            frmKeyInTransID.ShowDialog()
            If dgvCart.Rows.Count > 0 Then
                btnPayRtn.Text = "&Return"
                btnCancel.Text = "Cancel Return"
                Dim flag As Boolean = False
                EnableControl(flag)
                btnReturn.Enabled = True
                btnUpload.Enabled = True
                dgvCart.Columns(2).HeaderText = "Remark"
                dgvCart.Refresh()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub BindDataCat()
        Dim db As New DBDataContext()
        Dim rs = From c In db.categories
                 Select c

        dgvCat.DataSource = rs

        For i As Integer = 0 To dgvCat.Rows.Count() - 2
            Dim strCatogories As String = CStr(dgvCat.Rows(i).Cells(1).Value)
            cboCategories.Items.Add(strCatogories)
        Next
    End Sub

    Private Sub cboSearchType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchType.SelectedIndexChanged
        If cboSearchType.SelectedIndex = 2 Then
            cboCategories.Visible = True
            cboCategories.SelectedIndex = 0
            txtSearch.Visible = False
            txtSearch.Clear()
        Else
            BindData()
            flp.Controls.Clear()
            DynamicButton()
            txtSearch.Visible = True
            cboCategories.Visible = False
        End If
    End Sub

    Private Sub cboCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategories.SelectedIndexChanged
        BindData()
        flp.Controls.Clear()
        DynamicButton()
    End Sub

    Private Sub dgvCart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCart.CellContentClick
        If btnPayRtn.Text = "&Pay" Then
            If e.ColumnIndex = 4 Then
                frmPOSAdminLogin.ShowDialog()
                If blnAdmin = False Then
                    Exit Sub
                End If
                Dim i As Integer = e.RowIndex
                If i > -1 Then
                    Dim id As String = CStr(dgvCart.Rows(i).Cells(3).Value)
                    Dim qty As Integer = CInt(dgvCart.Rows(i).Cells(1).Value)
                    Dim ans As Long = MessageBox.Show("Sure to Remove " & CStr(dgvCart.Rows(i).Cells(0).Value) & " x " & qty & " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If ans = vbYes Then
                        If id <> "memberCard" Then
                            Dim bookQty As Integer = CInt(dgvCart.Rows(i).Cells(1).Value)
                            SubmitQuantityLeft(id, bookQty * -1)
                        Else
                            Dim db As New DBDataContext()
                            Dim m As Member = db.Members.FirstOrDefault(Function(o) o.memberID = strMemberID)
                            db.Members.DeleteOnSubmit(m)

                            btnMember.Text = "&Member"
                            strMemberID = ""

                            db.SubmitChanges()
                            File.Delete(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\MemberQRcode\" & m.memberID & ".jpg"))
                        End If
                        dgvCart.Rows.RemoveAt(i)
                        DynamicButton()

                        If dgvCart.Rows.Count() = 0 Then
                            txtSubTotal.Clear()
                            txtTax.Clear()
                            txtRndAdj.Clear()
                            txtMemberDisc.Clear()
                            txtTotal.Clear()
                        Else
                            ShowTotal()
                        End If
                    End If
                Else
                    MessageBox.Show("No Thing Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            If e.ColumnIndex = 4 Then
                frmPOSAdminLogin.ShowDialog()
                If blnAdmin = False Then
                    Exit Sub
                End If
                Dim i As Integer = e.RowIndex

                For Each row As DataGridViewRow In frmReturn.dgvTransDetail.Rows
                    If CStr(row.Cells(0).Value) = CStr(dgvCart.Rows(i).Cells(3).Value) Then
                        row.Cells(3).Value += CInt(dgvCart.Rows(i).Cells(1).Value)
                    End If
                Next
                dgvCart.Rows.RemoveAt(i)
            End If
        End If
    End Sub

    Private Sub dgvCart_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCart.CellDoubleClick
        If btnPayRtn.Text = "&Pay" Then
            If e.ColumnIndex < 4 Then
                Dim i As Integer = e.RowIndex
                If i > -1 Then

                    frmEditItem.txtBookTitle.Text = CStr(dgvCart.Rows(i).Cells(0).Value)
                    frmEditItem.txtPrice.Text = "RM" & (CDbl(dgvCart.Rows(i).Cells(2).Value) / CInt(dgvCart.Rows(i).Cells(1).Value)).ToString("f2")
                    frmEditItem.txtQty.Text = CStr(dgvCart.Rows(i).Cells(1).Value)
                    frmEditItem.strProductid = CStr(dgvCart.Rows(i).Cells(3).Value)
                    SubmitQuantityLeft(frmEditItem.strProductid, CInt(frmEditItem.txtQty.Text) * -1)
                    frmEditItem.ShowDialog()
                Else
                    MessageBox.Show("No Thing Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                dgvCart.Rows(i).Cells(1).Value = frmEditItem.txtQty.Text
                dgvCart.Rows(i).Cells(2).Value = frmEditItem.txtAmount.Text.Replace("RM", "")

                SubmitQuantityLeft(frmEditItem.strProductid, frmEditItem.txtQty.Text)
                DynamicButton()
                ShowTotal()
            End If
        Else
            If e.ColumnIndex < 4 Then
                Dim i As Integer = e.RowIndex
                If i > -1 Then
                    frmEditReturn.txtBookID.Text = CStr(dgvCart.Rows(i).Cells(3).Value)
                    frmEditReturn.txtBookTitle.Text = CStr(dgvCart.Rows(i).Cells(0).Value)
                    frmEditReturn.txtQty.Text = CStr(dgvCart.Rows(i).Cells(1).Value)
                    frmEditReturn.txtRemark.Text = CStr(dgvCart.Rows(i).Cells(2).Value)
                    dgvCart.Rows.RemoveAt(i)
                    frmEditReturn.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub cboPaymentMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaymentMethod.SelectedIndexChanged
        If cboPaymentMethod.SelectedIndex = 0 Then
            btnPayRtn.Text = "&Pay"
            txtCash.Enabled = True
        Else
            btnPayRtn.Text = "Connect To &Mechine"
            txtCash.Enabled = False
        End If
    End Sub

    Dim objWriter As StreamWriter

    Public Sub writeTemp()
        objWriter = New StreamWriter(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\temp.txt"), False)
        Dim strWriteTemp As String = ""
        strWriteTemp = "MyBookStore*"
        strWriteTemp &= CStr(dgvTrans.Rows(dgvTrans.Rows.Count() - 2).Cells(0).Value) & "!"
            strWriteTemp &= CStr(dgvTrans.Rows(dgvTrans.Rows.Count() - 2).Cells(1).Value) & "@"
            frmPay.TransactionID = CStr(dgvTrans.Rows(dgvTrans.Rows.Count() - 2).Cells(0).Value)

            For Each row As DataGridViewRow In dgvCart.Rows
            Dim book As String = CStr(row.Cells(0).Value)
            Dim qty As String = CStr(row.Cells(1).Value)
            Dim totalPrice As String = CStr(row.Cells(2).Value)
            strWriteTemp &= book & "|"
            strWriteTemp &= qty & ","
            strWriteTemp &= totalPrice & "#"
        Next

        strWriteTemp &= txtSubTotal.Text & "$"
        strWriteTemp &= txtTax.Text & "+"
        strWriteTemp &= txtMemberDisc.Text & "-"
        strWriteTemp &= txtRndAdj.Text & "%"
        strWriteTemp &= txtTotal.Text & "^"
        strWriteTemp &= "RM" & CDbl(txtCash.Text).ToString("f2") & "&"
        strWriteTemp &= "RM" & (CDbl(txtCash.Text) - CDbl(txtTotal.Text.Replace("RM", ""))).ToString("f2") & "="
        objWriter.Write(strWriteTemp)
        objWriter.Close()
    End Sub

    Private Function ShowReceipt() As String
        frmPay.TransactionID = CStr(dgvTrans.Rows(dgvTrans.Rows.Count() - 2).Cells(0).Value)
        ShowReceipt = "FINO SDN BHD" & vbNewLine
        ShowReceipt &= "5,Lorong Fino 6," & vbNewLine
        ShowReceipt &= "Taman Four In One," & vbNewLine
        ShowReceipt &= "13400,Butterworth," & vbNewLine

        ShowReceipt &= "Pulau Pinang." & vbNewLine & vbNewLine & vbNewLine
        ShowReceipt &= "Transaction_ID:" & CStr(dgvTrans.Rows(dgvTrans.Rows.Count() - 2).Cells(0).Value) & vbNewLine
        ShowReceipt &= "Transaction_Date:" & CStr(dgvTrans.Rows(dgvTrans.Rows.Count() - 2).Cells(1).Value) & vbNewLine


        ShowReceipt &= "Member_ID:" & strMemberID & vbNewLine
        ShowReceipt &= "========Invoice======" & vbNewLine
        ShowReceipt &= "Item             Qty     Amount" & vbNewLine
        For Each row As DataGridViewRow In dgvCart.Rows
            Dim book As String = CStr(row.Cells(0).Value)
            Dim qty As String = CStr(row.Cells(1).Value)
            Dim totalPrice As String = ""
            If qty.Length = 1 Then
                qty = "  " & qty
            ElseIf qty.Length = 2 Then
                qty = " " & qty
            End If
            For i As Integer = CStr(row.Cells(2).Value).Length To 8
                totalPrice &= " "
            Next

            totalPrice &= CStr(row.Cells(2).Value)

            If book.Length >= 15 Then
                book = Microsoft.VisualBasic.Left(CStr(row.Cells(0).Value), 15)
                ShowReceipt &= book & "  " & qty & "  " & totalPrice & vbNewLine
                book = Microsoft.VisualBasic.Right(CStr(row.Cells(0).Value), CStr(row.Cells(0).Value).Length - 15) & vbNewLine
                ShowReceipt &= book & vbNewLine
            Else
                ShowReceipt &= book
                For i As Integer = book.Length To 14
                    ShowReceipt &= " "
                Next
                ShowReceipt &= "  " & qty & "  " & totalPrice & vbNewLine & vbNewLine
            End If
        Next
        ShowReceipt &= "      " & lblSubTotal.Text & txtSubTotal.Text & vbNewLine
        ShowReceipt &= "        " & lblTax.Text & txtTax.Text & vbNewLine
        ShowReceipt &= lblMemberDisc.Text & txtMemberDisc.Text & vbNewLine
        ShowReceipt &= lblRndAdj.Text & txtRndAdj.Text & vbNewLine
        For i As Integer = 0 To 30
            ShowReceipt &= "="
        Next
        Dim db As New DBDataContext()
        Dim m As Member = db.Members.FirstOrDefault(Function(o) o.memberID = strMemberID)

        ShowReceipt &= vbNewLine
        ShowReceipt &= "          Total:" & txtTotal.Text & vbNewLine
        ShowReceipt &= "            Pay:RM" & CDbl(txtCash.Text).ToString("f2") & vbNewLine
        ShowReceipt &= "         Change:RM" & (CDbl(txtCash.Text) - CDbl(txtTotal.Text.Replace("RM", ""))).ToString("f2") & vbNewLine
        frmPay.lblChange.Text = "Change:RM" & (CDbl(txtCash.Text) - CDbl(txtTotal.Text.Replace("RM", ""))).ToString("f2")
        For i As Integer = 0 To 30
            ShowReceipt &= "="
        Next
        ShowReceipt &= vbNewLine
        If strMemberID = "" Then
            ShowReceipt &= "     Point Loss:" & (CInt(txtTotal.Text.Replace("RM", "")) / 10) & vbNewLine
        Else
            ShowReceipt &= "     Point Gain:" & (CInt(txtTotal.Text.Replace("RM", "")) / 10) & vbNewLine
            ShowReceipt &= "  Point Balance:" & m.mPoint & vbNewLine
            If m.mPoint >= 10 And m.mPoint <= 1000 Then
                m.mLevel = "Gold"
                m.mRate = 0.05
            ElseIf m.mPoint >= 1000 Then
                m.mLevel = "Gold"
                m.mRate = 0.1
            End If
        End If
        ShowReceipt &= vbNewLine & vbNewLine
        ShowReceipt &= "Thank You For Puchase." & vbNewLine
        ShowReceipt &= "Name:" & lblStaffName.Text

    End Function

    Private Sub btnPayRtn_Click_1(sender As Object, e As EventArgs) Handles btnPayRtn.Click
        If btnPayRtn.Text.Contains("Return") Then
            If dgvCart.Rows.Count() > 0 Then
                saveDataReturn()
                MessageBox.Show("Return Sucess", "Return", MessageBoxButtons.OK)
                Dim flag As Boolean = True
                EnableControl(flag)
                btnPayRtn.Text = "&Pay"
                btnCancel.Text = "Cancel Transaction"
                dgvCart.Columns(2).HeaderText = "Amount"
                Clear()
            Else
                MessageBox.Show("No Thing For Return", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Exit Sub
        End If
        blnRecallBill = False
        If dgvCart.Rows.Count() > 0 Then
            Dim flag As Boolean = False
            btnCancel.Text = "Cancel Pay"
            EnableControl(flag)
            If cboPaymentMethod.Visible = False Then
                cboPaymentMethod.Visible = True
                lblCash.Visible = True
                txtCash.Visible = True
                txtCash.Focus()
                txtCash.Enabled = True
            Else
                If cboPaymentMethod.SelectedIndex = 0 Then
                    Try
                        If CDbl(txtCash.Text) < CDbl(txtTotal.Text.Replace("RM", "")) Then
                            MessageBox.Show("No Enough Pay..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtCash.Focus()
                        Else
                            Dim db As New DBDataContext()
                            Dim m As Member = db.Members.FirstOrDefault(Function(o) o.memberID = strMemberID)
                            SaveData("Paid", cboPaymentMethod.Text)
                            BindData()
                            BindDataCat()
                            frmPay.btnQRCode.Visible = True
                            DbltotalAMount += CDbl(txtTotal.Text.Replace("RM", ""))
                            BindDataTran()
                            dgvTrans.Refresh()
                            MessageBox.Show("Change:RM" & (CDbl(txtCash.Text) - CDbl(txtTotal.Text.Replace("RM", ""))).ToString("f2"), "Change", MessageBoxButtons.OK)
                            frmPay.txtReceipt.Text = ShowReceipt()
                            writeTemp()
                            cboSearchType.SelectedIndex = 0
                            cboPaymentMethod.SelectedIndex = 0
                            DynamicButton()
                            flag = True
                            EnableControl(flag)
                            Clear()
                            frmPay.ShowDialog()
                            frmPay.txtReceipt.Clear()
                            btnCancel.Text = "Cancel Transaction"
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Key In The Pay Amount First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCash.Focus()
                    End Try
                ElseIf cboPaymentMethod.SelectedIndex = 1 Then
                    MessageBox.Show("No Machine Connected..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("No Machine Connected..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("No Item For Pay..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Try
            If txtCash.Text IsNot "" Then
                Dim dblCash As Double = CDbl(txtCash.Text)
                Dim decWholePart As Decimal = Math.Truncate(dblCash)
                Dim decFractionalPart As Decimal = dblCash - decWholePart

                If ((CDec(decFractionalPart.ToString("f2")) * 100) Mod 5) <> 0 Then
                    MessageBox.Show("Invalid Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtCash.Text = txtCash.Text.Substring(0, txtCash.Text.Length - 1)
                    txtCash.SelectionStart = txtCash.Text.Length
                    txtCash.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCash.Text = txtCash.Text.Substring(0, txtCash.Text.Length - 1)
            txtCash.SelectionStart = txtCash.Text.Length
            txtCash.Focus()
        End Try
    End Sub
    Dim blnDec As Boolean = True
    Private Sub txtCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCash.KeyPress
        Dim decPoint As String = "."

        If txtCash.Text.Contains(decPoint) Then
            decPoint = ""
            Dim max As Byte = 0
            If blnDec = True Then
                max = txtCash.Text.Length + 2
                txtCash.MaxLength = max
                blnDec = False
            End If
        Else
            decPoint = "."
            blnDec = True
        End If

        If e.KeyChar = Convert.ToChar(Keys.Back) Or e.KeyChar = decPoint Or e.KeyChar = Convert.ToChar(Keys.Enter) Then
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

    Private Sub btnMember_Click(sender As Object, e As EventArgs) Handles btnMember.Click
        If strStaffName = "Self POS System" Then
            If btnMember.Text = "&Member" Then
                FrmMemberLogin.ShowDialog()
                ShowTotal()
                If strMemberID <> "" Then
                    btnMember.Text = "&Back"
                End If
            Else
                FrmMemberHomepage.Show()
            End If
            Exit Sub

        End If

        If btnMember.Text = "&Member" Then
            frmMemLogPOS.ShowDialog()
            ShowTotal()
            If strMemberID <> "" Then
                btnMember.Text = "&Member Detail"
            End If
        Else
            Dim db As New DBDataContext()
            Dim m As Member = db.Members.FirstOrDefault(Function(o) o.memberID = strMemberID)
            MessageBox.Show("Member ID: " & m.memberID & vbNewLine & "Member Level: " & m.mLevel & vbNewLine & "Member Rate: " & m.mRate & vbNewLine & "Point: " & m.mPoint, "Member Detail", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        frmPOSAdminLogin.ShowDialog()
        If blnAdmin = False Then
            Exit Sub
        End If

        If dgvCart.Rows.Count() > 0 Then
            Dim ans As Long = MessageBox.Show("Done the Transaction before Log Out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim db As New DBDataContext()
        Dim tran As Transaction = db.Transactions.FirstOrDefault(Function(o) o.Status = "Hold")

        If tran IsNot Nothing And strStaffName <> "Self POS System" Then
            Dim ans As Long = MessageBox.Show("Had Bill Holding." & vbNewLine & "Confrim to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ans <> vbYes Then
                btnRecallBill.PerformClick()
                Exit Sub
            End If
        End If

        frmFloat.txtTransaction.Text = "RM" & (DbltotalAMount).ToString("f2")
        frmFloat.lblInform.Text = "Please Key In Your Cash On Hand"
        frmFloat.Text = "Generate Final Report"
        frmFloat.ShowDialog()
        frmFloat.Text = "Float"
        frmFloat.Text = "Please Key In Your Float"
        Clear()
        Me.Close()

        If strStaffName = "Self POS System" Then
            frmLogin.ShowDialog()
        Else
            frmHomepage.ShowDialog()
        End If
    End Sub

    Private Sub txtCash_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCash.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnPayRtn.PerformClick()
        End If
    End Sub

    Dim reader As New QRCodeDecoder

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim pic As New PictureBox
        Me.Controls.Add(pic)
        Try
            Dim od As New OpenFileDialog
            od.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\BookQRcode\")
            If od.ShowDialog() = DialogResult.OK Then
                pic.Load(od.FileName)

                reader = New QRCodeDecoder

                Dim bookID As String = reader.decode(New Data.QRCodeBitmapImage(pic.Image))

                If btnPayRtn.Text.Contains("Pay") Then
                    Dim db As New DBDataContext()
                    Dim b As book = db.books.FirstOrDefault(Function(o) o.bookID.Trim = bookID.Trim)
                    If b IsNot Nothing Then
                        If b.quantity > 0 Then
                            Dim strID As String = b.bookID
                            Dim strName As String = b.bookTitle
                            Dim dblPrice As Double = b.price
                            Dim intQtyLeft As Integer = b.quantity

                            For Each row As DataGridViewRow In dgvCart.Rows
                                If row.Cells(0).Value = strName Then
                                    row.Cells(1).Value = CInt(row.Cells(1).Value) + 1
                                    row.Cells(2).Value = (CInt(row.Cells(1).Value) * dblPrice).ToString("f2")
                                    SubmitQuantityLeft(strID, 1)
                                    ShowTotal()
                                    Exit Sub
                                End If
                            Next

                            dgvCart.Rows.Add(strName, "1", dblPrice.ToString("f2"), strID)

                            SubmitQuantityLeft(strID, 1)
                            ShowTotal()
                        Else
                            MessageBox.Show("Book Sold Out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Invalid QR code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    Dim blnTrue As Boolean = False

                    For Each row As DataGridViewRow In frmReturn.dgvTransDetail.Rows
                        If CStr(row.Cells(0).Value) = bookID Then
                            blnTrue = True
                            Dim strProductID As String = CStr(row.Cells(0).Value)
                            Dim strProductName As String = CStr(row.Cells(1).Value)
                            Dim strProductQty As Double = CDbl(row.Cells(3).Value)

                            frmEditReturn.txtBookID.Text = strProductID
                            frmEditReturn.txtBookTitle.Text = strProductName
                            frmEditReturn.qty = strProductQty
                            frmEditReturn.btnMax.Text = "Max(" & strProductQty & ")"
                            frmEditReturn.txtQty.Text = strProductQty
                            frmEditReturn.ShowDialog()
                            Exit For
                        End If
                    Next
                    If blnTrue = False Then
                        MessageBox.Show("Invalid Book Return For This TransactionID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid QR code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Controls.Remove(pic)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        frmAddExpenses.ShowDialog()
    End Sub

End Class
