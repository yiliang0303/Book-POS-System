Public Class frmSelectSummaryReport
    Private Sub BindDataCat()
        Dim db As New DBDataContext()
        Dim rs = From c In db.categories
                 Select c

        dgvCat.DataSource = rs
    End Sub

    Private Sub dynamicCheckBox(ByVal flag As Boolean)
        lstCat.Items.Clear()
        flp.Controls.Clear()
        For i = 0 To dgvCat.Rows.Count - 2
            'Check
            Dim chk As New CheckBox
            chk.Name = i
            chk.Text = CStr(dgvCat.Rows(i).Cells(1).Value)
            chk.Checked = flag
            chk.Visible = True
            If chk.Checked = True Then
                lstCat.Items.Add(chk.Text)
            End If
            AddHandler chk.CheckedChanged, AddressOf chkChecked
            flp.Controls.Add(chk)
        Next
    End Sub

    Private Sub chkChecked(ByVal sendr As Object, ByVal e As EventArgs)
        Dim chk As New CheckBox
        chk = DirectCast(sendr, CheckBox)
        If chk.Checked = True Then
            lstCat.Items.Add(chk.Text)
        Else
            lstCat.Items.Remove(chk.Text)
        End If
    End Sub

    Private Sub frmSelectSummaryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindDataCat()
        dynamicCheckBox(True)
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        frmSummaryReport.Show()
        Me.Hide()
    End Sub

    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
        dynamicCheckBox(True)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        dynamicCheckBox(False)
    End Sub

    Private Sub radSales_CheckedChanged(sender As Object, e As EventArgs) Handles radSales.CheckedChanged
        If radSales.Checked Then
            frmSummaryReport.type = radSales.Text
        Else
            frmSummaryReport.type = radQuantity.Text
        End If
    End Sub

    Private Sub radQuantity_CheckedChanged(sender As Object, e As EventArgs) Handles radQuantity.CheckedChanged
        If radSales.Checked Then
            frmSummaryReport.type = radSales.Text
        Else
            frmSummaryReport.type = radQuantity.Text
        End If
    End Sub
End Class