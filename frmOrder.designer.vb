<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpItem = New System.Windows.Forms.GroupBox()
        Me.flp = New System.Windows.Forms.FlowLayoutPanel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.cboSearchType = New System.Windows.Forms.ComboBox()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cboCategories = New System.Windows.Forms.ComboBox()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.btnReceipt = New System.Windows.Forms.Button()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dgvTrans = New System.Windows.Forms.DataGridView()
        Me.dgvReturnBook = New System.Windows.Forms.DataGridView()
        Me.dgvDetail = New System.Windows.Forms.DataGridView()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.dgvCat = New System.Windows.Forms.DataGridView()
        Me.grpFunction = New System.Windows.Forms.GroupBox()
        Me.tlp = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnMember = New System.Windows.Forms.Button()
        Me.btnHoldBill = New System.Windows.Forms.Button()
        Me.btnRecallBill = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.grpOrder = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDigitOnly = New System.Windows.Forms.Label()
        Me.btnPayRtn = New System.Windows.Forms.Button()
        Me.cboPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.dgvCart = New System.Windows.Forms.DataGridView()
        Me.ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AMOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvclmbtnRemove = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.grpAmount = New System.Windows.Forms.GroupBox()
        Me.txtRndAdj = New System.Windows.Forms.TextBox()
        Me.txtMemberDisc = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.pnlLabel = New System.Windows.Forms.Panel()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblRndAdj = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMemberDisc = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grpItem.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        CType(Me.dgvTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReturnBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFunction.SuspendLayout()
        Me.tlp.SuspendLayout()
        Me.grpOrder.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAmount.SuspendLayout()
        Me.pnlLabel.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpItem
        '
        Me.grpItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpItem.Controls.Add(Me.picLogo)
        Me.grpItem.Controls.Add(Me.flp)
        Me.grpItem.Controls.Add(Me.cboSearchType)
        Me.grpItem.Controls.Add(Me.btnLogOut)
        Me.grpItem.Controls.Add(Me.txtSearch)
        Me.grpItem.Controls.Add(Me.cboCategories)
        Me.grpItem.Controls.Add(Me.pnl1)
        Me.grpItem.Controls.Add(Me.dgvTrans)
        Me.grpItem.Controls.Add(Me.dgvReturnBook)
        Me.grpItem.Controls.Add(Me.dgvDetail)
        Me.grpItem.Controls.Add(Me.dgv)
        Me.grpItem.Controls.Add(Me.dgvCat)
        Me.grpItem.Location = New System.Drawing.Point(3, -1)
        Me.grpItem.Name = "grpItem"
        Me.grpItem.Size = New System.Drawing.Size(823, 620)
        Me.grpItem.TabIndex = 11
        Me.grpItem.TabStop = False
        '
        'flp
        '
        Me.flp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flp.AutoScroll = True
        Me.flp.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flp.Location = New System.Drawing.Point(11, 124)
        Me.flp.Name = "flp"
        Me.flp.Size = New System.Drawing.Size(807, 432)
        Me.flp.TabIndex = 14
        '
        'picLogo
        '
        Me.picLogo.Image = Global.BookPOS.My.Resources.Resources.mybook
        Me.picLogo.Location = New System.Drawing.Point(11, 9)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(259, 76)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 10
        Me.picLogo.TabStop = False
        '
        'cboSearchType
        '
        Me.cboSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchType.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchType.FormattingEnabled = True
        Me.cboSearchType.Items.AddRange(New Object() {"Name", "Primary Code", "Categories"})
        Me.cboSearchType.Location = New System.Drawing.Point(11, 91)
        Me.cboSearchType.Name = "cboSearchType"
        Me.cboSearchType.Size = New System.Drawing.Size(167, 27)
        Me.cboSearchType.TabIndex = 8
        '
        'btnLogOut
        '
        Me.btnLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLogOut.AutoSize = True
        Me.btnLogOut.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(9, 562)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(127, 40)
        Me.btnLogOut.TabIndex = 7
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(184, 91)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(245, 27)
        Me.txtSearch.TabIndex = 9
        '
        'cboCategories
        '
        Me.cboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategories.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategories.FormattingEnabled = True
        Me.cboCategories.Location = New System.Drawing.Point(184, 91)
        Me.cboCategories.Name = "cboCategories"
        Me.cboCategories.Size = New System.Drawing.Size(350, 27)
        Me.cboCategories.TabIndex = 17
        Me.cboCategories.Visible = False
        '
        'pnl1
        '
        Me.pnl1.Controls.Add(Me.btnReceipt)
        Me.pnl1.Controls.Add(Me.lblStaffID)
        Me.pnl1.Controls.Add(Me.lblStaffName)
        Me.pnl1.Controls.Add(Me.lblDate)
        Me.pnl1.Location = New System.Drawing.Point(277, 14)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(540, 71)
        Me.pnl1.TabIndex = 21
        '
        'btnReceipt
        '
        Me.btnReceipt.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnReceipt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipt.Location = New System.Drawing.Point(367, 0)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(173, 71)
        Me.btnReceipt.TabIndex = 21
        Me.btnReceipt.Text = "QR Code Receipt"
        Me.btnReceipt.UseVisualStyleBackColor = True
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffID.Location = New System.Drawing.Point(3, 26)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(59, 19)
        Me.lblStaffID.TabIndex = 19
        Me.lblStaffID.Text = "StaffID"
        '
        'lblStaffName
        '
        Me.lblStaffName.AutoSize = True
        Me.lblStaffName.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffName.Location = New System.Drawing.Point(3, 45)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(82, 19)
        Me.lblStaffName.TabIndex = 20
        Me.lblStaffName.Text = "StaffName"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(3, 7)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(75, 19)
        Me.lblDate.TabIndex = 12
        Me.lblDate.Text = "DateTime"
        '
        'dgvTrans
        '
        Me.dgvTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrans.Location = New System.Drawing.Point(126, 9)
        Me.dgvTrans.Name = "dgvTrans"
        Me.dgvTrans.RowTemplate.Height = 27
        Me.dgvTrans.Size = New System.Drawing.Size(28, 19)
        Me.dgvTrans.TabIndex = 15
        Me.dgvTrans.Visible = False
        '
        'dgvReturnBook
        '
        Me.dgvReturnBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReturnBook.Location = New System.Drawing.Point(206, 9)
        Me.dgvReturnBook.Name = "dgvReturnBook"
        Me.dgvReturnBook.RowTemplate.Height = 27
        Me.dgvReturnBook.Size = New System.Drawing.Size(40, 36)
        Me.dgvReturnBook.TabIndex = 22
        Me.dgvReturnBook.Visible = False
        '
        'dgvDetail
        '
        Me.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetail.Location = New System.Drawing.Point(160, 9)
        Me.dgvDetail.Name = "dgvDetail"
        Me.dgvDetail.RowTemplate.Height = 27
        Me.dgvDetail.Size = New System.Drawing.Size(40, 36)
        Me.dgvDetail.TabIndex = 16
        Me.dgvDetail.Visible = False
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(44, 9)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 27
        Me.dgv.Size = New System.Drawing.Size(40, 31)
        Me.dgv.TabIndex = 13
        Me.dgv.Visible = False
        '
        'dgvCat
        '
        Me.dgvCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCat.Location = New System.Drawing.Point(90, 9)
        Me.dgvCat.Name = "dgvCat"
        Me.dgvCat.RowTemplate.Height = 27
        Me.dgvCat.Size = New System.Drawing.Size(26, 22)
        Me.dgvCat.TabIndex = 18
        Me.dgvCat.Visible = False
        '
        'grpFunction
        '
        Me.grpFunction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFunction.Controls.Add(Me.tlp)
        Me.grpFunction.Location = New System.Drawing.Point(3, 614)
        Me.grpFunction.Name = "grpFunction"
        Me.grpFunction.Size = New System.Drawing.Size(823, 106)
        Me.grpFunction.TabIndex = 15
        Me.grpFunction.TabStop = False
        '
        'tlp
        '
        Me.tlp.ColumnCount = 6
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp.Controls.Add(Me.btnCancel, 3, 0)
        Me.tlp.Controls.Add(Me.btnUpload, 5, 0)
        Me.tlp.Controls.Add(Me.btnMember, 4, 0)
        Me.tlp.Controls.Add(Me.btnHoldBill, 0, 0)
        Me.tlp.Controls.Add(Me.btnRecallBill, 1, 0)
        Me.tlp.Controls.Add(Me.btnReturn, 2, 0)
        Me.tlp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp.Location = New System.Drawing.Point(3, 21)
        Me.tlp.Name = "tlp"
        Me.tlp.RowCount = 1
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp.Size = New System.Drawing.Size(817, 82)
        Me.tlp.TabIndex = 14
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(369, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(116, 76)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel Transaction"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.AutoSize = True
        Me.btnUpload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUpload.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.Location = New System.Drawing.Point(613, 3)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(201, 76)
        Me.btnUpload.TabIndex = 12
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'btnMember
        '
        Me.btnMember.AutoSize = True
        Me.btnMember.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMember.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMember.Location = New System.Drawing.Point(491, 3)
        Me.btnMember.Name = "btnMember"
        Me.btnMember.Size = New System.Drawing.Size(116, 76)
        Me.btnMember.TabIndex = 11
        Me.btnMember.Text = "&Member"
        Me.btnMember.UseVisualStyleBackColor = True
        '
        'btnHoldBill
        '
        Me.btnHoldBill.AutoSize = True
        Me.btnHoldBill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHoldBill.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHoldBill.Location = New System.Drawing.Point(3, 3)
        Me.btnHoldBill.Name = "btnHoldBill"
        Me.btnHoldBill.Size = New System.Drawing.Size(116, 76)
        Me.btnHoldBill.TabIndex = 8
        Me.btnHoldBill.Text = "Hold Bill"
        Me.btnHoldBill.UseVisualStyleBackColor = True
        '
        'btnRecallBill
        '
        Me.btnRecallBill.AutoSize = True
        Me.btnRecallBill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRecallBill.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecallBill.Location = New System.Drawing.Point(125, 3)
        Me.btnRecallBill.Name = "btnRecallBill"
        Me.btnRecallBill.Size = New System.Drawing.Size(116, 76)
        Me.btnRecallBill.TabIndex = 9
        Me.btnRecallBill.Text = "Recall Bill"
        Me.btnRecallBill.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.AutoSize = True
        Me.btnReturn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReturn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(247, 3)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(116, 76)
        Me.btnReturn.TabIndex = 13
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'grpOrder
        '
        Me.grpOrder.Controls.Add(Me.Panel1)
        Me.grpOrder.Controls.Add(Me.dgvCart)
        Me.grpOrder.Controls.Add(Me.grpAmount)
        Me.grpOrder.Dock = System.Windows.Forms.DockStyle.Right
        Me.grpOrder.Location = New System.Drawing.Point(829, 0)
        Me.grpOrder.Name = "grpOrder"
        Me.grpOrder.Size = New System.Drawing.Size(555, 723)
        Me.grpOrder.TabIndex = 23
        Me.grpOrder.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblDigitOnly)
        Me.Panel1.Controls.Add(Me.btnPayRtn)
        Me.Panel1.Controls.Add(Me.cboPaymentMethod)
        Me.Panel1.Controls.Add(Me.txtCash)
        Me.Panel1.Controls.Add(Me.lblCash)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 575)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 145)
        Me.Panel1.TabIndex = 30
        '
        'lblDigitOnly
        '
        Me.lblDigitOnly.AutoSize = True
        Me.lblDigitOnly.ForeColor = System.Drawing.Color.Red
        Me.lblDigitOnly.Location = New System.Drawing.Point(433, 10)
        Me.lblDigitOnly.Name = "lblDigitOnly"
        Me.lblDigitOnly.Size = New System.Drawing.Size(88, 22)
        Me.lblDigitOnly.TabIndex = 32
        Me.lblDigitOnly.Text = "DigitOnly"
        Me.lblDigitOnly.Visible = False
        '
        'btnPayRtn
        '
        Me.btnPayRtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnPayRtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayRtn.Location = New System.Drawing.Point(0, 86)
        Me.btnPayRtn.Name = "btnPayRtn"
        Me.btnPayRtn.Size = New System.Drawing.Size(549, 59)
        Me.btnPayRtn.TabIndex = 31
        Me.btnPayRtn.Text = "&Pay"
        Me.btnPayRtn.UseVisualStyleBackColor = True
        '
        'cboPaymentMethod
        '
        Me.cboPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaymentMethod.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPaymentMethod.FormattingEnabled = True
        Me.cboPaymentMethod.Items.AddRange(New Object() {"Cash", "Credit Card", "E-Payment"})
        Me.cboPaymentMethod.Location = New System.Drawing.Point(17, 40)
        Me.cboPaymentMethod.Name = "cboPaymentMethod"
        Me.cboPaymentMethod.Size = New System.Drawing.Size(523, 28)
        Me.cboPaymentMethod.TabIndex = 29
        Me.cboPaymentMethod.Visible = False
        '
        'txtCash
        '
        Me.txtCash.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCash.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(241, 7)
        Me.txtCash.MaxLength = 2000
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(185, 27)
        Me.txtCash.TabIndex = 24
        Me.txtCash.Visible = False
        '
        'lblCash
        '
        Me.lblCash.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCash.AutoSize = True
        Me.lblCash.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.Location = New System.Drawing.Point(110, 10)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(118, 19)
        Me.lblCash.TabIndex = 18
        Me.lblCash.Text = "Cash Received :"
        Me.lblCash.Visible = False
        '
        'dgvCart
        '
        Me.dgvCart.AllowUserToAddRows = False
        Me.dgvCart.AllowUserToDeleteRows = False
        Me.dgvCart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvCart.BackgroundColor = System.Drawing.Color.White
        Me.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEM, Me.QTY, Me.AMOUNT, Me.ItemCode, Me.dgvclmbtnRemove})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCart.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCart.Location = New System.Drawing.Point(7, 12)
        Me.dgvCart.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCart.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCart.RowHeadersVisible = False
        Me.dgvCart.Size = New System.Drawing.Size(535, 358)
        Me.dgvCart.TabIndex = 28
        '
        'ITEM
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ITEM.DefaultCellStyle = DataGridViewCellStyle2
        Me.ITEM.FillWeight = 100.2843!
        Me.ITEM.HeaderText = "ITEM"
        Me.ITEM.Name = "ITEM"
        Me.ITEM.ReadOnly = True
        '
        'QTY
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.QTY.DefaultCellStyle = DataGridViewCellStyle3
        Me.QTY.FillWeight = 50.32317!
        Me.QTY.HeaderText = "QTY"
        Me.QTY.Name = "QTY"
        Me.QTY.ReadOnly = True
        '
        'AMOUNT
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.AMOUNT.DefaultCellStyle = DataGridViewCellStyle4
        Me.AMOUNT.FillWeight = 67.39257!
        Me.AMOUNT.HeaderText = "AMOUNT"
        Me.AMOUNT.Name = "AMOUNT"
        Me.AMOUNT.ReadOnly = True
        '
        'ItemCode
        '
        Me.ItemCode.HeaderText = "ItemCode"
        Me.ItemCode.Name = "ItemCode"
        Me.ItemCode.ReadOnly = True
        Me.ItemCode.Visible = False
        '
        'dgvclmbtnRemove
        '
        Me.dgvclmbtnRemove.FillWeight = 40.0!
        Me.dgvclmbtnRemove.HeaderText = " "
        Me.dgvclmbtnRemove.Name = "dgvclmbtnRemove"
        Me.dgvclmbtnRemove.ReadOnly = True
        Me.dgvclmbtnRemove.Text = "Remove"
        Me.dgvclmbtnRemove.UseColumnTextForButtonValue = True
        '
        'grpAmount
        '
        Me.grpAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.grpAmount.Controls.Add(Me.txtRndAdj)
        Me.grpAmount.Controls.Add(Me.txtMemberDisc)
        Me.grpAmount.Controls.Add(Me.txtTotal)
        Me.grpAmount.Controls.Add(Me.txtTax)
        Me.grpAmount.Controls.Add(Me.txtSubTotal)
        Me.grpAmount.Controls.Add(Me.pnlLabel)
        Me.grpAmount.Location = New System.Drawing.Point(63, 376)
        Me.grpAmount.Name = "grpAmount"
        Me.grpAmount.Size = New System.Drawing.Size(419, 193)
        Me.grpAmount.TabIndex = 24
        Me.grpAmount.TabStop = False
        '
        'txtRndAdj
        '
        Me.txtRndAdj.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRndAdj.Enabled = False
        Me.txtRndAdj.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRndAdj.Location = New System.Drawing.Point(181, 123)
        Me.txtRndAdj.Name = "txtRndAdj"
        Me.txtRndAdj.ReadOnly = True
        Me.txtRndAdj.Size = New System.Drawing.Size(207, 27)
        Me.txtRndAdj.TabIndex = 22
        '
        'txtMemberDisc
        '
        Me.txtMemberDisc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMemberDisc.Enabled = False
        Me.txtMemberDisc.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberDisc.Location = New System.Drawing.Point(181, 89)
        Me.txtMemberDisc.Name = "txtMemberDisc"
        Me.txtMemberDisc.ReadOnly = True
        Me.txtMemberDisc.Size = New System.Drawing.Size(207, 27)
        Me.txtMemberDisc.TabIndex = 20
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(181, 157)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(207, 27)
        Me.txtTotal.TabIndex = 21
        '
        'txtTax
        '
        Me.txtTax.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTax.Enabled = False
        Me.txtTax.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Location = New System.Drawing.Point(181, 55)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(207, 27)
        Me.txtTax.TabIndex = 19
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(181, 21)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(207, 27)
        Me.txtSubTotal.TabIndex = 18
        '
        'pnlLabel
        '
        Me.pnlLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLabel.Controls.Add(Me.lblSubTotal)
        Me.pnlLabel.Controls.Add(Me.lblRndAdj)
        Me.pnlLabel.Controls.Add(Me.lblTax)
        Me.pnlLabel.Controls.Add(Me.lblTotal)
        Me.pnlLabel.Controls.Add(Me.lblMemberDisc)
        Me.pnlLabel.Location = New System.Drawing.Point(7, 12)
        Me.pnlLabel.Name = "pnlLabel"
        Me.pnlLabel.Size = New System.Drawing.Size(169, 175)
        Me.pnlLabel.TabIndex = 23
        '
        'lblSubTotal
        '
        Me.lblSubTotal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(75, 13)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(81, 19)
        Me.lblSubTotal.TabIndex = 10
        Me.lblSubTotal.Text = "Sub Total :"
        '
        'lblRndAdj
        '
        Me.lblRndAdj.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRndAdj.AutoSize = True
        Me.lblRndAdj.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRndAdj.Location = New System.Drawing.Point(23, 115)
        Me.lblRndAdj.Name = "lblRndAdj"
        Me.lblRndAdj.Size = New System.Drawing.Size(130, 19)
        Me.lblRndAdj.TabIndex = 16
        Me.lblRndAdj.Text = "Rounding Adjust :"
        '
        'lblTax
        '
        Me.lblTax.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(80, 47)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(76, 19)
        Me.lblTax.TabIndex = 13
        Me.lblTax.Text = "Tax(6%) :"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(109, 149)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(52, 19)
        Me.lblTotal.TabIndex = 17
        Me.lblTotal.Text = "Total :"
        '
        'lblMemberDisc
        '
        Me.lblMemberDisc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMemberDisc.AutoSize = True
        Me.lblMemberDisc.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberDisc.Location = New System.Drawing.Point(11, 81)
        Me.lblMemberDisc.Name = "lblMemberDisc"
        Me.lblMemberDisc.Size = New System.Drawing.Size(142, 19)
        Me.lblMemberDisc.TabIndex = 14
        Me.lblMemberDisc.Text = "Member Discount :"
        '
        'Timer1
        '
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1384, 723)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpItem)
        Me.Controls.Add(Me.grpFunction)
        Me.Controls.Add(Me.grpOrder)
        Me.MinimizeBox = False
        Me.Name = "frmOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Point Of Sales System"
        Me.grpItem.ResumeLayout(False)
        Me.grpItem.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        CType(Me.dgvTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReturnBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFunction.ResumeLayout(False)
        Me.tlp.ResumeLayout(False)
        Me.tlp.PerformLayout()
        Me.grpOrder.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAmount.ResumeLayout(False)
        Me.grpAmount.PerformLayout()
        Me.pnlLabel.ResumeLayout(False)
        Me.pnlLabel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpItem As GroupBox
    Friend WithEvents btnLogOut As Button
    Friend WithEvents grpFunction As GroupBox
    Friend WithEvents grpOrder As GroupBox
    Friend WithEvents grpAmount As GroupBox
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents txtRndAdj As TextBox
    Friend WithEvents lblMemberDisc As Label
    Friend WithEvents txtMemberDisc As TextBox
    Friend WithEvents lblRndAdj As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents btnHoldBill As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnMember As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRecallBill As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cboSearchType As ComboBox
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents flp As FlowLayoutPanel
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents pnlLabel As Panel
    Friend WithEvents dgvTrans As DataGridView
    Friend WithEvents dgvDetail As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tlp As TableLayoutPanel
    Friend WithEvents cboCategories As ComboBox
    Friend WithEvents dgvCat As DataGridView
    Friend WithEvents ITEM As DataGridViewTextBoxColumn
    Friend WithEvents QTY As DataGridViewTextBoxColumn
    Friend WithEvents AMOUNT As DataGridViewTextBoxColumn
    Friend WithEvents ItemCode As DataGridViewTextBoxColumn
    Friend WithEvents dgvclmbtnRemove As DataGridViewButtonColumn
    Friend WithEvents lblStaffName As Label
    Friend WithEvents lblStaffID As Label
    Friend WithEvents pnl1 As Panel
    Friend WithEvents cboPaymentMethod As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCash As TextBox
    Friend WithEvents lblCash As Label
    Friend WithEvents btnPayRtn As Button
    Friend WithEvents lblDigitOnly As Label
    Friend WithEvents dgvReturnBook As DataGridView
    Friend WithEvents btnReceipt As Button
End Class
