Imports System.Data.SqlClient
Public Class FrmReturnInwardReport

    Private Sub FrmReturnInwardReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BindDataReturn()
        Dim db As New DBDataContext()

        Dim rs = From br In db.BookReturns
                 Select br

        dgv.DataSource = rs
    End Sub


    Private Sub BindDataReturnDesQty()
        Dim db As New DBDataContext()


        Dim rs = From br In db.BookReturns
                 Order By br.Qty Descending
                 Select br


        dgv.DataSource = rs
    End Sub

    Private Sub BindDataReturnAscQty()


        Dim db As New DBDataContext()

        Dim rs = From br In db.BookReturns
                 Order By br.Qty, br.remark
                 Select br

        dgv.DataSource = rs
    End Sub

    Private Sub BindDataReturnS1()
        Dim db As New DBDataContext()
        Dim Qry = From br In db.BookReturns
                  Where br.StaffID = "20S00001"
                  Select br.StaffID

        dgv.DataSource = CType(Qry.FirstOrDefault, String
           )

        dgv.DataSource = Qry

    End Sub

    Private Sub BindDataReturnS2()
        Dim db As New DBDataContext()
        Dim Qry = From br In db.BookReturns.Select(Function(br) New With {.StaffID = br.StaffID("20S00002")})
                  Select br
        'Where br.StaffID = "20S00002"


        dgv.DataSource = CType(Qry.FirstOrDefault.StaffID, String)

        dgv.DataSource = Qry

    End Sub

    'Private Sub BindDataCount()
    '    Dim db As New DBDataContext()
    '    Dim Qry = From br In db.BookReturns
    '              Select br


    '    dgv.DataSource = CType(Qry.FirstOrDefault, String
    '       )

    '    dgv.DataSource = Qry

    'End Sub


    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Label5.Text = "Date: " & DateTime.Today.ToShortDateString.ToString()
        If ComboBox1.SelectedIndex = 1 Then
            BindDataReturn()
        ElseIf ComboBox1.SelectedIndex = 2 Then
            BindDataReturnDesQty()
        ElseIf ComboBox1.SelectedIndex = 3 Then
            BindDataReturnAscQty()


        End If
    End Sub
End Class