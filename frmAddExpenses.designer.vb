<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddExpenses
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
        Me.btnQRcode = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtShopName = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtReceiptNo = New System.Windows.Forms.TextBox()
        Me.flpItem = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtRounding = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPay = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.flpItem.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnQRcode
        '
        Me.btnQRcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQRcode.Location = New System.Drawing.Point(562, 105)
        Me.btnQRcode.Margin = New System.Windows.Forms.Padding(4)
        Me.btnQRcode.Name = "btnQRcode"
        Me.btnQRcode.Size = New System.Drawing.Size(132, 111)
        Me.btnQRcode.TabIndex = 0
        Me.btnQRcode.Text = "Upload QR Code"
        Me.btnQRcode.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Shop Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date           :"
        '
        'lblItem
        '
        Me.lblItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.Location = New System.Drawing.Point(4, 0)
        Me.lblItem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(235, 27)
        Me.lblItem.TabIndex = 3
        Me.lblItem.Text = "Items"
        Me.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "SubTotal  :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 35)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tax         :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 70)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Discount :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 105)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Rouding  :"
        '
        'txtShopName
        '
        Me.txtShopName.Location = New System.Drawing.Point(129, 4)
        Me.txtShopName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShopName.Name = "txtShopName"
        Me.txtShopName.ReadOnly = True
        Me.txtShopName.Size = New System.Drawing.Size(338, 27)
        Me.txtShopName.TabIndex = 8
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(113, 4)
        Me.txtSubTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(168, 27)
        Me.txtSubTotal.TabIndex = 9
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(111, 39)
        Me.txtTax.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(170, 27)
        Me.txtTax.TabIndex = 10
        Me.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(108, 74)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(173, 27)
        Me.txtDiscount.TabIndex = 11
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(111, 144)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(170, 27)
        Me.txtTotal.TabIndex = 12
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(133, 74)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(334, 27)
        Me.txtDate.TabIndex = 14
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtShopName)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtReceiptNo)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtDate)
        Me.FlowLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(75, 105)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(479, 111)
        Me.FlowLayoutPanel1.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 35)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 20)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Receipt No  :"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.Location = New System.Drawing.Point(132, 39)
        Me.txtReceiptNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.ReadOnly = True
        Me.txtReceiptNo.Size = New System.Drawing.Size(335, 27)
        Me.txtReceiptNo.TabIndex = 16
        '
        'flpItem
        '
        Me.flpItem.Controls.Add(Me.lblItem)
        Me.flpItem.Controls.Add(Me.lblQuantity)
        Me.flpItem.Controls.Add(Me.lblPrice)
        Me.flpItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flpItem.Location = New System.Drawing.Point(75, 224)
        Me.flpItem.Margin = New System.Windows.Forms.Padding(4)
        Me.flpItem.Name = "flpItem"
        Me.flpItem.Size = New System.Drawing.Size(620, 286)
        Me.flpItem.TabIndex = 16
        '
        'lblQuantity
        '
        Me.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(247, 0)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(172, 27)
        Me.lblQuantity.TabIndex = 18
        Me.lblQuantity.Text = "Quantity"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(427, 0)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(188, 28)
        Me.lblPrice.TabIndex = 19
        Me.lblPrice.Text = "Price"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel3.Controls.Add(Me.txtSubTotal)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel3.Controls.Add(Me.txtTax)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel3.Controls.Add(Me.txtDiscount)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel3.Controls.Add(Me.txtRounding)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label11)
        Me.FlowLayoutPanel3.Controls.Add(Me.txtTotal)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label13)
        Me.FlowLayoutPanel3.Controls.Add(Me.txtPay)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label14)
        Me.FlowLayoutPanel3.Controls.Add(Me.txtChange)
        Me.FlowLayoutPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(75, 518)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(290, 252)
        Me.FlowLayoutPanel3.TabIndex = 17
        '
        'txtRounding
        '
        Me.txtRounding.Location = New System.Drawing.Point(107, 109)
        Me.txtRounding.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRounding.Name = "txtRounding"
        Me.txtRounding.ReadOnly = True
        Me.txtRounding.Size = New System.Drawing.Size(174, 27)
        Me.txtRounding.TabIndex = 17
        Me.txtRounding.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 140)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 20)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Total       :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 175)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 20)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Paid       :"
        '
        'txtPay
        '
        Me.txtPay.Location = New System.Drawing.Point(106, 179)
        Me.txtPay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.ReadOnly = True
        Me.txtPay.Size = New System.Drawing.Size(175, 27)
        Me.txtPay.TabIndex = 18
        Me.txtPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 210)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 20)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Changes :"
        '
        'txtChange
        '
        Me.txtChange.Location = New System.Drawing.Point(106, 214)
        Me.txtChange.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(175, 27)
        Me.txtChange.TabIndex = 19
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(225, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(423, 55)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Receiptless Concepts"
        '
        'frmAddExpenses
        '
        Me.AcceptButton = Me.btnQRcode
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 774)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.flpItem)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnQRcode)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddExpenses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddExpenses"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.flpItem.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQRcode As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblItem As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtShopName As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents flpItem As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtReceiptNo As TextBox
    Friend WithEvents txtRounding As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPay As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtChange As TextBox
    Friend WithEvents Label12 As Label
End Class
