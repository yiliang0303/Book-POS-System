Imports System.Windows.Forms.DataVisualization.Charting
Public Class frmYearlySales
    Private Sub BindData()
        Dim db As New DBDataContext
        Dim rs = From td In db.TransactionDetails
                 Where td.Transaction.Status = "Paid"
                 Select td.book.price, td.qty, td.Transaction_ID
        dgv.DataSource = rs
    End Sub

    Dim s1 As New Series
    Private Sub DoChart()

        BindData()
        Chart1.Series.Clear()
        s1.ChartType = SeriesChartType.Column
        s1.CustomProperties = "PixelPointWidth=50"

        For i As Integer = 1 To 12
            Dim s1 As New Series
            s1.ChartType = SeriesChartType.FastLine
            If i = 1 Then
                s1.Name = "JANUARY"
            ElseIf i = 2 Then
                s1.Name = "FEBRUARY"
            ElseIf i = 3 Then
                s1.Name = "MARCH"
            ElseIf i = 4 Then
                s1.Name = "APRIL"
            ElseIf i = 5 Then
                s1.Name = "MAY"
            ElseIf i = 6 Then
                s1.Name = "JUNE"
            ElseIf i = 7 Then
                s1.Name = "JULY"
            ElseIf i = 8 Then
                s1.Name = "AUGUST"
            ElseIf i = 9 Then
                s1.Name = "SEPTEMBER"
            ElseIf i = 10 Then
                s1.Name = "OCTOBER"
            ElseIf i = 11 Then
                s1.Name = "NOVEMBER"
            Else
                s1.Name = "DECEMBER"
            End If

            Dim totalamount As Double = 0
            For Each rows As DataGridViewRow In dgv.Rows

                If CStr(rows.Cells(2).Value).Contains("19" & i.ToString("00")) Then
                    totalamount += CDbl(rows.Cells(0).Value) * CInt(rows.Cells(1).Value)
                End If
                s1.Points.AddXY(i, totalamount)

            Next
            Chart1.Series.Add(s1)
        Next
    End Sub

    Private Sub frmYearlySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoChart()
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
End Class