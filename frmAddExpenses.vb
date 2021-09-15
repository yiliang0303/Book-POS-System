Imports MessagingToolkit.QRCode.Codec
Imports System.IO

Public Class frmAddExpenses
    Dim Reader As New QRCodeDecoder
    Dim wptr As StreamWriter
    Dim rptr As StreamReader

    Private Sub btnQRcode_Click(sender As Object, e As EventArgs) Handles btnQRcode.Click

        Dim pic As New PictureBox
        Me.Controls.Add(pic)
        pic.Visible = False

        Try
            Dim od As New OpenFileDialog
            od.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\")
            If od.ShowDialog() = DialogResult.OK Then
                pic.Load(od.FileName)

                wptr = New StreamWriter(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\temp.txt"))
                Reader = New QRCodeDecoder
                wptr.Write(Reader.decode(New Data.QRCodeBitmapImage(pic.Image)))

                wptr.Close()

                rptr = New StreamReader(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\temp.txt"))

                Dim strTemp As String = ""
                While rptr.Peek <> -1
                    Dim buffer(1) As Char
                    rptr.Read(buffer, 0, 1)

                    If buffer(0) = "*" Then
                        txtShopName.Text = strTemp
                        strTemp = ""
                    ElseIf buffer(0) = "!" Then
                        txtReceiptNo.Text = strTemp
                        strTemp = ""
                    ElseIf buffer(0) = "@" Then
                        txtDate.Text = strTemp
                        strTemp = ""
                    ElseIf buffer(0) = "|" Then
                        Dim txtItem As New TextBox
                        flpItem.Controls.Add(txtItem)
                        txtItem.Width = lblItem.Width
                        txtItem.ForeColor = Color.Black
                        txtItem.ReadOnly = True
                        txtItem.Text = strTemp
                        strTemp = ""
                    ElseIf buffer(0) = "," Then
                        Dim txtQuantity As New TextBox
                        flpItem.Controls.Add(txtQuantity)
                        txtQuantity.ForeColor = Color.Black
                        txtQuantity.Width = lblQuantity.Width
                        txtQuantity.ReadOnly = True
                        txtQuantity.Text = strTemp
                        strTemp = ""
                    ElseIf buffer(0) = "#" Then
                        Dim txtPrice As New TextBox
                        flpItem.Controls.Add(txtPrice)
                        txtPrice.ForeColor = Color.Black
                        txtPrice.Width = lblPrice.Width
                        txtPrice.ReadOnly = True
                        txtPrice.Text = strTemp
                        strTemp = ""
                    ElseIf buffer(0) = "$" Then
                        txtSubTotal.Text = strTemp
                        strTemp = ""
                    ElseIf buffer(0) = "+" Then
                        txtTax.Text = strTemp
                        strTemp = ""
                    ElseIf buffer(0) = "-" Then
                        txtDiscount.Text = strTemp
                        strTemp = ""
                    ElseIf buffer(0) = "%" Then
                        txtRounding.Text = strTemp
                        strTemp = ""
                        'rounding
                    ElseIf buffer(0) = "^" Then
                        txtTotal.Text = strTemp
                        strTemp = ""
                    ElseIf buffer(0) = "&" Then
                        txtPay.Text = strTemp
                        strTemp = ""
                        'moneypay
                    ElseIf buffer(0) = "=" Then
                        txtChange.Text = strTemp
                        strTemp = ""
                        'change
                    Else
                        strTemp &= buffer(0)
                    End If
                End While

                rptr.Close()
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub frmAddExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor
        Me.btnQRcode.BackColor = My.Settings.buttonColor
        Me.btnQRcode.Font = My.Settings.buttonFont
        Me.btnQRcode.ForeColor = My.Settings.buttonForeColor
    End Sub
End Class