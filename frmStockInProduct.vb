Imports System.IO
Imports MessagingToolkit.QRCode.Codec

Public Class frmStockInProduct
    Dim reader As New QRCodeDecoder
    Dim wptr As StreamWriter
    Dim rptr As StreamReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pic As New PictureBox
        Me.Controls.Add(pic)
        pic.Visible = False

        Try
            Dim od As New OpenFileDialog
            od.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\stockInQRcode\")
            If od.ShowDialog() = DialogResult.OK Then
                pic.Load(od.FileName)

                reader = New QRCodeDecoder

                wptr = New StreamWriter(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\stockInQRcode\tempStockIn.txt"))
                wptr.Write(reader.decode(New Data.QRCodeBitmapImage(pic.Image)))
                wptr.Close()

                Dim bookID As String = ""
                Dim bookTitle As String = ""
                Dim oriQuantity As Integer = 0
                Dim addQuantity As Integer = 0
                rptr = New StreamReader(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\stockInQRcode\tempStockIn.txt"))

                Try
                    While rptr.Peek <> -1
                        bookID = rptr.ReadLine
                        Dim temp As String = ""
                        temp = rptr.ReadLine
                        addQuantity = CInt(temp)
                        Exit While
                    End While
                    Dim db As New DBDataContext
                    Dim rs = From bk In db.books
                             Where bk.bookID = bookID And bk.status = True And bk.bookID IsNot "memberCard"
                             Select bk

                    Dim dgv As New DataGridView
                    Me.Controls.Add(dgv)
                    dgv.Visible = False
                    dgv.DataSource = rs
                    oriQuantity = CInt(dgv.Rows(0).Cells(3).Value)
                    bookTitle = CStr(dgv.Rows(0).Cells(1).Value)

                    txtBookTitle.Text = bookTitle
                    txtOriQuantity.Text = oriQuantity.ToString
                    txtAddQuantity.Text = addQuantity.ToString
                    txtFinalQuantity.Text = (oriQuantity + addQuantity).ToString
                    picBook.Image = Image.FromFile("..\..\Resources\BookImage\" & CStr(dgv.Rows(0).Cells(0).Value).Trim & ".jpg")

                    Dim b As New book
                    b = db.books.FirstOrDefault(Function(o) o.bookID = bookID)
                    b.quantity = oriQuantity + addQuantity
                    db.SubmitChanges()

                Catch ex As Exception
                    MessageBox.Show("Invalid QR code", "Stock In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtAddQuantity.Clear()
                    txtFinalQuantity.Clear()
                    txtOriQuantity.Clear()
                End Try

                rptr.Close()
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub frmStockInProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor
    End Sub

    Private Sub frmStockInProduct_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtAddQuantity.Clear()
        txtBookTitle.Clear()
        txtFinalQuantity.Clear()
        txtOriQuantity.Clear()
    End Sub
End Class