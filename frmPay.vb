Imports QRCoder
Imports System.IO
Public Class frmPay
    Public TransactionID As String = ""
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim ans As Long = MessageBox.Show("Confirm to Close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbYes Then
            lblChange.Text = " "
            Me.Close()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim x As Single = e.MarginBounds.Left
        Dim y As Single = e.MarginBounds.Top
        Dim myfont1 As New Font("Time New Romans", 12)
        Dim lineHeight As Single = myfont1.GetHeight

        Dim img As Image
        img = Image.FromFile("../../Resources/mybook.png")
        e.Graphics.DrawImage(img, x - 30, y)
        y += lineHeight * 11
        e.Graphics.DrawString(txtReceipt.Text, myfont1, Brushes.Black, x, y)
    End Sub

    Private Sub btnQRCode_Click(sender As Object, e As EventArgs) Handles btnQRCode.Click
        Dim gen As New QRCodeGenerator
        Dim value As String = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\temp.txt"))
        Dim data = gen.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        picQrCode.Image = code.GetGraphic(6)
        SaveImageCopy(TransactionID, picQrCode.Image)
        PictureBox1.Visible = True
        picQrCode.Visible = True
    End Sub

    Private Sub SaveImageCopy(filename As String, image As Image)
        Dim path As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\Transaction"), filename & ".jpg")
        Dim dest As New Bitmap(image.Width, image.Height)
        Dim gfx As Graphics = Graphics.FromImage(dest)
        gfx.DrawImageUnscaled(image, Point.Empty)
        gfx.Dispose()
        dest.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg)
        dest.Dispose()
    End Sub

    Private Sub frmPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        Me.btnClose.BackColor = My.Settings.buttonColor
        Me.btnClose.ForeColor = My.Settings.buttonForeColor

        Me.btnPrint.BackColor = My.Settings.buttonColor
        Me.btnPrint.ForeColor = My.Settings.buttonForeColor

        Me.btnQRCode.BackColor = My.Settings.buttonColor
        Me.btnQRCode.ForeColor = My.Settings.buttonForeColor

        picQrCode.Visible = False

        If btnQRCode.Visible = True Then
            btnQRCode.PerformClick()
            btnQRCode.PerformClick()
        End If
    End Sub
End Class