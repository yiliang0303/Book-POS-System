<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserProfile
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.grpAcc = New System.Windows.Forms.GroupBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblChangepassword = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.picVisibleOri = New System.Windows.Forms.PictureBox()
        Me.lblOriPassFalse = New System.Windows.Forms.Label()
        Me.txtOriPass = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.picVisible = New System.Windows.Forms.PictureBox()
        Me.lblPass2False = New System.Windows.Forms.Label()
        Me.lblPass1False = New System.Windows.Forms.Label()
        Me.lblUsernameFalse = New System.Windows.Forms.Label()
        Me.picVisible2 = New System.Windows.Forms.PictureBox()
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
        Me.mskID = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picProfilePic = New System.Windows.Forms.PictureBox()
        Me.btnBack2 = New System.Windows.Forms.Button()
        Me.btnBack1 = New System.Windows.Forms.Button()
        Me.grpAcc.SuspendLayout()
        CType(Me.picVisibleOri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVisible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVisible2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDetail.SuspendLayout()
        CType(Me.picProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.Blue
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(1147, 610)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 46)
        Me.btnSave.TabIndex = 41
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(1266, 610)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(92, 43)
        Me.btnDelete.TabIndex = 40
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.Lime
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(1147, 610)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(96, 43)
        Me.btnEdit.TabIndex = 39
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'grpAcc
        '
        Me.grpAcc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpAcc.BackColor = System.Drawing.SystemColors.Control
        Me.grpAcc.Controls.Add(Me.btnCheck)
        Me.grpAcc.Controls.Add(Me.lblChangepassword)
        Me.grpAcc.Controls.Add(Me.btnConfirm)
        Me.grpAcc.Controls.Add(Me.picVisibleOri)
        Me.grpAcc.Controls.Add(Me.lblOriPassFalse)
        Me.grpAcc.Controls.Add(Me.txtOriPass)
        Me.grpAcc.Controls.Add(Me.Label17)
        Me.grpAcc.Controls.Add(Me.picVisible)
        Me.grpAcc.Controls.Add(Me.lblPass2False)
        Me.grpAcc.Controls.Add(Me.lblPass1False)
        Me.grpAcc.Controls.Add(Me.lblUsernameFalse)
        Me.grpAcc.Controls.Add(Me.picVisible2)
        Me.grpAcc.Controls.Add(Me.txtPassword2)
        Me.grpAcc.Controls.Add(Me.Label4)
        Me.grpAcc.Controls.Add(Me.txtPassword1)
        Me.grpAcc.Controls.Add(Me.Label3)
        Me.grpAcc.Controls.Add(Me.txtUsername)
        Me.grpAcc.Controls.Add(Me.Label1)
        Me.grpAcc.Cursor = System.Windows.Forms.Cursors.Default
        Me.grpAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAcc.Location = New System.Drawing.Point(12, 280)
        Me.grpAcc.Name = "grpAcc"
        Me.grpAcc.Size = New System.Drawing.Size(678, 331)
        Me.grpAcc.TabIndex = 44
        Me.grpAcc.TabStop = False
        Me.grpAcc.Text = "Account details :"
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(578, 151)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(94, 38)
        Me.btnCheck.TabIndex = 64
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        Me.btnCheck.Visible = False
        '
        'lblChangepassword
        '
        Me.lblChangepassword.AutoSize = True
        Me.lblChangepassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblChangepassword.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangepassword.ForeColor = System.Drawing.Color.Blue
        Me.lblChangepassword.Location = New System.Drawing.Point(41, 84)
        Me.lblChangepassword.Name = "lblChangepassword"
        Me.lblChangepassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChangepassword.Size = New System.Drawing.Size(179, 22)
        Me.lblChangepassword.TabIndex = 48
        Me.lblChangepassword.Text = "Change password ?"
        Me.lblChangepassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblChangepassword.Visible = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(578, 287)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(94, 38)
        Me.btnConfirm.TabIndex = 63
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        Me.btnConfirm.Visible = False
        '
        'picVisibleOri
        '
        Me.picVisibleOri.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picVisibleOri.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picVisibleOri.Image = Global.BookPOS.My.Resources.Resources.invisible
        Me.picVisibleOri.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picVisibleOri.Location = New System.Drawing.Point(467, 122)
        Me.picVisibleOri.Name = "picVisibleOri"
        Me.picVisibleOri.Size = New System.Drawing.Size(38, 26)
        Me.picVisibleOri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVisibleOri.TabIndex = 62
        Me.picVisibleOri.TabStop = False
        Me.picVisibleOri.Visible = False
        '
        'lblOriPassFalse
        '
        Me.lblOriPassFalse.ForeColor = System.Drawing.Color.Red
        Me.lblOriPassFalse.Location = New System.Drawing.Point(511, 128)
        Me.lblOriPassFalse.Name = "lblOriPassFalse"
        Me.lblOriPassFalse.Size = New System.Drawing.Size(130, 20)
        Me.lblOriPassFalse.TabIndex = 61
        '
        'txtOriPass
        '
        Me.txtOriPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOriPass.Location = New System.Drawing.Point(260, 119)
        Me.txtOriPass.MaxLength = 30
        Me.txtOriPass.Name = "txtOriPass"
        Me.txtOriPass.Size = New System.Drawing.Size(201, 29)
        Me.txtOriPass.TabIndex = 59
        Me.txtOriPass.UseSystemPasswordChar = True
        Me.txtOriPass.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(42, 119)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(171, 24)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Original password :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label17.Visible = False
        '
        'picVisible
        '
        Me.picVisible.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picVisible.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picVisible.Image = Global.BookPOS.My.Resources.Resources.invisible
        Me.picVisible.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picVisible.Location = New System.Drawing.Point(466, 206)
        Me.picVisible.Name = "picVisible"
        Me.picVisible.Size = New System.Drawing.Size(39, 26)
        Me.picVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVisible.TabIndex = 58
        Me.picVisible.TabStop = False
        Me.picVisible.Visible = False
        '
        'lblPass2False
        '
        Me.lblPass2False.ForeColor = System.Drawing.Color.Red
        Me.lblPass2False.Location = New System.Drawing.Point(509, 259)
        Me.lblPass2False.Name = "lblPass2False"
        Me.lblPass2False.Size = New System.Drawing.Size(156, 21)
        Me.lblPass2False.TabIndex = 57
        Me.lblPass2False.Visible = False
        '
        'lblPass1False
        '
        Me.lblPass1False.ForeColor = System.Drawing.Color.Red
        Me.lblPass1False.Location = New System.Drawing.Point(507, 200)
        Me.lblPass1False.Name = "lblPass1False"
        Me.lblPass1False.Size = New System.Drawing.Size(158, 59)
        Me.lblPass1False.TabIndex = 56
        Me.lblPass1False.Visible = False
        '
        'lblUsernameFalse
        '
        Me.lblUsernameFalse.ForeColor = System.Drawing.Color.Red
        Me.lblUsernameFalse.Location = New System.Drawing.Point(509, 49)
        Me.lblUsernameFalse.Name = "lblUsernameFalse"
        Me.lblUsernameFalse.Size = New System.Drawing.Size(130, 20)
        Me.lblUsernameFalse.TabIndex = 40
        '
        'picVisible2
        '
        Me.picVisible2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picVisible2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picVisible2.Image = Global.BookPOS.My.Resources.Resources.invisible
        Me.picVisible2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picVisible2.Location = New System.Drawing.Point(466, 264)
        Me.picVisible2.Name = "picVisible2"
        Me.picVisible2.Size = New System.Drawing.Size(35, 25)
        Me.picVisible2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVisible2.TabIndex = 55
        Me.picVisible2.TabStop = False
        Me.picVisible2.Visible = False
        '
        'txtPassword2
        '
        Me.txtPassword2.Enabled = False
        Me.txtPassword2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword2.Location = New System.Drawing.Point(259, 259)
        Me.txtPassword2.MaxLength = 30
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.Size = New System.Drawing.Size(202, 29)
        Me.txtPassword2.TabIndex = 3
        Me.txtPassword2.UseSystemPasswordChar = True
        Me.txtPassword2.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(172, 24)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Confirm Password :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.Visible = False
        '
        'txtPassword1
        '
        Me.txtPassword1.Enabled = False
        Me.txtPassword1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword1.Location = New System.Drawing.Point(259, 202)
        Me.txtPassword1.MaxLength = 30
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.Size = New System.Drawing.Size(202, 29)
        Me.txtPassword1.TabIndex = 2
        Me.txtPassword1.UseSystemPasswordChar = True
        Me.txtPassword1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(146, 24)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "New Password :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'txtUsername
        '
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.No
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(259, 40)
        Me.txtUsername.MaxLength = 30
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(201, 29)
        Me.txtUsername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(107, 24)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Username :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpDetail
        '
        Me.grpDetail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpDetail.BackColor = System.Drawing.SystemColors.Control
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
        Me.grpDetail.Controls.Add(Me.mskID)
        Me.grpDetail.Controls.Add(Me.Label8)
        Me.grpDetail.Controls.Add(Me.Label7)
        Me.grpDetail.Controls.Add(Me.txtName)
        Me.grpDetail.Controls.Add(Me.Label6)
        Me.grpDetail.Controls.Add(Me.Label5)
        Me.grpDetail.Controls.Add(Me.txtEmail)
        Me.grpDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDetail.Location = New System.Drawing.Point(711, 61)
        Me.grpDetail.Name = "grpDetail"
        Me.grpDetail.Size = New System.Drawing.Size(647, 552)
        Me.grpDetail.TabIndex = 45
        Me.grpDetail.TabStop = False
        Me.grpDetail.Text = "Staff Details :"
        '
        'lblAddressFalse
        '
        Me.lblAddressFalse.ForeColor = System.Drawing.Color.Red
        Me.lblAddressFalse.Location = New System.Drawing.Point(462, 437)
        Me.lblAddressFalse.Name = "lblAddressFalse"
        Me.lblAddressFalse.Size = New System.Drawing.Size(155, 21)
        Me.lblAddressFalse.TabIndex = 79
        '
        'txtAddress
        '
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.No
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(241, 437)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(202, 94)
        Me.txtAddress.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(46, 439)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(90, 24)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "Address :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt4number
        '
        Me.txt4number.Cursor = System.Windows.Forms.Cursors.No
        Me.txt4number.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4number.Location = New System.Drawing.Point(400, 269)
        Me.txt4number.Margin = New System.Windows.Forms.Padding(2)
        Me.txt4number.MaxLength = 4
        Me.txt4number.Name = "txt4number"
        Me.txt4number.ReadOnly = True
        Me.txt4number.Size = New System.Drawing.Size(46, 29)
        Me.txt4number.TabIndex = 10
        '
        'txt2number
        '
        Me.txt2number.Cursor = System.Windows.Forms.Cursors.No
        Me.txt2number.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2number.Location = New System.Drawing.Point(349, 269)
        Me.txt2number.Margin = New System.Windows.Forms.Padding(2)
        Me.txt2number.MaxLength = 2
        Me.txt2number.Name = "txt2number"
        Me.txt2number.ReadOnly = True
        Me.txt2number.Size = New System.Drawing.Size(29, 29)
        Me.txt2number.TabIndex = 9
        '
        'txtPhone2nd
        '
        Me.txtPhone2nd.Cursor = System.Windows.Forms.Cursors.No
        Me.txtPhone2nd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone2nd.Location = New System.Drawing.Point(321, 382)
        Me.txtPhone2nd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhone2nd.Name = "txtPhone2nd"
        Me.txtPhone2nd.ReadOnly = True
        Me.txtPhone2nd.Size = New System.Drawing.Size(122, 29)
        Me.txtPhone2nd.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(301, 382)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 30)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "-"
        '
        'txtPhone1st
        '
        Me.txtPhone1st.Cursor = System.Windows.Forms.Cursors.No
        Me.txtPhone1st.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone1st.Location = New System.Drawing.Point(242, 383)
        Me.txtPhone1st.MaxLength = 3
        Me.txtPhone1st.Name = "txtPhone1st"
        Me.txtPhone1st.ReadOnly = True
        Me.txtPhone1st.Size = New System.Drawing.Size(54, 29)
        Me.txtPhone1st.TabIndex = 12
        '
        'lblBirthFalse
        '
        Me.lblBirthFalse.ForeColor = System.Drawing.Color.Red
        Me.lblBirthFalse.Location = New System.Drawing.Point(462, 219)
        Me.lblBirthFalse.Name = "lblBirthFalse"
        Me.lblBirthFalse.Size = New System.Drawing.Size(155, 21)
        Me.lblBirthFalse.TabIndex = 71
        '
        'Label14
        '
        Me.Label14.Enabled = False
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(379, 269)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 30)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "-"
        '
        'Label11
        '
        Me.Label11.Enabled = False
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(332, 268)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 30)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "-   "
        '
        'txtYMD
        '
        Me.txtYMD.Cursor = System.Windows.Forms.Cursors.No
        Me.txtYMD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYMD.Location = New System.Drawing.Point(242, 268)
        Me.txtYMD.Margin = New System.Windows.Forms.Padding(2)
        Me.txtYMD.Name = "txtYMD"
        Me.txtYMD.ReadOnly = True
        Me.txtYMD.Size = New System.Drawing.Size(88, 29)
        Me.txtYMD.TabIndex = 8
        '
        'timeBirthdate
        '
        Me.timeBirthdate.Cursor = System.Windows.Forms.Cursors.No
        Me.timeBirthdate.CustomFormat = "dd/MM/yyyy"
        Me.timeBirthdate.Enabled = False
        Me.timeBirthdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.timeBirthdate.Location = New System.Drawing.Point(241, 213)
        Me.timeBirthdate.Margin = New System.Windows.Forms.Padding(2)
        Me.timeBirthdate.Name = "timeBirthdate"
        Me.timeBirthdate.Size = New System.Drawing.Size(202, 29)
        Me.timeBirthdate.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(46, 215)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 30)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Birth Date:"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(46, 270)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 30)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "NRIC:"
        '
        'lblPositionFalse
        '
        Me.lblPositionFalse.ForeColor = System.Drawing.Color.Red
        Me.lblPositionFalse.Location = New System.Drawing.Point(462, 58)
        Me.lblPositionFalse.Name = "lblPositionFalse"
        Me.lblPositionFalse.Size = New System.Drawing.Size(155, 21)
        Me.lblPositionFalse.TabIndex = 62
        '
        'lblNameFalse
        '
        Me.lblNameFalse.ForeColor = System.Drawing.Color.Red
        Me.lblNameFalse.Location = New System.Drawing.Point(462, 158)
        Me.lblNameFalse.Name = "lblNameFalse"
        Me.lblNameFalse.Size = New System.Drawing.Size(155, 21)
        Me.lblNameFalse.TabIndex = 61
        '
        'lblNRICFalse
        '
        Me.lblNRICFalse.ForeColor = System.Drawing.Color.Red
        Me.lblNRICFalse.Location = New System.Drawing.Point(462, 279)
        Me.lblNRICFalse.Name = "lblNRICFalse"
        Me.lblNRICFalse.Size = New System.Drawing.Size(155, 21)
        Me.lblNRICFalse.TabIndex = 60
        '
        'lblEmailFalse
        '
        Me.lblEmailFalse.ForeColor = System.Drawing.Color.Red
        Me.lblEmailFalse.Location = New System.Drawing.Point(462, 338)
        Me.lblEmailFalse.Name = "lblEmailFalse"
        Me.lblEmailFalse.Size = New System.Drawing.Size(155, 21)
        Me.lblEmailFalse.TabIndex = 59
        '
        'lblContactFalse
        '
        Me.lblContactFalse.ForeColor = System.Drawing.Color.Red
        Me.lblContactFalse.Location = New System.Drawing.Point(462, 391)
        Me.lblContactFalse.Name = "lblContactFalse"
        Me.lblContactFalse.Size = New System.Drawing.Size(155, 21)
        Me.lblContactFalse.TabIndex = 58
        '
        'cboPosition
        '
        Me.cboPosition.Cursor = System.Windows.Forms.Cursors.No
        Me.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPosition.Enabled = False
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Items.AddRange(New Object() {"Admin", "Cashier"})
        Me.cboPosition.Location = New System.Drawing.Point(242, 58)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(201, 28)
        Me.cboPosition.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(46, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(86, 24)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Position :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mskID
        '
        Me.mskID.Cursor = System.Windows.Forms.Cursors.No
        Me.mskID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskID.Location = New System.Drawing.Point(242, 109)
        Me.mskID.Name = "mskID"
        Me.mskID.ReadOnly = True
        Me.mskID.Size = New System.Drawing.Size(201, 29)
        Me.mskID.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(76, 24)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Staff ID :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(71, 24)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Name :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Cursor = System.Windows.Forms.Cursors.No
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(242, 159)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(201, 29)
        Me.txtName.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 391)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(157, 24)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Contact Number :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(67, 24)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Email :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmail
        '
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.No
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(242, 327)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(201, 29)
        Me.txtEmail.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(604, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 25)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Staff Profile"
        '
        'picProfilePic
        '
        Me.picProfilePic.BackColor = System.Drawing.Color.Transparent
        Me.picProfilePic.Cursor = System.Windows.Forms.Cursors.Default
        Me.picProfilePic.Image = Global.BookPOS.My.Resources.Resources.login
        Me.picProfilePic.Location = New System.Drawing.Point(244, 84)
        Me.picProfilePic.Name = "picProfilePic"
        Me.picProfilePic.Size = New System.Drawing.Size(228, 179)
        Me.picProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProfilePic.TabIndex = 29
        Me.picProfilePic.TabStop = False
        '
        'btnBack2
        '
        Me.btnBack2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.btnBack2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBack2.Location = New System.Drawing.Point(7, 0)
        Me.btnBack2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnBack2.Name = "btnBack2"
        Me.btnBack2.Size = New System.Drawing.Size(118, 43)
        Me.btnBack2.TabIndex = 60
        Me.btnBack2.Text = "&Back"
        Me.btnBack2.UseVisualStyleBackColor = True
        Me.btnBack2.Visible = False
        '
        'btnBack1
        '
        Me.btnBack1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.btnBack1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBack1.Location = New System.Drawing.Point(7, 0)
        Me.btnBack1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnBack1.Name = "btnBack1"
        Me.btnBack1.Size = New System.Drawing.Size(118, 43)
        Me.btnBack1.TabIndex = 61
        Me.btnBack1.Text = "&Back"
        Me.btnBack1.UseVisualStyleBackColor = True
        '
        'frmUserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1370, 655)
        Me.Controls.Add(Me.btnBack1)
        Me.Controls.Add(Me.btnBack2)
        Me.Controls.Add(Me.grpAcc)
        Me.Controls.Add(Me.grpDetail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picProfilePic)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Name = "frmUserProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStaffProfile"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpAcc.ResumeLayout(False)
        Me.grpAcc.PerformLayout()
        CType(Me.picVisibleOri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVisible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVisible2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDetail.ResumeLayout(False)
        Me.grpDetail.PerformLayout()
        CType(Me.picProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents grpAcc As GroupBox
    Friend WithEvents lblPass2False As Label
    Friend WithEvents lblPass1False As Label
    Friend WithEvents lblUsernameFalse As Label
    Friend WithEvents picVisible2 As PictureBox
    Friend WithEvents picProfilePic As PictureBox
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpDetail As GroupBox
    Friend WithEvents txt4number As TextBox
    Friend WithEvents txt2number As TextBox
    Friend WithEvents txtPhone2nd As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPhone1st As TextBox
    Friend WithEvents lblBirthFalse As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtYMD As TextBox
    Friend WithEvents timeBirthdate As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblPositionFalse As Label
    Friend WithEvents lblNameFalse As Label
    Friend WithEvents lblNRICFalse As Label
    Friend WithEvents lblEmailFalse As Label
    Friend WithEvents lblContactFalse As Label
    Friend WithEvents cboPosition As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents mskID As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents picVisible As PictureBox
    Friend WithEvents lblAddressFalse As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lblChangepassword As Label
    Friend WithEvents picVisibleOri As PictureBox
    Friend WithEvents lblOriPassFalse As Label
    Friend WithEvents txtOriPass As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnBack2 As Button
    Friend WithEvents btnBack1 As Button
End Class
