<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMemberLogin
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
        Me.LinklblSignUp = New System.Windows.Forms.LinkLabel()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinklblForgotPass = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnQRcode = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinklblSignUp
        '
        Me.LinklblSignUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LinklblSignUp.AutoSize = True
        Me.LinklblSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinklblSignUp.Location = New System.Drawing.Point(972, 936)
        Me.LinklblSignUp.Name = "LinklblSignUp"
        Me.LinklblSignUp.Size = New System.Drawing.Size(93, 25)
        Me.LinklblSignUp.TabIndex = 49
        Me.LinklblSignUp.TabStop = True
        Me.LinklblSignUp.Text = "Sign Up?"
        '
        'txtUser
        '
        Me.txtUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtUser.BackColor = System.Drawing.Color.White
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.Black
        Me.txtUser.Location = New System.Drawing.Point(909, 462)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(340, 30)
        Me.txtUser.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(942, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 38)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Login"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinklblForgotPass
        '
        Me.LinklblForgotPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinklblForgotPass.AutoSize = True
        Me.LinklblForgotPass.Location = New System.Drawing.Point(1072, 552)
        Me.LinklblForgotPass.Margin = New System.Windows.Forms.Padding(200, 0, 0, 0)
        Me.LinklblForgotPass.Name = "LinklblForgotPass"
        Me.LinklblForgotPass.Size = New System.Drawing.Size(143, 15)
        Me.LinklblForgotPass.TabIndex = 47
        Me.LinklblForgotPass.TabStop = True
        Me.LinklblForgotPass.Text = "Forgot password ?"
        Me.LinklblForgotPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(766, 936)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 25)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Need an account?"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(821, 655)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(311, 47)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(909, 503)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(340, 30)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(786, 462)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 25)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(786, 506)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 25)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Password:"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(1819, 918)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(80, 40)
        Me.dgv.TabIndex = 54
        Me.dgv.Visible = False
        '
        'btnQRcode
        '
        Me.btnQRcode.BackColor = System.Drawing.Color.White
        Me.btnQRcode.ForeColor = System.Drawing.Color.Black
        Me.btnQRcode.Location = New System.Drawing.Point(821, 722)
        Me.btnQRcode.Name = "btnQRcode"
        Me.btnQRcode.Size = New System.Drawing.Size(311, 47)
        Me.btnQRcode.TabIndex = 55
        Me.btnQRcode.Text = "Login With QR code"
        Me.btnQRcode.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.BookPOS.My.Resources.Resources.showHidePass
        Me.PictureBox2.Location = New System.Drawing.Point(1330, 503)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.BookPOS.My.Resources.Resources.MyBookBookStore
        Me.PictureBox1.Location = New System.Drawing.Point(835, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'FrmMemberLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1924, 968)
        Me.Controls.Add(Me.btnQRcode)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinklblForgotPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.LinklblSignUp)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "FrmMemberLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMemberLogin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinklblSignUp As LinkLabel
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinklblForgotPass As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btnQRcode As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
