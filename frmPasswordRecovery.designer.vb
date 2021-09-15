<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPasswordRecovery
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
        Me.grpResetPassword = New System.Windows.Forms.GroupBox()
        Me.lblPass2False = New System.Windows.Forms.Label()
        Me.lblPass1False = New System.Windows.Forms.Label()
        Me.picVisible2 = New System.Windows.Forms.PictureBox()
        Me.picVisible = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtPassword1 = New System.Windows.Forms.TextBox()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picValidCode = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblEmailFalse = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnSendCode = New System.Windows.Forms.Button()
        Me.btnResend = New System.Windows.Forms.Button()
        Me.grpResetPassword.SuspendLayout()
        CType(Me.picVisible2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVisible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picValidCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpResetPassword
        '
        Me.grpResetPassword.Controls.Add(Me.lblPass2False)
        Me.grpResetPassword.Controls.Add(Me.lblPass1False)
        Me.grpResetPassword.Controls.Add(Me.picVisible2)
        Me.grpResetPassword.Controls.Add(Me.picVisible)
        Me.grpResetPassword.Controls.Add(Me.btnReset)
        Me.grpResetPassword.Controls.Add(Me.txtPassword1)
        Me.grpResetPassword.Controls.Add(Me.txtPassword2)
        Me.grpResetPassword.Controls.Add(Me.Label3)
        Me.grpResetPassword.Controls.Add(Me.Label4)
        Me.grpResetPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpResetPassword.Location = New System.Drawing.Point(224, 247)
        Me.grpResetPassword.Name = "grpResetPassword"
        Me.grpResetPassword.Size = New System.Drawing.Size(532, 200)
        Me.grpResetPassword.TabIndex = 32
        Me.grpResetPassword.TabStop = False
        Me.grpResetPassword.Text = "Reset Password"
        '
        'lblPass2False
        '
        Me.lblPass2False.ForeColor = System.Drawing.Color.Red
        Me.lblPass2False.Location = New System.Drawing.Point(374, 110)
        Me.lblPass2False.Name = "lblPass2False"
        Me.lblPass2False.Size = New System.Drawing.Size(155, 21)
        Me.lblPass2False.TabIndex = 59
        '
        'lblPass1False
        '
        Me.lblPass1False.ForeColor = System.Drawing.Color.Red
        Me.lblPass1False.Location = New System.Drawing.Point(374, 52)
        Me.lblPass1False.Name = "lblPass1False"
        Me.lblPass1False.Size = New System.Drawing.Size(152, 78)
        Me.lblPass1False.TabIndex = 58
        '
        'picVisible2
        '
        Me.picVisible2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picVisible2.Image = Global.BookPOS.My.Resources.Resources.invisible
        Me.picVisible2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picVisible2.Location = New System.Drawing.Point(334, 105)
        Me.picVisible2.Name = "picVisible2"
        Me.picVisible2.Size = New System.Drawing.Size(34, 25)
        Me.picVisible2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVisible2.TabIndex = 57
        Me.picVisible2.TabStop = False
        '
        'picVisible
        '
        Me.picVisible.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picVisible.Image = Global.BookPOS.My.Resources.Resources.invisible
        Me.picVisible.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picVisible.Location = New System.Drawing.Point(334, 51)
        Me.picVisible.Name = "picVisible"
        Me.picVisible.Size = New System.Drawing.Size(34, 25)
        Me.picVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVisible.TabIndex = 56
        Me.picVisible.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(187, 159)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(127, 35)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtPassword1
        '
        Me.txtPassword1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword1.Location = New System.Drawing.Point(175, 52)
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.Size = New System.Drawing.Size(153, 26)
        Me.txtPassword1.TabIndex = 7
        Me.txtPassword1.UseSystemPasswordChar = True
        '
        'txtPassword2
        '
        Me.txtPassword2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword2.Location = New System.Drawing.Point(175, 105)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.Size = New System.Drawing.Size(153, 26)
        Me.txtPassword2.TabIndex = 9
        Me.txtPassword2.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password                : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Confirm Password : "
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(482, 173)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 31
        Me.lblStatus.Text = "Status"
        Me.lblStatus.Visible = False
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(299, 166)
        Me.txtCode.MaxLength = 6
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(153, 26)
        Me.txtCode.TabIndex = 28
        Me.txtCode.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(232, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Code : "
        Me.Label2.Visible = False
        '
        'picValidCode
        '
        Me.picValidCode.Location = New System.Drawing.Point(458, 169)
        Me.picValidCode.Name = "picValidCode"
        Me.picValidCode.Size = New System.Drawing.Size(20, 20)
        Me.picValidCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picValidCode.TabIndex = 30
        Me.picValidCode.TabStop = False
        Me.picValidCode.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(231, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Email : "
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(232, 22)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(466, 50)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Password Recovery"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmailFalse
        '
        Me.lblEmailFalse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailFalse.ForeColor = System.Drawing.Color.Red
        Me.lblEmailFalse.Location = New System.Drawing.Point(519, 124)
        Me.lblEmailFalse.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmailFalse.Name = "lblEmailFalse"
        Me.lblEmailFalse.Size = New System.Drawing.Size(150, 26)
        Me.lblEmailFalse.TabIndex = 35
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(296, 118)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(219, 26)
        Me.txtEmail.TabIndex = 34
        '
        'btnSendCode
        '
        Me.btnSendCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendCode.Location = New System.Drawing.Point(525, 115)
        Me.btnSendCode.Name = "btnSendCode"
        Me.btnSendCode.Size = New System.Drawing.Size(131, 32)
        Me.btnSendCode.TabIndex = 60
        Me.btnSendCode.Text = "Send Code"
        Me.btnSendCode.UseVisualStyleBackColor = True
        Me.btnSendCode.Visible = False
        '
        'btnResend
        '
        Me.btnResend.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResend.Location = New System.Drawing.Point(525, 162)
        Me.btnResend.Name = "btnResend"
        Me.btnResend.Size = New System.Drawing.Size(131, 32)
        Me.btnResend.TabIndex = 61
        Me.btnResend.Text = "Resend Code"
        Me.btnResend.UseVisualStyleBackColor = True
        Me.btnResend.Visible = False
        '
        'frmPasswordRecovery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 486)
        Me.Controls.Add(Me.btnResend)
        Me.Controls.Add(Me.btnSendCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblEmailFalse)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.grpResetPassword)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.picValidCode)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPasswordRecovery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPasswordRecovery"
        Me.grpResetPassword.ResumeLayout(False)
        Me.grpResetPassword.PerformLayout()
        CType(Me.picVisible2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVisible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picValidCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpResetPassword As GroupBox
    Friend WithEvents btnReset As Button
    Friend WithEvents txtPassword1 As TextBox
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents picValidCode As PictureBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents picVisible2 As PictureBox
    Friend WithEvents picVisible As PictureBox
    Friend WithEvents lblPass2False As Label
    Friend WithEvents lblPass1False As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblEmailFalse As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnSendCode As Button
    Friend WithEvents btnResend As Button
End Class
