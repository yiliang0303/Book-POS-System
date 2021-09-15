<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditItem
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.BtnMinus = New System.Windows.Forms.Button()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblDigitOnly = New System.Windows.Forms.Label()
        Me.picBook = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(44, 247)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(94, 22)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Book Title"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(39, 294)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(99, 22)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Book Price"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.Location = New System.Drawing.Point(62, 342)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(76, 22)
        Me.lblQty.TabIndex = 3
        Me.lblQty.Text = "Quantity"
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Enabled = False
        Me.txtBookTitle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookTitle.Location = New System.Drawing.Point(155, 244)
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(351, 30)
        Me.txtBookTitle.TabIndex = 4
        '
        'txtPrice
        '
        Me.txtPrice.Enabled = False
        Me.txtPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(155, 291)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(351, 30)
        Me.txtPrice.TabIndex = 5
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(67, 391)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(71, 22)
        Me.lblAmount.TabIndex = 6
        Me.lblAmount.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.Enabled = False
        Me.txtAmount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(155, 383)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(351, 30)
        Me.txtAmount.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(360, 335)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(39, 36)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'BtnMinus
        '
        Me.BtnMinus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinus.Location = New System.Drawing.Point(262, 335)
        Me.BtnMinus.Name = "BtnMinus"
        Me.BtnMinus.Size = New System.Drawing.Size(39, 37)
        Me.BtnMinus.TabIndex = 12
        Me.BtnMinus.Text = "-"
        Me.BtnMinus.UseVisualStyleBackColor = True
        '
        'BtnMin
        '
        Me.BtnMin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMin.Location = New System.Drawing.Point(155, 337)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(101, 33)
        Me.BtnMin.TabIndex = 13
        Me.BtnMin.Text = "Min(1)"
        Me.BtnMin.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMax.Location = New System.Drawing.Point(405, 337)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(101, 33)
        Me.btnMax.TabIndex = 14
        Me.btnMax.Text = "Max(100)"
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(347, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(167, 53)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConfirm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(175, 3)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(166, 53)
        Me.btnConfirm.TabIndex = 16
        Me.btnConfirm.Text = "Confrim"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnConfirm, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 442)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(517, 59)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(307, 340)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(47, 30)
        Me.txtQty.TabIndex = 8
        '
        'lblDigitOnly
        '
        Me.lblDigitOnly.AutoSize = True
        Me.lblDigitOnly.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigitOnly.ForeColor = System.Drawing.Color.Red
        Me.lblDigitOnly.Location = New System.Drawing.Point(512, 344)
        Me.lblDigitOnly.Name = "lblDigitOnly"
        Me.lblDigitOnly.Size = New System.Drawing.Size(81, 21)
        Me.lblDigitOnly.TabIndex = 33
        Me.lblDigitOnly.Text = "DigitOnly"
        Me.lblDigitOnly.Visible = False
        '
        'picBook
        '
        Me.picBook.Location = New System.Drawing.Point(155, 12)
        Me.picBook.Name = "picBook"
        Me.picBook.Size = New System.Drawing.Size(228, 216)
        Me.picBook.TabIndex = 0
        Me.picBook.TabStop = False
        '
        'frmEditItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 513)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDigitOnly)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.BtnMin)
        Me.Controls.Add(Me.BtnMinus)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtBookTitle)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.picBook)
        Me.Name = "frmEditItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBook As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents txtBookTitle As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents BtnMinus As Button
    Friend WithEvents BtnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtQty As TextBox
    Friend WithEvents lblDigitOnly As Label
End Class
