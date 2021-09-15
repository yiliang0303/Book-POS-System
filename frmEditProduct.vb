#Disable Warning IDE1006
Imports System.ComponentModel
Imports System.IO
Imports System.Text.RegularExpressions
Imports MessagingToolkit.QRCode.Codec
Imports QRCoder

Public Class FrmEditProduct
    Public selectedID As String
    Dim wptr As StreamWriter
    Dim rptr As StreamReader
    Dim b As book

    Public Function validateCategory(ByRef cmbCategory As ComboBox) As Boolean
        If cmbCategory.SelectedIndex = -1 Then
            MessageBox.Show("Please select a category", "Invalid Category", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function

    Private Function validateLanguage() As Boolean
        If txtLanguage.Text.Trim = "" Then
            MessageBox.Show("Please fill up language", "Invalid Language", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLanguage.Clear()
            txtLanguage.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Public Function validatePrice(input As String, ByRef txtPrice As TextBox) As Boolean
        If Regex.Match(input, "\d{0,}\.?\d{1,2}").Value = input And (Not txtPrice.Text = "") Then
            Return True
        Else
            MessageBox.Show("Invalid Price", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function

    Private Sub FrmEditProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        Me.btnDelete.BackColor = My.Settings.buttonColor
        ' Me.btnDelete.Font = My.Settings.buttonFont
        Me.btnDelete.ForeColor = My.Settings.buttonForeColor

        Me.btnDone.BackColor = My.Settings.buttonColor
        'Me.btnDone.Font = My.Settings.buttonFont
        Me.btnDone.ForeColor = My.Settings.buttonForeColor


        Dim db As New DBDataContext
        b = db.books.FirstOrDefault(Function(o) o.bookID = selectedID)

        If b Is Nothing Then
            MessageBox.Show("Book Not Found")
            Me.Close()
            Return
        End If

        Dim rs = From c In db.categories
                 Select c

        Dim dgvInsert As New DataGridView
        Me.Controls.Add(dgvInsert)
        dgvInsert.DataSource = rs

        For i As Integer = 0 To rs.Count - 1
            cmbCategory.Items.Add(dgvInsert.Rows(i).Cells(1).Value)
        Next
        cmbCategory.Items.Add("Other")

        rs = From cat In db.categories
             Where cat.categoryID = b.categoryID
             Select cat

        dgv.DataSource = rs

        cmbCategory.SelectedItem = CStr(dgv.Rows(0).Cells(1).Value)
        txtAuthor.Text = b.authorName
        txtBookTitle.Text = b.bookTitle
        txtPrice.Text = b.price.ToString("f2")
        txtQuantity.Text = b.quantity
        dtpPublishDate.Text = b.publishDate
        txtLanguage.Text = b.language
        Try
            picBook.Image = Image.FromFile("..\..\Resources\BookImage\" & b.bookID.Trim & ".jpg")
        Catch ex As Exception
        End Try

        dgv.Visible = False
        dgvInsert.Dispose()
        dtpPublishDate.Format = DateTimePickerFormat.Custom
        dtpPublishDate.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        If cmbCategory.SelectedItem = "Other" Then
            txtOtherCategory.Enabled = True
            lblOther.Visible = True
        Else
            txtOtherCategory.Enabled = False
            lblOther.Visible = False
        End If
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim db As New DBDataContext
        Dim strCategoryName As String = ""
        b = db.books.FirstOrDefault(Function(o) o.bookID = selectedID)

        Dim rs1 = From c In db.categories
                  Where c.categoryID = b.categoryID
                  Select c
        Dim dgvCheck As New DataGridView
        Me.Controls.Add(dgvCheck)
        dgvCheck.Visible = False
        dgv.DataSource = rs1
        Dim oriCategory As String = b.categoryID
        Dim oriPrice As Double = CDbl(b.price)
        Dim oriPulishDate As String = b.publishDate
        Dim oriAuthor As String = b.authorName
        Dim oriLanguage As String = b.language

        Dim ans As Long = 0
        ans = MessageBox.Show("Do you want to save changes you made to " & b.bookTitle & "?", "Edit Book Details", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

        If ans = vbYes Then
            If validateCategory(cmbCategory) And validatePrice(txtPrice.Text, txtPrice) And validateLanguage() Then
                If cmbCategory.SelectedItem = "Other" Then
                    If txtOtherCategory.Text = "" Then
                        MessageBox.Show("Please fill up other category name", "Invalid Category", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtOtherCategory.Focus()
                        Exit Sub
                    Else
                        b.categoryID = FrmAddProduct.insertNewCategory(txtOtherCategory.Text.Trim)
                    End If
                Else
                    Dim rs = From c In db.categories
                             Where c.categoryName = cmbCategory.SelectedItem.ToString
                             Select c
                    dgv.DataSource = rs

                    b.categoryID = CStr(dgv.Rows(0).Cells(0).Value)
                End If

                b.authorName = txtAuthor.Text.Trim
                b.publishDate = dtpPublishDate.Value
                b.price = CDec(txtPrice.Text)
                b.language = txtLanguage.Text.Trim
                'SaveImageCopy(b.bookID.Trim, picBook.Image, "BookImage\")

                db.SubmitChanges()
                FrmProduct.disposeBookButton()
                FrmProduct.createBookBtn()
                wptr = New StreamWriter(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\BookEditHistory\" & b.bookID & ".txt"), True)

                If Not oriCategory = b.categoryID Then
                    wptr.WriteLine(Date.Today.ToShortDateString & " " & DateTime.Now.ToShortTimeString & " - Category changed from " & oriCategory.Trim & " to " & b.categoryID)
                End If

                If Not oriLanguage = b.language Then
                    wptr.WriteLine(Date.Today.ToLongDateString & " " & DateTime.Now.ToShortTimeString & " - Language changed from " & oriLanguage.Trim & " to " & b.language)
                End If

                If Not oriPulishDate = b.publishDate Then
                    wptr.WriteLine(Date.Today.ToShortDateString & " " & DateTime.Now.ToShortTimeString & " - Publish Date changed from " & oriPulishDate.Trim & " to " & b.publishDate)
                End If

                If Not oriAuthor = b.authorName Then
                    wptr.WriteLine(Date.Today.ToShortDateString & " " & DateTime.Now.ToShortTimeString & " - Author changed from " & oriAuthor.Trim & " to " & b.authorName)
                End If

                If Not oriPrice.ToString("f2") = b.price.ToString("f2") Then
                    wptr.WriteLine(Date.Today.ToShortDateString & " " & DateTime.Now.ToShortTimeString & " - Price changed from RM" & oriPrice.ToString("f2").Trim & " to RM" & b.price.ToString("f2"))
                End If

                wptr.Close()

                Me.Close()
            End If
        ElseIf ans = vbNo Then
            Me.Close()
            End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim db As New DBDataContext()
        b = db.books.FirstOrDefault(Function(o) o.bookID = selectedID)

        If b Is Nothing Then
            MessageBox.Show("Customer not found")
            Me.Close()
            Return
        End If

        Dim ans As Long = 0
        ans = MessageBox.Show("Do you want to delete " & b.bookTitle & "?", "Delete Book", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        Dim path As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\BookQRcode\"), b.bookID.Trim & "-" & b.bookTitle & ".jpg")
        If ans = vbOK Then
            b.status = False
            File.Delete(path)
            db.SubmitChanges()
            FrmProduct.disposeBookButton()
            FrmProduct.createBookBtn()
            wptr = New StreamWriter(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\BookEditHistory\" & b.bookID & ".txt"), True)

            wptr.WriteLine(Date.Today.ToShortDateString & " " & DateTime.Now.ToShortTimeString & " - " & b.bookTitle & " have been removed.")
            wptr.Close()
            Me.Close()
        End If
    End Sub

    Private Sub FrmEditProduct_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        cmbCategory.Items.Clear()
    End Sub

    Private Sub txtOtherCategory_TextChanged(sender As Object, e As EventArgs) Handles txtOtherCategory.TextChanged
        If txtOtherCategory.Text = "" Then
            lblOther.ForeColor = Color.Red
        Else
            lblOther.ForeColor = Color.Black
        End If
    End Sub

    Private Sub FrmEditProduct_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtOtherCategory.Clear()
        Dim db As New DBDataContext
        b = db.books.FirstOrDefault(Function(o) o.bookID = selectedID)

        wptr = New StreamWriter(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\BookEditHistory\" & b.bookID & ".txt"), True)
        wptr.Close()

        rptr = New StreamReader(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\BookEditHistory\" & b.bookID & ".txt"))

        While rptr.Peek <> -1
            lblHistory.Text = rptr.ReadToEnd
        End While

        rptr.Close()
    End Sub

    Private Sub FrmEditProduct_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        lblHistory.Text = ""
    End Sub

    'Private Sub picBook_Click(sender As Object, e As EventArgs) Handles picBook.Click
    '    Try
    '        Dim od As New OpenFileDialog
    '        od.InitialDirectory = Environment.SpecialFolder.MyPictures.ToString
    '        'AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\")

    '        If od.ShowDialog() = DialogResult.OK Then
    '            picBook.Load(od.FileName)
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show("Please select an image file", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub SaveImageCopy(filename As String, image As Image, p As String)
    ' Dim path As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\" & p), filename & ".jpg")
    'picBook.Dispose()
    'File.Delete(path)
    'Dim dest As New Bitmap(image.Width, image.Height)
    'Dim gfx As Graphics = Graphics.FromImage(dest)
    'gfx.DrawImageUnscaled(image, Point.Empty)
    'gfx.Dispose()
    'Try
    '    dest.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg)
    'Catch ex As Exception
    '    MessageBox.Show("Please Select .jpg as image", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End Try
    'dest.Dispose()

    'Dim pic As New PictureBox
    'pic.Name = "picBook"
    'pic.SizeMode = PictureBoxSizeMode.StretchImage
    'AddHandler picBook.Click, AddressOf picBook_Click
    'Me.Controls.Add(pic)
    ' End Sub
End Class