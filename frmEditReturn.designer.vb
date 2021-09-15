<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditReturn
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.lblRemark = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.picBook = New System.Windows.Forms.PictureBox()
        Me.txtTransaction = New System.Windows.Forms.TextBox()
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.lblDigitOnly = New System.Windows.Forms.Label()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.BtnMinus = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnConfirm, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(50, 435)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(517, 59)
        Me.TableLayoutPanel1.TabIndex = 24
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
        'txtBookTitle
        '
        Me.txtBookTitle.Enabled = False
        Me.txtBookTitle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookTitle.Location = New System.Drawing.Point(193, 265)
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(351, 30)
        Me.txtBookTitle.TabIndex = 22
        '
        'lblBookID
        '
        Me.lblBookID.AutoSize = True
        Me.lblBookID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookID.Location = New System.Drawing.Point(115, 235)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(72, 22)
        Me.lblBookID.TabIndex = 21
        Me.lblBookID.Text = "BookID"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(93, 273)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(94, 22)
        Me.lblName.TabIndex = 19
        Me.lblName.Text = "Book Title"
        '
        'txtBookID
        '
        Me.txtBookID.Enabled = False
        Me.txtBookID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookID.Location = New System.Drawing.Point(193, 227)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(351, 30)
        Me.txtBookID.TabIndex = 25
        '
        'lblRemark
        '
        Me.lblRemark.AutoSize = True
        Me.lblRemark.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemark.Location = New System.Drawing.Point(115, 345)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(71, 22)
        Me.lblRemark.TabIndex = 26
        Me.lblRemark.Text = "Remark"
        '
        'txtRemark
        '
        Me.txtRemark.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemark.Location = New System.Drawing.Point(193, 342)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemark.Size = New System.Drawing.Size(351, 84)
        Me.txtRemark.TabIndex = 27
        '
        'picBook
        '
        Me.picBook.Location = New System.Drawing.Point(193, 5)
        Me.picBook.Name = "picBook"
        Me.picBook.Size = New System.Drawing.Size(228, 180)
        Me.picBook.TabIndex = 18
        Me.picBook.TabStop = False
        '
        'txtTransaction
        '
        Me.txtTransaction.Enabled = False
        Me.txtTransaction.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransaction.Location = New System.Drawing.Point(193, 191)
        Me.txtTransaction.Name = "txtTransaction"
        Me.txtTransaction.Size = New System.Drawing.Size(351, 30)
        Me.txtTransaction.TabIndex = 28
        '
        'lblTransaction
        '
        Me.lblTransaction.AutoSize = True
        Me.lblTransaction.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaction.Location = New System.Drawing.Point(65, 199)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(122, 22)
        Me.lblTransaction.TabIndex = 29
        Me.lblTransaction.Text = "TransactionID"
        '
        'lblDigitOnly
        '
        Me.lblDigitOnly.AutoSize = True
        Me.lblDigitOnly.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigitOnly.ForeColor = System.Drawing.Color.Red
        Me.lblDigitOnly.Location = New System.Drawing.Point(550, 310)
        Me.lblDigitOnly.Name = "lblDigitOnly"
        Me.lblDigitOnly.Size = New System.Drawing.Size(81, 21)
        Me.lblDigitOnly.TabIndex = 40
        Me.lblDigitOnly.Text = "DigitOnly"
        Me.lblDigitOnly.Visible = False
        '
        'btnMax
        '
        Me.btnMax.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMax.Location = New System.Drawing.Point(443, 303)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(101, 33)
        Me.btnMax.TabIndex = 39
        Me.btnMax.Text = "Max(100)"
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'BtnMin
        '
        Me.BtnMin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMin.Location = New System.Drawing.Point(193, 303)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(101, 33)
        Me.BtnMin.TabIndex = 38
        Me.BtnMin.Text = "Min(1)"
        Me.BtnMin.UseVisualStyleBackColor = True
        '
        'BtnMinus
        '
        Me.BtnMinus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinus.Location = New System.Drawing.Point(300, 301)
        Me.BtnMinus.Name = "BtnMinus"
        Me.BtnMinus.Size = New System.Drawing.Size(39, 37)
        Me.BtnMinus.TabIndex = 37
        Me.BtnMinus.Text = "-"
        Me.BtnMinus.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(398, 301)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(39, 36)
        Me.btnAdd.TabIndex = 36
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(345, 306)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(47, 30)
        Me.txtQty.TabIndex = 35
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.Location = New System.Drawing.Point(110, 308)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(76, 22)
        Me.lblQty.TabIndex = 34
        Me.lblQty.Text = "Quantity"
        '
        'frmEditReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 498)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDigitOnly)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.BtnMin)
        Me.Controls.Add(Me.BtnMinus)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.lblTransaction)
        Me.Controls.Add(Me.txtTransaction)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.lblRemark)
        Me.Controls.Add(Me.txtBookID)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.txtBookTitle)
        Me.Controls.Add(Me.lblBookID)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.picBook)
        Me.Name = "frmEditReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents txtBookTitle As TextBox
    Friend WithEvents lblBookID As Label
    Friend WithEvents lblName As Label
    Friend WithEvents picBook As PictureBox
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents lblRemark As Label
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents txtTransaction As TextBox
    Friend WithEvents lblTransaction As Label
    Friend WithEvents lblDigitOnly As Label
    Friend WithEvents btnMax As Button
    Friend WithEvents BtnMin As Button
    Friend WithEvents BtnMinus As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtQty As TextBox
    Friend WithEvents lblQty As Label
End Class
