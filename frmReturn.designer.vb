<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReturn
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnCancelBack = New System.Windows.Forms.Button()
        Me.dgvTransDetail = New System.Windows.Forms.DataGridView()
        Me.BookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookTiTle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTrans2 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvTransDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTrans2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnReturn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancelBack, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 396)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(598, 44)
        Me.TableLayoutPanel1.TabIndex = 35
        '
        'btnReturn
        '
        Me.btnReturn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReturn.Location = New System.Drawing.Point(3, 3)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(293, 38)
        Me.btnReturn.TabIndex = 30
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnCancelBack
        '
        Me.btnCancelBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelBack.Location = New System.Drawing.Point(302, 3)
        Me.btnCancelBack.Name = "btnCancelBack"
        Me.btnCancelBack.Size = New System.Drawing.Size(293, 38)
        Me.btnCancelBack.TabIndex = 32
        Me.btnCancelBack.Text = "&Cancel"
        Me.btnCancelBack.UseVisualStyleBackColor = True
        '
        'dgvTransDetail
        '
        Me.dgvTransDetail.AllowUserToAddRows = False
        Me.dgvTransDetail.AllowUserToDeleteRows = False
        Me.dgvTransDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTransDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTransDetail.BackgroundColor = System.Drawing.Color.White
        Me.dgvTransDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvTransDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookID, Me.BookTiTle, Me.BookPrice, Me.BookQuantity})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTransDetail.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvTransDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTransDetail.Location = New System.Drawing.Point(0, 0)
        Me.dgvTransDetail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvTransDetail.Name = "dgvTransDetail"
        Me.dgvTransDetail.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransDetail.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvTransDetail.RowHeadersVisible = False
        Me.dgvTransDetail.Size = New System.Drawing.Size(598, 440)
        Me.dgvTransDetail.TabIndex = 34
        '
        'BookID
        '
        Me.BookID.HeaderText = "BookID"
        Me.BookID.Name = "BookID"
        Me.BookID.ReadOnly = True
        '
        'BookTiTle
        '
        Me.BookTiTle.HeaderText = "BookTiTle"
        Me.BookTiTle.Name = "BookTiTle"
        Me.BookTiTle.ReadOnly = True
        '
        'BookPrice
        '
        Me.BookPrice.HeaderText = "Book Price"
        Me.BookPrice.Name = "BookPrice"
        Me.BookPrice.ReadOnly = True
        '
        'BookQuantity
        '
        Me.BookQuantity.HeaderText = "BookQuantity"
        Me.BookQuantity.Name = "BookQuantity"
        Me.BookQuantity.ReadOnly = True
        '
        'dgvTrans2
        '
        Me.dgvTrans2.AllowUserToAddRows = False
        Me.dgvTrans2.AllowUserToDeleteRows = False
        Me.dgvTrans2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTrans2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTrans2.BackgroundColor = System.Drawing.Color.White
        Me.dgvTrans2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTrans2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvTrans2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTrans2.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvTrans2.Location = New System.Drawing.Point(72, 87)
        Me.dgvTrans2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvTrans2.Name = "dgvTrans2"
        Me.dgvTrans2.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTrans2.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvTrans2.RowHeadersVisible = False
        Me.dgvTrans2.Size = New System.Drawing.Size(109, 98)
        Me.dgvTrans2.TabIndex = 36
        '
        'frmReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 440)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.dgvTransDetail)
        Me.Controls.Add(Me.dgvTrans2)
        Me.Name = "frmReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReturn"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvTransDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTrans2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnCancelBack As Button
    Friend WithEvents dgvTransDetail As DataGridView
    Friend WithEvents dgvTrans2 As DataGridView
    Friend WithEvents BookID As DataGridViewTextBoxColumn
    Friend WithEvents BookTiTle As DataGridViewTextBoxColumn
    Friend WithEvents BookPrice As DataGridViewTextBoxColumn
    Friend WithEvents BookQuantity As DataGridViewTextBoxColumn
End Class
