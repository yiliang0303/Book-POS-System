<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Me.btnAdminRegister = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPass2False = New System.Windows.Forms.Label()
        Me.lblPass1False = New System.Windows.Forms.Label()
        Me.lblUsernameFalse = New System.Windows.Forms.Label()
        Me.picVisible2 = New System.Windows.Forms.PictureBox()
        Me.picVisible = New System.Windows.Forms.PictureBox()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpDetail = New System.Windows.Forms.GroupBox()
        Me.lblAddressFalse = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt4number = New System.Windows.Forms.TextBox()
        Me.txt2number = New System.Windows.Forms.TextBox()
        Me.txtPhone2nd = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPhone1st = New System.Windows.Forms.TextBox()
        Me.lblBirthFalse = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtYMD = New System.Windows.Forms.TextBox()
        Me.timeBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblPositionFalse = New System.Windows.Forms.Label()
        Me.lblNameFalse = New System.Windows.Forms.Label()
        Me.lblNRICFalse = New System.Windows.Forms.Label()
        Me.lblEmailFalse = New System.Windows.Forms.Label()
        Me.lblContactFalse = New System.Windows.Forms.Label()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnStaffRegister = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picVisible2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVisible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDetail.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdminRegister
        '
        Me.btnAdminRegister.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdminRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminRegister.Location = New System.Drawing.Point(1589, 855)
        Me.btnAdminRegister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdminRegister.Name = "btnAdminRegister"
        Me.btnAdminRegister.Size = New System.Drawing.Size(141, 46)
        Me.btnAdminRegister.TabIndex = 12
        Me.btnAdminRegister.Text = "Register"
        Me.btnAdminRegister.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1420, 855)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(141, 46)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.lblPass2False)
        Me.GroupBox2.Controls.Add(Me.lblPass1False)
        Me.GroupBox2.Controls.Add(Me.lblUsernameFalse)
        Me.GroupBox2.Controls.Add(Me.picVisible2)
        Me.GroupBox2.Controls.Add(Me.picVisible)
        Me.GroupBox2.Controls.Add(Me.txtPassword2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtPassword1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtUsername)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 121)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(904, 725)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Create new account :"
        '
        'lblPass2False
        '
        Me.lblPass2False.ForeColor = System.Drawing.Color.Red
        Me.lblPass2False.Location = New System.Drawing.Point(669, 238)
        Me.lblPass2False.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPass2False.Name = "lblPass2False"
        Me.lblPass2False.Size = New System.Drawing.Size(207, 26)
        Me.lblPass2False.TabIndex = 57
        '
        'lblPass1False
        '
        Me.lblPass1False.ForeColor = System.Drawing.Color.Red
        Me.lblPass1False.Location = New System.Drawing.Point(669, 166)
        Me.lblPass1False.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPass1False.Name = "lblPass1False"
        Me.lblPass1False.Size = New System.Drawing.Size(168, 71)
        Me.lblPass1False.TabIndex = 56
        '
        'lblUsernameFalse
        '
        Me.lblUsernameFalse.AutoSize = True
        Me.lblUsernameFalse.ForeColor = System.Drawing.Color.Red
        Me.lblUsernameFalse.Location = New System.Drawing.Point(663, 100)
        Me.lblUsernameFalse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsernameFalse.Name = "lblUsernameFalse"
        Me.lblUsernameFalse.Size = New System.Drawing.Size(0, 25)
        Me.lblUsernameFalse.TabIndex = 40
        '
        'picVisible2
        '
        Me.picVisible2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picVisible2.Image = Global.BookPOS.My.Resources.Resources.invisible
        Me.picVisible2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picVisible2.Location = New System.Drawing.Point(621, 233)
        Me.picVisible2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picVisible2.Name = "picVisible2"
        Me.picVisible2.Size = New System.Drawing.Size(45, 31)
        Me.picVisible2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVisible2.TabIndex = 55
        Me.picVisible2.TabStop = False
        '
        'picVisible
        '
        Me.picVisible.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picVisible.Image = Global.BookPOS.My.Resources.Resources.invisible
        Me.picVisible.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picVisible.Location = New System.Drawing.Point(621, 164)
        Me.picVisible.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picVisible.Name = "picVisible"
        Me.picVisible.Size = New System.Drawing.Size(45, 31)
        Me.picVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVisible.TabIndex = 54
        Me.picVisible.TabStop = False
        '
        'txtPassword2
        '
        Me.txtPassword2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword2.Location = New System.Drawing.Point(336, 226)
        Me.txtPassword2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword2.MaxLength = 30
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.Size = New System.Drawing.Size(267, 34)
        Me.txtPassword2.TabIndex = 3
        Me.txtPassword2.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 233)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(222, 29)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Confirm Password :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPassword1
        '
        Me.txtPassword1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword1.Location = New System.Drawing.Point(336, 156)
        Me.txtPassword1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword1.MaxLength = 30
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.Size = New System.Drawing.Size(267, 34)
        Me.txtPassword1.TabIndex = 2
        Me.txtPassword1.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 165)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(132, 29)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Password :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(336, 94)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsername.MaxLength = 30
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(267, 34)
        Me.txtUsername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(136, 29)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Username :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpDetail
        '
        Me.grpDetail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpDetail.Controls.Add(Me.lblAddressFalse)
        Me.grpDetail.Controls.Add(Me.txtAddress)
        Me.grpDetail.Controls.Add(Me.Label15)
        Me.grpDetail.Controls.Add(Me.txt4number)
        Me.grpDetail.Controls.Add(Me.txt2number)
        Me.grpDetail.Controls.Add(Me.txtPhone2nd)
        Me.grpDetail.Controls.Add(Me.Label9)
        Me.grpDetail.Controls.Add(Me.txtPhone1st)
        Me.grpDetail.Controls.Add(Me.lblBirthFalse)
        Me.grpDetail.Controls.Add(Me.Label14)
        Me.grpDetail.Controls.Add(Me.Label11)
        Me.grpDetail.Controls.Add(Me.txtYMD)
        Me.grpDetail.Controls.Add(Me.timeBirthdate)
        Me.grpDetail.Controls.Add(Me.Label12)
        Me.grpDetail.Controls.Add(Me.Label13)
        Me.grpDetail.Controls.Add(Me.lblPositionFalse)
        Me.grpDetail.Controls.Add(Me.lblNameFalse)
        Me.grpDetail.Controls.Add(Me.lblNRICFalse)
        Me.grpDetail.Controls.Add(Me.lblEmailFalse)
        Me.grpDetail.Controls.Add(Me.lblContactFalse)
        Me.grpDetail.Controls.Add(Me.cboPosition)
        Me.grpDetail.Controls.Add(Me.Label10)
        Me.grpDetail.Controls.Add(Me.Label7)
        Me.grpDetail.Controls.Add(Me.txtName)
        Me.grpDetail.Controls.Add(Me.Label6)
        Me.grpDetail.Controls.Add(Me.Label5)
        Me.grpDetail.Controls.Add(Me.txtEmail)
        Me.grpDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDetail.Location = New System.Drawing.Point(928, 121)
        Me.grpDetail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpDetail.Name = "grpDetail"
        Me.grpDetail.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpDetail.Size = New System.Drawing.Size(883, 725)
        Me.grpDetail.TabIndex = 38
        Me.grpDetail.TabStop = False
        Me.grpDetail.Text = "Staff Details :"
        '
        'lblAddressFalse
        '
        Me.lblAddressFalse.ForeColor = System.Drawing.Color.Red
        Me.lblAddressFalse.Location = New System.Drawing.Point(616, 487)
        Me.lblAddressFalse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddressFalse.Name = "lblAddressFalse"
        Me.lblAddressFalse.Size = New System.Drawing.Size(207, 26)
        Me.lblAddressFalse.TabIndex = 76
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(321, 481)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(268, 150)
        Me.txtAddress.TabIndex = 75
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(61, 484)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(114, 29)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "Address :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt4number
        '
        Me.txt4number.Enabled = False
        Me.txt4number.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4number.Location = New System.Drawing.Point(533, 271)
        Me.txt4number.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt4number.MaxLength = 4
        Me.txt4number.Name = "txt4number"
        Me.txt4number.Size = New System.Drawing.Size(60, 34)
        Me.txt4number.TabIndex = 7
        '
        'txt2number
        '
        Me.txt2number.Enabled = False
        Me.txt2number.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2number.Location = New System.Drawing.Point(465, 271)
        Me.txt2number.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt2number.MaxLength = 2
        Me.txt2number.Name = "txt2number"
        Me.txt2number.Size = New System.Drawing.Size(37, 34)
        Me.txt2number.TabIndex = 6
        '
        'txtPhone2nd
        '
        Me.txtPhone2nd.Enabled = False
        Me.txtPhone2nd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone2nd.Location = New System.Drawing.Point(428, 410)
        Me.txtPhone2nd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPhone2nd.Name = "txtPhone2nd"
        Me.txtPhone2nd.Size = New System.Drawing.Size(161, 34)
        Me.txtPhone2nd.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(401, 410)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 37)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "-"
        '
        'txtPhone1st
        '
        Me.txtPhone1st.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone1st.Location = New System.Drawing.Point(323, 411)
        Me.txtPhone1st.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPhone1st.MaxLength = 3
        Me.txtPhone1st.Name = "txtPhone1st"
        Me.txtPhone1st.Size = New System.Drawing.Size(71, 34)
        Me.txtPhone1st.TabIndex = 9
        '
        'lblBirthFalse
        '
        Me.lblBirthFalse.ForeColor = System.Drawing.Color.Red
        Me.lblBirthFalse.Location = New System.Drawing.Point(616, 199)
        Me.lblBirthFalse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBirthFalse.Name = "lblBirthFalse"
        Me.lblBirthFalse.Size = New System.Drawing.Size(207, 26)
        Me.lblBirthFalse.TabIndex = 71
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(505, 271)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 37)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "-"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(443, 270)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 37)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "-   "
        '
        'txtYMD
        '
        Me.txtYMD.Enabled = False
        Me.txtYMD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYMD.Location = New System.Drawing.Point(323, 270)
        Me.txtYMD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtYMD.Name = "txtYMD"
        Me.txtYMD.Size = New System.Drawing.Size(116, 34)
        Me.txtYMD.TabIndex = 66
        '
        'timeBirthdate
        '
        Me.timeBirthdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.timeBirthdate.Location = New System.Drawing.Point(321, 202)
        Me.timeBirthdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.timeBirthdate.Name = "timeBirthdate"
        Me.timeBirthdate.Size = New System.Drawing.Size(268, 34)
        Me.timeBirthdate.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(61, 204)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(163, 37)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Birth Date:"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(61, 272)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 37)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "NRIC:"
        '
        'lblPositionFalse
        '
        Me.lblPositionFalse.ForeColor = System.Drawing.Color.Red
        Me.lblPositionFalse.Location = New System.Drawing.Point(616, 71)
        Me.lblPositionFalse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPositionFalse.Name = "lblPositionFalse"
        Me.lblPositionFalse.Size = New System.Drawing.Size(207, 26)
        Me.lblPositionFalse.TabIndex = 62
        '
        'lblNameFalse
        '
        Me.lblNameFalse.ForeColor = System.Drawing.Color.Red
        Me.lblNameFalse.Location = New System.Drawing.Point(616, 145)
        Me.lblNameFalse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNameFalse.Name = "lblNameFalse"
        Me.lblNameFalse.Size = New System.Drawing.Size(207, 26)
        Me.lblNameFalse.TabIndex = 61
        '
        'lblNRICFalse
        '
        Me.lblNRICFalse.ForeColor = System.Drawing.Color.Red
        Me.lblNRICFalse.Location = New System.Drawing.Point(616, 273)
        Me.lblNRICFalse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNRICFalse.Name = "lblNRICFalse"
        Me.lblNRICFalse.Size = New System.Drawing.Size(207, 26)
        Me.lblNRICFalse.TabIndex = 60
        '
        'lblEmailFalse
        '
        Me.lblEmailFalse.ForeColor = System.Drawing.Color.Red
        Me.lblEmailFalse.Location = New System.Drawing.Point(616, 346)
        Me.lblEmailFalse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmailFalse.Name = "lblEmailFalse"
        Me.lblEmailFalse.Size = New System.Drawing.Size(207, 26)
        Me.lblEmailFalse.TabIndex = 59
        '
        'lblContactFalse
        '
        Me.lblContactFalse.ForeColor = System.Drawing.Color.Red
        Me.lblContactFalse.Location = New System.Drawing.Point(616, 411)
        Me.lblContactFalse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContactFalse.Name = "lblContactFalse"
        Me.lblContactFalse.Size = New System.Drawing.Size(207, 26)
        Me.lblContactFalse.TabIndex = 58
        '
        'cboPosition
        '
        Me.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Items.AddRange(New Object() {"Admin", "Cashier"})
        Me.cboPosition.Location = New System.Drawing.Point(323, 71)
        Me.cboPosition.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(267, 33)
        Me.cboPosition.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(61, 71)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(112, 29)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Position :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(61, 140)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(90, 29)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Name :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(323, 135)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(267, 34)
        Me.txtName.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(61, 421)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(199, 29)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Contact Number :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 353)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(86, 29)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Email :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(323, 342)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(267, 34)
        Me.txtEmail.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(803, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 31)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Staff Registration"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgv.Location = New System.Drawing.Point(669, 15)
        Me.dgv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(89, 59)
        Me.dgv.TabIndex = 58
        Me.dgv.Visible = False
        '
        'btnStaffRegister
        '
        Me.btnStaffRegister.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStaffRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffRegister.Location = New System.Drawing.Point(1589, 855)
        Me.btnStaffRegister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnStaffRegister.Name = "btnStaffRegister"
        Me.btnStaffRegister.Size = New System.Drawing.Size(141, 46)
        Me.btnStaffRegister.TabIndex = 59
        Me.btnStaffRegister.Text = "Register"
        Me.btnStaffRegister.UseVisualStyleBackColor = True
        Me.btnStaffRegister.Visible = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.btnBack.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBack.Location = New System.Drawing.Point(15, 2)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(157, 53)
        Me.btnBack.TabIndex = 60
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        Me.btnBack.Visible = False
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1827, 922)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnStaffRegister)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btnAdminRegister)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpDetail)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStaffRegister"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picVisible2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVisible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDetail.ResumeLayout(False)
        Me.grpDetail.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdminRegister As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpDetail As GroupBox
    Friend WithEvents cboPosition As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents picVisible2 As PictureBox
    Friend WithEvents picVisible As PictureBox
    Friend WithEvents lblPass2False As Label
    Friend WithEvents lblPass1False As Label
    Friend WithEvents lblUsernameFalse As Label
    Friend WithEvents lblPositionFalse As Label
    Friend WithEvents lblNameFalse As Label
    Friend WithEvents lblNRICFalse As Label
    Friend WithEvents lblEmailFalse As Label
    Friend WithEvents lblContactFalse As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtYMD As TextBox
    Friend WithEvents timeBirthdate As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblBirthFalse As Label
    Friend WithEvents txtPhone1st As TextBox
    Friend WithEvents txtPhone2nd As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt4number As TextBox
    Friend WithEvents txt2number As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lblAddressFalse As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btnStaffRegister As Button
    Friend WithEvents btnBack As Button
End Class
