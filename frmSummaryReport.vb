Imports System.Windows.Forms.DataVisualization.Charting


Public Class frmSummaryReport
    Public selectedMonth As Double = 12
    Public selectedYear As Double = 19

    Private Sub BindDataCat()
        Dim db As New DBDataContext()
        Dim rs = From c In db.categories
                 Select c

        dgvCat.DataSource = rs
    End Sub

    Private Sub BindDataTD(ByVal cat As String)
        Dim db As New DBDataContext()

        Dim rs = From t In db.TransactionDetails
                 Where t.book.category.categoryName = cat And t.Transaction.Status = "Paid"
                 Select t.qty, t.book.price, t.Transaction_ID

        DataGridView1.DataSource = rs
    End Sub

    Dim s As New Series
    Public type As String = ""
    Private Sub DoChart()
        Chart1.Titles.Clear()
        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()

        Dim c As New ChartArea
        c.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount
        c.AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount
        c.AxisX.Minimum = 0
        c.AxisY.Minimum = 0
        c.AxisX.Maximum = 31
        Chart1.ChartAreas.Add(c)

        If frmSelectSummaryReport.radQuantity.Checked Then
            type = frmSelectSummaryReport.radQuantity.Text
        Else
            type = frmSelectSummaryReport.radSales.Text
        End If
        Dim selectedMonthText As String = frmReportPage.cboMonth.SelectedItem.ToString
        Chart1.Titles.Add("Monlty Sales Report (" & type & ") IN " & selectedMonthText & " 20" & selectedYear)

        BindDataCat()
        For Each itm In frmSelectSummaryReport.lstCat.Items
            Dim s As New Series
            s.Name = frmSelectSummaryReport.lstCat.GetItemText(itm)
            BindDataTD(frmSelectSummaryReport.lstCat.GetItemText(itm))
            s.ChartType = SeriesChartType.Line
            s.Points.AddXY(0, 0)
            For j As Integer = 1 To 31
                If frmSelectSummaryReport.radSales.Checked Then
                    Chart1.ChartAreas(0).AxisY.Title = "Sales"
                    s.CustomProperties = "MinPixelPointWidth = 100"
                    Dim dblPerDay As Double = 0
                    For Each rows As DataGridViewRow In DataGridView1.Rows
                        Dim dateTran As String = CStr(rows.Cells(2).Value)
                        Dim year As String = Microsoft.VisualBasic.Left(dateTran, 3)
                        Dim month As String = Microsoft.VisualBasic.Left(dateTran, 5)
                        Dim day As String = Microsoft.VisualBasic.Left(dateTran, 7)
                        year = Microsoft.VisualBasic.Right(year, 2)
                        month = Microsoft.VisualBasic.Right(month, 2)
                        day = Microsoft.VisualBasic.Right(day, 2)

                        If month = selectedMonth And day = j.ToString("00") And year = selectedYear Then
                            dblPerDay += CInt(rows.Cells(0).Value) * CDbl(rows.Cells(1).Value)
                        End If
                        s.Points.AddXY(j, CInt(dblPerDay))
                    Next
                ElseIf frmSelectSummaryReport.radQuantity.Checked Then
                    Chart1.ChartAreas(0).AxisY.Title = "Quantity"
                    s.CustomProperties = "MinPixelPointWidth = 100"
                    Dim dblQty As Integer = 0
                    For Each rows As DataGridViewRow In DataGridView1.Rows
                        Dim dateTran As String = CStr(rows.Cells(2).Value)
                        Dim year As String = Microsoft.VisualBasic.Left(dateTran, 3)
                        Dim month As String = Microsoft.VisualBasic.Left(dateTran, 5)
                        Dim day As String = Microsoft.VisualBasic.Left(dateTran, 7)
                        year = Microsoft.VisualBasic.Right(year, 2)
                        month = Microsoft.VisualBasic.Right(month, 2)
                        day = Microsoft.VisualBasic.Right(day, 2)

                        If month = selectedMonth And day = j.ToString("00") And year = selectedYear Then
                            dblQty += CDbl(rows.Cells(0).Value)
                        End If
                        s.Points.AddXY(j, dblQty)
                    Next
                End If
            Next
            Chart1.Series.Add(s)
        Next
    End Sub

    Private Sub frmReportSummary_Load_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DoChart()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmReportPage.Show()
        Me.Close()
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        frmSelectSummaryReport.Show()
        DoChart()
        DoChart()
    End Sub

    Private Sub frmSummaryReport_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DoChart()
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
End Class