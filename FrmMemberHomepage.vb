Imports System.Data.SqlClient
Public Class FrmMemberHomepage
    Public selectedID As String



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub lblMyshelf_Click(sender As Object, e As EventArgs)
        'GroupBox2.Visible = True
        'PanelColumn.Visible = False
        'btnUpdate.Visible = True
        'dgv.Visible = True
        'Dim dgvTextColumn4 As New DataGridViewTextBoxColumn
        'dgvTextColumn4.HeaderText = "SubTotal"

        'Dim dgvTextColumn3 As New DataGridViewTextBoxColumn
        'dgvTextColumn3.HeaderText = "Quantity"

        'Dim dgvTextColumn2 As New DataGridViewTextBoxColumn
        'dgvTextColumn2.HeaderText = "Price"

        'Dim dgvTextColumn1 As New DataGridViewTextBoxColumn
        'dgvTextColumn1.HeaderText = "Description"

        'Dim dgvImageColumn As New DataGridViewImageColumn
        'dgvImageColumn.HeaderText = "Image"
        'dgvImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch

        'Dim dgvTextColumn As New DataGridViewTextBoxColumn
        'dgvTextColumn.HeaderText = "Id"

        'dgv.Columns.Add(dgvTextColumn)
        'dgv.Columns.Add(dgvImageColumn)
        'dgv.Columns.Add(dgvTextColumn1)
        'dgv.Columns.Add(dgvTextColumn2)
        'dgv.Columns.Add(dgvTextColumn3)
        'dgv.Columns.Add(dgvTextColumn4)

        'dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        'dgv.RowTemplate.Height = 120
        'dgv.AllowUserToAddRows = False

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        FrmMemberEdit.ShowDialog()
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        FrmMemberEdit.ShowDialog()
        Me.Close()

    End Sub



    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        FrmMemberResetPassword.Show()
        Me.Close()


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        'Dim search As String = txtSearch.Text.ToLower
        'Dim db As New Db1DataContext
        'Dim rs = From b In db.books
        '         Where b.bookTitle.ToLower = search
        '         Select b.bookID, b.picture, b.bookTitle, b.authorName, b.quantity_, b.price


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        FrmMemberResetPassword.ShowDialog()
        FrmMemberResetPassword.Enabled = True
        Me.Close()

    End Sub

    Private Sub FrmMemberHomepage_Closed(sender As Object, e As EventArgs) Handles Me.Closed


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        FrmBookDetails.mSelectedID = selectedID
        FrmBookDetails.ShowDialog()
        Me.Hide()

    End Sub

    Private Sub FrmMemberHomepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Dim ans As Long = MessageBox.Show("You are signing out of myBook apps on this device", "Confirm Sign Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If ans = vbOK Then
            Me.Dispose(False)
            'Me.Close()
            'FrmMemberLogin.Show()
            FrmMemberLogout.Show()
        End If
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim ans As Long = MessageBox.Show("You are signing out of myBook apps on this device", "Confirm Sign Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If ans = vbOK Then
            Me.Dispose(False)
            'Me.Close()
            'FrmMemberLogin.Show()
            FrmMemberLogout.Show()
        End If
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click
        frmOrder.btnCancel.PerformClick()
        Me.Close()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Dispose(False)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        frmOrder.Show()
        Me.Dispose(False)
    End Sub
End Class