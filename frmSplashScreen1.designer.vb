<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashScreen
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
    Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Version = New System.Windows.Forms.Label()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Version
        '
        Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(7, 2)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(241, 20)
        Me.Version.TabIndex = 1
        Me.Version.Text = "Version {0}.{1:00}"
        '
        'Copyright
        '
        Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.Location = New System.Drawing.Point(7, 22)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(150, 24)
        Me.Copyright.TabIndex = 2
        Me.Copyright.Text = "Copyright"
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Font = New System.Drawing.Font("MS Reference Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.Location = New System.Drawing.Point(70, 76)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(389, 131)
        Me.ApplicationTitle.TabIndex = 0
        Me.ApplicationTitle.Text = "Application Title"
        Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(32, 232)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(482, 31)
        Me.ProgressBar1.Step = 5
        Me.ProgressBar1.TabIndex = 3
        Me.ProgressBar1.UseWaitCursor = True
        '
        'Timer1
        '
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(476, 266)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(18, 20)
        Me.lblNumber.TabIndex = 10
        Me.lblNumber.Text = "0"
        '
        'lblLoading
        '
        Me.lblLoading.AutoSize = True
        Me.lblLoading.BackColor = System.Drawing.Color.Transparent
        Me.lblLoading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.Location = New System.Drawing.Point(28, 266)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(78, 20)
        Me.lblLoading.TabIndex = 11
        Me.lblLoading.Text = "Loading..."
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BookPOS.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(552, 309)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.ApplicationTitle)
        Me.Controls.Add(Me.Copyright)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplashScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblLoading As Label
End Class
