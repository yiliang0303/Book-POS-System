<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEditProduct
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
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOtherCategory = New System.Windows.Forms.TextBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.dtpPublishDate = New System.Windows.Forms.DateTimePicker()
        Me.txtLanguage = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblHistory = New System.Windows.Forms.RichTextBox()
        Me.lblOther = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.picBook = New System.Windows.Forms.PictureBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtQuantity
        '
        Me.txtQuantity.Enabled = False
        Me.txtQuantity.Location = New System.Drawing.Point(440, 413)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ReadOnly = True
        Me.txtQuantity.Size = New System.Drawing.Size(121, 30)
        Me.txtQuantity.TabIndex = 26
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(440, 359)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 30)
        Me.txtPrice.TabIndex = 25
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(440, 257)
        Me.txtAuthor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAuthor.Multiline = True
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(121, 30)
        Me.txtAuthor.TabIndex = 24
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Location = New System.Drawing.Point(440, 99)
        Me.txtBookTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBookTitle.Multiline = True
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.ReadOnly = True
        Me.txtBookTitle.Size = New System.Drawing.Size(121, 30)
        Me.txtBookTitle.TabIndex = 23
        Me.txtBookTitle.WordWrap = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(248, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 25)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Date            :"
        '
        'txtOtherCategory
        '
        Me.txtOtherCategory.Enabled = False
        Me.txtOtherCategory.Location = New System.Drawing.Point(624, 153)
        Me.txtOtherCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOtherCategory.Multiline = True
        Me.txtOtherCategory.Name = "txtOtherCategory"
        Me.txtOtherCategory.Size = New System.Drawing.Size(121, 24)
        Me.txtOtherCategory.TabIndex = 20
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(440, 153)
        Me.cmbCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(121, 24)
        Me.cmbCategory.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(251, 413)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Quantity     :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(250, 359)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 25)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Price           :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(246, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Author         :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(247, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Book Title   :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Categories  :"
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(637, 342)
        Me.btnDone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(117, 45)
        Me.btnDone.TabIndex = 28
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(637, 401)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(117, 45)
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(747, 12)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(31, 31)
        Me.dgv.TabIndex = 30
        '
        'dtpPublishDate
        '
        Me.dtpPublishDate.Location = New System.Drawing.Point(440, 311)
        Me.dtpPublishDate.Name = "dtpPublishDate"
        Me.dtpPublishDate.Size = New System.Drawing.Size(121, 22)
        Me.dtpPublishDate.TabIndex = 31
        Me.dtpPublishDate.Value = New Date(2019, 12, 30, 22, 8, 59, 0)
        '
        'txtLanguage
        '
        Me.txtLanguage.Location = New System.Drawing.Point(440, 202)
        Me.txtLanguage.Multiline = True
        Me.txtLanguage.Name = "txtLanguage"
        Me.txtLanguage.Size = New System.Drawing.Size(121, 30)
        Me.txtLanguage.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(246, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 25)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Language   :"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(117, 470)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(659, 2)
        Me.Label8.TabIndex = 34
        '
        'lblHistory
        '
        Me.lblHistory.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistory.Location = New System.Drawing.Point(9, 494)
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.ReadOnly = True
        Me.lblHistory.Size = New System.Drawing.Size(767, 547)
        Me.lblHistory.TabIndex = 35
        Me.lblHistory.Text = ""
        '
        'lblOther
        '
        Me.lblOther.AutoSize = True
        Me.lblOther.ForeColor = System.Drawing.Color.Red
        Me.lblOther.Location = New System.Drawing.Point(621, 134)
        Me.lblOther.Name = "lblOther"
        Me.lblOther.Size = New System.Drawing.Size(53, 17)
        Me.lblOther.TabIndex = 36
        Me.lblOther.Text = "*Other:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 452)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 29)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "History :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.BookPOS.My.Resources.Resources.mybook
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(88, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(191, 44)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Edit Book"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'picBook
        '
        Me.picBook.Location = New System.Drawing.Point(50, 99)
        Me.picBook.Name = "picBook"
        Me.picBook.Size = New System.Drawing.Size(170, 170)
        Me.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBook.TabIndex = 40
        Me.picBook.TabStop = False
        '
        'FrmEditProduct
        '
        Me.AcceptButton = Me.btnDone
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(790, 1053)
        Me.Controls.Add(Me.picBook)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblOther)
        Me.Controls.Add(Me.lblHistory)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtLanguage)
        Me.Controls.Add(Me.dtpPublishDate)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtBookTitle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtOtherCategory)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 1100)
        Me.Name = "FrmEditProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eidt Product"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtBookTitle As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtOtherCategory As TextBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDone As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents dtpPublishDate As DateTimePicker
    Friend WithEvents txtLanguage As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblHistory As RichTextBox
    Friend WithEvents lblOther As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents picBook As PictureBox
End Class
