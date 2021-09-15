<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCommentBook
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblComment = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(151, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 165)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.Location = New System.Drawing.Point(477, 52)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(100, 22)
        Me.lblTitle.TabIndex = 1
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Location = New System.Drawing.Point(477, 97)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(100, 22)
        Me.lblPrice.TabIndex = 2
        '
        'lblQuantity
        '
        Me.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuantity.Location = New System.Drawing.Point(477, 139)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(100, 22)
        Me.lblQuantity.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(389, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Book Title:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(389, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Price :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(389, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Quantity"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(-1, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(762, 2)
        Me.Label6.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 33)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Comment"
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(12, 685)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(634, 50)
        Me.txtComment.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(652, 685)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 50)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Comment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblComment
        '
        Me.lblComment.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComment.Location = New System.Drawing.Point(12, 259)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.ReadOnly = True
        Me.lblComment.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.lblComment.Size = New System.Drawing.Size(737, 418)
        Me.lblComment.TabIndex = 12
        Me.lblComment.Text = ""
        '
        'FrmCommentBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 746)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "FrmCommentBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCommentBook"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtComment As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblComment As RichTextBox
End Class
