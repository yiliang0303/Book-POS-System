Public Class frmHoldBill
    Private data As Integer = 0
    Private id As String = ""
    Private Sub BindDataHoldBill()
        Dim db As New DBDataContext()

        Dim rs = From t In db.Transactions
                 Where t.Status = "Hold"
                 Select t.Transaction_ID, t.Date, t.Staff.sName, t.StaffID

        dgvTrans.DataSource = rs

        If dgvTrans.Rows.Count < 1 Then
            Me.Close()
            MessageBox.Show("No Bill Holding", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        data = 0
    End Sub

    Private Sub BindDataTDetail()
        Dim db As New DBDataContext()

        Dim rs = From td In db.TransactionDetails Join b In db.books On td.BookID Equals b.bookID
                 Where td.Transaction_ID = id
                 Select b.bookID, b.bookTitle, b.price, td.qty

        dgvTrans.DataSource = rs
        data = 1
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancelBack.Click
        If btnCancelBack.Text = "&Cancel" Then
            Dim ans As Long = MessageBox.Show("Sure to Cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If ans = vbYes Then
                Me.Close()
            End If
        Else
            BindDataHoldBill()
            btnCancelBack.Text = "&Cancel"
        End If

    End Sub

    Private Sub frmHoldBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        Me.btnCancelBack.BackColor = My.Settings.buttonColor
        Me.btnCancelBack.ForeColor = My.Settings.buttonForeColor

        Me.btnReCall.BackColor = My.Settings.buttonColor
        Me.btnReCall.ForeColor = My.Settings.buttonForeColor

        BindDataHoldBill()
        btnCancelBack.Text = "&Cancel"
    End Sub

    Private Sub dgvTrans_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTrans.CellDoubleClick
        If data = 0 Then
            Dim i As Integer = e.RowIndex
            If i > -1 Then
                id = CStr(dgvTrans.Rows(i).Cells(0).Value)
                BindDataTDetail()
                btnCancelBack.Text = "&Back"
                Exit Sub
            End If
        Else
            btnCancelBack.PerformClick()
        End If
    End Sub

    Private Sub recallFunction(ByVal id As String)
        Dim db As New DBDataContext()

        For j As Integer = 0 To dgvTrans.Rows.Count - 1
            Dim strProductID As String = CStr(dgvTrans.Rows(j).Cells(0).Value)
            Dim strProductName As String = CStr(dgvTrans.Rows(j).Cells(1).Value)
            Dim intQty As Integer = CInt(dgvTrans.Rows(j).Cells(3).Value)
            Dim dblAmount As Double = CDbl(dgvTrans.Rows(j).Cells(2).Value) * intQty

            frmOrder.dgvCart.Rows.Add(strProductName, intQty, dblAmount, strProductID)

            Dim td As TransactionDetail = db.TransactionDetails.FirstOrDefault(Function(o) o.Transaction_ID = id)
            db.TransactionDetails.DeleteOnSubmit(td)
            db.SubmitChanges()
            frmOrder.blnRecallBill = True
            frmOrder.strRecallID = id
        Next
        Me.Close()
    End Sub

    Private Sub btnReCall_Click(sender As Object, e As EventArgs) Handles btnReCall.Click
        If data = 0 Then
            Dim i As Integer = dgvTrans.CurrentCell.RowIndex
            If i > -1 Then
                id = CStr(dgvTrans.Rows(i).Cells(0).Value)
                BindDataTDetail()
                recallFunction(id)
            Else
                MessageBox.Show("No Transaction Selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            BindDataTDetail()
            recallFunction(id)
        End If
    End Sub

End Class