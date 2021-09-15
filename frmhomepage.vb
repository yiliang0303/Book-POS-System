Public Class frmHomepage
    Private Sub frmhomepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        Dim btnImage1 As New Bitmap(New Bitmap(My.Resources.cash_register), 80, 80)
        btnStartBusiness.Image = btnImage1
        btnStartBusiness.ImageAlign = ContentAlignment.MiddleCenter

        Dim btnImage2 As New Bitmap(New Bitmap(My.Resources.inventory), 80, 80)
        btnInventory.Image = btnImage2
        btnInventory.ImageAlign = ContentAlignment.MiddleCenter

        Dim btnImage3 As New Bitmap(New Bitmap(My.Resources.staff__1_), 80, 80)
        btnUserMaintenance.Image = btnImage3
        btnUserMaintenance.ImageAlign = ContentAlignment.MiddleCenter

        Dim btnImage4 As New Bitmap(New Bitmap(My.Resources.report__1_), 80, 80)
        btnReport.Image = btnImage4
        btnReport.ImageAlign = ContentAlignment.MiddleCenter

        Dim btnImage5 As New Bitmap(New Bitmap(My.Resources.gear), 80, 80)
        btnSetting.Image = btnImage5
        btnSetting.ImageAlign = ContentAlignment.MiddleCenter

        Dim btnImage6 As New Bitmap(New Bitmap(My.Resources.Button_Log_Off_icon), 80, 80)
        btnLogout.Image = btnImage6
        btnLogout.ImageAlign = ContentAlignment.MiddleCenter

    End Sub

    Private Sub btnStartBusiness_Click(sender As Object, e As EventArgs) Handles btnStartBusiness.Click
        frmLogin.Show()
        frmLogin.txtPassword.Clear()
        frmLogin.txtUsername.Clear()
        frmLogin.btnBack.Visible = True
        frmLogin.lblAdmin.Text = "Cashier Login"
        frmLogin.btnSelfPOS.Visible = True
        frmLogin.btnCashierLogin.Visible = True
        frmLogin.btnAdminLogin.Visible = False
        frmLogin.picStaff.Visible = True
        frmLogin.picAdmin.Visible = False

        frmLogin.BackColor = My.Settings.backgroundColor
        frmLogin.btnAdminLogin.BackColor = My.Settings.buttonColor
        frmLogin.btnAdminLogin.Font = My.Settings.buttonFont
        frmLogin.btnAdminLogin.ForeColor = My.Settings.buttonForeColor
        frmLogin.btnCashierLogin.BackColor = My.Settings.buttonColor
        frmLogin.btnCashierLogin.Font = My.Settings.buttonFont
        frmLogin.btnCashierLogin.ForeColor = My.Settings.buttonForeColor
        frmLogin.btnSelfPOS.BackColor = My.Settings.buttonColor
        frmLogin.btnSelfPOS.Font = My.Settings.buttonFont
        frmLogin.btnSelfPOS.ForeColor = My.Settings.buttonForeColor
        Me.Hide()

    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        frmSetting.Show()
        Me.Hide()
    End Sub

    Private Sub btnUserMaintenance_Click(sender As Object, e As EventArgs) Handles btnUserMaintenance.Click
        Me.Hide()
        frmUserList.Show()
        frmUserList.BackColor = My.Settings.backgroundColor
        frmUserList.btnRegister.BackColor = My.Settings.buttonColor
        frmUserList.btnRegister.Font = My.Settings.buttonFont
        frmUserList.btnSearch.BackColor = My.Settings.buttonColor
        frmUserList.btnSearch.Font = My.Settings.buttonFont
        frmUserList.dgv.BackgroundColor = My.Settings.backgroundColor
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim intResult As Integer = 0
        intResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If intResult = vbYes Then
            frmLogin.Show()
            frmLogin.btnBack.Visible = False
            frmLogin.lblAdmin.Text = "Admin Login"
            frmLogin.btnSelfPOS.Visible = False
            frmLogin.btnCashierLogin.Visible = False
            frmLogin.btnAdminLogin.Visible = True
            frmLogin.txtPassword.Clear()
            frmLogin.txtUsername.Clear()
            Me.Close()
        End If
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        frmReportPage.Show()
        Me.Hide()

    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Me.Hide()
        FrmProduct.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class