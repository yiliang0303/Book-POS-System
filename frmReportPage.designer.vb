<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportPage
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
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.txtTop = New System.Windows.Forms.TextBox()
        Me.lblTop = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboType
        '
        Me.cboType.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Summary Report", "Detailed Report", "Exception Report"})
        Me.cboType.Location = New System.Drawing.Point(409, 70)
        Me.cboType.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(600, 37)
        Me.cboType.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Types of report :"
        '
        'cboName
        '
        Me.cboName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(409, 149)
        Me.cboName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(600, 37)
        Me.cboName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(167, 159)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Report name :"
        '
        'btnGenerate
        '
        Me.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(484, 489)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(177, 47)
        Me.btnGenerate.TabIndex = 11
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lblQuantity
        '
        Me.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(167, 233)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(112, 29)
        Me.lblQuantity.TabIndex = 49
        Me.lblQuantity.Text = "Quantity :"
        Me.lblQuantity.Visible = False
        '
        'txtQuantity
        '
        Me.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(409, 226)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(268, 34)
        Me.txtQuantity.TabIndex = 50
        Me.txtQuantity.Visible = False
        '
        'lblYear
        '
        Me.lblYear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(167, 311)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(76, 29)
        Me.lblYear.TabIndex = 54
        Me.lblYear.Text = "Year :"
        Me.lblYear.Visible = False
        '
        'cboYear
        '
        Me.cboYear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"2019", "2020", "2021"})
        Me.cboYear.Location = New System.Drawing.Point(409, 303)
        Me.cboYear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(600, 37)
        Me.cboYear.TabIndex = 53
        Me.cboYear.Visible = False
        '
        'lblMonth
        '
        Me.lblMonth.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(167, 233)
        Me.lblMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(91, 29)
        Me.lblMonth.TabIndex = 52
        Me.lblMonth.Text = "Month :"
        Me.lblMonth.Visible = False
        '
        'cboMonth
        '
        Me.cboMonth.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonth.Location = New System.Drawing.Point(409, 225)
        Me.cboMonth.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(600, 37)
        Me.cboMonth.TabIndex = 51
        Me.cboMonth.Visible = False
        '
        'txtTop
        '
        Me.txtTop.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTop.Location = New System.Drawing.Point(409, 226)
        Me.txtTop.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTop.Name = "txtTop"
        Me.txtTop.Size = New System.Drawing.Size(268, 34)
        Me.txtTop.TabIndex = 56
        Me.txtTop.Visible = False
        '
        'lblTop
        '
        Me.lblTop.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTop.AutoSize = True
        Me.lblTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTop.Location = New System.Drawing.Point(167, 233)
        Me.lblTop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTop.Name = "lblTop"
        Me.lblTop.Size = New System.Drawing.Size(98, 29)
        Me.lblTop.TabIndex = 55
        Me.lblTop.Text = "Top X  :"
        Me.lblTop.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BookPOS.My.Resources.Resources.mybook
        Me.PictureBox1.Location = New System.Drawing.Point(956, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(275, 223)
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.btnBack.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBack.Location = New System.Drawing.Point(3, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(157, 53)
        Me.btnBack.TabIndex = 58
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmReportPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 583)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtTop)
        Me.Controls.Add(Me.lblTop)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboType)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmReportPage"
        Me.Text = "frmReportPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboName As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblYear As Label
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents lblMonth As Label
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents txtTop As TextBox
    Friend WithEvents lblTop As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
End Class
