<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSetting
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
        Me.btnBackgroundColor = New System.Windows.Forms.Button()
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.btnButtonColor = New System.Windows.Forms.Button()
        Me.btnButtonFont = New System.Windows.Forms.Button()
        Me.dlgFont = New System.Windows.Forms.FontDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFontColor = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBackgroundColor
        '
        Me.btnBackgroundColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackgroundColor.Location = New System.Drawing.Point(302, 133)
        Me.btnBackgroundColor.Name = "btnBackgroundColor"
        Me.btnBackgroundColor.Size = New System.Drawing.Size(221, 40)
        Me.btnBackgroundColor.TabIndex = 0
        Me.btnBackgroundColor.Text = "Change"
        Me.btnBackgroundColor.UseVisualStyleBackColor = True
        '
        'btnButtonColor
        '
        Me.btnButtonColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButtonColor.Location = New System.Drawing.Point(302, 203)
        Me.btnButtonColor.Name = "btnButtonColor"
        Me.btnButtonColor.Size = New System.Drawing.Size(221, 40)
        Me.btnButtonColor.TabIndex = 33
        Me.btnButtonColor.Text = "Change"
        Me.btnButtonColor.UseVisualStyleBackColor = True
        '
        'btnButtonFont
        '
        Me.btnButtonFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButtonFont.Location = New System.Drawing.Point(302, 280)
        Me.btnButtonFont.Name = "btnButtonFont"
        Me.btnButtonFont.Size = New System.Drawing.Size(221, 40)
        Me.btnButtonFont.TabIndex = 34
        Me.btnButtonFont.Text = "Change"
        Me.btnButtonFont.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 25)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Background Color :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 25)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Button Back Color :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 25)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Button Font :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 369)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 25)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Button Font Color:"
        '
        'btnFontColor
        '
        Me.btnFontColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFontColor.Location = New System.Drawing.Point(302, 354)
        Me.btnFontColor.Name = "btnFontColor"
        Me.btnFontColor.Size = New System.Drawing.Size(221, 40)
        Me.btnFontColor.TabIndex = 39
        Me.btnFontColor.Text = "Change"
        Me.btnFontColor.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BookPOS.My.Resources.Resources.mybook
        Me.PictureBox1.Location = New System.Drawing.Point(582, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 181)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'btnBack2
        '
        Me.btnBack2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.btnBack2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBack2.Location = New System.Drawing.Point(11, 3)
        Me.btnBack2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnBack2.Name = "btnBack2"
        Me.btnBack2.Size = New System.Drawing.Size(118, 43)
        Me.btnBack2.TabIndex = 59
        Me.btnBack2.Text = "&Back"
        Me.btnBack2.UseVisualStyleBackColor = True
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBack2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnFontColor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnButtonFont)
        Me.Controls.Add(Me.btnButtonColor)
        Me.Controls.Add(Me.btnBackgroundColor)
        Me.Name = "frmSetting"
        Me.Text = "frmSetting"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBackgroundColor As Button
    Friend WithEvents dlgColor As ColorDialog
    Friend WithEvents btnButtonColor As Button
    Friend WithEvents btnButtonFont As Button
    Friend WithEvents dlgFont As FontDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnFontColor As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack2 As Button
End Class
