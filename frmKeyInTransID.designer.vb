<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKeyInTransID
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
        Me.lblTranID = New System.Windows.Forms.Label()
        Me.txtTransaction = New System.Windows.Forms.TextBox()
        Me.btnQRCode = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnConfirm, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 73)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(567, 58)
        Me.TableLayoutPanel1.TabIndex = 66
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(192, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(183, 52)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "C&ancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConfirm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(381, 3)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(183, 52)
        Me.btnConfirm.TabIndex = 0
        Me.btnConfirm.Text = "&Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblTranID
        '
        Me.lblTranID.AutoSize = True
        Me.lblTranID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTranID.Location = New System.Drawing.Point(7, 34)
        Me.lblTranID.Name = "lblTranID"
        Me.lblTranID.Size = New System.Drawing.Size(138, 22)
        Me.lblTranID.TabIndex = 65
        Me.lblTranID.Text = "Transaction_ID:"
        '
        'txtTransaction
        '
        Me.txtTransaction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtTransaction.BackColor = System.Drawing.Color.White
        Me.txtTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransaction.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransaction.ForeColor = System.Drawing.Color.Black
        Me.txtTransaction.Location = New System.Drawing.Point(151, 26)
        Me.txtTransaction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTransaction.Name = "txtTransaction"
        Me.txtTransaction.Size = New System.Drawing.Size(261, 30)
        Me.txtTransaction.TabIndex = 64
        '
        'btnQRCode
        '
        Me.btnQRCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQRCode.Location = New System.Drawing.Point(419, 21)
        Me.btnQRCode.Name = "btnQRCode"
        Me.btnQRCode.Size = New System.Drawing.Size(142, 37)
        Me.btnQRCode.TabIndex = 67
        Me.btnQRCode.Text = "&QR Code"
        Me.btnQRCode.UseVisualStyleBackColor = True
        '
        'frmKeyInTransID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 131)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnQRCode)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblTranID)
        Me.Controls.Add(Me.txtTransaction)
        Me.Name = "frmKeyInTransID"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransactionID"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblTranID As Label
    Friend WithEvents txtTransaction As TextBox
    Friend WithEvents btnQRCode As Button
End Class
