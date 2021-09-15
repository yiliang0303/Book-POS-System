Imports MessagingToolkit.QRCode.Codec
Public Class frmKeyInTransID
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim ans As Long = MessageBox.Show("Confirm to Close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim db As New DBDataContext()
        Dim t As Transaction = db.Transactions.FirstOrDefault(Function(o) o.Transaction_ID = txtTransaction.Text And o.Status = "Paid")

        If t IsNot Nothing Then
            Me.Hide()
            Dim rs = From td In db.TransactionDetails
                     Where td.Transaction_ID = txtTransaction.Text
                     Select td.book.bookID, td.book.bookTitle, td.book.price, td.qty

            frmReturn.dgvTrans2.DataSource = rs
            For Each row As DataGridViewRow In frmReturn.dgvTrans2.Rows
                frmReturn.dgvTransDetail.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value)
            Next
            frmEditReturn.txtTransaction.Text = txtTransaction.Text
            frmOrder.Show()
            frmReturn.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("Wrong ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTransaction.Focus()
        End If
    End Sub

    Private Sub frmKeyInTransID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        Me.btnConfirm.BackColor = My.Settings.buttonColor
        Me.btnConfirm.ForeColor = My.Settings.buttonForeColor

        Me.btnCancel.BackColor = My.Settings.buttonColor
        Me.btnCancel.ForeColor = My.Settings.buttonForeColor

        Me.btnQRCode.BackColor = My.Settings.buttonColor
        Me.btnQRCode.ForeColor = My.Settings.buttonForeColor


        txtTransaction.Clear()
    End Sub

    Private Sub txtTransaction_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTransaction.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnConfirm.PerformClick()
        End If
    End Sub
    Dim reader As New QRCodeDecoder
    Private Sub btnQRCode_Click(sender As Object, e As EventArgs) Handles btnQRCode.Click
        Dim pic As New PictureBox
        Me.Controls.Add(pic)
        pic.Visible = False
        Try
            Dim od As New OpenFileDialog
            od.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\Transaction")
            If od.ShowDialog() = DialogResult.OK Then
                pic.Load(od.FileName)
                reader = New QRCodeDecoder
                Dim QRTran As String = reader.decode(New Data.QRCodeBitmapImage(pic.Image))
                Dim db As New DBDataContext
                QRTran = Microsoft.VisualBasic.Left(QRTran, 23)
                QRTran = Microsoft.VisualBasic.Right(QRTran, 11)

                Dim t As Transaction = db.Transactions.FirstOrDefault(Function(o) o.Transaction_ID = QRTran)
                If t IsNot Nothing Then
                    txtTransaction.Text = QRTran
                    btnConfirm.PerformClick()
                Else
                    MessageBox.Show("Invalid QR code")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class