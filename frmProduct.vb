#Disable Warning IDE1006
Imports System.ComponentModel
Imports System.IO
Imports MessagingToolkit.QRCode.Codec

Public Class FrmProduct
    Dim reader As New QRCodeDecoder

    'create button for every category
    Public Sub createCategoryBtn()
        Dim btn As New Button
        Dim db As New DBDataContext
        Dim rs = From c In db.categories
                 Select c

        dgv.DataSource = rs

        For i As Integer = 0 To rs.Count - 1
            btn = New Button


            btn.Text = CStr(dgv.Rows(i).Cells(1).Value)
            btn.Name = CStr(dgv.Rows(i).Cells(0).Value)
            btn.Visible = True
            btn.Tag = "CategoryButton"
            btn.Font = New Font("Microsoft Sans Serif", 17)
            btn.Width = flpCategory.Width * 0.16
            btn.Height = flpCategory.Height * 0.24
            AddHandler btn.Click, AddressOf Me.ButtonCategory_Click
            AddHandler btn.MouseHover, AddressOf FrmProduct_MouseHover

            flpCategory.Controls.Add(btn)
        Next

    End Sub

    'create button for every book 
    Public Sub createBookBtn()
        Dim btn As New Button
        Dim db As New DBDataContext
        Dim rs = From b In db.books
                 Where b.status = True And b.bookID IsNot "memberCard"
                 Order By b.bookTitle Ascending
                 Select b

        dgv.DataSource = rs
        For i As Integer = 0 To rs.Count - 1
            btn = New Button
            btn.Text = CStr(dgv.Rows(i).Cells(1).Value)
            btn.Name = CStr(dgv.Rows(i).Cells(8).Value).ToUpper.Trim 'languages
            btn.Font = New Font("Microsoft Sans Serif", 12)
            btn.Width = flpCategory.Width * 0.19
            btn.Height = flpCategory.Height * 0.24
            btn.Tag = CStr(dgv.Rows(i).Cells(0).Value) 'ID
            AddHandler btn.Click, AddressOf Me.ButtonBook_Click
            AddHandler btn.MouseHover, AddressOf FrmProduct_MouseHover

            flpBook.Controls.Add(btn)
        Next
    End Sub

    Public Sub disposeCategoryButton()
        For i As Integer = flpCategory.Controls.Count - 1 To 0 Step -1
            Dim c = flpCategory.Controls(i)

            If (TypeOf c Is Button) And c.Tag = "CategoryButton" Then
                c.Dispose()           '' NOTE: disposing the control also removes it 
            End If
        Next
    End Sub

    Public Sub disposeBookButton()
        For i As Integer = flpBook.Controls.Count - 1 To 0 Step -1
            Dim c = flpBook.Controls(i)

            If (TypeOf c Is Button) Then
                c.Dispose()           '' NOTE: disposing the control also removes it
            End If
        Next
    End Sub

    'search book
    Private Sub searchBook()
        Dim strSearch As String = txtSearch.Text

        dgv = New DataGridView
        Me.Controls.Add(dgv)
        dgv.Visible = False

        invisibleBookButton()

        Dim db As New DBDataContext
        Dim rs = From b In db.books
                 Where b.bookTitle.Contains(strSearch) Or b.bookID.Contains(strSearch) And b.status = True
                 Select b

        dgv.DataSource = rs

        For i As Integer = 0 To rs.Count - 1
            For Each c As Control In flpBook.Controls
                If (TypeOf c Is Button) And CStr(dgv.Rows(i).Cells(0).Value).Equals(c.Tag) Then
                    c.Visible = True
                End If
            Next
        Next
    End Sub

    'search Category
    Private Sub searchCategory()
        Dim strSearch As String = "*" & txtSearch.Text & "*"

        Dim db As New DBDataContext
        Dim rs = From c In db.categories
                 Where c.categoryName Like strSearch
                 Select c
        dgv.DataSource = rs

        If Not txtSearch.Text = "" Then
            invisibleCategoryButton()
        End If

        For i As Integer = 0 To rs.Count - 1
            For Each c As Control In flpCategory.Controls
                If (TypeOf c Is Button) And CStr(dgv.Rows(i).Cells(0).Value).Equals(c.Name) Then
                    c.Visible = True
                End If
            Next
        Next
    End Sub

    'show the book that only related to the categories
    Private Sub categoriseBook(ByVal categoryID As String)
        invisibleBookButton()

        Dim db As New DBDataContext
        Dim rs = From b In db.books
                 Where b.categoryID = categoryID And b.status = True And b.bookID IsNot "memberCard"
                 Select b

        dgv.DataSource = rs
        For i As Integer = 0 To rs.Count - 1
            For Each c As Control In flpBook.Controls
                If (TypeOf c Is Button) And CStr(dgv.Rows(i).Cells(0).Value).Equals(c.Tag) Then
                    c.Visible = True
                End If
            Next
        Next
    End Sub

    'invisible all book button
    Private Sub invisibleBookButton()
        For Each c As Control In flpBook.Controls
            If TypeOf c Is Button Then
                c.Visible = False
            End If
        Next
    End Sub

    'invisible all category button
    Private Sub invisibleCategoryButton()
        For Each c As Control In flpCategory.Controls
            If (TypeOf c Is Button) And "CategoryButton".Equals(c.Tag) Then
                c.Visible = False
            End If
        Next
    End Sub

    'visible all category button
    Private Sub visibleCategoryButton()
        For Each c As Control In flpCategory.Controls
            If (TypeOf c Is Button) Then
                c.Visible = True
            End If
        Next
    End Sub

    'visible all book button
    Private Sub visibleBookButton()
        For Each c As Control In flpBook.Controls
            If (TypeOf c Is Button) Then
                c.Visible = True
            End If
        Next
    End Sub

    'create button for every categories 
    Private Sub FrmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'createLanguageCheckBox()

        'Me.BackColor = My.Settings.backgroundColor

        'Me.btnAddBook.BackColor = My.Settings.buttonColor
        'Me.btnAddBook.Font = My.Settings.buttonFont
        'Me.btnAddBook.ForeColor = My.Settings.buttonForeColor

        'Me.btnBack.BackColor = My.Settings.buttonColor
        'Me.btnBack.Font = My.Settings.buttonFont
        'Me.btnBack.ForeColor = My.Settings.buttonForeColor


        'Me.btnQRcode.BackColor = My.Settings.buttonColor
        'Me.btnQRcode.Font = My.Settings.buttonFont
        Me.btnQRcode.ForeColor = My.Settings.buttonForeColor

        'Me.btnRecover.BackColor = My.Settings.buttonColor
        'Me.btnRecover.Font = My.Settings.buttonFont
        Me.btnRecover.ForeColor = My.Settings.buttonForeColor

        'Me.btnStockIn.BackColor = My.Settings.buttonColor
        'Me.btnStockIn.Font = My.Settings.buttonFont
        Me.btnStockIn.ForeColor = My.Settings.buttonForeColor


        Me.Controls.Add(dgv)
        'dgv.Visible = False
        flpBook.Visible = False
        flpCategory.Visible = True
        radCategory.Checked = True
        'Dim db As New DBDataContext
        'Dim bookTitleName() As String = {"In Search of Lost Time", "Ulysses", "Don Quixote", "The Great Gatsby", "One Hundred Years of Solitude", "Moby Dick", "War and Peace", "Lolita", "Hamlet", "Hamlet", "The Catcher in the Rye", "The Odyssey", "The Brothers Karamazov", "Crime and Punishment", "Madame Bovary", "The Divine Comedy", "The Adventures of Huckleberry Finn", "Alice's Adventures in Wonderland", "Pride and Prejudice", "Wuthering Heights", "To the Lighthouse"}

        'Dim bookAuthor() As String = {"Marcel Proust", "James Joyce", "Miguel de Cervantes", "F. Scott Fitzgerald", "Gabriel Garcia Marquez", "Herman Melville", "Leo Tolstoy", "Vladimir Nabokov", "William Shakespeare", "William Shakespeare", "J. D. Salinger", "Homer", "Fyodor Dostoyevsky", "Fyodor Dostoyevsky", "Gustave Flaubert", "Dante Alighieri", "Mark Twain", "Lewis Carroll", "Jane Austen", "Emily Brontë", "Virginia Woolf"}

        'Dim price() As Double = {100, 123, 156, 189, 142, 134, 95, 125, 143, 45, 213, 189, 132, 174, 86, 156, 148, 85, 84, 96}

        'Dim quantity() As Integer = {50, 100, 53, 98, 45, 123, 156, 52, 64, 75, 95, 10, 5, 2, 1, 6, 0, 3, 4, 1}

        'Dim publishDate() As String = {"12/12/2019", "1/9/2019", "5/3/2019", "8/3/2019", "1/1/2019", "2/2/2019", "3/3/2019", "4/4/2019", "4/2/2019", "1/3/2019", "12/12/2019", "1/9/2019", "5/3/2019", "8/3/2019", "1/1/2019", "2/6/2019", "3/3/2019", "4/4/2019", "4/2/2019", "1/3/2019", "1/3/2019"}

        'Dim language() As String = {"English", "Mandarin", "English", "Melayu", "English", "English", "Mandarin", "English", "Mandarin", "English", "Melayu", "English", "English", "Mandarin", "English", "Melayu", "English", "English", "Mandarin", "English", "Melayu"}

        'Dim categoryID() As String = {"B01", "C01", "C02", "C03", "C01", "B01", "C01", "C02", "C03", "C01", "B01", "C01", "C02", "C03", "C01", "B01", "C01", "C02", "C03", "C01"}

        'For i As Integer = 0 To bookTitleName.Length - 1
        '    Dim b As New book
        '    b.authorName = bookAuthor(i)
        '    b.bookTitle = bookTitleName(i)
        '    b.language = language(i)
        '    b.publishDate = publishDate(i)
        '    b.quantity = quantity(i)
        '    b.price = price(i)
        '    b.bookID = FrmAddProduct.generateBookPrimaryKey(language(i).Chars(0), bookTitleName(i))
        '    b.status = True
        '    b.categoryID = categoryID(i)
        '    db.books.InsertOnSubmit(b)
        '    db.SubmitChanges()
        'Next
        'Dim categoryName() As String = {"Biography", "Reference Book", "Textbook", "Essay", "Mystery", "Romance", "Short Story"}

        'For i As Integer = 0 To categoryName.Length - 1
        '    Dim cat As New category
        '    cat.categoryName = categoryName(i)
        '    cat.categoryID = FrmAddProduct.generateCategoryPrimaryKey(categoryName(i))
        '    db.categories.InsertOnSubmit(cat)
        '    db.SubmitChanges()
        'Next

        ' Dim scienceFiction() As String = {""}
        createCategoryBtn()
        createBookBtn()
    End Sub

    'handle category button click 
    Public Sub ButtonCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btn As Button = sender
        flpCategory.Visible = False
        flpBook.Visible = True
        categoriseBook(btn.Name)
    End Sub

    'handle book button click
    Private Sub ButtonBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btn As Button = sender
        FrmEditProduct.selectedID = btn.Tag
        FrmEditProduct.ShowDialog(Me)
    End Sub

    'search
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If radBook.Checked Then
            flpBook.Visible = True
            flpCategory.Visible = False
            searchBook()
        Else
            flpBook.Visible = False
            flpCategory.Visible = True
            searchCategory()
        End If
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        txtSearch.Clear()
        txtSearch.BackColor = Color.White
        txtSearch.ForeColor = Color.Black
        If radBook.Checked Then
            flpBook.Visible = True
            flpCategory.Visible = False
        Else
            flpBook.Visible = False
            flpCategory.Visible = True
        End If
    End Sub

    'add
    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        FrmAddProduct.ShowDialog()
    End Sub

    'back
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If flpCategory.Visible Then
            Me.Close()
        End If
        txtSearch.Text = "Search"
        txtSearch.ForeColor = Color.DimGray
        txtSearch.BackColor = Color.WhiteSmoke
        flpBook.Visible = False
        flpCategory.Visible = True
        btnAddBook.Focus()
        visibleCategoryButton()
    End Sub

    Private Sub FrmProduct_Click(sender As Object, e As EventArgs) Handles Me.Click, flpBook.Click, flpCategory.Click
        If Not txtSearch.Text = "Search" Then
            txtSearch.Text = "Search"
            txtSearch.ForeColor = Color.DimGray
            txtSearch.BackColor = Color.WhiteSmoke
            btnAddBook.Focus()
            If radCategory.Checked Then
                flpBook.Visible = False
                flpCategory.Visible = True
                visibleCategoryButton()
            Else
                flpBook.Visible = True
                flpCategory.Visible = False
                visibleBookButton()
            End If
        End If
    End Sub

    Private Sub radCategory_CheckedChanged(sender As Object, e As EventArgs) Handles radCategory.CheckedChanged
        If radCategory.Checked Then
            txtSearch.Text = "Search"
            txtSearch.ForeColor = Color.DimGray
            txtSearch.BackColor = Color.WhiteSmoke
            cmbLanguage.Visible = False
            flpCategory.Visible = True
            flpBook.Visible = False
            flpLanguage.Visible = False
            visibleCategoryButton()
        End If
    End Sub

    Private Sub radBook_CheckedChanged(sender As Object, e As EventArgs) Handles radBook.CheckedChanged
        If radBook.Checked Then
            txtSearch.Text = "Search"
            txtSearch.ForeColor = Color.DimGray
            txtSearch.BackColor = Color.WhiteSmoke
            cmbLanguage.Visible = True
            flpCategory.Visible = False
            flpBook.Visible = True
            visibleBookButton()
        End If
    End Sub

    '
    Private Sub cmbLanguage_Click(sender As Object, e As EventArgs) Handles cmbLanguage.Click
        flpLanguage.Visible = True
        txtSearch.ForeColor = Color.DimGray
        txtSearch.BackColor = Color.WhiteSmoke

        txtSearch.ForeColor = Color.DimGray
        txtSearch.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub FrmProduct_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover, flpCategory.MouseHover, flpBook.MouseHover, txtSearch.MouseHover, radBook.MouseHover, radCategory.MouseHover, btnBack.MouseHover, btnAddBook.MouseHover, btnStockIn.MouseHover
        flpLanguage.Visible = False
    End Sub


    Private Sub btnStockIn_Click(sender As Object, e As EventArgs) Handles btnStockIn.Click
        frmStockInProduct.ShowDialog()
    End Sub

    Private Sub btnRecover_Click(sender As Object, e As EventArgs) Handles btnRecover.Click
        frmRecoverBook.ShowDialog()
    End Sub

    Private Sub btnQRcode_Click(sender As Object, e As EventArgs) Handles btnQRcode.Click
        Dim pic As New PictureBox
        Me.Controls.Add(pic)
        pic.Visible = False
        radBook.Checked = True
        Try
            Dim od As New OpenFileDialog
            od.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\Debug\", "Resources\BookQRcode\")
            If od.ShowDialog() = DialogResult.OK Then
                flpBook.Visible = True
                flpCategory.Visible = False
                pic.Load(od.FileName)

                reader = New QRCodeDecoder
                txtSearch.Text = reader.decode(New Data.QRCodeBitmapImage(pic.Image)).Trim
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub FrmProduct_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmHomepage.Show()
    End Sub


    Private Sub createLanguageCheckBox()
        Dim ckb As New CheckBox
        Dim db As New DBDataContext

        Dim rs = From b In db.books
                 Where b.status = True And b.bookID IsNot "memberCard"
                 Select b

        dgv.DataSource = rs
        ckb.Text = "Select All"
        ckb.Checked = True
        ckb.Width = flpLanguage.Width * 0.75
        ckb.Margin = New Padding(0, 0, 3, 0)
        AddHandler ckb.CheckedChanged, AddressOf ckb_CheckedChanged
        flpLanguage.Controls.Add(ckb)
        Dim flag As Boolean = False
        For i As Integer = 0 To rs.Count - 1
            flag = True
            For k As Integer = 0 To flpLanguage.Controls.Count - 1

                If CStr(dgv.Rows(i).Cells(8).Value).ToUpper.Trim.Equals(flpLanguage.Controls.Item(k).Text.ToUpper) Then
                    flag = False
                    Exit For
                End If
            Next

            If flag Then
                ckb = New CheckBox
                ckb.Text = CStr(dgv.Rows(i).Cells(8).Value).ToUpper.Trim
                ckb.Tag = CStr(dgv.Rows(i).Cells(8).Value).ToUpper.Trim
                ckb.Width = flpLanguage.Width * 0.75
                ckb.Checked = True
                ckb.Margin = New Padding(0, 0, 3, 0)
                flpLanguage.Controls.Add(ckb)
                AddHandler ckb.CheckedChanged, AddressOf ckb_CheckedChanged
            End If
        Next
    End Sub

    Private Sub ckb_CheckedChanged(sender As Object, e As EventArgs)
        Dim ckb As CheckBox = sender

        If ckb.Checked Then
            If ckb.Text = "Select All" Then
                For i As Integer = 1 To flpLanguage.Controls.Count - 1
                    DirectCast(flpLanguage.Controls.Item(i), CheckBox).Checked = True
                Next
            Else
                visibleLanguageBook(ckb.Tag)
            End If
        Else
            If ckb.Text = "Select All" Then
                For i As Integer = 1 To flpLanguage.Controls.Count - 1
                    DirectCast(flpLanguage.Controls.Item(i), CheckBox).Checked = False
                Next
            Else
                invisibleLanguageBook(ckb.Tag)
            End If
        End If
    End Sub

    Private Function visibleLanguageBook(language As String)
        For i As Integer = 0 To flpBook.Controls.Count - 1
            If flpBook.Controls.Item(i).Name.Equals(language) Then
                flpBook.Controls.Item(i).Visible = True
            End If
        Next
    End Function

    Private Function invisibleLanguageBook(language As String)
        For i As Integer = 0 To flpBook.Controls.Count - 1
            If flpBook.Controls.Item(i).Name.Equals(language) Then
                flpBook.Controls.Item(i).Visible = False
            End If
        Next
    End Function

    Private Sub FrmProduct_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        flpLanguage.Controls.Clear()
        createLanguageCheckBox()
        If radBook.Checked Then
            flpBook.Visible = True
            flpCategory.Visible = False
        Else
            flpCategory.Visible = True
            flpBook.Visible = False
        End If
    End Sub

    Private Sub FrmProduct_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If radBook.Checked Then
            flpBook.Visible = True
            flpCategory.Visible = False
        Else
            flpCategory.Visible = True
            flpBook.Visible = False
        End If
    End Sub
End Class