Imports System.ComponentModel
Imports System.IO
Imports QRCoder

Public Class frmRecoverBook
    Dim wptr As StreamWriter

    Private Sub createDeletedBookBtn()
        Dim dgv As New DataGridView
        Me.Controls.Add(dgv)
        dgv.Visible = False
        Dim btn As New Button
        Dim db As New DBDataContext
        Dim rs = From b In db.books
                 Where b.status = False And b.bookID IsNot "memberCard"
                 Order By b.bookTitle Ascending
                 Select b

        dgv.DataSource = rs
        For i As Integer = 0 To rs.Count - 1
            btn = New Button
            btn.Text = CStr(dgv.Rows(i).Cells(1).Value)
            btn.Name = CStr(dgv.Rows(i).Cells(0).Value)
            btn.Font = New Font("Microsoft Sans Serif", 10)
            btn.Width = flpDeletedBook.Width * 0.19
            btn.Height = flpDeletedBook.Height * 0.2
            btn.Tag = "DeletedBookButton"
            AddHandler btn.Click, AddressOf Me.DeletedButtonBook_Click

            flpDeletedBook.Controls.Add(btn)
        Next
    End Sub

    Public Sub disposeBookButton()
        For i As Integer = flpDeletedBook.Controls.Count - 1 To 0 Step -1
            Dim c = flpDeletedBook.Controls(i)

            If (TypeOf c Is Button) And c.Tag = "DeletedBookButton" Then
                c.Dispose()           '' NOTE: disposing the control also removes it
            End If
        Next
    End Sub

    Private Sub DeletedButtonBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btn As Button = sender
        Dim db As New DBDataContext
        Dim b As New book

        b = db.books.FirstOrDefault(Function(o) o.bookID = btn.Name)
        Dim temp As String = vbNewLine & "Author : " & b.authorName & vbNewLine
        temp &= "Price     : RM" & b.price.ToString("f2") & vbNewLine
        Dim ans As Long = 0
        ans = MessageBox.Show("Are you sure to recover " & b.bookTitle & "?" & temp, "Recover Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ans = vbYes Then
            b.status = True
            db.SubmitChanges()
            disposeBookButton()
            createDeletedBookBtn()
            FrmProduct.disposeBookButton()
            FrmProduct.createBookBtn()

            Dim gen As New QRCodeGenerator
            Dim data = gen.CreateQrCode(b.bookID, QRCodeGenerator.ECCLevel.Q)
            Dim code As New QRCode(data)
            Dim picBox As New PictureBox
            picBox.Image = code.GetGraphic(6)
            'SaveImageCopy(b.bookID & "-" & b.bookTitle, picBox.Image)

            Dim path As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\BookQRcode\"), b.bookID.Trim & "-" & b.bookTitle & ".jpg")
            Dim dest As New Bitmap(picBox.Image.Width, picBox.Image.Height)
            Dim gfx As Graphics = Graphics.FromImage(dest)
            gfx.DrawImageUnscaled(picBox.Image, Point.Empty)
            gfx.Dispose()
            dest.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg)
            dest.Dispose()

            wptr = New StreamWriter(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\BookEditHistory\" & b.bookID & ".txt"), True)

            wptr.WriteLine(Date.Today.ToShortDateString & " " & DateTime.Now.ToShortTimeString & " - " & b.bookTitle & " have been recovered!")

            wptr.Close()
        End If
    End Sub

    Private Sub frmRecoverBook_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        createDeletedBookBtn()
    End Sub

    Private Sub frmRecoverBook_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        disposeBookButton()
    End Sub
End Class