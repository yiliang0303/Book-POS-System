<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYearlySales
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgv = New System.Windows.Forms.DataGridView()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.AxisX.LabelStyle.Enabled = False
        ChartArea1.AxisX.MajorGrid.LineWidth = 0
        ChartArea1.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea1.AxisX.MinorGrid.LineWidth = 0
        ChartArea1.AxisX.Title = "Month"
        ChartArea1.AxisY.Title = "Sales (RM)"
        ChartArea1.InnerPlotPosition.Auto = False
        ChartArea1.InnerPlotPosition.Height = 86.63421!
        ChartArea1.InnerPlotPosition.Width = 79.03114!
        ChartArea1.InnerPlotPosition.X = 20.96886!
        ChartArea1.InnerPlotPosition.Y = 2.23404!
        ChartArea1.IsSameFontSizeForAllAxes = True
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.BorderWidth = 10
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.CustomProperties = "PixelPointWidth=50, MinPixelPointWidth=50, PointWidth=1, MaxPixelPointWidth=100"
        Series1.Legend = "Legend1"
        Series1.MarkerSize = 10
        Series1.Name = "Series1"
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(800, 450)
        Me.Chart1.SuppressExceptions = True
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "Yearly Sales Report in 2019"
        Me.Chart1.Titles.Add(Title1)
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(652, 107)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(148, 99)
        Me.dgv.TabIndex = 1
        Me.dgv.Visible = False
        '
        'frmYearlySales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.dgv)
        Me.Name = "frmYearlySales"
        Me.Text = "frmYearlySales"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents dgv As DataGridView
End Class
