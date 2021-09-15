Imports System.Data.SqlClient

Public Class frmUserList
    Private Sub BindData()
        Dim name As String = txtSearch.Text
        Dim db As New DBDataContext
        Dim rs = From s In db.Staffs
                 Where s.staffID <> "SELF-POS"
                 Order By s.staffID
                 Select s.staffID, s.sName, s.sPosition
        dgv.DataSource = rs
        dgv.Columns(0).HeaderText = "Staff ID"
        dgv.Columns(1).HeaderText = "Staff Name"
        dgv.Columns(2).HeaderText = "Staff Position"
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        frmRegister.Show()
        Me.Close()
        frmRegister.Label2.Text = "Staff Registration"
        frmRegister.cboPosition.Enabled = False
        frmRegister.btnBack.Visible = True
        frmRegister.cboPosition.SelectedIndex = 1
        frmRegister.btnAdminRegister.Visible = False
        frmRegister.btnStaffRegister.Visible = True
        frmRegister.BackColor = My.Settings.backgroundColor
        frmRegister.btnAdminRegister.BackColor = My.Settings.buttonColor
        frmRegister.btnClear.BackColor = My.Settings.buttonColor
        frmRegister.btnStaffRegister.BackColor = My.Settings.buttonColor
        frmRegister.btnAdminRegister.Font = My.Settings.buttonFont
        frmRegister.btnClear.Font = My.Settings.buttonFont
        frmRegister.btnStaffRegister.Font = My.Settings.buttonFont
        frmRegister.btnClear.ForeColor = My.Settings.buttonForeColor
        frmRegister.btnAdminRegister.ForeColor = My.Settings.buttonForeColor
        frmRegister.btnStaffRegister.ForeColor = My.Settings.buttonForeColor

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim search As String = txtSearch.Text
        Dim db As New DBDataContext
        Dim rs = From s In db.Staffs
                 Where s.staffID <> "SELF-POS" And s.sName.ToUpper = search.ToUpper Or s.staffID.ToUpper = search.ToUpper
                 Select s.staffID, s.sName, s.sPosition
        dgv.DataSource = rs
        If rs.Count = 0 Then
            MessageBox.Show("No record")
            txtSearch.Clear()
            BindData()
        End If
    End Sub

    Private Sub frmUserList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor
        dgv.BackgroundColor = My.Settings.backgroundColor

        Me.btnRegister.BackColor = My.Settings.buttonColor
        Me.btnSearch.BackColor = My.Settings.buttonColor
        Me.btnBack.BackColor = My.Settings.buttonColor

        Me.btnRegister.Font = My.Settings.buttonFont
        Me.btnSearch.Font = My.Settings.buttonFont
        Me.btnBack.Font = My.Settings.buttonFont

        Me.btnRegister.ForeColor = My.Settings.buttonForeColor
        Me.btnSearch.ForeColor = My.Settings.buttonForeColor
        Me.btnBack.ForeColor = My.Settings.buttonForeColor

        BindData()
    End Sub

    Private Sub dgv_DoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim i As Integer = e.RowIndex
        If i > -1 Then
            Dim id As String = CStr(dgv.Rows(i).Cells(0).Value)
            frmUserProfile.selectedId = id
            frmUserProfile.Show()
            BindData()
            Me.Close()
        End If

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim search As String = txtSearch.Text
        Dim db As New DBDataContext
        Dim rs = From s In db.Staffs
                 Where s.staffID IsNot "SELF-POS" And s.sName IsNot "Self POS System" And s.sName.ToUpper.Contains(search.ToUpper) Or s.staffID.ToUpper.Contains(search.ToUpper)
                 Select s.staffID, s.sName, s.sPosition
        dgv.DataSource = rs
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmHomepage.Show()
    End Sub
End Class