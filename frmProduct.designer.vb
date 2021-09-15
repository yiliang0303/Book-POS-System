<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProduct
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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.flpCategory = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpBook = New System.Windows.Forms.FlowLayoutPanel()
        Me.radCategory = New System.Windows.Forms.RadioButton()
        Me.radBook = New System.Windows.Forms.RadioButton()
        Me.btnStockIn = New System.Windows.Forms.Button()
        Me.btnRecover = New System.Windows.Forms.Button()
        Me.btnQRcode = New System.Windows.Forms.Button()
        Me.cmbLanguage = New System.Windows.Forms.Label()
        Me.flpLanguage = New System.Windows.Forms.FlowLayoutPanel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSearch.Font = New System.Drawing.Font("Yu Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.DimGray
        Me.txtSearch.Location = New System.Drawing.Point(279, 12)
        Me.txtSearch.MaxLength = 30
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(722, 40)
        Me.txtSearch.TabIndex = 10
        Me.txtSearch.Text = "Search"
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddBook
        '
        Me.btnAddBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAddBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBook.Location = New System.Drawing.Point(727, 625)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(649, 48)
        Me.btnAddBook.TabIndex = 1
        Me.btnAddBook.Text = "Add New Book"
        Me.btnAddBook.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Red
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(20, 7)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(130, 50)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'flpCategory
        '
        Me.flpCategory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpCategory.AutoScroll = True
        Me.flpCategory.BackgroundImage = Global.BookPOS.My.Resources.Resources.mybook
        Me.flpCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.flpCategory.Location = New System.Drawing.Point(16, 67)
        Me.flpCategory.Name = "flpCategory"
        Me.flpCategory.Size = New System.Drawing.Size(1388, 558)
        Me.flpCategory.TabIndex = 4
        '
        'flpBook
        '
        Me.flpBook.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpBook.AutoScroll = True
        Me.flpBook.BackColor = System.Drawing.SystemColors.Control
        Me.flpBook.BackgroundImage = Global.BookPOS.My.Resources.Resources.mybook
        Me.flpBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.flpBook.Location = New System.Drawing.Point(16, 67)
        Me.flpBook.Name = "flpBook"
        Me.flpBook.Size = New System.Drawing.Size(1388, 549)
        Me.flpBook.TabIndex = 5
        '
        'radCategory
        '
        Me.radCategory.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.radCategory.AutoSize = True
        Me.radCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCategory.Location = New System.Drawing.Point(1052, 10)
        Me.radCategory.Name = "radCategory"
        Me.radCategory.Size = New System.Drawing.Size(106, 28)
        Me.radCategory.TabIndex = 11
        Me.radCategory.TabStop = True
        Me.radCategory.Text = "Category"
        Me.radCategory.UseVisualStyleBackColor = True
        '
        'radBook
        '
        Me.radBook.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.radBook.AutoSize = True
        Me.radBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBook.Location = New System.Drawing.Point(1052, 37)
        Me.radBook.Name = "radBook"
        Me.radBook.Size = New System.Drawing.Size(74, 28)
        Me.radBook.TabIndex = 12
        Me.radBook.TabStop = True
        Me.radBook.Text = "Book"
        Me.radBook.UseVisualStyleBackColor = True
        '
        'btnStockIn
        '
        Me.btnStockIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnStockIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockIn.Location = New System.Drawing.Point(370, 625)
        Me.btnStockIn.Name = "btnStockIn"
        Me.btnStockIn.Size = New System.Drawing.Size(666, 48)
        Me.btnStockIn.TabIndex = 14
        Me.btnStockIn.Text = "Stock In"
        Me.btnStockIn.UseVisualStyleBackColor = True
        '
        'btnRecover
        '
        Me.btnRecover.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRecover.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecover.Location = New System.Drawing.Point(16, 625)
        Me.btnRecover.Name = "btnRecover"
        Me.btnRecover.Size = New System.Drawing.Size(666, 48)
        Me.btnRecover.TabIndex = 16
        Me.btnRecover.Text = "Recover Deleted Book"
        Me.btnRecover.UseVisualStyleBackColor = True
        '
        'btnQRcode
        '
        Me.btnQRcode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnQRcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQRcode.Location = New System.Drawing.Point(156, 7)
        Me.btnQRcode.Name = "btnQRcode"
        Me.btnQRcode.Size = New System.Drawing.Size(101, 54)
        Me.btnQRcode.TabIndex = 17
        Me.btnQRcode.Text = "Upload QR Code"
        Me.btnQRcode.UseVisualStyleBackColor = True
        '
        'cmbLanguage
        '
        Me.cmbLanguage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbLanguage.BackColor = System.Drawing.Color.White
        Me.cmbLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmbLanguage.Location = New System.Drawing.Point(1212, 18)
        Me.cmbLanguage.Name = "cmbLanguage"
        Me.cmbLanguage.Size = New System.Drawing.Size(170, 23)
        Me.cmbLanguage.TabIndex = 18
        Me.cmbLanguage.Text = "\/  "
        Me.cmbLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmbLanguage.Visible = False
        '
        'flpLanguage
        '
        Me.flpLanguage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.flpLanguage.AutoScroll = True
        Me.flpLanguage.BackColor = System.Drawing.Color.White
        Me.flpLanguage.Location = New System.Drawing.Point(1212, 42)
        Me.flpLanguage.Name = "flpLanguage"
        Me.flpLanguage.Padding = New System.Windows.Forms.Padding(5, 3, 0, 0)
        Me.flpLanguage.Size = New System.Drawing.Size(170, 142)
        Me.flpLanguage.TabIndex = 19
        Me.flpLanguage.Visible = False
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(1403, 694)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(14, 13)
        Me.dgv.TabIndex = 20
        Me.dgv.Visible = False
        '
        'FrmProduct
        '
        Me.AcceptButton = Me.btnAddBook
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(1420, 710)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.flpLanguage)
        Me.Controls.Add(Me.cmbLanguage)
        Me.Controls.Add(Me.btnQRcode)
        Me.Controls.Add(Me.btnRecover)
        Me.Controls.Add(Me.btnStockIn)
        Me.Controls.Add(Me.radBook)
        Me.Controls.Add(Me.radCategory)
        Me.Controls.Add(Me.btnAddBook)
        Me.Controls.Add(Me.flpCategory)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.flpBook)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmProduct"
        Me.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnAddBook As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents flpCategory As FlowLayoutPanel
    Friend WithEvents flpBook As FlowLayoutPanel
    Friend WithEvents radCategory As RadioButton
    Friend WithEvents radBook As RadioButton
    Friend WithEvents btnStockIn As Button
    Friend WithEvents btnRecover As Button
    Friend WithEvents btnQRcode As Button
    Friend WithEvents cmbLanguage As Label
    Friend WithEvents flpLanguage As FlowLayoutPanel
    Friend WithEvents dgv As DataGridView
End Class
