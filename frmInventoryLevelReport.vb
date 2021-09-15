Public Class frmInventoryLevelReport
    Public qtyLevel As Integer = 0

    Private Sub frmInventoryLevelReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBDataContext
        Dim rs = From b In db.books
                 Where b.quantity < qtyLevel And b.bookID IsNot "memberCard" And b.status = True
                 Order By b.quantity Ascending
                 Select b.bookID, b.bookTitle, b.price, b.quantity

        dgv.DataSource = rs
        dgv.Columns(0).HeaderText = "Book ID"
        dgv.Columns(1).HeaderText = "Book Title"
        dgv.Columns(2).HeaderText = "Price (RM)"
        dgv.Columns(3).HeaderText = "Quantiy"

        lblCount.Text = rs.Count() & " item(s)"
        lblTitle.Text = "Book quantiy below " & CStr(qtyLevel) & " in " & Date.Today.Date.ToString("dd MMM yyyy")

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim x As Single = e.MarginBounds.Left
        Dim y As Single = e.MarginBounds.Top
        Dim myfont1 As New Font("Arial", 13)
        Dim myfont2 As New Font("Arial", 20, FontStyle.Bold)
        Dim myfont3 As New Font("Arial", 14, FontStyle.Bold)
        Dim lineHeight As Single = myfont3.GetHeight

        Dim printData As String = ""
        Dim img As Image
        img = Image.FromFile("..\..\Resources\mybook.png")
        e.Graphics.DrawImage(img, x + 240, y)
        y += lineHeight * 10
        printData &= lblTitle.Text & vbNewLine
        e.Graphics.DrawString(printData, myfont2, Brushes.Black, x + 95, y)
        y += lineHeight * 3
        printData = dgv.Columns(0).HeaderText & "            " & dgv.Columns(1).HeaderText & "                                       " & dgv.Columns(2).HeaderText & "           " & dgv.Columns(3).HeaderText & vbNewLine
        e.Graphics.DrawString(printData, myfont3, Brushes.Black, x, y)
        y += lineHeight * 2

        Dim db As New DBDataContext
        Dim rs = From b In db.books
                 Where b.quantity <= qtyLevel And b.bookID IsNot "memberCard" And b.status = True
                 Order By b.quantity Ascending
                 Select b.bookID, b.bookTitle, b.price, b.quantity
        dgv.DataSource = rs
        printData = ""

        For k As Integer = 0 To 3
            For i As Integer = 0 To rs.Count() - 1
                printData &= CStr(dgv.Rows(i).Cells(k).Value) & vbNewLine
            Next
            If k = 0 Then
                printData &= vbNewLine & rs.Count & " item(s)"
            ElseIf k = 1 Then
                x += 140
            ElseIf k = 2 Then
                x += 320
            Else
                x += 170
            End If
            e.Graphics.DrawString(printData, myfont1, Brushes.Black, x, y)
            printData = ""
        Next
    End Sub
End Class