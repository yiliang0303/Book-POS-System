<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSelectSummaryReport
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
        Me.flp = New System.Windows.Forms.FlowLayoutPanel()
        Me.grpYaxis = New System.Windows.Forms.GroupBox()
        Me.radQuantity = New System.Windows.Forms.RadioButton()
        Me.radSales = New System.Windows.Forms.RadioButton()
        Me.dgvCat = New System.Windows.Forms.DataGridView()
        Me.lstCat = New System.Windows.Forms.ListBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.grpYaxis.SuspendLayout()
        CType(Me.dgvCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flp
        '
        Me.flp.AutoScroll = True
        Me.flp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flp.Location = New System.Drawing.Point(389, 22)
        Me.flp.Margin = New System.Windows.Forms.Padding(4)
        Me.flp.Name = "flp"
        Me.flp.Size = New System.Drawing.Size(555, 181)
        Me.flp.TabIndex = 15
        '
        'grpYaxis
        '
        Me.grpYaxis.Controls.Add(Me.radQuantity)
        Me.grpYaxis.Controls.Add(Me.radSales)
        Me.grpYaxis.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpYaxis.Location = New System.Drawing.Point(20, 22)
        Me.grpYaxis.Margin = New System.Windows.Forms.Padding(4)
        Me.grpYaxis.Name = "grpYaxis"
        Me.grpYaxis.Padding = New System.Windows.Forms.Padding(4)
        Me.grpYaxis.Size = New System.Drawing.Size(354, 119)
        Me.grpYaxis.TabIndex = 16
        Me.grpYaxis.TabStop = False
        Me.grpYaxis.Text = "Y - axis"
        '
        'radQuantity
        '
        Me.radQuantity.AutoSize = True
        Me.radQuantity.Location = New System.Drawing.Point(8, 72)
        Me.radQuantity.Name = "radQuantity"
        Me.radQuantity.Size = New System.Drawing.Size(97, 26)
        Me.radQuantity.TabIndex = 1
        Me.radQuantity.TabStop = True
        Me.radQuantity.Text = "Quantity"
        Me.radQuantity.UseVisualStyleBackColor = True
        '
        'radSales
        '
        Me.radSales.AutoSize = True
        Me.radSales.Checked = True
        Me.radSales.Location = New System.Drawing.Point(8, 31)
        Me.radSales.Name = "radSales"
        Me.radSales.Size = New System.Drawing.Size(74, 26)
        Me.radSales.TabIndex = 0
        Me.radSales.TabStop = True
        Me.radSales.Text = "Sales"
        Me.radSales.UseVisualStyleBackColor = True
        '
        'dgvCat
        '
        Me.dgvCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCat.Location = New System.Drawing.Point(20, 148)
        Me.dgvCat.Name = "dgvCat"
        Me.dgvCat.RowTemplate.Height = 27
        Me.dgvCat.Size = New System.Drawing.Size(240, 150)
        Me.dgvCat.TabIndex = 17
        Me.dgvCat.Visible = False
        '
        'lstCat
        '
        Me.lstCat.FormattingEnabled = True
        Me.lstCat.ItemHeight = 22
        Me.lstCat.Location = New System.Drawing.Point(20, 164)
        Me.lstCat.Name = "lstCat"
        Me.lstCat.Size = New System.Drawing.Size(218, 114)
        Me.lstCat.TabIndex = 18
        Me.lstCat.Visible = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(12, 226)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(152, 72)
        Me.btnConfirm.TabIndex = 19
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Location = New System.Drawing.Point(182, 226)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(152, 72)
        Me.btnSelectAll.TabIndex = 20
        Me.btnSelectAll.Text = "Select All"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(351, 226)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(152, 72)
        Me.btnReset.TabIndex = 21
        Me.btnReset.Text = "Reset All"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmSelectSummaryReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 329)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lstCat)
        Me.Controls.Add(Me.dgvCat)
        Me.Controls.Add(Me.grpYaxis)
        Me.Controls.Add(Me.flp)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSelectSummaryReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSelectSummaryReport"
        Me.grpYaxis.ResumeLayout(False)
        Me.grpYaxis.PerformLayout()
        CType(Me.dgvCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flp As FlowLayoutPanel
    Friend WithEvents grpYaxis As GroupBox
    Friend WithEvents dgvCat As DataGridView
    Friend WithEvents radQuantity As RadioButton
    Friend WithEvents radSales As RadioButton
    Friend WithEvents lstCat As ListBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnSelectAll As Button
    Friend WithEvents btnReset As Button
End Class
