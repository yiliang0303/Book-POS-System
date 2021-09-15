Public Class frmReportPage
    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        cboName.Items.Clear()
        If cboType.SelectedIndex = 0 Then
            cboName.Items.Add("Monthly Sales Report")
            cboName.Items.Add("Yearly Sales Report")
        ElseIf cboType.SelectedIndex = 1 Then
            cboName.Items.Add("Return Inward Report")
        ElseIf cboType.SelectedIndex = 2 Then
            cboName.Items.Add("Stock Inventory Item Below Certain Quantity")
        End If
    End Sub

    Private Sub frmReportPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        btnGenerate.BackColor = My.Settings.buttonColor
        btnBack.BackColor = My.Settings.buttonColor

        btnGenerate.Font = My.Settings.buttonFont
        btnBack.Font = My.Settings.buttonFont
    End Sub

    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        If cboType.SelectedIndex = 2 And cboName.SelectedIndex = 0 Then
            lblQuantity.Visible = True
            txtQuantity.Visible = True
            cboMonth.Visible = False
            cboYear.Visible = False
            lblYear.Visible = False
            lblMonth.Visible = False
            txtTop.Visible = False
            lblTop.Visible = False
        ElseIf cboType.SelectedIndex = 1 And cboName.SelectedIndex = 0 Then
            cboMonth.Visible = False
            cboYear.Visible = False
            lblYear.Visible = False
            lblMonth.Visible = False
            lblQuantity.Visible = False
            txtQuantity.Visible = False
            txtTop.Visible = False
            lblTop.Visible = False
        ElseIf cboType.SelectedIndex = 0 And cboName.SelectedIndex = 0 Then
            cboMonth.Visible = True
            cboYear.Visible = True
            lblYear.Visible = True
            lblMonth.Visible = True
            lblQuantity.Visible = False
            txtQuantity.Visible = False
            txtTop.Visible = False
            lblTop.Visible = False
        ElseIf cboType.SelectedIndex = 0 And cboName.SelectedIndex = 1 Then
            txtTop.Visible = False
            lblTop.Visible = False
            cboMonth.Visible = False
            cboYear.Visible = True
            lblYear.Visible = True
            lblMonth.Visible = False
            lblQuantity.Visible = False
            txtQuantity.Visible = False
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmHomepage.Show()
        Me.Hide()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Try

            If cboName.SelectedItem.ToString().Contains("Monthly Sales Report") Then
                Me.Hide()
                If cboYear.SelectedItem.ToString() <> "2019" And cboYear.SelectedItem.ToString() <> "2020" Then
                    MessageBox.Show("Invalid Report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    frmSummaryReport.selectedMonth = cboMonth.SelectedIndex + 1
                    frmSummaryReport.selectedYear = CInt(cboYear.SelectedItem.ToString().Replace("20", ""))
                    frmSelectSummaryReport.ShowDialog()
                End If
            ElseIf cboName.SelectedItem.ToString().Contains("Yearly Sales Report") Then
                If cboYear.SelectedItem.ToString() <> "2019" Then
                    MessageBox.Show("Invalid Report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    frmYearlySales.ShowDialog()
                End If
            ElseIf cboName.SelectedItem.ToString().Contains("Return") Then
                FrmReturnInwardReport.ShowDialog()
            ElseIf cboName.SelectedItem.ToString().Contains("Inventory") Then
                frmInventoryLevelReport.qtyLevel = CInt(txtQuantity.Text)
                frmInventoryLevelReport.ShowDialog()
            End If

        Catch ex As Exception
            MessageBox.Show("Invalid Report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        Dim postCode As Integer = 0
        Try
            postCode = CInt(txtQuantity.Text)
        Catch ex As Exception
            If txtQuantity.Text = "" Then

            Else
                MessageBox.Show("Invalid Input")
            End If
            txtQuantity.Clear()
            txtQuantity.Focus()
        End Try
    End Sub
End Class