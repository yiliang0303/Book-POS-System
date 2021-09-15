Public Class frmReturn
    Private Sub btnCancelBack_Click(sender As Object, e As EventArgs) Handles btnCancelBack.Click
        Dim ans As Long = MessageBox.Show("Sure to Cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbYes Then
            Me.Close()
        End If

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim i As Integer = dgvTransDetail.CurrentCell.RowIndex
        Dim remark As String = ""
        If i > -1 Then
            Dim strProductID As String = CStr(dgvTransDetail.Rows(i).Cells(0).Value)
            Dim strProductName As String = CStr(dgvTransDetail.Rows(i).Cells(1).Value)
            Dim strProductQty As Double = CDbl(dgvTransDetail.Rows(i).Cells(3).Value)
            If strProductQty = 0 Then
                MessageBox.Show("No Quantity For Return", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            frmEditReturn.txtBookID.Text = strProductID
            frmEditReturn.txtBookTitle.Text = strProductName
            frmEditReturn.qty = strProductQty
            frmEditReturn.btnMax.Text = "Max(" & strProductQty & ")"
            frmEditReturn.txtQty.Text = strProductQty
            frmOrder.Show()
            frmEditReturn.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("No Item Selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgvTransDetail_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransDetail.CellContentDoubleClick
        Dim i As Integer = e.RowIndex
        If i > -1 Then
            Dim strProductID As String = CStr(dgvTransDetail.Rows(i).Cells(0).Value)
            Dim strProductName As String = CStr(dgvTransDetail.Rows(i).Cells(1).Value)
            Dim strProductQty As Double = CDbl(dgvTransDetail.Rows(i).Cells(3).Value)

            frmEditReturn.txtBookID.Text = strProductID
            frmEditReturn.txtBookTitle.Text = strProductName
            frmEditReturn.qty = strProductQty
            frmEditReturn.btnMax.Text = "Max(" & strProductQty & ")"
            frmEditReturn.txtQty.Text = strProductQty
            frmOrder.Show()
            frmEditReturn.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("No Item Selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgvTransDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransDetail.CellContentClick

    End Sub

    Private Sub frmReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        Me.btnCancelBack.BackColor = My.Settings.buttonColor
        Me.btnCancelBack.ForeColor = My.Settings.buttonForeColor

        Me.btnReturn.BackColor = My.Settings.buttonColor
        Me.btnReturn.ForeColor = My.Settings.buttonForeColor

    End Sub
End Class