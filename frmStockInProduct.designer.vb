<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockInProduct
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOriQuantity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFinalQuantity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAddQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.picBook = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Location = New System.Drawing.Point(594, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 94)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Upload QR Code"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Location = New System.Drawing.Point(424, 155)
        Me.txtBookTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBookTitle.Multiline = True
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.ReadOnly = True
        Me.txtBookTitle.Size = New System.Drawing.Size(121, 28)
        Me.txtBookTitle.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(255, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Book Title       :"
        '
        'txtOriQuantity
        '
        Me.txtOriQuantity.Enabled = False
        Me.txtOriQuantity.Location = New System.Drawing.Point(424, 206)
        Me.txtOriQuantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOriQuantity.Multiline = True
        Me.txtOriQuantity.Name = "txtOriQuantity"
        Me.txtOriQuantity.ReadOnly = True
        Me.txtOriQuantity.Size = New System.Drawing.Size(121, 28)
        Me.txtOriQuantity.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(250, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 25)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Original            :"
        '
        'txtFinalQuantity
        '
        Me.txtFinalQuantity.Enabled = False
        Me.txtFinalQuantity.Location = New System.Drawing.Point(424, 307)
        Me.txtFinalQuantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFinalQuantity.Multiline = True
        Me.txtFinalQuantity.Name = "txtFinalQuantity"
        Me.txtFinalQuantity.ReadOnly = True
        Me.txtFinalQuantity.Size = New System.Drawing.Size(121, 28)
        Me.txtFinalQuantity.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Final                :"
        '
        'txtAddQuantity
        '
        Me.txtAddQuantity.Enabled = False
        Me.txtAddQuantity.Location = New System.Drawing.Point(424, 256)
        Me.txtAddQuantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddQuantity.Multiline = True
        Me.txtAddQuantity.Name = "txtAddQuantity"
        Me.txtAddQuantity.ReadOnly = True
        Me.txtAddQuantity.Size = New System.Drawing.Size(121, 28)
        Me.txtAddQuantity.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(251, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 25)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Stock In           :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.BookPOS.My.Resources.Resources.mybook
        Me.PictureBox1.Location = New System.Drawing.Point(227, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(346, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 46)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Stock In"
        '
        'picBook
        '
        Me.picBook.Location = New System.Drawing.Point(28, 147)
        Me.picBook.Name = "picBook"
        Me.picBook.Size = New System.Drawing.Size(200, 188)
        Me.picBook.TabIndex = 35
        Me.picBook.TabStop = False
        '
        'frmStockInProduct
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(781, 382)
        Me.Controls.Add(Me.picBook)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtAddQuantity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFinalQuantity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOriQuantity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBookTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmStockInProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStockInProduct"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtBookTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOriQuantity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFinalQuantity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAddQuantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents picBook As PictureBox
End Class
