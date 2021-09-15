<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHomepage
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnSetting = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnUserMaintenance = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnStartBusiness = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLogout.Font = New System.Drawing.Font("Bahnschrift Condensed", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Image = Global.BookPOS.My.Resources.Resources.Button_Log_Off_icon
        Me.btnLogout.Location = New System.Drawing.Point(149, 744)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(677, 118)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "       Log Out"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseCompatibleTextRendering = True
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnSetting
        '
        Me.btnSetting.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSetting.Font = New System.Drawing.Font("Bahnschrift Condensed", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetting.Image = Global.BookPOS.My.Resources.Resources.gear
        Me.btnSetting.Location = New System.Drawing.Point(2, 612)
        Me.btnSetting.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(677, 118)
        Me.btnSetting.TabIndex = 4
        Me.btnSetting.Text = "      General Setting"
        Me.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSetting.UseCompatibleTextRendering = True
        Me.btnSetting.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnReport.Font = New System.Drawing.Font("Bahnschrift Condensed", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Image = Global.BookPOS.My.Resources.Resources.report__1_
        Me.btnReport.Location = New System.Drawing.Point(134, 477)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(677, 118)
        Me.btnReport.TabIndex = 3
        Me.btnReport.Text = "        Report Generation"
        Me.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReport.UseCompatibleTextRendering = True
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnUserMaintenance
        '
        Me.btnUserMaintenance.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUserMaintenance.Font = New System.Drawing.Font("Bahnschrift Condensed", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserMaintenance.Image = Global.BookPOS.My.Resources.Resources.cash_register
        Me.btnUserMaintenance.Location = New System.Drawing.Point(134, 201)
        Me.btnUserMaintenance.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnUserMaintenance.Name = "btnUserMaintenance"
        Me.btnUserMaintenance.Size = New System.Drawing.Size(677, 118)
        Me.btnUserMaintenance.TabIndex = 2
        Me.btnUserMaintenance.Text = "         User Maintenance"
        Me.btnUserMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUserMaintenance.UseCompatibleTextRendering = True
        Me.btnUserMaintenance.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnInventory.Font = New System.Drawing.Font("Bahnschrift Condensed", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.Image = Global.BookPOS.My.Resources.Resources.staff__1_
        Me.btnInventory.Location = New System.Drawing.Point(2, 338)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(677, 118)
        Me.btnInventory.TabIndex = 1
        Me.btnInventory.Text = "       Inventory Control"
        Me.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventory.UseCompatibleTextRendering = True
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnStartBusiness
        '
        Me.btnStartBusiness.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnStartBusiness.Font = New System.Drawing.Font("Bahnschrift Condensed", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartBusiness.Image = Global.BookPOS.My.Resources.Resources.cash_register
        Me.btnStartBusiness.Location = New System.Drawing.Point(1, 62)
        Me.btnStartBusiness.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnStartBusiness.Name = "btnStartBusiness"
        Me.btnStartBusiness.Size = New System.Drawing.Size(677, 118)
        Me.btnStartBusiness.TabIndex = 0
        Me.btnStartBusiness.Text = "      Start Business"
        Me.btnStartBusiness.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStartBusiness.UseCompatibleTextRendering = True
        Me.btnStartBusiness.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BookPOS.My.Resources.Resources.mybook
        Me.PictureBox1.Location = New System.Drawing.Point(1178, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(341, 307)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmHomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackgroundImage = Global.BookPOS.My.Resources.Resources.book
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1583, 864)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnSetting)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnUserMaintenance)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.btnStartBusiness)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmHomepage"
        Me.Text = "frmhomepage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStartBusiness As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnUserMaintenance As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnSetting As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
