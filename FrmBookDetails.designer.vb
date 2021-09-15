<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBookDetails
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.picEdit = New System.Windows.Forms.PictureBox()
        Me.lblEdit = New System.Windows.Forms.Label()
        Me.PanelEdit = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PanelBookSelf = New System.Windows.Forms.Panel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.lblBookshelf = New System.Windows.Forms.Label()
        Me.PanelReset = New System.Windows.Forms.Panel()
        Me.picReset = New System.Windows.Forms.PictureBox()
        Me.lblResetPass = New System.Windows.Forms.Label()
        Me.PanelMyself = New System.Windows.Forms.Panel()
        Me.cboSearchType = New System.Windows.Forms.ComboBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.PanelColumn = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.flpBook = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.picEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBookSelf.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelReset.SuspendLayout()
        CType(Me.picReset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMyself.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelColumn.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.flpBook.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel7, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelBookSelf, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelReset, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelMyself, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 94, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.394366!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.71831!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(323, 799)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(317, 53)
        Me.Panel3.TabIndex = 62
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.BookPOS.My.Resources.Resources.homepage
        Me.PictureBox2.Location = New System.Drawing.Point(42, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 54
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(99, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 36)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Home Page"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.AutoSize = True
        Me.Panel7.Controls.Add(Me.picEdit)
        Me.Panel7.Controls.Add(Me.lblEdit)
        Me.Panel7.Controls.Add(Me.PanelEdit)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 61)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(317, 153)
        Me.Panel7.TabIndex = 2
        '
        'picEdit
        '
        Me.picEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picEdit.Image = Global.BookPOS.My.Resources.Resources.editProfile2
        Me.picEdit.Location = New System.Drawing.Point(37, 49)
        Me.picEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picEdit.Name = "picEdit"
        Me.picEdit.Size = New System.Drawing.Size(56, 47)
        Me.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEdit.TabIndex = 50
        Me.picEdit.TabStop = False
        Me.picEdit.Visible = False
        '
        'lblEdit
        '
        Me.lblEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEdit.AutoSize = True
        Me.lblEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit.ForeColor = System.Drawing.Color.Black
        Me.lblEdit.Location = New System.Drawing.Point(88, 63)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(160, 36)
        Me.lblEdit.TabIndex = 51
        Me.lblEdit.Text = "Edit Profile"
        Me.lblEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEdit.Visible = False
        '
        'PanelEdit
        '
        Me.PanelEdit.BackColor = System.Drawing.Color.Transparent
        Me.PanelEdit.Location = New System.Drawing.Point(0, 1)
        Me.PanelEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelEdit.Name = "PanelEdit"
        Me.PanelEdit.Size = New System.Drawing.Size(315, 145)
        Me.PanelEdit.TabIndex = 52
        Me.PanelEdit.Visible = False
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(3, 653)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(317, 141)
        Me.Panel6.TabIndex = 4
        '
        'PanelBookSelf
        '
        Me.PanelBookSelf.Controls.Add(Me.PictureBox8)
        Me.PanelBookSelf.Controls.Add(Me.lblBookshelf)
        Me.PanelBookSelf.Enabled = False
        Me.PanelBookSelf.Location = New System.Drawing.Point(3, 363)
        Me.PanelBookSelf.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelBookSelf.Name = "PanelBookSelf"
        Me.PanelBookSelf.Size = New System.Drawing.Size(314, 141)
        Me.PanelBookSelf.TabIndex = 2
        '
        'PictureBox8
        '
        Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox8.Image = Global.BookPOS.My.Resources.Resources.bookself
        Me.PictureBox8.Location = New System.Drawing.Point(35, 53)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(56, 37)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 52
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Visible = False
        '
        'lblBookshelf
        '
        Me.lblBookshelf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBookshelf.BackColor = System.Drawing.Color.Transparent
        Me.lblBookshelf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBookshelf.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookshelf.ForeColor = System.Drawing.Color.Black
        Me.lblBookshelf.Location = New System.Drawing.Point(3, 0)
        Me.lblBookshelf.Name = "lblBookshelf"
        Me.lblBookshelf.Size = New System.Drawing.Size(311, 141)
        Me.lblBookshelf.TabIndex = 4
        Me.lblBookshelf.Text = "Bookshelf"
        Me.lblBookshelf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBookshelf.Visible = False
        '
        'PanelReset
        '
        Me.PanelReset.BackColor = System.Drawing.Color.Transparent
        Me.PanelReset.Controls.Add(Me.picReset)
        Me.PanelReset.Controls.Add(Me.lblResetPass)
        Me.PanelReset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelReset.Enabled = False
        Me.PanelReset.Location = New System.Drawing.Point(3, 218)
        Me.PanelReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelReset.Name = "PanelReset"
        Me.PanelReset.Size = New System.Drawing.Size(317, 141)
        Me.PanelReset.TabIndex = 1
        Me.PanelReset.Visible = False
        '
        'picReset
        '
        Me.picReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picReset.Image = Global.BookPOS.My.Resources.Resources.resetPass
        Me.picReset.Location = New System.Drawing.Point(32, 43)
        Me.picReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picReset.Name = "picReset"
        Me.picReset.Size = New System.Drawing.Size(59, 46)
        Me.picReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picReset.TabIndex = 51
        Me.picReset.TabStop = False
        Me.picReset.Visible = False
        '
        'lblResetPass
        '
        Me.lblResetPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblResetPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResetPass.ForeColor = System.Drawing.Color.Black
        Me.lblResetPass.Location = New System.Drawing.Point(77, 15)
        Me.lblResetPass.Name = "lblResetPass"
        Me.lblResetPass.Size = New System.Drawing.Size(244, 113)
        Me.lblResetPass.TabIndex = 1
        Me.lblResetPass.Text = "Reset  Password"
        Me.lblResetPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblResetPass.Visible = False
        '
        'PanelMyself
        '
        Me.PanelMyself.BackColor = System.Drawing.Color.Transparent
        Me.PanelMyself.Controls.Add(Me.cboSearchType)
        Me.PanelMyself.Controls.Add(Me.dgv)
        Me.PanelMyself.Location = New System.Drawing.Point(3, 508)
        Me.PanelMyself.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelMyself.Name = "PanelMyself"
        Me.PanelMyself.Size = New System.Drawing.Size(316, 140)
        Me.PanelMyself.TabIndex = 3
        '
        'cboSearchType
        '
        Me.cboSearchType.FormattingEnabled = True
        Me.cboSearchType.Items.AddRange(New Object() {"name"})
        Me.cboSearchType.Location = New System.Drawing.Point(9, 114)
        Me.cboSearchType.Name = "cboSearchType"
        Me.cboSearchType.Size = New System.Drawing.Size(121, 23)
        Me.cboSearchType.TabIndex = 62
        Me.cboSearchType.Visible = False
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(9, 54)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(66, 54)
        Me.dgv.TabIndex = 58
        Me.dgv.Visible = False
        '
        'PanelColumn
        '
        Me.PanelColumn.BackColor = System.Drawing.Color.Transparent
        Me.PanelColumn.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelColumn.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelColumn.Location = New System.Drawing.Point(0, 0)
        Me.PanelColumn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelColumn.Name = "PanelColumn"
        Me.PanelColumn.Size = New System.Drawing.Size(323, 989)
        Me.PanelColumn.TabIndex = 25
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(564, 24)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(683, 25)
        Me.txtSearch.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(421, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Search Bar:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.flpBook)
        Me.Panel1.Location = New System.Drawing.Point(339, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1555, 796)
        Me.Panel1.TabIndex = 62
        '
        'flpBook
        '
        Me.flpBook.AutoScroll = True
        Me.flpBook.BackColor = System.Drawing.Color.LemonChiffon
        Me.flpBook.BackgroundImage = Global.BookPOS.My.Resources.Resources.MyBookBookStore
        Me.flpBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.flpBook.Controls.Add(Me.PictureBox3)
        Me.flpBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpBook.ForeColor = System.Drawing.Color.Black
        Me.flpBook.Location = New System.Drawing.Point(0, 0)
        Me.flpBook.Name = "flpBook"
        Me.flpBook.Size = New System.Drawing.Size(1555, 796)
        Me.flpBook.TabIndex = 63
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = Global.BookPOS.My.Resources.Resources.MyBookBookStore
        Me.PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(613, 0)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 62
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PictureBox1.Location = New System.Drawing.Point(-324, 148)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 192)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'FrmBookDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1924, 989)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PanelColumn)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "FrmBookDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBookDetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.picEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBookSelf.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelReset.ResumeLayout(False)
        CType(Me.picReset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMyself.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelColumn.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.flpBook.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents picEdit As PictureBox
    Friend WithEvents lblEdit As Label
    Friend WithEvents PanelEdit As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PanelMyself As Panel
    Friend WithEvents PanelBookSelf As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents lblBookshelf As Label
    Friend WithEvents PanelReset As Panel
    Friend WithEvents picReset As PictureBox
    Friend WithEvents lblResetPass As Label
    Friend WithEvents PanelColumn As Panel
    Friend WithEvents dgv As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboSearchType As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents flpBook As FlowLayoutPanel
    Friend WithEvents PictureBox3 As PictureBox
End Class
