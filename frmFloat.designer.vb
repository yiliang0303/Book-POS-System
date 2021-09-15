<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFloat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblInform = New System.Windows.Forms.Label()
        Me.lblRM100 = New System.Windows.Forms.Label()
        Me.lblRM50 = New System.Windows.Forms.Label()
        Me.lblRM20 = New System.Windows.Forms.Label()
        Me.lblRM10 = New System.Windows.Forms.Label()
        Me.lblRM5 = New System.Windows.Forms.Label()
        Me.lblRM1 = New System.Windows.Forms.Label()
        Me.lbl50Sen = New System.Windows.Forms.Label()
        Me.lbl20sen = New System.Windows.Forms.Label()
        Me.lbl10sen = New System.Windows.Forms.Label()
        Me.lbl5sen = New System.Windows.Forms.Label()
        Me.txtRM100 = New System.Windows.Forms.TextBox()
        Me.txtRM50 = New System.Windows.Forms.TextBox()
        Me.txtRM20 = New System.Windows.Forms.TextBox()
        Me.txtRM10 = New System.Windows.Forms.TextBox()
        Me.txtRM5 = New System.Windows.Forms.TextBox()
        Me.txtRM1 = New System.Windows.Forms.TextBox()
        Me.txt50sen = New System.Windows.Forms.TextBox()
        Me.txt20sen = New System.Windows.Forms.TextBox()
        Me.txt10sen = New System.Windows.Forms.TextBox()
        Me.txt5sen = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblFloat = New System.Windows.Forms.Label()
        Me.txtFloat = New System.Windows.Forms.TextBox()
        Me.grpCal = New System.Windows.Forms.GroupBox()
        Me.lblDigitOnly = New System.Windows.Forms.Label()
        Me.lblBalanceRm = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.txtTotalFnT = New System.Windows.Forms.TextBox()
        Me.lblTotalFnT = New System.Windows.Forms.Label()
        Me.txtTransaction = New System.Windows.Forms.TextBox()
        Me.lblTotalTran = New System.Windows.Forms.Label()
        Me.btnEditRM100 = New System.Windows.Forms.Button()
        Me.btnEditRM50 = New System.Windows.Forms.Button()
        Me.btnEditRM20 = New System.Windows.Forms.Button()
        Me.btnEditRM10 = New System.Windows.Forms.Button()
        Me.btnEditRM5 = New System.Windows.Forms.Button()
        Me.btnEditRM1 = New System.Windows.Forms.Button()
        Me.btnEdit50sen = New System.Windows.Forms.Button()
        Me.btnEdit20sen = New System.Windows.Forms.Button()
        Me.btnEdit10sen = New System.Windows.Forms.Button()
        Me.btnEdit5sen = New System.Windows.Forms.Button()
        Me.lblPress = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpCal.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInform
        '
        Me.lblInform.AutoSize = True
        Me.lblInform.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInform.Location = New System.Drawing.Point(12, 9)
        Me.lblInform.Name = "lblInform"
        Me.lblInform.Size = New System.Drawing.Size(213, 22)
        Me.lblInform.TabIndex = 0
        Me.lblInform.Text = "Please Key in Your Float:"
        '
        'lblRM100
        '
        Me.lblRM100.AutoSize = True
        Me.lblRM100.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRM100.Location = New System.Drawing.Point(12, 44)
        Me.lblRM100.Name = "lblRM100"
        Me.lblRM100.Size = New System.Drawing.Size(82, 26)
        Me.lblRM100.TabIndex = 1
        Me.lblRM100.Text = "RM100 :"
        '
        'lblRM50
        '
        Me.lblRM50.AutoSize = True
        Me.lblRM50.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRM50.Location = New System.Drawing.Point(22, 80)
        Me.lblRM50.Name = "lblRM50"
        Me.lblRM50.Size = New System.Drawing.Size(72, 26)
        Me.lblRM50.TabIndex = 2
        Me.lblRM50.Text = "RM50 :"
        Me.lblRM50.Visible = False
        '
        'lblRM20
        '
        Me.lblRM20.AutoSize = True
        Me.lblRM20.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRM20.Location = New System.Drawing.Point(22, 115)
        Me.lblRM20.Name = "lblRM20"
        Me.lblRM20.Size = New System.Drawing.Size(72, 26)
        Me.lblRM20.TabIndex = 3
        Me.lblRM20.Text = "RM20 :"
        Me.lblRM20.Visible = False
        '
        'lblRM10
        '
        Me.lblRM10.AutoSize = True
        Me.lblRM10.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRM10.Location = New System.Drawing.Point(22, 151)
        Me.lblRM10.Name = "lblRM10"
        Me.lblRM10.Size = New System.Drawing.Size(72, 26)
        Me.lblRM10.TabIndex = 4
        Me.lblRM10.Text = "RM10 :"
        Me.lblRM10.Visible = False
        '
        'lblRM5
        '
        Me.lblRM5.AutoSize = True
        Me.lblRM5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRM5.Location = New System.Drawing.Point(32, 187)
        Me.lblRM5.Name = "lblRM5"
        Me.lblRM5.Size = New System.Drawing.Size(62, 26)
        Me.lblRM5.TabIndex = 5
        Me.lblRM5.Text = "RM5 :"
        Me.lblRM5.Visible = False
        '
        'lblRM1
        '
        Me.lblRM1.AutoSize = True
        Me.lblRM1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRM1.Location = New System.Drawing.Point(32, 223)
        Me.lblRM1.Name = "lblRM1"
        Me.lblRM1.Size = New System.Drawing.Size(62, 26)
        Me.lblRM1.TabIndex = 6
        Me.lblRM1.Text = "RM1 :"
        Me.lblRM1.Visible = False
        '
        'lbl50Sen
        '
        Me.lbl50Sen.AutoSize = True
        Me.lbl50Sen.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl50Sen.Location = New System.Drawing.Point(19, 259)
        Me.lbl50Sen.Name = "lbl50Sen"
        Me.lbl50Sen.Size = New System.Drawing.Size(75, 26)
        Me.lbl50Sen.TabIndex = 7
        Me.lbl50Sen.Text = "50sen :"
        Me.lbl50Sen.Visible = False
        '
        'lbl20sen
        '
        Me.lbl20sen.AutoSize = True
        Me.lbl20sen.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl20sen.Location = New System.Drawing.Point(19, 295)
        Me.lbl20sen.Name = "lbl20sen"
        Me.lbl20sen.Size = New System.Drawing.Size(75, 26)
        Me.lbl20sen.TabIndex = 8
        Me.lbl20sen.Text = "20sen :"
        Me.lbl20sen.Visible = False
        '
        'lbl10sen
        '
        Me.lbl10sen.AutoSize = True
        Me.lbl10sen.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10sen.Location = New System.Drawing.Point(19, 331)
        Me.lbl10sen.Name = "lbl10sen"
        Me.lbl10sen.Size = New System.Drawing.Size(75, 26)
        Me.lbl10sen.TabIndex = 9
        Me.lbl10sen.Text = "10sen :"
        Me.lbl10sen.Visible = False
        '
        'lbl5sen
        '
        Me.lbl5sen.AutoSize = True
        Me.lbl5sen.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5sen.Location = New System.Drawing.Point(29, 367)
        Me.lbl5sen.Name = "lbl5sen"
        Me.lbl5sen.Size = New System.Drawing.Size(65, 26)
        Me.lbl5sen.TabIndex = 10
        Me.lbl5sen.Text = "5sen :"
        Me.lbl5sen.Visible = False
        '
        'txtRM100
        '
        Me.txtRM100.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRM100.Location = New System.Drawing.Point(100, 44)
        Me.txtRM100.Name = "txtRM100"
        Me.txtRM100.Size = New System.Drawing.Size(100, 30)
        Me.txtRM100.TabIndex = 11
        '
        'txtRM50
        '
        Me.txtRM50.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRM50.Location = New System.Drawing.Point(100, 80)
        Me.txtRM50.Name = "txtRM50"
        Me.txtRM50.Size = New System.Drawing.Size(100, 30)
        Me.txtRM50.TabIndex = 12
        Me.txtRM50.Visible = False
        '
        'txtRM20
        '
        Me.txtRM20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRM20.Location = New System.Drawing.Point(100, 115)
        Me.txtRM20.Name = "txtRM20"
        Me.txtRM20.Size = New System.Drawing.Size(100, 30)
        Me.txtRM20.TabIndex = 13
        Me.txtRM20.Visible = False
        '
        'txtRM10
        '
        Me.txtRM10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRM10.Location = New System.Drawing.Point(100, 151)
        Me.txtRM10.Name = "txtRM10"
        Me.txtRM10.Size = New System.Drawing.Size(100, 30)
        Me.txtRM10.TabIndex = 14
        Me.txtRM10.Visible = False
        '
        'txtRM5
        '
        Me.txtRM5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRM5.Location = New System.Drawing.Point(100, 187)
        Me.txtRM5.Name = "txtRM5"
        Me.txtRM5.Size = New System.Drawing.Size(100, 30)
        Me.txtRM5.TabIndex = 15
        Me.txtRM5.Visible = False
        '
        'txtRM1
        '
        Me.txtRM1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRM1.Location = New System.Drawing.Point(100, 223)
        Me.txtRM1.Name = "txtRM1"
        Me.txtRM1.Size = New System.Drawing.Size(100, 30)
        Me.txtRM1.TabIndex = 16
        Me.txtRM1.Visible = False
        '
        'txt50sen
        '
        Me.txt50sen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt50sen.Location = New System.Drawing.Point(100, 259)
        Me.txt50sen.Name = "txt50sen"
        Me.txt50sen.Size = New System.Drawing.Size(100, 30)
        Me.txt50sen.TabIndex = 17
        Me.txt50sen.Visible = False
        '
        'txt20sen
        '
        Me.txt20sen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt20sen.Location = New System.Drawing.Point(100, 295)
        Me.txt20sen.Name = "txt20sen"
        Me.txt20sen.Size = New System.Drawing.Size(100, 30)
        Me.txt20sen.TabIndex = 18
        Me.txt20sen.Visible = False
        '
        'txt10sen
        '
        Me.txt10sen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt10sen.Location = New System.Drawing.Point(100, 331)
        Me.txt10sen.Name = "txt10sen"
        Me.txt10sen.Size = New System.Drawing.Size(100, 30)
        Me.txt10sen.TabIndex = 19
        Me.txt10sen.Visible = False
        '
        'txt5sen
        '
        Me.txt5sen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5sen.Location = New System.Drawing.Point(100, 367)
        Me.txt5sen.Name = "txt5sen"
        Me.txt5sen.Size = New System.Drawing.Size(100, 30)
        Me.txt5sen.TabIndex = 20
        Me.txt5sen.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(111, 24)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(71, 26)
        Me.lblTotal.TabIndex = 21
        Me.lblTotal.Text = "Total :"
        Me.lblTotal.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(188, 24)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(162, 30)
        Me.txtTotal.TabIndex = 22
        Me.txtTotal.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnReset, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnConfirm, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 421)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(654, 52)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'btnReset
        '
        Me.btnReset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(221, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(212, 46)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        Me.btnReset.Visible = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConfirm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(439, 3)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(212, 46)
        Me.btnConfirm.TabIndex = 0
        Me.btnConfirm.Text = "&Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        Me.btnConfirm.Visible = False
        '
        'lblFloat
        '
        Me.lblFloat.AutoSize = True
        Me.lblFloat.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFloat.Location = New System.Drawing.Point(110, 60)
        Me.lblFloat.Name = "lblFloat"
        Me.lblFloat.Size = New System.Drawing.Size(72, 26)
        Me.lblFloat.TabIndex = 24
        Me.lblFloat.Text = "Float :"
        Me.lblFloat.Visible = False
        '
        'txtFloat
        '
        Me.txtFloat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFloat.Location = New System.Drawing.Point(188, 60)
        Me.txtFloat.Name = "txtFloat"
        Me.txtFloat.ReadOnly = True
        Me.txtFloat.Size = New System.Drawing.Size(162, 30)
        Me.txtFloat.TabIndex = 25
        Me.txtFloat.Visible = False
        '
        'grpCal
        '
        Me.grpCal.Controls.Add(Me.lblDigitOnly)
        Me.grpCal.Controls.Add(Me.lblBalanceRm)
        Me.grpCal.Controls.Add(Me.lblBalance)
        Me.grpCal.Controls.Add(Me.txtTotalFnT)
        Me.grpCal.Controls.Add(Me.lblTotalFnT)
        Me.grpCal.Controls.Add(Me.txtTransaction)
        Me.grpCal.Controls.Add(Me.lblTotalTran)
        Me.grpCal.Controls.Add(Me.txtFloat)
        Me.grpCal.Controls.Add(Me.txtTotal)
        Me.grpCal.Controls.Add(Me.lblFloat)
        Me.grpCal.Controls.Add(Me.lblTotal)
        Me.grpCal.Location = New System.Drawing.Point(270, 34)
        Me.grpCal.Name = "grpCal"
        Me.grpCal.Size = New System.Drawing.Size(372, 363)
        Me.grpCal.TabIndex = 26
        Me.grpCal.TabStop = False
        '
        'lblDigitOnly
        '
        Me.lblDigitOnly.AutoSize = True
        Me.lblDigitOnly.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigitOnly.ForeColor = System.Drawing.Color.Red
        Me.lblDigitOnly.Location = New System.Drawing.Point(6, 14)
        Me.lblDigitOnly.Name = "lblDigitOnly"
        Me.lblDigitOnly.Size = New System.Drawing.Size(88, 22)
        Me.lblDigitOnly.TabIndex = 33
        Me.lblDigitOnly.Text = "DigitOnly"
        Me.lblDigitOnly.Visible = False
        '
        'lblBalanceRm
        '
        Me.lblBalanceRm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBalanceRm.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalanceRm.Location = New System.Drawing.Point(94, 251)
        Me.lblBalanceRm.Name = "lblBalanceRm"
        Me.lblBalanceRm.Size = New System.Drawing.Size(223, 57)
        Me.lblBalanceRm.TabIndex = 31
        Me.lblBalanceRm.Visible = False
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(89, 225)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(228, 26)
        Me.lblBalance.TabIndex = 30
        Me.lblBalance.Text = "Balance(Total1 - Total2)"
        Me.lblBalance.Visible = False
        '
        'txtTotalFnT
        '
        Me.txtTotalFnT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFnT.Location = New System.Drawing.Point(188, 132)
        Me.txtTotalFnT.Name = "txtTotalFnT"
        Me.txtTotalFnT.ReadOnly = True
        Me.txtTotalFnT.Size = New System.Drawing.Size(162, 30)
        Me.txtTotalFnT.TabIndex = 29
        Me.txtTotalFnT.Visible = False
        '
        'lblTotalFnT
        '
        Me.lblTotalFnT.AutoSize = True
        Me.lblTotalFnT.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFnT.Location = New System.Drawing.Point(52, 132)
        Me.lblTotalFnT.Name = "lblTotalFnT"
        Me.lblTotalFnT.Size = New System.Drawing.Size(130, 26)
        Me.lblTotalFnT.TabIndex = 28
        Me.lblTotalFnT.Text = "Total (F + T):"
        Me.lblTotalFnT.Visible = False
        '
        'txtTransaction
        '
        Me.txtTransaction.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransaction.Location = New System.Drawing.Point(188, 96)
        Me.txtTransaction.Name = "txtTransaction"
        Me.txtTransaction.ReadOnly = True
        Me.txtTransaction.Size = New System.Drawing.Size(162, 30)
        Me.txtTransaction.TabIndex = 27
        Me.txtTransaction.Visible = False
        '
        'lblTotalTran
        '
        Me.lblTotalTran.AutoSize = True
        Me.lblTotalTran.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTran.Location = New System.Drawing.Point(58, 96)
        Me.lblTotalTran.Name = "lblTotalTran"
        Me.lblTotalTran.Size = New System.Drawing.Size(124, 26)
        Me.lblTotalTran.TabIndex = 26
        Me.lblTotalTran.Text = "Transaction:"
        Me.lblTotalTran.Visible = False
        '
        'btnEditRM100
        '
        Me.btnEditRM100.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditRM100.Location = New System.Drawing.Point(206, 45)
        Me.btnEditRM100.Name = "btnEditRM100"
        Me.btnEditRM100.Size = New System.Drawing.Size(57, 29)
        Me.btnEditRM100.TabIndex = 27
        Me.btnEditRM100.Text = "Edit"
        Me.btnEditRM100.UseVisualStyleBackColor = True
        Me.btnEditRM100.Visible = False
        '
        'btnEditRM50
        '
        Me.btnEditRM50.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditRM50.Location = New System.Drawing.Point(206, 81)
        Me.btnEditRM50.Name = "btnEditRM50"
        Me.btnEditRM50.Size = New System.Drawing.Size(57, 29)
        Me.btnEditRM50.TabIndex = 28
        Me.btnEditRM50.Text = "Edit"
        Me.btnEditRM50.UseVisualStyleBackColor = True
        Me.btnEditRM50.Visible = False
        '
        'btnEditRM20
        '
        Me.btnEditRM20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditRM20.Location = New System.Drawing.Point(207, 115)
        Me.btnEditRM20.Name = "btnEditRM20"
        Me.btnEditRM20.Size = New System.Drawing.Size(57, 29)
        Me.btnEditRM20.TabIndex = 29
        Me.btnEditRM20.Text = "Edit"
        Me.btnEditRM20.UseVisualStyleBackColor = True
        Me.btnEditRM20.Visible = False
        '
        'btnEditRM10
        '
        Me.btnEditRM10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditRM10.Location = New System.Drawing.Point(207, 152)
        Me.btnEditRM10.Name = "btnEditRM10"
        Me.btnEditRM10.Size = New System.Drawing.Size(57, 29)
        Me.btnEditRM10.TabIndex = 30
        Me.btnEditRM10.Text = "Edit"
        Me.btnEditRM10.UseVisualStyleBackColor = True
        Me.btnEditRM10.Visible = False
        '
        'btnEditRM5
        '
        Me.btnEditRM5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditRM5.Location = New System.Drawing.Point(207, 188)
        Me.btnEditRM5.Name = "btnEditRM5"
        Me.btnEditRM5.Size = New System.Drawing.Size(57, 29)
        Me.btnEditRM5.TabIndex = 31
        Me.btnEditRM5.Text = "Edit"
        Me.btnEditRM5.UseVisualStyleBackColor = True
        Me.btnEditRM5.Visible = False
        '
        'btnEditRM1
        '
        Me.btnEditRM1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditRM1.Location = New System.Drawing.Point(207, 224)
        Me.btnEditRM1.Name = "btnEditRM1"
        Me.btnEditRM1.Size = New System.Drawing.Size(57, 29)
        Me.btnEditRM1.TabIndex = 32
        Me.btnEditRM1.Text = "Edit"
        Me.btnEditRM1.UseVisualStyleBackColor = True
        Me.btnEditRM1.Visible = False
        '
        'btnEdit50sen
        '
        Me.btnEdit50sen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit50sen.Location = New System.Drawing.Point(206, 260)
        Me.btnEdit50sen.Name = "btnEdit50sen"
        Me.btnEdit50sen.Size = New System.Drawing.Size(57, 29)
        Me.btnEdit50sen.TabIndex = 33
        Me.btnEdit50sen.Text = "Edit"
        Me.btnEdit50sen.UseVisualStyleBackColor = True
        Me.btnEdit50sen.Visible = False
        '
        'btnEdit20sen
        '
        Me.btnEdit20sen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit20sen.Location = New System.Drawing.Point(206, 296)
        Me.btnEdit20sen.Name = "btnEdit20sen"
        Me.btnEdit20sen.Size = New System.Drawing.Size(57, 29)
        Me.btnEdit20sen.TabIndex = 34
        Me.btnEdit20sen.Text = "Edit"
        Me.btnEdit20sen.UseVisualStyleBackColor = True
        Me.btnEdit20sen.Visible = False
        '
        'btnEdit10sen
        '
        Me.btnEdit10sen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit10sen.Location = New System.Drawing.Point(206, 333)
        Me.btnEdit10sen.Name = "btnEdit10sen"
        Me.btnEdit10sen.Size = New System.Drawing.Size(57, 29)
        Me.btnEdit10sen.TabIndex = 35
        Me.btnEdit10sen.Text = "Edit"
        Me.btnEdit10sen.UseVisualStyleBackColor = True
        Me.btnEdit10sen.Visible = False
        '
        'btnEdit5sen
        '
        Me.btnEdit5sen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit5sen.Location = New System.Drawing.Point(206, 368)
        Me.btnEdit5sen.Name = "btnEdit5sen"
        Me.btnEdit5sen.Size = New System.Drawing.Size(57, 29)
        Me.btnEdit5sen.TabIndex = 36
        Me.btnEdit5sen.Text = "Edit"
        Me.btnEdit5sen.UseVisualStyleBackColor = True
        Me.btnEdit5sen.Visible = False
        '
        'lblPress
        '
        Me.lblPress.AutoSize = True
        Me.lblPress.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPress.Location = New System.Drawing.Point(416, 9)
        Me.lblPress.Name = "lblPress"
        Me.lblPress.Size = New System.Drawing.Size(226, 22)
        Me.lblPress.TabIndex = 37
        Me.lblPress.Text = "*Press Enter To Next Value"
        '
        'frmFloat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 473)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblPress)
        Me.Controls.Add(Me.btnEdit5sen)
        Me.Controls.Add(Me.btnEdit10sen)
        Me.Controls.Add(Me.btnEdit20sen)
        Me.Controls.Add(Me.btnEdit50sen)
        Me.Controls.Add(Me.btnEditRM1)
        Me.Controls.Add(Me.btnEditRM5)
        Me.Controls.Add(Me.btnEditRM10)
        Me.Controls.Add(Me.btnEditRM20)
        Me.Controls.Add(Me.btnEditRM50)
        Me.Controls.Add(Me.btnEditRM100)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.txt5sen)
        Me.Controls.Add(Me.txt10sen)
        Me.Controls.Add(Me.txt20sen)
        Me.Controls.Add(Me.txt50sen)
        Me.Controls.Add(Me.txtRM1)
        Me.Controls.Add(Me.txtRM5)
        Me.Controls.Add(Me.txtRM10)
        Me.Controls.Add(Me.txtRM20)
        Me.Controls.Add(Me.txtRM50)
        Me.Controls.Add(Me.txtRM100)
        Me.Controls.Add(Me.lbl5sen)
        Me.Controls.Add(Me.lbl10sen)
        Me.Controls.Add(Me.lbl20sen)
        Me.Controls.Add(Me.lbl50Sen)
        Me.Controls.Add(Me.lblRM1)
        Me.Controls.Add(Me.lblRM5)
        Me.Controls.Add(Me.lblRM10)
        Me.Controls.Add(Me.lblRM20)
        Me.Controls.Add(Me.lblRM50)
        Me.Controls.Add(Me.lblRM100)
        Me.Controls.Add(Me.lblInform)
        Me.Controls.Add(Me.grpCal)
        Me.Name = "frmFloat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Float"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.grpCal.ResumeLayout(False)
        Me.grpCal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInform As Label
    Friend WithEvents lblRM100 As Label
    Friend WithEvents lblRM50 As Label
    Friend WithEvents lblRM20 As Label
    Friend WithEvents lblRM10 As Label
    Friend WithEvents lblRM5 As Label
    Friend WithEvents lblRM1 As Label
    Friend WithEvents lbl50Sen As Label
    Friend WithEvents lbl20sen As Label
    Friend WithEvents lbl10sen As Label
    Friend WithEvents lbl5sen As Label
    Friend WithEvents txtRM100 As TextBox
    Friend WithEvents txtRM50 As TextBox
    Friend WithEvents txtRM20 As TextBox
    Friend WithEvents txtRM10 As TextBox
    Friend WithEvents txtRM5 As TextBox
    Friend WithEvents txtRM1 As TextBox
    Friend WithEvents txt50sen As TextBox
    Friend WithEvents txt20sen As TextBox
    Friend WithEvents txt10sen As TextBox
    Friend WithEvents txt5sen As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnReset As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblFloat As Label
    Friend WithEvents txtFloat As TextBox
    Friend WithEvents grpCal As GroupBox
    Friend WithEvents lblBalanceRm As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents txtTotalFnT As TextBox
    Friend WithEvents lblTotalFnT As Label
    Friend WithEvents txtTransaction As TextBox
    Friend WithEvents lblTotalTran As Label
    Friend WithEvents lblDigitOnly As Label
    Friend WithEvents btnEditRM100 As Button
    Friend WithEvents btnEditRM50 As Button
    Friend WithEvents btnEditRM20 As Button
    Friend WithEvents btnEditRM10 As Button
    Friend WithEvents btnEditRM5 As Button
    Friend WithEvents btnEditRM1 As Button
    Friend WithEvents btnEdit50sen As Button
    Friend WithEvents btnEdit20sen As Button
    Friend WithEvents btnEdit10sen As Button
    Friend WithEvents btnEdit5sen As Button
    Friend WithEvents lblPress As Label
End Class
