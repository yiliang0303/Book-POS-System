Public Class FrmBookDetails
    Public mSelectedID As String
    Public selectedID As String
    Private Sub BindData()
        Dim search As String = txtSearch.Text

        Dim db As New DBDataContext()
        If cboSearchType.SelectedIndex = 0 Then
            Dim rs = From b In db.books
                     Where b.bookTitle.Contains(search) And b.bookTitle IsNot "Member Card"
                     Select b
            dgv.DataSource = rs
        ElseIf cboSearchType.SelectedIndex = 1 Then
            Dim rs = From b In db.books
                     Where b.bookID.Contains(search) And b.bookTitle IsNot "Member Card"
                     Select b
            dgv.DataSource = rs
            'ElseIf cboSearchType.SelectedIndex = 2 Then
            '    Dim rs = From b In db.books
            '             Where b.category.categoryName.Contains(cboCategories.Text) And b.bookTitle IsNot "Member Card"
            '             Select b
            '    dgv.DataSource = rs
        End If
    End Sub

    Private Sub DynamicButton()
        Dim totalwidth As Integer = 0
        Dim x As Integer = 0
        Dim y As Integer = 0
        flpBook.Controls.Clear()

        For i = 0 To dgv.Rows.Count - 2
            'Panel
            Dim pnl As New Panel
            pnl.Name = "txt" & i
            pnl.Enabled = True
            pnl.Dock = DockStyle.Top
            pnl.Visible = True
            flpBook.Controls.Add(pnl)
            pnl.Width = 180
            pnl.Height = 200

            'lblPrice
            Dim lblPrice As New Label
            Dim dblPrice As Double = CDbl(dgv.Rows(i).Cells(2).Value)
            lblPrice.Text = "RM " & dblPrice.ToString("f2")
            lblPrice.Name = "lblPrice" & i
            lblPrice.Dock = DockStyle.Top
            lblPrice.Visible = True
            lblPrice.BorderStyle = BorderStyle.Fixed3D
            lblPrice.Anchor = AnchorStyles.Left + AnchorStyles.Top
            pnl.Controls.Add(lblPrice)

            If CInt(dgv.Rows(i).Cells(3).Value) = 0 Then
                pnl.Enabled = True
                Dim lblSoldOut As New Label
                lblSoldOut.Text = "(Sold Out)"
                lblSoldOut.Name = "lblSoldOut" & i
                lblSoldOut.Dock = DockStyle.None
                lblSoldOut.Visible = True
                lblSoldOut.Anchor = AnchorStyles.Left + AnchorStyles.Top
                lblSoldOut.BorderStyle = BorderStyle.Fixed3D
                pnl.Controls.Add(lblSoldOut)
            End If

            'LabelName
            Dim lbl As New Label
            Dim strName As String = CStr(dgv.Rows(i).Cells(1).Value)
            lbl.Text = strName
            lbl.Name = "lbl" & i
            lbl.Dock = DockStyle.Top
            lbl.Visible = True
            lbl.Anchor = AnchorStyles.Left + AnchorStyles.Top
            pnl.Controls.Add(lbl)

            'Picture
            Dim pb As New PictureBox
            pb.Name = i
            pb.Width = 100 'or whatever
            pb.Height = 100
            pb.Visible = True
            pb.Image = Image.FromFile("..\..\Resources\BookImage\" & CStr(dgv.Rows(i).Cells(0).Value).Trim & ".jpg")
            pnl.Controls.Add(pb)
            pb.SizeMode = PictureBoxSizeMode.StretchImage
            pb.Dock = DockStyle.Top
            AddHandler pb.Click, AddressOf Me.ClickPicture
        Next
    End Sub

    Private Sub pb_click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FrmBookDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        cboSearchType.SelectedIndex = 0
        BindData()
        DynamicButton()
    End Sub

    Private Sub ClickPicture(ByVal sendr As Object, ByVal e As EventArgs)

        Dim pb As New PictureBox
        pb = DirectCast(sendr, PictureBox)
        Dim strID As String = CStr(dgv.Rows(pb.Name).Cells(0).Value)
        Dim strName As String = CStr(dgv.Rows(pb.Name).Cells(1).Value)
        Dim dblPrice As Double = CDbl(dgv.Rows(pb.Name).Cells(2).Value)
        Dim intQtyLeft As Integer = CInt(dgv.Rows(pb.Name).Cells(3).Value)

        FrmCommentBook.selectedID = strID
        FrmCommentBook.lblTitle.Text = strName
        FrmCommentBook.lblPrice.Text = dblPrice
        FrmCommentBook.lblQuantity.Text = intQtyLeft
        FrmCommentBook.ShowDialog()

        'For Each row As DataGridViewRow In dgvCart.Rows
        '    If row.Cells(0).Value = strName Then
        '        row.Cells(1).Value = CInt(row.Cells(1).Value) + 1
        '        row.Cells(2).Value = (CInt(row.Cells(1).Value) * dblPrice).ToString("f2")
        '        SubmitQuantityLeft(strID, 1)
        '        ShowTotal()
        '        Exit Sub
        '    End If
        'Next

        'dgvCart.Rows.Add(strName, "1", dblPrice.ToString("f2"), strID)

        'SubmitQuantityLeft(strID, 1)
        'ShowTotal()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        BindData()
        DynamicButton()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub flpBook_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click


        Me.Hide()
        FrmMemberHomepage.Show()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub lblBookshelf_Click(sender As Object, e As EventArgs) Handles lblBookshelf.Click

    End Sub

    Private Sub flpBook_Paint_1(sender As Object, e As PaintEventArgs) Handles flpBook.Paint

    End Sub
End Class