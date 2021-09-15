<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddProduct
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
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.txtOtherCategory = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dtpPublishDate = New System.Windows.Forms.DateTimePicker()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtAuthorName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtLanguage = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picBook = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblOther = New System.Windows.Forms.Label()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(412, 91)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(121, 23)
        Me.cmbCategory.TabIndex = 1
        '
        'txtOtherCategory
        '
        Me.txtOtherCategory.Enabled = False
        Me.txtOtherCategory.Location = New System.Drawing.Point(587, 91)
        Me.txtOtherCategory.Multiline = True
        Me.txtOtherCategory.Name = "txtOtherCategory"
        Me.txtOtherCategory.Size = New System.Drawing.Size(120, 23)
        Me.txtOtherCategory.TabIndex = 2
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dtpPublishDate
        '
        Me.dtpPublishDate.Location = New System.Drawing.Point(412, 295)
        Me.dtpPublishDate.Name = "dtpPublishDate"
        Me.dtpPublishDate.Size = New System.Drawing.Size(121, 25)
        Me.dtpPublishDate.TabIndex = 6
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(412, 138)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(121, 28)
        Me.txtTitle.TabIndex = 3
        '
        'txtAuthorName
        '
        Me.txtAuthorName.Location = New System.Drawing.Point(411, 243)
        Me.txtAuthorName.Multiline = True
        Me.txtAuthorName.Name = "txtAuthorName"
        Me.txtAuthorName.Size = New System.Drawing.Size(121, 28)
        Me.txtAuthorName.TabIndex = 5
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(412, 340)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 28)
        Me.txtPrice.TabIndex = 7
        '
        'nudQuantity
        '
        Me.nudQuantity.Hexadecimal = True
        Me.nudQuantity.Location = New System.Drawing.Point(412, 393)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(120, 25)
        Me.nudQuantity.TabIndex = 8
        Me.nudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdd.Location = New System.Drawing.Point(587, 360)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(146, 52)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(3, 490)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(23, 24)
        Me.dgv.TabIndex = 16
        Me.dgv.Visible = False
        '
        'txtLanguage
        '
        Me.txtLanguage.Location = New System.Drawing.Point(412, 190)
        Me.txtLanguage.Multiline = True
        Me.txtLanguage.Name = "txtLanguage"
        Me.txtLanguage.Size = New System.Drawing.Size(120, 28)
        Me.txtLanguage.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(250, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 25)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Language   :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(252, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 25)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Date            :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(255, 388)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 25)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Quantity     :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(254, 338)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 25)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Price           :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(250, 242)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 25)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Author         :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(251, 138)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 25)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Book Title   :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(248, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 25)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Categories  :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BookPOS.My.Resources.Resources.mybook
        Me.PictureBox1.Location = New System.Drawing.Point(25, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 46)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Add Book"
        '
        'picBook
        '
        Me.picBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBook.Location = New System.Drawing.Point(23, 121)
        Me.picBook.Name = "picBook"
        Me.picBook.Size = New System.Drawing.Size(170, 160)
        Me.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBook.TabIndex = 44
        Me.picBook.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 25)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Book Image:"
        '
        'lblOther
        '
        Me.lblOther.AutoSize = True
        Me.lblOther.BackColor = System.Drawing.SystemColors.Control
        Me.lblOther.ForeColor = System.Drawing.Color.Red
        Me.lblOther.Location = New System.Drawing.Point(584, 72)
        Me.lblOther.Name = "lblOther"
        Me.lblOther.Size = New System.Drawing.Size(63, 15)
        Me.lblOther.TabIndex = 46
        Me.lblOther.Text = "*Other:"
        Me.lblOther.Visible = False
        '
        'FrmAddProduct
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 460)
        Me.Controls.Add(Me.lblOther)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picBook)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtLanguage)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.nudQuantity)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtAuthorName)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.dtpPublishDate)
        Me.Controls.Add(Me.txtOtherCategory)
        Me.Controls.Add(Me.cmbCategory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmAddProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Product"
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents txtOtherCategory As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents dtpPublishDate As DateTimePicker
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthorName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents txtLanguage As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents picBook As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblOther As Label
End Class
