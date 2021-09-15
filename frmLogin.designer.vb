<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblForgotPassword = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnAdminLogin = New System.Windows.Forms.Button()
        Me.lblForgotPass = New System.Windows.Forms.Label()
        Me.btnCashierLogin = New System.Windows.Forms.Button()
        Me.btnSelfPOS = New System.Windows.Forms.Button()
        Me.picVisible = New System.Windows.Forms.PictureBox()
        Me.picAdmin = New System.Windows.Forms.PictureBox()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.picStaff = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.picVisible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblForgotPassword
        '
        Me.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblForgotPassword.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.lblForgotPassword, "lblForgotPassword")
        Me.lblForgotPassword.Name = "lblForgotPassword"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtPassword
        '
        resources.ApplyResources(Me.txtPassword, "txtPassword")
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtUsername
        '
        resources.ApplyResources(Me.txtUsername, "txtUsername")
        Me.txtUsername.Name = "txtUsername"
        '
        'btnAdminLogin
        '
        resources.ApplyResources(Me.btnAdminLogin, "btnAdminLogin")
        Me.btnAdminLogin.Name = "btnAdminLogin"
        Me.btnAdminLogin.UseVisualStyleBackColor = True
        '
        'lblForgotPass
        '
        resources.ApplyResources(Me.lblForgotPass, "lblForgotPass")
        Me.lblForgotPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForgotPass.ForeColor = System.Drawing.Color.Blue
        Me.lblForgotPass.Name = "lblForgotPass"
        '
        'btnCashierLogin
        '
        resources.ApplyResources(Me.btnCashierLogin, "btnCashierLogin")
        Me.btnCashierLogin.Name = "btnCashierLogin"
        Me.btnCashierLogin.UseVisualStyleBackColor = True
        '
        'btnSelfPOS
        '
        resources.ApplyResources(Me.btnSelfPOS, "btnSelfPOS")
        Me.btnSelfPOS.Name = "btnSelfPOS"
        Me.btnSelfPOS.UseVisualStyleBackColor = True
        '
        'picVisible
        '
        resources.ApplyResources(Me.picVisible, "picVisible")
        Me.picVisible.Image = Global.BookPOS.My.Resources.Resources.invisible
        Me.picVisible.Name = "picVisible"
        Me.picVisible.TabStop = False
        '
        'picAdmin
        '
        resources.ApplyResources(Me.picAdmin, "picAdmin")
        Me.picAdmin.BackColor = System.Drawing.Color.Transparent
        Me.picAdmin.Image = Global.BookPOS.My.Resources.Resources.qrCODE
        Me.picAdmin.Name = "picAdmin"
        Me.picAdmin.TabStop = False
        '
        'lblAdmin
        '
        resources.ApplyResources(Me.lblAdmin, "lblAdmin")
        Me.lblAdmin.Name = "lblAdmin"
        '
        'picStaff
        '
        resources.ApplyResources(Me.picStaff, "picStaff")
        Me.picStaff.BackColor = System.Drawing.Color.Transparent
        Me.picStaff.Image = Global.BookPOS.My.Resources.Resources.qrCODE
        Me.picStaff.Name = "picStaff"
        Me.picStaff.TabStop = False
        '
        'btnBack
        '
        resources.ApplyResources(Me.btnBack, "btnBack")
        Me.btnBack.Name = "btnBack"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.picStaff)
        Me.Controls.Add(Me.btnSelfPOS)
        Me.Controls.Add(Me.btnCashierLogin)
        Me.Controls.Add(Me.picVisible)
        Me.Controls.Add(Me.lblForgotPass)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.picAdmin)
        Me.Controls.Add(Me.lblForgotPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnAdminLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLogin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picVisible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblForgotPassword As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnAdminLogin As Button
    Friend WithEvents picAdmin As PictureBox
    Friend WithEvents lblForgotPass As Label
    Friend WithEvents picVisible As PictureBox
    Friend WithEvents btnCashierLogin As Button
    Friend WithEvents btnSelfPOS As Button
    Friend WithEvents lblAdmin As Label
    Friend WithEvents picStaff As PictureBox
    Friend WithEvents btnBack As Button
End Class
