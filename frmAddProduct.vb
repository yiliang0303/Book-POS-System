#Disable Warning IDE1006
Imports System.ComponentModel
Imports MessagingToolkit.QRCode.Codec
Imports QRCoder

Public Class FrmAddProduct
    Dim reader As QRCodeDecoder
    Public Function generateCategoryPrimaryKey(ByVal strCategoryName As String) As String
        Dim db As New DBDataContext
        Dim primaryKey As String = ""
        Dim str As String = strCategoryName.Chars(0) & "*"

        Dim rs = From c In db.categories
                 Where c.categoryID Like str
                 Select c
        primaryKey = strCategoryName.ToUpper.Chars(0) & (rs.Count() + 1).ToString("00")

        Return primaryKey
    End Function

    Public Function insertNewCategory(ByVal strCategoryName As String) As String
        Dim db As New DBDataContext
        Dim cat As New category
        cat.categoryID = generateCategoryPrimaryKey(strCategoryName).Trim
        cat.categoryName = strCategoryName.Trim
        db.categories.InsertOnSubmit(cat)
        db.SubmitChanges()
        FrmProduct.disposeCategoryButton()
        FrmProduct.createCategoryBtn()

        Return cat.categoryID
    End Function

    Private Function generateBookPrimaryKey(fistLetter As Char) As String
        Dim db As New DBDataContext
        Dim rs = From b In db.books
                 Select b

        Dim primaryKey As String = fistLetter.ToString.ToUpper & Date.Today.ToString("yy") & rs.Count().ToString("0000")
        createQRcode(primaryKey, txtTitle.Text.Trim)
        Return primaryKey
    End Function

    Private Sub createQRcode(ByVal primaryKey As String, bookName As String)

        Dim gen As New QRCodeGenerator
        Dim data = gen.CreateQrCode(primaryKey, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        Dim picBox As New PictureBox
        picBox.Image = code.GetGraphic(6)
        SaveImageCopy(primaryKey & "-" & txtTitle.Text, picBox.Image, "BookQRcode\")
        'SaveImageCopy(primaryKey & "-" & bookName, picBox.Image, "BookQRcode\")
    End Sub

    Private Sub SaveImageCopy(filename As String, image As Image, p As String)
        Dim path As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\" & p), filename & ".jpg")
        Dim dest As New Bitmap(image.Width, image.Height)
        Dim gfx As Graphics = Graphics.FromImage(dest)
        gfx.DrawImageUnscaled(image, Point.Empty)
        gfx.Dispose()
        Try
            dest.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg)
        Catch ex As Exception
            MessageBox.Show("Please Select .jpg as image", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        dest.Dispose()
    End Sub

    Private Sub insertNewBook()
        Dim db As New DBDataContext
        Dim b As New book
        If cmbCategory.SelectedItem = "Other" Then
            b.categoryID = insertNewCategory(txtOtherCategory.Text.Trim)
        Else
            Dim rs = From c In db.categories
                     Where c.categoryName = cmbCategory.SelectedItem.ToString
                     Select c
            dgv.DataSource = rs

            b.categoryID = CStr(dgv.Rows(0).Cells(0).Value)
        End If



        b.bookID = generateBookPrimaryKey(txtLanguage.Text.Chars(0)).Trim
        b.bookTitle = txtTitle.Text.Trim
        b.price = CDec(txtPrice.Text)
        b.quantity = nudQuantity.Value
        b.authorName = txtAuthorName.Text.Trim
        b.publishDate = dtpPublishDate.Value
        b.language = txtLanguage.Text.Trim
        b.status = True

        If picBook.Image Is Nothing Then
            picBook.Image = Image.FromFile("..\..\Resources\BookImage\notfound.png")
            SaveImageCopy(b.bookID.Trim, picBook.Image, "BookImage\")
        Else
            SaveImageCopy(b.bookID.Trim, picBook.Image, "BookImage\")
        End If

        db.books.InsertOnSubmit(b)
        db.SubmitChanges()

        FrmProduct.disposeBookButton()
        FrmProduct.createBookBtn()
    End Sub

    Private Function validateBookTitle() As Boolean
        If txtTitle.Text = "" Then
            MessageBox.Show("Please fill up book title", "Invalid Title", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTitle.Focus()
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

    Private Function validateQuantity() As Boolean
        If Not nudQuantity.Value = 0 Then
            Return True
        Else
            MessageBox.Show("Please enter at least 1 in quantiy", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function

    Private Sub FrmAddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor
        Me.btnAdd.BackColor = My.Settings.buttonColor
        Me.btnAdd.Font = My.Settings.buttonFont
        Me.btnAdd.ForeColor = My.Settings.buttonForeColor

        dtpPublishDate.Format = DateTimePickerFormat.Custom
        dtpPublishDate.CustomFormat = "dd/MM/yyyy"

        Dim db As New DBDataContext
        Dim rs = From c In db.categories
                 Select c

        Dim dgvInsert As New DataGridView
        Me.Controls.Add(dgvInsert)
        dgvInsert.DataSource = rs

        For i As Integer = 0 To rs.Count - 1
            cmbCategory.Items.Add(dgvInsert.Rows(i).Cells(1).Value)
        Next
        cmbCategory.Items.Add("Other")
        dgvInsert.Dispose()

        cmbCategory.SelectedIndex = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim ans As Long = 0

        ans = MessageBox.Show("Add " & txtTitle.Text & " as New Book?", "Add New Book", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        If ans = vbYes Then
            If FrmEditProduct.validatePrice(txtPrice.Text, txtPrice) And FrmEditProduct.validateCategory(cmbCategory) And validateBookTitle() And validateQuantity() And validateLanguage() Then
                If cmbCategory.SelectedItem = "Other" And txtOtherCategory.Text = "" Then
                    MessageBox.Show("Please fill up other category name", "Invalid Category", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtOtherCategory.Focus()
                Else
                    insertNewBook()
                    Me.Close()
                End If
            End If
        ElseIf ans = vbNo Then
            Me.Close()
        End If
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

    Private Sub FrmAddProduct_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        cmbCategory.Items.Clear()
    End Sub

    Private Sub FrmAddProduct_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        cmbCategory.SelectedIndex = 0
        txtAuthorName.Clear()
        txtLanguage.Clear()
        txtOtherCategory.Clear()
        txtPrice.Clear()
        txtTitle.Clear()
        nudQuantity.Value = 0
    End Sub

    Private Sub picBook_Click(sender As Object, e As EventArgs) Handles picBook.Click
        Try
            Dim od As New OpenFileDialog
            od.InitialDirectory = Environment.SpecialFolder.MyPictures.ToString()

            If od.ShowDialog() = DialogResult.OK Then
                picBook.Load(od.FileName)
            End If

        Catch ex As Exception
            MessageBox.Show("Please select an image file", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtOtherCategory_TextChanged(sender As Object, e As EventArgs) Handles txtOtherCategory.TextChanged
        If txtOtherCategory.Text = "" Then
            lblOther.ForeColor = Color.Red
        Else
            lblOther.ForeColor = Color.Black
        End If
    End Sub
End Class