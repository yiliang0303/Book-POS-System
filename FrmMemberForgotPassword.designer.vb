<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMemberForgotPassword
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblConfirmPassFalse = New System.Windows.Forms.Label()
        Me.lblPassFalse = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtPassword1 = New System.Windows.Forms.TextBox()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.lblEmailFalse = New System.Windows.Forms.Label()
        Me.PanelSpacing = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picValidCode = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picValidCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1034, 33)
        Me.Panel1.TabIndex = 42
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(828, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(206, 33)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(97, 27)
        Me.Panel2.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Location = New System.Drawing.Point(15, 8)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(66, 19)
        Me.LinkLabel1.TabIndex = 44
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Login"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LinkLabel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(106, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(97, 27)
        Me.Panel3.TabIndex = 1
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Location = New System.Drawing.Point(17, 8)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(62, 19)
        Me.LinkLabel2.TabIndex = 43
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Register"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblConfirmPassFalse)
        Me.GroupBox1.Controls.Add(Me.lblPassFalse)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.txtPassword1)
        Me.GroupBox1.Controls.Add(Me.txtPassword2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(178, 626)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(724, 246)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reset Password"
        Me.GroupBox1.Visible = False
        '
        'lblConfirmPassFalse
        '
        Me.lblConfirmPassFalse.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassFalse.ForeColor = System.Drawing.Color.Red
        Me.lblConfirmPassFalse.Location = New System.Drawing.Point(476, 115)
        Me.lblConfirmPassFalse.Name = "lblConfirmPassFalse"
        Me.lblConfirmPassFalse.Size = New System.Drawing.Size(221, 38)
        Me.lblConfirmPassFalse.TabIndex = 58
        Me.lblConfirmPassFalse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPassFalse
        '
        Me.lblPassFalse.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassFalse.ForeColor = System.Drawing.Color.Red
        Me.lblPassFalse.Location = New System.Drawing.Point(492, 63)
        Me.lblPassFalse.Name = "lblPassFalse"
        Me.lblPassFalse.Size = New System.Drawing.Size(221, 38)
        Me.lblPassFalse.TabIndex = 57
        Me.lblPassFalse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.BookPOS.My.Resources.Resources.showHidePass
        Me.PictureBox2.Location = New System.Drawing.Point(443, 64)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 57
        Me.PictureBox2.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(359, 182)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(142, 43)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'txtPassword1
        '
        Me.txtPassword1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword1.Location = New System.Drawing.Point(233, 66)
        Me.txtPassword1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.Size = New System.Drawing.Size(203, 30)
        Me.txtPassword1.TabIndex = 7
        Me.txtPassword1.UseSystemPasswordChar = True
        '
        'txtPassword2
        '
        Me.txtPassword2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword2.Location = New System.Drawing.Point(233, 116)
        Me.txtPassword2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.Size = New System.Drawing.Size(203, 30)
        Me.txtPassword2.TabIndex = 9
        Me.txtPassword2.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 71)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Password                : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 123)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Confirm Password : "
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(520, 542)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(48, 17)
        Me.lblStatus.TabIndex = 51
        Me.lblStatus.Text = "Status"
        Me.lblStatus.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(173, 482)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 25)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Email : "
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(263, 531)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCode.MaxLength = 6
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(203, 30)
        Me.txtCode.TabIndex = 48
        Me.txtCode.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(173, 538)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 25)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Code : "
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(268, 419)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(431, 38)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Forgot your password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(254, 332)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(457, 62)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Forgot Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(263, 479)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(291, 30)
        Me.txtEmail.TabIndex = 44
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.White
        Me.btnSend.Location = New System.Drawing.Point(593, 534)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(152, 30)
        Me.btnSend.TabIndex = 43
        Me.btnSend.Text = "Send Code"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'lblEmailFalse
        '
        Me.lblEmailFalse.ForeColor = System.Drawing.Color.Red
        Me.lblEmailFalse.Location = New System.Drawing.Point(605, 471)
        Me.lblEmailFalse.Name = "lblEmailFalse"
        Me.lblEmailFalse.Size = New System.Drawing.Size(131, 38)
        Me.lblEmailFalse.TabIndex = 53
        Me.lblEmailFalse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelSpacing
        '
        Me.PanelSpacing.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSpacing.Location = New System.Drawing.Point(0, 33)
        Me.PanelSpacing.Name = "PanelSpacing"
        Me.PanelSpacing.Size = New System.Drawing.Size(1034, 39)
        Me.PanelSpacing.TabIndex = 55
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Location = New System.Drawing.Point(0, 69)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1034, 260)
        Me.Panel4.TabIndex = 56
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.BookPOS.My.Resources.Resources.MyBookBookStore
        Me.PictureBox1.Location = New System.Drawing.Point(370, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(302, 270)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'picValidCode
        '
        Me.picValidCode.Image = Global.BookPOS.My.Resources.Resources._false
        Me.picValidCode.Location = New System.Drawing.Point(486, 536)
        Me.picValidCode.Margin = New System.Windows.Forms.Padding(4)
        Me.picValidCode.Name = "picValidCode"
        Me.picValidCode.Size = New System.Drawing.Size(27, 25)
        Me.picValidCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picValidCode.TabIndex = 50
        Me.picValidCode.TabStop = False
        Me.picValidCode.Visible = False
        '
        'FrmMemberForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1034, 1014)
        Me.Controls.Add(Me.PanelSpacing)
        Me.Controls.Add(Me.lblEmailFalse)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.picValidCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMemberForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMemberForgotPassword"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picValidCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnReset As Button
    Friend WithEvents txtPassword1 As TextBox
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents picValidCode As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents lblEmailFalse As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelSpacing As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblPassFalse As Label
    Friend WithEvents lblConfirmPassFalse As Label
End Class
